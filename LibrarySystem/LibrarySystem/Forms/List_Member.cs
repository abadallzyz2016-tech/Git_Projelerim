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
    public partial class List_Member : Form
    {
        public List_Member()
        {
            InitializeComponent();
        }

        private void List_Member_Load(object sender, EventArgs e)
        {
            MemberService list = new MemberService();
            list.MemberList(this);
        }

        private void button_listmember_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
