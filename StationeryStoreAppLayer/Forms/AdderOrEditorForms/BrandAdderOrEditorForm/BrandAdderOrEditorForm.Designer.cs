namespace StationeryStoreUILayer.Forms.AdderOrEditorForms.BrandAdderOrEditorForm
{
    partial class BrandAdderOrEditorForm
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
            txtBrandName = new TextBox();
            SendBtn = new Button();
            SuspendLayout();
            // 
            // txtBrandName
            // 
            txtBrandName.Location = new Point(96, 47);
            txtBrandName.Name = "txtBrandName";
            txtBrandName.Size = new Size(154, 27);
            txtBrandName.TabIndex = 0;
            // 
            // SendBtn
            // 
            SendBtn.BackColor = Color.Black;
            SendBtn.FlatStyle = FlatStyle.Popup;
            SendBtn.ForeColor = Color.White;
            SendBtn.Location = new Point(115, 102);
            SendBtn.Name = "SendBtn";
            SendBtn.Size = new Size(114, 29);
            SendBtn.TabIndex = 1;
            SendBtn.Text = "افزودن";
            SendBtn.UseVisualStyleBackColor = false;
            SendBtn.Click += SendBtn_Click;
            // 
            // BrandAdderOrEditorForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(349, 169);
            Controls.Add(SendBtn);
            Controls.Add(txtBrandName);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "BrandAdderOrEditorForm";
            RightToLeft = RightToLeft.Yes;
            StartPosition = FormStartPosition.CenterParent;
            Text = "افزودن برند جدید";
            Load += BrandAdderOrEditorForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBrandName;
        private Button SendBtn;
    }
}