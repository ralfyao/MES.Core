namespace DigiERP.UserControl.Customer.OtherIncome
{
    partial class OtherIncomeMaintainControl
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region 元件設計工具產生的程式碼

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OtherIncomeMaintainControl));
            panel1 = new Panel();
            btnBack = new Button();
            btnSubmit = new Button();
            btnDelete = new Button();
            btnApprove = new Button();
            btnCancelApprove = new Button();
            btnModify = new Button();
            lblMode = new Label();
            panelForm = new Panel();
            lbl日期 = new Label();
            dtDate = new DateTimePicker();
            lbl單號 = new Label();
            txtFormNo = new TextBox();
            lbl客戶編號 = new Label();
            cboCustId = new DigiERP.Common.CommonComboBox();
            lbl客戶簡稱 = new Label();
            txtCustAlias = new TextBox();
            lbl傳票 = new Label();
            txtVoucher = new TextBox();
            lbl業務人員 = new Label();
            cboSales = new DigiERP.Common.CommonComboBox();
            txtSalesName = new TextBox();
            lbl幣別 = new Label();
            cboCurrency = new DigiERP.Common.CommonComboBox();
            lbl匯率 = new Label();
            txtExRate = new TextBox();
            lbl稅別 = new Label();
            cboTaxType = new DigiERP.Common.CommonComboBox();
            lbl稅率 = new Label();
            cboTaxRate = new DigiERP.Common.CommonComboBox();
            lbl客戶全名 = new Label();
            txtCompany = new TextBox();
            lbl收款帳號 = new Label();
            txtCredibility = new TextBox();
            lblMachineNo = new Label();
            txtMachineNo = new TextBox();
            lbl貿易條件 = new Label();
            priceCondControl1 = new Common.PriceCondControl();
            lbl付款方式 = new Label();
            payMethod = new Common.PriceCondControl();
            lbl備註 = new Label();
            txtRemark = new TextBox();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            colItemNo = new DataGridViewComboBoxColumn();
            colItemName = new DataGridViewTextBoxColumn();
            colOrigAmount = new DataGridViewTextBoxColumn();
            colTaxFree = new DataGridViewTextBoxColumn();
            colTax = new DataGridViewTextBoxColumn();
            colTotal = new DataGridViewTextBoxColumn();
            colRemark = new DataGridViewTextBoxColumn();
            panelFooter = new Panel();
            lbl覆核人員 = new Label();
            txtApprover = new TextBox();
            lbl核准 = new Label();
            txtApprove = new TextBox();
            lbl核准日 = new Label();
            txtApproveDate = new TextBox();
            lbl修改人員 = new Label();
            txtModifier = new TextBox();
            lbl修改 = new Label();
            txtModify = new TextBox();
            lbl修改日 = new Label();
            txtModifyDate = new TextBox();
            lbl建檔人員 = new Label();
            txtCreator = new TextBox();
            lbl建檔 = new Label();
            txtCreate = new TextBox();
            lbl建檔日 = new Label();
            txtCreateDate = new TextBox();
            panel1.SuspendLayout();
            panelForm.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panelFooter.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnBack);
            panel1.Controls.Add(btnSubmit);
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(btnApprove);
            panel1.Controls.Add(btnCancelApprove);
            panel1.Controls.Add(btnModify);
            panel1.Controls.Add(lblMode);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1654, 60);
            panel1.TabIndex = 0;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.DarkGray;
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(12, 8);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(100, 44);
            btnBack.TabIndex = 0;
            btnBack.Text = "返回";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.SteelBlue;
            btnSubmit.ForeColor = Color.White;
            btnSubmit.Location = new Point(120, 8);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(100, 44);
            btnSubmit.TabIndex = 1;
            btnSubmit.Text = "儲存";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.IndianRed;
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(228, 8);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(100, 44);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "刪除";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnApprove
            // 
            btnApprove.BackColor = Color.SeaGreen;
            btnApprove.ForeColor = Color.White;
            btnApprove.Location = new Point(336, 8);
            btnApprove.Name = "btnApprove";
            btnApprove.Size = new Size(100, 44);
            btnApprove.TabIndex = 3;
            btnApprove.Text = "核准";
            btnApprove.UseVisualStyleBackColor = false;
            btnApprove.Click += btnApprove_Click;
            // 
            // btnCancelApprove
            // 
            btnCancelApprove.BackColor = Color.Orange;
            btnCancelApprove.ForeColor = Color.White;
            btnCancelApprove.Location = new Point(444, 8);
            btnCancelApprove.Name = "btnCancelApprove";
            btnCancelApprove.Size = new Size(120, 44);
            btnCancelApprove.TabIndex = 4;
            btnCancelApprove.Text = "取消核准";
            btnCancelApprove.UseVisualStyleBackColor = false;
            btnCancelApprove.Click += btnCancelApprove_Click;
            //
            // btnModify
            //
            btnModify.BackColor = Color.Gainsboro;
            btnModify.Location = new Point(576, 8);
            btnModify.Name = "btnModify";
            btnModify.Size = new Size(100, 44);
            btnModify.TabIndex = 5;
            btnModify.Text = "修改";
            btnModify.UseVisualStyleBackColor = false;
            btnModify.Click += btnModify_Click;
            //
            // lblMode
            //
            lblMode.AutoSize = true;
            lblMode.Location = new Point(700, 20);
            lblMode.Name = "lblMode";
            lblMode.Size = new Size(48, 24);
            lblMode.TabIndex = 6;
            lblMode.Text = "新增";
            lblMode.Visible = false;
            // 
            // panelForm
            // 
            panelForm.AutoScroll = true;
            panelForm.Controls.Add(lbl日期);
            panelForm.Controls.Add(dtDate);
            panelForm.Controls.Add(lbl單號);
            panelForm.Controls.Add(txtFormNo);
            panelForm.Controls.Add(lbl客戶編號);
            panelForm.Controls.Add(cboCustId);
            panelForm.Controls.Add(lbl客戶簡稱);
            panelForm.Controls.Add(txtCustAlias);
            panelForm.Controls.Add(lbl傳票);
            panelForm.Controls.Add(txtVoucher);
            panelForm.Controls.Add(lbl業務人員);
            panelForm.Controls.Add(cboSales);
            panelForm.Controls.Add(txtSalesName);
            panelForm.Controls.Add(lbl幣別);
            panelForm.Controls.Add(cboCurrency);
            panelForm.Controls.Add(lbl匯率);
            panelForm.Controls.Add(txtExRate);
            panelForm.Controls.Add(lbl稅別);
            panelForm.Controls.Add(cboTaxType);
            panelForm.Controls.Add(lbl稅率);
            panelForm.Controls.Add(cboTaxRate);
            panelForm.Controls.Add(lbl客戶全名);
            panelForm.Controls.Add(txtCompany);
            panelForm.Controls.Add(lbl收款帳號);
            panelForm.Controls.Add(txtCredibility);
            panelForm.Controls.Add(lblMachineNo);
            panelForm.Controls.Add(txtMachineNo);
            panelForm.Controls.Add(lbl貿易條件);
            panelForm.Controls.Add(priceCondControl1);
            panelForm.Controls.Add(lbl付款方式);
            panelForm.Controls.Add(payMethod);
            panelForm.Controls.Add(lbl備註);
            panelForm.Controls.Add(txtRemark);
            panelForm.Dock = DockStyle.Top;
            panelForm.Location = new Point(0, 60);
            panelForm.Name = "panelForm";
            panelForm.Size = new Size(1654, 392);
            panelForm.TabIndex = 1;
            // 
            // lbl日期
            // 
            lbl日期.AutoSize = true;
            lbl日期.Location = new Point(6, 16);
            lbl日期.Name = "lbl日期";
            lbl日期.Size = new Size(48, 24);
            lbl日期.TabIndex = 0;
            lbl日期.Text = "日期";
            // 
            // dtDate
            // 
            dtDate.CustomFormat = "yyyy/MM/dd";
            dtDate.Format = DateTimePickerFormat.Custom;
            dtDate.Location = new Point(55, 10);
            dtDate.Name = "dtDate";
            dtDate.Size = new Size(170, 32);
            dtDate.TabIndex = 1;
            // 
            // lbl單號
            // 
            lbl單號.AutoSize = true;
            lbl單號.Location = new Point(231, 16);
            lbl單號.Name = "lbl單號";
            lbl單號.Size = new Size(48, 24);
            lbl單號.TabIndex = 2;
            lbl單號.Text = "單號";
            // 
            // txtFormNo
            // 
            txtFormNo.BackColor = Color.LightGray;
            txtFormNo.Location = new Point(280, 10);
            txtFormNo.Name = "txtFormNo";
            txtFormNo.ReadOnly = true;
            txtFormNo.Size = new Size(170, 32);
            txtFormNo.TabIndex = 3;
            // 
            // lbl客戶編號
            // 
            lbl客戶編號.AutoSize = true;
            lbl客戶編號.Location = new Point(459, 16);
            lbl客戶編號.Name = "lbl客戶編號";
            lbl客戶編號.Size = new Size(86, 24);
            lbl客戶編號.TabIndex = 4;
            lbl客戶編號.Text = "客戶編號";
            // 
            // cboCustId
            // 
            cboCustId.FormattingEnabled = true;
            cboCustId.Location = new Point(550, 10);
            cboCustId.Name = "cboCustId";
            cboCustId.Size = new Size(180, 32);
            cboCustId.TabIndex = 5;
            cboCustId.MouseClick += cboCustId_MouseClick;
            // 
            // lbl客戶簡稱
            // 
            lbl客戶簡稱.AutoSize = true;
            lbl客戶簡稱.Location = new Point(739, 16);
            lbl客戶簡稱.Name = "lbl客戶簡稱";
            lbl客戶簡稱.Size = new Size(86, 24);
            lbl客戶簡稱.TabIndex = 6;
            lbl客戶簡稱.Text = "客戶簡稱";
            // 
            // txtCustAlias
            // 
            txtCustAlias.BackColor = Color.LightGray;
            txtCustAlias.Location = new Point(828, 10);
            txtCustAlias.Name = "txtCustAlias";
            txtCustAlias.ReadOnly = true;
            txtCustAlias.Size = new Size(150, 32);
            txtCustAlias.TabIndex = 7;
            // 
            // lbl傳票
            // 
            lbl傳票.AutoSize = true;
            lbl傳票.Location = new Point(985, 16);
            lbl傳票.Name = "lbl傳票";
            lbl傳票.Size = new Size(48, 24);
            lbl傳票.TabIndex = 8;
            lbl傳票.Text = "傳票";
            // 
            // txtVoucher
            // 
            txtVoucher.Location = new Point(1036, 10);
            txtVoucher.Name = "txtVoucher";
            txtVoucher.Size = new Size(200, 32);
            txtVoucher.TabIndex = 9;
            // 
            // lbl業務人員
            // 
            lbl業務人員.AutoSize = true;
            lbl業務人員.Location = new Point(12, 63);
            lbl業務人員.Name = "lbl業務人員";
            lbl業務人員.Size = new Size(86, 24);
            lbl業務人員.TabIndex = 10;
            lbl業務人員.Text = "業務人員";
            // 
            // cboSales
            // 
            cboSales.FormattingEnabled = true;
            cboSales.Location = new Point(98, 57);
            cboSales.Name = "cboSales";
            cboSales.Size = new Size(120, 32);
            cboSales.TabIndex = 11;
            cboSales.SelectedIndexChanged += cboSales_SelectedIndexChanged;
            // 
            // txtSalesName
            // 
            txtSalesName.BackColor = Color.LightGray;
            txtSalesName.Location = new Point(226, 57);
            txtSalesName.Name = "txtSalesName";
            txtSalesName.ReadOnly = true;
            txtSalesName.Size = new Size(150, 32);
            txtSalesName.TabIndex = 12;
            // 
            // lbl幣別
            // 
            lbl幣別.AutoSize = true;
            lbl幣別.Location = new Point(380, 63);
            lbl幣別.Name = "lbl幣別";
            lbl幣別.Size = new Size(48, 24);
            lbl幣別.TabIndex = 13;
            lbl幣別.Text = "幣別";
            // 
            // cboCurrency
            // 
            cboCurrency.FormattingEnabled = true;
            cboCurrency.Location = new Point(430, 57);
            cboCurrency.Name = "cboCurrency";
            cboCurrency.Size = new Size(100, 32);
            cboCurrency.TabIndex = 14;
            cboCurrency.SelectedIndexChanged += cboCurrency_SelectedIndexChanged;
            // 
            // lbl匯率
            // 
            lbl匯率.AutoSize = true;
            lbl匯率.Location = new Point(534, 63);
            lbl匯率.Name = "lbl匯率";
            lbl匯率.Size = new Size(48, 24);
            lbl匯率.TabIndex = 15;
            lbl匯率.Text = "匯率";
            // 
            // txtExRate
            // 
            txtExRate.Location = new Point(582, 57);
            txtExRate.Name = "txtExRate";
            txtExRate.Size = new Size(100, 32);
            txtExRate.TabIndex = 16;
            // 
            // lbl稅別
            // 
            lbl稅別.AutoSize = true;
            lbl稅別.Location = new Point(685, 63);
            lbl稅別.Name = "lbl稅別";
            lbl稅別.Size = new Size(48, 24);
            lbl稅別.TabIndex = 17;
            lbl稅別.Text = "稅別";
            // 
            // cboTaxType
            // 
            cboTaxType.FormattingEnabled = true;
            cboTaxType.Location = new Point(736, 57);
            cboTaxType.Name = "cboTaxType";
            cboTaxType.Size = new Size(130, 32);
            cboTaxType.TabIndex = 18;
            // 
            // lbl稅率
            // 
            lbl稅率.AutoSize = true;
            lbl稅率.Location = new Point(869, 63);
            lbl稅率.Name = "lbl稅率";
            lbl稅率.Size = new Size(48, 24);
            lbl稅率.TabIndex = 19;
            lbl稅率.Text = "稅率";
            // 
            // cboTaxRate
            // 
            cboTaxRate.FormattingEnabled = true;
            cboTaxRate.Location = new Point(918, 57);
            cboTaxRate.Name = "cboTaxRate";
            cboTaxRate.Size = new Size(100, 32);
            cboTaxRate.TabIndex = 20;
            // 
            // lbl客戶全名
            // 
            lbl客戶全名.AutoSize = true;
            lbl客戶全名.Location = new Point(1026, 63);
            lbl客戶全名.Name = "lbl客戶全名";
            lbl客戶全名.Size = new Size(86, 24);
            lbl客戶全名.TabIndex = 21;
            lbl客戶全名.Text = "客戶全名";
            // 
            // txtCompany
            // 
            txtCompany.BackColor = Color.LightGray;
            txtCompany.Location = new Point(1116, 57);
            txtCompany.Name = "txtCompany";
            txtCompany.ReadOnly = true;
            txtCompany.Size = new Size(300, 32);
            txtCompany.TabIndex = 22;
            // 
            // lbl收款帳號
            // 
            lbl收款帳號.AutoSize = true;
            lbl收款帳號.Location = new Point(12, 110);
            lbl收款帳號.Name = "lbl收款帳號";
            lbl收款帳號.Size = new Size(86, 24);
            lbl收款帳號.TabIndex = 23;
            lbl收款帳號.Text = "收款帳號";
            // 
            // txtCredibility
            // 
            txtCredibility.BackColor = Color.LightGray;
            txtCredibility.Location = new Point(98, 104);
            txtCredibility.Name = "txtCredibility";
            txtCredibility.ReadOnly = true;
            txtCredibility.Size = new Size(200, 32);
            txtCredibility.TabIndex = 24;
            // 
            // lblMachineNo
            // 
            lblMachineNo.AutoSize = true;
            lblMachineNo.Location = new Point(312, 110);
            lblMachineNo.Name = "lblMachineNo";
            lblMachineNo.Size = new Size(48, 24);
            lblMachineNo.TabIndex = 25;
            lblMachineNo.Text = "機號";
            // 
            // txtMachineNo
            // 
            txtMachineNo.Location = new Point(356, 104);
            txtMachineNo.Name = "txtMachineNo";
            txtMachineNo.Size = new Size(180, 32);
            txtMachineNo.TabIndex = 26;
            // 
            // lbl貿易條件
            // 
            lbl貿易條件.AutoSize = true;
            lbl貿易條件.Location = new Point(4, 160);
            lbl貿易條件.Name = "lbl貿易條件";
            lbl貿易條件.Size = new Size(86, 24);
            lbl貿易條件.TabIndex = 27;
            lbl貿易條件.Text = "貿易條件";
            // 
            // priceCondControl1
            // 
            priceCondControl1.Location = new Point(96, 156);
            priceCondControl1.Name = "priceCondControl1";
            priceCondControl1.Size = new Size(690, 128);
            priceCondControl1.TabIndex = 28;
            priceCondControl1.txType = "T";
            // 
            // lbl付款方式
            // 
            lbl付款方式.AutoSize = true;
            lbl付款方式.Location = new Point(830, 168);
            lbl付款方式.Name = "lbl付款方式";
            lbl付款方式.Size = new Size(86, 24);
            lbl付款方式.TabIndex = 29;
            lbl付款方式.Text = "付款方式";
            // 
            // payMethod
            // 
            payMethod.Location = new Point(916, 156);
            payMethod.Name = "payMethod";
            payMethod.Size = new Size(450, 128);
            payMethod.TabIndex = 30;
            payMethod.txType = "P,Y";
            // 
            // lbl備註
            // 
            lbl備註.AutoSize = true;
            lbl備註.Location = new Point(8, 316);
            lbl備註.Name = "lbl備註";
            lbl備註.Size = new Size(86, 24);
            lbl備註.TabIndex = 31;
            lbl備註.Text = "備註說明";
            // 
            // txtRemark
            // 
            txtRemark.Location = new Point(94, 306);
            txtRemark.Multiline = true;
            txtRemark.Name = "txtRemark";
            txtRemark.Size = new Size(800, 52);
            txtRemark.TabIndex = 32;
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridView1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 452);
            panel2.Name = "panel2";
            panel2.Size = new Size(1654, 406);
            panel2.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colItemNo, colItemName, colOrigAmount, colTaxFree, colTax, colTotal, colRemark });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(1654, 406);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellValueChanged += dataGridView1_CellValueChanged;
            dataGridView1.DataError += dataGridView1_DataError;
            dataGridView1.EditingControlShowing += dataGridView1_EditingControlShowing;
            // 
            // colItemNo
            // 
            colItemNo.HeaderText = "項目編號";
            colItemNo.Name = "colItemNo";
            // 
            // colItemName
            // 
            colItemName.HeaderText = "項目名稱";
            colItemName.Name = "colItemName";
            colItemName.ReadOnly = true;
            // 
            // colOrigAmount
            // 
            colOrigAmount.HeaderText = "原幣未稅";
            colOrigAmount.Name = "colOrigAmount";
            // 
            // colTaxFree
            // 
            colTaxFree.HeaderText = "未稅";
            colTaxFree.Name = "colTaxFree";
            // 
            // colTax
            // 
            colTax.HeaderText = "稅";
            colTax.Name = "colTax";
            // 
            // colTotal
            // 
            colTotal.HeaderText = "金額";
            colTotal.Name = "colTotal";
            colTotal.ReadOnly = true;
            // 
            // colRemark
            // 
            colRemark.HeaderText = "備註";
            colRemark.Name = "colRemark";
            // 
            // panelFooter
            // 
            panelFooter.Controls.Add(lbl覆核人員);
            panelFooter.Controls.Add(txtApprover);
            panelFooter.Controls.Add(lbl核准);
            panelFooter.Controls.Add(txtApprove);
            panelFooter.Controls.Add(lbl核准日);
            panelFooter.Controls.Add(txtApproveDate);
            panelFooter.Controls.Add(lbl修改人員);
            panelFooter.Controls.Add(txtModifier);
            panelFooter.Controls.Add(lbl修改);
            panelFooter.Controls.Add(txtModify);
            panelFooter.Controls.Add(lbl修改日);
            panelFooter.Controls.Add(txtModifyDate);
            panelFooter.Controls.Add(lbl建檔人員);
            panelFooter.Controls.Add(txtCreator);
            panelFooter.Controls.Add(lbl建檔);
            panelFooter.Controls.Add(txtCreate);
            panelFooter.Controls.Add(lbl建檔日);
            panelFooter.Controls.Add(txtCreateDate);
            panelFooter.Dock = DockStyle.Bottom;
            panelFooter.Location = new Point(0, 858);
            panelFooter.Name = "panelFooter";
            panelFooter.Size = new Size(1654, 50);
            panelFooter.TabIndex = 3;
            // 
            // lbl覆核人員
            // 
            lbl覆核人員.AutoSize = true;
            lbl覆核人員.Location = new Point(2, 14);
            lbl覆核人員.Name = "lbl覆核人員";
            lbl覆核人員.Size = new Size(86, 24);
            lbl覆核人員.TabIndex = 0;
            lbl覆核人員.Text = "覆核人員";
            // 
            // txtApprover
            // 
            txtApprover.BackColor = Color.LightGray;
            txtApprover.Location = new Point(90, 8);
            txtApprover.Name = "txtApprover";
            txtApprover.ReadOnly = true;
            txtApprover.Size = new Size(90, 32);
            txtApprover.TabIndex = 1;
            // 
            // lbl核准
            // 
            lbl核准.AutoSize = true;
            lbl核准.Location = new Point(182, 14);
            lbl核准.Name = "lbl核准";
            lbl核准.Size = new Size(48, 24);
            lbl核准.TabIndex = 2;
            lbl核准.Text = "核准";
            // 
            // txtApprove
            // 
            txtApprove.BackColor = Color.LightGray;
            txtApprove.Location = new Point(230, 8);
            txtApprove.Name = "txtApprove";
            txtApprove.ReadOnly = true;
            txtApprove.Size = new Size(120, 32);
            txtApprove.TabIndex = 3;
            // 
            // lbl核准日
            // 
            lbl核准日.AutoSize = true;
            lbl核准日.Location = new Point(351, 14);
            lbl核准日.Name = "lbl核准日";
            lbl核准日.Size = new Size(67, 24);
            lbl核准日.TabIndex = 4;
            lbl核准日.Text = "核准日";
            // 
            // txtApproveDate
            // 
            txtApproveDate.BackColor = Color.LightGray;
            txtApproveDate.Location = new Point(417, 8);
            txtApproveDate.Name = "txtApproveDate";
            txtApproveDate.ReadOnly = true;
            txtApproveDate.Size = new Size(120, 32);
            txtApproveDate.TabIndex = 5;
            // 
            // lbl修改人員
            // 
            lbl修改人員.AutoSize = true;
            lbl修改人員.Location = new Point(540, 14);
            lbl修改人員.Name = "lbl修改人員";
            lbl修改人員.Size = new Size(86, 24);
            lbl修改人員.TabIndex = 6;
            lbl修改人員.Text = "修改人員";
            // 
            // txtModifier
            // 
            txtModifier.BackColor = Color.LightGray;
            txtModifier.Location = new Point(627, 8);
            txtModifier.Name = "txtModifier";
            txtModifier.ReadOnly = true;
            txtModifier.Size = new Size(90, 32);
            txtModifier.TabIndex = 7;
            // 
            // lbl修改
            // 
            lbl修改.AutoSize = true;
            lbl修改.Location = new Point(719, 14);
            lbl修改.Name = "lbl修改";
            lbl修改.Size = new Size(48, 24);
            lbl修改.TabIndex = 8;
            lbl修改.Text = "修改";
            // 
            // txtModify
            // 
            txtModify.BackColor = Color.LightGray;
            txtModify.Location = new Point(768, 8);
            txtModify.Name = "txtModify";
            txtModify.ReadOnly = true;
            txtModify.Size = new Size(112, 32);
            txtModify.TabIndex = 9;
            // 
            // lbl修改日
            // 
            lbl修改日.AutoSize = true;
            lbl修改日.Location = new Point(888, 14);
            lbl修改日.Name = "lbl修改日";
            lbl修改日.Size = new Size(67, 24);
            lbl修改日.TabIndex = 10;
            lbl修改日.Text = "修改日";
            // 
            // txtModifyDate
            // 
            txtModifyDate.BackColor = Color.LightGray;
            txtModifyDate.Location = new Point(964, 8);
            txtModifyDate.Name = "txtModifyDate";
            txtModifyDate.ReadOnly = true;
            txtModifyDate.Size = new Size(96, 32);
            txtModifyDate.TabIndex = 11;
            // 
            // lbl建檔人員
            // 
            lbl建檔人員.AutoSize = true;
            lbl建檔人員.Location = new Point(1074, 14);
            lbl建檔人員.Name = "lbl建檔人員";
            lbl建檔人員.Size = new Size(86, 24);
            lbl建檔人員.TabIndex = 12;
            lbl建檔人員.Text = "建檔人員";
            // 
            // txtCreator
            // 
            txtCreator.BackColor = Color.LightGray;
            txtCreator.Location = new Point(1168, 8);
            txtCreator.Name = "txtCreator";
            txtCreator.ReadOnly = true;
            txtCreator.Size = new Size(74, 32);
            txtCreator.TabIndex = 13;
            // 
            // lbl建檔
            // 
            lbl建檔.AutoSize = true;
            lbl建檔.Location = new Point(1248, 12);
            lbl建檔.Name = "lbl建檔";
            lbl建檔.Size = new Size(48, 24);
            lbl建檔.TabIndex = 14;
            lbl建檔.Text = "建檔";
            // 
            // txtCreate
            // 
            txtCreate.BackColor = Color.LightGray;
            txtCreate.Location = new Point(1296, 8);
            txtCreate.Name = "txtCreate";
            txtCreate.ReadOnly = true;
            txtCreate.Size = new Size(112, 32);
            txtCreate.TabIndex = 15;
            // 
            // lbl建檔日
            // 
            lbl建檔日.AutoSize = true;
            lbl建檔日.Location = new Point(1416, 14);
            lbl建檔日.Name = "lbl建檔日";
            lbl建檔日.Size = new Size(67, 24);
            lbl建檔日.TabIndex = 16;
            lbl建檔日.Text = "建檔日";
            // 
            // txtCreateDate
            // 
            txtCreateDate.BackColor = Color.LightGray;
            txtCreateDate.Location = new Point(1480, 8);
            txtCreateDate.Name = "txtCreateDate";
            txtCreateDate.ReadOnly = true;
            txtCreateDate.Size = new Size(106, 32);
            txtCreateDate.TabIndex = 17;
            // 
            // OtherIncomeMaintainControl
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(255, 192, 192);
            Controls.Add(panel2);
            Controls.Add(panelFooter);
            Controls.Add(panelForm);
            Controls.Add(panel1);
            Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            Name = "OtherIncomeMaintainControl";
            Size = new Size(1654, 908);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelForm.ResumeLayout(false);
            panelForm.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panelFooter.ResumeLayout(false);
            panelFooter.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnBack;
        private Button btnSubmit;
        private Button btnDelete;
        private Button btnApprove;
        private Button btnCancelApprove;
        private Button btnModify;
        public Label lblMode;

        private Panel panelForm;
        private Label lbl日期;
        private DateTimePicker dtDate;
        private Label lbl單號;
        private TextBox txtFormNo;
        private Label lbl客戶編號;
        private DigiERP.Common.CommonComboBox cboCustId;
        private Label lbl客戶簡稱;
        private TextBox txtCustAlias;
        private Label lbl傳票;
        private TextBox txtVoucher;
        private Label lbl業務人員;
        private DigiERP.Common.CommonComboBox cboSales;
        private TextBox txtSalesName;
        private Label lbl幣別;
        private DigiERP.Common.CommonComboBox cboCurrency;
        private Label lbl匯率;
        private TextBox txtExRate;
        private Label lbl稅別;
        private DigiERP.Common.CommonComboBox cboTaxType;
        private Label lbl稅率;
        private DigiERP.Common.CommonComboBox cboTaxRate;
        private Label lbl客戶全名;
        private TextBox txtCompany;
        private Label lbl收款帳號;
        private TextBox txtCredibility;
        private Label lblMachineNo;
        private TextBox txtMachineNo;
        private Label lbl貿易條件;
        private Common.PriceCondControl priceCondControl1;
        private Label lbl付款方式;
        private Common.PriceCondControl payMethod;
        private Label lbl備註;
        private TextBox txtRemark;

        private Panel panel2;
        private DataGridView dataGridView1;
        private DataGridViewComboBoxColumn colItemNo;
        private DataGridViewTextBoxColumn colItemName;
        private DataGridViewTextBoxColumn colOrigAmount;
        private DataGridViewTextBoxColumn colTaxFree;
        private DataGridViewTextBoxColumn colTax;
        private DataGridViewTextBoxColumn colTotal;
        private DataGridViewTextBoxColumn colRemark;

        private Panel panelFooter;
        private Label lbl覆核人員;
        private TextBox txtApprover;
        private Label lbl核准;
        private TextBox txtApprove;
        private Label lbl核准日;
        private TextBox txtApproveDate;
        private Label lbl修改人員;
        private TextBox txtModifier;
        private Label lbl修改;
        private TextBox txtModify;
        private Label lbl修改日;
        private TextBox txtModifyDate;
        private Label lbl建檔人員;
        private TextBox txtCreator;
        private Label lbl建檔;
        private TextBox txtCreate;
        private Label lbl建檔日;
        private TextBox txtCreateDate;
    }
}
