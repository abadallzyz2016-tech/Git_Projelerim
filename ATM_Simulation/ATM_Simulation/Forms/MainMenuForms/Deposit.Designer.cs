namespace ATM_Simulasyonu.Forms.MainMenuForms
{
    partial class Deposit
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
            label_deposit_head = new Label();
            label_deposit_depositmoney = new Label();
            label_deposit_availablebalance = new Label();
            label_deposit_enteramount = new Label();
            text_deposit_enteramount = new TextBox();
            label_deposit_quickamount = new Label();
            rdobutton_deposit_200 = new RadioButton();
            rdobutton_deposit_500 = new RadioButton();
            rdobutton_deposit_1000 = new RadioButton();
            rdobutton_deposit_2000 = new RadioButton();
            button_deposit_deposit = new Button();
            button_deposit_cancel = new Button();
            SuspendLayout();
            // 
            // label_deposit_head
            // 
            label_deposit_head.AutoSize = true;
            label_deposit_head.BorderStyle = BorderStyle.Fixed3D;
            label_deposit_head.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_deposit_head.Location = new Point(212, 37);
            label_deposit_head.Name = "label_deposit_head";
            label_deposit_head.Size = new Size(138, 43);
            label_deposit_head.TabIndex = 0;
            label_deposit_head.Text = "Aea ATM";
            // 
            // label_deposit_depositmoney
            // 
            label_deposit_depositmoney.AutoSize = true;
            label_deposit_depositmoney.BorderStyle = BorderStyle.FixedSingle;
            label_deposit_depositmoney.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_deposit_depositmoney.Location = new Point(195, 106);
            label_deposit_depositmoney.Name = "label_deposit_depositmoney";
            label_deposit_depositmoney.Size = new Size(171, 33);
            label_deposit_depositmoney.TabIndex = 0;
            label_deposit_depositmoney.Text = "Deposit Money";
            // 
            // label_deposit_availablebalance
            // 
            label_deposit_availablebalance.AutoSize = true;
            label_deposit_availablebalance.BorderStyle = BorderStyle.FixedSingle;
            label_deposit_availablebalance.FlatStyle = FlatStyle.System;
            label_deposit_availablebalance.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_deposit_availablebalance.Location = new Point(42, 173);
            label_deposit_availablebalance.Name = "label_deposit_availablebalance";
            label_deposit_availablebalance.Size = new Size(149, 27);
            label_deposit_availablebalance.TabIndex = 0;
            label_deposit_availablebalance.Text = "Available Balance";
            // 
            // label_deposit_enteramount
            // 
            label_deposit_enteramount.AutoSize = true;
            label_deposit_enteramount.BorderStyle = BorderStyle.Fixed3D;
            label_deposit_enteramount.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_deposit_enteramount.Location = new Point(42, 393);
            label_deposit_enteramount.Name = "label_deposit_enteramount";
            label_deposit_enteramount.Size = new Size(133, 27);
            label_deposit_enteramount.TabIndex = 0;
            label_deposit_enteramount.Text = "Enter Amount :";
            // 
            // text_deposit_enteramount
            // 
            text_deposit_enteramount.BorderStyle = BorderStyle.FixedSingle;
            text_deposit_enteramount.Location = new Point(195, 393);
            text_deposit_enteramount.Name = "text_deposit_enteramount";
            text_deposit_enteramount.Size = new Size(226, 27);
            text_deposit_enteramount.TabIndex = 5;
            // 
            // label_deposit_quickamount
            // 
            label_deposit_quickamount.AutoSize = true;
            label_deposit_quickamount.BorderStyle = BorderStyle.Fixed3D;
            label_deposit_quickamount.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_deposit_quickamount.Location = new Point(42, 229);
            label_deposit_quickamount.Name = "label_deposit_quickamount";
            label_deposit_quickamount.Size = new Size(129, 27);
            label_deposit_quickamount.TabIndex = 0;
            label_deposit_quickamount.Text = "Quick Amount";
            // 
            // rdobutton_deposit_200
            // 
            rdobutton_deposit_200.AutoSize = true;
            rdobutton_deposit_200.Location = new Point(123, 283);
            rdobutton_deposit_200.Name = "rdobutton_deposit_200";
            rdobutton_deposit_200.Size = new Size(66, 24);
            rdobutton_deposit_200.TabIndex = 1;
            rdobutton_deposit_200.TabStop = true;
            rdobutton_deposit_200.Text = "200 $";
            rdobutton_deposit_200.UseVisualStyleBackColor = true;
            // 
            // rdobutton_deposit_500
            // 
            rdobutton_deposit_500.AutoSize = true;
            rdobutton_deposit_500.Location = new Point(123, 339);
            rdobutton_deposit_500.Name = "rdobutton_deposit_500";
            rdobutton_deposit_500.Size = new Size(66, 24);
            rdobutton_deposit_500.TabIndex = 2;
            rdobutton_deposit_500.TabStop = true;
            rdobutton_deposit_500.Text = "500 $";
            rdobutton_deposit_500.UseVisualStyleBackColor = true;
            // 
            // rdobutton_deposit_1000
            // 
            rdobutton_deposit_1000.AutoSize = true;
            rdobutton_deposit_1000.BackColor = SystemColors.Control;
            rdobutton_deposit_1000.Location = new Point(347, 283);
            rdobutton_deposit_1000.Name = "rdobutton_deposit_1000";
            rdobutton_deposit_1000.Size = new Size(74, 24);
            rdobutton_deposit_1000.TabIndex = 3;
            rdobutton_deposit_1000.TabStop = true;
            rdobutton_deposit_1000.Text = "1000 $";
            rdobutton_deposit_1000.UseVisualStyleBackColor = false;
            // 
            // rdobutton_deposit_2000
            // 
            rdobutton_deposit_2000.AutoSize = true;
            rdobutton_deposit_2000.Location = new Point(347, 339);
            rdobutton_deposit_2000.Name = "rdobutton_deposit_2000";
            rdobutton_deposit_2000.Size = new Size(74, 24);
            rdobutton_deposit_2000.TabIndex = 4;
            rdobutton_deposit_2000.TabStop = true;
            rdobutton_deposit_2000.Text = "2000 $";
            rdobutton_deposit_2000.UseVisualStyleBackColor = true;
            // 
            // button_deposit_deposit
            // 
            button_deposit_deposit.FlatStyle = FlatStyle.Popup;
            button_deposit_deposit.Location = new Point(222, 450);
            button_deposit_deposit.Name = "button_deposit_deposit";
            button_deposit_deposit.Size = new Size(160, 48);
            button_deposit_deposit.TabIndex = 6;
            button_deposit_deposit.Text = "Deposit";
            button_deposit_deposit.UseVisualStyleBackColor = true;
            button_deposit_deposit.Click += button_deposit_deposit_Click;
            // 
            // button_deposit_cancel
            // 
            button_deposit_cancel.FlatStyle = FlatStyle.Popup;
            button_deposit_cancel.Location = new Point(460, 506);
            button_deposit_cancel.Name = "button_deposit_cancel";
            button_deposit_cancel.Size = new Size(118, 39);
            button_deposit_cancel.TabIndex = 7;
            button_deposit_cancel.Text = "Cancel";
            button_deposit_cancel.UseVisualStyleBackColor = true;
            button_deposit_cancel.Click += button_deposit_cancel_Click;
            // 
            // Deposit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(606, 574);
            Controls.Add(button_deposit_cancel);
            Controls.Add(button_deposit_deposit);
            Controls.Add(rdobutton_deposit_2000);
            Controls.Add(rdobutton_deposit_500);
            Controls.Add(rdobutton_deposit_1000);
            Controls.Add(rdobutton_deposit_200);
            Controls.Add(label_deposit_quickamount);
            Controls.Add(text_deposit_enteramount);
            Controls.Add(label_deposit_enteramount);
            Controls.Add(label_deposit_availablebalance);
            Controls.Add(label_deposit_depositmoney);
            Controls.Add(label_deposit_head);
            Name = "Deposit";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Deposit";
            Load += Deposit_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_deposit_head;
        private Label label_deposit_depositmoney;
        private Label label_deposit_availablebalance;
        private Label label_deposit_enteramount;
        private TextBox text_deposit_enteramount;
        private Label label_deposit_quickamount;
        private RadioButton rdobutton_deposit_200;
        private RadioButton rdobutton_deposit_500;
        private RadioButton rdobutton_deposit_1000;
        private RadioButton rdobutton_deposit_2000;
        private Button button_deposit_deposit;
        private Button button_deposit_cancel;
    }
}