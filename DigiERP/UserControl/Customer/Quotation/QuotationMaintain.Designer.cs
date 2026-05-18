using DigiERP.UserControl.Common;
using System.Windows.Forms;

namespace DigiERP.UserControl.Customer.Quotation
{
    partial class QuotationMaintain
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
            priceCond = new PriceCondControl();
            lblMode = new Label();
            label1 = new Label();
            button1 = new Button();
            dtQUODATE = new DigiERP.Common.CommonDateTimePicker();
            label2 = new Label();
            label3 = new Label();
            txtQUONO = new DigiERP.Common.CommonTextBox();
            label4 = new Label();
            dtAvailableDate = new DigiERP.Common.CommonDateTimePicker();
            label5 = new Label();
            txtRFQNO = new DigiERP.Common.CommonTextBox();
            label6 = new Label();
            salesSelect1 = new SalesSelect();
            txtCustNo = new DigiERP.Common.CommonTextBox();
            label7 = new Label();
            txtCustAlias = new DigiERP.Common.CommonTextBox();
            label8 = new Label();
            label9 = new Label();
            txtCompany = new DigiERP.Common.CommonTextBox();
            label10 = new Label();
            currencySelect1 = new Common.Customer.CurrencySelect();
            label11 = new Label();
            label12 = new Label();
            exRate = new DigiERP.Common.CommonNumericUpDown();
            cboContactList = new DigiERP.Common.CommonComboBox();
            label13 = new Label();
            cboMType = new DigiERP.Common.CommonComboBox();
            txtAddress = new DigiERP.Common.CommonTextBox();
            label14 = new Label();
            label15 = new Label();
            cboTaxRate = new DigiERP.Common.CommonComboBox();
            label16 = new Label();
            label17 = new Label();
            ETDRequest = new PriceCondControl();
            label18 = new Label();
            shipMethod = new PriceCondControl();
            label19 = new Label();
            payMethod = new PriceCondControl();
            label20 = new Label();
            txtXomment = new DigiERP.Common.CommonTextBox();
            dataGridView1 = new DataGridView();
            產品編號 = new DataGridViewTextBoxColumn();
            品名規格 = new DataGridViewTextBoxColumn();
            數量 = new DataGridViewTextBoxColumn();
            單位 = new DataGridViewTextBoxColumn();
            單價 = new DataGridViewTextBoxColumn();
            金額 = new DataGridViewTextBoxColumn();
            描述 = new DataGridViewTextBoxColumn();
            btnAddDetail = new Button();
            label21 = new Label();
            lblSummary = new Label();
            label22 = new Label();
            label23 = new Label();
            label24 = new Label();
            label25 = new Label();
            label26 = new Label();
            label27 = new Label();
            lblCreator = new Label();
            lblCreateDate = new Label();
            lblModifyDate = new Label();
            lblModifier = new Label();
            lblApprover = new Label();
            lblApproveDate = new Label();
            ((System.ComponentModel.ISupportInitialize)exRate).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // priceCond
            // 
            priceCond.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            priceCond.Location = new Point(88, 189);
            priceCond.Name = "priceCond";
            priceCond.Size = new Size(448, 91);
            priceCond.TabIndex = 190;
            priceCond.txType = null;
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
            lblMode.TabIndex = 156;
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
            label1.TabIndex = 157;
            label1.Text = "報價單";
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(1512, 8);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(20, 22);
            button1.TabIndex = 158;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dtQUODATE
            // 
            dtQUODATE.Enabled = false;
            dtQUODATE.Font = new Font("Microsoft JhengHei UI", 14.25F);
            dtQUODATE.Location = new Point(96, 44);
            dtQUODATE.Name = "dtQUODATE";
            dtQUODATE.Size = new Size(184, 32);
            dtQUODATE.TabIndex = 159;
            dtQUODATE.Value = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft JhengHei UI", 14.25F);
            label2.Location = new Point(0, 48);
            label2.Name = "label2";
            label2.Size = new Size(48, 24);
            label2.TabIndex = 160;
            label2.Text = "日期";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft JhengHei UI", 14.25F);
            label3.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            label3.Location = new Point(304, 48);
            label3.Name = "label3";
            label3.Size = new Size(86, 24);
            label3.TabIndex = 161;
            label3.Text = "報價單號";
            // 
            // txtQUONO
            // 
            txtQUONO.Enabled = false;
            txtQUONO.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            txtQUONO.Location = new Point(400, 46);
            txtQUONO.Name = "txtQUONO";
            txtQUONO.Size = new Size(144, 32);
            txtQUONO.TabIndex = 162;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft JhengHei UI", 14.25F);
            label4.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            label4.Location = new Point(568, 48);
            label4.Name = "label4";
            label4.Size = new Size(124, 24);
            label4.TabIndex = 163;
            label4.Text = "報價有效日期";
            // 
            // dtAvailableDate
            // 
            dtAvailableDate.Font = new Font("Microsoft JhengHei UI", 14.25F);
            dtAvailableDate.Location = new Point(710, 46);
            dtAvailableDate.Name = "dtAvailableDate";
            dtAvailableDate.Size = new Size(184, 32);
            dtAvailableDate.TabIndex = 164;
            dtAvailableDate.Value = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft JhengHei UI", 14.25F);
            label5.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            label5.Location = new Point(911, 48);
            label5.Name = "label5";
            label5.Size = new Size(86, 24);
            label5.TabIndex = 165;
            label5.Text = "詢問單號";
            // 
            // txtRFQNO
            // 
            txtRFQNO.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            txtRFQNO.Location = new Point(1008, 46);
            txtRFQNO.Name = "txtRFQNO";
            txtRFQNO.Size = new Size(144, 32);
            txtRFQNO.TabIndex = 166;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft JhengHei UI", 14.25F);
            label6.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            label6.Location = new Point(1168, 48);
            label6.Name = "label6";
            label6.Size = new Size(86, 24);
            label6.TabIndex = 167;
            label6.Text = "業務人員";
            // 
            // salesSelect1
            // 
            salesSelect1.Location = new Point(1264, 40);
            salesSelect1.Name = "salesSelect1";
            salesSelect1.Size = new Size(256, 50);
            salesSelect1.TabIndex = 168;
            // 
            // txtCustNo
            // 
            txtCustNo.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            txtCustNo.Location = new Point(97, 94);
            txtCustNo.Name = "txtCustNo";
            txtCustNo.Size = new Size(183, 32);
            txtCustNo.TabIndex = 170;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft JhengHei UI", 14.25F);
            label7.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            label7.Location = new Point(0, 96);
            label7.Name = "label7";
            label7.Size = new Size(86, 24);
            label7.TabIndex = 169;
            label7.Text = "客戶編號";
            // 
            // txtCustAlias
            // 
            txtCustAlias.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            txtCustAlias.Location = new Point(401, 94);
            txtCustAlias.Name = "txtCustAlias";
            txtCustAlias.Size = new Size(143, 32);
            txtCustAlias.TabIndex = 172;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft JhengHei UI", 14.25F);
            label8.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            label8.Location = new Point(304, 96);
            label8.Name = "label8";
            label8.Size = new Size(86, 24);
            label8.TabIndex = 171;
            label8.Text = "客戶簡稱";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft JhengHei UI", 14.25F);
            label9.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            label9.Location = new Point(568, 96);
            label9.Name = "label9";
            label9.Size = new Size(86, 24);
            label9.TabIndex = 173;
            label9.Text = "客戶全名";
            // 
            // txtCompany
            // 
            txtCompany.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            txtCompany.Location = new Point(664, 94);
            txtCompany.Name = "txtCompany";
            txtCompany.Size = new Size(488, 32);
            txtCompany.TabIndex = 174;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft JhengHei UI", 14.25F);
            label10.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            label10.Location = new Point(1168, 96);
            label10.Name = "label10";
            label10.Size = new Size(48, 24);
            label10.TabIndex = 175;
            label10.Text = "幣別";
            // 
            // currencySelect1
            // 
            currencySelect1.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            currencySelect1.FormattingEnabled = true;
            currencySelect1.Location = new Point(1272, 94);
            currencySelect1.Name = "currencySelect1";
            currencySelect1.Size = new Size(64, 32);
            currencySelect1.TabIndex = 176;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft JhengHei UI", 14.25F);
            label11.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            label11.Location = new Point(1352, 98);
            label11.Name = "label11";
            label11.Size = new Size(48, 24);
            label11.TabIndex = 177;
            label11.Text = "匯率";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft JhengHei UI", 14.25F);
            label12.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            label12.Location = new Point(0, 152);
            label12.Name = "label12";
            label12.Size = new Size(67, 24);
            label12.TabIndex = 179;
            label12.Text = "聯絡人";
            // 
            // exRate
            // 
            exRate.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            exRate.Location = new Point(1408, 94);
            exRate.Name = "exRate";
            exRate.ReadOnly = true;
            exRate.Size = new Size(80, 32);
            exRate.TabIndex = 182;
            // 
            // cboContactList
            // 
            cboContactList.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            cboContactList.FormattingEnabled = true;
            cboContactList.Location = new Point(96, 149);
            cboContactList.Name = "cboContactList";
            cboContactList.Size = new Size(184, 32);
            cboContactList.TabIndex = 183;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Microsoft JhengHei UI", 14.25F);
            label13.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            label13.Location = new Point(304, 152);
            label13.Name = "label13";
            label13.Size = new Size(86, 24);
            label13.TabIndex = 184;
            label13.Text = "機台類別";
            // 
            // cboMType
            // 
            cboMType.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            cboMType.FormattingEnabled = true;
            cboMType.Location = new Point(402, 150);
            cboMType.Name = "cboMType";
            cboMType.Size = new Size(142, 32);
            cboMType.TabIndex = 185;
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            txtAddress.Location = new Point(664, 150);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(488, 32);
            txtAddress.TabIndex = 187;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Microsoft JhengHei UI", 14.25F);
            label14.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            label14.Location = new Point(568, 152);
            label14.Name = "label14";
            label14.Size = new Size(86, 24);
            label14.TabIndex = 186;
            label14.Text = "交貨地址";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Microsoft JhengHei UI", 14.25F);
            label15.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            label15.Location = new Point(1168, 152);
            label15.Name = "label15";
            label15.Size = new Size(48, 24);
            label15.TabIndex = 188;
            label15.Text = "稅率";
            // 
            // cboTaxRate
            // 
            cboTaxRate.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            cboTaxRate.FormattingEnabled = true;
            cboTaxRate.Items.AddRange(new object[] { "", "0%", "5%" });
            cboTaxRate.Location = new Point(1272, 149);
            cboTaxRate.Name = "cboTaxRate";
            cboTaxRate.Size = new Size(64, 32);
            cboTaxRate.TabIndex = 189;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Microsoft JhengHei UI", 14.25F);
            label16.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            label16.Location = new Point(0, 200);
            label16.Name = "label16";
            label16.Size = new Size(86, 24);
            label16.TabIndex = 190;
            label16.Text = "價格條件";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Microsoft JhengHei UI", 14.25F);
            label17.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            label17.Location = new Point(336, 200);
            label17.Name = "label17";
            label17.Size = new Size(86, 24);
            label17.TabIndex = 192;
            label17.Text = "交期要求";
            // 
            // ETDRequest
            // 
            ETDRequest.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            ETDRequest.Location = new Point(424, 189);
            ETDRequest.Name = "ETDRequest";
            ETDRequest.Size = new Size(448, 91);
            ETDRequest.TabIndex = 193;
            ETDRequest.txType = null;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Microsoft JhengHei UI", 14.25F);
            label18.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            label18.Location = new Point(672, 200);
            label18.Name = "label18";
            label18.Size = new Size(86, 24);
            label18.TabIndex = 194;
            label18.Text = "交貨方式";
            // 
            // shipMethod
            // 
            shipMethod.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            shipMethod.Location = new Point(760, 192);
            shipMethod.Name = "shipMethod";
            shipMethod.Size = new Size(448, 91);
            shipMethod.TabIndex = 196;
            shipMethod.txType = null;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Microsoft JhengHei UI", 14.25F);
            label19.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            label19.Location = new Point(984, 200);
            label19.Name = "label19";
            label19.Size = new Size(86, 24);
            label19.TabIndex = 196;
            label19.Text = "付款方式";
            // 
            // payMethod
            // 
            payMethod.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            payMethod.Location = new Point(1072, 189);
            payMethod.Name = "payMethod";
            payMethod.Size = new Size(448, 91);
            payMethod.TabIndex = 197;
            payMethod.txType = null;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Microsoft JhengHei UI", 14.25F);
            label20.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            label20.Location = new Point(0, 288);
            label20.Name = "label20";
            label20.Size = new Size(48, 24);
            label20.TabIndex = 198;
            label20.Text = "備註";
            // 
            // txtXomment
            // 
            txtXomment.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            txtXomment.Location = new Point(96, 288);
            txtXomment.Multiline = true;
            txtXomment.Name = "txtXomment";
            txtXomment.Size = new Size(1312, 104);
            txtXomment.TabIndex = 199;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { 產品編號, 品名規格, 數量, 單位, 單價, 金額, 描述 });
            dataGridView1.Location = new Point(96, 448);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1416, 288);
            dataGridView1.TabIndex = 200;
            // 
            // 產品編號
            // 
            產品編號.HeaderText = "產品編號";
            產品編號.Name = "產品編號";
            產品編號.ReadOnly = true;
            // 
            // 品名規格
            // 
            品名規格.HeaderText = "品名規格";
            品名規格.Name = "品名規格";
            品名規格.ReadOnly = true;
            // 
            // 數量
            // 
            數量.HeaderText = "數量";
            數量.Name = "數量";
            數量.ReadOnly = true;
            // 
            // 單位
            // 
            單位.HeaderText = "單位";
            單位.Name = "單位";
            單位.ReadOnly = true;
            // 
            // 單價
            // 
            單價.HeaderText = "單價";
            單價.Name = "單價";
            單價.ReadOnly = true;
            // 
            // 金額
            // 
            金額.HeaderText = "金額";
            金額.Name = "金額";
            金額.ReadOnly = true;
            // 
            // 描述
            // 
            描述.HeaderText = "描述";
            描述.Name = "描述";
            描述.ReadOnly = true;
            // 
            // btnAddDetail
            // 
            btnAddDetail.Location = new Point(1432, 416);
            btnAddDetail.Name = "btnAddDetail";
            btnAddDetail.Size = new Size(75, 23);
            btnAddDetail.TabIndex = 201;
            btnAddDetail.Text = "新增細項";
            btnAddDetail.UseVisualStyleBackColor = true;
            btnAddDetail.Click += btnAddDetail_Click;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label21.Location = new Point(1248, 744);
            label21.Name = "label21";
            label21.Size = new Size(86, 24);
            label21.TabIndex = 202;
            label21.Text = "金額總計";
            // 
            // lblSummary
            // 
            lblSummary.AutoSize = true;
            lblSummary.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            lblSummary.Location = new Point(1400, 744);
            lblSummary.Name = "lblSummary";
            lblSummary.Size = new Size(118, 24);
            lblSummary.TabIndex = 203;
            lblSummary.Text = "lblSummary";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label22.Location = new Point(96, 768);
            label22.Name = "label22";
            label22.Size = new Size(48, 24);
            label22.TabIndex = 204;
            label22.Text = "建檔";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label23.Location = new Point(264, 768);
            label23.Name = "label23";
            label23.Size = new Size(67, 24);
            label23.TabIndex = 205;
            label23.Text = "建檔日";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label24.Location = new Point(624, 768);
            label24.Name = "label24";
            label24.Size = new Size(67, 24);
            label24.TabIndex = 207;
            label24.Text = "修改日";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label25.Location = new Point(488, 768);
            label25.Name = "label25";
            label25.Size = new Size(48, 24);
            label25.TabIndex = 206;
            label25.Text = "修改";
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label26.Location = new Point(1016, 768);
            label26.Name = "label26";
            label26.Size = new Size(67, 24);
            label26.TabIndex = 209;
            label26.Text = "核准日";
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label27.Location = new Point(832, 768);
            label27.Name = "label27";
            label27.Size = new Size(48, 24);
            label27.TabIndex = 208;
            label27.Text = "核准";
            // 
            // lblCreator
            // 
            lblCreator.AutoSize = true;
            lblCreator.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            lblCreator.Location = new Point(152, 768);
            lblCreator.Name = "lblCreator";
            lblCreator.Size = new Size(99, 24);
            lblCreator.TabIndex = 210;
            lblCreator.Text = "lblCreator";
            // 
            // lblCreateDate
            // 
            lblCreateDate.AutoSize = true;
            lblCreateDate.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            lblCreateDate.Location = new Point(344, 768);
            lblCreateDate.Name = "lblCreateDate";
            lblCreateDate.Size = new Size(133, 24);
            lblCreateDate.TabIndex = 211;
            lblCreateDate.Text = "lblCreateDate";
            // 
            // lblModifyDate
            // 
            lblModifyDate.AutoSize = true;
            lblModifyDate.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            lblModifyDate.Location = new Point(688, 768);
            lblModifyDate.Name = "lblModifyDate";
            lblModifyDate.Size = new Size(137, 24);
            lblModifyDate.TabIndex = 212;
            lblModifyDate.Text = "lblModifyDate";
            // 
            // lblModifier
            // 
            lblModifier.AutoSize = true;
            lblModifier.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            lblModifier.Location = new Point(536, 768);
            lblModifier.Name = "lblModifier";
            lblModifier.Size = new Size(108, 24);
            lblModifier.TabIndex = 213;
            lblModifier.Text = "lblModifier";
            // 
            // lblApprover
            // 
            lblApprover.AutoSize = true;
            lblApprover.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            lblApprover.Location = new Point(896, 768);
            lblApprover.Name = "lblApprover";
            lblApprover.Size = new Size(116, 24);
            lblApprover.TabIndex = 215;
            lblApprover.Text = "lblApprover";
            // 
            // lblApproveDate
            // 
            lblApproveDate.AutoSize = true;
            lblApproveDate.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            lblApproveDate.Location = new Point(1088, 768);
            lblApproveDate.Name = "lblApproveDate";
            lblApproveDate.Size = new Size(151, 24);
            lblApproveDate.TabIndex = 214;
            lblApproveDate.Text = "lblApproveDate";
            // 
            // QuotationMaintain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleTurquoise;
            Controls.Add(lblApprover);
            Controls.Add(lblApproveDate);
            Controls.Add(lblModifier);
            Controls.Add(lblModifyDate);
            Controls.Add(lblCreateDate);
            Controls.Add(lblCreator);
            Controls.Add(label26);
            Controls.Add(label27);
            Controls.Add(label24);
            Controls.Add(label25);
            Controls.Add(label23);
            Controls.Add(label22);
            Controls.Add(lblSummary);
            Controls.Add(label21);
            Controls.Add(btnAddDetail);
            Controls.Add(dataGridView1);
            Controls.Add(txtXomment);
            Controls.Add(label20);
            Controls.Add(label19);
            Controls.Add(payMethod);
            Controls.Add(label18);
            Controls.Add(shipMethod);
            Controls.Add(label17);
            Controls.Add(ETDRequest);
            Controls.Add(label16);
            Controls.Add(cboTaxRate);
            Controls.Add(label15);
            Controls.Add(txtAddress);
            Controls.Add(label14);
            Controls.Add(cboMType);
            Controls.Add(label13);
            Controls.Add(cboContactList);
            Controls.Add(exRate);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(currencySelect1);
            Controls.Add(label10);
            Controls.Add(txtCompany);
            Controls.Add(label9);
            Controls.Add(txtCustAlias);
            Controls.Add(label8);
            Controls.Add(txtCustNo);
            Controls.Add(label7);
            Controls.Add(salesSelect1);
            Controls.Add(label6);
            Controls.Add(txtRFQNO);
            Controls.Add(label5);
            Controls.Add(dtAvailableDate);
            Controls.Add(label4);
            Controls.Add(txtQUONO);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dtQUODATE);
            Controls.Add(button1);
            Controls.Add(lblMode);
            Controls.Add(label1);
            Controls.Add(priceCond);
            Name = "QuotationMaintain";
            Size = new Size(1534, 829);
            ((System.ComponentModel.ISupportInitialize)exRate).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PriceCondControl priceCond;
        private Label lblMode;
        private Label label1;
        private Button button1;
        private DigiERP.Common.CommonDateTimePicker dtQUODATE;
        private Label label2;
        private Label label3;
        private DigiERP.Common.CommonTextBox txtQUONO;
        private Label label4;
        private DigiERP.Common.CommonDateTimePicker dtAvailableDate;
        private Label label5;
        private DigiERP.Common.CommonTextBox txtRFQNO;
        private Label label6;
        private Common.SalesSelect salesSelect1;
        private DigiERP.Common.CommonTextBox txtCustNo;
        private Label label7;
        private DigiERP.Common.CommonTextBox txtCustAlias;
        private Label label8;
        private Label label9;
        private DigiERP.Common.CommonTextBox txtCompany;
        private Label label10;
        private Common.Customer.CurrencySelect currencySelect1;
        private Label label11;
        private Label label12;
        private DigiERP.Common.CommonNumericUpDown exRate;
        private DigiERP.Common.CommonComboBox cboContactList;
        private Label label13;
        private DigiERP.Common.CommonComboBox cboMType;
        private DigiERP.Common.CommonTextBox txtAddress;
        private Label label14;
        private Label label15;
        private DigiERP.Common.CommonComboBox cboTaxRate;
        private Label label16;
        private Label label17;
        private PriceCondControl ETDRequest;
        private Label label18;
        private PriceCondControl shipMethod;
        private Label label19;
        private PriceCondControl payMethod;
        private Label label20;
        private DigiERP.Common.CommonTextBox commonTextBox1;
        private DigiERP.Common.CommonTextBox txtXomment;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn 產品編號;
        private DataGridViewTextBoxColumn 品名規格;
        private DataGridViewTextBoxColumn 數量;
        private DataGridViewTextBoxColumn 單位;
        private DataGridViewTextBoxColumn 單價;
        private DataGridViewTextBoxColumn 金額;
        private DataGridViewTextBoxColumn 描述;
        private Button btnAddDetail;
        private Label label21;
        private Label lblSummary;
        private Label label22;
        private Label label23;
        private Label label24;
        private Label label25;
        private Label label26;
        private Label label27;
        private Label lblCreator;
        private Label lblCreateDate;
        private Label lblModifyDate;
        private Label lblModifier;
        private Label lblApprover;
        private Label lblApproveDate;
    }
}
