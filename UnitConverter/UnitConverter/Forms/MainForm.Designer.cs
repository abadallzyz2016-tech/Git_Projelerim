namespace UnitConverter.Forms
{
    partial class MainForm
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
            label_main_unitconverter = new Label();
            label_main_category = new Label();
            label_main_from = new Label();
            label_main_to = new Label();
            label_main_value = new Label();
            button_main_convert = new Button();
            cbox_main_category = new ComboBox();
            cbox_main_from = new ComboBox();
            cbox_main_to = new ComboBox();
            text_main_value = new TextBox();
            text_main_result = new TextBox();
            label_main_result = new Label();
            SuspendLayout();
            // 
            // label_main_unitconverter
            // 
            label_main_unitconverter.AutoSize = true;
            label_main_unitconverter.BorderStyle = BorderStyle.Fixed3D;
            label_main_unitconverter.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_main_unitconverter.Location = new Point(237, 28);
            label_main_unitconverter.Name = "label_main_unitconverter";
            label_main_unitconverter.Size = new Size(258, 43);
            label_main_unitconverter.TabIndex = 0;
            label_main_unitconverter.Text = "UNIT CONVERTER";
            // 
            // label_main_category
            // 
            label_main_category.AutoSize = true;
            label_main_category.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_main_category.Location = new Point(57, 171);
            label_main_category.Name = "label_main_category";
            label_main_category.Size = new Size(106, 28);
            label_main_category.TabIndex = 1;
            label_main_category.Text = "Category : ";
            // 
            // label_main_from
            // 
            label_main_from.AutoSize = true;
            label_main_from.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_main_from.Location = new Point(57, 246);
            label_main_from.Name = "label_main_from";
            label_main_from.Size = new Size(72, 28);
            label_main_from.TabIndex = 1;
            label_main_from.Text = "From : ";
            // 
            // label_main_to
            // 
            label_main_to.AutoSize = true;
            label_main_to.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_main_to.Location = new Point(57, 307);
            label_main_to.Name = "label_main_to";
            label_main_to.Size = new Size(46, 28);
            label_main_to.TabIndex = 1;
            label_main_to.Text = "To : ";
            // 
            // label_main_value
            // 
            label_main_value.AutoSize = true;
            label_main_value.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_main_value.Location = new Point(57, 365);
            label_main_value.Name = "label_main_value";
            label_main_value.Size = new Size(73, 28);
            label_main_value.TabIndex = 1;
            label_main_value.Text = "Value : ";
            // 
            // button_main_convert
            // 
            button_main_convert.BackColor = SystemColors.InactiveCaption;
            button_main_convert.FlatStyle = FlatStyle.Flat;
            button_main_convert.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_main_convert.Location = new Point(301, 539);
            button_main_convert.Name = "button_main_convert";
            button_main_convert.Size = new Size(119, 39);
            button_main_convert.TabIndex = 2;
            button_main_convert.Text = "Convert";
            button_main_convert.UseVisualStyleBackColor = false;
            button_main_convert.Click += button_main_convert_Click;
            // 
            // cbox_main_category
            // 
            cbox_main_category.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbox_main_category.ForeColor = SystemColors.ControlDarkDark;
            cbox_main_category.FormattingEnabled = true;
            cbox_main_category.Location = new Point(189, 175);
            cbox_main_category.Name = "cbox_main_category";
            cbox_main_category.Size = new Size(173, 31);
            cbox_main_category.TabIndex = 3;
            cbox_main_category.SelectedIndexChanged += cbox_main_category_SelectedIndexChanged;
            // 
            // cbox_main_from
            // 
            cbox_main_from.DropDownStyle = ComboBoxStyle.DropDownList;
            cbox_main_from.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbox_main_from.ForeColor = SystemColors.ButtonShadow;
            cbox_main_from.FormattingEnabled = true;
            cbox_main_from.Location = new Point(189, 248);
            cbox_main_from.Name = "cbox_main_from";
            cbox_main_from.Size = new Size(173, 31);
            cbox_main_from.TabIndex = 3;
            // 
            // cbox_main_to
            // 
            cbox_main_to.DropDownStyle = ComboBoxStyle.DropDownList;
            cbox_main_to.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbox_main_to.ForeColor = SystemColors.ButtonShadow;
            cbox_main_to.FormattingEnabled = true;
            cbox_main_to.Location = new Point(189, 309);
            cbox_main_to.Name = "cbox_main_to";
            cbox_main_to.Size = new Size(173, 31);
            cbox_main_to.TabIndex = 3;
            // 
            // text_main_value
            // 
            text_main_value.Location = new Point(189, 369);
            text_main_value.Name = "text_main_value";
            text_main_value.Size = new Size(173, 27);
            text_main_value.TabIndex = 4;
            // 
            // text_main_result
            // 
            text_main_result.Location = new Point(189, 444);
            text_main_result.Name = "text_main_result";
            text_main_result.ReadOnly = true;
            text_main_result.Size = new Size(173, 27);
            text_main_result.TabIndex = 4;
            // 
            // label_main_result
            // 
            label_main_result.AutoSize = true;
            label_main_result.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_main_result.Location = new Point(57, 440);
            label_main_result.Name = "label_main_result";
            label_main_result.Size = new Size(78, 28);
            label_main_result.TabIndex = 1;
            label_main_result.Text = "Result : ";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(732, 703);
            Controls.Add(text_main_result);
            Controls.Add(text_main_value);
            Controls.Add(cbox_main_to);
            Controls.Add(cbox_main_from);
            Controls.Add(cbox_main_category);
            Controls.Add(button_main_convert);
            Controls.Add(label_main_result);
            Controls.Add(label_main_value);
            Controls.Add(label_main_from);
            Controls.Add(label_main_to);
            Controls.Add(label_main_category);
            Controls.Add(label_main_unitconverter);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main";
            Load += MainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_main_unitconverter;
        private Label label_main_category;
        private Label label_main_from;
        private Label label_main_to;
        private Label label_main_value;
        public Button button_main_convert;
        public ComboBox cbox_main_category;
        public ComboBox cbox_main_from;
        public ComboBox cbox_main_to;
        public TextBox text_main_value;
        public TextBox text_main_result;
        private Label label_main_result;
    }
}