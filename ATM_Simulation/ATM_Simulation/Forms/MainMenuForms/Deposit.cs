using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace ATM_Simulasyonu.Forms.MainMenuForms
{

    public partial class Deposit : Form
    {

        private string availablebalanceID;

        public Deposit(string balanceAccountID)
        {
            InitializeComponent();
            this.availablebalanceID = balanceAccountID;
        }

        internal void Deposit_Load(object sender, EventArgs e)
        {
            string availableBalanceFilePath = $@"A:\ATM_Simulasyonu\Users\{this.availablebalanceID}.txt";
            label_deposit_availablebalance.Text = "Available Balance : " + File.ReadAllText(availableBalanceFilePath);
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

        //
        // buttons 
        //

        private void button_deposit_deposit_Click(object sender, EventArgs e)
        {
            double balance = double.Parse(File.ReadAllText($@"A:\ATM_Simulasyonu\Users\{this.availablebalanceID}.txt"));

            if (rdobutton_deposit_200.Checked)
            {
                File.WriteAllText($@"A:\ATM_Simulasyonu\Users\{this.availablebalanceID}.txt", (balance + 200).ToString());
                MessageBox.Show("Deposit successful! $200 has been deposited, Available Balance: " + File.ReadAllText($@"A:\ATM_Simulasyonu\Users\{this.availablebalanceID}.txt"));

                label_deposit_availablebalance.Text = "Available Balance : " + File.ReadAllText($@"A:\ATM_Simulasyonu\Users\{this.availablebalanceID}.txt");
                AddHistory(this.availablebalanceID, "Deposit", +200, balance + 200, $"Custom deposit of 200");
                
                this.Close();


                // Handle deposit logic for $200
            }
            else if (rdobutton_deposit_500.Checked)
            {
                File.WriteAllText($@"A:\ATM_Simulasyonu\Users\{this.availablebalanceID}.txt", (balance + 500).ToString());
                MessageBox.Show("Deposit successful! $500 has been deposited, Available Balance: " + File.ReadAllText($@"A:\ATM_Simulasyonu\Users\{this.availablebalanceID}.txt"));
                label_deposit_availablebalance.Text = "Available Balance : " + File.ReadAllText($@"A:\ATM_Simulasyonu\Users\{this.availablebalanceID}.txt");
                AddHistory(this.availablebalanceID, "Deposit", +500, balance + 500, $"Custom deposit of 500");
                
                this.Close();
            }
            else if (rdobutton_deposit_1000.Checked)
            {
                File.WriteAllText($@"A:\ATM_Simulasyonu\Users\{this.availablebalanceID}.txt", (balance + 1000).ToString());
                MessageBox.Show("Deposit successful! $1000 has been deposited, Available Balance: " + File.ReadAllText($@"A:\ATM_Simulasyonu\Users\{this.availablebalanceID}.txt"));
                label_deposit_availablebalance.Text = "Available Balance : " + File.ReadAllText($@"A:\ATM_Simulasyonu\Users\{this.availablebalanceID}.txt");
                AddHistory(this.availablebalanceID, "Deposit", +1000, balance + 1000, $"Custom deposit of 1000");
                
                this.Close();
            }
            else if (rdobutton_deposit_2000.Checked)
            {
                File.WriteAllText($@"A:\ATM_Simulasyonu\Users\{this.availablebalanceID}.txt", (balance + 2000).ToString());
                MessageBox.Show("Deposit successful! $2000 has been deposited, Available Balance: " + File.ReadAllText($@"A:\ATM_Simulasyonu\Users\{this.availablebalanceID}.txt"));
                label_deposit_availablebalance.Text = "Available Balance : " + File.ReadAllText($@"A:\ATM_Simulasyonu\Users\{this.availablebalanceID}.txt");
                AddHistory(this.availablebalanceID, "Deposit", +2000, balance + 2000, $"Custom deposit of 2000");
                this.Close();
            }
            else if (!string.IsNullOrEmpty(text_deposit_enteramount.Text))
            {
                if (double.TryParse(text_deposit_enteramount.Text, out double customAmount))
                {
                    File.WriteAllText($@"A:\ATM_Simulasyonu\Users\{this.availablebalanceID}.txt", (balance + customAmount).ToString());
                    MessageBox.Show("Deposit successful! $" + customAmount + " has been deposited, Available Balance: " + File.ReadAllText($@"A:\ATM_Simulasyonu\Users\{this.availablebalanceID}.txt"));
                    label_deposit_availablebalance.Text = "Available Balance : " + File.ReadAllText($@"A:\ATM_Simulasyonu\Users\{this.availablebalanceID}.txt");
                    AddHistory(this.availablebalanceID, "Deposit", +customAmount, balance + customAmount, $"Custom deposit of ${customAmount}");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Invalid amount entered.");
                }
            }
            else
            {
                MessageBox.Show("Please select an amount or enter a custom amount.");
            }
        }



        private void button_deposit_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
            MainMenu mainMenuForm = new MainMenu("");
            mainMenuForm.Show();
        }
    }
}
