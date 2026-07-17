using System.Drawing;
using System.Windows.Forms;

namespace DigiERP.Forms.Accounting
{
    partial class FrmBill
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
            panel1 = new Panel();
            lblTitle = new Label();
            btnModify = new Button();
            btnConfirm = new Button();
            btnClose = new Button();
            panel2 = new Panel();
            lblPayDate = new Label();
            dtPayDate = new DateTimePicker();
            lblBillNo = new Label();
            txtBillNo = new TextBox();
            lblPayType = new Label();
            txtPayType = new TextBox();
            lblTarget = new Label();
            txtTarget = new TextBox();
            lblBankAccount = new Label();
            cboBankAccount = new ComboBox();
            lblIssueAccount = new Label();
            txtIssueAccount = new TextBox();
            lblCashDate = new Label();
            dtCashDate = new DateTimePicker();
            lblAmount = new Label();
            txtAmount = new TextBox();
            lblBillStatus = new Label();
            txtBillStatus = new TextBox();
            lblLinkNo = new Label();
            txtLinkNo = new TextBox();
            lblRemark = new Label();
            txtRemark = new TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(lblTitle);
            panel1.Controls.Add(btnModify);
            panel1.Controls.Add(btnConfirm);
            panel1.Controls.Add(btnClose);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(700, 44);
            panel1.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("微軟正黑體", 12F, FontStyle.Bold);
            lblTitle.Location = new Point(16, 10);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(42, 21);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "付票";
            // 
            // btnModify
            // 
            btnModify.BackColor = Color.Gainsboro;
            btnModify.FlatStyle = FlatStyle.Flat;
            btnModify.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            btnModify.Location = new Point(340, 8);
            btnModify.Name = "btnModify";
            btnModify.Size = new Size(90, 28);
            btnModify.TabIndex = 1;
            btnModify.Text = "修改";
            btnModify.UseVisualStyleBackColor = false;
            btnModify.Click += btnModify_Click;
            // 
            // btnConfirm
            // 
            btnConfirm.BackColor = Color.SeaGreen;
            btnConfirm.FlatStyle = FlatStyle.Flat;
            btnConfirm.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            btnConfirm.ForeColor = Color.White;
            btnConfirm.Location = new Point(440, 8);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(90, 28);
            btnConfirm.TabIndex = 2;
            btnConfirm.Text = "確定";
            btnConfirm.UseVisualStyleBackColor = false;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Gainsboro;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            btnClose.Location = new Point(540, 8);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(90, 28);
            btnClose.TabIndex = 3;
            btnClose.Text = "關閉";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Visible = false;
            btnClose.Click += btnClose_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(lblPayDate);
            panel2.Controls.Add(dtPayDate);
            panel2.Controls.Add(lblBillNo);
            panel2.Controls.Add(txtBillNo);
            panel2.Controls.Add(lblPayType);
            panel2.Controls.Add(txtPayType);
            panel2.Controls.Add(lblTarget);
            panel2.Controls.Add(txtTarget);
            panel2.Controls.Add(lblBankAccount);
            panel2.Controls.Add(cboBankAccount);
            panel2.Controls.Add(lblIssueAccount);
            panel2.Controls.Add(txtIssueAccount);
            panel2.Controls.Add(lblCashDate);
            panel2.Controls.Add(dtCashDate);
            panel2.Controls.Add(lblAmount);
            panel2.Controls.Add(txtAmount);
            panel2.Controls.Add(lblBillStatus);
            panel2.Controls.Add(txtBillStatus);
            panel2.Controls.Add(lblLinkNo);
            panel2.Controls.Add(txtLinkNo);
            panel2.Controls.Add(lblRemark);
            panel2.Controls.Add(txtRemark);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 44);
            panel2.Name = "panel2";
            panel2.Size = new Size(700, 256);
            panel2.TabIndex = 1;
            // 
            // lblPayDate
            // 
            lblPayDate.AutoSize = true;
            lblPayDate.Location = new Point(16, 16);
            lblPayDate.Name = "lblPayDate";
            lblPayDate.Size = new Size(64, 18);
            lblPayDate.TabIndex = 0;
            lblPayDate.Text = "付款日期";
            // 
            // dtPayDate
            // 
            dtPayDate.Format = DateTimePickerFormat.Short;
            dtPayDate.Location = new Point(96, 12);
            dtPayDate.Name = "dtPayDate";
            dtPayDate.Size = new Size(160, 25);
            dtPayDate.TabIndex = 1;
            // 
            // lblBillNo
            // 
            lblBillNo.AutoSize = true;
            lblBillNo.Location = new Point(360, 16);
            lblBillNo.Name = "lblBillNo";
            lblBillNo.Size = new Size(64, 18);
            lblBillNo.TabIndex = 2;
            lblBillNo.Text = "票據號碼";
            // 
            // txtBillNo
            // 
            txtBillNo.Location = new Point(440, 12);
            txtBillNo.Name = "txtBillNo";
            txtBillNo.Size = new Size(200, 25);
            txtBillNo.TabIndex = 3;
            // 
            // lblPayType
            // 
            lblPayType.AutoSize = true;
            lblPayType.Location = new Point(16, 56);
            lblPayType.Name = "lblPayType";
            lblPayType.Size = new Size(50, 18);
            lblPayType.TabIndex = 4;
            lblPayType.Text = "收付別";
            // 
            // txtPayType
            // 
            txtPayType.Location = new Point(96, 52);
            txtPayType.Name = "txtPayType";
            txtPayType.ReadOnly = true;
            txtPayType.Size = new Size(160, 25);
            txtPayType.TabIndex = 5;
            // 
            // lblTarget
            // 
            lblTarget.AutoSize = true;
            lblTarget.Location = new Point(360, 56);
            lblTarget.Name = "lblTarget";
            lblTarget.Size = new Size(64, 18);
            lblTarget.TabIndex = 6;
            lblTarget.Text = "付款對象";
            // 
            // txtTarget
            // 
            txtTarget.Location = new Point(440, 52);
            txtTarget.Name = "txtTarget";
            txtTarget.Size = new Size(200, 25);
            txtTarget.TabIndex = 7;
            // 
            // lblBankAccount
            // 
            lblBankAccount.AutoSize = true;
            lblBankAccount.Location = new Point(16, 96);
            lblBankAccount.Name = "lblBankAccount";
            lblBankAccount.Size = new Size(64, 18);
            lblBankAccount.TabIndex = 8;
            lblBankAccount.Text = "兌付帳戶";
            // 
            // cboBankAccount
            // 
            cboBankAccount.FormattingEnabled = true;
            cboBankAccount.Location = new Point(96, 92);
            cboBankAccount.Name = "cboBankAccount";
            cboBankAccount.Size = new Size(160, 25);
            cboBankAccount.TabIndex = 9;
            cboBankAccount.SelectedIndexChanged += cboBankAccount_SelectedIndexChanged;
            // 
            // lblIssueAccount
            // 
            lblIssueAccount.AutoSize = true;
            lblIssueAccount.Location = new Point(360, 96);
            lblIssueAccount.Name = "lblIssueAccount";
            lblIssueAccount.Size = new Size(64, 18);
            lblIssueAccount.TabIndex = 10;
            lblIssueAccount.Text = "開票帳號";
            // 
            // txtIssueAccount
            // 
            txtIssueAccount.BackColor = Color.LightYellow;
            txtIssueAccount.Location = new Point(440, 92);
            txtIssueAccount.Name = "txtIssueAccount";
            txtIssueAccount.ReadOnly = true;
            txtIssueAccount.Size = new Size(200, 25);
            txtIssueAccount.TabIndex = 11;
            // 
            // lblCashDate
            // 
            lblCashDate.AutoSize = true;
            lblCashDate.Location = new Point(16, 136);
            lblCashDate.Name = "lblCashDate";
            lblCashDate.Size = new Size(64, 18);
            lblCashDate.TabIndex = 12;
            lblCashDate.Text = "兌現日期";
            // 
            // dtCashDate
            // 
            dtCashDate.Checked = false;
            dtCashDate.Format = DateTimePickerFormat.Short;
            dtCashDate.Location = new Point(96, 132);
            dtCashDate.Name = "dtCashDate";
            dtCashDate.ShowCheckBox = true;
            dtCashDate.Size = new Size(160, 25);
            dtCashDate.TabIndex = 13;
            // 
            // lblAmount
            // 
            lblAmount.AutoSize = true;
            lblAmount.Location = new Point(360, 136);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(36, 18);
            lblAmount.TabIndex = 14;
            lblAmount.Text = "金額";
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(440, 132);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(200, 25);
            txtAmount.TabIndex = 15;
            // 
            // lblBillStatus
            // 
            lblBillStatus.AutoSize = true;
            lblBillStatus.Location = new Point(16, 176);
            lblBillStatus.Name = "lblBillStatus";
            lblBillStatus.Size = new Size(36, 18);
            lblBillStatus.TabIndex = 16;
            lblBillStatus.Text = "票況";
            // 
            // txtBillStatus
            // 
            txtBillStatus.Location = new Point(96, 172);
            txtBillStatus.Name = "txtBillStatus";
            txtBillStatus.ReadOnly = true;
            txtBillStatus.Size = new Size(160, 25);
            txtBillStatus.TabIndex = 17;
            // 
            // lblLinkNo
            // 
            lblLinkNo.AutoSize = true;
            lblLinkNo.Location = new Point(360, 176);
            lblLinkNo.Name = "lblLinkNo";
            lblLinkNo.Size = new Size(64, 18);
            lblLinkNo.TabIndex = 18;
            lblLinkNo.Text = "連結單號";
            // 
            // txtLinkNo
            // 
            txtLinkNo.Location = new Point(440, 172);
            txtLinkNo.Name = "txtLinkNo";
            txtLinkNo.ReadOnly = true;
            txtLinkNo.Size = new Size(200, 25);
            txtLinkNo.TabIndex = 19;
            // 
            // lblRemark
            // 
            lblRemark.AutoSize = true;
            lblRemark.Location = new Point(16, 216);
            lblRemark.Name = "lblRemark";
            lblRemark.Size = new Size(36, 18);
            lblRemark.TabIndex = 20;
            lblRemark.Text = "備註";
            // 
            // txtRemark
            // 
            txtRemark.Location = new Point(96, 212);
            txtRemark.Name = "txtRemark";
            txtRemark.Size = new Size(544, 25);
            txtRemark.TabIndex = 21;
            // 
            // FrmBill
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 300);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("微軟正黑體", 10F);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "FrmBill";
            StartPosition = FormStartPosition.CenterParent;
            Text = "付票";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblTitle;
        private Button btnModify;
        private Button btnConfirm;
        private Button btnClose;
        private Panel panel2;
        private Label lblPayDate;
        private DateTimePicker dtPayDate;
        private Label lblBillNo;
        private TextBox txtBillNo;
        private Label lblPayType;
        private TextBox txtPayType;
        private Label lblTarget;
        private TextBox txtTarget;
        private Label lblBankAccount;
        private ComboBox cboBankAccount;
        private Label lblIssueAccount;
        private TextBox txtIssueAccount;
        private Label lblCashDate;
        private DateTimePicker dtCashDate;
        private Label lblAmount;
        private TextBox txtAmount;
        private Label lblBillStatus;
        private TextBox txtBillStatus;
        private Label lblLinkNo;
        private TextBox txtLinkNo;
        private Label lblRemark;
        private TextBox txtRemark;
    }
}
