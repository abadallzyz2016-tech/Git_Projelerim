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
    public partial class LoanHistory : Form
    {
        public LoanHistory()
        {
            InitializeComponent();
        }

        private void button_loanhistory_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_loanhistory_find_Click(object sender, EventArgs e)
        {
            LibraryService historyService = new LibraryService();
            historyService.HistoryLoan(this);
        }

        private void LoanHistory_Load(object sender, EventArgs e)
        {

        }
    }
}
