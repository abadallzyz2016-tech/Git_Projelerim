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
    public partial class StudentUpdateForm : Form
    {
        public StudentUpdateForm()
        {
            InitializeComponent();

        }

        private void StudentUpdateForm_Load(object sender, EventArgs e)
        {
            combobox_studentupdate_nsex.Items.Add("Male");
            combobox_studentupdate_nsex.Items.Add("Female");
        }

        private void button_studentupdate_save_Click(object sender, EventArgs e)
        {
            if (text_studentupdate_id.Text == null || text_studentupdate_id.Text == "")
            {
                MessageBox.Show("Please fill in all fields! ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                StudentService studentService = new StudentService();
                studentService.UpdateStudent(this);
            }
        }

        private void text_studentupdate_oname_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_studentupdate_find_Click(object sender, EventArgs e)
        {
            StudentService studentService = new StudentService();
            studentService.FindStudent(this);
        }

        private void button_studentupdate_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
