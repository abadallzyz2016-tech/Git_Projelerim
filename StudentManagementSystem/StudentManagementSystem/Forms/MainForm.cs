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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void button_mainform_studentadd_Click(object sender, EventArgs e)
        {
            this.Hide();

            StudentAddForm studentAddForm = new StudentAddForm();
            studentAddForm.FormClosed += (s, args) =>
            {
                this.Show();
            };
            studentAddForm.Show();
        }
        private void button_mainform_studentdelete_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentDeleteForm studentDeleteForm = new StudentDeleteForm();
            studentDeleteForm.FormClosed += (s, args) =>
            {
                this.Show();
            };
            studentDeleteForm.Show();
        }
        private void button_mainform_studentupdate_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentUpdateForm studentUpdateForm = new StudentUpdateForm();
            studentUpdateForm.FormClosed += (s, args) =>
            {
                this.Show();
            };
            studentUpdateForm.Show();
        }
        private void button_mainform_studentlist_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentListForm studentListForm = new StudentListForm();
            studentListForm.FormClosed += (s, args) =>
            {
                this.Show();
            };
            studentListForm.Show();
        }
        private void button_mainform_fakedata_Click(object sender, EventArgs e)
        {
            StudentService studentService = new StudentService();
            studentService.AddStudent();
            MessageBox.Show("100 fake student records were saved. You can check the student list.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void button_mainform_studentsearch_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentSearchForm studentSearchForm = new StudentSearchForm();
            studentSearchForm.FormClosed += (s, args) =>
            {
                this.Show();
            };
            studentSearchForm.Show();
        }





        private void button_mainform_deletealldata_Click(object sender, EventArgs e)
        {
            StudentService studentService = new StudentService();
            studentService.DeleteAll();
        }
        private void button_mainform_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_mainform_averagerating_Click(object sender, EventArgs e)
        {
            this.Hide();
            AverageRatingForm averageRatingForm = new AverageRatingForm();
            averageRatingForm.FormClosed += (s, args) =>
            {
                this.Show();
            };
            averageRatingForm.Show();
        }
    }
}
