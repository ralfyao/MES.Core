using System.Drawing;
using System.Windows.Forms;

namespace DigiERP.UserControl.Objective.Bank
{
    partial class BankMaintainControl
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region 元件設計工具產生的程式碼

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BankMaintainControl));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            lblTitle = new Label();
            btnAdd = new Button();
            btnModify = new Button();
            btnSave = new Button();
            btnDetail = new Button();
            btnClose = new Button();
            panel2 = new Panel();
            lblBankCode = new Label();
            txtBankCode = new TextBox();
            lblBankName = new Label();
            txtBankName = new TextBox();
            lblBankFullName = new Label();
            txtBankFullName = new TextBox();
            lblBankAddress = new Label();
            txtBankAddress = new TextBox();
            lblBeneficiary = new Label();
            txtBeneficiary = new TextBox();
            lblAcctCode = new Label();
            txtAcctCode = new TextBox();
            lblAccountNo = new Label();
            txtAccountNo = new TextBox();
            lblSwiftCode = new Label();
            txtSwiftCode = new TextBox();
            lblContact = new Label();
            txtContact = new TextBox();
            lblPhone = new Label();
            txtPhone = new TextBox();
            lblExt = new Label();
            txtExt = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.MistyRose;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(lblTitle);
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(btnModify);
            panel1.Controls.Add(btnSave);
            panel1.Controls.Add(btnDetail);
            panel1.Controls.Add(btnClose);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1900, 56);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(4, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(48, 48);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("微軟正黑體", 14F, FontStyle.Bold);
            lblTitle.Location = new Point(60, 16);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(86, 24);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "銀行設定";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Gainsboro;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            btnAdd.Location = new Point(340, 12);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(100, 32);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "新增";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnModify
            // 
            btnModify.BackColor = Color.Gainsboro;
            btnModify.FlatStyle = FlatStyle.Flat;
            btnModify.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            btnModify.Location = new Point(450, 12);
            btnModify.Name = "btnModify";
            btnModify.Size = new Size(100, 32);
            btnModify.TabIndex = 2;
            btnModify.Text = "修改";
            btnModify.UseVisualStyleBackColor = false;
            btnModify.Click += btnModify_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Gainsboro;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            btnSave.Location = new Point(560, 12);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(100, 32);
            btnSave.TabIndex = 3;
            btnSave.Text = "儲存";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnDetail
            // 
            btnDetail.BackColor = Color.Gainsboro;
            btnDetail.FlatStyle = FlatStyle.Flat;
            btnDetail.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            btnDetail.Location = new Point(670, 12);
            btnDetail.Name = "btnDetail";
            btnDetail.Size = new Size(100, 32);
            btnDetail.TabIndex = 4;
            btnDetail.Text = "明細";
            btnDetail.UseVisualStyleBackColor = false;
            btnDetail.Click += btnDetail_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Gainsboro;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            btnClose.Location = new Point(780, 12);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(100, 32);
            btnClose.TabIndex = 5;
            btnClose.Text = "關閉";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(lblBankCode);
            panel2.Controls.Add(txtBankCode);
            panel2.Controls.Add(lblBankName);
            panel2.Controls.Add(txtBankName);
            panel2.Controls.Add(lblBankFullName);
            panel2.Controls.Add(txtBankFullName);
            panel2.Controls.Add(lblBankAddress);
            panel2.Controls.Add(txtBankAddress);
            panel2.Controls.Add(lblBeneficiary);
            panel2.Controls.Add(txtBeneficiary);
            panel2.Controls.Add(lblAcctCode);
            panel2.Controls.Add(txtAcctCode);
            panel2.Controls.Add(lblAccountNo);
            panel2.Controls.Add(txtAccountNo);
            panel2.Controls.Add(lblSwiftCode);
            panel2.Controls.Add(txtSwiftCode);
            panel2.Controls.Add(lblContact);
            panel2.Controls.Add(txtContact);
            panel2.Controls.Add(lblPhone);
            panel2.Controls.Add(txtPhone);
            panel2.Controls.Add(lblExt);
            panel2.Controls.Add(txtExt);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 56);
            panel2.Name = "panel2";
            panel2.Size = new Size(1900, 600);
            panel2.TabIndex = 1;
            // 
            // lblBankCode
            // 
            lblBankCode.AutoSize = true;
            lblBankCode.Location = new Point(16, 20);
            lblBankCode.Name = "lblBankCode";
            lblBankCode.Size = new Size(64, 18);
            lblBankCode.TabIndex = 0;
            lblBankCode.Text = "銀存代號";
            // 
            // txtBankCode
            // 
            txtBankCode.Location = new Point(96, 16);
            txtBankCode.Name = "txtBankCode";
            txtBankCode.Size = new Size(150, 25);
            txtBankCode.TabIndex = 1;
            // 
            // lblBankName
            // 
            lblBankName.AutoSize = true;
            lblBankName.Location = new Point(266, 20);
            lblBankName.Name = "lblBankName";
            lblBankName.Size = new Size(64, 18);
            lblBankName.TabIndex = 2;
            lblBankName.Text = "代號名稱";
            // 
            // txtBankName
            // 
            txtBankName.Location = new Point(346, 16);
            txtBankName.Name = "txtBankName";
            txtBankName.Size = new Size(300, 25);
            txtBankName.TabIndex = 3;
            // 
            // lblBankFullName
            // 
            lblBankFullName.AutoSize = true;
            lblBankFullName.Location = new Point(16, 56);
            lblBankFullName.Name = "lblBankFullName";
            lblBankFullName.Size = new Size(64, 18);
            lblBankFullName.TabIndex = 4;
            lblBankFullName.Text = "銀行全名";
            // 
            // txtBankFullName
            // 
            txtBankFullName.Location = new Point(96, 52);
            txtBankFullName.Name = "txtBankFullName";
            txtBankFullName.Size = new Size(700, 25);
            txtBankFullName.TabIndex = 5;
            // 
            // lblBankAddress
            // 
            lblBankAddress.AutoSize = true;
            lblBankAddress.Location = new Point(16, 92);
            lblBankAddress.Name = "lblBankAddress";
            lblBankAddress.Size = new Size(64, 18);
            lblBankAddress.TabIndex = 6;
            lblBankAddress.Text = "銀行地址";
            // 
            // txtBankAddress
            // 
            txtBankAddress.Location = new Point(96, 88);
            txtBankAddress.Name = "txtBankAddress";
            txtBankAddress.Size = new Size(700, 25);
            txtBankAddress.TabIndex = 7;
            // 
            // lblBeneficiary
            // 
            lblBeneficiary.AutoSize = true;
            lblBeneficiary.Location = new Point(16, 128);
            lblBeneficiary.Name = "lblBeneficiary";
            lblBeneficiary.Size = new Size(64, 18);
            lblBeneficiary.TabIndex = 8;
            lblBeneficiary.Text = "帳戶名稱";
            // 
            // txtBeneficiary
            // 
            txtBeneficiary.Location = new Point(96, 124);
            txtBeneficiary.Name = "txtBeneficiary";
            txtBeneficiary.Size = new Size(300, 25);
            txtBeneficiary.TabIndex = 9;
            // 
            // lblAcctCode
            // 
            lblAcctCode.AutoSize = true;
            lblAcctCode.Location = new Point(410, 128);
            lblAcctCode.Name = "lblAcctCode";
            lblAcctCode.Size = new Size(64, 18);
            lblAcctCode.TabIndex = 10;
            lblAcctCode.Text = "會科代碼";
            // 
            // txtAcctCode
            // 
            txtAcctCode.Location = new Point(490, 124);
            txtAcctCode.Name = "txtAcctCode";
            txtAcctCode.Size = new Size(150, 25);
            txtAcctCode.TabIndex = 11;
            // 
            // lblAccountNo
            // 
            lblAccountNo.AutoSize = true;
            lblAccountNo.Location = new Point(16, 164);
            lblAccountNo.Name = "lblAccountNo";
            lblAccountNo.Size = new Size(36, 18);
            lblAccountNo.TabIndex = 12;
            lblAccountNo.Text = "帳號";
            // 
            // txtAccountNo
            // 
            txtAccountNo.Location = new Point(96, 160);
            txtAccountNo.Name = "txtAccountNo";
            txtAccountNo.Size = new Size(300, 25);
            txtAccountNo.TabIndex = 13;
            // 
            // lblSwiftCode
            // 
            lblSwiftCode.AutoSize = true;
            lblSwiftCode.Location = new Point(410, 164);
            lblSwiftCode.Name = "lblSwiftCode";
            lblSwiftCode.Size = new Size(76, 18);
            lblSwiftCode.TabIndex = 14;
            lblSwiftCode.Text = "SwiftCode";
            // 
            // txtSwiftCode
            // 
            txtSwiftCode.Location = new Point(490, 160);
            txtSwiftCode.Name = "txtSwiftCode";
            txtSwiftCode.Size = new Size(150, 25);
            txtSwiftCode.TabIndex = 15;
            // 
            // lblContact
            // 
            lblContact.AutoSize = true;
            lblContact.Location = new Point(16, 200);
            lblContact.Name = "lblContact";
            lblContact.Size = new Size(64, 18);
            lblContact.TabIndex = 16;
            lblContact.Text = "聯絡窗口";
            // 
            // txtContact
            // 
            txtContact.Location = new Point(96, 196);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(200, 25);
            txtContact.TabIndex = 17;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(310, 200);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(36, 18);
            lblPhone.TabIndex = 18;
            lblPhone.Text = "電話";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(360, 196);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(180, 25);
            txtPhone.TabIndex = 19;
            // 
            // lblExt
            // 
            lblExt.AutoSize = true;
            lblExt.Location = new Point(556, 200);
            lblExt.Name = "lblExt";
            lblExt.Size = new Size(36, 18);
            lblExt.TabIndex = 20;
            lblExt.Text = "分機";
            // 
            // txtExt
            // 
            txtExt.Location = new Point(606, 196);
            txtExt.Name = "txtExt";
            txtExt.Size = new Size(100, 25);
            txtExt.TabIndex = 21;
            // 
            // BankMaintainControl
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("微軟正黑體", 10F);
            Margin = new Padding(4);
            Name = "BankMaintainControl";
            Size = new Size(1900, 656);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label lblTitle;
        private Button btnAdd;
        private Button btnModify;
        private Button btnSave;
        private Button btnDetail;
        private Button btnClose;
        private Panel panel2;
        private Label lblBankCode;
        private TextBox txtBankCode;
        private Label lblBankName;
        private TextBox txtBankName;
        private Label lblBankFullName;
        private TextBox txtBankFullName;
        private Label lblBankAddress;
        private TextBox txtBankAddress;
        private Label lblBeneficiary;
        private TextBox txtBeneficiary;
        private Label lblAcctCode;
        private TextBox txtAcctCode;
        private Label lblAccountNo;
        private TextBox txtAccountNo;
        private Label lblSwiftCode;
        private TextBox txtSwiftCode;
        private Label lblContact;
        private TextBox txtContact;
        private Label lblPhone;
        private TextBox txtPhone;
        private Label lblExt;
        private TextBox txtExt;
    }
}
