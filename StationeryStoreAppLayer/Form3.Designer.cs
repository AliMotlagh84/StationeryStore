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
            MinTotalAmountTxt = new NumericUpDown();
            label7 = new Label();
            MaxTotalAmountTxt = new NumericUpDown();
            label6 = new Label();
            MinRequestedCountTxt = new NumericUpDown();
            label5 = new Label();
            BrandNameTxt = new TextBox();
            label4 = new Label();
            ProductIdTxt = new NumericUpDown();
            label3 = new Label();
            BrandIdtxt = new NumericUpDown();
            MaxAmountTxt = new NumericUpDown();
            MinAmounttxt = new NumericUpDown();
            label2 = new Label();
            label1 = new Label();
            BrandNameLbl = new Label();
            btnProductsSearch = new Button();
            txtProductName = new TextBox();
            ProductNameLbl = new Label();
            DGPruducts = new DataGridView();
            DraftOrderId = new DataGridViewTextBoxColumn();
            UserId = new DataGridViewTextBoxColumn();
            UserName = new DataGridViewTextBoxColumn();
            ProductId = new DataGridViewTextBoxColumn();
            ProductName = new DataGridViewTextBoxColumn();
            BrandId = new DataGridViewTextBoxColumn();
            BrandName = new DataGridViewTextBoxColumn();
            RequestedCount = new DataGridViewTextBoxColumn();
            Amount = new DataGridViewTextBoxColumn();
            TotalAmount = new DataGridViewTextBoxColumn();
            MaxCountTxt = new NumericUpDown();
            label8 = new Label();
            DraftOrderIdTxt = new NumericUpDown();
            label9 = new Label();
            ProductGB.SuspendLayout();
            ProductsSearchBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MinTotalAmountTxt).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MaxTotalAmountTxt).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MinRequestedCountTxt).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ProductIdTxt).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BrandIdtxt).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MaxAmountTxt).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MinAmounttxt).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DGPruducts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MaxCountTxt).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DraftOrderIdTxt).BeginInit();
            SuspendLayout();
            // 
            // ProductGB
            // 
            ProductGB.Controls.Add(ProductsSearchBox);
            ProductGB.Controls.Add(DGPruducts);
            ProductGB.Location = new Point(31, 14);
            ProductGB.Name = "ProductGB";
            ProductGB.Size = new Size(869, 587);
            ProductGB.TabIndex = 6;
            ProductGB.TabStop = false;
            ProductGB.Text = "محصولات";
            // 
            // ProductsSearchBox
            // 
            ProductsSearchBox.Controls.Add(DraftOrderIdTxt);
            ProductsSearchBox.Controls.Add(label9);
            ProductsSearchBox.Controls.Add(MaxCountTxt);
            ProductsSearchBox.Controls.Add(label8);
            ProductsSearchBox.Controls.Add(MinTotalAmountTxt);
            ProductsSearchBox.Controls.Add(label7);
            ProductsSearchBox.Controls.Add(MaxTotalAmountTxt);
            ProductsSearchBox.Controls.Add(label6);
            ProductsSearchBox.Controls.Add(MinRequestedCountTxt);
            ProductsSearchBox.Controls.Add(label5);
            ProductsSearchBox.Controls.Add(BrandNameTxt);
            ProductsSearchBox.Controls.Add(label4);
            ProductsSearchBox.Controls.Add(ProductIdTxt);
            ProductsSearchBox.Controls.Add(label3);
            ProductsSearchBox.Controls.Add(BrandIdtxt);
            ProductsSearchBox.Controls.Add(MaxAmountTxt);
            ProductsSearchBox.Controls.Add(MinAmounttxt);
            ProductsSearchBox.Controls.Add(label2);
            ProductsSearchBox.Controls.Add(label1);
            ProductsSearchBox.Controls.Add(BrandNameLbl);
            ProductsSearchBox.Controls.Add(btnProductsSearch);
            ProductsSearchBox.Controls.Add(txtProductName);
            ProductsSearchBox.Controls.Add(ProductNameLbl);
            ProductsSearchBox.Dock = DockStyle.Top;
            ProductsSearchBox.Location = new Point(3, 23);
            ProductsSearchBox.Name = "ProductsSearchBox";
            ProductsSearchBox.Size = new Size(863, 192);
            ProductsSearchBox.TabIndex = 1;
            ProductsSearchBox.TabStop = false;
            ProductsSearchBox.Text = "جستوجو در محصولات ";
            // 
            // MinTotalAmountTxt
            // 
            MinTotalAmountTxt.Location = new Point(255, 134);
            MinTotalAmountTxt.Maximum = new decimal(new int[] { 1569325056, 23283064, 0, 0 });
            MinTotalAmountTxt.Name = "MinTotalAmountTxt";
            MinTotalAmountTxt.Size = new Size(117, 27);
            MinTotalAmountTxt.TabIndex = 27;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(378, 134);
            label7.Name = "label7";
            label7.Size = new Size(114, 20);
            label7.TabIndex = 26;
            label7.Text = "از قیمت مجموع :";
            // 
            // MaxTotalAmountTxt
            // 
            MaxTotalAmountTxt.Location = new Point(10, 131);
            MaxTotalAmountTxt.Maximum = new decimal(new int[] { 1569325056, 23283064, 0, 0 });
            MaxTotalAmountTxt.Name = "MaxTotalAmountTxt";
            MaxTotalAmountTxt.Size = new Size(117, 27);
            MaxTotalAmountTxt.TabIndex = 25;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(133, 131);
            label6.Name = "label6";
            label6.Size = new Size(113, 20);
            label6.TabIndex = 23;
            label6.Text = "تا قیمت مجموع :";
            // 
            // MinRequestedCountTxt
            // 
            MinRequestedCountTxt.Location = new Point(620, 134);
            MinRequestedCountTxt.Maximum = new decimal(new int[] { 1569325056, 23283064, 0, 0 });
            MinRequestedCountTxt.Name = "MinRequestedCountTxt";
            MinRequestedCountTxt.Size = new Size(117, 27);
            MinRequestedCountTxt.TabIndex = 21;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(749, 138);
            label5.Name = "label5";
            label5.Size = new Size(98, 20);
            label5.TabIndex = 20;
            label5.Text = "کمترین تعداد :";
            // 
            // BrandNameTxt
            // 
            BrandNameTxt.Location = new Point(620, 35);
            BrandNameTxt.Name = "BrandNameTxt";
            BrandNameTxt.Size = new Size(117, 27);
            BrandNameTxt.TabIndex = 19;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(745, 38);
            label4.Name = "label4";
            label4.Size = new Size(61, 20);
            label4.TabIndex = 18;
            label4.Text = "نام برند :";
            // 
            // ProductIdTxt
            // 
            ProductIdTxt.Location = new Point(143, 35);
            ProductIdTxt.Maximum = new decimal(new int[] { 1569325056, 23283064, 0, 0 });
            ProductIdTxt.Name = "ProductIdTxt";
            ProductIdTxt.Size = new Size(117, 27);
            ProductIdTxt.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(272, 39);
            label3.Name = "label3";
            label3.Size = new Size(102, 20);
            label3.TabIndex = 16;
            label3.Text = "ای دی محصول";
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
            BrandNameLbl.Size = new Size(85, 20);
            BrandNameLbl.TabIndex = 5;
            BrandNameLbl.Text = "آی دی برند : ";
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
            txtProductName.Location = new Point(145, 80);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(117, 27);
            txtProductName.TabIndex = 1;
            // 
            // ProductNameLbl
            // 
            ProductNameLbl.AutoSize = true;
            ProductNameLbl.Location = new Point(272, 83);
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
            DGPruducts.Columns.AddRange(new DataGridViewColumn[] { DraftOrderId, UserId, UserName, ProductId, ProductName, BrandId, BrandName, RequestedCount, Amount, TotalAmount });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            DGPruducts.DefaultCellStyle = dataGridViewCellStyle4;
            DGPruducts.Location = new Point(6, 235);
            DGPruducts.Name = "DGPruducts";
            DGPruducts.ReadOnly = true;
            DGPruducts.RowHeadersWidth = 51;
            DGPruducts.Size = new Size(863, 340);
            DGPruducts.TabIndex = 0;
            // 
            // DraftOrderId
            // 
            DraftOrderId.DataPropertyName = "DraftOrderId";
            DraftOrderId.HeaderText = "آی دی پیش سفارش";
            DraftOrderId.MinimumWidth = 6;
            DraftOrderId.Name = "DraftOrderId";
            DraftOrderId.ReadOnly = true;
            // 
            // UserId
            // 
            UserId.DataPropertyName = "UserId";
            UserId.HeaderText = "آی دی کاربر";
            UserId.MinimumWidth = 6;
            UserId.Name = "UserId";
            UserId.ReadOnly = true;
            // 
            // UserName
            // 
            UserName.DataPropertyName = "UserName";
            UserName.HeaderText = "نام کاربر";
            UserName.MinimumWidth = 6;
            UserName.Name = "UserName";
            UserName.ReadOnly = true;
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
            // RequestedCount
            // 
            RequestedCount.DataPropertyName = "RequestedCount";
            RequestedCount.HeaderText = "تعداد";
            RequestedCount.MinimumWidth = 6;
            RequestedCount.Name = "RequestedCount";
            RequestedCount.ReadOnly = true;
            // 
            // Amount
            // 
            Amount.DataPropertyName = "Amount";
            Amount.HeaderText = "قیمت";
            Amount.MinimumWidth = 6;
            Amount.Name = "Amount";
            Amount.ReadOnly = true;
            // 
            // TotalAmount
            // 
            TotalAmount.DataPropertyName = "TotalAmount";
            TotalAmount.HeaderText = "جمع کل";
            TotalAmount.MinimumWidth = 6;
            TotalAmount.Name = "TotalAmount";
            TotalAmount.ReadOnly = true;
            // 
            // MaxCountTxt
            // 
            MaxCountTxt.Location = new Point(620, 165);
            MaxCountTxt.Maximum = new decimal(new int[] { 1569325056, 23283064, 0, 0 });
            MaxCountTxt.Name = "MaxCountTxt";
            MaxCountTxt.Size = new Size(117, 27);
            MaxCountTxt.TabIndex = 29;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(749, 169);
            label8.Name = "label8";
            label8.Size = new Size(104, 20);
            label8.TabIndex = 28;
            label8.Text = "بیشترین تعداد :";
            // 
            // DraftOrderIdTxt
            // 
            DraftOrderIdTxt.Location = new Point(255, 162);
            DraftOrderIdTxt.Maximum = new decimal(new int[] { 1569325056, 23283064, 0, 0 });
            DraftOrderIdTxt.Name = "DraftOrderIdTxt";
            DraftOrderIdTxt.Size = new Size(117, 27);
            DraftOrderIdTxt.TabIndex = 31;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(379, 162);
            label9.Name = "label9";
            label9.Size = new Size(85, 20);
            label9.TabIndex = 30;
            label9.Text = "آی دی برند : ";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(944, 566);
            Controls.Add(ProductGB);
            Name = "Form3";
            RightToLeft = RightToLeft.Yes;
            Text = "Form3";
            Load += Form3_Load;
            ProductGB.ResumeLayout(false);
            ProductsSearchBox.ResumeLayout(false);
            ProductsSearchBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)MinTotalAmountTxt).EndInit();
            ((System.ComponentModel.ISupportInitialize)MaxTotalAmountTxt).EndInit();
            ((System.ComponentModel.ISupportInitialize)MinRequestedCountTxt).EndInit();
            ((System.ComponentModel.ISupportInitialize)ProductIdTxt).EndInit();
            ((System.ComponentModel.ISupportInitialize)BrandIdtxt).EndInit();
            ((System.ComponentModel.ISupportInitialize)MaxAmountTxt).EndInit();
            ((System.ComponentModel.ISupportInitialize)MinAmounttxt).EndInit();
            ((System.ComponentModel.ISupportInitialize)DGPruducts).EndInit();
            ((System.ComponentModel.ISupportInitialize)MaxCountTxt).EndInit();
            ((System.ComponentModel.ISupportInitialize)DraftOrderIdTxt).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox ProductGB;
        private GroupBox ProductsSearchBox;
        private Button btnProductsSearch;
        private TextBox txtProductName;
        private Label ProductNameLbl;
        private DataGridView DGPruducts;
        private Label label1;
        private Label BrandNameLbl;
        private Label label2;
        private NumericUpDown MaxAmountTxt;
        private NumericUpDown MinAmounttxt;
        private NumericUpDown BrandIdtxt;
        private DataGridViewTextBoxColumn DraftOrderId;
        private DataGridViewTextBoxColumn UserId;
        private DataGridViewTextBoxColumn UserName;
        private DataGridViewTextBoxColumn ProductId;
        private DataGridViewTextBoxColumn ProductName;
        private DataGridViewTextBoxColumn BrandId;
        private DataGridViewTextBoxColumn BrandName;
        private DataGridViewTextBoxColumn RequestedCount;
        private DataGridViewTextBoxColumn Amount;
        private DataGridViewTextBoxColumn TotalAmount;
        private NumericUpDown ProductIdTxt;
        private Label label3;
        private TextBox BrandNameTxt;
        private Label label4;
        private NumericUpDown MinRequestedCountTxt;
        private Label label5;
        private NumericUpDown MaxTotalAmountTxt;
        private Label label6;
        private NumericUpDown MinTotalAmountTxt;
        private Label label7;
        private NumericUpDown MaxCountTxt;
        private Label label8;
        private NumericUpDown DraftOrderIdTxt;
        private Label label9;
    }
}