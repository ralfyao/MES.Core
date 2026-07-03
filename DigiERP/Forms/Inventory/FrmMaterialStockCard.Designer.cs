namespace DigiERP.Forms.Inventory
{
    partial class FrmMaterialStockCard
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
            btnEditPart = new Button();
            btnEditTransaction = new Button();
            btnSaveRecord = new Button();
            btnExit = new Button();
            panelHeader = new Panel();
            lblCode = new Label();
            txtCode = new TextBox();
            lblType = new Label();
            txtType = new TextBox();
            lblCategory = new Label();
            txtCategory = new TextBox();
            lblSubCategory = new Label();
            txtSubCategory = new TextBox();
            lblProductCode = new Label();
            txtProductCode = new TextBox();
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
            colDate = new DigiERP.Common.DataGridViewDateTimePickerColumn();
            colSummary = new DataGridViewComboBoxColumn();
            colSource = new DataGridViewTextBoxColumn();
            colUnit = new DataGridViewTextBoxColumn();
            colStockIn = new DataGridViewTextBoxColumn();
            colStockOut = new DataGridViewTextBoxColumn();
            colLocation = new DataGridViewTextBoxColumn();
            colOperator = new DataGridViewComboBoxColumn();
            colRemark = new DataGridViewTextBoxColumn();
            panelFooter = new Panel();
            lblTotal = new Label();
            txtStockInTotal = new TextBox();
            txtStockOutTotal = new TextBox();
            lblBalance = new Label();
            txtBalance = new TextBox();
            panelToolbar.SuspendLayout();
            panelHeader.SuspendLayout();
            panelGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panelFooter.SuspendLayout();
            SuspendLayout();
            //
            // panelToolbar
            //
            panelToolbar.BackColor = Color.FromArgb(255, 222, 173);
            panelToolbar.Controls.Add(lblTitle);
            panelToolbar.Controls.Add(btnEditPart);
            panelToolbar.Controls.Add(btnEditTransaction);
            panelToolbar.Controls.Add(btnSaveRecord);
            panelToolbar.Controls.Add(btnExit);
            panelToolbar.Dock = DockStyle.Top;
            panelToolbar.Location = new Point(0, 0);
            panelToolbar.Name = "panelToolbar";
            panelToolbar.Size = new Size(1040, 56);
            panelToolbar.TabIndex = 0;
            //
            // lblTitle
            //
            lblTitle.Font = new Font("微軟正黑體", 14F, FontStyle.Bold);
            lblTitle.Location = new Point(16, 14);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(140, 28);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "材料庫存卡";
            //
            // btnEditPart
            //
            btnEditPart.BackColor = Color.SteelBlue;
            btnEditPart.FlatStyle = FlatStyle.Flat;
            btnEditPart.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            btnEditPart.ForeColor = Color.White;
            btnEditPart.Location = new Point(300, 10);
            btnEditPart.Name = "btnEditPart";
            btnEditPart.Size = new Size(110, 36);
            btnEditPart.TabIndex = 1;
            btnEditPart.Text = "編修料品";
            btnEditPart.UseVisualStyleBackColor = false;
            btnEditPart.Click += btnEditPart_Click;
            //
            // btnEditTransaction
            //
            btnEditTransaction.BackColor = Color.SteelBlue;
            btnEditTransaction.FlatStyle = FlatStyle.Flat;
            btnEditTransaction.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            btnEditTransaction.ForeColor = Color.White;
            btnEditTransaction.Location = new Point(420, 10);
            btnEditTransaction.Name = "btnEditTransaction";
            btnEditTransaction.Size = new Size(110, 36);
            btnEditTransaction.TabIndex = 2;
            btnEditTransaction.Text = "異動編修";
            btnEditTransaction.UseVisualStyleBackColor = false;
            btnEditTransaction.Click += btnEditTransaction_Click;
            //
            // btnSaveRecord
            //
            btnSaveRecord.BackColor = Color.SteelBlue;
            btnSaveRecord.FlatStyle = FlatStyle.Flat;
            btnSaveRecord.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            btnSaveRecord.ForeColor = Color.White;
            btnSaveRecord.Location = new Point(540, 10);
            btnSaveRecord.Name = "btnSaveRecord";
            btnSaveRecord.Size = new Size(110, 36);
            btnSaveRecord.TabIndex = 3;
            btnSaveRecord.Text = "儲存紀錄";
            btnSaveRecord.UseVisualStyleBackColor = false;
            btnSaveRecord.Click += btnSaveRecord_Click;
            //
            // btnExit
            //
            btnExit.BackColor = Color.FromArgb(150, 150, 180);
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            btnExit.ForeColor = Color.White;
            btnExit.Location = new Point(940, 10);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(90, 36);
            btnExit.TabIndex = 4;
            btnExit.Text = "EXIT";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            //
            // panelHeader
            //
            panelHeader.BackColor = Color.FromArgb(255, 248, 240);
            panelHeader.Controls.Add(lblCode);
            panelHeader.Controls.Add(txtCode);
            panelHeader.Controls.Add(lblType);
            panelHeader.Controls.Add(txtType);
            panelHeader.Controls.Add(lblCategory);
            panelHeader.Controls.Add(txtCategory);
            panelHeader.Controls.Add(lblSubCategory);
            panelHeader.Controls.Add(txtSubCategory);
            panelHeader.Controls.Add(lblProductCode);
            panelHeader.Controls.Add(txtProductCode);
            panelHeader.Controls.Add(lblSpec);
            panelHeader.Controls.Add(txtSpec);
            panelHeader.Controls.Add(lblLength);
            panelHeader.Controls.Add(txtLength);
            panelHeader.Controls.Add(lblWidth);
            panelHeader.Controls.Add(txtWidth);
            panelHeader.Controls.Add(lblThickness);
            panelHeader.Controls.Add(txtThickness);
            panelHeader.Controls.Add(lblOuterDia);
            panelHeader.Controls.Add(txtOuterDia);
            panelHeader.Controls.Add(lblInnerDia);
            panelHeader.Controls.Add(txtInnerDia);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 56);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1040, 80);
            panelHeader.TabIndex = 1;
            //
            // lblCode
            //
            lblCode.AutoSize = true;
            lblCode.Font = new Font("微軟正黑體", 10F);
            lblCode.Location = new Point(8, 12);
            lblCode.Name = "lblCode";
            lblCode.Size = new Size(60, 18);
            lblCode.TabIndex = 0;
            lblCode.Text = "材料編號";
            //
            // txtCode
            //
            txtCode.BackColor = Color.WhiteSmoke;
            txtCode.Font = new Font("微軟正黑體", 10F);
            txtCode.Location = new Point(70, 8);
            txtCode.Name = "txtCode";
            txtCode.ReadOnly = true;
            txtCode.Size = new Size(150, 25);
            txtCode.TabIndex = 1;
            //
            // lblType
            //
            lblType.AutoSize = true;
            lblType.Font = new Font("微軟正黑體", 10F);
            lblType.Location = new Point(230, 12);
            lblType.Name = "lblType";
            lblType.Size = new Size(60, 18);
            lblType.TabIndex = 2;
            lblType.Text = "市購品別";
            //
            // txtType
            //
            txtType.BackColor = Color.WhiteSmoke;
            txtType.Font = new Font("微軟正黑體", 10F);
            txtType.Location = new Point(294, 8);
            txtType.Name = "txtType";
            txtType.ReadOnly = true;
            txtType.Size = new Size(110, 25);
            txtType.TabIndex = 3;
            //
            // lblCategory
            //
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("微軟正黑體", 10F);
            lblCategory.Location = new Point(414, 12);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(50, 18);
            lblCategory.TabIndex = 4;
            lblCategory.Text = "大分類";
            //
            // txtCategory
            //
            txtCategory.BackColor = Color.WhiteSmoke;
            txtCategory.Font = new Font("微軟正黑體", 10F);
            txtCategory.Location = new Point(466, 8);
            txtCategory.Name = "txtCategory";
            txtCategory.ReadOnly = true;
            txtCategory.Size = new Size(60, 25);
            txtCategory.TabIndex = 5;
            //
            // lblSubCategory
            //
            lblSubCategory.AutoSize = true;
            lblSubCategory.Font = new Font("微軟正黑體", 10F);
            lblSubCategory.Location = new Point(536, 12);
            lblSubCategory.Name = "lblSubCategory";
            lblSubCategory.Size = new Size(50, 18);
            lblSubCategory.TabIndex = 6;
            lblSubCategory.Text = "小分類";
            //
            // txtSubCategory
            //
            txtSubCategory.BackColor = Color.WhiteSmoke;
            txtSubCategory.Font = new Font("微軟正黑體", 10F);
            txtSubCategory.Location = new Point(588, 8);
            txtSubCategory.Name = "txtSubCategory";
            txtSubCategory.ReadOnly = true;
            txtSubCategory.Size = new Size(60, 25);
            txtSubCategory.TabIndex = 7;
            //
            // lblProductCode
            //
            lblProductCode.AutoSize = true;
            lblProductCode.Font = new Font("微軟正黑體", 10F);
            lblProductCode.Location = new Point(658, 12);
            lblProductCode.Name = "lblProductCode";
            lblProductCode.Size = new Size(60, 18);
            lblProductCode.TabIndex = 8;
            lblProductCode.Text = "產品代號";
            //
            // txtProductCode
            //
            txtProductCode.BackColor = Color.WhiteSmoke;
            txtProductCode.Font = new Font("微軟正黑體", 10F);
            txtProductCode.Location = new Point(720, 8);
            txtProductCode.Name = "txtProductCode";
            txtProductCode.ReadOnly = true;
            txtProductCode.Size = new Size(270, 25);
            txtProductCode.TabIndex = 9;
            //
            // lblSpec
            //
            lblSpec.AutoSize = true;
            lblSpec.Font = new Font("微軟正黑體", 10F);
            lblSpec.Location = new Point(8, 48);
            lblSpec.Name = "lblSpec";
            lblSpec.Size = new Size(60, 18);
            lblSpec.TabIndex = 10;
            lblSpec.Text = "品名規格";
            //
            // txtSpec
            //
            txtSpec.BackColor = Color.WhiteSmoke;
            txtSpec.Font = new Font("微軟正黑體", 10F);
            txtSpec.Location = new Point(70, 44);
            txtSpec.Name = "txtSpec";
            txtSpec.ReadOnly = true;
            txtSpec.Size = new Size(340, 25);
            txtSpec.TabIndex = 11;
            //
            // lblLength
            //
            lblLength.AutoSize = true;
            lblLength.Font = new Font("微軟正黑體", 10F);
            lblLength.Location = new Point(420, 48);
            lblLength.Name = "lblLength";
            lblLength.Size = new Size(60, 18);
            lblLength.TabIndex = 12;
            lblLength.Text = "外尺寸長";
            //
            // txtLength
            //
            txtLength.BackColor = Color.WhiteSmoke;
            txtLength.Font = new Font("微軟正黑體", 10F);
            txtLength.Location = new Point(484, 44);
            txtLength.Name = "txtLength";
            txtLength.ReadOnly = true;
            txtLength.Size = new Size(70, 25);
            txtLength.TabIndex = 13;
            //
            // lblWidth
            //
            lblWidth.AutoSize = true;
            lblWidth.Font = new Font("微軟正黑體", 10F);
            lblWidth.Location = new Point(564, 48);
            lblWidth.Name = "lblWidth";
            lblWidth.Size = new Size(60, 18);
            lblWidth.TabIndex = 14;
            lblWidth.Text = "外尺寸寬";
            //
            // txtWidth
            //
            txtWidth.BackColor = Color.WhiteSmoke;
            txtWidth.Font = new Font("微軟正黑體", 10F);
            txtWidth.Location = new Point(628, 44);
            txtWidth.Name = "txtWidth";
            txtWidth.ReadOnly = true;
            txtWidth.Size = new Size(70, 25);
            txtWidth.TabIndex = 15;
            //
            // lblThickness
            //
            lblThickness.AutoSize = true;
            lblThickness.Font = new Font("微軟正黑體", 10F);
            lblThickness.Location = new Point(708, 48);
            lblThickness.Name = "lblThickness";
            lblThickness.Size = new Size(40, 18);
            lblThickness.TabIndex = 16;
            lblThickness.Text = "厚度";
            //
            // txtThickness
            //
            txtThickness.BackColor = Color.WhiteSmoke;
            txtThickness.Font = new Font("微軟正黑體", 10F);
            txtThickness.Location = new Point(752, 44);
            txtThickness.Name = "txtThickness";
            txtThickness.ReadOnly = true;
            txtThickness.Size = new Size(60, 25);
            txtThickness.TabIndex = 17;
            //
            // lblOuterDia
            //
            lblOuterDia.AutoSize = true;
            lblOuterDia.Font = new Font("微軟正黑體", 10F);
            lblOuterDia.Location = new Point(822, 48);
            lblOuterDia.Name = "lblOuterDia";
            lblOuterDia.Size = new Size(40, 18);
            lblOuterDia.TabIndex = 18;
            lblOuterDia.Text = "外徑";
            //
            // txtOuterDia
            //
            txtOuterDia.BackColor = Color.WhiteSmoke;
            txtOuterDia.Font = new Font("微軟正黑體", 10F);
            txtOuterDia.Location = new Point(866, 44);
            txtOuterDia.Name = "txtOuterDia";
            txtOuterDia.ReadOnly = true;
            txtOuterDia.Size = new Size(60, 25);
            txtOuterDia.TabIndex = 19;
            //
            // lblInnerDia
            //
            lblInnerDia.AutoSize = true;
            lblInnerDia.Font = new Font("微軟正黑體", 10F);
            lblInnerDia.Location = new Point(936, 48);
            lblInnerDia.Name = "lblInnerDia";
            lblInnerDia.Size = new Size(40, 18);
            lblInnerDia.TabIndex = 20;
            lblInnerDia.Text = "內徑";
            //
            // txtInnerDia
            //
            txtInnerDia.BackColor = Color.WhiteSmoke;
            txtInnerDia.Font = new Font("微軟正黑體", 10F);
            txtInnerDia.Location = new Point(978, 44);
            txtInnerDia.Name = "txtInnerDia";
            txtInnerDia.ReadOnly = true;
            txtInnerDia.Size = new Size(54, 25);
            txtInnerDia.TabIndex = 21;
            //
            // panelGrid
            //
            panelGrid.Controls.Add(dataGridView1);
            panelGrid.Dock = DockStyle.Fill;
            panelGrid.Location = new Point(0, 136);
            panelGrid.Name = "panelGrid";
            panelGrid.Size = new Size(1040, 424);
            panelGrid.TabIndex = 2;
            //
            // dataGridView1
            //
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] {
                colDate, colSummary, colSource, colUnit, colStockIn, colStockOut, colLocation, colOperator, colRemark
            });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Font = new Font("微軟正黑體", 10F);
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = false;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 26;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1040, 424);
            dataGridView1.TabIndex = 0;
            //
            // colDate
            //
            colDate.FillWeight = 70F;
            colDate.HeaderText = "異動日期";
            colDate.Name = "colDate";
            //
            // colSummary
            //
            colSummary.FillWeight = 60F;
            colSummary.HeaderText = "摘要";
            colSummary.Name = "colSummary";
            colSummary.Items.AddRange(new object[] { "進料", "退料", "領料", "報廢", "盤盈", "盤損", "盤存週期" });
            //
            // colSource
            //
            colSource.FillWeight = 100F;
            colSource.HeaderText = "來源用途";
            colSource.Name = "colSource";
            //
            // colUnit
            //
            colUnit.FillWeight = 50F;
            colUnit.HeaderText = "單位";
            colUnit.Name = "colUnit";
            //
            // colStockIn
            //
            colStockIn.FillWeight = 60F;
            colStockIn.HeaderText = "入庫";
            colStockIn.Name = "colStockIn";
            //
            // colStockOut
            //
            colStockOut.FillWeight = 60F;
            colStockOut.HeaderText = "出庫";
            colStockOut.Name = "colStockOut";
            //
            // colLocation
            //
            colLocation.FillWeight = 60F;
            colLocation.HeaderText = "儲位";
            colLocation.Name = "colLocation";
            //
            // colOperator
            //
            colOperator.FillWeight = 70F;
            colOperator.HeaderText = "異動人員";
            colOperator.Name = "colOperator";
            //
            // colRemark
            //
            colRemark.FillWeight = 100F;
            colRemark.HeaderText = "備註";
            colRemark.Name = "colRemark";
            //
            // panelFooter
            //
            panelFooter.BackColor = Color.FromArgb(255, 248, 220);
            panelFooter.Controls.Add(lblTotal);
            panelFooter.Controls.Add(txtStockInTotal);
            panelFooter.Controls.Add(txtStockOutTotal);
            panelFooter.Controls.Add(lblBalance);
            panelFooter.Controls.Add(txtBalance);
            panelFooter.Dock = DockStyle.Bottom;
            panelFooter.Location = new Point(0, 560);
            panelFooter.Name = "panelFooter";
            panelFooter.Size = new Size(1040, 40);
            panelFooter.TabIndex = 3;
            //
            // lblTotal
            //
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            lblTotal.Location = new Point(360, 12);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(44, 18);
            lblTotal.TabIndex = 0;
            lblTotal.Text = "合計:";
            //
            // txtStockInTotal
            //
            txtStockInTotal.BackColor = Color.WhiteSmoke;
            txtStockInTotal.Font = new Font("微軟正黑體", 10F);
            txtStockInTotal.Location = new Point(410, 8);
            txtStockInTotal.Name = "txtStockInTotal";
            txtStockInTotal.ReadOnly = true;
            txtStockInTotal.Size = new Size(100, 25);
            txtStockInTotal.TabIndex = 1;
            txtStockInTotal.TextAlign = HorizontalAlignment.Right;
            //
            // txtStockOutTotal
            //
            txtStockOutTotal.BackColor = Color.WhiteSmoke;
            txtStockOutTotal.Font = new Font("微軟正黑體", 10F);
            txtStockOutTotal.Location = new Point(520, 8);
            txtStockOutTotal.Name = "txtStockOutTotal";
            txtStockOutTotal.ReadOnly = true;
            txtStockOutTotal.Size = new Size(100, 25);
            txtStockOutTotal.TabIndex = 2;
            txtStockOutTotal.TextAlign = HorizontalAlignment.Right;
            //
            // lblBalance
            //
            lblBalance.AutoSize = true;
            lblBalance.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            lblBalance.Location = new Point(640, 12);
            lblBalance.Name = "lblBalance";
            lblBalance.Size = new Size(44, 18);
            lblBalance.TabIndex = 3;
            lblBalance.Text = "結餘:";
            //
            // txtBalance
            //
            txtBalance.BackColor = Color.PaleGreen;
            txtBalance.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            txtBalance.Location = new Point(690, 8);
            txtBalance.Name = "txtBalance";
            txtBalance.ReadOnly = true;
            txtBalance.Size = new Size(100, 25);
            txtBalance.TabIndex = 4;
            txtBalance.TextAlign = HorizontalAlignment.Right;
            //
            // FrmMaterialStockCard
            //
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1040, 600);
            Controls.Add(panelGrid);
            Controls.Add(panelFooter);
            Controls.Add(panelHeader);
            Controls.Add(panelToolbar);
            Font = new Font("微軟正黑體", 10F);
            FormBorderStyle = FormBorderStyle.Sizable;
            MinimumSize = new Size(900, 500);
            Name = "FrmMaterialStockCard";
            StartPosition = FormStartPosition.CenterParent;
            Text = "材料庫存卡";
            panelToolbar.ResumeLayout(false);
            panelToolbar.PerformLayout();
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panelFooter.ResumeLayout(false);
            panelFooter.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelToolbar;
        private Label lblTitle;
        private Button btnEditPart;
        private Button btnEditTransaction;
        private Button btnSaveRecord;
        private Button btnExit;

        private Panel panelHeader;
        private Label lblCode; private TextBox txtCode;
        private Label lblType; private TextBox txtType;
        private Label lblCategory; private TextBox txtCategory;
        private Label lblSubCategory; private TextBox txtSubCategory;
        private Label lblProductCode; private TextBox txtProductCode;
        private Label lblSpec; private TextBox txtSpec;
        private Label lblLength; private TextBox txtLength;
        private Label lblWidth; private TextBox txtWidth;
        private Label lblThickness; private TextBox txtThickness;
        private Label lblOuterDia; private TextBox txtOuterDia;
        private Label lblInnerDia; private TextBox txtInnerDia;

        private Panel panelGrid;
        private DataGridView dataGridView1;
        private DigiERP.Common.DataGridViewDateTimePickerColumn colDate;
        private DataGridViewComboBoxColumn colSummary;
        private DataGridViewTextBoxColumn colSource;
        private DataGridViewTextBoxColumn colUnit;
        private DataGridViewTextBoxColumn colStockIn;
        private DataGridViewTextBoxColumn colStockOut;
        private DataGridViewTextBoxColumn colLocation;
        private DataGridViewComboBoxColumn colOperator;
        private DataGridViewTextBoxColumn colRemark;

        private Panel panelFooter;
        private Label lblTotal; private TextBox txtStockInTotal; private TextBox txtStockOutTotal;
        private Label lblBalance; private TextBox txtBalance;
    }
}
