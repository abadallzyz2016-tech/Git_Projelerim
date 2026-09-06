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
    public partial class Search_Member : Form
    {
        public Search_Member()
        {
            InitializeComponent();
        }

        private void button_searchmember_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_searchmember_search_Click(object sender, EventArgs e)
        {
            MemberService memberService = new MemberService();
            memberService.MemberSearch(this);

        }
    }
}
