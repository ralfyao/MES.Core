namespace DigiERP
{
    partial class FrmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            label1 = new Label();
            txtAccount = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtPassword = new TextBox();
            button1 = new Button();
            button2 = new Button();
            close = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft JhengHei UI", 26F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 136);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(92, 16);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(229, 44);
            label1.TabIndex = 0;
            label1.Text = "企業管理系統";
            // 
            // txtAccount
            // 
            txtAccount.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            txtAccount.Location = new Point(143, 78);
            txtAccount.Margin = new Padding(2, 2, 2, 2);
            txtAccount.Name = "txtAccount";
            txtAccount.Size = new Size(164, 31);
            txtAccount.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft JhengHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label2.Location = new Point(81, 78);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(61, 30);
            label2.TabIndex = 2;
            label2.Text = "帳號";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft JhengHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label3.Location = new Point(81, 115);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(61, 30);
            label3.TabIndex = 4;
            label3.Text = "密碼";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            txtPassword.Location = new Point(143, 115);
            txtPassword.Margin = new Padding(2, 2, 2, 2);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '●';
            txtPassword.Size = new Size(164, 31);
            txtPassword.TabIndex = 3;
            txtPassword.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(127, 157);
            button1.Margin = new Padding(2, 2, 2, 2);
            button1.Name = "button1";
            button1.Size = new Size(71, 22);
            button1.TabIndex = 5;
            button1.Text = "登入";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(204, 157);
            button2.Margin = new Padding(2, 2, 2, 2);
            button2.Name = "button2";
            button2.Size = new Size(71, 22);
            button2.TabIndex = 6;
            button2.Text = "清空";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // close
            // 
            close.Location = new Point(361, 10);
            close.Margin = new Padding(2, 2, 2, 2);
            close.Name = "close";
            close.Size = new Size(25, 22);
            close.TabIndex = 7;
            close.Text = "X";
            close.UseVisualStyleBackColor = true;
            close.Click += close_Click;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(391, 209);
            ControlBox = false;
            Controls.Add(close);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(txtPassword);
            Controls.Add(label2);
            Controls.Add(txtAccount);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2, 2, 2, 2);
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "登入";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtAccount;
        private Label label2;
        private Label label3;
        private TextBox txtPassword;
        private Button button1;
        private Button button2;
        private Button close;
        private System.Windows.Forms.Timer timer1;
    }
}
