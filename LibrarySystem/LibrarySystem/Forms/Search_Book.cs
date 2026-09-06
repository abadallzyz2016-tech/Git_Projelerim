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
    public partial class Search_Book : Form
    {
        public Search_Book()
        {
            InitializeComponent();
        }

        private void Search_Book_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button_searchbook_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_searchbook_search_Click(object sender, EventArgs e)
        {
            BookService search = new BookService();
            search.BookSearch(this);
        }
    }
}
