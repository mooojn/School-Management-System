using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1.Forms
{
    public partial class Class : Form
    {
        private bool isClassView = true; // Track the active view (Class or Subject)

        public Class()
        {
            InitializeComponent();
            InitializeUI();
        }

        private void InitializeUI()
        {
            ShowClassView(); // Load and display the initial Class data
        }

        private void LoadClasses()
        {
            dgvClasses.DataSource = GetDataTable("SELECT * FROM Classes");
        }

        private void LoadSubjects()
        {
            dgvSubjects.DataSource = GetDataTable("SELECT * FROM Subjects");
        }

        private DataTable GetDataTable(string query)
        {
            Database.OpenConnection();
            SqlDataAdapter da = new SqlDataAdapter(query, Database.connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Database.CloseConnection();
            return dt;
        }

        private void dgvClasses_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtClassName.Text = dgvClasses.Rows[e.RowIndex].Cells["ClassName"].Value.ToString();
            }
        }

        private void dgvSubjects_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtSubjectName.Text = dgvSubjects.Rows[e.RowIndex].Cells["SubjectName"].Value.ToString();
            }
        }

        private void AddClass_Click(object sender, EventArgs e)
        {
           
        }

        private void EditClass_Click(object sender, EventArgs e)
        {
        }

		private void DeleteClass_Click(object sender, EventArgs e)
		{
			
		}



		private void AddSubject_Click(object sender, EventArgs e)
        {
            
        }

        private void EditSubject_Click(object sender, EventArgs e)
        {
           
        }

		private void DeleteSubject_Click(object sender, EventArgs e)
		{
			
		}



		private void ExecuteQuery(string query, params SqlParameter[] parameters)
        {
            Database.OpenConnection();
            using (SqlCommand cmd = new SqlCommand(query, Database.connection))
            {
                cmd.Parameters.AddRange(parameters);
                cmd.ExecuteNonQuery();
            }
            Database.CloseConnection();
        }

        private void ShowClassView()
        {
            // Show Class DataGridView and CRUD buttons
            dgvClasses.Visible = true;
            AddClass.Visible = true;
            EditClass.Visible = true;
            DeleteClass.Visible = true;
            txtClassName.Visible = true;

            // Hide Subject DataGridView and CRUD buttons
            dgvSubjects.Visible = false;
            AddSubject.Visible = false;
            EditSubject.Visible = false;
            DeleteSubject.Visible = false;
            txtSubjectName.Visible = false;

            // Load Class Data
            LoadClasses();
        }

        private void ShowSubjectView()
        {
            // Show Subject DataGridView and CRUD buttons
            dgvSubjects.Visible = true;
            AddSubject.Visible = true;
            EditSubject.Visible = true;
            DeleteSubject.Visible = true;
            txtSubjectName.Visible = true;

            // Hide Class DataGridView and CRUD buttons
            dgvClasses.Visible = false;
            AddClass.Visible = false;
            EditClass.Visible = false;
            DeleteClass.Visible = false;
            txtClassName.Visible = false;

            // Load Subject Data
            LoadSubjects();
        }

        private void SWITCH_Click(object sender, EventArgs e)
        {
            
        }

		private void save_Click(object sender, EventArgs e)
		{
			// Toggle view between Class and Subject
			isClassView = !isClassView;

			if (isClassView)
				ShowClassView();
			else
				ShowSubjectView();
		}

		private void bunifuButton3_Click(object sender, EventArgs e)
		{
			if (dgvSubjects.SelectedRows.Count == 0) return;

			int subjectID = Convert.ToInt32(dgvSubjects.SelectedRows[0].Cells["SubjectID"].Value);

			Database.OpenConnection();

			string updateTeachersQuery = "UPDATE Teachers SET SubjectID = NULL WHERE SubjectID = @SubjectID";
			SqlCommand updateTeachersCommand = new SqlCommand(updateTeachersQuery, Database.connection);
			updateTeachersCommand.Parameters.AddWithValue("@SubjectID", subjectID);
			updateTeachersCommand.ExecuteNonQuery();

			string deleteMarksQuery = "DELETE FROM Marks WHERE SubjectID = @SubjectID";
			SqlCommand deleteMarksCommand = new SqlCommand(deleteMarksQuery, Database.connection);
			deleteMarksCommand.Parameters.AddWithValue("@SubjectID", subjectID);
			deleteMarksCommand.ExecuteNonQuery();

			string deleteSubjectQuery = "DELETE FROM Subjects WHERE SubjectID = @SubjectID";
			SqlCommand deleteSubjectCommand = new SqlCommand(deleteSubjectQuery, Database.connection);
			deleteSubjectCommand.Parameters.AddWithValue("@SubjectID", subjectID);
			int rowsAffected = deleteSubjectCommand.ExecuteNonQuery();

			// Close database connection
			Database.CloseConnection();

			if (rowsAffected > 0)
			{
				ShowMessage("Subject deleted successfully!");
				LoadSubjects(); // Refresh table
			}
		}

		private void bunifuButton3_Click_1(object sender, EventArgs e)
		{
			if (dgvClasses.SelectedRows.Count == 0) return;

			int classID = Convert.ToInt32(dgvClasses.SelectedRows[0].Cells["ClassID"].Value);

			Database.OpenConnection();

			string updateQuery = "UPDATE Students SET ClassID = NULL WHERE ClassID = @ClassID";
			SqlCommand updateCommand = new SqlCommand(updateQuery, Database.connection);
			updateCommand.Parameters.AddWithValue("@ClassID", classID);
			updateCommand.ExecuteNonQuery();

			string deleteAttendanceQuery = "DELETE FROM Attendance WHERE ClassID = @ClassID";
			SqlCommand deleteAttendanceCommand = new SqlCommand(deleteAttendanceQuery, Database.connection);
			deleteAttendanceCommand.Parameters.AddWithValue("@ClassID", classID);
			deleteAttendanceCommand.ExecuteNonQuery();

			string deleteClassQuery = "DELETE FROM Classes WHERE ClassID = @ClassID";
			SqlCommand deleteClassCommand = new SqlCommand(deleteClassQuery, Database.connection);
			deleteClassCommand.Parameters.AddWithValue("@ClassID", classID);
			int rowsAffected = deleteClassCommand.ExecuteNonQuery();

			Database.CloseConnection();

			if (rowsAffected > 0)
			{
				ShowMessage("Class deleted successfully!");
				LoadClasses(); // Refresh table
			}
		}

		private void bunifuButton2_Click(object sender, EventArgs e)
		{
			if (dgvSubjects.SelectedRows.Count == 0) return;

			int subjectID = Convert.ToInt32(dgvSubjects.SelectedRows[0].Cells["SubjectID"].Value);
			ExecuteQuery("UPDATE Subjects SET SubjectName = @SubjectName WHERE SubjectID = @SubjectID",
				new SqlParameter("@SubjectName", txtSubjectName.Text),
				new SqlParameter("@SubjectID", subjectID));
			ShowMessage("Subject updated successfully!");
			LoadSubjects();
		}

		private void bunifuButton3_Click_2(object sender, EventArgs e)
		{

			if (dgvClasses.SelectedRows.Count == 0) return;

			int classID = Convert.ToInt32(dgvClasses.SelectedRows[0].Cells["ClassID"].Value);
			ExecuteQuery("UPDATE Classes SET ClassName = @ClassName WHERE ClassID = @ClassID",
				new SqlParameter("@ClassName", txtClassName.Text),
				new SqlParameter("@ClassID", classID));
			ShowMessage("Class updated successfully!");
			LoadClasses();
		}

		private void bunifuButton1_Click(object sender, EventArgs e)
		{
			ExecuteQuery("INSERT INTO Classes (ClassName) VALUES (@ClassName)", new SqlParameter("@ClassName", txtClassName.Text));
			ShowMessage("Class added successfully!");
			LoadClasses();
		}

		private void bunifuButton2_Click_1(object sender, EventArgs e)
		{
			ExecuteQuery("INSERT INTO Subjects (SubjectName) VALUES (@SubjectName)", new SqlParameter("@SubjectName", txtSubjectName.Text));
			ShowMessage("Subject added successfully!");
			LoadSubjects();
		}

		private void ShowMessage(string msg)
		{
			message.Show(this, $"{msg}", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Information);
		}
		private void Class_Load(object sender, EventArgs e)
		{

		}
	}
}
