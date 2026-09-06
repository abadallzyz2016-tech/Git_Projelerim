namespace LibrarySystem.Forms
{
    partial class Delete_Member
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
            label_deletemember_lastname = new Label();
            label_deletemember_firstname = new Label();
            text_deletemember_lastname = new TextBox();
            text_deletemember_firstname = new TextBox();
            label_deletemember_head = new Label();
            button_deletemember_back = new Button();
            button_deletemember_delete = new Button();
            SuspendLayout();
            // 
            // label_deletemember_lastname
            // 
            label_deletemember_lastname.AutoSize = true;
            label_deletemember_lastname.ForeColor = Color.DarkCyan;
            label_deletemember_lastname.Location = new Point(46, 192);
            label_deletemember_lastname.Name = "label_deletemember_lastname";
            label_deletemember_lastname.Size = new Size(105, 23);
            label_deletemember_lastname.TabIndex = 6;
            label_deletemember_lastname.Text = "Last Name : ";
            // 
            // label_deletemember_firstname
            // 
            label_deletemember_firstname.AutoSize = true;
            label_deletemember_firstname.ForeColor = Color.DarkCyan;
            label_deletemember_firstname.Location = new Point(46, 145);
            label_deletemember_firstname.Name = "label_deletemember_firstname";
            label_deletemember_firstname.Size = new Size(106, 23);
            label_deletemember_firstname.TabIndex = 7;
            label_deletemember_firstname.Text = "First Name : ";
            // 
            // text_deletemember_lastname
            // 
            text_deletemember_lastname.BackColor = Color.CadetBlue;
            text_deletemember_lastname.BorderStyle = BorderStyle.FixedSingle;
            text_deletemember_lastname.Location = new Point(170, 190);
            text_deletemember_lastname.Name = "text_deletemember_lastname";
            text_deletemember_lastname.Size = new Size(192, 30);
            text_deletemember_lastname.TabIndex = 2;
            // 
            // text_deletemember_firstname
            // 
            text_deletemember_firstname.BackColor = Color.CadetBlue;
            text_deletemember_firstname.BorderStyle = BorderStyle.FixedSingle;
            text_deletemember_firstname.Location = new Point(170, 143);
            text_deletemember_firstname.Name = "text_deletemember_firstname";
            text_deletemember_firstname.Size = new Size(192, 30);
            text_deletemember_firstname.TabIndex = 1;
            // 
            // label_deletemember_head
            // 
            label_deletemember_head.AutoSize = true;
            label_deletemember_head.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_deletemember_head.ForeColor = Color.DarkCyan;
            label_deletemember_head.Location = new Point(170, 29);
            label_deletemember_head.Name = "label_deletemember_head";
            label_deletemember_head.Size = new Size(225, 41);
            label_deletemember_head.TabIndex = 3;
            label_deletemember_head.Text = "Delete Member";
            // 
            // button_deletemember_back
            // 
            button_deletemember_back.BackColor = Color.CadetBlue;
            button_deletemember_back.Location = new Point(406, 332);
            button_deletemember_back.Name = "button_deletemember_back";
            button_deletemember_back.Size = new Size(124, 40);
            button_deletemember_back.TabIndex = 4;
            button_deletemember_back.Text = "Back";
            button_deletemember_back.UseVisualStyleBackColor = false;
            button_deletemember_back.Click += button_deletemember_back_Click;
            // 
            // button_deletemember_delete
            // 
            button_deletemember_delete.BackColor = Color.CadetBlue;
            button_deletemember_delete.Location = new Point(212, 283);
            button_deletemember_delete.Name = "button_deletemember_delete";
            button_deletemember_delete.Size = new Size(124, 40);
            button_deletemember_delete.TabIndex = 3;
            button_deletemember_delete.Text = "Delete";
            button_deletemember_delete.UseVisualStyleBackColor = false;
            button_deletemember_delete.Click += button_deletemember_delete_Click;
            // 
            // Delete_Member
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(572, 397);
            Controls.Add(button_deletemember_back);
            Controls.Add(button_deletemember_delete);
            Controls.Add(label_deletemember_lastname);
            Controls.Add(label_deletemember_firstname);
            Controls.Add(text_deletemember_lastname);
            Controls.Add(text_deletemember_firstname);
            Controls.Add(label_deletemember_head);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "Delete_Member";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Delete_Member";
            Load += Delete_Member_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public TextBox text_deletemember_firstname;
        public TextBox text_deletemember_lastname;
        private Label label_deletemember_lastname;
        private Label label_deletemember_firstname;
        private Label label_deletemember_head;
        private Button button_deletemember_back;
        private Button button_deletemember_delete;
    }
}