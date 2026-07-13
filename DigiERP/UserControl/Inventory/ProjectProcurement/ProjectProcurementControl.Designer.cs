using System.Drawing;
using System.Windows.Forms;

namespace DigiERP.UserControl.Inventory.ProjectProcurement
{
    partial class ProjectProcurementControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjectProcurementControl));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            lblTitle = new Label();
            btnMultiFilter = new Button();
            btnClearFilter = new Button();
            btnModify = new Button();
            btnSave = new Button();
            btnPrint = new Button();
            btnExit = new Button();
            panel3 = new Panel();
            lblHintPartNo = new Label();
            lblHintStockIn = new Label();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            colProjectNo = new DataGridViewTextBoxColumn();
            colModuleCode = new DataGridViewTextBoxColumn();
            colModuleName = new DataGridViewTextBoxColumn();
            colPartNo = new DataGridViewTextBoxColumn();
            colPartName = new DataGridViewTextBoxColumn();
            colDesc = new DataGridViewTextBoxColumn();
            colQty = new DataGridViewTextBoxColumn();
            colPartType = new DataGridViewComboBoxColumn();
            colPurchaser = new DataGridViewComboBoxColumn();
            colActualPurchaseDate = new DataGridViewTextBoxColumn();
            colExpectedArrival = new DataGridViewTextBoxColumn();
            colWarehouseStaff = new DataGridViewComboBoxColumn();
            colStockInDate = new DataGridViewTextBoxColumn();
            colInquiry = new DataGridViewButtonColumn();
            colControlNo = new DataGridViewTextBoxColumn();
            colAcceptance = new DataGridViewComboBoxColumn();
            colPurchaseId = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Cornsilk;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(lblTitle);
            panel1.Controls.Add(btnMultiFilter);
            panel1.Controls.Add(btnClearFilter);
            panel1.Controls.Add(btnModify);
            panel1.Controls.Add(btnSave);
            panel1.Controls.Add(btnPrint);
            panel1.Controls.Add(btnExit);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1900, 56);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(4, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(48, 48);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("微軟正黑體", 14F, FontStyle.Bold);
            lblTitle.ForeColor = Color.Firebrick;
            lblTitle.Location = new Point(60, 16);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(86, 24);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "採購計畫";
            // 
            // btnMultiFilter
            // 
            btnMultiFilter.BackColor = Color.Firebrick;
            btnMultiFilter.FlatStyle = FlatStyle.Flat;
            btnMultiFilter.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            btnMultiFilter.ForeColor = Color.White;
            btnMultiFilter.Location = new Point(340, 12);
            btnMultiFilter.Name = "btnMultiFilter";
            btnMultiFilter.Size = new Size(110, 32);
            btnMultiFilter.TabIndex = 1;
            btnMultiFilter.Text = "複式篩選器";
            btnMultiFilter.UseVisualStyleBackColor = false;
            btnMultiFilter.Click += btnMultiFilter_Click;
            // 
            // btnClearFilter
            // 
            btnClearFilter.BackColor = Color.Gainsboro;
            btnClearFilter.FlatStyle = FlatStyle.Flat;
            btnClearFilter.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            btnClearFilter.Location = new Point(460, 12);
            btnClearFilter.Name = "btnClearFilter";
            btnClearFilter.Size = new Size(100, 32);
            btnClearFilter.TabIndex = 2;
            btnClearFilter.Text = "清除篩選";
            btnClearFilter.UseVisualStyleBackColor = false;
            btnClearFilter.Click += btnClearFilter_Click;
            // 
            // btnModify
            // 
            btnModify.BackColor = Color.Gainsboro;
            btnModify.FlatStyle = FlatStyle.Flat;
            btnModify.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            btnModify.Location = new Point(900, 12);
            btnModify.Name = "btnModify";
            btnModify.Size = new Size(100, 32);
            btnModify.TabIndex = 3;
            btnModify.Text = "修改";
            btnModify.UseVisualStyleBackColor = false;
            btnModify.Click += btnModify_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Gainsboro;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            btnSave.Location = new Point(1010, 12);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(100, 32);
            btnSave.TabIndex = 4;
            btnSave.Text = "儲存";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnPrint
            // 
            btnPrint.BackColor = Color.Gainsboro;
            btnPrint.FlatStyle = FlatStyle.Flat;
            btnPrint.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            btnPrint.Location = new Point(1120, 12);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(100, 32);
            btnPrint.TabIndex = 5;
            btnPrint.Text = "列印";
            btnPrint.UseVisualStyleBackColor = false;
            btnPrint.Click += btnPrint_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Gainsboro;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            btnExit.Location = new Point(1230, 12);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(100, 32);
            btnExit.TabIndex = 6;
            btnExit.Text = "關閉";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(lblHintPartNo);
            panel3.Controls.Add(lblHintStockIn);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 628);
            panel3.Name = "panel3";
            panel3.Size = new Size(1900, 28);
            panel3.TabIndex = 2;
            // 
            // lblHintPartNo
            // 
            lblHintPartNo.AutoSize = true;
            lblHintPartNo.ForeColor = Color.Firebrick;
            lblHintPartNo.Location = new Point(8, 6);
            lblHintPartNo.Name = "lblHintPartNo";
            lblHintPartNo.Size = new Size(622, 18);
            lblHintPartNo.TabIndex = 0;
            lblHintPartNo.Text = "※點選欲詢價之『零件號碼』，即開啟零件組合單可查詢對應材料目前庫存狀況以利進行後續採購！";
            // 
            // lblHintStockIn
            // 
            lblHintStockIn.AutoSize = true;
            lblHintStockIn.ForeColor = Color.SteelBlue;
            lblHintStockIn.Location = new Point(636, 6);
            lblHintStockIn.Name = "lblHintStockIn";
            lblHintStockIn.Size = new Size(426, 18);
            lblHintStockIn.TabIndex = 1;
            lblHintStockIn.Text = "※點擊兩次『入庫移轉日』，即開啟材料進貨清單以進行入庫查詢！";
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridView1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 56);
            panel2.Name = "panel2";
            panel2.Size = new Size(1900, 572);
            panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colProjectNo, colModuleCode, colModuleName, colPartNo, colPartName, colDesc, colQty, colPartType, colPurchaser, colActualPurchaseDate, colExpectedArrival, colWarehouseStaff, colStockInDate, colInquiry, colControlNo, colAcceptance, colPurchaseId });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Font = new Font("微軟正黑體", 9F);
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 26;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1900, 572);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellValueChanged += dataGridView1_CellValueChanged;
            dataGridView1.CurrentCellDirtyStateChanged += dataGridView1_CurrentCellDirtyStateChanged;
            dataGridView1.DataError += dataGridView1_DataError;
            // 
            // colProjectNo
            // 
            colProjectNo.HeaderText = "專案序號";
            colProjectNo.Name = "colProjectNo";
            colProjectNo.ReadOnly = true;
            // 
            // colModuleCode
            // 
            colModuleCode.HeaderText = "模組";
            colModuleCode.Name = "colModuleCode";
            colModuleCode.ReadOnly = true;
            // 
            // colModuleName
            // 
            colModuleName.FillWeight = 120F;
            colModuleName.HeaderText = "模組名稱";
            colModuleName.Name = "colModuleName";
            colModuleName.ReadOnly = true;
            // 
            // colPartNo
            // 
            colPartNo.HeaderText = "零件號碼";
            colPartNo.Name = "colPartNo";
            colPartNo.ReadOnly = true;
            // 
            // colPartName
            // 
            colPartName.FillWeight = 120F;
            colPartName.HeaderText = "品名";
            colPartName.Name = "colPartName";
            colPartName.ReadOnly = true;
            // 
            // colDesc
            // 
            colDesc.FillWeight = 140F;
            colDesc.HeaderText = "描述";
            colDesc.Name = "colDesc";
            colDesc.ReadOnly = true;
            // 
            // colQty
            // 
            colQty.HeaderText = "數量";
            colQty.Name = "colQty";
            colQty.ReadOnly = true;
            // 
            // colPartType
            // 
            colPartType.HeaderText = "零件分類";
            colPartType.Name = "colPartType";
            colPartType.ReadOnly = true;
            // 
            // colPurchaser
            // 
            colPurchaser.HeaderText = "採購人員";
            colPurchaser.Name = "colPurchaser";
            colPurchaser.ReadOnly = true;
            // 
            // colActualPurchaseDate
            // 
            colActualPurchaseDate.HeaderText = "實際採購日";
            colActualPurchaseDate.Name = "colActualPurchaseDate";
            colActualPurchaseDate.ReadOnly = true;
            // 
            // colExpectedArrival
            // 
            colExpectedArrival.HeaderText = "預計到貨日";
            colExpectedArrival.Name = "colExpectedArrival";
            colExpectedArrival.ReadOnly = true;
            // 
            // colWarehouseStaff
            // 
            colWarehouseStaff.HeaderText = "倉管人員";
            colWarehouseStaff.Name = "colWarehouseStaff";
            colWarehouseStaff.ReadOnly = true;
            // 
            // colStockInDate
            // 
            colStockInDate.HeaderText = "入庫移轉日";
            colStockInDate.Name = "colStockInDate";
            colStockInDate.ReadOnly = true;
            // 
            // colInquiry
            // 
            colInquiry.HeaderText = "查詢進貨";
            colInquiry.Name = "colInquiry";
            colInquiry.ReadOnly = true;
            colInquiry.Text = "查詢";
            colInquiry.UseColumnTextForButtonValue = true;
            // 
            // colControlNo
            // 
            colControlNo.HeaderText = "零件管制單號";
            colControlNo.Name = "colControlNo";
            colControlNo.ReadOnly = true;
            // 
            // colAcceptance
            // 
            colAcceptance.HeaderText = "驗收結果";
            colAcceptance.Name = "colAcceptance";
            colAcceptance.ReadOnly = true;
            // 
            // colPurchaseId
            // 
            colPurchaseId.HeaderText = "採購識別碼";
            colPurchaseId.Name = "colPurchaseId";
            colPurchaseId.ReadOnly = true;
            colPurchaseId.Visible = false;
            // 
            // ProjectProcurementControl
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Font = new Font("微軟正黑體", 10F);
            Margin = new Padding(4);
            Name = "ProjectProcurementControl";
            Size = new Size(1900, 656);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label lblTitle;
        private Button btnMultiFilter;
        private Button btnClearFilter;
        private Button btnModify;
        private Button btnSave;
        private Button btnPrint;
        private Button btnExit;
        private Panel panel3;
        private Label lblHintPartNo;
        private Label lblHintStockIn;
        private Panel panel2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn colProjectNo;
        private DataGridViewTextBoxColumn colModuleCode;
        private DataGridViewTextBoxColumn colModuleName;
        private DataGridViewTextBoxColumn colPartNo;
        private DataGridViewTextBoxColumn colPartName;
        private DataGridViewTextBoxColumn colDesc;
        private DataGridViewTextBoxColumn colQty;
        private DataGridViewComboBoxColumn colPartType;
        private DataGridViewComboBoxColumn colPurchaser;
        private DataGridViewTextBoxColumn colActualPurchaseDate;
        private DataGridViewTextBoxColumn colExpectedArrival;
        private DataGridViewComboBoxColumn colWarehouseStaff;
        private DataGridViewTextBoxColumn colStockInDate;
        private DataGridViewButtonColumn colInquiry;
        private DataGridViewTextBoxColumn colControlNo;
        private DataGridViewComboBoxColumn colAcceptance;
        private DataGridViewTextBoxColumn colPurchaseId;
    }
}
