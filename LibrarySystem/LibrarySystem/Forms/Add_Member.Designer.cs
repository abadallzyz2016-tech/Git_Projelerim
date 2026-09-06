namespace LibrarySystem.Forms
{
    partial class Add_Member
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
            label_addmember_head = new Label();
            text_addmember_firstname = new TextBox();
            label_addmember_firstname = new Label();
            text_addmember_lastname = new TextBox();
            label_addmember_lastname = new Label();
            text_addmember_phone = new TextBox();
            label_addmember_phone = new Label();
            button_addmember_add = new Button();
            button_addmember_back = new Button();
            SuspendLayout();
            // 
            // label_addmember_head
            // 
            label_addmember_head.AutoSize = true;
            label_addmember_head.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_addmember_head.ForeColor = Color.DarkCyan;
            label_addmember_head.Location = new Point(192, 28);
            label_addmember_head.Name = "label_addmember_head";
            label_addmember_head.Size = new Size(202, 41);
            label_addmember_head.TabIndex = 0;
            label_addmember_head.Text = "Add Member ";
            // 
            // text_addmember_firstname
            // 
            text_addmember_firstname.BackColor = Color.CadetBlue;
            text_addmember_firstname.BorderStyle = BorderStyle.FixedSingle;
            text_addmember_firstname.Location = new Point(159, 186);
            text_addmember_firstname.Name = "text_addmember_firstname";
            text_addmember_firstname.Size = new Size(192, 30);
            text_addmember_firstname.TabIndex = 1;
            text_addmember_firstname.TextChanged += text_addmember_firstname_TextChanged;
            // 
            // label_addmember_firstname
            // 
            label_addmember_firstname.AutoSize = true;
            label_addmember_firstname.ForeColor = Color.DarkCyan;
            label_addmember_firstname.Location = new Point(35, 188);
            label_addmember_firstname.Name = "label_addmember_firstname";
            label_addmember_firstname.Size = new Size(106, 23);
            label_addmember_firstname.TabIndex = 2;
            label_addmember_firstname.Text = "First Name : ";
            // 
            // text_addmember_lastname
            // 
            text_addmember_lastname.BackColor = Color.CadetBlue;
            text_addmember_lastname.BorderStyle = BorderStyle.FixedSingle;
            text_addmember_lastname.Location = new Point(159, 233);
            text_addmember_lastname.Name = "text_addmember_lastname";
            text_addmember_lastname.Size = new Size(192, 30);
            text_addmember_lastname.TabIndex = 2;
            // 
            // label_addmember_lastname
            // 
            label_addmember_lastname.AutoSize = true;
            label_addmember_lastname.ForeColor = Color.DarkCyan;
            label_addmember_lastname.Location = new Point(35, 235);
            label_addmember_lastname.Name = "label_addmember_lastname";
            label_addmember_lastname.Size = new Size(105, 23);
            label_addmember_lastname.TabIndex = 2;
            label_addmember_lastname.Text = "Last Name : ";
            // 
            // text_addmember_phone
            // 
            text_addmember_phone.BackColor = Color.CadetBlue;
            text_addmember_phone.BorderStyle = BorderStyle.FixedSingle;
            text_addmember_phone.Location = new Point(159, 279);
            text_addmember_phone.Name = "text_addmember_phone";
            text_addmember_phone.Size = new Size(192, 30);
            text_addmember_phone.TabIndex = 3;
            // 
            // label_addmember_phone
            // 
            label_addmember_phone.AutoSize = true;
            label_addmember_phone.ForeColor = Color.DarkCyan;
            label_addmember_phone.Location = new Point(35, 281);
            label_addmember_phone.Name = "label_addmember_phone";
            label_addmember_phone.Size = new Size(73, 23);
            label_addmember_phone.TabIndex = 2;
            label_addmember_phone.Text = "Phone : ";
            // 
            // button_addmember_add
            // 
            button_addmember_add.BackColor = Color.CadetBlue;
            button_addmember_add.Location = new Point(207, 368);
            button_addmember_add.Name = "button_addmember_add";
            button_addmember_add.Size = new Size(124, 40);
            button_addmember_add.TabIndex = 4;
            button_addmember_add.Text = "Add ";
            button_addmember_add.UseVisualStyleBackColor = false;
            button_addmember_add.Click += button_addmember_add_Click;
            // 
            // button_addmember_back
            // 
            button_addmember_back.BackColor = Color.CadetBlue;
            button_addmember_back.Location = new Point(434, 414);
            button_addmember_back.Name = "button_addmember_back";
            button_addmember_back.Size = new Size(124, 40);
            button_addmember_back.TabIndex = 5;
            button_addmember_back.Text = "Back";
            button_addmember_back.UseVisualStyleBackColor = false;
            button_addmember_back.Click += button_addmember_back_Click;
            // 
            // Add_Member
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(582, 483);
            Controls.Add(button_addmember_back);
            Controls.Add(button_addmember_add);
            Controls.Add(label_addmember_phone);
            Controls.Add(label_addmember_lastname);
            Controls.Add(text_addmember_phone);
            Controls.Add(label_addmember_firstname);
            Controls.Add(text_addmember_lastname);
            Controls.Add(text_addmember_firstname);
            Controls.Add(label_addmember_head);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "Add_Member";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add_Member";
            Load += Add_Member_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public TextBox text_addmember_firstname;
        public TextBox text_addmember_lastname;
        public TextBox text_addmember_phone;
        private Label label_addmember_firstname;
        private Label label_addmember_lastname;
        private Label label_addmember_head;
        private Label label_addmember_phone;
        private Button button_addmember_add;
        private Button button_addmember_back;
    }
}