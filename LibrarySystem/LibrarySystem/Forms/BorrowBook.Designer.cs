namespace LibrarySystem.Forms
{
    partial class BorrowBook
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
            label_borrowbook_head = new Label();
            button_borrowbook_back = new Button();
            button_borrowbook_borrow = new Button();
            label_borrowbook_pyear = new Label();
            label_borrowbook_category = new Label();
            label_borrowbook_author = new Label();
            text_borrowbook_pyear = new TextBox();
            text_borrowbook_category = new TextBox();
            label_borrowbook_id = new Label();
            text_borrowbook_author = new TextBox();
            text_borrowbook_title = new TextBox();
            text_borrowbook_id = new TextBox();
            label_borrowbook_title = new Label();
            text_borrowbook_firstname = new TextBox();
            text_borrowbook_lastname = new TextBox();
            label_borrowbook_firstname = new Label();
            text_borrowbook_phone = new TextBox();
            text_borrowbook_reg = new TextBox();
            label_borrowbook_lastname = new Label();
            label_borrowbook_phone = new Label();
            label_borrowbook_reg = new Label();
            text_borrowbook_memberid = new TextBox();
            label_borrowbook_memberid = new Label();
            text_borrowbook_isavailable = new TextBox();
            label_borrowbook_isavailable = new Label();
            button_borrowbook_check = new Button();
            SuspendLayout();
            // 
            // label_borrowbook_head
            // 
            label_borrowbook_head.AutoSize = true;
            label_borrowbook_head.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_borrowbook_head.Location = new Point(436, 29);
            label_borrowbook_head.Name = "label_borrowbook_head";
            label_borrowbook_head.Size = new Size(212, 41);
            label_borrowbook_head.TabIndex = 0;
            label_borrowbook_head.Text = "Borrow a Book";
            // 
            // button_borrowbook_back
            // 
            button_borrowbook_back.BackColor = Color.CadetBlue;
            button_borrowbook_back.Location = new Point(979, 488);
            button_borrowbook_back.Name = "button_borrowbook_back";
            button_borrowbook_back.Size = new Size(137, 39);
            button_borrowbook_back.TabIndex = 16;
            button_borrowbook_back.Text = "Back";
            button_borrowbook_back.UseVisualStyleBackColor = false;
            button_borrowbook_back.Click += button_borrowbook_back_Click;
            // 
            // button_borrowbook_borrow
            // 
            button_borrowbook_borrow.BackColor = Color.CadetBlue;
            button_borrowbook_borrow.Location = new Point(612, 449);
            button_borrowbook_borrow.Name = "button_borrowbook_borrow";
            button_borrowbook_borrow.Size = new Size(140, 46);
            button_borrowbook_borrow.TabIndex = 15;
            button_borrowbook_borrow.Text = "Borrow";
            button_borrowbook_borrow.UseVisualStyleBackColor = false;
            button_borrowbook_borrow.Click += button_borrowbook_borrow_Click;
            // 
            // label_borrowbook_pyear
            // 
            label_borrowbook_pyear.AutoSize = true;
            label_borrowbook_pyear.ForeColor = Color.DarkCyan;
            label_borrowbook_pyear.Location = new Point(33, 326);
            label_borrowbook_pyear.Name = "label_borrowbook_pyear";
            label_borrowbook_pyear.Size = new Size(146, 23);
            label_borrowbook_pyear.TabIndex = 17;
            label_borrowbook_pyear.Text = "Publication Year : ";
            // 
            // label_borrowbook_category
            // 
            label_borrowbook_category.AutoSize = true;
            label_borrowbook_category.ForeColor = Color.DarkCyan;
            label_borrowbook_category.Location = new Point(33, 281);
            label_borrowbook_category.Name = "label_borrowbook_category";
            label_borrowbook_category.Size = new Size(93, 23);
            label_borrowbook_category.TabIndex = 18;
            label_borrowbook_category.Text = "Category : ";
            // 
            // label_borrowbook_author
            // 
            label_borrowbook_author.AutoSize = true;
            label_borrowbook_author.ForeColor = Color.DarkCyan;
            label_borrowbook_author.Location = new Point(33, 233);
            label_borrowbook_author.Name = "label_borrowbook_author";
            label_borrowbook_author.Size = new Size(77, 23);
            label_borrowbook_author.TabIndex = 19;
            label_borrowbook_author.Text = "Author : ";
            // 
            // text_borrowbook_pyear
            // 
            text_borrowbook_pyear.BackColor = Color.CadetBlue;
            text_borrowbook_pyear.BorderStyle = BorderStyle.FixedSingle;
            text_borrowbook_pyear.Location = new Point(197, 324);
            text_borrowbook_pyear.Name = "text_borrowbook_pyear";
            text_borrowbook_pyear.ReadOnly = true;
            text_borrowbook_pyear.Size = new Size(216, 30);
            text_borrowbook_pyear.TabIndex = 14;
            // 
            // text_borrowbook_category
            // 
            text_borrowbook_category.BackColor = Color.CadetBlue;
            text_borrowbook_category.BorderStyle = BorderStyle.FixedSingle;
            text_borrowbook_category.Location = new Point(197, 279);
            text_borrowbook_category.Name = "text_borrowbook_category";
            text_borrowbook_category.ReadOnly = true;
            text_borrowbook_category.Size = new Size(216, 30);
            text_borrowbook_category.TabIndex = 13;
            // 
            // label_borrowbook_id
            // 
            label_borrowbook_id.AutoSize = true;
            label_borrowbook_id.ForeColor = Color.DarkCyan;
            label_borrowbook_id.Location = new Point(33, 121);
            label_borrowbook_id.Name = "label_borrowbook_id";
            label_borrowbook_id.Size = new Size(84, 23);
            label_borrowbook_id.TabIndex = 20;
            label_borrowbook_id.Text = "Book ID : ";
            // 
            // text_borrowbook_author
            // 
            text_borrowbook_author.BackColor = Color.CadetBlue;
            text_borrowbook_author.BorderStyle = BorderStyle.FixedSingle;
            text_borrowbook_author.Location = new Point(197, 231);
            text_borrowbook_author.Name = "text_borrowbook_author";
            text_borrowbook_author.ReadOnly = true;
            text_borrowbook_author.Size = new Size(216, 30);
            text_borrowbook_author.TabIndex = 12;
            // 
            // text_borrowbook_title
            // 
            text_borrowbook_title.BackColor = Color.CadetBlue;
            text_borrowbook_title.BorderStyle = BorderStyle.FixedSingle;
            text_borrowbook_title.Location = new Point(197, 183);
            text_borrowbook_title.Name = "text_borrowbook_title";
            text_borrowbook_title.ReadOnly = true;
            text_borrowbook_title.Size = new Size(216, 30);
            text_borrowbook_title.TabIndex = 11;
            // 
            // text_borrowbook_id
            // 
            text_borrowbook_id.BackColor = Color.CadetBlue;
            text_borrowbook_id.BorderStyle = BorderStyle.FixedSingle;
            text_borrowbook_id.Location = new Point(197, 119);
            text_borrowbook_id.Name = "text_borrowbook_id";
            text_borrowbook_id.Size = new Size(216, 30);
            text_borrowbook_id.TabIndex = 11;
            // 
            // label_borrowbook_title
            // 
            label_borrowbook_title.AutoSize = true;
            label_borrowbook_title.ForeColor = Color.DarkCyan;
            label_borrowbook_title.Location = new Point(33, 185);
            label_borrowbook_title.Name = "label_borrowbook_title";
            label_borrowbook_title.Size = new Size(56, 23);
            label_borrowbook_title.TabIndex = 20;
            label_borrowbook_title.Text = "Title : ";
            // 
            // text_borrowbook_firstname
            // 
            text_borrowbook_firstname.BackColor = Color.CadetBlue;
            text_borrowbook_firstname.BorderStyle = BorderStyle.FixedSingle;
            text_borrowbook_firstname.Location = new Point(866, 186);
            text_borrowbook_firstname.Name = "text_borrowbook_firstname";
            text_borrowbook_firstname.ReadOnly = true;
            text_borrowbook_firstname.Size = new Size(216, 30);
            text_borrowbook_firstname.TabIndex = 11;
            // 
            // text_borrowbook_lastname
            // 
            text_borrowbook_lastname.BackColor = Color.CadetBlue;
            text_borrowbook_lastname.BorderStyle = BorderStyle.FixedSingle;
            text_borrowbook_lastname.Location = new Point(866, 234);
            text_borrowbook_lastname.Name = "text_borrowbook_lastname";
            text_borrowbook_lastname.ReadOnly = true;
            text_borrowbook_lastname.Size = new Size(216, 30);
            text_borrowbook_lastname.TabIndex = 12;
            // 
            // label_borrowbook_firstname
            // 
            label_borrowbook_firstname.AutoSize = true;
            label_borrowbook_firstname.ForeColor = Color.DarkCyan;
            label_borrowbook_firstname.Location = new Point(679, 190);
            label_borrowbook_firstname.Name = "label_borrowbook_firstname";
            label_borrowbook_firstname.Size = new Size(106, 23);
            label_borrowbook_firstname.TabIndex = 20;
            label_borrowbook_firstname.Text = "First Name : ";
            // 
            // text_borrowbook_phone
            // 
            text_borrowbook_phone.BackColor = Color.CadetBlue;
            text_borrowbook_phone.BorderStyle = BorderStyle.FixedSingle;
            text_borrowbook_phone.Location = new Point(866, 279);
            text_borrowbook_phone.Name = "text_borrowbook_phone";
            text_borrowbook_phone.ReadOnly = true;
            text_borrowbook_phone.Size = new Size(216, 30);
            text_borrowbook_phone.TabIndex = 13;
            // 
            // text_borrowbook_reg
            // 
            text_borrowbook_reg.BackColor = Color.CadetBlue;
            text_borrowbook_reg.BorderStyle = BorderStyle.FixedSingle;
            text_borrowbook_reg.Location = new Point(866, 329);
            text_borrowbook_reg.Name = "text_borrowbook_reg";
            text_borrowbook_reg.ReadOnly = true;
            text_borrowbook_reg.Size = new Size(216, 30);
            text_borrowbook_reg.TabIndex = 14;
            // 
            // label_borrowbook_lastname
            // 
            label_borrowbook_lastname.AutoSize = true;
            label_borrowbook_lastname.ForeColor = Color.DarkCyan;
            label_borrowbook_lastname.Location = new Point(679, 238);
            label_borrowbook_lastname.Name = "label_borrowbook_lastname";
            label_borrowbook_lastname.Size = new Size(105, 23);
            label_borrowbook_lastname.TabIndex = 19;
            label_borrowbook_lastname.Text = "Last Name : ";
            // 
            // label_borrowbook_phone
            // 
            label_borrowbook_phone.AutoSize = true;
            label_borrowbook_phone.ForeColor = Color.DarkCyan;
            label_borrowbook_phone.Location = new Point(679, 283);
            label_borrowbook_phone.Name = "label_borrowbook_phone";
            label_borrowbook_phone.Size = new Size(73, 23);
            label_borrowbook_phone.TabIndex = 18;
            label_borrowbook_phone.Text = "Phone : ";
            // 
            // label_borrowbook_reg
            // 
            label_borrowbook_reg.AutoSize = true;
            label_borrowbook_reg.ForeColor = Color.DarkCyan;
            label_borrowbook_reg.Location = new Point(679, 331);
            label_borrowbook_reg.Name = "label_borrowbook_reg";
            label_borrowbook_reg.Size = new Size(163, 23);
            label_borrowbook_reg.TabIndex = 17;
            label_borrowbook_reg.Text = "Registrations Date : ";
            // 
            // text_borrowbook_memberid
            // 
            text_borrowbook_memberid.BackColor = Color.CadetBlue;
            text_borrowbook_memberid.BorderStyle = BorderStyle.FixedSingle;
            text_borrowbook_memberid.Location = new Point(866, 119);
            text_borrowbook_memberid.Name = "text_borrowbook_memberid";
            text_borrowbook_memberid.Size = new Size(216, 30);
            text_borrowbook_memberid.TabIndex = 11;
            // 
            // label_borrowbook_memberid
            // 
            label_borrowbook_memberid.AutoSize = true;
            label_borrowbook_memberid.ForeColor = Color.DarkCyan;
            label_borrowbook_memberid.Location = new Point(679, 123);
            label_borrowbook_memberid.Name = "label_borrowbook_memberid";
            label_borrowbook_memberid.Size = new Size(110, 23);
            label_borrowbook_memberid.TabIndex = 20;
            label_borrowbook_memberid.Text = "Member ID : ";
            // 
            // text_borrowbook_isavailable
            // 
            text_borrowbook_isavailable.BackColor = Color.CadetBlue;
            text_borrowbook_isavailable.BorderStyle = BorderStyle.FixedSingle;
            text_borrowbook_isavailable.Location = new Point(197, 373);
            text_borrowbook_isavailable.Name = "text_borrowbook_isavailable";
            text_borrowbook_isavailable.ReadOnly = true;
            text_borrowbook_isavailable.Size = new Size(216, 30);
            text_borrowbook_isavailable.TabIndex = 14;
            // 
            // label_borrowbook_isavailable
            // 
            label_borrowbook_isavailable.AutoSize = true;
            label_borrowbook_isavailable.ForeColor = Color.DarkCyan;
            label_borrowbook_isavailable.Location = new Point(33, 375);
            label_borrowbook_isavailable.Name = "label_borrowbook_isavailable";
            label_borrowbook_isavailable.Size = new Size(109, 23);
            label_borrowbook_isavailable.TabIndex = 17;
            label_borrowbook_isavailable.Text = "Is Available : ";
            // 
            // button_borrowbook_check
            // 
            button_borrowbook_check.BackColor = Color.CadetBlue;
            button_borrowbook_check.Location = new Point(371, 449);
            button_borrowbook_check.Name = "button_borrowbook_check";
            button_borrowbook_check.Size = new Size(140, 46);
            button_borrowbook_check.TabIndex = 15;
            button_borrowbook_check.Text = "Check";
            button_borrowbook_check.UseVisualStyleBackColor = false;
            button_borrowbook_check.Click += button_borrowbook_check_Click;
            // 
            // BorrowBook
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(1138, 550);
            Controls.Add(button_borrowbook_back);
            Controls.Add(button_borrowbook_check);
            Controls.Add(button_borrowbook_borrow);
            Controls.Add(label_borrowbook_reg);
            Controls.Add(label_borrowbook_isavailable);
            Controls.Add(label_borrowbook_pyear);
            Controls.Add(label_borrowbook_phone);
            Controls.Add(label_borrowbook_category);
            Controls.Add(label_borrowbook_lastname);
            Controls.Add(label_borrowbook_author);
            Controls.Add(text_borrowbook_reg);
            Controls.Add(text_borrowbook_isavailable);
            Controls.Add(text_borrowbook_pyear);
            Controls.Add(text_borrowbook_phone);
            Controls.Add(text_borrowbook_category);
            Controls.Add(label_borrowbook_firstname);
            Controls.Add(label_borrowbook_title);
            Controls.Add(label_borrowbook_memberid);
            Controls.Add(label_borrowbook_id);
            Controls.Add(text_borrowbook_lastname);
            Controls.Add(text_borrowbook_author);
            Controls.Add(text_borrowbook_memberid);
            Controls.Add(text_borrowbook_id);
            Controls.Add(text_borrowbook_firstname);
            Controls.Add(text_borrowbook_title);
            Controls.Add(label_borrowbook_head);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.DarkCyan;
            Name = "BorrowBook";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BorrowBook";
            Load += BorrowBook_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_borrowbook_head;
        private Label label_borrowbook_pyear;    
        private Label label_borrowbook_category;
        private Label label_borrowbook_firstname;
        private Label label_borrowbook_author;
        private Label label_borrowbook_id;
        private Label label_borrowbook_title;
        private Label label_borrowbook_lastname;
        private Label label_borrowbook_phone;
        private Label label_borrowbook_reg;
        private Label label_borrowbook_memberid;
        private Label label_borrowbook_isavailable;
        public TextBox text_borrowbook_memberid;
        public TextBox text_borrowbook_author;
        public TextBox text_borrowbook_pyear;
        public TextBox text_borrowbook_category;
        public TextBox text_borrowbook_title;
        public TextBox text_borrowbook_id;
        public TextBox text_borrowbook_firstname;
        public TextBox text_borrowbook_lastname;
        public TextBox text_borrowbook_phone;
        public TextBox text_borrowbook_reg;
        public TextBox text_borrowbook_isavailable;
        private Button button_borrowbook_back;
        private Button button_borrowbook_borrow;
        private Button button_borrowbook_check;
    }
}