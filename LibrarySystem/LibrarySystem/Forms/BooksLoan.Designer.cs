namespace LibrarySystem.Forms
{
    partial class BooksLoan
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
            label_booksloan_head = new Label();
            datagridview_booksloan = new DataGridView();
            button_listmember_back = new Button();
            ((System.ComponentModel.ISupportInitialize)datagridview_booksloan).BeginInit();
            SuspendLayout();
            // 
            // label_booksloan_head
            // 
            label_booksloan_head.AutoSize = true;
            label_booksloan_head.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_booksloan_head.Location = new Point(431, 23);
            label_booksloan_head.Name = "label_booksloan_head";
            label_booksloan_head.Size = new Size(214, 41);
            label_booksloan_head.TabIndex = 0;
            label_booksloan_head.Text = "Books on Loan";
            label_booksloan_head.Click += label_booksloan_head_Click;
            // 
            // datagridview_booksloan
            // 
            datagridview_booksloan.AllowUserToAddRows = false;
            datagridview_booksloan.AllowUserToDeleteRows = false;
            datagridview_booksloan.AllowUserToResizeColumns = false;
            datagridview_booksloan.AllowUserToResizeRows = false;
            datagridview_booksloan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            datagridview_booksloan.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            datagridview_booksloan.BackgroundColor = Color.DarkSlateGray;
            datagridview_booksloan.BorderStyle = BorderStyle.None;
            datagridview_booksloan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            datagridview_booksloan.Location = new Point(12, 84);
            datagridview_booksloan.MultiSelect = false;
            datagridview_booksloan.Name = "datagridview_booksloan";
            datagridview_booksloan.ReadOnly = true;
            datagridview_booksloan.RowHeadersVisible = false;
            datagridview_booksloan.RowHeadersWidth = 51;
            datagridview_booksloan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            datagridview_booksloan.Size = new Size(1112, 449);
            datagridview_booksloan.TabIndex = 1;
            // 
            // button_listmember_back
            // 
            button_listmember_back.BackColor = Color.CadetBlue;
            button_listmember_back.ForeColor = SystemColors.Desktop;
            button_listmember_back.Location = new Point(987, 557);
            button_listmember_back.Name = "button_listmember_back";
            button_listmember_back.Size = new Size(137, 35);
            button_listmember_back.TabIndex = 3;
            button_listmember_back.Text = "Back";
            button_listmember_back.UseVisualStyleBackColor = false;
            button_listmember_back.Click += button_listmember_back_Click;
            // 
            // BooksLoan
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(1136, 604);
            Controls.Add(button_listmember_back);
            Controls.Add(datagridview_booksloan);
            Controls.Add(label_booksloan_head);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.DarkCyan;
            Name = "BooksLoan";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BooksLoan";
            Load += BooksLoan_Load;
            ((System.ComponentModel.ISupportInitialize)datagridview_booksloan).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public DataGridView datagridview_booksloan;
        private Label label_booksloan_head;
        private Button button_listmember_back;
    }
}