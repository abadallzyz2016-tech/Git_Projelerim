namespace LibrarySystem.Forms
{
    partial class List_Member
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
            datagridview_listmember = new DataGridView();
            button_listmember_back = new Button();
            label_listmember_head = new Label();
            ((System.ComponentModel.ISupportInitialize)datagridview_listmember).BeginInit();
            SuspendLayout();
            // 
            // datagridview_listmember
            // 
            datagridview_listmember.AllowUserToAddRows = false;
            datagridview_listmember.AllowUserToDeleteRows = false;
            datagridview_listmember.AllowUserToResizeColumns = false;
            datagridview_listmember.AllowUserToResizeRows = false;
            datagridview_listmember.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            datagridview_listmember.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            datagridview_listmember.BackgroundColor = Color.DarkSlateGray;
            datagridview_listmember.BorderStyle = BorderStyle.None;
            datagridview_listmember.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            datagridview_listmember.Location = new Point(12, 87);
            datagridview_listmember.MultiSelect = false;
            datagridview_listmember.Name = "datagridview_listmember";
            datagridview_listmember.ReadOnly = true;
            datagridview_listmember.RowHeadersVisible = false;
            datagridview_listmember.RowHeadersWidth = 51;
            datagridview_listmember.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            datagridview_listmember.Size = new Size(1243, 516);
            datagridview_listmember.TabIndex = 1;
            // 
            // button_listmember_back
            // 
            button_listmember_back.BackColor = Color.CadetBlue;
            button_listmember_back.ForeColor = SystemColors.Desktop;
            button_listmember_back.Location = new Point(1105, 622);
            button_listmember_back.Name = "button_listmember_back";
            button_listmember_back.Size = new Size(137, 35);
            button_listmember_back.TabIndex = 2;
            button_listmember_back.Text = "Back";
            button_listmember_back.UseVisualStyleBackColor = false;
            button_listmember_back.Click += button_listmember_back_Click;
            // 
            // label_listmember_head
            // 
            label_listmember_head.AutoSize = true;
            label_listmember_head.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_listmember_head.Location = new Point(545, 19);
            label_listmember_head.Name = "label_listmember_head";
            label_listmember_head.Size = new Size(183, 41);
            label_listmember_head.TabIndex = 3;
            label_listmember_head.Text = "List Member";
            // 
            // List_Member
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(1267, 669);
            Controls.Add(label_listmember_head);
            Controls.Add(button_listmember_back);
            Controls.Add(datagridview_listmember);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.DarkCyan;
            Name = "List_Member";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "List_Member";
            Load += List_Member_Load;
            ((System.ComponentModel.ISupportInitialize)datagridview_listmember).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public DataGridView datagridview_listmember;
        private Button button_listmember_back;
        private Label label_listmember_head;
    }
}