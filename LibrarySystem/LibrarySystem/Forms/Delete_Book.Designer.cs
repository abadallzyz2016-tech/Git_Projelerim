namespace LibrarySystem.Forms
{
    partial class Delete_Book
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
            label_deletebook_author = new Label();
            label_deletebook_title = new Label();
            text_deletebook_author = new TextBox();
            text_deletebook_title = new TextBox();
            label_deletebook_head = new Label();
            text_deletebook_pyear = new TextBox();
            label_deletebook_pyear = new Label();
            button_deletebook_back = new Button();
            button_deletebook_remove = new Button();
            SuspendLayout();
            // 
            // label_deletebook_author
            // 
            label_deletebook_author.AutoSize = true;
            label_deletebook_author.ForeColor = Color.DarkCyan;
            label_deletebook_author.Location = new Point(28, 204);
            label_deletebook_author.Name = "label_deletebook_author";
            label_deletebook_author.Size = new Size(77, 23);
            label_deletebook_author.TabIndex = 14;
            label_deletebook_author.Text = "Author : ";
            // 
            // label_deletebook_title
            // 
            label_deletebook_title.AutoSize = true;
            label_deletebook_title.ForeColor = Color.DarkCyan;
            label_deletebook_title.Location = new Point(28, 150);
            label_deletebook_title.Name = "label_deletebook_title";
            label_deletebook_title.Size = new Size(56, 23);
            label_deletebook_title.TabIndex = 15;
            label_deletebook_title.Text = "Title : ";
            // 
            // text_deletebook_author
            // 
            text_deletebook_author.BackColor = Color.CadetBlue;
            text_deletebook_author.BorderStyle = BorderStyle.FixedSingle;
            text_deletebook_author.Location = new Point(192, 202);
            text_deletebook_author.Name = "text_deletebook_author";
            text_deletebook_author.Size = new Size(216, 30);
            text_deletebook_author.TabIndex = 2;
            // 
            // text_deletebook_title
            // 
            text_deletebook_title.BackColor = Color.CadetBlue;
            text_deletebook_title.BorderStyle = BorderStyle.FixedSingle;
            text_deletebook_title.Location = new Point(192, 148);
            text_deletebook_title.Name = "text_deletebook_title";
            text_deletebook_title.Size = new Size(216, 30);
            text_deletebook_title.TabIndex = 1;
            // 
            // label_deletebook_head
            // 
            label_deletebook_head.AutoSize = true;
            label_deletebook_head.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_deletebook_head.ForeColor = Color.DarkCyan;
            label_deletebook_head.Location = new Point(207, 39);
            label_deletebook_head.Name = "label_deletebook_head";
            label_deletebook_head.Size = new Size(180, 41);
            label_deletebook_head.TabIndex = 11;
            label_deletebook_head.Text = "Delete Book";
            // 
            // text_deletebook_pyear
            // 
            text_deletebook_pyear.BackColor = Color.CadetBlue;
            text_deletebook_pyear.BorderStyle = BorderStyle.FixedSingle;
            text_deletebook_pyear.Location = new Point(192, 258);
            text_deletebook_pyear.Name = "text_deletebook_pyear";
            text_deletebook_pyear.Size = new Size(216, 30);
            text_deletebook_pyear.TabIndex = 3;
            // 
            // label_deletebook_pyear
            // 
            label_deletebook_pyear.AutoSize = true;
            label_deletebook_pyear.ForeColor = Color.DarkCyan;
            label_deletebook_pyear.Location = new Point(28, 260);
            label_deletebook_pyear.Name = "label_deletebook_pyear";
            label_deletebook_pyear.Size = new Size(146, 23);
            label_deletebook_pyear.TabIndex = 14;
            label_deletebook_pyear.Text = "Publication Year : ";
            // 
            // button_deletebook_back
            // 
            button_deletebook_back.BackColor = Color.CadetBlue;
            button_deletebook_back.Location = new Point(420, 415);
            button_deletebook_back.Name = "button_deletebook_back";
            button_deletebook_back.Size = new Size(137, 39);
            button_deletebook_back.TabIndex = 5;
            button_deletebook_back.Text = "Back";
            button_deletebook_back.UseVisualStyleBackColor = false;
            button_deletebook_back.Click += button_deletebook_back_Click;
            // 
            // button_deletebook_remove
            // 
            button_deletebook_remove.BackColor = Color.CadetBlue;
            button_deletebook_remove.Location = new Point(220, 335);
            button_deletebook_remove.Name = "button_deletebook_remove";
            button_deletebook_remove.Size = new Size(140, 46);
            button_deletebook_remove.TabIndex = 4;
            button_deletebook_remove.Text = "Remove";
            button_deletebook_remove.UseVisualStyleBackColor = false;
            button_deletebook_remove.Click += button_deletebook_remove_Click;
            // 
            // Delete_Book
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(582, 483);
            Controls.Add(button_deletebook_back);
            Controls.Add(button_deletebook_remove);
            Controls.Add(label_deletebook_pyear);
            Controls.Add(label_deletebook_author);
            Controls.Add(label_deletebook_title);
            Controls.Add(text_deletebook_pyear);
            Controls.Add(text_deletebook_author);
            Controls.Add(text_deletebook_title);
            Controls.Add(label_deletebook_head);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "Delete_Book";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Delete_Book";
            Load += Delete_Book_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public TextBox text_deletebook_author;
        public TextBox text_deletebook_title;
        public TextBox text_deletebook_pyear;
        private Label label_deletebook_title;
        private Label label_deletebook_author;
        private Label label_deletebook_head;
        private Label label_deletebook_pyear;
        private Button button_deletebook_back;
        private Button button_deletebook_remove;
    }
}