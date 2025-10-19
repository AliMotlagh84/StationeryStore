namespace StationeryStoreAppLayer.Forms.SignUpForms
{
    partial class SignUpForm
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
            PasswordLbl = new Label();
            txtPassword = new TextBox();
            UserName = new Label();
            txtUserName = new TextBox();
            AdminiCodeLbl = new Label();
            txtAdminiCode = new TextBox();
            EmailLbl = new Label();
            txtEmail = new TextBox();
            label1 = new Label();
            RbUser = new RadioButton();
            RbAdmin = new RadioButton();
            button1 = new Button();
            LoginLink = new LinkLabel();
            SuspendLayout();
            // 
            // PasswordLbl
            // 
            PasswordLbl.AutoSize = true;
            PasswordLbl.Location = new Point(276, 60);
            PasswordLbl.Name = "PasswordLbl";
            PasswordLbl.Size = new Size(68, 18);
            PasswordLbl.TabIndex = 7;
            PasswordLbl.Text = "رمز عبور :";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(29, 58);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(234, 26);
            txtPassword.TabIndex = 6;
            // 
            // UserName
            // 
            UserName.AutoSize = true;
            UserName.Location = new Point(274, 22);
            UserName.Name = "UserName";
            UserName.Size = new Size(79, 18);
            UserName.TabIndex = 5;
            UserName.Text = "نام کاربری :";
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(29, 19);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(234, 26);
            txtUserName.TabIndex = 4;
            // 
            // AdminiCodeLbl
            // 
            AdminiCodeLbl.AutoSize = true;
            AdminiCodeLbl.Location = new Point(274, 179);
            AdminiCodeLbl.Name = "AdminiCodeLbl";
            AdminiCodeLbl.Size = new Size(82, 18);
            AdminiCodeLbl.TabIndex = 11;
            AdminiCodeLbl.Text = "کد ادمینی :";
            AdminiCodeLbl.Visible = false;
            // 
            // txtAdminiCode
            // 
            txtAdminiCode.Location = new Point(29, 176);
            txtAdminiCode.Name = "txtAdminiCode";
            txtAdminiCode.Size = new Size(234, 26);
            txtAdminiCode.TabIndex = 10;
            txtAdminiCode.Visible = false;
            // 
            // EmailLbl
            // 
            EmailLbl.AutoSize = true;
            EmailLbl.Location = new Point(274, 101);
            EmailLbl.Name = "EmailLbl";
            EmailLbl.Size = new Size(51, 18);
            EmailLbl.TabIndex = 9;
            EmailLbl.Text = "ایمیل :";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(29, 98);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(234, 26);
            txtEmail.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(274, 140);
            label1.Name = "label1";
            label1.Size = new Size(69, 18);
            label1.TabIndex = 12;
            label1.Text = "نوع کاربر :";
            // 
            // RbUser
            // 
            RbUser.AutoSize = true;
            RbUser.Location = new Point(146, 140);
            RbUser.Name = "RbUser";
            RbUser.Size = new Size(93, 22);
            RbUser.TabIndex = 13;
            RbUser.TabStop = true;
            RbUser.Text = "کاربر عادی";
            RbUser.UseVisualStyleBackColor = true;
            RbUser.CheckedChanged += RbUser_CheckedChanged;
            // 
            // RbAdmin
            // 
            RbAdmin.AutoSize = true;
            RbAdmin.Location = new Point(23, 140);
            RbAdmin.Name = "RbAdmin";
            RbAdmin.Size = new Size(64, 22);
            RbAdmin.TabIndex = 14;
            RbAdmin.TabStop = true;
            RbAdmin.Text = "ادمین";
            RbAdmin.UseVisualStyleBackColor = true;
            RbAdmin.CheckedChanged += RbAdmin_CheckedChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.Green;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(145, 217);
            button1.Name = "button1";
            button1.Size = new Size(94, 32);
            button1.TabIndex = 15;
            button1.Text = "ثبت نام";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // LoginLink
            // 
            LoginLink.AutoSize = true;
            LoginLink.DisabledLinkColor = Color.Red;
            LoginLink.LinkBehavior = LinkBehavior.NeverUnderline;
            LoginLink.LinkColor = Color.Green;
            LoginLink.Location = new Point(122, 258);
            LoginLink.Name = "LoginLink";
            LoginLink.Size = new Size(128, 18);
            LoginLink.TabIndex = 16;
            LoginLink.TabStop = true;
            LoginLink.Text = "برگشت به فرم ورود";
            LoginLink.TextAlign = ContentAlignment.MiddleCenter;
            LoginLink.VisitedLinkColor = Color.Black;
            LoginLink.LinkClicked += SingUpLink_LinkClicked;
            // 
            // SignUpForm
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.GreenYellow;
            ClientSize = new Size(380, 285);
            Controls.Add(LoginLink);
            Controls.Add(button1);
            Controls.Add(RbAdmin);
            Controls.Add(RbUser);
            Controls.Add(label1);
            Controls.Add(AdminiCodeLbl);
            Controls.Add(txtAdminiCode);
            Controls.Add(EmailLbl);
            Controls.Add(txtEmail);
            Controls.Add(PasswordLbl);
            Controls.Add(txtPassword);
            Controls.Add(UserName);
            Controls.Add(txtUserName);
            Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "SignUpForm";
            RightToLeft = RightToLeft.Yes;
            StartPosition = FormStartPosition.CenterParent;
            Text = "SignUpForm";
            Load += SignUpForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label PasswordLbl;
        private TextBox txtPassword;
        private Label UserName;
        private TextBox txtUserName;
        private Label AdminiCodeLbl;
        private TextBox txtAdminiCode;
        private Label EmailLbl;
        private TextBox txtEmail;
        private Label label1;
        private RadioButton RbUser;
        private RadioButton RbAdmin;
        private Button button1;
        private LinkLabel LoginLink;
    }
}