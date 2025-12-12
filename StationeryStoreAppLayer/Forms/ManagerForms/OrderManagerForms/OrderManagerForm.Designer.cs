namespace StationeryStoreUILayer.Forms.ManagerForms.OrderManagerForms
{
    partial class OrderManagerForm
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
            groupBox1 = new GroupBox();
            DeliveryStateCombo = new ComboBox();
            SearchBtn = new Button();
            label1 = new Label();
            txtMaxAmount = new NumericUpDown();
            label6 = new Label();
            txtMinAmount = new NumericUpDown();
            BrandNameLbl = new Label();
            txtUserName = new TextBox();
            ProductNameLbl = new Label();
            label5 = new Label();
            MaxDatetxt = new MaskedTextBox();
            label4 = new Label();
            MinDatetxt = new MaskedTextBox();
            groupBox2 = new GroupBox();
            DgOrders = new DataGridView();
            OrderId = new DataGridViewTextBoxColumn();
            OrderUserId = new DataGridViewTextBoxColumn();
            OrderUserName = new DataGridViewTextBoxColumn();
            OrderAmount = new DataGridViewTextBoxColumn();
            OrderDate = new DataGridViewTextBoxColumn();
            IsDelivered = new DataGridViewTextBoxColumn();
            OrderInfo = new DataGridViewTextBoxColumn();
            RefreshBtn = new Button();
            DeleteOrderBtn = new Button();
            CancelOrderBtn = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtMaxAmount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtMinAmount).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgOrders).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(DeliveryStateCombo);
            groupBox1.Controls.Add(SearchBtn);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtMaxAmount);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtMinAmount);
            groupBox1.Controls.Add(BrandNameLbl);
            groupBox1.Controls.Add(txtUserName);
            groupBox1.Controls.Add(ProductNameLbl);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(MaxDatetxt);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(MinDatetxt);
            groupBox1.Location = new Point(7, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(774, 114);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "جستوجو";
            // 
            // DeliveryStateCombo
            // 
            DeliveryStateCombo.BackColor = Color.PowderBlue;
            DeliveryStateCombo.ForeColor = Color.FromArgb(0, 64, 64);
            DeliveryStateCombo.FormattingEnabled = true;
            DeliveryStateCombo.Location = new Point(521, 74);
            DeliveryStateCombo.Name = "DeliveryStateCombo";
            DeliveryStateCombo.Size = new Size(104, 28);
            DeliveryStateCombo.TabIndex = 19;
            // 
            // SearchBtn
            // 
            SearchBtn.BackColor = Color.DarkTurquoise;
            SearchBtn.FlatStyle = FlatStyle.Popup;
            SearchBtn.ForeColor = Color.Navy;
            SearchBtn.Image = Properties.Resources.icons8_search_60;
            SearchBtn.Location = new Point(24, 25);
            SearchBtn.Name = "SearchBtn";
            SearchBtn.Size = new Size(89, 76);
            SearchBtn.TabIndex = 34;
            SearchBtn.UseVisualStyleBackColor = false;
            SearchBtn.Click += SearchBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(631, 74);
            label1.Name = "label1";
            label1.Size = new Size(119, 20);
            label1.TabIndex = 32;
            label1.Text = "وضعیت سفارش :";
            // 
            // txtMaxAmount
            // 
            txtMaxAmount.BackColor = Color.PowderBlue;
            txtMaxAmount.ForeColor = Color.FromArgb(0, 64, 64);
            txtMaxAmount.Location = new Point(315, 74);
            txtMaxAmount.Maximum = new decimal(new int[] { 1410065407, 2, 0, 0 });
            txtMaxAmount.Name = "txtMaxAmount";
            txtMaxAmount.Size = new Size(117, 27);
            txtMaxAmount.TabIndex = 31;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(437, 76);
            label6.Name = "label6";
            label6.Size = new Size(65, 20);
            label6.TabIndex = 30;
            label6.Text = "تا قیمت :";
            // 
            // txtMinAmount
            // 
            txtMinAmount.BackColor = Color.PowderBlue;
            txtMinAmount.ForeColor = Color.FromArgb(0, 64, 64);
            txtMinAmount.Location = new Point(313, 26);
            txtMinAmount.Maximum = new decimal(new int[] { 1569325056, 23283064, 0, 0 });
            txtMinAmount.Name = "txtMinAmount";
            txtMinAmount.Size = new Size(117, 27);
            txtMinAmount.TabIndex = 29;
            // 
            // BrandNameLbl
            // 
            BrandNameLbl.AutoSize = true;
            BrandNameLbl.Location = new Point(436, 26);
            BrandNameLbl.Name = "BrandNameLbl";
            BrandNameLbl.Size = new Size(70, 20);
            BrandNameLbl.TabIndex = 28;
            BrandNameLbl.Text = "از قیمت : ";
            // 
            // txtUserName
            // 
            txtUserName.BackColor = Color.PowderBlue;
            txtUserName.ForeColor = Color.FromArgb(0, 64, 64);
            txtUserName.Location = new Point(521, 25);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(104, 27);
            txtUserName.TabIndex = 25;
            // 
            // ProductNameLbl
            // 
            ProductNameLbl.AutoSize = true;
            ProductNameLbl.Location = new Point(631, 28);
            ProductNameLbl.Name = "ProductNameLbl";
            ProductNameLbl.Size = new Size(67, 20);
            ProductNameLbl.TabIndex = 24;
            ProductNameLbl.Text = "نام کاربر :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(247, 30);
            label5.Name = "label5";
            label5.Size = new Size(63, 20);
            label5.TabIndex = 23;
            label5.Text = "تا تاریخ : ";
            // 
            // MaxDatetxt
            // 
            MaxDatetxt.BackColor = Color.PowderBlue;
            MaxDatetxt.ForeColor = Color.FromArgb(0, 64, 64);
            MaxDatetxt.Location = new Point(133, 26);
            MaxDatetxt.Mask = "0000/00/00";
            MaxDatetxt.Name = "MaxDatetxt";
            MaxDatetxt.Size = new Size(112, 27);
            MaxDatetxt.TabIndex = 22;
            MaxDatetxt.ValidatingType = typeof(DateTime);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(249, 78);
            label4.Name = "label4";
            label4.Size = new Size(60, 20);
            label4.TabIndex = 21;
            label4.Text = "از تاریخ :";
            // 
            // MinDatetxt
            // 
            MinDatetxt.BackColor = Color.PowderBlue;
            MinDatetxt.ForeColor = Color.FromArgb(0, 64, 64);
            MinDatetxt.Location = new Point(133, 74);
            MinDatetxt.Mask = "0000/00/00";
            MinDatetxt.Name = "MinDatetxt";
            MinDatetxt.Size = new Size(112, 27);
            MinDatetxt.TabIndex = 20;
            MinDatetxt.ValidatingType = typeof(DateTime);
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(DgOrders);
            groupBox2.Location = new Point(7, 122);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(774, 281);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "سفارشات";
            // 
            // DgOrders
            // 
            DgOrders.AllowUserToAddRows = false;
            DgOrders.AllowUserToDeleteRows = false;
            DgOrders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgOrders.BackgroundColor = Color.LightSeaGreen;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            DgOrders.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            DgOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgOrders.Columns.AddRange(new DataGridViewColumn[] { OrderId, OrderUserId, OrderUserName, OrderAmount, OrderDate, IsDelivered, OrderInfo });
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
            DgOrders.Size = new Size(768, 255);
            DgOrders.TabIndex = 1;
            DgOrders.CellClick += DgOrders_CellClick;
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
            // IsDelivered
            // 
            IsDelivered.HeaderText = "وضعیت سفارش";
            IsDelivered.MinimumWidth = 6;
            IsDelivered.Name = "IsDelivered";
            IsDelivered.ReadOnly = true;
            // 
            // OrderInfo
            // 
            OrderInfo.DataPropertyName = "OrderInfo";
            OrderInfo.HeaderText = "جزِئیات سفارش";
            OrderInfo.MinimumWidth = 6;
            OrderInfo.Name = "OrderInfo";
            OrderInfo.ReadOnly = true;
            // 
            // RefreshBtn
            // 
            RefreshBtn.BackColor = Color.Thistle;
            RefreshBtn.FlatStyle = FlatStyle.Popup;
            RefreshBtn.ForeColor = Color.Indigo;
            RefreshBtn.Image = Properties.Resources.icons8_refresh_60;
            RefreshBtn.ImageAlign = ContentAlignment.TopCenter;
            RefreshBtn.Location = new Point(484, 409);
            RefreshBtn.Name = "RefreshBtn";
            RefreshBtn.Size = new Size(155, 86);
            RefreshBtn.TabIndex = 16;
            RefreshBtn.Text = "رفرش کردن فرم";
            RefreshBtn.TextAlign = ContentAlignment.BottomCenter;
            RefreshBtn.UseVisualStyleBackColor = false;
            RefreshBtn.Click += RefreshBtn_Click;
            // 
            // DeleteOrderBtn
            // 
            DeleteOrderBtn.BackColor = Color.FromArgb(255, 192, 192);
            DeleteOrderBtn.FlatStyle = FlatStyle.Popup;
            DeleteOrderBtn.ForeColor = Color.Maroon;
            DeleteOrderBtn.Image = Properties.Resources.icons8_remove_60;
            DeleteOrderBtn.ImageAlign = ContentAlignment.TopCenter;
            DeleteOrderBtn.Location = new Point(317, 409);
            DeleteOrderBtn.Name = "DeleteOrderBtn";
            DeleteOrderBtn.Size = new Size(161, 86);
            DeleteOrderBtn.TabIndex = 17;
            DeleteOrderBtn.Text = "حذف سفارش از حافظه ";
            DeleteOrderBtn.TextAlign = ContentAlignment.BottomCenter;
            DeleteOrderBtn.UseVisualStyleBackColor = false;
            DeleteOrderBtn.Click += DeleteOrderBtn_Click;
            // 
            // CancelOrderBtn
            // 
            CancelOrderBtn.BackColor = Color.FromArgb(255, 192, 192);
            CancelOrderBtn.FlatStyle = FlatStyle.Popup;
            CancelOrderBtn.ForeColor = Color.Maroon;
            CancelOrderBtn.Image = Properties.Resources.icons8_cancel_60;
            CancelOrderBtn.ImageAlign = ContentAlignment.TopCenter;
            CancelOrderBtn.Location = new Point(150, 409);
            CancelOrderBtn.Name = "CancelOrderBtn";
            CancelOrderBtn.Size = new Size(161, 86);
            CancelOrderBtn.TabIndex = 18;
            CancelOrderBtn.Text = "لغو سفارش";
            CancelOrderBtn.TextAlign = ContentAlignment.BottomCenter;
            CancelOrderBtn.UseVisualStyleBackColor = false;
            CancelOrderBtn.Click += CancelOrderBtn_Click;
            // 
            // OrderManagerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Turquoise;
            ClientSize = new Size(793, 501);
            Controls.Add(CancelOrderBtn);
            Controls.Add(RefreshBtn);
            Controls.Add(DeleteOrderBtn);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "OrderManagerForm";
            RightToLeft = RightToLeft.Yes;
            StartPosition = FormStartPosition.CenterParent;
            Text = "مدیریت سفارش ها";
            Load += OrderManagerForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtMaxAmount).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtMinAmount).EndInit();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DgOrders).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label5;
        private MaskedTextBox MaxDatetxt;
        private Label label4;
        private MaskedTextBox MinDatetxt;
        private TextBox txtUserName;
        private Label ProductNameLbl;
        private Label label1;
        private NumericUpDown txtMaxAmount;
        private Label label6;
        private NumericUpDown txtMinAmount;
        private Label BrandNameLbl;
        private Button SearchBtn;
        private GroupBox groupBox2;
        private DataGridView DgOrders;
        private DataGridViewTextBoxColumn OrderId;
        private DataGridViewTextBoxColumn OrderUserId;
        private DataGridViewTextBoxColumn OrderUserName;
        private DataGridViewTextBoxColumn OrderAmount;
        private DataGridViewTextBoxColumn OrderDate;
        private DataGridViewTextBoxColumn IsDelivered;
        private DataGridViewTextBoxColumn OrderInfo;
        private Button RefreshBtn;
        private Button DeleteOrderBtn;
        private ComboBox DeliveryStateCombo;
        private Button CancelOrderBtn;
    }
}