namespace StationeryStoreUILayer.Forms.ProductsManagerForms_for_Admin_
{
    partial class ProductsManagerForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            ProductGB = new GroupBox();
            ProductsSearchGB = new GroupBox();
            BrandIdCombo = new ComboBox();
            label5 = new Label();
            MaxDatetxt = new MaskedTextBox();
            label4 = new Label();
            MinDatetxt = new MaskedTextBox();
            MaxAmountTxt = new NumericUpDown();
            MinAmounttxt = new NumericUpDown();
            label3 = new Label();
            AvailablityCombo = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            BrandNameLbl = new Label();
            ProductsSearchBtn = new Button();
            txtProductName = new TextBox();
            ProductNameLbl = new Label();
            DGPruducts = new DataGridView();
            ProductId = new DataGridViewTextBoxColumn();
            ProductName = new DataGridViewTextBoxColumn();
            BrandId = new DataGridViewTextBoxColumn();
            BrandName = new DataGridViewTextBoxColumn();
            Count = new DataGridViewTextBoxColumn();
            Amount = new DataGridViewTextBoxColumn();
            AddTime = new DataGridViewTextBoxColumn();
            groupBox1 = new GroupBox();
            RefreshFrom = new Button();
            DeleteProductBtn = new Button();
            UpdateProductBtn = new Button();
            IncreaseCountBtn = new Button();
            AddNewProductBtn = new Button();
            ProductGB.SuspendLayout();
            ProductsSearchGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MaxAmountTxt).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MinAmounttxt).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DGPruducts).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // ProductGB
            // 
            ProductGB.Controls.Add(ProductsSearchGB);
            ProductGB.Controls.Add(DGPruducts);
            ProductGB.Location = new Point(0, 12);
            ProductGB.Name = "ProductGB";
            ProductGB.Size = new Size(869, 387);
            ProductGB.TabIndex = 6;
            ProductGB.TabStop = false;
            ProductGB.Text = "محصولات";
            // 
            // ProductsSearchGB
            // 
            ProductsSearchGB.BackColor = Color.FromArgb(255, 128, 128);
            ProductsSearchGB.Controls.Add(BrandIdCombo);
            ProductsSearchGB.Controls.Add(label5);
            ProductsSearchGB.Controls.Add(MaxDatetxt);
            ProductsSearchGB.Controls.Add(label4);
            ProductsSearchGB.Controls.Add(MinDatetxt);
            ProductsSearchGB.Controls.Add(MaxAmountTxt);
            ProductsSearchGB.Controls.Add(MinAmounttxt);
            ProductsSearchGB.Controls.Add(label3);
            ProductsSearchGB.Controls.Add(AvailablityCombo);
            ProductsSearchGB.Controls.Add(label2);
            ProductsSearchGB.Controls.Add(label1);
            ProductsSearchGB.Controls.Add(BrandNameLbl);
            ProductsSearchGB.Controls.Add(ProductsSearchBtn);
            ProductsSearchGB.Controls.Add(txtProductName);
            ProductsSearchGB.Controls.Add(ProductNameLbl);
            ProductsSearchGB.Dock = DockStyle.Top;
            ProductsSearchGB.ForeColor = Color.White;
            ProductsSearchGB.Location = new Point(3, 23);
            ProductsSearchGB.Name = "ProductsSearchGB";
            ProductsSearchGB.Size = new Size(863, 118);
            ProductsSearchGB.TabIndex = 2;
            ProductsSearchGB.TabStop = false;
            ProductsSearchGB.Text = "جستوجو در محصولات ";
            // 
            // BrandIdCombo
            // 
            BrandIdCombo.BackColor = Color.FromArgb(255, 128, 128);
            BrandIdCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            BrandIdCombo.FormattingEnabled = true;
            BrandIdCombo.Location = new Point(621, 84);
            BrandIdCombo.Name = "BrandIdCombo";
            BrandIdCombo.Size = new Size(117, 28);
            BrandIdCombo.TabIndex = 20;
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
            // MaxDatetxt
            // 
            MaxDatetxt.BackColor = Color.FromArgb(255, 192, 192);
            MaxDatetxt.Location = new Point(6, 81);
            MaxDatetxt.Mask = "0000/00/00";
            MaxDatetxt.Name = "MaxDatetxt";
            MaxDatetxt.Size = new Size(112, 27);
            MaxDatetxt.TabIndex = 18;
            MaxDatetxt.ValidatingType = typeof(DateTime);
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
            // MinDatetxt
            // 
            MinDatetxt.BackColor = Color.FromArgb(255, 192, 192);
            MinDatetxt.Location = new Point(189, 81);
            MinDatetxt.Mask = "0000/00/00";
            MinDatetxt.Name = "MinDatetxt";
            MinDatetxt.Size = new Size(112, 27);
            MinDatetxt.TabIndex = 16;
            MinDatetxt.ValidatingType = typeof(DateTime);
            // 
            // MaxAmountTxt
            // 
            MaxAmountTxt.BackColor = Color.FromArgb(255, 192, 192);
            MaxAmountTxt.Location = new Point(399, 84);
            MaxAmountTxt.Maximum = new decimal(new int[] { 1569325056, 23283064, 0, 0 });
            MaxAmountTxt.Name = "MaxAmountTxt";
            MaxAmountTxt.Size = new Size(117, 27);
            MaxAmountTxt.TabIndex = 14;
            // 
            // MinAmounttxt
            // 
            MinAmounttxt.BackColor = Color.FromArgb(255, 192, 192);
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
            AvailablityCombo.BackColor = Color.FromArgb(255, 192, 192);
            AvailablityCombo.DropDownStyle = ComboBoxStyle.DropDownList;
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
            // ProductsSearchBtn
            // 
            ProductsSearchBtn.BackColor = Color.Firebrick;
            ProductsSearchBtn.FlatStyle = FlatStyle.Popup;
            ProductsSearchBtn.ForeColor = Color.White;
            ProductsSearchBtn.Location = new Point(6, 34);
            ProductsSearchBtn.Name = "ProductsSearchBtn";
            ProductsSearchBtn.Size = new Size(131, 29);
            ProductsSearchBtn.TabIndex = 4;
            ProductsSearchBtn.Text = "جستوجو";
            ProductsSearchBtn.UseVisualStyleBackColor = false;
            ProductsSearchBtn.Click += ProductsSearchBtn_Click;
            // 
            // txtProductName
            // 
            txtProductName.BackColor = Color.FromArgb(255, 192, 192);
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
            DGPruducts.BackgroundColor = Color.FromArgb(255, 192, 192);
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            DGPruducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            DGPruducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGPruducts.Columns.AddRange(new DataGridViewColumn[] { ProductId, ProductName, BrandId, BrandName, Count, Amount, AddTime });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            DGPruducts.DefaultCellStyle = dataGridViewCellStyle2;
            DGPruducts.GridColor = Color.Firebrick;
            DGPruducts.Location = new Point(4, 147);
            DGPruducts.Name = "DGPruducts";
            DGPruducts.ReadOnly = true;
            DGPruducts.RowHeadersWidth = 51;
            DGPruducts.Size = new Size(863, 240);
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
            // AddTime
            // 
            AddTime.DataPropertyName = "AddTime";
            AddTime.HeaderText = "تاریخ اضافه شدن";
            AddTime.MinimumWidth = 6;
            AddTime.Name = "AddTime";
            AddTime.ReadOnly = true;
            AddTime.Visible = false;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Salmon;
            groupBox1.Controls.Add(RefreshFrom);
            groupBox1.Controls.Add(DeleteProductBtn);
            groupBox1.Controls.Add(UpdateProductBtn);
            groupBox1.Controls.Add(IncreaseCountBtn);
            groupBox1.Controls.Add(AddNewProductBtn);
            groupBox1.Location = new Point(3, 405);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(863, 100);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            // 
            // RefreshFrom
            // 
            RefreshFrom.BackColor = Color.Thistle;
            RefreshFrom.FlatStyle = FlatStyle.Popup;
            RefreshFrom.ForeColor = Color.Indigo;
            RefreshFrom.Image = StationeryStoreUILayer.Properties.Resources.icons8_refresh_60;
            RefreshFrom.ImageAlign = ContentAlignment.TopCenter;
            RefreshFrom.Location = new Point(9, 15);
            RefreshFrom.Name = "RefreshFrom";
            RefreshFrom.Size = new Size(143, 79);
            RefreshFrom.TabIndex = 4;
            RefreshFrom.Text = "رفرش کردن فرم";
            RefreshFrom.TextAlign = ContentAlignment.BottomCenter;
            RefreshFrom.UseVisualStyleBackColor = false;
            RefreshFrom.Click += RefreshFrom_Click;
            // 
            // DeleteProductBtn
            // 
            DeleteProductBtn.BackColor = Color.FromArgb(255, 192, 192);
            DeleteProductBtn.FlatStyle = FlatStyle.Popup;
            DeleteProductBtn.ForeColor = Color.Maroon;
            DeleteProductBtn.Image = StationeryStoreUILayer.Properties.Resources.icons8_remove_60;
            DeleteProductBtn.ImageAlign = ContentAlignment.TopCenter;
            DeleteProductBtn.Location = new Point(175, 15);
            DeleteProductBtn.Name = "DeleteProductBtn";
            DeleteProductBtn.Size = new Size(148, 79);
            DeleteProductBtn.TabIndex = 3;
            DeleteProductBtn.Text = "حذف محصول";
            DeleteProductBtn.TextAlign = ContentAlignment.BottomCenter;
            DeleteProductBtn.UseVisualStyleBackColor = false;
            DeleteProductBtn.Click += DeleteProductBtn_Click;
            // 
            // UpdateProductBtn
            // 
            UpdateProductBtn.BackColor = Color.FromArgb(192, 255, 192);
            UpdateProductBtn.FlatStyle = FlatStyle.Popup;
            UpdateProductBtn.ForeColor = Color.DarkGreen;
            UpdateProductBtn.Image = StationeryStoreUILayer.Properties.Resources.icons8_update_product_60;
            UpdateProductBtn.ImageAlign = ContentAlignment.TopCenter;
            UpdateProductBtn.Location = new Point(347, 15);
            UpdateProductBtn.Name = "UpdateProductBtn";
            UpdateProductBtn.Size = new Size(151, 79);
            UpdateProductBtn.TabIndex = 2;
            UpdateProductBtn.Text = "ویرایش محصول";
            UpdateProductBtn.TextAlign = ContentAlignment.BottomCenter;
            UpdateProductBtn.UseVisualStyleBackColor = false;
            UpdateProductBtn.Click += UpdateProductBtn_Click;
            // 
            // IncreaseCountBtn
            // 
            IncreaseCountBtn.BackColor = Color.Aquamarine;
            IncreaseCountBtn.FlatStyle = FlatStyle.Popup;
            IncreaseCountBtn.ForeColor = Color.FromArgb(0, 0, 192);
            IncreaseCountBtn.Image = StationeryStoreUILayer.Properties.Resources.icons8_add_Properties_60;
            IncreaseCountBtn.ImageAlign = ContentAlignment.TopCenter;
            IncreaseCountBtn.Location = new Point(525, 15);
            IncreaseCountBtn.Name = "IncreaseCountBtn";
            IncreaseCountBtn.Size = new Size(153, 79);
            IncreaseCountBtn.TabIndex = 1;
            IncreaseCountBtn.Text = "افزودن تعداد محصول";
            IncreaseCountBtn.TextAlign = ContentAlignment.BottomCenter;
            IncreaseCountBtn.UseVisualStyleBackColor = false;
            IncreaseCountBtn.Click += IncreaseCountBtn_Click;
            // 
            // AddNewProductBtn
            // 
            AddNewProductBtn.BackColor = Color.FromArgb(255, 255, 128);
            AddNewProductBtn.FlatStyle = FlatStyle.Popup;
            AddNewProductBtn.ForeColor = Color.FromArgb(192, 64, 0);
            AddNewProductBtn.Image = StationeryStoreUILayer.Properties.Resources.icons8_add_product_60;
            AddNewProductBtn.ImageAlign = ContentAlignment.TopCenter;
            AddNewProductBtn.Location = new Point(701, 15);
            AddNewProductBtn.Name = "AddNewProductBtn";
            AddNewProductBtn.Size = new Size(150, 79);
            AddNewProductBtn.TabIndex = 0;
            AddNewProductBtn.Text = "افزودن محصول جدید";
            AddNewProductBtn.TextAlign = ContentAlignment.BottomCenter;
            AddNewProductBtn.UseVisualStyleBackColor = false;
            AddNewProductBtn.Click += AddNewProductBtn_Click;
            // 
            // ProductsManagerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 192);
            ClientSize = new Size(872, 508);
            Controls.Add(groupBox1);
            Controls.Add(ProductGB);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "ProductsManagerForm";
            RightToLeft = RightToLeft.Yes;
            StartPosition = FormStartPosition.CenterParent;
            Text = "مدیریت محصولات";
            Load += ProductsManagerForm_Load;
            ProductGB.ResumeLayout(false);
            ProductsSearchGB.ResumeLayout(false);
            ProductsSearchGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)MaxAmountTxt).EndInit();
            ((System.ComponentModel.ISupportInitialize)MinAmounttxt).EndInit();
            ((System.ComponentModel.ISupportInitialize)DGPruducts).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox ProductGB;
        private GroupBox ProductsSearchGB;
        private ComboBox BrandIdCombo;
        private Label label5;
        private MaskedTextBox MaxDatetxt;
        private Label label4;
        private MaskedTextBox MinDatetxt;
        private NumericUpDown MaxAmountTxt;
        private NumericUpDown MinAmounttxt;
        private Label label3;
        private ComboBox AvailablityCombo;
        private Label label2;
        private Label label1;
        private Label BrandNameLbl;
        private Button ProductsSearchBtn;
        private TextBox txtProductName;
        private Label ProductNameLbl;
        private DataGridView DGPruducts;
        private GroupBox groupBox1;
        private Button UpdateProductBtn;
        private Button IncreaseCountBtn;
        private Button AddNewProductBtn;
        private Button RefreshFrom;
        private Button DeleteProductBtn;
        private DataGridViewTextBoxColumn ProductId;
        private DataGridViewTextBoxColumn ProductName;
        private DataGridViewTextBoxColumn BrandId;
        private DataGridViewTextBoxColumn BrandName;
        private DataGridViewTextBoxColumn Count;
        private DataGridViewTextBoxColumn Amount;
        private DataGridViewTextBoxColumn AddTime;
    }
}