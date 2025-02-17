using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1.Forms
{
    public partial class EvaluateStudent : Form
    {
        int studentId;
        int classId=0;
        DateTime newDate;
        SqlConnection con = Database.connection;
        DataTable data = new DataTable();
        public EvaluateStudent()
        {
            InitializeComponent();
            //LoadStudentData();
            LoadClasses();
        }
        private void LoadStudentData(int ClassID)
        {
            data.Clear();
            try
            {
                con.Open();
                SqlCommand load = new SqlCommand("SELECT s.FullName AS StudentName, sub.SubjectName, m.MarksObtained " +
    "FROM Marks m " +
    "JOIN Students s ON m.StudentID = s.StudentID " +
    "JOIN Subjects sub ON m.SubjectID = sub.SubjectID  WHERE s.ClassID = @ClassID", con);
                load.Parameters.AddWithValue("@ClassID", ClassID);
                SqlDataReader reader = load.ExecuteReader();
                data.Load(reader);

                StudentsData.DataSource = data;
                StudentsData.AutoResizeColumns();
                con.Close();
                DataTable subjectsTable = new DataTable();
                Database.OpenConnection();

                        string query1 = "SELECT s.SubjectID, s.SubjectName " +
                "FROM Subjects s " +
                "JOIN Teachers t ON s.SubjectID = t.SubjectID " +
                "JOIN Classes c ON t.TeacherID = c.TeacherID " +
                "WHERE c.ClassID ="+ ClassID;
                        using (SqlCommand command = new SqlCommand(query1, con))
                        {
                            SqlDataAdapter adapter = new SqlDataAdapter(command);
                            adapter.Fill(subjectsTable);
                        }

                Database.CloseConnection();
                // Bind the dropdown to the subjects data
                bunifuDropdown3.DataSource = subjectsTable;
                    bunifuDropdown3.DisplayMember = "SubjectName";
                    bunifuDropdown3.ValueMember = "SubjectID";
                DataTable studentsTable = new DataTable();
                Database.OpenConnection();
                    string query = "SELECT StudentID, FullName FROM Students WHERE ClassID = "+ ClassID;
                using (SqlCommand command = new SqlCommand(query, con))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        adapter.Fill(studentsTable);
                    }

                Database.CloseConnection();

                bunifuDropdown1.DataSource = studentsTable;
                bunifuDropdown1.DisplayMember = "FullName";  
                bunifuDropdown1.ValueMember = "StudentID"; 
            

        
            }
            catch (Exception ex)
            {
                bunifuSnackbar1.Show(this, "Error loading student data: " + ex.Message,
     Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error);
            }
        }
        private void save_Click(object sender, EventArgs e)
        {
            if (AreDropDownsNotNull())
            {
                try
                {
                    int studentId = Convert.ToInt32(bunifuDropdown1.SelectedValue);
                    int subjectId = Convert.ToInt32(bunifuDropdown3.SelectedValue);
                    double obtainedMarks = double.Parse(bunifuTextBox1.Text);

                    bunifuSnackbar1.Show(this, "Obtained Marks: " + obtainedMarks,
  Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Information);

                    Database.OpenConnection();


                    using (SqlCommand checkCommand = new SqlCommand(
                        "SELECT COUNT(*) FROM Marks WHERE StudentID = @StudentId AND SubjectID = @SubjectId", Database.connection))
                    {
                        checkCommand.Parameters.AddWithValue("@StudentId", studentId);
                        checkCommand.Parameters.AddWithValue("@SubjectId", subjectId);

                        int count = (int)checkCommand.ExecuteScalar();

                        if (count > 0) 
                        {
                            using (SqlCommand updateCommand = new SqlCommand(
                                "UPDATE Marks SET MarksObtained = @ObtainedMarks, ExamDate = @ExamDate WHERE StudentID = @StudentId AND SubjectID = @SubjectId",
                                Database.connection))
                            {
                                updateCommand.Parameters.AddWithValue("@StudentId", studentId);
                                updateCommand.Parameters.AddWithValue("@SubjectId", subjectId);
                                updateCommand.Parameters.AddWithValue("@ObtainedMarks", obtainedMarks);
                                updateCommand.Parameters.AddWithValue("@ExamDate", DateTime.Now);

                                updateCommand.ExecuteNonQuery();
                                bunifuSnackbar1.Show(this, "Evaluation Updated! ",
  Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success);
                            }
                        }
                        else 
                        {
                            using (SqlCommand insertCommand = new SqlCommand(
                                "INSERT INTO Marks (StudentID, SubjectID, MarksObtained, ExamDate) VALUES (@StudentId, @SubjectId, @ObtainedMarks, @ExamDate)",
                                Database.connection))
                            {
                                insertCommand.Parameters.AddWithValue("@StudentId", studentId);
                                insertCommand.Parameters.AddWithValue("@SubjectId", subjectId);
                                insertCommand.Parameters.AddWithValue("@ObtainedMarks", obtainedMarks);
                                insertCommand.Parameters.AddWithValue("@ExamDate", DateTime.Now);

                                insertCommand.ExecuteNonQuery();
                                bunifuSnackbar1.Show(this, "Evaluation Added! ",
 Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success);

                            }
                        }
                    }

                    Database.CloseConnection();
                }
                catch (Exception ex)
                {
                    bunifuSnackbar1.Show(this, "Error: " + ex.Message,
Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error);

                }
            }

            LoadStudentData(classId);
        }
        private void LoadClasses()
        {
            DataTable classTable = new DataTable();
            Database.OpenConnection();
            
                string query = "SELECT ClassID, ClassName FROM Classes";
                using (SqlCommand command = new SqlCommand(query, Database.connection))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(classTable);
                }
            Database.CloseConnection();

            // Bind data to dropdown
            bunifuDropdown2.DataSource = classTable;
            bunifuDropdown2.DisplayMember = "ClassName";
            bunifuDropdown2.ValueMember = "ClassID"; 
            bunifuDropdown2.SelectedIndex = -1; 
        }

        private bool AreDropDownsNotNull()
        {
            return bunifuDropdown1.SelectedItem != null &&
                   bunifuDropdown3.SelectedItem != null;

        }

        /// Extras
        private void StudentsData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }



        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void bunifuDropdown3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void bunifuDropdown1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void bunifuDropdown6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void DatePicker_ValueChanged(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuDropdown2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (bunifuDropdown2.SelectedIndex != -1)
            {
                // Correct way to get the ClassID from DataRowView
                int selectedClassId = Convert.ToInt32(((DataRowView)bunifuDropdown2.SelectedItem)["ClassID"]);

                classId = selectedClassId;
                LoadStudentData(classId);

            }
        }

		private void label1_Click(object sender, EventArgs e)
		{

		}
	}
}
