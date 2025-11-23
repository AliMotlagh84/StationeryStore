namespace StationeryStoreAppLayer.Forms.AdderOrEditorForms.AdressAdderOrEditorForms
{
    partial class AdressAdderOrEditorForm
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
            txtCityName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtStreetName = new TextBox();
            label3 = new Label();
            txtAlleyName = new TextBox();
            label4 = new Label();
            txtHouseNumber = new TextBox();
            label5 = new Label();
            txtPostalCode = new NumericUpDown();
            SendBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)txtPostalCode).BeginInit();
            SuspendLayout();
            // 
            // txtCityName
            // 
            txtCityName.BackColor = Color.PaleTurquoise;
            txtCityName.ForeColor = Color.Navy;
            txtCityName.Location = new Point(218, 25);
            txtCityName.Name = "txtCityName";
            txtCityName.Size = new Size(125, 27);
            txtCityName.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(349, 28);
            label1.Name = "label1";
            label1.Size = new Size(65, 20);
            label1.TabIndex = 1;
            label1.Text = "نام شهر :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(134, 28);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 3;
            label2.Text = "نام خیابان :";
            // 
            // txtStreetName
            // 
            txtStreetName.BackColor = Color.PaleTurquoise;
            txtStreetName.ForeColor = Color.Navy;
            txtStreetName.Location = new Point(3, 25);
            txtStreetName.Name = "txtStreetName";
            txtStreetName.Size = new Size(125, 27);
            txtStreetName.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(349, 100);
            label3.Name = "label3";
            label3.Size = new Size(71, 20);
            label3.TabIndex = 5;
            label3.Text = "نام کوچه :";
            // 
            // txtAlleyName
            // 
            txtAlleyName.BackColor = Color.PaleTurquoise;
            txtAlleyName.ForeColor = Color.Navy;
            txtAlleyName.Location = new Point(218, 97);
            txtAlleyName.Name = "txtAlleyName";
            txtAlleyName.Size = new Size(125, 27);
            txtAlleyName.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(134, 100);
            label4.Name = "label4";
            label4.Size = new Size(44, 20);
            label4.TabIndex = 7;
            label4.Text = "پلاک :";
            // 
            // txtHouseNumber
            // 
            txtHouseNumber.BackColor = Color.PaleTurquoise;
            txtHouseNumber.ForeColor = Color.Navy;
            txtHouseNumber.Location = new Point(3, 97);
            txtHouseNumber.Name = "txtHouseNumber";
            txtHouseNumber.Size = new Size(125, 27);
            txtHouseNumber.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(288, 160);
            label5.Name = "label5";
            label5.Size = new Size(72, 20);
            label5.TabIndex = 9;
            label5.Text = "کد پستی :";
            // 
            // txtPostalCode
            // 
            txtPostalCode.BackColor = Color.PaleTurquoise;
            txtPostalCode.ForeColor = Color.Navy;
            txtPostalCode.Location = new Point(133, 158);
            txtPostalCode.Maximum = new decimal(new int[] { 1410065407, 2, 0, 0 });
            txtPostalCode.Minimum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            txtPostalCode.Name = "txtPostalCode";
            txtPostalCode.Size = new Size(150, 27);
            txtPostalCode.TabIndex = 10;
            txtPostalCode.Value = new decimal(new int[] { 1000000000, 0, 0, 0 });
            // 
            // SendBtn
            // 
            SendBtn.FlatStyle = FlatStyle.Popup;
            SendBtn.Location = new Point(134, 212);
            SendBtn.Name = "SendBtn";
            SendBtn.Size = new Size(141, 35);
            SendBtn.TabIndex = 11;
            SendBtn.Text = "افزودن";
            SendBtn.UseVisualStyleBackColor = true;
            // 
            // AdressAdderOrEditorForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DeepSkyBlue;
            ClientSize = new Size(419, 259);
            Controls.Add(SendBtn);
            Controls.Add(txtPostalCode);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtHouseNumber);
            Controls.Add(label3);
            Controls.Add(txtAlleyName);
            Controls.Add(label2);
            Controls.Add(txtStreetName);
            Controls.Add(label1);
            Controls.Add(txtCityName);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "AdressAdderOrEditorForm";
            RightToLeft = RightToLeft.Yes;
            Text = "افزودن آدرس";
            Load += AdressAdderOrEditorForm_Load;
            ((System.ComponentModel.ISupportInitialize)txtPostalCode).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCityName;
        private Label label1;
        private Label label2;
        private TextBox txtStreetName;
        private Label label3;
        private TextBox txtAlleyName;
        private Label label4;
        private TextBox txtHouseNumber;
        private Label label5;
        private NumericUpDown txtPostalCode;
        private Button SendBtn;
    }
}