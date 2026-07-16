using System.Drawing;
using System.Windows.Forms;

namespace DigiERP.UserControl.Inventory.StockInCert
{
    partial class StockInCertMaintainControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockInCertMaintainControl));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            lblTitle = new Label();
            btnCashier = new Button();
            btnVoucherEntry = new Button();
            btnImportDetail = new Button();
            btnDelete = new Button();
            btnAdd = new Button();
            btnModify = new Button();
            btnSave = new Button();
            btnVerify = new Button();
            btnCancelVerify = new Button();
            btnPrint = new Button();
            btnOverview = new Button();
            btnClose = new Button();
            panel2 = new Panel();
            lblDate = new Label();
            dtDate = new DateTimePicker();
            lblNo = new Label();
            txtNo = new TextBox();
            lblCategory = new Label();
            cboCategory = new ComboBox();
            lblCertType = new Label();
            cboCertType = new ComboBox();
            lblPayDate = new Label();
            dtPayDate = new DateTimePicker();
            lblSupplierNo = new Label();
            txtSupplierNo = new TextBox();
            btnSelectSupplier = new Button();
            lblSupplierName = new Label();
            txtSupplierName = new TextBox();
            lblInvoiceNo = new Label();
            txtInvoiceNo = new TextBox();
            lblVoucher = new Label();
            txtVoucher = new TextBox();
            lblCurrency = new Label();
            cboCurrency = new ComboBox();
            lblExRate = new Label();
            txtExRate = new TextBox();
            lblRequester = new Label();
            txtRequester = new TextBox();
            lblBankAmt = new Label();
            txtBankAmt = new TextBox();
            lblCheckAmt = new Label();
            txtCheckAmt = new TextBox();
            lblPayTotal = new Label();
            txtPayTotal = new TextBox();
            lblClosed = new Label();
            chkClosed = new CheckBox();
            btnSingleClose = new Button();
            lblRemark = new Label();
            txtRemark = new TextBox();
            panel3 = new Panel();
            dataGridView1 = new DataGridView();
            colSource = new DataGridViewTextBoxColumn();
            colOffsetCode = new DataGridViewTextBoxColumn();
            colOrigAmt = new DataGridViewTextBoxColumn();
            colTwdAmt = new DataGridViewTextBoxColumn();
            colProject = new DataGridViewTextBoxColumn();
            colDesc = new DataGridViewTextBoxColumn();
            panel3b = new Panel();
            lblDetailTotal = new Label();
            txtDetailTotal = new TextBox();
            panel4 = new Panel();
            lblReviewerCap = new Label();
            txtReviewer = new TextBox();
            lblReviewDateCap = new Label();
            txtReviewDate = new TextBox();
            lblModifierCap = new Label();
            txtModifier = new TextBox();
            lblModifyDateCap = new Label();
            txtModifyDate = new TextBox();
            lblCreatorCap = new Label();
            txtCreator = new TextBox();
            lblCreateDateCap = new Label();
            txtCreateDate = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel3b.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Honeydew;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(lblTitle);
            panel1.Controls.Add(btnCashier);
            panel1.Controls.Add(btnVoucherEntry);
            panel1.Controls.Add(btnImportDetail);
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(btnModify);
            panel1.Controls.Add(btnSave);
            panel1.Controls.Add(btnVerify);
            panel1.Controls.Add(btnCancelVerify);
            panel1.Controls.Add(btnPrint);
            panel1.Controls.Add(btnOverview);
            panel1.Controls.Add(btnClose);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1650, 56);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(4, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(48, 48);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("微軟正黑體", 13F, FontStyle.Bold);
            lblTitle.ForeColor = Color.Firebrick;
            lblTitle.Location = new Point(60, 16);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(118, 23);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "進項憑證登載";
            // 
            // btnCashier
            // 
            btnCashier.BackColor = Color.SeaGreen;
            btnCashier.FlatStyle = FlatStyle.Flat;
            btnCashier.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            btnCashier.ForeColor = Color.White;
            btnCashier.Location = new Point(230, 12);
            btnCashier.Name = "btnCashier";
            btnCashier.Size = new Size(98, 32);
            btnCashier.TabIndex = 1;
            btnCashier.Text = "出納付款";
            btnCashier.UseVisualStyleBackColor = false;
            btnCashier.Click += btnCashier_Click;
            // 
            // btnVoucherEntry
            // 
            btnVoucherEntry.BackColor = Color.Gainsboro;
            btnVoucherEntry.FlatStyle = FlatStyle.Flat;
            btnVoucherEntry.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            btnVoucherEntry.Location = new Point(334, 12);
            btnVoucherEntry.Name = "btnVoucherEntry";
            btnVoucherEntry.Size = new Size(98, 32);
            btnVoucherEntry.TabIndex = 2;
            btnVoucherEntry.Text = "會計傳票";
            btnVoucherEntry.UseVisualStyleBackColor = false;
            btnVoucherEntry.Click += btnVoucherEntry_Click;
            // 
            // btnImportDetail
            // 
            btnImportDetail.BackColor = Color.CadetBlue;
            btnImportDetail.FlatStyle = FlatStyle.Flat;
            btnImportDetail.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            btnImportDetail.ForeColor = Color.White;
            btnImportDetail.Location = new Point(438, 12);
            btnImportDetail.Name = "btnImportDetail";
            btnImportDetail.Size = new Size(110, 32);
            btnImportDetail.TabIndex = 3;
            btnImportDetail.Text = "付款明細導入";
            btnImportDetail.UseVisualStyleBackColor = false;
            btnImportDetail.Click += btnImportDetail_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Firebrick;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(560, 12);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(98, 32);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "刪除紀錄";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Gainsboro;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            btnAdd.Location = new Point(664, 12);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(98, 32);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "新增";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnModify
            // 
            btnModify.BackColor = Color.Gainsboro;
            btnModify.FlatStyle = FlatStyle.Flat;
            btnModify.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            btnModify.Location = new Point(768, 12);
            btnModify.Name = "btnModify";
            btnModify.Size = new Size(98, 32);
            btnModify.TabIndex = 6;
            btnModify.Text = "修改";
            btnModify.UseVisualStyleBackColor = false;
            btnModify.Click += btnModify_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Gainsboro;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            btnSave.Location = new Point(872, 12);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(98, 32);
            btnSave.TabIndex = 7;
            btnSave.Text = "儲存";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnVerify
            // 
            btnVerify.BackColor = Color.Gainsboro;
            btnVerify.FlatStyle = FlatStyle.Flat;
            btnVerify.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            btnVerify.Location = new Point(976, 12);
            btnVerify.Name = "btnVerify";
            btnVerify.Size = new Size(98, 32);
            btnVerify.TabIndex = 8;
            btnVerify.Text = "覆核";
            btnVerify.UseVisualStyleBackColor = false;
            btnVerify.Click += btnVerify_Click;
            // 
            // btnCancelVerify
            // 
            btnCancelVerify.BackColor = Color.Gainsboro;
            btnCancelVerify.FlatStyle = FlatStyle.Flat;
            btnCancelVerify.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            btnCancelVerify.Location = new Point(1080, 12);
            btnCancelVerify.Name = "btnCancelVerify";
            btnCancelVerify.Size = new Size(98, 32);
            btnCancelVerify.TabIndex = 9;
            btnCancelVerify.Text = "取消覆核";
            btnCancelVerify.UseVisualStyleBackColor = false;
            btnCancelVerify.Click += btnCancelVerify_Click;
            // 
            // btnPrint
            // 
            btnPrint.BackColor = Color.Gainsboro;
            btnPrint.FlatStyle = FlatStyle.Flat;
            btnPrint.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            btnPrint.Location = new Point(1184, 12);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(98, 32);
            btnPrint.TabIndex = 10;
            btnPrint.Text = "列印";
            btnPrint.UseVisualStyleBackColor = false;
            btnPrint.Click += btnPrint_Click;
            // 
            // btnOverview
            // 
            btnOverview.BackColor = Color.Gainsboro;
            btnOverview.FlatStyle = FlatStyle.Flat;
            btnOverview.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            btnOverview.Location = new Point(1288, 12);
            btnOverview.Name = "btnOverview";
            btnOverview.Size = new Size(98, 32);
            btnOverview.TabIndex = 11;
            btnOverview.Text = "總覽";
            btnOverview.UseVisualStyleBackColor = false;
            btnOverview.Click += btnOverview_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Gainsboro;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            btnClose.Location = new Point(1392, 12);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(98, 32);
            btnClose.TabIndex = 12;
            btnClose.Text = "關閉";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Honeydew;
            panel2.Controls.Add(lblDate);
            panel2.Controls.Add(dtDate);
            panel2.Controls.Add(lblNo);
            panel2.Controls.Add(txtNo);
            panel2.Controls.Add(lblCategory);
            panel2.Controls.Add(cboCategory);
            panel2.Controls.Add(lblCertType);
            panel2.Controls.Add(cboCertType);
            panel2.Controls.Add(lblPayDate);
            panel2.Controls.Add(dtPayDate);
            panel2.Controls.Add(lblSupplierNo);
            panel2.Controls.Add(txtSupplierNo);
            panel2.Controls.Add(btnSelectSupplier);
            panel2.Controls.Add(lblSupplierName);
            panel2.Controls.Add(txtSupplierName);
            panel2.Controls.Add(lblInvoiceNo);
            panel2.Controls.Add(txtInvoiceNo);
            panel2.Controls.Add(lblVoucher);
            panel2.Controls.Add(txtVoucher);
            panel2.Controls.Add(lblCurrency);
            panel2.Controls.Add(cboCurrency);
            panel2.Controls.Add(lblExRate);
            panel2.Controls.Add(txtExRate);
            panel2.Controls.Add(lblRequester);
            panel2.Controls.Add(txtRequester);
            panel2.Controls.Add(lblBankAmt);
            panel2.Controls.Add(txtBankAmt);
            panel2.Controls.Add(lblCheckAmt);
            panel2.Controls.Add(txtCheckAmt);
            panel2.Controls.Add(lblPayTotal);
            panel2.Controls.Add(txtPayTotal);
            panel2.Controls.Add(lblClosed);
            panel2.Controls.Add(chkClosed);
            panel2.Controls.Add(btnSingleClose);
            panel2.Controls.Add(lblRemark);
            panel2.Controls.Add(txtRemark);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 56);
            panel2.Name = "panel2";
            panel2.Size = new Size(1650, 128);
            panel2.TabIndex = 1;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Location = new Point(8, 10);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(36, 18);
            lblDate.TabIndex = 0;
            lblDate.Text = "日期";
            // 
            // dtDate
            // 
            dtDate.Enabled = false;
            dtDate.Format = DateTimePickerFormat.Short;
            dtDate.Location = new Point(62, 6);
            dtDate.Name = "dtDate";
            dtDate.Size = new Size(142, 25);
            dtDate.TabIndex = 1;
            // 
            // lblNo
            // 
            lblNo.AutoSize = true;
            lblNo.Location = new Point(214, 10);
            lblNo.Name = "lblNo";
            lblNo.Size = new Size(36, 18);
            lblNo.TabIndex = 2;
            lblNo.Text = "單號";
            // 
            // txtNo
            // 
            txtNo.Location = new Point(268, 6);
            txtNo.Name = "txtNo";
            txtNo.ReadOnly = true;
            txtNo.Size = new Size(200, 25);
            txtNo.TabIndex = 3;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(476, 10);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(64, 18);
            lblCategory.TabIndex = 4;
            lblCategory.Text = "付款類別";
            // 
            // cboCategory
            // 
            cboCategory.FormattingEnabled = true;
            cboCategory.Items.AddRange(new object[] { "進貨驗收", "委外加工", "總務支出", "採購預付", "其他暫付" });
            cboCategory.Location = new Point(552, 6);
            cboCategory.Name = "cboCategory";
            cboCategory.Size = new Size(120, 25);
            cboCategory.TabIndex = 5;
            // 
            // lblCertType
            // 
            lblCertType.AutoSize = true;
            lblCertType.Location = new Point(690, 10);
            lblCertType.Name = "lblCertType";
            lblCertType.Size = new Size(64, 18);
            lblCertType.TabIndex = 6;
            lblCertType.Text = "憑證種類";
            // 
            // cboCertType
            // 
            cboCertType.FormattingEnabled = true;
            cboCertType.Location = new Point(764, 6);
            cboCertType.Name = "cboCertType";
            cboCertType.Size = new Size(84, 25);
            cboCertType.TabIndex = 7;
            // 
            // lblPayDate
            // 
            lblPayDate.AutoSize = true;
            lblPayDate.Location = new Point(866, 10);
            lblPayDate.Name = "lblPayDate";
            lblPayDate.Size = new Size(64, 18);
            lblPayDate.TabIndex = 8;
            lblPayDate.Text = "發票日期";
            // 
            // dtPayDate
            // 
            dtPayDate.Format = DateTimePickerFormat.Short;
            dtPayDate.Location = new Point(940, 6);
            dtPayDate.Name = "dtPayDate";
            dtPayDate.Size = new Size(130, 25);
            dtPayDate.TabIndex = 9;
            // 
            // lblSupplierNo
            // 
            lblSupplierNo.AutoSize = true;
            lblSupplierNo.Location = new Point(8, 46);
            lblSupplierNo.Name = "lblSupplierNo";
            lblSupplierNo.Size = new Size(64, 18);
            lblSupplierNo.TabIndex = 10;
            lblSupplierNo.Text = "廠商編號";
            // 
            // txtSupplierNo
            // 
            txtSupplierNo.Location = new Point(82, 42);
            txtSupplierNo.Name = "txtSupplierNo";
            txtSupplierNo.ReadOnly = true;
            txtSupplierNo.Size = new Size(120, 25);
            txtSupplierNo.TabIndex = 11;
            // 
            // btnSelectSupplier
            // 
            btnSelectSupplier.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            btnSelectSupplier.Location = new Point(204, 42);
            btnSelectSupplier.Name = "btnSelectSupplier";
            btnSelectSupplier.Size = new Size(30, 25);
            btnSelectSupplier.TabIndex = 12;
            btnSelectSupplier.Text = "🔍";
            btnSelectSupplier.UseVisualStyleBackColor = true;
            btnSelectSupplier.Click += btnSelectSupplier_Click;
            // 
            // lblSupplierName
            // 
            lblSupplierName.AutoSize = true;
            lblSupplierName.Location = new Point(240, 46);
            lblSupplierName.Name = "lblSupplierName";
            lblSupplierName.Size = new Size(64, 18);
            lblSupplierName.TabIndex = 13;
            lblSupplierName.Text = "廠商名稱";
            // 
            // txtSupplierName
            // 
            txtSupplierName.Location = new Point(314, 42);
            txtSupplierName.Name = "txtSupplierName";
            txtSupplierName.ReadOnly = true;
            txtSupplierName.Size = new Size(534, 25);
            txtSupplierName.TabIndex = 14;
            // 
            // lblInvoiceNo
            // 
            lblInvoiceNo.AutoSize = true;
            lblInvoiceNo.Location = new Point(866, 44);
            lblInvoiceNo.Name = "lblInvoiceNo";
            lblInvoiceNo.Size = new Size(64, 18);
            lblInvoiceNo.TabIndex = 15;
            lblInvoiceNo.Text = "發票號碼";
            // 
            // txtInvoiceNo
            // 
            txtInvoiceNo.Location = new Point(936, 40);
            txtInvoiceNo.Name = "txtInvoiceNo";
            txtInvoiceNo.Size = new Size(134, 25);
            txtInvoiceNo.TabIndex = 16;
            // 
            // lblVoucher
            // 
            lblVoucher.AutoSize = true;
            lblVoucher.Location = new Point(8, 82);
            lblVoucher.Name = "lblVoucher";
            lblVoucher.Size = new Size(64, 18);
            lblVoucher.TabIndex = 19;
            lblVoucher.Text = "會計傳票";
            // 
            // txtVoucher
            // 
            txtVoucher.Location = new Point(82, 78);
            txtVoucher.Name = "txtVoucher";
            txtVoucher.ReadOnly = true;
            txtVoucher.Size = new Size(120, 25);
            txtVoucher.TabIndex = 20;
            // 
            // lblCurrency
            // 
            lblCurrency.AutoSize = true;
            lblCurrency.Location = new Point(212, 82);
            lblCurrency.Name = "lblCurrency";
            lblCurrency.Size = new Size(36, 18);
            lblCurrency.TabIndex = 21;
            lblCurrency.Text = "幣別";
            // 
            // cboCurrency
            // 
            cboCurrency.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCurrency.FormattingEnabled = true;
            cboCurrency.Location = new Point(262, 78);
            cboCurrency.Name = "cboCurrency";
            cboCurrency.Size = new Size(72, 25);
            cboCurrency.TabIndex = 22;
            cboCurrency.SelectedIndexChanged += cboCurrency_SelectedIndexChanged;
            // 
            // lblExRate
            // 
            lblExRate.AutoSize = true;
            lblExRate.Location = new Point(342, 82);
            lblExRate.Name = "lblExRate";
            lblExRate.Size = new Size(36, 18);
            lblExRate.TabIndex = 23;
            lblExRate.Text = "匯率";
            // 
            // txtExRate
            // 
            txtExRate.Location = new Point(388, 78);
            txtExRate.Name = "txtExRate";
            txtExRate.Size = new Size(80, 25);
            txtExRate.TabIndex = 24;
            // 
            // lblRequester
            // 
            lblRequester.AutoSize = true;
            lblRequester.Location = new Point(478, 82);
            lblRequester.Name = "lblRequester";
            lblRequester.Size = new Size(64, 18);
            lblRequester.TabIndex = 25;
            lblRequester.Text = "付款單號";
            // 
            // txtRequester
            // 
            txtRequester.Location = new Point(552, 78);
            txtRequester.Name = "txtRequester";
            txtRequester.Size = new Size(120, 25);
            txtRequester.TabIndex = 26;
            // 
            // lblBankAmt
            // 
            lblBankAmt.AutoSize = true;
            lblBankAmt.Location = new Point(1086, 12);
            lblBankAmt.Name = "lblBankAmt";
            lblBankAmt.Size = new Size(64, 18);
            lblBankAmt.TabIndex = 31;
            lblBankAmt.Text = "未稅金額";
            // 
            // txtBankAmt
            // 
            txtBankAmt.Location = new Point(1160, 8);
            txtBankAmt.Name = "txtBankAmt";
            txtBankAmt.Size = new Size(110, 25);
            txtBankAmt.TabIndex = 32;
            txtBankAmt.Leave += txtBankAmt_Leave;
            // 
            // lblCheckAmt
            // 
            lblCheckAmt.AutoSize = true;
            lblCheckAmt.Location = new Point(1086, 46);
            lblCheckAmt.Name = "lblCheckAmt";
            lblCheckAmt.Size = new Size(36, 18);
            lblCheckAmt.TabIndex = 35;
            lblCheckAmt.Text = "稅額";
            // 
            // txtCheckAmt
            // 
            txtCheckAmt.Location = new Point(1160, 42);
            txtCheckAmt.Name = "txtCheckAmt";
            txtCheckAmt.Size = new Size(110, 25);
            txtCheckAmt.TabIndex = 36;
            txtCheckAmt.Leave += txtCheckAmt_Leave;
            // 
            // lblPayTotal
            // 
            lblPayTotal.AutoSize = true;
            lblPayTotal.Location = new Point(1086, 80);
            lblPayTotal.Name = "lblPayTotal";
            lblPayTotal.Size = new Size(36, 18);
            lblPayTotal.TabIndex = 37;
            lblPayTotal.Text = "總額";
            // 
            // txtPayTotal
            // 
            txtPayTotal.BackColor = Color.LightYellow;
            txtPayTotal.Location = new Point(1160, 76);
            txtPayTotal.Name = "txtPayTotal";
            txtPayTotal.ReadOnly = true;
            txtPayTotal.Size = new Size(120, 25);
            txtPayTotal.TabIndex = 38;
            // 
            // lblClosed
            // 
            lblClosed.AutoSize = true;
            lblClosed.Location = new Point(774, 82);
            lblClosed.Name = "lblClosed";
            lblClosed.Size = new Size(36, 18);
            lblClosed.TabIndex = 39;
            lblClosed.Text = "結案";
            // 
            // chkClosed
            // 
            chkClosed.Location = new Point(820, 78);
            chkClosed.Name = "chkClosed";
            chkClosed.Size = new Size(24, 24);
            chkClosed.TabIndex = 40;
            chkClosed.UseVisualStyleBackColor = true;
            // 
            // btnSingleClose
            // 
            btnSingleClose.BackColor = Color.DarkOrange;
            btnSingleClose.FlatStyle = FlatStyle.Flat;
            btnSingleClose.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            btnSingleClose.ForeColor = Color.White;
            btnSingleClose.Location = new Point(688, 80);
            btnSingleClose.Name = "btnSingleClose";
            btnSingleClose.Size = new Size(80, 24);
            btnSingleClose.TabIndex = 43;
            btnSingleClose.Text = "單筆結案";
            btnSingleClose.UseVisualStyleBackColor = false;
            btnSingleClose.Click += btnSingleClose_Click;
            // 
            // lblRemark
            // 
            lblRemark.AutoSize = true;
            lblRemark.Location = new Point(866, 80);
            lblRemark.Name = "lblRemark";
            lblRemark.Size = new Size(36, 18);
            lblRemark.TabIndex = 41;
            lblRemark.Text = "備註";
            // 
            // txtRemark
            // 
            txtRemark.Location = new Point(938, 76);
            txtRemark.Name = "txtRemark";
            txtRemark.Size = new Size(132, 25);
            txtRemark.TabIndex = 42;
            // 
            // panel3
            // 
            panel3.Controls.Add(dataGridView1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 184);
            panel3.Name = "panel3";
            panel3.Size = new Size(1650, 382);
            panel3.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colSource, colOffsetCode, colOrigAmt, colTwdAmt, colProject, colDesc });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Font = new Font("微軟正黑體", 9F);
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 26;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1650, 382);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellEndEdit += dataGridView1_CellEndEdit;
            dataGridView1.CellValueChanged += dataGridView1_CellValueChanged;
            // 
            // colSource
            // 
            colSource.HeaderText = "帳款來源";
            colSource.Name = "colSource";
            // 
            // colOffsetCode
            // 
            colOffsetCode.HeaderText = "沖帳碼";
            colOffsetCode.Name = "colOffsetCode";
            // 
            // colOrigAmt
            // 
            colOrigAmt.HeaderText = "原幣收帳金額";
            colOrigAmt.Name = "colOrigAmt";
            // 
            // colTwdAmt
            // 
            colTwdAmt.HeaderText = "台幣換算金額";
            colTwdAmt.Name = "colTwdAmt";
            // 
            // colProject
            // 
            colProject.HeaderText = "專案序號";
            colProject.Name = "colProject";
            // 
            // colDesc
            // 
            colDesc.FillWeight = 200F;
            colDesc.HeaderText = "說明";
            colDesc.Name = "colDesc";
            // 
            // panel3b
            // 
            panel3b.BackColor = Color.Honeydew;
            panel3b.Controls.Add(lblDetailTotal);
            panel3b.Controls.Add(txtDetailTotal);
            panel3b.Dock = DockStyle.Bottom;
            panel3b.Location = new Point(0, 566);
            panel3b.Name = "panel3b";
            panel3b.Size = new Size(1650, 34);
            panel3b.TabIndex = 3;
            // 
            // lblDetailTotal
            // 
            lblDetailTotal.AutoSize = true;
            lblDetailTotal.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            lblDetailTotal.Location = new Point(8, 8);
            lblDetailTotal.Name = "lblDetailTotal";
            lblDetailTotal.Size = new Size(55, 16);
            lblDetailTotal.TabIndex = 0;
            lblDetailTotal.Text = "金額合計";
            // 
            // txtDetailTotal
            // 
            txtDetailTotal.BackColor = Color.LightYellow;
            txtDetailTotal.Location = new Point(82, 4);
            txtDetailTotal.Name = "txtDetailTotal";
            txtDetailTotal.ReadOnly = true;
            txtDetailTotal.Size = new Size(150, 25);
            txtDetailTotal.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Honeydew;
            panel4.Controls.Add(lblReviewerCap);
            panel4.Controls.Add(txtReviewer);
            panel4.Controls.Add(lblReviewDateCap);
            panel4.Controls.Add(txtReviewDate);
            panel4.Controls.Add(lblModifierCap);
            panel4.Controls.Add(txtModifier);
            panel4.Controls.Add(lblModifyDateCap);
            panel4.Controls.Add(txtModifyDate);
            panel4.Controls.Add(lblCreatorCap);
            panel4.Controls.Add(txtCreator);
            panel4.Controls.Add(lblCreateDateCap);
            panel4.Controls.Add(txtCreateDate);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(0, 600);
            panel4.Name = "panel4";
            panel4.Size = new Size(1650, 56);
            panel4.TabIndex = 4;
            // 
            // lblReviewerCap
            // 
            lblReviewerCap.AutoSize = true;
            lblReviewerCap.Location = new Point(10, 18);
            lblReviewerCap.Name = "lblReviewerCap";
            lblReviewerCap.Size = new Size(64, 18);
            lblReviewerCap.TabIndex = 0;
            lblReviewerCap.Text = "財務覆核";
            // 
            // txtReviewer
            // 
            txtReviewer.Location = new Point(92, 14);
            txtReviewer.Name = "txtReviewer";
            txtReviewer.ReadOnly = true;
            txtReviewer.Size = new Size(120, 25);
            txtReviewer.TabIndex = 1;
            // 
            // lblReviewDateCap
            // 
            lblReviewDateCap.AutoSize = true;
            lblReviewDateCap.Location = new Point(226, 18);
            lblReviewDateCap.Name = "lblReviewDateCap";
            lblReviewDateCap.Size = new Size(50, 18);
            lblReviewDateCap.TabIndex = 2;
            lblReviewDateCap.Text = "核准日";
            // 
            // txtReviewDate
            // 
            txtReviewDate.Location = new Point(288, 14);
            txtReviewDate.Name = "txtReviewDate";
            txtReviewDate.ReadOnly = true;
            txtReviewDate.Size = new Size(120, 25);
            txtReviewDate.TabIndex = 3;
            // 
            // lblModifierCap
            // 
            lblModifierCap.AutoSize = true;
            lblModifierCap.Location = new Point(430, 18);
            lblModifierCap.Name = "lblModifierCap";
            lblModifierCap.Size = new Size(64, 18);
            lblModifierCap.TabIndex = 4;
            lblModifierCap.Text = "修改人員";
            // 
            // txtModifier
            // 
            txtModifier.Location = new Point(512, 14);
            txtModifier.Name = "txtModifier";
            txtModifier.ReadOnly = true;
            txtModifier.Size = new Size(120, 25);
            txtModifier.TabIndex = 5;
            // 
            // lblModifyDateCap
            // 
            lblModifyDateCap.AutoSize = true;
            lblModifyDateCap.Location = new Point(646, 18);
            lblModifyDateCap.Name = "lblModifyDateCap";
            lblModifyDateCap.Size = new Size(50, 18);
            lblModifyDateCap.TabIndex = 6;
            lblModifyDateCap.Text = "修改日";
            // 
            // txtModifyDate
            // 
            txtModifyDate.Location = new Point(708, 14);
            txtModifyDate.Name = "txtModifyDate";
            txtModifyDate.ReadOnly = true;
            txtModifyDate.Size = new Size(120, 25);
            txtModifyDate.TabIndex = 7;
            // 
            // lblCreatorCap
            // 
            lblCreatorCap.AutoSize = true;
            lblCreatorCap.Location = new Point(850, 18);
            lblCreatorCap.Name = "lblCreatorCap";
            lblCreatorCap.Size = new Size(64, 18);
            lblCreatorCap.TabIndex = 8;
            lblCreatorCap.Text = "建檔人員";
            // 
            // txtCreator
            // 
            txtCreator.Location = new Point(932, 14);
            txtCreator.Name = "txtCreator";
            txtCreator.ReadOnly = true;
            txtCreator.Size = new Size(120, 25);
            txtCreator.TabIndex = 9;
            // 
            // lblCreateDateCap
            // 
            lblCreateDateCap.AutoSize = true;
            lblCreateDateCap.Location = new Point(1066, 18);
            lblCreateDateCap.Name = "lblCreateDateCap";
            lblCreateDateCap.Size = new Size(50, 18);
            lblCreateDateCap.TabIndex = 10;
            lblCreateDateCap.Text = "建檔日";
            // 
            // txtCreateDate
            // 
            txtCreateDate.Location = new Point(1128, 14);
            txtCreateDate.Name = "txtCreateDate";
            txtCreateDate.ReadOnly = true;
            txtCreateDate.Size = new Size(120, 25);
            txtCreateDate.TabIndex = 11;
            // 
            // StockInCertMaintainControl
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel3);
            Controls.Add(panel3b);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("微軟正黑體", 10F);
            Margin = new Padding(4);
            Name = "StockInCertMaintainControl";
            Size = new Size(1650, 656);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel3b.ResumeLayout(false);
            panel3b.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label lblTitle;
        private Button btnCashier;
        private Button btnVoucherEntry;
        private Button btnImportDetail;
        private Button btnDelete;
        private Button btnAdd;
        private Button btnModify;
        private Button btnSave;
        private Button btnVerify;
        private Button btnCancelVerify;
        private Button btnPrint;
        private Button btnOverview;
        private Button btnClose;
        private Panel panel2;
        private Label lblDate;
        private DateTimePicker dtDate;
        private Label lblNo;
        private TextBox txtNo;
        private Label lblCategory;
        private ComboBox cboCategory;
        private Label lblCertType;
        private ComboBox cboCertType;
        private Label lblPayDate;
        private DateTimePicker dtPayDate;
        private Label lblSupplierNo;
        private TextBox txtSupplierNo;
        private Button btnSelectSupplier;
        private Label lblSupplierName;
        private TextBox txtSupplierName;
        private Label lblInvoiceNo;
        private TextBox txtInvoiceNo;
        private Label lblVoucher;
        private TextBox txtVoucher;
        private Label lblCurrency;
        private ComboBox cboCurrency;
        private Label lblExRate;
        private TextBox txtExRate;
        private Label lblRequester;
        private TextBox txtRequester;
        private Label lblBankAmt;
        private TextBox txtBankAmt;
        private Label lblCheckAmt;
        private TextBox txtCheckAmt;
        private Label lblPayTotal;
        private TextBox txtPayTotal;
        private Label lblClosed;
        private CheckBox chkClosed;
        private Button btnSingleClose;
        private Label lblRemark;
        private TextBox txtRemark;
        private Panel panel3;
        private Panel panel3b;
        private Label lblDetailTotal;
        private TextBox txtDetailTotal;
        private Panel panel4;
        private Label lblReviewerCap;
        private TextBox txtReviewer;
        private Label lblReviewDateCap;
        private TextBox txtReviewDate;
        private Label lblModifierCap;
        private TextBox txtModifier;
        private Label lblModifyDateCap;
        private TextBox txtModifyDate;
        private Label lblCreatorCap;
        private TextBox txtCreator;
        private Label lblCreateDateCap;
        private TextBox txtCreateDate;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn colSource;
        private DataGridViewTextBoxColumn colOffsetCode;
        private DataGridViewTextBoxColumn colOrigAmt;
        private DataGridViewTextBoxColumn colTwdAmt;
        private DataGridViewTextBoxColumn colProject;
        private DataGridViewTextBoxColumn colDesc;
    }
}
