namespace DigiERP
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            panel1 = new Panel();
            label1 = new Label();
            lblUser = new Label();
            lblUserName = new Label();
            label2 = new Label();
            lblLoginTime = new Label();
            btnClose = new Button();
            btnPasswordManage = new Button();
            btnPassworkChange = new Button();
            panelSettings = new Panel();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(1, 0, 0, 0);
            panel1.Cursor = Cursors.Hand;
            panel1.Location = new Point(308, 93);
            panel1.Margin = new Padding(2, 2, 2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(196, 178);
            panel1.TabIndex = 0;
            panel1.Click += panel1_Click;
            panel1.DoubleClick += panel1_DoubleClick;
            panel1.MouseLeave += panel1_MouseLeave;
            panel1.MouseMove += panel1_MouseMove;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft JhengHei UI", 14F);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(33, 13);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(85, 30);
            label1.TabIndex = 1;
            label1.Text = "登錄者";
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.BackColor = Color.Transparent;
            lblUser.Font = new Font("Microsoft JhengHei UI", 14F);
            lblUser.ForeColor = Color.Yellow;
            lblUser.Location = new Point(131, 13);
            lblUser.Margin = new Padding(2, 0, 2, 0);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(92, 30);
            lblUser.TabIndex = 2;
            lblUser.Text = "lblUser";
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.BackColor = Color.Transparent;
            lblUserName.Font = new Font("Microsoft JhengHei UI", 14F);
            lblUserName.ForeColor = SystemColors.ButtonHighlight;
            lblUserName.Location = new Point(229, 13);
            lblUserName.Margin = new Padding(2, 0, 2, 0);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(160, 30);
            lblUserName.TabIndex = 3;
            lblUserName.Text = "lblUserName";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Microsoft JhengHei UI", 14F);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(406, 13);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(109, 30);
            label2.TabIndex = 4;
            label2.Text = "登錄時間";
            // 
            // lblLoginTime
            // 
            lblLoginTime.AutoSize = true;
            lblLoginTime.BackColor = Color.Transparent;
            lblLoginTime.Font = new Font("Microsoft JhengHei UI", 14F);
            lblLoginTime.ForeColor = SystemColors.ButtonHighlight;
            lblLoginTime.Location = new Point(524, 13);
            lblLoginTime.Margin = new Padding(2, 0, 2, 0);
            lblLoginTime.Name = "lblLoginTime";
            lblLoginTime.Size = new Size(158, 30);
            lblLoginTime.TabIndex = 5;
            lblLoginTime.Text = "lblLoginTime";
            // 
            // btnClose
            // 
            btnClose.Location = new Point(1021, 20);
            btnClose.Margin = new Padding(2, 2, 2, 2);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(33, 28);
            btnClose.TabIndex = 6;
            btnClose.Text = "X";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnPasswordManage
            // 
            btnPasswordManage.ForeColor = Color.Blue;
            btnPasswordManage.Location = new Point(766, 20);
            btnPasswordManage.Margin = new Padding(2, 2, 2, 2);
            btnPasswordManage.Name = "btnPasswordManage";
            btnPasswordManage.Size = new Size(92, 28);
            btnPasswordManage.TabIndex = 7;
            btnPasswordManage.Text = "密碼管理";
            btnPasswordManage.UseVisualStyleBackColor = true;
            // 
            // btnPassworkChange
            // 
            btnPassworkChange.ForeColor = Color.Red;
            btnPassworkChange.Location = new Point(877, 20);
            btnPassworkChange.Margin = new Padding(2, 2, 2, 2);
            btnPassworkChange.Name = "btnPassworkChange";
            btnPassworkChange.Size = new Size(92, 28);
            btnPassworkChange.TabIndex = 8;
            btnPassworkChange.Text = "密碼變更";
            btnPassworkChange.UseVisualStyleBackColor = true;
            btnPassworkChange.Click += btnPassworkChange_Click;
            // 
            // panelSettings
            // 
            panelSettings.BackColor = Color.FromArgb(1, 0, 0, 0);
            panelSettings.Cursor = Cursors.Hand;
            panelSettings.Location = new Point(812, 317);
            panelSettings.Margin = new Padding(2, 2, 2, 2);
            panelSettings.Name = "panelSettings";
            panelSettings.Size = new Size(196, 178);
            panelSettings.TabIndex = 9;
            panelSettings.Click += panelSettings_Click;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1073, 573);
            ControlBox = false;
            Controls.Add(panelSettings);
            Controls.Add(btnPassworkChange);
            Controls.Add(btnPasswordManage);
            Controls.Add(btnClose);
            Controls.Add(lblLoginTime);
            Controls.Add(label2);
            Controls.Add(lblUserName);
            Controls.Add(lblUser);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2, 2, 2, 2);
            Name = "FrmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmMain";
            Resize += FrmMain_Resize;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label lblUser;
        private Label lblUserName;
        private Label label2;
        private Label lblLoginTime;
        private Button btnClose;
        private Button btnPasswordManage;
        private Button btnPassworkChange;
        private Panel panelSettings;
    }
}