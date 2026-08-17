using DigiERP.Common;
using System.Drawing;
using System.Windows.Forms;

namespace DigiERP.UserControl.HR.ClockInOut
{
    partial class ClockInOutControl
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
            panelHeader = new Panel();
            lblTitle = new Label();
            btnLast = new Button();
            btnNext = new Button();
            btnModify = new Button();
            btnSave = new Button();
            btnImportClock = new Button();
            btnAttendanceCheck = new Button();
            btnPrint = new Button();
            btnOverview = new Button();
            btnExit = new Button();
            panelInfo = new Panel();
            lblDateT = new Label();
            dtpDate = new DateTimePicker();
            chkHoliday = new CheckBox();
            lblWeekdayT = new Label();
            lblWeekday = new Label();
            chkImported = new CheckBox();
            lblImportTimeT = new Label();
            txtImportTime = new TextBox();
            btnAddRow = new Button();
            panelBody = new Panel();
            dataGridView1 = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colEmpNo = new DataGridViewComboBoxColumn();
            colName = new DataGridViewTextBoxColumn();
            colCardNo = new DataGridViewTextBoxColumn();
            colShift = new DataGridViewTextBoxColumn();
            colRegularStart = new DataGridViewTimePickerColumn();
            colRegularEnd = new DataGridViewTimePickerColumn();
            colOvertimeStart = new DataGridViewTimePickerColumn();
            colOvertimeEnd = new DataGridViewTimePickerColumn();
            colWorkHours = new DataGridViewComboBoxColumn();
            colLeaveHours = new DataGridViewComboBoxColumn();
            colLateMinutes = new DataGridViewNumericUpDownColumn();
            colForgotCard = new DataGridViewComboBoxColumn();
            colLeaveType = new DataGridViewTextBoxColumn();
            colDelete = new DataGridViewButtonColumn();
            panelHeader.SuspendLayout();
            panelInfo.SuspendLayout();
            panelBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            //
            // panelHeader
            //
            panelHeader.BackColor = Color.Moccasin;
            panelHeader.Controls.Add(lblTitle);
            panelHeader.Controls.Add(btnLast);
            panelHeader.Controls.Add(btnNext);
            panelHeader.Controls.Add(btnModify);
            panelHeader.Controls.Add(btnSave);
            panelHeader.Controls.Add(btnImportClock);
            panelHeader.Controls.Add(btnAttendanceCheck);
            panelHeader.Controls.Add(btnPrint);
            panelHeader.Controls.Add(btnOverview);
            panelHeader.Controls.Add(btnExit);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1500, 56);
            panelHeader.TabIndex = 0;
            //
            // lblTitle
            //
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("微軟正黑體", 14F, FontStyle.Bold);
            lblTitle.ForeColor = Color.Firebrick;
            lblTitle.Location = new Point(10, 16);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(150, 24);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "每日出勤紀錄表";
            //
            // btnLast
            //
            btnLast.BackColor = Color.Gainsboro;
            btnLast.FlatStyle = FlatStyle.Flat;
            btnLast.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            btnLast.Location = new Point(280, 12);
            btnLast.Name = "btnLast";
            btnLast.Size = new Size(40, 32);
            btnLast.TabIndex = 1;
            btnLast.Text = "◄";
            btnLast.UseVisualStyleBackColor = false;
            btnLast.Click += btnLast_Click;
            //
            // btnNext
            //
            btnNext.BackColor = Color.Gainsboro;
            btnNext.FlatStyle = FlatStyle.Flat;
            btnNext.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            btnNext.Location = new Point(325, 12);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(40, 32);
            btnNext.TabIndex = 2;
            btnNext.Text = "►";
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click;
            //
            // btnModify
            //
            btnModify.BackColor = Color.SteelBlue;
            btnModify.FlatStyle = FlatStyle.Flat;
            btnModify.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            btnModify.ForeColor = Color.White;
            btnModify.Location = new Point(390, 12);
            btnModify.Name = "btnModify";
            btnModify.Size = new Size(90, 32);
            btnModify.TabIndex = 3;
            btnModify.Text = "修改";
            btnModify.UseVisualStyleBackColor = false;
            btnModify.Click += btnModify_Click;
            //
            // btnSave
            //
            btnSave.BackColor = Color.SeaGreen;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(485, 12);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(90, 32);
            btnSave.TabIndex = 4;
            btnSave.Text = "儲存";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            //
            // btnImportClock
            //
            btnImportClock.BackColor = Color.Gainsboro;
            btnImportClock.FlatStyle = FlatStyle.Flat;
            btnImportClock.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            btnImportClock.Location = new Point(590, 12);
            btnImportClock.Name = "btnImportClock";
            btnImportClock.Size = new Size(120, 32);
            btnImportClock.TabIndex = 5;
            btnImportClock.Text = "導入卡鐘資料";
            btnImportClock.UseVisualStyleBackColor = false;
            btnImportClock.Click += btnImportClock_Click;
            //
            // btnAttendanceCheck
            //
            btnAttendanceCheck.BackColor = Color.Gainsboro;
            btnAttendanceCheck.FlatStyle = FlatStyle.Flat;
            btnAttendanceCheck.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            btnAttendanceCheck.Location = new Point(720, 12);
            btnAttendanceCheck.Name = "btnAttendanceCheck";
            btnAttendanceCheck.Size = new Size(120, 32);
            btnAttendanceCheck.TabIndex = 6;
            btnAttendanceCheck.Text = "員工考勤核對";
            btnAttendanceCheck.UseVisualStyleBackColor = false;
            btnAttendanceCheck.Click += btnAttendanceCheck_Click;
            //
            // btnPrint
            //
            btnPrint.BackColor = Color.Gainsboro;
            btnPrint.FlatStyle = FlatStyle.Flat;
            btnPrint.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            btnPrint.Location = new Point(1200, 12);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(90, 32);
            btnPrint.TabIndex = 7;
            btnPrint.Text = "列印";
            btnPrint.UseVisualStyleBackColor = false;
            btnPrint.Click += btnPrint_Click;
            //
            // btnOverview
            //
            btnOverview.BackColor = Color.Gainsboro;
            btnOverview.FlatStyle = FlatStyle.Flat;
            btnOverview.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            btnOverview.Location = new Point(1295, 12);
            btnOverview.Name = "btnOverview";
            btnOverview.Size = new Size(90, 32);
            btnOverview.TabIndex = 8;
            btnOverview.Text = "總覽";
            btnOverview.UseVisualStyleBackColor = false;
            btnOverview.Click += btnOverview_Click;
            //
            // btnExit
            //
            btnExit.BackColor = Color.Gainsboro;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            btnExit.Location = new Point(1390, 12);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(90, 32);
            btnExit.TabIndex = 9;
            btnExit.Text = "關閉";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            //
            // panelInfo
            //
            panelInfo.BackColor = Color.LightYellow;
            panelInfo.Controls.Add(lblDateT);
            panelInfo.Controls.Add(dtpDate);
            panelInfo.Controls.Add(chkHoliday);
            panelInfo.Controls.Add(lblWeekdayT);
            panelInfo.Controls.Add(lblWeekday);
            panelInfo.Controls.Add(chkImported);
            panelInfo.Controls.Add(lblImportTimeT);
            panelInfo.Controls.Add(txtImportTime);
            panelInfo.Controls.Add(btnAddRow);
            panelInfo.Dock = DockStyle.Top;
            panelInfo.Location = new Point(0, 56);
            panelInfo.Name = "panelInfo";
            panelInfo.Size = new Size(1500, 56);
            panelInfo.TabIndex = 1;
            //
            // lblDateT
            //
            lblDateT.AutoSize = true;
            lblDateT.Font = new Font("微軟正黑體", 9F);
            lblDateT.Location = new Point(10, 10);
            lblDateT.Name = "lblDateT";
            lblDateT.Size = new Size(32, 17);
            lblDateT.TabIndex = 0;
            lblDateT.Text = "日期";
            //
            // dtpDate
            //
            dtpDate.Font = new Font("微軟正黑體", 9F);
            dtpDate.Format = DateTimePickerFormat.Custom;
            dtpDate.CustomFormat = "yyyy/MM/dd";
            dtpDate.Location = new Point(10, 30);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(130, 23);
            dtpDate.TabIndex = 1;
            dtpDate.ValueChanged += dtpDate_ValueChanged;
            //
            // chkHoliday
            //
            chkHoliday.AutoSize = true;
            chkHoliday.Font = new Font("微軟正黑體", 9F);
            chkHoliday.Location = new Point(160, 30);
            chkHoliday.Name = "chkHoliday";
            chkHoliday.Size = new Size(56, 21);
            chkHoliday.TabIndex = 2;
            chkHoliday.Text = "例假日";
            chkHoliday.UseVisualStyleBackColor = true;
            //
            // lblWeekdayT
            //
            lblWeekdayT.AutoSize = true;
            lblWeekdayT.Font = new Font("微軟正黑體", 9F);
            lblWeekdayT.Location = new Point(260, 10);
            lblWeekdayT.Name = "lblWeekdayT";
            lblWeekdayT.Size = new Size(32, 17);
            lblWeekdayT.TabIndex = 3;
            lblWeekdayT.Text = "週次";
            //
            // lblWeekday
            //
            lblWeekday.AutoSize = true;
            lblWeekday.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            lblWeekday.Location = new Point(260, 30);
            lblWeekday.Name = "lblWeekday";
            lblWeekday.Size = new Size(20, 19);
            lblWeekday.TabIndex = 4;
            lblWeekday.Text = "一";
            //
            // chkImported
            //
            chkImported.AutoSize = true;
            chkImported.Enabled = false;
            chkImported.Font = new Font("微軟正黑體", 9F);
            chkImported.Location = new Point(330, 30);
            chkImported.Name = "chkImported";
            chkImported.Size = new Size(104, 21);
            chkImported.TabIndex = 5;
            chkImported.Text = "已導入卡鐘資料";
            chkImported.UseVisualStyleBackColor = true;
            //
            // lblImportTimeT
            //
            lblImportTimeT.AutoSize = true;
            lblImportTimeT.Font = new Font("微軟正黑體", 9F);
            lblImportTimeT.Location = new Point(460, 10);
            lblImportTimeT.Name = "lblImportTimeT";
            lblImportTimeT.Size = new Size(56, 17);
            lblImportTimeT.TabIndex = 6;
            lblImportTimeT.Text = "導入時間";
            //
            // txtImportTime
            //
            txtImportTime.BackColor = Color.WhiteSmoke;
            txtImportTime.Font = new Font("微軟正黑體", 9F);
            txtImportTime.Location = new Point(460, 30);
            txtImportTime.Name = "txtImportTime";
            txtImportTime.ReadOnly = true;
            txtImportTime.Size = new Size(150, 23);
            txtImportTime.TabIndex = 7;
            //
            // btnAddRow
            //
            btnAddRow.BackColor = Color.LightSteelBlue;
            btnAddRow.FlatStyle = FlatStyle.Flat;
            btnAddRow.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            btnAddRow.Location = new Point(630, 26);
            btnAddRow.Name = "btnAddRow";
            btnAddRow.Size = new Size(90, 28);
            btnAddRow.TabIndex = 8;
            btnAddRow.Text = "新增一筆";
            btnAddRow.UseVisualStyleBackColor = false;
            btnAddRow.Click += btnAddRow_Click;
            //
            // panelBody
            //
            panelBody.Controls.Add(dataGridView1);
            panelBody.Dock = DockStyle.Fill;
            panelBody.Location = new Point(0, 112);
            panelBody.Name = "panelBody";
            panelBody.Size = new Size(1500, 500);
            panelBody.TabIndex = 2;
            //
            // dataGridView1
            //
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] {
                colId, colEmpNo, colName, colCardNo, colShift, colRegularStart, colRegularEnd,
                colOvertimeStart, colOvertimeEnd, colWorkHours, colLeaveHours, colLateMinutes,
                colForgotCard, colLeaveType, colDelete });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Font = new Font("微軟正黑體", 9F);
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 26;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1500, 500);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.CellEndEdit += dataGridView1_CellEndEdit;
            //
            // colId
            //
            colId.HeaderText = "識別碼";
            colId.Name = "colId";
            colId.ReadOnly = true;
            colId.Visible = false;
            colId.Width = 60;
            //
            // colEmpNo
            //
            colEmpNo.HeaderText = "員工編號";
            colEmpNo.Name = "colEmpNo";
            colEmpNo.ReadOnly = true;
            colEmpNo.Width = 90;
            //
            // colName
            //
            colName.HeaderText = "姓名";
            colName.Name = "colName";
            colName.ReadOnly = true;
            colName.Width = 80;
            //
            // colCardNo
            //
            colCardNo.HeaderText = "卡號";
            colCardNo.Name = "colCardNo";
            colCardNo.ReadOnly = true;
            colCardNo.Width = 90;
            //
            // colShift
            //
            colShift.HeaderText = "班次";
            colShift.Name = "colShift";
            colShift.ReadOnly = true;
            colShift.Width = 70;
            //
            // colRegularStart
            //
            colRegularStart.HeaderText = "正規上班";
            colRegularStart.Name = "colRegularStart";
            colRegularStart.ReadOnly = true;
            colRegularStart.Width = 80;
            //
            // colRegularEnd
            //
            colRegularEnd.HeaderText = "正規下班";
            colRegularEnd.Name = "colRegularEnd";
            colRegularEnd.ReadOnly = true;
            colRegularEnd.Width = 80;
            //
            // colOvertimeStart
            //
            colOvertimeStart.HeaderText = "加班上班";
            colOvertimeStart.Name = "colOvertimeStart";
            colOvertimeStart.ReadOnly = true;
            colOvertimeStart.Width = 80;
            //
            // colOvertimeEnd
            //
            colOvertimeEnd.HeaderText = "加班下班";
            colOvertimeEnd.Name = "colOvertimeEnd";
            colOvertimeEnd.ReadOnly = true;
            colOvertimeEnd.Width = 80;
            //
            // colWorkHours
            //
            colWorkHours.HeaderText = "出勤時數";
            colWorkHours.Name = "colWorkHours";
            colWorkHours.ReadOnly = true;
            colWorkHours.Width = 80;
            colWorkHours.Items.AddRange(new object[] { "0", "0.5", "1", "1.5", "2", "2.5", "3", "3.5", "4", "4.5", "5", "5.5", "6", "6.5", "7", "7.5", "8" });
            //
            // colLeaveHours
            //
            colLeaveHours.HeaderText = "請休時數";
            colLeaveHours.Name = "colLeaveHours";
            colLeaveHours.ReadOnly = true;
            colLeaveHours.Width = 80;
            colLeaveHours.Items.AddRange(new object[] { "0", "0.5", "1", "1.5", "2", "2.5", "3", "3.5", "4", "4.5", "5", "5.5", "6", "6.5", "7", "7.5", "8" });
            //
            // colLateMinutes
            //
            colLateMinutes.HeaderText = "遲到分鐘數";
            colLateMinutes.Name = "colLateMinutes";
            colLateMinutes.ReadOnly = true;
            colLateMinutes.Width = 90;
            colLateMinutes.DecimalPlaces = 0;
            colLateMinutes.Minimum = 0;
            colLateMinutes.Maximum = 999;
            //
            // colForgotCard
            //
            colForgotCard.HeaderText = "忘卡";
            colForgotCard.Name = "colForgotCard";
            colForgotCard.ReadOnly = true;
            colForgotCard.Width = 60;
            colForgotCard.Items.AddRange(new object[] { "1", "2" });
            //
            // colLeaveType
            //
            colLeaveType.HeaderText = "假別";
            colLeaveType.Name = "colLeaveType";
            colLeaveType.ReadOnly = true;
            colLeaveType.Width = 80;
            //
            // colDelete
            //
            colDelete.HeaderText = "";
            colDelete.Name = "colDelete";
            colDelete.Text = "刪除";
            colDelete.UseColumnTextForButtonValue = true;
            colDelete.Width = 60;
            //
            // ClockInOutControl
            //
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelBody);
            Controls.Add(panelInfo);
            Controls.Add(panelHeader);
            Font = new Font("微軟正黑體", 10F);
            Margin = new Padding(4);
            Name = "ClockInOutControl";
            Size = new Size(1500, 668);
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelInfo.ResumeLayout(false);
            panelInfo.PerformLayout();
            panelBody.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private Label lblTitle;
        private Button btnLast;
        private Button btnNext;
        private Button btnModify;
        private Button btnSave;
        private Button btnImportClock;
        private Button btnAttendanceCheck;
        private Button btnPrint;
        private Button btnOverview;
        private Button btnExit;
        private Panel panelInfo;
        private Label lblDateT;
        private DateTimePicker dtpDate;
        private CheckBox chkHoliday;
        private Label lblWeekdayT;
        private Label lblWeekday;
        private CheckBox chkImported;
        private Label lblImportTimeT;
        private TextBox txtImportTime;
        private Button btnAddRow;
        private Panel panelBody;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewComboBoxColumn colEmpNo;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn colCardNo;
        private DataGridViewTextBoxColumn colShift;
        private DataGridViewTimePickerColumn colRegularStart;
        private DataGridViewTimePickerColumn colRegularEnd;
        private DataGridViewTimePickerColumn colOvertimeStart;
        private DataGridViewTimePickerColumn colOvertimeEnd;
        private DataGridViewComboBoxColumn colWorkHours;
        private DataGridViewComboBoxColumn colLeaveHours;
        private DataGridViewNumericUpDownColumn colLateMinutes;
        private DataGridViewComboBoxColumn colForgotCard;
        private DataGridViewTextBoxColumn colLeaveType;
        private DataGridViewButtonColumn colDelete;
    }
}
