namespace StationeryStoreAppLayer.Forms.ProductAdderOrEditorForms
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
            BarndIdCombo = new ComboBox();
            MaxAmountTxt = new NumericUpDown();
            MinAmounttxt = new NumericUpDown();
            label2 = new Label();
            label1 = new Label();
            BrandNameLbl = new Label();
            ProductNameLbl = new Label();
            txtProductName = new TextBox();
            SendBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)MaxAmountTxt).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MinAmounttxt).BeginInit();
            SuspendLayout();
            // 
            // BarndIdCombo
            // 
            BarndIdCombo.BackColor = Color.SaddleBrown;
            BarndIdCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            BarndIdCombo.ForeColor = Color.White;
            BarndIdCombo.FormattingEnabled = true;
            BarndIdCombo.Location = new Point(16, 24);
            BarndIdCombo.Name = "BarndIdCombo";
            BarndIdCombo.Size = new Size(138, 28);
            BarndIdCombo.TabIndex = 35;
            // 
            // MaxAmountTxt
            // 
            MaxAmountTxt.BackColor = Color.SaddleBrown;
            MaxAmountTxt.BorderStyle = BorderStyle.FixedSingle;
            MaxAmountTxt.ForeColor = Color.White;
            MaxAmountTxt.Location = new Point(260, 93);
            MaxAmountTxt.Maximum = new decimal(new int[] { 1569325056, 23283064, 0, 0 });
            MaxAmountTxt.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            MaxAmountTxt.Name = "MaxAmountTxt";
            MaxAmountTxt.Size = new Size(148, 27);
            MaxAmountTxt.TabIndex = 30;
            MaxAmountTxt.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // MinAmounttxt
            // 
            MinAmounttxt.BackColor = Color.SaddleBrown;
            MinAmounttxt.BorderStyle = BorderStyle.FixedSingle;
            MinAmounttxt.ForeColor = Color.White;
            MinAmounttxt.Location = new Point(16, 91);
            MinAmounttxt.Maximum = new decimal(new int[] { 1569325056, 23283064, 0, 0 });
            MinAmounttxt.Minimum = new decimal(new int[] { 1000, 0, 0, 0 });
            MinAmounttxt.Name = "MinAmounttxt";
            MinAmounttxt.Size = new Size(138, 27);
            MinAmounttxt.TabIndex = 29;
            MinAmounttxt.Value = new decimal(new int[] { 1000, 0, 0, 0 });
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(420, 96);
            label2.Name = "label2";
            label2.Size = new Size(65, 20);
            label2.TabIndex = 26;
            label2.Text = "تا قیمت :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(168, 96);
            label1.Name = "label1";
            label1.Size = new Size(66, 20);
            label1.TabIndex = 25;
            label1.Text = "از قیمت :";
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
            // 
            // ProductAdderOrEditorForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SandyBrown;
            ClientSize = new Size(523, 213);
            Controls.Add(SendBtn);
            Controls.Add(BarndIdCombo);
            Controls.Add(MaxAmountTxt);
            Controls.Add(MinAmounttxt);
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
            ((System.ComponentModel.ISupportInitialize)MaxAmountTxt).EndInit();
            ((System.ComponentModel.ISupportInitialize)MinAmounttxt).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox BarndIdCombo;
        private NumericUpDown MaxAmountTxt;
        private NumericUpDown MinAmounttxt;
        private Label label2;
        private Label label1;
        private Label BrandNameLbl;
        private Label ProductNameLbl;
        private TextBox txtProductName;
        private Button SendBtn;
    }
}