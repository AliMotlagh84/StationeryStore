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
            ProductsSearchBox = new GroupBox();
            txtPostalCode = new NumericUpDown();
            label6 = new Label();
            txtHouseNumber = new TextBox();
            label5 = new Label();
            txtStreet = new TextBox();
            label2 = new Label();
            txtAlley = new TextBox();
            label1 = new Label();
            txtCity = new TextBox();
            label4 = new Label();
            txtUserId = new NumericUpDown();
            label3 = new Label();
            AdressIdtxt = new NumericUpDown();
            BrandNameLbl = new Label();
            btnProductsSearch = new Button();
            txtUserName = new TextBox();
            ProductNameLbl = new Label();
            DGPruducts = new DataGridView();
            AdressId = new DataGridViewTextBoxColumn();
            UserId = new DataGridViewTextBoxColumn();
            UserName = new DataGridViewTextBoxColumn();
            City = new DataGridViewTextBoxColumn();
            Street = new DataGridViewTextBoxColumn();
            Alley = new DataGridViewTextBoxColumn();
            HouseNumber = new DataGridViewTextBoxColumn();
            PostalCode = new DataGridViewTextBoxColumn();
            ProductGB.SuspendLayout();
            ProductsSearchBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtPostalCode).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtUserId).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AdressIdtxt).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DGPruducts).BeginInit();
            SuspendLayout();
            // 
            // ProductGB
            // 
            ProductGB.Controls.Add(ProductsSearchBox);
            ProductGB.Controls.Add(DGPruducts);
            ProductGB.Location = new Point(31, 14);
            ProductGB.Name = "ProductGB";
            ProductGB.Size = new Size(869, 587);
            ProductGB.TabIndex = 6;
            ProductGB.TabStop = false;
            ProductGB.Text = "محصولات";
            // 
            // ProductsSearchBox
            // 
            ProductsSearchBox.Controls.Add(txtPostalCode);
            ProductsSearchBox.Controls.Add(label6);
            ProductsSearchBox.Controls.Add(txtHouseNumber);
            ProductsSearchBox.Controls.Add(label5);
            ProductsSearchBox.Controls.Add(txtStreet);
            ProductsSearchBox.Controls.Add(label2);
            ProductsSearchBox.Controls.Add(txtAlley);
            ProductsSearchBox.Controls.Add(label1);
            ProductsSearchBox.Controls.Add(txtCity);
            ProductsSearchBox.Controls.Add(label4);
            ProductsSearchBox.Controls.Add(txtUserId);
            ProductsSearchBox.Controls.Add(label3);
            ProductsSearchBox.Controls.Add(AdressIdtxt);
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
            // txtPostalCode
            // 
            txtPostalCode.Location = new Point(622, 132);
            txtPostalCode.Maximum = new decimal(new int[] { 1410065407, 2, 0, 0 });
            txtPostalCode.Minimum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            txtPostalCode.Name = "txtPostalCode";
            txtPostalCode.Size = new Size(117, 27);
            txtPostalCode.TabIndex = 27;
            txtPostalCode.Value = new decimal(new int[] { 1000000000, 0, 0, 0 });
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(745, 134);
            label6.Name = "label6";
            label6.Size = new Size(72, 20);
            label6.TabIndex = 26;
            label6.Text = "کد پستی :";
            // 
            // txtHouseNumber
            // 
            txtHouseNumber.Location = new Point(6, 80);
            txtHouseNumber.Name = "txtHouseNumber";
            txtHouseNumber.Size = new Size(117, 27);
            txtHouseNumber.TabIndex = 25;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(131, 83);
            label5.Name = "label5";
            label5.Size = new Size(44, 20);
            label5.TabIndex = 24;
            label5.Text = "پلاک :";
            // 
            // txtStreet
            // 
            txtStreet.Location = new Point(424, 84);
            txtStreet.Name = "txtStreet";
            txtStreet.Size = new Size(117, 27);
            txtStreet.TabIndex = 23;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(549, 87);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 22;
            label2.Text = "خیابان";
            // 
            // txtAlley
            // 
            txtAlley.Location = new Point(424, 35);
            txtAlley.Name = "txtAlley";
            txtAlley.Size = new Size(117, 27);
            txtAlley.TabIndex = 21;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(549, 38);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 20;
            label1.Text = "کوچه :";
            // 
            // txtCity
            // 
            txtCity.Location = new Point(620, 35);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(117, 27);
            txtCity.TabIndex = 19;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(745, 38);
            label4.Name = "label4";
            label4.Size = new Size(43, 20);
            label4.TabIndex = 18;
            label4.Text = "شهر :";
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
            // AdressIdtxt
            // 
            AdressIdtxt.Location = new Point(620, 84);
            AdressIdtxt.Maximum = new decimal(new int[] { 1569325056, 23283064, 0, 0 });
            AdressIdtxt.Name = "AdressIdtxt";
            AdressIdtxt.Size = new Size(117, 27);
            AdressIdtxt.TabIndex = 15;
            // 
            // BrandNameLbl
            // 
            BrandNameLbl.AutoSize = true;
            BrandNameLbl.Location = new Point(744, 84);
            BrandNameLbl.Name = "BrandNameLbl";
            BrandNameLbl.Size = new Size(97, 20);
            BrandNameLbl.TabIndex = 5;
            BrandNameLbl.Text = "آی دی آدرس : ";
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
            // DGPruducts
            // 
            DGPruducts.AllowUserToAddRows = false;
            DGPruducts.AllowUserToDeleteRows = false;
            DGPruducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            DGPruducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            DGPruducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGPruducts.Columns.AddRange(new DataGridViewColumn[] { AdressId, UserId, UserName, City, Street, Alley, HouseNumber, PostalCode });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            DGPruducts.DefaultCellStyle = dataGridViewCellStyle2;
            DGPruducts.Location = new Point(6, 235);
            DGPruducts.Name = "DGPruducts";
            DGPruducts.ReadOnly = true;
            DGPruducts.RowHeadersWidth = 51;
            DGPruducts.Size = new Size(863, 340);
            DGPruducts.TabIndex = 0;
            // 
            // AdressId
            // 
            AdressId.DataPropertyName = "AdressId";
            AdressId.HeaderText = "آی دی آدرس ";
            AdressId.MinimumWidth = 6;
            AdressId.Name = "AdressId";
            AdressId.ReadOnly = true;
            // 
            // UserId
            // 
            UserId.DataPropertyName = "UserId";
            UserId.HeaderText = "آی دی کاربر";
            UserId.MinimumWidth = 6;
            UserId.Name = "UserId";
            UserId.ReadOnly = true;
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
            ProductsSearchBox.ResumeLayout(false);
            ProductsSearchBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtPostalCode).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtUserId).EndInit();
            ((System.ComponentModel.ISupportInitialize)AdressIdtxt).EndInit();
            ((System.ComponentModel.ISupportInitialize)DGPruducts).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox ProductGB;
        private GroupBox ProductsSearchBox;
        private Button btnProductsSearch;
        private TextBox txtUserName;
        private Label ProductNameLbl;
        private DataGridView DGPruducts;
        private Label BrandNameLbl;
        private NumericUpDown AdressIdtxt;
        private NumericUpDown txtUserId;
        private Label label3;
        private TextBox txtCity;
        private Label label4;
        private TextBox txtHouseNumber;
        private Label label5;
        private TextBox txtStreet;
        private Label label2;
        private TextBox txtAlley;
        private Label label1;
        private Label label6;
        private NumericUpDown txtPostalCode;
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