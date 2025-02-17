using Bunifu.UI.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Forms
{
	public partial class Student : Form
	{
		public Student()
		{
			InitializeComponent();
            OpenChildForm(new Forms.StudentView());
        }

		private void Student_Load(object sender, EventArgs e)
		{

		}

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton21_Click(object sender, EventArgs e)
        {
            
        }

        public void OpenChildForm(Form childForm)
        {
            panelContainer.Controls.Clear();

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            panelContainer.Controls.Add(childForm);
            panelContainer.Tag = childForm;

            childForm.BringToFront();
            childForm.Show();
        }

        private void bunifuButton26_Click(object sender, EventArgs e)
        {
            
        }

        private void bunifuButton23_Click(object sender, EventArgs e)
        {
            
        }




        private void bunifuButton25_Click(object sender, EventArgs e)
        {
            
        }

        private void panelContainer_Click(object sender, EventArgs e)
        {

        }

		private void save_Click(object sender, EventArgs e)
		{
			OpenChildForm(new Forms.AddStudent());
		}

		private void bunifuButton1_Click(object sender, EventArgs e)
		{
			StudentView studentView = Application.OpenForms.OfType<StudentView>().FirstOrDefault();
			if (studentView != null)
			{
				studentView.UpdateStudentFromGrid(); // Refresh the grid after editing
			}
			else
			{
				MessageBox.Show("Error: StudentView is not open.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void bunifuButton3_Click(object sender, EventArgs e)
		{
			StudentView studentView = Application.OpenForms.OfType<StudentView>().FirstOrDefault();
			if (studentView != null)
			{
				if (studentView.SelectedStudentID() != -1) // Ensure a student is selected
				{
					studentView.DeleteStudentFromGrid(); // Delete student
				}
				else
				{
					MessageBox.Show("Please select a student to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
			}
			else
			{
				MessageBox.Show("Error: StudentView is not open.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void bunifuButton2_Click(object sender, EventArgs e)
		{
			OpenChildForm(new Forms.Enroll());
		}

		private void panelContainer_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}
	}
}
