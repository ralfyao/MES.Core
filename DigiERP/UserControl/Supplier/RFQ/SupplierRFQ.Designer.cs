namespace DigiERP.UserControl.Supplier.RFQ
{
    partial class SupplierRFQ
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SupplierRFQ));
            panelToolbar = new Panel();
            pictureBox1 = new PictureBox();
            lblTitle = new Label();
            btnHistory = new Button();
            btnEditMaterialSetting = new Button();
            btnAddPreQueryMaterial = new Button();
            btnAddRFQ = new Button();
            btnSaveRecord = new Button();
            panelFilter1 = new Panel();
            lblMaterialNo = new Label();
            txtMaterialNo = new TextBox();
            btnQuery = new Button();
            lblPurchaseType = new Label();
            txtPurchaseType = new TextBox();
            lblCategory = new Label();
            txtCategory = new TextBox();
            lblSubCategory = new Label();
            txtSubCategory = new TextBox();
            lblProductCode = new Label();
            txtProductCode = new TextBox();
            panelFilter2 = new Panel();
            lblSpec = new Label();
            txtSpec = new TextBox();
            lblLength = new Label();
            txtLength = new TextBox();
            lblWidth = new Label();
            txtWidth = new TextBox();
            lblThickness = new Label();
            txtThickness = new TextBox();
            lblOuterDia = new Label();
            txtOuterDia = new TextBox();
            lblInnerDia = new Label();
            txtInnerDia = new TextBox();
            panelGrid = new Panel();
            dataGridView1 = new DataGridView();
            colPicker = new DataGridViewButtonColumn();
            colSupplierNo = new DataGridViewComboBoxColumn();
            colSupplierShortName = new DataGridViewTextBoxColumn();
            colInquiryDate = new DigiERP.Common.DataGridViewDateTimePickerColumn();
            colUnitPrice = new DigiERP.Common.DataGridViewNumericUpDownColumn();
            colCurrency = new DataGridViewComboBoxColumn();
            colPurchaseUnit = new DataGridViewTextBoxColumn();
            colMinPurchaseQty = new DigiERP.Common.DataGridViewNumericUpDownColumn();
            colPlannedPurchaseQty = new DigiERP.Common.DataGridViewNumericUpDownColumn();
            colInquiryPerson = new DataGridViewComboBoxColumn();
            colQuoteValidDate = new DigiERP.Common.DataGridViewDateTimePickerColumn();
            colSupplierPartNo = new DataGridViewTextBoxColumn();
            colPrint = new DataGridViewButtonColumn();
            panelToolbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelFilter1.SuspendLayout();
            panelFilter2.SuspendLayout();
            panelGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panelToolbar
            // 
            panelToolbar.BackColor = Color.FromArgb(255, 248, 240);
            panelToolbar.Controls.Add(pictureBox1);
            panelToolbar.Controls.Add(lblTitle);
            panelToolbar.Controls.Add(btnHistory);
            panelToolbar.Controls.Add(btnEditMaterialSetting);
            panelToolbar.Controls.Add(btnAddPreQueryMaterial);
            panelToolbar.Controls.Add(btnAddRFQ);
            panelToolbar.Controls.Add(btnSaveRecord);
            panelToolbar.Dock = DockStyle.Top;
            panelToolbar.Location = new Point(0, 0);
            panelToolbar.Name = "panelToolbar";
            panelToolbar.Size = new Size(1497, 56);
            panelToolbar.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(4, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(60, 48);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("微軟正黑體", 14F, FontStyle.Bold);
            lblTitle.Location = new Point(86, 14);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(140, 28);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "採購詢價";
            // 
            // btnHistory
            // 
            btnHistory.BackColor = Color.FromArgb(192, 255, 192);
            btnHistory.Location = new Point(240, 10);
            btnHistory.Name = "btnHistory";
            btnHistory.Size = new Size(130, 36);
            btnHistory.TabIndex = 1;
            btnHistory.Text = "採購詢價歷程";
            btnHistory.UseVisualStyleBackColor = false;
            // 
            // btnEditMaterialSetting
            // 
            btnEditMaterialSetting.BackColor = Color.FromArgb(198, 216, 255);
            btnEditMaterialSetting.Location = new Point(380, 10);
            btnEditMaterialSetting.Name = "btnEditMaterialSetting";
            btnEditMaterialSetting.Size = new Size(120, 36);
            btnEditMaterialSetting.TabIndex = 2;
            btnEditMaterialSetting.Text = "編修材料設定";
            btnEditMaterialSetting.UseVisualStyleBackColor = false;
            btnEditMaterialSetting.Click += btnEditMaterialSetting_Click;
            //
            // btnAddPreQueryMaterial
            //
            btnAddPreQueryMaterial.BackColor = Color.FromArgb(198, 216, 255);
            btnAddPreQueryMaterial.Location = new Point(510, 10);
            btnAddPreQueryMaterial.Name = "btnAddPreQueryMaterial";
            btnAddPreQueryMaterial.Size = new Size(120, 36);
            btnAddPreQueryMaterial.TabIndex = 3;
            btnAddPreQueryMaterial.Text = "新增預詢材料";
            btnAddPreQueryMaterial.UseVisualStyleBackColor = false;
            btnAddPreQueryMaterial.Click += btnAddPreQueryMaterial_Click;
            //
            // btnAddRFQ
            //
            btnAddRFQ.BackColor = Color.FromArgb(198, 216, 255);
            btnAddRFQ.Location = new Point(640, 10);
            btnAddRFQ.Name = "btnAddRFQ";
            btnAddRFQ.Size = new Size(110, 36);
            btnAddRFQ.TabIndex = 4;
            btnAddRFQ.Text = "新增詢價單";
            btnAddRFQ.UseVisualStyleBackColor = false;
            btnAddRFQ.Click += btnAddRFQ_Click;
            // 
            // btnSaveRecord
            // 
            btnSaveRecord.BackColor = Color.FromArgb(198, 216, 255);
            btnSaveRecord.Location = new Point(760, 10);
            btnSaveRecord.Name = "btnSaveRecord";
            btnSaveRecord.Size = new Size(110, 36);
            btnSaveRecord.TabIndex = 5;
            btnSaveRecord.Text = "儲存紀錄";
            btnSaveRecord.UseVisualStyleBackColor = false;
            btnSaveRecord.Click += btnSaveRecord_Click;
            // 
            // panelFilter1
            // 
            panelFilter1.BackColor = Color.FromArgb(255, 248, 240);
            panelFilter1.Controls.Add(lblMaterialNo);
            panelFilter1.Controls.Add(txtMaterialNo);
            panelFilter1.Controls.Add(btnQuery);
            panelFilter1.Controls.Add(lblPurchaseType);
            panelFilter1.Controls.Add(txtPurchaseType);
            panelFilter1.Controls.Add(lblCategory);
            panelFilter1.Controls.Add(txtCategory);
            panelFilter1.Controls.Add(lblSubCategory);
            panelFilter1.Controls.Add(txtSubCategory);
            panelFilter1.Controls.Add(lblProductCode);
            panelFilter1.Controls.Add(txtProductCode);
            panelFilter1.Dock = DockStyle.Top;
            panelFilter1.Location = new Point(0, 56);
            panelFilter1.Name = "panelFilter1";
            panelFilter1.Size = new Size(1497, 40);
            panelFilter1.TabIndex = 1;
            // 
            // lblMaterialNo
            // 
            lblMaterialNo.AutoSize = true;
            lblMaterialNo.Font = new Font("微軟正黑體", 10F);
            lblMaterialNo.Location = new Point(8, 12);
            lblMaterialNo.Name = "lblMaterialNo";
            lblMaterialNo.Size = new Size(64, 18);
            lblMaterialNo.TabIndex = 0;
            lblMaterialNo.Text = "材料編號";
            // 
            // txtMaterialNo
            // 
            txtMaterialNo.Font = new Font("微軟正黑體", 10F);
            txtMaterialNo.Location = new Point(80, 8);
            txtMaterialNo.Name = "txtMaterialNo";
            txtMaterialNo.Size = new Size(140, 25);
            txtMaterialNo.TabIndex = 1;
            // 
            // btnQuery
            // 
            btnQuery.BackColor = Color.FromArgb(255, 192, 96);
            btnQuery.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            btnQuery.Location = new Point(230, 6);
            btnQuery.Name = "btnQuery";
            btnQuery.Size = new Size(70, 30);
            btnQuery.TabIndex = 2;
            btnQuery.Text = "查料";
            btnQuery.UseVisualStyleBackColor = false;
            btnQuery.Click += btnQuery_Click;
            // 
            // lblPurchaseType
            // 
            lblPurchaseType.AutoSize = true;
            lblPurchaseType.Font = new Font("微軟正黑體", 10F);
            lblPurchaseType.Location = new Point(316, 12);
            lblPurchaseType.Name = "lblPurchaseType";
            lblPurchaseType.Size = new Size(78, 18);
            lblPurchaseType.TabIndex = 3;
            lblPurchaseType.Text = "市購品類別";
            // 
            // txtPurchaseType
            // 
            txtPurchaseType.Font = new Font("微軟正黑體", 10F);
            txtPurchaseType.Location = new Point(400, 8);
            txtPurchaseType.Name = "txtPurchaseType";
            txtPurchaseType.Size = new Size(80, 25);
            txtPurchaseType.TabIndex = 4;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("微軟正黑體", 10F);
            lblCategory.Location = new Point(494, 12);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(50, 18);
            lblCategory.TabIndex = 5;
            lblCategory.Text = "大分類";
            // 
            // txtCategory
            // 
            txtCategory.Font = new Font("微軟正黑體", 10F);
            txtCategory.Location = new Point(548, 8);
            txtCategory.Name = "txtCategory";
            txtCategory.Size = new Size(66, 25);
            txtCategory.TabIndex = 6;
            // 
            // lblSubCategory
            // 
            lblSubCategory.AutoSize = true;
            lblSubCategory.Font = new Font("微軟正黑體", 10F);
            lblSubCategory.Location = new Point(624, 12);
            lblSubCategory.Name = "lblSubCategory";
            lblSubCategory.Size = new Size(50, 18);
            lblSubCategory.TabIndex = 7;
            lblSubCategory.Text = "小分類";
            // 
            // txtSubCategory
            // 
            txtSubCategory.Font = new Font("微軟正黑體", 10F);
            txtSubCategory.Location = new Point(684, 8);
            txtSubCategory.Name = "txtSubCategory";
            txtSubCategory.Size = new Size(60, 25);
            txtSubCategory.TabIndex = 8;
            // 
            // lblProductCode
            // 
            lblProductCode.AutoSize = true;
            lblProductCode.Font = new Font("微軟正黑體", 10F);
            lblProductCode.Location = new Point(754, 12);
            lblProductCode.Name = "lblProductCode";
            lblProductCode.Size = new Size(64, 18);
            lblProductCode.TabIndex = 9;
            lblProductCode.Text = "產品代號";
            // 
            // txtProductCode
            // 
            txtProductCode.Font = new Font("微軟正黑體", 10F);
            txtProductCode.Location = new Point(828, 8);
            txtProductCode.Name = "txtProductCode";
            txtProductCode.Size = new Size(286, 25);
            txtProductCode.TabIndex = 10;
            // 
            // panelFilter2
            // 
            panelFilter2.BackColor = Color.FromArgb(255, 248, 240);
            panelFilter2.Controls.Add(lblSpec);
            panelFilter2.Controls.Add(txtSpec);
            panelFilter2.Controls.Add(lblLength);
            panelFilter2.Controls.Add(txtLength);
            panelFilter2.Controls.Add(lblWidth);
            panelFilter2.Controls.Add(txtWidth);
            panelFilter2.Controls.Add(lblThickness);
            panelFilter2.Controls.Add(txtThickness);
            panelFilter2.Controls.Add(lblOuterDia);
            panelFilter2.Controls.Add(txtOuterDia);
            panelFilter2.Controls.Add(lblInnerDia);
            panelFilter2.Controls.Add(txtInnerDia);
            panelFilter2.Dock = DockStyle.Top;
            panelFilter2.Location = new Point(0, 96);
            panelFilter2.Name = "panelFilter2";
            panelFilter2.Size = new Size(1497, 40);
            panelFilter2.TabIndex = 2;
            // 
            // lblSpec
            // 
            lblSpec.AutoSize = true;
            lblSpec.Font = new Font("微軟正黑體", 10F);
            lblSpec.Location = new Point(8, 12);
            lblSpec.Name = "lblSpec";
            lblSpec.Size = new Size(64, 18);
            lblSpec.TabIndex = 0;
            lblSpec.Text = "品名規格";
            // 
            // txtSpec
            // 
            txtSpec.Font = new Font("微軟正黑體", 10F);
            txtSpec.Location = new Point(84, 8);
            txtSpec.Name = "txtSpec";
            txtSpec.Size = new Size(386, 25);
            txtSpec.TabIndex = 1;
            // 
            // lblLength
            // 
            lblLength.AutoSize = true;
            lblLength.Font = new Font("微軟正黑體", 10F);
            lblLength.Location = new Point(480, 12);
            lblLength.Name = "lblLength";
            lblLength.Size = new Size(64, 18);
            lblLength.TabIndex = 2;
            lblLength.Text = "外尺寸長";
            // 
            // txtLength
            // 
            txtLength.Font = new Font("微軟正黑體", 10F);
            txtLength.Location = new Point(552, 8);
            txtLength.Name = "txtLength";
            txtLength.Size = new Size(62, 25);
            txtLength.TabIndex = 3;
            // 
            // lblWidth
            // 
            lblWidth.AutoSize = true;
            lblWidth.Font = new Font("微軟正黑體", 10F);
            lblWidth.Location = new Point(624, 12);
            lblWidth.Name = "lblWidth";
            lblWidth.Size = new Size(64, 18);
            lblWidth.TabIndex = 4;
            lblWidth.Text = "外尺寸寬";
            // 
            // txtWidth
            // 
            txtWidth.Font = new Font("微軟正黑體", 10F);
            txtWidth.Location = new Point(700, 8);
            txtWidth.Name = "txtWidth";
            txtWidth.Size = new Size(58, 25);
            txtWidth.TabIndex = 5;
            // 
            // lblThickness
            // 
            lblThickness.AutoSize = true;
            lblThickness.Font = new Font("微軟正黑體", 10F);
            lblThickness.Location = new Point(768, 12);
            lblThickness.Name = "lblThickness";
            lblThickness.Size = new Size(36, 18);
            lblThickness.TabIndex = 6;
            lblThickness.Text = "厚度";
            // 
            // txtThickness
            // 
            txtThickness.Font = new Font("微軟正黑體", 10F);
            txtThickness.Location = new Point(820, 8);
            txtThickness.Name = "txtThickness";
            txtThickness.Size = new Size(52, 25);
            txtThickness.TabIndex = 7;
            // 
            // lblOuterDia
            // 
            lblOuterDia.AutoSize = true;
            lblOuterDia.Font = new Font("微軟正黑體", 10F);
            lblOuterDia.Location = new Point(882, 12);
            lblOuterDia.Name = "lblOuterDia";
            lblOuterDia.Size = new Size(36, 18);
            lblOuterDia.TabIndex = 8;
            lblOuterDia.Text = "外徑";
            // 
            // txtOuterDia
            // 
            txtOuterDia.Font = new Font("微軟正黑體", 10F);
            txtOuterDia.Location = new Point(932, 8);
            txtOuterDia.Name = "txtOuterDia";
            txtOuterDia.Size = new Size(54, 25);
            txtOuterDia.TabIndex = 9;
            // 
            // lblInnerDia
            // 
            lblInnerDia.AutoSize = true;
            lblInnerDia.Font = new Font("微軟正黑體", 10F);
            lblInnerDia.Location = new Point(996, 12);
            lblInnerDia.Name = "lblInnerDia";
            lblInnerDia.Size = new Size(36, 18);
            lblInnerDia.TabIndex = 10;
            lblInnerDia.Text = "內徑";
            // 
            // txtInnerDia
            // 
            txtInnerDia.Font = new Font("微軟正黑體", 10F);
            txtInnerDia.Location = new Point(1052, 8);
            txtInnerDia.Name = "txtInnerDia";
            txtInnerDia.Size = new Size(48, 25);
            txtInnerDia.TabIndex = 11;
            // 
            // panelGrid
            // 
            panelGrid.Controls.Add(dataGridView1);
            panelGrid.Dock = DockStyle.Fill;
            panelGrid.Location = new Point(0, 136);
            panelGrid.Name = "panelGrid";
            panelGrid.Size = new Size(1497, 540);
            panelGrid.TabIndex = 3;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colPicker, colSupplierNo, colSupplierShortName, colInquiryDate, colUnitPrice, colCurrency, colPurchaseUnit, colMinPurchaseQty, colPlannedPurchaseQty, colInquiryPerson, colQuoteValidDate, colSupplierPartNo, colPrint });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Font = new Font("微軟正黑體", 10F);
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 28;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1497, 540);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellBeginEdit += dataGridView1_CellBeginEdit;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // colPicker
            // 
            colPicker.FillWeight = 40F;
            colPicker.HeaderText = "";
            colPicker.Name = "colPicker";
            colPicker.Text = "🔍";
            colPicker.UseColumnTextForButtonValue = true;
            // 
            // colSupplierNo
            // 
            colSupplierNo.FillWeight = 80F;
            colSupplierNo.HeaderText = "廠商編號";
            colSupplierNo.Name = "colSupplierNo";
            // 
            // colSupplierShortName
            // 
            colSupplierShortName.FillWeight = 90F;
            colSupplierShortName.HeaderText = "廠商簡稱";
            colSupplierShortName.Name = "colSupplierShortName";
            // 
            // colInquiryDate
            // 
            colInquiryDate.FillWeight = 80F;
            colInquiryDate.HeaderText = "詢價日期";
            colInquiryDate.Name = "colInquiryDate";
            // 
            // colUnitPrice
            //
            colUnitPrice.DecimalPlaces = 2;
            colUnitPrice.Maximum = 99999999m;
            colUnitPrice.FillWeight = 70F;
            colUnitPrice.HeaderText = "單價";
            colUnitPrice.Name = "colUnitPrice";
            // 
            // colCurrency
            // 
            colCurrency.FillWeight = 60F;
            colCurrency.HeaderText = "幣別";
            colCurrency.Items.AddRange(new object[] { "NTD", "USD", "RMB", "JPY", "EUR" });
            colCurrency.Name = "colCurrency";
            // 
            // colPurchaseUnit
            // 
            colPurchaseUnit.FillWeight = 70F;
            colPurchaseUnit.HeaderText = "採購單位";
            colPurchaseUnit.Name = "colPurchaseUnit";
            // 
            // colMinPurchaseQty
            //
            colMinPurchaseQty.Maximum = 999999m;
            colMinPurchaseQty.FillWeight = 80F;
            colMinPurchaseQty.HeaderText = "最低採購量";
            colMinPurchaseQty.Name = "colMinPurchaseQty";
            //
            // colPlannedPurchaseQty
            //
            colPlannedPurchaseQty.Maximum = 999999m;
            colPlannedPurchaseQty.FillWeight = 80F;
            colPlannedPurchaseQty.HeaderText = "預計採購量";
            colPlannedPurchaseQty.Name = "colPlannedPurchaseQty";
            // 
            // colInquiryPerson
            // 
            colInquiryPerson.FillWeight = 80F;
            colInquiryPerson.HeaderText = "詢價人員";
            colInquiryPerson.Name = "colInquiryPerson";
            // 
            // colQuoteValidDate
            // 
            colQuoteValidDate.FillWeight = 90F;
            colQuoteValidDate.HeaderText = "報價有效日期";
            colQuoteValidDate.Name = "colQuoteValidDate";
            // 
            // colSupplierPartNo
            // 
            colSupplierPartNo.FillWeight = 90F;
            colSupplierPartNo.HeaderText = "廠商品號";
            colSupplierPartNo.Name = "colSupplierPartNo";
            // 
            // colPrint
            // 
            colPrint.FillWeight = 90F;
            colPrint.HeaderText = "";
            colPrint.Name = "colPrint";
            colPrint.Text = "列印詢價單";
            colPrint.UseColumnTextForButtonValue = true;
            // 
            // SupplierRFQ
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelGrid);
            Controls.Add(panelFilter2);
            Controls.Add(panelFilter1);
            Controls.Add(panelToolbar);
            Font = new Font("微軟正黑體", 10F);
            Margin = new Padding(4);
            Name = "SupplierRFQ";
            Size = new Size(1497, 676);
            panelToolbar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelFilter1.ResumeLayout(false);
            panelFilter1.PerformLayout();
            panelFilter2.ResumeLayout(false);
            panelFilter2.PerformLayout();
            panelGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelToolbar;
        private Label lblTitle;
        private Button btnHistory;
        private Button btnEditMaterialSetting;
        private Button btnAddPreQueryMaterial;
        private Button btnAddRFQ;
        private Button btnSaveRecord;

        private Panel panelFilter1;
        private Label lblMaterialNo; private TextBox txtMaterialNo;
        private Button btnQuery;
        private Label lblPurchaseType; private TextBox txtPurchaseType;
        private Label lblCategory; private TextBox txtCategory;
        private Label lblSubCategory; private TextBox txtSubCategory;
        private Label lblProductCode; private TextBox txtProductCode;

        private Panel panelFilter2;
        private Label lblSpec; private TextBox txtSpec;
        private Label lblLength; private TextBox txtLength;
        private Label lblWidth; private TextBox txtWidth;
        private Label lblThickness; private TextBox txtThickness;
        private Label lblOuterDia; private TextBox txtOuterDia;
        private Label lblInnerDia; private TextBox txtInnerDia;

        private Panel panelGrid;
        private DataGridView dataGridView1;
        private DataGridViewButtonColumn colPicker;
        private DataGridViewComboBoxColumn colSupplierNo;
        private DataGridViewTextBoxColumn colSupplierShortName;
        private DigiERP.Common.DataGridViewDateTimePickerColumn colInquiryDate;
        private DigiERP.Common.DataGridViewNumericUpDownColumn colUnitPrice;
        private DataGridViewComboBoxColumn colCurrency;
        private DataGridViewTextBoxColumn colPurchaseUnit;
        private DigiERP.Common.DataGridViewNumericUpDownColumn colMinPurchaseQty;
        private DigiERP.Common.DataGridViewNumericUpDownColumn colPlannedPurchaseQty;
        private DataGridViewComboBoxColumn colInquiryPerson;
        private DigiERP.Common.DataGridViewDateTimePickerColumn colQuoteValidDate;
        private DataGridViewTextBoxColumn colSupplierPartNo;
        private DataGridViewButtonColumn colPrint;
        private PictureBox pictureBox1;
    }
}
