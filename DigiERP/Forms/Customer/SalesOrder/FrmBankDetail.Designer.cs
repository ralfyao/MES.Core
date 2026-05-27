namespace DigiERP.Forms.Customer.SalesOrder
{
    partial class FrmBankDetail
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
            label2 = new Label();
            txtBankCode = new TextBox();
            txtBankName = new TextBox();
            txtBankNameE = new TextBox();
            label3 = new Label();
            txtBankAddress = new TextBox();
            label4 = new Label();
            txtAccount = new TextBox();
            label5 = new Label();
            txtSwiftCode = new TextBox();
            label6 = new Label();
            txtTel = new TextBox();
            label7 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 20);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 0;
            label1.Text = "銀存編碼";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 64);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 1;
            label2.Text = "銀行名稱";
            // 
            // txtBankCode
            // 
            txtBankCode.Enabled = false;
            txtBankCode.Location = new Point(88, 16);
            txtBankCode.Name = "txtBankCode";
            txtBankCode.Size = new Size(268, 23);
            txtBankCode.TabIndex = 2;
            // 
            // txtBankName
            // 
            txtBankName.Enabled = false;
            txtBankName.Location = new Point(88, 60);
            txtBankName.Name = "txtBankName";
            txtBankName.Size = new Size(268, 23);
            txtBankName.TabIndex = 3;
            // 
            // txtBankNameE
            // 
            txtBankNameE.Enabled = false;
            txtBankNameE.Location = new Point(88, 104);
            txtBankNameE.Multiline = true;
            txtBankNameE.Name = "txtBankNameE";
            txtBankNameE.Size = new Size(268, 56);
            txtBankNameE.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(4, 108);
            label3.Name = "label3";
            label3.Size = new Size(72, 15);
            label3.TabIndex = 4;
            label3.Text = "Bank Name";
            // 
            // txtBankAddress
            // 
            txtBankAddress.Enabled = false;
            txtBankAddress.Location = new Point(88, 176);
            txtBankAddress.Multiline = true;
            txtBankAddress.Name = "txtBankAddress";
            txtBankAddress.Size = new Size(268, 56);
            txtBankAddress.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(4, 180);
            label4.Name = "label4";
            label4.Size = new Size(82, 15);
            label4.TabIndex = 6;
            label4.Text = "Bank Address";
            // 
            // txtAccount
            // 
            txtAccount.Enabled = false;
            txtAccount.Location = new Point(88, 248);
            txtAccount.Name = "txtAccount";
            txtAccount.Size = new Size(268, 23);
            txtAccount.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(32, 252);
            label5.Name = "label5";
            label5.Size = new Size(31, 15);
            label5.TabIndex = 8;
            label5.Text = "帳號";
            // 
            // txtSwiftCode
            // 
            txtSwiftCode.Enabled = false;
            txtSwiftCode.Location = new Point(88, 288);
            txtSwiftCode.Name = "txtSwiftCode";
            txtSwiftCode.Size = new Size(268, 23);
            txtSwiftCode.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(4, 292);
            label6.Name = "label6";
            label6.Size = new Size(68, 15);
            label6.TabIndex = 10;
            label6.Text = "Swift Code";
            // 
            // txtTel
            // 
            txtTel.Enabled = false;
            txtTel.Location = new Point(88, 328);
            txtTel.Name = "txtTel";
            txtTel.Size = new Size(268, 23);
            txtTel.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(32, 332);
            label7.Name = "label7";
            label7.Size = new Size(31, 15);
            label7.TabIndex = 12;
            label7.Text = "電話";
            // 
            // FrmBankDetail
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(386, 374);
            Controls.Add(txtTel);
            Controls.Add(label7);
            Controls.Add(txtSwiftCode);
            Controls.Add(label6);
            Controls.Add(txtAccount);
            Controls.Add(label5);
            Controls.Add(txtBankAddress);
            Controls.Add(label4);
            Controls.Add(txtBankNameE);
            Controls.Add(label3);
            Controls.Add(txtBankName);
            Controls.Add(txtBankCode);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "FrmBankDetail";
            Text = "銀行帳戶核對";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtBankCode;
        private TextBox txtBankName;
        private TextBox txtBankNameE;
        private Label label3;
        private TextBox txtBankAddress;
        private Label label4;
        private TextBox txtAccount;
        private Label label5;
        private TextBox txtSwiftCode;
        private Label label6;
        private TextBox txtTel;
        private Label label7;
    }
}