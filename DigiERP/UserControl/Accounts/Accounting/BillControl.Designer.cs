using System.Drawing;
using System.Windows.Forms;

namespace DigiERP.UserControl.Accounts.Accounting
{
    partial class BillControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BillControl));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            lblTitle = new Label();
            btnAdd = new Button();
            btnExit = new Button();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            colBillNo = new DataGridViewTextBoxColumn();
            colPayDate = new DataGridViewTextBoxColumn();
            colPayType = new DataGridViewTextBoxColumn();
            colTargetCode = new DataGridViewTextBoxColumn();
            colTargetName = new DataGridViewTextBoxColumn();
            colBankAccount = new DataGridViewTextBoxColumn();
            colCashDate = new DataGridViewTextBoxColumn();
            colBillStatus = new DataGridViewTextBoxColumn();
            colLinkNo = new DataGridViewTextBoxColumn();
            colAmount = new DataGridViewTextBoxColumn();
            colCollectDate = new DataGridViewTextBoxColumn();
            colVoucherNo = new DataGridViewTextBoxColumn();
            colTargetBank = new DataGridViewTextBoxColumn();
            colRemark = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Azure;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(lblTitle);
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(btnExit);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1467, 64);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(4, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(68, 56);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("微軟正黑體", 14F, FontStyle.Bold);
            lblTitle.ForeColor = Color.Firebrick;
            lblTitle.Location = new Point(80, 18);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(86, 24);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "票據異動";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Gainsboro;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            btnAdd.Location = new Point(1283, 14);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(80, 32);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "新增";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Gainsboro;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            btnExit.Location = new Point(1373, 14);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(80, 32);
            btnExit.TabIndex = 2;
            btnExit.Text = "關閉";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridView1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 64);
            panel2.Name = "panel2";
            panel2.Size = new Size(1467, 600);
            panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colBillNo, colPayDate, colPayType, colTargetCode, colTargetName, colBankAccount, colCashDate, colBillStatus, colLinkNo, colAmount, colCollectDate, colVoucherNo, colTargetBank, colRemark });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Font = new Font("微軟正黑體", 10F);
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 26;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1467, 600);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // colBillNo
            // 
            colBillNo.HeaderText = "票據號碼";
            colBillNo.Name = "colBillNo";
            colBillNo.ReadOnly = true;
            // 
            // colPayDate
            // 
            colPayDate.HeaderText = "收付日期";
            colPayDate.Name = "colPayDate";
            colPayDate.ReadOnly = true;
            // 
            // colPayType
            // 
            colPayType.HeaderText = "收付別";
            colPayType.Name = "colPayType";
            colPayType.ReadOnly = true;
            // 
            // colTargetCode
            // 
            colTargetCode.HeaderText = "對象";
            colTargetCode.Name = "colTargetCode";
            colTargetCode.ReadOnly = true;
            // 
            // colTargetName
            // 
            colTargetName.FillWeight = 150F;
            colTargetName.HeaderText = "對象";
            colTargetName.Name = "colTargetName";
            colTargetName.ReadOnly = true;
            // 
            // colBankAccount
            // 
            colBankAccount.HeaderText = "兌付帳戶";
            colBankAccount.Name = "colBankAccount";
            colBankAccount.ReadOnly = true;
            // 
            // colCashDate
            // 
            colCashDate.HeaderText = "兌現日期";
            colCashDate.Name = "colCashDate";
            colCashDate.ReadOnly = true;
            // 
            // colBillStatus
            // 
            colBillStatus.HeaderText = "票況";
            colBillStatus.Name = "colBillStatus";
            colBillStatus.ReadOnly = true;
            // 
            // colLinkNo
            // 
            colLinkNo.HeaderText = "連結單號";
            colLinkNo.Name = "colLinkNo";
            colLinkNo.ReadOnly = true;
            // 
            // colAmount
            // 
            colAmount.HeaderText = "金額";
            colAmount.Name = "colAmount";
            colAmount.ReadOnly = true;
            // 
            // colCollectDate
            // 
            colCollectDate.HeaderText = "託收日期";
            colCollectDate.Name = "colCollectDate";
            colCollectDate.ReadOnly = true;
            // 
            // colVoucherNo
            // 
            colVoucherNo.HeaderText = "傳票編號";
            colVoucherNo.Name = "colVoucherNo";
            colVoucherNo.ReadOnly = true;
            // 
            // colTargetBank
            // 
            colTargetBank.HeaderText = "對象銀行";
            colTargetBank.Name = "colTargetBank";
            colTargetBank.ReadOnly = true;
            // 
            // colRemark
            // 
            colRemark.FillWeight = 150F;
            colRemark.HeaderText = "備註";
            colRemark.Name = "colRemark";
            colRemark.ReadOnly = true;
            // 
            // BillControl
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("微軟正黑體", 10F);
            Margin = new Padding(4);
            Name = "BillControl";
            Size = new Size(1467, 664);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label lblTitle;
        private Button btnAdd;
        private Button btnExit;
        private Panel panel2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn colBillNo;
        private DataGridViewTextBoxColumn colPayDate;
        private DataGridViewTextBoxColumn colPayType;
        private DataGridViewTextBoxColumn colTargetCode;
        private DataGridViewTextBoxColumn colTargetName;
        private DataGridViewTextBoxColumn colBankAccount;
        private DataGridViewTextBoxColumn colCashDate;
        private DataGridViewTextBoxColumn colBillStatus;
        private DataGridViewTextBoxColumn colLinkNo;
        private DataGridViewTextBoxColumn colAmount;
        private DataGridViewTextBoxColumn colCollectDate;
        private DataGridViewTextBoxColumn colVoucherNo;
        private DataGridViewTextBoxColumn colTargetBank;
        private DataGridViewTextBoxColumn colRemark;
    }
}
