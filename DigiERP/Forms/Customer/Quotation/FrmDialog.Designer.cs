namespace DigiERP.Forms.Customer.Quotation
{
    partial class FrmDialog
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
            txtQUONO = new Common.CommonTextBox();
            txtCustNo = new Common.CommonTextBox();
            label2 = new Label();
            label3 = new Label();
            txtCustName = new Common.CommonTextBox();
            label4 = new Label();
            txtComment = new Common.CommonTextBox();
            btnSave = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label1.Location = new Point(24, 16);
            label1.Name = "label1";
            label1.Size = new Size(48, 24);
            label1.TabIndex = 0;
            label1.Text = "單號";
            // 
            // txtQUONO
            // 
            txtQUONO.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            txtQUONO.Location = new Point(80, 12);
            txtQUONO.Name = "txtQUONO";
            txtQUONO.Size = new Size(160, 32);
            txtQUONO.TabIndex = 1;
            // 
            // txtCustNo
            // 
            txtCustNo.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            txtCustNo.Location = new Point(344, 12);
            txtCustNo.Name = "txtCustNo";
            txtCustNo.Size = new Size(160, 32);
            txtCustNo.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label2.Location = new Point(288, 16);
            label2.Name = "label2";
            label2.Size = new Size(48, 24);
            label2.TabIndex = 2;
            label2.Text = "客戶";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label3.Location = new Point(24, 56);
            label3.Name = "label3";
            label3.Size = new Size(136, 24);
            label3.TabIndex = 4;
            label3.Text = "備註(補充說明)";
            // 
            // txtCustName
            // 
            txtCustName.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            txtCustName.Location = new Point(344, 52);
            txtCustName.Name = "txtCustName";
            txtCustName.Size = new Size(320, 32);
            txtCustName.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label4.Location = new Point(288, 56);
            label4.Name = "label4";
            label4.Size = new Size(48, 24);
            label4.TabIndex = 5;
            label4.Text = "名稱";
            // 
            // txtComment
            // 
            txtComment.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            txtComment.Location = new Point(32, 96);
            txtComment.Multiline = true;
            txtComment.Name = "txtComment";
            txtComment.Size = new Size(632, 304);
            txtComment.TabIndex = 7;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(512, 16);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(64, 23);
            btnSave.TabIndex = 8;
            btnSave.Text = "儲存";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // button1
            // 
            button1.Location = new Point(584, 16);
            button1.Name = "button1";
            button1.Size = new Size(64, 23);
            button1.TabIndex = 9;
            button1.Text = "關閉";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // FrmDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(712, 420);
            Controls.Add(button1);
            Controls.Add(btnSave);
            Controls.Add(txtComment);
            Controls.Add(txtCustName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtCustNo);
            Controls.Add(label2);
            Controls.Add(txtQUONO);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "FrmDialog";
            Text = "FrmDialog";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Common.CommonTextBox txtQUONO;
        private Common.CommonTextBox txtCustNo;
        private Label label2;
        private Label label3;
        private Common.CommonTextBox txtCustName;
        private Label label4;
        private Common.CommonTextBox txtComment;
        private Button btnSave;
        private Button button1;
    }
}