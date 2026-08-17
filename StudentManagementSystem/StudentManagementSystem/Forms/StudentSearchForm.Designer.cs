namespace StudentManagementSystem.Forms
{
    partial class StudentSearchForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            text_studentsearch_id = new TextBox();
            text_studentsearch_name = new TextBox();
            text_studentsearch_surname = new TextBox();
            text_studentsearch_age = new TextBox();
            text_studentsearch_department = new TextBox();
            text_studentsearch_average = new TextBox();
            text_studentsearch_sex = new TextBox();
            button_studentsearch_back = new Button();
            button_studentsearch_search = new Button();
            label9 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(284, 33);
            label1.Name = "label1";
            label1.Size = new Size(290, 41);
            label1.TabIndex = 0;
            label1.Text = "Student Search Page";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Font = new Font("Segoe UI", 10.2F);
            label2.Location = new Point(35, 163);
            label2.Name = "label2";
            label2.Size = new Size(107, 25);
            label2.TabIndex = 1;
            label2.Text = "Student ID : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BorderStyle = BorderStyle.Fixed3D;
            label3.Font = new Font("Segoe UI", 10.2F);
            label3.Location = new Point(35, 221);
            label3.Name = "label3";
            label3.Size = new Size(72, 25);
            label3.TabIndex = 1;
            label3.Text = "Name : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BorderStyle = BorderStyle.Fixed3D;
            label4.Font = new Font("Segoe UI", 10.2F);
            label4.Location = new Point(35, 260);
            label4.Name = "label4";
            label4.Size = new Size(94, 25);
            label4.TabIndex = 1;
            label4.Text = "Surname : ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BorderStyle = BorderStyle.Fixed3D;
            label5.Font = new Font("Segoe UI", 10.2F);
            label5.Location = new Point(35, 303);
            label5.Name = "label5";
            label5.Size = new Size(56, 25);
            label5.TabIndex = 1;
            label5.Text = "Age : ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BorderStyle = BorderStyle.Fixed3D;
            label6.Font = new Font("Segoe UI", 10.2F);
            label6.Location = new Point(35, 344);
            label6.Name = "label6";
            label6.Size = new Size(52, 25);
            label6.TabIndex = 1;
            label6.Text = "Sex : ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BorderStyle = BorderStyle.Fixed3D;
            label7.Font = new Font("Segoe UI", 10.2F);
            label7.Location = new Point(35, 389);
            label7.Name = "label7";
            label7.Size = new Size(118, 25);
            label7.TabIndex = 1;
            label7.Text = "Department : ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BorderStyle = BorderStyle.Fixed3D;
            label8.Font = new Font("Segoe UI", 10.2F);
            label8.Location = new Point(35, 429);
            label8.Name = "label8";
            label8.Size = new Size(88, 25);
            label8.TabIndex = 1;
            label8.Text = "Average : ";
            // 
            // text_studentsearch_id
            // 
            text_studentsearch_id.Location = new Point(170, 162);
            text_studentsearch_id.Name = "text_studentsearch_id";
            text_studentsearch_id.Size = new Size(164, 27);
            text_studentsearch_id.TabIndex = 0;
            // 
            // text_studentsearch_name
            // 
            text_studentsearch_name.Location = new Point(170, 220);
            text_studentsearch_name.Name = "text_studentsearch_name";
            text_studentsearch_name.ReadOnly = true;
            text_studentsearch_name.Size = new Size(164, 27);
            text_studentsearch_name.TabIndex = 0;
            text_studentsearch_name.TabStop = false;
            // 
            // text_studentsearch_surname
            // 
            text_studentsearch_surname.Location = new Point(170, 259);
            text_studentsearch_surname.Name = "text_studentsearch_surname";
            text_studentsearch_surname.ReadOnly = true;
            text_studentsearch_surname.Size = new Size(164, 27);
            text_studentsearch_surname.TabIndex = 0;
            text_studentsearch_surname.TabStop = false;
            // 
            // text_studentsearch_age
            // 
            text_studentsearch_age.Location = new Point(170, 302);
            text_studentsearch_age.Name = "text_studentsearch_age";
            text_studentsearch_age.ReadOnly = true;
            text_studentsearch_age.Size = new Size(164, 27);
            text_studentsearch_age.TabIndex = 2;
            text_studentsearch_age.TabStop = false;
            // 
            // text_studentsearch_department
            // 
            text_studentsearch_department.Location = new Point(170, 385);
            text_studentsearch_department.Name = "text_studentsearch_department";
            text_studentsearch_department.ReadOnly = true;
            text_studentsearch_department.Size = new Size(164, 27);
            text_studentsearch_department.TabIndex = 2;
            text_studentsearch_department.TabStop = false;
            // 
            // text_studentsearch_average
            // 
            text_studentsearch_average.Location = new Point(170, 425);
            text_studentsearch_average.Name = "text_studentsearch_average";
            text_studentsearch_average.ReadOnly = true;
            text_studentsearch_average.Size = new Size(164, 27);
            text_studentsearch_average.TabIndex = 2;
            text_studentsearch_average.TabStop = false;
            // 
            // text_studentsearch_sex
            // 
            text_studentsearch_sex.Location = new Point(170, 343);
            text_studentsearch_sex.Name = "text_studentsearch_sex";
            text_studentsearch_sex.ReadOnly = true;
            text_studentsearch_sex.Size = new Size(164, 27);
            text_studentsearch_sex.TabIndex = 2;
            text_studentsearch_sex.TabStop = false;
            // 
            // button_studentsearch_back
            // 
            button_studentsearch_back.Font = new Font("Segoe UI", 10.2F);
            button_studentsearch_back.Location = new Point(773, 506);
            button_studentsearch_back.Name = "button_studentsearch_back";
            button_studentsearch_back.Size = new Size(120, 39);
            button_studentsearch_back.TabIndex = 2;
            button_studentsearch_back.Text = "Back";
            button_studentsearch_back.UseVisualStyleBackColor = true;
            button_studentsearch_back.Click += button_studentsearch_back_Click;
            // 
            // button_studentsearch_search
            // 
            button_studentsearch_search.Font = new Font("Segoe UI", 10.2F);
            button_studentsearch_search.Location = new Point(35, 506);
            button_studentsearch_search.Name = "button_studentsearch_search";
            button_studentsearch_search.Size = new Size(120, 39);
            button_studentsearch_search.TabIndex = 1;
            button_studentsearch_search.Text = "Search";
            button_studentsearch_search.UseVisualStyleBackColor = true;
            button_studentsearch_search.Click += button_studentsearch_search_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.WindowText;
            label9.Location = new Point(35, 112);
            label9.Name = "label9";
            label9.Size = new Size(146, 25);
            label9.TabIndex = 0;
            label9.Text = "Enter Student ID ";
            // 
            // StudentSearchForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(934, 569);
            Controls.Add(button_studentsearch_search);
            Controls.Add(button_studentsearch_back);
            Controls.Add(text_studentsearch_sex);
            Controls.Add(text_studentsearch_average);
            Controls.Add(text_studentsearch_age);
            Controls.Add(text_studentsearch_name);
            Controls.Add(text_studentsearch_department);
            Controls.Add(text_studentsearch_surname);
            Controls.Add(text_studentsearch_id);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label9);
            Controls.Add(label1);
            Name = "StudentSearchForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StudentSearch";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        public TextBox text_studentsearch_id;
        public TextBox text_studentsearch_name;
        public TextBox text_studentsearch_surname;
        public TextBox text_studentsearch_age;
        public TextBox text_studentsearch_department;
        public TextBox text_studentsearch_average;
        public TextBox text_studentsearch_sex;
        public Button button_studentsearch_back;
        public Button button_studentsearch_search;
    }
}