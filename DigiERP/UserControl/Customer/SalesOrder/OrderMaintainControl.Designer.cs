using DigiERP.Common;

namespace DigiERP.UserControl.Customer.SalesOrder
{
    partial class OrderMaintainControl
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
            chkClosed = new CommonCheckBox();
            lblMode = new Label();
            label1 = new Label();
            button1 = new Button();
            btnModify = new Button();
            label2 = new Label();
            dtORDERDATE = new CommonDateTimePicker();
            txtOrderNo = new CommonTextBox();
            label3 = new Label();
            label13 = new Label();
            cboCustId = new CommonComboBox();
            dataGridView1 = new DataGridView();
            識別 = new DataGridViewTextBoxColumn();
            款項期別 = new DataGridViewTextBoxColumn();
            成數 = new DataGridViewTextBoxColumn();
            金額 = new DataGridViewTextBoxColumn();
            立帳單號 = new DataGridViewTextBoxColumn();
            轉立帳單 = new DataGridViewButtonColumn();
            label4 = new Label();
            lblCustAlias = new Label();
            label6 = new Label();
            dtETD = new CommonDateTimePicker();
            txtCompany = new CommonTextBox();
            label5 = new Label();
            label7 = new Label();
            cboSales = new CommonComboBox();
            label8 = new Label();
            cboCurrency = new CommonComboBox();
            label9 = new Label();
            txtAddress = new CommonTextBox();
            label10 = new Label();
            cboTaxType = new CommonComboBox();
            label11 = new Label();
            cboTaxRate = new CommonComboBox();
            priceCondControl1 = new Common.PriceCondControl();
            label12 = new Label();
            label14 = new Label();
            txtDestPort = new CommonTextBox();
            label15 = new Label();
            shipMethod = new Common.PriceCondControl();
            txtOrderSum = new CommonTextBox();
            label16 = new Label();
            label17 = new Label();
            ETDRequest = new Common.PriceCondControl();
            label18 = new Label();
            payMethod = new Common.PriceCondControl();
            label19 = new Label();
            bankCodeSelect1 = new Common.BankCodeSelect();
            btnCheck = new Button();
            txtCountry = new CommonTextBox();
            label20 = new Label();
            txtComment = new CommonTextBox();
            label21 = new Label();
            dgvDetail = new DataGridView();
            識別碼 = new DataGridViewTextBoxColumn();
            品項編號 = new DataGridViewTextBoxColumn();
            品名 = new DataGridViewTextBoxColumn();
            銷售單位 = new DataGridViewTextBoxColumn();
            數量 = new DataGridViewTextBoxColumn();
            訂單單價 = new DataGridViewTextBoxColumn();
            總金額 = new DataGridViewTextBoxColumn();
            報價單價 = new DataGridViewTextBoxColumn();
            折數 = new DataGridViewTextBoxColumn();
            註記 = new DataGridViewTextBoxColumn();
            專案序號 = new DataGridViewTextBoxColumn();
            機台類型 = new DataGridViewTextBoxColumn();
            傭金率 = new DataGridViewTextBoxColumn();
            報價單號 = new DataGridViewTextBoxColumn();
            btnAddLine = new Button();
            txtApprover = new CommonTextBox();
            label22 = new Label();
            txtApproveDate = new CommonTextBox();
            txtModifyDate = new CommonTextBox();
            txtModifier = new CommonTextBox();
            label23 = new Label();
            txtCreateDate = new CommonTextBox();
            txtCreator = new CommonTextBox();
            label24 = new Label();
            txtWorkOrder = new CommonTextBox();
            label25 = new Label();
            btnAddAR = new Button();
            btnSubmit = new Button();
            btnPrint = new Button();
            btnCancelActivate = new Button();
            btnActivate = new Button();
            btnDelete = new Button();
            btnTransShipping = new Button();
            btnTransWorkOrder = new Button();
            btnQuotationDistribution = new Button();
            txtAmount = new CommonTextBox();
            label26 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDetail).BeginInit();
            SuspendLayout();
            // 
            // chkClosed
            // 
            chkClosed.Location = new Point(780, 88);
            chkClosed.Name = "chkClosed";
            chkClosed.Size = new Size(28, 24);
            chkClosed.TabIndex = 240;
            chkClosed.CheckedChanged += commonCheckBox_CheckedChanged;
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
            lblMode.TabIndex = 158;
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
            label1.Size = new Size(48, 24);
            label1.TabIndex = 159;
            label1.Text = "訂單";
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(1416, 8);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(20, 22);
            button1.TabIndex = 160;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnModify
            // 
            btnModify.BackColor = Color.FromArgb(192, 0, 0);
            btnModify.ForeColor = SystemColors.ButtonHighlight;
            btnModify.Location = new Point(144, 8);
            btnModify.Name = "btnModify";
            btnModify.Size = new Size(75, 23);
            btnModify.TabIndex = 226;
            btnModify.Text = "修改";
            btnModify.UseVisualStyleBackColor = false;
            btnModify.Click += btnModify_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft JhengHei UI", 14.25F);
            label2.Location = new Point(8, 48);
            label2.Name = "label2";
            label2.Size = new Size(48, 24);
            label2.TabIndex = 225;
            label2.Text = "日期";
            // 
            // dtORDERDATE
            // 
            dtORDERDATE.Enabled = false;
            dtORDERDATE.Font = new Font("Microsoft JhengHei UI", 14.25F);
            dtORDERDATE.Location = new Point(56, 44);
            dtORDERDATE.Name = "dtORDERDATE";
            dtORDERDATE.Size = new Size(184, 32);
            dtORDERDATE.TabIndex = 224;
            dtORDERDATE.Value = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            // 
            // txtOrderNo
            // 
            txtOrderNo.Enabled = false;
            txtOrderNo.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            txtOrderNo.Location = new Point(302, 44);
            txtOrderNo.Name = "txtOrderNo";
            txtOrderNo.Size = new Size(144, 32);
            txtOrderNo.TabIndex = 228;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft JhengHei UI", 14.25F);
            label3.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            label3.Location = new Point(248, 46);
            label3.Name = "label3";
            label3.Size = new Size(48, 24);
            label3.TabIndex = 227;
            label3.Text = "單號";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Microsoft JhengHei UI", 14.25F);
            label13.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            label13.Location = new Point(456, 45);
            label13.Name = "label13";
            label13.Size = new Size(86, 24);
            label13.TabIndex = 230;
            label13.Text = "客戶編號";
            // 
            // cboCustId
            // 
            cboCustId.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCustId.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            cboCustId.FormattingEnabled = true;
            cboCustId.Location = new Point(544, 40);
            cboCustId.Name = "cboCustId";
            cboCustId.Size = new Size(121, 32);
            cboCustId.TabIndex = 231;
            cboCustId.Enter += cboCustId_Enter;
            cboCustId.Leave += cboCustId_Leave;
            cboCustId.MouseClick += cboCustId_MouseClick;
            cboCustId.MouseLeave += cboCustId_MouseLeave;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { 識別, 款項期別, 成數, 金額, 立帳單號, 轉立帳單 });
            dataGridView1.Location = new Point(876, 40);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(540, 312);
            dataGridView1.TabIndex = 232;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // 識別
            // 
            識別.HeaderText = "識別";
            識別.Name = "識別";
            識別.ReadOnly = true;
            識別.Visible = false;
            // 
            // 款項期別
            // 
            款項期別.HeaderText = "款項期別";
            款項期別.Name = "款項期別";
            款項期別.ReadOnly = true;
            // 
            // 成數
            // 
            成數.HeaderText = "成數";
            成數.Name = "成數";
            成數.ReadOnly = true;
            // 
            // 金額
            // 
            金額.HeaderText = "金額";
            金額.Name = "金額";
            金額.ReadOnly = true;
            // 
            // 立帳單號
            // 
            立帳單號.HeaderText = "立帳單號";
            立帳單號.Name = "立帳單號";
            立帳單號.ReadOnly = true;
            // 
            // 轉立帳單
            // 
            轉立帳單.HeaderText = "轉立帳單";
            轉立帳單.Name = "轉立帳單";
            轉立帳單.ReadOnly = true;
            轉立帳單.Resizable = DataGridViewTriState.True;
            轉立帳單.SortMode = DataGridViewColumnSortMode.Automatic;
            轉立帳單.Text = "轉立帳單";
            轉立帳單.UseColumnTextForButtonValue = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft JhengHei UI", 14.25F);
            label4.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            label4.Location = new Point(675, 44);
            label4.Name = "label4";
            label4.Size = new Size(86, 24);
            label4.TabIndex = 233;
            label4.Text = "客戶簡稱";
            // 
            // lblCustAlias
            // 
            lblCustAlias.AutoSize = true;
            lblCustAlias.Font = new Font("Microsoft JhengHei UI", 14.25F);
            lblCustAlias.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            lblCustAlias.Location = new Point(766, 45);
            lblCustAlias.Name = "lblCustAlias";
            lblCustAlias.Size = new Size(95, 24);
            lblCustAlias.TabIndex = 234;
            lblCustAlias.Text = "                 ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft JhengHei UI", 14.25F);
            label6.Location = new Point(8, 92);
            label6.Name = "label6";
            label6.Size = new Size(86, 24);
            label6.TabIndex = 236;
            label6.Text = "預交日期";
            // 
            // dtETD
            // 
            dtETD.Enabled = false;
            dtETD.Font = new Font("Microsoft JhengHei UI", 14.25F);
            dtETD.Location = new Point(96, 88);
            dtETD.Name = "dtETD";
            dtETD.Size = new Size(184, 32);
            dtETD.TabIndex = 235;
            dtETD.Value = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            // 
            // txtCompany
            // 
            txtCompany.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            txtCompany.Location = new Point(376, 86);
            txtCompany.Name = "txtCompany";
            txtCompany.Size = new Size(342, 32);
            txtCompany.TabIndex = 238;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft JhengHei UI", 14.25F);
            label5.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            label5.Location = new Point(284, 90);
            label5.Name = "label5";
            label5.Size = new Size(86, 24);
            label5.TabIndex = 237;
            label5.Text = "客戶全名";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft JhengHei UI", 14.25F);
            label7.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            label7.Location = new Point(724, 88);
            label7.Name = "label7";
            label7.Size = new Size(48, 24);
            label7.TabIndex = 239;
            label7.Text = "結案";
            // 
            // cboSales
            // 
            cboSales.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSales.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            cboSales.FormattingEnabled = true;
            cboSales.Location = new Point(100, 131);
            cboSales.Name = "cboSales";
            cboSales.Size = new Size(64, 32);
            cboSales.TabIndex = 242;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft JhengHei UI", 14.25F);
            label8.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            label8.Location = new Point(12, 136);
            label8.Name = "label8";
            label8.Size = new Size(86, 24);
            label8.TabIndex = 241;
            label8.Text = "業務人員";
            // 
            // cboCurrency
            // 
            cboCurrency.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCurrency.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            cboCurrency.FormattingEnabled = true;
            cboCurrency.Location = new Point(216, 132);
            cboCurrency.Name = "cboCurrency";
            cboCurrency.Size = new Size(64, 32);
            cboCurrency.TabIndex = 244;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft JhengHei UI", 14.25F);
            label9.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            label9.Location = new Point(168, 136);
            label9.Name = "label9";
            label9.Size = new Size(48, 24);
            label9.TabIndex = 243;
            label9.Text = "幣別";
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            txtAddress.Location = new Point(376, 130);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(488, 32);
            txtAddress.TabIndex = 246;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft JhengHei UI", 14.25F);
            label10.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            label10.Location = new Point(284, 134);
            label10.Name = "label10";
            label10.Size = new Size(86, 24);
            label10.TabIndex = 245;
            label10.Text = "收貨地址";
            // 
            // cboTaxType
            // 
            cboTaxType.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTaxType.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            cboTaxType.FormattingEnabled = true;
            cboTaxType.Items.AddRange(new object[] { "", "應稅", "免稅", "零稅率" });
            cboTaxType.Location = new Point(100, 175);
            cboTaxType.Name = "cboTaxType";
            cboTaxType.Size = new Size(64, 32);
            cboTaxType.TabIndex = 248;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft JhengHei UI", 14.25F);
            label11.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            label11.Location = new Point(12, 180);
            label11.Name = "label11";
            label11.Size = new Size(86, 24);
            label11.TabIndex = 247;
            label11.Text = "營業稅率";
            // 
            // cboTaxRate
            // 
            cboTaxRate.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTaxRate.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            cboTaxRate.FormattingEnabled = true;
            cboTaxRate.Items.AddRange(new object[] { "", "0%", "5%" });
            cboTaxRate.Location = new Point(176, 176);
            cboTaxRate.Name = "cboTaxRate";
            cboTaxRate.Size = new Size(64, 32);
            cboTaxRate.TabIndex = 249;
            // 
            // priceCondControl1
            // 
            priceCondControl1.Location = new Point(92, 216);
            priceCondControl1.Name = "priceCondControl1";
            priceCondControl1.Size = new Size(352, 82);
            priceCondControl1.TabIndex = 250;
            priceCondControl1.txType = null;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft JhengHei UI", 14.25F);
            label12.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            label12.Location = new Point(12, 220);
            label12.Name = "label12";
            label12.Size = new Size(86, 24);
            label12.TabIndex = 251;
            label12.Text = "價格條件";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Microsoft JhengHei UI", 14.25F);
            label14.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            label14.Location = new Point(252, 180);
            label14.Name = "label14";
            label14.Size = new Size(67, 24);
            label14.TabIndex = 252;
            label14.Text = "目的港";
            // 
            // txtDestPort
            // 
            txtDestPort.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            txtDestPort.Location = new Point(336, 176);
            txtDestPort.Name = "txtDestPort";
            txtDestPort.Size = new Size(228, 32);
            txtDestPort.TabIndex = 253;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Microsoft JhengHei UI", 14.25F);
            label15.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            label15.Location = new Point(404, 220);
            label15.Name = "label15";
            label15.Size = new Size(86, 24);
            label15.TabIndex = 255;
            label15.Text = "交貨方式";
            // 
            // shipMethod
            // 
            shipMethod.Location = new Point(484, 216);
            shipMethod.Name = "shipMethod";
            shipMethod.Size = new Size(352, 82);
            shipMethod.TabIndex = 254;
            shipMethod.txType = null;
            // 
            // txtOrderSum
            // 
            txtOrderSum.Enabled = false;
            txtOrderSum.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            txtOrderSum.Location = new Point(656, 172);
            txtOrderSum.Name = "txtOrderSum";
            txtOrderSum.Size = new Size(108, 32);
            txtOrderSum.TabIndex = 257;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Microsoft JhengHei UI", 14.25F);
            label16.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            label16.Location = new Point(572, 176);
            label16.Name = "label16";
            label16.Size = new Size(86, 24);
            label16.TabIndex = 256;
            label16.Text = "訂單總額";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Microsoft JhengHei UI", 14.25F);
            label17.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            label17.Location = new Point(12, 312);
            label17.Name = "label17";
            label17.Size = new Size(86, 24);
            label17.TabIndex = 259;
            label17.Text = "交期要求";
            // 
            // ETDRequest
            // 
            ETDRequest.Location = new Point(92, 308);
            ETDRequest.Name = "ETDRequest";
            ETDRequest.Size = new Size(352, 82);
            ETDRequest.TabIndex = 258;
            ETDRequest.txType = null;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Microsoft JhengHei UI", 14.25F);
            label18.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            label18.Location = new Point(404, 308);
            label18.Name = "label18";
            label18.Size = new Size(86, 24);
            label18.TabIndex = 261;
            label18.Text = "付款方式";
            // 
            // payMethod
            // 
            payMethod.Location = new Point(484, 304);
            payMethod.Name = "payMethod";
            payMethod.Size = new Size(352, 82);
            payMethod.TabIndex = 260;
            payMethod.txType = null;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Microsoft JhengHei UI", 14.25F);
            label19.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            label19.Location = new Point(8, 396);
            label19.Name = "label19";
            label19.Size = new Size(86, 24);
            label19.TabIndex = 262;
            label19.Text = "收款帳號";
            // 
            // bankCodeSelect1
            // 
            bankCodeSelect1.Location = new Point(92, 396);
            bankCodeSelect1.Margin = new Padding(2);
            bankCodeSelect1.Name = "bankCodeSelect1";
            bankCodeSelect1.Size = new Size(234, 44);
            bankCodeSelect1.TabIndex = 263;
            // 
            // btnCheck
            // 
            btnCheck.Location = new Point(340, 400);
            btnCheck.Name = "btnCheck";
            btnCheck.Size = new Size(75, 32);
            btnCheck.TabIndex = 264;
            btnCheck.Text = "核對";
            btnCheck.UseVisualStyleBackColor = true;
            btnCheck.Click += btnCheck_Click;
            // 
            // txtCountry
            // 
            txtCountry.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            txtCountry.Location = new Point(516, 400);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new Size(144, 32);
            txtCountry.TabIndex = 266;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Microsoft JhengHei UI", 14.25F);
            label20.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            label20.Location = new Point(432, 404);
            label20.Name = "label20";
            label20.Size = new Size(86, 24);
            label20.TabIndex = 265;
            label20.Text = "指配國別";
            // 
            // txtComment
            // 
            txtComment.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            txtComment.Location = new Point(768, 400);
            txtComment.Name = "txtComment";
            txtComment.Size = new Size(648, 32);
            txtComment.TabIndex = 268;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Microsoft JhengHei UI", 14.25F);
            label21.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            label21.Location = new Point(676, 404);
            label21.Name = "label21";
            label21.Size = new Size(86, 24);
            label21.TabIndex = 267;
            label21.Text = "備註說明";
            // 
            // dgvDetail
            // 
            dgvDetail.AllowUserToAddRows = false;
            dgvDetail.AllowUserToDeleteRows = false;
            dgvDetail.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDetail.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetail.Columns.AddRange(new DataGridViewColumn[] { 識別碼, 品項編號, 品名, 銷售單位, 數量, 訂單單價, 總金額, 報價單價, 折數, 註記, 專案序號, 機台類型, 傭金率, 報價單號 });
            dgvDetail.Location = new Point(16, 469);
            dgvDetail.Name = "dgvDetail";
            dgvDetail.Size = new Size(1396, 239);
            dgvDetail.TabIndex = 269;
            dgvDetail.CellEndEdit += dgvDetail_CellEndEdit;
            // 
            // 識別碼
            // 
            識別碼.HeaderText = "識別碼";
            識別碼.Name = "識別碼";
            識別碼.ReadOnly = true;
            識別碼.Visible = false;
            // 
            // 品項編號
            // 
            品項編號.HeaderText = "品項編號";
            品項編號.Name = "品項編號";
            品項編號.ReadOnly = true;
            // 
            // 品名
            // 
            品名.HeaderText = "品名";
            品名.Name = "品名";
            品名.ReadOnly = true;
            // 
            // 銷售單位
            // 
            銷售單位.HeaderText = "銷售單位";
            銷售單位.Name = "銷售單位";
            銷售單位.ReadOnly = true;
            // 
            // 數量
            // 
            數量.HeaderText = "數量";
            數量.Name = "數量";
            // 
            // 訂單單價
            // 
            訂單單價.HeaderText = "訂單單價";
            訂單單價.Name = "訂單單價";
            // 
            // 總金額
            // 
            總金額.HeaderText = "總金額";
            總金額.Name = "總金額";
            總金額.ReadOnly = true;
            // 
            // 報價單價
            // 
            報價單價.HeaderText = "報價單價";
            報價單價.Name = "報價單價";
            報價單價.ReadOnly = true;
            // 
            // 折數
            // 
            折數.HeaderText = "折數";
            折數.Name = "折數";
            折數.ReadOnly = true;
            // 
            // 註記
            // 
            註記.HeaderText = "註記";
            註記.Name = "註記";
            註記.ReadOnly = true;
            // 
            // 專案序號
            // 
            專案序號.HeaderText = "專案序號";
            專案序號.Name = "專案序號";
            專案序號.ReadOnly = true;
            // 
            // 機台類型
            // 
            機台類型.HeaderText = "機台類型";
            機台類型.Name = "機台類型";
            機台類型.ReadOnly = true;
            // 
            // 傭金率
            // 
            傭金率.HeaderText = "傭金率";
            傭金率.Name = "傭金率";
            傭金率.ReadOnly = true;
            // 
            // 報價單號
            // 
            報價單號.HeaderText = "報價單號";
            報價單號.Name = "報價單號";
            報價單號.ReadOnly = true;
            // 
            // btnAddLine
            // 
            btnAddLine.Location = new Point(16, 432);
            btnAddLine.Name = "btnAddLine";
            btnAddLine.Size = new Size(75, 32);
            btnAddLine.TabIndex = 270;
            btnAddLine.Text = "新增項目";
            btnAddLine.UseVisualStyleBackColor = true;
            btnAddLine.Click += btnAddLine_Click;
            // 
            // txtApprover
            // 
            txtApprover.Enabled = false;
            txtApprover.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            txtApprover.Location = new Point(68, 752);
            txtApprover.Name = "txtApprover";
            txtApprover.Size = new Size(120, 32);
            txtApprover.TabIndex = 272;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Microsoft JhengHei UI", 14.25F);
            label22.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            label22.Location = new Point(16, 756);
            label22.Name = "label22";
            label22.Size = new Size(48, 24);
            label22.TabIndex = 271;
            label22.Text = "核准";
            // 
            // txtApproveDate
            // 
            txtApproveDate.Enabled = false;
            txtApproveDate.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            txtApproveDate.Location = new Point(196, 752);
            txtApproveDate.Name = "txtApproveDate";
            txtApproveDate.Size = new Size(120, 32);
            txtApproveDate.TabIndex = 274;
            // 
            // txtModifyDate
            // 
            txtModifyDate.Enabled = false;
            txtModifyDate.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            txtModifyDate.Location = new Point(537, 752);
            txtModifyDate.Name = "txtModifyDate";
            txtModifyDate.Size = new Size(120, 32);
            txtModifyDate.TabIndex = 277;
            // 
            // txtModifier
            // 
            txtModifier.Enabled = false;
            txtModifier.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            txtModifier.Location = new Point(409, 752);
            txtModifier.Name = "txtModifier";
            txtModifier.Size = new Size(120, 32);
            txtModifier.TabIndex = 276;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Microsoft JhengHei UI", 14.25F);
            label23.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            label23.Location = new Point(357, 756);
            label23.Name = "label23";
            label23.Size = new Size(48, 24);
            label23.TabIndex = 275;
            label23.Text = "修改";
            // 
            // txtCreateDate
            // 
            txtCreateDate.Enabled = false;
            txtCreateDate.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            txtCreateDate.Location = new Point(859, 751);
            txtCreateDate.Name = "txtCreateDate";
            txtCreateDate.Size = new Size(120, 32);
            txtCreateDate.TabIndex = 280;
            // 
            // txtCreator
            // 
            txtCreator.Enabled = false;
            txtCreator.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            txtCreator.Location = new Point(731, 751);
            txtCreator.Name = "txtCreator";
            txtCreator.Size = new Size(120, 32);
            txtCreator.TabIndex = 279;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Microsoft JhengHei UI", 14.25F);
            label24.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            label24.Location = new Point(679, 755);
            label24.Name = "label24";
            label24.Size = new Size(48, 24);
            label24.TabIndex = 278;
            label24.Text = "建檔";
            // 
            // txtWorkOrder
            // 
            txtWorkOrder.Enabled = false;
            txtWorkOrder.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            txtWorkOrder.Location = new Point(1204, 752);
            txtWorkOrder.Name = "txtWorkOrder";
            txtWorkOrder.Size = new Size(208, 32);
            txtWorkOrder.TabIndex = 282;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Font = new Font("Microsoft JhengHei UI", 14.25F);
            label25.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            label25.Location = new Point(1072, 756);
            label25.Name = "label25";
            label25.Size = new Size(124, 24);
            label25.TabIndex = 281;
            label25.Text = "零件工令單號";
            // 
            // btnAddAR
            // 
            btnAddAR.Location = new Point(1340, 356);
            btnAddAR.Name = "btnAddAR";
            btnAddAR.Size = new Size(75, 32);
            btnAddAR.TabIndex = 283;
            btnAddAR.Text = "新增應收款";
            btnAddAR.UseVisualStyleBackColor = true;
            btnAddAR.Click += btnAddAR_Click;
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.ForestGreen;
            btnSubmit.ForeColor = SystemColors.ButtonHighlight;
            btnSubmit.Location = new Point(1340, 8);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(75, 24);
            btnSubmit.TabIndex = 284;
            btnSubmit.Text = "送出";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // btnPrint
            // 
            btnPrint.BackColor = Color.Gray;
            btnPrint.ForeColor = SystemColors.ButtonHighlight;
            btnPrint.Location = new Point(1260, 8);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(75, 24);
            btnPrint.TabIndex = 285;
            btnPrint.Text = "列印";
            btnPrint.UseVisualStyleBackColor = false;
            btnPrint.Click += btnPrint_Click;
            // 
            // btnCancelActivate
            // 
            btnCancelActivate.BackColor = Color.Gray;
            btnCancelActivate.ForeColor = SystemColors.ButtonHighlight;
            btnCancelActivate.Location = new Point(1176, 8);
            btnCancelActivate.Name = "btnCancelActivate";
            btnCancelActivate.Size = new Size(75, 24);
            btnCancelActivate.TabIndex = 286;
            btnCancelActivate.Text = "取消生效";
            btnCancelActivate.UseVisualStyleBackColor = false;
            btnCancelActivate.Click += btnCancelActivate_Click;
            // 
            // btnActivate
            // 
            btnActivate.BackColor = Color.Gray;
            btnActivate.ForeColor = SystemColors.ButtonHighlight;
            btnActivate.Location = new Point(1092, 8);
            btnActivate.Name = "btnActivate";
            btnActivate.Size = new Size(75, 24);
            btnActivate.TabIndex = 287;
            btnActivate.Text = "生效";
            btnActivate.UseVisualStyleBackColor = false;
            btnActivate.Click += btnActivate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Red;
            btnDelete.ForeColor = SystemColors.ButtonHighlight;
            btnDelete.Location = new Point(1008, 8);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 24);
            btnDelete.TabIndex = 288;
            btnDelete.Text = "刪除";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnTransShipping
            // 
            btnTransShipping.BackColor = Color.DarkRed;
            btnTransShipping.ForeColor = SystemColors.ButtonHighlight;
            btnTransShipping.Location = new Point(924, 8);
            btnTransShipping.Name = "btnTransShipping";
            btnTransShipping.Size = new Size(75, 24);
            btnTransShipping.TabIndex = 289;
            btnTransShipping.Text = "轉開出貨單";
            btnTransShipping.UseVisualStyleBackColor = false;
            btnTransShipping.Click += btnTransShipping_Click;
            // 
            // btnTransWorkOrder
            // 
            btnTransWorkOrder.BackColor = Color.Blue;
            btnTransWorkOrder.ForeColor = SystemColors.ButtonHighlight;
            btnTransWorkOrder.Location = new Point(840, 8);
            btnTransWorkOrder.Name = "btnTransWorkOrder";
            btnTransWorkOrder.Size = new Size(75, 24);
            btnTransWorkOrder.TabIndex = 290;
            btnTransWorkOrder.Text = "轉製令工件";
            btnTransWorkOrder.UseVisualStyleBackColor = false;
            // 
            // btnQuotationDistribution
            // 
            btnQuotationDistribution.BackColor = Color.Green;
            btnQuotationDistribution.ForeColor = SystemColors.ButtonHighlight;
            btnQuotationDistribution.Location = new Point(756, 8);
            btnQuotationDistribution.Name = "btnQuotationDistribution";
            btnQuotationDistribution.Size = new Size(75, 24);
            btnQuotationDistribution.TabIndex = 291;
            btnQuotationDistribution.Text = "報價單分配";
            btnQuotationDistribution.UseVisualStyleBackColor = false;
            btnQuotationDistribution.Click += btnQuotationDistribution_Click;
            // 
            // txtAmount
            // 
            txtAmount.Enabled = false;
            txtAmount.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            txtAmount.Location = new Point(1204, 712);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(208, 32);
            txtAmount.TabIndex = 293;
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Font = new Font("Microsoft JhengHei UI", 14.25F);
            label26.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            label26.Location = new Point(1072, 716);
            label26.Name = "label26";
            label26.Size = new Size(86, 24);
            label26.TabIndex = 292;
            label26.Text = "金額總計";
            // 
            // OrderMaintainControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(txtAmount);
            Controls.Add(label26);
            Controls.Add(btnQuotationDistribution);
            Controls.Add(btnTransWorkOrder);
            Controls.Add(btnTransShipping);
            Controls.Add(btnDelete);
            Controls.Add(btnActivate);
            Controls.Add(btnCancelActivate);
            Controls.Add(btnPrint);
            Controls.Add(btnSubmit);
            Controls.Add(btnAddAR);
            Controls.Add(txtWorkOrder);
            Controls.Add(label25);
            Controls.Add(txtCreateDate);
            Controls.Add(txtCreator);
            Controls.Add(label24);
            Controls.Add(txtModifyDate);
            Controls.Add(txtModifier);
            Controls.Add(label23);
            Controls.Add(txtApproveDate);
            Controls.Add(txtApprover);
            Controls.Add(label22);
            Controls.Add(btnAddLine);
            Controls.Add(dgvDetail);
            Controls.Add(txtComment);
            Controls.Add(label21);
            Controls.Add(txtCountry);
            Controls.Add(label20);
            Controls.Add(btnCheck);
            Controls.Add(bankCodeSelect1);
            Controls.Add(label19);
            Controls.Add(label18);
            Controls.Add(payMethod);
            Controls.Add(label17);
            Controls.Add(ETDRequest);
            Controls.Add(txtOrderSum);
            Controls.Add(label16);
            Controls.Add(label15);
            Controls.Add(shipMethod);
            Controls.Add(txtDestPort);
            Controls.Add(label14);
            Controls.Add(label12);
            Controls.Add(priceCondControl1);
            Controls.Add(cboTaxRate);
            Controls.Add(cboTaxType);
            Controls.Add(label11);
            Controls.Add(txtAddress);
            Controls.Add(label10);
            Controls.Add(cboCurrency);
            Controls.Add(label9);
            Controls.Add(cboSales);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(txtCompany);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(dtETD);
            Controls.Add(lblCustAlias);
            Controls.Add(label4);
            Controls.Add(dataGridView1);
            Controls.Add(cboCustId);
            Controls.Add(label13);
            Controls.Add(txtOrderNo);
            Controls.Add(label3);
            Controls.Add(btnModify);
            Controls.Add(label2);
            Controls.Add(dtORDERDATE);
            Controls.Add(button1);
            Controls.Add(lblMode);
            Controls.Add(label1);
            Controls.Add(chkClosed);
            Name = "OrderMaintainControl";
            Size = new Size(1446, 788);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDetail).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private CommonCheckBox chkClosed;
        private Label lblMode;
        private Label label1;
        private Button button1;
        private Button btnModify;
        private Label label2;
        private DigiERP.Common.CommonDateTimePicker dtORDERDATE;
        private DigiERP.Common.CommonTextBox txtOrderNo;
        private Label label3;
        private Label label13;
        private DigiERP.Common.CommonComboBox cboCustId;
        private DataGridView dataGridView1;
        private Label label4;
        private Label lblCustAlias;
        private Label label6;
        private DigiERP.Common.CommonDateTimePicker dtETD;
        private DigiERP.Common.CommonTextBox txtCompany;
        private Label label5;
        private Label label7;
        private CommonComboBox cboSales;
        private Label label8;
        private CommonComboBox cboCurrency;
        private Label label9;
        private CommonTextBox txtAddress;
        private Label label10;
        private CommonComboBox cboTaxType;
        private Label label11;
        private CommonComboBox cboTaxRate;
        private Common.PriceCondControl priceCondControl1;
        private Label label12;
        private Label label14;
        private CommonTextBox txtDestPort;
        private Label label15;
        private Common.PriceCondControl shipMethod;
        private CommonTextBox txtOrderSum;
        private Label label16;
        private Label label17;
        private Common.PriceCondControl ETDRequest;
        private Label label18;
        private Common.PriceCondControl payMethod;
        private Label label19;
        private Common.BankCodeSelect bankCodeSelect1;
        private Button btnCheck;
        private CommonTextBox txtCountry;
        private Label label20;
        private CommonTextBox txtComment;
        private Label label21;
        private DataGridView dgvDetail;
        private Button btnAddLine;
        private CommonTextBox txtApprover;
        private Label label22;
        private CommonTextBox txtApproveDate;
        private CommonTextBox txtModifyDate;
        private CommonTextBox txtModifier;
        private Label label23;
        private CommonTextBox txtCreateDate;
        private CommonTextBox txtCreator;
        private Label label24;
        private CommonTextBox txtWorkOrder;
        private Label label25;
        private Button btnAddAR;
        private Button btnSubmit;
        private Button btnPrint;
        private Button btnCancelActivate;
        private Button btnActivate;
        private Button btnDelete;
        private Button btnTransShipping;
        private Button btnTransWorkOrder;
        private Button btnQuotationDistribution;
        private DataGridViewTextBoxColumn 識別;
        private DataGridViewTextBoxColumn 款項期別;
        private DataGridViewTextBoxColumn 成數;
        private DataGridViewTextBoxColumn 金額;
        private DataGridViewTextBoxColumn 立帳單號;
        private DataGridViewButtonColumn 轉立帳單;
        private CommonTextBox txtAmount;
        private Label label26;
        private DataGridViewTextBoxColumn 識別碼;
        private DataGridViewTextBoxColumn 品項編號;
        private DataGridViewTextBoxColumn 品名;
        private DataGridViewTextBoxColumn 銷售單位;
        private DataGridViewTextBoxColumn 數量;
        private DataGridViewTextBoxColumn 訂單單價;
        private DataGridViewTextBoxColumn 總金額;
        private DataGridViewTextBoxColumn 報價單價;
        private DataGridViewTextBoxColumn 折數;
        private DataGridViewTextBoxColumn 註記;
        private DataGridViewTextBoxColumn 專案序號;
        private DataGridViewTextBoxColumn 機台類型;
        private DataGridViewTextBoxColumn 傭金率;
        private DataGridViewTextBoxColumn 報價單號;
    }
}
