namespace StationeryStoreAppLayer.Forms.ManagerForms.DraftOrdersManagerForms
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
            DarftOrderSearchGB = new GroupBox();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            DeleteDraftOrderBtn = new Button();
            RefreshFrom = new Button();
            BarndIdCombo = new ComboBox();
            BrandNameLbl = new Label();
            txtProductName = new TextBox();
            ProductNameLbl = new Label();
            MaxAmountTxt = new NumericUpDown();
            MinAmounttxt = new NumericUpDown();
            label2 = new Label();
            label1 = new Label();
            numericUpDown1 = new NumericUpDown();
            numericUpDown2 = new NumericUpDown();
            label3 = new Label();
            label4 = new Label();
            numericUpDown3 = new NumericUpDown();
            label5 = new Label();
            textBox1 = new TextBox();
            label6 = new Label();
            dataGridView1 = new DataGridView();
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
            BrandUpdateBtn = new Button();
            DarftOrderSearchGB.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MaxAmountTxt).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MinAmounttxt).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // DarftOrderSearchGB
            // 
            DarftOrderSearchGB.BackColor = Color.FromArgb(0, 192, 192);
            DarftOrderSearchGB.Controls.Add(BrandUpdateBtn);
            DarftOrderSearchGB.Controls.Add(textBox1);
            DarftOrderSearchGB.Controls.Add(label6);
            DarftOrderSearchGB.Controls.Add(label5);
            DarftOrderSearchGB.Controls.Add(numericUpDown3);
            DarftOrderSearchGB.Controls.Add(numericUpDown1);
            DarftOrderSearchGB.Controls.Add(numericUpDown2);
            DarftOrderSearchGB.Controls.Add(label3);
            DarftOrderSearchGB.Controls.Add(label4);
            DarftOrderSearchGB.Controls.Add(MaxAmountTxt);
            DarftOrderSearchGB.Controls.Add(MinAmounttxt);
            DarftOrderSearchGB.Controls.Add(label2);
            DarftOrderSearchGB.Controls.Add(label1);
            DarftOrderSearchGB.Controls.Add(BarndIdCombo);
            DarftOrderSearchGB.Controls.Add(BrandNameLbl);
            DarftOrderSearchGB.Controls.Add(txtProductName);
            DarftOrderSearchGB.Controls.Add(ProductNameLbl);
            DarftOrderSearchGB.ForeColor = Color.White;
            DarftOrderSearchGB.Location = new Point(0, 115);
            DarftOrderSearchGB.Name = "DarftOrderSearchGB";
            DarftOrderSearchGB.Size = new Size(1034, 113);
            DarftOrderSearchGB.TabIndex = 0;
            DarftOrderSearchGB.TabStop = false;
            DarftOrderSearchGB.Text = "جستوجو در پیش سفارش ها";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Location = new Point(0, 224);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1034, 215);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "پیش سفارش ها";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.FromArgb(0, 192, 192);
            groupBox2.Controls.Add(RefreshFrom);
            groupBox2.Controls.Add(DeleteDraftOrderBtn);
            groupBox2.Location = new Point(0, -6);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1034, 102);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            // 
            // DeleteDraftOrderBtn
            // 
            DeleteDraftOrderBtn.BackColor = Color.FromArgb(255, 192, 192);
            DeleteDraftOrderBtn.FlatStyle = FlatStyle.Popup;
            DeleteDraftOrderBtn.ForeColor = Color.Maroon;
            DeleteDraftOrderBtn.Image = Properties.Resources.icons8_delete_document_60;
            DeleteDraftOrderBtn.ImageAlign = ContentAlignment.TopCenter;
            DeleteDraftOrderBtn.Location = new Point(875, 16);
            DeleteDraftOrderBtn.Name = "DeleteDraftOrderBtn";
            DeleteDraftOrderBtn.Size = new Size(150, 79);
            DeleteDraftOrderBtn.TabIndex = 4;
            DeleteDraftOrderBtn.Text = "حذف پیش سفارش ";
            DeleteDraftOrderBtn.TextAlign = ContentAlignment.BottomCenter;
            DeleteDraftOrderBtn.UseVisualStyleBackColor = false;
            // 
            // RefreshFrom
            // 
            RefreshFrom.BackColor = Color.Thistle;
            RefreshFrom.FlatStyle = FlatStyle.Popup;
            RefreshFrom.ForeColor = Color.Indigo;
            RefreshFrom.Image = Properties.Resources.icons8_refresh_60;
            RefreshFrom.ImageAlign = ContentAlignment.TopCenter;
            RefreshFrom.Location = new Point(715, 16);
            RefreshFrom.Name = "RefreshFrom";
            RefreshFrom.Size = new Size(143, 79);
            RefreshFrom.TabIndex = 5;
            RefreshFrom.Text = "رفرش کردن فرم";
            RefreshFrom.TextAlign = ContentAlignment.BottomCenter;
            RefreshFrom.UseVisualStyleBackColor = false;
            // 
            // BarndIdCombo
            // 
            BarndIdCombo.BackColor = Color.FromArgb(192, 255, 255);
            BarndIdCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            BarndIdCombo.ForeColor = Color.FromArgb(0, 64, 64);
            BarndIdCombo.FormattingEnabled = true;
            BarndIdCombo.Location = new Point(817, 74);
            BarndIdCombo.Name = "BarndIdCombo";
            BarndIdCombo.Size = new Size(117, 28);
            BarndIdCombo.TabIndex = 24;
            // 
            // BrandNameLbl
            // 
            BrandNameLbl.AutoSize = true;
            BrandNameLbl.Location = new Point(940, 74);
            BrandNameLbl.Name = "BrandNameLbl";
            BrandNameLbl.Size = new Size(61, 20);
            BrandNameLbl.TabIndex = 23;
            BrandNameLbl.Text = "نام برند :";
            // 
            // txtProductName
            // 
            txtProductName.BackColor = Color.FromArgb(192, 255, 255);
            txtProductName.ForeColor = Color.FromArgb(0, 64, 64);
            txtProductName.Location = new Point(816, 26);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(117, 27);
            txtProductName.TabIndex = 22;
            // 
            // ProductNameLbl
            // 
            ProductNameLbl.AutoSize = true;
            ProductNameLbl.Location = new Point(940, 29);
            ProductNameLbl.Name = "ProductNameLbl";
            ProductNameLbl.Size = new Size(89, 20);
            ProductNameLbl.TabIndex = 21;
            ProductNameLbl.Text = "نام محصول :";
            // 
            // MaxAmountTxt
            // 
            MaxAmountTxt.BackColor = Color.FromArgb(192, 255, 255);
            MaxAmountTxt.ForeColor = Color.FromArgb(0, 64, 64);
            MaxAmountTxt.Location = new Point(321, 76);
            MaxAmountTxt.Maximum = new decimal(new int[] { 1569325056, 23283064, 0, 0 });
            MaxAmountTxt.Name = "MaxAmountTxt";
            MaxAmountTxt.Size = new Size(117, 27);
            MaxAmountTxt.TabIndex = 28;
            // 
            // MinAmounttxt
            // 
            MinAmounttxt.BackColor = Color.FromArgb(192, 255, 255);
            MinAmounttxt.ForeColor = Color.FromArgb(0, 64, 64);
            MinAmounttxt.Location = new Point(320, 26);
            MinAmounttxt.Maximum = new decimal(new int[] { 1569325056, 23283064, 0, 0 });
            MinAmounttxt.Name = "MinAmounttxt";
            MinAmounttxt.Size = new Size(117, 27);
            MinAmounttxt.TabIndex = 27;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(444, 77);
            label2.Name = "label2";
            label2.Size = new Size(113, 20);
            label2.TabIndex = 26;
            label2.Text = "تا مجموع قیمت :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(446, 31);
            label1.Name = "label1";
            label1.Size = new Size(114, 20);
            label1.TabIndex = 25;
            label1.Text = "از مجموع قیمت :";
            // 
            // numericUpDown1
            // 
            numericUpDown1.BackColor = Color.FromArgb(192, 255, 255);
            numericUpDown1.ForeColor = Color.FromArgb(0, 64, 64);
            numericUpDown1.Location = new Point(123, 76);
            numericUpDown1.Maximum = new decimal(new int[] { 1569325056, 23283064, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(117, 27);
            numericUpDown1.TabIndex = 32;
            // 
            // numericUpDown2
            // 
            numericUpDown2.BackColor = Color.FromArgb(192, 255, 255);
            numericUpDown2.ForeColor = Color.FromArgb(0, 64, 64);
            numericUpDown2.Location = new Point(122, 26);
            numericUpDown2.Maximum = new decimal(new int[] { 1569325056, 23283064, 0, 0 });
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(117, 27);
            numericUpDown2.TabIndex = 31;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(246, 78);
            label3.Name = "label3";
            label3.Size = new Size(65, 20);
            label3.TabIndex = 30;
            label3.Text = "تا قیمت :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(248, 31);
            label4.Name = "label4";
            label4.Size = new Size(66, 20);
            label4.TabIndex = 29;
            label4.Text = "از قیمت :";
            // 
            // numericUpDown3
            // 
            numericUpDown3.BackColor = Color.FromArgb(192, 255, 255);
            numericUpDown3.ForeColor = Color.FromArgb(0, 64, 64);
            numericUpDown3.Location = new Point(569, 74);
            numericUpDown3.Maximum = new decimal(new int[] { 1569325056, 23283064, 0, 0 });
            numericUpDown3.Name = "numericUpDown3";
            numericUpDown3.Size = new Size(117, 27);
            numericUpDown3.TabIndex = 33;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(692, 75);
            label5.Name = "label5";
            label5.Size = new Size(120, 20);
            label5.TabIndex = 34;
            label5.Text = "تعداد درخواستی :";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(192, 255, 255);
            textBox1.ForeColor = Color.FromArgb(0, 64, 64);
            textBox1.Location = new Point(569, 27);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(117, 27);
            textBox1.TabIndex = 36;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(693, 30);
            label6.Name = "label6";
            label6.Size = new Size(67, 20);
            label6.TabIndex = 35;
            label6.Text = "نام کاربر :";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.FromArgb(0, 192, 192);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { DraftOrderId, UserId, UserName, ProductId, ProductName, BrandId, BrandName, RequestedCount, Amount, TotalAmount });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.GridColor = Color.FromArgb(0, 64, 64);
            dataGridView1.Location = new Point(3, 23);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1028, 189);
            dataGridView1.TabIndex = 0;
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
            // BrandUpdateBtn
            // 
            BrandUpdateBtn.BackColor = Color.FromArgb(192, 255, 255);
            BrandUpdateBtn.FlatStyle = FlatStyle.Popup;
            BrandUpdateBtn.ForeColor = Color.Blue;
            BrandUpdateBtn.Image = Properties.Resources.icons8_search_60;
            BrandUpdateBtn.ImageAlign = ContentAlignment.TopCenter;
            BrandUpdateBtn.Location = new Point(3, 23);
            BrandUpdateBtn.Name = "BrandUpdateBtn";
            BrandUpdateBtn.Size = new Size(102, 81);
            BrandUpdateBtn.TabIndex = 37;
            BrandUpdateBtn.Text = "تغییر نام برند";
            BrandUpdateBtn.TextAlign = ContentAlignment.BottomCenter;
            BrandUpdateBtn.UseVisualStyleBackColor = false;
            // 
            // DraftOrdersManagerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(1033, 442);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(DarftOrderSearchGB);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "DraftOrdersManagerForm";
            RightToLeft = RightToLeft.Yes;
            Text = "مدیریت سبد خرید";
            DarftOrderSearchGB.ResumeLayout(false);
            DarftOrderSearchGB.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)MaxAmountTxt).EndInit();
            ((System.ComponentModel.ISupportInitialize)MinAmounttxt).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox DarftOrderSearchGB;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button DeleteDraftOrderBtn;
        private Button RefreshFrom;
        private ComboBox BarndIdCombo;
        private Label BrandNameLbl;
        private TextBox txtProductName;
        private Label ProductNameLbl;
        private NumericUpDown numericUpDown1;
        private NumericUpDown numericUpDown2;
        private Label label3;
        private Label label4;
        private NumericUpDown MaxAmountTxt;
        private NumericUpDown MinAmounttxt;
        private Label label2;
        private Label label1;
        private TextBox textBox1;
        private Label label6;
        private Label label5;
        private NumericUpDown numericUpDown3;
        private DataGridView dataGridView1;
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
        private Button BrandUpdateBtn;
    }
}