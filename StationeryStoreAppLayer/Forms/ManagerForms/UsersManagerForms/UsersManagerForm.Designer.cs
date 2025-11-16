namespace StationeryStoreAppLayer.Forms.ManagerForms.UsersManagerForms
{
    partial class UsersManagerForm
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
            DeleteUserBtn = new Button();
            RefreshBtn = new Button();
            groupBox2 = new GroupBox();
            UsersSearchBtn = new Button();
            txtUserName = new TextBox();
            groupBox1 = new GroupBox();
            UsersDg = new DataGridView();
            UserId = new DataGridViewTextBoxColumn();
            UserName = new DataGridViewTextBoxColumn();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)UsersDg).BeginInit();
            SuspendLayout();
            // 
            // DeleteUserBtn
            // 
            DeleteUserBtn.BackColor = Color.FromArgb(255, 192, 192);
            DeleteUserBtn.FlatStyle = FlatStyle.Popup;
            DeleteUserBtn.ForeColor = Color.FromArgb(192, 0, 0);
            DeleteUserBtn.Image = Properties.Resources.icons8_delete_user_55;
            DeleteUserBtn.Location = new Point(191, 147);
            DeleteUserBtn.Name = "DeleteUserBtn";
            DeleteUserBtn.Size = new Size(161, 84);
            DeleteUserBtn.TabIndex = 11;
            DeleteUserBtn.Text = "حذف برند";
            DeleteUserBtn.TextAlign = ContentAlignment.BottomCenter;
            DeleteUserBtn.UseVisualStyleBackColor = false;
            // 
            // RefreshBtn
            // 
            RefreshBtn.BackColor = Color.FromArgb(255, 192, 255);
            RefreshBtn.FlatStyle = FlatStyle.Popup;
            RefreshBtn.ForeColor = Color.Purple;
            RefreshBtn.Image = Properties.Resources.icons8_refresh_60;
            RefreshBtn.Location = new Point(191, 240);
            RefreshBtn.Name = "RefreshBtn";
            RefreshBtn.Size = new Size(161, 84);
            RefreshBtn.TabIndex = 9;
            RefreshBtn.Text = "رفرش";
            RefreshBtn.TextAlign = ContentAlignment.BottomCenter;
            RefreshBtn.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Purple;
            groupBox2.Controls.Add(UsersSearchBtn);
            groupBox2.Controls.Add(txtUserName);
            groupBox2.ForeColor = Color.White;
            groupBox2.Location = new Point(191, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(161, 134);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "جستوجو در کاربران";
            // 
            // UsersSearchBtn
            // 
            UsersSearchBtn.BackColor = Color.FromArgb(64, 0, 64);
            UsersSearchBtn.FlatStyle = FlatStyle.Popup;
            UsersSearchBtn.ForeColor = Color.White;
            UsersSearchBtn.Location = new Point(19, 78);
            UsersSearchBtn.Name = "UsersSearchBtn";
            UsersSearchBtn.Size = new Size(125, 36);
            UsersSearchBtn.TabIndex = 1;
            UsersSearchBtn.Text = "جستوجو";
            UsersSearchBtn.UseVisualStyleBackColor = false;
            // 
            // txtUserName
            // 
            txtUserName.BackColor = Color.FromArgb(255, 192, 255);
            txtUserName.ForeColor = Color.FromArgb(64, 0, 64);
            txtUserName.Location = new Point(19, 36);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(125, 27);
            txtUserName.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(UsersDg);
            groupBox1.Location = new Point(0, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(185, 324);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "لیست کاربران";
            // 
            // UsersDg
            // 
            UsersDg.AllowUserToAddRows = false;
            UsersDg.AllowUserToDeleteRows = false;
            UsersDg.BackgroundColor = Color.Purple;
            UsersDg.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            UsersDg.Columns.AddRange(new DataGridViewColumn[] { UserId, UserName });
            UsersDg.Dock = DockStyle.Fill;
            UsersDg.GridColor = Color.Gray;
            UsersDg.Location = new Point(3, 23);
            UsersDg.Name = "UsersDg";
            UsersDg.ReadOnly = true;
            UsersDg.RowHeadersWidth = 51;
            UsersDg.Size = new Size(179, 298);
            UsersDg.TabIndex = 0;
            // 
            // UserId
            // 
            UserId.DataPropertyName = "UserId";
            UserId.HeaderText = "آی دی کاربر";
            UserId.MinimumWidth = 6;
            UserId.Name = "UserId";
            UserId.ReadOnly = true;
            UserId.Visible = false;
            UserId.Width = 125;
            // 
            // UserName
            // 
            UserName.DataPropertyName = "UserName";
            UserName.HeaderText = "نام کاربر";
            UserName.MinimumWidth = 6;
            UserName.Name = "UserName";
            UserName.ReadOnly = true;
            UserName.Width = 125;
            // 
            // UsersManagerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 128, 255);
            ClientSize = new Size(358, 327);
            Controls.Add(DeleteUserBtn);
            Controls.Add(RefreshBtn);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "UsersManagerForm";
            RightToLeft = RightToLeft.Yes;
            StartPosition = FormStartPosition.CenterParent;
            Text = "مدیریت کاربران";
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)UsersDg).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button DeleteUserBtn;
        private Button RefreshBtn;
        private GroupBox groupBox2;
        private Button UsersSearchBtn;
        private TextBox txtUserName;
        private GroupBox groupBox1;
        private DataGridView UsersDg;
        private DataGridViewTextBoxColumn UserId;
        private DataGridViewTextBoxColumn UserName;
    }
}