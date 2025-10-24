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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
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
            NewProductsSearchBox = new GroupBox();
            btnNewProductsSearch = new Button();
            txtNewBrandName = new TextBox();
            NewBrandNameLbl = new Label();
            txtNewProductName = new TextBox();
            NewProductNameLbl = new Label();
            DGNewProducts = new DataGridView();
            NewProductId = new DataGridViewTextBoxColumn();
            NewProductName = new DataGridViewTextBoxColumn();
            NewBrandId = new DataGridViewTextBoxColumn();
            NewBrandName = new DataGridViewTextBoxColumn();
            NewCount = new DataGridViewTextBoxColumn();
            NewAmount = new DataGridViewTextBoxColumn();
            ProductGB = new GroupBox();
            ProductsSearchBox = new GroupBox();
            btnProductsSearch = new Button();
            txtBrandName = new TextBox();
            BrandNameLbl = new Label();
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
            NewProductsSearchBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGNewProducts).BeginInit();
            ProductGB.SuspendLayout();
            ProductsSearchBox.SuspendLayout();
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
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            DgOrders.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            DgOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgOrders.Columns.AddRange(new DataGridViewColumn[] { OrderId, OrderUserId, OrderUserName, OrderAmount, OrderDate, OrderInfo });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            DgOrders.DefaultCellStyle = dataGridViewCellStyle2;
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
            NewProductsGB.Controls.Add(NewProductsSearchBox);
            NewProductsGB.Controls.Add(DGNewProducts);
            NewProductsGB.Location = new Point(3, 491);
            NewProductsGB.Name = "NewProductsGB";
            NewProductsGB.Size = new Size(869, 338);
            NewProductsGB.TabIndex = 4;
            NewProductsGB.TabStop = false;
            NewProductsGB.Text = "محصولات جدید";
            // 
            // NewProductsSearchBox
            // 
            NewProductsSearchBox.Controls.Add(btnNewProductsSearch);
            NewProductsSearchBox.Controls.Add(txtNewBrandName);
            NewProductsSearchBox.Controls.Add(NewBrandNameLbl);
            NewProductsSearchBox.Controls.Add(txtNewProductName);
            NewProductsSearchBox.Controls.Add(NewProductNameLbl);
            NewProductsSearchBox.Location = new Point(6, 26);
            NewProductsSearchBox.Name = "NewProductsSearchBox";
            NewProductsSearchBox.Size = new Size(848, 81);
            NewProductsSearchBox.TabIndex = 1;
            NewProductsSearchBox.TabStop = false;
            NewProductsSearchBox.Text = "جستوجو در محصولات جدید";
            // 
            // btnNewProductsSearch
            // 
            btnNewProductsSearch.Location = new Point(36, 34);
            btnNewProductsSearch.Name = "btnNewProductsSearch";
            btnNewProductsSearch.Size = new Size(131, 29);
            btnNewProductsSearch.TabIndex = 4;
            btnNewProductsSearch.Text = "جستوجو";
            btnNewProductsSearch.UseVisualStyleBackColor = true;
            // 
            // txtNewBrandName
            // 
            txtNewBrandName.Location = new Point(236, 36);
            txtNewBrandName.Name = "txtNewBrandName";
            txtNewBrandName.Size = new Size(178, 27);
            txtNewBrandName.TabIndex = 3;
            // 
            // NewBrandNameLbl
            // 
            NewBrandNameLbl.AutoSize = true;
            NewBrandNameLbl.Location = new Point(420, 39);
            NewBrandNameLbl.Name = "NewBrandNameLbl";
            NewBrandNameLbl.Size = new Size(61, 20);
            NewBrandNameLbl.TabIndex = 2;
            NewBrandNameLbl.Text = "نام برند :";
            // 
            // txtNewProductName
            // 
            txtNewProductName.Location = new Point(559, 36);
            txtNewProductName.Name = "txtNewProductName";
            txtNewProductName.Size = new Size(178, 27);
            txtNewProductName.TabIndex = 1;
            // 
            // NewProductNameLbl
            // 
            NewProductNameLbl.AutoSize = true;
            NewProductNameLbl.Location = new Point(743, 39);
            NewProductNameLbl.Name = "NewProductNameLbl";
            NewProductNameLbl.Size = new Size(89, 20);
            NewProductNameLbl.TabIndex = 0;
            NewProductNameLbl.Text = "نام محصول :";
            // 
            // DGNewProducts
            // 
            DGNewProducts.AllowUserToAddRows = false;
            DGNewProducts.AllowUserToDeleteRows = false;
            DGNewProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            DGNewProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            DGNewProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGNewProducts.Columns.AddRange(new DataGridViewColumn[] { NewProductId, NewProductName, NewBrandId, NewBrandName, NewCount, NewAmount });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            DGNewProducts.DefaultCellStyle = dataGridViewCellStyle4;
            DGNewProducts.Location = new Point(2, 111);
            DGNewProducts.Name = "DGNewProducts";
            DGNewProducts.ReadOnly = true;
            DGNewProducts.RowHeadersWidth = 51;
            DGNewProducts.Size = new Size(863, 221);
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
            ProductGB.Controls.Add(ProductsSearchBox);
            ProductGB.Controls.Add(DGPruducts);
            ProductGB.Location = new Point(5, 843);
            ProductGB.Name = "ProductGB";
            ProductGB.Size = new Size(869, 425);
            ProductGB.TabIndex = 5;
            ProductGB.TabStop = false;
            ProductGB.Text = "محصولات";
            // 
            // ProductsSearchBox
            // 
            ProductsSearchBox.Controls.Add(btnProductsSearch);
            ProductsSearchBox.Controls.Add(txtBrandName);
            ProductsSearchBox.Controls.Add(BrandNameLbl);
            ProductsSearchBox.Controls.Add(txtProductName);
            ProductsSearchBox.Controls.Add(ProductNameLbl);
            ProductsSearchBox.Location = new Point(6, 26);
            ProductsSearchBox.Name = "ProductsSearchBox";
            ProductsSearchBox.Size = new Size(848, 81);
            ProductsSearchBox.TabIndex = 1;
            ProductsSearchBox.TabStop = false;
            ProductsSearchBox.Text = "جستوجو در محصولات ";
            // 
            // btnProductsSearch
            // 
            btnProductsSearch.Location = new Point(36, 34);
            btnProductsSearch.Name = "btnProductsSearch";
            btnProductsSearch.Size = new Size(131, 29);
            btnProductsSearch.TabIndex = 4;
            btnProductsSearch.Text = "جستوجو";
            btnProductsSearch.UseVisualStyleBackColor = true;
            // 
            // txtBrandName
            // 
            txtBrandName.Location = new Point(236, 36);
            txtBrandName.Name = "txtBrandName";
            txtBrandName.Size = new Size(178, 27);
            txtBrandName.TabIndex = 3;
            // 
            // BrandNameLbl
            // 
            BrandNameLbl.AutoSize = true;
            BrandNameLbl.Location = new Point(420, 39);
            BrandNameLbl.Name = "BrandNameLbl";
            BrandNameLbl.Size = new Size(61, 20);
            BrandNameLbl.TabIndex = 2;
            BrandNameLbl.Text = "نام برند :";
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(559, 36);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(178, 27);
            txtProductName.TabIndex = 1;
            // 
            // ProductNameLbl
            // 
            ProductNameLbl.AutoSize = true;
            ProductNameLbl.Location = new Point(743, 39);
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
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = SystemColors.Control;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            DGPruducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            DGPruducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGPruducts.Columns.AddRange(new DataGridViewColumn[] { ProductId, ProductName, BrandId, BrandName, Count, Amount });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            DGPruducts.DefaultCellStyle = dataGridViewCellStyle6;
            DGPruducts.Location = new Point(0, 113);
            DGPruducts.Name = "DGPruducts";
            DGPruducts.ReadOnly = true;
            DGPruducts.RowHeadersWidth = 51;
            DGPruducts.Size = new Size(863, 306);
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
            Footer.Location = new Point(0, 1268);
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
            ClientSize = new Size(905, 855);
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
            NewProductsSearchBox.ResumeLayout(false);
            NewProductsSearchBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DGNewProducts).EndInit();
            ProductGB.ResumeLayout(false);
            ProductsSearchBox.ResumeLayout(false);
            ProductsSearchBox.PerformLayout();
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
        private GroupBox NewProductsSearchBox;
        private TextBox txtNewProductName;
        private Label NewProductNameLbl;
        private TextBox txtNewBrandName;
        private Label NewBrandNameLbl;
        private Button btnNewProductsSearch;
        private GroupBox ProductGB;
        private GroupBox ProductsSearchBox;
        private Button btnProductsSearch;
        private TextBox txtBrandName;
        private Label BrandNameLbl;
        private TextBox txtProductName;
        private Label ProductNameLbl;
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
    }
}
