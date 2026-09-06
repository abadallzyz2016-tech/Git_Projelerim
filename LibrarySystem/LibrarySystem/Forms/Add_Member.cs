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
    public partial class Add_Member : Form
    {
        public Add_Member()
        {
            InitializeComponent();
        }


        private void Add_Member_Load(object sender, EventArgs e)
        {

        }

        private void text_addmember_firstname_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_addmember_add_Click(object sender, EventArgs e)
        {
            MemberService memberService = new MemberService();
            memberService.MemberAdd(this);
            
        }
        private void button_addmember_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
