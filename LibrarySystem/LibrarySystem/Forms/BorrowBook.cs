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
    public partial class BorrowBook : Form
    {
        public BorrowBook()
        {
            InitializeComponent();
        }

        private void BorrowBook_Load(object sender, EventArgs e)
        {

        }

        private void button_borrowbook_borrow_Click(object sender, EventArgs e)
        {
            LibraryService libraryService = new LibraryService();
            libraryService.BorrowBook(this);
        }

        private void button_borrowbook_check_Click(object sender, EventArgs e)
        {
            LibraryService libraryService = new LibraryService();
            libraryService.CheckBook(this);
        }

        private void button_borrowbook_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
