namespace LibrarySystem.Forms
{
    partial class Search_Book
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
            label_searchbook_head = new Label();
            button_searchbook_back = new Button();
            button_searchbook_search = new Button();
            label_searchbook_author = new Label();
            label_searchbook_title = new Label();
            text_searchbook_author = new TextBox();
            text_searchbook_title = new TextBox();
            text_searchbook_id = new TextBox();
            label_searchbook_id = new Label();
            text_searchbook_category = new TextBox();
            text_searchbook_pyear = new TextBox();
            label_searchbook_category = new Label();
            label_searchbook_pyear = new Label();
            text_searchbook_available = new TextBox();
            label_searchbook_available = new Label();
            SuspendLayout();
            // 
            // label_searchbook_head
            // 
            label_searchbook_head.AutoSize = true;
            label_searchbook_head.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_searchbook_head.Location = new Point(263, 9);
            label_searchbook_head.Name = "label_searchbook_head";
            label_searchbook_head.Size = new Size(182, 41);
            label_searchbook_head.TabIndex = 0;
            label_searchbook_head.Text = "Search Book";
            // 
            // button_searchbook_back
            // 
            button_searchbook_back.BackColor = Color.CadetBlue;
            button_searchbook_back.Location = new Point(544, 447);
            button_searchbook_back.Name = "button_searchbook_back";
            button_searchbook_back.Size = new Size(124, 40);
            button_searchbook_back.TabIndex = 3;
            button_searchbook_back.Text = "Back";
            button_searchbook_back.UseVisualStyleBackColor = false;
            button_searchbook_back.Click += button_searchbook_back_Click;
            // 
            // button_searchbook_search
            // 
            button_searchbook_search.BackColor = Color.CadetBlue;
            button_searchbook_search.Location = new Point(184, 434);
            button_searchbook_search.Name = "button_searchbook_search";
            button_searchbook_search.Size = new Size(124, 40);
            button_searchbook_search.TabIndex = 2;
            button_searchbook_search.Text = "Search";
            button_searchbook_search.UseVisualStyleBackColor = false;
            button_searchbook_search.Click += button_searchbook_search_Click;
            // 
            // label_searchbook_author
            // 
            label_searchbook_author.AutoSize = true;
            label_searchbook_author.ForeColor = Color.DarkCyan;
            label_searchbook_author.Location = new Point(35, 235);
            label_searchbook_author.Name = "label_searchbook_author";
            label_searchbook_author.Size = new Size(77, 23);
            label_searchbook_author.TabIndex = 12;
            label_searchbook_author.Text = "Author : ";
            // 
            // label_searchbook_title
            // 
            label_searchbook_title.AutoSize = true;
            label_searchbook_title.ForeColor = Color.DarkCyan;
            label_searchbook_title.Location = new Point(35, 188);
            label_searchbook_title.Name = "label_searchbook_title";
            label_searchbook_title.Size = new Size(56, 23);
            label_searchbook_title.TabIndex = 13;
            label_searchbook_title.Text = "Title : ";
            // 
            // text_searchbook_author
            // 
            text_searchbook_author.BackColor = Color.CadetBlue;
            text_searchbook_author.BorderStyle = BorderStyle.FixedSingle;
            text_searchbook_author.Location = new Point(158, 233);
            text_searchbook_author.Name = "text_searchbook_author";
            text_searchbook_author.ReadOnly = true;
            text_searchbook_author.Size = new Size(192, 30);
            text_searchbook_author.TabIndex = 10;
            // 
            // text_searchbook_title
            // 
            text_searchbook_title.BackColor = Color.CadetBlue;
            text_searchbook_title.BorderStyle = BorderStyle.FixedSingle;
            text_searchbook_title.Location = new Point(158, 186);
            text_searchbook_title.Name = "text_searchbook_title";
            text_searchbook_title.ReadOnly = true;
            text_searchbook_title.Size = new Size(192, 30);
            text_searchbook_title.TabIndex = 11;
            // 
            // text_searchbook_id
            // 
            text_searchbook_id.BackColor = Color.CadetBlue;
            text_searchbook_id.BorderStyle = BorderStyle.FixedSingle;
            text_searchbook_id.Location = new Point(158, 114);
            text_searchbook_id.Name = "text_searchbook_id";
            text_searchbook_id.Size = new Size(192, 30);
            text_searchbook_id.TabIndex = 1;
            // 
            // label_searchbook_id
            // 
            label_searchbook_id.AutoSize = true;
            label_searchbook_id.ForeColor = Color.DarkCyan;
            label_searchbook_id.Location = new Point(35, 116);
            label_searchbook_id.Name = "label_searchbook_id";
            label_searchbook_id.Size = new Size(84, 23);
            label_searchbook_id.TabIndex = 13;
            label_searchbook_id.Text = "Book ID : ";
            // 
            // text_searchbook_category
            // 
            text_searchbook_category.BackColor = Color.CadetBlue;
            text_searchbook_category.BorderStyle = BorderStyle.FixedSingle;
            text_searchbook_category.Location = new Point(158, 281);
            text_searchbook_category.Name = "text_searchbook_category";
            text_searchbook_category.ReadOnly = true;
            text_searchbook_category.Size = new Size(192, 30);
            text_searchbook_category.TabIndex = 11;
            // 
            // text_searchbook_pyear
            // 
            text_searchbook_pyear.BackColor = Color.CadetBlue;
            text_searchbook_pyear.BorderStyle = BorderStyle.FixedSingle;
            text_searchbook_pyear.Location = new Point(158, 328);
            text_searchbook_pyear.Name = "text_searchbook_pyear";
            text_searchbook_pyear.ReadOnly = true;
            text_searchbook_pyear.Size = new Size(192, 30);
            text_searchbook_pyear.TabIndex = 10;
            // 
            // label_searchbook_category
            // 
            label_searchbook_category.AutoSize = true;
            label_searchbook_category.ForeColor = Color.DarkCyan;
            label_searchbook_category.Location = new Point(35, 283);
            label_searchbook_category.Name = "label_searchbook_category";
            label_searchbook_category.Size = new Size(79, 23);
            label_searchbook_category.TabIndex = 13;
            label_searchbook_category.Text = "Category";
            // 
            // label_searchbook_pyear
            // 
            label_searchbook_pyear.AutoSize = true;
            label_searchbook_pyear.ForeColor = Color.DarkCyan;
            label_searchbook_pyear.Location = new Point(35, 330);
            label_searchbook_pyear.Name = "label_searchbook_pyear";
            label_searchbook_pyear.Size = new Size(111, 23);
            label_searchbook_pyear.TabIndex = 12;
            label_searchbook_pyear.Text = "Public. Year : ";
            // 
            // text_searchbook_available
            // 
            text_searchbook_available.BackColor = Color.CadetBlue;
            text_searchbook_available.BorderStyle = BorderStyle.FixedSingle;
            text_searchbook_available.Location = new Point(158, 373);
            text_searchbook_available.Name = "text_searchbook_available";
            text_searchbook_available.ReadOnly = true;
            text_searchbook_available.Size = new Size(192, 30);
            text_searchbook_available.TabIndex = 10;
            // 
            // label_searchbook_available
            // 
            label_searchbook_available.AutoSize = true;
            label_searchbook_available.ForeColor = Color.DarkCyan;
            label_searchbook_available.Location = new Point(35, 375);
            label_searchbook_available.Name = "label_searchbook_available";
            label_searchbook_available.Size = new Size(92, 23);
            label_searchbook_available.TabIndex = 12;
            label_searchbook_available.Text = "Available : ";
            // 
            // Search_Book
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(717, 518);
            Controls.Add(button_searchbook_back);
            Controls.Add(button_searchbook_search);
            Controls.Add(label_searchbook_available);
            Controls.Add(label_searchbook_pyear);
            Controls.Add(label_searchbook_author);
            Controls.Add(label_searchbook_id);
            Controls.Add(label_searchbook_category);
            Controls.Add(label_searchbook_title);
            Controls.Add(text_searchbook_available);
            Controls.Add(text_searchbook_pyear);
            Controls.Add(text_searchbook_author);
            Controls.Add(text_searchbook_id);
            Controls.Add(text_searchbook_category);
            Controls.Add(text_searchbook_title);
            Controls.Add(label_searchbook_head);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.DarkCyan;
            Name = "Search_Book";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Searxh_Book";
            Load += Search_Book_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_searchbook_back;
        private Button button_searchbook_search;
        public TextBox text_searchbook_author;
        public TextBox text_searchbook_title;
        public TextBox text_searchbook_id;
        public TextBox text_searchbook_category;
        public TextBox text_searchbook_pyear;
        public TextBox text_searchbook_available;
        private Label label_searchbook_title;
        private Label label_searchbook_author;
        private Label label_searchbook_id;
        private Label label_searchbook_category;
        private Label label_searchbook_pyear;
        private Label label_searchbook_head;
        private Label label_searchbook_available;
    }
}