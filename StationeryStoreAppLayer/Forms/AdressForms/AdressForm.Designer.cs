namespace StationeryStoreAppLayer.Forms.AdressForms
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
            DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
            groupBox1 = new GroupBox();
            dataGridView1 = new DataGridView();
            DeleteAdressBtn = new Button();
            UpdateAdressBtn = new Button();
            AddNewAdressBtn = new Button();
            AdressId = new DataGridViewTextBoxColumn();
            UserId = new DataGridViewTextBoxColumn();
            UserName = new DataGridViewTextBoxColumn();
            City = new DataGridViewTextBoxColumn();
            Street = new DataGridViewTextBoxColumn();
            Alley = new DataGridViewTextBoxColumn();
            HouseNumber = new DataGridViewTextBoxColumn();
            PostalCode = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Location = new Point(2, -1);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(685, 282);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "آدرس های شما";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.Purple;
            dataGridViewCellStyle13.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = SystemColors.Control;
            dataGridViewCellStyle13.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle13.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { AdressId, UserId, UserName, City, Street, Alley, HouseNumber, PostalCode });
            dataGridViewCellStyle14.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = SystemColors.Window;
            dataGridViewCellStyle14.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle14.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle14;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.GridColor = Color.FromArgb(64, 0, 64);
            dataGridView1.Location = new Point(3, 23);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(679, 256);
            dataGridView1.TabIndex = 0;
            // 
            // DeleteAdressBtn
            // 
            DeleteAdressBtn.BackColor = Color.FromArgb(255, 192, 192);
            DeleteAdressBtn.FlatStyle = FlatStyle.Popup;
            DeleteAdressBtn.ForeColor = Color.Maroon;
            DeleteAdressBtn.Image = Properties.Resources.icons8_remove_60;
            DeleteAdressBtn.ImageAlign = ContentAlignment.TopCenter;
            DeleteAdressBtn.Location = new Point(5, 287);
            DeleteAdressBtn.Name = "DeleteAdressBtn";
            DeleteAdressBtn.Size = new Size(183, 86);
            DeleteAdressBtn.TabIndex = 7;
            DeleteAdressBtn.Text = "حذف آدرس";
            DeleteAdressBtn.TextAlign = ContentAlignment.BottomCenter;
            DeleteAdressBtn.UseVisualStyleBackColor = false;
            // 
            // UpdateAdressBtn
            // 
            UpdateAdressBtn.BackColor = Color.FromArgb(192, 255, 192);
            UpdateAdressBtn.FlatStyle = FlatStyle.Popup;
            UpdateAdressBtn.ForeColor = Color.DarkGreen;
            UpdateAdressBtn.Image = Properties.Resources.icons8_update_60;
            UpdateAdressBtn.ImageAlign = ContentAlignment.TopCenter;
            UpdateAdressBtn.Location = new Point(257, 287);
            UpdateAdressBtn.Name = "UpdateAdressBtn";
            UpdateAdressBtn.Size = new Size(182, 86);
            UpdateAdressBtn.TabIndex = 6;
            UpdateAdressBtn.Text = "ویرایش آدرس";
            UpdateAdressBtn.TextAlign = ContentAlignment.BottomCenter;
            UpdateAdressBtn.UseVisualStyleBackColor = false;
            // 
            // AddNewAdressBtn
            // 
            AddNewAdressBtn.BackColor = Color.FromArgb(255, 255, 128);
            AddNewAdressBtn.FlatStyle = FlatStyle.Popup;
            AddNewAdressBtn.ForeColor = Color.FromArgb(192, 64, 0);
            AddNewAdressBtn.Image = Properties.Resources.icons8_address_55;
            AddNewAdressBtn.ImageAlign = ContentAlignment.TopCenter;
            AddNewAdressBtn.Location = new Point(502, 287);
            AddNewAdressBtn.Name = "AddNewAdressBtn";
            AddNewAdressBtn.Size = new Size(182, 86);
            AddNewAdressBtn.TabIndex = 4;
            AddNewAdressBtn.Text = "افزودن آدرس جدید";
            AddNewAdressBtn.TextAlign = ContentAlignment.BottomCenter;
            AddNewAdressBtn.UseVisualStyleBackColor = false;
            // 
            // AdressId
            // 
            AdressId.HeaderText = "آی دی آدرس";
            AdressId.MinimumWidth = 6;
            AdressId.Name = "AdressId";
            AdressId.ReadOnly = true;
            AdressId.Visible = false;
            // 
            // UserId
            // 
            UserId.HeaderText = "آی دی کاربر";
            UserId.MinimumWidth = 6;
            UserId.Name = "UserId";
            UserId.ReadOnly = true;
            UserId.Visible = false;
            // 
            // UserName
            // 
            UserName.HeaderText = "نام کاربر";
            UserName.MinimumWidth = 6;
            UserName.Name = "UserName";
            UserName.ReadOnly = true;
            UserName.Visible = false;
            // 
            // City
            // 
            City.HeaderText = "شهر";
            City.MinimumWidth = 6;
            City.Name = "City";
            City.ReadOnly = true;
            // 
            // Street
            // 
            Street.HeaderText = "خیابان";
            Street.MinimumWidth = 6;
            Street.Name = "Street";
            Street.ReadOnly = true;
            // 
            // Alley
            // 
            Alley.HeaderText = "کوچه";
            Alley.MinimumWidth = 6;
            Alley.Name = "Alley";
            Alley.ReadOnly = true;
            // 
            // HouseNumber
            // 
            HouseNumber.HeaderText = "پلاک";
            HouseNumber.MinimumWidth = 6;
            HouseNumber.Name = "HouseNumber";
            HouseNumber.ReadOnly = true;
            // 
            // PostalCode
            // 
            PostalCode.HeaderText = "کد پستی";
            PostalCode.MinimumWidth = 6;
            PostalCode.Name = "PostalCode";
            PostalCode.ReadOnly = true;
            // 
            // AdressForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 128, 255);
            ClientSize = new Size(687, 379);
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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView dataGridView1;
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
    }
}