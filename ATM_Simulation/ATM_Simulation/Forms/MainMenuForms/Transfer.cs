using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ATM_Simulasyonu.Forms.MainMenuForms
{
    public partial class Transfer : Form
    {
        private string availableBalanceFileID;
        public Transfer(string balanceAccountID)
        {
            InitializeComponent();
            this.availableBalanceFileID = balanceAccountID;
        }

        private void AddHistory(
    string accountID,
    string type,
    double amount,
    double balance,
    string description)
        {
            string historyFolder = @"A:\ATM_Simulasyonu\History";

            if (!Directory.Exists(historyFolder))
            {
                Directory.CreateDirectory(historyFolder);
            }

            string historyFilePath =
                $@"{historyFolder}\{accountID}.txt";

            string historyLine =
                $"{DateTime.Now:dd.MM.yyyy HH:mm}|{type}|{amount}|{balance}|{description}"
                + Environment.NewLine;

            File.AppendAllText(historyFilePath, historyLine);
        }
        private void label_transfer_transfermoney_Click(object sender, EventArgs e)
        {

        }
        private void Transfer_Load(object sender, EventArgs e)
        {
            string balanceAccountID = this.availableBalanceFileID;
            label_transfer_availablebalance.Text = $"Available Balance : {File.ReadAllText($@"A:\ATM_Simulasyonu\Users\{balanceAccountID}.txt")}".ToString();
            label_transfer_accountid.Text = $"Account ID : {balanceAccountID}";
        }



        //
        //
        // Button click event handlers for transfer options
        //
        //

        private void button_transfer_transfer_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(text_transfer_recipientaccountid.Text) && !string.IsNullOrEmpty(text_transfer_transferamount.Text))
            {
                string recipientAccountID = text_transfer_recipientaccountid.Text;
                double transferAmount = double.Parse(text_transfer_transferamount.Text);
                if (transferAmount > 0)
                {
                    string senderAccountID = this.availableBalanceFileID;
                    string senderBalanceFilePath = $@"A:\ATM_Simulasyonu\Users\{senderAccountID}.txt";
                    string recipientBalanceFilePath = $@"A:\ATM_Simulasyonu\Users\{recipientAccountID}.txt";
                    if (!File.Exists(recipientBalanceFilePath))
                    {
                        MessageBox.Show("Recipient account does not exist.");
                        return;
                    }
                    double senderBalance = double.Parse(File.ReadAllText(senderBalanceFilePath));
                    if (transferAmount > senderBalance)
                    {
                        MessageBox.Show("Insufficient funds for the transfer.");
                        return;
                    }

                    // Perform the transfer
                    senderBalance -= transferAmount;
                    double recipientBalance = double.Parse(File.ReadAllText(recipientBalanceFilePath));
                    recipientBalance += transferAmount;
                    File.WriteAllText(senderBalanceFilePath, senderBalance.ToString());
                    File.WriteAllText(recipientBalanceFilePath, recipientBalance.ToString());
                    label_transfer_availablebalance.Text = $"Available Balance : {File.ReadAllText(senderBalanceFilePath)}";
                    MessageBox.Show($"Transfer successful! ${transferAmount} has been transferred to account {recipientAccountID}.");
                    AddHistory(
                        senderAccountID,
                        "Transfer",
                        -transferAmount,
                        senderBalance,
                        $"To: {recipientAccountID}"
                    );

                    AddHistory(
                        recipientAccountID,
                        "Transfer",
                        transferAmount,
                        recipientBalance,
                        $"From: {senderAccountID}"
                    );
                }
                else
                {
                    MessageBox.Show("Please enter a valid transfer amount greater than 0.");
                }
            }
            else
            {
                MessageBox.Show("Please enter both recipient account ID and transfer amount.");
            }
        }

        private void button_transfer_cancel_Click(object sender, EventArgs e)
        {

            this.Close();

        }

        private void label_transfer_head_Click(object sender, EventArgs e)
        {

        }


    }
}
