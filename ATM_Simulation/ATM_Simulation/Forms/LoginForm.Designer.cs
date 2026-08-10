namespace ATM_Simulasyonu
{
    partial class Form_Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            
            label1 = new Label();
            label_login_username = new Label();
            label_login_password = new Label();
            text_login_username = new TextBox();
            button_login = new Button();
            button_login_signup = new Button();
            button_login_exit = new Button();
            text_login_password = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(280, 19);
            label1.Name = "label1";
            label1.Size = new Size(138, 43);
            label1.TabIndex = 0;
            label1.Text = "Aea ATM";
            label1.Click += label1_Click;
            // 
            // label_login_username
            // 
            label_login_username.AutoSize = true;
            label_login_username.BorderStyle = BorderStyle.Fixed3D;
            label_login_username.Location = new Point(162, 103);
            label_login_username.Name = "label_login_username";
            label_login_username.Size = new Size(80, 22);
            label_login_username.TabIndex = 1;
            label_login_username.Text = "UserName";
            // 
            // label_login_password
            // 
            label_login_password.AutoSize = true;
            label_login_password.BorderStyle = BorderStyle.Fixed3D;
            label_login_password.Location = new Point(162, 133);
            label_login_password.Name = "label_login_password";
            label_login_password.Size = new Size(72, 22);
            label_login_password.TabIndex = 1;
            label_login_password.Text = "Password";
            // 
            // text_login_username
            // 
            text_login_username.BorderStyle = BorderStyle.FixedSingle;
            text_login_username.Location = new Point(266, 100);
            text_login_username.Name = "text_login_username";
            text_login_username.Size = new Size(182, 27);
            text_login_username.TabIndex = 1;
            // 
            // button_login
            // 
            button_login.FlatStyle = FlatStyle.Popup;
            button_login.Location = new Point(248, 197);
            button_login.Name = "button_login";
            button_login.Size = new Size(100, 29);
            button_login.TabIndex = 3;
            button_login.Text = "Login";
            button_login.UseVisualStyleBackColor = true;
            button_login.Click += button_login_Click;
            // 
            // button_login_signup
            // 
            button_login_signup.FlatStyle = FlatStyle.Popup;
            button_login_signup.Location = new Point(354, 197);
            button_login_signup.Name = "button_login_signup";
            button_login_signup.Size = new Size(108, 29);
            button_login_signup.TabIndex = 4;
            button_login_signup.Text = "Signup";
            button_login_signup.UseVisualStyleBackColor = true;
            button_login_signup.Click += button_login_signup_Click;
            // 
            // button_login_exit
            // 
            button_login_exit.FlatStyle = FlatStyle.Popup;
            button_login_exit.Location = new Point(37, 259);
            button_login_exit.Name = "button_login_exit";
            button_login_exit.Size = new Size(100, 29);
            button_login_exit.TabIndex = 5;
            button_login_exit.Text = "Exit";
            button_login_exit.UseVisualStyleBackColor = true;
            button_login_exit.Click += button_login_exit_Click;
            // 
            // text_login_password
            // 
            text_login_password.BorderStyle = BorderStyle.FixedSingle;
            text_login_password.Location = new Point(266, 133);
            text_login_password.Name = "text_login_password";
            text_login_password.Size = new Size(182, 27);
            text_login_password.TabIndex = 2;
            // 
            // Form_Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(659, 323);
            Controls.Add(button_login_signup);
            Controls.Add(button_login_exit);
            Controls.Add(button_login);
            Controls.Add(text_login_password);
            Controls.Add(text_login_username);
            Controls.Add(label_login_password);
            Controls.Add(label_login_username);
            Controls.Add(label1);
            Name = "Form_Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login ";
            Load += Form_Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label_login_username;
        private Label label_login_password;
        private TextBox text_login_username;
        private TextBox text_login_password;
        private Button button_login;
        private Button button_login_signup;
        private Button button_login_exit;
    }
}
