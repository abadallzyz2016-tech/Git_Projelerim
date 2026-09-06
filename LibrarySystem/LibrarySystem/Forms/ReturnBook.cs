using LibrarySystem.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace LibrarySystem.Forms
{
    public partial class ReturnBook : Form
    {
        public ReturnBook()
        {
            InitializeComponent();
        }

        private void text_borrowbook_phone_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_returnbook_borrow_Click(object sender, EventArgs e)
        {
            LibraryService libraryService = new LibraryService();
            libraryService.ReturnBook(this);
        }

        private void button_returnbook_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
