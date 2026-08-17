using System.Drawing;
using System.Windows.Forms;

namespace DigiERP.UserControl.HR.ClockInOut
{
    partial class AttendanceCheckControl
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
            btnFirst = new Button();
            btnPrev = new Button();
            btnNext = new Button();
            btnLast = new Button();
            btnPrint = new Button();
            btnExit = new Button();
            panelInfo = new Panel();
            lblEmpNoT = new Label();
            txtEmpNo = new TextBox();
            lblNameT = new Label();
            txtName = new TextBox();
            lblJobTitleT = new Label();
            txtJobTitle = new TextBox();
            lblDeptT = new Label();
            txtDept = new TextBox();
            lblStartDateT = new Label();
            dtpStartDate = new DateTimePicker();
            lblEndDateT = new Label();
            dtpEndDate = new DateTimePicker();
            btnRequery = new Button();
            panelBody = new Panel();
            dataGridView1 = new DataGridView();
            colDate = new DataGridViewTextBoxColumn();
            colWeekday = new DataGridViewTextBoxColumn();
            colHoliday = new DataGridViewCheckBoxColumn();
            colShift = new DataGridViewTextBoxColumn();
            colRegStart = new DataGridViewTextBoxColumn();
            colRegEnd = new DataGridViewTextBoxColumn();
            colOtStart = new DataGridViewTextBoxColumn();
            colOtEnd = new DataGridViewTextBoxColumn();
            colWorkHours = new DataGridViewTextBoxColumn();
            colLeaveHours = new DataGridViewTextBoxColumn();
            colLate = new DataGridViewTextBoxColumn();
            colEarlyLeave = new DataGridViewTextBoxColumn();
            colOtHours = new DataGridViewTextBoxColumn();
            colForgotCard = new DataGridViewTextBoxColumn();
            colLeaveType = new DataGridViewTextBoxColumn();
            colNote = new DataGridViewTextBoxColumn();
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
            panelHeader.Controls.Add(btnFirst);
            panelHeader.Controls.Add(btnPrev);
            panelHeader.Controls.Add(btnNext);
            panelHeader.Controls.Add(btnLast);
            panelHeader.Controls.Add(btnPrint);
            panelHeader.Controls.Add(btnExit);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1300, 56);
            panelHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("微軟正黑體", 14F, FontStyle.Bold);
            lblTitle.ForeColor = Color.Firebrick;
            lblTitle.Location = new Point(10, 16);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(124, 24);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "員工考勤核對";
            // 
            // btnFirst
            // 
            btnFirst.BackColor = Color.Gainsboro;
            btnFirst.FlatStyle = FlatStyle.Flat;
            btnFirst.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            btnFirst.Location = new Point(280, 12);
            btnFirst.Name = "btnFirst";
            btnFirst.Size = new Size(40, 32);
            btnFirst.TabIndex = 1;
            btnFirst.Text = "|◄";
            btnFirst.UseVisualStyleBackColor = false;
            btnFirst.Click += btnFirst_Click;
            // 
            // btnPrev
            // 
            btnPrev.BackColor = Color.Gainsboro;
            btnPrev.FlatStyle = FlatStyle.Flat;
            btnPrev.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            btnPrev.Location = new Point(325, 12);
            btnPrev.Name = "btnPrev";
            btnPrev.Size = new Size(40, 32);
            btnPrev.TabIndex = 2;
            btnPrev.Text = "◄";
            btnPrev.UseVisualStyleBackColor = false;
            btnPrev.Click += btnPrev_Click;
            // 
            // btnNext
            // 
            btnNext.BackColor = Color.Gainsboro;
            btnNext.FlatStyle = FlatStyle.Flat;
            btnNext.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            btnNext.Location = new Point(370, 12);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(40, 32);
            btnNext.TabIndex = 3;
            btnNext.Text = "►";
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click;
            // 
            // btnLast
            // 
            btnLast.BackColor = Color.Gainsboro;
            btnLast.FlatStyle = FlatStyle.Flat;
            btnLast.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            btnLast.Location = new Point(415, 12);
            btnLast.Name = "btnLast";
            btnLast.Size = new Size(40, 32);
            btnLast.TabIndex = 4;
            btnLast.Text = "►|";
            btnLast.UseVisualStyleBackColor = false;
            btnLast.Click += btnLast_Click;
            // 
            // btnPrint
            // 
            btnPrint.BackColor = Color.Gainsboro;
            btnPrint.FlatStyle = FlatStyle.Flat;
            btnPrint.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            btnPrint.Location = new Point(996, 12);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(184, 32);
            btnPrint.TabIndex = 5;
            btnPrint.Text = "列印:員工別出勤明細表";
            btnPrint.UseVisualStyleBackColor = false;
            btnPrint.Click += btnPrint_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Gainsboro;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            btnExit.Location = new Point(1190, 12);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(100, 32);
            btnExit.TabIndex = 6;
            btnExit.Text = "關閉";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // panelInfo
            // 
            panelInfo.BackColor = Color.LightYellow;
            panelInfo.Controls.Add(lblEmpNoT);
            panelInfo.Controls.Add(txtEmpNo);
            panelInfo.Controls.Add(lblNameT);
            panelInfo.Controls.Add(txtName);
            panelInfo.Controls.Add(lblJobTitleT);
            panelInfo.Controls.Add(txtJobTitle);
            panelInfo.Controls.Add(lblDeptT);
            panelInfo.Controls.Add(txtDept);
            panelInfo.Controls.Add(lblStartDateT);
            panelInfo.Controls.Add(dtpStartDate);
            panelInfo.Controls.Add(lblEndDateT);
            panelInfo.Controls.Add(dtpEndDate);
            panelInfo.Controls.Add(btnRequery);
            panelInfo.Dock = DockStyle.Top;
            panelInfo.Location = new Point(0, 56);
            panelInfo.Name = "panelInfo";
            panelInfo.Size = new Size(1300, 56);
            panelInfo.TabIndex = 1;
            // 
            // lblEmpNoT
            // 
            lblEmpNoT.AutoSize = true;
            lblEmpNoT.Font = new Font("微軟正黑體", 9F);
            lblEmpNoT.Location = new Point(10, 10);
            lblEmpNoT.Name = "lblEmpNoT";
            lblEmpNoT.Size = new Size(55, 16);
            lblEmpNoT.TabIndex = 0;
            lblEmpNoT.Text = "員工編號";
            // 
            // txtEmpNo
            // 
            txtEmpNo.BackColor = Color.WhiteSmoke;
            txtEmpNo.Font = new Font("微軟正黑體", 9F);
            txtEmpNo.Location = new Point(10, 30);
            txtEmpNo.Name = "txtEmpNo";
            txtEmpNo.ReadOnly = true;
            txtEmpNo.Size = new Size(90, 23);
            txtEmpNo.TabIndex = 1;
            // 
            // lblNameT
            // 
            lblNameT.AutoSize = true;
            lblNameT.Font = new Font("微軟正黑體", 9F);
            lblNameT.Location = new Point(110, 10);
            lblNameT.Name = "lblNameT";
            lblNameT.Size = new Size(31, 16);
            lblNameT.TabIndex = 2;
            lblNameT.Text = "姓名";
            // 
            // txtName
            // 
            txtName.BackColor = Color.WhiteSmoke;
            txtName.Font = new Font("微軟正黑體", 9F);
            txtName.Location = new Point(110, 30);
            txtName.Name = "txtName";
            txtName.ReadOnly = true;
            txtName.Size = new Size(90, 23);
            txtName.TabIndex = 3;
            // 
            // lblJobTitleT
            // 
            lblJobTitleT.AutoSize = true;
            lblJobTitleT.Font = new Font("微軟正黑體", 9F);
            lblJobTitleT.Location = new Point(210, 10);
            lblJobTitleT.Name = "lblJobTitleT";
            lblJobTitleT.Size = new Size(31, 16);
            lblJobTitleT.TabIndex = 4;
            lblJobTitleT.Text = "職稱";
            // 
            // txtJobTitle
            // 
            txtJobTitle.BackColor = Color.WhiteSmoke;
            txtJobTitle.Font = new Font("微軟正黑體", 9F);
            txtJobTitle.Location = new Point(210, 30);
            txtJobTitle.Name = "txtJobTitle";
            txtJobTitle.ReadOnly = true;
            txtJobTitle.Size = new Size(90, 23);
            txtJobTitle.TabIndex = 5;
            // 
            // lblDeptT
            // 
            lblDeptT.AutoSize = true;
            lblDeptT.Font = new Font("微軟正黑體", 9F);
            lblDeptT.Location = new Point(310, 10);
            lblDeptT.Name = "lblDeptT";
            lblDeptT.Size = new Size(43, 16);
            lblDeptT.TabIndex = 6;
            lblDeptT.Text = "單位別";
            // 
            // txtDept
            // 
            txtDept.BackColor = Color.WhiteSmoke;
            txtDept.Font = new Font("微軟正黑體", 9F);
            txtDept.Location = new Point(310, 30);
            txtDept.Name = "txtDept";
            txtDept.ReadOnly = true;
            txtDept.Size = new Size(110, 23);
            txtDept.TabIndex = 7;
            // 
            // lblStartDateT
            // 
            lblStartDateT.AutoSize = true;
            lblStartDateT.Font = new Font("微軟正黑體", 9F);
            lblStartDateT.Location = new Point(440, 10);
            lblStartDateT.Name = "lblStartDateT";
            lblStartDateT.Size = new Size(55, 16);
            lblStartDateT.TabIndex = 8;
            lblStartDateT.Text = "查詢起日";
            // 
            // dtpStartDate
            // 
            dtpStartDate.CustomFormat = "yyyy/MM/dd";
            dtpStartDate.Font = new Font("微軟正黑體", 9F);
            dtpStartDate.Format = DateTimePickerFormat.Custom;
            dtpStartDate.Location = new Point(440, 30);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(120, 23);
            dtpStartDate.TabIndex = 9;
            // 
            // lblEndDateT
            // 
            lblEndDateT.AutoSize = true;
            lblEndDateT.Font = new Font("微軟正黑體", 9F);
            lblEndDateT.Location = new Point(570, 10);
            lblEndDateT.Name = "lblEndDateT";
            lblEndDateT.Size = new Size(55, 16);
            lblEndDateT.TabIndex = 10;
            lblEndDateT.Text = "查詢迄日";
            // 
            // dtpEndDate
            // 
            dtpEndDate.CustomFormat = "yyyy/MM/dd";
            dtpEndDate.Font = new Font("微軟正黑體", 9F);
            dtpEndDate.Format = DateTimePickerFormat.Custom;
            dtpEndDate.Location = new Point(570, 30);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Size = new Size(120, 23);
            dtpEndDate.TabIndex = 11;
            // 
            // btnRequery
            // 
            btnRequery.BackColor = Color.SteelBlue;
            btnRequery.FlatStyle = FlatStyle.Flat;
            btnRequery.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            btnRequery.ForeColor = Color.White;
            btnRequery.Location = new Point(700, 26);
            btnRequery.Name = "btnRequery";
            btnRequery.Size = new Size(90, 30);
            btnRequery.TabIndex = 12;
            btnRequery.Text = "重新查詢";
            btnRequery.UseVisualStyleBackColor = false;
            btnRequery.Click += btnRequery_Click;
            // 
            // panelBody
            // 
            panelBody.Controls.Add(dataGridView1);
            panelBody.Dock = DockStyle.Fill;
            panelBody.Location = new Point(0, 112);
            panelBody.Name = "panelBody";
            panelBody.Size = new Size(1300, 556);
            panelBody.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colDate, colWeekday, colHoliday, colShift, colRegStart, colRegEnd, colOtStart, colOtEnd, colWorkHours, colLeaveHours, colLate, colEarlyLeave, colOtHours, colForgotCard, colLeaveType, colNote });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Font = new Font("微軟正黑體", 9F);
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 26;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1300, 556);
            dataGridView1.TabIndex = 0;
            // 
            // colDate
            // 
            colDate.HeaderText = "日期";
            colDate.Name = "colDate";
            colDate.ReadOnly = true;
            colDate.Width = 90;
            // 
            // colWeekday
            // 
            colWeekday.HeaderText = "週次";
            colWeekday.Name = "colWeekday";
            colWeekday.ReadOnly = true;
            colWeekday.Width = 50;
            // 
            // colHoliday
            // 
            colHoliday.HeaderText = "例假";
            colHoliday.Name = "colHoliday";
            colHoliday.ReadOnly = true;
            colHoliday.Width = 50;
            // 
            // colShift
            // 
            colShift.HeaderText = "班次";
            colShift.Name = "colShift";
            colShift.ReadOnly = true;
            colShift.Width = 60;
            // 
            // colRegStart
            // 
            colRegStart.HeaderText = "正規上班";
            colRegStart.Name = "colRegStart";
            colRegStart.ReadOnly = true;
            colRegStart.Width = 80;
            // 
            // colRegEnd
            // 
            colRegEnd.HeaderText = "正規下班";
            colRegEnd.Name = "colRegEnd";
            colRegEnd.ReadOnly = true;
            colRegEnd.Width = 80;
            // 
            // colOtStart
            // 
            colOtStart.HeaderText = "加班上班";
            colOtStart.Name = "colOtStart";
            colOtStart.ReadOnly = true;
            colOtStart.Width = 80;
            // 
            // colOtEnd
            // 
            colOtEnd.HeaderText = "加班下班";
            colOtEnd.Name = "colOtEnd";
            colOtEnd.ReadOnly = true;
            colOtEnd.Width = 80;
            // 
            // colWorkHours
            // 
            colWorkHours.HeaderText = "出勤時數";
            colWorkHours.Name = "colWorkHours";
            colWorkHours.ReadOnly = true;
            colWorkHours.Width = 80;
            // 
            // colLeaveHours
            // 
            colLeaveHours.HeaderText = "請休時數";
            colLeaveHours.Name = "colLeaveHours";
            colLeaveHours.ReadOnly = true;
            colLeaveHours.Width = 80;
            // 
            // colLate
            // 
            colLate.HeaderText = "遲到分鐘";
            colLate.Name = "colLate";
            colLate.ReadOnly = true;
            colLate.Width = 80;
            // 
            // colEarlyLeave
            // 
            colEarlyLeave.HeaderText = "早退分鐘";
            colEarlyLeave.Name = "colEarlyLeave";
            colEarlyLeave.ReadOnly = true;
            colEarlyLeave.Width = 80;
            // 
            // colOtHours
            // 
            colOtHours.HeaderText = "加班時數";
            colOtHours.Name = "colOtHours";
            colOtHours.ReadOnly = true;
            colOtHours.Width = 70;
            // 
            // colForgotCard
            // 
            colForgotCard.HeaderText = "忘卡";
            colForgotCard.Name = "colForgotCard";
            colForgotCard.ReadOnly = true;
            colForgotCard.Width = 60;
            // 
            // colLeaveType
            // 
            colLeaveType.HeaderText = "請假別";
            colLeaveType.Name = "colLeaveType";
            colLeaveType.ReadOnly = true;
            colLeaveType.Width = 80;
            // 
            // colNote
            // 
            colNote.HeaderText = "備註";
            colNote.Name = "colNote";
            colNote.ReadOnly = true;
            colNote.Width = 120;
            // 
            // AttendanceCheckControl
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelBody);
            Controls.Add(panelInfo);
            Controls.Add(panelHeader);
            Font = new Font("微軟正黑體", 10F);
            Margin = new Padding(4);
            Name = "AttendanceCheckControl";
            Size = new Size(1300, 668);
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
        private Button btnFirst;
        private Button btnPrev;
        private Button btnNext;
        private Button btnLast;
        private Button btnPrint;
        private Button btnExit;
        private Panel panelInfo;
        private Label lblEmpNoT;
        private TextBox txtEmpNo;
        private Label lblNameT;
        private TextBox txtName;
        private Label lblJobTitleT;
        private TextBox txtJobTitle;
        private Label lblDeptT;
        private TextBox txtDept;
        private Label lblStartDateT;
        private DateTimePicker dtpStartDate;
        private Label lblEndDateT;
        private DateTimePicker dtpEndDate;
        private Button btnRequery;
        private Panel panelBody;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn colDate;
        private DataGridViewTextBoxColumn colWeekday;
        private DataGridViewCheckBoxColumn colHoliday;
        private DataGridViewTextBoxColumn colShift;
        private DataGridViewTextBoxColumn colRegStart;
        private DataGridViewTextBoxColumn colRegEnd;
        private DataGridViewTextBoxColumn colOtStart;
        private DataGridViewTextBoxColumn colOtEnd;
        private DataGridViewTextBoxColumn colWorkHours;
        private DataGridViewTextBoxColumn colLeaveHours;
        private DataGridViewTextBoxColumn colLate;
        private DataGridViewTextBoxColumn colEarlyLeave;
        private DataGridViewTextBoxColumn colForgotCard;
        private DataGridViewTextBoxColumn colOtHours;
        private DataGridViewTextBoxColumn colLeaveType;
        private DataGridViewTextBoxColumn colNote;
    }
}
