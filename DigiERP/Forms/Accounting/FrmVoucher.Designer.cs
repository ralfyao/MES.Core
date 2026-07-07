using System.Drawing;
using System.Windows.Forms;

namespace DigiERP.UserControl.Inventory.StockIn
{
    partial class FrmVoucher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVoucher));
            panelToolbar = new Panel();
            lblTitle = new Label();
            btnDeleteRecord = new Button();
            btnAddNew = new Button();
            btnModify = new Button();
            btnSave = new Button();
            btnPost = new Button();
            btnCancelPost = new Button();
            btnQuery = new Button();
            btnPrint = new Button();
            btnClose = new Button();
            panelHeader = new Panel();
            lblDate = new Label();
            dtDate = new DateTimePicker();
            lblVoucherNo = new Label();
            txtVoucherNo = new TextBox();
            lblModifier = new Label();
            txtModifier = new TextBox();
            lblPost = new Label();
            txtPost = new TextBox();
            lblMonthClose = new Label();
            chkMonthClose = new CheckBox();
            lblStatus = new Label();
            txtStatus = new TextBox();
            lblRegistrar = new Label();
            txtRegistrar = new TextBox();
            lblModifyDate = new Label();
            txtModifyDate = new TextBox();
            lblPostDate = new Label();
            txtPostDate = new TextBox();
            btnImportAccount = new Button();
            panelGrid = new Panel();
            dgvDetail = new DataGridView();
            colAccountCode = new DataGridViewTextBoxColumn();
            colAccountName = new DataGridViewTextBoxColumn();
            colSummary = new DataGridViewTextBoxColumn();
            colDebit = new DataGridViewTextBoxColumn();
            colCredit = new DataGridViewTextBoxColumn();
            colSourceDoc = new DataGridViewTextBoxColumn();
            colNote = new DataGridViewTextBoxColumn();
            panelFooter = new Panel();
            lblTotalCap = new Label();
            txtTotalDebit = new TextBox();
            txtTotalCredit = new TextBox();
            pictureBox1 = new PictureBox();
            panelToolbar.SuspendLayout();
            panelHeader.SuspendLayout();
            panelGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDetail).BeginInit();
            panelFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelToolbar
            // 
            panelToolbar.BackColor = Color.WhiteSmoke;
            panelToolbar.Controls.Add(pictureBox1);
            panelToolbar.Controls.Add(lblTitle);
            panelToolbar.Controls.Add(btnDeleteRecord);
            panelToolbar.Controls.Add(btnAddNew);
            panelToolbar.Controls.Add(btnModify);
            panelToolbar.Controls.Add(btnSave);
            panelToolbar.Controls.Add(btnPost);
            panelToolbar.Controls.Add(btnCancelPost);
            panelToolbar.Controls.Add(btnQuery);
            panelToolbar.Controls.Add(btnPrint);
            panelToolbar.Controls.Add(btnClose);
            panelToolbar.Dock = DockStyle.Top;
            panelToolbar.Location = new Point(0, 0);
            panelToolbar.Name = "panelToolbar";
            panelToolbar.Size = new Size(1000, 44);
            panelToolbar.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("微軟正黑體", 12F, FontStyle.Bold);
            lblTitle.Location = new Point(59, 10);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(74, 21);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "會計傳票";
            // 
            // btnDeleteRecord
            // 
            btnDeleteRecord.BackColor = Color.Firebrick;
            btnDeleteRecord.FlatStyle = FlatStyle.Flat;
            btnDeleteRecord.ForeColor = Color.White;
            btnDeleteRecord.Location = new Point(149, 8);
            btnDeleteRecord.Name = "btnDeleteRecord";
            btnDeleteRecord.Size = new Size(90, 28);
            btnDeleteRecord.TabIndex = 1;
            btnDeleteRecord.Text = "刪除紀錄";
            btnDeleteRecord.UseVisualStyleBackColor = false;
            btnDeleteRecord.Click += btnDeleteRecord_Click;
            // 
            // btnAddNew
            // 
            btnAddNew.BackColor = Color.Gainsboro;
            btnAddNew.FlatStyle = FlatStyle.Flat;
            btnAddNew.Location = new Point(247, 8);
            btnAddNew.Name = "btnAddNew";
            btnAddNew.Size = new Size(80, 28);
            btnAddNew.TabIndex = 2;
            btnAddNew.Text = "新增";
            btnAddNew.UseVisualStyleBackColor = false;
            btnAddNew.Click += btnAddNew_Click;
            // 
            // btnModify
            // 
            btnModify.BackColor = Color.Gainsboro;
            btnModify.FlatStyle = FlatStyle.Flat;
            btnModify.Location = new Point(330, 8);
            btnModify.Name = "btnModify";
            btnModify.Size = new Size(80, 28);
            btnModify.TabIndex = 3;
            btnModify.Text = "修改";
            btnModify.UseVisualStyleBackColor = false;
            btnModify.Click += btnModify_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Gainsboro;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Location = new Point(413, 8);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(80, 28);
            btnSave.TabIndex = 4;
            btnSave.Text = "儲存";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnPost
            // 
            btnPost.BackColor = Color.Gainsboro;
            btnPost.FlatStyle = FlatStyle.Flat;
            btnPost.Location = new Point(496, 8);
            btnPost.Name = "btnPost";
            btnPost.Size = new Size(80, 28);
            btnPost.TabIndex = 5;
            btnPost.Text = "過帳";
            btnPost.UseVisualStyleBackColor = false;
            btnPost.Click += btnPost_Click;
            // 
            // btnCancelPost
            // 
            btnCancelPost.BackColor = Color.Gainsboro;
            btnCancelPost.FlatStyle = FlatStyle.Flat;
            btnCancelPost.Location = new Point(579, 8);
            btnCancelPost.Name = "btnCancelPost";
            btnCancelPost.Size = new Size(90, 28);
            btnCancelPost.TabIndex = 6;
            btnCancelPost.Text = "取消過帳";
            btnCancelPost.UseVisualStyleBackColor = false;
            btnCancelPost.Click += btnCancelPost_Click;
            // 
            // btnQuery
            // 
            btnQuery.BackColor = Color.Gainsboro;
            btnQuery.FlatStyle = FlatStyle.Flat;
            btnQuery.Location = new Point(672, 8);
            btnQuery.Name = "btnQuery";
            btnQuery.Size = new Size(80, 28);
            btnQuery.TabIndex = 7;
            btnQuery.Text = "查詢";
            btnQuery.UseVisualStyleBackColor = false;
            btnQuery.Click += btnQuery_Click;
            // 
            // btnPrint
            // 
            btnPrint.BackColor = Color.Gainsboro;
            btnPrint.FlatStyle = FlatStyle.Flat;
            btnPrint.Location = new Point(755, 8);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(80, 28);
            btnPrint.TabIndex = 8;
            btnPrint.Text = "列印";
            btnPrint.UseVisualStyleBackColor = false;
            btnPrint.Click += btnPrint_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Gainsboro;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Location = new Point(838, 8);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(80, 28);
            btnClose.TabIndex = 9;
            btnClose.Text = "關閉";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.Lavender;
            panelHeader.Controls.Add(lblDate);
            panelHeader.Controls.Add(dtDate);
            panelHeader.Controls.Add(lblVoucherNo);
            panelHeader.Controls.Add(txtVoucherNo);
            panelHeader.Controls.Add(lblModifier);
            panelHeader.Controls.Add(txtModifier);
            panelHeader.Controls.Add(lblPost);
            panelHeader.Controls.Add(txtPost);
            panelHeader.Controls.Add(lblMonthClose);
            panelHeader.Controls.Add(chkMonthClose);
            panelHeader.Controls.Add(lblStatus);
            panelHeader.Controls.Add(txtStatus);
            panelHeader.Controls.Add(lblRegistrar);
            panelHeader.Controls.Add(txtRegistrar);
            panelHeader.Controls.Add(lblModifyDate);
            panelHeader.Controls.Add(txtModifyDate);
            panelHeader.Controls.Add(lblPostDate);
            panelHeader.Controls.Add(txtPostDate);
            panelHeader.Controls.Add(btnImportAccount);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 44);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1000, 70);
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
            dtDate.Location = new Point(60, 8);
            dtDate.Name = "dtDate";
            dtDate.Size = new Size(110, 23);
            dtDate.TabIndex = 1;
            // 
            // lblVoucherNo
            // 
            lblVoucherNo.AutoSize = true;
            lblVoucherNo.Location = new Point(185, 12);
            lblVoucherNo.Name = "lblVoucherNo";
            lblVoucherNo.Size = new Size(55, 16);
            lblVoucherNo.TabIndex = 2;
            lblVoucherNo.Text = "傳票編號";
            // 
            // txtVoucherNo
            // 
            txtVoucherNo.Location = new Point(260, 8);
            txtVoucherNo.Name = "txtVoucherNo";
            txtVoucherNo.ReadOnly = true;
            txtVoucherNo.Size = new Size(120, 23);
            txtVoucherNo.TabIndex = 3;
            // 
            // lblModifier
            // 
            lblModifier.AutoSize = true;
            lblModifier.Location = new Point(395, 12);
            lblModifier.Name = "lblModifier";
            lblModifier.Size = new Size(31, 16);
            lblModifier.TabIndex = 4;
            lblModifier.Text = "修改";
            // 
            // txtModifier
            // 
            txtModifier.Location = new Point(430, 8);
            txtModifier.Name = "txtModifier";
            txtModifier.ReadOnly = true;
            txtModifier.Size = new Size(100, 23);
            txtModifier.TabIndex = 5;
            // 
            // lblPost
            // 
            lblPost.AutoSize = true;
            lblPost.Location = new Point(545, 12);
            lblPost.Name = "lblPost";
            lblPost.Size = new Size(31, 16);
            lblPost.TabIndex = 6;
            lblPost.Text = "過帳";
            // 
            // txtPost
            // 
            txtPost.Location = new Point(580, 8);
            txtPost.Name = "txtPost";
            txtPost.ReadOnly = true;
            txtPost.Size = new Size(100, 23);
            txtPost.TabIndex = 7;
            // 
            // lblMonthClose
            // 
            lblMonthClose.AutoSize = true;
            lblMonthClose.Location = new Point(695, 12);
            lblMonthClose.Name = "lblMonthClose";
            lblMonthClose.Size = new Size(31, 16);
            lblMonthClose.TabIndex = 8;
            lblMonthClose.Text = "月結";
            // 
            // chkMonthClose
            // 
            chkMonthClose.Enabled = false;
            chkMonthClose.Location = new Point(740, 10);
            chkMonthClose.Name = "chkMonthClose";
            chkMonthClose.Size = new Size(20, 20);
            chkMonthClose.TabIndex = 9;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(10, 42);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(31, 16);
            lblStatus.TabIndex = 10;
            lblStatus.Text = "狀態";
            // 
            // txtStatus
            // 
            txtStatus.Location = new Point(60, 38);
            txtStatus.Name = "txtStatus";
            txtStatus.ReadOnly = true;
            txtStatus.Size = new Size(110, 23);
            txtStatus.TabIndex = 11;
            // 
            // lblRegistrar
            // 
            lblRegistrar.AutoSize = true;
            lblRegistrar.Location = new Point(185, 42);
            lblRegistrar.Name = "lblRegistrar";
            lblRegistrar.Size = new Size(55, 16);
            lblRegistrar.TabIndex = 12;
            lblRegistrar.Text = "登錄人員";
            // 
            // txtRegistrar
            // 
            txtRegistrar.Location = new Point(260, 38);
            txtRegistrar.Name = "txtRegistrar";
            txtRegistrar.ReadOnly = true;
            txtRegistrar.Size = new Size(120, 23);
            txtRegistrar.TabIndex = 13;
            // 
            // lblModifyDate
            // 
            lblModifyDate.AutoSize = true;
            lblModifyDate.Location = new Point(395, 42);
            lblModifyDate.Name = "lblModifyDate";
            lblModifyDate.Size = new Size(43, 16);
            lblModifyDate.TabIndex = 14;
            lblModifyDate.Text = "修改日";
            // 
            // txtModifyDate
            // 
            txtModifyDate.Location = new Point(430, 38);
            txtModifyDate.Name = "txtModifyDate";
            txtModifyDate.ReadOnly = true;
            txtModifyDate.Size = new Size(100, 23);
            txtModifyDate.TabIndex = 15;
            // 
            // lblPostDate
            // 
            lblPostDate.AutoSize = true;
            lblPostDate.Location = new Point(545, 42);
            lblPostDate.Name = "lblPostDate";
            lblPostDate.Size = new Size(43, 16);
            lblPostDate.TabIndex = 16;
            lblPostDate.Text = "過帳日";
            // 
            // txtPostDate
            // 
            txtPostDate.Location = new Point(580, 38);
            txtPostDate.Name = "txtPostDate";
            txtPostDate.ReadOnly = true;
            txtPostDate.Size = new Size(100, 23);
            txtPostDate.TabIndex = 17;
            // 
            // btnImportAccount
            // 
            btnImportAccount.BackColor = Color.SteelBlue;
            btnImportAccount.FlatStyle = FlatStyle.Flat;
            btnImportAccount.ForeColor = Color.White;
            btnImportAccount.Location = new Point(695, 36);
            btnImportAccount.Name = "btnImportAccount";
            btnImportAccount.Size = new Size(90, 26);
            btnImportAccount.TabIndex = 18;
            btnImportAccount.Text = "會科帶入";
            btnImportAccount.UseVisualStyleBackColor = false;
            btnImportAccount.Click += btnImportAccount_Click;
            // 
            // panelGrid
            // 
            panelGrid.Controls.Add(dgvDetail);
            panelGrid.Dock = DockStyle.Fill;
            panelGrid.Location = new Point(0, 114);
            panelGrid.Name = "panelGrid";
            panelGrid.Size = new Size(1000, 380);
            panelGrid.TabIndex = 2;
            // 
            // dgvDetail
            // 
            dgvDetail.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDetail.BackgroundColor = Color.White;
            dgvDetail.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetail.Columns.AddRange(new DataGridViewColumn[] { colAccountCode, colAccountName, colSummary, colDebit, colCredit, colSourceDoc, colNote });
            dgvDetail.Dock = DockStyle.Fill;
            dgvDetail.Font = new Font("微軟正黑體", 9F);
            dgvDetail.Location = new Point(0, 0);
            dgvDetail.Name = "dgvDetail";
            dgvDetail.RowTemplate.Height = 26;
            dgvDetail.Size = new Size(1000, 380);
            dgvDetail.TabIndex = 0;
            dgvDetail.CellEndEdit += dgvDetail_CellEndEdit;
            dgvDetail.RowsRemoved += dgvDetail_RowsRemoved;
            // 
            // colAccountCode
            // 
            colAccountCode.FillWeight = 80F;
            colAccountCode.HeaderText = "會科代碼";
            colAccountCode.Name = "colAccountCode";
            colAccountCode.ReadOnly = true;
            // 
            // colAccountName
            // 
            colAccountName.FillWeight = 200F;
            colAccountName.HeaderText = "會計科目";
            colAccountName.Name = "colAccountName";
            colAccountName.ReadOnly = true;
            // 
            // colSummary
            // 
            colSummary.FillWeight = 180F;
            colSummary.HeaderText = "摘要";
            colSummary.Name = "colSummary";
            // 
            // colDebit
            // 
            colDebit.HeaderText = "借方";
            colDebit.Name = "colDebit";
            // 
            // colCredit
            // 
            colCredit.HeaderText = "貸方";
            colCredit.Name = "colCredit";
            // 
            // colSourceDoc
            // 
            colSourceDoc.FillWeight = 120F;
            colSourceDoc.HeaderText = "來源單據";
            colSourceDoc.Name = "colSourceDoc";
            // 
            // colNote
            // 
            colNote.FillWeight = 140F;
            colNote.HeaderText = "備註";
            colNote.Name = "colNote";
            // 
            // panelFooter
            // 
            panelFooter.Controls.Add(lblTotalCap);
            panelFooter.Controls.Add(txtTotalDebit);
            panelFooter.Controls.Add(txtTotalCredit);
            panelFooter.Dock = DockStyle.Bottom;
            panelFooter.Location = new Point(0, 494);
            panelFooter.Name = "panelFooter";
            panelFooter.Size = new Size(1000, 40);
            panelFooter.TabIndex = 3;
            // 
            // lblTotalCap
            // 
            lblTotalCap.AutoSize = true;
            lblTotalCap.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            lblTotalCap.Location = new Point(400, 10);
            lblTotalCap.Name = "lblTotalCap";
            lblTotalCap.Size = new Size(36, 18);
            lblTotalCap.TabIndex = 0;
            lblTotalCap.Text = "合計";
            // 
            // txtTotalDebit
            // 
            txtTotalDebit.Location = new Point(460, 6);
            txtTotalDebit.Name = "txtTotalDebit";
            txtTotalDebit.ReadOnly = true;
            txtTotalDebit.Size = new Size(100, 23);
            txtTotalDebit.TabIndex = 1;
            txtTotalDebit.TextAlign = HorizontalAlignment.Right;
            // 
            // txtTotalCredit
            // 
            txtTotalCredit.Location = new Point(570, 6);
            txtTotalCredit.Name = "txtTotalCredit";
            txtTotalCredit.ReadOnly = true;
            txtTotalCredit.Size = new Size(100, 23);
            txtTotalCredit.TabIndex = 2;
            txtTotalCredit.TextAlign = HorizontalAlignment.Right;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(4, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(44, 32);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // FrmVoucher
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 534);
            Controls.Add(panelGrid);
            Controls.Add(panelFooter);
            Controls.Add(panelHeader);
            Controls.Add(panelToolbar);
            Font = new Font("微軟正黑體", 9F);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MinimumSize = new Size(700, 400);
            Name = "FrmVoucher";
            StartPosition = FormStartPosition.CenterParent;
            Text = "會計傳票";
            panelToolbar.ResumeLayout(false);
            panelToolbar.PerformLayout();
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDetail).EndInit();
            panelFooter.ResumeLayout(false);
            panelFooter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelToolbar;
        private Label lblTitle;
        private Button btnDeleteRecord;
        private Button btnAddNew;
        private Button btnModify;
        private Button btnSave;
        private Button btnPost;
        private Button btnCancelPost;
        private Button btnQuery;
        private Button btnPrint;
        private Button btnClose;

        private Panel panelHeader;
        private Label lblDate; private DateTimePicker dtDate;
        private Label lblVoucherNo; private TextBox txtVoucherNo;
        private Label lblModifier; private TextBox txtModifier;
        private Label lblPost; private TextBox txtPost;
        private Label lblMonthClose; private CheckBox chkMonthClose;
        private Label lblStatus; private TextBox txtStatus;
        private Label lblRegistrar; private TextBox txtRegistrar;
        private Label lblModifyDate; private TextBox txtModifyDate;
        private Label lblPostDate; private TextBox txtPostDate;
        private Button btnImportAccount;

        private Panel panelGrid;
        private DataGridView dgvDetail;
        private DataGridViewTextBoxColumn colAccountCode;
        private DataGridViewTextBoxColumn colAccountName;
        private DataGridViewTextBoxColumn colSummary;
        private DataGridViewTextBoxColumn colDebit;
        private DataGridViewTextBoxColumn colCredit;
        private DataGridViewTextBoxColumn colSourceDoc;
        private DataGridViewTextBoxColumn colNote;

        private Panel panelFooter;
        private Label lblTotalCap;
        private TextBox txtTotalDebit;
        private TextBox txtTotalCredit;
        private PictureBox pictureBox1;
    }
}
