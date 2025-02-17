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

namespace WindowsFormsApp1.Forms
{
	public partial class Teacher : Form
	{
        public int TeacherID = 0;
        public int classID = 0; 
        public int SubjectID = 0;
        public string FullName = null;
        public string className = null;
        public string Phone = null;
        public DateTime hireDate;
        public bool Table_Flag = false;

		public Teacher()
		{
			InitializeComponent();
            bunifuPanel1.Visible = false;
            Delet_Button.Visible = false;
            Edit_Button.Visible = false;
            Add_Teacher.Visible = false;
            EditApplier_Button.Visible = false;
            Assign_Class_Button.Visible = false;
            Assign_Button.Visible = false;
            Back_Button_2.Visible = false;
            TeacherRecordsTable.CellClick += TeacherRecordsTable_CellClick;

		}
        private void Teacher_Load(object sender, EventArgs e)
        {
            loadTeacherReports();
            LoadSubjectBox();
        }
		private void ShowMessage(string msg)
		{
			message.Show(this, $"{msg}", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Information);
		}
		public void loadTeacherReports() 
        {
            Database.OpenConnection();
            string query = "SELECT TeacherID, FullName, SubjectID, Phone, HireDate FROM Teachers";
            SqlDataAdapter adapter = new SqlDataAdapter(query,Database.connection);
            DataTable datatable = new DataTable();
            adapter.Fill(datatable);
            TeacherRecordsTable.DataSource = datatable;
            Database.CloseConnection();
        }
        public void Insert_New_Teacher() 
        {
                Database.OpenConnection();
                string query = "INSERT  INTO Teachers ( FullName, SubjectID, Phone, HireDate) VALUES (@Name, @Subject, @Phone, @Date)";
                SqlCommand command = new SqlCommand(query, Database.connection);
                command.Parameters.AddWithValue("@Name", FullName_TextBox.Text);
                command.Parameters.AddWithValue("@Subject", Convert.ToInt32(SubjectID_comboBox.SelectedValue));
                command.Parameters.AddWithValue("@Phone", Phone_TextBox.Text);
                command.Parameters.AddWithValue("@Date", HireDate_DatePicker.Value);

                command.ExecuteNonQuery();
                Database.CloseConnection();
                ShowMessage("Teacher Added successfully!");
                loadTeacherReports();


        }
        public void EditClassRecords()
        {
            Database.OpenConnection();
            string query = "UPDATE Classes SET TeacherID = @ID WHERE ClassID = @ClassID";
            SqlCommand command = new SqlCommand(query, Database.connection);
            command.Parameters.AddWithValue("@ID", TeacherID);
            command.Parameters.AddWithValue("@ClassID", classID);

            int rowsAffected = command.ExecuteNonQuery();
            Database.CloseConnection();

            if (rowsAffected > 0)
            {
                loadClasses(); // Refresh table
            }
        }
        public void EditTeacherRecords()
        {
            Database.OpenConnection();
            string query = "UPDATE Teachers SET FullName = @FullName, SubjectID = @SubjectID, Phone = @Phone, HireDate = @HireDate WHERE TeacherID = @TeacherID";
            SqlCommand command = new SqlCommand(query, Database.connection);
            command.Parameters.AddWithValue("@TeacherID", TeacherID);
            command.Parameters.AddWithValue("@FullName", FullName_TextBox.Text);    
            command.Parameters.AddWithValue("@SubjectID", Convert.ToInt32(SubjectID_comboBox.SelectedValue));
            command.Parameters.AddWithValue("@Phone", Phone_TextBox.Text);
            command.Parameters.AddWithValue("@HireDate", HireDate_DatePicker.Value);
            int rowsAffected = command.ExecuteNonQuery();
            Database.CloseConnection();

            if (rowsAffected > 0)
            {
                ShowMessage("Record Edited successfully!");
                loadTeacherReports(); // Refresh table
            }
        }
		public void DeleteTeacherRecord()
		{
			Database.OpenConnection();
			string updateQuery = "UPDATE Classes SET TeacherID = NULL WHERE TeacherID = @TeacherID";
			SqlCommand updateCommand = new SqlCommand(updateQuery, Database.connection);
			updateCommand.Parameters.AddWithValue("@TeacherID", TeacherID);
			updateCommand.ExecuteNonQuery();
			string deleteQuery = "DELETE FROM Teachers WHERE TeacherID = @TeacherID";
			SqlCommand deleteCommand = new SqlCommand(deleteQuery, Database.connection);
			deleteCommand.Parameters.AddWithValue("@TeacherID", TeacherID);

			int rowsAffected = deleteCommand.ExecuteNonQuery();

			Database.CloseConnection();

			if (rowsAffected > 0)
			{
				ShowMessage("Teacher deleted successfully!");
				loadTeacherReports(); 
			}
		}

		private void TeacherRecordsTable_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0)
			{
				try
				{
					if (Table_Flag)
					{
						classID = Convert.ToInt32(TeacherRecordsTable.Rows[e.RowIndex].Cells["ClassID"].Value ?? 0);
						className = Convert.ToString(TeacherRecordsTable.Rows[e.RowIndex].Cells["ClassName"].Value ?? string.Empty);
					}
					else
					{
						TeacherID = Convert.ToInt32(TeacherRecordsTable.Rows[e.RowIndex].Cells["TeacherID"].Value ?? 0);
						SubjectID = Convert.ToInt32(TeacherRecordsTable.Rows[e.RowIndex].Cells["SubjectID"].Value ?? 0);
						Phone = Convert.ToString(TeacherRecordsTable.Rows[e.RowIndex].Cells["Phone"].Value ?? string.Empty);
						FullName = Convert.ToString(TeacherRecordsTable.Rows[e.RowIndex].Cells["FullName"].Value ?? string.Empty);
						hireDate = Convert.ToDateTime(TeacherRecordsTable.Rows[e.RowIndex].Cells["HireDate"].Value ?? DateTime.MinValue);
					}

					if (classID > 0)
					{
						Assign_Button.Visible = true;
					}
					if (classID < 1)
					{
						Delet_Button.Visible = true;
						Edit_Button.Visible = true;
						Assign_Class_Button.Visible = true;
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show($"Error: {ex.Message}", "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			else
			{
				Delet_Button.Visible = false;
				Edit_Button.Visible = false;
			}
		}

		public void loadClasses() 
        {
            Database.OpenConnection();
            string query = "SELECT ClassID, ClassName FROM Classes WHERE TeacherID IS NULL";
            SqlDataAdapter adapter = new SqlDataAdapter(query, Database.connection);
            DataTable datatable = new DataTable();
            adapter.Fill(datatable);
            TeacherRecordsTable.DataSource = datatable;
            Database.CloseConnection();
        }
        private void LoadSubjectBox()
        {
            DataTable classTable = new DataTable();
            Database.OpenConnection();

            string query = "SELECT SubjectID, SubjectName FROM Subjects";
            using (SqlCommand command = new SqlCommand(query, Database.connection))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(classTable);
            }
            Database.CloseConnection();

            // Bind data to dropdown
            SubjectID_comboBox.DataSource = classTable;
            SubjectID_comboBox.DisplayMember = "SubjectName";
            SubjectID_comboBox.ValueMember = "SubjectID";
            SubjectID_comboBox.Text = SubjectID_comboBox.ValueMember;
            SubjectID_comboBox.SelectedIndex = 0;
        }
        private void TeacherRecordsTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void bunifuPanel1_Click(object sender, EventArgs e)
        {

        }
        private void Insert_Button_Click(object sender, EventArgs e)
        {
			

		}
        private void Add_Teacher_Click(object sender, EventArgs e)
        {
            
        }
        private void FullName_TextBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void Phone_TextBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void HireDate_DatePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void GoBack_Button_Click(object sender, EventArgs e)
        {
           

        }

        private void SibjectID_TextBox_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void Delet_Button_Click(object sender, EventArgs e)
        {
			
		}
       
        private void EditApplier_Button_Click(object sender, EventArgs e)
        {
            
        }
        
        private void Edit_Button_Click(object sender, EventArgs e)
        {
            
        }

        private void Assign_Class_Button_Click(object sender, EventArgs e)
        {
            
        }

        private void Assign_Button_Click(object sender, EventArgs e)
        {
            
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

		private void save_Click(object sender, EventArgs e)
		{
			loadTeacherReports();
			Table_Flag = false;
			Insert_Button.Visible = true;
			classID = 0;
			Assign_Button.Visible = false;
			Back_Button_2.Visible = false;
		}

		private void bunifuButton1_Click(object sender, EventArgs e)
		{
			FullName_TextBox.Text = null;
			SubjectID_comboBox.Text = null;
			Phone_TextBox.Text = null;
			bunifuPanel1.Visible = true;
            bunifuPanel1.BringToFront();
			Add_Teacher.Visible = true;
			EditApplier_Button.Visible = false;
		}

		private void bunifuButton1_Click_1(object sender, EventArgs e)
		{
			DialogResult result = MessageBox.Show("Assign Class?", "Attendance", MessageBoxButtons.YesNoCancel);
			if (result == DialogResult.Yes)
			{
				EditClassRecords();
				ShowMessage($"Teacher {FullName} assigned to class {className}!");
			}
		}

		private void bunifuButton1_Click_2(object sender, EventArgs e)
		{
			if (!bunifuPanel1.Visible)
			{
				DialogResult result = MessageBox.Show("Assign Class?", "Attendance", MessageBoxButtons.YesNoCancel);
				if (result == DialogResult.Yes)
				{
					Table_Flag = true;
					Delet_Button.Visible = false;
					Edit_Button.Visible = false;
					Insert_Button.Visible = false;
					Back_Button_2.Visible = true;
					loadClasses();
					Assign_Class_Button.Visible = false;
				}
			}
		}

		private void bunifuButton1_Click_3(object sender, EventArgs e)
		{
			if (!bunifuPanel1.Visible)
			{
				if (TeacherID > 0)
				{
					DeleteTeacherRecord();
				}
			}
			else
			{
				ShowMessage("An Error Occured!");
			}
		}

		private void bunifuButton1_Click_4(object sender, EventArgs e)
		{
			FullName_TextBox.Text = FullName;
			SubjectID_comboBox.Text = Convert.ToString(SubjectID);
			Phone_TextBox.Text = Phone;
			HireDate_DatePicker.Value = hireDate;
			bunifuPanel1.Visible = true;
			bunifuPanel1.BringToFront();
			EditApplier_Button.Visible = true;
			Add_Teacher.Visible = false;
		}

		private void bunifuButton1_Click_5(object sender, EventArgs e)
		{
			bunifuPanel1.Visible = false;
			Add_Teacher.Visible = false;
			EditApplier_Button.Visible = false;
		}

		private void bunifuButton1_Click_6(object sender, EventArgs e)
		{
			if (TeacherID > 0)
			{
				EditTeacherRecords();
				SubjectID = Convert.ToInt32(SubjectID_comboBox.SelectedValue);
				FullName = FullName_TextBox.Text;
				Phone = Phone_TextBox.Text;
				hireDate = HireDate_DatePicker.Value;
				FullName_TextBox.Text = null;
				SubjectID_comboBox.Text = null;
				Phone_TextBox.Text = null;
				HireDate_DatePicker.Value = DateTime.Now;
				bunifuPanel1.Visible = false;
				EditApplier_Button.Visible = false;
			}
			else
			{
				ShowMessage("An Error Occured!");
			}
		}

		private void bunifuButton2_Click(object sender, EventArgs e)
		{
			if (SubjectID_comboBox.SelectedValue == null ||
				string.IsNullOrWhiteSpace(FullName_TextBox.Text) ||
				string.IsNullOrWhiteSpace(Phone_TextBox.Text) ||
				string.IsNullOrWhiteSpace(HireDate_DatePicker.Text))
			{
				ShowMessage("Please Fill Complete Information!");
			}
			else
			{
				Insert_New_Teacher();
				bunifuPanel1.Visible = false;
				Add_Teacher.Visible = false;
			}
		}
	}
}
