using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Security.Policy;
using System.Security.Principal;
using System.Text;
using System.Windows.Forms;

namespace ATM_Simulasyonu.Forms.MainMenuForms
{
    public partial class History : Form
    {
        private string accountID;
        public History(string accountID)
        {
            InitializeComponent();
            this.accountID = accountID;
        }

        private void History_Load(object sender, EventArgs e)
        {
            label_history_accountid.Text = "Account ID : " + this.accountID;
            string historyFilePath =
        $@"A:\ATM_Simulasyonu\History\{this.accountID}.txt";

            if (!File.Exists(historyFilePath))
            {
                MessageBox.Show("No transaction history found.");
                return;
            }

            string[] transactions =
                File.ReadAllLines(historyFilePath);

            foreach (string transaction in transactions)
            {
                string[] parts = transaction.Split('|');

                if (parts.Length >= 5)
                {
                    dgv_history.Rows.Add(
                        parts[0], parts[1], parts[2], parts[3], parts[4]);
                    // DataGridView'e ekle
                }
            }

        }

        private void label_history_accountid_Click(object sender, EventArgs e)
        {

        }

        private void button_history_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
