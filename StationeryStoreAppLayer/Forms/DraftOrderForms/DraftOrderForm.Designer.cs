namespace StationeryStoreAppLayer.Forms.DraftOrderForms
{
    partial class DraftOrderForm
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
            RequestedProductCounttxt = new NumericUpDown();
            NumberQuestionLbl = new Label();
            SendDraftOrderBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)RequestedProductCounttxt).BeginInit();
            SuspendLayout();
            // 
            // RequestedProductCounttxt
            // 
            RequestedProductCounttxt.BackColor = Color.Maroon;
            RequestedProductCounttxt.BorderStyle = BorderStyle.FixedSingle;
            RequestedProductCounttxt.ForeColor = SystemColors.Info;
            RequestedProductCounttxt.Location = new Point(102, 69);
            RequestedProductCounttxt.Name = "RequestedProductCounttxt";
            RequestedProductCounttxt.Size = new Size(128, 27);
            RequestedProductCounttxt.TabIndex = 0;
            // 
            // NumberQuestionLbl
            // 
            NumberQuestionLbl.AutoSize = true;
            NumberQuestionLbl.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NumberQuestionLbl.ForeColor = Color.Maroon;
            NumberQuestionLbl.Location = new Point(54, 24);
            NumberQuestionLbl.Name = "NumberQuestionLbl";
            NumberQuestionLbl.Size = new Size(239, 20);
            NumberQuestionLbl.TabIndex = 1;
            NumberQuestionLbl.Text = "چه تعداد از این محصول را میخواهید؟";
            // 
            // SendDraftOrderBtn
            // 
            SendDraftOrderBtn.BackColor = Color.Red;
            SendDraftOrderBtn.FlatStyle = FlatStyle.Popup;
            SendDraftOrderBtn.ForeColor = Color.White;
            SendDraftOrderBtn.Location = new Point(92, 113);
            SendDraftOrderBtn.Name = "SendDraftOrderBtn";
            SendDraftOrderBtn.Size = new Size(151, 29);
            SendDraftOrderBtn.TabIndex = 2;
            SendDraftOrderBtn.Text = "افزودن به سبد خرید";
            SendDraftOrderBtn.UseVisualStyleBackColor = false;
            SendDraftOrderBtn.Click += SendDraftOrderBtn_Click;
            // 
            // DraftOrderForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 128);
            ClientSize = new Size(343, 157);
            Controls.Add(SendDraftOrderBtn);
            Controls.Add(NumberQuestionLbl);
            Controls.Add(RequestedProductCounttxt);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "DraftOrderForm";
            Padding = new Padding(2, 0, 0, 0);
            RightToLeft = RightToLeft.Yes;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "افزودن به سبد خرید";
            Load += DraftOrderForm_Load;
            ((System.ComponentModel.ISupportInitialize)RequestedProductCounttxt).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown RequestedProductCounttxt;
        private Label NumberQuestionLbl;
        private Button SendDraftOrderBtn;
    }
}