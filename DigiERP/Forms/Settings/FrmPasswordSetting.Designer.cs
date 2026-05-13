namespace DigiERP.Forms.Settings
{
    partial class FrmPasswordSetting
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
            txtPassword = new Common.CommonTextBox();
            label1 = new Label();
            lblAccount = new Label();
            label2 = new Label();
            label3 = new Label();
            txtNewPassword = new Common.CommonTextBox();
            btnSubmit = new Button();
            label4 = new Label();
            txtNewPasswordConfirm = new Common.CommonTextBox();
            SuspendLayout();
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(144, 88);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '●';
            txtPassword.Size = new Size(125, 27);
            txtPassword.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label1.Location = new Point(16, 24);
            label1.Name = "label1";
            label1.Size = new Size(59, 29);
            label1.TabIndex = 1;
            label1.Text = "帳號";
            // 
            // lblAccount
            // 
            lblAccount.AutoSize = true;
            lblAccount.Font = new Font("Microsoft JhengHei UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 136);
            lblAccount.Location = new Point(128, 24);
            lblAccount.Name = "lblAccount";
            lblAccount.Size = new Size(129, 29);
            lblAccount.TabIndex = 2;
            lblAccount.Text = "lblAccount";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft JhengHei UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label2.Location = new Point(16, 88);
            label2.Name = "label2";
            label2.Size = new Size(128, 29);
            label2.TabIndex = 3;
            label2.Text = "輸入舊密碼";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft JhengHei UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label3.Location = new Point(16, 136);
            label3.Name = "label3";
            label3.Size = new Size(128, 29);
            label3.TabIndex = 5;
            label3.Text = "輸入新密碼";
            // 
            // txtNewPassword
            // 
            txtNewPassword.Location = new Point(144, 136);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.PasswordChar = '●';
            txtNewPassword.Size = new Size(125, 27);
            txtNewPassword.TabIndex = 4;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(176, 256);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(94, 29);
            btnSubmit.TabIndex = 6;
            btnSubmit.Text = "送出";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft JhengHei UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label4.Location = new Point(16, 184);
            label4.Name = "label4";
            label4.Size = new Size(128, 29);
            label4.TabIndex = 8;
            label4.Text = "確認新密碼";
            // 
            // txtNewPasswordConfirm
            // 
            txtNewPasswordConfirm.Location = new Point(144, 184);
            txtNewPasswordConfirm.Name = "txtNewPasswordConfirm";
            txtNewPasswordConfirm.PasswordChar = '●';
            txtNewPasswordConfirm.Size = new Size(125, 27);
            txtNewPasswordConfirm.TabIndex = 7;
            // 
            // FrmPasswordSetting
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(288, 312);
            Controls.Add(label4);
            Controls.Add(txtNewPasswordConfirm);
            Controls.Add(btnSubmit);
            Controls.Add(label3);
            Controls.Add(txtNewPassword);
            Controls.Add(label2);
            Controls.Add(lblAccount);
            Controls.Add(label1);
            Controls.Add(txtPassword);
            Name = "FrmPasswordSetting";
            Text = "變更密碼";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Common.CommonTextBox txtPassword;
        private Label label1;
        private Label lblAccount;
        private Label label2;
        private Label label3;
        private Common.CommonTextBox txtNewPassword;
        private Button btnSubmit;
        private Label label4;
        private Common.CommonTextBox txtNewPasswordConfirm;
    }
}