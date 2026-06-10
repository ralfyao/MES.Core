namespace DigiERP.UserControl.Customer.ShippingOrder
{
    partial class ShippingOrderMaintainControl
    {
        /// <summary> 
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 元件設計工具產生的程式碼

        /// <summary> 
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            lblMode = new Label();
            label1 = new Label();
            btnClose = new Button();
            btnModify = new Button();
            label2 = new Label();
            dtORDERDATE = new DigiERP.Common.CommonDateTimePicker();
            txtOrderNo = new DigiERP.Common.CommonTextBox();
            label3 = new Label();
            cboCustId = new DigiERP.Common.CommonComboBox();
            label13 = new Label();
            btnSearch = new Button();
            lblCustAlias = new Label();
            label4 = new Label();
            label6 = new Label();
            label7 = new Label();
            dtShippingDate = new DigiERP.Common.CommonDateTimePicker();
            txtCommission = new DigiERP.Common.CommonTextBox();
            label5 = new Label();
            cboTaxType = new DigiERP.Common.CommonComboBox();
            cboTaxRate = new DigiERP.Common.CommonComboBox();
            txtCustName = new DigiERP.Common.CommonTextBox();
            label8 = new Label();
            cboCurrency = new DigiERP.Common.CommonComboBox();
            label9 = new Label();
            txtExRate = new DigiERP.Common.CommonTextBox();
            label10 = new Label();
            txtAmountSum = new DigiERP.Common.CommonTextBox();
            label11 = new Label();
            txtAddress = new DigiERP.Common.CommonTextBox();
            label12 = new Label();
            txtBankCode = new DigiERP.Common.CommonTextBox();
            label14 = new Label();
            btnCheck = new Button();
            txtCountry = new DigiERP.Common.CommonTextBox();
            label15 = new Label();
            txtDestination = new DigiERP.Common.CommonTextBox();
            label16 = new Label();
            cboShipMethod = new DigiERP.Common.CommonComboBox();
            label17 = new Label();
            cboTradeCond = new DigiERP.Common.CommonComboBox();
            label18 = new Label();
            cboSales = new DigiERP.Common.CommonComboBox();
            label19 = new Label();
            lblSalesName = new Label();
            txtRemark = new DigiERP.Common.CommonTextBox();
            label20 = new Label();
            cboPaymentTerm = new DigiERP.Common.CommonComboBox();
            label21 = new Label();
            lblPaymentTerm = new Label();
            dataGridView1 = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            ProductNo = new DataGridViewTextBoxColumn();
            ProductName = new DataGridViewTextBoxColumn();
            SalesUnit = new DataGridViewTextBoxColumn();
            Qty = new DataGridViewTextBoxColumn();
            UnitPrice = new DataGridViewTextBoxColumn();
            UnTaxedAmount = new DataGridViewTextBoxColumn();
            Remark = new DataGridViewTextBoxColumn();
            ProjectNo = new DataGridViewTextBoxColumn();
            WareHouse = new DataGridViewTextBoxColumn();
            SalesOrderNo = new DataGridViewTextBoxColumn();
            label22 = new Label();
            lblTotalSum = new Label();
            lblAuditor = new Label();
            label24 = new Label();
            lblAuditDate = new Label();
            lblCreateDate = new Label();
            lblCreator = new Label();
            label26 = new Label();
            lblModifyDate = new Label();
            lblModifier = new Label();
            label27 = new Label();
            btnSODistribute = new Button();
            btnSubmit = new Button();
            btnVerify = new Button();
            btnCancelVerify = new Button();
            btnPrint = new Button();
            lblTradeCond = new Label();
            lblShippingMethod = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblMode
            // 
            lblMode.AutoSize = true;
            lblMode.BackColor = Color.Lime;
            lblMode.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            lblMode.Location = new Point(8, 8);
            lblMode.Margin = new Padding(2, 0, 2, 0);
            lblMode.Name = "lblMode";
            lblMode.Size = new Size(85, 24);
            lblMode.TabIndex = 160;
            lblMode.Text = "lblMode";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Lime;
            label1.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label1.Location = new Point(58, 8);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(67, 24);
            label1.TabIndex = 161;
            label1.Text = "出貨單";
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Red;
            btnClose.ForeColor = SystemColors.ButtonHighlight;
            btnClose.Location = new Point(1128, 8);
            btnClose.Margin = new Padding(2);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(20, 22);
            btnClose.TabIndex = 162;
            btnClose.Text = "X";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // btnModify
            // 
            btnModify.BackColor = Color.FromArgb(192, 0, 0);
            btnModify.ForeColor = SystemColors.ButtonHighlight;
            btnModify.Location = new Point(148, 8);
            btnModify.Name = "btnModify";
            btnModify.Size = new Size(75, 23);
            btnModify.TabIndex = 227;
            btnModify.Text = "修改";
            btnModify.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft JhengHei UI", 14.25F);
            label2.Location = new Point(8, 40);
            label2.Name = "label2";
            label2.Size = new Size(48, 24);
            label2.TabIndex = 229;
            label2.Text = "日期";
            // 
            // dtORDERDATE
            // 
            dtORDERDATE.Enabled = false;
            dtORDERDATE.Font = new Font("Microsoft JhengHei UI", 14.25F);
            dtORDERDATE.Location = new Point(56, 36);
            dtORDERDATE.Name = "dtORDERDATE";
            dtORDERDATE.Size = new Size(184, 32);
            dtORDERDATE.TabIndex = 228;
            dtORDERDATE.Value = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            // 
            // txtOrderNo
            // 
            txtOrderNo.Enabled = false;
            txtOrderNo.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            txtOrderNo.Location = new Point(302, 38);
            txtOrderNo.Name = "txtOrderNo";
            txtOrderNo.Size = new Size(144, 32);
            txtOrderNo.TabIndex = 231;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft JhengHei UI", 14.25F);
            label3.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            label3.Location = new Point(248, 40);
            label3.Name = "label3";
            label3.Size = new Size(48, 24);
            label3.TabIndex = 230;
            label3.Text = "單號";
            // 
            // cboCustId
            // 
            cboCustId.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCustId.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            cboCustId.FormattingEnabled = true;
            cboCustId.Location = new Point(544, 39);
            cboCustId.Name = "cboCustId";
            cboCustId.Size = new Size(121, 32);
            cboCustId.TabIndex = 233;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Microsoft JhengHei UI", 14.25F);
            label13.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            label13.Location = new Point(456, 44);
            label13.Name = "label13";
            label13.Size = new Size(86, 24);
            label13.TabIndex = 232;
            label13.Text = "客戶編號";
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            btnSearch.Image = Properties.Resources.search_24dp_1F1F1F_FILL0_wght400_GRAD0_opsz24;
            btnSearch.Location = new Point(672, 40);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(40, 32);
            btnSearch.TabIndex = 234;
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // lblCustAlias
            // 
            lblCustAlias.AutoSize = true;
            lblCustAlias.Font = new Font("Microsoft JhengHei UI", 14.25F);
            lblCustAlias.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            lblCustAlias.Location = new Point(812, 44);
            lblCustAlias.Name = "lblCustAlias";
            lblCustAlias.Size = new Size(95, 24);
            lblCustAlias.TabIndex = 236;
            lblCustAlias.Text = "                 ";
            lblCustAlias.Click += lblCustAlias_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft JhengHei UI", 14.25F);
            label4.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            label4.Location = new Point(724, 44);
            label4.Name = "label4";
            label4.Size = new Size(86, 24);
            label4.TabIndex = 235;
            label4.Text = "客戶簡稱";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft JhengHei UI", 14.25F);
            label6.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            label6.Location = new Point(924, 43);
            label6.Name = "label6";
            label6.Size = new Size(86, 24);
            label6.TabIndex = 237;
            label6.Text = "應付佣金";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft JhengHei UI", 14.25F);
            label7.Location = new Point(12, 84);
            label7.Name = "label7";
            label7.Size = new Size(105, 24);
            label7.TabIndex = 240;
            label7.Text = "原定交貨日";
            // 
            // dtShippingDate
            // 
            dtShippingDate.Enabled = false;
            dtShippingDate.Font = new Font("Microsoft JhengHei UI", 14.25F);
            dtShippingDate.Location = new Point(124, 80);
            dtShippingDate.Name = "dtShippingDate";
            dtShippingDate.Size = new Size(184, 32);
            dtShippingDate.TabIndex = 239;
            dtShippingDate.Value = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            // 
            // txtCommission
            // 
            txtCommission.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            txtCommission.Location = new Point(1016, 40);
            txtCommission.Name = "txtCommission";
            txtCommission.Size = new Size(132, 32);
            txtCommission.TabIndex = 241;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft JhengHei UI", 14.25F);
            label5.Location = new Point(316, 84);
            label5.Name = "label5";
            label5.Size = new Size(86, 24);
            label5.TabIndex = 242;
            label5.Text = "營業稅率";
            // 
            // cboTaxType
            // 
            cboTaxType.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            cboTaxType.FormattingEnabled = true;
            cboTaxType.Items.AddRange(new object[] { "", "零稅率", "應稅", "免稅" });
            cboTaxType.Location = new Point(404, 80);
            cboTaxType.Name = "cboTaxType";
            cboTaxType.Size = new Size(92, 32);
            cboTaxType.TabIndex = 243;
            // 
            // cboTaxRate
            // 
            cboTaxRate.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            cboTaxRate.FormattingEnabled = true;
            cboTaxRate.Items.AddRange(new object[] { "", "0%", "5%" });
            cboTaxRate.Location = new Point(504, 80);
            cboTaxRate.Name = "cboTaxRate";
            cboTaxRate.Size = new Size(68, 32);
            cboTaxRate.TabIndex = 244;
            // 
            // txtCustName
            // 
            txtCustName.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            txtCustName.Location = new Point(672, 81);
            txtCustName.Name = "txtCustName";
            txtCustName.Size = new Size(476, 32);
            txtCustName.TabIndex = 246;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft JhengHei UI", 14.25F);
            label8.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            label8.Location = new Point(580, 84);
            label8.Name = "label8";
            label8.Size = new Size(86, 24);
            label8.TabIndex = 245;
            label8.Text = "客戶全名";
            // 
            // cboCurrency
            // 
            cboCurrency.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            cboCurrency.FormattingEnabled = true;
            cboCurrency.Items.AddRange(new object[] { "", "零稅率", "應稅", "免稅" });
            cboCurrency.Location = new Point(68, 120);
            cboCurrency.Name = "cboCurrency";
            cboCurrency.Size = new Size(92, 32);
            cboCurrency.TabIndex = 248;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft JhengHei UI", 14.25F);
            label9.Location = new Point(16, 124);
            label9.Name = "label9";
            label9.Size = new Size(48, 24);
            label9.TabIndex = 247;
            label9.Text = "幣別";
            // 
            // txtExRate
            // 
            txtExRate.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            txtExRate.Location = new Point(220, 120);
            txtExRate.Name = "txtExRate";
            txtExRate.Size = new Size(80, 32);
            txtExRate.TabIndex = 250;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft JhengHei UI", 14.25F);
            label10.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            label10.Location = new Point(168, 124);
            label10.Name = "label10";
            label10.Size = new Size(48, 24);
            label10.TabIndex = 249;
            label10.Text = "匯率";
            // 
            // txtAmountSum
            // 
            txtAmountSum.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            txtAmountSum.Location = new Point(400, 120);
            txtAmountSum.Name = "txtAmountSum";
            txtAmountSum.Size = new Size(108, 32);
            txtAmountSum.TabIndex = 252;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft JhengHei UI", 14.25F);
            label11.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            label11.Location = new Point(308, 124);
            label11.Name = "label11";
            label11.Size = new Size(86, 24);
            label11.TabIndex = 251;
            label11.Text = "訂單總額";
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            txtAddress.Location = new Point(608, 121);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(540, 32);
            txtAddress.TabIndex = 254;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft JhengHei UI", 14.25F);
            label12.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            label12.Location = new Point(516, 124);
            label12.Name = "label12";
            label12.Size = new Size(86, 24);
            label12.TabIndex = 253;
            label12.Text = "收貨地址";
            // 
            // txtBankCode
            // 
            txtBankCode.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            txtBankCode.Location = new Point(108, 160);
            txtBankCode.Name = "txtBankCode";
            txtBankCode.Size = new Size(108, 32);
            txtBankCode.TabIndex = 256;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Microsoft JhengHei UI", 14.25F);
            label14.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            label14.Location = new Point(16, 164);
            label14.Name = "label14";
            label14.Size = new Size(86, 24);
            label14.TabIndex = 255;
            label14.Text = "收款帳號";
            // 
            // btnCheck
            // 
            btnCheck.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            btnCheck.Location = new Point(224, 160);
            btnCheck.Name = "btnCheck";
            btnCheck.Size = new Size(76, 36);
            btnCheck.TabIndex = 257;
            btnCheck.Text = "核對";
            btnCheck.UseVisualStyleBackColor = true;
            // 
            // txtCountry
            // 
            txtCountry.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            txtCountry.Location = new Point(400, 160);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new Size(136, 32);
            txtCountry.TabIndex = 259;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Microsoft JhengHei UI", 14.25F);
            label15.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            label15.Location = new Point(308, 164);
            label15.Name = "label15";
            label15.Size = new Size(86, 24);
            label15.TabIndex = 258;
            label15.Text = "指配國別";
            // 
            // txtDestination
            // 
            txtDestination.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            txtDestination.Location = new Point(624, 160);
            txtDestination.Name = "txtDestination";
            txtDestination.Size = new Size(136, 32);
            txtDestination.TabIndex = 261;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Microsoft JhengHei UI", 14.25F);
            label16.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            label16.Location = new Point(548, 164);
            label16.Name = "label16";
            label16.Size = new Size(67, 24);
            label16.TabIndex = 260;
            label16.Text = "目的地";
            // 
            // cboShipMethod
            // 
            cboShipMethod.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            cboShipMethod.FormattingEnabled = true;
            cboShipMethod.Items.AddRange(new object[] { "", "海運", "空運", "貨運指派", "客戶自取" });
            cboShipMethod.Location = new Point(856, 200);
            cboShipMethod.Name = "cboShipMethod";
            cboShipMethod.Size = new Size(84, 32);
            cboShipMethod.TabIndex = 263;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Microsoft JhengHei UI", 14.25F);
            label17.Location = new Point(768, 204);
            label17.Name = "label17";
            label17.Size = new Size(86, 24);
            label17.TabIndex = 262;
            label17.Text = "交貨方式";
            // 
            // cboTradeCond
            // 
            cboTradeCond.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            cboTradeCond.FormattingEnabled = true;
            cboTradeCond.Items.AddRange(new object[] { "", "海運", "空運", "貨運指派", "客戶自取" });
            cboTradeCond.Location = new Point(852, 160);
            cboTradeCond.Name = "cboTradeCond";
            cboTradeCond.Size = new Size(84, 32);
            cboTradeCond.TabIndex = 265;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Microsoft JhengHei UI", 14.25F);
            label18.Location = new Point(764, 164);
            label18.Name = "label18";
            label18.Size = new Size(86, 24);
            label18.TabIndex = 264;
            label18.Text = "貿易條件";
            // 
            // cboSales
            // 
            cboSales.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            cboSales.FormattingEnabled = true;
            cboSales.Items.AddRange(new object[] { "", "海運", "空運", "貨運指派", "客戶自取" });
            cboSales.Location = new Point(102, 202);
            cboSales.Name = "cboSales";
            cboSales.Size = new Size(84, 32);
            cboSales.TabIndex = 267;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Microsoft JhengHei UI", 14.25F);
            label19.Location = new Point(14, 206);
            label19.Name = "label19";
            label19.Size = new Size(86, 24);
            label19.TabIndex = 266;
            label19.Text = "業務人員";
            // 
            // lblSalesName
            // 
            lblSalesName.AutoSize = true;
            lblSalesName.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            lblSalesName.Location = new Point(192, 206);
            lblSalesName.Name = "lblSalesName";
            lblSalesName.Size = new Size(132, 24);
            lblSalesName.TabIndex = 268;
            lblSalesName.Text = "lblSalesName";
            // 
            // txtRemark
            // 
            txtRemark.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            txtRemark.Location = new Point(426, 202);
            txtRemark.Name = "txtRemark";
            txtRemark.Size = new Size(334, 32);
            txtRemark.TabIndex = 270;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Microsoft JhengHei UI", 14.25F);
            label20.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            label20.Location = new Point(336, 206);
            label20.Name = "label20";
            label20.Size = new Size(86, 24);
            label20.TabIndex = 269;
            label20.Text = "備註說明";
            // 
            // cboPaymentTerm
            // 
            cboPaymentTerm.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            cboPaymentTerm.FormattingEnabled = true;
            cboPaymentTerm.Items.AddRange(new object[] { "", "海運", "空運", "貨運指派", "客戶自取" });
            cboPaymentTerm.Location = new Point(104, 240);
            cboPaymentTerm.Name = "cboPaymentTerm";
            cboPaymentTerm.Size = new Size(112, 32);
            cboPaymentTerm.TabIndex = 272;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Microsoft JhengHei UI", 14.25F);
            label21.Location = new Point(16, 244);
            label21.Name = "label21";
            label21.Size = new Size(86, 24);
            label21.TabIndex = 271;
            label21.Text = "付款方式";
            // 
            // lblPaymentTerm
            // 
            lblPaymentTerm.AutoSize = true;
            lblPaymentTerm.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            lblPaymentTerm.Location = new Point(224, 244);
            lblPaymentTerm.Name = "lblPaymentTerm";
            lblPaymentTerm.Size = new Size(158, 24);
            lblPaymentTerm.TabIndex = 273;
            lblPaymentTerm.Text = "lblPaymentTerm";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ID, ProductNo, ProductName, SalesUnit, Qty, UnitPrice, UnTaxedAmount, Remark, ProjectNo, WareHouse, SalesOrderNo });
            dataGridView1.Location = new Point(20, 288);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1128, 324);
            dataGridView1.TabIndex = 274;
            // 
            // ID
            // 
            ID.HeaderText = "識別";
            ID.Name = "ID";
            ID.Visible = false;
            // 
            // ProductNo
            // 
            ProductNo.HeaderText = "產品編號";
            ProductNo.Name = "ProductNo";
            ProductNo.ReadOnly = true;
            // 
            // ProductName
            // 
            ProductName.HeaderText = "品名";
            ProductName.Name = "ProductName";
            ProductName.ReadOnly = true;
            // 
            // SalesUnit
            // 
            SalesUnit.HeaderText = "銷售單位";
            SalesUnit.Name = "SalesUnit";
            SalesUnit.ReadOnly = true;
            // 
            // Qty
            // 
            Qty.HeaderText = "數量";
            Qty.Name = "Qty";
            Qty.ReadOnly = true;
            // 
            // UnitPrice
            // 
            UnitPrice.HeaderText = "訂金單價";
            UnitPrice.Name = "UnitPrice";
            UnitPrice.ReadOnly = true;
            // 
            // UnTaxedAmount
            // 
            UnTaxedAmount.HeaderText = "未稅金額";
            UnTaxedAmount.Name = "UnTaxedAmount";
            UnTaxedAmount.ReadOnly = true;
            // 
            // Remark
            // 
            Remark.HeaderText = "註記";
            Remark.Name = "Remark";
            Remark.ReadOnly = true;
            // 
            // ProjectNo
            // 
            ProjectNo.HeaderText = "專案序號";
            ProjectNo.Name = "ProjectNo";
            ProjectNo.ReadOnly = true;
            // 
            // WareHouse
            // 
            WareHouse.HeaderText = "倉庫別";
            WareHouse.Name = "WareHouse";
            WareHouse.ReadOnly = true;
            // 
            // SalesOrderNo
            // 
            SalesOrderNo.HeaderText = "訂單單號";
            SalesOrderNo.Name = "SalesOrderNo";
            SalesOrderNo.ReadOnly = true;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label22.Location = new Point(932, 620);
            label22.Name = "label22";
            label22.Size = new Size(86, 24);
            label22.TabIndex = 275;
            label22.Text = "金額總計";
            // 
            // lblTotalSum
            // 
            lblTotalSum.AutoSize = true;
            lblTotalSum.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            lblTotalSum.Location = new Point(1020, 620);
            lblTotalSum.Name = "lblTotalSum";
            lblTotalSum.Size = new Size(118, 24);
            lblTotalSum.TabIndex = 276;
            lblTotalSum.Text = "lblTotalSum";
            // 
            // lblAuditor
            // 
            lblAuditor.AutoSize = true;
            lblAuditor.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            lblAuditor.Location = new Point(112, 648);
            lblAuditor.Name = "lblAuditor";
            lblAuditor.Size = new Size(100, 24);
            lblAuditor.TabIndex = 278;
            lblAuditor.Text = "lblAuditor";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label24.Location = new Point(24, 648);
            label24.Name = "label24";
            label24.Size = new Size(86, 24);
            label24.TabIndex = 277;
            label24.Text = "財務覆核";
            // 
            // lblAuditDate
            // 
            lblAuditDate.AutoSize = true;
            lblAuditDate.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            lblAuditDate.Location = new Point(216, 648);
            lblAuditDate.Name = "lblAuditDate";
            lblAuditDate.Size = new Size(123, 24);
            lblAuditDate.TabIndex = 279;
            lblAuditDate.Text = "lblAuditDate";
            // 
            // lblCreateDate
            // 
            lblCreateDate.AutoSize = true;
            lblCreateDate.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            lblCreateDate.Location = new Point(612, 648);
            lblCreateDate.Name = "lblCreateDate";
            lblCreateDate.Size = new Size(133, 24);
            lblCreateDate.TabIndex = 282;
            lblCreateDate.Text = "lblCreateDate";
            // 
            // lblCreator
            // 
            lblCreator.AutoSize = true;
            lblCreator.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            lblCreator.Location = new Point(508, 648);
            lblCreator.Name = "lblCreator";
            lblCreator.Size = new Size(99, 24);
            lblCreator.TabIndex = 281;
            lblCreator.Text = "lblCreator";
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label26.Location = new Point(420, 648);
            label26.Name = "label26";
            label26.Size = new Size(86, 24);
            label26.TabIndex = 280;
            label26.Text = "建檔人員";
            // 
            // lblModifyDate
            // 
            lblModifyDate.AutoSize = true;
            lblModifyDate.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            lblModifyDate.Location = new Point(1020, 648);
            lblModifyDate.Name = "lblModifyDate";
            lblModifyDate.Size = new Size(137, 24);
            lblModifyDate.TabIndex = 285;
            lblModifyDate.Text = "lblModifyDate";
            // 
            // lblModifier
            // 
            lblModifier.AutoSize = true;
            lblModifier.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            lblModifier.Location = new Point(908, 648);
            lblModifier.Name = "lblModifier";
            lblModifier.Size = new Size(108, 24);
            lblModifier.TabIndex = 284;
            lblModifier.Text = "lblModifier";
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label27.Location = new Point(820, 648);
            label27.Name = "label27";
            label27.Size = new Size(86, 24);
            label27.TabIndex = 283;
            label27.Text = "修改人員";
            // 
            // btnSODistribute
            // 
            btnSODistribute.BackColor = Color.RoyalBlue;
            btnSODistribute.ForeColor = SystemColors.ButtonHighlight;
            btnSODistribute.Location = new Point(232, 8);
            btnSODistribute.Name = "btnSODistribute";
            btnSODistribute.Size = new Size(75, 23);
            btnSODistribute.TabIndex = 286;
            btnSODistribute.Text = "訂單分配";
            btnSODistribute.UseVisualStyleBackColor = false;
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.FromArgb(0, 192, 0);
            btnSubmit.ForeColor = SystemColors.ButtonHighlight;
            btnSubmit.Location = new Point(1048, 8);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(75, 23);
            btnSubmit.TabIndex = 287;
            btnSubmit.Text = "送出";
            btnSubmit.UseVisualStyleBackColor = false;
            // 
            // btnVerify
            // 
            btnVerify.BackColor = Color.Gray;
            btnVerify.ForeColor = SystemColors.ButtonHighlight;
            btnVerify.Location = new Point(792, 8);
            btnVerify.Name = "btnVerify";
            btnVerify.Size = new Size(75, 23);
            btnVerify.TabIndex = 288;
            btnVerify.Text = "覆核";
            btnVerify.UseVisualStyleBackColor = false;
            // 
            // btnCancelVerify
            // 
            btnCancelVerify.BackColor = Color.Gray;
            btnCancelVerify.ForeColor = SystemColors.ButtonHighlight;
            btnCancelVerify.Location = new Point(872, 8);
            btnCancelVerify.Name = "btnCancelVerify";
            btnCancelVerify.Size = new Size(75, 23);
            btnCancelVerify.TabIndex = 289;
            btnCancelVerify.Text = "取消覆核";
            btnCancelVerify.UseVisualStyleBackColor = false;
            // 
            // btnPrint
            // 
            btnPrint.BackColor = Color.Gray;
            btnPrint.ForeColor = SystemColors.ButtonHighlight;
            btnPrint.Location = new Point(952, 8);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(75, 23);
            btnPrint.TabIndex = 290;
            btnPrint.Text = "列印";
            btnPrint.UseVisualStyleBackColor = false;
            // 
            // lblTradeCond
            // 
            lblTradeCond.AutoSize = true;
            lblTradeCond.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            lblTradeCond.Location = new Point(944, 164);
            lblTradeCond.Name = "lblTradeCond";
            lblTradeCond.Size = new Size(132, 24);
            lblTradeCond.TabIndex = 291;
            lblTradeCond.Text = "lblTradeCond";
            // 
            // lblShippingMethod
            // 
            lblShippingMethod.AutoSize = true;
            lblShippingMethod.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            lblShippingMethod.Location = new Point(948, 204);
            lblShippingMethod.Name = "lblShippingMethod";
            lblShippingMethod.Size = new Size(185, 24);
            lblShippingMethod.TabIndex = 292;
            lblShippingMethod.Text = "lblShippingMethod";
            // 
            // ShippingOrderMaintainControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblShippingMethod);
            Controls.Add(lblTradeCond);
            Controls.Add(btnPrint);
            Controls.Add(btnCancelVerify);
            Controls.Add(btnVerify);
            Controls.Add(btnSubmit);
            Controls.Add(btnSODistribute);
            Controls.Add(lblModifyDate);
            Controls.Add(lblModifier);
            Controls.Add(label27);
            Controls.Add(lblCreateDate);
            Controls.Add(lblCreator);
            Controls.Add(label26);
            Controls.Add(lblAuditDate);
            Controls.Add(lblAuditor);
            Controls.Add(label24);
            Controls.Add(lblTotalSum);
            Controls.Add(label22);
            Controls.Add(dataGridView1);
            Controls.Add(lblPaymentTerm);
            Controls.Add(cboPaymentTerm);
            Controls.Add(label21);
            Controls.Add(txtRemark);
            Controls.Add(label20);
            Controls.Add(lblSalesName);
            Controls.Add(cboSales);
            Controls.Add(label19);
            Controls.Add(cboTradeCond);
            Controls.Add(label18);
            Controls.Add(cboShipMethod);
            Controls.Add(label17);
            Controls.Add(txtDestination);
            Controls.Add(label16);
            Controls.Add(txtCountry);
            Controls.Add(label15);
            Controls.Add(btnCheck);
            Controls.Add(txtBankCode);
            Controls.Add(label14);
            Controls.Add(txtAddress);
            Controls.Add(label12);
            Controls.Add(txtAmountSum);
            Controls.Add(label11);
            Controls.Add(txtExRate);
            Controls.Add(label10);
            Controls.Add(cboCurrency);
            Controls.Add(label9);
            Controls.Add(txtCustName);
            Controls.Add(label8);
            Controls.Add(cboTaxRate);
            Controls.Add(cboTaxType);
            Controls.Add(label5);
            Controls.Add(txtCommission);
            Controls.Add(label7);
            Controls.Add(dtShippingDate);
            Controls.Add(label6);
            Controls.Add(lblCustAlias);
            Controls.Add(label4);
            Controls.Add(btnSearch);
            Controls.Add(cboCustId);
            Controls.Add(label13);
            Controls.Add(txtOrderNo);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dtORDERDATE);
            Controls.Add(btnModify);
            Controls.Add(btnClose);
            Controls.Add(lblMode);
            Controls.Add(label1);
            Name = "ShippingOrderMaintainControl";
            Size = new Size(1180, 685);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMode;
        private Label label1;
        private Button btnClose;
        private Button btnModify;
        private Label label2;
        private DigiERP.Common.CommonDateTimePicker dtORDERDATE;
        private DigiERP.Common.CommonTextBox txtOrderNo;
        private Label label3;
        private DigiERP.Common.CommonComboBox cboCustId;
        private Label label13;
        private Button btnSearch;
        private Label lblCustAlias;
        private Label label4;
        private Label label6;
        private Label label7;
        private DigiERP.Common.CommonDateTimePicker dtShippingDate;
        private DigiERP.Common.CommonTextBox txtCommission;
        private Label label5;
        private DigiERP.Common.CommonComboBox cboTaxType;
        private DigiERP.Common.CommonComboBox cboTaxRate;
        private DigiERP.Common.CommonTextBox txtCustName;
        private Label label8;
        private DigiERP.Common.CommonComboBox cboCurrency;
        private Label label9;
        private DigiERP.Common.CommonTextBox txtExRate;
        private Label label10;
        private DigiERP.Common.CommonTextBox txtAmountSum;
        private Label label11;
        private DigiERP.Common.CommonTextBox txtAddress;
        private Label label12;
        private DigiERP.Common.CommonTextBox txtBankCode;
        private Label label14;
        private Button btnCheck;
        private DigiERP.Common.CommonTextBox txtCountry;
        private Label label15;
        private DigiERP.Common.CommonTextBox txtDestination;
        private Label label16;
        private DigiERP.Common.CommonComboBox cboShipMethod;
        private Label label17;
        private DigiERP.Common.CommonComboBox cboTradeCond;
        private Label label18;
        private DigiERP.Common.CommonComboBox cboSales;
        private Label label19;
        private Label lblSalesName;
        private DigiERP.Common.CommonTextBox txtRemark;
        private Label label20;
        private DigiERP.Common.CommonComboBox cboPaymentTerm;
        private Label label21;
        private Label lblPaymentTerm;
        private DataGridView dataGridView1;
        private Label label22;
        private Label lblTotalSum;
        private Label lblAuditor;
        private Label label24;
        private Label lblAuditDate;
        private Label lblCreateDate;
        private Label lblCreator;
        private Label label26;
        private Label lblModifyDate;
        private Label lblModifier;
        private Label label27;
        private Button btnSODistribute;
        private Button btnSubmit;
        private Button btnVerify;
        private Button btnCancelVerify;
        private Button btnPrint;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn ProductNo;
        private DataGridViewTextBoxColumn ProductName;
        private DataGridViewTextBoxColumn SalesUnit;
        private DataGridViewTextBoxColumn Qty;
        private DataGridViewTextBoxColumn UnitPrice;
        private DataGridViewTextBoxColumn UnTaxedAmount;
        private DataGridViewTextBoxColumn Remark;
        private DataGridViewTextBoxColumn ProjectNo;
        private DataGridViewTextBoxColumn WareHouse;
        private DataGridViewTextBoxColumn SalesOrderNo;
        private Label lblTradeCond;
        private Label lblShippingMethod;
    }
}
