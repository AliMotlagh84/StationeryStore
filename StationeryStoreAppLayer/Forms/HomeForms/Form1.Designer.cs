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
            HeaderMenu = new ToolStrip();
            AdminLbl = new ToolStripLabel();
            ShoppingCartBtn = new ToolStripButton();
            ProductsManageBtn = new ToolStripButton();
            OrdersGB = new GroupBox();
            DgOrders = new DataGridView();
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
            ProductGB = new GroupBox();
            ProductsSearchBox = new GroupBox();
            btnProductsSearch = new Button();
            txtBrandName = new TextBox();
            BrandNameLbl = new Label();
            txtProductName = new TextBox();
            ProductNameLbl = new Label();
            DGPruducts = new DataGridView();
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
            DgOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgOrders.Dock = DockStyle.Fill;
            DgOrders.Location = new Point(3, 23);
            DgOrders.Name = "DgOrders";
            DgOrders.ReadOnly = true;
            DgOrders.RowHeadersWidth = 51;
            DgOrders.Size = new Size(863, 196);
            DgOrders.TabIndex = 0;
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
            DGNewProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGNewProducts.Location = new Point(0, 113);
            DGNewProducts.Name = "DGNewProducts";
            DGNewProducts.ReadOnly = true;
            DGNewProducts.RowHeadersWidth = 51;
            DGNewProducts.Size = new Size(863, 221);
            DGNewProducts.TabIndex = 0;
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
            DGPruducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGPruducts.Location = new Point(0, 113);
            DGPruducts.Name = "DGPruducts";
            DGPruducts.ReadOnly = true;
            DGPruducts.RowHeadersWidth = 51;
            DGPruducts.Size = new Size(863, 306);
            DGPruducts.TabIndex = 0;
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
    }
}
