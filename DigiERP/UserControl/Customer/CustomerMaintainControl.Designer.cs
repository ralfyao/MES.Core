namespace DigiERP.UserControl
{
    partial class CustomerMaintainControl : System.Windows.Forms.UserControl
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
            txtMachineIssue = new TextBox();
            label19 = new Label();
            btnIndustryCodeManage = new Button();
            industryCodeSelect1 = new Common.IndustryCodeSelect();
            txtColumn1 = new TextBox();
            label18 = new Label();
            cboIndustrry = new ComboBox();
            label17 = new Label();
            cboSource = new ComboBox();
            cboMa = new ComboBox();
            label15 = new Label();
            txtEmail = new TextBox();
            label16 = new Label();
            txtFax = new TextBox();
            label13 = new Label();
            txtWebsite = new TextBox();
            label14 = new Label();
            txtZipcode = new TextBox();
            label11 = new Label();
            txtTel = new TextBox();
            label12 = new Label();
            txtDAddress = new TextBox();
            label10 = new Label();
            txtAddress = new TextBox();
            label9 = new Label();
            txtPosition = new TextBox();
            label8 = new Label();
            txtContactPersion = new TextBox();
            label7 = new Label();
            label6 = new Label();
            coutrySelect1 = new Common.CoutrySelect();
            label5 = new Label();
            btnGenCustNumber = new Button();
            txtCustNumber = new TextBox();
            label4 = new Label();
            btnCompanyChange = new Button();
            txtCustAlias = new TextBox();
            label3 = new Label();
            txtCustomerCompany = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Lime;
            label1.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label1.Location = new Point(46, 5);
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
            lblMode.Location = new Point(5, 5);
            lblMode.Margin = new Padding(2, 0, 2, 0);
            lblMode.Name = "lblMode";
            lblMode.Size = new Size(85, 24);
            lblMode.TabIndex = 1;
            lblMode.Text = "lblMode";
            // 
            // button1
            // 
            button1.Location = new Point(1044, 0);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(20, 22);
            button1.TabIndex = 2;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label20.Location = new Point(8, 443);
            label20.Margin = new Padding(2, 0, 2, 0);
            label20.Name = "label20";
            label20.Size = new Size(86, 24);
            label20.TabIndex = 122;
            label20.Text = "機台類別";
            // 
            // txtMachineIssue
            // 
            txtMachineIssue.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            txtMachineIssue.Location = new Point(89, 443);
            txtMachineIssue.Margin = new Padding(2);
            txtMachineIssue.Name = "txtMachineIssue";
            txtMachineIssue.Size = new Size(455, 31);
            txtMachineIssue.TabIndex = 121;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label19.Location = new Point(8, 407);
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
            btnIndustryCodeManage.Location = new Point(456, 407);
            btnIndustryCodeManage.Margin = new Padding(2);
            btnIndustryCodeManage.Name = "btnIndustryCodeManage";
            btnIndustryCodeManage.Size = new Size(87, 31);
            btnIndustryCodeManage.TabIndex = 119;
            btnIndustryCodeManage.Text = "業別管理";
            btnIndustryCodeManage.UseVisualStyleBackColor = false;
            // 
            // industryCodeSelect1
            // 
            industryCodeSelect1.Location = new Point(79, 402);
            industryCodeSelect1.Margin = new Padding(1);
            industryCodeSelect1.Name = "industryCodeSelect1";
            industryCodeSelect1.Size = new Size(367, 37);
            industryCodeSelect1.TabIndex = 118;
            // 
            // txtColumn1
            // 
            txtColumn1.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            txtColumn1.Location = new Point(375, 370);
            txtColumn1.Margin = new Padding(2);
            txtColumn1.Name = "txtColumn1";
            txtColumn1.Size = new Size(175, 31);
            txtColumn1.TabIndex = 117;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label18.Location = new Point(293, 370);
            label18.Margin = new Padding(2, 0, 2, 0);
            label18.Name = "label18";
            label18.Size = new Size(86, 24);
            label18.TabIndex = 116;
            label18.Text = "終端使用";
            // 
            // cboIndustrry
            // 
            cboIndustrry.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            cboIndustrry.FormattingEnabled = true;
            cboIndustrry.Items.AddRange(new object[] { "Manufacturer", "Trader", "Agent" });
            cboIndustrry.Location = new Point(89, 370);
            cboIndustrry.Margin = new Padding(2);
            cboIndustrry.Name = "cboIndustrry";
            cboIndustrry.Size = new Size(200, 32);
            cboIndustrry.TabIndex = 115;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label17.Location = new Point(8, 370);
            label17.Margin = new Padding(2, 0, 2, 0);
            label17.Name = "label17";
            label17.Size = new Size(86, 24);
            label17.TabIndex = 114;
            label17.Text = "配合代理";
            // 
            // cboSource
            // 
            cboSource.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            cboSource.FormattingEnabled = true;
            cboSource.Items.AddRange(new object[] { "社群軟體", "非代理/朋友", "搜尋引擎", "公司官網詢問函", "代理轉介", "展覽認識", "自主開發" });
            cboSource.Location = new Point(375, 109);
            cboSource.Margin = new Padding(2);
            cboSource.Name = "cboSource";
            cboSource.Size = new Size(169, 32);
            cboSource.TabIndex = 113;
            // 
            // cboMa
            // 
            cboMa.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            cboMa.FormattingEnabled = true;
            cboMa.Items.AddRange(new object[] { "Manufacturer", "Trader", "Agent" });
            cboMa.Location = new Point(375, 334);
            cboMa.Margin = new Padding(2);
            cboMa.Name = "cboMa";
            cboMa.Size = new Size(169, 32);
            cboMa.TabIndex = 112;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label15.Location = new Point(293, 297);
            label15.Margin = new Padding(2, 0, 2, 0);
            label15.Name = "label15";
            label15.Size = new Size(86, 24);
            label15.TabIndex = 111;
            label15.Text = "型態分類";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            txtEmail.Location = new Point(89, 333);
            txtEmail.Margin = new Padding(2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(200, 31);
            txtEmail.TabIndex = 110;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label16.Location = new Point(44, 338);
            label16.Margin = new Padding(2, 0, 2, 0);
            label16.Name = "label16";
            label16.Size = new Size(48, 24);
            label16.TabIndex = 109;
            label16.Text = "電郵";
            // 
            // txtFax
            // 
            txtFax.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            txtFax.Location = new Point(375, 296);
            txtFax.Margin = new Padding(2);
            txtFax.Name = "txtFax";
            txtFax.Size = new Size(175, 31);
            txtFax.TabIndex = 108;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label13.Location = new Point(324, 260);
            label13.Margin = new Padding(2, 0, 2, 0);
            label13.Name = "label13";
            label13.Size = new Size(48, 24);
            label13.TabIndex = 107;
            label13.Text = "傳真";
            // 
            // txtWebsite
            // 
            txtWebsite.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            txtWebsite.Location = new Point(89, 296);
            txtWebsite.Margin = new Padding(2);
            txtWebsite.Name = "txtWebsite";
            txtWebsite.Size = new Size(200, 31);
            txtWebsite.TabIndex = 106;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label14.Location = new Point(44, 302);
            label14.Margin = new Padding(2, 0, 2, 0);
            label14.Name = "label14";
            label14.Size = new Size(48, 24);
            label14.TabIndex = 105;
            label14.Text = "網址";
            // 
            // txtZipcode
            // 
            txtZipcode.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            txtZipcode.Location = new Point(375, 259);
            txtZipcode.Margin = new Padding(2);
            txtZipcode.Name = "txtZipcode";
            txtZipcode.Size = new Size(175, 31);
            txtZipcode.TabIndex = 104;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label11.Location = new Point(324, 223);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(48, 24);
            label11.TabIndex = 103;
            label11.Text = "手機";
            // 
            // txtTel
            // 
            txtTel.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            txtTel.Location = new Point(89, 259);
            txtTel.Margin = new Padding(2);
            txtTel.Name = "txtTel";
            txtTel.Size = new Size(200, 31);
            txtTel.TabIndex = 102;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label12.Location = new Point(44, 265);
            label12.Margin = new Padding(2, 0, 2, 0);
            label12.Name = "label12";
            label12.Size = new Size(48, 24);
            label12.TabIndex = 101;
            label12.Text = "電話";
            // 
            // txtDAddress
            // 
            txtDAddress.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            txtDAddress.Location = new Point(89, 220);
            txtDAddress.Margin = new Padding(2);
            txtDAddress.Name = "txtDAddress";
            txtDAddress.Size = new Size(465, 31);
            txtDAddress.TabIndex = 100;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label10.Location = new Point(8, 223);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(86, 24);
            label10.TabIndex = 99;
            label10.Text = "寄件地址";
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            txtAddress.Location = new Point(89, 182);
            txtAddress.Margin = new Padding(2);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(465, 31);
            txtAddress.TabIndex = 98;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label9.Location = new Point(8, 187);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(86, 24);
            label9.TabIndex = 97;
            label9.Text = "營業地址";
            // 
            // txtPosition
            // 
            txtPosition.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            txtPosition.Location = new Point(375, 146);
            txtPosition.Margin = new Padding(2);
            txtPosition.Name = "txtPosition";
            txtPosition.Size = new Size(175, 31);
            txtPosition.TabIndex = 96;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label8.Location = new Point(319, 151);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(48, 24);
            label8.TabIndex = 95;
            label8.Text = "職位";
            // 
            // txtContactPersion
            // 
            txtContactPersion.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            txtContactPersion.Location = new Point(84, 146);
            txtContactPersion.Margin = new Padding(2);
            txtContactPersion.Name = "txtContactPersion";
            txtContactPersion.Size = new Size(200, 31);
            txtContactPersion.TabIndex = 94;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label7.Location = new Point(18, 151);
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
            label6.Location = new Point(293, 109);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(86, 24);
            label6.TabIndex = 92;
            label6.Text = "開發來源";
            // 
            // coutrySelect1
            // 
            coutrySelect1.Location = new Point(79, 104);
            coutrySelect1.Margin = new Padding(2, 2, 2, 2);
            coutrySelect1.Name = "coutrySelect1";
            coutrySelect1.Size = new Size(214, 37);
            coutrySelect1.TabIndex = 91;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label5.Location = new Point(39, 115);
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
            btnGenCustNumber.Location = new Point(487, 73);
            btnGenCustNumber.Margin = new Padding(2);
            btnGenCustNumber.Name = "btnGenCustNumber";
            btnGenCustNumber.Size = new Size(71, 31);
            btnGenCustNumber.TabIndex = 89;
            btnGenCustNumber.Text = "取號";
            btnGenCustNumber.UseVisualStyleBackColor = false;
            // 
            // txtCustNumber
            // 
            txtCustNumber.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            txtCustNumber.Location = new Point(375, 73);
            txtCustNumber.Margin = new Padding(2);
            txtCustNumber.Name = "txtCustNumber";
            txtCustNumber.ReadOnly = true;
            txtCustNumber.Size = new Size(108, 31);
            txtCustNumber.TabIndex = 88;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label4.Location = new Point(293, 73);
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
            btnCompanyChange.Location = new Point(201, 73);
            btnCompanyChange.Margin = new Padding(2);
            btnCompanyChange.Name = "btnCompanyChange";
            btnCompanyChange.Size = new Size(87, 31);
            btnCompanyChange.TabIndex = 86;
            btnCompanyChange.Text = "全稱更名";
            btnCompanyChange.UseVisualStyleBackColor = false;
            // 
            // txtCustAlias
            // 
            txtCustAlias.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            txtCustAlias.Location = new Point(84, 73);
            txtCustAlias.Margin = new Padding(2);
            txtCustAlias.Name = "txtCustAlias";
            txtCustAlias.Size = new Size(108, 31);
            txtCustAlias.TabIndex = 85;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label3.Location = new Point(8, 73);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(86, 24);
            label3.TabIndex = 84;
            label3.Text = "客戶簡稱";
            // 
            // txtCustomerCompany
            // 
            txtCustomerCompany.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            txtCustomerCompany.Location = new Point(89, 34);
            txtCustomerCompany.Margin = new Padding(2);
            txtCustomerCompany.Name = "txtCustomerCompany";
            txtCustomerCompany.Size = new Size(465, 31);
            txtCustomerCompany.TabIndex = 83;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label2.Location = new Point(8, 40);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(86, 24);
            label2.TabIndex = 82;
            label2.Text = "客戶全稱";
            // 
            // CustomerMaintainControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
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
            Size = new Size(1066, 646);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblMode;
        private Button button1;
        private Label label20;
        private TextBox txtMachineIssue;
        private Label label19;
        private Button btnIndustryCodeManage;
        private Common.IndustryCodeSelect industryCodeSelect1;
        private TextBox txtColumn1;
        private Label label18;
        private ComboBox cboIndustrry;
        private Label label17;
        private ComboBox cboSource;
        private ComboBox cboMa;
        private Label label15;
        private TextBox txtEmail;
        private Label label16;
        private TextBox txtFax;
        private Label label13;
        private TextBox txtWebsite;
        private Label label14;
        private TextBox txtZipcode;
        private Label label11;
        private TextBox txtTel;
        private Label label12;
        private TextBox txtDAddress;
        private Label label10;
        private TextBox txtAddress;
        private Label label9;
        private TextBox txtPosition;
        private Label label8;
        private TextBox txtContactPersion;
        private Label label7;
        private Label label6;
        private Common.CoutrySelect coutrySelect1;
        private Label label5;
        private Button btnGenCustNumber;
        private TextBox txtCustNumber;
        private Label label4;
        private Button btnCompanyChange;
        private TextBox txtCustAlias;
        private Label label3;
        private TextBox txtCustomerCompany;
        private Label label2;
    }
}
