namespace LibrarySystem.Forms
{
    partial class LoanHistory
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
            label_loanhistory_head = new Label();
            label_loanhistory_memberid = new Label();
            text_loanhistory_memberid = new TextBox();
            datagridview_loanhistory = new DataGridView();
            button_loanhistory_back = new Button();
            button_loanhistory_find = new Button();
            ((System.ComponentModel.ISupportInitialize)datagridview_loanhistory).BeginInit();
            SuspendLayout();
            // 
            // label_loanhistory_head
            // 
            label_loanhistory_head.AutoSize = true;
            label_loanhistory_head.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_loanhistory_head.Location = new Point(410, 26);
            label_loanhistory_head.Name = "label_loanhistory_head";
            label_loanhistory_head.Size = new Size(184, 41);
            label_loanhistory_head.TabIndex = 1;
            label_loanhistory_head.Text = "Loan History";
            // 
            // label_loanhistory_memberid
            // 
            label_loanhistory_memberid.AutoSize = true;
            label_loanhistory_memberid.Location = new Point(12, 101);
            label_loanhistory_memberid.Name = "label_loanhistory_memberid";
            label_loanhistory_memberid.Size = new Size(110, 23);
            label_loanhistory_memberid.TabIndex = 2;
            label_loanhistory_memberid.Text = "Member ID : ";
            // 
            // text_loanhistory_memberid
            // 
            text_loanhistory_memberid.Location = new Point(140, 98);
            text_loanhistory_memberid.Name = "text_loanhistory_memberid";
            text_loanhistory_memberid.Size = new Size(165, 30);
            text_loanhistory_memberid.TabIndex = 3;
            // 
            // datagridview_loanhistory
            // 
            datagridview_loanhistory.AllowUserToAddRows = false;
            datagridview_loanhistory.AllowUserToDeleteRows = false;
            datagridview_loanhistory.AllowUserToResizeColumns = false;
            datagridview_loanhistory.AllowUserToResizeRows = false;
            datagridview_loanhistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            datagridview_loanhistory.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            datagridview_loanhistory.BackgroundColor = Color.DarkSlateGray;
            datagridview_loanhistory.BorderStyle = BorderStyle.None;
            datagridview_loanhistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            datagridview_loanhistory.Location = new Point(12, 153);
            datagridview_loanhistory.MultiSelect = false;
            datagridview_loanhistory.Name = "datagridview_loanhistory";
            datagridview_loanhistory.ReadOnly = true;
            datagridview_loanhistory.RowHeadersVisible = false;
            datagridview_loanhistory.RowHeadersWidth = 51;
            datagridview_loanhistory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            datagridview_loanhistory.Size = new Size(969, 308);
            datagridview_loanhistory.TabIndex = 4;
            // 
            // button_loanhistory_back
            // 
            button_loanhistory_back.BackColor = Color.CadetBlue;
            button_loanhistory_back.ForeColor = SystemColors.Desktop;
            button_loanhistory_back.Location = new Point(835, 506);
            button_loanhistory_back.Name = "button_loanhistory_back";
            button_loanhistory_back.Size = new Size(137, 35);
            button_loanhistory_back.TabIndex = 5;
            button_loanhistory_back.Text = "Back";
            button_loanhistory_back.UseVisualStyleBackColor = false;
            button_loanhistory_back.Click += button_loanhistory_back_Click;
            // 
            // button_loanhistory_find
            // 
            button_loanhistory_find.BackColor = Color.CadetBlue;
            button_loanhistory_find.ForeColor = SystemColors.Desktop;
            button_loanhistory_find.Location = new Point(442, 486);
            button_loanhistory_find.Name = "button_loanhistory_find";
            button_loanhistory_find.Size = new Size(137, 35);
            button_loanhistory_find.TabIndex = 5;
            button_loanhistory_find.Text = "Find";
            button_loanhistory_find.UseVisualStyleBackColor = false;
            button_loanhistory_find.Click += button_loanhistory_find_Click;
            // 
            // LoanHistory
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(993, 564);
            Controls.Add(button_loanhistory_find);
            Controls.Add(button_loanhistory_back);
            Controls.Add(datagridview_loanhistory);
            Controls.Add(text_loanhistory_memberid);
            Controls.Add(label_loanhistory_memberid);
            Controls.Add(label_loanhistory_head);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.DarkCyan;
            Name = "LoanHistory";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoanHistory";
            Load += LoanHistory_Load;
            ((System.ComponentModel.ISupportInitialize)datagridview_loanhistory).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_loanhistory_head;
        private Label label_loanhistory_memberid;
        public TextBox text_loanhistory_memberid;
        public DataGridView datagridview_loanhistory;
        private Button button_loanhistory_back;
        private Button button_loanhistory_find;
    }
}