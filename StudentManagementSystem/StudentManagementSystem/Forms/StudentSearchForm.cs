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
    public partial class StudentSearchForm : Form
    {
        public StudentSearchForm()
        {
            InitializeComponent();
        }

        private void button_studentsearch_search_Click(object sender, EventArgs e)
        {
            StudentService studentService = new StudentService();
            studentService.StudentSearch(this);
        }

        private void button_studentsearch_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
