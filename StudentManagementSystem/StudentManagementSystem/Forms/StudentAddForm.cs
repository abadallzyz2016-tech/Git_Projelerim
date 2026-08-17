using StudentManagementSystem.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace StudentManagementSystem.Forms
{
    public partial class StudentAddForm : Form
    {
        public StudentAddForm()
        {
            InitializeComponent();
        }

        private void StudentAddForm_Load(object sender, EventArgs e)
        {

            comboBox_studentadd_sex.Items.Add("Male");
            comboBox_studentadd_sex.Items.Add("Female");


        }

        private void button_studentadd_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_studentadd_save_Click(object sender, EventArgs e)
        {
            StudentService addStudent = new StudentService();
            addStudent.AddStudentManuel(this);
        }

        private void text_studentadd_average_TextChanged(object sender, EventArgs e)
        {

        }

        private void text_studentadd_department_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
