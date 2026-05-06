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
            label2 = new Label();
            txtCustomerCompany = new TextBox();
            label3 = new Label();
            txtCustAlias = new TextBox();
            btnCompanyChange = new Button();
            label4 = new Label();
            txtCustNumber = new TextBox();
            btnGenCustNumber = new Button();
            label5 = new Label();
            coutrySelect1 = new Common.CoutrySelect();
            label6 = new Label();
            label7 = new Label();
            txtContactPersion = new TextBox();
            label8 = new Label();
            txtPosition = new TextBox();
            label9 = new Label();
            txtAddress = new TextBox();
            label10 = new Label();
            txtDAddress = new TextBox();
            label12 = new Label();
            txtTel = new TextBox();
            label11 = new Label();
            txtZipcode = new TextBox();
            label14 = new Label();
            txtWebsite = new TextBox();
            label13 = new Label();
            txtFax = new TextBox();
            label16 = new Label();
            txtEmail = new TextBox();
            label15 = new Label();
            cboMa = new ComboBox();
            cboSource = new ComboBox();
            label17 = new Label();
            cboIndustrry = new ComboBox();
            label18 = new Label();
            txtColumn1 = new TextBox();
            industryCodeSelect1 = new Common.IndustryCodeSelect();
            btnIndustryCodeManage = new Button();
            label19 = new Label();
            txtMachineIssue = new TextBox();
            label20 = new Label();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
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
            button1.Margin = new Padding(2, 2, 2, 2);
            button1.Name = "button1";
            button1.Size = new Size(20, 22);
            button1.TabIndex = 2;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label2.Location = new Point(0, 35);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(86, 24);
            label2.TabIndex = 40;
            label2.Text = "客戶全稱";
            // 
            // txtCustomerCompany
            // 
            txtCustomerCompany.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            txtCustomerCompany.Location = new Point(81, 29);
            txtCustomerCompany.Margin = new Padding(2);
            txtCustomerCompany.Name = "txtCustomerCompany";
            txtCustomerCompany.Size = new Size(465, 31);
            txtCustomerCompany.TabIndex = 41;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label3.Location = new Point(0, 68);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(86, 24);
            label3.TabIndex = 42;
            label3.Text = "客戶簡稱";
            // 
            // txtCustAlias
            // 
            txtCustAlias.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            txtCustAlias.Location = new Point(76, 68);
            txtCustAlias.Margin = new Padding(2);
            txtCustAlias.Name = "txtCustAlias";
            txtCustAlias.Size = new Size(108, 31);
            txtCustAlias.TabIndex = 43;
            // 
            // btnCompanyChange
            // 
            btnCompanyChange.BackColor = SystemColors.AppWorkspace;
            btnCompanyChange.ForeColor = SystemColors.ControlLight;
            btnCompanyChange.Location = new Point(193, 68);
            btnCompanyChange.Margin = new Padding(2);
            btnCompanyChange.Name = "btnCompanyChange";
            btnCompanyChange.Size = new Size(87, 31);
            btnCompanyChange.TabIndex = 44;
            btnCompanyChange.Text = "全稱更名";
            btnCompanyChange.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label4.Location = new Point(285, 68);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(86, 24);
            label4.TabIndex = 45;
            label4.Text = "客戶編號";
            // 
            // txtCustNumber
            // 
            txtCustNumber.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            txtCustNumber.Location = new Point(367, 68);
            txtCustNumber.Margin = new Padding(2);
            txtCustNumber.Name = "txtCustNumber";
            txtCustNumber.ReadOnly = true;
            txtCustNumber.Size = new Size(108, 31);
            txtCustNumber.TabIndex = 46;
            // 
            // btnGenCustNumber
            // 
            btnGenCustNumber.BackColor = Color.IndianRed;
            btnGenCustNumber.ForeColor = SystemColors.Control;
            btnGenCustNumber.Location = new Point(479, 68);
            btnGenCustNumber.Margin = new Padding(2);
            btnGenCustNumber.Name = "btnGenCustNumber";
            btnGenCustNumber.Size = new Size(71, 31);
            btnGenCustNumber.TabIndex = 47;
            btnGenCustNumber.Text = "取號";
            btnGenCustNumber.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label5.Location = new Point(31, 110);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(48, 24);
            label5.TabIndex = 48;
            label5.Text = "國別";
            // 
            // coutrySelect1
            // 
            coutrySelect1.Location = new Point(71, 99);
            coutrySelect1.Name = "coutrySelect1";
            coutrySelect1.Size = new Size(214, 37);
            coutrySelect1.TabIndex = 49;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label6.Location = new Point(285, 104);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(86, 24);
            label6.TabIndex = 50;
            label6.Text = "開發來源";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label7.Location = new Point(10, 146);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(67, 24);
            label7.TabIndex = 51;
            label7.Text = "聯絡人";
            // 
            // txtContactPersion
            // 
            txtContactPersion.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            txtContactPersion.Location = new Point(76, 141);
            txtContactPersion.Margin = new Padding(2);
            txtContactPersion.Name = "txtContactPersion";
            txtContactPersion.Size = new Size(200, 31);
            txtContactPersion.TabIndex = 52;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label8.Location = new Point(311, 146);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(48, 24);
            label8.TabIndex = 53;
            label8.Text = "職位";
            // 
            // txtPosition
            // 
            txtPosition.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            txtPosition.Location = new Point(367, 141);
            txtPosition.Margin = new Padding(2);
            txtPosition.Name = "txtPosition";
            txtPosition.Size = new Size(175, 31);
            txtPosition.TabIndex = 54;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label9.Location = new Point(0, 182);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(86, 24);
            label9.TabIndex = 55;
            label9.Text = "營業地址";
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            txtAddress.Location = new Point(81, 177);
            txtAddress.Margin = new Padding(2);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(465, 31);
            txtAddress.TabIndex = 56;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label10.Location = new Point(0, 218);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(86, 24);
            label10.TabIndex = 57;
            label10.Text = "寄件地址";
            // 
            // txtDAddress
            // 
            txtDAddress.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            txtDAddress.Location = new Point(81, 215);
            txtDAddress.Margin = new Padding(2);
            txtDAddress.Name = "txtDAddress";
            txtDAddress.Size = new Size(465, 31);
            txtDAddress.TabIndex = 58;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label12.Location = new Point(36, 260);
            label12.Margin = new Padding(2, 0, 2, 0);
            label12.Name = "label12";
            label12.Size = new Size(48, 24);
            label12.TabIndex = 59;
            label12.Text = "電話";
            // 
            // txtTel
            // 
            txtTel.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            txtTel.Location = new Point(81, 254);
            txtTel.Margin = new Padding(2);
            txtTel.Name = "txtTel";
            txtTel.Size = new Size(200, 31);
            txtTel.TabIndex = 60;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label11.Location = new Point(316, 218);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(48, 24);
            label11.TabIndex = 61;
            label11.Text = "手機";
            // 
            // txtZipcode
            // 
            txtZipcode.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            txtZipcode.Location = new Point(367, 254);
            txtZipcode.Margin = new Padding(2);
            txtZipcode.Name = "txtZipcode";
            txtZipcode.Size = new Size(175, 31);
            txtZipcode.TabIndex = 62;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label14.Location = new Point(36, 297);
            label14.Margin = new Padding(2, 0, 2, 0);
            label14.Name = "label14";
            label14.Size = new Size(48, 24);
            label14.TabIndex = 63;
            label14.Text = "網址";
            // 
            // txtWebsite
            // 
            txtWebsite.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            txtWebsite.Location = new Point(81, 291);
            txtWebsite.Margin = new Padding(2);
            txtWebsite.Name = "txtWebsite";
            txtWebsite.Size = new Size(200, 31);
            txtWebsite.TabIndex = 64;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label13.Location = new Point(316, 255);
            label13.Margin = new Padding(2, 0, 2, 0);
            label13.Name = "label13";
            label13.Size = new Size(48, 24);
            label13.TabIndex = 65;
            label13.Text = "傳真";
            // 
            // txtFax
            // 
            txtFax.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            txtFax.Location = new Point(367, 291);
            txtFax.Margin = new Padding(2);
            txtFax.Name = "txtFax";
            txtFax.Size = new Size(175, 31);
            txtFax.TabIndex = 66;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label16.Location = new Point(36, 333);
            label16.Margin = new Padding(2, 0, 2, 0);
            label16.Name = "label16";
            label16.Size = new Size(48, 24);
            label16.TabIndex = 67;
            label16.Text = "電郵";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            txtEmail.Location = new Point(81, 328);
            txtEmail.Margin = new Padding(2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(200, 31);
            txtEmail.TabIndex = 68;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label15.Location = new Point(285, 292);
            label15.Margin = new Padding(2, 0, 2, 0);
            label15.Name = "label15";
            label15.Size = new Size(86, 24);
            label15.TabIndex = 69;
            label15.Text = "型態分類";
            // 
            // cboMa
            // 
            cboMa.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            cboMa.FormattingEnabled = true;
            cboMa.Items.AddRange(new object[] { "Manufacturer", "Trader", "Agent" });
            cboMa.Location = new Point(367, 329);
            cboMa.Margin = new Padding(2);
            cboMa.Name = "cboMa";
            cboMa.Size = new Size(169, 32);
            cboMa.TabIndex = 70;
            // 
            // cboSource
            // 
            cboSource.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            cboSource.FormattingEnabled = true;
            cboSource.Items.AddRange(new object[] { "社群軟體", "非代理/朋友", "搜尋引擎", "公司官網詢問函", "代理轉介", "展覽認識", "自主開發" });
            cboSource.Location = new Point(367, 104);
            cboSource.Margin = new Padding(2);
            cboSource.Name = "cboSource";
            cboSource.Size = new Size(169, 32);
            cboSource.TabIndex = 71;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label17.Location = new Point(0, 365);
            label17.Margin = new Padding(2, 0, 2, 0);
            label17.Name = "label17";
            label17.Size = new Size(86, 24);
            label17.TabIndex = 72;
            label17.Text = "配合代理";
            // 
            // cboIndustrry
            // 
            cboIndustrry.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            cboIndustrry.FormattingEnabled = true;
            cboIndustrry.Items.AddRange(new object[] { "Manufacturer", "Trader", "Agent" });
            cboIndustrry.Location = new Point(81, 365);
            cboIndustrry.Margin = new Padding(2);
            cboIndustrry.Name = "cboIndustrry";
            cboIndustrry.Size = new Size(200, 32);
            cboIndustrry.TabIndex = 73;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label18.Location = new Point(285, 365);
            label18.Margin = new Padding(2, 0, 2, 0);
            label18.Name = "label18";
            label18.Size = new Size(86, 24);
            label18.TabIndex = 74;
            label18.Text = "終端使用";
            // 
            // txtColumn1
            // 
            txtColumn1.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            txtColumn1.Location = new Point(367, 365);
            txtColumn1.Margin = new Padding(2);
            txtColumn1.Name = "txtColumn1";
            txtColumn1.Size = new Size(175, 31);
            txtColumn1.TabIndex = 75;
            // 
            // industryCodeSelect1
            // 
            industryCodeSelect1.Location = new Point(71, 397);
            industryCodeSelect1.Margin = new Padding(1);
            industryCodeSelect1.Name = "industryCodeSelect1";
            industryCodeSelect1.Size = new Size(367, 37);
            industryCodeSelect1.TabIndex = 76;
            // 
            // btnIndustryCodeManage
            // 
            btnIndustryCodeManage.BackColor = Color.Brown;
            btnIndustryCodeManage.ForeColor = SystemColors.ButtonFace;
            btnIndustryCodeManage.Location = new Point(448, 402);
            btnIndustryCodeManage.Margin = new Padding(2);
            btnIndustryCodeManage.Name = "btnIndustryCodeManage";
            btnIndustryCodeManage.Size = new Size(87, 31);
            btnIndustryCodeManage.TabIndex = 77;
            btnIndustryCodeManage.Text = "業別管理";
            btnIndustryCodeManage.UseVisualStyleBackColor = false;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label19.Location = new Point(0, 402);
            label19.Margin = new Padding(2, 0, 2, 0);
            label19.Name = "label19";
            label19.Size = new Size(86, 24);
            label19.TabIndex = 78;
            label19.Text = "所屬業別";
            // 
            // txtMachineIssue
            // 
            txtMachineIssue.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            txtMachineIssue.Location = new Point(81, 438);
            txtMachineIssue.Margin = new Padding(2);
            txtMachineIssue.Name = "txtMachineIssue";
            txtMachineIssue.Size = new Size(455, 31);
            txtMachineIssue.TabIndex = 80;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label20.Location = new Point(0, 438);
            label20.Margin = new Padding(2, 0, 2, 0);
            label20.Name = "label20";
            label20.Size = new Size(86, 24);
            label20.TabIndex = 81;
            label20.Text = "機台類別";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label20);
            groupBox1.Controls.Add(txtMachineIssue);
            groupBox1.Controls.Add(label19);
            groupBox1.Controls.Add(btnIndustryCodeManage);
            groupBox1.Controls.Add(industryCodeSelect1);
            groupBox1.Controls.Add(txtColumn1);
            groupBox1.Controls.Add(label18);
            groupBox1.Controls.Add(cboIndustrry);
            groupBox1.Controls.Add(label17);
            groupBox1.Controls.Add(cboSource);
            groupBox1.Controls.Add(cboMa);
            groupBox1.Controls.Add(label15);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(label16);
            groupBox1.Controls.Add(txtFax);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(txtWebsite);
            groupBox1.Controls.Add(label14);
            groupBox1.Controls.Add(txtZipcode);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(txtTel);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(txtDAddress);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(txtAddress);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(txtPosition);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(txtContactPersion);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(coutrySelect1);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(btnGenCustNumber);
            groupBox1.Controls.Add(txtCustNumber);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(btnCompanyChange);
            groupBox1.Controls.Add(txtCustAlias);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtCustomerCompany);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            groupBox1.Location = new Point(15, 37);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(593, 595);
            groupBox1.TabIndex = 40;
            groupBox1.TabStop = false;
            groupBox1.Text = "輸入資料";
            // 
            // CustomerMaintainControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox1);
            Controls.Add(button1);
            Controls.Add(lblMode);
            Controls.Add(label1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "CustomerMaintainControl";
            Size = new Size(1066, 646);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblMode;
        private Button button1;
        private Label label2;
        private TextBox txtCustomerCompany;
        private Label label3;
        private TextBox txtCustAlias;
        private Button btnCompanyChange;
        private Label label4;
        private TextBox txtCustNumber;
        private Button btnGenCustNumber;
        private Label label5;
        private Common.CoutrySelect coutrySelect1;
        private Label label6;
        private Label label7;
        private TextBox txtContactPersion;
        private Label label8;
        private TextBox txtPosition;
        private Label label9;
        private TextBox txtAddress;
        private Label label10;
        private TextBox txtDAddress;
        private Label label12;
        private TextBox txtTel;
        private Label label11;
        private TextBox txtZipcode;
        private Label label14;
        private TextBox txtWebsite;
        private Label label13;
        private TextBox txtFax;
        private Label label16;
        private TextBox txtEmail;
        private Label label15;
        private ComboBox cboMa;
        private ComboBox cboSource;
        private Label label17;
        private ComboBox cboIndustrry;
        private Label label18;
        private TextBox txtColumn1;
        private Common.IndustryCodeSelect industryCodeSelect1;
        private Button btnIndustryCodeManage;
        private Label label19;
        private TextBox txtMachineIssue;
        private Label label20;
        private GroupBox groupBox1;
    }
}
