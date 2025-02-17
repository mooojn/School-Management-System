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
    public partial class Enroll : Form
    {
        public Enroll()
        {
            InitializeComponent();
            LoadStudentIDs();
            LoadClassNames();
        }
		private void LoadStudentIDs()
		{
			List<(int StudentID, string FullName)> students = StudentDB.GetStudentsForBox(); // Get Student IDs and Names

			if (students.Count > 0)
			{
				comboBox3.Items.Clear(); // Clear existing items

				foreach (var student in students)
				{
					comboBox3.Items.Add(new KeyValuePair<int, string>(student.StudentID, student.FullName));
				}

				comboBox3.DisplayMember = "Value"; // Show FullName in ComboBox
				comboBox3.ValueMember = "Key"; // Store StudentID as value
			}
			else
			{
				MessageBox.Show("No students found!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}


		private void LoadClassNames()
        {
            List<string> classNames = StudentDB.GetClassNames(); // Fetch Class Names

            if (classNames.Count > 0)
            {
                comboBox1.Items.Clear(); // Clear existing items

                foreach (string className in classNames)
                {
                    comboBox1.Items.Add(className); // Add each Class Name
                }
            }
            else
            {
                MessageBox.Show("No classes found!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private int GetClassIDFromName(string className)
        {
            try
            {
                Database.OpenConnection();
                string query = "SELECT ClassID FROM Classes WHERE ClassName = @ClassName";

                using (SqlCommand cmd = new SqlCommand(query, Database.connection))
                {
                    cmd.Parameters.AddWithValue("@ClassName", className);
                    object result = cmd.ExecuteScalar();
                    return result != null ? Convert.ToInt32(result) : -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving Class ID: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
            finally
            {
                Database.CloseConnection();
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
           
        }

		private void bunifuButton2_Click(object sender, EventArgs e)
		{
			if (comboBox3.SelectedItem == null || comboBox1.SelectedItem == null)
			{
				MessageBox.Show("Please select a Student ID and a Class!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			// Extract StudentID properly
			int studentID = ((KeyValuePair<int, string>)comboBox3.SelectedItem).Key;
			string className = comboBox1.SelectedItem.ToString();

			// Convert Class Name to Class ID
			int classID = GetClassIDFromName(className);
			if (classID == -1)
			{
				MessageBox.Show("Invalid class selection!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			// Call the function to enroll the student
			bool enrolled = StudentDB.EnrollStudent(studentID, classID);

			if (enrolled)
			{
				MessageBox.Show("Student enrolled successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{
				MessageBox.Show("Enrollment failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

	}
}
