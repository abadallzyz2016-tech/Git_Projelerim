namespace StudentManagementSystem.Forms
{
    partial class StudentDeleteForm
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
            label_deletestudent_studentid = new Label();
            label_deletestudent_studentname = new Label();
            label_deletestudent_studentsurname = new Label();
            label_deletestudent_studentinformation = new Label();
            text_deletestudent_id = new TextBox();
            text_deletestudent_name = new TextBox();
            text_deletestudent_surname = new TextBox();
            button_deletestudent_back = new Button();
            button_deletestudent_delete = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(303, 56);
            label1.Name = "label1";
            label1.Size = new Size(288, 41);
            label1.TabIndex = 0;
            label1.Text = "Delete Student Page";
            // 
            // label_deletestudent_studentid
            // 
            label_deletestudent_studentid.AutoSize = true;
            label_deletestudent_studentid.BorderStyle = BorderStyle.Fixed3D;
            label_deletestudent_studentid.Font = new Font("Segoe UI", 10.8F);
            label_deletestudent_studentid.Location = new Point(46, 206);
            label_deletestudent_studentid.Name = "label_deletestudent_studentid";
            label_deletestudent_studentid.Size = new Size(46, 27);
            label_deletestudent_studentid.TabIndex = 1;
            label_deletestudent_studentid.Text = "ID : ";
            label_deletestudent_studentid.Click += label_deletestudent_studentid_Click;
            // 
            // label_deletestudent_studentname
            // 
            label_deletestudent_studentname.AutoSize = true;
            label_deletestudent_studentname.BorderStyle = BorderStyle.Fixed3D;
            label_deletestudent_studentname.Font = new Font("Segoe UI", 10.8F);
            label_deletestudent_studentname.Location = new Point(46, 251);
            label_deletestudent_studentname.Name = "label_deletestudent_studentname";
            label_deletestudent_studentname.Size = new Size(75, 27);
            label_deletestudent_studentname.TabIndex = 1;
            label_deletestudent_studentname.Text = "Name : ";
            label_deletestudent_studentname.Click += label_deletestudent_studentname_Click;
            // 
            // label_deletestudent_studentsurname
            // 
            label_deletestudent_studentsurname.AutoSize = true;
            label_deletestudent_studentsurname.BorderStyle = BorderStyle.Fixed3D;
            label_deletestudent_studentsurname.Font = new Font("Segoe UI", 10.8F);
            label_deletestudent_studentsurname.Location = new Point(46, 300);
            label_deletestudent_studentsurname.Name = "label_deletestudent_studentsurname";
            label_deletestudent_studentsurname.Size = new Size(98, 27);
            label_deletestudent_studentsurname.TabIndex = 1;
            label_deletestudent_studentsurname.Text = "Surname : ";
            label_deletestudent_studentsurname.Click += label_deletestudent_studentsurname_Click;
            // 
            // label_deletestudent_studentinformation
            // 
            label_deletestudent_studentinformation.AutoSize = true;
            label_deletestudent_studentinformation.Font = new Font("Segoe UI", 10.8F);
            label_deletestudent_studentinformation.Location = new Point(46, 150);
            label_deletestudent_studentinformation.Name = "label_deletestudent_studentinformation";
            label_deletestudent_studentinformation.Size = new Size(177, 25);
            label_deletestudent_studentinformation.TabIndex = 1;
            label_deletestudent_studentinformation.Text = "Student Information ";
            label_deletestudent_studentinformation.Click += label_deletestudent_studentinformation_Click;
            // 
            // text_deletestudent_id
            // 
            text_deletestudent_id.BorderStyle = BorderStyle.FixedSingle;
            text_deletestudent_id.Location = new Point(171, 207);
            text_deletestudent_id.Name = "text_deletestudent_id";
            text_deletestudent_id.Size = new Size(145, 27);
            text_deletestudent_id.TabIndex = 0;
            // 
            // text_deletestudent_name
            // 
            text_deletestudent_name.BorderStyle = BorderStyle.FixedSingle;
            text_deletestudent_name.Location = new Point(171, 252);
            text_deletestudent_name.Name = "text_deletestudent_name";
            text_deletestudent_name.Size = new Size(145, 27);
            text_deletestudent_name.TabIndex = 1;
            // 
            // text_deletestudent_surname
            // 
            text_deletestudent_surname.BorderStyle = BorderStyle.FixedSingle;
            text_deletestudent_surname.Location = new Point(171, 301);
            text_deletestudent_surname.Name = "text_deletestudent_surname";
            text_deletestudent_surname.Size = new Size(145, 27);
            text_deletestudent_surname.TabIndex = 2;
            // 
            // button_deletestudent_back
            // 
            button_deletestudent_back.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_deletestudent_back.Location = new Point(747, 474);
            button_deletestudent_back.Name = "button_deletestudent_back";
            button_deletestudent_back.Size = new Size(114, 39);
            button_deletestudent_back.TabIndex = 4;
            button_deletestudent_back.Text = "Back";
            button_deletestudent_back.UseVisualStyleBackColor = true;
            button_deletestudent_back.Click += button_deletestudent_back_Click;
            // 
            // button_deletestudent_delete
            // 
            button_deletestudent_delete.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_deletestudent_delete.Location = new Point(34, 475);
            button_deletestudent_delete.Name = "button_deletestudent_delete";
            button_deletestudent_delete.Size = new Size(137, 39);
            button_deletestudent_delete.TabIndex = 3;
            button_deletestudent_delete.Text = "Delete";
            button_deletestudent_delete.UseVisualStyleBackColor = true;
            button_deletestudent_delete.Click += button_deletestudent_delete_Click;
            // 
            // StudentDeleteForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(934, 569);
            Controls.Add(button_deletestudent_delete);
            Controls.Add(button_deletestudent_back);
            Controls.Add(text_deletestudent_surname);
            Controls.Add(text_deletestudent_name);
            Controls.Add(text_deletestudent_id);
            Controls.Add(label_deletestudent_studentsurname);
            Controls.Add(label_deletestudent_studentname);
            Controls.Add(label_deletestudent_studentinformation);
            Controls.Add(label_deletestudent_studentid);
            Controls.Add(label1);
            Name = "StudentDeleteForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DeleteStudent";
            Load += DeleteStudentForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label_deletestudent_studentid;
        private Label label_deletestudent_studentname;
        private Label label_deletestudent_studentsurname;
        private Label label_deletestudent_studentinformation;
        public TextBox text_deletestudent_id;
        public TextBox text_deletestudent_name;
        public TextBox text_deletestudent_surname;
        public Button button_deletestudent_back;
        public Button button_deletestudent_delete;
    }
}