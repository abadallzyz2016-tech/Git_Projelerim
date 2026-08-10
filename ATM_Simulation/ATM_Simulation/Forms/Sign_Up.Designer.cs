namespace ATM_Simulasyonu.Forms
{
    partial class Sign_Up
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label_signup_name = new Label();
            label_signup_identitynumber = new Label();
            label_signup_phonenumber = new Label();
            label_signup_email = new Label();
            label_signup_password = new Label();
            text_signup_name = new TextBox();
            text_signup_identityno = new TextBox();
            text_signup_phoneno = new TextBox();
            text_signup_email = new TextBox();
            text_signup_password = new TextBox();
            label_signup_username = new Label();
            text_signup_username = new TextBox();
            button_signup = new Button();
            button_signup_back = new Button();
            label_signup_aeaatm = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(276, 98);
            label1.Name = "label1";
            label1.Size = new Size(101, 33);
            label1.TabIndex = 0;
            label1.Text = "Sign_Up";
            label1.Click += label1_Click;
            // 
            // label_signup_name
            // 
            label_signup_name.AutoSize = true;
            label_signup_name.BorderStyle = BorderStyle.Fixed3D;
            label_signup_name.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_signup_name.Location = new Point(124, 159);
            label_signup_name.Name = "label_signup_name";
            label_signup_name.Size = new Size(58, 25);
            label_signup_name.TabIndex = 0;
            label_signup_name.Text = "Name";
            // 
            // label_signup_identitynumber
            // 
            label_signup_identitynumber.AutoSize = true;
            label_signup_identitynumber.BorderStyle = BorderStyle.Fixed3D;
            label_signup_identitynumber.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_signup_identitynumber.Location = new Point(120, 194);
            label_signup_identitynumber.Name = "label_signup_identitynumber";
            label_signup_identitynumber.Size = new Size(107, 25);
            label_signup_identitynumber.TabIndex = 0;
            label_signup_identitynumber.Text = "Identity No. ";
            label_signup_identitynumber.Click += label_signup_identitynumber_Click;
            // 
            // label_signup_phonenumber
            // 
            label_signup_phonenumber.AutoSize = true;
            label_signup_phonenumber.BorderStyle = BorderStyle.Fixed3D;
            label_signup_phonenumber.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_signup_phonenumber.Location = new Point(120, 260);
            label_signup_phonenumber.Name = "label_signup_phonenumber";
            label_signup_phonenumber.Size = new Size(93, 25);
            label_signup_phonenumber.TabIndex = 0;
            label_signup_phonenumber.Text = "Phone No.";
            label_signup_phonenumber.Click += label_signup_phonenumber_Click;
            // 
            // label_signup_email
            // 
            label_signup_email.AutoSize = true;
            label_signup_email.BorderStyle = BorderStyle.Fixed3D;
            label_signup_email.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_signup_email.Location = new Point(120, 290);
            label_signup_email.Name = "label_signup_email";
            label_signup_email.Size = new Size(60, 25);
            label_signup_email.TabIndex = 0;
            label_signup_email.Text = "E-mail";
            label_signup_email.Click += label_signup_email_Click;
            // 
            // label_signup_password
            // 
            label_signup_password.AutoSize = true;
            label_signup_password.BorderStyle = BorderStyle.Fixed3D;
            label_signup_password.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_signup_password.Location = new Point(120, 324);
            label_signup_password.Name = "label_signup_password";
            label_signup_password.Size = new Size(83, 25);
            label_signup_password.TabIndex = 0;
            label_signup_password.Text = "password";
            label_signup_password.Click += label_signup_password_Click;
            // 
            // text_signup_name
            // 
            text_signup_name.BorderStyle = BorderStyle.FixedSingle;
            text_signup_name.Location = new Point(245, 156);
            text_signup_name.Name = "text_signup_name";
            text_signup_name.Size = new Size(232, 27);
            text_signup_name.TabIndex = 1;
            // 
            // text_signup_identityno
            // 
            text_signup_identityno.BorderStyle = BorderStyle.FixedSingle;
            text_signup_identityno.Location = new Point(245, 191);
            text_signup_identityno.Name = "text_signup_identityno";
            text_signup_identityno.Size = new Size(232, 27);
            text_signup_identityno.TabIndex = 2;
            // 
            // text_signup_phoneno
            // 
            text_signup_phoneno.BorderStyle = BorderStyle.FixedSingle;
            text_signup_phoneno.Location = new Point(244, 257);
            text_signup_phoneno.Name = "text_signup_phoneno";
            text_signup_phoneno.Size = new Size(232, 27);
            text_signup_phoneno.TabIndex = 4;
            text_signup_phoneno.TextChanged += text_signup_phoneno_TextChanged;
            // 
            // text_signup_email
            // 
            text_signup_email.BorderStyle = BorderStyle.FixedSingle;
            text_signup_email.Location = new Point(244, 290);
            text_signup_email.Name = "text_signup_email";
            text_signup_email.Size = new Size(232, 27);
            text_signup_email.TabIndex = 5;
            text_signup_email.TextChanged += text_signup_email_TextChanged;
            // 
            // text_signup_password
            // 
            text_signup_password.BorderStyle = BorderStyle.FixedSingle;
            text_signup_password.Location = new Point(244, 324);
            text_signup_password.Name = "text_signup_password";
            text_signup_password.Size = new Size(232, 27);
            text_signup_password.TabIndex = 6;
            text_signup_password.TextChanged += text_signup_password_TextChanged;
            // 
            // label_signup_username
            // 
            label_signup_username.AutoSize = true;
            label_signup_username.BorderStyle = BorderStyle.Fixed3D;
            label_signup_username.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_signup_username.Location = new Point(120, 227);
            label_signup_username.Name = "label_signup_username";
            label_signup_username.Size = new Size(92, 25);
            label_signup_username.TabIndex = 0;
            label_signup_username.Text = "UserName";
            label_signup_username.Click += label_signup_password2_Click;
            // 
            // text_signup_username
            // 
            text_signup_username.BorderStyle = BorderStyle.FixedSingle;
            text_signup_username.Location = new Point(244, 224);
            text_signup_username.Name = "text_signup_username";
            text_signup_username.Size = new Size(232, 27);
            text_signup_username.TabIndex = 3;
            text_signup_username.TextChanged += text_signup_username_TextChanged;
            // 
            // button_signup
            // 
            button_signup.FlatStyle = FlatStyle.Popup;
            button_signup.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_signup.Location = new Point(302, 376);
            button_signup.Name = "button_signup";
            button_signup.Size = new Size(110, 39);
            button_signup.TabIndex = 7;
            button_signup.Text = "Sign up";
            button_signup.UseVisualStyleBackColor = true;
            button_signup.Click += button_signup_Click;
            // 
            // button_signup_back
            // 
            button_signup_back.FlatStyle = FlatStyle.Popup;
            button_signup_back.Location = new Point(555, 392);
            button_signup_back.Name = "button_signup_back";
            button_signup_back.Size = new Size(72, 35);
            button_signup_back.TabIndex = 8;
            button_signup_back.Text = " Back";
            button_signup_back.UseVisualStyleBackColor = true;
            button_signup_back.Click += button_signup_back_Click_1;
            // 
            // label_signup_aeaatm
            // 
            label_signup_aeaatm.AutoSize = true;
            label_signup_aeaatm.BorderStyle = BorderStyle.Fixed3D;
            label_signup_aeaatm.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_signup_aeaatm.Location = new Point(263, 23);
            label_signup_aeaatm.Name = "label_signup_aeaatm";
            label_signup_aeaatm.Size = new Size(138, 43);
            label_signup_aeaatm.TabIndex = 9;
            label_signup_aeaatm.Text = "Aea ATM";
            // 
            // Sign_Up
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(661, 463);
            Controls.Add(label_signup_aeaatm);
            Controls.Add(button_signup_back);
            Controls.Add(button_signup);
            Controls.Add(text_signup_username);
            Controls.Add(text_signup_password);
            Controls.Add(text_signup_email);
            Controls.Add(text_signup_identityno);
            Controls.Add(text_signup_phoneno);
            Controls.Add(label_signup_username);
            Controls.Add(text_signup_name);
            Controls.Add(label_signup_password);
            Controls.Add(label_signup_phonenumber);
            Controls.Add(label_signup_name);
            Controls.Add(label_signup_email);
            Controls.Add(label_signup_identitynumber);
            Controls.Add(label1);
            Name = "Sign_Up";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sign_Up";
            Load += Sign_Up_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label_signup_name;
        private Label label_signup_identitynumber;
        private Label label_signup_phonenumber;
        private Label label_signup_email;
        private Label label_signup_password;
        private TextBox text_signup_name;
        private TextBox text_signup_identityno;
        private TextBox text_signup_phoneno;
        private TextBox text_signup_email;
        private TextBox text_signup_password;
        private Label label_signup_username;
        private TextBox text_signup_username;
        private Button button_signup;
        private Button button_signup_back;
        private Label label_signup_aeaatm;
    }
}