using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
            ActiveButton(button1, panel3);
            label3.Text = "Student";
            OpenChildForm(new Forms.Student());
        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private Form activeForm;
        private void ActiveButton(Button button, Panel panel)
        {
            button1.BackColor = Color.FromArgb(24, 30, 51);
            button2.BackColor = Color.FromArgb(24, 30, 51);
            button4.BackColor = Color.FromArgb(24, 30, 51);
            button5.BackColor = Color.FromArgb(24, 30, 51);
            button7.BackColor = Color.FromArgb(24, 30, 51);
            panel2.BackColor = Color.Transparent;
            panel3.BackColor = Color.Transparent;
            panel4.BackColor = Color.Transparent;
            panel5.BackColor = Color.Transparent;
            panel6.BackColor = Color.Transparent;
            button.BackColor = Color.FromArgb(24, 30, 45);
            panel.BackColor = Color.DeepSkyBlue;
        }
        public void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panel8.Controls.Add(childForm);
            this.panel8.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

       
         
        private void button1_Click_1(object sender, EventArgs e)
        {
            ActiveButton(button1, panel3);
            label3.Text = "Manage Student";
            OpenChildForm(new Forms.Student());
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            ActiveButton(button5, panel4);
            label3.Text = "Manage Teacher";
            OpenChildForm(new Forms.Teacher());
        }

        public void button4_Click_1(object sender, EventArgs e)
        {
            ActiveButton(button4, panel5);
            label3.Text = "Manage Classes";
            OpenChildForm(new Forms.Class());
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            ActiveButton(button2, panel6);
            label3.Text = "Mark Attendance";
            OpenChildForm(new Forms.Attendance());
        }
 
        private void button7_Click_1(object sender, EventArgs e)
        {
            ActiveButton(button7, panel2);
            label3.Text = "Evaluate Students";
            OpenChildForm(new Forms.EvaluateStudent());
        }


 
        private void Manager_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Role_Click(object sender, EventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void panel8_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
