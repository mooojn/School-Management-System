using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    internal class StudentDB
    {
        public static List<string> GetClassNames()
        {
            List<string> classNames = new List<string>();

            try
            {
                Database.OpenConnection();
                string query = "SELECT ClassName FROM Classes"; // Fetch ClassName instead of ClassID

                using (SqlCommand cmd = new SqlCommand(query, Database.connection))
                using (SqlDataReader reader = cmd.ExecuteReader()) // Read multiple rows
                {
                    while (reader.Read())
                    {
                        classNames.Add(reader.GetString(0)); // Get ClassName from the first column
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                Database.CloseConnection();
            }

            return classNames;
        }
        public static bool EnrollStudent(int studentID, int classID)
        {
            try
            {
                Database.OpenConnection();
                
                // Step 1: Update the Students table with the selected ClassID
                string updateQuery = "UPDATE Students SET ClassID = @ClassID WHERE StudentID = @StudentID";

                using (SqlCommand updateCmd = new SqlCommand(updateQuery, Database.connection))
                {
                    updateCmd.Parameters.AddWithValue("@StudentID", studentID);
                    updateCmd.Parameters.AddWithValue("@ClassID", classID);
                    updateCmd.ExecuteNonQuery();
                }

                // Step 2: Insert into Enrollments table
                string insertQuery = "INSERT INTO Enrollments (StudentID, ClassID, EnrollmentDate) VALUES (@StudentID, @ClassID, GETDATE())";

                using (SqlCommand insertCmd = new SqlCommand(insertQuery, Database.connection))
                {
                    insertCmd.Parameters.AddWithValue("@StudentID", studentID);
                    insertCmd.Parameters.AddWithValue("@ClassID", classID);
                    int rowsAffected = insertCmd.ExecuteNonQuery();
                    
                    return rowsAffected > 0; // Returns true if enrollment was successful
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error enrolling student: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                Database.CloseConnection();
            }
        }

        public static bool AddStudent(string fullName, DateTime dob, string gender, string phone)
        {
            

            try
            {
                Database.OpenConnection();
                string query = "INSERT INTO Students (FullName, DOB, Gender,  Phone) VALUES (@FullName, @DOB, @Gender,  @Phone)";

                using (SqlCommand cmd = new SqlCommand(query, Database.connection))
                {
                    cmd.Parameters.AddWithValue("@FullName", fullName);
                    cmd.Parameters.AddWithValue("@DOB", dob.ToString("yyyy-MM-dd")); // Convert DateTime to MSSQL format
                    cmd.Parameters.AddWithValue("@Gender", gender);
                    cmd.Parameters.AddWithValue("@Phone", phone ?? (object)DBNull.Value); // Handle NULL phone

                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0; // Returns true if insertion was successful
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                Database.CloseConnection();
            }
        }

        private static int GetClassID(string className)
        {
            try
            {
                Database.OpenConnection();
                string query = "SELECT ClassID FROM Classes WHERE ClassName = @ClassName";

                using (SqlCommand cmd = new SqlCommand(query, Database.connection))
                {
                    cmd.Parameters.AddWithValue("@ClassName", className);
                    object result = cmd.ExecuteScalar();
                    return result != null ? Convert.ToInt32(result) : -1; // Return ClassID or -1 if not found
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving ClassID: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
            finally
            {
                Database.CloseConnection();
            }
        }

		public static List<(int StudentID, string FullName)> GetStudentsForBox()
		{
			List<(int, string)> students = new List<(int, string)>();

			try
			{
				Database.OpenConnection();
				string query = "SELECT StudentID, FullName FROM Students";

				using (SqlCommand cmd = new SqlCommand(query, Database.connection))
				using (SqlDataReader reader = cmd.ExecuteReader())
				{
					while (reader.Read())
					{
						students.Add((reader.GetInt32(0), reader.GetString(1))); // Add StudentID and FullName
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Database Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				Database.CloseConnection();
			}

			return students;
		}


		public static Dictionary<string, object> GetStudentDetails(int studentID)
        {
            Dictionary<string, object> studentDetails = new Dictionary<string, object>();

            try
            {
                Database.OpenConnection();
                string query = @"SELECT FullName, DOB, Gender, Phone FROM Students WHERE StudentID = @StudentID";

                using (SqlCommand cmd = new SqlCommand(query, Database.connection))
                {
                    cmd.Parameters.AddWithValue("@StudentID", studentID);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            studentDetails["FullName"] = reader["FullName"].ToString();
                            studentDetails["DOB"] = Convert.ToDateTime(reader["DOB"]);
                            studentDetails["Gender"] = reader["Gender"].ToString();
                            studentDetails["Phone"] = reader["Phone"].ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Database.CloseConnection();
            }

            return studentDetails;
        }
        public static List<Dictionary<string, object>> GetAllStudentDetails()
        {
            List<Dictionary<string, object>> studentsList = new List<Dictionary<string, object>>();

            try
            {
                Database.OpenConnection();
                string query = @"SELECT StudentID, FullName, DOB, Gender, Phone, ClassID FROM Students";

                using (SqlCommand cmd = new SqlCommand(query, Database.connection))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Dictionary<string, object> studentDetails = new Dictionary<string, object>
                        {
                            ["StudentID"] = reader["StudentID"],
                            ["FullName"] = reader["FullName"].ToString(),
                            ["DOB"] = Convert.ToDateTime(reader["DOB"]),
                            ["Gender"] = reader["Gender"].ToString(),
                            ["Phone"] = reader["Phone"].ToString(),
                            ["ClassID"] = reader["ClassID"]
                        };

                        studentsList.Add(studentDetails);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Database.CloseConnection();
            }

            return studentsList;
        }

        public static string GetClassName(int classID)
        {
            try
            {
                Database.OpenConnection();
                string query = "SELECT ClassName FROM Classes WHERE ClassID = @ClassID";

                using (SqlCommand cmd = new SqlCommand(query, Database.connection))
                {
                    cmd.Parameters.AddWithValue("@ClassID", classID);
                    object result = cmd.ExecuteScalar();
                    return result != null ? result.ToString() : "Unknown Class";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving Class Name: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "Unknown Class";
            }
            finally
            {
                Database.CloseConnection();
            }
        }
        public static bool UpdateStudent(int studentID, string fullName, DateTime dob, string gender, string phone)
        {
            try
            {
                Database.OpenConnection();
                string query = @"UPDATE Students 
                             SET FullName = @FullName, DOB = @DOB, Gender = @Gender, Phone = @Phone
                             WHERE StudentID = @StudentID";

                using (SqlCommand cmd = new SqlCommand(query, Database.connection))
                {
                    cmd.Parameters.AddWithValue("@StudentID", studentID);
                    cmd.Parameters.AddWithValue("@FullName", fullName);
                    cmd.Parameters.AddWithValue("@DOB", dob.ToString("yyyy-MM-dd")); // Format for MSSQL
                    cmd.Parameters.AddWithValue("@Gender", gender);
                    cmd.Parameters.AddWithValue("@Phone", phone);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0; // Returns true if update was successful
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                Database.CloseConnection();
            }
        }
        public static DataTable GetStudentDataTable(int studentID)
        {
            try
            {
                Database.OpenConnection();
                string query = "SELECT StudentID, FullName, DOB, Gender, ClassID, Phone FROM Students WHERE StudentID = @StudentID";

                using (SqlCommand cmd = new SqlCommand(query, Database.connection))
                {
                    cmd.Parameters.AddWithValue("@StudentID", studentID);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable studentTable = new DataTable();
                    adapter.Fill(studentTable);
                    return studentTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new DataTable();
            }
            finally
            {
                Database.CloseConnection();
            }
        }

        public static bool DeleteStudent(int studentID)
        {
            try
            {
                Database.OpenConnection();
                string query = "DELETE FROM Students WHERE StudentID = @StudentID";

                using (SqlCommand cmd = new SqlCommand(query, Database.connection))
                {
                    cmd.Parameters.AddWithValue("@StudentID", studentID);
                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0; // Returns true if delete was successful
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                Database.CloseConnection();
            }
        }
        public static bool DeleteStudentAttendance(int studentID)
        {
            try
            {
                Database.OpenConnection();
                string query = "DELETE FROM Attendance WHERE StudentID = @StudentID";

                using (SqlCommand cmd = new SqlCommand(query, Database.connection))
                {
                    cmd.Parameters.AddWithValue("@StudentID", studentID);
                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0; // Returns true if attendance records were deleted
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                Database.CloseConnection();
            }
        }







    }
}
