using System.Drawing;
using System.Windows.Forms;

namespace DigiERP.UserControl.Objective.Bank
{
    partial class CurrencyAdjustMaintainControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CurrencyAdjustMaintainControl));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            lblTitle = new Label();
            btnDelete = new Button();
            btnAdd = new Button();
            btnModify = new Button();
            btnSave = new Button();
            btnVerify = new Button();
            btnCancelVerify = new Button();
            btnPrint = new Button();
            btnClose = new Button();
            panel2 = new Panel();
            lblDate = new Label();
            dtDate = new DateTimePicker();
            lblNo = new Label();
            txtNo = new TextBox();
            lblPurpose = new Label();
            cboPurpose = new ComboBox();
            lblSubjectCode = new Label();
            txtSubjectCode = new TextBox();
            lblSubjectName = new Label();
            txtSubjectName = new TextBox();
            lblVoucherNo = new Label();
            txtVoucherNo = new TextBox();
            lblRemark = new Label();
            txtRemark = new TextBox();
            panel3 = new Panel();
            dataGridView1 = new DataGridView();
            colBank = new DataGridViewComboBoxColumn();
            colBankName = new DataGridViewTextBoxColumn();
            colDate = new DigiERP.Common.DataGridViewDateTimePickerColumn();
            colSummary = new DataGridViewTextBoxColumn();
            colDeposit = new DataGridViewTextBoxColumn();
            colWithdraw = new DataGridViewTextBoxColumn();
            colCurrency = new DataGridViewComboBoxColumn();
            colExRate = new DataGridViewTextBoxColumn();
            colDetailRemark = new DataGridViewTextBoxColumn();
            panel4 = new Panel();
            lblCreatorCap = new Label();
            txtCreator = new TextBox();
            lblCreateDateCap = new Label();
            txtCreateDate = new TextBox();
            lblModifierCap = new Label();
            txtModifier = new TextBox();
            lblModifyDateCap = new Label();
            txtModifyDate = new TextBox();
            lblReviewerCap = new Label();
            txtReviewer = new TextBox();
            lblReviewDateCap = new Label();
            txtReviewDate = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel4.SuspendLayout();
            SuspendLayout();
            //
            // panel1
            //
            panel1.BackColor = Color.Honeydew;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(lblTitle);
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(btnModify);
            panel1.Controls.Add(btnSave);
            panel1.Controls.Add(btnVerify);
            panel1.Controls.Add(btnCancelVerify);
            panel1.Controls.Add(btnPrint);
            panel1.Controls.Add(btnClose);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1539, 56);
            panel1.TabIndex = 0;
            //
            // pictureBox1
            //
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(4, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(48, 48);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            //
            // lblTitle
            //
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("微軟正黑體", 13F, FontStyle.Bold);
            lblTitle.ForeColor = Color.Firebrick;
            lblTitle.Location = new Point(60, 16);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(100, 23);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "資金調節";
            //
            // btnDelete
            //
            btnDelete.BackColor = Color.Firebrick;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(444, 12);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(98, 32);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "刪除紀錄";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            //
            // btnAdd
            //
            btnAdd.BackColor = Color.Gainsboro;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            btnAdd.Location = new Point(548, 12);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(98, 32);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "新增";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            //
            // btnModify
            //
            btnModify.BackColor = Color.Gainsboro;
            btnModify.FlatStyle = FlatStyle.Flat;
            btnModify.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            btnModify.Location = new Point(652, 12);
            btnModify.Name = "btnModify";
            btnModify.Size = new Size(98, 32);
            btnModify.TabIndex = 4;
            btnModify.Text = "修改";
            btnModify.UseVisualStyleBackColor = false;
            btnModify.Click += btnModify_Click;
            //
            // btnSave
            //
            btnSave.BackColor = Color.Gainsboro;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            btnSave.Location = new Point(756, 12);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(98, 32);
            btnSave.TabIndex = 5;
            btnSave.Text = "儲存";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            //
            // btnVerify
            //
            btnVerify.BackColor = Color.Gainsboro;
            btnVerify.FlatStyle = FlatStyle.Flat;
            btnVerify.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            btnVerify.Location = new Point(860, 12);
            btnVerify.Name = "btnVerify";
            btnVerify.Size = new Size(98, 32);
            btnVerify.TabIndex = 6;
            btnVerify.Text = "覆核";
            btnVerify.UseVisualStyleBackColor = false;
            btnVerify.Click += btnVerify_Click;
            //
            // btnCancelVerify
            //
            btnCancelVerify.BackColor = Color.Gainsboro;
            btnCancelVerify.FlatStyle = FlatStyle.Flat;
            btnCancelVerify.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            btnCancelVerify.Location = new Point(964, 12);
            btnCancelVerify.Name = "btnCancelVerify";
            btnCancelVerify.Size = new Size(98, 32);
            btnCancelVerify.TabIndex = 7;
            btnCancelVerify.Text = "取消覆核";
            btnCancelVerify.UseVisualStyleBackColor = false;
            btnCancelVerify.Click += btnCancelVerify_Click;
            //
            // btnPrint
            //
            btnPrint.BackColor = Color.Gainsboro;
            btnPrint.FlatStyle = FlatStyle.Flat;
            btnPrint.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            btnPrint.Location = new Point(1068, 12);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(98, 32);
            btnPrint.TabIndex = 8;
            btnPrint.Text = "列印";
            btnPrint.UseVisualStyleBackColor = false;
            btnPrint.Click += btnPrint_Click;
            //
            // btnClose
            //
            btnClose.BackColor = Color.Gainsboro;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            btnClose.Location = new Point(1276, 12);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(98, 32);
            btnClose.TabIndex = 10;
            btnClose.Text = "關閉";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            //
            // panel2
            //
            panel2.BackColor = Color.Honeydew;
            panel2.Controls.Add(lblDate);
            panel2.Controls.Add(dtDate);
            panel2.Controls.Add(lblNo);
            panel2.Controls.Add(txtNo);
            panel2.Controls.Add(lblPurpose);
            panel2.Controls.Add(cboPurpose);
            panel2.Controls.Add(lblSubjectCode);
            panel2.Controls.Add(txtSubjectCode);
            panel2.Controls.Add(lblSubjectName);
            panel2.Controls.Add(txtSubjectName);
            panel2.Controls.Add(lblVoucherNo);
            panel2.Controls.Add(txtVoucherNo);
            panel2.Controls.Add(lblRemark);
            panel2.Controls.Add(txtRemark);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 56);
            panel2.Name = "panel2";
            panel2.Size = new Size(1539, 96);
            panel2.TabIndex = 1;
            //
            // lblDate
            //
            lblDate.AutoSize = true;
            lblDate.Location = new Point(8, 10);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(36, 18);
            lblDate.TabIndex = 0;
            lblDate.Text = "日期";
            //
            // dtDate
            //
            dtDate.Enabled = false;
            dtDate.Format = DateTimePickerFormat.Short;
            dtDate.Location = new Point(62, 6);
            dtDate.Name = "dtDate";
            dtDate.Size = new Size(130, 25);
            dtDate.TabIndex = 1;
            //
            // lblNo
            //
            lblNo.AutoSize = true;
            lblNo.Location = new Point(204, 8);
            lblNo.Name = "lblNo";
            lblNo.Size = new Size(36, 18);
            lblNo.TabIndex = 2;
            lblNo.Text = "單號";
            //
            // txtNo
            //
            txtNo.Location = new Point(258, 4);
            txtNo.Name = "txtNo";
            txtNo.ReadOnly = true;
            txtNo.Size = new Size(150, 25);
            txtNo.TabIndex = 3;
            //
            // lblPurpose
            //
            lblPurpose.AutoSize = true;
            lblPurpose.Location = new Point(420, 8);
            lblPurpose.Name = "lblPurpose";
            lblPurpose.Size = new Size(36, 18);
            lblPurpose.TabIndex = 4;
            lblPurpose.Text = "用途";
            //
            // cboPurpose
            //
            cboPurpose.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPurpose.FormattingEnabled = true;
            cboPurpose.Location = new Point(474, 4);
            cboPurpose.Name = "cboPurpose";
            cboPurpose.Size = new Size(180, 25);
            cboPurpose.TabIndex = 5;
            cboPurpose.SelectedIndexChanged += cboPurpose_SelectedIndexChanged;
            //
            // lblSubjectCode
            //
            lblSubjectCode.AutoSize = true;
            lblSubjectCode.Location = new Point(668, 8);
            lblSubjectCode.Name = "lblSubjectCode";
            lblSubjectCode.Size = new Size(64, 18);
            lblSubjectCode.TabIndex = 6;
            lblSubjectCode.Text = "會科代碼";
            //
            // txtSubjectCode
            //
            txtSubjectCode.Location = new Point(742, 4);
            txtSubjectCode.Name = "txtSubjectCode";
            txtSubjectCode.ReadOnly = true;
            txtSubjectCode.Size = new Size(90, 25);
            txtSubjectCode.TabIndex = 7;
            //
            // lblSubjectName
            //
            lblSubjectName.AutoSize = true;
            lblSubjectName.Location = new Point(848, 8);
            lblSubjectName.Name = "lblSubjectName";
            lblSubjectName.Size = new Size(64, 18);
            lblSubjectName.TabIndex = 8;
            lblSubjectName.Text = "會科名稱";
            //
            // txtSubjectName
            //
            txtSubjectName.Location = new Point(922, 4);
            txtSubjectName.Name = "txtSubjectName";
            txtSubjectName.ReadOnly = true;
            txtSubjectName.Size = new Size(180, 25);
            txtSubjectName.TabIndex = 9;
            //
            // lblVoucherNo
            //
            lblVoucherNo.AutoSize = true;
            lblVoucherNo.Location = new Point(8, 46);
            lblVoucherNo.Name = "lblVoucherNo";
            lblVoucherNo.Size = new Size(64, 18);
            lblVoucherNo.TabIndex = 10;
            lblVoucherNo.Text = "傳票編號";
            //
            // txtVoucherNo
            //
            txtVoucherNo.Location = new Point(82, 42);
            txtVoucherNo.Name = "txtVoucherNo";
            txtVoucherNo.Size = new Size(140, 25);
            txtVoucherNo.TabIndex = 11;
            //
            // lblRemark
            //
            lblRemark.AutoSize = true;
            lblRemark.Location = new Point(238, 46);
            lblRemark.Name = "lblRemark";
            lblRemark.Size = new Size(36, 18);
            lblRemark.TabIndex = 12;
            lblRemark.Text = "備註";
            //
            // txtRemark
            //
            txtRemark.Location = new Point(292, 42);
            txtRemark.Name = "txtRemark";
            txtRemark.Size = new Size(500, 25);
            txtRemark.TabIndex = 13;
            //
            // panel3
            //
            panel3.Controls.Add(dataGridView1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 152);
            panel3.Name = "panel3";
            panel3.Size = new Size(1539, 384);
            panel3.TabIndex = 2;
            //
            // dataGridView1
            //
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colBank, colBankName, colDate, colSummary, colDeposit, colWithdraw, colCurrency, colExRate, colDetailRemark });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Font = new Font("微軟正黑體", 9F);
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 26;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1539, 384);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellValueChanged += dataGridView1_CellValueChanged;
            dataGridView1.CurrentCellDirtyStateChanged += dataGridView1_CurrentCellDirtyStateChanged;
            //
            // colBank
            //
            colBank.HeaderText = "銀存編碼";
            colBank.Name = "colBank";
            //
            // colBankName
            //
            colBankName.FillWeight = 160F;
            colBankName.HeaderText = "銀存名稱";
            colBankName.Name = "colBankName";
            colBankName.ReadOnly = true;
            //
            // colDate
            //
            colDate.HeaderText = "日期";
            colDate.Name = "colDate";
            //
            // colSummary
            //
            colSummary.FillWeight = 160F;
            colSummary.HeaderText = "摘要";
            colSummary.Name = "colSummary";
            //
            // colDeposit
            //
            colDeposit.HeaderText = "存入";
            colDeposit.Name = "colDeposit";
            //
            // colWithdraw
            //
            colWithdraw.HeaderText = "支出";
            colWithdraw.Name = "colWithdraw";
            //
            // colCurrency
            //
            colCurrency.HeaderText = "幣別";
            colCurrency.Name = "colCurrency";
            //
            // colExRate
            //
            colExRate.HeaderText = "轉帳匯率";
            colExRate.Name = "colExRate";
            colExRate.ReadOnly = true;
            //
            // colDetailRemark
            //
            colDetailRemark.FillWeight = 200F;
            colDetailRemark.HeaderText = "備註";
            colDetailRemark.Name = "colDetailRemark";
            //
            // panel4
            //
            panel4.BackColor = Color.Honeydew;
            panel4.Controls.Add(lblCreatorCap);
            panel4.Controls.Add(txtCreator);
            panel4.Controls.Add(lblCreateDateCap);
            panel4.Controls.Add(txtCreateDate);
            panel4.Controls.Add(lblModifierCap);
            panel4.Controls.Add(txtModifier);
            panel4.Controls.Add(lblModifyDateCap);
            panel4.Controls.Add(txtModifyDate);
            panel4.Controls.Add(lblReviewerCap);
            panel4.Controls.Add(txtReviewer);
            panel4.Controls.Add(lblReviewDateCap);
            panel4.Controls.Add(txtReviewDate);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(0, 536);
            panel4.Name = "panel4";
            panel4.Size = new Size(1539, 64);
            panel4.TabIndex = 3;
            //
            // lblCreatorCap
            //
            lblCreatorCap.AutoSize = true;
            lblCreatorCap.Location = new Point(10, 20);
            lblCreatorCap.Name = "lblCreatorCap";
            lblCreatorCap.Size = new Size(64, 18);
            lblCreatorCap.TabIndex = 0;
            lblCreatorCap.Text = "建檔人員";
            //
            // txtCreator
            //
            txtCreator.Location = new Point(92, 16);
            txtCreator.Name = "txtCreator";
            txtCreator.ReadOnly = true;
            txtCreator.Size = new Size(120, 25);
            txtCreator.TabIndex = 1;
            //
            // lblCreateDateCap
            //
            lblCreateDateCap.AutoSize = true;
            lblCreateDateCap.Location = new Point(226, 20);
            lblCreateDateCap.Name = "lblCreateDateCap";
            lblCreateDateCap.Size = new Size(50, 18);
            lblCreateDateCap.TabIndex = 2;
            lblCreateDateCap.Text = "建檔日";
            //
            // txtCreateDate
            //
            txtCreateDate.Location = new Point(288, 16);
            txtCreateDate.Name = "txtCreateDate";
            txtCreateDate.ReadOnly = true;
            txtCreateDate.Size = new Size(120, 25);
            txtCreateDate.TabIndex = 3;
            //
            // lblModifierCap
            //
            lblModifierCap.AutoSize = true;
            lblModifierCap.Location = new Point(430, 20);
            lblModifierCap.Name = "lblModifierCap";
            lblModifierCap.Size = new Size(64, 18);
            lblModifierCap.TabIndex = 4;
            lblModifierCap.Text = "修改人員";
            //
            // txtModifier
            //
            txtModifier.Location = new Point(512, 16);
            txtModifier.Name = "txtModifier";
            txtModifier.ReadOnly = true;
            txtModifier.Size = new Size(120, 25);
            txtModifier.TabIndex = 5;
            //
            // lblModifyDateCap
            //
            lblModifyDateCap.AutoSize = true;
            lblModifyDateCap.Location = new Point(646, 20);
            lblModifyDateCap.Name = "lblModifyDateCap";
            lblModifyDateCap.Size = new Size(50, 18);
            lblModifyDateCap.TabIndex = 6;
            lblModifyDateCap.Text = "修改日";
            //
            // txtModifyDate
            //
            txtModifyDate.Location = new Point(708, 16);
            txtModifyDate.Name = "txtModifyDate";
            txtModifyDate.ReadOnly = true;
            txtModifyDate.Size = new Size(120, 25);
            txtModifyDate.TabIndex = 7;
            //
            // lblReviewerCap
            //
            lblReviewerCap.AutoSize = true;
            lblReviewerCap.Location = new Point(850, 20);
            lblReviewerCap.Name = "lblReviewerCap";
            lblReviewerCap.Size = new Size(64, 18);
            lblReviewerCap.TabIndex = 8;
            lblReviewerCap.Text = "核准人員";
            //
            // txtReviewer
            //
            txtReviewer.Location = new Point(932, 16);
            txtReviewer.Name = "txtReviewer";
            txtReviewer.ReadOnly = true;
            txtReviewer.Size = new Size(120, 25);
            txtReviewer.TabIndex = 9;
            //
            // lblReviewDateCap
            //
            lblReviewDateCap.AutoSize = true;
            lblReviewDateCap.Location = new Point(1066, 20);
            lblReviewDateCap.Name = "lblReviewDateCap";
            lblReviewDateCap.Size = new Size(50, 18);
            lblReviewDateCap.TabIndex = 10;
            lblReviewDateCap.Text = "核准日";
            //
            // txtReviewDate
            //
            txtReviewDate.Location = new Point(1128, 16);
            txtReviewDate.Name = "txtReviewDate";
            txtReviewDate.ReadOnly = true;
            txtReviewDate.Size = new Size(120, 25);
            txtReviewDate.TabIndex = 11;
            //
            // CurrencyAdjustMaintainControl
            //
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel3);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("微軟正黑體", 10F);
            Margin = new Padding(4);
            Name = "CurrencyAdjustMaintainControl";
            Size = new Size(1539, 656);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label lblTitle;
        private Button btnDelete;
        private Button btnAdd;
        private Button btnModify;
        private Button btnSave;
        private Button btnVerify;
        private Button btnCancelVerify;
        private Button btnPrint;
        private Button btnClose;
        private Panel panel2;
        private Label lblDate;
        private DateTimePicker dtDate;
        private Label lblNo;
        private TextBox txtNo;
        private Label lblPurpose;
        private ComboBox cboPurpose;
        private Label lblSubjectCode;
        private TextBox txtSubjectCode;
        private Label lblSubjectName;
        private TextBox txtSubjectName;
        private Label lblVoucherNo;
        private TextBox txtVoucherNo;
        private Label lblRemark;
        private TextBox txtRemark;
        private Panel panel3;
        private DataGridView dataGridView1;
        private DataGridViewComboBoxColumn colBank;
        private DataGridViewTextBoxColumn colBankName;
        private DigiERP.Common.DataGridViewDateTimePickerColumn colDate;
        private DataGridViewTextBoxColumn colSummary;
        private DataGridViewTextBoxColumn colDeposit;
        private DataGridViewTextBoxColumn colWithdraw;
        private DataGridViewComboBoxColumn colCurrency;
        private DataGridViewTextBoxColumn colExRate;
        private DataGridViewTextBoxColumn colDetailRemark;
        private Panel panel4;
        private Label lblCreatorCap;
        private TextBox txtCreator;
        private Label lblCreateDateCap;
        private TextBox txtCreateDate;
        private Label lblModifierCap;
        private TextBox txtModifier;
        private Label lblModifyDateCap;
        private TextBox txtModifyDate;
        private Label lblReviewerCap;
        private TextBox txtReviewer;
        private Label lblReviewDateCap;
        private TextBox txtReviewDate;
    }
}
