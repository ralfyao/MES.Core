using System.Drawing;
using System.Windows.Forms;

namespace DigiERP.UserControl.Inventory.StockInCert
{
    partial class StockInCertControl
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
            btnOpen = new Button();
            btnClosed = new Button();
            btnAdd = new Button();
            btnExit = new Button();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            colNo = new DataGridViewTextBoxColumn();
            colDate = new DataGridViewTextBoxColumn();
            colSupplierNo = new DataGridViewTextBoxColumn();
            colSupplierName = new DataGridViewTextBoxColumn();
            colCurrency = new DataGridViewTextBoxColumn();
            colCategory = new DataGridViewTextBoxColumn();
            colCertDate = new DataGridViewTextBoxColumn();
            colInvoiceNo = new DataGridViewTextBoxColumn();
            colCertType = new DataGridViewTextBoxColumn();
            colUntaxedAmt = new DataGridViewTextBoxColumn();
            colTaxAmt = new DataGridViewTextBoxColumn();
            colPayableTotal = new DataGridViewTextBoxColumn();
            colVoucher = new DataGridViewTextBoxColumn();
            colClosed = new DataGridViewCheckBoxColumn();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Cornsilk;
            panel1.Controls.Add(lblTitle);
            panel1.Controls.Add(btnOpen);
            panel1.Controls.Add(btnClosed);
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(btnExit);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1450, 64);
            panel1.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("微軟正黑體", 14F, FontStyle.Bold);
            lblTitle.ForeColor = Color.Firebrick;
            lblTitle.Location = new Point(10, 18);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(227, 24);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "進項憑證沖銷總覽-未結案";
            // 
            // btnOpen
            // 
            btnOpen.BackColor = Color.SteelBlue;
            btnOpen.FlatStyle = FlatStyle.Flat;
            btnOpen.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            btnOpen.ForeColor = Color.White;
            btnOpen.Location = new Point(310, 14);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(100, 32);
            btnOpen.TabIndex = 1;
            btnOpen.Text = "未結案";
            btnOpen.UseVisualStyleBackColor = false;
            btnOpen.Click += btnOpen_Click;
            // 
            // btnClosed
            // 
            btnClosed.BackColor = Color.SeaGreen;
            btnClosed.FlatStyle = FlatStyle.Flat;
            btnClosed.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            btnClosed.ForeColor = Color.White;
            btnClosed.Location = new Point(420, 14);
            btnClosed.Name = "btnClosed";
            btnClosed.Size = new Size(100, 32);
            btnClosed.TabIndex = 2;
            btnClosed.Text = "已結案";
            btnClosed.UseVisualStyleBackColor = false;
            btnClosed.Click += btnClosed_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Gainsboro;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            btnAdd.Location = new Point(1250, 14);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(80, 32);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "新增";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Gainsboro;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            btnExit.Location = new Point(1340, 14);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(90, 32);
            btnExit.TabIndex = 4;
            btnExit.Text = "關閉";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Visible = false;
            btnExit.Click += btnExit_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridView1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 64);
            panel2.Name = "panel2";
            panel2.Size = new Size(1450, 600);
            panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colNo, colDate, colSupplierNo, colSupplierName, colCurrency, colCategory, colCertDate, colInvoiceNo, colCertType, colUntaxedAmt, colTaxAmt, colPayableTotal, colVoucher, colClosed });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Font = new Font("微軟正黑體", 10F);
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 26;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1450, 600);
            dataGridView1.TabIndex = 0;
            dataGridView1.VisibleChanged += dataGridView1_VisibleChanged;
            // 
            // colNo
            // 
            colNo.FillWeight = 90F;
            colNo.HeaderText = "單號";
            colNo.Name = "colNo";
            colNo.ReadOnly = true;
            // 
            // colDate
            // 
            colDate.FillWeight = 75F;
            colDate.HeaderText = "日期";
            colDate.Name = "colDate";
            colDate.ReadOnly = true;
            // 
            // colSupplierNo
            // 
            colSupplierNo.FillWeight = 80F;
            colSupplierNo.HeaderText = "廠商編號";
            colSupplierNo.Name = "colSupplierNo";
            colSupplierNo.ReadOnly = true;
            // 
            // colSupplierName
            // 
            colSupplierName.FillWeight = 160F;
            colSupplierName.HeaderText = "廠商名稱";
            colSupplierName.Name = "colSupplierName";
            colSupplierName.ReadOnly = true;
            // 
            // colCurrency
            // 
            colCurrency.FillWeight = 60F;
            colCurrency.HeaderText = "幣別";
            colCurrency.Name = "colCurrency";
            colCurrency.ReadOnly = true;
            // 
            // colCategory
            // 
            colCategory.FillWeight = 70F;
            colCategory.HeaderText = "類別";
            colCategory.Name = "colCategory";
            colCategory.ReadOnly = true;
            // 
            // colCertDate
            // 
            colCertDate.FillWeight = 90F;
            colCertDate.HeaderText = "憑證日期";
            colCertDate.Name = "colCertDate";
            colCertDate.ReadOnly = true;
            // 
            // colInvoiceNo
            // 
            colInvoiceNo.HeaderText = "發票號碼";
            colInvoiceNo.Name = "colInvoiceNo";
            colInvoiceNo.ReadOnly = true;
            // 
            // colCertType
            // 
            colCertType.FillWeight = 90F;
            colCertType.HeaderText = "憑證種類";
            colCertType.Name = "colCertType";
            colCertType.ReadOnly = true;
            // 
            // colUntaxedAmt
            // 
            colUntaxedAmt.FillWeight = 90F;
            colUntaxedAmt.HeaderText = "未稅金額";
            colUntaxedAmt.Name = "colUntaxedAmt";
            colUntaxedAmt.ReadOnly = true;
            // 
            // colTaxAmt
            // 
            colTaxAmt.FillWeight = 80F;
            colTaxAmt.HeaderText = "稅額";
            colTaxAmt.Name = "colTaxAmt";
            colTaxAmt.ReadOnly = true;
            // 
            // colPayableTotal
            // 
            colPayableTotal.FillWeight = 90F;
            colPayableTotal.HeaderText = "應付總額";
            colPayableTotal.Name = "colPayableTotal";
            colPayableTotal.ReadOnly = true;
            // 
            // colVoucher
            // 
            colVoucher.HeaderText = "傳票";
            colVoucher.Name = "colVoucher";
            colVoucher.ReadOnly = true;
            // 
            // colClosed
            // 
            colClosed.FillWeight = 50F;
            colClosed.HeaderText = "結案";
            colClosed.Name = "colClosed";
            colClosed.ReadOnly = true;
            // 
            // StockInCertControl
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("微軟正黑體", 10F);
            Margin = new Padding(4);
            Name = "StockInCertControl";
            Size = new Size(1450, 664);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblTitle;
        private Button btnOpen;
        private Button btnClosed;
        private Button btnAdd;
        private Button btnExit;
        private Panel panel2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn colNo;
        private DataGridViewTextBoxColumn colDate;
        private DataGridViewTextBoxColumn colSupplierNo;
        private DataGridViewTextBoxColumn colSupplierName;
        private DataGridViewTextBoxColumn colCurrency;
        private DataGridViewTextBoxColumn colCategory;
        private DataGridViewTextBoxColumn colCertDate;
        private DataGridViewTextBoxColumn colInvoiceNo;
        private DataGridViewTextBoxColumn colCertType;
        private DataGridViewTextBoxColumn colUntaxedAmt;
        private DataGridViewTextBoxColumn colTaxAmt;
        private DataGridViewTextBoxColumn colPayableTotal;
        private DataGridViewTextBoxColumn colVoucher;
        private DataGridViewCheckBoxColumn colClosed;
    }
}
