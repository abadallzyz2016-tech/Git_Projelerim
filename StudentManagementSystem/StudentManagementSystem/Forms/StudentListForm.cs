using StudentManagementSystem.Models;
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
    public partial class StudentListForm : Form
    {
        public StudentListForm()
        {
            InitializeComponent();
        }

        private void StudentListForm_Load(object sender, EventArgs e)
        {

            StudentService studentService = new StudentService();

            List<Student> students = studentService.GetAllStudents();

            dataGridView_students.DataSource = students;
        }

        private void button_studentlist_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
