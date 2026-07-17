using System.Drawing;
using System.Windows.Forms;

namespace DigiERP.UserControl.Objective.Bank
{
    partial class FrmBankDeposit
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
            lblDate = new Label();
            dtDate = new DateTimePicker();
            lblTarget = new Label();
            txtTarget = new TextBox();
            lblBankAccount = new Label();
            cboBankAccount = new ComboBox();
            lblBankAccountNo = new Label();
            txtBankAccountNo = new TextBox();
            lblSummary = new Label();
            txtSummary = new TextBox();
            lblCurrency = new Label();
            txtCurrency = new TextBox();
            lblLinkNo = new Label();
            txtLinkNo = new TextBox();
            lblDeposit = new Label();
            txtDeposit = new TextBox();
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
            lblTitle.Size = new Size(58, 21);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "匯入款";
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
            panel2.Controls.Add(lblDate);
            panel2.Controls.Add(dtDate);
            panel2.Controls.Add(lblTarget);
            panel2.Controls.Add(txtTarget);
            panel2.Controls.Add(lblBankAccount);
            panel2.Controls.Add(cboBankAccount);
            panel2.Controls.Add(lblBankAccountNo);
            panel2.Controls.Add(txtBankAccountNo);
            panel2.Controls.Add(lblSummary);
            panel2.Controls.Add(txtSummary);
            panel2.Controls.Add(lblCurrency);
            panel2.Controls.Add(txtCurrency);
            panel2.Controls.Add(lblLinkNo);
            panel2.Controls.Add(txtLinkNo);
            panel2.Controls.Add(lblDeposit);
            panel2.Controls.Add(txtDeposit);
            panel2.Controls.Add(lblRemark);
            panel2.Controls.Add(txtRemark);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 44);
            panel2.Name = "panel2";
            panel2.Size = new Size(700, 216);
            panel2.TabIndex = 1;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Location = new Point(16, 16);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(64, 18);
            lblDate.TabIndex = 0;
            lblDate.Text = "收款日期";
            // 
            // dtDate
            // 
            dtDate.Format = DateTimePickerFormat.Short;
            dtDate.Location = new Point(96, 12);
            dtDate.Name = "dtDate";
            dtDate.Size = new Size(160, 25);
            dtDate.TabIndex = 1;
            // 
            // lblTarget
            // 
            lblTarget.AutoSize = true;
            lblTarget.Location = new Point(360, 16);
            lblTarget.Name = "lblTarget";
            lblTarget.Size = new Size(64, 18);
            lblTarget.TabIndex = 2;
            lblTarget.Text = "收款對象";
            // 
            // txtTarget
            // 
            txtTarget.Location = new Point(440, 12);
            txtTarget.Name = "txtTarget";
            txtTarget.Size = new Size(200, 25);
            txtTarget.TabIndex = 3;
            // 
            // lblBankAccount
            // 
            lblBankAccount.AutoSize = true;
            lblBankAccount.Location = new Point(16, 56);
            lblBankAccount.Name = "lblBankAccount";
            lblBankAccount.Size = new Size(64, 18);
            lblBankAccount.TabIndex = 4;
            lblBankAccount.Text = "兌收帳戶";
            // 
            // cboBankAccount
            // 
            cboBankAccount.FormattingEnabled = true;
            cboBankAccount.Location = new Point(96, 52);
            cboBankAccount.Name = "cboBankAccount";
            cboBankAccount.Size = new Size(160, 25);
            cboBankAccount.TabIndex = 5;
            cboBankAccount.SelectedIndexChanged += cboBankAccount_SelectedIndexChanged;
            // 
            // lblBankAccountNo
            // 
            lblBankAccountNo.AutoSize = true;
            lblBankAccountNo.Location = new Point(360, 56);
            lblBankAccountNo.Name = "lblBankAccountNo";
            lblBankAccountNo.Size = new Size(64, 18);
            lblBankAccountNo.TabIndex = 6;
            lblBankAccountNo.Text = "匯入帳號";
            // 
            // txtBankAccountNo
            // 
            txtBankAccountNo.BackColor = Color.LightYellow;
            txtBankAccountNo.Location = new Point(440, 52);
            txtBankAccountNo.Name = "txtBankAccountNo";
            txtBankAccountNo.ReadOnly = true;
            txtBankAccountNo.Size = new Size(200, 25);
            txtBankAccountNo.TabIndex = 7;
            // 
            // lblSummary
            // 
            lblSummary.AutoSize = true;
            lblSummary.Location = new Point(16, 96);
            lblSummary.Name = "lblSummary";
            lblSummary.Size = new Size(36, 18);
            lblSummary.TabIndex = 8;
            lblSummary.Text = "摘要";
            // 
            // txtSummary
            // 
            txtSummary.Location = new Point(96, 92);
            txtSummary.Name = "txtSummary";
            txtSummary.Size = new Size(160, 25);
            txtSummary.TabIndex = 9;
            // 
            // lblCurrency
            // 
            lblCurrency.AutoSize = true;
            lblCurrency.Location = new Point(360, 96);
            lblCurrency.Name = "lblCurrency";
            lblCurrency.Size = new Size(36, 18);
            lblCurrency.TabIndex = 10;
            lblCurrency.Text = "幣別";
            // 
            // txtCurrency
            // 
            txtCurrency.Location = new Point(440, 92);
            txtCurrency.Name = "txtCurrency";
            txtCurrency.Size = new Size(200, 25);
            txtCurrency.TabIndex = 11;
            // 
            // lblLinkNo
            // 
            lblLinkNo.AutoSize = true;
            lblLinkNo.Location = new Point(16, 136);
            lblLinkNo.Name = "lblLinkNo";
            lblLinkNo.Size = new Size(64, 18);
            lblLinkNo.TabIndex = 12;
            lblLinkNo.Text = "連結單號";
            // 
            // txtLinkNo
            // 
            txtLinkNo.Location = new Point(96, 132);
            txtLinkNo.Name = "txtLinkNo";
            txtLinkNo.ReadOnly = true;
            txtLinkNo.Size = new Size(160, 25);
            txtLinkNo.TabIndex = 13;
            // 
            // lblDeposit
            // 
            lblDeposit.AutoSize = true;
            lblDeposit.Location = new Point(360, 136);
            lblDeposit.Name = "lblDeposit";
            lblDeposit.Size = new Size(64, 18);
            lblDeposit.TabIndex = 14;
            lblDeposit.Text = "收入金額";
            // 
            // txtDeposit
            // 
            txtDeposit.Location = new Point(440, 132);
            txtDeposit.Name = "txtDeposit";
            txtDeposit.Size = new Size(200, 25);
            txtDeposit.TabIndex = 15;
            // 
            // lblRemark
            // 
            lblRemark.AutoSize = true;
            lblRemark.Location = new Point(16, 176);
            lblRemark.Name = "lblRemark";
            lblRemark.Size = new Size(36, 18);
            lblRemark.TabIndex = 16;
            lblRemark.Text = "備註";
            // 
            // txtRemark
            // 
            txtRemark.Location = new Point(96, 172);
            txtRemark.Name = "txtRemark";
            txtRemark.Size = new Size(544, 25);
            txtRemark.TabIndex = 17;
            // 
            // FrmBankDeposit
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 260);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("微軟正黑體", 10F);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "FrmBankDeposit";
            StartPosition = FormStartPosition.CenterParent;
            Text = "匯入款作業";
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
        private Label lblDate;
        private DateTimePicker dtDate;
        private Label lblTarget;
        private TextBox txtTarget;
        private Label lblBankAccount;
        private ComboBox cboBankAccount;
        private Label lblBankAccountNo;
        private TextBox txtBankAccountNo;
        private Label lblSummary;
        private TextBox txtSummary;
        private Label lblCurrency;
        private TextBox txtCurrency;
        private Label lblLinkNo;
        private TextBox txtLinkNo;
        private Label lblDeposit;
        private TextBox txtDeposit;
        private Label lblRemark;
        private TextBox txtRemark;
    }
}
