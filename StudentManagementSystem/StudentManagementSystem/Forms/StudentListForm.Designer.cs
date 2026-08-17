namespace StudentManagementSystem.Forms
{
    partial class StudentListForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            dataGridView_students = new DataGridView();
            label1 = new Label();
            button_studentlist_back = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView_students).BeginInit();
            SuspendLayout();
            // 
            // dataGridView_students
            // 
            dataGridView_students.AllowUserToAddRows = false;
            dataGridView_students.AllowUserToDeleteRows = false;
            dataGridView_students.AllowUserToResizeColumns = false;
            dataGridView_students.AllowUserToResizeRows = false;
            dataGridView_students.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_students.BackgroundColor = SystemColors.Info;
            dataGridView_students.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView_students.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView_students.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView_students.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView_students.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridView_students.Location = new Point(0, 122);
            dataGridView_students.MultiSelect = false;
            dataGridView_students.Name = "dataGridView_students";
            dataGridView_students.ReadOnly = true;
            dataGridView_students.RowHeadersVisible = false;
            dataGridView_students.RowHeadersWidth = 51;
            dataGridView_students.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView_students.Size = new Size(1092, 455);
            dataGridView_students.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(407, 23);
            label1.Name = "label1";
            label1.Size = new Size(246, 41);
            label1.TabIndex = 1;
            label1.Text = "Student List Page";
            // 
            // button_studentlist_back
            // 
            button_studentlist_back.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_studentlist_back.Location = new Point(935, 633);
            button_studentlist_back.Name = "button_studentlist_back";
            button_studentlist_back.Size = new Size(124, 38);
            button_studentlist_back.TabIndex = 2;
            button_studentlist_back.Text = "Back";
            button_studentlist_back.UseVisualStyleBackColor = true;
            button_studentlist_back.Click += button_studentlist_back_Click;
            // 
            // StudentListForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(1093, 703);
            Controls.Add(button_studentlist_back);
            Controls.Add(label1);
            Controls.Add(dataGridView_students);
            Name = "StudentListForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StudentListForm";
            Load += StudentListForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView_students).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dataGridView_students;
        private Label label1;
        private Button button_studentlist_back;
    }
}