using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using cmpt391Project.Library;

namespace cmpt391Project
{
    public partial class InstructorScreen : Form
    {
        List<InstructorScreen> instructor = new List<InstructorScreen>();
        public InstructorScreen()
        {
            InitializeComponent();
            updateBinding();
        }

        private void updateBinding()
        {
            InstructorListBox1.DataSource = instructor;
            InstructorListBox1.DisplayMember = "FullInfo";
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Instructors_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            InstructorDataAccess db = new InstructorDataAccess();

            db.InsertInstructor(Int32.Parse(instIdTB.Text), firstNameTextBox.Text, lastNameTextBox.Text, Int32.Parse(deptNameTextBox.Text));
            instIdTB.Text = "0";
            firstNameTextBox.Text = "";
            lastNameTextBox.Text = "";
            deptNameTextBox.Text = "0";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void View_Click(object sender, EventArgs e)
        {
            InstructorDataAccess db = new InstructorDataAccess();

            instructor = db.GetInstructor(Int32.Parse(instIdTB.Text));
            updateBinding();
        }

    }
}
