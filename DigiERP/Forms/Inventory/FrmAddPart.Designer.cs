namespace DigiERP.Forms.Inventory
{
    partial class FrmAddPart
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            panelToolbar = new Panel();
            lblTitle = new Label();
            btnDisableManage = new Button();
            btnDelete = new Button();
            btnAdd = new Button();
            btnModify = new Button();
            btnSave = new Button();
            btnApprove = new Button();
            btnCancelApprove = new Button();
            panelDetail = new Panel();
            lblItemNo = new Label();
            txtItemNo = new TextBox();
            lblName = new Label();
            txtName = new TextBox();
            chkDisabled = new CheckBox();
            lblType = new Label();
            cboType = new ComboBox();
            lblEnglishName = new Label();
            txtEnglishName = new TextBox();
            lblCategory = new Label();
            txtCategory = new TextBox();
            btnPickCategory = new Button();
            lblStockUnit = new Label();
            txtStockUnit = new TextBox();
            lblLength = new Label();
            numLength = new NumericUpDown();
            lblSubCategory = new Label();
            cboSubCategory = new ComboBox();
            lblPurchaseUnit = new Label();
            txtPurchaseUnit = new TextBox();
            lblWidth = new Label();
            txtWidth = new TextBox();
            lblSourceAttr = new Label();
            cboSourceAttr = new ComboBox();
            lblPurchaseFactor = new Label();
            numPurchaseFactor = new NumericUpDown();
            lblThickness = new Label();
            numThickness = new NumericUpDown();
            lblMaterialCode = new Label();
            txtMaterialCode = new TextBox();
            lblSalesUnit = new Label();
            txtSalesUnit = new TextBox();
            lblOuterDia = new Label();
            numOuterDia = new NumericUpDown();
            btnPreQueryTempCode = new Button();
            btnAbandon = new Button();
            lblSalesFactor = new Label();
            numSalesFactor = new NumericUpDown();
            lblInnerDia = new Label();
            numInnerDia = new NumericUpDown();
            panelFooter = new Panel();
            lblApprover = new Label();
            txtApprover = new TextBox();
            lblModifier = new Label();
            txtModifier = new TextBox();
            txtModifyDate = new TextBox();
            lblCreator = new Label();
            txtCreator = new TextBox();
            txtCreateDate = new TextBox();
            panelToolbar.SuspendLayout();
            panelDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numLength).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numPurchaseFactor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numThickness).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numOuterDia).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numSalesFactor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numInnerDia).BeginInit();
            panelFooter.SuspendLayout();
            SuspendLayout();
            // 
            // panelToolbar
            // 
            panelToolbar.BackColor = Color.FromArgb(255, 255, 192);
            panelToolbar.Controls.Add(lblTitle);
            panelToolbar.Controls.Add(btnDisableManage);
            panelToolbar.Controls.Add(btnDelete);
            panelToolbar.Controls.Add(btnAdd);
            panelToolbar.Controls.Add(btnModify);
            panelToolbar.Controls.Add(btnSave);
            panelToolbar.Controls.Add(btnApprove);
            panelToolbar.Controls.Add(btnCancelApprove);
            panelToolbar.Dock = DockStyle.Top;
            panelToolbar.Location = new Point(0, 0);
            panelToolbar.Name = "panelToolbar";
            panelToolbar.Size = new Size(940, 48);
            panelToolbar.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("微軟正黑體", 13F, FontStyle.Bold);
            lblTitle.Location = new Point(8, 10);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(120, 28);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "品項維護";
            // 
            // btnDisableManage
            // 
            btnDisableManage.BackColor = Color.FromArgb(46, 125, 50);
            btnDisableManage.FlatStyle = FlatStyle.Flat;
            btnDisableManage.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            btnDisableManage.ForeColor = Color.White;
            btnDisableManage.Location = new Point(150, 8);
            btnDisableManage.Name = "btnDisableManage";
            btnDisableManage.Size = new Size(90, 32);
            btnDisableManage.TabIndex = 1;
            btnDisableManage.Text = "停用管理";
            btnDisableManage.UseVisualStyleBackColor = false;
            btnDisableManage.Click += btnDisableManage_Click;
            //
            // btnDelete
            // 
            btnDelete.BackColor = Color.IndianRed;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(360, 8);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(90, 32);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "刪除紀錄";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(150, 150, 180);
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(455, 8);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(70, 32);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "新增";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            //
            // btnModify
            //
            btnModify.BackColor = Color.FromArgb(150, 150, 180);
            btnModify.FlatStyle = FlatStyle.Flat;
            btnModify.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            btnModify.ForeColor = Color.White;
            btnModify.Location = new Point(530, 8);
            btnModify.Name = "btnModify";
            btnModify.Size = new Size(70, 32);
            btnModify.TabIndex = 4;
            btnModify.Text = "修改";
            btnModify.UseVisualStyleBackColor = false;
            btnModify.Click += btnModify_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(150, 150, 180);
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(605, 8);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(70, 32);
            btnSave.TabIndex = 5;
            btnSave.Text = "儲存";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            //
            // btnApprove
            // 
            btnApprove.BackColor = Color.FromArgb(150, 150, 180);
            btnApprove.FlatStyle = FlatStyle.Flat;
            btnApprove.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            btnApprove.ForeColor = Color.White;
            btnApprove.Location = new Point(680, 8);
            btnApprove.Name = "btnApprove";
            btnApprove.Size = new Size(70, 32);
            btnApprove.TabIndex = 6;
            btnApprove.Text = "生效";
            btnApprove.UseVisualStyleBackColor = false;
            btnApprove.Click += btnApprove_Click;
            //
            // btnCancelApprove
            //
            btnCancelApprove.BackColor = Color.FromArgb(150, 150, 180);
            btnCancelApprove.FlatStyle = FlatStyle.Flat;
            btnCancelApprove.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            btnCancelApprove.ForeColor = Color.White;
            btnCancelApprove.Location = new Point(755, 8);
            btnCancelApprove.Name = "btnCancelApprove";
            btnCancelApprove.Size = new Size(85, 32);
            btnCancelApprove.TabIndex = 7;
            btnCancelApprove.Text = "取消生效";
            btnCancelApprove.UseVisualStyleBackColor = false;
            btnCancelApprove.Click += btnCancelApprove_Click;
            // 
            // panelDetail
            // 
            panelDetail.BackColor = Color.FromArgb(255, 248, 240);
            panelDetail.Controls.Add(lblItemNo);
            panelDetail.Controls.Add(txtItemNo);
            panelDetail.Controls.Add(lblName);
            panelDetail.Controls.Add(txtName);
            panelDetail.Controls.Add(chkDisabled);
            panelDetail.Controls.Add(lblType);
            panelDetail.Controls.Add(cboType);
            panelDetail.Controls.Add(lblEnglishName);
            panelDetail.Controls.Add(txtEnglishName);
            panelDetail.Controls.Add(lblCategory);
            panelDetail.Controls.Add(txtCategory);
            panelDetail.Controls.Add(btnPickCategory);
            panelDetail.Controls.Add(lblStockUnit);
            panelDetail.Controls.Add(txtStockUnit);
            panelDetail.Controls.Add(lblLength);
            panelDetail.Controls.Add(numLength);
            panelDetail.Controls.Add(lblSubCategory);
            panelDetail.Controls.Add(cboSubCategory);
            panelDetail.Controls.Add(lblPurchaseUnit);
            panelDetail.Controls.Add(txtPurchaseUnit);
            panelDetail.Controls.Add(lblWidth);
            panelDetail.Controls.Add(txtWidth);
            panelDetail.Controls.Add(lblSourceAttr);
            panelDetail.Controls.Add(cboSourceAttr);
            panelDetail.Controls.Add(lblPurchaseFactor);
            panelDetail.Controls.Add(numPurchaseFactor);
            panelDetail.Controls.Add(lblThickness);
            panelDetail.Controls.Add(numThickness);
            panelDetail.Controls.Add(lblMaterialCode);
            panelDetail.Controls.Add(txtMaterialCode);
            panelDetail.Controls.Add(lblSalesUnit);
            panelDetail.Controls.Add(txtSalesUnit);
            panelDetail.Controls.Add(lblOuterDia);
            panelDetail.Controls.Add(numOuterDia);
            panelDetail.Controls.Add(btnPreQueryTempCode);
            panelDetail.Controls.Add(btnAbandon);
            panelDetail.Controls.Add(lblSalesFactor);
            panelDetail.Controls.Add(numSalesFactor);
            panelDetail.Controls.Add(lblInnerDia);
            panelDetail.Controls.Add(numInnerDia);
            panelDetail.Dock = DockStyle.Top;
            panelDetail.Location = new Point(0, 48);
            panelDetail.Name = "panelDetail";
            panelDetail.Size = new Size(940, 268);
            panelDetail.TabIndex = 1;
            // 
            // lblItemNo
            // 
            lblItemNo.AutoSize = true;
            lblItemNo.Font = new Font("微軟正黑體", 10F);
            lblItemNo.Location = new Point(8, 12);
            lblItemNo.Name = "lblItemNo";
            lblItemNo.Size = new Size(64, 18);
            lblItemNo.TabIndex = 0;
            lblItemNo.Text = "品項編號";
            // 
            // txtItemNo
            // 
            txtItemNo.Font = new Font("微軟正黑體", 10F);
            txtItemNo.Location = new Point(82, 8);
            txtItemNo.Name = "txtItemNo";
            txtItemNo.Size = new Size(160, 25);
            txtItemNo.TabIndex = 1;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("微軟正黑體", 10F);
            lblName.Location = new Point(310, 12);
            lblName.Name = "lblName";
            lblName.Size = new Size(36, 18);
            lblName.TabIndex = 2;
            lblName.Text = "品名";
            // 
            // txtName
            // 
            txtName.Font = new Font("微軟正黑體", 10F);
            txtName.Location = new Point(404, 8);
            txtName.Name = "txtName";
            txtName.Size = new Size(160, 25);
            txtName.TabIndex = 3;
            // 
            // chkDisabled
            // 
            chkDisabled.AutoSize = true;
            chkDisabled.Font = new Font("微軟正黑體", 10F);
            chkDisabled.Location = new Point(684, 10);
            chkDisabled.Name = "chkDisabled";
            chkDisabled.Size = new Size(55, 22);
            chkDisabled.TabIndex = 4;
            chkDisabled.Text = "停用";
            chkDisabled.CheckedChanged += chkDisabled_CheckedChanged;
            //
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.Font = new Font("微軟正黑體", 10F);
            lblType.Location = new Point(8, 48);
            lblType.Name = "lblType";
            lblType.Size = new Size(36, 18);
            lblType.TabIndex = 5;
            lblType.Text = "品別";
            // 
            // cboType
            // 
            cboType.Font = new Font("微軟正黑體", 10F);
            cboType.Location = new Point(82, 44);
            cboType.Name = "cboType";
            cboType.Size = new Size(160, 25);
            cboType.TabIndex = 6;
            // 
            // lblEnglishName
            // 
            lblEnglishName.AutoSize = true;
            lblEnglishName.Font = new Font("微軟正黑體", 10F);
            lblEnglishName.Location = new Point(310, 48);
            lblEnglishName.Name = "lblEnglishName";
            lblEnglishName.Size = new Size(64, 18);
            lblEnglishName.TabIndex = 7;
            lblEnglishName.Text = "英文品名";
            // 
            // txtEnglishName
            // 
            txtEnglishName.Font = new Font("微軟正黑體", 10F);
            txtEnglishName.Location = new Point(404, 44);
            txtEnglishName.Name = "txtEnglishName";
            txtEnglishName.Size = new Size(160, 25);
            txtEnglishName.TabIndex = 8;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("微軟正黑體", 10F);
            lblCategory.Location = new Point(8, 84);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(50, 18);
            lblCategory.TabIndex = 9;
            lblCategory.Text = "主分類";
            // 
            // txtCategory
            // 
            txtCategory.BackColor = Color.WhiteSmoke;
            txtCategory.Font = new Font("微軟正黑體", 10F);
            txtCategory.Location = new Point(82, 80);
            txtCategory.Name = "txtCategory";
            txtCategory.ReadOnly = true;
            txtCategory.Size = new Size(132, 25);
            txtCategory.TabIndex = 10;
            // 
            // btnPickCategory
            // 
            btnPickCategory.FlatStyle = FlatStyle.Flat;
            btnPickCategory.Font = new Font("Segoe MDL2 Assets", 8F);
            btnPickCategory.Location = new Point(214, 80);
            btnPickCategory.Name = "btnPickCategory";
            btnPickCategory.Size = new Size(28, 25);
            btnPickCategory.TabIndex = 11;
            btnPickCategory.UseVisualStyleBackColor = true;
            btnPickCategory.Click += btnPickCategory_Click;
            // 
            // lblStockUnit
            // 
            lblStockUnit.AutoSize = true;
            lblStockUnit.Font = new Font("微軟正黑體", 10F);
            lblStockUnit.Location = new Point(310, 84);
            lblStockUnit.Name = "lblStockUnit";
            lblStockUnit.Size = new Size(92, 18);
            lblStockUnit.TabIndex = 12;
            lblStockUnit.Text = "庫存成本單位";
            // 
            // txtStockUnit
            // 
            txtStockUnit.Font = new Font("微軟正黑體", 10F);
            txtStockUnit.Location = new Point(404, 80);
            txtStockUnit.Name = "txtStockUnit";
            txtStockUnit.Size = new Size(160, 25);
            txtStockUnit.TabIndex = 13;
            // 
            // lblLength
            // 
            lblLength.AutoSize = true;
            lblLength.Font = new Font("微軟正黑體", 10F);
            lblLength.Location = new Point(610, 84);
            lblLength.Name = "lblLength";
            lblLength.Size = new Size(48, 18);
            lblLength.TabIndex = 14;
            lblLength.Text = "長mm";
            // 
            // numLength
            // 
            numLength.DecimalPlaces = 2;
            numLength.Font = new Font("微軟正黑體", 10F);
            numLength.Location = new Point(684, 80);
            numLength.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            numLength.Name = "numLength";
            numLength.Size = new Size(160, 25);
            numLength.TabIndex = 15;
            // 
            // lblSubCategory
            // 
            lblSubCategory.AutoSize = true;
            lblSubCategory.Font = new Font("微軟正黑體", 10F);
            lblSubCategory.Location = new Point(8, 120);
            lblSubCategory.Name = "lblSubCategory";
            lblSubCategory.Size = new Size(50, 18);
            lblSubCategory.TabIndex = 16;
            lblSubCategory.Text = "次分類";
            // 
            // cboSubCategory
            // 
            cboSubCategory.Font = new Font("微軟正黑體", 10F);
            cboSubCategory.Location = new Point(82, 116);
            cboSubCategory.Name = "cboSubCategory";
            cboSubCategory.Size = new Size(160, 25);
            cboSubCategory.TabIndex = 17;
            // 
            // lblPurchaseUnit
            // 
            lblPurchaseUnit.AutoSize = true;
            lblPurchaseUnit.Font = new Font("微軟正黑體", 10F);
            lblPurchaseUnit.Location = new Point(310, 120);
            lblPurchaseUnit.Name = "lblPurchaseUnit";
            lblPurchaseUnit.Size = new Size(64, 18);
            lblPurchaseUnit.TabIndex = 18;
            lblPurchaseUnit.Text = "採購單位";
            // 
            // txtPurchaseUnit
            // 
            txtPurchaseUnit.Font = new Font("微軟正黑體", 10F);
            txtPurchaseUnit.Location = new Point(404, 116);
            txtPurchaseUnit.Name = "txtPurchaseUnit";
            txtPurchaseUnit.Size = new Size(160, 25);
            txtPurchaseUnit.TabIndex = 19;
            // 
            // lblWidth
            // 
            lblWidth.AutoSize = true;
            lblWidth.Font = new Font("微軟正黑體", 10F);
            lblWidth.Location = new Point(610, 120);
            lblWidth.Name = "lblWidth";
            lblWidth.Size = new Size(48, 18);
            lblWidth.TabIndex = 20;
            lblWidth.Text = "寬mm";
            // 
            // txtWidth
            // 
            txtWidth.Font = new Font("微軟正黑體", 10F);
            txtWidth.Location = new Point(684, 116);
            txtWidth.Name = "txtWidth";
            txtWidth.Size = new Size(160, 25);
            txtWidth.TabIndex = 21;
            // 
            // lblSourceAttr
            // 
            lblSourceAttr.AutoSize = true;
            lblSourceAttr.Font = new Font("微軟正黑體", 10F);
            lblSourceAttr.Location = new Point(8, 156);
            lblSourceAttr.Name = "lblSourceAttr";
            lblSourceAttr.Size = new Size(64, 18);
            lblSourceAttr.TabIndex = 22;
            lblSourceAttr.Text = "來源屬性";
            // 
            // cboSourceAttr
            // 
            cboSourceAttr.Font = new Font("微軟正黑體", 10F);
            cboSourceAttr.Location = new Point(82, 152);
            cboSourceAttr.Name = "cboSourceAttr";
            cboSourceAttr.Size = new Size(160, 25);
            cboSourceAttr.TabIndex = 23;
            // 
            // lblPurchaseFactor
            // 
            lblPurchaseFactor.AutoSize = true;
            lblPurchaseFactor.Font = new Font("微軟正黑體", 10F);
            lblPurchaseFactor.Location = new Point(310, 156);
            lblPurchaseFactor.Name = "lblPurchaseFactor";
            lblPurchaseFactor.Size = new Size(92, 18);
            lblPurchaseFactor.TabIndex = 24;
            lblPurchaseFactor.Text = "採購換算倍數";
            // 
            // numPurchaseFactor
            // 
            numPurchaseFactor.Font = new Font("微軟正黑體", 10F);
            numPurchaseFactor.Location = new Point(404, 152);
            numPurchaseFactor.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            numPurchaseFactor.Name = "numPurchaseFactor";
            numPurchaseFactor.Size = new Size(160, 25);
            numPurchaseFactor.TabIndex = 25;
            // 
            // lblThickness
            // 
            lblThickness.AutoSize = true;
            lblThickness.Font = new Font("微軟正黑體", 10F);
            lblThickness.Location = new Point(610, 156);
            lblThickness.Name = "lblThickness";
            lblThickness.Size = new Size(48, 18);
            lblThickness.TabIndex = 26;
            lblThickness.Text = "厚mm";
            // 
            // numThickness
            // 
            numThickness.DecimalPlaces = 2;
            numThickness.Font = new Font("微軟正黑體", 10F);
            numThickness.Location = new Point(684, 152);
            numThickness.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            numThickness.Name = "numThickness";
            numThickness.Size = new Size(160, 25);
            numThickness.TabIndex = 27;
            // 
            // lblMaterialCode
            // 
            lblMaterialCode.AutoSize = true;
            lblMaterialCode.Font = new Font("微軟正黑體", 10F);
            lblMaterialCode.Location = new Point(8, 192);
            lblMaterialCode.Name = "lblMaterialCode";
            lblMaterialCode.Size = new Size(64, 18);
            lblMaterialCode.TabIndex = 28;
            lblMaterialCode.Text = "材料代碼";
            // 
            // txtMaterialCode
            // 
            txtMaterialCode.Font = new Font("微軟正黑體", 10F);
            txtMaterialCode.Location = new Point(82, 188);
            txtMaterialCode.Name = "txtMaterialCode";
            txtMaterialCode.Size = new Size(160, 25);
            txtMaterialCode.TabIndex = 29;
            // 
            // lblSalesUnit
            // 
            lblSalesUnit.AutoSize = true;
            lblSalesUnit.Font = new Font("微軟正黑體", 10F);
            lblSalesUnit.Location = new Point(310, 192);
            lblSalesUnit.Name = "lblSalesUnit";
            lblSalesUnit.Size = new Size(64, 18);
            lblSalesUnit.TabIndex = 30;
            lblSalesUnit.Text = "銷售單位";
            // 
            // txtSalesUnit
            // 
            txtSalesUnit.Font = new Font("微軟正黑體", 10F);
            txtSalesUnit.Location = new Point(404, 188);
            txtSalesUnit.Name = "txtSalesUnit";
            txtSalesUnit.Size = new Size(160, 25);
            txtSalesUnit.TabIndex = 31;
            // 
            // lblOuterDia
            // 
            lblOuterDia.AutoSize = true;
            lblOuterDia.Font = new Font("微軟正黑體", 10F);
            lblOuterDia.Location = new Point(610, 192);
            lblOuterDia.Name = "lblOuterDia";
            lblOuterDia.Size = new Size(62, 18);
            lblOuterDia.TabIndex = 32;
            lblOuterDia.Text = "外徑mm";
            // 
            // numOuterDia
            // 
            numOuterDia.DecimalPlaces = 2;
            numOuterDia.Font = new Font("微軟正黑體", 10F);
            numOuterDia.Location = new Point(684, 188);
            numOuterDia.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            numOuterDia.Name = "numOuterDia";
            numOuterDia.Size = new Size(160, 25);
            numOuterDia.TabIndex = 33;
            // 
            // btnPreQueryTempCode
            // 
            btnPreQueryTempCode.BackColor = Color.SteelBlue;
            btnPreQueryTempCode.FlatStyle = FlatStyle.Flat;
            btnPreQueryTempCode.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            btnPreQueryTempCode.ForeColor = Color.White;
            btnPreQueryTempCode.Location = new Point(8, 224);
            btnPreQueryTempCode.Name = "btnPreQueryTempCode";
            btnPreQueryTempCode.Size = new Size(160, 32);
            btnPreQueryTempCode.TabIndex = 34;
            btnPreQueryTempCode.Text = "採購預查新增臨時品號";
            btnPreQueryTempCode.UseVisualStyleBackColor = false;
            btnPreQueryTempCode.Click += btnPreQueryTempCode_Click;
            //
            // btnAbandon
            // 
            btnAbandon.BackColor = Color.FromArgb(224, 224, 224);
            btnAbandon.FlatStyle = FlatStyle.Flat;
            btnAbandon.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            btnAbandon.Location = new Point(172, 224);
            btnAbandon.Name = "btnAbandon";
            btnAbandon.Size = new Size(72, 32);
            btnAbandon.TabIndex = 35;
            btnAbandon.Text = "放棄";
            btnAbandon.UseVisualStyleBackColor = false;
            // 
            // lblSalesFactor
            // 
            lblSalesFactor.AutoSize = true;
            lblSalesFactor.Font = new Font("微軟正黑體", 10F);
            lblSalesFactor.Location = new Point(310, 228);
            lblSalesFactor.Name = "lblSalesFactor";
            lblSalesFactor.Size = new Size(92, 18);
            lblSalesFactor.TabIndex = 36;
            lblSalesFactor.Text = "銷售換算倍數";
            // 
            // numSalesFactor
            // 
            numSalesFactor.Font = new Font("微軟正黑體", 10F);
            numSalesFactor.Location = new Point(404, 224);
            numSalesFactor.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            numSalesFactor.Name = "numSalesFactor";
            numSalesFactor.Size = new Size(160, 25);
            numSalesFactor.TabIndex = 37;
            // 
            // lblInnerDia
            // 
            lblInnerDia.AutoSize = true;
            lblInnerDia.Font = new Font("微軟正黑體", 10F);
            lblInnerDia.Location = new Point(610, 228);
            lblInnerDia.Name = "lblInnerDia";
            lblInnerDia.Size = new Size(62, 18);
            lblInnerDia.TabIndex = 38;
            lblInnerDia.Text = "內徑mm";
            // 
            // numInnerDia
            // 
            numInnerDia.DecimalPlaces = 2;
            numInnerDia.Font = new Font("微軟正黑體", 10F);
            numInnerDia.Location = new Point(684, 224);
            numInnerDia.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            numInnerDia.Name = "numInnerDia";
            numInnerDia.Size = new Size(160, 25);
            numInnerDia.TabIndex = 39;
            // 
            // panelFooter
            // 
            panelFooter.BackColor = Color.FromArgb(230, 230, 250);
            panelFooter.Controls.Add(lblApprover);
            panelFooter.Controls.Add(txtApprover);
            panelFooter.Controls.Add(lblModifier);
            panelFooter.Controls.Add(txtModifier);
            panelFooter.Controls.Add(txtModifyDate);
            panelFooter.Controls.Add(lblCreator);
            panelFooter.Controls.Add(txtCreator);
            panelFooter.Controls.Add(txtCreateDate);
            panelFooter.Dock = DockStyle.Top;
            panelFooter.Location = new Point(0, 316);
            panelFooter.Name = "panelFooter";
            panelFooter.Size = new Size(940, 32);
            panelFooter.TabIndex = 2;
            // 
            // lblApprover
            // 
            lblApprover.AutoSize = true;
            lblApprover.Font = new Font("微軟正黑體", 10F);
            lblApprover.Location = new Point(8, 8);
            lblApprover.Name = "lblApprover";
            lblApprover.Size = new Size(36, 18);
            lblApprover.TabIndex = 0;
            lblApprover.Text = "核准";
            // 
            // txtApprover
            // 
            txtApprover.BackColor = Color.WhiteSmoke;
            txtApprover.Font = new Font("微軟正黑體", 9F);
            txtApprover.Location = new Point(48, 5);
            txtApprover.Name = "txtApprover";
            txtApprover.ReadOnly = true;
            txtApprover.Size = new Size(150, 23);
            txtApprover.TabIndex = 1;
            // 
            // lblModifier
            // 
            lblModifier.AutoSize = true;
            lblModifier.Font = new Font("微軟正黑體", 10F);
            lblModifier.Location = new Point(400, 8);
            lblModifier.Name = "lblModifier";
            lblModifier.Size = new Size(36, 18);
            lblModifier.TabIndex = 2;
            lblModifier.Text = "修改";
            // 
            // txtModifier
            // 
            txtModifier.BackColor = Color.WhiteSmoke;
            txtModifier.Font = new Font("微軟正黑體", 9F);
            txtModifier.Location = new Point(440, 5);
            txtModifier.Name = "txtModifier";
            txtModifier.ReadOnly = true;
            txtModifier.Size = new Size(110, 23);
            txtModifier.TabIndex = 3;
            // 
            // txtModifyDate
            // 
            txtModifyDate.BackColor = Color.WhiteSmoke;
            txtModifyDate.Font = new Font("微軟正黑體", 9F);
            txtModifyDate.Location = new Point(556, 5);
            txtModifyDate.Name = "txtModifyDate";
            txtModifyDate.ReadOnly = true;
            txtModifyDate.Size = new Size(110, 23);
            txtModifyDate.TabIndex = 4;
            // 
            // lblCreator
            // 
            lblCreator.AutoSize = true;
            lblCreator.Font = new Font("微軟正黑體", 10F);
            lblCreator.Location = new Point(700, 8);
            lblCreator.Name = "lblCreator";
            lblCreator.Size = new Size(36, 18);
            lblCreator.TabIndex = 5;
            lblCreator.Text = "建檔";
            // 
            // txtCreator
            // 
            txtCreator.BackColor = Color.WhiteSmoke;
            txtCreator.Font = new Font("微軟正黑體", 9F);
            txtCreator.Location = new Point(740, 5);
            txtCreator.Name = "txtCreator";
            txtCreator.ReadOnly = true;
            txtCreator.Size = new Size(90, 23);
            txtCreator.TabIndex = 6;
            // 
            // txtCreateDate
            // 
            txtCreateDate.BackColor = Color.WhiteSmoke;
            txtCreateDate.Font = new Font("微軟正黑體", 9F);
            txtCreateDate.Location = new Point(836, 5);
            txtCreateDate.Name = "txtCreateDate";
            txtCreateDate.ReadOnly = true;
            txtCreateDate.Size = new Size(90, 23);
            txtCreateDate.TabIndex = 7;
            // 
            // FrmAddPart
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(940, 348);
            Controls.Add(panelFooter);
            Controls.Add(panelDetail);
            Controls.Add(panelToolbar);
            Font = new Font("微軟正黑體", 10F);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmAddPart";
            StartPosition = FormStartPosition.CenterParent;
            Text = "品項維護";
            panelToolbar.ResumeLayout(false);
            panelDetail.ResumeLayout(false);
            panelDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numLength).EndInit();
            ((System.ComponentModel.ISupportInitialize)numPurchaseFactor).EndInit();
            ((System.ComponentModel.ISupportInitialize)numThickness).EndInit();
            ((System.ComponentModel.ISupportInitialize)numOuterDia).EndInit();
            ((System.ComponentModel.ISupportInitialize)numSalesFactor).EndInit();
            ((System.ComponentModel.ISupportInitialize)numInnerDia).EndInit();
            panelFooter.ResumeLayout(false);
            panelFooter.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelToolbar;
        private Label lblTitle;
        private Button btnDisableManage;
        private Button btnDelete;
        private Button btnAdd;
        private Button btnModify;
        private Button btnSave;
        private Button btnApprove;
        private Button btnCancelApprove;

        private Panel panelDetail;
        private Label lblItemNo; private TextBox txtItemNo;
        private Label lblName; private TextBox txtName;
        private CheckBox chkDisabled;
        private Label lblType; private ComboBox cboType;
        private Label lblEnglishName; private TextBox txtEnglishName;
        private Label lblCategory; private TextBox txtCategory; private Button btnPickCategory;
        private Label lblStockUnit; private TextBox txtStockUnit;
        private Label lblLength; private NumericUpDown numLength;
        private Label lblSubCategory; private ComboBox cboSubCategory;
        private Label lblPurchaseUnit; private TextBox txtPurchaseUnit;
        private Label lblWidth; private TextBox txtWidth;
        private Label lblSourceAttr; private ComboBox cboSourceAttr;
        private Label lblPurchaseFactor; private NumericUpDown numPurchaseFactor;
        private Label lblThickness; private NumericUpDown numThickness;
        private Label lblMaterialCode; private TextBox txtMaterialCode;
        private Label lblSalesUnit; private TextBox txtSalesUnit;
        private Label lblOuterDia; private NumericUpDown numOuterDia;
        private Button btnPreQueryTempCode;
        private Button btnAbandon;
        private Label lblSalesFactor; private NumericUpDown numSalesFactor;
        private Label lblInnerDia; private NumericUpDown numInnerDia;

        private Panel panelFooter;
        private Label lblApprover; private TextBox txtApprover;
        private Label lblModifier; private TextBox txtModifier; private TextBox txtModifyDate;
        private Label lblCreator; private TextBox txtCreator; private TextBox txtCreateDate;
    }
}
