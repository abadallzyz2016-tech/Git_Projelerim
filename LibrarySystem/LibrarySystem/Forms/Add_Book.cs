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
    public partial class Add_Book : Form
    {
        public Add_Book()
        {
            InitializeComponent();
        }

        private void button_addbook_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Add_Book_Load(object sender, EventArgs e)
        {

        }

        private void button_addbook_add_Click(object sender, EventArgs e)
        {
            BookService add = new BookService();
            add.BookAdd(this);
        }
    }
}
