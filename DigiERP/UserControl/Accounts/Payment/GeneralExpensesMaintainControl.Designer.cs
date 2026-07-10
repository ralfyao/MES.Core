using System.Drawing;
using System.Windows.Forms;

namespace DigiERP.UserControl.Accounts.Payment
{
    partial class GeneralExpensesMaintainControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GeneralExpensesMaintainControl));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            lblTitle = new Label();
            btnVoucher = new Button();
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
            lblSupplier = new Label();
            cboSupplier = new ComboBox();
            btnSelectSupplier = new Button();
            lblSupplierName = new Label();
            txtSupplierName = new TextBox();
            lblContact = new Label();
            txtContact = new TextBox();
            lblPaymentTerm = new Label();
            cboPaymentTerm = new ComboBox();
            lblCurrency = new Label();
            cboCurrency = new ComboBox();
            lblExRate = new Label();
            txtExRate = new TextBox();
            lblPurchaser = new Label();
            cboPurchaser = new ComboBox();
            lblPurchaserName = new Label();
            lblVoid = new Label();
            chkVoid = new CheckBox();
            lblCategory = new Label();
            cboCategory = new ComboBox();
            lblTaxRate = new Label();
            cboTaxRate = new ComboBox();
            lblVoucherNo = new Label();
            txtVoucherNo = new TextBox();
            lblNote = new Label();
            txtNote = new TextBox();
            btnVoidAll = new Button();
            panel3 = new Panel();
            dataGridView1 = new DataGridView();
            colItemNo = new DataGridViewComboBoxColumn();
            colItemName = new DataGridViewTextBoxColumn();
            colOrigAmt = new DataGridViewTextBoxColumn();
            colTwdAmt = new DataGridViewTextBoxColumn();
            colTax = new DataGridViewTextBoxColumn();
            colAmount = new DataGridViewTextBoxColumn();
            colRemark = new DataGridViewTextBoxColumn();
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
            textBox1 = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Honeydew;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(lblTitle);
            panel1.Controls.Add(btnVoucher);
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
            panel1.Size = new Size(1539, 56);
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
            lblTitle.Size = new Size(100, 23);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "總務支出單";
            // 
            // btnVoucher
            // 
            btnVoucher.BackColor = Color.Gainsboro;
            btnVoucher.FlatStyle = FlatStyle.Flat;
            btnVoucher.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            btnVoucher.Location = new Point(340, 12);
            btnVoucher.Name = "btnVoucher";
            btnVoucher.Size = new Size(98, 32);
            btnVoucher.TabIndex = 1;
            btnVoucher.Text = "會計傳票";
            btnVoucher.UseVisualStyleBackColor = false;
            btnVoucher.Click += btnVoucher_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Firebrick;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(444, 12);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(98, 32);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "刪除紀錄";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Gainsboro;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            btnAdd.Location = new Point(548, 12);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(98, 32);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "新增";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnModify
            // 
            btnModify.BackColor = Color.Gainsboro;
            btnModify.FlatStyle = FlatStyle.Flat;
            btnModify.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            btnModify.Location = new Point(652, 12);
            btnModify.Name = "btnModify";
            btnModify.Size = new Size(98, 32);
            btnModify.TabIndex = 4;
            btnModify.Text = "修改";
            btnModify.UseVisualStyleBackColor = false;
            btnModify.Click += btnModify_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Gainsboro;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            btnSave.Location = new Point(756, 12);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(98, 32);
            btnSave.TabIndex = 5;
            btnSave.Text = "儲存";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnVerify
            // 
            btnVerify.BackColor = Color.Gainsboro;
            btnVerify.FlatStyle = FlatStyle.Flat;
            btnVerify.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            btnVerify.Location = new Point(860, 12);
            btnVerify.Name = "btnVerify";
            btnVerify.Size = new Size(98, 32);
            btnVerify.TabIndex = 6;
            btnVerify.Text = "覆核";
            btnVerify.UseVisualStyleBackColor = false;
            btnVerify.Click += btnVerify_Click;
            // 
            // btnCancelVerify
            // 
            btnCancelVerify.BackColor = Color.Gainsboro;
            btnCancelVerify.FlatStyle = FlatStyle.Flat;
            btnCancelVerify.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            btnCancelVerify.Location = new Point(964, 12);
            btnCancelVerify.Name = "btnCancelVerify";
            btnCancelVerify.Size = new Size(98, 32);
            btnCancelVerify.TabIndex = 7;
            btnCancelVerify.Text = "取消覆核";
            btnCancelVerify.UseVisualStyleBackColor = false;
            btnCancelVerify.Click += btnCancelVerify_Click;
            // 
            // btnPrint
            // 
            btnPrint.BackColor = Color.Gainsboro;
            btnPrint.FlatStyle = FlatStyle.Flat;
            btnPrint.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            btnPrint.Location = new Point(1068, 12);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(98, 32);
            btnPrint.TabIndex = 8;
            btnPrint.Text = "列印";
            btnPrint.UseVisualStyleBackColor = false;
            btnPrint.Click += btnPrint_Click;
            // 
            // btnOverview
            // 
            btnOverview.BackColor = Color.Gainsboro;
            btnOverview.FlatStyle = FlatStyle.Flat;
            btnOverview.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            btnOverview.Location = new Point(1172, 12);
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
            btnClose.Location = new Point(1276, 12);
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
            panel2.Controls.Add(lblSupplier);
            panel2.Controls.Add(cboSupplier);
            panel2.Controls.Add(btnSelectSupplier);
            panel2.Controls.Add(lblSupplierName);
            panel2.Controls.Add(txtSupplierName);
            panel2.Controls.Add(lblContact);
            panel2.Controls.Add(txtContact);
            panel2.Controls.Add(lblPaymentTerm);
            panel2.Controls.Add(cboPaymentTerm);
            panel2.Controls.Add(lblCurrency);
            panel2.Controls.Add(cboCurrency);
            panel2.Controls.Add(lblExRate);
            panel2.Controls.Add(txtExRate);
            panel2.Controls.Add(lblPurchaser);
            panel2.Controls.Add(cboPurchaser);
            panel2.Controls.Add(lblPurchaserName);
            panel2.Controls.Add(lblVoid);
            panel2.Controls.Add(chkVoid);
            panel2.Controls.Add(lblCategory);
            panel2.Controls.Add(cboCategory);
            panel2.Controls.Add(lblTaxRate);
            panel2.Controls.Add(cboTaxRate);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(lblVoucherNo);
            panel2.Controls.Add(txtVoucherNo);
            panel2.Controls.Add(lblNote);
            panel2.Controls.Add(txtNote);
            panel2.Controls.Add(btnVoidAll);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 56);
            panel2.Name = "panel2";
            panel2.Size = new Size(1539, 116);
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
            lblNo.Location = new Point(216, 8);
            lblNo.Name = "lblNo";
            lblNo.Size = new Size(36, 18);
            lblNo.TabIndex = 2;
            lblNo.Text = "單號";
            // 
            // txtNo
            // 
            txtNo.Location = new Point(270, 4);
            txtNo.Name = "txtNo";
            txtNo.ReadOnly = true;
            txtNo.Size = new Size(150, 25);
            txtNo.TabIndex = 3;
            // 
            // lblSupplier
            // 
            lblSupplier.AutoSize = true;
            lblSupplier.Location = new Point(436, 6);
            lblSupplier.Name = "lblSupplier";
            lblSupplier.Size = new Size(64, 18);
            lblSupplier.TabIndex = 4;
            lblSupplier.Text = "廠商編號";
            // 
            // cboSupplier
            // 
            cboSupplier.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSupplier.FormattingEnabled = true;
            cboSupplier.Location = new Point(510, 2);
            cboSupplier.Name = "cboSupplier";
            cboSupplier.Size = new Size(150, 25);
            cboSupplier.TabIndex = 5;
            cboSupplier.SelectedIndexChanged += cboSupplier_SelectedIndexChanged;
            //
            // btnSelectSupplier
            //
            btnSelectSupplier.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            btnSelectSupplier.Location = new Point(662, 2);
            btnSelectSupplier.Name = "btnSelectSupplier";
            btnSelectSupplier.Size = new Size(30, 25);
            btnSelectSupplier.TabIndex = 30;
            btnSelectSupplier.Text = "🔍";
            btnSelectSupplier.UseVisualStyleBackColor = true;
            btnSelectSupplier.Click += btnSelectSupplier_Click;
            //
            // lblSupplierName
            //
            lblSupplierName.AutoSize = true;
            lblSupplierName.Location = new Point(706, 6);
            lblSupplierName.Name = "lblSupplierName";
            lblSupplierName.Size = new Size(64, 18);
            lblSupplierName.TabIndex = 6;
            lblSupplierName.Text = "廠商名稱";
            //
            // txtSupplierName
            //
            txtSupplierName.Location = new Point(780, 2);
            txtSupplierName.Name = "txtSupplierName";
            txtSupplierName.ReadOnly = true;
            txtSupplierName.Size = new Size(220, 25);
            txtSupplierName.TabIndex = 7;
            // 
            // lblContact
            // 
            lblContact.AutoSize = true;
            lblContact.Location = new Point(8, 46);
            lblContact.Name = "lblContact";
            lblContact.Size = new Size(50, 18);
            lblContact.TabIndex = 8;
            lblContact.Text = "聯絡人";
            // 
            // txtContact
            // 
            txtContact.Location = new Point(62, 42);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(142, 25);
            txtContact.TabIndex = 9;
            // 
            // lblPaymentTerm
            // 
            lblPaymentTerm.AutoSize = true;
            lblPaymentTerm.Location = new Point(216, 44);
            lblPaymentTerm.Name = "lblPaymentTerm";
            lblPaymentTerm.Size = new Size(64, 18);
            lblPaymentTerm.TabIndex = 10;
            lblPaymentTerm.Text = "付款條件";
            // 
            // cboPaymentTerm
            // 
            cboPaymentTerm.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPaymentTerm.FormattingEnabled = true;
            cboPaymentTerm.Location = new Point(290, 40);
            cboPaymentTerm.Name = "cboPaymentTerm";
            cboPaymentTerm.Size = new Size(130, 25);
            cboPaymentTerm.TabIndex = 11;
            // 
            // lblCurrency
            // 
            lblCurrency.AutoSize = true;
            lblCurrency.Location = new Point(437, 43);
            lblCurrency.Name = "lblCurrency";
            lblCurrency.Size = new Size(36, 18);
            lblCurrency.TabIndex = 12;
            lblCurrency.Text = "幣別";
            // 
            // cboCurrency
            // 
            cboCurrency.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCurrency.FormattingEnabled = true;
            cboCurrency.Location = new Point(486, 40);
            cboCurrency.Name = "cboCurrency";
            cboCurrency.Size = new Size(62, 25);
            cboCurrency.TabIndex = 13;
            cboCurrency.SelectedIndexChanged += cboCurrency_SelectedIndexChanged;
            // 
            // lblExRate
            // 
            lblExRate.AutoSize = true;
            lblExRate.Location = new Point(556, 42);
            lblExRate.Name = "lblExRate";
            lblExRate.Size = new Size(36, 18);
            lblExRate.TabIndex = 14;
            lblExRate.Text = "匯率";
            // 
            // txtExRate
            // 
            txtExRate.Location = new Point(610, 38);
            txtExRate.Name = "txtExRate";
            txtExRate.Size = new Size(50, 25);
            txtExRate.TabIndex = 15;
            // 
            // lblPurchaser
            // 
            lblPurchaser.AutoSize = true;
            lblPurchaser.Location = new Point(672, 42);
            lblPurchaser.Name = "lblPurchaser";
            lblPurchaser.Size = new Size(64, 18);
            lblPurchaser.TabIndex = 16;
            lblPurchaser.Text = "採購人員";
            // 
            // cboPurchaser
            // 
            cboPurchaser.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPurchaser.FormattingEnabled = true;
            cboPurchaser.Location = new Point(746, 38);
            cboPurchaser.Name = "cboPurchaser";
            cboPurchaser.Size = new Size(100, 25);
            cboPurchaser.TabIndex = 17;
            cboPurchaser.SelectedIndexChanged += cboPurchaser_SelectedIndexChanged;
            // 
            // lblPurchaserName
            // 
            lblPurchaserName.AutoSize = true;
            lblPurchaserName.Location = new Point(884, 46);
            lblPurchaserName.Name = "lblPurchaserName";
            lblPurchaserName.Size = new Size(0, 18);
            lblPurchaserName.TabIndex = 18;
            // 
            // lblVoid
            // 
            lblVoid.AutoSize = true;
            lblVoid.Location = new Point(968, 44);
            lblVoid.Name = "lblVoid";
            lblVoid.Size = new Size(36, 18);
            lblVoid.TabIndex = 19;
            lblVoid.Text = "作廢";
            // 
            // chkVoid
            // 
            chkVoid.Location = new Point(1016, 42);
            chkVoid.Name = "chkVoid";
            chkVoid.Size = new Size(24, 24);
            chkVoid.TabIndex = 20;
            chkVoid.UseVisualStyleBackColor = true;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(8, 82);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(64, 18);
            lblCategory.TabIndex = 21;
            lblCategory.Text = "支出類別";
            // 
            // cboCategory
            // 
            cboCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCategory.FormattingEnabled = true;
            cboCategory.Location = new Point(82, 78);
            cboCategory.Name = "cboCategory";
            cboCategory.Size = new Size(120, 25);
            cboCategory.TabIndex = 22;
            // 
            // lblTaxRate
            // 
            lblTaxRate.AutoSize = true;
            lblTaxRate.Location = new Point(212, 82);
            lblTaxRate.Name = "lblTaxRate";
            lblTaxRate.Size = new Size(64, 18);
            lblTaxRate.TabIndex = 23;
            lblTaxRate.Text = "營業稅率(%)";
            // 
            // cboTaxRate
            // 
            cboTaxRate.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTaxRate.FormattingEnabled = true;
            cboTaxRate.Location = new Point(286, 78);
            cboTaxRate.Name = "cboTaxRate";
            cboTaxRate.Size = new Size(130, 25);
            cboTaxRate.TabIndex = 24;
            // 
            // lblVoucherNo
            // 
            lblVoucherNo.AutoSize = true;
            lblVoucherNo.Location = new Point(440, 80);
            lblVoucherNo.Name = "lblVoucherNo";
            lblVoucherNo.Size = new Size(36, 18);
            lblVoucherNo.TabIndex = 25;
            lblVoucherNo.Text = "傳票";
            // 
            // txtVoucherNo
            // 
            txtVoucherNo.Location = new Point(494, 76);
            txtVoucherNo.Name = "txtVoucherNo";
            txtVoucherNo.ReadOnly = true;
            txtVoucherNo.Size = new Size(110, 25);
            txtVoucherNo.TabIndex = 26;
            // 
            // lblNote
            // 
            lblNote.AutoSize = true;
            lblNote.Location = new Point(672, 84);
            lblNote.Name = "lblNote";
            lblNote.Size = new Size(64, 18);
            lblNote.TabIndex = 27;
            lblNote.Text = "注意事項";
            // 
            // txtNote
            // 
            txtNote.Location = new Point(752, 78);
            txtNote.Name = "txtNote";
            txtNote.Size = new Size(212, 25);
            txtNote.TabIndex = 28;
            // 
            // btnVoidAll
            // 
            btnVoidAll.BackColor = Color.LightSalmon;
            btnVoidAll.FlatStyle = FlatStyle.Flat;
            btnVoidAll.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            btnVoidAll.Location = new Point(972, 76);
            btnVoidAll.Name = "btnVoidAll";
            btnVoidAll.Size = new Size(100, 28);
            btnVoidAll.TabIndex = 29;
            btnVoidAll.Text = "全單作廢";
            btnVoidAll.UseVisualStyleBackColor = false;
            btnVoidAll.Click += btnVoidAll_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(dataGridView1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 172);
            panel3.Name = "panel3";
            panel3.Size = new Size(1539, 364);
            panel3.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colItemNo, colItemName, colOrigAmt, colTwdAmt, colTax, colAmount, colRemark });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Font = new Font("微軟正黑體", 9F);
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 26;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1539, 364);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellValueChanged += dataGridView1_CellValueChanged;
            dataGridView1.CurrentCellDirtyStateChanged += dataGridView1_CurrentCellDirtyStateChanged;
            dataGridView1.CellEndEdit += dataGridView1_CellEndEdit;
            // 
            // colItemNo
            // 
            colItemNo.HeaderText = "項目編號";
            colItemNo.Name = "colItemNo";
            // 
            // colItemName
            // 
            colItemName.FillWeight = 150F;
            colItemName.HeaderText = "項目名稱";
            colItemName.Name = "colItemName";
            colItemName.ReadOnly = true;
            // 
            // colOrigAmt
            // 
            colOrigAmt.HeaderText = "原幣未稅";
            colOrigAmt.Name = "colOrigAmt";
            // 
            // colTwdAmt
            // 
            colTwdAmt.HeaderText = "台幣未稅";
            colTwdAmt.Name = "colTwdAmt";
            colTwdAmt.ReadOnly = true;
            //
            // colTax
            //
            colTax.HeaderText = "稅額";
            colTax.Name = "colTax";
            colTax.ReadOnly = true;
            //
            // colAmount
            //
            colAmount.HeaderText = "金額";
            colAmount.Name = "colAmount";
            colAmount.ReadOnly = true;
            // 
            // colRemark
            // 
            colRemark.FillWeight = 200F;
            colRemark.HeaderText = "備註";
            colRemark.Name = "colRemark";
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
            panel4.Location = new Point(0, 536);
            panel4.Name = "panel4";
            panel4.Size = new Size(1539, 120);
            panel4.TabIndex = 3;
            // 
            // lblReviewerCap
            // 
            lblReviewerCap.AutoSize = true;
            lblReviewerCap.Location = new Point(10, 70);
            lblReviewerCap.Name = "lblReviewerCap";
            lblReviewerCap.Size = new Size(64, 18);
            lblReviewerCap.TabIndex = 0;
            lblReviewerCap.Text = "覆核人員";
            // 
            // txtReviewer
            // 
            txtReviewer.Location = new Point(92, 66);
            txtReviewer.Name = "txtReviewer";
            txtReviewer.ReadOnly = true;
            txtReviewer.Size = new Size(120, 25);
            txtReviewer.TabIndex = 1;
            // 
            // lblReviewDateCap
            // 
            lblReviewDateCap.AutoSize = true;
            lblReviewDateCap.Location = new Point(302, 70);
            lblReviewDateCap.Name = "lblReviewDateCap";
            lblReviewDateCap.Size = new Size(50, 18);
            lblReviewDateCap.TabIndex = 2;
            lblReviewDateCap.Text = "核准日";
            // 
            // txtReviewDate
            // 
            txtReviewDate.Location = new Point(372, 66);
            txtReviewDate.Name = "txtReviewDate";
            txtReviewDate.ReadOnly = true;
            txtReviewDate.Size = new Size(120, 25);
            txtReviewDate.TabIndex = 3;
            // 
            // lblModifierCap
            // 
            lblModifierCap.AutoSize = true;
            lblModifierCap.Location = new Point(514, 72);
            lblModifierCap.Name = "lblModifierCap";
            lblModifierCap.Size = new Size(64, 18);
            lblModifierCap.TabIndex = 4;
            lblModifierCap.Text = "修改人員";
            // 
            // txtModifier
            // 
            txtModifier.Location = new Point(596, 68);
            txtModifier.Name = "txtModifier";
            txtModifier.ReadOnly = true;
            txtModifier.Size = new Size(120, 25);
            txtModifier.TabIndex = 5;
            // 
            // lblModifyDateCap
            // 
            lblModifyDateCap.AutoSize = true;
            lblModifyDateCap.Location = new Point(806, 72);
            lblModifyDateCap.Name = "lblModifyDateCap";
            lblModifyDateCap.Size = new Size(50, 18);
            lblModifyDateCap.TabIndex = 6;
            lblModifyDateCap.Text = "修改日";
            // 
            // txtModifyDate
            // 
            txtModifyDate.Location = new Point(876, 68);
            txtModifyDate.Name = "txtModifyDate";
            txtModifyDate.ReadOnly = true;
            txtModifyDate.Size = new Size(120, 25);
            txtModifyDate.TabIndex = 7;
            // 
            // lblCreatorCap
            // 
            lblCreatorCap.AutoSize = true;
            lblCreatorCap.Location = new Point(1010, 72);
            lblCreatorCap.Name = "lblCreatorCap";
            lblCreatorCap.Size = new Size(64, 18);
            lblCreatorCap.TabIndex = 8;
            lblCreatorCap.Text = "製單人員";
            // 
            // txtCreator
            // 
            txtCreator.Location = new Point(1092, 68);
            txtCreator.Name = "txtCreator";
            txtCreator.ReadOnly = true;
            txtCreator.Size = new Size(120, 25);
            txtCreator.TabIndex = 9;
            // 
            // lblCreateDateCap
            // 
            lblCreateDateCap.AutoSize = true;
            lblCreateDateCap.Location = new Point(1302, 72);
            lblCreateDateCap.Name = "lblCreateDateCap";
            lblCreateDateCap.Size = new Size(50, 18);
            lblCreateDateCap.TabIndex = 10;
            lblCreateDateCap.Text = "建檔日";
            // 
            // txtCreateDate
            // 
            txtCreateDate.Location = new Point(1372, 68);
            txtCreateDate.Name = "txtCreateDate";
            txtCreateDate.ReadOnly = true;
            txtCreateDate.Size = new Size(120, 25);
            txtCreateDate.TabIndex = 11;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(494, 80);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(162, 25);
            textBox1.TabIndex = 26;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(440, 84);
            label1.Name = "label1";
            label1.Size = new Size(36, 18);
            label1.TabIndex = 25;
            label1.Text = "傳票";
            // 
            // GeneralExpensesMaintainControl
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel3);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("微軟正黑體", 10F);
            Margin = new Padding(4);
            Name = "GeneralExpensesMaintainControl";
            Size = new Size(1539, 656);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label lblTitle;
        private Button btnVoucher;
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
        private Label lblSupplier;
        private ComboBox cboSupplier;
        private Button btnSelectSupplier;
        private Label lblSupplierName;
        private TextBox txtSupplierName;
        private Label lblContact;
        private TextBox txtContact;
        private Label lblPaymentTerm;
        private ComboBox cboPaymentTerm;
        private Label lblCurrency;
        private ComboBox cboCurrency;
        private Label lblExRate;
        private TextBox txtExRate;
        private Label lblPurchaser;
        private ComboBox cboPurchaser;
        private Label lblPurchaserName;
        private Label lblVoid;
        private CheckBox chkVoid;
        private Label lblCategory;
        private ComboBox cboCategory;
        private Label lblTaxRate;
        private ComboBox cboTaxRate;
        private Label lblVoucherNo;
        private TextBox txtVoucherNo;
        private Label lblNote;
        private TextBox txtNote;
        private Button btnVoidAll;
        private Panel panel3;
        private DataGridView dataGridView1;
        private DataGridViewComboBoxColumn colItemNo;
        private DataGridViewTextBoxColumn colItemName;
        private DataGridViewTextBoxColumn colOrigAmt;
        private DataGridViewTextBoxColumn colTwdAmt;
        private DataGridViewTextBoxColumn colTax;
        private DataGridViewTextBoxColumn colAmount;
        private DataGridViewTextBoxColumn colRemark;
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
        private Label label1;
        private TextBox textBox1;
    }
}
