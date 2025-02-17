using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1.Forms
{
    public partial class StudentView : Form
    {
        public StudentView()
        {
            InitializeComponent();
            LoadStudentData();
            bunifuDataGridView1.ReadOnly = false; // Allow editing
            bunifuDataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // Select full row
            bunifuDataGridView1.AllowUserToAddRows = false; // Prevent adding new rows manually
            bunifuDataGridView1.AllowUserToDeleteRows = false; // Prevent deletion via UI

        }
        public void UpdateStudentFromGrid()
        {
            try
            {
                // Ensure a row is selected
                if (bunifuDataGridView1.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = bunifuDataGridView1.SelectedRows[0];

                    // Get values from the selected row
                    int studentID = Convert.ToInt32(selectedRow.Cells["StudentID"].Value);
                    string fullName = selectedRow.Cells["FullName"].Value.ToString();
                    DateTime dob = Convert.ToDateTime(selectedRow.Cells["DOB"].Value);
                    string gender = selectedRow.Cells["Gender"].Value.ToString();
                    string phone = selectedRow.Cells["Phone"].Value.ToString();

                    // Call UpdateStudent function
                    bool success = StudentDB.UpdateStudent(studentID, fullName, dob, gender, phone);

                    if (success)
                    {
                        MessageBox.Show("Student updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadStudentData(); // Refresh the DataGridView
                    }
                    else
                    {
                        MessageBox.Show("Failed to update student.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Please select a student to edit.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating student: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public int SelectedStudentID()
        {
            if (bunifuDataGridView1.SelectedRows.Count > 0)
            {
                return Convert.ToInt32(bunifuDataGridView1.SelectedRows[0].Cells["StudentID"].Value);
            }
            return -1; // Return -1 if no student is selected
        }

        public void bunifuDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void DeleteStudentFromGrid()
        {
            int studentID = SelectedStudentID();
            if (studentID == -1)
            {
                MessageBox.Show("Please select a student to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete this student and all associated records?",
                                                  "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                bool attendanceDeleted = StudentDB.DeleteStudentAttendance(studentID); // Delete attendance records
                bool studentDeleted = StudentDB.DeleteStudent(studentID); // Delete student

                if (studentDeleted)
                {
                    MessageBox.Show("Student deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadStudentData(); // Refresh grid
                }
                else
                {
                    MessageBox.Show("Failed to delete student.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void bunifuDataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Ensure row index is valid
                if (e.RowIndex >= 0)
                {
                    // Get updated values from the grid
                    int studentID = Convert.ToInt32(bunifuDataGridView1.Rows[e.RowIndex].Cells["StudentID"].Value);
                    string fullName = bunifuDataGridView1.Rows[e.RowIndex].Cells["FullName"].Value.ToString();
                    DateTime dob = Convert.ToDateTime(bunifuDataGridView1.Rows[e.RowIndex].Cells["DOB"].Value);
                    string gender = bunifuDataGridView1.Rows[e.RowIndex].Cells["Gender"].Value.ToString();
                    string phone = bunifuDataGridView1.Rows[e.RowIndex].Cells["Phone"].Value.ToString();

                    // Call UpdateStudent function
                    bool success = StudentDB.UpdateStudent(studentID, fullName, dob, gender, phone);

                    if (success)
                    {
                        MessageBox.Show("Student updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Failed to update student.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating student: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private static DataTable ConvertToDataTable(List<Dictionary<string, object>> list)
        {
            DataTable dt = new DataTable();

            if (list.Count > 0)
            {
                // Add columns based on the first dictionary keys
                foreach (var key in list[0].Keys)
                {
                    dt.Columns.Add(key);
                }

                // Add rows
                foreach (var dict in list)
                {
                    DataRow row = dt.NewRow();
                    foreach (var kvp in dict)
                    {
                        row[kvp.Key] = kvp.Value;
                    }
                    dt.Rows.Add(row);
                }
            }

            return dt;
        }

        private void LoadStudentData()
        {
            List<Dictionary<string, object>> students = StudentDB.GetAllStudentDetails();
            DataTable dt = ConvertToDataTable(students);

            bunifuDataGridView1.DataSource = dt;
        }


    }
}
