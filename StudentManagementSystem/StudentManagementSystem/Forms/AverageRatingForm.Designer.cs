namespace StudentManagementSystem.Forms
{
    partial class AverageRatingForm
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
            button_averagerating_back = new Button();
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
            dataGridView_students.Location = new Point(1, 134);
            dataGridView_students.MultiSelect = false;
            dataGridView_students.Name = "dataGridView_students";
            dataGridView_students.ReadOnly = true;
            dataGridView_students.RowHeadersVisible = false;
            dataGridView_students.RowHeadersWidth = 51;
            dataGridView_students.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView_students.Size = new Size(1092, 455);
            dataGridView_students.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(390, 26);
            label1.Name = "label1";
            label1.Size = new Size(291, 41);
            label1.TabIndex = 2;
            label1.Text = "Average Rating Page";
            // 
            // button_averagerating_back
            // 
            button_averagerating_back.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_averagerating_back.Location = new Point(934, 619);
            button_averagerating_back.Name = "button_averagerating_back";
            button_averagerating_back.Size = new Size(137, 35);
            button_averagerating_back.TabIndex = 3;
            button_averagerating_back.Text = "Back";
            button_averagerating_back.UseVisualStyleBackColor = true;
            button_averagerating_back.Click += button_averagerating_back_Click;
            // 
            // AverageRatingForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(1095, 679);
            Controls.Add(button_averagerating_back);
            Controls.Add(label1);
            Controls.Add(dataGridView_students);
            Name = "AverageRatingForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AverageRating";
            Load += AverageRatingForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView_students).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView_students;
        private Label label1;
        private Button button_averagerating_back;
    }
}