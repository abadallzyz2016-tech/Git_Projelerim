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
    public partial class StudentDeleteForm : Form
    {
        public StudentDeleteForm()
        {
            InitializeComponent();
        }

        private void DeleteStudentForm_Load(object sender, EventArgs e)
        {

        }
        private void label_deletestudent_studentsurname_Click(object sender, EventArgs E)
        {

        }
        private void label_deletestudent_studentname_Click(object sender, EventArgs e)
        {

        }
        private void label_deletestudent_studentid_Click(object sender, EventArgs e)
        {

        }
        private void label_deletestudent_studentinformation_Click(object sender, EventArgs e)
        {

        }
        private void button_deletestudent_delete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(text_deletestudent_id.Text) ||
                string.IsNullOrEmpty(text_deletestudent_name.Text) ||
                string.IsNullOrEmpty(text_deletestudent_surname.Text))
            {
                MessageBox.Show("Please fill in all fields! ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Are you sure about this Process?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                StudentService studentService = new StudentService();

                studentService.DeleteStudent(this);
            }

        }

        private void button_deletestudent_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
