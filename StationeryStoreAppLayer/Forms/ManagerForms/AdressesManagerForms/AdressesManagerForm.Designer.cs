namespace StationeryStoreUILayer.Forms.ManagerForms.AdressesManagerForms
{
    partial class AdressesManagerForm
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
            AdressDG = new DataGridView();
            AdressId = new DataGridViewTextBoxColumn();
            UserId = new DataGridViewTextBoxColumn();
            UserName = new DataGridViewTextBoxColumn();
            City = new DataGridViewTextBoxColumn();
            Street = new DataGridViewTextBoxColumn();
            Alley = new DataGridViewTextBoxColumn();
            HouseNumber = new DataGridViewTextBoxColumn();
            PostalCode = new DataGridViewTextBoxColumn();
            groupBox1 = new GroupBox();
            label2 = new Label();
            txtCity = new TextBox();
            groupBox2 = new GroupBox();
            button1 = new Button();
            label6 = new Label();
            txtUserName = new TextBox();
            label4 = new Label();
            txtAlleyName = new TextBox();
            txtPostalCode = new NumericUpDown();
            label5 = new Label();
            txtStreet = new TextBox();
            label1 = new Label();
            label3 = new Label();
            txtHouseNumber = new TextBox();
            DeleteAdressBtn = new Button();
            RefreshBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)AdressDG).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtPostalCode).BeginInit();
            SuspendLayout();
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
            AdressDG.Dock = DockStyle.Fill;
            AdressDG.GridColor = Color.FromArgb(64, 0, 64);
            AdressDG.Location = new Point(3, 23);
            AdressDG.Name = "AdressDG";
            AdressDG.ReadOnly = true;
            AdressDG.RowHeadersWidth = 51;
            AdressDG.Size = new Size(750, 258);
            AdressDG.TabIndex = 1;
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
            // groupBox1
            // 
            groupBox1.Controls.Add(AdressDG);
            groupBox1.Location = new Point(3, 111);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(756, 284);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "همه ی آدرس ها";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(701, 29);
            label2.Name = "label2";
            label2.Size = new Size(43, 20);
            label2.TabIndex = 13;
            label2.Text = "شهر :";
            // 
            // txtCity
            // 
            txtCity.BackColor = Color.FromArgb(192, 255, 192);
            txtCity.ForeColor = Color.FromArgb(0, 64, 0);
            txtCity.Location = new Point(560, 26);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(133, 27);
            txtCity.TabIndex = 12;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(txtUserName);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(txtAlleyName);
            groupBox2.Controls.Add(txtPostalCode);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(txtStreet);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(txtHouseNumber);
            groupBox2.Controls.Add(txtCity);
            groupBox2.Controls.Add(label2);
            groupBox2.Location = new Point(3, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(756, 109);
            groupBox2.TabIndex = 14;
            groupBox2.TabStop = false;
            groupBox2.Text = "جستوجو در آدرس ها";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 255, 192);
            button1.FlatStyle = FlatStyle.Popup;
            button1.Image = Properties.Resources.icons8_search_50__1_;
            button1.Location = new Point(9, 26);
            button1.Name = "button1";
            button1.Size = new Size(94, 68);
            button1.TabIndex = 26;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(485, 70);
            label6.Name = "label6";
            label6.Size = new Size(67, 20);
            label6.TabIndex = 25;
            label6.Text = "نام کاربر :";
            // 
            // txtUserName
            // 
            txtUserName.BackColor = Color.FromArgb(192, 255, 192);
            txtUserName.ForeColor = Color.FromArgb(0, 64, 0);
            txtUserName.Location = new Point(354, 67);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(125, 27);
            txtUserName.TabIndex = 24;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(485, 29);
            label4.Name = "label4";
            label4.Size = new Size(71, 20);
            label4.TabIndex = 23;
            label4.Text = "نام کوچه :";
            // 
            // txtAlleyName
            // 
            txtAlleyName.BackColor = Color.FromArgb(192, 255, 192);
            txtAlleyName.ForeColor = Color.FromArgb(0, 64, 0);
            txtAlleyName.Location = new Point(354, 26);
            txtAlleyName.Name = "txtAlleyName";
            txtAlleyName.Size = new Size(125, 27);
            txtAlleyName.TabIndex = 22;
            // 
            // txtPostalCode
            // 
            txtPostalCode.BackColor = Color.FromArgb(192, 255, 192);
            txtPostalCode.ForeColor = Color.FromArgb(0, 64, 0);
            txtPostalCode.Location = new Point(125, 67);
            txtPostalCode.Maximum = new decimal(new int[] { 1410065407, 2, 0, 0 });
            txtPostalCode.Minimum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            txtPostalCode.Name = "txtPostalCode";
            txtPostalCode.Size = new Size(139, 27);
            txtPostalCode.TabIndex = 16;
            txtPostalCode.Value = new decimal(new int[] { 1000000000, 0, 0, 0 });
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(272, 69);
            label5.Name = "label5";
            label5.Size = new Size(72, 20);
            label5.TabIndex = 15;
            label5.Text = "کد پستی :";
            // 
            // txtStreet
            // 
            txtStreet.BackColor = Color.FromArgb(192, 255, 192);
            txtStreet.ForeColor = Color.FromArgb(0, 64, 0);
            txtStreet.Location = new Point(560, 67);
            txtStreet.Name = "txtStreet";
            txtStreet.Size = new Size(133, 27);
            txtStreet.TabIndex = 20;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(701, 70);
            label1.Name = "label1";
            label1.Size = new Size(53, 20);
            label1.TabIndex = 21;
            label1.Text = "خیابان :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(272, 29);
            label3.Name = "label3";
            label3.Size = new Size(44, 20);
            label3.TabIndex = 17;
            label3.Text = "پلاک :";
            // 
            // txtHouseNumber
            // 
            txtHouseNumber.BackColor = Color.FromArgb(192, 255, 192);
            txtHouseNumber.ForeColor = Color.FromArgb(0, 64, 0);
            txtHouseNumber.Location = new Point(125, 26);
            txtHouseNumber.Name = "txtHouseNumber";
            txtHouseNumber.ReadOnly = true;
            txtHouseNumber.Size = new Size(139, 27);
            txtHouseNumber.TabIndex = 16;
            // 
            // DeleteAdressBtn
            // 
            DeleteAdressBtn.BackColor = Color.FromArgb(255, 192, 192);
            DeleteAdressBtn.FlatStyle = FlatStyle.Popup;
            DeleteAdressBtn.ForeColor = Color.Maroon;
            DeleteAdressBtn.Image = Properties.Resources.icons8_remove_60;
            DeleteAdressBtn.ImageAlign = ContentAlignment.TopCenter;
            DeleteAdressBtn.Location = new Point(213, 398);
            DeleteAdressBtn.Name = "DeleteAdressBtn";
            DeleteAdressBtn.Size = new Size(161, 86);
            DeleteAdressBtn.TabIndex = 15;
            DeleteAdressBtn.Text = "حذف آدرس";
            DeleteAdressBtn.TextAlign = ContentAlignment.BottomCenter;
            DeleteAdressBtn.UseVisualStyleBackColor = false;
            DeleteAdressBtn.Click += DeleteAdressBtn_Click;
            // 
            // RefreshBtn
            // 
            RefreshBtn.BackColor = Color.Thistle;
            RefreshBtn.FlatStyle = FlatStyle.Popup;
            RefreshBtn.ForeColor = Color.Indigo;
            RefreshBtn.Image = Properties.Resources.icons8_refresh_60;
            RefreshBtn.ImageAlign = ContentAlignment.TopCenter;
            RefreshBtn.Location = new Point(380, 398);
            RefreshBtn.Name = "RefreshBtn";
            RefreshBtn.Size = new Size(155, 86);
            RefreshBtn.TabIndex = 6;
            RefreshBtn.Text = "رفرش کردن فرم";
            RefreshBtn.TextAlign = ContentAlignment.BottomCenter;
            RefreshBtn.UseVisualStyleBackColor = false;
            RefreshBtn.Click += RefreshBtn_Click;
            // 
            // AdressesManagerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 255, 128);
            ClientSize = new Size(761, 486);
            Controls.Add(RefreshBtn);
            Controls.Add(DeleteAdressBtn);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            ForeColor = Color.FromArgb(0, 64, 0);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "AdressesManagerForm";
            RightToLeft = RightToLeft.Yes;
            StartPosition = FormStartPosition.CenterParent;
            Text = "مدیریت آدرس ها";
            Load += AdressesManagerForm_Load;
            ((System.ComponentModel.ISupportInitialize)AdressDG).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtPostalCode).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView AdressDG;
        private GroupBox groupBox1;
        private Label label2;
        private TextBox txtCity;
        private GroupBox groupBox2;
        private TextBox txtStreet;
        private Label label1;
        private Label label3;
        private TextBox txtHouseNumber;
        private NumericUpDown txtPostalCode;
        private Label label5;
        private Label label6;
        private TextBox txtUserName;
        private Label label4;
        private TextBox txtAlleyName;
        private Button button1;
        private Button DeleteAdressBtn;
        private Button RefreshBtn;
        private DataGridViewTextBoxColumn AdressId;
        private DataGridViewTextBoxColumn UserId;
        private DataGridViewTextBoxColumn UserName;
        private DataGridViewTextBoxColumn City;
        private DataGridViewTextBoxColumn Street;
        private DataGridViewTextBoxColumn Alley;
        private DataGridViewTextBoxColumn HouseNumber;
        private DataGridViewTextBoxColumn PostalCode;
    }
}