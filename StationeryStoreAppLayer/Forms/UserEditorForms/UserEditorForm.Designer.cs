
namespace StationeryStoreAppLayer.Forms.UserEditorForms
{
    partial class UserEditorForm
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
            label1 = new Label();
            NewPasswordtxt = new TextBox();
            NewEmaitxt = new TextBox();
            label2 = new Label();
            EditUserBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.FromArgb(192, 64, 0);
            label1.Location = new Point(325, 36);
            label1.Name = "label1";
            label1.Size = new Size(40, 20);
            label1.TabIndex = 0;
            label1.Text = "رمز : ";
            // 
            // NewPasswordtxt
            // 
            NewPasswordtxt.BackColor = Color.FromArgb(255, 128, 0);
            NewPasswordtxt.BorderStyle = BorderStyle.FixedSingle;
            NewPasswordtxt.ForeColor = Color.White;
            NewPasswordtxt.Location = new Point(63, 33);
            NewPasswordtxt.Name = "NewPasswordtxt";
            NewPasswordtxt.Size = new Size(256, 27);
            NewPasswordtxt.TabIndex = 1;
            // 
            // NewEmaitxt
            // 
            NewEmaitxt.BackColor = Color.FromArgb(255, 128, 0);
            NewEmaitxt.BorderStyle = BorderStyle.FixedSingle;
            NewEmaitxt.ForeColor = Color.White;
            NewEmaitxt.Location = new Point(64, 97);
            NewEmaitxt.Name = "NewEmaitxt";
            NewEmaitxt.Size = new Size(256, 27);
            NewEmaitxt.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(192, 64, 0);
            label2.Location = new Point(325, 100);
            label2.Name = "label2";
            label2.Size = new Size(53, 20);
            label2.TabIndex = 2;
            label2.Text = "ایمیل : ";
            label2.Click += label2_Click;
            // 
            // EditUserBtn
            // 
            EditUserBtn.BackColor = Color.FromArgb(255, 128, 0);
            EditUserBtn.FlatStyle = FlatStyle.Popup;
            EditUserBtn.ForeColor = Color.White;
            EditUserBtn.Location = new Point(155, 150);
            EditUserBtn.Name = "EditUserBtn";
            EditUserBtn.Size = new Size(94, 29);
            EditUserBtn.TabIndex = 4;
            EditUserBtn.Text = "تایید";
            EditUserBtn.UseVisualStyleBackColor = false;
            EditUserBtn.Click += EditUserBtn_Click;
            // 
            // UserEditorForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gold;
            ClientSize = new Size(406, 191);
            Controls.Add(EditUserBtn);
            Controls.Add(NewEmaitxt);
            Controls.Add(label2);
            Controls.Add(NewPasswordtxt);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "UserEditorForm";
            RightToLeft = RightToLeft.Yes;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ویرایش اطلاعات کاربر";
            Load += UserEditorForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Label label1;
        private TextBox NewPasswordtxt;
        private TextBox NewEmaitxt;
        private Label label2;
        private Button EditUserBtn;
    }
}