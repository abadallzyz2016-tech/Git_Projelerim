using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ATM_Simulasyonu.Forms.MainMenuForms
{
    public partial class Withdraw : Form
    {
        private string availableBalanceFileID;
        public Withdraw(string balanceAccountID)
        {
            InitializeComponent();

            this.availableBalanceFileID = balanceAccountID;

        }
        internal double GetAvailableBalance(string balanceAccountID)
        {
            string availableBalanceFilePath = $@"A:\ATM_Simulasyonu\Users\{balanceAccountID}.txt";
            string availabelBalanceText = File.ReadAllText(availableBalanceFilePath);

            if (double.TryParse(availabelBalanceText, out double balance))
            {
                return balance;
            }

            return 0.0; // Return 0 if the balance is invalid
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
        private void Withdraw_Load(object sender, EventArgs e)
        {
            string balanceAccountID = this.availableBalanceFileID;
            text_withdraw_enteramount.Enabled = false;
            if (rdobutton_withdraw_other.Checked)
            {
                text_withdraw_enteramount.Enabled = true;
            }
            label_withdraw_availablebalance.Text = $"Available Balance : {GetAvailableBalance(balanceAccountID)}";

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void rdobutton_withdraw_other_Checked(object sender, EventArgs e)
        {
            text_withdraw_enteramount.Enabled = false;
            if (rdobutton_withdraw_other.Checked == true)
            {
                text_withdraw_enteramount.Enabled = true;
            }


        }

        private void button_withdraw_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
            MainMenu mainMenuForm = new MainMenu("");
            mainMenuForm.Show();
        }

        private void button_withdraw_withdraw_Click(object sender, EventArgs e)
        {
            
            double availableBalance = GetAvailableBalance(this.availableBalanceFileID);
            if (rdobutton_withdraw_50.Checked)
            {
                if (availableBalance >= 50)
                {
                    File.WriteAllText($@"A:\ATM_Simulasyonu\Users\{this.availableBalanceFileID}.txt", (availableBalance - 50).ToString());
                    MessageBox.Show("Withdrawal of $50 successful, please take your cash.");
                    AddHistory(this.availableBalanceFileID, "Withdrawal", -50, availableBalance - 50, "Withdrawal of $50");

                }
                else
                {
                    MessageBox.Show("Insufficient balance for withdrawal.");
                }
                // Handle withdrawal of $50
            }
            else if (rdobutton_withdraw_100.Checked)
            {
                if (availableBalance >= 100)
                {
                    File.WriteAllText($@"A:\ATM_Simulasyonu\Users\{this.availableBalanceFileID}.txt", (availableBalance - 100).ToString());
                    MessageBox.Show("Withdrawal of $100 successful, please take your cash.");
                    AddHistory(this.availableBalanceFileID, "Withdrawal", -100, availableBalance - 100, "Withdrawal of $100");
                }
                else
                {
                    MessageBox.Show("Insufficient balance for withdrawal.");
                }
            }
            else if (rdobutton_withdraw_200.Checked)
            {
                if (availableBalance >= 200)
                {
                    File.WriteAllText($@"A:\ATM_Simulasyonu\Users\{this.availableBalanceFileID}.txt", (availableBalance - 200).ToString());
                    MessageBox.Show("Withdrawal of $200 successful, please take your cash.");
                    AddHistory(this.availableBalanceFileID, "Withdrawal", -200, availableBalance - 200, "Withdrawal of $200");
                }
                else
                {
                    MessageBox.Show("Insufficient balance for withdrawal.");
                }
            }
            else if (rdobutton_withdraw_500.Checked)
            {
                if (availableBalance >= 500)
                {
                    File.WriteAllText($@"A:\ATM_Simulasyonu\Users\{this.availableBalanceFileID}.txt", (availableBalance - 500).ToString());
                    MessageBox.Show("Withdrawal of $500 successful, please take your cash.");
                    AddHistory(this.availableBalanceFileID, "Withdrawal", -500, availableBalance - 500, "Withdrawal of $500");
                }
                else
                {
                    MessageBox.Show("Insufficient balance for withdrawal.");
                }
            }
            else if (rdobutton_withdraw_1000.Checked)
            {
                if (availableBalance >= 1000)
                {
                    File.WriteAllText($@"A:\ATM_Simulasyonu\Users\{this.availableBalanceFileID}.txt", (availableBalance - 1000).ToString());
                    MessageBox.Show("Withdrawal of $1000 successful, please take your cash.");
                    AddHistory(this.availableBalanceFileID, "Withdrawal", -1000, availableBalance - 1000, "Withdrawal of $1000");
                }
                else
                {
                    MessageBox.Show("Insufficient balance for withdrawal.");
                }
            }
            else if (rdobutton_withdraw_2000.Checked)
            {
                if (availableBalance >= 2000)
                {
                    File.WriteAllText($@"A:\ATM_Simulasyonu\Users\{this.availableBalanceFileID}.txt", (availableBalance - 2000).ToString());
                    MessageBox.Show("Withdrawal of $2000 successful, please take your cash.");
                    AddHistory(this.availableBalanceFileID, "Withdrawal", -2000, availableBalance - 2000, "Withdrawal of $2000");

                }
                else
                {
                    MessageBox.Show("Insufficient balance for withdrawal.");
                }
            }
            else if (rdobutton_withdraw_5000.Checked)
            {
                if (availableBalance >= 5000)
                {
                    File.WriteAllText($@"A:\ATM_Simulasyonu\Users\{this.availableBalanceFileID}.txt", (availableBalance - 5000).ToString());
                    MessageBox.Show("Withdrawal of $5000 successful, please take your cash.");
                    AddHistory(this.availableBalanceFileID, "Withdrawal", -5000, availableBalance - 5000, "Withdrawal of $5000");
                }
                else
                {
                    MessageBox.Show("Insufficient balance for withdrawal.");
                }
            }
            else if (rdobutton_withdraw_other.Checked)
            {
                if (double.TryParse(text_withdraw_enteramount.Text, out double otherAmount))
                {
                    if (availableBalance >= otherAmount)
                    {
                        File.WriteAllText($@"A:\ATM_Simulasyonu\Users\{this.availableBalanceFileID}.txt", (availableBalance - otherAmount).ToString());
                        MessageBox.Show($"Withdrawal of ${otherAmount} successful, please take your cash.");
                        AddHistory(this.availableBalanceFileID, "Withdrawal", -otherAmount, availableBalance - otherAmount, $"Custom withdrawal of ${otherAmount}");

                    }
                    else
                    {
                        MessageBox.Show("Insufficient balance for withdrawal.");
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a valid amount.");
                }
            }
            else
            {
                MessageBox.Show("Please select a withdrawal amount.");
            }
        }


        private void label_withdraw_availablebalance_Click(object sender, EventArgs e)
        {

        }
    }
}
