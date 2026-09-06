using LibrarySystem.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LibrarySystem.Forms
{
    public partial class Delete_Member : Form
    {
        public Delete_Member()
        {
            InitializeComponent();
        }

        private void Delete_Member_Load(object sender, EventArgs e)
        {

        }

        private void button_deletemember_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_deletemember_delete_Click(object sender, EventArgs e)
        {
            MemberService delete = new MemberService();
            delete.MemberDelete(this);
        }
    }
}
