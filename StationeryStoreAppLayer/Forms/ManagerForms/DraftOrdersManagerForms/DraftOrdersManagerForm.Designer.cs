namespace StationeryStoreUILayer.Forms.ManagerForms.DraftOrdersManagerForms
{
    partial class DraftOrdersManagerForm
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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DarftOrderSearchGB = new GroupBox();
            label7 = new Label();
            txtMinRequestedCount = new NumericUpDown();
            txtUserName = new TextBox();
            label6 = new Label();
            SearchBtn = new Button();
            label5 = new Label();
            txtMaxRequestedCount = new NumericUpDown();
            txtMaxAmount = new NumericUpDown();
            txtMinAmount = new NumericUpDown();
            label3 = new Label();
            label4 = new Label();
            MaxTotalAmountTxt = new NumericUpDown();
            MinTotalAmounttxt = new NumericUpDown();
            label2 = new Label();
            label1 = new Label();
            BarndIdCombo = new ComboBox();
            BrandNameLbl = new Label();
            txtProductName = new TextBox();
            ProductNameLbl = new Label();
            groupBox1 = new GroupBox();
            DraftOrdersDG = new DataGridView();
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
            groupBox2 = new GroupBox();
            RefreshBtn = new Button();
            DeleteDraftOrderBtn = new Button();
            DarftOrderSearchGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtMinRequestedCount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtMaxRequestedCount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtMaxAmount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtMinAmount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MaxTotalAmountTxt).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MinTotalAmounttxt).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DraftOrdersDG).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // DarftOrderSearchGB
            // 
            DarftOrderSearchGB.BackColor = Color.FromArgb(0, 192, 192);
            DarftOrderSearchGB.Controls.Add(label7);
            DarftOrderSearchGB.Controls.Add(txtMinRequestedCount);
            DarftOrderSearchGB.Controls.Add(txtUserName);
            DarftOrderSearchGB.Controls.Add(label6);
            DarftOrderSearchGB.Controls.Add(SearchBtn);
            DarftOrderSearchGB.Controls.Add(label5);
            DarftOrderSearchGB.Controls.Add(txtMaxRequestedCount);
            DarftOrderSearchGB.Controls.Add(txtMaxAmount);
            DarftOrderSearchGB.Controls.Add(txtMinAmount);
            DarftOrderSearchGB.Controls.Add(label3);
            DarftOrderSearchGB.Controls.Add(label4);
            DarftOrderSearchGB.Controls.Add(MaxTotalAmountTxt);
            DarftOrderSearchGB.Controls.Add(MinTotalAmounttxt);
            DarftOrderSearchGB.Controls.Add(label2);
            DarftOrderSearchGB.Controls.Add(label1);
            DarftOrderSearchGB.Controls.Add(BarndIdCombo);
            DarftOrderSearchGB.Controls.Add(BrandNameLbl);
            DarftOrderSearchGB.Controls.Add(txtProductName);
            DarftOrderSearchGB.Controls.Add(ProductNameLbl);
            DarftOrderSearchGB.ForeColor = Color.White;
            DarftOrderSearchGB.Location = new Point(0, 115);
            DarftOrderSearchGB.Name = "DarftOrderSearchGB";
            DarftOrderSearchGB.Size = new Size(1161, 113);
            DarftOrderSearchGB.TabIndex = 0;
            DarftOrderSearchGB.TabStop = false;
            DarftOrderSearchGB.Text = "جستوجو در پیش سفارش ها";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(798, 30);
            label7.Name = "label7";
            label7.Size = new Size(134, 20);
            label7.TabIndex = 41;
            label7.Text = "از تعداد درخواستی :";
            // 
            // txtMinRequestedCount
            // 
            txtMinRequestedCount.BackColor = Color.FromArgb(192, 255, 255);
            txtMinRequestedCount.ForeColor = Color.FromArgb(0, 64, 64);
            txtMinRequestedCount.Location = new Point(675, 29);
            txtMinRequestedCount.Maximum = new decimal(new int[] { 1569325056, 23283064, 0, 0 });
            txtMinRequestedCount.Name = "txtMinRequestedCount";
            txtMinRequestedCount.Size = new Size(117, 27);
            txtMinRequestedCount.TabIndex = 40;
            // 
            // txtUserName
            // 
            txtUserName.BackColor = Color.FromArgb(192, 255, 255);
            txtUserName.ForeColor = Color.FromArgb(0, 64, 64);
            txtUserName.Location = new Point(27, 26);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(117, 27);
            txtUserName.TabIndex = 39;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(151, 29);
            label6.Name = "label6";
            label6.Size = new Size(67, 20);
            label6.TabIndex = 38;
            label6.Text = "نام کاربر :";
            // 
            // SearchBtn
            // 
            SearchBtn.BackColor = Color.FromArgb(0, 64, 64);
            SearchBtn.FlatStyle = FlatStyle.Popup;
            SearchBtn.ForeColor = Color.White;
            SearchBtn.ImageAlign = ContentAlignment.TopCenter;
            SearchBtn.Location = new Point(27, 74);
            SearchBtn.Name = "SearchBtn";
            SearchBtn.Size = new Size(117, 28);
            SearchBtn.TabIndex = 37;
            SearchBtn.Text = "جستوجو";
            SearchBtn.TextAlign = ContentAlignment.BottomCenter;
            SearchBtn.UseVisualStyleBackColor = false;
            SearchBtn.Click += SearchBtn_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(798, 75);
            label5.Name = "label5";
            label5.Size = new Size(137, 20);
            label5.TabIndex = 34;
            label5.Text = " تا تعداد درخواستی :";
            // 
            // txtMaxRequestedCount
            // 
            txtMaxRequestedCount.BackColor = Color.FromArgb(192, 255, 255);
            txtMaxRequestedCount.ForeColor = Color.FromArgb(0, 64, 64);
            txtMaxRequestedCount.Location = new Point(675, 74);
            txtMaxRequestedCount.Maximum = new decimal(new int[] { 1569325056, 23283064, 0, 0 });
            txtMaxRequestedCount.Name = "txtMaxRequestedCount";
            txtMaxRequestedCount.Size = new Size(117, 27);
            txtMaxRequestedCount.TabIndex = 33;
            // 
            // txtMaxAmount
            // 
            txtMaxAmount.BackColor = Color.FromArgb(192, 255, 255);
            txtMaxAmount.ForeColor = Color.FromArgb(0, 64, 64);
            txtMaxAmount.Location = new Point(229, 76);
            txtMaxAmount.Maximum = new decimal(new int[] { 1569325056, 23283064, 0, 0 });
            txtMaxAmount.Name = "txtMaxAmount";
            txtMaxAmount.Size = new Size(117, 27);
            txtMaxAmount.TabIndex = 32;
            // 
            // txtMinAmount
            // 
            txtMinAmount.BackColor = Color.FromArgb(192, 255, 255);
            txtMinAmount.ForeColor = Color.FromArgb(0, 64, 64);
            txtMinAmount.Location = new Point(228, 26);
            txtMinAmount.Maximum = new decimal(new int[] { 1569325056, 23283064, 0, 0 });
            txtMinAmount.Name = "txtMinAmount";
            txtMinAmount.Size = new Size(117, 27);
            txtMinAmount.TabIndex = 31;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(352, 78);
            label3.Name = "label3";
            label3.Size = new Size(65, 20);
            label3.TabIndex = 30;
            label3.Text = "تا قیمت :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(354, 31);
            label4.Name = "label4";
            label4.Size = new Size(66, 20);
            label4.TabIndex = 29;
            label4.Text = "از قیمت :";
            // 
            // MaxTotalAmountTxt
            // 
            MaxTotalAmountTxt.BackColor = Color.FromArgb(192, 255, 255);
            MaxTotalAmountTxt.ForeColor = Color.FromArgb(0, 64, 64);
            MaxTotalAmountTxt.Location = new Point(427, 76);
            MaxTotalAmountTxt.Maximum = new decimal(new int[] { 1569325056, 23283064, 0, 0 });
            MaxTotalAmountTxt.Name = "MaxTotalAmountTxt";
            MaxTotalAmountTxt.Size = new Size(117, 27);
            MaxTotalAmountTxt.TabIndex = 28;
            // 
            // MinTotalAmounttxt
            // 
            MinTotalAmounttxt.BackColor = Color.FromArgb(192, 255, 255);
            MinTotalAmounttxt.ForeColor = Color.FromArgb(0, 64, 64);
            MinTotalAmounttxt.Location = new Point(426, 26);
            MinTotalAmounttxt.Maximum = new decimal(new int[] { 1569325056, 23283064, 0, 0 });
            MinTotalAmounttxt.Name = "MinTotalAmounttxt";
            MinTotalAmounttxt.Size = new Size(117, 27);
            MinTotalAmounttxt.TabIndex = 27;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(550, 77);
            label2.Name = "label2";
            label2.Size = new Size(113, 20);
            label2.TabIndex = 26;
            label2.Text = "تا مجموع قیمت :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(552, 31);
            label1.Name = "label1";
            label1.Size = new Size(114, 20);
            label1.TabIndex = 25;
            label1.Text = "از مجموع قیمت :";
            // 
            // BarndIdCombo
            // 
            BarndIdCombo.BackColor = Color.FromArgb(192, 255, 255);
            BarndIdCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            BarndIdCombo.ForeColor = Color.FromArgb(0, 64, 64);
            BarndIdCombo.FormattingEnabled = true;
            BarndIdCombo.Location = new Point(945, 74);
            BarndIdCombo.Name = "BarndIdCombo";
            BarndIdCombo.Size = new Size(117, 28);
            BarndIdCombo.TabIndex = 24;
            // 
            // BrandNameLbl
            // 
            BrandNameLbl.AutoSize = true;
            BrandNameLbl.Location = new Point(1068, 74);
            BrandNameLbl.Name = "BrandNameLbl";
            BrandNameLbl.Size = new Size(61, 20);
            BrandNameLbl.TabIndex = 23;
            BrandNameLbl.Text = "نام برند :";
            // 
            // txtProductName
            // 
            txtProductName.BackColor = Color.FromArgb(192, 255, 255);
            txtProductName.ForeColor = Color.FromArgb(0, 64, 64);
            txtProductName.Location = new Point(944, 26);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(117, 27);
            txtProductName.TabIndex = 22;
            // 
            // ProductNameLbl
            // 
            ProductNameLbl.AutoSize = true;
            ProductNameLbl.Location = new Point(1068, 29);
            ProductNameLbl.Name = "ProductNameLbl";
            ProductNameLbl.Size = new Size(89, 20);
            ProductNameLbl.TabIndex = 21;
            ProductNameLbl.Text = "نام محصول :";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(DraftOrdersDG);
            groupBox1.Location = new Point(0, 224);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1161, 215);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "پیش سفارش ها";
            // 
            // DraftOrdersDG
            // 
            DraftOrdersDG.AllowUserToAddRows = false;
            DraftOrdersDG.AllowUserToDeleteRows = false;
            DraftOrdersDG.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DraftOrdersDG.BackgroundColor = Color.FromArgb(0, 192, 192);
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = SystemColors.Control;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            DraftOrdersDG.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            DraftOrdersDG.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DraftOrdersDG.Columns.AddRange(new DataGridViewColumn[] { DraftOrderId, UserId, UserName, ProductId, ProductName, BrandId, BrandName, RequestedCount, Amount, TotalAmount });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            DraftOrdersDG.DefaultCellStyle = dataGridViewCellStyle6;
            DraftOrdersDG.Dock = DockStyle.Fill;
            DraftOrdersDG.GridColor = Color.FromArgb(0, 64, 64);
            DraftOrdersDG.Location = new Point(3, 23);
            DraftOrdersDG.Name = "DraftOrdersDG";
            DraftOrdersDG.ReadOnly = true;
            DraftOrdersDG.RowHeadersWidth = 51;
            DraftOrdersDG.Size = new Size(1155, 189);
            DraftOrdersDG.TabIndex = 0;
            // 
            // DraftOrderId
            // 
            DraftOrderId.DataPropertyName = "DraftOrderId";
            DraftOrderId.HeaderText = "ای دی پیش سفارش";
            DraftOrderId.MinimumWidth = 6;
            DraftOrderId.Name = "DraftOrderId";
            DraftOrderId.ReadOnly = true;
            DraftOrderId.Visible = false;
            // 
            // UserId
            // 
            UserId.DataPropertyName = "UserId";
            UserId.HeaderText = "ای دی سفارش دهنده";
            UserId.MinimumWidth = 6;
            UserId.Name = "UserId";
            UserId.ReadOnly = true;
            UserId.Visible = false;
            // 
            // UserName
            // 
            UserName.DataPropertyName = "UserName";
            UserName.HeaderText = "نام سفارش دهنده";
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
            BrandId.HeaderText = "ای دی برند";
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
            RequestedCount.HeaderText = "تعداد درخواستی";
            RequestedCount.MinimumWidth = 6;
            RequestedCount.Name = "RequestedCount";
            RequestedCount.ReadOnly = true;
            // 
            // Amount
            // 
            Amount.DataPropertyName = "Amount";
            Amount.HeaderText = "قیمت محصول";
            Amount.MinimumWidth = 6;
            Amount.Name = "Amount";
            Amount.ReadOnly = true;
            // 
            // TotalAmount
            // 
            TotalAmount.DataPropertyName = "TotalAmount";
            TotalAmount.HeaderText = "قیمت مجموع";
            TotalAmount.MinimumWidth = 6;
            TotalAmount.Name = "TotalAmount";
            TotalAmount.ReadOnly = true;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.FromArgb(0, 192, 192);
            groupBox2.Controls.Add(RefreshBtn);
            groupBox2.Controls.Add(DeleteDraftOrderBtn);
            groupBox2.Location = new Point(0, -6);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1161, 102);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            // 
            // RefreshBtn
            // 
            RefreshBtn.BackColor = Color.Thistle;
            RefreshBtn.FlatStyle = FlatStyle.Popup;
            RefreshBtn.ForeColor = Color.Indigo;
            RefreshBtn.Image = StationeryStoreUILayer.Properties.Resources.icons8_refresh_60;
            RefreshBtn.ImageAlign = ContentAlignment.TopCenter;
            RefreshBtn.Location = new Point(833, 17);
            RefreshBtn.Name = "RefreshBtn";
            RefreshBtn.Size = new Size(155, 79);
            RefreshBtn.TabIndex = 5;
            RefreshBtn.Text = "رفرش کردن فرم";
            RefreshBtn.TextAlign = ContentAlignment.BottomCenter;
            RefreshBtn.UseVisualStyleBackColor = false;
            RefreshBtn.Click += RefreshFrom_Click;
            // 
            // DeleteDraftOrderBtn
            // 
            DeleteDraftOrderBtn.BackColor = Color.FromArgb(255, 192, 192);
            DeleteDraftOrderBtn.FlatStyle = FlatStyle.Popup;
            DeleteDraftOrderBtn.ForeColor = Color.Maroon;
            DeleteDraftOrderBtn.Image = StationeryStoreUILayer.Properties.Resources.icons8_delete_document_60;
            DeleteDraftOrderBtn.ImageAlign = ContentAlignment.TopCenter;
            DeleteDraftOrderBtn.Location = new Point(993, 17);
            DeleteDraftOrderBtn.Name = "DeleteDraftOrderBtn";
            DeleteDraftOrderBtn.Size = new Size(162, 79);
            DeleteDraftOrderBtn.TabIndex = 4;
            DeleteDraftOrderBtn.Text = "حذف پیش سفارش ";
            DeleteDraftOrderBtn.TextAlign = ContentAlignment.BottomCenter;
            DeleteDraftOrderBtn.UseVisualStyleBackColor = false;
            DeleteDraftOrderBtn.Click += DeleteDraftOrderBtn_Click;
            // 
            // DraftOrdersManagerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(1159, 442);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(DarftOrderSearchGB);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "DraftOrdersManagerForm";
            RightToLeft = RightToLeft.Yes;
            StartPosition = FormStartPosition.CenterParent;
            Text = "مدیریت سبد خرید";
            Load += DraftOrdersManagerForm_Load;
            DarftOrderSearchGB.ResumeLayout(false);
            DarftOrderSearchGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtMinRequestedCount).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtMaxRequestedCount).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtMaxAmount).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtMinAmount).EndInit();
            ((System.ComponentModel.ISupportInitialize)MaxTotalAmountTxt).EndInit();
            ((System.ComponentModel.ISupportInitialize)MinTotalAmounttxt).EndInit();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DraftOrdersDG).EndInit();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox DarftOrderSearchGB;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button DeleteDraftOrderBtn;
        private Button RefreshBtn;
        private ComboBox BarndIdCombo;
        private Label BrandNameLbl;
        private TextBox txtProductName;
        private Label ProductNameLbl;
        private NumericUpDown txtMaxAmount;
        private NumericUpDown txtMinAmount;
        private Label label3;
        private Label label4;
        private NumericUpDown MaxTotalAmountTxt;
        private NumericUpDown MinTotalAmounttxt;
        private Label label2;
        private Label label1;
        private Label label5;
        private NumericUpDown txtMaxRequestedCount;
        private DataGridView DraftOrdersDG;
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
        private Button SearchBtn;
        private Label label7;
        private NumericUpDown txtMinRequestedCount;
        private TextBox txtUserName;
        private Label label6;
    }
}