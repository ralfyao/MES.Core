using System.Drawing;
using System.Windows.Forms;

namespace DigiERP.Forms.Production
{
    partial class FrmMaterialRequisitionList
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
            panel1 = new Panel();
            lblTitle = new Label();
            btnEdit = new Button();
            btnSave = new Button();
            btnPrint = new Button();
            btnExit = new Button();
            panel2 = new Panel();
            lblProjectNo = new Label();
            txtProjectNo = new TextBox();
            lblModuleCode = new Label();
            txtModuleCode = new TextBox();
            lblModuleName = new Label();
            txtModuleName = new TextBox();
            lblBomNo = new Label();
            txtBomNo = new TextBox();
            dataGridView1 = new DataGridView();
            colTxnDate = new Common.DataGridViewDateTimePickerColumn();
            colProductNo = new DataGridViewTextBoxColumn();
            colSpec = new DataGridViewTextBoxColumn();
            colSummary = new DataGridViewTextBoxColumn();
            colControlNo = new DataGridViewTextBoxColumn();
            colSource = new DataGridViewTextBoxColumn();
            colUnit = new DataGridViewTextBoxColumn();
            colStockIn = new DataGridViewTextBoxColumn();
            colStockOut = new DataGridViewTextBoxColumn();
            colLocation = new DataGridViewTextBoxColumn();
            colUnitPrice = new DataGridViewTextBoxColumn();
            colRequester = new DataGridViewTextBoxColumn();
            colLength = new DataGridViewTextBoxColumn();
            colErpDocNo = new DataGridViewTextBoxColumn();
            colRemark = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Honeydew;
            panel1.Controls.Add(lblTitle);
            panel1.Controls.Add(btnEdit);
            panel1.Controls.Add(btnSave);
            panel1.Controls.Add(btnPrint);
            panel1.Controls.Add(btnExit);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1192, 56);
            panel1.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("微軟正黑體", 13F, FontStyle.Bold);
            lblTitle.Location = new Point(16, 16);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(118, 23);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "材料領用清單";
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.LightSteelBlue;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            btnEdit.Location = new Point(500, 12);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(90, 32);
            btnEdit.TabIndex = 1;
            btnEdit.Text = "修改";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.LightSteelBlue;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            btnSave.Location = new Point(598, 12);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(90, 32);
            btnSave.TabIndex = 2;
            btnSave.Text = "儲存";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnPrint
            // 
            btnPrint.BackColor = Color.LightGray;
            btnPrint.FlatStyle = FlatStyle.Flat;
            btnPrint.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            btnPrint.Location = new Point(696, 12);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(90, 32);
            btnPrint.TabIndex = 3;
            btnPrint.Text = "列印";
            btnPrint.UseVisualStyleBackColor = false;
            btnPrint.Click += btnPrint_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.LightSteelBlue;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            btnExit.Location = new Point(794, 12);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(98, 32);
            btnExit.TabIndex = 4;
            btnExit.Text = "關閉";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(lblProjectNo);
            panel2.Controls.Add(txtProjectNo);
            panel2.Controls.Add(lblModuleCode);
            panel2.Controls.Add(txtModuleCode);
            panel2.Controls.Add(lblModuleName);
            panel2.Controls.Add(txtModuleName);
            panel2.Controls.Add(lblBomNo);
            panel2.Controls.Add(txtBomNo);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 56);
            panel2.Name = "panel2";
            panel2.Size = new Size(1192, 56);
            panel2.TabIndex = 1;
            // 
            // lblProjectNo
            // 
            lblProjectNo.AutoSize = true;
            lblProjectNo.Location = new Point(10, 16);
            lblProjectNo.Name = "lblProjectNo";
            lblProjectNo.Size = new Size(64, 18);
            lblProjectNo.TabIndex = 0;
            lblProjectNo.Text = "專案序號";
            // 
            // txtProjectNo
            // 
            txtProjectNo.Location = new Point(90, 13);
            txtProjectNo.Name = "txtProjectNo";
            txtProjectNo.ReadOnly = true;
            txtProjectNo.Size = new Size(120, 25);
            txtProjectNo.TabIndex = 1;
            // 
            // lblModuleCode
            // 
            lblModuleCode.AutoSize = true;
            lblModuleCode.Location = new Point(226, 16);
            lblModuleCode.Name = "lblModuleCode";
            lblModuleCode.Size = new Size(64, 18);
            lblModuleCode.TabIndex = 2;
            lblModuleCode.Text = "模組編碼";
            // 
            // txtModuleCode
            // 
            txtModuleCode.Location = new Point(306, 13);
            txtModuleCode.Name = "txtModuleCode";
            txtModuleCode.ReadOnly = true;
            txtModuleCode.Size = new Size(120, 25);
            txtModuleCode.TabIndex = 3;
            // 
            // lblModuleName
            // 
            lblModuleName.AutoSize = true;
            lblModuleName.Location = new Point(442, 16);
            lblModuleName.Name = "lblModuleName";
            lblModuleName.Size = new Size(64, 18);
            lblModuleName.TabIndex = 4;
            lblModuleName.Text = "模組名稱";
            // 
            // txtModuleName
            // 
            txtModuleName.Location = new Point(522, 13);
            txtModuleName.Name = "txtModuleName";
            txtModuleName.ReadOnly = true;
            txtModuleName.Size = new Size(180, 25);
            txtModuleName.TabIndex = 5;
            // 
            // lblBomNo
            // 
            lblBomNo.AutoSize = true;
            lblBomNo.Location = new Point(716, 16);
            lblBomNo.Name = "lblBomNo";
            lblBomNo.Size = new Size(70, 18);
            lblBomNo.TabIndex = 6;
            lblBomNo.Text = "BOM編號";
            // 
            // txtBomNo
            // 
            txtBomNo.Location = new Point(800, 12);
            txtBomNo.Name = "txtBomNo";
            txtBomNo.ReadOnly = true;
            txtBomNo.Size = new Size(160, 25);
            txtBomNo.TabIndex = 7;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colTxnDate, colProductNo, colSpec, colSummary, colControlNo, colSource, colUnit, colStockIn, colStockOut, colLocation, colUnitPrice, colRequester, colLength, colErpDocNo, colRemark });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Font = new Font("微軟正黑體", 9F);
            dataGridView1.Location = new Point(0, 112);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 26;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1192, 288);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // colTxnDate
            // 
            colTxnDate.HeaderText = "異動日期";
            colTxnDate.Name = "colTxnDate";
            // 
            // colProductNo
            // 
            colProductNo.HeaderText = "產品編號";
            colProductNo.Name = "colProductNo";
            colProductNo.ReadOnly = true;
            // 
            // colSpec
            // 
            colSpec.FillWeight = 150F;
            colSpec.HeaderText = "品名規格";
            colSpec.Name = "colSpec";
            colSpec.ReadOnly = true;
            // 
            // colSummary
            // 
            colSummary.HeaderText = "摘要";
            colSummary.Name = "colSummary";
            colSummary.ReadOnly = true;
            // 
            // colControlNo
            // 
            colControlNo.FillWeight = 130F;
            colControlNo.HeaderText = "管制單號";
            colControlNo.Name = "colControlNo";
            colControlNo.ReadOnly = true;
            // 
            // colSource
            // 
            colSource.FillWeight = 130F;
            colSource.HeaderText = "來源用途";
            colSource.Name = "colSource";
            // 
            // colUnit
            // 
            colUnit.HeaderText = "單位";
            colUnit.Name = "colUnit";
            // 
            // colStockIn
            // 
            colStockIn.HeaderText = "入庫";
            colStockIn.Name = "colStockIn";
            // 
            // colStockOut
            // 
            colStockOut.HeaderText = "出庫";
            colStockOut.Name = "colStockOut";
            // 
            // colLocation
            // 
            colLocation.HeaderText = "儲位";
            colLocation.Name = "colLocation";
            // 
            // colUnitPrice
            // 
            colUnitPrice.HeaderText = "單價";
            colUnitPrice.Name = "colUnitPrice";
            // 
            // colRequester
            // 
            colRequester.HeaderText = "領用人";
            colRequester.Name = "colRequester";
            // 
            // colLength
            // 
            colLength.HeaderText = "領用長度";
            colLength.Name = "colLength";
            // 
            // colErpDocNo
            // 
            colErpDocNo.FillWeight = 130F;
            colErpDocNo.HeaderText = "ERP領料單號";
            colErpDocNo.Name = "colErpDocNo";
            // 
            // colRemark
            // 
            colRemark.FillWeight = 130F;
            colRemark.HeaderText = "備註";
            colRemark.Name = "colRemark";
            // 
            // FrmMaterialRequisitionList
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1192, 400);
            Controls.Add(dataGridView1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("微軟正黑體", 10F);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MinimumSize = new Size(700, 300);
            Name = "FrmMaterialRequisitionList";
            StartPosition = FormStartPosition.CenterParent;
            Text = "材料領用清單";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblTitle;
        private Button btnEdit;
        private Button btnSave;
        private Button btnPrint;
        private Button btnExit;
        private Panel panel2;
        private Label lblProjectNo;
        private TextBox txtProjectNo;
        private Label lblModuleCode;
        private TextBox txtModuleCode;
        private Label lblModuleName;
        private TextBox txtModuleName;
        private Label lblBomNo;
        private TextBox txtBomNo;
        private DataGridView dataGridView1;
        private DigiERP.Common.DataGridViewDateTimePickerColumn colTxnDate;
        private DataGridViewTextBoxColumn colProductNo;
        private DataGridViewTextBoxColumn colSpec;
        private DataGridViewTextBoxColumn colSummary;
        private DataGridViewTextBoxColumn colControlNo;
        private DataGridViewTextBoxColumn colSource;
        private DataGridViewTextBoxColumn colUnit;
        private DataGridViewTextBoxColumn colStockIn;
        private DataGridViewTextBoxColumn colStockOut;
        private DataGridViewTextBoxColumn colLocation;
        private DataGridViewTextBoxColumn colUnitPrice;
        private DataGridViewTextBoxColumn colRequester;
        private DataGridViewTextBoxColumn colLength;
        private DataGridViewTextBoxColumn colErpDocNo;
        private DataGridViewTextBoxColumn colRemark;
    }
}
