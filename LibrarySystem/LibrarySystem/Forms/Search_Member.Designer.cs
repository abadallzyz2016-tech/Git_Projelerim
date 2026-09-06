namespace LibrarySystem.Forms
{
    partial class Search_Member
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
            button_searchmember_back = new Button();
            button_searchmember_search = new Button();
            label_searchmember_regdate = new Label();
            label_searchmember_lastname = new Label();
            label_searchmember_id = new Label();
            label_searchmember_phone = new Label();
            label_searchmember_firstname = new Label();
            text_searchmember_lastname = new TextBox();
            text_searchmember_id = new TextBox();
            text_searchmember_firstname = new TextBox();
            label_searchmember_head = new Label();
            text_searchmember_phone = new TextBox();
            text_searchmember_regdate = new TextBox();
            SuspendLayout();
            // 
            // button_searchmember_back
            // 
            button_searchmember_back.BackColor = Color.CadetBlue;
            button_searchmember_back.Location = new Point(462, 442);
            button_searchmember_back.Name = "button_searchmember_back";
            button_searchmember_back.Size = new Size(124, 40);
            button_searchmember_back.TabIndex = 17;
            button_searchmember_back.Text = "Back";
            button_searchmember_back.UseVisualStyleBackColor = false;
            button_searchmember_back.Click += button_searchmember_back_Click;
            // 
            // button_searchmember_search
            // 
            button_searchmember_search.BackColor = Color.CadetBlue;
            button_searchmember_search.Location = new Point(239, 397);
            button_searchmember_search.Name = "button_searchmember_search";
            button_searchmember_search.Size = new Size(124, 40);
            button_searchmember_search.TabIndex = 16;
            button_searchmember_search.Text = "Search";
            button_searchmember_search.UseVisualStyleBackColor = false;
            button_searchmember_search.Click += button_searchmember_search_Click;
            // 
            // label_searchmember_regdate
            // 
            label_searchmember_regdate.AutoSize = true;
            label_searchmember_regdate.ForeColor = Color.DarkCyan;
            label_searchmember_regdate.Location = new Point(23, 333);
            label_searchmember_regdate.Name = "label_searchmember_regdate";
            label_searchmember_regdate.Size = new Size(109, 23);
            label_searchmember_regdate.TabIndex = 24;
            label_searchmember_regdate.Text = "Regis. Date : ";
            // 
            // label_searchmember_lastname
            // 
            label_searchmember_lastname.AutoSize = true;
            label_searchmember_lastname.ForeColor = Color.DarkCyan;
            label_searchmember_lastname.Location = new Point(23, 238);
            label_searchmember_lastname.Name = "label_searchmember_lastname";
            label_searchmember_lastname.Size = new Size(105, 23);
            label_searchmember_lastname.TabIndex = 25;
            label_searchmember_lastname.Text = "Last Name : ";
            // 
            // label_searchmember_id
            // 
            label_searchmember_id.AutoSize = true;
            label_searchmember_id.ForeColor = Color.DarkCyan;
            label_searchmember_id.Location = new Point(23, 119);
            label_searchmember_id.Name = "label_searchmember_id";
            label_searchmember_id.Size = new Size(110, 23);
            label_searchmember_id.TabIndex = 26;
            label_searchmember_id.Text = "Member ID : ";
            // 
            // label_searchmember_phone
            // 
            label_searchmember_phone.AutoSize = true;
            label_searchmember_phone.ForeColor = Color.DarkCyan;
            label_searchmember_phone.Location = new Point(23, 286);
            label_searchmember_phone.Name = "label_searchmember_phone";
            label_searchmember_phone.Size = new Size(73, 23);
            label_searchmember_phone.TabIndex = 27;
            label_searchmember_phone.Text = "Phone : ";
            // 
            // label_searchmember_firstname
            // 
            label_searchmember_firstname.AutoSize = true;
            label_searchmember_firstname.ForeColor = Color.DarkCyan;
            label_searchmember_firstname.Location = new Point(23, 191);
            label_searchmember_firstname.Name = "label_searchmember_firstname";
            label_searchmember_firstname.Size = new Size(106, 23);
            label_searchmember_firstname.TabIndex = 28;
            label_searchmember_firstname.Text = "First Name : ";
            // 
            // text_searchmember_lastname
            // 
            text_searchmember_lastname.BackColor = Color.CadetBlue;
            text_searchmember_lastname.BorderStyle = BorderStyle.FixedSingle;
            text_searchmember_lastname.Location = new Point(146, 236);
            text_searchmember_lastname.Name = "text_searchmember_lastname";
            text_searchmember_lastname.ReadOnly = true;
            text_searchmember_lastname.Size = new Size(192, 30);
            text_searchmember_lastname.TabIndex = 20;
            // 
            // text_searchmember_id
            // 
            text_searchmember_id.BackColor = Color.CadetBlue;
            text_searchmember_id.BorderStyle = BorderStyle.FixedSingle;
            text_searchmember_id.Location = new Point(146, 117);
            text_searchmember_id.Name = "text_searchmember_id";
            text_searchmember_id.Size = new Size(192, 30);
            text_searchmember_id.TabIndex = 15;
            // 
            // text_searchmember_firstname
            // 
            text_searchmember_firstname.BackColor = Color.CadetBlue;
            text_searchmember_firstname.BorderStyle = BorderStyle.FixedSingle;
            text_searchmember_firstname.Location = new Point(146, 189);
            text_searchmember_firstname.Name = "text_searchmember_firstname";
            text_searchmember_firstname.ReadOnly = true;
            text_searchmember_firstname.Size = new Size(192, 30);
            text_searchmember_firstname.TabIndex = 22;
            // 
            // label_searchmember_head
            // 
            label_searchmember_head.AutoSize = true;
            label_searchmember_head.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_searchmember_head.ForeColor = Color.DarkCyan;
            label_searchmember_head.Location = new Point(218, 21);
            label_searchmember_head.Name = "label_searchmember_head";
            label_searchmember_head.Size = new Size(227, 41);
            label_searchmember_head.TabIndex = 14;
            label_searchmember_head.Text = "Search Member";
            // 
            // text_searchmember_phone
            // 
            text_searchmember_phone.BackColor = Color.CadetBlue;
            text_searchmember_phone.BorderStyle = BorderStyle.FixedSingle;
            text_searchmember_phone.Location = new Point(146, 286);
            text_searchmember_phone.Name = "text_searchmember_phone";
            text_searchmember_phone.ReadOnly = true;
            text_searchmember_phone.Size = new Size(192, 30);
            text_searchmember_phone.TabIndex = 22;
            // 
            // text_searchmember_regdate
            // 
            text_searchmember_regdate.BackColor = Color.CadetBlue;
            text_searchmember_regdate.BorderStyle = BorderStyle.FixedSingle;
            text_searchmember_regdate.Location = new Point(146, 333);
            text_searchmember_regdate.Name = "text_searchmember_regdate";
            text_searchmember_regdate.ReadOnly = true;
            text_searchmember_regdate.Size = new Size(192, 30);
            text_searchmember_regdate.TabIndex = 20;
            // 
            // Search_Member
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(614, 503);
            Controls.Add(button_searchmember_back);
            Controls.Add(button_searchmember_search);
            Controls.Add(label_searchmember_regdate);
            Controls.Add(label_searchmember_lastname);
            Controls.Add(label_searchmember_id);
            Controls.Add(label_searchmember_phone);
            Controls.Add(label_searchmember_firstname);
            Controls.Add(text_searchmember_regdate);
            Controls.Add(text_searchmember_lastname);
            Controls.Add(text_searchmember_id);
            Controls.Add(text_searchmember_phone);
            Controls.Add(text_searchmember_firstname);
            Controls.Add(label_searchmember_head);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "Search_Member";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Search_Member";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_searchmember_back;
        private Button button_searchmember_search;
        public TextBox text_searchmember_id;
        public TextBox text_searchmember_firstname;
        public TextBox text_searchmember_lastname;
        public TextBox text_searchmember_phone;
        public TextBox text_searchmember_regdate;
        private Label label_searchmember_head;
        private Label label_searchmember_regdate;
        private Label label_searchmember_lastname;
        private Label label_searchmember_id;
        private Label label_searchmember_phone;
        private Label label_searchmember_firstname;
    }
}