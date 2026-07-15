using System.Drawing;
using System.Windows.Forms;

namespace DigiERP.UserControl.Objective.Bank
{
    partial class BankMonthSummaryBalance
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BankMonthSummaryBalance));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            lblTitle = new Label();
            btnConfirm = new Button();
            btnCancel = new Button();
            btnClose = new Button();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            colYearMonth = new DataGridViewTextBoxColumn();
            colBankCode = new DataGridViewTextBoxColumn();
            colBankName = new DataGridViewTextBoxColumn();
            colAccountNo = new DataGridViewTextBoxColumn();
            colCurrency = new DataGridViewTextBoxColumn();
            colDepositSum = new DataGridViewTextBoxColumn();
            colExpenseSum = new DataGridViewTextBoxColumn();
            colCount = new DataGridViewTextBoxColumn();
            colBalance = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Cornsilk;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(lblTitle);
            panel1.Controls.Add(btnConfirm);
            panel1.Controls.Add(btnCancel);
            panel1.Controls.Add(btnClose);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1300, 56);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(4, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(48, 48);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("微軟正黑體", 14F, FontStyle.Bold);
            lblTitle.Location = new Point(60, 16);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(124, 24);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "銀行月底餘額";
            // 
            // btnConfirm
            // 
            btnConfirm.BackColor = Color.SeaGreen;
            btnConfirm.FlatStyle = FlatStyle.Flat;
            btnConfirm.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            btnConfirm.ForeColor = Color.White;
            btnConfirm.Location = new Point(340, 12);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(100, 32);
            btnConfirm.TabIndex = 1;
            btnConfirm.Text = "月結確定";
            btnConfirm.UseVisualStyleBackColor = false;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.CadetBlue;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(450, 12);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(100, 32);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "月結取消";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Gainsboro;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            btnClose.Location = new Point(1180, 12);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(100, 32);
            btnClose.TabIndex = 3;
            btnClose.Text = "離開";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridView1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 56);
            panel2.Name = "panel2";
            panel2.Size = new Size(1300, 500);
            panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colYearMonth, colBankCode, colBankName, colAccountNo, colCurrency, colDepositSum, colExpenseSum, colCount, colBalance });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Font = new Font("微軟正黑體", 9F);
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 26;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1300, 500);
            dataGridView1.TabIndex = 0;
            // 
            // colYearMonth
            // 
            colYearMonth.HeaderText = "日期/月";
            colYearMonth.Name = "colYearMonth";
            colYearMonth.ReadOnly = true;
            // 
            // colBankCode
            // 
            colBankCode.HeaderText = "銀存編碼";
            colBankCode.Name = "colBankCode";
            colBankCode.ReadOnly = true;
            // 
            // colBankName
            // 
            colBankName.FillWeight = 180F;
            colBankName.HeaderText = "銀行名稱";
            colBankName.Name = "colBankName";
            colBankName.ReadOnly = true;
            // 
            // colAccountNo
            // 
            colAccountNo.FillWeight = 150F;
            colAccountNo.HeaderText = "帳號";
            colAccountNo.Name = "colAccountNo";
            colAccountNo.ReadOnly = true;
            // 
            // colCurrency
            // 
            colCurrency.HeaderText = "幣別";
            colCurrency.Name = "colCurrency";
            colCurrency.ReadOnly = true;
            // 
            // colDepositSum
            // 
            colDepositSum.HeaderText = "存入總計";
            colDepositSum.Name = "colDepositSum";
            colDepositSum.ReadOnly = true;
            // 
            // colExpenseSum
            // 
            colExpenseSum.HeaderText = "支出總計";
            colExpenseSum.Name = "colExpenseSum";
            colExpenseSum.ReadOnly = true;
            // 
            // colCount
            // 
            colCount.HeaderText = "筆數";
            colCount.Name = "colCount";
            colCount.ReadOnly = true;
            // 
            // colBalance
            // 
            colBalance.HeaderText = "餘額";
            colBalance.Name = "colBalance";
            colBalance.ReadOnly = true;
            // 
            // BankMonthSummaryBalance
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1300, 556);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("微軟正黑體", 10F);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "BankMonthSummaryBalance";
            StartPosition = FormStartPosition.CenterParent;
            Text = "銀行月底餘額";
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
        private Button btnConfirm;
        private Button btnCancel;
        private Button btnClose;
        private Panel panel2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn colYearMonth;
        private DataGridViewTextBoxColumn colBankCode;
        private DataGridViewTextBoxColumn colBankName;
        private DataGridViewTextBoxColumn colAccountNo;
        private DataGridViewTextBoxColumn colCurrency;
        private DataGridViewTextBoxColumn colDepositSum;
        private DataGridViewTextBoxColumn colExpenseSum;
        private DataGridViewTextBoxColumn colCount;
        private DataGridViewTextBoxColumn colBalance;
    }
}
