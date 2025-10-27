namespace StationeryStoreAppLayer
{
    partial class Form3
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            ProductGB = new GroupBox();
            ProductsSearchBox = new GroupBox();
            label5 = new Label();
            maskedToDatetxt = new MaskedTextBox();
            label4 = new Label();
            maskedAsDatetxt = new MaskedTextBox();
            BrandIdtxt = new NumericUpDown();
            MaxAmountTxt = new NumericUpDown();
            MinAmounttxt = new NumericUpDown();
            label3 = new Label();
            AvailablityCombo = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            BrandNameLbl = new Label();
            btnProductsSearch = new Button();
            txtProductName = new TextBox();
            ProductNameLbl = new Label();
            DGPruducts = new DataGridView();
            ProductId = new DataGridViewTextBoxColumn();
            ProductName = new DataGridViewTextBoxColumn();
            BrandId = new DataGridViewTextBoxColumn();
            BrandName = new DataGridViewTextBoxColumn();
            Count = new DataGridViewTextBoxColumn();
            Amount = new DataGridViewTextBoxColumn();
            ProductGB.SuspendLayout();
            ProductsSearchBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BrandIdtxt).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MaxAmountTxt).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MinAmounttxt).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DGPruducts).BeginInit();
            SuspendLayout();
            // 
            // ProductGB
            // 
            ProductGB.Controls.Add(ProductsSearchBox);
            ProductGB.Controls.Add(DGPruducts);
            ProductGB.Location = new Point(31, 14);
            ProductGB.Name = "ProductGB";
            ProductGB.Size = new Size(869, 477);
            ProductGB.TabIndex = 6;
            ProductGB.TabStop = false;
            ProductGB.Text = "محصولات";
            // 
            // ProductsSearchBox
            // 
            ProductsSearchBox.Controls.Add(label5);
            ProductsSearchBox.Controls.Add(maskedToDatetxt);
            ProductsSearchBox.Controls.Add(label4);
            ProductsSearchBox.Controls.Add(maskedAsDatetxt);
            ProductsSearchBox.Controls.Add(BrandIdtxt);
            ProductsSearchBox.Controls.Add(MaxAmountTxt);
            ProductsSearchBox.Controls.Add(MinAmounttxt);
            ProductsSearchBox.Controls.Add(label3);
            ProductsSearchBox.Controls.Add(AvailablityCombo);
            ProductsSearchBox.Controls.Add(label2);
            ProductsSearchBox.Controls.Add(label1);
            ProductsSearchBox.Controls.Add(BrandNameLbl);
            ProductsSearchBox.Controls.Add(btnProductsSearch);
            ProductsSearchBox.Controls.Add(txtProductName);
            ProductsSearchBox.Controls.Add(ProductNameLbl);
            ProductsSearchBox.Dock = DockStyle.Top;
            ProductsSearchBox.Location = new Point(3, 23);
            ProductsSearchBox.Name = "ProductsSearchBox";
            ProductsSearchBox.Size = new Size(863, 139);
            ProductsSearchBox.TabIndex = 1;
            ProductsSearchBox.TabStop = false;
            ProductsSearchBox.Text = "جستوجو در محصولات ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(120, 86);
            label5.Name = "label5";
            label5.Size = new Size(63, 20);
            label5.TabIndex = 19;
            label5.Text = "تا تاریخ : ";
            // 
            // maskedToDatetxt
            // 
            maskedToDatetxt.Location = new Point(6, 81);
            maskedToDatetxt.Mask = "0000/00/00";
            maskedToDatetxt.Name = "maskedToDatetxt";
            maskedToDatetxt.Size = new Size(112, 27);
            maskedToDatetxt.TabIndex = 18;
            maskedToDatetxt.ValidatingType = typeof(DateTime);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(308, 86);
            label4.Name = "label4";
            label4.Size = new Size(60, 20);
            label4.TabIndex = 17;
            label4.Text = "از تاریخ :";
            // 
            // maskedAsDatetxt
            // 
            maskedAsDatetxt.Location = new Point(189, 81);
            maskedAsDatetxt.Mask = "0000/00/00";
            maskedAsDatetxt.Name = "maskedAsDatetxt";
            maskedAsDatetxt.Size = new Size(112, 27);
            maskedAsDatetxt.TabIndex = 16;
            maskedAsDatetxt.ValidatingType = typeof(DateTime);
            // 
            // BrandIdtxt
            // 
            BrandIdtxt.Location = new Point(620, 84);
            BrandIdtxt.Maximum = new decimal(new int[] { 1569325056, 23283064, 0, 0 });
            BrandIdtxt.Name = "BrandIdtxt";
            BrandIdtxt.Size = new Size(117, 27);
            BrandIdtxt.TabIndex = 15;
            // 
            // MaxAmountTxt
            // 
            MaxAmountTxt.Location = new Point(399, 84);
            MaxAmountTxt.Maximum = new decimal(new int[] { 1569325056, 23283064, 0, 0 });
            MaxAmountTxt.Name = "MaxAmountTxt";
            MaxAmountTxt.Size = new Size(117, 27);
            MaxAmountTxt.TabIndex = 14;
            // 
            // MinAmounttxt
            // 
            MinAmounttxt.Location = new Point(398, 34);
            MinAmounttxt.Maximum = new decimal(new int[] { 1569325056, 23283064, 0, 0 });
            MinAmounttxt.Name = "MinAmounttxt";
            MinAmounttxt.Size = new Size(117, 27);
            MinAmounttxt.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(308, 38);
            label3.Name = "label3";
            label3.Size = new Size(81, 20);
            label3.TabIndex = 12;
            label3.Text = " موجودیت :";
            // 
            // AvailablityCombo
            // 
            AvailablityCombo.FormattingEnabled = true;
            AvailablityCombo.Location = new Point(189, 34);
            AvailablityCombo.Name = "AvailablityCombo";
            AvailablityCombo.Size = new Size(112, 28);
            AvailablityCombo.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(522, 84);
            label2.Name = "label2";
            label2.Size = new Size(65, 20);
            label2.TabIndex = 9;
            label2.Text = "تا قیمت :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(524, 39);
            label1.Name = "label1";
            label1.Size = new Size(66, 20);
            label1.TabIndex = 7;
            label1.Text = "از قیمت :";
            // 
            // BrandNameLbl
            // 
            BrandNameLbl.AutoSize = true;
            BrandNameLbl.Location = new Point(744, 84);
            BrandNameLbl.Name = "BrandNameLbl";
            BrandNameLbl.Size = new Size(61, 20);
            BrandNameLbl.TabIndex = 5;
            BrandNameLbl.Text = "نام برند :";
            // 
            // btnProductsSearch
            // 
            btnProductsSearch.Location = new Point(6, 35);
            btnProductsSearch.Name = "btnProductsSearch";
            btnProductsSearch.Size = new Size(131, 29);
            btnProductsSearch.TabIndex = 4;
            btnProductsSearch.Text = "جستوجو";
            btnProductsSearch.UseVisualStyleBackColor = true;
            btnProductsSearch.Click += btnProductsSearch_Click;
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(620, 36);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(117, 27);
            txtProductName.TabIndex = 1;
            // 
            // ProductNameLbl
            // 
            ProductNameLbl.AutoSize = true;
            ProductNameLbl.Location = new Point(745, 39);
            ProductNameLbl.Name = "ProductNameLbl";
            ProductNameLbl.Size = new Size(89, 20);
            ProductNameLbl.TabIndex = 0;
            ProductNameLbl.Text = "نام محصول :";
            // 
            // DGPruducts
            // 
            DGPruducts.AllowUserToAddRows = false;
            DGPruducts.AllowUserToDeleteRows = false;
            DGPruducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            DGPruducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            DGPruducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGPruducts.Columns.AddRange(new DataGridViewColumn[] { ProductId, ProductName, BrandId, BrandName, Count, Amount });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            DGPruducts.DefaultCellStyle = dataGridViewCellStyle4;
            DGPruducts.Location = new Point(0, 168);
            DGPruducts.Name = "DGPruducts";
            DGPruducts.ReadOnly = true;
            DGPruducts.RowHeadersWidth = 51;
            DGPruducts.Size = new Size(863, 309);
            DGPruducts.TabIndex = 0;
            // 
            // ProductId
            // 
            ProductId.DataPropertyName = "ProductId";
            ProductId.HeaderText = "آی دی محصول";
            ProductId.MinimumWidth = 6;
            ProductId.Name = "ProductId";
            ProductId.ReadOnly = true;
            ProductId.Visible = false;
            // 
            // ProductName
            // 
            ProductName.DataPropertyName = "ProductName";
            ProductName.HeaderText = "نام محصول";
            ProductName.MinimumWidth = 6;
            ProductName.Name = "ProductName";
            ProductName.ReadOnly = true;
            // 
            // BrandId
            // 
            BrandId.DataPropertyName = "BrandId";
            BrandId.HeaderText = "آی دی برند";
            BrandId.MinimumWidth = 6;
            BrandId.Name = "BrandId";
            BrandId.ReadOnly = true;
            BrandId.Visible = false;
            // 
            // BrandName
            // 
            BrandName.DataPropertyName = "BrandName";
            BrandName.HeaderText = "نام برند";
            BrandName.MinimumWidth = 6;
            BrandName.Name = "BrandName";
            BrandName.ReadOnly = true;
            // 
            // Count
            // 
            Count.DataPropertyName = "Count";
            Count.HeaderText = "تعداد";
            Count.MinimumWidth = 6;
            Count.Name = "Count";
            Count.ReadOnly = true;
            // 
            // Amount
            // 
            Amount.DataPropertyName = "Amount";
            Amount.HeaderText = "قیمت";
            Amount.MinimumWidth = 6;
            Amount.Name = "Amount";
            Amount.ReadOnly = true;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(944, 490);
            Controls.Add(ProductGB);
            Name = "Form3";
            RightToLeft = RightToLeft.Yes;
            Text = "Form3";
            Load += Form3_Load;
            ProductGB.ResumeLayout(false);
            ProductsSearchBox.ResumeLayout(false);
            ProductsSearchBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)BrandIdtxt).EndInit();
            ((System.ComponentModel.ISupportInitialize)MaxAmountTxt).EndInit();
            ((System.ComponentModel.ISupportInitialize)MinAmounttxt).EndInit();
            ((System.ComponentModel.ISupportInitialize)DGPruducts).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox ProductGB;
        private GroupBox ProductsSearchBox;
        private Button btnProductsSearch;
        private TextBox txtProductName;
        private Label ProductNameLbl;
        private DataGridView DGPruducts;
        private DataGridViewTextBoxColumn ProductId;
        private DataGridViewTextBoxColumn ProductName;
        private DataGridViewTextBoxColumn BrandId;
        private DataGridViewTextBoxColumn BrandName;
        private DataGridViewTextBoxColumn Count;
        private DataGridViewTextBoxColumn Amount;
        private Label label1;
        private Label BrandNameLbl;
        private Label label2;
        private Label label3;
        private ComboBox AvailablityCombo;
        private NumericUpDown MaxAmountTxt;
        private NumericUpDown MinAmounttxt;
        private NumericUpDown BrandIdtxt;
        private MaskedTextBox maskedAsDatetxt;
        private Label label4;
        private Label label5;
        private MaskedTextBox maskedToDatetxt;
    }
}