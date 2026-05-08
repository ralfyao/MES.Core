namespace DigiERP.Forms.Customer
{
    partial class FrmChangeCustName
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
            txtOriginalName = new TextBox();
            txtChangedName = new TextBox();
            label2 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label1.Location = new Point(21, 32);
            label1.Name = "label1";
            label1.Size = new Size(105, 24);
            label1.TabIndex = 0;
            label1.Text = "變更前名稱";
            // 
            // txtOriginalName
            // 
            txtOriginalName.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            txtOriginalName.Location = new Point(128, 29);
            txtOriginalName.Name = "txtOriginalName";
            txtOriginalName.ReadOnly = true;
            txtOriginalName.Size = new Size(192, 31);
            txtOriginalName.TabIndex = 1;
            // 
            // txtChangedName
            // 
            txtChangedName.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            txtChangedName.Location = new Point(128, 77);
            txtChangedName.Name = "txtChangedName";
            txtChangedName.Size = new Size(192, 31);
            txtChangedName.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label2.Location = new Point(22, 80);
            label2.Name = "label2";
            label2.Size = new Size(105, 24);
            label2.TabIndex = 2;
            label2.Text = "變更後名稱";
            // 
            // button1
            // 
            button1.Location = new Point(232, 120);
            button1.Name = "button1";
            button1.Size = new Size(88, 32);
            button1.TabIndex = 4;
            button1.Text = "送出";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // FrmChangeCustName
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(349, 168);
            Controls.Add(button1);
            Controls.Add(txtChangedName);
            Controls.Add(label2);
            Controls.Add(txtOriginalName);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "FrmChangeCustName";
            Text = "客戶全稱更名";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtOriginalName;
        private TextBox txtChangedName;
        private Label label2;
        private Button button1;
    }
}