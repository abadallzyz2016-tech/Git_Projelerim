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
    public partial class BooksLoan : Form
    {
        public BooksLoan()
        {
            InitializeComponent();
        }

        private void label_booksloan_head_Click(object sender, EventArgs e)
        {

        }

        private void BooksLoan_Load(object sender, EventArgs e)
        {
            LibraryService loan = new LibraryService();
            loan.BooksLoan(this);
        }

        private void button_listmember_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
