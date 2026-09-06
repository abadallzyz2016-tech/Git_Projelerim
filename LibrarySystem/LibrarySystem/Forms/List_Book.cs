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
    public partial class List_Book : Form
    {
        public List_Book()
        {
            InitializeComponent();
        }

        private void List_Book_Load(object sender, EventArgs e)
        {
            BookService list = new BookService();
            list.BookList(this);
        }

        private void button_listbook_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void button_listbook_list_Click(object sender, EventArgs e)
        {
            
        }
    }
}
