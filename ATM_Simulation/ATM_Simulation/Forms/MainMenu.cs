using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ATM_Simulasyonu.Forms
{
    public partial class MainMenu : Form
    {
        private string loggedInUsername;
        public MainMenu(string username)
        {
            InitializeComponent();
            this.loggedInUsername = username;
        }
        private string BALANCEACCOUNTID;

        private void MainMenu_Load(object sender, EventArgs e)
        {
            string filePath = $@"A:\ATM_Simulasyonu\Sign_Up.txt";
            if (!File.Exists(filePath))
            {
                MessageBox.Show("No user data found. Please sign up first.");
                return;
            }
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split('|');
                    if (parts.Length >= 8)
                    {
                        BALANCEACCOUNTID = parts[6];
                        string username = parts[5];
                        if (username == loggedInUsername)
                        {
                            label_mainmenu_name.Text = $"Welcome , {parts[0]}";
                            label_mainmenu_accountid.Text = $"Account ID : {parts[6]}";
                            break;
                        }
                    }
                }
            }
            label_mainmenu_accountbalance.Text = $"Account Balance : ${File.ReadAllText($@"A:\ATM_Simulasyonu\Users\{this.BALANCEACCOUNTID}.txt").ToString()} ";
        }
        //private void Main
        //{

        //}
        private void label_mainmenu_name_Click(object sender, EventArgs e)
        {

        }
        private void label_mainmenu_accountid_Click(object sender, EventArgs e)
        {

        }
        private void label_mainmenu_accountbalance_Click(object sender, EventArgs e)
        {

        }

        //
        //
        // Button click event handlers for main menu options
        //
        //

        private void button_mainmenu_withdraw_Click(object sender, EventArgs e)
        {
            this.Close();
            string balanceAccountID = this.BALANCEACCOUNTID;
            MainMenuForms.Withdraw withdrawForm = new MainMenuForms.Withdraw(balanceAccountID);
            withdrawForm.Show();
        }
        private void button_mainmenu_deposit_Click(object sender, EventArgs e)
        {

            string balanceAccountID = this.BALANCEACCOUNTID;
            MainMenuForms.Deposit depositForm = new MainMenuForms.Deposit(balanceAccountID);
            depositForm.Show();
        }
        private void button_mainmenu_transfer_Click(object sender, EventArgs e)
        {
            MainMenuForms.Transfer transferForm = new MainMenuForms.Transfer(this.BALANCEACCOUNTID);
            transferForm.Show();
        }
        private void button_mainmenu_history_Click(object snder, EventArgs e)
        {
            
            MainMenuForms.History historyForm = new MainMenuForms.History(this.BALANCEACCOUNTID);
            historyForm.Show();

        }
        private void button_mainmenu_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
