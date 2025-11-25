namespace StationeryStoreAppLayer.Forms.AdressChooserForms
{
    partial class AdressChooserForm
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
            AdressDG = new DataGridView();
            AdressId = new DataGridViewTextBoxColumn();
            UserId = new DataGridViewTextBoxColumn();
            UserName = new DataGridViewTextBoxColumn();
            City = new DataGridViewTextBoxColumn();
            Street = new DataGridViewTextBoxColumn();
            Alley = new DataGridViewTextBoxColumn();
            HouseNumber = new DataGridViewTextBoxColumn();
            PostalCode = new DataGridViewTextBoxColumn();
            groupBox2 = new GroupBox();
            SendOrderBtn = new Button();
            txtCity = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtHouseNumber = new TextBox();
            label4 = new Label();
            txtPostalCode = new TextBox();
            label1 = new Label();
            label5 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)AdressDG).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(AdressDG);
            groupBox1.Location = new Point(3, -1);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(648, 286);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "آدرس های شما";
            // 
            // AdressDG
            // 
            AdressDG.AllowUserToAddRows = false;
            AdressDG.AllowUserToDeleteRows = false;
            AdressDG.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            AdressDG.BackgroundColor = Color.SeaGreen;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            AdressDG.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            AdressDG.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AdressDG.Columns.AddRange(new DataGridViewColumn[] { AdressId, UserId, UserName, City, Street, Alley, HouseNumber, PostalCode });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(0, 64, 0);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            AdressDG.DefaultCellStyle = dataGridViewCellStyle2;
            AdressDG.GridColor = Color.FromArgb(64, 0, 64);
            AdressDG.Location = new Point(3, 53);
            AdressDG.Name = "AdressDG";
            AdressDG.ReadOnly = true;
            AdressDG.RowHeadersWidth = 51;
            AdressDG.Size = new Size(642, 226);
            AdressDG.TabIndex = 0;
            // 
            // AdressId
            // 
            AdressId.DataPropertyName = "AdressId";
            AdressId.HeaderText = "آی دی آدرس";
            AdressId.MinimumWidth = 6;
            AdressId.Name = "AdressId";
            AdressId.ReadOnly = true;
            AdressId.Visible = false;
            // 
            // UserId
            // 
            UserId.DataPropertyName = "UserId";
            UserId.HeaderText = "آی دی کاربر";
            UserId.MinimumWidth = 6;
            UserId.Name = "UserId";
            UserId.ReadOnly = true;
            UserId.Visible = false;
            // 
            // UserName
            // 
            UserName.DataPropertyName = "UserName";
            UserName.HeaderText = "نام کاربر";
            UserName.MinimumWidth = 6;
            UserName.Name = "UserName";
            UserName.ReadOnly = true;
            UserName.Visible = false;
            // 
            // City
            // 
            City.DataPropertyName = "City";
            City.HeaderText = "شهر";
            City.MinimumWidth = 6;
            City.Name = "City";
            City.ReadOnly = true;
            // 
            // Street
            // 
            Street.DataPropertyName = "Street";
            Street.HeaderText = "خیابان";
            Street.MinimumWidth = 6;
            Street.Name = "Street";
            Street.ReadOnly = true;
            // 
            // Alley
            // 
            Alley.DataPropertyName = "Alley";
            Alley.HeaderText = "کوچه";
            Alley.MinimumWidth = 6;
            Alley.Name = "Alley";
            Alley.ReadOnly = true;
            // 
            // HouseNumber
            // 
            HouseNumber.DataPropertyName = "HouseNumber";
            HouseNumber.HeaderText = "پلاک";
            HouseNumber.MinimumWidth = 6;
            HouseNumber.Name = "HouseNumber";
            HouseNumber.ReadOnly = true;
            // 
            // PostalCode
            // 
            PostalCode.DataPropertyName = "PostalCode";
            PostalCode.HeaderText = "کد پستی";
            PostalCode.MinimumWidth = 6;
            PostalCode.Name = "PostalCode";
            PostalCode.ReadOnly = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(txtPostalCode);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(txtHouseNumber);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(txtCity);
            groupBox2.Controls.Add(SendOrderBtn);
            groupBox2.Location = new Point(654, -1);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(237, 283);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            // 
            // SendOrderBtn
            // 
            SendOrderBtn.BackColor = Color.FromArgb(192, 255, 192);
            SendOrderBtn.FlatStyle = FlatStyle.Popup;
            SendOrderBtn.ForeColor = Color.DarkGreen;
            SendOrderBtn.Image = Properties.Resources.icons8_send_file_55;
            SendOrderBtn.ImageAlign = ContentAlignment.TopCenter;
            SendOrderBtn.Location = new Point(20, 192);
            SendOrderBtn.Name = "SendOrderBtn";
            SendOrderBtn.Size = new Size(205, 82);
            SendOrderBtn.TabIndex = 9;
            SendOrderBtn.Text = "ادامه ثبت سفارش";
            SendOrderBtn.TextAlign = ContentAlignment.BottomCenter;
            SendOrderBtn.UseVisualStyleBackColor = false;
            // 
            // txtCity
            // 
            txtCity.Location = new Point(20, 65);
            txtCity.Name = "txtCity";
            txtCity.ReadOnly = true;
            txtCity.Size = new Size(125, 27);
            txtCity.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(153, 68);
            label2.Name = "label2";
            label2.Size = new Size(43, 20);
            label2.TabIndex = 11;
            label2.Text = "شهر :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(153, 110);
            label3.Name = "label3";
            label3.Size = new Size(44, 20);
            label3.TabIndex = 13;
            label3.Text = "پلاک :";
            // 
            // txtHouseNumber
            // 
            txtHouseNumber.Location = new Point(20, 107);
            txtHouseNumber.Name = "txtHouseNumber";
            txtHouseNumber.ReadOnly = true;
            txtHouseNumber.Size = new Size(125, 27);
            txtHouseNumber.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(153, 151);
            label4.Name = "label4";
            label4.Size = new Size(72, 20);
            label4.TabIndex = 15;
            label4.Text = "کد پستی :";
            // 
            // txtPostalCode
            // 
            txtPostalCode.Location = new Point(20, 148);
            txtPostalCode.Name = "txtPostalCode";
            txtPostalCode.ReadOnly = true;
            txtPostalCode.Size = new Size(125, 27);
            txtPostalCode.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.FromArgb(0, 64, 0);
            label1.Location = new Point(185, 23);
            label1.Name = "label1";
            label1.Size = new Size(286, 20);
            label1.TabIndex = 1;
            label1.Text = "روی آدرس مورد نظر خود در جدول کلیک کنید";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.FromArgb(0, 64, 0);
            label5.Location = new Point(41, 23);
            label5.Name = "label5";
            label5.Size = new Size(161, 20);
            label5.TabIndex = 2;
            label5.Text = "مقصد فرستادن محصول";
            // 
            // AdressChooserForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SpringGreen;
            ClientSize = new Size(893, 285);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            ForeColor = Color.FromArgb(0, 64, 0);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "AdressChooserForm";
            RightToLeft = RightToLeft.Yes;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdressChooserForm";
            Load += AdressChooserForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)AdressDG).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView AdressDG;
        private DataGridViewTextBoxColumn AdressId;
        private DataGridViewTextBoxColumn UserId;
        private DataGridViewTextBoxColumn UserName;
        private DataGridViewTextBoxColumn City;
        private DataGridViewTextBoxColumn Street;
        private DataGridViewTextBoxColumn Alley;
        private DataGridViewTextBoxColumn HouseNumber;
        private DataGridViewTextBoxColumn PostalCode;
        private GroupBox groupBox2;
        private Label label4;
        private TextBox txtPostalCode;
        private Label label3;
        private TextBox txtHouseNumber;
        private Label label2;
        private TextBox txtCity;
        private Button SendOrderBtn;
        private Label label1;
        private Label label5;
    }
}