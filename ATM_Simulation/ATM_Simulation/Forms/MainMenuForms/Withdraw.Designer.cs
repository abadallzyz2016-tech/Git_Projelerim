namespace ATM_Simulasyonu.Forms.MainMenuForms
{
    partial class Withdraw
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
            label_withdraw_head = new Label();
            label_withdraw_withdrawmoney = new Label();
            rdobutton_withdraw_50 = new RadioButton();
            rdobutton_withdraw_100 = new RadioButton();
            rdobutton_withdraw_200 = new RadioButton();
            rdobutton_withdraw_500 = new RadioButton();
            rdobutton_withdraw_5000 = new RadioButton();
            rdobutton_withdraw_other = new RadioButton();
            rdobutton_withdraw_1000 = new RadioButton();
            rdobutton_withdraw_2000 = new RadioButton();
            label_withdraw_availablebalance = new Label();
            label1 = new Label();
            button_withdraw_withdraw = new Button();
            button_withdraw_cancel = new Button();
            label_withdraw_enteramount = new Label();
            text_withdraw_enteramount = new TextBox();
            SuspendLayout();
            // 
            // label_withdraw_head
            // 
            label_withdraw_head.AutoSize = true;
            label_withdraw_head.BorderStyle = BorderStyle.Fixed3D;
            label_withdraw_head.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_withdraw_head.Location = new Point(228, 34);
            label_withdraw_head.Name = "label_withdraw_head";
            label_withdraw_head.Size = new Size(138, 43);
            label_withdraw_head.TabIndex = 0;
            label_withdraw_head.Text = "Aea ATM";
            // 
            // label_withdraw_withdrawmoney
            // 
            label_withdraw_withdrawmoney.AllowDrop = true;
            label_withdraw_withdrawmoney.AutoSize = true;
            label_withdraw_withdrawmoney.BorderStyle = BorderStyle.FixedSingle;
            label_withdraw_withdrawmoney.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_withdraw_withdrawmoney.Location = new Point(202, 101);
            label_withdraw_withdrawmoney.Name = "label_withdraw_withdrawmoney";
            label_withdraw_withdrawmoney.Size = new Size(191, 33);
            label_withdraw_withdrawmoney.TabIndex = 0;
            label_withdraw_withdrawmoney.Text = "Withdraw Money";
            // 
            // rdobutton_withdraw_50
            // 
            rdobutton_withdraw_50.AutoSize = true;
            rdobutton_withdraw_50.Location = new Point(54, 315);
            rdobutton_withdraw_50.Name = "rdobutton_withdraw_50";
            rdobutton_withdraw_50.Size = new Size(58, 24);
            rdobutton_withdraw_50.TabIndex = 1;
            rdobutton_withdraw_50.TabStop = true;
            rdobutton_withdraw_50.Text = "50 $";
            rdobutton_withdraw_50.UseVisualStyleBackColor = true;
            // 
            // rdobutton_withdraw_100
            // 
            rdobutton_withdraw_100.AutoSize = true;
            rdobutton_withdraw_100.Location = new Point(54, 358);
            rdobutton_withdraw_100.Name = "rdobutton_withdraw_100";
            rdobutton_withdraw_100.Size = new Size(66, 24);
            rdobutton_withdraw_100.TabIndex = 2;
            rdobutton_withdraw_100.TabStop = true;
            rdobutton_withdraw_100.Text = "100 $";
            rdobutton_withdraw_100.UseVisualStyleBackColor = true;
            // 
            // rdobutton_withdraw_200
            // 
            rdobutton_withdraw_200.AutoSize = true;
            rdobutton_withdraw_200.Location = new Point(202, 315);
            rdobutton_withdraw_200.Name = "rdobutton_withdraw_200";
            rdobutton_withdraw_200.Size = new Size(66, 24);
            rdobutton_withdraw_200.TabIndex = 3;
            rdobutton_withdraw_200.TabStop = true;
            rdobutton_withdraw_200.Text = "200 $";
            rdobutton_withdraw_200.UseVisualStyleBackColor = true;
            // 
            // rdobutton_withdraw_500
            // 
            rdobutton_withdraw_500.AutoSize = true;
            rdobutton_withdraw_500.Location = new Point(202, 358);
            rdobutton_withdraw_500.Name = "rdobutton_withdraw_500";
            rdobutton_withdraw_500.Size = new Size(66, 24);
            rdobutton_withdraw_500.TabIndex = 4;
            rdobutton_withdraw_500.TabStop = true;
            rdobutton_withdraw_500.Text = "500 $";
            rdobutton_withdraw_500.UseVisualStyleBackColor = true;
            rdobutton_withdraw_500.CheckedChanged += radioButton4_CheckedChanged;
            // 
            // rdobutton_withdraw_5000
            // 
            rdobutton_withdraw_5000.AutoSize = true;
            rdobutton_withdraw_5000.Location = new Point(502, 315);
            rdobutton_withdraw_5000.Name = "rdobutton_withdraw_5000";
            rdobutton_withdraw_5000.Size = new Size(74, 24);
            rdobutton_withdraw_5000.TabIndex = 7;
            rdobutton_withdraw_5000.TabStop = true;
            rdobutton_withdraw_5000.Text = "5000 $";
            rdobutton_withdraw_5000.UseVisualStyleBackColor = true;
            // 
            // rdobutton_withdraw_other
            // 
            rdobutton_withdraw_other.AutoSize = true;
            rdobutton_withdraw_other.Location = new Point(502, 358);
            rdobutton_withdraw_other.Name = "rdobutton_withdraw_other";
            rdobutton_withdraw_other.Size = new Size(67, 24);
            rdobutton_withdraw_other.TabIndex = 8;
            rdobutton_withdraw_other.TabStop = true;
            rdobutton_withdraw_other.Text = "Other";
            rdobutton_withdraw_other.UseVisualStyleBackColor = true;
            rdobutton_withdraw_other.Click += rdobutton_withdraw_other_Checked;
            // 
            // rdobutton_withdraw_1000
            // 
            rdobutton_withdraw_1000.AutoSize = true;
            rdobutton_withdraw_1000.Location = new Point(364, 315);
            rdobutton_withdraw_1000.Name = "rdobutton_withdraw_1000";
            rdobutton_withdraw_1000.Size = new Size(78, 24);
            rdobutton_withdraw_1000.TabIndex = 5;
            rdobutton_withdraw_1000.TabStop = true;
            rdobutton_withdraw_1000.Text = "1000 $ ";
            rdobutton_withdraw_1000.UseVisualStyleBackColor = true;
            // 
            // rdobutton_withdraw_2000
            // 
            rdobutton_withdraw_2000.AutoSize = true;
            rdobutton_withdraw_2000.Location = new Point(364, 358);
            rdobutton_withdraw_2000.Name = "rdobutton_withdraw_2000";
            rdobutton_withdraw_2000.Size = new Size(74, 24);
            rdobutton_withdraw_2000.TabIndex = 6;
            rdobutton_withdraw_2000.TabStop = true;
            rdobutton_withdraw_2000.Text = "2000 $";
            rdobutton_withdraw_2000.UseVisualStyleBackColor = true;
            // 
            // label_withdraw_availablebalance
            // 
            label_withdraw_availablebalance.AutoSize = true;
            label_withdraw_availablebalance.BorderStyle = BorderStyle.FixedSingle;
            label_withdraw_availablebalance.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_withdraw_availablebalance.Location = new Point(54, 187);
            label_withdraw_availablebalance.Name = "label_withdraw_availablebalance";
            label_withdraw_availablebalance.Size = new Size(163, 27);
            label_withdraw_availablebalance.TabIndex = 0;
            label_withdraw_availablebalance.Text = "Available Balance : ";
            label_withdraw_availablebalance.Click += label_withdraw_availablebalance_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(54, 259);
            label1.Name = "label1";
            label1.Size = new Size(134, 27);
            label1.TabIndex = 0;
            label1.Text = "Quick Amount ";
            // 
            // button_withdraw_withdraw
            // 
            button_withdraw_withdraw.FlatStyle = FlatStyle.Popup;
            button_withdraw_withdraw.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_withdraw_withdraw.Location = new Point(228, 475);
            button_withdraw_withdraw.Name = "button_withdraw_withdraw";
            button_withdraw_withdraw.Size = new Size(163, 49);
            button_withdraw_withdraw.TabIndex = 10;
            button_withdraw_withdraw.Text = "Withdraw";
            button_withdraw_withdraw.UseVisualStyleBackColor = true;
            button_withdraw_withdraw.Click += button_withdraw_withdraw_Click;
            // 
            // button_withdraw_cancel
            // 
            button_withdraw_cancel.FlatStyle = FlatStyle.Popup;
            button_withdraw_cancel.Location = new Point(482, 527);
            button_withdraw_cancel.Name = "button_withdraw_cancel";
            button_withdraw_cancel.Size = new Size(94, 29);
            button_withdraw_cancel.TabIndex = 11;
            button_withdraw_cancel.Text = "Cancel";
            button_withdraw_cancel.UseVisualStyleBackColor = true;
            button_withdraw_cancel.Click += button_withdraw_cancel_Click;
            // 
            // label_withdraw_enteramount
            // 
            label_withdraw_enteramount.AutoSize = true;
            label_withdraw_enteramount.BorderStyle = BorderStyle.Fixed3D;
            label_withdraw_enteramount.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_withdraw_enteramount.Location = new Point(54, 424);
            label_withdraw_enteramount.Name = "label_withdraw_enteramount";
            label_withdraw_enteramount.Size = new Size(133, 27);
            label_withdraw_enteramount.TabIndex = 0;
            label_withdraw_enteramount.Text = "Enter Amount :";
            // 
            // text_withdraw_enteramount
            // 
            text_withdraw_enteramount.BorderStyle = BorderStyle.FixedSingle;
            text_withdraw_enteramount.Location = new Point(195, 425);
            text_withdraw_enteramount.Name = "text_withdraw_enteramount";
            text_withdraw_enteramount.Size = new Size(198, 27);
            text_withdraw_enteramount.TabIndex = 9;
            // 
            // Withdraw
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(626, 590);
            Controls.Add(text_withdraw_enteramount);
            Controls.Add(label_withdraw_enteramount);
            Controls.Add(button_withdraw_cancel);
            Controls.Add(button_withdraw_withdraw);
            Controls.Add(label1);
            Controls.Add(label_withdraw_availablebalance);
            Controls.Add(rdobutton_withdraw_2000);
            Controls.Add(rdobutton_withdraw_other);
            Controls.Add(rdobutton_withdraw_500);
            Controls.Add(rdobutton_withdraw_100);
            Controls.Add(rdobutton_withdraw_1000);
            Controls.Add(rdobutton_withdraw_5000);
            Controls.Add(rdobutton_withdraw_200);
            Controls.Add(rdobutton_withdraw_50);
            Controls.Add(label_withdraw_withdrawmoney);
            Controls.Add(label_withdraw_head);
            Name = "Withdraw";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Withdraw";
            Load += Withdraw_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_withdraw_head;
        private Label label_withdraw_withdrawmoney;
        private RadioButton rdobutton_withdraw_50;
        private RadioButton rdobutton_withdraw_100;
        private RadioButton rdobutton_withdraw_200;
        private RadioButton rdobutton_withdraw_500;
        private RadioButton rdobutton_withdraw_5000;
        private RadioButton rdobutton_withdraw_other;
        private RadioButton rdobutton_withdraw_1000;
        private RadioButton rdobutton_withdraw_2000;
        private Label label_withdraw_availablebalance;
        private Label label1;
        private Button button_withdraw_withdraw;
        private Button button_withdraw_cancel;
        private Label label_withdraw_enteramount;
        private TextBox text_withdraw_enteramount;
    }
}