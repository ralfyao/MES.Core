using System.Drawing;
using System.Windows.Forms;

namespace DigiERP.UserControl.Inventory.StockInCert
{
    partial class PaymentOffsetMaintainControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaymentOffsetMaintainControl));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            lblTitle = new Label();
            btnVoucherEntry = new Button();
            btnImportDetail = new Button();
            btnDelete = new Button();
            btnAdd = new Button();
            btnModify = new Button();
            btnSave = new Button();
            btnVerify = new Button();
            btnCancelVerify = new Button();
            btnOverview = new Button();
            btnClose = new Button();
            panel2 = new Panel();
            lblDate = new Label();
            dtDate = new DateTimePicker();
            lblNo = new Label();
            txtNo = new TextBox();
            lblCurrency = new Label();
            cboCurrency = new ComboBox();
            lblExRate = new Label();
            txtExRate = new TextBox();
            lblSupplierNo = new Label();
            txtSupplierNo = new TextBox();
            lblSupplierName = new Label();
            txtSupplierName = new TextBox();
            lblTwdOffset = new Label();
            txtTwdOffset = new TextBox();
            lblExDiff = new Label();
            txtExDiff = new TextBox();
            lblAllowance = new Label();
            txtAllowance = new TextBox();
            lblVoucher = new Label();
            txtVoucher = new TextBox();
            lblRemark = new Label();
            txtRemark = new TextBox();
            lblCashAmt = new Label();
            txtCashAmt = new TextBox();
            lblFee = new Label();
            txtFee = new TextBox();
            lblBankAmt = new Label();
            txtBankAmt = new TextBox();
            lblBankCode = new Label();
            cboBankCode = new ComboBox();
            btnRemit = new Button();
            lblCheckAmt = new Label();
            txtCheckAmt = new TextBox();
            lblCheckNo = new Label();
            txtCheckNo = new TextBox();
            btnCheck = new Button();
            lblPayTotal = new Label();
            txtPayTotal = new TextBox();
            lblOrigOffset = new Label();
            txtOrigOffset = new TextBox();
            panel3 = new Panel();
            dataGridView1 = new DataGridView();
            colSource = new DataGridViewTextBoxColumn();
            colAccDate = new DataGridViewTextBoxColumn();
            colNature = new DataGridViewTextBoxColumn();
            colOffsetCode = new DataGridViewTextBoxColumn();
            colOrigUntaxed = new DataGridViewTextBoxColumn();
            colTwdUntaxed = new DataGridViewTextBoxColumn();
            colTax = new DataGridViewTextBoxColumn();
            colAmount = new DataGridViewTextBoxColumn();
            colOrigOffsetAmt = new DataGridViewTextBoxColumn();
            colTwdOffsetAmt = new DataGridViewTextBoxColumn();
            colAllowance = new DataGridViewTextBoxColumn();
            colExDiff = new DataGridViewTextBoxColumn();
            colRemark = new DataGridViewTextBoxColumn();
            panel3b = new Panel();
            lblSumCap = new Label();
            txtSumOrigUntaxed = new TextBox();
            txtSumTwdUntaxed = new TextBox();
            txtSumTax = new TextBox();
            txtSumAmount = new TextBox();
            txtSumOrigOffsetAmt = new TextBox();
            txtSumTwdOffsetAmt = new TextBox();
            txtSumAllowance = new TextBox();
            txtSumExDiff = new TextBox();
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
            panel1.Controls.Add(btnVoucherEntry);
            panel1.Controls.Add(btnImportDetail);
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(btnModify);
            panel1.Controls.Add(btnSave);
            panel1.Controls.Add(btnVerify);
            panel1.Controls.Add(btnCancelVerify);
            panel1.Controls.Add(btnOverview);
            panel1.Controls.Add(btnClose);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1700, 56);
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
            lblTitle.Size = new Size(64, 23);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "付款單";
            // 
            // btnVoucherEntry
            // 
            btnVoucherEntry.BackColor = Color.Gainsboro;
            btnVoucherEntry.FlatStyle = FlatStyle.Flat;
            btnVoucherEntry.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            btnVoucherEntry.Location = new Point(230, 12);
            btnVoucherEntry.Name = "btnVoucherEntry";
            btnVoucherEntry.Size = new Size(98, 32);
            btnVoucherEntry.TabIndex = 1;
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
            btnImportDetail.Location = new Point(334, 12);
            btnImportDetail.Name = "btnImportDetail";
            btnImportDetail.Size = new Size(110, 32);
            btnImportDetail.TabIndex = 2;
            btnImportDetail.Text = "應付款導入";
            btnImportDetail.UseVisualStyleBackColor = false;
            btnImportDetail.Click += btnImportDetail_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Firebrick;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(456, 12);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(98, 32);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "刪除紀錄";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Gainsboro;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            btnAdd.Location = new Point(560, 12);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(98, 32);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "新增";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnModify
            // 
            btnModify.BackColor = Color.Gainsboro;
            btnModify.FlatStyle = FlatStyle.Flat;
            btnModify.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            btnModify.Location = new Point(664, 12);
            btnModify.Name = "btnModify";
            btnModify.Size = new Size(98, 32);
            btnModify.TabIndex = 5;
            btnModify.Text = "修改";
            btnModify.UseVisualStyleBackColor = false;
            btnModify.Click += btnModify_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Gainsboro;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            btnSave.Location = new Point(768, 12);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(98, 32);
            btnSave.TabIndex = 6;
            btnSave.Text = "儲存";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnVerify
            // 
            btnVerify.BackColor = Color.Gainsboro;
            btnVerify.FlatStyle = FlatStyle.Flat;
            btnVerify.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            btnVerify.Location = new Point(872, 12);
            btnVerify.Name = "btnVerify";
            btnVerify.Size = new Size(98, 32);
            btnVerify.TabIndex = 7;
            btnVerify.Text = "覆核";
            btnVerify.UseVisualStyleBackColor = false;
            btnVerify.Click += btnVerify_Click;
            // 
            // btnCancelVerify
            // 
            btnCancelVerify.BackColor = Color.Gainsboro;
            btnCancelVerify.FlatStyle = FlatStyle.Flat;
            btnCancelVerify.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            btnCancelVerify.Location = new Point(976, 12);
            btnCancelVerify.Name = "btnCancelVerify";
            btnCancelVerify.Size = new Size(98, 32);
            btnCancelVerify.TabIndex = 8;
            btnCancelVerify.Text = "取消覆核";
            btnCancelVerify.UseVisualStyleBackColor = false;
            btnCancelVerify.Click += btnCancelVerify_Click;
            // 
            // btnOverview
            // 
            btnOverview.BackColor = Color.Gainsboro;
            btnOverview.FlatStyle = FlatStyle.Flat;
            btnOverview.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            btnOverview.Location = new Point(1080, 12);
            btnOverview.Name = "btnOverview";
            btnOverview.Size = new Size(98, 32);
            btnOverview.TabIndex = 9;
            btnOverview.Text = "總覽";
            btnOverview.UseVisualStyleBackColor = false;
            btnOverview.Click += btnOverview_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Gainsboro;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            btnClose.Location = new Point(1184, 12);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(98, 32);
            btnClose.TabIndex = 10;
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
            panel2.Controls.Add(lblCurrency);
            panel2.Controls.Add(cboCurrency);
            panel2.Controls.Add(lblExRate);
            panel2.Controls.Add(txtExRate);
            panel2.Controls.Add(lblSupplierNo);
            panel2.Controls.Add(txtSupplierNo);
            panel2.Controls.Add(lblSupplierName);
            panel2.Controls.Add(txtSupplierName);
            panel2.Controls.Add(lblTwdOffset);
            panel2.Controls.Add(txtTwdOffset);
            panel2.Controls.Add(lblExDiff);
            panel2.Controls.Add(txtExDiff);
            panel2.Controls.Add(lblAllowance);
            panel2.Controls.Add(txtAllowance);
            panel2.Controls.Add(lblVoucher);
            panel2.Controls.Add(txtVoucher);
            panel2.Controls.Add(lblRemark);
            panel2.Controls.Add(txtRemark);
            panel2.Controls.Add(lblCashAmt);
            panel2.Controls.Add(txtCashAmt);
            panel2.Controls.Add(lblFee);
            panel2.Controls.Add(txtFee);
            panel2.Controls.Add(lblBankAmt);
            panel2.Controls.Add(txtBankAmt);
            panel2.Controls.Add(lblBankCode);
            panel2.Controls.Add(cboBankCode);
            panel2.Controls.Add(btnRemit);
            panel2.Controls.Add(lblCheckAmt);
            panel2.Controls.Add(txtCheckAmt);
            panel2.Controls.Add(lblCheckNo);
            panel2.Controls.Add(txtCheckNo);
            panel2.Controls.Add(btnCheck);
            panel2.Controls.Add(lblPayTotal);
            panel2.Controls.Add(txtPayTotal);
            panel2.Controls.Add(lblOrigOffset);
            panel2.Controls.Add(txtOrigOffset);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 56);
            panel2.Name = "panel2";
            panel2.Size = new Size(1700, 190);
            panel2.TabIndex = 1;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Location = new Point(8, 10);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(64, 18);
            lblDate.TabIndex = 0;
            lblDate.Text = "付款日期";
            // 
            // dtDate
            // 
            dtDate.Enabled = false;
            dtDate.Format = DateTimePickerFormat.Short;
            dtDate.Location = new Point(82, 6);
            dtDate.Name = "dtDate";
            dtDate.Size = new Size(130, 25);
            dtDate.TabIndex = 1;
            // 
            // lblNo
            // 
            lblNo.AutoSize = true;
            lblNo.Location = new Point(224, 10);
            lblNo.Name = "lblNo";
            lblNo.Size = new Size(36, 18);
            lblNo.TabIndex = 2;
            lblNo.Text = "單號";
            // 
            // txtNo
            // 
            txtNo.Location = new Point(278, 6);
            txtNo.Name = "txtNo";
            txtNo.ReadOnly = true;
            txtNo.Size = new Size(150, 25);
            txtNo.TabIndex = 3;
            // 
            // lblCurrency
            // 
            lblCurrency.AutoSize = true;
            lblCurrency.Location = new Point(440, 10);
            lblCurrency.Name = "lblCurrency";
            lblCurrency.Size = new Size(36, 18);
            lblCurrency.TabIndex = 4;
            lblCurrency.Text = "幣別";
            // 
            // cboCurrency
            // 
            cboCurrency.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCurrency.FormattingEnabled = true;
            cboCurrency.Location = new Point(486, 6);
            cboCurrency.Name = "cboCurrency";
            cboCurrency.Size = new Size(72, 25);
            cboCurrency.TabIndex = 5;
            cboCurrency.SelectedIndexChanged += cboCurrency_SelectedIndexChanged;
            // 
            // lblExRate
            // 
            lblExRate.AutoSize = true;
            lblExRate.Location = new Point(566, 10);
            lblExRate.Name = "lblExRate";
            lblExRate.Size = new Size(36, 18);
            lblExRate.TabIndex = 6;
            lblExRate.Text = "匯率";
            // 
            // txtExRate
            // 
            txtExRate.Location = new Point(612, 6);
            txtExRate.Name = "txtExRate";
            txtExRate.Size = new Size(80, 25);
            txtExRate.TabIndex = 7;
            // 
            // lblSupplierNo
            // 
            lblSupplierNo.AutoSize = true;
            lblSupplierNo.Location = new Point(8, 46);
            lblSupplierNo.Name = "lblSupplierNo";
            lblSupplierNo.Size = new Size(64, 18);
            lblSupplierNo.TabIndex = 8;
            lblSupplierNo.Text = "廠商編號";
            // 
            // txtSupplierNo
            // 
            txtSupplierNo.Location = new Point(82, 42);
            txtSupplierNo.Name = "txtSupplierNo";
            txtSupplierNo.ReadOnly = true;
            txtSupplierNo.Size = new Size(120, 25);
            txtSupplierNo.TabIndex = 9;
            // 
            // lblSupplierName
            // 
            lblSupplierName.AutoSize = true;
            lblSupplierName.Location = new Point(212, 46);
            lblSupplierName.Name = "lblSupplierName";
            lblSupplierName.Size = new Size(64, 18);
            lblSupplierName.TabIndex = 10;
            lblSupplierName.Text = "廠商名稱";
            // 
            // txtSupplierName
            // 
            txtSupplierName.Location = new Point(286, 42);
            txtSupplierName.Name = "txtSupplierName";
            txtSupplierName.ReadOnly = true;
            txtSupplierName.Size = new Size(220, 25);
            txtSupplierName.TabIndex = 11;
            // 
            // lblTwdOffset
            // 
            lblTwdOffset.AutoSize = true;
            lblTwdOffset.Location = new Point(520, 46);
            lblTwdOffset.Name = "lblTwdOffset";
            lblTwdOffset.Size = new Size(64, 18);
            lblTwdOffset.TabIndex = 12;
            lblTwdOffset.Text = "台幣沖款";
            // 
            // txtTwdOffset
            // 
            txtTwdOffset.BackColor = Color.LightYellow;
            txtTwdOffset.Location = new Point(594, 42);
            txtTwdOffset.Name = "txtTwdOffset";
            txtTwdOffset.ReadOnly = true;
            txtTwdOffset.Size = new Size(110, 25);
            txtTwdOffset.TabIndex = 13;
            // 
            // lblExDiff
            // 
            lblExDiff.AutoSize = true;
            lblExDiff.Location = new Point(716, 46);
            lblExDiff.Name = "lblExDiff";
            lblExDiff.Size = new Size(64, 18);
            lblExDiff.TabIndex = 14;
            lblExDiff.Text = "匯兌損益";
            // 
            // txtExDiff
            // 
            txtExDiff.BackColor = Color.LightYellow;
            txtExDiff.Location = new Point(790, 42);
            txtExDiff.Name = "txtExDiff";
            txtExDiff.ReadOnly = true;
            txtExDiff.Size = new Size(110, 25);
            txtExDiff.TabIndex = 15;
            // 
            // lblAllowance
            // 
            lblAllowance.AutoSize = true;
            lblAllowance.Location = new Point(912, 46);
            lblAllowance.Name = "lblAllowance";
            lblAllowance.Size = new Size(64, 18);
            lblAllowance.TabIndex = 16;
            lblAllowance.Text = "折讓金額";
            // 
            // txtAllowance
            // 
            txtAllowance.BackColor = Color.LightYellow;
            txtAllowance.Location = new Point(986, 42);
            txtAllowance.Name = "txtAllowance";
            txtAllowance.ReadOnly = true;
            txtAllowance.Size = new Size(110, 25);
            txtAllowance.TabIndex = 17;
            // 
            // lblVoucher
            // 
            lblVoucher.AutoSize = true;
            lblVoucher.Location = new Point(8, 82);
            lblVoucher.Name = "lblVoucher";
            lblVoucher.Size = new Size(64, 18);
            lblVoucher.TabIndex = 18;
            lblVoucher.Text = "傳票編號";
            // 
            // txtVoucher
            // 
            txtVoucher.Location = new Point(82, 78);
            txtVoucher.Name = "txtVoucher";
            txtVoucher.Size = new Size(120, 25);
            txtVoucher.TabIndex = 19;
            // 
            // lblRemark
            // 
            lblRemark.AutoSize = true;
            lblRemark.Location = new Point(212, 82);
            lblRemark.Name = "lblRemark";
            lblRemark.Size = new Size(36, 18);
            lblRemark.TabIndex = 20;
            lblRemark.Text = "備註";
            // 
            // txtRemark
            // 
            txtRemark.Location = new Point(262, 78);
            txtRemark.Name = "txtRemark";
            txtRemark.Size = new Size(500, 25);
            txtRemark.TabIndex = 21;
            // 
            // lblCashAmt
            // 
            lblCashAmt.AutoSize = true;
            lblCashAmt.Location = new Point(8, 118);
            lblCashAmt.Name = "lblCashAmt";
            lblCashAmt.Size = new Size(64, 18);
            lblCashAmt.TabIndex = 22;
            lblCashAmt.Text = "付現金額";
            // 
            // txtCashAmt
            // 
            txtCashAmt.Location = new Point(82, 114);
            txtCashAmt.Name = "txtCashAmt";
            txtCashAmt.Size = new Size(110, 25);
            txtCashAmt.TabIndex = 23;
            txtCashAmt.Leave += txtCashAmt_Leave;
            // 
            // lblFee
            // 
            lblFee.AutoSize = true;
            lblFee.Location = new Point(200, 118);
            lblFee.Name = "lblFee";
            lblFee.Size = new Size(36, 18);
            lblFee.TabIndex = 24;
            lblFee.Text = "匯費";
            // 
            // txtFee
            // 
            txtFee.Location = new Point(246, 114);
            txtFee.Name = "txtFee";
            txtFee.Size = new Size(90, 25);
            txtFee.TabIndex = 25;
            // 
            // lblBankAmt
            // 
            lblBankAmt.AutoSize = true;
            lblBankAmt.Location = new Point(344, 118);
            lblBankAmt.Name = "lblBankAmt";
            lblBankAmt.Size = new Size(64, 18);
            lblBankAmt.TabIndex = 26;
            lblBankAmt.Text = "銀轉金額";
            // 
            // txtBankAmt
            // 
            txtBankAmt.Location = new Point(418, 114);
            txtBankAmt.Name = "txtBankAmt";
            txtBankAmt.Size = new Size(110, 25);
            txtBankAmt.TabIndex = 27;
            txtBankAmt.Leave += txtBankAmt_Leave;
            // 
            // lblBankCode
            // 
            lblBankCode.AutoSize = true;
            lblBankCode.Location = new Point(536, 118);
            lblBankCode.Name = "lblBankCode";
            lblBankCode.Size = new Size(64, 18);
            lblBankCode.TabIndex = 28;
            lblBankCode.Text = "銀存編碼";
            // 
            // cboBankCode
            // 
            cboBankCode.FormattingEnabled = true;
            cboBankCode.Location = new Point(610, 114);
            cboBankCode.Name = "cboBankCode";
            cboBankCode.Size = new Size(120, 25);
            cboBankCode.TabIndex = 29;
            // 
            // btnRemit
            // 
            btnRemit.BackColor = Color.Orange;
            btnRemit.FlatStyle = FlatStyle.Flat;
            btnRemit.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            btnRemit.Location = new Point(736, 112);
            btnRemit.Name = "btnRemit";
            btnRemit.Size = new Size(80, 28);
            btnRemit.TabIndex = 30;
            btnRemit.Text = "匯出款";
            btnRemit.UseVisualStyleBackColor = false;
            btnRemit.Click += btnRemit_Click;
            // 
            // lblCheckAmt
            // 
            lblCheckAmt.AutoSize = true;
            lblCheckAmt.Location = new Point(830, 118);
            lblCheckAmt.Name = "lblCheckAmt";
            lblCheckAmt.Size = new Size(64, 18);
            lblCheckAmt.TabIndex = 31;
            lblCheckAmt.Text = "付票金額";
            // 
            // txtCheckAmt
            // 
            txtCheckAmt.Location = new Point(904, 114);
            txtCheckAmt.Name = "txtCheckAmt";
            txtCheckAmt.Size = new Size(110, 25);
            txtCheckAmt.TabIndex = 32;
            txtCheckAmt.Leave += txtCheckAmt_Leave;
            // 
            // lblCheckNo
            // 
            lblCheckNo.AutoSize = true;
            lblCheckNo.Location = new Point(1022, 118);
            lblCheckNo.Name = "lblCheckNo";
            lblCheckNo.Size = new Size(64, 18);
            lblCheckNo.TabIndex = 33;
            lblCheckNo.Text = "票據號碼";
            // 
            // txtCheckNo
            // 
            txtCheckNo.Location = new Point(1096, 114);
            txtCheckNo.Name = "txtCheckNo";
            txtCheckNo.Size = new Size(140, 25);
            txtCheckNo.TabIndex = 34;
            // 
            // btnCheck
            // 
            btnCheck.BackColor = Color.SteelBlue;
            btnCheck.FlatStyle = FlatStyle.Flat;
            btnCheck.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            btnCheck.ForeColor = Color.White;
            btnCheck.Location = new Point(1242, 112);
            btnCheck.Name = "btnCheck";
            btnCheck.Size = new Size(70, 28);
            btnCheck.TabIndex = 35;
            btnCheck.Text = "付票";
            btnCheck.UseVisualStyleBackColor = false;
            btnCheck.Click += btnCheck_Click;
            // 
            // lblPayTotal
            // 
            lblPayTotal.AutoSize = true;
            lblPayTotal.Location = new Point(8, 154);
            lblPayTotal.Name = "lblPayTotal";
            lblPayTotal.Size = new Size(64, 18);
            lblPayTotal.TabIndex = 36;
            lblPayTotal.Text = "付款總額";
            // 
            // txtPayTotal
            // 
            txtPayTotal.BackColor = Color.LightYellow;
            txtPayTotal.Location = new Point(82, 150);
            txtPayTotal.Name = "txtPayTotal";
            txtPayTotal.ReadOnly = true;
            txtPayTotal.Size = new Size(110, 25);
            txtPayTotal.TabIndex = 37;
            // 
            // lblOrigOffset
            // 
            lblOrigOffset.AutoSize = true;
            lblOrigOffset.Location = new Point(200, 154);
            lblOrigOffset.Name = "lblOrigOffset";
            lblOrigOffset.Size = new Size(64, 18);
            lblOrigOffset.TabIndex = 38;
            lblOrigOffset.Text = "原幣沖帳";
            // 
            // txtOrigOffset
            // 
            txtOrigOffset.BackColor = Color.LightYellow;
            txtOrigOffset.Location = new Point(274, 150);
            txtOrigOffset.Name = "txtOrigOffset";
            txtOrigOffset.ReadOnly = true;
            txtOrigOffset.Size = new Size(110, 25);
            txtOrigOffset.TabIndex = 39;
            // 
            // panel3
            // 
            panel3.Controls.Add(dataGridView1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 246);
            panel3.Name = "panel3";
            panel3.Size = new Size(1700, 320);
            panel3.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colSource, colAccDate, colNature, colOffsetCode, colOrigUntaxed, colTwdUntaxed, colTax, colAmount, colOrigOffsetAmt, colTwdOffsetAmt, colAllowance, colExDiff, colRemark });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Font = new Font("微軟正黑體", 9F);
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 26;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1700, 320);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellValueChanged += dataGridView1_CellValueChanged;
            // 
            // colSource
            // 
            colSource.HeaderText = "帳款來源";
            colSource.Name = "colSource";
            colSource.ReadOnly = true;
            // 
            // colAccDate
            // 
            colAccDate.HeaderText = "帳款日期";
            colAccDate.Name = "colAccDate";
            colAccDate.ReadOnly = true;
            // 
            // colNature
            // 
            colNature.HeaderText = "收款性質";
            colNature.Name = "colNature";
            colNature.ReadOnly = true;
            // 
            // colOffsetCode
            // 
            colOffsetCode.HeaderText = "沖帳碼";
            colOffsetCode.Name = "colOffsetCode";
            colOffsetCode.ReadOnly = true;
            // 
            // colOrigUntaxed
            // 
            colOrigUntaxed.HeaderText = "原幣未稅";
            colOrigUntaxed.Name = "colOrigUntaxed";
            colOrigUntaxed.ReadOnly = true;
            // 
            // colTwdUntaxed
            // 
            colTwdUntaxed.HeaderText = "台幣未稅";
            colTwdUntaxed.Name = "colTwdUntaxed";
            colTwdUntaxed.ReadOnly = true;
            // 
            // colTax
            // 
            colTax.HeaderText = "稅";
            colTax.Name = "colTax";
            colTax.ReadOnly = true;
            // 
            // colAmount
            // 
            colAmount.HeaderText = "金額";
            colAmount.Name = "colAmount";
            colAmount.ReadOnly = true;
            // 
            // colOrigOffsetAmt
            // 
            colOrigOffsetAmt.HeaderText = "原幣沖帳金額";
            colOrigOffsetAmt.Name = "colOrigOffsetAmt";
            // 
            // colTwdOffsetAmt
            // 
            colTwdOffsetAmt.HeaderText = "台幣沖帳金額";
            colTwdOffsetAmt.Name = "colTwdOffsetAmt";
            // 
            // colAllowance
            // 
            colAllowance.HeaderText = "折讓金額";
            colAllowance.Name = "colAllowance";
            // 
            // colExDiff
            // 
            colExDiff.HeaderText = "匯差";
            colExDiff.Name = "colExDiff";
            // 
            // colRemark
            // 
            colRemark.FillWeight = 160F;
            colRemark.HeaderText = "備註";
            colRemark.Name = "colRemark";
            // 
            // panel3b
            // 
            panel3b.BackColor = Color.Honeydew;
            panel3b.Controls.Add(lblSumCap);
            panel3b.Controls.Add(txtSumOrigUntaxed);
            panel3b.Controls.Add(txtSumTwdUntaxed);
            panel3b.Controls.Add(txtSumTax);
            panel3b.Controls.Add(txtSumAmount);
            panel3b.Controls.Add(txtSumOrigOffsetAmt);
            panel3b.Controls.Add(txtSumTwdOffsetAmt);
            panel3b.Controls.Add(txtSumAllowance);
            panel3b.Controls.Add(txtSumExDiff);
            panel3b.Dock = DockStyle.Bottom;
            panel3b.Location = new Point(0, 566);
            panel3b.Name = "panel3b";
            panel3b.Size = new Size(1700, 34);
            panel3b.TabIndex = 3;
            // 
            // lblSumCap
            // 
            lblSumCap.AutoSize = true;
            lblSumCap.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            lblSumCap.Location = new Point(8, 8);
            lblSumCap.Name = "lblSumCap";
            lblSumCap.Size = new Size(31, 16);
            lblSumCap.TabIndex = 0;
            lblSumCap.Text = "合計";
            // 
            // txtSumOrigUntaxed
            // 
            txtSumOrigUntaxed.Location = new Point(300, 4);
            txtSumOrigUntaxed.Name = "txtSumOrigUntaxed";
            txtSumOrigUntaxed.ReadOnly = true;
            txtSumOrigUntaxed.Size = new Size(100, 25);
            txtSumOrigUntaxed.TabIndex = 1;
            // 
            // txtSumTwdUntaxed
            // 
            txtSumTwdUntaxed.Location = new Point(404, 4);
            txtSumTwdUntaxed.Name = "txtSumTwdUntaxed";
            txtSumTwdUntaxed.ReadOnly = true;
            txtSumTwdUntaxed.Size = new Size(100, 25);
            txtSumTwdUntaxed.TabIndex = 2;
            // 
            // txtSumTax
            // 
            txtSumTax.Location = new Point(508, 4);
            txtSumTax.Name = "txtSumTax";
            txtSumTax.ReadOnly = true;
            txtSumTax.Size = new Size(80, 25);
            txtSumTax.TabIndex = 3;
            // 
            // txtSumAmount
            // 
            txtSumAmount.Location = new Point(592, 4);
            txtSumAmount.Name = "txtSumAmount";
            txtSumAmount.ReadOnly = true;
            txtSumAmount.Size = new Size(100, 25);
            txtSumAmount.TabIndex = 4;
            // 
            // txtSumOrigOffsetAmt
            // 
            txtSumOrigOffsetAmt.Location = new Point(696, 4);
            txtSumOrigOffsetAmt.Name = "txtSumOrigOffsetAmt";
            txtSumOrigOffsetAmt.ReadOnly = true;
            txtSumOrigOffsetAmt.Size = new Size(100, 25);
            txtSumOrigOffsetAmt.TabIndex = 5;
            // 
            // txtSumTwdOffsetAmt
            // 
            txtSumTwdOffsetAmt.Location = new Point(800, 4);
            txtSumTwdOffsetAmt.Name = "txtSumTwdOffsetAmt";
            txtSumTwdOffsetAmt.ReadOnly = true;
            txtSumTwdOffsetAmt.Size = new Size(100, 25);
            txtSumTwdOffsetAmt.TabIndex = 6;
            // 
            // txtSumAllowance
            // 
            txtSumAllowance.Location = new Point(904, 4);
            txtSumAllowance.Name = "txtSumAllowance";
            txtSumAllowance.ReadOnly = true;
            txtSumAllowance.Size = new Size(100, 25);
            txtSumAllowance.TabIndex = 7;
            // 
            // txtSumExDiff
            // 
            txtSumExDiff.Location = new Point(1008, 4);
            txtSumExDiff.Name = "txtSumExDiff";
            txtSumExDiff.ReadOnly = true;
            txtSumExDiff.Size = new Size(100, 25);
            txtSumExDiff.TabIndex = 8;
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
            panel4.Size = new Size(1700, 56);
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
            // PaymentOffsetMaintainControl
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
            Name = "PaymentOffsetMaintainControl";
            Size = new Size(1700, 656);
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
        private Button btnVoucherEntry;
        private Button btnImportDetail;
        private Button btnDelete;
        private Button btnAdd;
        private Button btnModify;
        private Button btnSave;
        private Button btnVerify;
        private Button btnCancelVerify;
        private Button btnOverview;
        private Button btnClose;
        private Panel panel2;
        private Label lblDate;
        private DateTimePicker dtDate;
        private Label lblNo;
        private TextBox txtNo;
        private Label lblCurrency;
        private ComboBox cboCurrency;
        private Label lblExRate;
        private TextBox txtExRate;
        private Label lblSupplierNo;
        private TextBox txtSupplierNo;
        private Label lblSupplierName;
        private TextBox txtSupplierName;
        private Label lblTwdOffset;
        private TextBox txtTwdOffset;
        private Label lblExDiff;
        private TextBox txtExDiff;
        private Label lblAllowance;
        private TextBox txtAllowance;
        private Label lblVoucher;
        private TextBox txtVoucher;
        private Label lblRemark;
        private TextBox txtRemark;
        private Label lblCashAmt;
        private TextBox txtCashAmt;
        private Label lblFee;
        private TextBox txtFee;
        private Label lblBankAmt;
        private TextBox txtBankAmt;
        private Label lblBankCode;
        private ComboBox cboBankCode;
        private Button btnRemit;
        private Label lblCheckAmt;
        private TextBox txtCheckAmt;
        private Label lblCheckNo;
        private TextBox txtCheckNo;
        private Button btnCheck;
        private Label lblPayTotal;
        private TextBox txtPayTotal;
        private Label lblOrigOffset;
        private TextBox txtOrigOffset;
        private Panel panel3;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn colSource;
        private DataGridViewTextBoxColumn colAccDate;
        private DataGridViewTextBoxColumn colNature;
        private DataGridViewTextBoxColumn colOffsetCode;
        private DataGridViewTextBoxColumn colOrigUntaxed;
        private DataGridViewTextBoxColumn colTwdUntaxed;
        private DataGridViewTextBoxColumn colTax;
        private DataGridViewTextBoxColumn colAmount;
        private DataGridViewTextBoxColumn colOrigOffsetAmt;
        private DataGridViewTextBoxColumn colTwdOffsetAmt;
        private DataGridViewTextBoxColumn colAllowance;
        private DataGridViewTextBoxColumn colExDiff;
        private DataGridViewTextBoxColumn colRemark;
        private Panel panel3b;
        private Label lblSumCap;
        private TextBox txtSumOrigUntaxed;
        private TextBox txtSumTwdUntaxed;
        private TextBox txtSumTax;
        private TextBox txtSumAmount;
        private TextBox txtSumOrigOffsetAmt;
        private TextBox txtSumTwdOffsetAmt;
        private TextBox txtSumAllowance;
        private TextBox txtSumExDiff;
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
    }
}
