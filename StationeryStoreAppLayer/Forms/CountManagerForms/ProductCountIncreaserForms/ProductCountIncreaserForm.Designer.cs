namespace StationeryStoreAppLayer.Forms.ProductCountIncreaserForms
{
    partial class ProductCountIncreaserForm
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
            ProductCountTxt = new NumericUpDown();
            label1 = new Label();
            BtnSend = new Button();
            ((System.ComponentModel.ISupportInitialize)ProductCountTxt).BeginInit();
            SuspendLayout();
            // 
            // ProductCountTxt
            // 
            ProductCountTxt.BackColor = Color.Green;
            ProductCountTxt.ForeColor = Color.White;
            ProductCountTxt.Location = new Point(124, 62);
            ProductCountTxt.Name = "ProductCountTxt";
            ProductCountTxt.Size = new Size(175, 27);
            ProductCountTxt.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.FromArgb(0, 64, 0);
            label1.Location = new Point(305, 64);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 1;
            label1.Text = "تعداد :";
            // 
            // BtnSend
            // 
            BtnSend.BackColor = Color.Green;
            BtnSend.FlatStyle = FlatStyle.Popup;
            BtnSend.Location = new Point(153, 116);
            BtnSend.Name = "BtnSend";
            BtnSend.Size = new Size(124, 37);
            BtnSend.TabIndex = 2;
            BtnSend.Text = "افزایش تعداد";
            BtnSend.UseVisualStyleBackColor = false;
            BtnSend.Click += BtnSend_Click;
            // 
            // ProductCountIncreaserForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Chartreuse;
            ClientSize = new Size(422, 197);
            Controls.Add(BtnSend);
            Controls.Add(label1);
            Controls.Add(ProductCountTxt);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "ProductCountIncreaserForm";
            RightToLeft = RightToLeft.Yes;
            StartPosition = FormStartPosition.CenterParent;
            Text = "افزایش تعداد محصول";
            Load += ProductCountIncreaserForm_Load;
            ((System.ComponentModel.ISupportInitialize)ProductCountTxt).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown ProductCountTxt;
        private Label label1;
        private Button BtnSend;
    }
}