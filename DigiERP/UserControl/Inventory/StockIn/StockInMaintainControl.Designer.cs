using System.Drawing;
using System.Windows.Forms;

namespace DigiERP.UserControl.Inventory.StockIn
{
    partial class StockInMaintainControl
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
            panelToolbar = new Panel();
            lblTitle = new Label();
            btnAllocate = new Button();
            btnVoucher = new Button();
            btnDeleteRecord = new Button();
            btnAddNew = new Button();
            btnModify = new Button();
            btnSave = new Button();
            btnReview = new Button();
            btnCancelReview = new Button();
            btnPrint = new Button();
            btnOverview = new Button();
            btnClose = new Button();
            lblMode = new Label();
            panelHeader = new Panel();
            lblDate = new Label();
            dtDate = new DateTimePicker();
            lblNo = new Label();
            txtNo = new TextBox();
            lblWarehouseWorker = new Label();
            cboWarehouseWorker = new ComboBox();
            lblWarehouseWorkerName = new Label();
            lblReviewer = new Label();
            txtReviewer = new TextBox();
            lblReviewDate = new Label();
            txtReviewDate = new TextBox();
            lblVoucher = new Label();
            txtVoucher = new TextBox();
            lblNote = new Label();
            txtNote = new TextBox();
            panelGrid = new Panel();
            dgvDetail = new DataGridView();
            colItemNo = new DataGridViewTextBoxColumn();
            colItemSpec = new DataGridViewTextBoxColumn();
            colUnit = new DataGridViewTextBoxColumn();
            colSupplierNo = new DataGridViewTextBoxColumn();
            colSupplierShortName = new DataGridViewTextBoxColumn();
            colPurchaseQty = new DataGridViewTextBoxColumn();
            colReceiveQty = new DataGridViewTextBoxColumn();
            colQualifiedQty = new DataGridViewTextBoxColumn();
            colSpecialQty = new DataGridViewTextBoxColumn();
            colReturnQty = new DataGridViewTextBoxColumn();
            colSample = new DataGridViewCheckBoxColumn();
            colBatchNo = new DataGridViewTextBoxColumn();
            colProject = new DataGridViewTextBoxColumn();
            colPurchaseNo = new DataGridViewTextBoxColumn();
            colActualPrice = new DataGridViewTextBoxColumn();
            colDiscountAmt = new DataGridViewTextBoxColumn();
            colPaymentAmt = new DataGridViewTextBoxColumn();
            panelToolbar.SuspendLayout();
            panelHeader.SuspendLayout();
            panelGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDetail).BeginInit();
            SuspendLayout();
            // 
            // panelToolbar
            // 
            panelToolbar.BackColor = Color.WhiteSmoke;
            panelToolbar.Controls.Add(lblTitle);
            panelToolbar.Controls.Add(btnAllocate);
            panelToolbar.Controls.Add(btnVoucher);
            panelToolbar.Controls.Add(btnDeleteRecord);
            panelToolbar.Controls.Add(btnAddNew);
            panelToolbar.Controls.Add(btnModify);
            panelToolbar.Controls.Add(btnSave);
            panelToolbar.Controls.Add(btnReview);
            panelToolbar.Controls.Add(btnCancelReview);
            panelToolbar.Controls.Add(btnPrint);
            panelToolbar.Controls.Add(btnOverview);
            panelToolbar.Controls.Add(btnClose);
            panelToolbar.Controls.Add(lblMode);
            panelToolbar.Dock = DockStyle.Top;
            panelToolbar.Location = new Point(0, 0);
            panelToolbar.Name = "panelToolbar";
            panelToolbar.Size = new Size(1420, 44);
            panelToolbar.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("微軟正黑體", 12F, FontStyle.Bold);
            lblTitle.Location = new Point(50, 10);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(58, 21);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "進貨單";
            // 
            // btnAllocate
            // 
            btnAllocate.BackColor = Color.SteelBlue;
            btnAllocate.FlatStyle = FlatStyle.Flat;
            btnAllocate.ForeColor = Color.White;
            btnAllocate.Location = new Point(130, 8);
            btnAllocate.Name = "btnAllocate";
            btnAllocate.Size = new Size(90, 28);
            btnAllocate.TabIndex = 1;
            btnAllocate.Text = "採購分配";
            btnAllocate.UseVisualStyleBackColor = false;
            btnAllocate.Click += btnAllocate_Click;
            // 
            // btnVoucher
            // 
            btnVoucher.BackColor = Color.Gainsboro;
            btnVoucher.FlatStyle = FlatStyle.Flat;
            btnVoucher.Location = new Point(228, 8);
            btnVoucher.Name = "btnVoucher";
            btnVoucher.Size = new Size(90, 28);
            btnVoucher.TabIndex = 2;
            btnVoucher.Text = "會計傳票";
            btnVoucher.UseVisualStyleBackColor = false;
            btnVoucher.Click += btnVoucher_Click;
            // 
            // btnDeleteRecord
            // 
            btnDeleteRecord.BackColor = Color.Firebrick;
            btnDeleteRecord.FlatStyle = FlatStyle.Flat;
            btnDeleteRecord.ForeColor = Color.White;
            btnDeleteRecord.Location = new Point(326, 8);
            btnDeleteRecord.Name = "btnDeleteRecord";
            btnDeleteRecord.Size = new Size(90, 28);
            btnDeleteRecord.TabIndex = 3;
            btnDeleteRecord.Text = "刪除紀錄";
            btnDeleteRecord.UseVisualStyleBackColor = false;
            btnDeleteRecord.Click += btnDeleteRecord_Click;
            // 
            // btnAddNew
            // 
            btnAddNew.BackColor = Color.Gainsboro;
            btnAddNew.FlatStyle = FlatStyle.Flat;
            btnAddNew.Location = new Point(424, 8);
            btnAddNew.Name = "btnAddNew";
            btnAddNew.Size = new Size(80, 28);
            btnAddNew.TabIndex = 4;
            btnAddNew.Text = "新增";
            btnAddNew.UseVisualStyleBackColor = false;
            btnAddNew.Visible = false;
            btnAddNew.Click += btnAddNew_Click;
            // 
            // btnModify
            // 
            btnModify.BackColor = Color.Gainsboro;
            btnModify.FlatStyle = FlatStyle.Flat;
            btnModify.Location = new Point(507, 8);
            btnModify.Name = "btnModify";
            btnModify.Size = new Size(80, 28);
            btnModify.TabIndex = 5;
            btnModify.Text = "修改";
            btnModify.UseVisualStyleBackColor = false;
            btnModify.Click += btnModify_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Gainsboro;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Location = new Point(590, 8);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(80, 28);
            btnSave.TabIndex = 6;
            btnSave.Text = "儲存";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnReview
            // 
            btnReview.BackColor = Color.Gainsboro;
            btnReview.FlatStyle = FlatStyle.Flat;
            btnReview.Location = new Point(673, 8);
            btnReview.Name = "btnReview";
            btnReview.Size = new Size(80, 28);
            btnReview.TabIndex = 7;
            btnReview.Text = "覆核";
            btnReview.UseVisualStyleBackColor = false;
            btnReview.Click += btnReview_Click;
            // 
            // btnCancelReview
            // 
            btnCancelReview.BackColor = Color.Gainsboro;
            btnCancelReview.FlatStyle = FlatStyle.Flat;
            btnCancelReview.Location = new Point(756, 8);
            btnCancelReview.Name = "btnCancelReview";
            btnCancelReview.Size = new Size(90, 28);
            btnCancelReview.TabIndex = 8;
            btnCancelReview.Text = "取消覆核";
            btnCancelReview.UseVisualStyleBackColor = false;
            btnCancelReview.Click += btnCancelReview_Click;
            // 
            // btnPrint
            // 
            btnPrint.BackColor = Color.Gainsboro;
            btnPrint.FlatStyle = FlatStyle.Flat;
            btnPrint.Location = new Point(849, 8);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(80, 28);
            btnPrint.TabIndex = 9;
            btnPrint.Text = "列印";
            btnPrint.UseVisualStyleBackColor = false;
            btnPrint.Click += btnPrint_Click;
            // 
            // btnOverview
            // 
            btnOverview.BackColor = Color.Gainsboro;
            btnOverview.FlatStyle = FlatStyle.Flat;
            btnOverview.Location = new Point(932, 8);
            btnOverview.Name = "btnOverview";
            btnOverview.Size = new Size(80, 28);
            btnOverview.TabIndex = 10;
            btnOverview.Text = "總覽";
            btnOverview.UseVisualStyleBackColor = false;
            btnOverview.Visible = false;
            btnOverview.Click += btnOverview_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Gainsboro;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Location = new Point(1015, 8);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(80, 28);
            btnClose.TabIndex = 11;
            btnClose.Text = "關閉";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // lblMode
            // 
            lblMode.AutoSize = true;
            lblMode.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            lblMode.ForeColor = Color.Red;
            lblMode.Location = new Point(8, 12);
            lblMode.Name = "lblMode";
            lblMode.Size = new Size(36, 18);
            lblMode.TabIndex = 12;
            lblMode.Text = "新增";
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.Lavender;
            panelHeader.Controls.Add(lblDate);
            panelHeader.Controls.Add(dtDate);
            panelHeader.Controls.Add(lblNo);
            panelHeader.Controls.Add(txtNo);
            panelHeader.Controls.Add(lblWarehouseWorker);
            panelHeader.Controls.Add(cboWarehouseWorker);
            panelHeader.Controls.Add(lblWarehouseWorkerName);
            panelHeader.Controls.Add(lblReviewer);
            panelHeader.Controls.Add(txtReviewer);
            panelHeader.Controls.Add(lblReviewDate);
            panelHeader.Controls.Add(txtReviewDate);
            panelHeader.Controls.Add(lblVoucher);
            panelHeader.Controls.Add(txtVoucher);
            panelHeader.Controls.Add(lblNote);
            panelHeader.Controls.Add(txtNote);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 44);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1420, 80);
            panelHeader.TabIndex = 1;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Location = new Point(10, 12);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(31, 16);
            lblDate.TabIndex = 0;
            lblDate.Text = "日期";
            // 
            // dtDate
            // 
            dtDate.Format = DateTimePickerFormat.Short;
            dtDate.Location = new Point(75, 8);
            dtDate.Name = "dtDate";
            dtDate.Size = new Size(110, 23);
            dtDate.TabIndex = 1;
            // 
            // lblNo
            // 
            lblNo.AutoSize = true;
            lblNo.Location = new Point(200, 12);
            lblNo.Name = "lblNo";
            lblNo.Size = new Size(31, 16);
            lblNo.TabIndex = 2;
            lblNo.Text = "單號";
            // 
            // txtNo
            // 
            txtNo.Location = new Point(255, 8);
            txtNo.Name = "txtNo";
            txtNo.ReadOnly = true;
            txtNo.Size = new Size(110, 23);
            txtNo.TabIndex = 3;
            // 
            // lblWarehouseWorker
            // 
            lblWarehouseWorker.AutoSize = true;
            lblWarehouseWorker.Location = new Point(380, 12);
            lblWarehouseWorker.Name = "lblWarehouseWorker";
            lblWarehouseWorker.Size = new Size(55, 16);
            lblWarehouseWorker.TabIndex = 4;
            lblWarehouseWorker.Text = "倉管人員";
            // 
            // cboWarehouseWorker
            // 
            cboWarehouseWorker.Location = new Point(455, 8);
            cboWarehouseWorker.Name = "cboWarehouseWorker";
            cboWarehouseWorker.Size = new Size(80, 24);
            cboWarehouseWorker.TabIndex = 5;
            cboWarehouseWorker.SelectedIndexChanged += cboWarehouseWorker_SelectedIndexChanged;
            cboWarehouseWorker.Leave += cboWarehouseWorker_Leave;
            // 
            // lblWarehouseWorkerName
            // 
            lblWarehouseWorkerName.AutoSize = true;
            lblWarehouseWorkerName.Location = new Point(540, 12);
            lblWarehouseWorkerName.Name = "lblWarehouseWorkerName";
            lblWarehouseWorkerName.Size = new Size(0, 16);
            lblWarehouseWorkerName.TabIndex = 6;
            // 
            // lblReviewer
            // 
            lblReviewer.AutoSize = true;
            lblReviewer.Location = new Point(650, 12);
            lblReviewer.Name = "lblReviewer";
            lblReviewer.Size = new Size(55, 16);
            lblReviewer.TabIndex = 7;
            lblReviewer.Text = "覆核人員";
            // 
            // txtReviewer
            // 
            txtReviewer.Enabled = false;
            txtReviewer.Location = new Point(725, 8);
            txtReviewer.Name = "txtReviewer";
            txtReviewer.ReadOnly = true;
            txtReviewer.Size = new Size(100, 23);
            txtReviewer.TabIndex = 8;
            // 
            // lblReviewDate
            // 
            lblReviewDate.AutoSize = true;
            lblReviewDate.Location = new Point(840, 12);
            lblReviewDate.Name = "lblReviewDate";
            lblReviewDate.Size = new Size(55, 16);
            lblReviewDate.TabIndex = 9;
            lblReviewDate.Text = "覆核日期";
            // 
            // txtReviewDate
            // 
            txtReviewDate.Enabled = false;
            txtReviewDate.Location = new Point(915, 8);
            txtReviewDate.Name = "txtReviewDate";
            txtReviewDate.ReadOnly = true;
            txtReviewDate.Size = new Size(100, 23);
            txtReviewDate.TabIndex = 10;
            // 
            // lblVoucher
            // 
            lblVoucher.AutoSize = true;
            lblVoucher.Location = new Point(1030, 12);
            lblVoucher.Name = "lblVoucher";
            lblVoucher.Size = new Size(31, 16);
            lblVoucher.TabIndex = 11;
            lblVoucher.Text = "傳票";
            // 
            // txtVoucher
            // 
            txtVoucher.Location = new Point(1075, 8);
            txtVoucher.Name = "txtVoucher";
            txtVoucher.Size = new Size(120, 23);
            txtVoucher.TabIndex = 12;
            // 
            // lblNote
            // 
            lblNote.AutoSize = true;
            lblNote.Location = new Point(10, 46);
            lblNote.Name = "lblNote";
            lblNote.Size = new Size(31, 16);
            lblNote.TabIndex = 13;
            lblNote.Text = "備註";
            // 
            // txtNote
            // 
            txtNote.Location = new Point(75, 42);
            txtNote.Name = "txtNote";
            txtNote.Size = new Size(1120, 23);
            txtNote.TabIndex = 14;
            // 
            // panelGrid
            // 
            panelGrid.Controls.Add(dgvDetail);
            panelGrid.Dock = DockStyle.Fill;
            panelGrid.Location = new Point(0, 124);
            panelGrid.Name = "panelGrid";
            panelGrid.Size = new Size(1420, 524);
            panelGrid.TabIndex = 2;
            // 
            // dgvDetail
            // 
            dgvDetail.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDetail.BackgroundColor = Color.White;
            dgvDetail.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetail.Columns.AddRange(new DataGridViewColumn[] { colItemNo, colItemSpec, colUnit, colSupplierNo, colSupplierShortName, colPurchaseQty, colReceiveQty, colQualifiedQty, colSpecialQty, colReturnQty, colSample, colBatchNo, colProject, colPurchaseNo, colActualPrice, colDiscountAmt, colPaymentAmt });
            dgvDetail.Dock = DockStyle.Fill;
            dgvDetail.Font = new Font("微軟正黑體", 9F);
            dgvDetail.Location = new Point(0, 0);
            dgvDetail.Name = "dgvDetail";
            dgvDetail.RowTemplate.Height = 26;
            dgvDetail.Size = new Size(1420, 524);
            dgvDetail.TabIndex = 0;
            dgvDetail.CellDoubleClick += dgvDetail_CellDoubleClick;
            dgvDetail.CellClick += dgvDetail_CellClick;
            dgvDetail.CellEndEdit += dgvDetail_CellEndEdit;
            // 
            // colItemNo
            // 
            colItemNo.FillWeight = 110F;
            colItemNo.HeaderText = "品項編號";
            colItemNo.Name = "colItemNo";
            colItemNo.ReadOnly = true;
            //
            // colItemSpec
            //
            colItemSpec.FillWeight = 200F;
            colItemSpec.HeaderText = "品名規格";
            colItemSpec.Name = "colItemSpec";
            colItemSpec.ReadOnly = true;
            //
            // colUnit
            //
            colUnit.FillWeight = 55F;
            colUnit.HeaderText = "單位";
            colUnit.Name = "colUnit";
            //
            // colSupplierNo
            //
            colSupplierNo.FillWeight = 75F;
            colSupplierNo.HeaderText = "廠商編號";
            colSupplierNo.Name = "colSupplierNo";
            colSupplierNo.ReadOnly = true;
            //
            // colSupplierShortName
            //
            colSupplierShortName.FillWeight = 85F;
            colSupplierShortName.HeaderText = "廠商簡稱";
            colSupplierShortName.Name = "colSupplierShortName";
            colSupplierShortName.ReadOnly = true;
            // 
            // colPurchaseQty
            // 
            colPurchaseQty.FillWeight = 75F;
            colPurchaseQty.HeaderText = "採購數量";
            colPurchaseQty.Name = "colPurchaseQty";
            // 
            // colReceiveQty
            // 
            colReceiveQty.FillWeight = 75F;
            colReceiveQty.HeaderText = "收貨數量";
            colReceiveQty.Name = "colReceiveQty";
            // 
            // colQualifiedQty
            // 
            colQualifiedQty.FillWeight = 75F;
            colQualifiedQty.HeaderText = "合格數量";
            colQualifiedQty.Name = "colQualifiedQty";
            // 
            // colSpecialQty
            // 
            colSpecialQty.FillWeight = 75F;
            colSpecialQty.HeaderText = "特採數量";
            colSpecialQty.Name = "colSpecialQty";
            // 
            // colReturnQty
            // 
            colReturnQty.FillWeight = 75F;
            colReturnQty.HeaderText = "退回數量";
            colReturnQty.Name = "colReturnQty";
            // 
            // colSample
            // 
            colSample.FillWeight = 50F;
            colSample.HeaderText = "樣品";
            colSample.Name = "colSample";
            //
            // colBatchNo
            //
            colBatchNo.FillWeight = 85F;
            colBatchNo.HeaderText = "批號";
            colBatchNo.Name = "colBatchNo";
            colBatchNo.ReadOnly = true;
            //
            // colProject
            //
            colProject.FillWeight = 80F;
            colProject.HeaderText = "專案序號";
            colProject.Name = "colProject";
            //
            // colPurchaseNo
            //
            colPurchaseNo.FillWeight = 90F;
            colPurchaseNo.HeaderText = "採購單號";
            colPurchaseNo.Name = "colPurchaseNo";
            // 
            // colActualPrice
            // 
            colActualPrice.FillWeight = 75F;
            colActualPrice.HeaderText = "實際單價";
            colActualPrice.Name = "colActualPrice";
            // 
            // colDiscountAmt
            // 
            colDiscountAmt.FillWeight = 75F;
            colDiscountAmt.HeaderText = "折讓金額";
            colDiscountAmt.Name = "colDiscountAmt";
            // 
            // colPaymentAmt
            // 
            colPaymentAmt.FillWeight = 75F;
            colPaymentAmt.HeaderText = "付款金額";
            colPaymentAmt.Name = "colPaymentAmt";
            // 
            // StockInMaintainControl
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelGrid);
            Controls.Add(panelHeader);
            Controls.Add(panelToolbar);
            Font = new Font("微軟正黑體", 9F);
            Name = "StockInMaintainControl";
            Size = new Size(1420, 648);
            panelToolbar.ResumeLayout(false);
            panelToolbar.PerformLayout();
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDetail).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelToolbar;
        private Label lblTitle;
        private Label lblMode;
        private Button btnAllocate;
        private Button btnVoucher;
        private Button btnDeleteRecord;
        private Button btnAddNew;
        private Button btnModify;
        private Button btnSave;
        private Button btnReview;
        private Button btnCancelReview;
        private Button btnPrint;
        private Button btnOverview;
        private Button btnClose;

        private Panel panelHeader;
        private Label lblDate; private DateTimePicker dtDate;
        private Label lblNo; private TextBox txtNo;
        private Label lblWarehouseWorker; private ComboBox cboWarehouseWorker; private Label lblWarehouseWorkerName;
        private Label lblReviewer; private TextBox txtReviewer;
        private Label lblReviewDate; private TextBox txtReviewDate;
        private Label lblVoucher; private TextBox txtVoucher;
        private Label lblNote; private TextBox txtNote;

        private Panel panelGrid;
        private DataGridView dgvDetail;
        private DataGridViewTextBoxColumn colItemNo;
        private DataGridViewTextBoxColumn colItemSpec;
        private DataGridViewTextBoxColumn colUnit;
        private DataGridViewTextBoxColumn colSupplierNo;
        private DataGridViewTextBoxColumn colSupplierShortName;
        private DataGridViewTextBoxColumn colPurchaseQty;
        private DataGridViewTextBoxColumn colReceiveQty;
        private DataGridViewTextBoxColumn colQualifiedQty;
        private DataGridViewTextBoxColumn colSpecialQty;
        private DataGridViewTextBoxColumn colReturnQty;
        private DataGridViewCheckBoxColumn colSample;
        private DataGridViewTextBoxColumn colBatchNo;
        private DataGridViewTextBoxColumn colProject;
        private DataGridViewTextBoxColumn colPurchaseNo;
        private DataGridViewTextBoxColumn colActualPrice;
        private DataGridViewTextBoxColumn colDiscountAmt;
        private DataGridViewTextBoxColumn colPaymentAmt;
    }
}
