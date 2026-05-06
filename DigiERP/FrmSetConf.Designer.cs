namespace DigiERP
{
    partial class FrmSetConf
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSetConf));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtDBServer = new TextBox();
            txtDBName = new TextBox();
            txtUser = new TextBox();
            txtPassword = new TextBox();
            btnSubmit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(64, 56);
            label1.Name = "label1";
            label1.Size = new Size(99, 36);
            label1.TabIndex = 0;
            label1.Text = "伺服器";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(64, 128);
            label2.Name = "label2";
            label2.Size = new Size(155, 36);
            label2.TabIndex = 1;
            label2.Text = "資料庫名稱";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(64, 200);
            label3.Name = "label3";
            label3.Size = new Size(71, 36);
            label3.TabIndex = 2;
            label3.Text = "帳號";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(64, 256);
            label4.Name = "label4";
            label4.Size = new Size(71, 36);
            label4.TabIndex = 3;
            label4.Text = "密碼";
            // 
            // txtDBServer
            // 
            txtDBServer.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            txtDBServer.Location = new Point(248, 56);
            txtDBServer.Name = "txtDBServer";
            txtDBServer.Size = new Size(288, 43);
            txtDBServer.TabIndex = 4;
            // 
            // txtDBName
            // 
            txtDBName.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            txtDBName.Location = new Point(248, 120);
            txtDBName.Name = "txtDBName";
            txtDBName.Size = new Size(288, 43);
            txtDBName.TabIndex = 5;
            // 
            // txtUser
            // 
            txtUser.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            txtUser.Location = new Point(248, 192);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(288, 43);
            txtUser.TabIndex = 6;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            txtPassword.Location = new Point(248, 256);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(288, 43);
            txtPassword.TabIndex = 7;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(424, 312);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(112, 34);
            btnSubmit.TabIndex = 8;
            btnSubmit.Text = "送出";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // FrmSetConf
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(596, 356);
            Controls.Add(btnSubmit);
            Controls.Add(txtPassword);
            Controls.Add(txtUser);
            Controls.Add(txtDBName);
            Controls.Add(txtDBServer);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmSetConf";
            Text = "資料庫連線設定";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtDBServer;
        private TextBox txtDBName;
        private TextBox txtUser;
        private TextBox txtPassword;
        private Button btnSubmit;
    }
}