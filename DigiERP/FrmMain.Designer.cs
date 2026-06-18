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
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(1, 0, 0, 0);
            panel1.Cursor = Cursors.Hand;
            panel1.Location = new Point(240, 73);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(152, 141);
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
            label1.Location = new Point(26, 10);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(67, 24);
            label1.TabIndex = 1;
            label1.Text = "登錄者";
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.BackColor = Color.Transparent;
            lblUser.Font = new Font("Microsoft JhengHei UI", 14F);
            lblUser.ForeColor = Color.Yellow;
            lblUser.Location = new Point(102, 10);
            lblUser.Margin = new Padding(2, 0, 2, 0);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(73, 24);
            lblUser.TabIndex = 2;
            lblUser.Text = "lblUser";
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.BackColor = Color.Transparent;
            lblUserName.Font = new Font("Microsoft JhengHei UI", 14F);
            lblUserName.ForeColor = SystemColors.ButtonHighlight;
            lblUserName.Location = new Point(178, 10);
            lblUserName.Margin = new Padding(2, 0, 2, 0);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(127, 24);
            lblUserName.TabIndex = 3;
            lblUserName.Text = "lblUserName";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Microsoft JhengHei UI", 14F);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(316, 10);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(86, 24);
            label2.TabIndex = 4;
            label2.Text = "登錄時間";
            // 
            // lblLoginTime
            // 
            lblLoginTime.AutoSize = true;
            lblLoginTime.BackColor = Color.Transparent;
            lblLoginTime.Font = new Font("Microsoft JhengHei UI", 14F);
            lblLoginTime.ForeColor = SystemColors.ButtonHighlight;
            lblLoginTime.Location = new Point(408, 10);
            lblLoginTime.Margin = new Padding(2, 0, 2, 0);
            lblLoginTime.Name = "lblLoginTime";
            lblLoginTime.Size = new Size(128, 24);
            lblLoginTime.TabIndex = 5;
            lblLoginTime.Text = "lblLoginTime";
            // 
            // btnClose
            // 
            btnClose.Location = new Point(794, 16);
            btnClose.Margin = new Padding(2);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(26, 22);
            btnClose.TabIndex = 6;
            btnClose.Text = "X";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnPasswordManage
            // 
            btnPasswordManage.ForeColor = Color.Blue;
            btnPasswordManage.Location = new Point(596, 16);
            btnPasswordManage.Margin = new Padding(2);
            btnPasswordManage.Name = "btnPasswordManage";
            btnPasswordManage.Size = new Size(72, 22);
            btnPasswordManage.TabIndex = 7;
            btnPasswordManage.Text = "密碼管理";
            btnPasswordManage.UseVisualStyleBackColor = true;
            btnPasswordManage.Click += btnPasswordManage_Click;
            // 
            // btnPassworkChange
            // 
            btnPassworkChange.ForeColor = Color.Red;
            btnPassworkChange.Location = new Point(682, 16);
            btnPassworkChange.Margin = new Padding(2);
            btnPassworkChange.Name = "btnPassworkChange";
            btnPassworkChange.Size = new Size(72, 22);
            btnPassworkChange.TabIndex = 8;
            btnPassworkChange.Text = "密碼變更";
            btnPassworkChange.UseVisualStyleBackColor = true;
            btnPassworkChange.Click += btnPassworkChange_Click;
            // 
            // panel2
            // 
            panel2.BackgroundImage = Properties.Resources._2026_06_16_09_39_51;
            panel2.BackgroundImageLayout = ImageLayout.Zoom;
            panel2.Location = new Point(436, 60);
            panel2.Name = "panel2";
            panel2.Size = new Size(152, 160);
            panel2.TabIndex = 9;
            panel2.Click += panel2_Click;
            panel2.MouseEnter += panel2_MouseEnter;
            panel2.MouseLeave += panel2_MouseLeave;
            panel2.MouseMove += panel2_MouseMove;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(436, 244);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(156, 160);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            pictureBox1.MouseEnter += pictureBox1_MouseEnter;
            pictureBox1.MouseLeave += pictureBox1_MouseLeave;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Gold;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(636, 244);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(140, 156);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            pictureBox2.MouseEnter += pictureBox2_MouseEnter;
            pictureBox2.MouseLeave += pictureBox2_MouseLeave;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(835, 452);
            ControlBox = false;
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(panel2);
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
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "FrmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmMain";
            Resize += FrmMain_Resize;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
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
        private Panel panel2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}