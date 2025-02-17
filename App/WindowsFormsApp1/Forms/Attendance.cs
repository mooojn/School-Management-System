using Bunifu.UI.WinForms;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1.Forms
{
	public partial class Attendance : Form
	{
		private int selectedClassID; // Store selected class ID
		private string selectedDate;

		public Attendance()
		{
			InitializeComponent();
			SetAttendaceTable();
			LoadClassesBox();
			attendanceTable.CellClick += AttendanceTable_CellClick; // Handle student selection
		}

		private void Attendance_Load(object sender, EventArgs e)
		{
			LoadClasses();
		}

		private void LoadClassesBox()
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
			classBox.DataSource = classTable;
			classBox.DisplayMember = "ClassName";
			classBox.ValueMember = "ClassID";
			classBox.SelectedIndex = 0;

			SetClassIndex();
			LoadStudents(selectedClassID);
			
		}
		private void LoadClasses()
		{
			Database.OpenConnection();
			string query = "SELECT ClassID, ClassName FROM Classes"; // Fetch only relevant columns
			SqlDataAdapter adapter = new SqlDataAdapter(query, Database.connection);
			DataTable dt = new DataTable();

			adapter.Fill(dt);
			Database.CloseConnection();
		}
		private void LoadStudents(int classID)
		{
			Database.OpenConnection();
			string query = @"
				SELECT s.StudentID, s.FullName 
				FROM Students s
				LEFT JOIN Attendance a ON s.StudentID = a.StudentID 
					AND a.ClassID = @ClassID 
					AND CAST(a.Date AS DATE) = CAST(GETDATE() AS DATE)
				WHERE s.ClassID = @ClassID AND a.StudentID IS NULL"; // Fetch only students who haven't been marked today

			SqlCommand cmd = new SqlCommand(query, Database.connection);
			cmd.Parameters.AddWithValue("@ClassID", classID);

			SqlDataAdapter adapter = new SqlDataAdapter(cmd);
			DataTable dt = new DataTable();
			adapter.Fill(dt);

			attendanceTable.DataSource = dt;
			Database.CloseConnection();
		}

		private void AttendanceTable_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0) // Ensure a valid row is clicked
			{
				int studentID = Convert.ToInt32(attendanceTable.Rows[e.RowIndex].Cells["StudentID"].Value);
				string status = PromptForStatus(); // Ask for attendance status

				if (!string.IsNullOrEmpty(status))
				{
					MarkAttendance(studentID, selectedClassID, status);
					LoadStudents(selectedClassID); // Refresh the student list after marking attendance
				}
			}
		}

		private string PromptForStatus()
		{
			DialogResult result = MessageBox.Show("Mark Present?", "Attendance", MessageBoxButtons.YesNoCancel);
			if (result == DialogResult.Yes) return "Present";
			if (result == DialogResult.No) return "Absent";
			return null;
		}

		private void MarkAttendance(int studentID, int classID, string status)
		{
			Database.OpenConnection();
			string query = "INSERT INTO Attendance (StudentID, ClassID, Date, Status) VALUES (@StudentID, @ClassID, @Date, @Status)";
			SqlCommand cmd = new SqlCommand(query, Database.connection);
			cmd.Parameters.AddWithValue("@StudentID", studentID);
			cmd.Parameters.AddWithValue("@ClassID", classID);
			cmd.Parameters.AddWithValue("@Date", DateTime.Now);
			cmd.Parameters.AddWithValue("@Status", status);

			cmd.ExecuteNonQuery();
			Database.CloseConnection();

			ShowMessage("Attendance Marked Successfully");
		}
		private void classBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			SetAttendaceTable();
			SetClassIndex();
			LoadStudents(selectedClassID);
		}
		private void SetAttendaceTable()
		{
			attendanceTable.Visible = true;
			attendanceReportBtn.Visible = true;
			
			goBackBtn.Visible = false;
			attendanceReport.Visible = false;

			dateFilterLabel.Visible = false;
			dateFilterBox.Visible = false;
		}
		private void SetReportTable()
		{
			attendanceReport.Visible = true;
			goBackBtn.Visible = true;
			
			dateFilterBox.Visible = true;
			dateFilterLabel.Visible = true;

			attendanceReportBtn.Visible = false;
			attendanceTable.Visible = false;
		}
		private void SetClassIndex()
		{
			if (classBox.SelectedValue != null && classBox.SelectedValue is int)
			{
				selectedClassID = (int)classBox.SelectedValue;
				
			}
		}
		private void attendanceReport_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void LoadDateFilter()
		{
			Database.OpenConnection();

			string query = "SELECT DISTINCT Date FROM Attendance WHERE classID = @ClassID";
			using (SqlCommand command = new SqlCommand(query, Database.connection))
			{
				command.Parameters.AddWithValue("@ClassID", selectedClassID);

				SqlDataAdapter adapter = new SqlDataAdapter(command);
				DataTable dt = new DataTable();
				adapter.Fill(dt);

				dateFilterBox.DataSource = dt;
				dateFilterBox.DisplayMember = "Date"; // Adjust if column name differs
				dateFilterBox.ValueMember = "Date";   // Can be used if needed
				dateFilterBox.SelectedIndex = 0;
				
				SetDate();
				LoadFilteredAttendance();
			}

			Database.CloseConnection();
		}

		private void attendanceReportBtn_Click_2(object sender, EventArgs e)
		{
			Database.OpenConnection();
			string query = @"
            SELECT S.FullName, A.Date, A.Status 
            FROM Attendance A
            JOIN Students S ON A.StudentID = S.StudentID
            WHERE A.ClassID = @ClassID
            ORDER BY A.Date DESC"; // Sort by latest attendance first

			SqlCommand cmd = new SqlCommand(query, Database.connection);
			cmd.Parameters.AddWithValue("@ClassID", selectedClassID);

			SqlDataAdapter adapter = new SqlDataAdapter(cmd);
			DataTable dt = new DataTable();
			adapter.Fill(dt);

			Database.CloseConnection();

			if (dt.Rows.Count > 0)
			{
				attendanceReport.DataSource = dt; // Show attendance records

				LoadDateFilter();
				SetReportTable();
			}
			else
			{
				ShowMessage("No attendance records found for this class.");
			}
		}
		private void ShowMessage(string msg)
		{
			message.Show(this, $"{msg}", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Information);
		}

		private void goBackBtn_Click(object sender, EventArgs e)
		{
			SetAttendaceTable();
		}

		private void dateFilterBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (dateFilterBox.SelectedValue != null)
			{
				SetDate();
				LoadFilteredAttendance();
			}
		}
		private void SetDate()
		{
			selectedDate = dateFilterBox.SelectedValue.ToString();
		}
		private void LoadFilteredAttendance()
		{
			try
			{
				Database.OpenConnection();

				string query = @"
            SELECT S.FullName, A.Date, A.Status 
            FROM Attendance A
            JOIN Students S ON A.StudentID = S.StudentID
            WHERE A.ClassID = @ClassID AND CAST(A.Date AS DATE) = @SelectedDate
            ORDER BY A.Date DESC";

				using (SqlCommand cmd = new SqlCommand(query, Database.connection))
				{
					cmd.Parameters.AddWithValue("@ClassID", selectedClassID);

					// Convert selectedDate to DateTime
					DateTime dateValue;
					if (DateTime.TryParse(selectedDate, out dateValue))
					{
						cmd.Parameters.AddWithValue("@SelectedDate", dateValue.Date);
					}
					else
					{
						ShowMessage("Invalid date format."); // Handle invalid date
						return;
					}

					SqlDataAdapter adapter = new SqlDataAdapter(cmd);
					DataTable dt = new DataTable();
					adapter.Fill(dt);

					attendanceReport.DataSource = dt; // Update table with filtered data
				}
			}
			finally
			{
				Database.CloseConnection();
			}
		}



	}
}
