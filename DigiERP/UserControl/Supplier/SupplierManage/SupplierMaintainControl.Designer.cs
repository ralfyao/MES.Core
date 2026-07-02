namespace DigiERP.UserControl.Supplier.SupplierManage
{
    partial class SupplierMaintainControl
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
            panel1 = new Panel();
            btnModify = new Button();
            btnBack = new Button();
            btnSaveQuotation = new Button();
            btnActivate = new Button();
            btnDeactivate = new Button();
            btnCancelApprove = new Button();
            btnApprove = new Button();
            btnDelete = new Button();
            btnSave = new Button();
            lblMode = new Label();
            panelForm = new Panel();
            chkDisabled = new CheckBox();
            txtR3 = new TextBox();
            lbl個人手機 = new Label();
            txtR2 = new TextBox();
            lbl負責人 = new Label();
            txtR1 = new TextBox();
            lbl廠商特色 = new Label();
            txtRemark = new TextBox();
            lbl備註 = new Label();
            cboGrade = new ComboBox();
            lbl評鑑等級 = new Label();
            txtMgmtClass = new TextBox();
            lbl管理分類 = new Label();
            txtIndustry = new TextBox();
            lbl業別 = new Label();
            txtFax = new TextBox();
            lbl傳真 = new Label();
            txtPhone = new TextBox();
            lbl電話 = new Label();
            txtEmail = new TextBox();
            lbl電郵 = new Label();
            txtMobile = new TextBox();
            lbl手機 = new Label();
            txtTitle = new TextBox();
            lbl職稱 = new Label();
            btnFindContact = new Button();
            txtContact = new TextBox();
            lbl聯絡人 = new Label();
            txtTaxNo = new TextBox();
            lbl統一編號 = new Label();
            txtFactoryAddr = new TextBox();
            lbl工廠地址 = new Label();
            txtCompanyAddr = new TextBox();
            lbl公司地址 = new Label();
            cboCountry = new ComboBox();
            lbl區域國別 = new Label();
            txtSupplierNo = new TextBox();
            lbl廠商編號 = new Label();
            txtName = new TextBox();
            lbl廠商名稱 = new Label();
            txtShortName = new TextBox();
            lbl廠商簡稱 = new Label();
            panelDetail = new Panel();
            dgvQuotation = new DataGridView();
            colQuotDate = new DataGridViewTextBoxColumn();
            colItemNo = new DataGridViewTextBoxColumn();
            colItemName = new DataGridViewTextBoxColumn();
            colUnit = new DataGridViewTextBoxColumn();
            colMinQty = new DataGridViewTextBoxColumn();
            colMaxQty = new DataGridViewTextBoxColumn();
            colPrice = new DataGridViewTextBoxColumn();
            colCurrency = new DataGridViewTextBoxColumn();
            colInquirer = new DataGridViewTextBoxColumn();
            colValidDate = new DataGridViewTextBoxColumn();
            colVendorItemNo = new DataGridViewTextBoxColumn();
            panelQuotHeader = new Panel();
            lblQuotTitle = new Label();
            panelFooter = new Panel();
            txtModifyDate = new TextBox();
            txtModifier = new TextBox();
            lbl修改F = new Label();
            txtCreateDate = new TextBox();
            txtCreator = new TextBox();
            lbl建檔F = new Label();
            txtApproveDate = new TextBox();
            txtApprover = new TextBox();
            lbl核准F = new Label();
            button1 = new Button();
            panel1.SuspendLayout();
            panelForm.SuspendLayout();
            panelDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvQuotation).BeginInit();
            panelQuotHeader.SuspendLayout();
            panelFooter.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 255, 192);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(btnModify);
            panel1.Controls.Add(btnBack);
            panel1.Controls.Add(btnSaveQuotation);
            panel1.Controls.Add(btnActivate);
            panel1.Controls.Add(btnDeactivate);
            panel1.Controls.Add(btnCancelApprove);
            panel1.Controls.Add(btnApprove);
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(btnSave);
            panel1.Controls.Add(lblMode);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1497, 60);
            panel1.TabIndex = 0;
            // 
            // btnModify
            // 
            btnModify.BackColor = Color.Olive;
            btnModify.FlatStyle = FlatStyle.Flat;
            btnModify.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            btnModify.ForeColor = Color.White;
            btnModify.Location = new Point(92, 8);
            btnModify.Name = "btnModify";
            btnModify.Size = new Size(100, 44);
            btnModify.TabIndex = 9;
            btnModify.Text = "修改";
            btnModify.UseVisualStyleBackColor = false;
            btnModify.Click += btnModify_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.DimGray;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(1380, 8);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(100, 44);
            btnBack.TabIndex = 8;
            btnBack.Text = "關閉";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnSaveQuotation
            // 
            btnSaveQuotation.BackColor = Color.SeaGreen;
            btnSaveQuotation.FlatStyle = FlatStyle.Flat;
            btnSaveQuotation.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            btnSaveQuotation.ForeColor = Color.White;
            btnSaveQuotation.Location = new Point(880, 8);
            btnSaveQuotation.Name = "btnSaveQuotation";
            btnSaveQuotation.Size = new Size(130, 44);
            btnSaveQuotation.TabIndex = 7;
            btnSaveQuotation.Text = "供料詢價";
            btnSaveQuotation.UseVisualStyleBackColor = false;
            btnSaveQuotation.Click += btnSaveQuotation_Click;
            // 
            // btnActivate
            // 
            btnActivate.BackColor = Color.Teal;
            btnActivate.FlatStyle = FlatStyle.Flat;
            btnActivate.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            btnActivate.ForeColor = Color.White;
            btnActivate.Location = new Point(606, 8);
            btnActivate.Name = "btnActivate";
            btnActivate.Size = new Size(100, 44);
            btnActivate.TabIndex = 6;
            btnActivate.Text = "取消停用";
            btnActivate.UseVisualStyleBackColor = false;
            btnActivate.Click += btnActivate_Click;
            // 
            // btnDeactivate
            // 
            btnDeactivate.BackColor = Color.DarkOrange;
            btnDeactivate.FlatStyle = FlatStyle.Flat;
            btnDeactivate.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            btnDeactivate.ForeColor = Color.White;
            btnDeactivate.Location = new Point(520, 8);
            btnDeactivate.Name = "btnDeactivate";
            btnDeactivate.Size = new Size(80, 44);
            btnDeactivate.TabIndex = 5;
            btnDeactivate.Text = "停用";
            btnDeactivate.UseVisualStyleBackColor = false;
            btnDeactivate.Click += btnDeactivate_Click;
            // 
            // btnCancelApprove
            // 
            btnCancelApprove.BackColor = Color.SteelBlue;
            btnCancelApprove.FlatStyle = FlatStyle.Flat;
            btnCancelApprove.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            btnCancelApprove.ForeColor = Color.White;
            btnCancelApprove.Location = new Point(404, 8);
            btnCancelApprove.Name = "btnCancelApprove";
            btnCancelApprove.Size = new Size(100, 44);
            btnCancelApprove.TabIndex = 4;
            btnCancelApprove.Text = "取消生效";
            btnCancelApprove.UseVisualStyleBackColor = false;
            btnCancelApprove.Click += btnCancelApprove_Click;
            // 
            // btnApprove
            // 
            btnApprove.BackColor = Color.MediumSeaGreen;
            btnApprove.FlatStyle = FlatStyle.Flat;
            btnApprove.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            btnApprove.ForeColor = Color.White;
            btnApprove.Location = new Point(318, 8);
            btnApprove.Name = "btnApprove";
            btnApprove.Size = new Size(80, 44);
            btnApprove.TabIndex = 3;
            btnApprove.Text = "生效";
            btnApprove.UseVisualStyleBackColor = false;
            btnApprove.Click += btnApprove_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.IndianRed;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(202, 8);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(100, 44);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "刪除記錄";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.CornflowerBlue;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(716, 8);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(100, 44);
            btnSave.TabIndex = 1;
            btnSave.Text = "儲存";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // lblMode
            // 
            lblMode.Font = new Font("微軟正黑體", 14F, FontStyle.Bold);
            lblMode.ForeColor = Color.FromArgb(60, 60, 120);
            lblMode.Location = new Point(8, 14);
            lblMode.Name = "lblMode";
            lblMode.Size = new Size(80, 32);
            lblMode.TabIndex = 0;
            lblMode.Text = "修改";
            lblMode.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panelForm
            // 
            panelForm.BackColor = Color.FromArgb(255, 248, 240);
            panelForm.Controls.Add(chkDisabled);
            panelForm.Controls.Add(txtR3);
            panelForm.Controls.Add(lbl個人手機);
            panelForm.Controls.Add(txtR2);
            panelForm.Controls.Add(lbl負責人);
            panelForm.Controls.Add(txtR1);
            panelForm.Controls.Add(lbl廠商特色);
            panelForm.Controls.Add(txtRemark);
            panelForm.Controls.Add(lbl備註);
            panelForm.Controls.Add(cboGrade);
            panelForm.Controls.Add(lbl評鑑等級);
            panelForm.Controls.Add(txtMgmtClass);
            panelForm.Controls.Add(lbl管理分類);
            panelForm.Controls.Add(txtIndustry);
            panelForm.Controls.Add(lbl業別);
            panelForm.Controls.Add(txtFax);
            panelForm.Controls.Add(lbl傳真);
            panelForm.Controls.Add(txtPhone);
            panelForm.Controls.Add(lbl電話);
            panelForm.Controls.Add(txtEmail);
            panelForm.Controls.Add(lbl電郵);
            panelForm.Controls.Add(txtMobile);
            panelForm.Controls.Add(lbl手機);
            panelForm.Controls.Add(txtTitle);
            panelForm.Controls.Add(lbl職稱);
            panelForm.Controls.Add(btnFindContact);
            panelForm.Controls.Add(txtContact);
            panelForm.Controls.Add(lbl聯絡人);
            panelForm.Controls.Add(txtTaxNo);
            panelForm.Controls.Add(lbl統一編號);
            panelForm.Controls.Add(txtFactoryAddr);
            panelForm.Controls.Add(lbl工廠地址);
            panelForm.Controls.Add(txtCompanyAddr);
            panelForm.Controls.Add(lbl公司地址);
            panelForm.Controls.Add(cboCountry);
            panelForm.Controls.Add(lbl區域國別);
            panelForm.Controls.Add(txtSupplierNo);
            panelForm.Controls.Add(lbl廠商編號);
            panelForm.Controls.Add(txtName);
            panelForm.Controls.Add(lbl廠商名稱);
            panelForm.Controls.Add(txtShortName);
            panelForm.Controls.Add(lbl廠商簡稱);
            panelForm.Dock = DockStyle.Top;
            panelForm.Location = new Point(0, 60);
            panelForm.Name = "panelForm";
            panelForm.Size = new Size(1497, 222);
            panelForm.TabIndex = 1;
            // 
            // chkDisabled
            // 
            chkDisabled.AutoSize = true;
            chkDisabled.Font = new Font("微軟正黑體", 10F);
            chkDisabled.Location = new Point(8, 196);
            chkDisabled.Name = "chkDisabled";
            chkDisabled.Size = new Size(55, 22);
            chkDisabled.TabIndex = 0;
            chkDisabled.Text = "停用";
            // 
            // txtR3
            // 
            txtR3.Font = new Font("微軟正黑體", 10F);
            txtR3.Location = new Point(1216, 156);
            txtR3.Name = "txtR3";
            txtR3.Size = new Size(272, 25);
            txtR3.TabIndex = 1;
            // 
            // lbl個人手機
            // 
            lbl個人手機.AutoSize = true;
            lbl個人手機.Font = new Font("微軟正黑體", 10F);
            lbl個人手機.Location = new Point(1148, 160);
            lbl個人手機.Name = "lbl個人手機";
            lbl個人手機.Size = new Size(64, 18);
            lbl個人手機.TabIndex = 2;
            lbl個人手機.Text = "個人手機";
            // 
            // txtR2
            // 
            txtR2.Font = new Font("微軟正黑體", 10F);
            txtR2.Location = new Point(912, 160);
            txtR2.Name = "txtR2";
            txtR2.Size = new Size(228, 25);
            txtR2.TabIndex = 3;
            // 
            // lbl負責人
            // 
            lbl負責人.AutoSize = true;
            lbl負責人.Font = new Font("微軟正黑體", 10F);
            lbl負責人.Location = new Point(856, 164);
            lbl負責人.Name = "lbl負責人";
            lbl負責人.Size = new Size(50, 18);
            lbl負責人.TabIndex = 4;
            lbl負責人.Text = "負責人";
            // 
            // txtR1
            // 
            txtR1.Font = new Font("微軟正黑體", 10F);
            txtR1.Location = new Point(536, 164);
            txtR1.Name = "txtR1";
            txtR1.Size = new Size(276, 25);
            txtR1.TabIndex = 5;
            // 
            // lbl廠商特色
            // 
            lbl廠商特色.AutoSize = true;
            lbl廠商特色.Font = new Font("微軟正黑體", 10F);
            lbl廠商特色.Location = new Point(464, 168);
            lbl廠商特色.Name = "lbl廠商特色";
            lbl廠商特色.Size = new Size(64, 18);
            lbl廠商特色.TabIndex = 6;
            lbl廠商特色.Text = "廠商特色";
            // 
            // txtRemark
            // 
            txtRemark.Font = new Font("微軟正黑體", 10F);
            txtRemark.Location = new Point(80, 164);
            txtRemark.Name = "txtRemark";
            txtRemark.Size = new Size(352, 25);
            txtRemark.TabIndex = 7;
            // 
            // lbl備註
            // 
            lbl備註.AutoSize = true;
            lbl備註.Font = new Font("微軟正黑體", 10F);
            lbl備註.Location = new Point(8, 166);
            lbl備註.Name = "lbl備註";
            lbl備註.Size = new Size(36, 18);
            lbl備註.TabIndex = 8;
            lbl備註.Text = "備註";
            // 
            // cboGrade
            // 
            cboGrade.DropDownStyle = ComboBoxStyle.DropDownList;
            cboGrade.Font = new Font("微軟正黑體", 10F);
            cboGrade.Location = new Point(1218, 120);
            cboGrade.Name = "cboGrade";
            cboGrade.Size = new Size(270, 25);
            cboGrade.TabIndex = 9;
            // 
            // lbl評鑑等級
            // 
            lbl評鑑等級.AutoSize = true;
            lbl評鑑等級.Font = new Font("微軟正黑體", 10F);
            lbl評鑑等級.Location = new Point(1148, 124);
            lbl評鑑等級.Name = "lbl評鑑等級";
            lbl評鑑等級.Size = new Size(64, 18);
            lbl評鑑等級.TabIndex = 10;
            lbl評鑑等級.Text = "評鑑等級";
            // 
            // txtMgmtClass
            // 
            txtMgmtClass.Font = new Font("微軟正黑體", 10F);
            txtMgmtClass.Location = new Point(912, 124);
            txtMgmtClass.Name = "txtMgmtClass";
            txtMgmtClass.Size = new Size(228, 25);
            txtMgmtClass.TabIndex = 11;
            // 
            // lbl管理分類
            // 
            lbl管理分類.AutoSize = true;
            lbl管理分類.Font = new Font("微軟正黑體", 10F);
            lbl管理分類.Location = new Point(848, 128);
            lbl管理分類.Name = "lbl管理分類";
            lbl管理分類.Size = new Size(64, 18);
            lbl管理分類.TabIndex = 12;
            lbl管理分類.Text = "管理分類";
            // 
            // txtIndustry
            // 
            txtIndustry.Font = new Font("微軟正黑體", 10F);
            txtIndustry.Location = new Point(688, 124);
            txtIndustry.Name = "txtIndustry";
            txtIndustry.Size = new Size(130, 25);
            txtIndustry.TabIndex = 13;
            // 
            // lbl業別
            // 
            lbl業別.AutoSize = true;
            lbl業別.Font = new Font("微軟正黑體", 10F);
            lbl業別.Location = new Point(620, 128);
            lbl業別.Name = "lbl業別";
            lbl業別.Size = new Size(64, 18);
            lbl業別.TabIndex = 14;
            lbl業別.Text = "所屬業別";
            // 
            // txtFax
            // 
            txtFax.Font = new Font("微軟正黑體", 10F);
            txtFax.Location = new Point(440, 124);
            txtFax.Name = "txtFax";
            txtFax.Size = new Size(160, 25);
            txtFax.TabIndex = 15;
            // 
            // lbl傳真
            // 
            lbl傳真.AutoSize = true;
            lbl傳真.Font = new Font("微軟正黑體", 10F);
            lbl傳真.Location = new Point(404, 128);
            lbl傳真.Name = "lbl傳真";
            lbl傳真.Size = new Size(36, 18);
            lbl傳真.TabIndex = 16;
            lbl傳真.Text = "傳真";
            // 
            // txtPhone
            // 
            txtPhone.Font = new Font("微軟正黑體", 10F);
            txtPhone.Location = new Point(76, 124);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(312, 25);
            txtPhone.TabIndex = 17;
            // 
            // lbl電話
            // 
            lbl電話.AutoSize = true;
            lbl電話.Font = new Font("微軟正黑體", 10F);
            lbl電話.Location = new Point(8, 128);
            lbl電話.Name = "lbl電話";
            lbl電話.Size = new Size(36, 18);
            lbl電話.TabIndex = 18;
            lbl電話.Text = "電話";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("微軟正黑體", 10F);
            txtEmail.Location = new Point(1220, 84);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(270, 25);
            txtEmail.TabIndex = 19;
            // 
            // lbl電郵
            // 
            lbl電郵.AutoSize = true;
            lbl電郵.Font = new Font("微軟正黑體", 10F);
            lbl電郵.Location = new Point(1152, 88);
            lbl電郵.Name = "lbl電郵";
            lbl電郵.Size = new Size(64, 18);
            lbl電郵.TabIndex = 20;
            lbl電郵.Text = "電郵信箱";
            // 
            // txtMobile
            // 
            txtMobile.Font = new Font("微軟正黑體", 10F);
            txtMobile.Location = new Point(916, 84);
            txtMobile.Name = "txtMobile";
            txtMobile.Size = new Size(224, 25);
            txtMobile.TabIndex = 21;
            // 
            // lbl手機
            // 
            lbl手機.AutoSize = true;
            lbl手機.Font = new Font("微軟正黑體", 10F);
            lbl手機.Location = new Point(848, 88);
            lbl手機.Name = "lbl手機";
            lbl手機.Size = new Size(64, 18);
            lbl手機.TabIndex = 22;
            lbl手機.Text = "聯絡手機";
            // 
            // txtTitle
            // 
            txtTitle.Font = new Font("微軟正黑體", 10F);
            txtTitle.Location = new Point(536, 84);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(284, 25);
            txtTitle.TabIndex = 23;
            // 
            // lbl職稱
            // 
            lbl職稱.AutoSize = true;
            lbl職稱.Font = new Font("微軟正黑體", 10F);
            lbl職稱.Location = new Point(500, 88);
            lbl職稱.Name = "lbl職稱";
            lbl職稱.Size = new Size(36, 18);
            lbl職稱.TabIndex = 24;
            lbl職稱.Text = "職稱";
            // 
            // btnFindContact
            // 
            btnFindContact.FlatStyle = FlatStyle.Flat;
            btnFindContact.Font = new Font("Segoe MDL2 Assets", 10F);
            btnFindContact.Location = new Point(440, 84);
            btnFindContact.Name = "btnFindContact";
            btnFindContact.Size = new Size(28, 25);
            btnFindContact.TabIndex = 99;
            btnFindContact.Text = "";
            btnFindContact.UseVisualStyleBackColor = true;
            btnFindContact.Click += btnFindContact_Click;
            // 
            // txtContact
            // 
            txtContact.Font = new Font("微軟正黑體", 10F);
            txtContact.Location = new Point(80, 84);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(356, 25);
            txtContact.TabIndex = 100;
            // 
            // lbl聯絡人
            // 
            lbl聯絡人.AutoSize = true;
            lbl聯絡人.Font = new Font("微軟正黑體", 10F);
            lbl聯絡人.Location = new Point(8, 90);
            lbl聯絡人.Name = "lbl聯絡人";
            lbl聯絡人.Size = new Size(50, 18);
            lbl聯絡人.TabIndex = 101;
            lbl聯絡人.Text = "聯絡人";
            // 
            // txtTaxNo
            // 
            txtTaxNo.Font = new Font("微軟正黑體", 10F);
            txtTaxNo.Location = new Point(1296, 48);
            txtTaxNo.Name = "txtTaxNo";
            txtTaxNo.Size = new Size(160, 25);
            txtTaxNo.TabIndex = 102;
            // 
            // lbl統一編號
            // 
            lbl統一編號.AutoSize = true;
            lbl統一編號.Font = new Font("微軟正黑體", 10F);
            lbl統一編號.Location = new Point(1224, 52);
            lbl統一編號.Name = "lbl統一編號";
            lbl統一編號.Size = new Size(64, 18);
            lbl統一編號.TabIndex = 103;
            lbl統一編號.Text = "統一編號";
            // 
            // txtFactoryAddr
            // 
            txtFactoryAddr.Font = new Font("微軟正黑體", 10F);
            txtFactoryAddr.Location = new Point(568, 48);
            txtFactoryAddr.Name = "txtFactoryAddr";
            txtFactoryAddr.Size = new Size(652, 25);
            txtFactoryAddr.TabIndex = 104;
            // 
            // lbl工廠地址
            // 
            lbl工廠地址.AutoSize = true;
            lbl工廠地址.Font = new Font("微軟正黑體", 10F);
            lbl工廠地址.Location = new Point(488, 52);
            lbl工廠地址.Name = "lbl工廠地址";
            lbl工廠地址.Size = new Size(64, 18);
            lbl工廠地址.TabIndex = 105;
            lbl工廠地址.Text = "工廠地址";
            // 
            // txtCompanyAddr
            // 
            txtCompanyAddr.Font = new Font("微軟正黑體", 10F);
            txtCompanyAddr.Location = new Point(80, 48);
            txtCompanyAddr.Name = "txtCompanyAddr";
            txtCompanyAddr.Size = new Size(396, 25);
            txtCompanyAddr.TabIndex = 106;
            // 
            // lbl公司地址
            // 
            lbl公司地址.AutoSize = true;
            lbl公司地址.Font = new Font("微軟正黑體", 10F);
            lbl公司地址.Location = new Point(8, 52);
            lbl公司地址.Name = "lbl公司地址";
            lbl公司地址.Size = new Size(64, 18);
            lbl公司地址.TabIndex = 107;
            lbl公司地址.Text = "公司地址";
            // 
            // cboCountry
            // 
            cboCountry.Font = new Font("微軟正黑體", 10F);
            cboCountry.Location = new Point(1296, 8);
            cboCountry.Name = "cboCountry";
            cboCountry.Size = new Size(192, 25);
            cboCountry.TabIndex = 108;
            // 
            // lbl區域國別
            // 
            lbl區域國別.AutoSize = true;
            lbl區域國別.Font = new Font("微軟正黑體", 10F);
            lbl區域國別.Location = new Point(1224, 12);
            lbl區域國別.Name = "lbl區域國別";
            lbl區域國別.Size = new Size(64, 18);
            lbl區域國別.TabIndex = 109;
            lbl區域國別.Text = "區域國別";
            // 
            // txtSupplierNo
            // 
            txtSupplierNo.BackColor = Color.WhiteSmoke;
            txtSupplierNo.Font = new Font("微軟正黑體", 10F);
            txtSupplierNo.Location = new Point(308, 8);
            txtSupplierNo.Name = "txtSupplierNo";
            txtSupplierNo.Size = new Size(168, 25);
            txtSupplierNo.TabIndex = 110;
            // 
            // lbl廠商編號
            // 
            lbl廠商編號.AutoSize = true;
            lbl廠商編號.Font = new Font("微軟正黑體", 10F);
            lbl廠商編號.Location = new Point(228, 12);
            lbl廠商編號.Name = "lbl廠商編號";
            lbl廠商編號.Size = new Size(64, 18);
            lbl廠商編號.TabIndex = 111;
            lbl廠商編號.Text = "廠商編號";
            // 
            // txtName
            // 
            txtName.Font = new Font("微軟正黑體", 10F);
            txtName.Location = new Point(568, 8);
            txtName.Name = "txtName";
            txtName.Size = new Size(652, 25);
            txtName.TabIndex = 112;
            // 
            // lbl廠商名稱
            // 
            lbl廠商名稱.AutoSize = true;
            lbl廠商名稱.Font = new Font("微軟正黑體", 10F);
            lbl廠商名稱.Location = new Point(488, 12);
            lbl廠商名稱.Name = "lbl廠商名稱";
            lbl廠商名稱.Size = new Size(64, 18);
            lbl廠商名稱.TabIndex = 113;
            lbl廠商名稱.Text = "廠商名稱";
            // 
            // txtShortName
            // 
            txtShortName.Font = new Font("微軟正黑體", 10F);
            txtShortName.Location = new Point(80, 10);
            txtShortName.Name = "txtShortName";
            txtShortName.Size = new Size(130, 25);
            txtShortName.TabIndex = 114;
            // 
            // lbl廠商簡稱
            // 
            lbl廠商簡稱.AutoSize = true;
            lbl廠商簡稱.Font = new Font("微軟正黑體", 10F);
            lbl廠商簡稱.Location = new Point(8, 14);
            lbl廠商簡稱.Name = "lbl廠商簡稱";
            lbl廠商簡稱.Size = new Size(64, 18);
            lbl廠商簡稱.TabIndex = 115;
            lbl廠商簡稱.Text = "廠商簡稱";
            // 
            // panelDetail
            // 
            panelDetail.Controls.Add(dgvQuotation);
            panelDetail.Controls.Add(panelQuotHeader);
            panelDetail.Dock = DockStyle.Fill;
            panelDetail.Location = new Point(0, 282);
            panelDetail.Name = "panelDetail";
            panelDetail.Size = new Size(1497, 450);
            panelDetail.TabIndex = 2;
            // 
            // dgvQuotation
            // 
            dgvQuotation.AllowUserToAddRows = false;
            dgvQuotation.AllowUserToDeleteRows = false;
            dgvQuotation.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvQuotation.BackgroundColor = Color.White;
            dgvQuotation.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvQuotation.Columns.AddRange(new DataGridViewColumn[] { colQuotDate, colItemNo, colItemName, colUnit, colMinQty, colMaxQty, colPrice, colCurrency, colInquirer, colValidDate, colVendorItemNo });
            dgvQuotation.Dock = DockStyle.Fill;
            dgvQuotation.Font = new Font("微軟正黑體", 10F);
            dgvQuotation.Location = new Point(0, 30);
            dgvQuotation.Name = "dgvQuotation";
            dgvQuotation.RowHeadersVisible = false;
            dgvQuotation.RowTemplate.Height = 26;
            dgvQuotation.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvQuotation.Size = new Size(1497, 420);
            dgvQuotation.TabIndex = 1;
            // 
            // colQuotDate
            // 
            colQuotDate.FillWeight = 70F;
            colQuotDate.HeaderText = "詢價日期";
            colQuotDate.Name = "colQuotDate";
            // 
            // colItemNo
            // 
            colItemNo.FillWeight = 70F;
            colItemNo.HeaderText = "品項編號";
            colItemNo.Name = "colItemNo";
            // 
            // colItemName
            // 
            colItemName.FillWeight = 150F;
            colItemName.HeaderText = "品名規格";
            colItemName.Name = "colItemName";
            colItemName.ReadOnly = true;
            // 
            // colUnit
            // 
            colUnit.FillWeight = 55F;
            colUnit.HeaderText = "採購單位";
            colUnit.Name = "colUnit";
            // 
            // colMinQty
            // 
            colMinQty.FillWeight = 65F;
            colMinQty.HeaderText = "最低採購量";
            colMinQty.Name = "colMinQty";
            // 
            // colMaxQty
            // 
            colMaxQty.FillWeight = 65F;
            colMaxQty.HeaderText = "最大採購量";
            colMaxQty.Name = "colMaxQty";
            // 
            // colPrice
            // 
            colPrice.FillWeight = 65F;
            colPrice.HeaderText = "單價";
            colPrice.Name = "colPrice";
            // 
            // colCurrency
            // 
            colCurrency.FillWeight = 45F;
            colCurrency.HeaderText = "幣別";
            colCurrency.Name = "colCurrency";
            // 
            // colInquirer
            // 
            colInquirer.FillWeight = 70F;
            colInquirer.HeaderText = "詢價人員";
            colInquirer.Name = "colInquirer";
            // 
            // colValidDate
            // 
            colValidDate.FillWeight = 80F;
            colValidDate.HeaderText = "報價有效日期";
            colValidDate.Name = "colValidDate";
            // 
            // colVendorItemNo
            // 
            colVendorItemNo.HeaderText = "廠商品號";
            colVendorItemNo.Name = "colVendorItemNo";
            // 
            // panelQuotHeader
            // 
            panelQuotHeader.BackColor = Color.FromArgb(40, 100, 160);
            panelQuotHeader.Controls.Add(lblQuotTitle);
            panelQuotHeader.Dock = DockStyle.Top;
            panelQuotHeader.Location = new Point(0, 0);
            panelQuotHeader.Name = "panelQuotHeader";
            panelQuotHeader.Size = new Size(1497, 30);
            panelQuotHeader.TabIndex = 0;
            // 
            // lblQuotTitle
            // 
            lblQuotTitle.AutoSize = true;
            lblQuotTitle.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            lblQuotTitle.ForeColor = Color.White;
            lblQuotTitle.Location = new Point(8, 6);
            lblQuotTitle.Name = "lblQuotTitle";
            lblQuotTitle.Size = new Size(120, 18);
            lblQuotTitle.TabIndex = 0;
            lblQuotTitle.Text = "供料詢價明細記錄";
            // 
            // panelFooter
            // 
            panelFooter.BackColor = Color.FromArgb(230, 230, 250);
            panelFooter.Controls.Add(txtModifyDate);
            panelFooter.Controls.Add(txtModifier);
            panelFooter.Controls.Add(lbl修改F);
            panelFooter.Controls.Add(txtCreateDate);
            panelFooter.Controls.Add(txtCreator);
            panelFooter.Controls.Add(lbl建檔F);
            panelFooter.Controls.Add(txtApproveDate);
            panelFooter.Controls.Add(txtApprover);
            panelFooter.Controls.Add(lbl核准F);
            panelFooter.Dock = DockStyle.Bottom;
            panelFooter.Location = new Point(0, 732);
            panelFooter.Name = "panelFooter";
            panelFooter.Size = new Size(1497, 32);
            panelFooter.TabIndex = 3;
            // 
            // txtModifyDate
            // 
            txtModifyDate.BackColor = Color.WhiteSmoke;
            txtModifyDate.Font = new Font("微軟正黑體", 9F);
            txtModifyDate.Location = new Point(696, 5);
            txtModifyDate.Name = "txtModifyDate";
            txtModifyDate.ReadOnly = true;
            txtModifyDate.Size = new Size(110, 23);
            txtModifyDate.TabIndex = 0;
            // 
            // txtModifier
            // 
            txtModifier.BackColor = Color.WhiteSmoke;
            txtModifier.Font = new Font("微軟正黑體", 9F);
            txtModifier.Location = new Point(582, 5);
            txtModifier.Name = "txtModifier";
            txtModifier.ReadOnly = true;
            txtModifier.Size = new Size(110, 23);
            txtModifier.TabIndex = 1;
            // 
            // lbl修改F
            // 
            lbl修改F.AutoSize = true;
            lbl修改F.Font = new Font("微軟正黑體", 9F);
            lbl修改F.Location = new Point(548, 8);
            lbl修改F.Name = "lbl修改F";
            lbl修改F.Size = new Size(31, 16);
            lbl修改F.TabIndex = 2;
            lbl修改F.Text = "修改";
            // 
            // txtCreateDate
            // 
            txtCreateDate.BackColor = Color.WhiteSmoke;
            txtCreateDate.Font = new Font("微軟正黑體", 9F);
            txtCreateDate.Location = new Point(428, 5);
            txtCreateDate.Name = "txtCreateDate";
            txtCreateDate.ReadOnly = true;
            txtCreateDate.Size = new Size(110, 23);
            txtCreateDate.TabIndex = 3;
            // 
            // txtCreator
            // 
            txtCreator.BackColor = Color.WhiteSmoke;
            txtCreator.Font = new Font("微軟正黑體", 9F);
            txtCreator.Location = new Point(314, 5);
            txtCreator.Name = "txtCreator";
            txtCreator.ReadOnly = true;
            txtCreator.Size = new Size(110, 23);
            txtCreator.TabIndex = 4;
            // 
            // lbl建檔F
            // 
            lbl建檔F.AutoSize = true;
            lbl建檔F.Font = new Font("微軟正黑體", 9F);
            lbl建檔F.Location = new Point(280, 8);
            lbl建檔F.Name = "lbl建檔F";
            lbl建檔F.Size = new Size(31, 16);
            lbl建檔F.TabIndex = 5;
            lbl建檔F.Text = "建檔";
            // 
            // txtApproveDate
            // 
            txtApproveDate.BackColor = Color.WhiteSmoke;
            txtApproveDate.Font = new Font("微軟正黑體", 9F);
            txtApproveDate.Location = new Point(156, 5);
            txtApproveDate.Name = "txtApproveDate";
            txtApproveDate.ReadOnly = true;
            txtApproveDate.Size = new Size(110, 23);
            txtApproveDate.TabIndex = 6;
            // 
            // txtApprover
            // 
            txtApprover.BackColor = Color.WhiteSmoke;
            txtApprover.Font = new Font("微軟正黑體", 9F);
            txtApprover.Location = new Point(42, 5);
            txtApprover.Name = "txtApprover";
            txtApprover.ReadOnly = true;
            txtApprover.Size = new Size(110, 23);
            txtApprover.TabIndex = 7;
            // 
            // lbl核准F
            // 
            lbl核准F.AutoSize = true;
            lbl核准F.Font = new Font("微軟正黑體", 9F);
            lbl核准F.Location = new Point(8, 8);
            lbl核准F.Name = "lbl核准F";
            lbl核准F.Size = new Size(31, 16);
            lbl核准F.TabIndex = 8;
            lbl核准F.Text = "核准";
            // 
            // button1
            // 
            button1.BackColor = Color.SandyBrown;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(1020, 8);
            button1.Name = "button1";
            button1.Size = new Size(100, 44);
            button1.TabIndex = 10;
            button1.Text = "廠商評鑑";
            button1.UseVisualStyleBackColor = false;
            // 
            // SupplierMaintainControl
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelDetail);
            Controls.Add(panelFooter);
            Controls.Add(panelForm);
            Controls.Add(panel1);
            Font = new Font("微軟正黑體", 10F);
            Margin = new Padding(4);
            Name = "SupplierMaintainControl";
            Size = new Size(1497, 764);
            panel1.ResumeLayout(false);
            panelForm.ResumeLayout(false);
            panelForm.PerformLayout();
            panelDetail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvQuotation).EndInit();
            panelQuotHeader.ResumeLayout(false);
            panelQuotHeader.PerformLayout();
            panelFooter.ResumeLayout(false);
            panelFooter.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel   panel1;
        private Label   lblMode;
        private Button  btnSave;
        private Button  btnDelete;
        private Button  btnApprove;
        private Button  btnCancelApprove;
        private Button  btnDeactivate;
        private Button  btnActivate;
        private Button  btnSaveQuotation;
        private Button  btnBack;
        private Panel   panelForm;
        private Label   lbl廠商簡稱;
        private TextBox txtShortName;
        private Label   lbl廠商名稱;
        private TextBox txtName;
        private Label   lbl廠商編號;
        private TextBox txtSupplierNo;
        private Label   lbl區域國別;
        private ComboBox cboCountry;
        private Label   lbl公司地址;
        private TextBox txtCompanyAddr;
        private Label   lbl工廠地址;
        private TextBox txtFactoryAddr;
        private Label   lbl統一編號;
        private TextBox txtTaxNo;
        private Label   lbl聯絡人;
        private TextBox txtContact;
        private Button  btnFindContact;
        private Label   lbl職稱;
        private TextBox txtTitle;
        private Label   lbl手機;
        private TextBox txtMobile;
        private Label   lbl電郵;
        private TextBox txtEmail;
        private Label   lbl電話;
        private TextBox txtPhone;
        private Label   lbl傳真;
        private TextBox txtFax;
        private Label   lbl業別;
        private TextBox txtIndustry;
        private Label   lbl管理分類;
        private TextBox txtMgmtClass;
        private Label   lbl評鑑等級;
        private ComboBox cboGrade;
        private Label   lbl備註;
        private TextBox txtRemark;
        private Label   lbl廠商特色;
        private TextBox txtR1;
        private Label   lbl負責人;
        private TextBox txtR2;
        private Label   lbl個人手機;
        private TextBox txtR3;
        private CheckBox chkDisabled;
        private Panel   panelDetail;
        private Panel   panelQuotHeader;
        private Label   lblQuotTitle;
        private DataGridView dgvQuotation;
        private DataGridViewTextBoxColumn colQuotDate;
        private DataGridViewTextBoxColumn colItemNo;
        private DataGridViewTextBoxColumn colItemName;
        private DataGridViewTextBoxColumn colUnit;
        private DataGridViewTextBoxColumn colMinQty;
        private DataGridViewTextBoxColumn colMaxQty;
        private DataGridViewTextBoxColumn colPrice;
        private DataGridViewTextBoxColumn colCurrency;
        private DataGridViewTextBoxColumn colInquirer;
        private DataGridViewTextBoxColumn colValidDate;
        private DataGridViewTextBoxColumn colVendorItemNo;
        private Panel   panelFooter;
        private Label   lbl核准F;
        private TextBox txtApprover;
        private TextBox txtApproveDate;
        private Label   lbl建檔F;
        private TextBox txtCreator;
        private TextBox txtCreateDate;
        private Label   lbl修改F;
        private TextBox txtModifier;
        private TextBox txtModifyDate;
        private Button btnModify;
        private Button button1;
    }
}
