using System.Drawing;
using System.Windows.Forms;

namespace DigiERP.UserControl.Objective.Bank
{
    partial class FrmBankLedgerDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBankLedgerDetail));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            lblTitle = new Label();
            dtYearMonth = new DateTimePicker();
            btnQueryMonth = new Button();
            btnThisMonth = new Button();
            btnLastMonth = new Button();
            btnOver60 = new Button();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            colBankCode = new DataGridViewTextBoxColumn();
            colDate = new DataGridViewTextBoxColumn();
            colSummary = new DataGridViewTextBoxColumn();
            colCurrency = new DataGridViewTextBoxColumn();
            colExpense = new DataGridViewTextBoxColumn();
            colDeposit = new DataGridViewTextBoxColumn();
            colLinkNo = new DataGridViewTextBoxColumn();
            colRemark = new DataGridViewTextBoxColumn();
            colTarget = new DataGridViewTextBoxColumn();
            panel3 = new Panel();
            lblExpenseSum = new Label();
            lblDepositSum = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.MistyRose;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(lblTitle);
            panel1.Controls.Add(dtYearMonth);
            panel1.Controls.Add(btnQueryMonth);
            panel1.Controls.Add(btnThisMonth);
            panel1.Controls.Add(btnLastMonth);
            panel1.Controls.Add(btnOver60);
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
            pictureBox1.TabIndex = 6;
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
            lblTitle.Text = "銀行存簿明細";
            // 
            // dtYearMonth
            // 
            dtYearMonth.CustomFormat = "yyyy/MM";
            dtYearMonth.Font = new Font("微軟正黑體", 10F);
            dtYearMonth.Format = DateTimePickerFormat.Custom;
            dtYearMonth.Location = new Point(320, 16);
            dtYearMonth.Name = "dtYearMonth";
            dtYearMonth.ShowUpDown = true;
            dtYearMonth.Size = new Size(110, 25);
            dtYearMonth.TabIndex = 1;
            // 
            // btnQueryMonth
            // 
            btnQueryMonth.BackColor = Color.SteelBlue;
            btnQueryMonth.FlatStyle = FlatStyle.Flat;
            btnQueryMonth.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            btnQueryMonth.ForeColor = Color.White;
            btnQueryMonth.Location = new Point(430, 12);
            btnQueryMonth.Name = "btnQueryMonth";
            btnQueryMonth.Size = new Size(120, 32);
            btnQueryMonth.TabIndex = 2;
            btnQueryMonth.Text = "指定月份查詢";
            btnQueryMonth.UseVisualStyleBackColor = false;
            btnQueryMonth.Click += btnQueryMonth_Click;
            // 
            // btnThisMonth
            // 
            btnThisMonth.BackColor = Color.Firebrick;
            btnThisMonth.FlatStyle = FlatStyle.Flat;
            btnThisMonth.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            btnThisMonth.ForeColor = Color.White;
            btnThisMonth.Location = new Point(570, 12);
            btnThisMonth.Name = "btnThisMonth";
            btnThisMonth.Size = new Size(100, 32);
            btnThisMonth.TabIndex = 3;
            btnThisMonth.Text = "本月份";
            btnThisMonth.UseVisualStyleBackColor = false;
            btnThisMonth.Click += btnThisMonth_Click;
            // 
            // btnLastMonth
            // 
            btnLastMonth.BackColor = Color.SeaGreen;
            btnLastMonth.FlatStyle = FlatStyle.Flat;
            btnLastMonth.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            btnLastMonth.ForeColor = Color.White;
            btnLastMonth.Location = new Point(680, 12);
            btnLastMonth.Name = "btnLastMonth";
            btnLastMonth.Size = new Size(100, 32);
            btnLastMonth.TabIndex = 4;
            btnLastMonth.Text = "上個月份";
            btnLastMonth.UseVisualStyleBackColor = false;
            btnLastMonth.Click += btnLastMonth_Click;
            // 
            // btnOver60
            // 
            btnOver60.BackColor = Color.DarkOrange;
            btnOver60.FlatStyle = FlatStyle.Flat;
            btnOver60.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            btnOver60.ForeColor = Color.White;
            btnOver60.Location = new Point(790, 12);
            btnOver60.Name = "btnOver60";
            btnOver60.Size = new Size(100, 32);
            btnOver60.TabIndex = 5;
            btnOver60.Text = "超過60天";
            btnOver60.UseVisualStyleBackColor = false;
            btnOver60.Click += btnOver60_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridView1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 56);
            panel2.Name = "panel2";
            panel2.Size = new Size(1300, 560);
            panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colBankCode, colDate, colSummary, colCurrency, colExpense, colDeposit, colLinkNo, colRemark, colTarget });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Font = new Font("微軟正黑體", 9F);
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 26;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1300, 560);
            dataGridView1.TabIndex = 0;
            // 
            // colBankCode
            // 
            colBankCode.HeaderText = "銀存編碼";
            colBankCode.Name = "colBankCode";
            colBankCode.ReadOnly = true;
            // 
            // colDate
            // 
            colDate.HeaderText = "日期";
            colDate.Name = "colDate";
            colDate.ReadOnly = true;
            // 
            // colSummary
            // 
            colSummary.FillWeight = 220F;
            colSummary.HeaderText = "摘要";
            colSummary.Name = "colSummary";
            colSummary.ReadOnly = true;
            // 
            // colCurrency
            // 
            colCurrency.HeaderText = "幣別";
            colCurrency.Name = "colCurrency";
            colCurrency.ReadOnly = true;
            // 
            // colExpense
            // 
            colExpense.HeaderText = "支出";
            colExpense.Name = "colExpense";
            colExpense.ReadOnly = true;
            // 
            // colDeposit
            // 
            colDeposit.HeaderText = "存入";
            colDeposit.Name = "colDeposit";
            colDeposit.ReadOnly = true;
            // 
            // colLinkNo
            // 
            colLinkNo.HeaderText = "連結單號";
            colLinkNo.Name = "colLinkNo";
            colLinkNo.ReadOnly = true;
            // 
            // colRemark
            // 
            colRemark.FillWeight = 150F;
            colRemark.HeaderText = "備註";
            colRemark.Name = "colRemark";
            colRemark.ReadOnly = true;
            // 
            // colTarget
            // 
            colTarget.HeaderText = "對象";
            colTarget.Name = "colTarget";
            colTarget.ReadOnly = true;
            // 
            // panel3
            // 
            panel3.BackColor = Color.WhiteSmoke;
            panel3.Controls.Add(lblExpenseSum);
            panel3.Controls.Add(lblDepositSum);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 616);
            panel3.Name = "panel3";
            panel3.Size = new Size(1300, 40);
            panel3.TabIndex = 2;
            // 
            // lblExpenseSum
            // 
            lblExpenseSum.BackColor = Color.White;
            lblExpenseSum.BorderStyle = BorderStyle.FixedSingle;
            lblExpenseSum.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            lblExpenseSum.Location = new Point(420, 6);
            lblExpenseSum.Name = "lblExpenseSum";
            lblExpenseSum.Size = new Size(140, 28);
            lblExpenseSum.TabIndex = 0;
            lblExpenseSum.Text = "0";
            lblExpenseSum.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblDepositSum
            // 
            lblDepositSum.BackColor = Color.White;
            lblDepositSum.BorderStyle = BorderStyle.FixedSingle;
            lblDepositSum.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            lblDepositSum.Location = new Point(580, 6);
            lblDepositSum.Name = "lblDepositSum";
            lblDepositSum.Size = new Size(140, 28);
            lblDepositSum.TabIndex = 1;
            lblDepositSum.Text = "0";
            lblDepositSum.TextAlign = ContentAlignment.MiddleRight;
            // 
            // FrmBankLedgerDetail
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1300, 656);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Font = new Font("微軟正黑體", 10F);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "FrmBankLedgerDetail";
            StartPosition = FormStartPosition.CenterParent;
            Text = "銀行存簿明細";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label lblTitle;
        private DateTimePicker dtYearMonth;
        private Button btnQueryMonth;
        private Button btnThisMonth;
        private Button btnLastMonth;
        private Button btnOver60;
        private Panel panel2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn colBankCode;
        private DataGridViewTextBoxColumn colDate;
        private DataGridViewTextBoxColumn colSummary;
        private DataGridViewTextBoxColumn colCurrency;
        private DataGridViewTextBoxColumn colExpense;
        private DataGridViewTextBoxColumn colDeposit;
        private DataGridViewTextBoxColumn colLinkNo;
        private DataGridViewTextBoxColumn colRemark;
        private DataGridViewTextBoxColumn colTarget;
        private Panel panel3;
        private Label lblExpenseSum;
        private Label lblDepositSum;
    }
}
