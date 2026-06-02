namespace DigiERP.Forms.Auth
{
    partial class FrmAccount
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
            txtAccount = new Common.CommonTextBox();
            label1 = new Label();
            label2 = new Label();
            txtPasword = new Common.CommonTextBox();
            label3 = new Label();
            txtName = new Common.CommonTextBox();
            label4 = new Label();
            chkActive = new Common.CommonCheckBox();
            chkIsEmail = new Common.CommonCheckBox();
            label5 = new Label();
            btnSetPrivilege = new Button();
            btnSetAccountData = new Button();
            SuspendLayout();
            // 
            // txtAccount
            // 
            txtAccount.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            txtAccount.Location = new Point(80, 36);
            txtAccount.Name = "txtAccount";
            txtAccount.ReadOnly = true;
            txtAccount.Size = new Size(248, 32);
            txtAccount.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label1.Location = new Point(20, 40);
            label1.Name = "label1";
            label1.Size = new Size(48, 24);
            label1.TabIndex = 1;
            label1.Text = "帳號";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label2.Location = new Point(20, 92);
            label2.Name = "label2";
            label2.Size = new Size(48, 24);
            label2.TabIndex = 3;
            label2.Text = "密碼";
            // 
            // txtPasword
            // 
            txtPasword.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            txtPasword.Location = new Point(80, 88);
            txtPasword.Name = "txtPasword";
            txtPasword.PasswordChar = '●';
            txtPasword.Size = new Size(248, 32);
            txtPasword.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label3.Location = new Point(20, 144);
            label3.Name = "label3";
            label3.Size = new Size(48, 24);
            label3.TabIndex = 5;
            label3.Text = "姓名";
            // 
            // txtName
            // 
            txtName.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            txtName.Location = new Point(80, 140);
            txtName.Name = "txtName";
            txtName.Size = new Size(248, 32);
            txtName.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label4.Location = new Point(20, 196);
            label4.Name = "label4";
            label4.Size = new Size(48, 24);
            label4.TabIndex = 6;
            label4.Text = "停用";
            // 
            // chkActive
            // 
            chkActive.AutoSize = true;
            chkActive.Location = new Point(192, 200);
            chkActive.Name = "chkActive";
            chkActive.Size = new Size(15, 14);
            chkActive.TabIndex = 7;
            chkActive.UseVisualStyleBackColor = true;
            // 
            // chkIsEmail
            // 
            chkIsEmail.AutoSize = true;
            chkIsEmail.Location = new Point(192, 240);
            chkIsEmail.Name = "chkIsEmail";
            chkIsEmail.Size = new Size(15, 14);
            chkIsEmail.TabIndex = 9;
            chkIsEmail.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label5.Location = new Point(20, 236);
            label5.Name = "label5";
            label5.Size = new Size(86, 24);
            label5.TabIndex = 8;
            label5.Text = "寄件允許";
            // 
            // btnSetPrivilege
            // 
            btnSetPrivilege.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            btnSetPrivilege.Location = new Point(24, 276);
            btnSetPrivilege.Name = "btnSetPrivilege";
            btnSetPrivilege.Size = new Size(176, 44);
            btnSetPrivilege.TabIndex = 10;
            btnSetPrivilege.Text = "設定系統權限";
            btnSetPrivilege.UseVisualStyleBackColor = true;
            btnSetPrivilege.Click += btnSetPrivilege_Click;
            // 
            // btnSetAccountData
            // 
            btnSetAccountData.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            btnSetAccountData.Location = new Point(24, 336);
            btnSetAccountData.Name = "btnSetAccountData";
            btnSetAccountData.Size = new Size(176, 44);
            btnSetAccountData.TabIndex = 11;
            btnSetAccountData.Text = "更新帳號資料";
            btnSetAccountData.UseVisualStyleBackColor = true;
            btnSetAccountData.Click += btnSetAccountData_Click;
            // 
            // FrmAccount
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(360, 405);
            Controls.Add(btnSetAccountData);
            Controls.Add(btnSetPrivilege);
            Controls.Add(chkIsEmail);
            Controls.Add(label5);
            Controls.Add(chkActive);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtName);
            Controls.Add(label2);
            Controls.Add(txtPasword);
            Controls.Add(label1);
            Controls.Add(txtAccount);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "FrmAccount";
            Text = "帳號資料";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Common.CommonTextBox txtAccount;
        private Label label1;
        private Label label2;
        private Common.CommonTextBox txtPasword;
        private Label label3;
        private Common.CommonTextBox txtName;
        private Label label4;
        private Common.CommonCheckBox chkActive;
        private Common.CommonCheckBox chkIsEmail;
        private Label label5;
        private Button btnSetPrivilege;
        private Button btnSetAccountData;
    }
}