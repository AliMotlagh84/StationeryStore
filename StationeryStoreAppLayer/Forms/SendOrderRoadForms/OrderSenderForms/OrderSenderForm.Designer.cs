namespace StationeryStoreUILayer.Forms.SendOrderRoadForms.OrderSenderForms
{
    partial class OrderSenderForm
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
            label1 = new Label();
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
            GoHomeFormBtn = new Button();
            groupBox2 = new GroupBox();
            OrderNameLbl = new Label();
            label2 = new Label();
            label3 = new Label();
            OrderDateLbl = new Label();
            label4 = new Label();
            label5 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DraftOrdersDG).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(121, 6);
            label1.Name = "label1";
            label1.Size = new Size(500, 51);
            label1.TabIndex = 0;
            label1.Text = "سفارش شما با موفقیت ثبت گردید";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(128, 255, 128);
            groupBox1.Controls.Add(DraftOrdersDG);
            groupBox1.ForeColor = Color.Black;
            groupBox1.Location = new Point(13, 153);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(724, 250);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "اقلام سفارش شما ";
            // 
            // DraftOrdersDG
            // 
            DraftOrdersDG.AllowUserToAddRows = false;
            DraftOrdersDG.AllowUserToDeleteRows = false;
            DraftOrdersDG.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DraftOrdersDG.BackgroundColor = Color.FromArgb(0, 192, 0);
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            DraftOrdersDG.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            DraftOrdersDG.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DraftOrdersDG.Columns.AddRange(new DataGridViewColumn[] { DraftOrderId, UserId, UserName, ProductId, ProductName, BrandId, BrandName, RequestedCount, Amount, TotalAmount });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            DraftOrdersDG.DefaultCellStyle = dataGridViewCellStyle4;
            DraftOrdersDG.Dock = DockStyle.Fill;
            DraftOrdersDG.GridColor = Color.Teal;
            DraftOrdersDG.Location = new Point(3, 23);
            DraftOrdersDG.Name = "DraftOrdersDG";
            DraftOrdersDG.ReadOnly = true;
            DraftOrdersDG.RowHeadersWidth = 51;
            DraftOrdersDG.Size = new Size(718, 224);
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
            // GoHomeFormBtn
            // 
            GoHomeFormBtn.BackColor = Color.FromArgb(192, 255, 192);
            GoHomeFormBtn.FlatStyle = FlatStyle.Popup;
            GoHomeFormBtn.ForeColor = Color.DarkGreen;
            GoHomeFormBtn.Image = Properties.Resources.icons8_home_60;
            GoHomeFormBtn.ImageAlign = ContentAlignment.TopCenter;
            GoHomeFormBtn.Location = new Point(261, 406);
            GoHomeFormBtn.Name = "GoHomeFormBtn";
            GoHomeFormBtn.Size = new Size(188, 85);
            GoHomeFormBtn.TabIndex = 19;
            GoHomeFormBtn.Text = "برگشت به فرم اصلی";
            GoHomeFormBtn.TextAlign = ContentAlignment.BottomCenter;
            GoHomeFormBtn.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(OrderDateLbl);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(OrderNameLbl);
            groupBox2.Controls.Add(label2);
            groupBox2.Location = new Point(12, 60);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(722, 87);
            groupBox2.TabIndex = 20;
            groupBox2.TabStop = false;
            groupBox2.Text = "اطلاعات سفارش";
            // 
            // OrderNameLbl
            // 
            OrderNameLbl.AutoSize = true;
            OrderNameLbl.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            OrderNameLbl.ForeColor = Color.FromArgb(0, 192, 0);
            OrderNameLbl.Location = new Point(465, 32);
            OrderNameLbl.Name = "OrderNameLbl";
            OrderNameLbl.RightToLeft = RightToLeft.Yes;
            OrderNameLbl.Size = new Size(112, 25);
            OrderNameLbl.TabIndex = 23;
            OrderNameLbl.Text = "0000000000";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(0, 64, 0);
            label2.Location = new Point(576, 33);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.Yes;
            label2.Size = new Size(129, 20);
            label2.TabIndex = 24;
            label2.Text = "نام سفارش دهنده :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.FromArgb(0, 64, 0);
            label3.Location = new Point(365, 34);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.Yes;
            label3.Size = new Size(102, 20);
            label3.TabIndex = 25;
            label3.Text = "تاریخ سفارش : ";
            // 
            // OrderDateLbl
            // 
            OrderDateLbl.AutoSize = true;
            OrderDateLbl.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            OrderDateLbl.ForeColor = Color.FromArgb(0, 192, 0);
            OrderDateLbl.Location = new Point(257, 33);
            OrderDateLbl.Name = "OrderDateLbl";
            OrderDateLbl.RightToLeft = RightToLeft.Yes;
            OrderDateLbl.Size = new Size(112, 25);
            OrderDateLbl.TabIndex = 26;
            OrderDateLbl.Text = "0000000000";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(0, 192, 0);
            label4.Location = new Point(2, 34);
            label4.Name = "label4";
            label4.RightToLeft = RightToLeft.Yes;
            label4.Size = new Size(112, 25);
            label4.TabIndex = 28;
            label4.Text = "0000000000";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.FromArgb(0, 64, 0);
            label5.Location = new Point(114, 35);
            label5.Name = "label5";
            label5.RightToLeft = RightToLeft.Yes;
            label5.Size = new Size(143, 20);
            label5.TabIndex = 27;
            label5.Text = "تاریخ رسیدن سفارش :";
            // 
            // OrderSenderForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 255, 128);
            ClientSize = new Size(749, 498);
            Controls.Add(groupBox2);
            Controls.Add(GoHomeFormBtn);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            ForeColor = Color.Green;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "OrderSenderForm";
            RightToLeft = RightToLeft.Yes;
            StartPosition = FormStartPosition.CenterParent;
            Text = "جزئیات سفارش";
            Load += OrderSenderForm_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DraftOrdersDG).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
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
        private Button GoHomeFormBtn;
        private GroupBox groupBox2;
        private Label OrderDateLbl;
        private Label label3;
        private Label OrderNameLbl;
        private Label label2;
        private Label label4;
        private Label label5;
    }
}