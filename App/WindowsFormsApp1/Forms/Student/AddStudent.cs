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
    public partial class AddStudent : Form
    {
        public AddStudent()
        {
            InitializeComponent();
            AddGender();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }


        private void AddGender()
        {
            comboBox1.Items.Add("Male");
            comboBox1.Items.Add("Female");
            comboBox1.Items.Add("Other");
        }






        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            
        }
        



        private void bunifuLabel5_Click(object sender, EventArgs e)
        {

        }

        private void phonetxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuLabel4_Click(object sender, EventArgs e)
        {

        }

        private void bunifuLabel3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuLabel2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuLabel1_Click(object sender, EventArgs e)
        {

        }

        private void dobtxt_ValueChanged(object sender, EventArgs e)
        {

        }

        private void fullNametxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddStudent_Load(object sender, EventArgs e)
        {

        }

		private void bunifuButton25_Click(object sender, EventArgs e)
		{
			string fullName = fullNametxt.Text;
			DateTime dob = dobtxt.Value;
			string gender = comboBox1.SelectedItem?.ToString() ?? ""; // Handle null selection
			string phone = phonetxt.Text;

			bool success = StudentDB.AddStudent(fullName, dob, gender, phone);

			if (success)
			{
				MessageBox.Show("Student added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

				// Find the main Student form
				Student studentForm = Application.OpenForms["Student"] as Student;
				if (studentForm != null)
				{
					// Open StudentView as a child form inside Student
					studentForm.OpenChildForm(new StudentView());
				}

				// Hide this form since it's a child
				this.Hide();
			}
			else
			{
				MessageBox.Show("Failed to add student.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}
