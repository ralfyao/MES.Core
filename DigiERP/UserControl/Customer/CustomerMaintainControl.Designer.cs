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
            groupBox1 = new GroupBox();
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
            industryCodeSelect1 = new Common.IndustryCodeSelect();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label1.Location = new Point(72, 8);
            label1.Name = "label1";
            label1.Size = new Size(71, 36);
            label1.TabIndex = 0;
            label1.Text = "客戶";
            // 
            // lblMode
            // 
            lblMode.AutoSize = true;
            lblMode.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            lblMode.Location = new Point(8, 8);
            lblMode.Name = "lblMode";
            lblMode.Size = new Size(126, 36);
            lblMode.TabIndex = 1;
            lblMode.Text = "lblMode";
            // 
            // button1
            // 
            button1.Location = new Point(1640, 0);
            button1.Name = "button1";
            button1.Size = new Size(32, 34);
            button1.TabIndex = 2;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // groupBox1
            // 
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
            groupBox1.Location = new Point(24, 56);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(872, 848);
            groupBox1.TabIndex = 40;
            groupBox1.TabStop = false;
            groupBox1.Text = "輸入資料";
            // 
            // txtColumn1
            // 
            txtColumn1.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            txtColumn1.Location = new Point(576, 560);
            txtColumn1.Name = "txtColumn1";
            txtColumn1.Size = new Size(272, 43);
            txtColumn1.TabIndex = 75;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label18.Location = new Point(448, 560);
            label18.Name = "label18";
            label18.Size = new Size(127, 36);
            label18.TabIndex = 74;
            label18.Text = "終端使用";
            // 
            // cboIndustrry
            // 
            cboIndustrry.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            cboIndustrry.FormattingEnabled = true;
            cboIndustrry.Items.AddRange(new object[] { "Manufacturer", "Trader", "Agent" });
            cboIndustrry.Location = new Point(128, 560);
            cboIndustrry.Name = "cboIndustrry";
            cboIndustrry.Size = new Size(312, 44);
            cboIndustrry.TabIndex = 73;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label17.Location = new Point(-16, 560);
            label17.Name = "label17";
            label17.Size = new Size(127, 36);
            label17.TabIndex = 72;
            label17.Text = "配合代理";
            // 
            // cboSource
            // 
            cboSource.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            cboSource.FormattingEnabled = true;
            cboSource.Items.AddRange(new object[] { "社群軟體", "非代理/朋友", "搜尋引擎", "公司官網詢問函", "代理轉介", "展覽認識", "自主開發" });
            cboSource.Location = new Point(576, 160);
            cboSource.Name = "cboSource";
            cboSource.Size = new Size(264, 44);
            cboSource.TabIndex = 71;
            // 
            // cboMa
            // 
            cboMa.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            cboMa.FormattingEnabled = true;
            cboMa.Items.AddRange(new object[] { "Manufacturer", "Trader", "Agent" });
            cboMa.Location = new Point(576, 504);
            cboMa.Name = "cboMa";
            cboMa.Size = new Size(264, 44);
            cboMa.TabIndex = 70;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label15.Location = new Point(448, 504);
            label15.Name = "label15";
            label15.Size = new Size(127, 36);
            label15.TabIndex = 69;
            label15.Text = "型態分類";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            txtEmail.Location = new Point(128, 503);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(312, 43);
            txtEmail.TabIndex = 68;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label16.Location = new Point(32, 511);
            label16.Name = "label16";
            label16.Size = new Size(71, 36);
            label16.TabIndex = 67;
            label16.Text = "電郵";
            // 
            // txtFax
            // 
            txtFax.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            txtFax.Location = new Point(576, 446);
            txtFax.Name = "txtFax";
            txtFax.Size = new Size(272, 43);
            txtFax.TabIndex = 66;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label13.Location = new Point(496, 448);
            label13.Name = "label13";
            label13.Size = new Size(71, 36);
            label13.TabIndex = 65;
            label13.Text = "傳真";
            // 
            // txtWebsite
            // 
            txtWebsite.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            txtWebsite.Location = new Point(128, 446);
            txtWebsite.Name = "txtWebsite";
            txtWebsite.Size = new Size(312, 43);
            txtWebsite.TabIndex = 64;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label14.Location = new Point(32, 454);
            label14.Name = "label14";
            label14.Size = new Size(71, 36);
            label14.TabIndex = 63;
            label14.Text = "網址";
            // 
            // txtZipcode
            // 
            txtZipcode.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            txtZipcode.Location = new Point(576, 389);
            txtZipcode.Name = "txtZipcode";
            txtZipcode.Size = new Size(272, 43);
            txtZipcode.TabIndex = 62;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label11.Location = new Point(496, 392);
            label11.Name = "label11";
            label11.Size = new Size(71, 36);
            label11.TabIndex = 61;
            label11.Text = "手機";
            // 
            // txtTel
            // 
            txtTel.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            txtTel.Location = new Point(128, 389);
            txtTel.Name = "txtTel";
            txtTel.Size = new Size(312, 43);
            txtTel.TabIndex = 60;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label12.Location = new Point(32, 397);
            label12.Name = "label12";
            label12.Size = new Size(71, 36);
            label12.TabIndex = 59;
            label12.Text = "電話";
            // 
            // txtDAddress
            // 
            txtDAddress.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            txtDAddress.Location = new Point(128, 330);
            txtDAddress.Name = "txtDAddress";
            txtDAddress.Size = new Size(728, 43);
            txtDAddress.TabIndex = 58;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label10.Location = new Point(-16, 338);
            label10.Name = "label10";
            label10.Size = new Size(127, 36);
            label10.TabIndex = 57;
            label10.Text = "寄件地址";
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            txtAddress.Location = new Point(128, 272);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(728, 43);
            txtAddress.TabIndex = 56;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label9.Location = new Point(-16, 280);
            label9.Name = "label9";
            label9.Size = new Size(127, 36);
            label9.TabIndex = 55;
            label9.Text = "營業地址";
            // 
            // txtPosition
            // 
            txtPosition.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            txtPosition.Location = new Point(576, 216);
            txtPosition.Name = "txtPosition";
            txtPosition.Size = new Size(272, 43);
            txtPosition.TabIndex = 54;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label8.Location = new Point(488, 224);
            label8.Name = "label8";
            label8.Size = new Size(71, 36);
            label8.TabIndex = 53;
            label8.Text = "職位";
            // 
            // txtContactPersion
            // 
            txtContactPersion.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            txtContactPersion.Location = new Point(128, 216);
            txtContactPersion.Name = "txtContactPersion";
            txtContactPersion.Size = new Size(312, 43);
            txtContactPersion.TabIndex = 52;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label7.Location = new Point(16, 224);
            label7.Name = "label7";
            label7.Size = new Size(99, 36);
            label7.TabIndex = 51;
            label7.Text = "聯絡人";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label6.Location = new Point(448, 160);
            label6.Name = "label6";
            label6.Size = new Size(127, 36);
            label6.TabIndex = 50;
            label6.Text = "開發來源";
            // 
            // coutrySelect1
            // 
            coutrySelect1.Location = new Point(185, 238);
            coutrySelect1.Margin = new Padding(5);
            coutrySelect1.Name = "coutrySelect1";
            coutrySelect1.Size = new Size(495, 88);
            coutrySelect1.TabIndex = 49;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label5.Location = new Point(48, 168);
            label5.Name = "label5";
            label5.Size = new Size(71, 36);
            label5.TabIndex = 48;
            label5.Text = "國別";
            // 
            // btnGenCustNumber
            // 
            btnGenCustNumber.Location = new Point(752, 104);
            btnGenCustNumber.Name = "btnGenCustNumber";
            btnGenCustNumber.Size = new Size(112, 48);
            btnGenCustNumber.TabIndex = 47;
            btnGenCustNumber.Text = "取號";
            btnGenCustNumber.UseVisualStyleBackColor = true;
            // 
            // txtCustNumber
            // 
            txtCustNumber.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            txtCustNumber.Location = new Point(576, 104);
            txtCustNumber.Name = "txtCustNumber";
            txtCustNumber.ReadOnly = true;
            txtCustNumber.Size = new Size(168, 43);
            txtCustNumber.TabIndex = 46;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label4.Location = new Point(448, 104);
            label4.Name = "label4";
            label4.Size = new Size(127, 36);
            label4.TabIndex = 45;
            label4.Text = "客戶編號";
            // 
            // btnCompanyChange
            // 
            btnCompanyChange.Location = new Point(304, 104);
            btnCompanyChange.Name = "btnCompanyChange";
            btnCompanyChange.Size = new Size(136, 48);
            btnCompanyChange.TabIndex = 44;
            btnCompanyChange.Text = "全稱更名";
            btnCompanyChange.UseVisualStyleBackColor = true;
            // 
            // txtCustAlias
            // 
            txtCustAlias.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            txtCustAlias.Location = new Point(128, 104);
            txtCustAlias.Name = "txtCustAlias";
            txtCustAlias.Size = new Size(168, 43);
            txtCustAlias.TabIndex = 43;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label3.Location = new Point(0, 104);
            label3.Name = "label3";
            label3.Size = new Size(127, 36);
            label3.TabIndex = 42;
            label3.Text = "客戶簡稱";
            // 
            // txtCustomerCompany
            // 
            txtCustomerCompany.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            txtCustomerCompany.Location = new Point(128, 45);
            txtCustomerCompany.Name = "txtCustomerCompany";
            txtCustomerCompany.Size = new Size(728, 43);
            txtCustomerCompany.TabIndex = 41;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label2.Location = new Point(0, 53);
            label2.Name = "label2";
            label2.Size = new Size(127, 36);
            label2.TabIndex = 40;
            label2.Text = "客戶全稱";
            // 
            // industryCodeSelect1
            // 
            industryCodeSelect1.Location = new Point(112, 608);
            industryCodeSelect1.Name = "industryCodeSelect1";
            industryCodeSelect1.Size = new Size(512, 56);
            industryCodeSelect1.TabIndex = 76;
            // 
            // CustomerMaintainControl
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox1);
            Controls.Add(button1);
            Controls.Add(lblMode);
            Controls.Add(label1);
            Name = "CustomerMaintainControl";
            Size = new Size(1675, 918);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblMode;
        private Button button1;
        private GroupBox groupBox1;
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
        private Common.IndustryCodeSelect industryCodeSelect1;
    }
}
