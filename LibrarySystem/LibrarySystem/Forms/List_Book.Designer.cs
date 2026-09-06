namespace LibrarySystem.Forms
{
    partial class List_Book
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
            datagridview_listbook = new DataGridView();
            label2 = new Label();
            button_listbook_back = new Button();
            ((System.ComponentModel.ISupportInitialize)datagridview_listbook).BeginInit();
            SuspendLayout();
            // 
            // datagridview_listbook
            // 
            datagridview_listbook.AllowUserToAddRows = false;
            datagridview_listbook.AllowUserToDeleteRows = false;
            datagridview_listbook.AllowUserToResizeColumns = false;
            datagridview_listbook.AllowUserToResizeRows = false;
            datagridview_listbook.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            datagridview_listbook.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            datagridview_listbook.BackgroundColor = Color.DarkSlateGray;
            datagridview_listbook.BorderStyle = BorderStyle.None;
            datagridview_listbook.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            datagridview_listbook.Location = new Point(12, 112);
            datagridview_listbook.MultiSelect = false;
            datagridview_listbook.Name = "datagridview_listbook";
            datagridview_listbook.ReadOnly = true;
            datagridview_listbook.RowHeadersVisible = false;
            datagridview_listbook.RowHeadersWidth = 51;
            datagridview_listbook.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            datagridview_listbook.Size = new Size(1100, 449);
            datagridview_listbook.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(493, 9);
            label2.Name = "label2";
            label2.Size = new Size(138, 41);
            label2.TabIndex = 2;
            label2.Text = "List Book";
            // 
            // button_listbook_back
            // 
            button_listbook_back.BackColor = Color.CadetBlue;
            button_listbook_back.ForeColor = SystemColors.Desktop;
            button_listbook_back.Location = new Point(975, 567);
            button_listbook_back.Name = "button_listbook_back";
            button_listbook_back.Size = new Size(137, 35);
            button_listbook_back.TabIndex = 1;
            button_listbook_back.Text = "Back";
            button_listbook_back.UseVisualStyleBackColor = false;
            button_listbook_back.Click += button_listbook_back_Click;
            // 
            // List_Book
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(1124, 614);
            Controls.Add(button_listbook_back);
            Controls.Add(label2);
            Controls.Add(datagridview_listbook);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.DarkCyan;
            Name = "List_Book";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "List_Book";
            Load += List_Book_Load;
            ((System.ComponentModel.ISupportInitialize)datagridview_listbook).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public DataGridView datagridview_listbook;
        private Label label2;
        private Button button_listbook_back;
    }
}