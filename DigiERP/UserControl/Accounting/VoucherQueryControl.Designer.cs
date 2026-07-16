using System.Drawing;
using System.Windows.Forms;

namespace DigiERP.UserControl.Accounting
{
    partial class VoucherQueryControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VoucherQueryControl));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            lblTitle = new Label();
            btnExit = new Button();
            panelRight = new Panel();
            lblVoucherNo = new Label();
            txtVoucherNoFuzzy = new TextBox();
            btnFuzzySearch = new Button();
            lblDateFrom = new Label();
            dtDateFrom = new DateTimePicker();
            lblDateTo = new Label();
            dtDateTo = new DateTimePicker();
            lblAccountCode = new Label();
            txtAccountCode = new TextBox();
            lblStatus = new Label();
            cboStatus = new ComboBox();
            btnMultiFilter = new Button();
            splitContainer1 = new SplitContainer();
            dgvMaster = new DataGridView();
            colNo = new DataGridViewTextBoxColumn();
            colDate = new DataGridViewTextBoxColumn();
            colStatus = new DataGridViewTextBoxColumn();
            colRegistrar = new DataGridViewTextBoxColumn();
            colPost = new DataGridViewTextBoxColumn();
            colPostDate = new DataGridViewTextBoxColumn();
            dgvDetail = new DataGridView();
            colDetailNo = new DataGridViewTextBoxColumn();
            colAccountCode = new DataGridViewTextBoxColumn();
            colAccountName = new DataGridViewTextBoxColumn();
            colSummary = new DataGridViewTextBoxColumn();
            colDebit = new DataGridViewTextBoxColumn();
            colCredit = new DataGridViewTextBoxColumn();
            colSourceDoc = new DataGridViewTextBoxColumn();
            colNote = new DataGridViewTextBoxColumn();
            panelFooter = new Panel();
            lblSumCap = new Label();
            txtSumDebit = new TextBox();
            txtSumCredit = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMaster).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDetail).BeginInit();
            panelFooter.SuspendLayout();
            SuspendLayout();
            //
            // panel1
            //
            panel1.BackColor = Color.Cornsilk;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(lblTitle);
            panel1.Controls.Add(btnExit);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1500, 56);
            panel1.TabIndex = 0;
            //
            // pictureBox1
            //
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(4, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(48, 48);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            //
            // lblTitle
            //
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("微軟正黑體", 13F, FontStyle.Bold);
            lblTitle.Location = new Point(60, 16);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(150, 23);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "會計傳票查詢作業";
            //
            // btnExit
            //
            btnExit.BackColor = Color.Gainsboro;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            btnExit.Location = new Point(1390, 12);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(98, 32);
            btnExit.TabIndex = 1;
            btnExit.Text = "EXIT";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            //
            // panelRight
            //
            panelRight.BackColor = Color.Cornsilk;
            panelRight.Controls.Add(lblVoucherNo);
            panelRight.Controls.Add(txtVoucherNoFuzzy);
            panelRight.Controls.Add(btnFuzzySearch);
            panelRight.Controls.Add(lblDateFrom);
            panelRight.Controls.Add(dtDateFrom);
            panelRight.Controls.Add(lblDateTo);
            panelRight.Controls.Add(dtDateTo);
            panelRight.Controls.Add(lblAccountCode);
            panelRight.Controls.Add(txtAccountCode);
            panelRight.Controls.Add(lblStatus);
            panelRight.Controls.Add(cboStatus);
            panelRight.Controls.Add(btnMultiFilter);
            panelRight.Dock = DockStyle.Right;
            panelRight.Location = new Point(1300, 56);
            panelRight.Name = "panelRight";
            panelRight.Size = new Size(200, 700);
            panelRight.TabIndex = 1;
            //
            // lblVoucherNo
            //
            lblVoucherNo.AutoSize = true;
            lblVoucherNo.Location = new Point(10, 16);
            lblVoucherNo.Name = "lblVoucherNo";
            lblVoucherNo.Size = new Size(64, 18);
            lblVoucherNo.TabIndex = 0;
            lblVoucherNo.Text = "傳票編號";
            //
            // txtVoucherNoFuzzy
            //
            txtVoucherNoFuzzy.Location = new Point(10, 38);
            txtVoucherNoFuzzy.Name = "txtVoucherNoFuzzy";
            txtVoucherNoFuzzy.Size = new Size(180, 25);
            txtVoucherNoFuzzy.TabIndex = 1;
            //
            // btnFuzzySearch
            //
            btnFuzzySearch.BackColor = Color.SlateGray;
            btnFuzzySearch.FlatStyle = FlatStyle.Flat;
            btnFuzzySearch.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            btnFuzzySearch.ForeColor = Color.White;
            btnFuzzySearch.Location = new Point(10, 68);
            btnFuzzySearch.Name = "btnFuzzySearch";
            btnFuzzySearch.Size = new Size(180, 32);
            btnFuzzySearch.TabIndex = 2;
            btnFuzzySearch.Text = "編號模糊篩選";
            btnFuzzySearch.UseVisualStyleBackColor = false;
            btnFuzzySearch.Click += btnFuzzySearch_Click;
            //
            // lblDateFrom
            //
            lblDateFrom.AutoSize = true;
            lblDateFrom.Location = new Point(10, 128);
            lblDateFrom.Name = "lblDateFrom";
            lblDateFrom.Size = new Size(64, 18);
            lblDateFrom.TabIndex = 3;
            lblDateFrom.Text = "日期起日";
            //
            // dtDateFrom
            //
            dtDateFrom.Format = DateTimePickerFormat.Short;
            dtDateFrom.Location = new Point(10, 150);
            dtDateFrom.Name = "dtDateFrom";
            dtDateFrom.ShowCheckBox = true;
            dtDateFrom.Checked = false;
            dtDateFrom.Size = new Size(180, 25);
            dtDateFrom.TabIndex = 4;
            //
            // lblDateTo
            //
            lblDateTo.AutoSize = true;
            lblDateTo.Location = new Point(10, 188);
            lblDateTo.Name = "lblDateTo";
            lblDateTo.Size = new Size(64, 18);
            lblDateTo.TabIndex = 5;
            lblDateTo.Text = "日期迄日";
            //
            // dtDateTo
            //
            dtDateTo.Format = DateTimePickerFormat.Short;
            dtDateTo.Location = new Point(10, 210);
            dtDateTo.Name = "dtDateTo";
            dtDateTo.ShowCheckBox = true;
            dtDateTo.Checked = false;
            dtDateTo.Size = new Size(180, 25);
            dtDateTo.TabIndex = 6;
            //
            // lblAccountCode
            //
            lblAccountCode.AutoSize = true;
            lblAccountCode.Location = new Point(10, 248);
            lblAccountCode.Name = "lblAccountCode";
            lblAccountCode.Size = new Size(64, 18);
            lblAccountCode.TabIndex = 7;
            lblAccountCode.Text = "會科代碼";
            //
            // txtAccountCode
            //
            txtAccountCode.Location = new Point(10, 270);
            txtAccountCode.Name = "txtAccountCode";
            txtAccountCode.Size = new Size(180, 25);
            txtAccountCode.TabIndex = 8;
            //
            // lblStatus
            //
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(10, 308);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(64, 18);
            lblStatus.TabIndex = 9;
            lblStatus.Text = "傳票狀態";
            //
            // cboStatus
            //
            cboStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cboStatus.FormattingEnabled = true;
            cboStatus.Location = new Point(10, 330);
            cboStatus.Name = "cboStatus";
            cboStatus.Size = new Size(180, 25);
            cboStatus.TabIndex = 10;
            //
            // btnMultiFilter
            //
            btnMultiFilter.BackColor = Color.SlateGray;
            btnMultiFilter.FlatStyle = FlatStyle.Flat;
            btnMultiFilter.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            btnMultiFilter.ForeColor = Color.White;
            btnMultiFilter.Location = new Point(10, 372);
            btnMultiFilter.Name = "btnMultiFilter";
            btnMultiFilter.Size = new Size(180, 32);
            btnMultiFilter.TabIndex = 11;
            btnMultiFilter.Text = "複式條件篩選";
            btnMultiFilter.UseVisualStyleBackColor = false;
            btnMultiFilter.Click += btnMultiFilter_Click;
            //
            // splitContainer1
            //
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 56);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            //
            // splitContainer1.Panel1
            //
            splitContainer1.Panel1.Controls.Add(dgvMaster);
            //
            // splitContainer1.Panel2
            //
            splitContainer1.Panel2.Controls.Add(panelFooter);
            splitContainer1.Panel2.Controls.Add(dgvDetail);
            splitContainer1.Size = new Size(1300, 700);
            splitContainer1.SplitterDistance = 340;
            splitContainer1.TabIndex = 2;
            //
            // dgvMaster
            //
            dgvMaster.AllowUserToAddRows = false;
            dgvMaster.AllowUserToDeleteRows = false;
            dgvMaster.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMaster.BackgroundColor = Color.White;
            dgvMaster.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMaster.Columns.AddRange(new DataGridViewColumn[] { colNo, colDate, colStatus, colRegistrar, colPost, colPostDate });
            dgvMaster.Dock = DockStyle.Fill;
            dgvMaster.Font = new Font("微軟正黑體", 9F);
            dgvMaster.Location = new Point(0, 0);
            dgvMaster.Name = "dgvMaster";
            dgvMaster.ReadOnly = true;
            dgvMaster.RowHeadersVisible = false;
            dgvMaster.RowTemplate.Height = 26;
            dgvMaster.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMaster.Size = new Size(1300, 340);
            dgvMaster.TabIndex = 0;
            dgvMaster.CellClick += dgvMaster_CellClick;
            //
            // colNo
            //
            colNo.HeaderText = "傳票編號";
            colNo.Name = "colNo";
            colNo.ReadOnly = true;
            //
            // colDate
            //
            colDate.HeaderText = "日期";
            colDate.Name = "colDate";
            colDate.ReadOnly = true;
            //
            // colStatus
            //
            colStatus.HeaderText = "狀態";
            colStatus.Name = "colStatus";
            colStatus.ReadOnly = true;
            //
            // colRegistrar
            //
            colRegistrar.HeaderText = "登錄人員";
            colRegistrar.Name = "colRegistrar";
            colRegistrar.ReadOnly = true;
            //
            // colPost
            //
            colPost.HeaderText = "過帳人員";
            colPost.Name = "colPost";
            colPost.ReadOnly = true;
            //
            // colPostDate
            //
            colPostDate.HeaderText = "過帳日";
            colPostDate.Name = "colPostDate";
            colPostDate.ReadOnly = true;
            //
            // dgvDetail
            //
            dgvDetail.AllowUserToAddRows = false;
            dgvDetail.AllowUserToDeleteRows = false;
            dgvDetail.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDetail.BackgroundColor = Color.White;
            dgvDetail.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetail.Columns.AddRange(new DataGridViewColumn[] { colDetailNo, colAccountCode, colAccountName, colSummary, colDebit, colCredit, colSourceDoc, colNote });
            dgvDetail.Dock = DockStyle.Fill;
            dgvDetail.Font = new Font("微軟正黑體", 9F);
            dgvDetail.Location = new Point(0, 0);
            dgvDetail.Name = "dgvDetail";
            dgvDetail.ReadOnly = true;
            dgvDetail.RowHeadersVisible = false;
            dgvDetail.RowTemplate.Height = 26;
            dgvDetail.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDetail.Size = new Size(1300, 322);
            dgvDetail.TabIndex = 1;
            dgvDetail.CellClick += dgvDetail_CellClick;
            //
            // colDetailNo
            //
            colDetailNo.HeaderText = "單號";
            colDetailNo.Name = "colDetailNo";
            colDetailNo.ReadOnly = true;
            //
            // colAccountCode
            //
            colAccountCode.HeaderText = "會科代碼";
            colAccountCode.Name = "colAccountCode";
            colAccountCode.ReadOnly = true;
            //
            // colAccountName
            //
            colAccountName.FillWeight = 150F;
            colAccountName.HeaderText = "會科名稱";
            colAccountName.Name = "colAccountName";
            colAccountName.ReadOnly = true;
            //
            // colSummary
            //
            colSummary.FillWeight = 200F;
            colSummary.HeaderText = "摘要";
            colSummary.Name = "colSummary";
            colSummary.ReadOnly = true;
            //
            // colDebit
            //
            colDebit.HeaderText = "借方";
            colDebit.Name = "colDebit";
            colDebit.ReadOnly = true;
            //
            // colCredit
            //
            colCredit.HeaderText = "貸方";
            colCredit.Name = "colCredit";
            colCredit.ReadOnly = true;
            //
            // colSourceDoc
            //
            colSourceDoc.HeaderText = "來源單據";
            colSourceDoc.Name = "colSourceDoc";
            colSourceDoc.ReadOnly = true;
            //
            // colNote
            //
            colNote.FillWeight = 150F;
            colNote.HeaderText = "備註";
            colNote.Name = "colNote";
            colNote.ReadOnly = true;
            //
            // panelFooter
            //
            panelFooter.BackColor = Color.Honeydew;
            panelFooter.Controls.Add(lblSumCap);
            panelFooter.Controls.Add(txtSumDebit);
            panelFooter.Controls.Add(txtSumCredit);
            panelFooter.Dock = DockStyle.Bottom;
            panelFooter.Location = new Point(0, 322);
            panelFooter.Name = "panelFooter";
            panelFooter.Size = new Size(1300, 34);
            panelFooter.TabIndex = 2;
            //
            // lblSumCap
            //
            lblSumCap.AutoSize = true;
            lblSumCap.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            lblSumCap.Location = new Point(8, 8);
            lblSumCap.Name = "lblSumCap";
            lblSumCap.Size = new Size(36, 18);
            lblSumCap.TabIndex = 0;
            lblSumCap.Text = "合計";
            //
            // txtSumDebit
            //
            txtSumDebit.Location = new Point(82, 4);
            txtSumDebit.Name = "txtSumDebit";
            txtSumDebit.ReadOnly = true;
            txtSumDebit.Size = new Size(150, 25);
            txtSumDebit.TabIndex = 1;
            //
            // txtSumCredit
            //
            txtSumCredit.Location = new Point(240, 4);
            txtSumCredit.Name = "txtSumCredit";
            txtSumCredit.ReadOnly = true;
            txtSumCredit.Size = new Size(150, 25);
            txtSumCredit.TabIndex = 2;
            //
            // VoucherQueryControl
            //
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(splitContainer1);
            Controls.Add(panelRight);
            Controls.Add(panel1);
            Font = new Font("微軟正黑體", 10F);
            Margin = new Padding(4);
            Name = "VoucherQueryControl";
            Size = new Size(1500, 756);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelRight.ResumeLayout(false);
            panelRight.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvMaster).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDetail).EndInit();
            panelFooter.ResumeLayout(false);
            panelFooter.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label lblTitle;
        private Button btnExit;
        private Panel panelRight;
        private Label lblVoucherNo;
        private TextBox txtVoucherNoFuzzy;
        private Button btnFuzzySearch;
        private Label lblDateFrom;
        private DateTimePicker dtDateFrom;
        private Label lblDateTo;
        private DateTimePicker dtDateTo;
        private Label lblAccountCode;
        private TextBox txtAccountCode;
        private Label lblStatus;
        private ComboBox cboStatus;
        private Button btnMultiFilter;
        private SplitContainer splitContainer1;
        private DataGridView dgvMaster;
        private DataGridViewTextBoxColumn colNo;
        private DataGridViewTextBoxColumn colDate;
        private DataGridViewTextBoxColumn colStatus;
        private DataGridViewTextBoxColumn colRegistrar;
        private DataGridViewTextBoxColumn colPost;
        private DataGridViewTextBoxColumn colPostDate;
        private DataGridView dgvDetail;
        private DataGridViewTextBoxColumn colDetailNo;
        private DataGridViewTextBoxColumn colAccountCode;
        private DataGridViewTextBoxColumn colAccountName;
        private DataGridViewTextBoxColumn colSummary;
        private DataGridViewTextBoxColumn colDebit;
        private DataGridViewTextBoxColumn colCredit;
        private DataGridViewTextBoxColumn colSourceDoc;
        private DataGridViewTextBoxColumn colNote;
        private Panel panelFooter;
        private Label lblSumCap;
        private TextBox txtSumDebit;
        private TextBox txtSumCredit;
    }
}
