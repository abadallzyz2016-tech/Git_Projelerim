namespace ATM_Simulasyonu.Forms
{
    partial class MainMenu
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
            label_mainmenu_name = new Label();
            label_mainmenu_accountid = new Label();
            button_mainmenu_withdraw = new Button();
            button_mainmenu_deposit = new Button();
            button_mainmenu_transfer = new Button();
            button_mainmenu_history = new Button();
            button_mainmenu_exit = new Button();
            label_mainmenu_accountbalance = new Label();
            SuspendLayout();
            // 
            // label_mainmenu_name
            // 
            label_mainmenu_name.AutoSize = true;
            label_mainmenu_name.BorderStyle = BorderStyle.Fixed3D;
            label_mainmenu_name.Location = new Point(54, 31);
            label_mainmenu_name.Name = "label_mainmenu_name";
            label_mainmenu_name.Size = new Size(51, 22);
            label_mainmenu_name.TabIndex = 0;
            label_mainmenu_name.Text = "Name\r\n";
            label_mainmenu_name.Click += label_mainmenu_name_Click;
            // 
            // label_mainmenu_accountid
            // 
            label_mainmenu_accountid.AutoSize = true;
            label_mainmenu_accountid.BorderStyle = BorderStyle.Fixed3D;
            label_mainmenu_accountid.Location = new Point(330, 31);
            label_mainmenu_accountid.Name = "label_mainmenu_accountid";
            label_mainmenu_accountid.Size = new Size(80, 22);
            label_mainmenu_accountid.TabIndex = 0;
            label_mainmenu_accountid.Text = "AccountID";
            label_mainmenu_accountid.Click += label_mainmenu_accountid_Click;
            // 
            // button_mainmenu_withdraw
            // 
            button_mainmenu_withdraw.FlatStyle = FlatStyle.Popup;
            button_mainmenu_withdraw.Location = new Point(54, 171);
            button_mainmenu_withdraw.Name = "button_mainmenu_withdraw";
            button_mainmenu_withdraw.Size = new Size(119, 47);
            button_mainmenu_withdraw.TabIndex = 1;
            button_mainmenu_withdraw.Text = "Withdraw";
            button_mainmenu_withdraw.UseVisualStyleBackColor = true;
            button_mainmenu_withdraw.Click += button_mainmenu_withdraw_Click;
            // 
            // button_mainmenu_deposit
            // 
            button_mainmenu_deposit.FlatStyle = FlatStyle.Popup;
            button_mainmenu_deposit.Location = new Point(54, 226);
            button_mainmenu_deposit.Name = "button_mainmenu_deposit";
            button_mainmenu_deposit.Size = new Size(119, 44);
            button_mainmenu_deposit.TabIndex = 2;
            button_mainmenu_deposit.Text = "Deposit";
            button_mainmenu_deposit.UseVisualStyleBackColor = true;
            button_mainmenu_deposit.Click += button_mainmenu_deposit_Click;
            // 
            // button_mainmenu_transfer
            // 
            button_mainmenu_transfer.FlatStyle = FlatStyle.Popup;
            button_mainmenu_transfer.Location = new Point(330, 171);
            button_mainmenu_transfer.Name = "button_mainmenu_transfer";
            button_mainmenu_transfer.Size = new Size(121, 47);
            button_mainmenu_transfer.TabIndex = 3;
            button_mainmenu_transfer.Text = "Transfer";
            button_mainmenu_transfer.UseVisualStyleBackColor = true;
            button_mainmenu_transfer.Click += button_mainmenu_transfer_Click;
            // 
            // button_mainmenu_history
            // 
            button_mainmenu_history.FlatStyle = FlatStyle.Popup;
            button_mainmenu_history.Location = new Point(330, 224);
            button_mainmenu_history.Name = "button_mainmenu_history";
            button_mainmenu_history.Size = new Size(121, 44);
            button_mainmenu_history.TabIndex = 4;
            button_mainmenu_history.Text = "History";
            button_mainmenu_history.UseVisualStyleBackColor = true;
            button_mainmenu_history.Click += button_mainmenu_history_Click;
            // 
            // button_mainmenu_exit
            // 
            button_mainmenu_exit.FlatStyle = FlatStyle.Popup;
            button_mainmenu_exit.Location = new Point(202, 306);
            button_mainmenu_exit.Name = "button_mainmenu_exit";
            button_mainmenu_exit.Size = new Size(94, 29);
            button_mainmenu_exit.TabIndex = 5;
            button_mainmenu_exit.Text = "Exit";
            button_mainmenu_exit.UseVisualStyleBackColor = true;
            button_mainmenu_exit.Click += button_mainmenu_exit_Click;
            // 
            // label_mainmenu_accountbalance
            // 
            label_mainmenu_accountbalance.AutoSize = true;
            label_mainmenu_accountbalance.BorderStyle = BorderStyle.Fixed3D;
            label_mainmenu_accountbalance.Location = new Point(54, 89);
            label_mainmenu_accountbalance.Name = "label_mainmenu_accountbalance";
            label_mainmenu_accountbalance.Size = new Size(74, 22);
            label_mainmenu_accountbalance.TabIndex = 0;
            label_mainmenu_accountbalance.Text = "Balance : ";
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(577, 377);
            Controls.Add(label_mainmenu_accountbalance);
            Controls.Add(button_mainmenu_history);
            Controls.Add(button_mainmenu_deposit);
            Controls.Add(button_mainmenu_transfer);
            Controls.Add(button_mainmenu_exit);
            Controls.Add(button_mainmenu_withdraw);
            Controls.Add(label_mainmenu_accountid);
            Controls.Add(label_mainmenu_name);
            Name = "MainMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainMenu";
            Load += MainMenu_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label_mainmenu_name;
        private Label label_mainmenu_accountid;
        private Button button_mainmenu_withdraw;
        private Button button_mainmenu_deposit;
        private Button button_mainmenu_transfer;
        private Button button_mainmenu_history;
        private Button button_mainmenu_exit;
        private Label label_mainmenu_accountbalance;
    }
}