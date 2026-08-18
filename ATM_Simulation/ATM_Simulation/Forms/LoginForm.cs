using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ATM_Simulasyonu
{
    public partial class Form_Login : Form
    {
        public Form_Login()
        {
            InitializeComponent();
        }
        private void label1_Click(object sender, EventArgs e)
        {
            // Handle label click event if needed
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(text_login_username.Text) && string.IsNullOrEmpty(text_login_password.Text))
            {
                MessageBox.Show("Please enter both username and password.");
            }
            else if (!string.IsNullOrEmpty(text_login_username.Text) && !string.IsNullOrEmpty(text_login_password.Text))
            {
                try
                {
                    string filePath = $@"A:\ATM_Simulasyonu\Sign_Up.txt";
                    if (!File.Exists(filePath))
                    {
                        MessageBox.Show("No user data found. Please sign up first.");
                        return;
                    }
                    string balanceAccountID = string.Empty;
                    bool isAuthenticated = false;
                    using (StreamReader reader = new StreamReader(filePath))
                    {
                        string line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            string[] parts = line.Split('|');
                            if (parts.Length >= 6)
                            {
                                string username = parts[5];
                                string password = parts[4];
                                if (username == text_login_username.Text.ToUpper() && password == text_login_password.Text.ToUpper())
                                {
                                    balanceAccountID = parts[6].ToString();
                                    isAuthenticated = true;
                                    break;
                                }
                            }
                        }
                    }
                    if (isAuthenticated)
                    {
                        MessageBox.Show("Login successful!");
                        string username = text_login_username.Text.ToUpper();

                        text_login_password.Text = "";
                        text_login_username.Text = "";
                        Forms.MainMenu mainMenuForm = new Forms.MainMenu(username);
                        mainMenuForm.Show();
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred during login: {ex.Message}");
                }
            }

            else
            {
                string filePath = $@"A:\ATM_Simulasyonu\" + "Sign_Up.txt";
                if (!File.Exists(filePath))
                {
                    MessageBox.Show("No user data found. Please sign up first.");
                    return;
                }
                bool isAuthenticated = false;
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] parts = line.Split('|');
                        if (parts.Length >= 8)
                        {
                            string username = parts[5];
                            string password = parts[4];
                            if (username == text_login_username.Text.ToUpper() && password == text_login_password.Text.ToUpper())
                            {
                                isAuthenticated = true;
                                break;
                            }
                        }
                    }
                }
                if (isAuthenticated)
                {
                    MessageBox.Show("Login successful!");
                    string username = text_login_username.Text.ToUpper();   
                    Forms.MainMenu mainMenuForm = new Forms.MainMenu(username);
                    mainMenuForm.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Invalid username or password.");
                }
            }
        }
        private void button_login_signup_Click(object sender, EventArgs e)
        {

            Forms.Sign_Up signUpForm = new Forms.Sign_Up();
            signUpForm.ShowDialog();
            this.Show();
        }

        private void Form_Login_Load(object sender, EventArgs e)
        {

        }
        private void button_login_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

