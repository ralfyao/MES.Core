using DigiERP.Common;

namespace DigiERP.UserControl
{
    partial class CustomerMaintainControl : CommonUserControl
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
            label1 = new Label();
            lblMode = new Label();
            button1 = new Button();
            label20 = new Label();
            txtMachineIssue = new CommonTextBox();
            label19 = new Label();
            btnIndustryCodeManage = new Button();
            industryCodeSelect1 = new Common.IndustryCodeSelect();
            txtColumn1 = new CommonTextBox();
            label18 = new Label();
            cboIndustrry = new CommonComboBox();
            label17 = new Label();
            cboSource = new CommonComboBox();
            cboMa = new CommonComboBox();
            label15 = new Label();
            txtEmail = new CommonTextBox();
            label16 = new Label();
            txtFax = new CommonTextBox();
            label13 = new Label();
            txtWebsite = new CommonTextBox();
            label14 = new Label();
            txtZipcode = new CommonTextBox();
            label11 = new Label();
            txtTel = new CommonTextBox();
            label12 = new Label();
            txtDAddress = new CommonTextBox();
            label10 = new Label();
            txtAddress = new CommonTextBox();
            label9 = new Label();
            txtPosition = new CommonTextBox();
            label8 = new Label();
            txtContactPersion = new CommonTextBox();
            label7 = new Label();
            label6 = new Label();
            coutrySelect1 = new Common.CoutrySelect();
            label5 = new Label();
            btnGenCustNumber = new Button();
            txtCustNumber = new CommonTextBox();
            label4 = new Label();
            btnCompanyChange = new Button();
            txtCustAlias = new CommonTextBox();
            label3 = new Label();
            txtCustomerCompany = new CommonTextBox();
            label2 = new Label();
            label21 = new Label();
            bankCodeSelect1 = new Common.BankCodeSelect();
            btnInactivate = new Button();
            btnActivate = new Button();
            label22 = new Label();
            dtEnableDate = new DateTimePicker();
            label23 = new Label();
            dtDisableDate = new DateTimePicker();
            label24 = new Label();
            txtMemo = new CommonTextBox();
            label25 = new Label();
            label26 = new Label();
            lblModifyUser = new Label();
            lblModifyDate = new Label();
            lblCreator = new Label();
            lblCreateDate = new Label();
            dgvContactList = new DataGridView();
            Contact = new DataGridViewTextBoxColumn();
            Position = new DataGridViewTextBoxColumn();
            email = new DataGridViewTextBoxColumn();
            dgvCustIntView = new DataGridView();
            洽談日期 = new DataGridViewTextBoxColumn();
            工號 = new DataGridViewTextBoxColumn();
            業務人員 = new DataGridViewTextBoxColumn();
            轉詢問函 = new DataGridViewTextBoxColumn();
            內容簡述 = new DataGridViewTextBoxColumn();
            btnSubmit = new Button();
            txtIdentity = new CommonTextBox();
            btnDelete = new Button();
            btnShippingRecord = new Button();
            btnRepairHistory = new Button();
            btnQuotationHistory = new Button();
            btnInquiryHistory = new Button();
            btnRecordWrite = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvContactList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCustIntView).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Lime;
            label1.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label1.Location = new Point(49, 91);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(48, 24);
            label1.TabIndex = 0;
            label1.Text = "客戶";
            // 
            // lblMode
            // 
            lblMode.AutoSize = true;
            lblMode.BackColor = Color.Lime;
            lblMode.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            lblMode.Location = new Point(8, 91);
            lblMode.Margin = new Padding(2, 0, 2, 0);
            lblMode.Name = "lblMode";
            lblMode.Size = new Size(85, 24);
            lblMode.TabIndex = 1;
            lblMode.Text = "lblMode";
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(1048, 91);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(20, 22);
            button1.TabIndex = 2;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label20.Location = new Point(11, 529);
            label20.Margin = new Padding(2, 0, 2, 0);
            label20.Name = "label20";
            label20.Size = new Size(86, 24);
            label20.TabIndex = 122;
            label20.Text = "機台類別";
            // 
            // txtMachineIssue
            // 
            txtMachineIssue.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            txtMachineIssue.Location = new Point(92, 529);
            txtMachineIssue.Margin = new Padding(2);
            txtMachineIssue.Name = "txtMachineIssue";
            txtMachineIssue.Size = new Size(455, 31);
            txtMachineIssue.TabIndex = 19;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label19.Location = new Point(11, 493);
            label19.Margin = new Padding(2, 0, 2, 0);
            label19.Name = "label19";
            label19.Size = new Size(86, 24);
            label19.TabIndex = 120;
            label19.Text = "所屬業別";
            // 
            // btnIndustryCodeManage
            // 
            btnIndustryCodeManage.BackColor = Color.Brown;
            btnIndustryCodeManage.ForeColor = SystemColors.ButtonFace;
            btnIndustryCodeManage.Location = new Point(459, 493);
            btnIndustryCodeManage.Margin = new Padding(2);
            btnIndustryCodeManage.Name = "btnIndustryCodeManage";
            btnIndustryCodeManage.Size = new Size(87, 31);
            btnIndustryCodeManage.TabIndex = 119;
            btnIndustryCodeManage.Text = "業別管理";
            btnIndustryCodeManage.UseVisualStyleBackColor = false;
            // 
            // industryCodeSelect1
            // 
            industryCodeSelect1.Location = new Point(91, 486);
            industryCodeSelect1.Margin = new Padding(1);
            industryCodeSelect1.Name = "industryCodeSelect1";
            industryCodeSelect1.Size = new Size(367, 37);
            industryCodeSelect1.TabIndex = 18;
            // 
            // txtColumn1
            // 
            txtColumn1.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            txtColumn1.Location = new Point(378, 456);
            txtColumn1.Margin = new Padding(2);
            txtColumn1.Name = "txtColumn1";
            txtColumn1.Size = new Size(175, 31);
            txtColumn1.TabIndex = 17;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label18.Location = new Point(296, 456);
            label18.Margin = new Padding(2, 0, 2, 0);
            label18.Name = "label18";
            label18.Size = new Size(86, 24);
            label18.TabIndex = 116;
            label18.Text = "終端使用";
            // 
            // cboIndustrry
            // 
            cboIndustrry.DropDownStyle = ComboBoxStyle.DropDownList;
            cboIndustrry.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            cboIndustrry.FormattingEnabled = true;
            cboIndustrry.Items.AddRange(new object[] { "Manufacturer", "Trader", "Agent" });
            cboIndustrry.Location = new Point(92, 456);
            cboIndustrry.Margin = new Padding(2);
            cboIndustrry.Name = "cboIndustrry";
            cboIndustrry.Size = new Size(200, 32);
            cboIndustrry.TabIndex = 16;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label17.Location = new Point(11, 456);
            label17.Margin = new Padding(2, 0, 2, 0);
            label17.Name = "label17";
            label17.Size = new Size(86, 24);
            label17.TabIndex = 114;
            label17.Text = "配合代理";
            // 
            // cboSource
            // 
            cboSource.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSource.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            cboSource.FormattingEnabled = true;
            cboSource.Items.AddRange(new object[] { "", "社群軟體", "非代理/朋友", "搜尋引擎", "公司官網詢問函", "代理轉介", "展覽認識", "自主開發" });
            cboSource.Location = new Point(378, 195);
            cboSource.Margin = new Padding(2);
            cboSource.Name = "cboSource";
            cboSource.Size = new Size(169, 32);
            cboSource.TabIndex = 5;
            // 
            // cboMa
            // 
            cboMa.DropDownStyle = ComboBoxStyle.DropDownList;
            cboMa.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            cboMa.FormattingEnabled = true;
            cboMa.Items.AddRange(new object[] { "", "Manufacturer", "Trader", "Agent" });
            cboMa.Location = new Point(378, 420);
            cboMa.Margin = new Padding(2);
            cboMa.Name = "cboMa";
            cboMa.Size = new Size(169, 32);
            cboMa.TabIndex = 15;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label15.Location = new Point(288, 424);
            label15.Margin = new Padding(2, 0, 2, 0);
            label15.Name = "label15";
            label15.Size = new Size(86, 24);
            label15.TabIndex = 111;
            label15.Text = "型態分類";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            txtEmail.Location = new Point(92, 419);
            txtEmail.Margin = new Padding(2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(200, 31);
            txtEmail.TabIndex = 14;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label16.Location = new Point(47, 424);
            label16.Margin = new Padding(2, 0, 2, 0);
            label16.Name = "label16";
            label16.Size = new Size(48, 24);
            label16.TabIndex = 109;
            label16.Text = "電郵";
            // 
            // txtFax
            // 
            txtFax.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            txtFax.Location = new Point(378, 382);
            txtFax.Margin = new Padding(2);
            txtFax.Name = "txtFax";
            txtFax.Size = new Size(175, 31);
            txtFax.TabIndex = 13;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label13.Location = new Point(328, 387);
            label13.Margin = new Padding(2, 0, 2, 0);
            label13.Name = "label13";
            label13.Size = new Size(48, 24);
            label13.TabIndex = 107;
            label13.Text = "傳真";
            // 
            // txtWebsite
            // 
            txtWebsite.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            txtWebsite.Location = new Point(92, 382);
            txtWebsite.Margin = new Padding(2);
            txtWebsite.Name = "txtWebsite";
            txtWebsite.Size = new Size(200, 31);
            txtWebsite.TabIndex = 12;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label14.Location = new Point(47, 388);
            label14.Margin = new Padding(2, 0, 2, 0);
            label14.Name = "label14";
            label14.Size = new Size(48, 24);
            label14.TabIndex = 105;
            label14.Text = "網址";
            // 
            // txtZipcode
            // 
            txtZipcode.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            txtZipcode.Location = new Point(378, 345);
            txtZipcode.Margin = new Padding(2);
            txtZipcode.Name = "txtZipcode";
            txtZipcode.Size = new Size(175, 31);
            txtZipcode.TabIndex = 11;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label11.Location = new Point(328, 347);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(48, 24);
            label11.TabIndex = 103;
            label11.Text = "手機";
            // 
            // txtTel
            // 
            txtTel.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            txtTel.Location = new Point(92, 345);
            txtTel.Margin = new Padding(2);
            txtTel.Name = "txtTel";
            txtTel.Size = new Size(200, 31);
            txtTel.TabIndex = 10;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label12.Location = new Point(47, 351);
            label12.Margin = new Padding(2, 0, 2, 0);
            label12.Name = "label12";
            label12.Size = new Size(48, 24);
            label12.TabIndex = 101;
            label12.Text = "電話";
            // 
            // txtDAddress
            // 
            txtDAddress.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            txtDAddress.Location = new Point(92, 306);
            txtDAddress.Margin = new Padding(2);
            txtDAddress.Name = "txtDAddress";
            txtDAddress.Size = new Size(465, 31);
            txtDAddress.TabIndex = 9;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label10.Location = new Point(11, 309);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(86, 24);
            label10.TabIndex = 99;
            label10.Text = "寄件地址";
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            txtAddress.Location = new Point(92, 268);
            txtAddress.Margin = new Padding(2);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(465, 31);
            txtAddress.TabIndex = 8;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label9.Location = new Point(11, 273);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(86, 24);
            label9.TabIndex = 97;
            label9.Text = "營業地址";
            // 
            // txtPosition
            // 
            txtPosition.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            txtPosition.Location = new Point(378, 232);
            txtPosition.Margin = new Padding(2);
            txtPosition.Name = "txtPosition";
            txtPosition.Size = new Size(175, 31);
            txtPosition.TabIndex = 7;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label8.Location = new Point(322, 237);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(48, 24);
            label8.TabIndex = 95;
            label8.Text = "職位";
            // 
            // txtContactPersion
            // 
            txtContactPersion.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            txtContactPersion.Location = new Point(87, 232);
            txtContactPersion.Margin = new Padding(2);
            txtContactPersion.Name = "txtContactPersion";
            txtContactPersion.Size = new Size(200, 31);
            txtContactPersion.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label7.Location = new Point(21, 237);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(67, 24);
            label7.TabIndex = 93;
            label7.Text = "聯絡人";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label6.Location = new Point(296, 195);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(86, 24);
            label6.TabIndex = 92;
            label6.Text = "開發來源";
            // 
            // coutrySelect1
            // 
            coutrySelect1.Location = new Point(82, 190);
            coutrySelect1.Margin = new Padding(2, 2, 2, 2);
            coutrySelect1.Name = "coutrySelect1";
            coutrySelect1.Size = new Size(214, 37);
            coutrySelect1.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label5.Location = new Point(42, 201);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(48, 24);
            label5.TabIndex = 90;
            label5.Text = "國別";
            // 
            // btnGenCustNumber
            // 
            btnGenCustNumber.BackColor = Color.IndianRed;
            btnGenCustNumber.ForeColor = SystemColors.Control;
            btnGenCustNumber.Location = new Point(490, 159);
            btnGenCustNumber.Margin = new Padding(2);
            btnGenCustNumber.Name = "btnGenCustNumber";
            btnGenCustNumber.Size = new Size(71, 31);
            btnGenCustNumber.TabIndex = 89;
            btnGenCustNumber.Text = "取號";
            btnGenCustNumber.UseVisualStyleBackColor = false;
            btnGenCustNumber.Click += btnGenCustNumber_Click;
            // 
            // txtCustNumber
            // 
            txtCustNumber.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            txtCustNumber.Location = new Point(378, 159);
            txtCustNumber.Margin = new Padding(2);
            txtCustNumber.Name = "txtCustNumber";
            txtCustNumber.ReadOnly = true;
            txtCustNumber.Size = new Size(108, 31);
            txtCustNumber.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label4.Location = new Point(296, 159);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(86, 24);
            label4.TabIndex = 87;
            label4.Text = "客戶編號";
            // 
            // btnCompanyChange
            // 
            btnCompanyChange.BackColor = SystemColors.AppWorkspace;
            btnCompanyChange.ForeColor = SystemColors.ControlLight;
            btnCompanyChange.Location = new Point(204, 159);
            btnCompanyChange.Margin = new Padding(2);
            btnCompanyChange.Name = "btnCompanyChange";
            btnCompanyChange.Size = new Size(87, 31);
            btnCompanyChange.TabIndex = 86;
            btnCompanyChange.Text = "全稱更名";
            btnCompanyChange.UseVisualStyleBackColor = false;
            btnCompanyChange.Click += btnCompanyChange_Click;
            // 
            // txtCustAlias
            // 
            txtCustAlias.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            txtCustAlias.Location = new Point(87, 159);
            txtCustAlias.Margin = new Padding(2);
            txtCustAlias.Name = "txtCustAlias";
            txtCustAlias.Size = new Size(108, 31);
            txtCustAlias.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label3.Location = new Point(11, 159);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(86, 24);
            label3.TabIndex = 84;
            label3.Text = "客戶簡稱";
            // 
            // txtCustomerCompany
            // 
            txtCustomerCompany.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            txtCustomerCompany.Location = new Point(92, 120);
            txtCustomerCompany.Margin = new Padding(2);
            txtCustomerCompany.Name = "txtCustomerCompany";
            txtCustomerCompany.Size = new Size(465, 31);
            txtCustomerCompany.TabIndex = 1;
            txtCustomerCompany.Enter += txtCustomerCompany_Enter;
            txtCustomerCompany.Leave += txtCustomerCompany_Leave;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label2.Location = new Point(11, 126);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(86, 24);
            label2.TabIndex = 82;
            label2.Text = "客戶全稱";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label21.Location = new Point(11, 566);
            label21.Margin = new Padding(2, 0, 2, 0);
            label21.Name = "label21";
            label21.Size = new Size(86, 24);
            label21.TabIndex = 123;
            label21.Text = "收款帳戶";
            // 
            // bankCodeSelect1
            // 
            bankCodeSelect1.Location = new Point(91, 558);
            bankCodeSelect1.Margin = new Padding(2);
            bankCodeSelect1.Name = "bankCodeSelect1";
            bankCodeSelect1.Size = new Size(144, 44);
            bankCodeSelect1.TabIndex = 20;
            // 
            // btnInactivate
            // 
            btnInactivate.BackColor = Color.Tomato;
            btnInactivate.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            btnInactivate.ForeColor = SystemColors.InactiveBorder;
            btnInactivate.Location = new Point(243, 566);
            btnInactivate.Name = "btnInactivate";
            btnInactivate.Size = new Size(88, 32);
            btnInactivate.TabIndex = 125;
            btnInactivate.Text = "停用";
            btnInactivate.UseVisualStyleBackColor = false;
            btnInactivate.Click += btnInactivate_Click;
            // 
            // btnActivate
            // 
            btnActivate.BackColor = Color.DodgerBlue;
            btnActivate.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            btnActivate.ForeColor = SystemColors.InactiveBorder;
            btnActivate.Location = new Point(355, 566);
            btnActivate.Name = "btnActivate";
            btnActivate.Size = new Size(104, 32);
            btnActivate.TabIndex = 126;
            btnActivate.Text = "取消停用";
            btnActivate.UseVisualStyleBackColor = false;
            btnActivate.Click += btnActivate_Click;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label22.Location = new Point(11, 606);
            label22.Margin = new Padding(2, 0, 2, 0);
            label22.Name = "label22";
            label22.Size = new Size(86, 24);
            label22.TabIndex = 127;
            label22.Text = "啟用日期";
            // 
            // dtEnableDate
            // 
            dtEnableDate.Enabled = false;
            dtEnableDate.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            dtEnableDate.Location = new Point(99, 598);
            dtEnableDate.Name = "dtEnableDate";
            dtEnableDate.Size = new Size(168, 32);
            dtEnableDate.TabIndex = 128;
            dtEnableDate.Value = new DateTime(1900, 1, 1, 8, 42, 0, 0);
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label23.Location = new Point(275, 598);
            label23.Margin = new Padding(2, 0, 2, 0);
            label23.Name = "label23";
            label23.Size = new Size(86, 24);
            label23.TabIndex = 129;
            label23.Text = "停用日期";
            // 
            // dtDisableDate
            // 
            dtDisableDate.Enabled = false;
            dtDisableDate.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            dtDisableDate.Location = new Point(363, 598);
            dtDisableDate.Name = "dtDisableDate";
            dtDisableDate.Size = new Size(168, 32);
            dtDisableDate.TabIndex = 130;
            dtDisableDate.Value = new DateTime(1900, 1, 1, 8, 42, 0, 0);
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label24.Location = new Point(43, 638);
            label24.Margin = new Padding(2, 0, 2, 0);
            label24.Name = "label24";
            label24.Size = new Size(48, 24);
            label24.TabIndex = 131;
            label24.Text = "備註";
            // 
            // txtMemo
            // 
            txtMemo.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            txtMemo.Location = new Point(99, 638);
            txtMemo.Multiline = true;
            txtMemo.Name = "txtMemo";
            txtMemo.Size = new Size(440, 56);
            txtMemo.TabIndex = 21;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label25.Location = new Point(483, 723);
            label25.Margin = new Padding(2, 0, 2, 0);
            label25.Name = "label25";
            label25.Size = new Size(48, 24);
            label25.TabIndex = 136;
            label25.Text = "建檔";
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label26.Location = new Point(32, 723);
            label26.Margin = new Padding(2, 0, 2, 0);
            label26.Name = "label26";
            label26.Size = new Size(48, 24);
            label26.TabIndex = 133;
            label26.Text = "修改";
            // 
            // lblModifyUser
            // 
            lblModifyUser.AutoSize = true;
            lblModifyUser.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            lblModifyUser.Location = new Point(104, 723);
            lblModifyUser.Margin = new Padding(2, 0, 2, 0);
            lblModifyUser.Name = "lblModifyUser";
            lblModifyUser.Size = new Size(136, 24);
            lblModifyUser.TabIndex = 137;
            lblModifyUser.Text = "lblModifyUser";
            // 
            // lblModifyDate
            // 
            lblModifyDate.AutoSize = true;
            lblModifyDate.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            lblModifyDate.Location = new Point(248, 723);
            lblModifyDate.Margin = new Padding(2, 0, 2, 0);
            lblModifyDate.Name = "lblModifyDate";
            lblModifyDate.Size = new Size(121, 24);
            lblModifyDate.TabIndex = 138;
            lblModifyDate.Text = "lblModiDate";
            // 
            // lblCreator
            // 
            lblCreator.AutoSize = true;
            lblCreator.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            lblCreator.Location = new Point(542, 723);
            lblCreator.Margin = new Padding(2, 0, 2, 0);
            lblCreator.Name = "lblCreator";
            lblCreator.Size = new Size(132, 24);
            lblCreator.TabIndex = 139;
            lblCreator.Text = "lblCreateUser";
            lblCreator.Click += lblCreator_Click;
            // 
            // lblCreateDate
            // 
            lblCreateDate.AutoSize = true;
            lblCreateDate.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            lblCreateDate.Location = new Point(678, 723);
            lblCreateDate.Margin = new Padding(2, 0, 2, 0);
            lblCreateDate.Name = "lblCreateDate";
            lblCreateDate.Size = new Size(133, 24);
            lblCreateDate.TabIndex = 140;
            lblCreateDate.Text = "lblCreateDate";
            // 
            // dgvContactList
            // 
            dgvContactList.AllowUserToAddRows = false;
            dgvContactList.AllowUserToDeleteRows = false;
            dgvContactList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvContactList.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvContactList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvContactList.Columns.AddRange(new DataGridViewColumn[] { Contact, Position, email });
            dgvContactList.Location = new Point(571, 118);
            dgvContactList.Name = "dgvContactList";
            dgvContactList.Size = new Size(501, 248);
            dgvContactList.TabIndex = 141;
            // 
            // Contact
            // 
            Contact.HeaderText = "Contact";
            Contact.Name = "Contact";
            Contact.ReadOnly = true;
            Contact.Width = 76;
            // 
            // Position
            // 
            Position.HeaderText = "Position";
            Position.Name = "Position";
            Position.ReadOnly = true;
            Position.Width = 77;
            // 
            // email
            // 
            email.HeaderText = "e-mail";
            email.Name = "email";
            email.ReadOnly = true;
            email.Width = 68;
            // 
            // dgvCustIntView
            // 
            dgvCustIntView.AllowUserToAddRows = false;
            dgvCustIntView.AllowUserToDeleteRows = false;
            dgvCustIntView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvCustIntView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvCustIntView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustIntView.Columns.AddRange(new DataGridViewColumn[] { 洽談日期, 工號, 業務人員, 轉詢問函, 內容簡述 });
            dgvCustIntView.Location = new Point(571, 390);
            dgvCustIntView.Name = "dgvCustIntView";
            dgvCustIntView.Size = new Size(501, 328);
            dgvCustIntView.TabIndex = 142;
            // 
            // 洽談日期
            // 
            洽談日期.HeaderText = "洽談日期";
            洽談日期.Name = "洽談日期";
            洽談日期.ReadOnly = true;
            洽談日期.Width = 80;
            // 
            // 工號
            // 
            工號.HeaderText = "工號";
            工號.Name = "工號";
            工號.ReadOnly = true;
            工號.Width = 56;
            // 
            // 業務人員
            // 
            業務人員.HeaderText = "業務人員";
            業務人員.Name = "業務人員";
            業務人員.ReadOnly = true;
            業務人員.Width = 80;
            // 
            // 轉詢問函
            // 
            轉詢問函.HeaderText = "轉詢問函";
            轉詢問函.Name = "轉詢問函";
            轉詢問函.ReadOnly = true;
            轉詢問函.Width = 80;
            // 
            // 內容簡述
            // 
            內容簡述.HeaderText = "內容簡述";
            內容簡述.Name = "內容簡述";
            內容簡述.ReadOnly = true;
            內容簡述.Width = 80;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(968, 91);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(75, 23);
            btnSubmit.TabIndex = 143;
            btnSubmit.Text = "送出";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // txtIdentity
            // 
            txtIdentity.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            txtIdentity.Location = new Point(112, 83);
            txtIdentity.Margin = new Padding(2);
            txtIdentity.Name = "txtIdentity";
            txtIdentity.Size = new Size(175, 31);
            txtIdentity.TabIndex = 144;
            txtIdentity.Text = "0";
            txtIdentity.Visible = false;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Red;
            btnDelete.ForeColor = SystemColors.ButtonHighlight;
            btnDelete.Location = new Point(896, 91);
            btnDelete.Margin = new Padding(2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(64, 22);
            btnDelete.TabIndex = 145;
            btnDelete.Text = "刪除紀錄";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnShippingRecord
            // 
            btnShippingRecord.BackColor = Color.FromArgb(0, 192, 0);
            btnShippingRecord.ForeColor = SystemColors.ButtonHighlight;
            btnShippingRecord.Location = new Point(824, 91);
            btnShippingRecord.Margin = new Padding(2);
            btnShippingRecord.Name = "btnShippingRecord";
            btnShippingRecord.Size = new Size(64, 22);
            btnShippingRecord.TabIndex = 146;
            btnShippingRecord.Text = "交貨紀錄";
            btnShippingRecord.UseVisualStyleBackColor = false;
            btnShippingRecord.Click += btnShippingRecord_Click;
            // 
            // btnRepairHistory
            // 
            btnRepairHistory.BackColor = Color.FromArgb(0, 0, 192);
            btnRepairHistory.ForeColor = SystemColors.ButtonHighlight;
            btnRepairHistory.Location = new Point(752, 91);
            btnRepairHistory.Margin = new Padding(2);
            btnRepairHistory.Name = "btnRepairHistory";
            btnRepairHistory.Size = new Size(64, 22);
            btnRepairHistory.TabIndex = 147;
            btnRepairHistory.Text = "查修履歷";
            btnRepairHistory.UseVisualStyleBackColor = false;
            btnRepairHistory.Click += btnRepairHistory_Click;
            // 
            // btnQuotationHistory
            // 
            btnQuotationHistory.BackColor = Color.FromArgb(192, 64, 0);
            btnQuotationHistory.ForeColor = SystemColors.ButtonHighlight;
            btnQuotationHistory.Location = new Point(680, 91);
            btnQuotationHistory.Margin = new Padding(2);
            btnQuotationHistory.Name = "btnQuotationHistory";
            btnQuotationHistory.Size = new Size(64, 22);
            btnQuotationHistory.TabIndex = 148;
            btnQuotationHistory.Text = "報價歷程";
            btnQuotationHistory.UseVisualStyleBackColor = false;
            btnQuotationHistory.Click += btnQuotationHistory_Click_1;
            // 
            // btnInquiryHistory
            // 
            btnInquiryHistory.BackColor = Color.DarkOrange;
            btnInquiryHistory.ForeColor = SystemColors.ButtonHighlight;
            btnInquiryHistory.Location = new Point(608, 91);
            btnInquiryHistory.Margin = new Padding(2);
            btnInquiryHistory.Name = "btnInquiryHistory";
            btnInquiryHistory.Size = new Size(64, 22);
            btnInquiryHistory.TabIndex = 149;
            btnInquiryHistory.Text = "詢問履歷";
            btnInquiryHistory.UseVisualStyleBackColor = false;
            btnInquiryHistory.Click += btnInquiryHistory_Click;
            // 
            // btnRecordWrite
            // 
            btnRecordWrite.BackColor = Color.SteelBlue;
            btnRecordWrite.ForeColor = SystemColors.ButtonHighlight;
            btnRecordWrite.Location = new Point(536, 91);
            btnRecordWrite.Margin = new Padding(2);
            btnRecordWrite.Name = "btnRecordWrite";
            btnRecordWrite.Size = new Size(64, 22);
            btnRecordWrite.TabIndex = 150;
            btnRecordWrite.Text = "撰寫時錄";
            btnRecordWrite.UseVisualStyleBackColor = false;
            btnRecordWrite.Click += btnRecordWrite_Click;
            // 
            // CustomerMaintainControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnRecordWrite);
            Controls.Add(btnInquiryHistory);
            Controls.Add(btnQuotationHistory);
            Controls.Add(btnRepairHistory);
            Controls.Add(btnShippingRecord);
            Controls.Add(btnDelete);
            Controls.Add(txtIdentity);
            Controls.Add(btnSubmit);
            Controls.Add(dgvCustIntView);
            Controls.Add(dgvContactList);
            Controls.Add(lblCreateDate);
            Controls.Add(lblCreator);
            Controls.Add(lblModifyDate);
            Controls.Add(lblModifyUser);
            Controls.Add(label25);
            Controls.Add(label26);
            Controls.Add(txtMemo);
            Controls.Add(label24);
            Controls.Add(dtDisableDate);
            Controls.Add(label23);
            Controls.Add(dtEnableDate);
            Controls.Add(label22);
            Controls.Add(btnActivate);
            Controls.Add(btnInactivate);
            Controls.Add(bankCodeSelect1);
            Controls.Add(label21);
            Controls.Add(label20);
            Controls.Add(txtMachineIssue);
            Controls.Add(label19);
            Controls.Add(btnIndustryCodeManage);
            Controls.Add(industryCodeSelect1);
            Controls.Add(txtColumn1);
            Controls.Add(label18);
            Controls.Add(cboIndustrry);
            Controls.Add(label17);
            Controls.Add(cboSource);
            Controls.Add(cboMa);
            Controls.Add(label15);
            Controls.Add(txtEmail);
            Controls.Add(label16);
            Controls.Add(txtFax);
            Controls.Add(label13);
            Controls.Add(txtWebsite);
            Controls.Add(label14);
            Controls.Add(txtZipcode);
            Controls.Add(label11);
            Controls.Add(txtTel);
            Controls.Add(label12);
            Controls.Add(txtDAddress);
            Controls.Add(label10);
            Controls.Add(txtAddress);
            Controls.Add(label9);
            Controls.Add(txtPosition);
            Controls.Add(label8);
            Controls.Add(txtContactPersion);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(coutrySelect1);
            Controls.Add(label5);
            Controls.Add(btnGenCustNumber);
            Controls.Add(txtCustNumber);
            Controls.Add(label4);
            Controls.Add(btnCompanyChange);
            Controls.Add(txtCustAlias);
            Controls.Add(label3);
            Controls.Add(txtCustomerCompany);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(lblMode);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "CustomerMaintainControl";
            Size = new Size(1085, 759);
            ((System.ComponentModel.ISupportInitialize)dgvContactList).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCustIntView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblMode;
        private Button button1;
        private Label label20;
        private CommonTextBox txtMachineIssue;
        private Label label19;
        private Button btnIndustryCodeManage;
        private Common.IndustryCodeSelect industryCodeSelect1;
        private CommonTextBox txtColumn1;
        private Label label18;
        private CommonComboBox cboIndustrry;
        private Label label17;
        private CommonComboBox cboSource;
        private CommonComboBox cboMa;
        private Label label15;
        private CommonTextBox txtEmail;
        private Label label16;
        private CommonTextBox txtFax;
        private Label label13;
        private CommonTextBox txtWebsite;
        private Label label14;
        private CommonTextBox txtZipcode;
        private Label label11;
        private CommonTextBox txtTel;
        private Label label12;
        private CommonTextBox txtDAddress;
        private Label label10;
        private CommonTextBox txtAddress;
        private Label label9;
        private CommonTextBox txtPosition;
        private Label label8;
        private CommonTextBox txtContactPersion;
        private Label label7;
        private Label label6;
        private Common.CoutrySelect coutrySelect1;
        private Label label5;
        private Button btnGenCustNumber;
        private CommonTextBox txtCustNumber;
        private Label label4;
        private Button btnCompanyChange;
        private CommonTextBox txtCustAlias;
        private Label label3;
        private CommonTextBox txtCustomerCompany;
        private Label label2;
        private Label label21;
        private Common.BankCodeSelect bankCodeSelect1;
        private Button btnInactivate;
        private Button btnActivate;
        private Label label22;
        private DateTimePicker dtEnableDate;
        private Label label23;
        private DateTimePicker dtDisableDate;
        private Label label24;
        private CommonTextBox txtMemo;
        private Label label25;
        private Label label26;
        private Label lblModifyUser;
        private Label lblModifyDate;
        private Label lblCreator;
        private Label lblCreateDate;
        private DataGridView dgvContactList;
        private DataGridView dgvCustIntView;
        private DataGridViewTextBoxColumn Contact;
        private DataGridViewTextBoxColumn Position;
        private DataGridViewTextBoxColumn email;
        private DataGridViewTextBoxColumn 洽談日期;
        private DataGridViewTextBoxColumn 工號;
        private DataGridViewTextBoxColumn 業務人員;
        private DataGridViewTextBoxColumn 轉詢問函;
        private DataGridViewTextBoxColumn 內容簡述;
        private Button btnSubmit;
        private CommonTextBox txtIdentity;
        private Button btnDelete;
        private Button btnShippingRecord;
        private Button btnRepairHistory;
        private Button btnQuotationHistory;
        private Button btnInquiryHistory;
        private Button btnRecordWrite;
    }
}
