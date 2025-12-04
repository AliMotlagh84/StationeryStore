namespace StationeryStoreUILayer.Forms.ProductAdderOrEditorForms
{
    partial class ProductAdderOrEditorForm
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
            BarndCombo = new ComboBox();
            CountTxt = new NumericUpDown();
            AmountTxt = new NumericUpDown();
            label2 = new Label();
            label1 = new Label();
            BrandNameLbl = new Label();
            ProductNameLbl = new Label();
            txtProductName = new TextBox();
            SendBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)CountTxt).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AmountTxt).BeginInit();
            SuspendLayout();
            // 
            // BarndCombo
            // 
            BarndCombo.BackColor = Color.SaddleBrown;
            BarndCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            BarndCombo.ForeColor = Color.White;
            BarndCombo.FormattingEnabled = true;
            BarndCombo.Location = new Point(16, 24);
            BarndCombo.Name = "BarndCombo";
            BarndCombo.Size = new Size(138, 28);
            BarndCombo.TabIndex = 35;
            // 
            // CountTxt
            // 
            CountTxt.BackColor = Color.SaddleBrown;
            CountTxt.BorderStyle = BorderStyle.FixedSingle;
            CountTxt.ForeColor = Color.White;
            CountTxt.Location = new Point(260, 93);
            CountTxt.Maximum = new decimal(new int[] { 1569325056, 23283064, 0, 0 });
            CountTxt.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            CountTxt.Name = "CountTxt";
            CountTxt.Size = new Size(148, 27);
            CountTxt.TabIndex = 30;
            CountTxt.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // AmountTxt
            // 
            AmountTxt.BackColor = Color.SaddleBrown;
            AmountTxt.BorderStyle = BorderStyle.FixedSingle;
            AmountTxt.ForeColor = Color.White;
            AmountTxt.Location = new Point(16, 91);
            AmountTxt.Maximum = new decimal(new int[] { 1569325056, 23283064, 0, 0 });
            AmountTxt.Minimum = new decimal(new int[] { 1000, 0, 0, 0 });
            AmountTxt.Name = "AmountTxt";
            AmountTxt.Size = new Size(138, 27);
            AmountTxt.TabIndex = 29;
            AmountTxt.Value = new decimal(new int[] { 1000, 0, 0, 0 });
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(420, 96);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 26;
            label2.Text = "تعداد :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(168, 96);
            label1.Name = "label1";
            label1.Size = new Size(52, 20);
            label1.TabIndex = 25;
            label1.Text = "قیمت :";
            // 
            // BrandNameLbl
            // 
            BrandNameLbl.AutoSize = true;
            BrandNameLbl.Location = new Point(168, 27);
            BrandNameLbl.Name = "BrandNameLbl";
            BrandNameLbl.Size = new Size(61, 20);
            BrandNameLbl.TabIndex = 24;
            BrandNameLbl.Text = "نام برند :";
            // 
            // ProductNameLbl
            // 
            ProductNameLbl.AutoSize = true;
            ProductNameLbl.Location = new Point(420, 27);
            ProductNameLbl.Name = "ProductNameLbl";
            ProductNameLbl.Size = new Size(89, 20);
            ProductNameLbl.TabIndex = 21;
            ProductNameLbl.Text = "نام محصول :";
            // 
            // txtProductName
            // 
            txtProductName.BackColor = Color.SaddleBrown;
            txtProductName.BorderStyle = BorderStyle.FixedSingle;
            txtProductName.ForeColor = Color.White;
            txtProductName.Location = new Point(260, 24);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(148, 27);
            txtProductName.TabIndex = 22;
            // 
            // SendBtn
            // 
            SendBtn.BackColor = Color.SaddleBrown;
            SendBtn.FlatStyle = FlatStyle.Popup;
            SendBtn.ForeColor = Color.White;
            SendBtn.Location = new Point(198, 156);
            SendBtn.Name = "SendBtn";
            SendBtn.Size = new Size(115, 38);
            SendBtn.TabIndex = 36;
            SendBtn.Text = "افزودن محصول";
            SendBtn.UseVisualStyleBackColor = false;
            SendBtn.Click += SendBtn_Click;
            // 
            // ProductAdderOrEditorForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SandyBrown;
            ClientSize = new Size(523, 213);
            Controls.Add(SendBtn);
            Controls.Add(BarndCombo);
            Controls.Add(CountTxt);
            Controls.Add(AmountTxt);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(BrandNameLbl);
            Controls.Add(txtProductName);
            Controls.Add(ProductNameLbl);
            ForeColor = Color.FromArgb(64, 0, 0);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "ProductAdderOrEditorForm";
            RightToLeft = RightToLeft.Yes;
            StartPosition = FormStartPosition.CenterParent;
            Text = "افزودن محصول";
            Load += ProductAdderOrEditorForm_Load;
            ((System.ComponentModel.ISupportInitialize)CountTxt).EndInit();
            ((System.ComponentModel.ISupportInitialize)AmountTxt).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox BarndCombo;
        private NumericUpDown CountTxt;
        private NumericUpDown AmountTxt;
        private Label label2;
        private Label label1;
        private Label BrandNameLbl;
        private Label ProductNameLbl;
        private TextBox txtProductName;
        private Button SendBtn;
    }
}