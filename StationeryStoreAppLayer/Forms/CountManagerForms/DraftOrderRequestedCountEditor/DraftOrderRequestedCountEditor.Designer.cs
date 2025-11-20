namespace StationeryStoreAppLayer.Forms.CountManagerForms.DraftOrderRequestedCountEditor
{
    partial class DraftOrderRequestedCountEditor
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
            textBox1 = new TextBox();
            label1 = new Label();
            EditDraftOrderRequestedCountBtn = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Yellow;
            textBox1.Location = new Point(93, 60);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(174, 27);
            textBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(67, 20);
            label1.Name = "label1";
            label1.Size = new Size(230, 20);
            label1.TabIndex = 1;
            label1.Text = "چه تعداد از این محصول میخواهید ؟";
            // 
            // EditDraftOrderRequestedCountBtn
            // 
            EditDraftOrderRequestedCountBtn.BackColor = Color.Yellow;
            EditDraftOrderRequestedCountBtn.FlatStyle = FlatStyle.Popup;
            EditDraftOrderRequestedCountBtn.Location = new Point(121, 106);
            EditDraftOrderRequestedCountBtn.Name = "EditDraftOrderRequestedCountBtn";
            EditDraftOrderRequestedCountBtn.Size = new Size(119, 29);
            EditDraftOrderRequestedCountBtn.TabIndex = 2;
            EditDraftOrderRequestedCountBtn.Text = "ویرایش";
            EditDraftOrderRequestedCountBtn.UseVisualStyleBackColor = false;
            // 
            // DraftOrderRequestedCountEditor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 192);
            ClientSize = new Size(373, 147);
            Controls.Add(EditDraftOrderRequestedCountBtn);
            Controls.Add(label1);
            Controls.Add(textBox1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "DraftOrderRequestedCountEditor";
            RightToLeft = RightToLeft.Yes;
            StartPosition = FormStartPosition.CenterParent;
            Text = "ویرایش تعداد درخواستی";
            Load += DraftOrderRequestedCountEditor_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private Button EditDraftOrderRequestedCountBtn;
    }
}