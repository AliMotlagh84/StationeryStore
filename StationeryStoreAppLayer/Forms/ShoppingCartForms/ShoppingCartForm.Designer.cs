namespace StationeryStoreAppLayer.Forms.ShoppingCartForms
{
    partial class ShoppingCartForm
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
            DeleteDraftOrderBtn = new Button();
            DeleteAllDraftOrdersBtn = new Button();
            EditDraftOrderCountBtn = new Button();
            OrderSenderForm = new Button();
            OrdersFormOpener = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DraftOrdersDG).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(DraftOrdersDG);
            groupBox1.Location = new Point(2, 84);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(844, 322);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "پیش سفارش ها ";
            // 
            // DraftOrdersDG
            // 
            DraftOrdersDG.AllowUserToAddRows = false;
            DraftOrdersDG.AllowUserToDeleteRows = false;
            DraftOrdersDG.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DraftOrdersDG.BackgroundColor = Color.FromArgb(255, 128, 0);
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            DraftOrdersDG.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            DraftOrdersDG.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DraftOrdersDG.Columns.AddRange(new DataGridViewColumn[] { DraftOrderId, UserId, UserName, ProductId, ProductName, BrandId, BrandName, RequestedCount, Amount, TotalAmount });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            DraftOrdersDG.DefaultCellStyle = dataGridViewCellStyle2;
            DraftOrdersDG.Dock = DockStyle.Fill;
            DraftOrdersDG.GridColor = Color.FromArgb(192, 64, 0);
            DraftOrdersDG.Location = new Point(3, 23);
            DraftOrdersDG.Name = "DraftOrdersDG";
            DraftOrdersDG.ReadOnly = true;
            DraftOrdersDG.RowHeadersWidth = 51;
            DraftOrdersDG.Size = new Size(838, 296);
            DraftOrdersDG.TabIndex = 1;
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
            UserName.Visible = false;
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
            // DeleteDraftOrderBtn
            // 
            DeleteDraftOrderBtn.BackColor = Color.FromArgb(255, 192, 192);
            DeleteDraftOrderBtn.FlatStyle = FlatStyle.Popup;
            DeleteDraftOrderBtn.ForeColor = Color.Maroon;
            DeleteDraftOrderBtn.Image = Properties.Resources.icons8_delete_document_60;
            DeleteDraftOrderBtn.ImageAlign = ContentAlignment.TopCenter;
            DeleteDraftOrderBtn.Location = new Point(653, 409);
            DeleteDraftOrderBtn.Name = "DeleteDraftOrderBtn";
            DeleteDraftOrderBtn.Size = new Size(190, 79);
            DeleteDraftOrderBtn.TabIndex = 5;
            DeleteDraftOrderBtn.Text = "حذف پیش سفارش ";
            DeleteDraftOrderBtn.TextAlign = ContentAlignment.BottomCenter;
            DeleteDraftOrderBtn.UseVisualStyleBackColor = false;
            DeleteDraftOrderBtn.Click += DeleteDraftOrderBtn_Click;
            // 
            // DeleteAllDraftOrdersBtn
            // 
            DeleteAllDraftOrdersBtn.BackColor = Color.Silver;
            DeleteAllDraftOrdersBtn.FlatStyle = FlatStyle.Popup;
            DeleteAllDraftOrdersBtn.ForeColor = Color.Black;
            DeleteAllDraftOrdersBtn.Image = Properties.Resources.icons8_delete_document_60;
            DeleteAllDraftOrdersBtn.ImageAlign = ContentAlignment.TopCenter;
            DeleteAllDraftOrdersBtn.Location = new Point(438, 409);
            DeleteAllDraftOrdersBtn.Name = "DeleteAllDraftOrdersBtn";
            DeleteAllDraftOrdersBtn.Size = new Size(189, 79);
            DeleteAllDraftOrdersBtn.TabIndex = 6;
            DeleteAllDraftOrdersBtn.Text = "حذف همه پیش سفارش ";
            DeleteAllDraftOrdersBtn.TextAlign = ContentAlignment.BottomCenter;
            DeleteAllDraftOrdersBtn.UseVisualStyleBackColor = false;
            DeleteAllDraftOrdersBtn.Click += DeleteAllDraftOrdersBtn_Click;
            // 
            // EditDraftOrderCountBtn
            // 
            EditDraftOrderCountBtn.BackColor = Color.Aquamarine;
            EditDraftOrderCountBtn.FlatStyle = FlatStyle.Popup;
            EditDraftOrderCountBtn.ForeColor = Color.FromArgb(0, 0, 192);
            EditDraftOrderCountBtn.Image = Properties.Resources.icons8_add_properties_60;
            EditDraftOrderCountBtn.ImageAlign = ContentAlignment.TopCenter;
            EditDraftOrderCountBtn.Location = new Point(231, 409);
            EditDraftOrderCountBtn.Name = "EditDraftOrderCountBtn";
            EditDraftOrderCountBtn.Size = new Size(182, 79);
            EditDraftOrderCountBtn.TabIndex = 7;
            EditDraftOrderCountBtn.Text = "ویرایش تعداد محصول";
            EditDraftOrderCountBtn.TextAlign = ContentAlignment.BottomCenter;
            EditDraftOrderCountBtn.UseVisualStyleBackColor = false;
            EditDraftOrderCountBtn.Click += EditDraftOrderCountBtn_Click;
            // 
            // OrderSenderForm
            // 
            OrderSenderForm.BackColor = Color.FromArgb(192, 255, 192);
            OrderSenderForm.FlatStyle = FlatStyle.Popup;
            OrderSenderForm.ForeColor = Color.DarkGreen;
            OrderSenderForm.Image = Properties.Resources.icons8_update_product_60;
            OrderSenderForm.ImageAlign = ContentAlignment.TopCenter;
            OrderSenderForm.Location = new Point(676, 4);
            OrderSenderForm.Name = "OrderSenderForm";
            OrderSenderForm.Size = new Size(170, 82);
            OrderSenderForm.TabIndex = 8;
            OrderSenderForm.Text = "ثبت سفارش ";
            OrderSenderForm.TextAlign = ContentAlignment.BottomCenter;
            OrderSenderForm.UseVisualStyleBackColor = false;
            // 
            // OrdersFormOpener
            // 
            OrdersFormOpener.BackColor = Color.FromArgb(192, 255, 192);
            OrdersFormOpener.FlatStyle = FlatStyle.Popup;
            OrdersFormOpener.ForeColor = Color.DarkGreen;
            OrdersFormOpener.Image = Properties.Resources.icons8_update_product_60;
            OrdersFormOpener.ImageAlign = ContentAlignment.TopCenter;
            OrdersFormOpener.Location = new Point(498, 4);
            OrdersFormOpener.Name = "OrdersFormOpener";
            OrdersFormOpener.Size = new Size(160, 82);
            OrdersFormOpener.TabIndex = 9;
            OrdersFormOpener.Text = "مشاهده سفارشات من";
            OrdersFormOpener.TextAlign = ContentAlignment.BottomCenter;
            OrdersFormOpener.UseVisualStyleBackColor = false;
            // 
            // ShoppingCartForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 128);
            ClientSize = new Size(851, 493);
            Controls.Add(OrdersFormOpener);
            Controls.Add(OrderSenderForm);
            Controls.Add(EditDraftOrderCountBtn);
            Controls.Add(DeleteAllDraftOrdersBtn);
            Controls.Add(DeleteDraftOrderBtn);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "ShoppingCartForm";
            RightToLeft = RightToLeft.Yes;
            StartPosition = FormStartPosition.CenterParent;
            Text = "سبد خرید";
            Load += ShoppingCartForm_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DraftOrdersDG).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
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
        private Button DeleteDraftOrderBtn;
        private Button DeleteAllDraftOrdersBtn;
        private Button EditDraftOrderCountBtn;
        private Button OrderSenderForm;
        private Button OrdersFormOpener;
    }
}