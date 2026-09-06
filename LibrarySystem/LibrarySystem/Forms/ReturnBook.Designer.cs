namespace LibrarySystem.Forms
{
    partial class ReturnBook
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
            button_returnbook_back = new Button();
            button_returnbook_borrow = new Button();
            label_returnbook_reg = new Label();
            label_returnbook_isavailable = new Label();
            label_returnbook_pyear = new Label();
            label_returnbook_phone = new Label();
            label_returnbook_category = new Label();
            label_returnbook_lastname = new Label();
            label_returnbook_author = new Label();
            text_returnbook_reg = new TextBox();
            text_returnbook_isavailable = new TextBox();
            text_returnbook_pyear = new TextBox();
            text_returnbook_phone = new TextBox();
            text_returnbook_category = new TextBox();
            label_returnbook_firstname = new Label();
            label_returnbook_title = new Label();
            label_returnbook_memberid = new Label();
            label_returnbook_id = new Label();
            text_returnbook_lastname = new TextBox();
            text_returnbook_author = new TextBox();
            text_returnbook_memberid = new TextBox();
            text_returnbook_id = new TextBox();
            text_returnbook_firstname = new TextBox();
            text_returnbook_title = new TextBox();
            label_returnbook_head = new Label();
            SuspendLayout();
            // 
            // button_returnbook_back
            // 
            button_returnbook_back.BackColor = Color.CadetBlue;
            button_returnbook_back.Location = new Point(962, 524);
            button_returnbook_back.Name = "button_returnbook_back";
            button_returnbook_back.Size = new Size(137, 39);
            button_returnbook_back.TabIndex = 35;
            button_returnbook_back.Text = "Back";
            button_returnbook_back.UseVisualStyleBackColor = false;
            button_returnbook_back.Click += button_returnbook_back_Click;
            // 
            // button_returnbook_borrow
            // 
            button_returnbook_borrow.BackColor = Color.CadetBlue;
            button_returnbook_borrow.Location = new Point(489, 474);
            button_returnbook_borrow.Name = "button_returnbook_borrow";
            button_returnbook_borrow.Size = new Size(140, 46);
            button_returnbook_borrow.TabIndex = 33;
            button_returnbook_borrow.Text = "Return";
            button_returnbook_borrow.UseVisualStyleBackColor = false;
            button_returnbook_borrow.Click += button_returnbook_borrow_Click;
            // 
            // label_returnbook_reg
            // 
            label_returnbook_reg.AutoSize = true;
            label_returnbook_reg.ForeColor = Color.DarkCyan;
            label_returnbook_reg.Location = new Point(662, 367);
            label_returnbook_reg.Name = "label_returnbook_reg";
            label_returnbook_reg.Size = new Size(163, 23);
            label_returnbook_reg.TabIndex = 38;
            label_returnbook_reg.Text = "Registrations Date : ";
            // 
            // label_returnbook_isavailable
            // 
            label_returnbook_isavailable.AutoSize = true;
            label_returnbook_isavailable.ForeColor = Color.DarkCyan;
            label_returnbook_isavailable.Location = new Point(16, 411);
            label_returnbook_isavailable.Name = "label_returnbook_isavailable";
            label_returnbook_isavailable.Size = new Size(109, 23);
            label_returnbook_isavailable.TabIndex = 37;
            label_returnbook_isavailable.Text = "Is Available : ";
            // 
            // label_returnbook_pyear
            // 
            label_returnbook_pyear.AutoSize = true;
            label_returnbook_pyear.ForeColor = Color.DarkCyan;
            label_returnbook_pyear.Location = new Point(16, 362);
            label_returnbook_pyear.Name = "label_returnbook_pyear";
            label_returnbook_pyear.Size = new Size(146, 23);
            label_returnbook_pyear.TabIndex = 36;
            label_returnbook_pyear.Text = "Publication Year : ";
            // 
            // label_returnbook_phone
            // 
            label_returnbook_phone.AutoSize = true;
            label_returnbook_phone.ForeColor = Color.DarkCyan;
            label_returnbook_phone.Location = new Point(662, 319);
            label_returnbook_phone.Name = "label_returnbook_phone";
            label_returnbook_phone.Size = new Size(73, 23);
            label_returnbook_phone.TabIndex = 40;
            label_returnbook_phone.Text = "Phone : ";
            // 
            // label_returnbook_category
            // 
            label_returnbook_category.AutoSize = true;
            label_returnbook_category.ForeColor = Color.DarkCyan;
            label_returnbook_category.Location = new Point(16, 317);
            label_returnbook_category.Name = "label_returnbook_category";
            label_returnbook_category.Size = new Size(93, 23);
            label_returnbook_category.TabIndex = 39;
            label_returnbook_category.Text = "Category : ";
            // 
            // label_returnbook_lastname
            // 
            label_returnbook_lastname.AutoSize = true;
            label_returnbook_lastname.ForeColor = Color.DarkCyan;
            label_returnbook_lastname.Location = new Point(662, 274);
            label_returnbook_lastname.Name = "label_returnbook_lastname";
            label_returnbook_lastname.Size = new Size(105, 23);
            label_returnbook_lastname.TabIndex = 42;
            label_returnbook_lastname.Text = "Last Name : ";
            // 
            // label_returnbook_author
            // 
            label_returnbook_author.AutoSize = true;
            label_returnbook_author.ForeColor = Color.DarkCyan;
            label_returnbook_author.Location = new Point(16, 269);
            label_returnbook_author.Name = "label_returnbook_author";
            label_returnbook_author.Size = new Size(77, 23);
            label_returnbook_author.TabIndex = 41;
            label_returnbook_author.Text = "Author : ";
            // 
            // text_returnbook_reg
            // 
            text_returnbook_reg.BackColor = Color.CadetBlue;
            text_returnbook_reg.BorderStyle = BorderStyle.FixedSingle;
            text_returnbook_reg.Location = new Point(849, 365);
            text_returnbook_reg.Name = "text_returnbook_reg";
            text_returnbook_reg.ReadOnly = true;
            text_returnbook_reg.Size = new Size(216, 30);
            text_returnbook_reg.TabIndex = 32;
            // 
            // text_returnbook_isavailable
            // 
            text_returnbook_isavailable.BackColor = Color.CadetBlue;
            text_returnbook_isavailable.BorderStyle = BorderStyle.FixedSingle;
            text_returnbook_isavailable.Location = new Point(180, 409);
            text_returnbook_isavailable.Name = "text_returnbook_isavailable";
            text_returnbook_isavailable.ReadOnly = true;
            text_returnbook_isavailable.Size = new Size(216, 30);
            text_returnbook_isavailable.TabIndex = 30;
            // 
            // text_returnbook_pyear
            // 
            text_returnbook_pyear.BackColor = Color.CadetBlue;
            text_returnbook_pyear.BorderStyle = BorderStyle.FixedSingle;
            text_returnbook_pyear.Location = new Point(180, 360);
            text_returnbook_pyear.Name = "text_returnbook_pyear";
            text_returnbook_pyear.ReadOnly = true;
            text_returnbook_pyear.Size = new Size(216, 30);
            text_returnbook_pyear.TabIndex = 31;
            // 
            // text_returnbook_phone
            // 
            text_returnbook_phone.BackColor = Color.CadetBlue;
            text_returnbook_phone.BorderStyle = BorderStyle.FixedSingle;
            text_returnbook_phone.Location = new Point(849, 315);
            text_returnbook_phone.Name = "text_returnbook_phone";
            text_returnbook_phone.ReadOnly = true;
            text_returnbook_phone.Size = new Size(216, 30);
            text_returnbook_phone.TabIndex = 29;
            text_returnbook_phone.TextChanged += text_borrowbook_phone_TextChanged;
            // 
            // text_returnbook_category
            // 
            text_returnbook_category.BackColor = Color.CadetBlue;
            text_returnbook_category.BorderStyle = BorderStyle.FixedSingle;
            text_returnbook_category.Location = new Point(180, 315);
            text_returnbook_category.Name = "text_returnbook_category";
            text_returnbook_category.ReadOnly = true;
            text_returnbook_category.Size = new Size(216, 30);
            text_returnbook_category.TabIndex = 28;
            // 
            // label_returnbook_firstname
            // 
            label_returnbook_firstname.AutoSize = true;
            label_returnbook_firstname.ForeColor = Color.DarkCyan;
            label_returnbook_firstname.Location = new Point(662, 226);
            label_returnbook_firstname.Name = "label_returnbook_firstname";
            label_returnbook_firstname.Size = new Size(106, 23);
            label_returnbook_firstname.TabIndex = 43;
            label_returnbook_firstname.Text = "First Name : ";
            // 
            // label_returnbook_title
            // 
            label_returnbook_title.AutoSize = true;
            label_returnbook_title.ForeColor = Color.DarkCyan;
            label_returnbook_title.Location = new Point(16, 221);
            label_returnbook_title.Name = "label_returnbook_title";
            label_returnbook_title.Size = new Size(56, 23);
            label_returnbook_title.TabIndex = 44;
            label_returnbook_title.Text = "Title : ";
            // 
            // label_returnbook_memberid
            // 
            label_returnbook_memberid.AutoSize = true;
            label_returnbook_memberid.ForeColor = Color.DarkCyan;
            label_returnbook_memberid.Location = new Point(662, 159);
            label_returnbook_memberid.Name = "label_returnbook_memberid";
            label_returnbook_memberid.Size = new Size(110, 23);
            label_returnbook_memberid.TabIndex = 45;
            label_returnbook_memberid.Text = "Member ID : ";
            // 
            // label_returnbook_id
            // 
            label_returnbook_id.AutoSize = true;
            label_returnbook_id.ForeColor = Color.DarkCyan;
            label_returnbook_id.Location = new Point(16, 157);
            label_returnbook_id.Name = "label_returnbook_id";
            label_returnbook_id.Size = new Size(84, 23);
            label_returnbook_id.TabIndex = 46;
            label_returnbook_id.Text = "Book ID : ";
            // 
            // text_returnbook_lastname
            // 
            text_returnbook_lastname.BackColor = Color.CadetBlue;
            text_returnbook_lastname.BorderStyle = BorderStyle.FixedSingle;
            text_returnbook_lastname.Location = new Point(849, 270);
            text_returnbook_lastname.Name = "text_returnbook_lastname";
            text_returnbook_lastname.ReadOnly = true;
            text_returnbook_lastname.Size = new Size(216, 30);
            text_returnbook_lastname.TabIndex = 27;
            // 
            // text_returnbook_author
            // 
            text_returnbook_author.BackColor = Color.CadetBlue;
            text_returnbook_author.BorderStyle = BorderStyle.FixedSingle;
            text_returnbook_author.Location = new Point(180, 267);
            text_returnbook_author.Name = "text_returnbook_author";
            text_returnbook_author.ReadOnly = true;
            text_returnbook_author.Size = new Size(216, 30);
            text_returnbook_author.TabIndex = 26;
            // 
            // text_returnbook_memberid
            // 
            text_returnbook_memberid.BackColor = Color.CadetBlue;
            text_returnbook_memberid.BorderStyle = BorderStyle.FixedSingle;
            text_returnbook_memberid.Location = new Point(849, 155);
            text_returnbook_memberid.Name = "text_returnbook_memberid";
            text_returnbook_memberid.Size = new Size(216, 30);
            text_returnbook_memberid.TabIndex = 24;
            // 
            // text_returnbook_id
            // 
            text_returnbook_id.BackColor = Color.CadetBlue;
            text_returnbook_id.BorderStyle = BorderStyle.FixedSingle;
            text_returnbook_id.Location = new Point(180, 155);
            text_returnbook_id.Name = "text_returnbook_id";
            text_returnbook_id.Size = new Size(216, 30);
            text_returnbook_id.TabIndex = 23;
            // 
            // text_returnbook_firstname
            // 
            text_returnbook_firstname.BackColor = Color.CadetBlue;
            text_returnbook_firstname.BorderStyle = BorderStyle.FixedSingle;
            text_returnbook_firstname.Location = new Point(849, 222);
            text_returnbook_firstname.Name = "text_returnbook_firstname";
            text_returnbook_firstname.ReadOnly = true;
            text_returnbook_firstname.Size = new Size(216, 30);
            text_returnbook_firstname.TabIndex = 22;
            // 
            // text_returnbook_title
            // 
            text_returnbook_title.BackColor = Color.CadetBlue;
            text_returnbook_title.BorderStyle = BorderStyle.FixedSingle;
            text_returnbook_title.Location = new Point(180, 219);
            text_returnbook_title.Name = "text_returnbook_title";
            text_returnbook_title.ReadOnly = true;
            text_returnbook_title.Size = new Size(216, 30);
            text_returnbook_title.TabIndex = 25;
            // 
            // label_returnbook_head
            // 
            label_returnbook_head.AutoSize = true;
            label_returnbook_head.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_returnbook_head.Location = new Point(448, 34);
            label_returnbook_head.Name = "label_returnbook_head";
            label_returnbook_head.Size = new Size(181, 41);
            label_returnbook_head.TabIndex = 21;
            label_returnbook_head.Text = "Return Book";
            // 
            // ReturnBook
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(1182, 612);
            Controls.Add(button_returnbook_back);
            Controls.Add(button_returnbook_borrow);
            Controls.Add(label_returnbook_reg);
            Controls.Add(label_returnbook_isavailable);
            Controls.Add(label_returnbook_pyear);
            Controls.Add(label_returnbook_phone);
            Controls.Add(label_returnbook_category);
            Controls.Add(label_returnbook_lastname);
            Controls.Add(label_returnbook_author);
            Controls.Add(text_returnbook_reg);
            Controls.Add(text_returnbook_isavailable);
            Controls.Add(text_returnbook_pyear);
            Controls.Add(text_returnbook_phone);
            Controls.Add(text_returnbook_category);
            Controls.Add(label_returnbook_firstname);
            Controls.Add(label_returnbook_title);
            Controls.Add(label_returnbook_memberid);
            Controls.Add(label_returnbook_id);
            Controls.Add(text_returnbook_lastname);
            Controls.Add(text_returnbook_author);
            Controls.Add(text_returnbook_memberid);
            Controls.Add(text_returnbook_id);
            Controls.Add(text_returnbook_firstname);
            Controls.Add(text_returnbook_title);
            Controls.Add(label_returnbook_head);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.DarkCyan;
            Name = "ReturnBook";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ReturnBook";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_returnbook_back;
        private Button button_returnbook_borrow;
        private Label label_returnbook_reg;
        private Label label_returnbook_isavailable;
        private Label label_returnbook_pyear;
        private Label label_returnbook_phone;
        private Label label_returnbook_category;
        private Label label_returnbook_lastname;
        private Label label_returnbook_author;
        public TextBox text_returnbook_reg;
        public TextBox text_returnbook_isavailable;
        public TextBox text_returnbook_pyear;
        public TextBox text_returnbook_phone;
        public TextBox text_returnbook_category;
        private Label label_returnbook_firstname;
        private Label label_returnbook_title;
        private Label label_returnbook_memberid;
        private Label label_returnbook_id;
        public TextBox text_returnbook_lastname;
        public TextBox text_returnbook_author;
        public TextBox text_returnbook_memberid;
        public TextBox text_returnbook_id;
        public TextBox text_returnbook_firstname;
        public TextBox text_returnbook_title;
        private Label label_returnbook_head;
    }
}