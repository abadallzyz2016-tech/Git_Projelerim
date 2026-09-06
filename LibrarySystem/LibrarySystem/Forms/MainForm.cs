using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LibrarySystem.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button_main_addb_Click(object sender, EventArgs e)
        {
            this.Hide();
            Add_Book addb = new Add_Book();
            addb.FormClosed += (s, args) =>
            {
                this.Show();
            };
            addb.Show();
        }

        private void button_main_deleteb_Click(object sender, EventArgs e)
        {
            this.Hide();
            Delete_Book delete_Book = new Delete_Book();
            delete_Book.FormClosed += (s, args) =>
            {
                this.Show();
            };
            delete_Book.Show();
        }

        private void button_main_listb_Click(object sender, EventArgs e)
        {
            this.Hide();
            List_Book list_Book = new List_Book();
            list_Book.FormClosed += (s, args) =>
            {
                this.Show();
            };
            list_Book.Show();
        }

        private void button_main_searchb_Click(object sender, EventArgs e)
        {
            this.Hide();
            Search_Book search_Book = new Search_Book();
            search_Book.FormClosed += (s, args) =>
            {
                this.Show();
            };
            search_Book.Show();

        }

        // buttons of members

        private void button_main_addm_Click(object sender, EventArgs e)
        {
            this.Hide();
            Add_Member add = new Add_Member();
            add.FormClosed += (s, args) =>
            {
                this.Show();
            };
            add.Show();
        }

        private void button_main_deletem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Delete_Member delete_Member = new Delete_Member();
            delete_Member.FormClosed += (s, args) =>
            {
                this.Show();
            };
            delete_Member.Show();
        }

        private void button_main_listm_Click(object sender, EventArgs e)
        {
            this.Hide();
            List_Member list_Member = new List_Member();
            list_Member.FormClosed += (s, args) =>
            {
                this.Show();
            };
            list_Member.Show();
        }

        private void button_main_searchm_Click(object sender, EventArgs e)
        {
            this.Hide();
            Search_Member search = new Search_Member();
            search.FormClosed += (s, args) =>
            {
                this.Show();
            };
            search.Show();
        }


        // Books Operations


        private void button_main_borrow_Click(object sender, EventArgs e)
        {
            this.Hide();
            BorrowBook borrowBook = new BorrowBook();
            borrowBook.FormClosed += (s, args) =>
            {
                this.Show();
            };
            borrowBook.Show();
        }

        private void button_main_return_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReturnBook returnBook = new ReturnBook();
            returnBook.FormClosed += (s, args) =>
            {
                this.Show();
            }; returnBook.Show();
        }

        private void button_main_booksloan_Click(object sender, EventArgs e)
        {
            this.Hide();
            BooksLoan booksLoan = new BooksLoan();
            booksLoan.FormClosed += (s, args) =>
            {
                this.Show();
            }; booksLoan.Show();

        }

        private void button_main_loanhistory_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoanHistory loanHistory = new LoanHistory();
            loanHistory.FormClosed += (s, args) =>
            {
                this.Show();
            }; loanHistory.Show();
        }

        private void button_main_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
