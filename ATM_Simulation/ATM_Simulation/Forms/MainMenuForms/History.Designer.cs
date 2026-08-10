namespace ATM_Simulasyonu.Forms.MainMenuForms
{
    partial class History
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
            dgv_history = new DataGridView();
            ColumnDate = new DataGridViewTextBoxColumn();
            ColumnType = new DataGridViewTextBoxColumn();
            ColumnAmount = new DataGridViewTextBoxColumn();
            ColumnBalance = new DataGridViewTextBoxColumn();
            ColumnDescription = new DataGridViewTextBoxColumn();
            label_history_aeaatm = new Label();
            label_history_accountid = new Label();
            button_history_back = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_history).BeginInit();
            SuspendLayout();
            // 
            // dgv_history
            // 
            dgv_history.AllowUserToAddRows = false;
            dgv_history.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_history.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgv_history.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_history.Columns.AddRange(new DataGridViewColumn[] { ColumnDate, ColumnType, ColumnAmount, ColumnBalance, ColumnDescription });
            dgv_history.Location = new Point(12, 211);
            dgv_history.Name = "dgv_history";
            dgv_history.ReadOnly = true;
            dgv_history.RowHeadersWidth = 51;
            dgv_history.Size = new Size(735, 293);
            dgv_history.TabIndex = 0;
            // 
            // ColumnDate
            // 
            ColumnDate.HeaderText = "Date";
            ColumnDate.MinimumWidth = 6;
            ColumnDate.Name = "ColumnDate";
            ColumnDate.ReadOnly = true;
            // 
            // ColumnType
            // 
            ColumnType.HeaderText = "Type";
            ColumnType.MinimumWidth = 6;
            ColumnType.Name = "ColumnType";
            ColumnType.ReadOnly = true;
            // 
            // ColumnAmount
            // 
            ColumnAmount.HeaderText = "Amount";
            ColumnAmount.MinimumWidth = 6;
            ColumnAmount.Name = "ColumnAmount";
            ColumnAmount.ReadOnly = true;
            // 
            // ColumnBalance
            // 
            ColumnBalance.HeaderText = "Balance";
            ColumnBalance.MinimumWidth = 6;
            ColumnBalance.Name = "ColumnBalance";
            ColumnBalance.ReadOnly = true;
            // 
            // ColumnDescription
            // 
            ColumnDescription.HeaderText = "Description";
            ColumnDescription.MinimumWidth = 6;
            ColumnDescription.Name = "ColumnDescription";
            ColumnDescription.ReadOnly = true;
            // 
            // label_history_aeaatm
            // 
            label_history_aeaatm.AutoSize = true;
            label_history_aeaatm.BorderStyle = BorderStyle.Fixed3D;
            label_history_aeaatm.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_history_aeaatm.Location = new Point(289, 38);
            label_history_aeaatm.Name = "label_history_aeaatm";
            label_history_aeaatm.Size = new Size(138, 43);
            label_history_aeaatm.TabIndex = 1;
            label_history_aeaatm.Text = "Aea ATM";
            // 
            // label_history_accountid
            // 
            label_history_accountid.AutoSize = true;
            label_history_accountid.BorderStyle = BorderStyle.Fixed3D;
            label_history_accountid.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_history_accountid.Location = new Point(12, 111);
            label_history_accountid.Name = "label_history_accountid";
            label_history_accountid.Size = new Size(116, 27);
            label_history_accountid.TabIndex = 2;
            label_history_accountid.Text = "Account ID : ";
            label_history_accountid.Click += label_history_accountid_Click;
            // 
            // button_history_back
            // 
            button_history_back.FlatStyle = FlatStyle.Popup;
            button_history_back.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_history_back.Location = new Point(624, 543);
            button_history_back.Name = "button_history_back";
            button_history_back.Size = new Size(103, 32);
            button_history_back.TabIndex = 3;
            button_history_back.Text = "Back";
            button_history_back.UseVisualStyleBackColor = true;
            button_history_back.Click += button_history_back_Click;
            // 
            // History
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(759, 603);
            Controls.Add(button_history_back);
            Controls.Add(label_history_accountid);
            Controls.Add(label_history_aeaatm);
            Controls.Add(dgv_history);
            Name = "History";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "History";
            Load += History_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_history).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_history;
        private DataGridViewTextBoxColumn ColumnDate;
        private DataGridViewTextBoxColumn ColumnType;
        private DataGridViewTextBoxColumn ColumnAmount;
        private DataGridViewTextBoxColumn ColumnBalance;
        private DataGridViewTextBoxColumn ColumnDescription;
        private Label label_history_aeaatm;
        private Label label_history_accountid;
        private Button button_history_back;
    }
}