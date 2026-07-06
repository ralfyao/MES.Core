using System.Drawing;
using System.Windows.Forms;

namespace DigiERP.UserControl.Supplier.Procurement
{
    partial class ProcurementMaintainControl
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
            panelToolbar = new Panel();
            lblTitle = new Label();
            btnAllocate = new Button();
            btnItemClose = new Button();
            btnDeleteRecord = new Button();
            btnLog = new Button();
            btnCopy = new Button();
            btnAddNew = new Button();
            btnModify = new Button();
            btnSave = new Button();
            btnActivate = new Button();
            btnCancelActivate = new Button();
            btnPrint = new Button();
            btnOverview = new Button();
            btnClose = new Button();
            lblMode = new Label();
            panelHeader = new Panel();
            lblDate = new Label();
            dtDate = new DateTimePicker();
            lblNo = new Label();
            txtNo = new TextBox();
            lblSupplierNo = new Label();
            cboSupplierNo = new ComboBox();
            btnSelectSupplier = new Button();
            lblSupplierName = new Label();
            txtSupplierName = new TextBox();
            lblContact = new Label();
            cboContact = new ComboBox();
            btnSelectContact = new Button();
            lblTaxRate = new Label();
            cboTaxRate = new ComboBox();
            lblCurrency = new Label();
            cboCurrency = new ComboBox();
            lblExRate = new Label();
            txtExRate = new TextBox();
            lblDeliveryAddr = new Label();
            cboDeliveryAddr = new ComboBox();
            lblPurchaseCategory = new Label();
            cboPurchaseCategory = new ComboBox();
            lblPayTerm = new Label();
            cboPayTerm = new ComboBox();
            lblShipMethod = new Label();
            txtShipMethod = new TextBox();
            lblPurchaser = new Label();
            cboPurchaser = new ComboBox();
            lblPurchaserName = new Label();
            chkClosed = new CheckBox();
            btnVoidAll = new Button();
            lblNote = new Label();
            txtNote = new TextBox();
            lblTradeTerm = new Label();
            txtTradeTerm = new TextBox();
            lblDeliveryDate = new Label();
            dtDeliveryDate = new DateTimePicker();
            panelGrid = new Panel();
            dgvDetail = new DataGridView();
            colItemNo = new DataGridViewTextBoxColumn();
            colItemSpec = new DataGridViewTextBoxColumn();
            colQty = new DataGridViewTextBoxColumn();
            colUnit = new DataGridViewTextBoxColumn();
            colUntaxedAmt = new DataGridViewTextBoxColumn();
            colPurchaseAmt = new DataGridViewTextBoxColumn();
            colProject = new DataGridViewTextBoxColumn();
            colSample = new DataGridViewCheckBoxColumn();
            colNote = new DataGridViewTextBoxColumn();
            colReqSerial = new DataGridViewTextBoxColumn();
            colOutsourceType = new DataGridViewTextBoxColumn();
            panelFooter = new Panel();
            lblSumUntaxed = new Label();
            txtSumUntaxed = new TextBox();
            lblSumTax = new Label();
            txtSumTax = new TextBox();
            lblSumPurchase = new Label();
            txtSumPurchase = new TextBox();
            lblCreatorCaption = new Label();
            txtCreator = new TextBox();
            txtCreateDate = new TextBox();
            lblModifierCaption = new Label();
            txtModifier = new TextBox();
            txtModifyDate = new TextBox();
            lblApproverCaption = new Label();
            txtApprover = new TextBox();
            txtApproveDate = new TextBox();
            panelToolbar.SuspendLayout();
            panelHeader.SuspendLayout();
            panelGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDetail).BeginInit();
            panelFooter.SuspendLayout();
            SuspendLayout();
            // 
            // panelToolbar
            // 
            panelToolbar.BackColor = Color.WhiteSmoke;
            panelToolbar.Controls.Add(lblTitle);
            panelToolbar.Controls.Add(btnAllocate);
            panelToolbar.Controls.Add(btnItemClose);
            panelToolbar.Controls.Add(btnDeleteRecord);
            panelToolbar.Controls.Add(btnLog);
            panelToolbar.Controls.Add(btnCopy);
            panelToolbar.Controls.Add(btnAddNew);
            panelToolbar.Controls.Add(btnModify);
            panelToolbar.Controls.Add(btnSave);
            panelToolbar.Controls.Add(btnActivate);
            panelToolbar.Controls.Add(btnCancelActivate);
            panelToolbar.Controls.Add(btnPrint);
            panelToolbar.Controls.Add(btnOverview);
            panelToolbar.Controls.Add(btnClose);
            panelToolbar.Controls.Add(lblMode);
            panelToolbar.Dock = DockStyle.Top;
            panelToolbar.Location = new Point(0, 0);
            panelToolbar.Name = "panelToolbar";
            panelToolbar.Size = new Size(1450, 44);
            panelToolbar.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("微軟正黑體", 12F, FontStyle.Bold);
            lblTitle.Location = new Point(88, 12);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(58, 21);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "採購單";
            // 
            // btnAllocate
            // 
            btnAllocate.BackColor = Color.SteelBlue;
            btnAllocate.FlatStyle = FlatStyle.Flat;
            btnAllocate.ForeColor = Color.White;
            btnAllocate.Location = new Point(160, 8);
            btnAllocate.Name = "btnAllocate";
            btnAllocate.Size = new Size(95, 28);
            btnAllocate.TabIndex = 1;
            btnAllocate.Text = "請購分配";
            btnAllocate.UseVisualStyleBackColor = false;
            btnAllocate.Click += btnAllocate_Click;
            // 
            // btnItemClose
            // 
            btnItemClose.BackColor = Color.DarkOrange;
            btnItemClose.FlatStyle = FlatStyle.Flat;
            btnItemClose.ForeColor = Color.White;
            btnItemClose.Location = new Point(258, 8);
            btnItemClose.Name = "btnItemClose";
            btnItemClose.Size = new Size(95, 28);
            btnItemClose.TabIndex = 2;
            btnItemClose.Text = "分項結案";
            btnItemClose.UseVisualStyleBackColor = false;
            btnItemClose.Visible = false;
            btnItemClose.Click += btnItemClose_Click;
            // 
            // btnDeleteRecord
            // 
            btnDeleteRecord.BackColor = Color.Firebrick;
            btnDeleteRecord.FlatStyle = FlatStyle.Flat;
            btnDeleteRecord.ForeColor = Color.White;
            btnDeleteRecord.Location = new Point(356, 8);
            btnDeleteRecord.Name = "btnDeleteRecord";
            btnDeleteRecord.Size = new Size(95, 28);
            btnDeleteRecord.TabIndex = 3;
            btnDeleteRecord.Text = "刪除紀錄";
            btnDeleteRecord.UseVisualStyleBackColor = false;
            btnDeleteRecord.Visible = false;
            btnDeleteRecord.Click += btnDeleteRecord_Click;
            // 
            // btnLog
            // 
            btnLog.BackColor = Color.DarkSlateBlue;
            btnLog.FlatStyle = FlatStyle.Flat;
            btnLog.ForeColor = Color.White;
            btnLog.Location = new Point(454, 8);
            btnLog.Name = "btnLog";
            btnLog.Size = new Size(95, 28);
            btnLog.TabIndex = 4;
            btnLog.Text = "填入日誌";
            btnLog.UseVisualStyleBackColor = false;
            btnLog.Visible = false;
            btnLog.Click += btnLog_Click;
            // 
            // btnCopy
            // 
            btnCopy.BackColor = Color.Gainsboro;
            btnCopy.FlatStyle = FlatStyle.Flat;
            btnCopy.Location = new Point(552, 8);
            btnCopy.Name = "btnCopy";
            btnCopy.Size = new Size(80, 28);
            btnCopy.TabIndex = 5;
            btnCopy.Text = "複製";
            btnCopy.UseVisualStyleBackColor = false;
            btnCopy.Visible = false;
            btnCopy.Click += btnCopy_Click;
            // 
            // btnAddNew
            // 
            btnAddNew.BackColor = Color.Gainsboro;
            btnAddNew.FlatStyle = FlatStyle.Flat;
            btnAddNew.Location = new Point(635, 8);
            btnAddNew.Name = "btnAddNew";
            btnAddNew.Size = new Size(80, 28);
            btnAddNew.TabIndex = 6;
            btnAddNew.Text = "新增";
            btnAddNew.UseVisualStyleBackColor = false;
            btnAddNew.Click += btnAddNew_Click;
            // 
            // btnModify
            // 
            btnModify.BackColor = Color.Gainsboro;
            btnModify.FlatStyle = FlatStyle.Flat;
            btnModify.Location = new Point(718, 8);
            btnModify.Name = "btnModify";
            btnModify.Size = new Size(80, 28);
            btnModify.TabIndex = 7;
            btnModify.Text = "修改";
            btnModify.UseVisualStyleBackColor = false;
            btnModify.Click += btnModify_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Gainsboro;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Location = new Point(801, 8);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(80, 28);
            btnSave.TabIndex = 8;
            btnSave.Text = "儲存";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnActivate
            // 
            btnActivate.BackColor = Color.Gainsboro;
            btnActivate.FlatStyle = FlatStyle.Flat;
            btnActivate.Location = new Point(884, 8);
            btnActivate.Name = "btnActivate";
            btnActivate.Size = new Size(80, 28);
            btnActivate.TabIndex = 9;
            btnActivate.Text = "生效";
            btnActivate.UseVisualStyleBackColor = false;
            btnActivate.Click += btnActivate_Click;
            // 
            // btnCancelActivate
            // 
            btnCancelActivate.BackColor = Color.Gainsboro;
            btnCancelActivate.FlatStyle = FlatStyle.Flat;
            btnCancelActivate.Location = new Point(967, 8);
            btnCancelActivate.Name = "btnCancelActivate";
            btnCancelActivate.Size = new Size(83, 28);
            btnCancelActivate.TabIndex = 10;
            btnCancelActivate.Text = "取消生效";
            btnCancelActivate.UseVisualStyleBackColor = false;
            btnCancelActivate.Click += btnCancelActivate_Click;
            // 
            // btnPrint
            // 
            btnPrint.BackColor = Color.Gainsboro;
            btnPrint.FlatStyle = FlatStyle.Flat;
            btnPrint.Location = new Point(1054, 8);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(80, 28);
            btnPrint.TabIndex = 11;
            btnPrint.Text = "列印";
            btnPrint.UseVisualStyleBackColor = false;
            btnPrint.Visible = false;
            btnPrint.Click += btnPrint_Click;
            // 
            // btnOverview
            // 
            btnOverview.BackColor = Color.Gainsboro;
            btnOverview.FlatStyle = FlatStyle.Flat;
            btnOverview.Location = new Point(1137, 8);
            btnOverview.Name = "btnOverview";
            btnOverview.Size = new Size(80, 28);
            btnOverview.TabIndex = 12;
            btnOverview.Text = "總覽";
            btnOverview.UseVisualStyleBackColor = false;
            btnOverview.Visible = false;
            btnOverview.Click += btnOverview_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Gainsboro;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Location = new Point(1220, 8);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(80, 28);
            btnClose.TabIndex = 13;
            btnClose.Text = "關閉";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // lblMode
            // 
            lblMode.AutoSize = true;
            lblMode.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            lblMode.ForeColor = Color.Red;
            lblMode.Location = new Point(16, 12);
            lblMode.Name = "lblMode";
            lblMode.Size = new Size(36, 18);
            lblMode.TabIndex = 14;
            lblMode.Text = "新增";
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.Lavender;
            panelHeader.Controls.Add(lblDate);
            panelHeader.Controls.Add(dtDate);
            panelHeader.Controls.Add(lblNo);
            panelHeader.Controls.Add(txtNo);
            panelHeader.Controls.Add(lblSupplierNo);
            panelHeader.Controls.Add(cboSupplierNo);
            panelHeader.Controls.Add(btnSelectSupplier);
            panelHeader.Controls.Add(lblSupplierName);
            panelHeader.Controls.Add(txtSupplierName);
            panelHeader.Controls.Add(lblContact);
            panelHeader.Controls.Add(cboContact);
            panelHeader.Controls.Add(btnSelectContact);
            panelHeader.Controls.Add(lblTaxRate);
            panelHeader.Controls.Add(cboTaxRate);
            panelHeader.Controls.Add(lblCurrency);
            panelHeader.Controls.Add(cboCurrency);
            panelHeader.Controls.Add(lblExRate);
            panelHeader.Controls.Add(txtExRate);
            panelHeader.Controls.Add(lblDeliveryAddr);
            panelHeader.Controls.Add(cboDeliveryAddr);
            panelHeader.Controls.Add(lblPurchaseCategory);
            panelHeader.Controls.Add(cboPurchaseCategory);
            panelHeader.Controls.Add(lblPayTerm);
            panelHeader.Controls.Add(cboPayTerm);
            panelHeader.Controls.Add(lblShipMethod);
            panelHeader.Controls.Add(txtShipMethod);
            panelHeader.Controls.Add(lblPurchaser);
            panelHeader.Controls.Add(cboPurchaser);
            panelHeader.Controls.Add(lblPurchaserName);
            panelHeader.Controls.Add(chkClosed);
            panelHeader.Controls.Add(btnVoidAll);
            panelHeader.Controls.Add(lblNote);
            panelHeader.Controls.Add(txtNote);
            panelHeader.Controls.Add(lblTradeTerm);
            panelHeader.Controls.Add(txtTradeTerm);
            panelHeader.Controls.Add(lblDeliveryDate);
            panelHeader.Controls.Add(dtDeliveryDate);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 44);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1450, 160);
            panelHeader.TabIndex = 1;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Location = new Point(10, 12);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(31, 16);
            lblDate.TabIndex = 0;
            lblDate.Text = "日期";
            // 
            // dtDate
            // 
            dtDate.Format = DateTimePickerFormat.Short;
            dtDate.Location = new Point(75, 8);
            dtDate.Name = "dtDate";
            dtDate.Size = new Size(141, 23);
            dtDate.TabIndex = 1;
            // 
            // lblNo
            // 
            lblNo.AutoSize = true;
            lblNo.Location = new Point(260, 12);
            lblNo.Name = "lblNo";
            lblNo.Size = new Size(31, 16);
            lblNo.TabIndex = 2;
            lblNo.Text = "單號";
            // 
            // txtNo
            // 
            txtNo.Location = new Point(315, 8);
            txtNo.Name = "txtNo";
            txtNo.ReadOnly = true;
            txtNo.Size = new Size(157, 23);
            txtNo.TabIndex = 3;
            // 
            // lblSupplierNo
            // 
            lblSupplierNo.AutoSize = true;
            lblSupplierNo.Location = new Point(491, 12);
            lblSupplierNo.Name = "lblSupplierNo";
            lblSupplierNo.Size = new Size(55, 16);
            lblSupplierNo.TabIndex = 4;
            lblSupplierNo.Text = "廠商編號";
            // 
            // cboSupplierNo
            // 
            cboSupplierNo.Location = new Point(566, 8);
            cboSupplierNo.Name = "cboSupplierNo";
            cboSupplierNo.Size = new Size(146, 24);
            cboSupplierNo.TabIndex = 5;
            cboSupplierNo.SelectedIndexChanged += cboSupplierNo_SelectedIndexChanged;
            cboSupplierNo.Leave += cboSupplierNo_Leave;
            // 
            // btnSelectSupplier
            // 
            btnSelectSupplier.Location = new Point(570, 8);
            btnSelectSupplier.Name = "btnSelectSupplier";
            btnSelectSupplier.Size = new Size(28, 23);
            btnSelectSupplier.TabIndex = 6;
            btnSelectSupplier.Text = "…";
            btnSelectSupplier.Click += btnSelectSupplier_Click;
            // 
            // lblSupplierName
            // 
            lblSupplierName.AutoSize = true;
            lblSupplierName.Location = new Point(763, 12);
            lblSupplierName.Name = "lblSupplierName";
            lblSupplierName.Size = new Size(55, 16);
            lblSupplierName.TabIndex = 7;
            lblSupplierName.Text = "廠商名稱";
            // 
            // txtSupplierName
            // 
            txtSupplierName.Location = new Point(838, 8);
            txtSupplierName.Name = "txtSupplierName";
            txtSupplierName.ReadOnly = true;
            txtSupplierName.Size = new Size(260, 23);
            txtSupplierName.TabIndex = 8;
            // 
            // lblContact
            // 
            lblContact.AutoSize = true;
            lblContact.Location = new Point(10, 46);
            lblContact.Name = "lblContact";
            lblContact.Size = new Size(43, 16);
            lblContact.TabIndex = 9;
            lblContact.Text = "聯絡人";
            // 
            // cboContact
            // 
            cboContact.Location = new Point(75, 42);
            cboContact.Name = "cboContact";
            cboContact.Size = new Size(140, 24);
            cboContact.TabIndex = 10;
            // 
            // btnSelectContact
            // 
            btnSelectContact.Location = new Point(220, 42);
            btnSelectContact.Name = "btnSelectContact";
            btnSelectContact.Size = new Size(28, 23);
            btnSelectContact.TabIndex = 11;
            btnSelectContact.Text = "…";
            btnSelectContact.Click += btnSelectContact_Click;
            // 
            // lblTaxRate
            // 
            lblTaxRate.AutoSize = true;
            lblTaxRate.Location = new Point(260, 46);
            lblTaxRate.Name = "lblTaxRate";
            lblTaxRate.Size = new Size(55, 16);
            lblTaxRate.TabIndex = 12;
            lblTaxRate.Text = "營業稅率";
            // 
            // cboTaxRate
            // 
            cboTaxRate.Items.AddRange(new object[] { "", "0%", "5%" });
            cboTaxRate.Location = new Point(335, 42);
            cboTaxRate.Name = "cboTaxRate";
            cboTaxRate.Size = new Size(80, 24);
            cboTaxRate.TabIndex = 13;
            cboTaxRate.SelectedIndexChanged += cboTaxRate_SelectedIndexChanged;
            cboTaxRate.Leave += cboTaxRate_Leave;
            // 
            // lblCurrency
            // 
            lblCurrency.AutoSize = true;
            lblCurrency.Location = new Point(490, 46);
            lblCurrency.Name = "lblCurrency";
            lblCurrency.Size = new Size(31, 16);
            lblCurrency.TabIndex = 14;
            lblCurrency.Text = "幣別";
            // 
            // cboCurrency
            // 
            cboCurrency.Location = new Point(551, 42);
            cboCurrency.Name = "cboCurrency";
            cboCurrency.Size = new Size(80, 24);
            cboCurrency.TabIndex = 15;
            cboCurrency.SelectedIndexChanged += cboCurrency_SelectedIndexChanged;
            cboCurrency.Leave += cboCurrency_Leave;
            // 
            // lblExRate
            // 
            lblExRate.AutoSize = true;
            lblExRate.Location = new Point(635, 46);
            lblExRate.Name = "lblExRate";
            lblExRate.Size = new Size(31, 16);
            lblExRate.TabIndex = 16;
            lblExRate.Text = "匯率";
            // 
            // txtExRate
            // 
            txtExRate.Location = new Point(676, 42);
            txtExRate.Name = "txtExRate";
            txtExRate.ReadOnly = true;
            txtExRate.Size = new Size(80, 23);
            txtExRate.TabIndex = 17;
            // 
            // lblDeliveryAddr
            // 
            lblDeliveryAddr.AutoSize = true;
            lblDeliveryAddr.Location = new Point(764, 44);
            lblDeliveryAddr.Name = "lblDeliveryAddr";
            lblDeliveryAddr.Size = new Size(55, 16);
            lblDeliveryAddr.TabIndex = 18;
            lblDeliveryAddr.Text = "送貨地址";
            // 
            // cboDeliveryAddr
            // 
            cboDeliveryAddr.Location = new Point(839, 40);
            cboDeliveryAddr.Name = "cboDeliveryAddr";
            cboDeliveryAddr.Size = new Size(220, 24);
            cboDeliveryAddr.TabIndex = 19;
            // 
            // lblPurchaseCategory
            // 
            lblPurchaseCategory.AutoSize = true;
            lblPurchaseCategory.Location = new Point(8, 80);
            lblPurchaseCategory.Name = "lblPurchaseCategory";
            lblPurchaseCategory.Size = new Size(55, 16);
            lblPurchaseCategory.TabIndex = 20;
            lblPurchaseCategory.Text = "採購歸屬";
            // 
            // cboPurchaseCategory
            // 
            cboPurchaseCategory.Items.AddRange(new object[] { "", "現場作業", "安全庫存", "研發試製", "買賣貿易" });
            cboPurchaseCategory.Location = new Point(76, 76);
            cboPurchaseCategory.Name = "cboPurchaseCategory";
            cboPurchaseCategory.Size = new Size(140, 24);
            cboPurchaseCategory.TabIndex = 21;
            // 
            // lblPayTerm
            // 
            lblPayTerm.AutoSize = true;
            lblPayTerm.Location = new Point(260, 80);
            lblPayTerm.Name = "lblPayTerm";
            lblPayTerm.Size = new Size(55, 16);
            lblPayTerm.TabIndex = 22;
            lblPayTerm.Text = "付款條件";
            // 
            // cboPayTerm
            // 
            cboPayTerm.Items.AddRange(new object[] { "", "貨到T/T", "即期票", "月結當月票", "月結30天", "月結60天", "月結90天" });
            cboPayTerm.Location = new Point(335, 76);
            cboPayTerm.Name = "cboPayTerm";
            cboPayTerm.Size = new Size(140, 24);
            cboPayTerm.TabIndex = 23;
            // 
            // lblShipMethod
            // 
            lblShipMethod.AutoSize = true;
            lblShipMethod.Location = new Point(490, 80);
            lblShipMethod.Name = "lblShipMethod";
            lblShipMethod.Size = new Size(55, 16);
            lblShipMethod.TabIndex = 24;
            lblShipMethod.Text = "運輸方式";
            // 
            // txtShipMethod
            // 
            txtShipMethod.Location = new Point(552, 76);
            txtShipMethod.Name = "txtShipMethod";
            txtShipMethod.Size = new Size(204, 23);
            txtShipMethod.TabIndex = 25;
            // 
            // lblPurchaser
            // 
            lblPurchaser.AutoSize = true;
            lblPurchaser.Location = new Point(768, 76);
            lblPurchaser.Name = "lblPurchaser";
            lblPurchaser.Size = new Size(55, 16);
            lblPurchaser.TabIndex = 26;
            lblPurchaser.Text = "採購人員";
            // 
            // cboPurchaser
            // 
            cboPurchaser.Location = new Point(838, 72);
            cboPurchaser.Name = "cboPurchaser";
            cboPurchaser.Size = new Size(110, 24);
            cboPurchaser.TabIndex = 27;
            cboPurchaser.SelectedIndexChanged += cboPurchaser_SelectedIndexChanged;
            cboPurchaser.Leave += cboPurchaser_Leave;
            // 
            // lblPurchaserName
            // 
            lblPurchaserName.AutoSize = true;
            lblPurchaserName.Location = new Point(390, 114);
            lblPurchaserName.Name = "lblPurchaserName";
            lblPurchaserName.Size = new Size(0, 16);
            lblPurchaserName.TabIndex = 28;
            // 
            // chkClosed
            // 
            chkClosed.AutoSize = true;
            chkClosed.Location = new Point(956, 76);
            chkClosed.Name = "chkClosed";
            chkClosed.Size = new Size(50, 20);
            chkClosed.TabIndex = 29;
            chkClosed.Text = "作廢";
            // 
            // btnVoidAll
            // 
            btnVoidAll.BackColor = Color.MistyRose;
            btnVoidAll.FlatStyle = FlatStyle.Flat;
            btnVoidAll.Location = new Point(1026, 74);
            btnVoidAll.Name = "btnVoidAll";
            btnVoidAll.Size = new Size(90, 23);
            btnVoidAll.TabIndex = 30;
            btnVoidAll.Text = "全單作廢";
            btnVoidAll.UseVisualStyleBackColor = false;
            btnVoidAll.Click += btnVoidAll_Click;
            // 
            // lblNote
            // 
            lblNote.AutoSize = true;
            lblNote.Location = new Point(10, 117);
            lblNote.Name = "lblNote";
            lblNote.Size = new Size(55, 16);
            lblNote.TabIndex = 31;
            lblNote.Text = "注意事項";
            // 
            // txtNote
            // 
            txtNote.Location = new Point(78, 113);
            txtNote.Name = "txtNote";
            txtNote.Size = new Size(391, 23);
            txtNote.TabIndex = 32;
            // 
            // lblTradeTerm
            // 
            lblTradeTerm.AutoSize = true;
            lblTradeTerm.Location = new Point(492, 116);
            lblTradeTerm.Name = "lblTradeTerm";
            lblTradeTerm.Size = new Size(55, 16);
            lblTradeTerm.TabIndex = 33;
            lblTradeTerm.Text = "貿易條件";
            // 
            // txtTradeTerm
            // 
            txtTradeTerm.Location = new Point(553, 112);
            txtTradeTerm.Name = "txtTradeTerm";
            txtTradeTerm.Size = new Size(140, 23);
            txtTradeTerm.TabIndex = 34;
            // 
            // lblDeliveryDate
            // 
            lblDeliveryDate.AutoSize = true;
            lblDeliveryDate.Location = new Point(768, 112);
            lblDeliveryDate.Name = "lblDeliveryDate";
            lblDeliveryDate.Size = new Size(55, 16);
            lblDeliveryDate.TabIndex = 35;
            lblDeliveryDate.Text = "交貨日期";
            // 
            // dtDeliveryDate
            // 
            dtDeliveryDate.Format = DateTimePickerFormat.Short;
            dtDeliveryDate.Location = new Point(840, 108);
            dtDeliveryDate.Name = "dtDeliveryDate";
            dtDeliveryDate.Size = new Size(110, 23);
            dtDeliveryDate.TabIndex = 36;
            // 
            // panelGrid
            // 
            panelGrid.Controls.Add(dgvDetail);
            panelGrid.Dock = DockStyle.Fill;
            panelGrid.Location = new Point(0, 204);
            panelGrid.Name = "panelGrid";
            panelGrid.Size = new Size(1450, 404);
            panelGrid.TabIndex = 2;
            // 
            // dgvDetail
            // 
            dgvDetail.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDetail.BackgroundColor = Color.White;
            dgvDetail.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetail.Columns.AddRange(new DataGridViewColumn[] { colItemNo, colItemSpec, colQty, colUnit, colUntaxedAmt, colPurchaseAmt, colProject, colSample, colNote, colReqSerial, colOutsourceType });
            dgvDetail.Dock = DockStyle.Fill;
            dgvDetail.Font = new Font("微軟正黑體", 10F);
            dgvDetail.Location = new Point(0, 0);
            dgvDetail.Name = "dgvDetail";
            dgvDetail.RowTemplate.Height = 26;
            dgvDetail.Size = new Size(1450, 404);
            dgvDetail.TabIndex = 0;
            dgvDetail.CellDoubleClick += dgvDetail_CellDoubleClick;
            dgvDetail.CellEndEdit += dgvDetail_CellEndEdit;
            dgvDetail.RowsRemoved += dgvDetail_RowsRemoved;
            // 
            // colItemNo
            // 
            colItemNo.FillWeight = 110F;
            colItemNo.HeaderText = "品項編號";
            colItemNo.Name = "colItemNo";
            // 
            // colItemSpec
            // 
            colItemSpec.FillWeight = 220F;
            colItemSpec.HeaderText = "品名規格";
            colItemSpec.Name = "colItemSpec";
            colItemSpec.ReadOnly = true;
            // 
            // colQty
            // 
            colQty.FillWeight = 70F;
            colQty.HeaderText = "數量";
            colQty.Name = "colQty";
            // 
            // colUnit
            // 
            colUnit.FillWeight = 60F;
            colUnit.HeaderText = "單位";
            colUnit.Name = "colUnit";
            colUnit.ReadOnly = true;
            // 
            // colUntaxedAmt
            // 
            colUntaxedAmt.FillWeight = 90F;
            colUntaxedAmt.HeaderText = "未稅金額";
            colUntaxedAmt.Name = "colUntaxedAmt";
            // 
            // colPurchaseAmt
            // 
            colPurchaseAmt.FillWeight = 90F;
            colPurchaseAmt.HeaderText = "採購金額";
            colPurchaseAmt.Name = "colPurchaseAmt";
            // 
            // colProject
            // 
            colProject.FillWeight = 80F;
            colProject.HeaderText = "專案序號";
            colProject.Name = "colProject";
            // 
            // colSample
            // 
            colSample.FillWeight = 50F;
            colSample.HeaderText = "樣品";
            colSample.Name = "colSample";
            // 
            // colNote
            // 
            colNote.FillWeight = 140F;
            colNote.HeaderText = "備註";
            colNote.Name = "colNote";
            // 
            // colReqSerial
            // 
            colReqSerial.FillWeight = 90F;
            colReqSerial.HeaderText = "請購序號";
            colReqSerial.Name = "colReqSerial";
            // 
            // colOutsourceType
            // 
            colOutsourceType.FillWeight = 90F;
            colOutsourceType.HeaderText = "代工類別";
            colOutsourceType.Name = "colOutsourceType";
            // 
            // panelFooter
            // 
            panelFooter.BackColor = Color.Lavender;
            panelFooter.Controls.Add(lblSumUntaxed);
            panelFooter.Controls.Add(txtSumUntaxed);
            panelFooter.Controls.Add(lblSumTax);
            panelFooter.Controls.Add(txtSumTax);
            panelFooter.Controls.Add(lblSumPurchase);
            panelFooter.Controls.Add(txtSumPurchase);
            panelFooter.Controls.Add(lblCreatorCaption);
            panelFooter.Controls.Add(txtCreator);
            panelFooter.Controls.Add(txtCreateDate);
            panelFooter.Controls.Add(lblModifierCaption);
            panelFooter.Controls.Add(txtModifier);
            panelFooter.Controls.Add(txtModifyDate);
            panelFooter.Controls.Add(lblApproverCaption);
            panelFooter.Controls.Add(txtApprover);
            panelFooter.Controls.Add(txtApproveDate);
            panelFooter.Dock = DockStyle.Bottom;
            panelFooter.Location = new Point(0, 608);
            panelFooter.Name = "panelFooter";
            panelFooter.Size = new Size(1450, 80);
            panelFooter.TabIndex = 3;
            // 
            // lblSumUntaxed
            // 
            lblSumUntaxed.AutoSize = true;
            lblSumUntaxed.Location = new Point(10, 12);
            lblSumUntaxed.Name = "lblSumUntaxed";
            lblSumUntaxed.Size = new Size(79, 16);
            lblSumUntaxed.TabIndex = 0;
            lblSumUntaxed.Text = "未稅金額合計";
            // 
            // txtSumUntaxed
            // 
            txtSumUntaxed.Location = new Point(105, 8);
            txtSumUntaxed.Name = "txtSumUntaxed";
            txtSumUntaxed.ReadOnly = true;
            txtSumUntaxed.Size = new Size(110, 23);
            txtSumUntaxed.TabIndex = 1;
            txtSumUntaxed.TextAlign = HorizontalAlignment.Right;
            // 
            // lblSumTax
            // 
            lblSumTax.AutoSize = true;
            lblSumTax.Location = new Point(230, 12);
            lblSumTax.Name = "lblSumTax";
            lblSumTax.Size = new Size(55, 16);
            lblSumTax.TabIndex = 2;
            lblSumTax.Text = "稅額合計";
            // 
            // txtSumTax
            // 
            txtSumTax.Location = new Point(305, 8);
            txtSumTax.Name = "txtSumTax";
            txtSumTax.ReadOnly = true;
            txtSumTax.Size = new Size(110, 23);
            txtSumTax.TabIndex = 3;
            txtSumTax.TextAlign = HorizontalAlignment.Right;
            // 
            // lblSumPurchase
            // 
            lblSumPurchase.AutoSize = true;
            lblSumPurchase.Location = new Point(430, 12);
            lblSumPurchase.Name = "lblSumPurchase";
            lblSumPurchase.Size = new Size(79, 16);
            lblSumPurchase.TabIndex = 4;
            lblSumPurchase.Text = "採購金額合計";
            // 
            // txtSumPurchase
            // 
            txtSumPurchase.Location = new Point(525, 8);
            txtSumPurchase.Name = "txtSumPurchase";
            txtSumPurchase.ReadOnly = true;
            txtSumPurchase.Size = new Size(110, 23);
            txtSumPurchase.TabIndex = 5;
            txtSumPurchase.TextAlign = HorizontalAlignment.Right;
            // 
            // lblCreatorCaption
            // 
            lblCreatorCaption.AutoSize = true;
            lblCreatorCaption.Location = new Point(10, 46);
            lblCreatorCaption.Name = "lblCreatorCaption";
            lblCreatorCaption.Size = new Size(55, 16);
            lblCreatorCaption.TabIndex = 6;
            lblCreatorCaption.Text = "建檔人員";
            // 
            // txtCreator
            // 
            txtCreator.Location = new Point(85, 42);
            txtCreator.Name = "txtCreator";
            txtCreator.ReadOnly = true;
            txtCreator.Size = new Size(90, 23);
            txtCreator.TabIndex = 7;
            // 
            // txtCreateDate
            // 
            txtCreateDate.Location = new Point(180, 42);
            txtCreateDate.Name = "txtCreateDate";
            txtCreateDate.ReadOnly = true;
            txtCreateDate.Size = new Size(90, 23);
            txtCreateDate.TabIndex = 8;
            // 
            // lblModifierCaption
            // 
            lblModifierCaption.AutoSize = true;
            lblModifierCaption.Location = new Point(285, 46);
            lblModifierCaption.Name = "lblModifierCaption";
            lblModifierCaption.Size = new Size(55, 16);
            lblModifierCaption.TabIndex = 9;
            lblModifierCaption.Text = "修改人員";
            // 
            // txtModifier
            // 
            txtModifier.Location = new Point(360, 42);
            txtModifier.Name = "txtModifier";
            txtModifier.ReadOnly = true;
            txtModifier.Size = new Size(90, 23);
            txtModifier.TabIndex = 10;
            // 
            // txtModifyDate
            // 
            txtModifyDate.Location = new Point(455, 42);
            txtModifyDate.Name = "txtModifyDate";
            txtModifyDate.ReadOnly = true;
            txtModifyDate.Size = new Size(90, 23);
            txtModifyDate.TabIndex = 11;
            // 
            // lblApproverCaption
            // 
            lblApproverCaption.AutoSize = true;
            lblApproverCaption.Location = new Point(560, 46);
            lblApproverCaption.Name = "lblApproverCaption";
            lblApproverCaption.Size = new Size(55, 16);
            lblApproverCaption.TabIndex = 12;
            lblApproverCaption.Text = "核准人員";
            // 
            // txtApprover
            // 
            txtApprover.Location = new Point(635, 42);
            txtApprover.Name = "txtApprover";
            txtApprover.ReadOnly = true;
            txtApprover.Size = new Size(90, 23);
            txtApprover.TabIndex = 13;
            // 
            // txtApproveDate
            // 
            txtApproveDate.Location = new Point(730, 42);
            txtApproveDate.Name = "txtApproveDate";
            txtApproveDate.ReadOnly = true;
            txtApproveDate.Size = new Size(90, 23);
            txtApproveDate.TabIndex = 14;
            // 
            // ProcurementMaintainControl
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelGrid);
            Controls.Add(panelFooter);
            Controls.Add(panelHeader);
            Controls.Add(panelToolbar);
            Font = new Font("微軟正黑體", 9F);
            Name = "ProcurementMaintainControl";
            Size = new Size(1450, 688);
            panelToolbar.ResumeLayout(false);
            panelToolbar.PerformLayout();
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDetail).EndInit();
            panelFooter.ResumeLayout(false);
            panelFooter.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelToolbar;
        private Label lblTitle;
        private Label lblMode;
        private Button btnAllocate;
        private Button btnItemClose;
        private Button btnDeleteRecord;
        private Button btnLog;
        private Button btnCopy;
        private Button btnAddNew;
        private Button btnModify;
        private Button btnSave;
        private Button btnActivate;
        private Button btnCancelActivate;
        private Button btnPrint;
        private Button btnOverview;
        private Button btnClose;

        private Panel panelHeader;
        private Label lblDate; private DateTimePicker dtDate;
        private Label lblNo; private TextBox txtNo;
        private Label lblSupplierNo; private ComboBox cboSupplierNo; private Button btnSelectSupplier;
        private Label lblSupplierName; private TextBox txtSupplierName;
        private Label lblContact; private ComboBox cboContact; private Button btnSelectContact;
        private Label lblTaxRate; private ComboBox cboTaxRate;
        private Label lblCurrency; private ComboBox cboCurrency;
        private Label lblExRate; private TextBox txtExRate;
        private Label lblDeliveryAddr; private ComboBox cboDeliveryAddr;
        private Label lblPurchaseCategory; private ComboBox cboPurchaseCategory;
        private Label lblPayTerm; private ComboBox cboPayTerm;
        private Label lblShipMethod; private TextBox txtShipMethod;
        private Label lblPurchaser; private ComboBox cboPurchaser; private Label lblPurchaserName;
        private CheckBox chkClosed; private Button btnVoidAll;
        private Label lblNote; private TextBox txtNote;
        private Label lblTradeTerm; private TextBox txtTradeTerm;
        private Label lblDeliveryDate; private DateTimePicker dtDeliveryDate;

        private Panel panelGrid;
        private DataGridView dgvDetail;
        private DataGridViewTextBoxColumn colItemNo;
        private DataGridViewTextBoxColumn colItemSpec;
        private DataGridViewTextBoxColumn colQty;
        private DataGridViewTextBoxColumn colUnit;
        private DataGridViewTextBoxColumn colUntaxedAmt;
        private DataGridViewTextBoxColumn colPurchaseAmt;
        private DataGridViewTextBoxColumn colProject;
        private DataGridViewCheckBoxColumn colSample;
        private DataGridViewTextBoxColumn colNote;
        private DataGridViewTextBoxColumn colReqSerial;
        private DataGridViewTextBoxColumn colOutsourceType;

        private Panel panelFooter;
        private Label lblSumUntaxed; private TextBox txtSumUntaxed;
        private Label lblSumTax; private TextBox txtSumTax;
        private Label lblSumPurchase; private TextBox txtSumPurchase;
        private Label lblCreatorCaption; private TextBox txtCreator; private TextBox txtCreateDate;
        private Label lblModifierCaption; private TextBox txtModifier; private TextBox txtModifyDate;
        private Label lblApproverCaption; private TextBox txtApprover; private TextBox txtApproveDate;
    }
}
