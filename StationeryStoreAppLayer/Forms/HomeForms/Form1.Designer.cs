namespace StationeryStoreAppLayer
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            HeaderMenu = new ToolStrip();
            AdminLbl = new ToolStripLabel();
            ShoppingCartBtn = new ToolStripButton();
            ProductsManageBtn = new ToolStripButton();
            OrdersGB = new GroupBox();
            DgOrders = new DataGridView();
            OrderId = new DataGridViewTextBoxColumn();
            OrderUserId = new DataGridViewTextBoxColumn();
            OrderUserName = new DataGridViewTextBoxColumn();
            OrderAmount = new DataGridViewTextBoxColumn();
            OrderDate = new DataGridViewTextBoxColumn();
            OrderInfo = new DataGridViewTextBoxColumn();
            IntroducingLbl = new Label();
            UseLbl = new Label();
            WelcomLbl = new Label();
            WelcomeGB = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            NewProductsGB = new GroupBox();
            NewProductsSearchGB = new GroupBox();
            NewBrandIdCombo = new ComboBox();
            NewMaxAmounttxt = new NumericUpDown();
            NewMinAmounttxt = new NumericUpDown();
            label8 = new Label();
            NewAvailblityCombo = new ComboBox();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            NewProductsSearchBtn = new Button();
            NewProductNametxt = new TextBox();
            label12 = new Label();
            DGNewProducts = new DataGridView();
            NewProductId = new DataGridViewTextBoxColumn();
            NewProductName = new DataGridViewTextBoxColumn();
            NewBrandId = new DataGridViewTextBoxColumn();
            NewBrandName = new DataGridViewTextBoxColumn();
            NewCount = new DataGridViewTextBoxColumn();
            NewAmount = new DataGridViewTextBoxColumn();
            ProductGB = new GroupBox();
            ProductsSearchGB = new GroupBox();
            BarndIdCombo = new ComboBox();
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
            Footer = new ToolStrip();
            DateLbl = new ToolStripLabel();
            DateValueLbl = new ToolStripLabel();
            TimeLbl = new ToolStripLabel();
            TimeValueLbl = new ToolStripLabel();
            timer1 = new System.Windows.Forms.Timer(components);
            HeaderMenu.SuspendLayout();
            OrdersGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgOrders).BeginInit();
            WelcomeGB.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            NewProductsGB.SuspendLayout();
            NewProductsSearchGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NewMaxAmounttxt).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NewMinAmounttxt).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DGNewProducts).BeginInit();
            ProductGB.SuspendLayout();
            ProductsSearchGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MaxAmountTxt).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MinAmounttxt).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DGPruducts).BeginInit();
            Footer.SuspendLayout();
            SuspendLayout();
            // 
            // HeaderMenu
            // 
            HeaderMenu.AutoSize = false;
            HeaderMenu.ImageScalingSize = new Size(20, 20);
            HeaderMenu.Items.AddRange(new ToolStripItem[] { AdminLbl, ShoppingCartBtn, ProductsManageBtn });
            HeaderMenu.Location = new Point(0, 0);
            HeaderMenu.Name = "HeaderMenu";
            HeaderMenu.Size = new Size(884, 64);
            HeaderMenu.TabIndex = 0;
            HeaderMenu.Text = "HeaderMenu";
            // 
            // AdminLbl
            // 
            AdminLbl.Image = Properties.Resources.icons8_user_50;
            AdminLbl.ImageAlign = ContentAlignment.MiddleLeft;
            AdminLbl.ImageScaling = ToolStripItemImageScaling.None;
            AdminLbl.ImageTransparentColor = Color.Magenta;
            AdminLbl.Margin = new Padding(20, 1, 0, 2);
            AdminLbl.Name = "AdminLbl";
            AdminLbl.Padding = new Padding(15, 0, 15, 0);
            AdminLbl.Size = new Size(158, 61);
            AdminLbl.Text = "علی مطلق";
            // 
            // ShoppingCartBtn
            // 
            ShoppingCartBtn.Image = Properties.Resources.icons8_fast_cart_40;
            ShoppingCartBtn.ImageScaling = ToolStripItemImageScaling.None;
            ShoppingCartBtn.ImageTransparentColor = Color.Magenta;
            ShoppingCartBtn.Margin = new Padding(20, 1, 0, 2);
            ShoppingCartBtn.Name = "ShoppingCartBtn";
            ShoppingCartBtn.Size = new Size(72, 61);
            ShoppingCartBtn.Text = "سبد خرید";
            ShoppingCartBtn.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // ProductsManageBtn
            // 
            ProductsManageBtn.Image = Properties.Resources.icons8_stationery_35;
            ProductsManageBtn.ImageScaling = ToolStripItemImageScaling.None;
            ProductsManageBtn.ImageTransparentColor = Color.Magenta;
            ProductsManageBtn.Name = "ProductsManageBtn";
            ProductsManageBtn.Size = new Size(129, 61);
            ProductsManageBtn.Text = "مدیریت محصولات";
            ProductsManageBtn.TextImageRelation = TextImageRelation.ImageAboveText;
            ProductsManageBtn.Click += ProductsManageBtn_Click;
            // 
            // OrdersGB
            // 
            OrdersGB.Controls.Add(DgOrders);
            OrdersGB.Location = new Point(0, 256);
            OrdersGB.Name = "OrdersGB";
            OrdersGB.Size = new Size(869, 222);
            OrdersGB.TabIndex = 3;
            OrdersGB.TabStop = false;
            OrdersGB.Text = "خریدهای شما";
            // 
            // DgOrders
            // 
            DgOrders.AllowUserToAddRows = false;
            DgOrders.AllowUserToDeleteRows = false;
            DgOrders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = SystemColors.Control;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle7.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            DgOrders.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            DgOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgOrders.Columns.AddRange(new DataGridViewColumn[] { OrderId, OrderUserId, OrderUserName, OrderAmount, OrderDate, OrderInfo });
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = SystemColors.Window;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle8.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            DgOrders.DefaultCellStyle = dataGridViewCellStyle8;
            DgOrders.Dock = DockStyle.Fill;
            DgOrders.Location = new Point(3, 23);
            DgOrders.Name = "DgOrders";
            DgOrders.ReadOnly = true;
            DgOrders.RowHeadersWidth = 51;
            DgOrders.Size = new Size(863, 196);
            DgOrders.TabIndex = 0;
            // 
            // OrderId
            // 
            OrderId.DataPropertyName = "OrderId";
            OrderId.HeaderText = "آی دی سفارش";
            OrderId.MinimumWidth = 6;
            OrderId.Name = "OrderId";
            OrderId.ReadOnly = true;
            OrderId.Visible = false;
            // 
            // OrderUserId
            // 
            OrderUserId.DataPropertyName = "UserId";
            OrderUserId.HeaderText = "آی دی کاربر";
            OrderUserId.MinimumWidth = 6;
            OrderUserId.Name = "OrderUserId";
            OrderUserId.ReadOnly = true;
            OrderUserId.Visible = false;
            // 
            // OrderUserName
            // 
            OrderUserName.DataPropertyName = "UserName";
            OrderUserName.HeaderText = "نام سفارش دهنده";
            OrderUserName.MinimumWidth = 6;
            OrderUserName.Name = "OrderUserName";
            OrderUserName.ReadOnly = true;
            // 
            // OrderAmount
            // 
            OrderAmount.DataPropertyName = "Amount";
            OrderAmount.HeaderText = "مبلغ سفارش";
            OrderAmount.MinimumWidth = 6;
            OrderAmount.Name = "OrderAmount";
            OrderAmount.ReadOnly = true;
            // 
            // OrderDate
            // 
            OrderDate.DataPropertyName = "Date";
            OrderDate.HeaderText = "تاریخ سفارش";
            OrderDate.MinimumWidth = 6;
            OrderDate.Name = "OrderDate";
            OrderDate.ReadOnly = true;
            // 
            // OrderInfo
            // 
            OrderInfo.DataPropertyName = "OrderInfo";
            OrderInfo.HeaderText = "جزِئیات سفارش";
            OrderInfo.MinimumWidth = 6;
            OrderInfo.Name = "OrderInfo";
            OrderInfo.ReadOnly = true;
            // 
            // IntroducingLbl
            // 
            IntroducingLbl.AutoEllipsis = true;
            IntroducingLbl.AutoSize = true;
            IntroducingLbl.Location = new Point(795, 48);
            IntroducingLbl.Name = "IntroducingLbl";
            IntroducingLbl.RightToLeft = RightToLeft.Yes;
            IntroducingLbl.Size = new Size(65, 20);
            IntroducingLbl.TabIndex = 0;
            IntroducingLbl.Text = "asasasas";
            // 
            // UseLbl
            // 
            UseLbl.AllowDrop = true;
            UseLbl.AutoEllipsis = true;
            UseLbl.AutoSize = true;
            UseLbl.Location = new Point(795, 96);
            UseLbl.Name = "UseLbl";
            UseLbl.RightToLeft = RightToLeft.Yes;
            UseLbl.Size = new Size(65, 20);
            UseLbl.TabIndex = 1;
            UseLbl.Text = "asasasas";
            // 
            // WelcomLbl
            // 
            WelcomLbl.AutoSize = true;
            WelcomLbl.Location = new Point(818, 0);
            WelcomLbl.Name = "WelcomLbl";
            WelcomLbl.RightToLeft = RightToLeft.No;
            WelcomLbl.Size = new Size(42, 20);
            WelcomLbl.TabIndex = 2;
            WelcomLbl.Text = "hello";
            // 
            // WelcomeGB
            // 
            WelcomeGB.Controls.Add(tableLayoutPanel1);
            WelcomeGB.Location = new Point(0, 67);
            WelcomeGB.Name = "WelcomeGB";
            WelcomeGB.Size = new Size(869, 172);
            WelcomeGB.TabIndex = 2;
            WelcomeGB.TabStop = false;
            WelcomeGB.Text = "خوش آمدید";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(WelcomLbl, 0, 0);
            tableLayoutPanel1.Controls.Add(UseLbl, 0, 2);
            tableLayoutPanel1.Controls.Add(IntroducingLbl, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 23);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 34F));
            tableLayoutPanel1.Size = new Size(863, 146);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // NewProductsGB
            // 
            NewProductsGB.Controls.Add(NewProductsSearchGB);
            NewProductsGB.Controls.Add(DGNewProducts);
            NewProductsGB.Location = new Point(3, 491);
            NewProductsGB.Name = "NewProductsGB";
            NewProductsGB.Size = new Size(869, 402);
            NewProductsGB.TabIndex = 4;
            NewProductsGB.TabStop = false;
            NewProductsGB.Text = "محصولات جدید";
            // 
            // NewProductsSearchGB
            // 
            NewProductsSearchGB.Controls.Add(NewBrandIdCombo);
            NewProductsSearchGB.Controls.Add(NewMaxAmounttxt);
            NewProductsSearchGB.Controls.Add(NewMinAmounttxt);
            NewProductsSearchGB.Controls.Add(label8);
            NewProductsSearchGB.Controls.Add(NewAvailblityCombo);
            NewProductsSearchGB.Controls.Add(label9);
            NewProductsSearchGB.Controls.Add(label10);
            NewProductsSearchGB.Controls.Add(label11);
            NewProductsSearchGB.Controls.Add(NewProductsSearchBtn);
            NewProductsSearchGB.Controls.Add(NewProductNametxt);
            NewProductsSearchGB.Controls.Add(label12);
            NewProductsSearchGB.Dock = DockStyle.Top;
            NewProductsSearchGB.Location = new Point(3, 23);
            NewProductsSearchGB.Name = "NewProductsSearchGB";
            NewProductsSearchGB.Size = new Size(863, 118);
            NewProductsSearchGB.TabIndex = 3;
            NewProductsSearchGB.TabStop = false;
            NewProductsSearchGB.Text = "جستوجو در محصولات در جدید ";
            // 
            // NewBrandIdCombo
            // 
            NewBrandIdCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            NewBrandIdCombo.FormattingEnabled = true;
            NewBrandIdCombo.Location = new Point(620, 83);
            NewBrandIdCombo.Name = "NewBrandIdCombo";
            NewBrandIdCombo.Size = new Size(117, 28);
            NewBrandIdCombo.TabIndex = 21;
            // 
            // NewMaxAmounttxt
            // 
            NewMaxAmounttxt.Location = new Point(399, 84);
            NewMaxAmounttxt.Maximum = new decimal(new int[] { 1569325056, 23283064, 0, 0 });
            NewMaxAmounttxt.Name = "NewMaxAmounttxt";
            NewMaxAmounttxt.Size = new Size(117, 27);
            NewMaxAmounttxt.TabIndex = 14;
            // 
            // NewMinAmounttxt
            // 
            NewMinAmounttxt.Location = new Point(398, 34);
            NewMinAmounttxt.Maximum = new decimal(new int[] { 1569325056, 23283064, 0, 0 });
            NewMinAmounttxt.Name = "NewMinAmounttxt";
            NewMinAmounttxt.Size = new Size(117, 27);
            NewMinAmounttxt.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(308, 61);
            label8.Name = "label8";
            label8.Size = new Size(81, 20);
            label8.TabIndex = 12;
            label8.Text = " موجودیت :";
            // 
            // NewAvailblityCombo
            // 
            NewAvailblityCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            NewAvailblityCombo.FormattingEnabled = true;
            NewAvailblityCombo.Location = new Point(189, 57);
            NewAvailblityCombo.Name = "NewAvailblityCombo";
            NewAvailblityCombo.Size = new Size(112, 28);
            NewAvailblityCombo.TabIndex = 11;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(522, 84);
            label9.Name = "label9";
            label9.Size = new Size(65, 20);
            label9.TabIndex = 9;
            label9.Text = "تا قیمت :";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(524, 39);
            label10.Name = "label10";
            label10.Size = new Size(66, 20);
            label10.TabIndex = 7;
            label10.Text = "از قیمت :";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(744, 84);
            label11.Name = "label11";
            label11.Size = new Size(61, 20);
            label11.TabIndex = 5;
            label11.Text = "نام برند :";
            // 
            // NewProductsSearchBtn
            // 
            NewProductsSearchBtn.Location = new Point(6, 56);
            NewProductsSearchBtn.Name = "NewProductsSearchBtn";
            NewProductsSearchBtn.Size = new Size(131, 29);
            NewProductsSearchBtn.TabIndex = 4;
            NewProductsSearchBtn.Text = "جستوجو";
            NewProductsSearchBtn.UseVisualStyleBackColor = true;
            NewProductsSearchBtn.Click += NewProductsSearchBtn_Click;
            // 
            // NewProductNametxt
            // 
            NewProductNametxt.Location = new Point(620, 36);
            NewProductNametxt.Name = "NewProductNametxt";
            NewProductNametxt.Size = new Size(117, 27);
            NewProductNametxt.TabIndex = 1;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(745, 39);
            label12.Name = "label12";
            label12.Size = new Size(89, 20);
            label12.TabIndex = 0;
            label12.Text = "نام محصول :";
            // 
            // DGNewProducts
            // 
            DGNewProducts.AllowUserToAddRows = false;
            DGNewProducts.AllowUserToDeleteRows = false;
            DGNewProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = SystemColors.Control;
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle9.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            DGNewProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            DGNewProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGNewProducts.Columns.AddRange(new DataGridViewColumn[] { NewProductId, NewProductName, NewBrandId, NewBrandName, NewCount, NewAmount });
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = SystemColors.Window;
            dataGridViewCellStyle10.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle10.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.False;
            DGNewProducts.DefaultCellStyle = dataGridViewCellStyle10;
            DGNewProducts.Location = new Point(3, 148);
            DGNewProducts.Name = "DGNewProducts";
            DGNewProducts.ReadOnly = true;
            DGNewProducts.RowHeadersWidth = 51;
            DGNewProducts.Size = new Size(863, 248);
            DGNewProducts.TabIndex = 0;
            // 
            // NewProductId
            // 
            NewProductId.DataPropertyName = "ProductId";
            NewProductId.HeaderText = "آی دی محصول";
            NewProductId.MinimumWidth = 6;
            NewProductId.Name = "NewProductId";
            NewProductId.ReadOnly = true;
            NewProductId.Visible = false;
            // 
            // NewProductName
            // 
            NewProductName.DataPropertyName = "ProductName";
            NewProductName.HeaderText = "نام محصول";
            NewProductName.MinimumWidth = 6;
            NewProductName.Name = "NewProductName";
            NewProductName.ReadOnly = true;
            // 
            // NewBrandId
            // 
            NewBrandId.DataPropertyName = "BrandId";
            NewBrandId.HeaderText = "آی دی برند";
            NewBrandId.MinimumWidth = 6;
            NewBrandId.Name = "NewBrandId";
            NewBrandId.ReadOnly = true;
            NewBrandId.Visible = false;
            // 
            // NewBrandName
            // 
            NewBrandName.DataPropertyName = "BrandName";
            NewBrandName.HeaderText = "نام برند";
            NewBrandName.MinimumWidth = 6;
            NewBrandName.Name = "NewBrandName";
            NewBrandName.ReadOnly = true;
            // 
            // NewCount
            // 
            NewCount.DataPropertyName = "Count";
            NewCount.HeaderText = "تعداد";
            NewCount.MinimumWidth = 6;
            NewCount.Name = "NewCount";
            NewCount.ReadOnly = true;
            // 
            // NewAmount
            // 
            NewAmount.DataPropertyName = "Amount";
            NewAmount.HeaderText = "قیمت";
            NewAmount.MinimumWidth = 6;
            NewAmount.Name = "NewAmount";
            NewAmount.ReadOnly = true;
            // 
            // ProductGB
            // 
            ProductGB.Controls.Add(ProductsSearchGB);
            ProductGB.Controls.Add(DGPruducts);
            ProductGB.Location = new Point(5, 899);
            ProductGB.Name = "ProductGB";
            ProductGB.Size = new Size(869, 394);
            ProductGB.TabIndex = 5;
            ProductGB.TabStop = false;
            ProductGB.Text = "محصولات";
            // 
            // ProductsSearchGB
            // 
            ProductsSearchGB.Controls.Add(BarndIdCombo);
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
            ProductsSearchGB.Location = new Point(3, 23);
            ProductsSearchGB.Name = "ProductsSearchGB";
            ProductsSearchGB.Size = new Size(863, 118);
            ProductsSearchGB.TabIndex = 2;
            ProductsSearchGB.TabStop = false;
            ProductsSearchGB.Text = "جستوجو در محصولات ";
            // 
            // BarndIdCombo
            // 
            BarndIdCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            BarndIdCombo.FormattingEnabled = true;
            BarndIdCombo.Location = new Point(621, 84);
            BarndIdCombo.Name = "BarndIdCombo";
            BarndIdCombo.Size = new Size(117, 28);
            BarndIdCombo.TabIndex = 20;
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
            MinDatetxt.Location = new Point(189, 81);
            MinDatetxt.Mask = "0000/00/00";
            MinDatetxt.Name = "MinDatetxt";
            MinDatetxt.Size = new Size(112, 27);
            MinDatetxt.TabIndex = 16;
            MinDatetxt.ValidatingType = typeof(DateTime);
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
            ProductsSearchBtn.Location = new Point(6, 34);
            ProductsSearchBtn.Name = "ProductsSearchBtn";
            ProductsSearchBtn.Size = new Size(131, 29);
            ProductsSearchBtn.TabIndex = 4;
            ProductsSearchBtn.Text = "جستوجو";
            ProductsSearchBtn.UseVisualStyleBackColor = true;
            ProductsSearchBtn.Click += ProductsSearchBtn_Click;
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
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = SystemColors.Control;
            dataGridViewCellStyle11.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle11.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.True;
            DGPruducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            DGPruducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGPruducts.Columns.AddRange(new DataGridViewColumn[] { ProductId, ProductName, BrandId, BrandName, Count, Amount });
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = SystemColors.Window;
            dataGridViewCellStyle12.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle12.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = DataGridViewTriState.False;
            DGPruducts.DefaultCellStyle = dataGridViewCellStyle12;
            DGPruducts.Location = new Point(0, 147);
            DGPruducts.Name = "DGPruducts";
            DGPruducts.ReadOnly = true;
            DGPruducts.RowHeadersWidth = 51;
            DGPruducts.Size = new Size(863, 297);
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
            // Footer
            // 
            Footer.Dock = DockStyle.Bottom;
            Footer.ImageScalingSize = new Size(20, 20);
            Footer.Items.AddRange(new ToolStripItem[] { DateLbl, DateValueLbl, TimeLbl, TimeValueLbl });
            Footer.Location = new Point(0, 1293);
            Footer.Name = "Footer";
            Footer.Size = new Size(884, 25);
            Footer.TabIndex = 6;
            Footer.Text = "toolStrip1";
            // 
            // DateLbl
            // 
            DateLbl.Name = "DateLbl";
            DateLbl.Size = new Size(50, 22);
            DateLbl.Text = "تاریخ : ";
            // 
            // DateValueLbl
            // 
            DateValueLbl.Name = "DateValueLbl";
            DateValueLbl.Size = new Size(0, 22);
            // 
            // TimeLbl
            // 
            TimeLbl.Name = "TimeLbl";
            TimeLbl.Size = new Size(88, 22);
            TimeLbl.Text = "       ساعت : ";
            // 
            // TimeValueLbl
            // 
            TimeValueLbl.Name = "TimeValueLbl";
            TimeValueLbl.Size = new Size(111, 22);
            TimeValueLbl.Text = "toolStripLabel1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(905, 897);
            Controls.Add(Footer);
            Controls.Add(ProductGB);
            Controls.Add(NewProductsGB);
            Controls.Add(OrdersGB);
            Controls.Add(WelcomeGB);
            Controls.Add(HeaderMenu);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form1";
            RightToLeft = RightToLeft.Yes;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "فروشگاه نوشت افزار";
            Load += Form1_Load;
            HeaderMenu.ResumeLayout(false);
            HeaderMenu.PerformLayout();
            OrdersGB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DgOrders).EndInit();
            WelcomeGB.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            NewProductsGB.ResumeLayout(false);
            NewProductsSearchGB.ResumeLayout(false);
            NewProductsSearchGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NewMaxAmounttxt).EndInit();
            ((System.ComponentModel.ISupportInitialize)NewMinAmounttxt).EndInit();
            ((System.ComponentModel.ISupportInitialize)DGNewProducts).EndInit();
            ProductGB.ResumeLayout(false);
            ProductsSearchGB.ResumeLayout(false);
            ProductsSearchGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)MaxAmountTxt).EndInit();
            ((System.ComponentModel.ISupportInitialize)MinAmounttxt).EndInit();
            ((System.ComponentModel.ISupportInitialize)DGPruducts).EndInit();
            Footer.ResumeLayout(false);
            Footer.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip HeaderMenu;
        private ToolStripButton ProductsManageBtn;
        private GroupBox OrdersGB;
        private DataGridView DgOrders;
        private Label IntroducingLbl;
        private Label UseLbl;
        private Label WelcomLbl;
        private GroupBox WelcomeGB;
        private GroupBox NewProductsGB;
        private DataGridView DGNewProducts;
        private GroupBox ProductGB;
        private DataGridView DGPruducts;
        private ToolStrip Footer;
        private ToolStripLabel DateLbl;
        private ToolStripLabel DateValueLbl;
        private ToolStripLabel TimeLbl;
        private ToolStripLabel TimeValueLbl;
        private System.Windows.Forms.Timer timer1;
        public ToolStripButton ShoppingCartBtn;
        private ToolStripLabel AdminLbl;
        private TableLayoutPanel tableLayoutPanel1;
        private DataGridViewTextBoxColumn NewProductId;
        private DataGridViewTextBoxColumn NewProductName;
        private DataGridViewTextBoxColumn NewBrandId;
        private DataGridViewTextBoxColumn NewBrandName;
        private DataGridViewTextBoxColumn NewCount;
        private DataGridViewTextBoxColumn NewAmount;
        private DataGridViewTextBoxColumn ProductId;
        private DataGridViewTextBoxColumn ProductName;
        private DataGridViewTextBoxColumn BrandId;
        private DataGridViewTextBoxColumn BrandName;
        private DataGridViewTextBoxColumn Count;
        private DataGridViewTextBoxColumn Amount;
        private DataGridViewTextBoxColumn OrderId;
        private DataGridViewTextBoxColumn OrderUserId;
        private DataGridViewTextBoxColumn OrderUserName;
        private DataGridViewTextBoxColumn OrderAmount;
        private DataGridViewTextBoxColumn OrderDate;
        private DataGridViewTextBoxColumn OrderInfo;
        private GroupBox ProductsSearchGB;
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
        private GroupBox NewProductsSearchGB;
        private NumericUpDown NewMaxAmounttxt;
        private NumericUpDown NewMinAmounttxt;
        private Label label8;
        private ComboBox NewAvailblityCombo;
        private Label label9;
        private Label label10;
        private Label label11;
        private Button NewProductsSearchBtn;
        private TextBox NewProductNametxt;
        private Label label12;
        private ComboBox NewBrandIdCombo;
        private ComboBox BarndIdCombo;
    }
}
