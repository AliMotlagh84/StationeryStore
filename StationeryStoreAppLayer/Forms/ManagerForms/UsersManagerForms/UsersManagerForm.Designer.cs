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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DeleteUserBtn = new Button();
            RefreshBtn = new Button();
            groupBox2 = new GroupBox();
            label2 = new Label();
            txtUserEmail = new TextBox();
            label1 = new Label();
            UsersSearchBtn = new Button();
            txtUserName = new TextBox();
            groupBox1 = new GroupBox();
            UsersDg = new DataGridView();
            UserId = new DataGridViewTextBoxColumn();
            UserName = new DataGridViewTextBoxColumn();
            Password = new DataGridViewTextBoxColumn();
            IsAdmin = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
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
            DeleteUserBtn.Location = new Point(679, 240);
            DeleteUserBtn.Name = "DeleteUserBtn";
            DeleteUserBtn.Size = new Size(130, 84);
            DeleteUserBtn.TabIndex = 11;
            DeleteUserBtn.Text = "حذف برند";
            DeleteUserBtn.TextAlign = ContentAlignment.BottomCenter;
            DeleteUserBtn.UseVisualStyleBackColor = false;
            DeleteUserBtn.Click += DeleteUserBtn_Click;
            // 
            // RefreshBtn
            // 
            RefreshBtn.BackColor = Color.FromArgb(255, 192, 255);
            RefreshBtn.FlatStyle = FlatStyle.Popup;
            RefreshBtn.ForeColor = Color.Purple;
            RefreshBtn.Image = Properties.Resources.icons8_refresh_60;
            RefreshBtn.Location = new Point(547, 240);
            RefreshBtn.Name = "RefreshBtn";
            RefreshBtn.Size = new Size(126, 84);
            RefreshBtn.TabIndex = 9;
            RefreshBtn.Text = "رفرش";
            RefreshBtn.TextAlign = ContentAlignment.BottomCenter;
            RefreshBtn.UseVisualStyleBackColor = false;
            RefreshBtn.Click += RefreshBtn_Click;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Purple;
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(txtUserEmail);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(UsersSearchBtn);
            groupBox2.Controls.Add(txtUserName);
            groupBox2.ForeColor = Color.White;
            groupBox2.Location = new Point(547, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(262, 231);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "جستوجو در کاربران";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(100, 93);
            label2.Name = "label2";
            label2.Size = new Size(42, 20);
            label2.TabIndex = 4;
            label2.Text = "ایمیل";
            // 
            // txtUserEmail
            // 
            txtUserEmail.BackColor = Color.FromArgb(255, 192, 255);
            txtUserEmail.ForeColor = Color.FromArgb(64, 0, 64);
            txtUserEmail.Location = new Point(37, 123);
            txtUserEmail.Name = "txtUserEmail";
            txtUserEmail.Size = new Size(175, 27);
            txtUserEmail.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(92, 22);
            label1.Name = "label1";
            label1.Size = new Size(60, 20);
            label1.TabIndex = 2;
            label1.Text = "نام کاربر";
            // 
            // UsersSearchBtn
            // 
            UsersSearchBtn.BackColor = Color.FromArgb(64, 0, 64);
            UsersSearchBtn.FlatStyle = FlatStyle.Popup;
            UsersSearchBtn.ForeColor = Color.White;
            UsersSearchBtn.Location = new Point(62, 178);
            UsersSearchBtn.Name = "UsersSearchBtn";
            UsersSearchBtn.Size = new Size(125, 36);
            UsersSearchBtn.TabIndex = 1;
            UsersSearchBtn.Text = "جستوجو";
            UsersSearchBtn.UseVisualStyleBackColor = false;
            UsersSearchBtn.Click += UsersSearchBtn_Click;
            // 
            // txtUserName
            // 
            txtUserName.BackColor = Color.FromArgb(255, 192, 255);
            txtUserName.ForeColor = Color.FromArgb(64, 0, 64);
            txtUserName.Location = new Point(37, 49);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(175, 27);
            txtUserName.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(UsersDg);
            groupBox1.Location = new Point(0, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(541, 324);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "لیست کاربران";
            // 
            // UsersDg
            // 
            UsersDg.AllowUserToAddRows = false;
            UsersDg.AllowUserToDeleteRows = false;
            UsersDg.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            UsersDg.BackgroundColor = Color.Purple;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            UsersDg.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            UsersDg.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            UsersDg.Columns.AddRange(new DataGridViewColumn[] { UserId, UserName, Password, IsAdmin, Email });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            UsersDg.DefaultCellStyle = dataGridViewCellStyle2;
            UsersDg.Dock = DockStyle.Fill;
            UsersDg.GridColor = Color.Gray;
            UsersDg.Location = new Point(3, 23);
            UsersDg.Name = "UsersDg";
            UsersDg.ReadOnly = true;
            UsersDg.RowHeadersWidth = 51;
            UsersDg.Size = new Size(535, 298);
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
            // 
            // UserName
            // 
            UserName.DataPropertyName = "UserName";
            UserName.HeaderText = "نام کاربر";
            UserName.MinimumWidth = 6;
            UserName.Name = "UserName";
            UserName.ReadOnly = true;
            // 
            // Password
            // 
            Password.DataPropertyName = "Password";
            Password.HeaderText = "رمز عبور";
            Password.MinimumWidth = 6;
            Password.Name = "Password";
            Password.ReadOnly = true;
            Password.Visible = false;
            // 
            // IsAdmin
            // 
            IsAdmin.DataPropertyName = "IsAdmin";
            IsAdmin.HeaderText = "وضعیت ادمینی";
            IsAdmin.MinimumWidth = 6;
            IsAdmin.Name = "IsAdmin";
            IsAdmin.ReadOnly = true;
            IsAdmin.Visible = false;
            // 
            // Email
            // 
            Email.DataPropertyName = "Email";
            Email.HeaderText = "ایمیل کاربر";
            Email.MinimumWidth = 6;
            Email.Name = "Email";
            Email.ReadOnly = true;
            // 
            // UsersManagerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 128, 255);
            ClientSize = new Size(811, 328);
            Controls.Add(DeleteUserBtn);
            Controls.Add(RefreshBtn);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "UsersManagerForm";
            RightToLeft = RightToLeft.Yes;
            StartPosition = FormStartPosition.CenterParent;
            Text = "مدیریت کاربران";
            Load += UsersManagerForm_Load;
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
        private Label label1;
        private Label label2;
        private TextBox txtUserEmail;
        private DataGridViewTextBoxColumn UserId;
        private DataGridViewTextBoxColumn UserName;
        private DataGridViewTextBoxColumn Password;
        private DataGridViewTextBoxColumn IsAdmin;
        private DataGridViewTextBoxColumn Email;
    }
}