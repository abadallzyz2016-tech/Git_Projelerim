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
    public partial class Delete_Book : Form
    {
        public Delete_Book()
        {
            InitializeComponent();
        }

        private void button_deletebook_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Delete_Book_Load(object sender, EventArgs e)
        {

        }

        private void button_deletebook_remove_Click(object sender, EventArgs e)
        {
            BookService delete = new BookService();
            delete.BookDelete(this);
        }
    }
}
