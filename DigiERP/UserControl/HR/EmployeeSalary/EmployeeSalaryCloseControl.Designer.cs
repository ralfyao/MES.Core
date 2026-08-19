using DigiERP.Common;
using System.Drawing;
using System.Windows.Forms;

namespace DigiERP.UserControl.HR.EmployeeSalary
{
    partial class EmployeeSalaryCloseControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeSalaryCloseControl));
            panelHeader = new Panel();
            pictureBox1 = new PictureBox();
            lblTitle = new Label();
            lblRecordInfo = new Label();
            btnPrev = new Button();
            btnNext = new Button();
            btnNew = new Button();
            btnModify = new Button();
            btnSave = new Button();
            btnCloseMonth = new Button();
            btnReopenMonth = new Button();
            btnCostImport = new Button();
            btnQuery = new Button();
            btnExit = new Button();
            panelFormHeader = new Panel();
            lblYearMonth = new Label();
            dtYearMonth = new DateTimePicker();
            lblMonthEndDate = new Label();
            dtMonthEndDate = new DateTimePicker();
            lblClosed = new Label();
            chkClosed = new CheckBox();
            lblVoucher = new Label();
            txtVoucher = new TextBox();
            lblCreator = new Label();
            txtCreator = new TextBox();
            lblCreateDate = new Label();
            txtCreateDate = new TextBox();
            lblModifier = new Label();
            txtModifier = new TextBox();
            lblModifyDate = new Label();
            txtModifyDate = new TextBox();
            lblApprover = new Label();
            txtApprover = new TextBox();
            lblApproveDate = new Label();
            txtApproveDate = new TextBox();
            panelBody = new Panel();
            dataGridView1 = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colEmpNo = new DataGridViewComboBoxColumn();
            colName = new DataGridViewTextBoxColumn();
            colAmount = new DataGridViewTextBoxColumn();
            colLeaveDeduct = new DataGridViewTextBoxColumn();
            colLateDeduct = new DataGridViewTextBoxColumn();
            colAttendHours = new DataGridViewTextBoxColumn();
            colLaborCost = new DataGridViewTextBoxColumn();
            panelGridTool = new Panel();
            btnAddDetailRow = new Button();
            btnDeleteDetailRow = new Button();
            panelFooter = new Panel();
            lblSumAmount = new Label();
            lblSumLeaveDeduct = new Label();
            lblSumLateDeduct = new Label();
            panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelFormHeader.SuspendLayout();
            panelBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panelGridTool.SuspendLayout();
            panelFooter.SuspendLayout();
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
            panelHeader.Controls.Add(btnModify);
            panelHeader.Controls.Add(btnSave);
            panelHeader.Controls.Add(btnCloseMonth);
            panelHeader.Controls.Add(btnReopenMonth);
            panelHeader.Controls.Add(btnCostImport);
            panelHeader.Controls.Add(btnQuery);
            panelHeader.Controls.Add(btnExit);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1400, 56);
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
            lblTitle.Size = new Size(90, 22);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "薪資月結";
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
            // btnModify
            //
            btnModify.BackColor = Color.SteelBlue;
            btnModify.FlatStyle = FlatStyle.Flat;
            btnModify.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            btnModify.ForeColor = Color.White;
            btnModify.Location = new Point(366, 12);
            btnModify.Name = "btnModify";
            btnModify.Size = new Size(66, 32);
            btnModify.TabIndex = 6;
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
            btnSave.Location = new Point(366, 12);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(66, 32);
            btnSave.TabIndex = 7;
            btnSave.Text = "儲存";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Visible = false;
            btnSave.Click += btnSave_Click;
            //
            // btnCloseMonth
            //
            btnCloseMonth.BackColor = Color.DarkGreen;
            btnCloseMonth.FlatStyle = FlatStyle.Flat;
            btnCloseMonth.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            btnCloseMonth.ForeColor = Color.White;
            btnCloseMonth.Location = new Point(436, 12);
            btnCloseMonth.Name = "btnCloseMonth";
            btnCloseMonth.Size = new Size(66, 32);
            btnCloseMonth.TabIndex = 8;
            btnCloseMonth.Text = "結帳";
            btnCloseMonth.UseVisualStyleBackColor = false;
            btnCloseMonth.Click += btnCloseMonth_Click;
            //
            // btnReopenMonth
            //
            btnReopenMonth.BackColor = Color.Gainsboro;
            btnReopenMonth.FlatStyle = FlatStyle.Flat;
            btnReopenMonth.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            btnReopenMonth.Location = new Point(506, 12);
            btnReopenMonth.Name = "btnReopenMonth";
            btnReopenMonth.Size = new Size(86, 32);
            btnReopenMonth.TabIndex = 9;
            btnReopenMonth.Text = "取消結帳";
            btnReopenMonth.UseVisualStyleBackColor = false;
            btnReopenMonth.Click += btnReopenMonth_Click;
            //
            // btnCostImport
            //
            btnCostImport.BackColor = Color.Lavender;
            btnCostImport.FlatStyle = FlatStyle.Flat;
            btnCostImport.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            btnCostImport.Location = new Point(596, 12);
            btnCostImport.Name = "btnCostImport";
            btnCostImport.Size = new Size(130, 32);
            btnCostImport.TabIndex = 10;
            btnCostImport.Text = "月工資成本導入";
            btnCostImport.UseVisualStyleBackColor = false;
            btnCostImport.Click += btnCostImport_Click;
            //
            // btnQuery
            //
            btnQuery.BackColor = Color.Gainsboro;
            btnQuery.FlatStyle = FlatStyle.Flat;
            btnQuery.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            btnQuery.Location = new Point(1180, 12);
            btnQuery.Name = "btnQuery";
            btnQuery.Size = new Size(90, 32);
            btnQuery.TabIndex = 11;
            btnQuery.Text = "查詢";
            btnQuery.UseVisualStyleBackColor = false;
            btnQuery.Click += btnQuery_Click;
            //
            // btnExit
            //
            btnExit.BackColor = Color.Gainsboro;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            btnExit.Location = new Point(1280, 12);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(100, 32);
            btnExit.TabIndex = 12;
            btnExit.Text = "關閉";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            //
            // panelFormHeader
            //
            panelFormHeader.Controls.Add(lblYearMonth);
            panelFormHeader.Controls.Add(dtYearMonth);
            panelFormHeader.Controls.Add(lblMonthEndDate);
            panelFormHeader.Controls.Add(dtMonthEndDate);
            panelFormHeader.Controls.Add(lblClosed);
            panelFormHeader.Controls.Add(chkClosed);
            panelFormHeader.Controls.Add(lblVoucher);
            panelFormHeader.Controls.Add(txtVoucher);
            panelFormHeader.Controls.Add(lblCreator);
            panelFormHeader.Controls.Add(txtCreator);
            panelFormHeader.Controls.Add(lblCreateDate);
            panelFormHeader.Controls.Add(txtCreateDate);
            panelFormHeader.Controls.Add(lblModifier);
            panelFormHeader.Controls.Add(txtModifier);
            panelFormHeader.Controls.Add(lblModifyDate);
            panelFormHeader.Controls.Add(txtModifyDate);
            panelFormHeader.Controls.Add(lblApprover);
            panelFormHeader.Controls.Add(txtApprover);
            panelFormHeader.Controls.Add(lblApproveDate);
            panelFormHeader.Controls.Add(txtApproveDate);
            panelFormHeader.Dock = DockStyle.Top;
            panelFormHeader.Location = new Point(0, 56);
            panelFormHeader.Name = "panelFormHeader";
            panelFormHeader.Size = new Size(1400, 96);
            panelFormHeader.TabIndex = 1;
            //
            // lblYearMonth
            //
            lblYearMonth.AutoSize = true;
            lblYearMonth.Font = new Font("微軟正黑體", 9F);
            lblYearMonth.Location = new Point(16, 15);
            lblYearMonth.Name = "lblYearMonth";
            lblYearMonth.Size = new Size(56, 17);
            lblYearMonth.TabIndex = 0;
            lblYearMonth.Text = "年月:";
            //
            // dtYearMonth
            //
            dtYearMonth.CustomFormat = "yyyy/MM";
            dtYearMonth.Font = new Font("微軟正黑體", 9F);
            dtYearMonth.Format = DateTimePickerFormat.Custom;
            dtYearMonth.Location = new Point(76, 12);
            dtYearMonth.Name = "dtYearMonth";
            dtYearMonth.ShowUpDown = true;
            dtYearMonth.Size = new Size(110, 25);
            dtYearMonth.TabIndex = 1;
            dtYearMonth.ValueChanged += dtYearMonth_ValueChanged;
            //
            // lblMonthEndDate
            //
            lblMonthEndDate.AutoSize = true;
            lblMonthEndDate.Font = new Font("微軟正黑體", 9F);
            lblMonthEndDate.Location = new Point(206, 15);
            lblMonthEndDate.Name = "lblMonthEndDate";
            lblMonthEndDate.Size = new Size(56, 17);
            lblMonthEndDate.TabIndex = 2;
            lblMonthEndDate.Text = "月底日:";
            //
            // dtMonthEndDate
            //
            dtMonthEndDate.Font = new Font("微軟正黑體", 9F);
            dtMonthEndDate.Format = DateTimePickerFormat.Short;
            dtMonthEndDate.Location = new Point(266, 12);
            dtMonthEndDate.Name = "dtMonthEndDate";
            dtMonthEndDate.Size = new Size(120, 25);
            dtMonthEndDate.TabIndex = 3;
            //
            // lblClosed
            //
            lblClosed.AutoSize = true;
            lblClosed.Font = new Font("微軟正黑體", 9F);
            lblClosed.Location = new Point(406, 15);
            lblClosed.Name = "lblClosed";
            lblClosed.Size = new Size(56, 17);
            lblClosed.TabIndex = 4;
            lblClosed.Text = "月結:";
            //
            // chkClosed
            //
            chkClosed.AutoSize = true;
            chkClosed.Enabled = false;
            chkClosed.Location = new Point(466, 15);
            chkClosed.Name = "chkClosed";
            chkClosed.Size = new Size(15, 14);
            chkClosed.TabIndex = 5;
            chkClosed.UseVisualStyleBackColor = true;
            //
            // lblVoucher
            //
            lblVoucher.AutoSize = true;
            lblVoucher.Font = new Font("微軟正黑體", 9F);
            lblVoucher.Location = new Point(506, 15);
            lblVoucher.Name = "lblVoucher";
            lblVoucher.Size = new Size(80, 17);
            lblVoucher.TabIndex = 6;
            lblVoucher.Text = "會計傳票:";
            //
            // txtVoucher
            //
            txtVoucher.Font = new Font("微軟正黑體", 9F);
            txtVoucher.ForeColor = Color.Blue;
            txtVoucher.Location = new Point(596, 12);
            txtVoucher.Name = "txtVoucher";
            txtVoucher.ReadOnly = true;
            txtVoucher.Size = new Size(150, 25);
            txtVoucher.TabIndex = 7;
            txtVoucher.DoubleClick += txtVoucher_DoubleClick;
            //
            // lblCreator
            //
            lblCreator.AutoSize = true;
            lblCreator.Font = new Font("微軟正黑體", 9F);
            lblCreator.Location = new Point(16, 55);
            lblCreator.Name = "lblCreator";
            lblCreator.Size = new Size(56, 17);
            lblCreator.TabIndex = 8;
            lblCreator.Text = "建檔:";
            //
            // txtCreator
            //
            txtCreator.Font = new Font("微軟正黑體", 9F);
            txtCreator.Location = new Point(76, 52);
            txtCreator.Name = "txtCreator";
            txtCreator.ReadOnly = true;
            txtCreator.Size = new Size(110, 25);
            txtCreator.TabIndex = 9;
            //
            // lblCreateDate
            //
            lblCreateDate.AutoSize = true;
            lblCreateDate.Font = new Font("微軟正黑體", 9F);
            lblCreateDate.Location = new Point(206, 55);
            lblCreateDate.Name = "lblCreateDate";
            lblCreateDate.Size = new Size(56, 17);
            lblCreateDate.TabIndex = 10;
            lblCreateDate.Text = "建檔日:";
            //
            // txtCreateDate
            //
            txtCreateDate.Font = new Font("微軟正黑體", 9F);
            txtCreateDate.Location = new Point(266, 52);
            txtCreateDate.Name = "txtCreateDate";
            txtCreateDate.ReadOnly = true;
            txtCreateDate.Size = new Size(120, 25);
            txtCreateDate.TabIndex = 11;
            //
            // lblModifier
            //
            lblModifier.AutoSize = true;
            lblModifier.Font = new Font("微軟正黑體", 9F);
            lblModifier.Location = new Point(406, 55);
            lblModifier.Name = "lblModifier";
            lblModifier.Size = new Size(56, 17);
            lblModifier.TabIndex = 12;
            lblModifier.Text = "修改:";
            //
            // txtModifier
            //
            txtModifier.Font = new Font("微軟正黑體", 9F);
            txtModifier.Location = new Point(466, 52);
            txtModifier.Name = "txtModifier";
            txtModifier.ReadOnly = true;
            txtModifier.Size = new Size(110, 25);
            txtModifier.TabIndex = 13;
            //
            // lblModifyDate
            //
            lblModifyDate.AutoSize = true;
            lblModifyDate.Font = new Font("微軟正黑體", 9F);
            lblModifyDate.Location = new Point(586, 55);
            lblModifyDate.Name = "lblModifyDate";
            lblModifyDate.Size = new Size(56, 17);
            lblModifyDate.TabIndex = 14;
            lblModifyDate.Text = "修改日:";
            //
            // txtModifyDate
            //
            txtModifyDate.Font = new Font("微軟正黑體", 9F);
            txtModifyDate.Location = new Point(646, 52);
            txtModifyDate.Name = "txtModifyDate";
            txtModifyDate.ReadOnly = true;
            txtModifyDate.Size = new Size(120, 25);
            txtModifyDate.TabIndex = 15;
            //
            // lblApprover
            //
            lblApprover.AutoSize = true;
            lblApprover.Font = new Font("微軟正黑體", 9F);
            lblApprover.Location = new Point(786, 55);
            lblApprover.Name = "lblApprover";
            lblApprover.Size = new Size(56, 17);
            lblApprover.TabIndex = 16;
            lblApprover.Text = "結帳:";
            //
            // txtApprover
            //
            txtApprover.Font = new Font("微軟正黑體", 9F);
            txtApprover.Location = new Point(846, 52);
            txtApprover.Name = "txtApprover";
            txtApprover.ReadOnly = true;
            txtApprover.Size = new Size(110, 25);
            txtApprover.TabIndex = 17;
            //
            // lblApproveDate
            //
            lblApproveDate.AutoSize = true;
            lblApproveDate.Font = new Font("微軟正黑體", 9F);
            lblApproveDate.Location = new Point(966, 55);
            lblApproveDate.Name = "lblApproveDate";
            lblApproveDate.Size = new Size(56, 17);
            lblApproveDate.TabIndex = 18;
            lblApproveDate.Text = "結帳日:";
            //
            // txtApproveDate
            //
            txtApproveDate.Font = new Font("微軟正黑體", 9F);
            txtApproveDate.Location = new Point(1026, 52);
            txtApproveDate.Name = "txtApproveDate";
            txtApproveDate.ReadOnly = true;
            txtApproveDate.Size = new Size(150, 25);
            txtApproveDate.TabIndex = 19;
            //
            // panelBody
            //
            panelBody.Controls.Add(dataGridView1);
            panelBody.Controls.Add(panelGridTool);
            panelBody.Dock = DockStyle.Fill;
            panelBody.Location = new Point(0, 152);
            panelBody.Name = "panelBody";
            panelBody.Size = new Size(1400, 548);
            panelBody.TabIndex = 2;
            //
            // dataGridView1
            //
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colId, colEmpNo, colName, colAmount, colLeaveDeduct, colLateDeduct, colAttendHours, colLaborCost });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Font = new Font("微軟正黑體", 9F);
            dataGridView1.Location = new Point(0, 40);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 26;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1400, 468);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellEndEdit += dataGridView1_CellEndEdit;
            dataGridView1.CurrentCellDirtyStateChanged += dataGridView1_CurrentCellDirtyStateChanged;
            dataGridView1.EditingControlShowing += dataGridView1_EditingControlShowing;
            //
            // colId
            //
            colId.HeaderText = "識別";
            colId.Name = "colId";
            colId.ReadOnly = true;
            colId.Visible = false;
            //
            // colEmpNo
            //
            colEmpNo.HeaderText = "工號";
            colEmpNo.Name = "colEmpNo";
            colEmpNo.Width = 90;
            //
            // colName
            //
            colName.HeaderText = "姓名";
            colName.Name = "colName";
            colName.ReadOnly = true;
            colName.Width = 90;
            //
            // colAmount
            //
            colAmount.HeaderText = "應領金額";
            colAmount.Name = "colAmount";
            colAmount.Width = 100;
            //
            // colLeaveDeduct
            //
            colLeaveDeduct.HeaderText = "請假扣款";
            colLeaveDeduct.Name = "colLeaveDeduct";
            colLeaveDeduct.Width = 90;
            //
            // colLateDeduct
            //
            colLateDeduct.HeaderText = "遲到扣款";
            colLateDeduct.Name = "colLateDeduct";
            colLateDeduct.Width = 90;
            //
            // colAttendHours
            //
            colAttendHours.HeaderText = "出勤時數";
            colAttendHours.Name = "colAttendHours";
            colAttendHours.Width = 90;
            //
            // colLaborCost
            //
            colLaborCost.HeaderText = "工時成本";
            colLaborCost.Name = "colLaborCost";
            colLaborCost.ReadOnly = true;
            colLaborCost.Width = 90;
            //
            // panelGridTool
            //
            panelGridTool.Controls.Add(btnAddDetailRow);
            panelGridTool.Controls.Add(btnDeleteDetailRow);
            panelGridTool.Dock = DockStyle.Top;
            panelGridTool.Location = new Point(0, 0);
            panelGridTool.Name = "panelGridTool";
            panelGridTool.Size = new Size(1400, 40);
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
            // panelFooter
            //
            panelFooter.BackColor = Color.WhiteSmoke;
            panelFooter.Controls.Add(lblSumAmount);
            panelFooter.Controls.Add(lblSumLeaveDeduct);
            panelFooter.Controls.Add(lblSumLateDeduct);
            panelFooter.Dock = DockStyle.Bottom;
            panelFooter.Location = new Point(0, 508);
            panelFooter.Name = "panelFooter";
            panelFooter.Size = new Size(1400, 40);
            panelFooter.TabIndex = 2;
            //
            // lblSumAmount
            //
            lblSumAmount.AutoSize = true;
            lblSumAmount.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            lblSumAmount.Location = new Point(16, 10);
            lblSumAmount.Name = "lblSumAmount";
            lblSumAmount.Size = new Size(120, 19);
            lblSumAmount.TabIndex = 0;
            lblSumAmount.Text = "應領金額合計：0";
            //
            // lblSumLeaveDeduct
            //
            lblSumLeaveDeduct.AutoSize = true;
            lblSumLeaveDeduct.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            lblSumLeaveDeduct.Location = new Point(220, 10);
            lblSumLeaveDeduct.Name = "lblSumLeaveDeduct";
            lblSumLeaveDeduct.Size = new Size(120, 19);
            lblSumLeaveDeduct.TabIndex = 1;
            lblSumLeaveDeduct.Text = "請假扣款合計：0";
            //
            // lblSumLateDeduct
            //
            lblSumLateDeduct.AutoSize = true;
            lblSumLateDeduct.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            lblSumLateDeduct.Location = new Point(420, 10);
            lblSumLateDeduct.Name = "lblSumLateDeduct";
            lblSumLateDeduct.Size = new Size(120, 19);
            lblSumLateDeduct.TabIndex = 2;
            lblSumLateDeduct.Text = "遲到扣款合計：0";
            //
            // EmployeeSalaryCloseControl
            //
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelFooter);
            Controls.Add(panelBody);
            Controls.Add(panelFormHeader);
            Controls.Add(panelHeader);
            Font = new Font("微軟正黑體", 10F);
            Margin = new Padding(4);
            Name = "EmployeeSalaryCloseControl";
            Size = new Size(1400, 700);
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelFormHeader.ResumeLayout(false);
            panelFormHeader.PerformLayout();
            panelBody.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panelGridTool.ResumeLayout(false);
            panelFooter.ResumeLayout(false);
            panelFooter.PerformLayout();
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
        private Button btnModify;
        private Button btnSave;
        private Button btnCloseMonth;
        private Button btnReopenMonth;
        private Button btnCostImport;
        private Button btnQuery;
        private Button btnExit;
        private Panel panelFormHeader;
        private Label lblYearMonth;
        private DateTimePicker dtYearMonth;
        private Label lblMonthEndDate;
        private DateTimePicker dtMonthEndDate;
        private Label lblClosed;
        private CheckBox chkClosed;
        private Label lblVoucher;
        private TextBox txtVoucher;
        private Label lblCreator;
        private TextBox txtCreator;
        private Label lblCreateDate;
        private TextBox txtCreateDate;
        private Label lblModifier;
        private TextBox txtModifier;
        private Label lblModifyDate;
        private TextBox txtModifyDate;
        private Label lblApprover;
        private TextBox txtApprover;
        private Label lblApproveDate;
        private TextBox txtApproveDate;
        private Panel panelBody;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewComboBoxColumn colEmpNo;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn colAmount;
        private DataGridViewTextBoxColumn colLeaveDeduct;
        private DataGridViewTextBoxColumn colLateDeduct;
        private DataGridViewTextBoxColumn colAttendHours;
        private DataGridViewTextBoxColumn colLaborCost;
        private Panel panelGridTool;
        private Button btnAddDetailRow;
        private Button btnDeleteDetailRow;
        private Panel panelFooter;
        private Label lblSumAmount;
        private Label lblSumLeaveDeduct;
        private Label lblSumLateDeduct;
    }
}
