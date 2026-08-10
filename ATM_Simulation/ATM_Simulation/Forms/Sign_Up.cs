using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ATM_Simulasyonu.Forms
{
    public partial class Sign_Up : Form
    {
        public Sign_Up()
        {
            InitializeComponent();
        }
        private void button_signup_Click(object sender, EventArgs e)
        {
            if ((string.IsNullOrEmpty(text_signup_name.Text)) ||
                (string.IsNullOrEmpty(text_signup_identityno.Text)) ||
                (string.IsNullOrEmpty(text_signup_phoneno.Text)) ||
                (string.IsNullOrEmpty(text_signup_email.Text)) ||
                (string.IsNullOrEmpty(text_signup_password.Text)) ||
                (string.IsNullOrEmpty(text_signup_username.Text)))
            {
                Console.WriteLine("Please fill in all fields.");
            }
            else
            {
                string olusturulmaTarihi = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                Directory.CreateDirectory($@"A:" + @"\ATM_Simulasyonu");
                string filePath = $@"A:\ATM_Simulasyonu\" + "Sign_Up.txt";
                if (!File.Exists(filePath))
                {
                    File.WriteAllText(filePath,
                    "Name|IdentityNumber|PhoneNumber|Email|Password|UserName|AccountID|CreationDate" + Environment.NewLine);

                }
                Random random = new Random();
                double accountID = random.Next(100_000_000,1000_000_000);
                File.AppendAllText(filePath, 
                    $"{text_signup_name.Text.ToUpper()}|" +
                    $"{text_signup_identityno.Text}|" +
                    $"{text_signup_phoneno.Text}|" +
                    $"{text_signup_email.Text}|" +
                    $"{text_signup_password.Text}|" +
                    $"{text_signup_username.Text.ToUpper()}|" +
                    $"{accountID}|" +
                    $"{olusturulmaTarihi}{Environment.NewLine}");

                // balance root and files
                double balance = 0.0;
                string userPath = $@"A:\ATM_Simulasyonu\Users";
                Directory.CreateDirectory(userPath);
                string accountIDPath = Path.Combine(userPath, $"{accountID}.txt");
                File.WriteAllText(accountIDPath, balance.ToString());
                MessageBox.Show($"Account Created Successfully! Your account ID : {accountID}");
                this.Close();

                Form_Login loginForm = new Form_Login();
                loginForm.Show();

                
            }
        }

        private void label_signup_identitynumber_Click(object sender, EventArgs e)
        {


        }
        private void label_signup_phonenumber_Click(object sender, EventArgs e)
        {

        }
        private void label_signup_email_Click(object sender, EventArgs e)
        {
        }
        private void label_signup_password_Click(object sender, EventArgs e)
        {
        }
        private void label_signup_password2_Click(object sender, EventArgs e)
        {
        }

        private void label_signup_name_Click(object sender, EventArgs e)
        {
        }
        private void text_signup_name_TextChanged(object sender, EventArgs e)
        {
        }
        private void text_signup_identityno_TextChanged(object sender, EventArgs e)
        {

        }
        private void text_signup_phoneno_TextChanged(object sender, EventArgs e)
        {

        }
        private void text_signup_email_TextChanged(object sender, EventArgs e)
        {
        }
        private void text_signup_password_TextChanged(object sender, EventArgs e)
        {
        }
        private void text_signup_username_TextChanged(object sender, EventArgs e)
        {
        }
        private void Sign_Up_Load(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_signup_back_Click_1(object sender, EventArgs e)
        {
            Form_Login loginForm = new Form_Login();
            this.Close();
            loginForm.Show();
        }
    }
}
