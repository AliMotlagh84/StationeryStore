namespace StationeryStoreAppLayer.LoginForms
{
    partial class Login
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
            txtUserName = new TextBox();
            UserName = new Label();
            PasswordLbl = new Label();
            txtPassword = new TextBox();
            BtnLogin = new Button();
            SingUpLink = new LinkLabel();
            SuspendLayout();
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(46, 26);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(234, 26);
            txtUserName.TabIndex = 0;
            // 
            // UserName
            // 
            UserName.AutoSize = true;
            UserName.Location = new Point(291, 29);
            UserName.Name = "UserName";
            UserName.Size = new Size(79, 18);
            UserName.TabIndex = 1;
            UserName.Text = "نام کاربری :";
            // 
            // PasswordLbl
            // 
            PasswordLbl.AutoSize = true;
            PasswordLbl.Location = new Point(293, 72);
            PasswordLbl.Name = "PasswordLbl";
            PasswordLbl.Size = new Size(68, 18);
            PasswordLbl.TabIndex = 3;
            PasswordLbl.Text = "رمز عبور :";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(46, 69);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(234, 26);
            txtPassword.TabIndex = 2;
            // 
            // BtnLogin
            // 
            BtnLogin.Location = new Point(132, 110);
            BtnLogin.Name = "BtnLogin";
            BtnLogin.Size = new Size(94, 26);
            BtnLogin.TabIndex = 4;
            BtnLogin.Text = "ورود";
            BtnLogin.UseVisualStyleBackColor = true;
            BtnLogin.Click += BtnLogin_Click;
            // 
            // SingUpLink
            // 
            SingUpLink.AutoSize = true;
            SingUpLink.LinkBehavior = LinkBehavior.NeverUnderline;
            SingUpLink.LinkColor = Color.FromArgb(0, 192, 192);
            SingUpLink.Location = new Point(151, 149);
            SingUpLink.Name = "SingUpLink";
            SingUpLink.Size = new Size(53, 18);
            SingUpLink.TabIndex = 5;
            SingUpLink.TabStop = true;
            SingUpLink.Text = "ثبت نام";
            SingUpLink.TextAlign = ContentAlignment.MiddleCenter;
            SingUpLink.VisitedLinkColor = Color.FromArgb(192, 64, 0);
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(380, 176);
            Controls.Add(SingUpLink);
            Controls.Add(BtnLogin);
            Controls.Add(PasswordLbl);
            Controls.Add(txtPassword);
            Controls.Add(UserName);
            Controls.Add(txtUserName);
            Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "Login";
            RightToLeft = RightToLeft.Yes;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ورود به برنامه";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUserName;
        private Label UserName;
        private Label PasswordLbl;
        private TextBox txtPassword;
        private Button BtnLogin;
        private LinkLabel SingUpLink;
    }
}