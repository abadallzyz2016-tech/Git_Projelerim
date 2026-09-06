namespace LibrarySystem.Forms
{
    partial class Add_Book
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
            button_addbook_back = new Button();
            button_addbook_add = new Button();
            label_addmember_phone = new Label();
            label_addmember_lastname = new Label();
            text_addbook_category = new TextBox();
            label_addmember_firstname = new Label();
            text_addbook_author = new TextBox();
            text_addbook_title = new TextBox();
            label_addbook_head = new Label();
            text_addbook_pyear = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // button_addbook_back
            // 
            button_addbook_back.BackColor = Color.CadetBlue;
            button_addbook_back.Location = new Point(424, 407);
            button_addbook_back.Name = "button_addbook_back";
            button_addbook_back.Size = new Size(137, 39);
            button_addbook_back.TabIndex = 6;
            button_addbook_back.Text = "Back";
            button_addbook_back.UseVisualStyleBackColor = false;
            button_addbook_back.Click += button_addbook_back_Click;
            // 
            // button_addbook_add
            // 
            button_addbook_add.BackColor = Color.CadetBlue;
            button_addbook_add.Location = new Point(227, 354);
            button_addbook_add.Name = "button_addbook_add";
            button_addbook_add.Size = new Size(140, 46);
            button_addbook_add.TabIndex = 5;
            button_addbook_add.Text = "Add ";
            button_addbook_add.UseVisualStyleBackColor = false;
            button_addbook_add.Click += button_addbook_add_Click;
            // 
            // label_addmember_phone
            // 
            label_addmember_phone.AutoSize = true;
            label_addmember_phone.ForeColor = Color.DarkCyan;
            label_addmember_phone.Location = new Point(24, 245);
            label_addmember_phone.Name = "label_addmember_phone";
            label_addmember_phone.Size = new Size(93, 23);
            label_addmember_phone.TabIndex = 8;
            label_addmember_phone.Text = "Category : ";
            // 
            // label_addmember_lastname
            // 
            label_addmember_lastname.AutoSize = true;
            label_addmember_lastname.ForeColor = Color.DarkCyan;
            label_addmember_lastname.Location = new Point(24, 192);
            label_addmember_lastname.Name = "label_addmember_lastname";
            label_addmember_lastname.Size = new Size(77, 23);
            label_addmember_lastname.TabIndex = 9;
            label_addmember_lastname.Text = "Author : ";
            // 
            // text_addbook_category
            // 
            text_addbook_category.BackColor = Color.CadetBlue;
            text_addbook_category.BorderStyle = BorderStyle.FixedSingle;
            text_addbook_category.Location = new Point(188, 243);
            text_addbook_category.Name = "text_addbook_category";
            text_addbook_category.Size = new Size(216, 30);
            text_addbook_category.TabIndex = 3;
            // 
            // label_addmember_firstname
            // 
            label_addmember_firstname.AutoSize = true;
            label_addmember_firstname.ForeColor = Color.DarkCyan;
            label_addmember_firstname.Location = new Point(24, 138);
            label_addmember_firstname.Name = "label_addmember_firstname";
            label_addmember_firstname.Size = new Size(56, 23);
            label_addmember_firstname.TabIndex = 10;
            label_addmember_firstname.Text = "Title : ";
            // 
            // text_addbook_author
            // 
            text_addbook_author.BackColor = Color.CadetBlue;
            text_addbook_author.BorderStyle = BorderStyle.FixedSingle;
            text_addbook_author.Location = new Point(188, 190);
            text_addbook_author.Name = "text_addbook_author";
            text_addbook_author.Size = new Size(216, 30);
            text_addbook_author.TabIndex = 2;
            // 
            // text_addbook_title
            // 
            text_addbook_title.BackColor = Color.CadetBlue;
            text_addbook_title.BorderStyle = BorderStyle.FixedSingle;
            text_addbook_title.Location = new Point(188, 136);
            text_addbook_title.Name = "text_addbook_title";
            text_addbook_title.Size = new Size(216, 30);
            text_addbook_title.TabIndex = 1;
            // 
            // label_addbook_head
            // 
            label_addbook_head.AutoSize = true;
            label_addbook_head.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_addbook_head.ForeColor = Color.DarkCyan;
            label_addbook_head.Location = new Point(216, 30);
            label_addbook_head.Name = "label_addbook_head";
            label_addbook_head.Size = new Size(149, 41);
            label_addbook_head.TabIndex = 4;
            label_addbook_head.Text = "Add Book";
            // 
            // text_addbook_pyear
            // 
            text_addbook_pyear.BackColor = Color.CadetBlue;
            text_addbook_pyear.BorderStyle = BorderStyle.FixedSingle;
            text_addbook_pyear.Location = new Point(188, 293);
            text_addbook_pyear.Name = "text_addbook_pyear";
            text_addbook_pyear.Size = new Size(216, 30);
            text_addbook_pyear.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.DarkCyan;
            label1.Location = new Point(24, 295);
            label1.Name = "label1";
            label1.Size = new Size(146, 23);
            label1.TabIndex = 8;
            label1.Text = "Publication Year : ";
            // 
            // Add_Book
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(582, 483);
            Controls.Add(button_addbook_back);
            Controls.Add(button_addbook_add);
            Controls.Add(label1);
            Controls.Add(label_addmember_phone);
            Controls.Add(label_addmember_lastname);
            Controls.Add(text_addbook_pyear);
            Controls.Add(text_addbook_category);
            Controls.Add(label_addmember_firstname);
            Controls.Add(text_addbook_author);
            Controls.Add(text_addbook_title);
            Controls.Add(label_addbook_head);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "Add_Book";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add_Book";
            Load += Add_Book_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_addbook_back;
        private Button button_addbook_add;
        public TextBox text_addbook_title;
        public TextBox text_addbook_author;
        public TextBox text_addbook_category;
        public TextBox text_addbook_pyear;
        private Label label_addmember_lastname;
        private Label label_addmember_phone;
        private Label label_addmember_firstname;
        private Label label_addbook_head;
        private Label label1;
    }
}