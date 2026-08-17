using DigiERP.Common;
using System.Drawing;
using System.Windows.Forms;

namespace DigiERP.UserControl.HR.Overtime
{
    partial class OverTimeControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OverTimeControl));
            panelHeader = new Panel();
            pictureBox1 = new PictureBox();
            lblTitle = new Label();
            lblRecordInfo = new Label();
            btnPrev = new Button();
            btnNext = new Button();
            btnNew = new Button();
            btnDelete = new Button();
            btnModify = new Button();
            btnSave = new Button();
            btnValidate = new Button();
            btnInvalidate = new Button();
            btnStaffReport = new Button();
            btnPrint = new Button();
            btnOverview = new Button();
            btnClose = new Button();
            panelFormHeader = new Panel();
            lblNo = new Label();
            txtNo = new TextBox();
            lblDate = new Label();
            dtDate = new DateTimePicker();
            lblCostUnit = new Label();
            cboCostUnit = new ComboBox();
            lblApplicant = new Label();
            cboApplicant = new ComboBox();
            lblApproved = new Label();
            chkApproved = new CheckBox();
            lblApprover = new Label();
            txtApprover = new TextBox();
            panelBody = new Panel();
            dataGridView1 = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colEmpNo = new DataGridViewComboBoxColumn();
            colName = new DataGridViewTextBoxColumn();
            colOtDate = new DataGridViewDateTimePickerColumn();
            colStart = new DataGridViewTimePickerColumn();
            colEnd = new DataGridViewTimePickerColumn();
            colHours = new DataGridViewComboBoxColumn();
            colReason = new DataGridViewComboBoxColumn();
            colDetail = new DataGridViewTextBoxColumn();
            colRemark = new DataGridViewTextBoxColumn();
            panelGridTool = new Panel();
            btnAddDetailRow = new Button();
            btnDeleteDetailRow = new Button();
            panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelFormHeader.SuspendLayout();
            panelBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panelGridTool.SuspendLayout();
            SuspendLayout();
            //
            // panelHeader
            //
            panelHeader.BackColor = Color.Moccasin;
            panelHeader.Controls.Add(pictureBox1);
            panelHeader.Controls.Add(lblTitle);
            panelHeader.Controls.Add(lblRecordInfo);
            panelHeader.Controls.Add(btnPrev);
            panelHeader.Controls.Add(btnNext);
            panelHeader.Controls.Add(btnNew);
            panelHeader.Controls.Add(btnDelete);
            panelHeader.Controls.Add(btnModify);
            panelHeader.Controls.Add(btnSave);
            panelHeader.Controls.Add(btnValidate);
            panelHeader.Controls.Add(btnInvalidate);
            panelHeader.Controls.Add(btnStaffReport);
            panelHeader.Controls.Add(btnPrint);
            panelHeader.Controls.Add(btnOverview);
            panelHeader.Controls.Add(btnClose);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1360, 56);
            panelHeader.TabIndex = 0;
            //
            // pictureBox1
            //
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(4, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(48, 48);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            //
            // lblTitle
            //
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("微軟正黑體", 13F, FontStyle.Bold);
            lblTitle.ForeColor = Color.Firebrick;
            lblTitle.Location = new Point(58, 4);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(120, 22);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "加班申請單";
            //
            // lblRecordInfo
            //
            lblRecordInfo.AutoSize = true;
            lblRecordInfo.Font = new Font("微軟正黑體", 9F);
            lblRecordInfo.Location = new Point(58, 30);
            lblRecordInfo.Name = "lblRecordInfo";
            lblRecordInfo.Size = new Size(90, 17);
            lblRecordInfo.TabIndex = 2;
            lblRecordInfo.Text = "第 0 筆 / 共 0 筆";
            //
            // btnPrev
            //
            btnPrev.BackColor = Color.Gainsboro;
            btnPrev.FlatStyle = FlatStyle.Flat;
            btnPrev.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            btnPrev.Location = new Point(210, 12);
            btnPrev.Name = "btnPrev";
            btnPrev.Size = new Size(36, 32);
            btnPrev.TabIndex = 3;
            btnPrev.Text = "◄";
            btnPrev.UseVisualStyleBackColor = false;
            btnPrev.Click += btnPrev_Click;
            //
            // btnNext
            //
            btnNext.BackColor = Color.Gainsboro;
            btnNext.FlatStyle = FlatStyle.Flat;
            btnNext.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            btnNext.Location = new Point(250, 12);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(36, 32);
            btnNext.TabIndex = 4;
            btnNext.Text = "►";
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click;
            //
            // btnNew
            //
            btnNew.BackColor = Color.LightSteelBlue;
            btnNew.FlatStyle = FlatStyle.Flat;
            btnNew.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            btnNew.Location = new Point(296, 12);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(66, 32);
            btnNew.TabIndex = 5;
            btnNew.Text = "新增";
            btnNew.UseVisualStyleBackColor = false;
            btnNew.Click += btnNew_Click;
            //
            // btnDelete
            //
            btnDelete.BackColor = Color.IndianRed;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(366, 12);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(66, 32);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "刪除";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            //
            // btnModify
            //
            btnModify.BackColor = Color.SteelBlue;
            btnModify.FlatStyle = FlatStyle.Flat;
            btnModify.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            btnModify.ForeColor = Color.White;
            btnModify.Location = new Point(436, 12);
            btnModify.Name = "btnModify";
            btnModify.Size = new Size(66, 32);
            btnModify.TabIndex = 7;
            btnModify.Text = "修改";
            btnModify.UseVisualStyleBackColor = false;
            btnModify.Click += btnModify_Click;
            //
            // btnSave
            //
            btnSave.BackColor = Color.SeaGreen;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(436, 12);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(66, 32);
            btnSave.TabIndex = 8;
            btnSave.Text = "儲存";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Visible = false;
            btnSave.Click += btnSave_Click;
            //
            // btnValidate
            //
            btnValidate.BackColor = Color.DarkGreen;
            btnValidate.FlatStyle = FlatStyle.Flat;
            btnValidate.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            btnValidate.ForeColor = Color.White;
            btnValidate.Location = new Point(506, 12);
            btnValidate.Name = "btnValidate";
            btnValidate.Size = new Size(66, 32);
            btnValidate.TabIndex = 9;
            btnValidate.Text = "生效";
            btnValidate.UseVisualStyleBackColor = false;
            btnValidate.Click += btnValidate_Click;
            //
            // btnInvalidate
            //
            btnInvalidate.BackColor = Color.Gainsboro;
            btnInvalidate.FlatStyle = FlatStyle.Flat;
            btnInvalidate.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            btnInvalidate.Location = new Point(576, 12);
            btnInvalidate.Name = "btnInvalidate";
            btnInvalidate.Size = new Size(86, 32);
            btnInvalidate.TabIndex = 10;
            btnInvalidate.Text = "取消生效";
            btnInvalidate.UseVisualStyleBackColor = false;
            btnInvalidate.Click += btnInvalidate_Click;
            //
            // btnStaffReport
            //
            btnStaffReport.BackColor = Color.Lavender;
            btnStaffReport.FlatStyle = FlatStyle.Flat;
            btnStaffReport.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            btnStaffReport.Location = new Point(666, 12);
            btnStaffReport.Name = "btnStaffReport";
            btnStaffReport.Size = new Size(130, 32);
            btnStaffReport.TabIndex = 11;
            btnStaffReport.Text = "員工別加班紀錄表";
            btnStaffReport.UseVisualStyleBackColor = false;
            btnStaffReport.Click += btnStaffReport_Click;
            //
            // btnPrint
            //
            btnPrint.BackColor = Color.Gainsboro;
            btnPrint.FlatStyle = FlatStyle.Flat;
            btnPrint.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            btnPrint.Location = new Point(800, 12);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(66, 32);
            btnPrint.TabIndex = 12;
            btnPrint.Text = "列印";
            btnPrint.UseVisualStyleBackColor = false;
            btnPrint.Click += btnPrint_Click;
            //
            // btnOverview
            //
            btnOverview.BackColor = Color.Gainsboro;
            btnOverview.FlatStyle = FlatStyle.Flat;
            btnOverview.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            btnOverview.Location = new Point(870, 12);
            btnOverview.Name = "btnOverview";
            btnOverview.Size = new Size(66, 32);
            btnOverview.TabIndex = 13;
            btnOverview.Text = "總覽";
            btnOverview.UseVisualStyleBackColor = false;
            btnOverview.Click += btnOverview_Click;
            //
            // btnClose
            //
            btnClose.BackColor = Color.Gainsboro;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            btnClose.Location = new Point(940, 12);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(66, 32);
            btnClose.TabIndex = 14;
            btnClose.Text = "關閉";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            //
            // panelFormHeader
            //
            panelFormHeader.Controls.Add(lblNo);
            panelFormHeader.Controls.Add(txtNo);
            panelFormHeader.Controls.Add(lblDate);
            panelFormHeader.Controls.Add(dtDate);
            panelFormHeader.Controls.Add(lblCostUnit);
            panelFormHeader.Controls.Add(cboCostUnit);
            panelFormHeader.Controls.Add(lblApplicant);
            panelFormHeader.Controls.Add(cboApplicant);
            panelFormHeader.Controls.Add(lblApproved);
            panelFormHeader.Controls.Add(chkApproved);
            panelFormHeader.Controls.Add(lblApprover);
            panelFormHeader.Controls.Add(txtApprover);
            panelFormHeader.Dock = DockStyle.Top;
            panelFormHeader.Location = new Point(0, 56);
            panelFormHeader.Name = "panelFormHeader";
            panelFormHeader.Size = new Size(1360, 96);
            panelFormHeader.TabIndex = 1;
            //
            // lblNo
            //
            lblNo.AutoSize = true;
            lblNo.Font = new Font("微軟正黑體", 9F);
            lblNo.Location = new Point(16, 15);
            lblNo.Name = "lblNo";
            lblNo.Size = new Size(70, 17);
            lblNo.TabIndex = 0;
            lblNo.Text = "單據編號:";
            //
            // txtNo
            //
            txtNo.Font = new Font("微軟正黑體", 9F);
            txtNo.Location = new Point(96, 12);
            txtNo.Name = "txtNo";
            txtNo.ReadOnly = true;
            txtNo.Size = new Size(150, 25);
            txtNo.TabIndex = 1;
            //
            // lblDate
            //
            lblDate.AutoSize = true;
            lblDate.Font = new Font("微軟正黑體", 9F);
            lblDate.Location = new Point(266, 15);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(70, 17);
            lblDate.TabIndex = 2;
            lblDate.Text = "申請日期:";
            //
            // dtDate
            //
            dtDate.Font = new Font("微軟正黑體", 9F);
            dtDate.Format = DateTimePickerFormat.Short;
            dtDate.Location = new Point(346, 12);
            dtDate.Name = "dtDate";
            dtDate.Size = new Size(140, 25);
            dtDate.TabIndex = 3;
            dtDate.ValueChanged += dtDate_ValueChanged;
            //
            // lblCostUnit
            //
            lblCostUnit.AutoSize = true;
            lblCostUnit.Font = new Font("微軟正黑體", 9F);
            lblCostUnit.Location = new Point(506, 15);
            lblCostUnit.Name = "lblCostUnit";
            lblCostUnit.Size = new Size(70, 17);
            lblCostUnit.TabIndex = 4;
            lblCostUnit.Text = "申請單位:";
            //
            // cboCostUnit
            //
            cboCostUnit.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCostUnit.Font = new Font("微軟正黑體", 9F);
            cboCostUnit.Location = new Point(586, 12);
            cboCostUnit.Name = "cboCostUnit";
            cboCostUnit.Size = new Size(150, 25);
            cboCostUnit.TabIndex = 5;
            //
            // lblApplicant
            //
            lblApplicant.AutoSize = true;
            lblApplicant.Font = new Font("微軟正黑體", 9F);
            lblApplicant.Location = new Point(16, 55);
            lblApplicant.Name = "lblApplicant";
            lblApplicant.Size = new Size(70, 17);
            lblApplicant.TabIndex = 6;
            lblApplicant.Text = "申請人:";
            //
            // cboApplicant
            //
            cboApplicant.DropDownStyle = ComboBoxStyle.DropDownList;
            cboApplicant.Font = new Font("微軟正黑體", 9F);
            cboApplicant.Location = new Point(96, 52);
            cboApplicant.Name = "cboApplicant";
            cboApplicant.Size = new Size(150, 25);
            cboApplicant.TabIndex = 7;
            //
            // lblApproved
            //
            lblApproved.AutoSize = true;
            lblApproved.Font = new Font("微軟正黑體", 9F);
            lblApproved.Location = new Point(266, 55);
            lblApproved.Name = "lblApproved";
            lblApproved.Size = new Size(70, 17);
            lblApproved.TabIndex = 8;
            lblApproved.Text = "核准生效:";
            //
            // chkApproved
            //
            chkApproved.AutoSize = true;
            chkApproved.Enabled = false;
            chkApproved.Location = new Point(346, 55);
            chkApproved.Name = "chkApproved";
            chkApproved.Size = new Size(15, 14);
            chkApproved.TabIndex = 9;
            chkApproved.UseVisualStyleBackColor = true;
            //
            // lblApprover
            //
            lblApprover.AutoSize = true;
            lblApprover.Font = new Font("微軟正黑體", 9F);
            lblApprover.Location = new Point(506, 55);
            lblApprover.Name = "lblApprover";
            lblApprover.Size = new Size(70, 17);
            lblApprover.TabIndex = 10;
            lblApprover.Text = "核准人:";
            //
            // txtApprover
            //
            txtApprover.Font = new Font("微軟正黑體", 9F);
            txtApprover.Location = new Point(586, 52);
            txtApprover.Name = "txtApprover";
            txtApprover.ReadOnly = true;
            txtApprover.Size = new Size(150, 25);
            txtApprover.TabIndex = 11;
            //
            // panelBody
            //
            panelBody.Controls.Add(dataGridView1);
            panelBody.Controls.Add(panelGridTool);
            panelBody.Dock = DockStyle.Fill;
            panelBody.Location = new Point(0, 152);
            panelBody.Name = "panelBody";
            panelBody.Size = new Size(1360, 548);
            panelBody.TabIndex = 2;
            //
            // dataGridView1
            //
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colId, colEmpNo, colName, colOtDate, colStart, colEnd, colHours, colReason, colDetail, colRemark });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Font = new Font("微軟正黑體", 9F);
            dataGridView1.Location = new Point(0, 40);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 26;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1360, 508);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellEndEdit += dataGridView1_CellEndEdit;
            dataGridView1.CurrentCellDirtyStateChanged += dataGridView1_CurrentCellDirtyStateChanged;
            dataGridView1.EditingControlShowing += dataGridView1_EditingControlShowing;
            //
            // colId
            //
            colId.HeaderText = "識別碼";
            colId.Name = "colId";
            colId.ReadOnly = true;
            colId.Visible = false;
            //
            // colEmpNo
            //
            colEmpNo.HeaderText = "員工編號";
            colEmpNo.Name = "colEmpNo";
            colEmpNo.Width = 90;
            //
            // colName
            //
            colName.HeaderText = "姓名";
            colName.Name = "colName";
            colName.ReadOnly = true;
            colName.Width = 80;
            //
            // colOtDate
            //
            colOtDate.HeaderText = "加班日期";
            colOtDate.Name = "colOtDate";
            colOtDate.Width = 100;
            //
            // colStart
            //
            colStart.HeaderText = "起";
            colStart.Name = "colStart";
            colStart.Width = 70;
            //
            // colEnd
            //
            colEnd.HeaderText = "訖";
            colEnd.Name = "colEnd";
            colEnd.Width = 70;
            //
            // colHours
            //
            colHours.HeaderText = "時數";
            colHours.Name = "colHours";
            colHours.Width = 70;
            colHours.Items.AddRange(new object[] { "0.5", "1.0", "1.5", "2.0", "2.5", "3.0", "3.5", "4.0" });
            //
            // colReason
            //
            colReason.HeaderText = "加班事由";
            colReason.Name = "colReason";
            colReason.Width = 110;
            //
            // colDetail
            //
            colDetail.HeaderText = "加班內容詳述";
            colDetail.Name = "colDetail";
            colDetail.Width = 160;
            //
            // colRemark
            //
            colRemark.HeaderText = "備註";
            colRemark.Name = "colRemark";
            colRemark.Width = 160;
            //
            // panelGridTool
            //
            panelGridTool.Controls.Add(btnAddDetailRow);
            panelGridTool.Controls.Add(btnDeleteDetailRow);
            panelGridTool.Dock = DockStyle.Top;
            panelGridTool.Location = new Point(0, 0);
            panelGridTool.Name = "panelGridTool";
            panelGridTool.Size = new Size(1360, 40);
            panelGridTool.TabIndex = 0;
            //
            // btnAddDetailRow
            //
            btnAddDetailRow.BackColor = Color.LightSteelBlue;
            btnAddDetailRow.FlatStyle = FlatStyle.Flat;
            btnAddDetailRow.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            btnAddDetailRow.Location = new Point(10, 4);
            btnAddDetailRow.Name = "btnAddDetailRow";
            btnAddDetailRow.Size = new Size(90, 32);
            btnAddDetailRow.TabIndex = 0;
            btnAddDetailRow.Text = "新增明細";
            btnAddDetailRow.UseVisualStyleBackColor = false;
            btnAddDetailRow.Click += btnAddDetailRow_Click;
            //
            // btnDeleteDetailRow
            //
            btnDeleteDetailRow.BackColor = Color.Gainsboro;
            btnDeleteDetailRow.FlatStyle = FlatStyle.Flat;
            btnDeleteDetailRow.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            btnDeleteDetailRow.Location = new Point(106, 4);
            btnDeleteDetailRow.Name = "btnDeleteDetailRow";
            btnDeleteDetailRow.Size = new Size(90, 32);
            btnDeleteDetailRow.TabIndex = 1;
            btnDeleteDetailRow.Text = "刪除明細";
            btnDeleteDetailRow.UseVisualStyleBackColor = false;
            btnDeleteDetailRow.Click += btnDeleteDetailRow_Click;
            //
            // OverTimeControl
            //
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelBody);
            Controls.Add(panelFormHeader);
            Controls.Add(panelHeader);
            Font = new Font("微軟正黑體", 10F);
            Margin = new Padding(4);
            Name = "OverTimeControl";
            Size = new Size(1360, 700);
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelFormHeader.ResumeLayout(false);
            panelFormHeader.PerformLayout();
            panelBody.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panelGridTool.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private PictureBox pictureBox1;
        private Label lblTitle;
        private Label lblRecordInfo;
        private Button btnPrev;
        private Button btnNext;
        private Button btnNew;
        private Button btnDelete;
        private Button btnModify;
        private Button btnSave;
        private Button btnValidate;
        private Button btnInvalidate;
        private Button btnStaffReport;
        private Button btnPrint;
        private Button btnOverview;
        private Button btnClose;
        private Panel panelFormHeader;
        private Label lblNo;
        private TextBox txtNo;
        private Label lblDate;
        private DateTimePicker dtDate;
        private Label lblCostUnit;
        private ComboBox cboCostUnit;
        private Label lblApplicant;
        private ComboBox cboApplicant;
        private Label lblApproved;
        private CheckBox chkApproved;
        private Label lblApprover;
        private TextBox txtApprover;
        private Panel panelBody;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewComboBoxColumn colEmpNo;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewDateTimePickerColumn colOtDate;
        private DataGridViewTimePickerColumn colStart;
        private DataGridViewTimePickerColumn colEnd;
        private DataGridViewComboBoxColumn colHours;
        private DataGridViewComboBoxColumn colReason;
        private DataGridViewTextBoxColumn colDetail;
        private DataGridViewTextBoxColumn colRemark;
        private Panel panelGridTool;
        private Button btnAddDetailRow;
        private Button btnDeleteDetailRow;
    }
}
