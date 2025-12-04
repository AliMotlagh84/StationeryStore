namespace StationeryStoreUILayer.Forms.AdressForms
{
    partial class AdressForm
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
            DeleteAdressBtn = new Button();
            UpdateAdressBtn = new Button();
            AddNewAdressBtn = new Button();
            DeleteAllAdressesBtn = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)AdressDG).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(AdressDG);
            groupBox1.Location = new Point(2, -1);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(685, 282);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "آدرس های شما";
            // 
            // AdressDG
            // 
            AdressDG.AllowUserToAddRows = false;
            AdressDG.AllowUserToDeleteRows = false;
            AdressDG.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            AdressDG.BackgroundColor = Color.Purple;
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
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
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
            AdressDG.Size = new Size(679, 256);
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
            // DeleteAdressBtn
            // 
            DeleteAdressBtn.BackColor = Color.FromArgb(255, 192, 192);
            DeleteAdressBtn.FlatStyle = FlatStyle.Popup;
            DeleteAdressBtn.ForeColor = Color.Maroon;
            DeleteAdressBtn.Image = StationeryStoreUILayer.Properties.Resources.icons8_remove_60;
            DeleteAdressBtn.ImageAlign = ContentAlignment.TopCenter;
            DeleteAdressBtn.Location = new Point(5, 287);
            DeleteAdressBtn.Name = "DeleteAdressBtn";
            DeleteAdressBtn.Size = new Size(161, 86);
            DeleteAdressBtn.TabIndex = 7;
            DeleteAdressBtn.Text = "حذف آدرس";
            DeleteAdressBtn.TextAlign = ContentAlignment.BottomCenter;
            DeleteAdressBtn.UseVisualStyleBackColor = false;
            DeleteAdressBtn.Click += DeleteAdressBtn_Click;
            // 
            // UpdateAdressBtn
            // 
            UpdateAdressBtn.BackColor = Color.FromArgb(192, 255, 192);
            UpdateAdressBtn.FlatStyle = FlatStyle.Popup;
            UpdateAdressBtn.ForeColor = Color.DarkGreen;
            UpdateAdressBtn.Image = StationeryStoreUILayer.Properties.Resources.icons8_update_60;
            UpdateAdressBtn.ImageAlign = ContentAlignment.TopCenter;
            UpdateAdressBtn.Location = new Point(348, 287);
            UpdateAdressBtn.Name = "UpdateAdressBtn";
            UpdateAdressBtn.Size = new Size(164, 86);
            UpdateAdressBtn.TabIndex = 6;
            UpdateAdressBtn.Text = "ویرایش آدرس";
            UpdateAdressBtn.TextAlign = ContentAlignment.BottomCenter;
            UpdateAdressBtn.UseVisualStyleBackColor = false;
            UpdateAdressBtn.Click += UpdateAdressBtn_Click;
            // 
            // AddNewAdressBtn
            // 
            AddNewAdressBtn.BackColor = Color.FromArgb(255, 255, 128);
            AddNewAdressBtn.FlatStyle = FlatStyle.Popup;
            AddNewAdressBtn.ForeColor = Color.FromArgb(192, 64, 0);
            AddNewAdressBtn.Image = StationeryStoreUILayer.Properties.Resources.icons8_address_55;
            AddNewAdressBtn.ImageAlign = ContentAlignment.TopCenter;
            AddNewAdressBtn.Location = new Point(520, 287);
            AddNewAdressBtn.Name = "AddNewAdressBtn";
            AddNewAdressBtn.Size = new Size(162, 86);
            AddNewAdressBtn.TabIndex = 4;
            AddNewAdressBtn.Text = "افزودن آدرس جدید";
            AddNewAdressBtn.TextAlign = ContentAlignment.BottomCenter;
            AddNewAdressBtn.UseVisualStyleBackColor = false;
            AddNewAdressBtn.Click += AddNewAdressBtn_Click;
            // 
            // DeleteAllAdressesBtn
            // 
            DeleteAllAdressesBtn.BackColor = Color.Silver;
            DeleteAllAdressesBtn.FlatStyle = FlatStyle.Popup;
            DeleteAllAdressesBtn.ForeColor = Color.Black;
            DeleteAllAdressesBtn.Image = StationeryStoreUILayer.Properties.Resources.icons8_trash_65;
            DeleteAllAdressesBtn.ImageAlign = ContentAlignment.TopCenter;
            DeleteAllAdressesBtn.Location = new Point(174, 287);
            DeleteAllAdressesBtn.Name = "DeleteAllAdressesBtn";
            DeleteAllAdressesBtn.Size = new Size(165, 86);
            DeleteAllAdressesBtn.TabIndex = 8;
            DeleteAllAdressesBtn.Text = "حذف همه آدرس ها";
            DeleteAllAdressesBtn.TextAlign = ContentAlignment.BottomCenter;
            DeleteAllAdressesBtn.UseVisualStyleBackColor = false;
            DeleteAllAdressesBtn.Click += DeleteAllAdressesBtn_Click;
            // 
            // AdressForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 128, 255);
            ClientSize = new Size(687, 379);
            Controls.Add(DeleteAllAdressesBtn);
            Controls.Add(DeleteAdressBtn);
            Controls.Add(UpdateAdressBtn);
            Controls.Add(AddNewAdressBtn);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            ImeMode = ImeMode.Hiragana;
            Name = "AdressForm";
            RightToLeft = RightToLeft.Yes;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "فرم آدرس ها";
            Load += AdressForm_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)AdressDG).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView AdressDG;
        private Button DeleteAdressBtn;
        private Button UpdateAdressBtn;
        private Button AddNewAdressBtn;
        private DataGridViewTextBoxColumn AdressId;
        private DataGridViewTextBoxColumn UserId;
        private DataGridViewTextBoxColumn UserName;
        private DataGridViewTextBoxColumn City;
        private DataGridViewTextBoxColumn Street;
        private DataGridViewTextBoxColumn Alley;
        private DataGridViewTextBoxColumn HouseNumber;
        private DataGridViewTextBoxColumn PostalCode;
        private Button DeleteAllAdressesBtn;
    }
}