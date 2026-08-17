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
    public partial class AverageRatingForm : Form
    {
        public AverageRatingForm()
        {
            InitializeComponent();
        }

        private void AverageRatingForm_Load(object sender, EventArgs e)
        {
            StudentService studentService = new StudentService();

            List<Student> students = studentService.GetAllStudents();

            students = students
                .OrderByDescending(student => student.Average)
                .ToList();

            dataGridView_students.DataSource = students;
        }

        private void button_averagerating_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
