namespace StationeryStoreUILayer
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            ProductGB = new GroupBox();
            DgOrders = new DataGridView();
            OrderId = new DataGridViewTextBoxColumn();
            OrderUserId = new DataGridViewTextBoxColumn();
            OrderUserName = new DataGridViewTextBoxColumn();
            OrderAmount = new DataGridViewTextBoxColumn();
            OrderDate = new DataGridViewTextBoxColumn();
            IsDelivered = new DataGridViewTextBoxColumn();
            OrderInfo = new DataGridViewTextBoxColumn();
            ProductsSearchBox = new GroupBox();
            txtMaxDate = new NumericUpDown();
            txtMaxAmount = new NumericUpDown();
            label1 = new Label();
            label6 = new Label();
            txtMinDate = new NumericUpDown();
            label2 = new Label();
            txtUserId = new NumericUpDown();
            label3 = new Label();
            txtMinAmount = new NumericUpDown();
            BrandNameLbl = new Label();
            btnProductsSearch = new Button();
            txtUserName = new TextBox();
            ProductNameLbl = new Label();
            ProductGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgOrders).BeginInit();
            ProductsSearchBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtMaxDate).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtMaxAmount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtMinDate).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtUserId).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtMinAmount).BeginInit();
            SuspendLayout();
            // 
            // ProductGB
            // 
            ProductGB.Controls.Add(DgOrders);
            ProductGB.Controls.Add(ProductsSearchBox);
            ProductGB.Location = new Point(31, 14);
            ProductGB.Name = "ProductGB";
            ProductGB.Size = new Size(869, 587);
            ProductGB.TabIndex = 6;
            ProductGB.TabStop = false;
            ProductGB.Text = "محصولات";
            ProductGB.Enter += ProductGB_Enter_1;
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
            DgOrders.Location = new Point(3, 200);
            DgOrders.Name = "DgOrders";
            DgOrders.ReadOnly = true;
            DgOrders.RowHeadersWidth = 51;
            DgOrders.Size = new Size(863, 384);
            DgOrders.TabIndex = 2;
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
            // ProductsSearchBox
            // 
            ProductsSearchBox.Controls.Add(txtMaxDate);
            ProductsSearchBox.Controls.Add(txtMaxAmount);
            ProductsSearchBox.Controls.Add(label1);
            ProductsSearchBox.Controls.Add(label6);
            ProductsSearchBox.Controls.Add(txtMinDate);
            ProductsSearchBox.Controls.Add(label2);
            ProductsSearchBox.Controls.Add(txtUserId);
            ProductsSearchBox.Controls.Add(label3);
            ProductsSearchBox.Controls.Add(txtMinAmount);
            ProductsSearchBox.Controls.Add(BrandNameLbl);
            ProductsSearchBox.Controls.Add(btnProductsSearch);
            ProductsSearchBox.Controls.Add(txtUserName);
            ProductsSearchBox.Controls.Add(ProductNameLbl);
            ProductsSearchBox.Dock = DockStyle.Top;
            ProductsSearchBox.Location = new Point(3, 23);
            ProductsSearchBox.Name = "ProductsSearchBox";
            ProductsSearchBox.Size = new Size(863, 177);
            ProductsSearchBox.TabIndex = 1;
            ProductsSearchBox.TabStop = false;
            ProductsSearchBox.Text = "جستوجو در محصولات ";
            // 
            // txtMaxDate
            // 
            txtMaxDate.Location = new Point(409, 85);
            txtMaxDate.Maximum = new decimal(new int[] { 1410065407, 2, 0, 0 });
            txtMaxDate.Name = "txtMaxDate";
            txtMaxDate.Size = new Size(117, 27);
            txtMaxDate.TabIndex = 31;
            // 
            // txtMaxAmount
            // 
            txtMaxAmount.Location = new Point(622, 85);
            txtMaxAmount.Maximum = new decimal(new int[] { 1410065407, 2, 0, 0 });
            txtMaxAmount.Name = "txtMaxAmount";
            txtMaxAmount.Size = new Size(117, 27);
            txtMaxAmount.TabIndex = 27;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(532, 87);
            label1.Name = "label1";
            label1.Size = new Size(59, 20);
            label1.TabIndex = 30;
            label1.Text = "تا تاریخ :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(745, 87);
            label6.Name = "label6";
            label6.Size = new Size(65, 20);
            label6.TabIndex = 26;
            label6.Text = "تا قیمت :";
            // 
            // txtMinDate
            // 
            txtMinDate.Location = new Point(407, 37);
            txtMinDate.Maximum = new decimal(new int[] { 1569325056, 23283064, 0, 0 });
            txtMinDate.Name = "txtMinDate";
            txtMinDate.Size = new Size(117, 27);
            txtMinDate.TabIndex = 29;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(531, 37);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 28;
            label2.Text = "از تاریخ : ";
            // 
            // txtUserId
            // 
            txtUserId.Location = new Point(181, 35);
            txtUserId.Maximum = new decimal(new int[] { 1569325056, 23283064, 0, 0 });
            txtUserId.Name = "txtUserId";
            txtUserId.Size = new Size(117, 27);
            txtUserId.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(310, 39);
            label3.Name = "label3";
            label3.Size = new Size(80, 20);
            label3.TabIndex = 16;
            label3.Text = "ای دی کاربر";
            // 
            // txtMinAmount
            // 
            txtMinAmount.Location = new Point(620, 37);
            txtMinAmount.Maximum = new decimal(new int[] { 1569325056, 23283064, 0, 0 });
            txtMinAmount.Name = "txtMinAmount";
            txtMinAmount.Size = new Size(117, 27);
            txtMinAmount.TabIndex = 15;
            // 
            // BrandNameLbl
            // 
            BrandNameLbl.AutoSize = true;
            BrandNameLbl.Location = new Point(744, 37);
            BrandNameLbl.Name = "BrandNameLbl";
            BrandNameLbl.Size = new Size(70, 20);
            BrandNameLbl.TabIndex = 5;
            BrandNameLbl.Text = "از قیمت : ";
            // 
            // btnProductsSearch
            // 
            btnProductsSearch.Location = new Point(6, 30);
            btnProductsSearch.Name = "btnProductsSearch";
            btnProductsSearch.Size = new Size(131, 29);
            btnProductsSearch.TabIndex = 4;
            btnProductsSearch.Text = "جستوجو";
            btnProductsSearch.UseVisualStyleBackColor = true;
            btnProductsSearch.Click += btnProductsSearch_Click;
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(183, 80);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(117, 27);
            txtUserName.TabIndex = 1;
            // 
            // ProductNameLbl
            // 
            ProductNameLbl.AutoSize = true;
            ProductNameLbl.Location = new Point(310, 83);
            ProductNameLbl.Name = "ProductNameLbl";
            ProductNameLbl.Size = new Size(67, 20);
            ProductNameLbl.TabIndex = 0;
            ProductNameLbl.Text = "نام کاربر :";
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
            ((System.ComponentModel.ISupportInitialize)DgOrders).EndInit();
            ProductsSearchBox.ResumeLayout(false);
            ProductsSearchBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtMaxDate).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtMaxAmount).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtMinDate).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtUserId).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtMinAmount).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox ProductGB;
        private GroupBox ProductsSearchBox;
        private Button btnProductsSearch;
        private NumericUpDown txtUserId;
        private Label label3;
        private NumericUpDown txtMaxDate;
        private NumericUpDown txtMaxAmount;
        private Label label1;
        private Label label6;
        private NumericUpDown txtMinDate;
        private Label label2;
        private NumericUpDown txtMinAmount;
        private Label BrandNameLbl;
        private TextBox txtUserName;
        private Label ProductNameLbl;
        private DataGridView DgOrders;
        private DataGridViewTextBoxColumn OrderId;
        private DataGridViewTextBoxColumn OrderUserId;
        private DataGridViewTextBoxColumn OrderUserName;
        private DataGridViewTextBoxColumn OrderAmount;
        private DataGridViewTextBoxColumn OrderDate;
        private DataGridViewTextBoxColumn IsDelivered;
        private DataGridViewTextBoxColumn OrderInfo;
    }
}