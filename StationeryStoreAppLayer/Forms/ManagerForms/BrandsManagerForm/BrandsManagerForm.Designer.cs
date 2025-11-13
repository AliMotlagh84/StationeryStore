namespace StationeryStoreAppLayer.Forms.ManagerForms.BrandsManagerForm
{
    partial class BrandsManagerForm
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
            groupBox1 = new GroupBox();
            dataGridView1 = new DataGridView();
            BrandId = new DataGridViewTextBoxColumn();
            BrandName = new DataGridViewTextBoxColumn();
            groupBox2 = new GroupBox();
            BrandUpdateBtn = new Button();
            RefreshBtn = new Button();
            AddBrandBtn = new Button();
            DeleteBrandBtn = new Button();
            textBox1 = new TextBox();
            BrandsSearchBtn = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Location = new Point(4, -2);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(185, 324);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "لیست برندها";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = SystemColors.ActiveCaptionText;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { BrandId, BrandName });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.GridColor = Color.Gray;
            dataGridView1.Location = new Point(3, 23);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(179, 298);
            dataGridView1.TabIndex = 0;
            // 
            // BrandId
            // 
            BrandId.DataPropertyName = "BrandId";
            BrandId.HeaderText = "آی دی برند";
            BrandId.MinimumWidth = 6;
            BrandId.Name = "BrandId";
            BrandId.ReadOnly = true;
            BrandId.Visible = false;
            BrandId.Width = 125;
            // 
            // BrandName
            // 
            BrandName.DataPropertyName = "BrandName";
            BrandName.HeaderText = "نام برند";
            BrandName.MinimumWidth = 6;
            BrandName.Name = "BrandName";
            BrandName.ReadOnly = true;
            BrandName.Width = 125;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(BrandsSearchBtn);
            groupBox2.Controls.Add(textBox1);
            groupBox2.Location = new Point(195, -2);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(213, 139);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "جستوجو در برند ها";
            // 
            // BrandUpdateBtn
            // 
            BrandUpdateBtn.BackColor = Color.FromArgb(255, 255, 128);
            BrandUpdateBtn.FlatStyle = FlatStyle.Popup;
            BrandUpdateBtn.ForeColor = Color.FromArgb(255, 128, 0);
            BrandUpdateBtn.Image = Properties.Resources.icons8_update_tag_45;
            BrandUpdateBtn.Location = new Point(195, 143);
            BrandUpdateBtn.Name = "BrandUpdateBtn";
            BrandUpdateBtn.Size = new Size(102, 89);
            BrandUpdateBtn.TabIndex = 2;
            BrandUpdateBtn.Text = "تغییر نام برند";
            BrandUpdateBtn.TextAlign = ContentAlignment.BottomCenter;
            BrandUpdateBtn.UseVisualStyleBackColor = false;
            // 
            // RefreshBtn
            // 
            RefreshBtn.BackColor = Color.FromArgb(255, 192, 255);
            RefreshBtn.FlatStyle = FlatStyle.Popup;
            RefreshBtn.ForeColor = Color.Purple;
            RefreshBtn.Image = Properties.Resources.icons8_refresh_60;
            RefreshBtn.Location = new Point(195, 238);
            RefreshBtn.Name = "RefreshBtn";
            RefreshBtn.Size = new Size(102, 84);
            RefreshBtn.TabIndex = 3;
            RefreshBtn.Text = "رفرش";
            RefreshBtn.TextAlign = ContentAlignment.BottomCenter;
            RefreshBtn.UseVisualStyleBackColor = false;
            // 
            // AddBrandBtn
            // 
            AddBrandBtn.BackColor = Color.FromArgb(192, 255, 192);
            AddBrandBtn.FlatStyle = FlatStyle.Popup;
            AddBrandBtn.ForeColor = Color.Green;
            AddBrandBtn.Image = Properties.Resources.icons8_add_tag_45;
            AddBrandBtn.Location = new Point(306, 143);
            AddBrandBtn.Name = "AddBrandBtn";
            AddBrandBtn.Size = new Size(102, 89);
            AddBrandBtn.TabIndex = 4;
            AddBrandBtn.Text = "افزودن برند";
            AddBrandBtn.TextAlign = ContentAlignment.BottomCenter;
            AddBrandBtn.UseVisualStyleBackColor = false;
            // 
            // DeleteBrandBtn
            // 
            DeleteBrandBtn.BackColor = Color.FromArgb(255, 192, 192);
            DeleteBrandBtn.FlatStyle = FlatStyle.Popup;
            DeleteBrandBtn.ForeColor = Color.FromArgb(192, 0, 0);
            DeleteBrandBtn.Image = Properties.Resources.icons8_remove_tag_45;
            DeleteBrandBtn.Location = new Point(306, 238);
            DeleteBrandBtn.Name = "DeleteBrandBtn";
            DeleteBrandBtn.Size = new Size(102, 84);
            DeleteBrandBtn.TabIndex = 5;
            DeleteBrandBtn.Text = "حذف برند";
            DeleteBrandBtn.TextAlign = ContentAlignment.BottomCenter;
            DeleteBrandBtn.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.White;
            textBox1.Location = new Point(44, 36);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 0;
            // 
            // BrandsSearchBtn
            // 
            BrandsSearchBtn.BackColor = Color.Gray;
            BrandsSearchBtn.FlatStyle = FlatStyle.Popup;
            BrandsSearchBtn.ForeColor = Color.White;
            BrandsSearchBtn.Location = new Point(44, 78);
            BrandsSearchBtn.Name = "BrandsSearchBtn";
            BrandsSearchBtn.Size = new Size(125, 36);
            BrandsSearchBtn.TabIndex = 1;
            BrandsSearchBtn.Text = "جستوجو";
            BrandsSearchBtn.UseVisualStyleBackColor = false;
            // 
            // BrandsManagerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(416, 329);
            Controls.Add(DeleteBrandBtn);
            Controls.Add(AddBrandBtn);
            Controls.Add(RefreshBtn);
            Controls.Add(BrandUpdateBtn);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "BrandsManagerForm";
            RightToLeft = RightToLeft.Yes;
            StartPosition = FormStartPosition.CenterParent;
            Text = "مدیریت برند ها";
            Load += BrandsManagerForm_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn BrandId;
        private DataGridViewTextBoxColumn BrandName;
        private GroupBox groupBox2;
        private Button BrandUpdateBtn;
        private Button RefreshBtn;
        private Button AddBrandBtn;
        private Button DeleteBrandBtn;
        private Button BrandsSearchBtn;
        private TextBox textBox1;
    }
}