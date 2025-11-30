namespace StationeryStoreAppLayer.Forms.SendOrderRoadForms.OrderInfoShowerForms
{
    partial class OrderInfoShowerForm
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
            Button GoBackBtn;
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
            groupBox2 = new GroupBox();
            label6 = new Label();
            txtAlley = new TextBox();
            label1 = new Label();
            txtStreet = new TextBox();
            label4 = new Label();
            txtPostalCode = new TextBox();
            label3 = new Label();
            txtHouseNumber = new TextBox();
            label2 = new Label();
            txtCity = new TextBox();
            label5 = new Label();
            DeleteOrderBtn = new Button();
            SendOrderBtn = new Button();
            pictureBox1 = new PictureBox();
            GoBackBtn = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DraftOrdersDG).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // GoBackBtn
            // 
            GoBackBtn.BackColor = Color.FromArgb(255, 224, 192);
            GoBackBtn.FlatStyle = FlatStyle.Popup;
            GoBackBtn.ForeColor = Color.FromArgb(192, 64, 0);
            GoBackBtn.Image = Properties.Resources.icons8_left_2_60;
            GoBackBtn.ImageAlign = ContentAlignment.TopCenter;
            GoBackBtn.Location = new Point(214, 7);
            GoBackBtn.Name = "GoBackBtn";
            GoBackBtn.Size = new Size(186, 85);
            GoBackBtn.TabIndex = 19;
            GoBackBtn.Text = "برو به مرحله قبل";
            GoBackBtn.TextAlign = ContentAlignment.BottomCenter;
            GoBackBtn.UseVisualStyleBackColor = false;
            GoBackBtn.Click += GoBackBtn_Click_1;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(0, 192, 192);
            groupBox1.Controls.Add(DraftOrdersDG);
            groupBox1.ForeColor = Color.Black;
            groupBox1.Location = new Point(1, 96);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(844, 322);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "اقلام سفارش";
            // 
            // DraftOrdersDG
            // 
            DraftOrdersDG.AllowUserToAddRows = false;
            DraftOrdersDG.AllowUserToDeleteRows = false;
            DraftOrdersDG.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DraftOrdersDG.BackgroundColor = Color.FromArgb(0, 192, 192);
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
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            DraftOrdersDG.DefaultCellStyle = dataGridViewCellStyle2;
            DraftOrdersDG.Dock = DockStyle.Fill;
            DraftOrdersDG.GridColor = Color.Teal;
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
            // groupBox2
            // 
            groupBox2.BackColor = Color.FromArgb(0, 192, 192);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(txtAlley);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(txtStreet);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(txtPostalCode);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(txtHouseNumber);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(txtCity);
            groupBox2.ForeColor = Color.White;
            groupBox2.Location = new Point(851, 96);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(252, 322);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "مقصد سفارش";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(175, 157);
            label6.Name = "label6";
            label6.Size = new Size(49, 20);
            label6.TabIndex = 27;
            label6.Text = "کوچه :";
            // 
            // txtAlley
            // 
            txtAlley.Location = new Point(5, 154);
            txtAlley.Name = "txtAlley";
            txtAlley.ReadOnly = true;
            txtAlley.Size = new Size(162, 27);
            txtAlley.TabIndex = 26;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(175, 96);
            label1.Name = "label1";
            label1.Size = new Size(53, 20);
            label1.TabIndex = 23;
            label1.Text = "خیابان :";
            // 
            // txtStreet
            // 
            txtStreet.Location = new Point(5, 93);
            txtStreet.Name = "txtStreet";
            txtStreet.ReadOnly = true;
            txtStreet.Size = new Size(162, 27);
            txtStreet.TabIndex = 22;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(175, 279);
            label4.Name = "label4";
            label4.Size = new Size(72, 20);
            label4.TabIndex = 21;
            label4.Text = "کد پستی :";
            // 
            // txtPostalCode
            // 
            txtPostalCode.Location = new Point(5, 275);
            txtPostalCode.Name = "txtPostalCode";
            txtPostalCode.ReadOnly = true;
            txtPostalCode.Size = new Size(162, 27);
            txtPostalCode.TabIndex = 20;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(175, 220);
            label3.Name = "label3";
            label3.Size = new Size(44, 20);
            label3.TabIndex = 19;
            label3.Text = "پلاک :";
            // 
            // txtHouseNumber
            // 
            txtHouseNumber.Location = new Point(5, 216);
            txtHouseNumber.Name = "txtHouseNumber";
            txtHouseNumber.ReadOnly = true;
            txtHouseNumber.Size = new Size(162, 27);
            txtHouseNumber.TabIndex = 18;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(175, 33);
            label2.Name = "label2";
            label2.Size = new Size(43, 20);
            label2.TabIndex = 17;
            label2.Text = "شهر :";
            // 
            // txtCity
            // 
            txtCity.Location = new Point(5, 30);
            txtCity.Name = "txtCity";
            txtCity.ReadOnly = true;
            txtCity.Size = new Size(162, 27);
            txtCity.TabIndex = 16;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Teal;
            label5.Location = new Point(659, 13);
            label5.Name = "label5";
            label5.Size = new Size(434, 68);
            label5.TabIndex = 3;
            label5.Text = "تایید جزئیات سفارش";
            // 
            // DeleteOrderBtn
            // 
            DeleteOrderBtn.BackColor = Color.FromArgb(255, 192, 192);
            DeleteOrderBtn.FlatStyle = FlatStyle.Popup;
            DeleteOrderBtn.ForeColor = Color.Maroon;
            DeleteOrderBtn.Image = Properties.Resources.icons8_cancel_order_55;
            DeleteOrderBtn.ImageAlign = ContentAlignment.TopCenter;
            DeleteOrderBtn.Location = new Point(4, 7);
            DeleteOrderBtn.Name = "DeleteOrderBtn";
            DeleteOrderBtn.Size = new Size(190, 85);
            DeleteOrderBtn.TabIndex = 17;
            DeleteOrderBtn.Text = "کنسل کردن سفارش ";
            DeleteOrderBtn.TextAlign = ContentAlignment.BottomCenter;
            DeleteOrderBtn.UseVisualStyleBackColor = false;
            DeleteOrderBtn.Click += DeleteOrderBtn_Click;
            // 
            // SendOrderBtn
            // 
            SendOrderBtn.BackColor = Color.FromArgb(192, 255, 192);
            SendOrderBtn.FlatStyle = FlatStyle.Popup;
            SendOrderBtn.ForeColor = Color.DarkGreen;
            SendOrderBtn.Image = Properties.Resources.icons8_pay_70__1_;
            SendOrderBtn.ImageAlign = ContentAlignment.TopCenter;
            SendOrderBtn.Location = new Point(420, 7);
            SendOrderBtn.Name = "SendOrderBtn";
            SendOrderBtn.Size = new Size(188, 85);
            SendOrderBtn.TabIndex = 18;
            SendOrderBtn.Text = "تایید و پرداخت";
            SendOrderBtn.TextAlign = ContentAlignment.BottomCenter;
            SendOrderBtn.UseVisualStyleBackColor = false;
            SendOrderBtn.Click += SendOrderBtn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.ChatGPT_Image_Nov_27__2025__03_36_18_AM_removebg_preview;
            pictureBox1.Location = new Point(251, 421);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(616, 147);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            // 
            // OrderInfoShowerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 255, 255);
            ClientSize = new Size(1116, 569);
            Controls.Add(pictureBox1);
            Controls.Add(GoBackBtn);
            Controls.Add(SendOrderBtn);
            Controls.Add(DeleteOrderBtn);
            Controls.Add(label5);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "OrderInfoShowerForm";
            RightToLeft = RightToLeft.Yes;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "تایید سفارش";
            Load += OrderInfoShowerForm_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DraftOrdersDG).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private GroupBox groupBox2;
        private Label label6;
        private TextBox txtAlley;
        private TextBox textBox3;
        private TextBox textBox2;
        private Label label1;
        private TextBox txtStreet;
        private Label label4;
        private TextBox txtPostalCode;
        private Label label3;
        private TextBox txtHouseNumber;
        private Label label2;
        private TextBox txtCity;
        private Label label5;
        private Button DeleteOrderBtn;
        private Button SendOrderBtn;
        private PictureBox pictureBox1;
    }
}