namespace StationeryStoreAppLayer.Forms.SendOrderRoadForms.PayerForms
{
    partial class PayerForm
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
            Button GoBackBtn;
            pictureBox2 = new PictureBox();
            groupBox1 = new GroupBox();
            DeleteOrderBtn = new Button();
            PayBtn = new Button();
            txtCaptcha = new MaskedTextBox();
            label5 = new Label();
            CaptchaPB = new PictureBox();
            label6 = new Label();
            txtCVV2 = new MaskedTextBox();
            label7 = new Label();
            PooyaPasswordBtn = new Button();
            label8 = new Label();
            txtCreditCragNumber = new MaskedTextBox();
            txtCreditCardPassword = new TextBox();
            groupBox2 = new GroupBox();
            DiscountedAmountLbl = new Label();
            TotalAmountLbl = new Label();
            label2 = new Label();
            label1 = new Label();
            GoBackBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CaptchaPB).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // GoBackBtn
            // 
            GoBackBtn.BackColor = Color.FromArgb(255, 224, 192);
            GoBackBtn.FlatStyle = FlatStyle.Popup;
            GoBackBtn.ForeColor = Color.FromArgb(192, 64, 0);
            GoBackBtn.Image = Properties.Resources.icons8_left_2_60;
            GoBackBtn.ImageAlign = ContentAlignment.TopCenter;
            GoBackBtn.Location = new Point(3, 310);
            GoBackBtn.Name = "GoBackBtn";
            GoBackBtn.Size = new Size(132, 82);
            GoBackBtn.TabIndex = 22;
            GoBackBtn.Text = "برو به مرحله قبل";
            GoBackBtn.TextAlign = ContentAlignment.BottomCenter;
            GoBackBtn.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.ChatGPT_Image_Nov_27__2025__03_31_51_AM_removebg_preview;
            pictureBox2.Location = new Point(2, 533);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(433, 141);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(DeleteOrderBtn);
            groupBox1.Controls.Add(GoBackBtn);
            groupBox1.Controls.Add(PayBtn);
            groupBox1.Controls.Add(txtCaptcha);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(CaptchaPB);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtCVV2);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(PooyaPasswordBtn);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(txtCreditCragNumber);
            groupBox1.Controls.Add(txtCreditCardPassword);
            groupBox1.Location = new Point(2, 108);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(433, 419);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "پرداخت";
            // 
            // DeleteOrderBtn
            // 
            DeleteOrderBtn.BackColor = Color.FromArgb(255, 192, 192);
            DeleteOrderBtn.FlatStyle = FlatStyle.Popup;
            DeleteOrderBtn.ForeColor = Color.Maroon;
            DeleteOrderBtn.Image = Properties.Resources.icons8_cancel_order_55;
            DeleteOrderBtn.ImageAlign = ContentAlignment.TopCenter;
            DeleteOrderBtn.Location = new Point(289, 310);
            DeleteOrderBtn.Name = "DeleteOrderBtn";
            DeleteOrderBtn.Size = new Size(141, 82);
            DeleteOrderBtn.TabIndex = 23;
            DeleteOrderBtn.Text = "کنسل کردن سفارش ";
            DeleteOrderBtn.TextAlign = ContentAlignment.BottomCenter;
            DeleteOrderBtn.UseVisualStyleBackColor = false;
            // 
            // PayBtn
            // 
            PayBtn.BackColor = Color.FromArgb(192, 255, 192);
            PayBtn.FlatStyle = FlatStyle.Popup;
            PayBtn.ForeColor = Color.Green;
            PayBtn.Image = Properties.Resources.icons8_pay_70__1_;
            PayBtn.ImageAlign = ContentAlignment.TopCenter;
            PayBtn.Location = new Point(144, 310);
            PayBtn.Name = "PayBtn";
            PayBtn.Size = new Size(137, 82);
            PayBtn.TabIndex = 21;
            PayBtn.Text = "پرداخت";
            PayBtn.TextAlign = ContentAlignment.BottomCenter;
            PayBtn.UseVisualStyleBackColor = false;
            // 
            // txtCaptcha
            // 
            txtCaptcha.BackColor = Color.FromArgb(255, 224, 192);
            txtCaptcha.ForeColor = Color.FromArgb(192, 64, 0);
            txtCaptcha.Location = new Point(80, 136);
            txtCaptcha.Mask = "00000";
            txtCaptcha.Name = "txtCaptcha";
            txtCaptcha.RejectInputOnFirstFailure = true;
            txtCaptcha.Size = new Size(114, 27);
            txtCaptcha.TabIndex = 20;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(202, 139);
            label5.Name = "label5";
            label5.RightToLeft = RightToLeft.Yes;
            label5.Size = new Size(143, 20);
            label5.TabIndex = 19;
            label5.Text = "کد تصویر را واد کنید :";
            // 
            // CaptchaPB
            // 
            CaptchaPB.Location = new Point(80, 178);
            CaptchaPB.Name = "CaptchaPB";
            CaptchaPB.Size = new Size(157, 62);
            CaptchaPB.TabIndex = 18;
            CaptchaPB.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(200, 84);
            label6.Name = "label6";
            label6.RightToLeft = RightToLeft.Yes;
            label6.Size = new Size(51, 20);
            label6.TabIndex = 17;
            label6.Text = "CVV2 :";
            // 
            // txtCVV2
            // 
            txtCVV2.BackColor = Color.FromArgb(255, 224, 192);
            txtCVV2.ForeColor = Color.FromArgb(192, 64, 0);
            txtCVV2.Location = new Point(77, 81);
            txtCVV2.Mask = "0000";
            txtCVV2.Name = "txtCVV2";
            txtCVV2.RejectInputOnFirstFailure = true;
            txtCVV2.Size = new Size(117, 27);
            txtCVV2.TabIndex = 16;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(278, 258);
            label7.Name = "label7";
            label7.RightToLeft = RightToLeft.Yes;
            label7.Size = new Size(65, 20);
            label7.TabIndex = 15;
            label7.Text = "رمز دوم :";
            // 
            // PooyaPasswordBtn
            // 
            PooyaPasswordBtn.BackColor = Color.OrangeRed;
            PooyaPasswordBtn.FlatStyle = FlatStyle.Popup;
            PooyaPasswordBtn.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PooyaPasswordBtn.ForeColor = Color.White;
            PooyaPasswordBtn.Location = new Point(80, 255);
            PooyaPasswordBtn.Name = "PooyaPasswordBtn";
            PooyaPasswordBtn.Size = new Size(65, 27);
            PooyaPasswordBtn.TabIndex = 14;
            PooyaPasswordBtn.Text = "رمز پویا";
            PooyaPasswordBtn.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(229, 28);
            label8.Name = "label8";
            label8.RightToLeft = RightToLeft.Yes;
            label8.Size = new Size(90, 20);
            label8.TabIndex = 13;
            label8.Text = "شماره کارت :";
            // 
            // txtCreditCragNumber
            // 
            txtCreditCragNumber.BackColor = Color.FromArgb(255, 224, 192);
            txtCreditCragNumber.ForeColor = Color.FromArgb(192, 64, 0);
            txtCreditCragNumber.Location = new Point(75, 25);
            txtCreditCragNumber.Mask = "0000 0000 0000 0000";
            txtCreditCragNumber.Name = "txtCreditCragNumber";
            txtCreditCragNumber.RejectInputOnFirstFailure = true;
            txtCreditCragNumber.Size = new Size(149, 27);
            txtCreditCragNumber.TabIndex = 12;
            // 
            // txtCreditCardPassword
            // 
            txtCreditCardPassword.BackColor = Color.FromArgb(255, 224, 192);
            txtCreditCardPassword.ForeColor = Color.FromArgb(192, 64, 0);
            txtCreditCardPassword.Location = new Point(144, 255);
            txtCreditCardPassword.Name = "txtCreditCardPassword";
            txtCreditCardPassword.Size = new Size(127, 27);
            txtCreditCardPassword.TabIndex = 11;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(DiscountedAmountLbl);
            groupBox2.Controls.Add(TotalAmountLbl);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(2, -2);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(433, 112);
            groupBox2.TabIndex = 13;
            groupBox2.TabStop = false;
            groupBox2.Text = "مبلغ پرداختی";
            // 
            // DiscountedAmountLbl
            // 
            DiscountedAmountLbl.AutoSize = true;
            DiscountedAmountLbl.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DiscountedAmountLbl.Location = new Point(97, 71);
            DiscountedAmountLbl.Name = "DiscountedAmountLbl";
            DiscountedAmountLbl.RightToLeft = RightToLeft.Yes;
            DiscountedAmountLbl.Size = new Size(112, 25);
            DiscountedAmountLbl.TabIndex = 25;
            DiscountedAmountLbl.Text = "0000000000";
            // 
            // TotalAmountLbl
            // 
            TotalAmountLbl.AutoSize = true;
            TotalAmountLbl.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TotalAmountLbl.Location = new Point(96, 34);
            TotalAmountLbl.Name = "TotalAmountLbl";
            TotalAmountLbl.RightToLeft = RightToLeft.Yes;
            TotalAmountLbl.Size = new Size(112, 25);
            TotalAmountLbl.TabIndex = 22;
            TotalAmountLbl.Text = "0000000000";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(210, 71);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.Yes;
            label2.Size = new Size(125, 20);
            label2.TabIndex = 23;
            label2.Text = "مبلغ کل با تخفیف :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(210, 34);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.Yes;
            label1.Size = new Size(66, 20);
            label1.TabIndex = 22;
            label1.Text = "مبلغ کل :";
            // 
            // PayerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 128, 0);
            ClientSize = new Size(438, 679);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox2);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "PayerForm";
            RightToLeft = RightToLeft.Yes;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "پرداخت";
            Load += PayerForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)CaptchaPB).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Microsoft.Data.SqlClient.SqlCommandBuilder sqlCommandBuilder1;
        private PictureBox pictureBox2;
        private GroupBox groupBox1;
        private Button PayBtn;
        private MaskedTextBox txtCaptcha;
        private Label label5;
        private PictureBox CaptchaPB;
        private Label label6;
        private MaskedTextBox txtCVV2;
        private Label label7;
        private Button PooyaPasswordBtn;
        private Label label8;
        private MaskedTextBox txtCreditCragNumber;
        private TextBox txtCreditCardPassword;
        private GroupBox groupBox2;
        private Label DiscountedAmountLbl;
        private Label TotalAmountLbl;
        private Label label2;
        private Label label1;
        private Button DeleteOrderBtn;
    }
}