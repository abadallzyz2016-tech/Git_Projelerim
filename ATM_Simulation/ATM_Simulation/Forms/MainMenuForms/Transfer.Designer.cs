namespace ATM_Simulasyonu.Forms.MainMenuForms
{
    partial class Transfer
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
            label_transfer_head = new Label();
            label_transfer_transfermoney = new Label();
            label_transfer_youraccount = new Label();
            label_transfer_accountid = new Label();
            label_transfer_availablebalance = new Label();
            label_transfer_recipientaccountid = new Label();
            text_transfer_recipientaccountid = new TextBox();
            text_transfer_transferamount = new TextBox();
            label_transfer_transferamount_ = new Label();
            button_transfer_transfer = new Button();
            button_transfer_cancel = new Button();
            SuspendLayout();
            // 
            // label_transfer_head
            // 
            label_transfer_head.AutoSize = true;
            label_transfer_head.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_transfer_head.Location = new Point(168, 38);
            label_transfer_head.Name = "label_transfer_head";
            label_transfer_head.Size = new Size(136, 41);
            label_transfer_head.TabIndex = 0;
            label_transfer_head.Text = "Aea ATM";
            // 
            // label_transfer_transfermoney
            // 
            label_transfer_transfermoney.AutoSize = true;
            label_transfer_transfermoney.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_transfer_transfermoney.Location = new Point(148, 100);
            label_transfer_transfermoney.Name = "label_transfer_transfermoney";
            label_transfer_transfermoney.Size = new Size(170, 31);
            label_transfer_transfermoney.TabIndex = 0;
            label_transfer_transfermoney.Text = "Transfer Money";
            label_transfer_transfermoney.Click += label_transfer_transfermoney_Click;
            // 
            // label_transfer_youraccount
            // 
            label_transfer_youraccount.AutoSize = true;
            label_transfer_youraccount.BorderStyle = BorderStyle.Fixed3D;
            label_transfer_youraccount.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_transfer_youraccount.Location = new Point(32, 161);
            label_transfer_youraccount.Name = "label_transfer_youraccount";
            label_transfer_youraccount.Size = new Size(119, 27);
            label_transfer_youraccount.TabIndex = 0;
            label_transfer_youraccount.Text = "Your Account";
            // 
            // label_transfer_accountid
            // 
            label_transfer_accountid.AutoSize = true;
            label_transfer_accountid.Location = new Point(32, 221);
            label_transfer_accountid.Name = "label_transfer_accountid";
            label_transfer_accountid.Size = new Size(93, 20);
            label_transfer_accountid.TabIndex = 0;
            label_transfer_accountid.Text = "Account ID : ";
            // 
            // label_transfer_availablebalance
            // 
            label_transfer_availablebalance.AutoSize = true;
            label_transfer_availablebalance.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_transfer_availablebalance.Location = new Point(32, 267);
            label_transfer_availablebalance.Name = "label_transfer_availablebalance";
            label_transfer_availablebalance.Size = new Size(161, 25);
            label_transfer_availablebalance.TabIndex = 0;
            label_transfer_availablebalance.Text = "Available Balance : ";
            // 
            // label_transfer_recipientaccountid
            // 
            label_transfer_recipientaccountid.AutoSize = true;
            label_transfer_recipientaccountid.BorderStyle = BorderStyle.Fixed3D;
            label_transfer_recipientaccountid.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_transfer_recipientaccountid.Location = new Point(32, 333);
            label_transfer_recipientaccountid.Name = "label_transfer_recipientaccountid";
            label_transfer_recipientaccountid.Size = new Size(178, 27);
            label_transfer_recipientaccountid.TabIndex = 0;
            label_transfer_recipientaccountid.Text = "Recipient Account ID";
            // 
            // text_transfer_recipientaccountid
            // 
            text_transfer_recipientaccountid.BorderStyle = BorderStyle.FixedSingle;
            text_transfer_recipientaccountid.Location = new Point(56, 397);
            text_transfer_recipientaccountid.MaxLength = 9;
            text_transfer_recipientaccountid.Name = "text_transfer_recipientaccountid";
            text_transfer_recipientaccountid.Size = new Size(246, 27);
            text_transfer_recipientaccountid.TabIndex = 1;
            // 
            // text_transfer_transferamount
            // 
            text_transfer_transferamount.BorderStyle = BorderStyle.FixedSingle;
            text_transfer_transferamount.Location = new Point(56, 491);
            text_transfer_transferamount.MaxLength = 7;
            text_transfer_transferamount.Name = "text_transfer_transferamount";
            text_transfer_transferamount.Size = new Size(246, 27);
            text_transfer_transferamount.TabIndex = 2;
            // 
            // label_transfer_transferamount_
            // 
            label_transfer_transferamount_.AutoSize = true;
            label_transfer_transferamount_.BorderStyle = BorderStyle.Fixed3D;
            label_transfer_transferamount_.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_transfer_transferamount_.Location = new Point(32, 441);
            label_transfer_transferamount_.Name = "label_transfer_transferamount_";
            label_transfer_transferamount_.Size = new Size(145, 27);
            label_transfer_transferamount_.TabIndex = 0;
            label_transfer_transferamount_.Text = "Transfer Amount";
            // 
            // button_transfer_transfer
            // 
            button_transfer_transfer.FlatStyle = FlatStyle.Popup;
            button_transfer_transfer.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_transfer_transfer.Location = new Point(168, 540);
            button_transfer_transfer.Name = "button_transfer_transfer";
            button_transfer_transfer.Size = new Size(150, 37);
            button_transfer_transfer.TabIndex = 3;
            button_transfer_transfer.Text = "Transfer";
            button_transfer_transfer.UseVisualStyleBackColor = true;
            button_transfer_transfer.Click += button_transfer_transfer_Click;
            // 
            // button_transfer_cancel
            // 
            button_transfer_cancel.FlatStyle = FlatStyle.Popup;
            button_transfer_cancel.Location = new Point(357, 576);
            button_transfer_cancel.Name = "button_transfer_cancel";
            button_transfer_cancel.Size = new Size(94, 29);
            button_transfer_cancel.TabIndex = 4;
            button_transfer_cancel.Text = "Cancel";
            button_transfer_cancel.UseVisualStyleBackColor = true;
            button_transfer_cancel.Click += button_transfer_cancel_Click;
            // 
            // Transfer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 640);
            Controls.Add(button_transfer_cancel);
            Controls.Add(button_transfer_transfer);
            Controls.Add(label_transfer_transferamount_);
            Controls.Add(text_transfer_transferamount);
            Controls.Add(text_transfer_recipientaccountid);
            Controls.Add(label_transfer_recipientaccountid);
            Controls.Add(label_transfer_availablebalance);
            Controls.Add(label_transfer_accountid);
            Controls.Add(label_transfer_youraccount);
            Controls.Add(label_transfer_transfermoney);
            Controls.Add(label_transfer_head);
            Name = "Transfer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Transfer";
            Load += Transfer_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_transfer_head;
        private Label label_transfer_transfermoney;
        private Label label_transfer_youraccount;
        private Label label_transfer_accountid;
        private Label label_transfer_availablebalance;
        private Label label_transfer_recipientaccountid;
        private TextBox text_transfer_recipientaccountid;
        private TextBox text_transfer_transferamount;
        private Label label_transfer_transferamount_;
        private Button button_transfer_transfer;
        private Button button_transfer_cancel;
    }
}