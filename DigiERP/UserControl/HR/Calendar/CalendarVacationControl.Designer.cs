using System.Drawing;
using System.Windows.Forms;

namespace DigiERP.UserControl.HR.Calendar
{
    partial class CalendarVacationControl
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region 元件設計工具產生的程式碼
        //
        // 比照 PITS-2025.accdb「H-日曆休假表」(Caption="日曆休假表"，畫面標題
        // "日曆休假及出勤紀錄")還原，含內嵌子表單「H-請假紀錄查詢」(請假紀錄表)
        // 與「H-每日出勤紀錄」(出勤紀錄表)，皆以 日期 連動。配色比照原表單：
        // 表頭金黃 RGB(255,217,102)。「總覽」開啟既有 CalendarControl(H-日曆
        // 總覽)，非新建。「列印」原表單無綁定巨集，「年度假別統計」對應
        // Access「H-年度假別統計表」查無既有畫面，兩者暫以提示訊息取代。全部
        // 控制項座標一律採內嵌常數寫死(不使用自訂輔助方法) ─────────────────────
        //
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panelHeader = new Panel();
            lblTitle = new Label();
            btnEdit = new Button();
            btnSave = new Button();
            btnApprove = new Button();
            btnUnapprove = new Button();
            btnAnnualStats = new Button();
            btnPrint = new Button();
            btnOverview = new Button();
            btnExit = new Button();
            lbl日期 = new Label();
            txt日期 = new TextBox();
            lbl週次 = new Label();
            txt週次 = new TextBox();
            lbl例假日 = new Label();
            chk例假日 = new CheckBox();
            lbl人事經辦 = new Label();
            cmb人事經辦 = new ComboBox();
            lbl核准生效 = new Label();
            chk核准生效 = new CheckBox();
            lbl核准人 = new Label();
            txt核准人 = new TextBox();
            lbl公告事項 = new Label();
            txt公告事項 = new TextBox();
            panelLeave = new Panel();
            dataGridViewLeave = new DataGridView();
            colLeaveEmpNo = new DataGridViewTextBoxColumn();
            colLeaveName = new DataGridViewTextBoxColumn();
            colLeavePersonal = new DataGridViewTextBoxColumn();
            colLeaveSick = new DataGridViewTextBoxColumn();
            colLeaveAnnual = new DataGridViewTextBoxColumn();
            colLeaveMaternity = new DataGridViewTextBoxColumn();
            colLeaveOfficial = new DataGridViewTextBoxColumn();
            colLeavePhysiological = new DataGridViewTextBoxColumn();
            colLeaveFamily = new DataGridViewTextBoxColumn();
            colLeaveAbsent = new DataGridViewTextBoxColumn();
            colLeaveRemark = new DataGridViewTextBoxColumn();
            colLeaveDeductFactor = new DataGridViewTextBoxColumn();
            lbl請假紀錄表 = new Label();
            panelAttend = new Panel();
            dataGridViewAttend = new DataGridView();
            colAttEmpNo = new DataGridViewTextBoxColumn();
            colAttName = new DataGridViewTextBoxColumn();
            colAttCard = new DataGridViewTextBoxColumn();
            colAttShift = new DataGridViewTextBoxColumn();
            colAttNormalIn = new DataGridViewTextBoxColumn();
            colAttNormalOut = new DataGridViewTextBoxColumn();
            colAttOTIn = new DataGridViewTextBoxColumn();
            colAttOTOut = new DataGridViewTextBoxColumn();
            colAttHours = new DataGridViewTextBoxColumn();
            colAttLeaveHours = new DataGridViewTextBoxColumn();
            colAttLate = new DataGridViewTextBoxColumn();
            colAttForgetCard = new DataGridViewTextBoxColumn();
            colAttLeaveType = new DataGridViewTextBoxColumn();
            lbl出勤紀錄表 = new Label();
            panelHeader.SuspendLayout();
            panelLeave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewLeave).BeginInit();
            panelAttend.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAttend).BeginInit();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(255, 217, 102);
            panelHeader.Controls.Add(lblTitle);
            panelHeader.Controls.Add(btnEdit);
            panelHeader.Controls.Add(btnSave);
            panelHeader.Controls.Add(btnApprove);
            panelHeader.Controls.Add(btnUnapprove);
            panelHeader.Controls.Add(btnAnnualStats);
            panelHeader.Controls.Add(btnPrint);
            panelHeader.Controls.Add(btnOverview);
            panelHeader.Controls.Add(btnExit);
            panelHeader.Controls.Add(lbl日期);
            panelHeader.Controls.Add(txt日期);
            panelHeader.Controls.Add(lbl週次);
            panelHeader.Controls.Add(txt週次);
            panelHeader.Controls.Add(lbl例假日);
            panelHeader.Controls.Add(chk例假日);
            panelHeader.Controls.Add(lbl人事經辦);
            panelHeader.Controls.Add(cmb人事經辦);
            panelHeader.Controls.Add(lbl核准生效);
            panelHeader.Controls.Add(chk核准生效);
            panelHeader.Controls.Add(lbl核准人);
            panelHeader.Controls.Add(txt核准人);
            panelHeader.Controls.Add(lbl公告事項);
            panelHeader.Controls.Add(txt公告事項);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1050, 150);
            panelHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("微軟正黑體", 12F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(120, 72, 0);
            lblTitle.Location = new Point(8, 8);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(220, 24);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "日曆休假及出勤紀錄";
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.FromArgb(140, 140, 140);
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            btnEdit.ForeColor = Color.White;
            btnEdit.Location = new Point(250, 8);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(75, 27);
            btnEdit.TabIndex = 1;
            btnEdit.Tag = "btn-modify";
            btnEdit.Text = "修改";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(140, 140, 140);
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(330, 8);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 27);
            btnSave.TabIndex = 2;
            btnSave.Tag = "btn-modify";
            btnSave.Text = "儲存";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnApprove
            // 
            btnApprove.BackColor = Color.FromArgb(69, 98, 135);
            btnApprove.FlatStyle = FlatStyle.Flat;
            btnApprove.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            btnApprove.ForeColor = Color.White;
            btnApprove.Location = new Point(410, 8);
            btnApprove.Name = "btnApprove";
            btnApprove.Size = new Size(75, 27);
            btnApprove.TabIndex = 3;
            btnApprove.Tag = "btn-modify";
            btnApprove.Text = "生效";
            btnApprove.UseVisualStyleBackColor = false;
            btnApprove.Click += btnApprove_Click;
            // 
            // btnUnapprove
            // 
            btnUnapprove.BackColor = Color.FromArgb(166, 166, 166);
            btnUnapprove.FlatStyle = FlatStyle.Flat;
            btnUnapprove.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            btnUnapprove.ForeColor = Color.White;
            btnUnapprove.Location = new Point(492, 8);
            btnUnapprove.Name = "btnUnapprove";
            btnUnapprove.Size = new Size(90, 27);
            btnUnapprove.TabIndex = 4;
            btnUnapprove.Tag = "btn-modify";
            btnUnapprove.Text = "取消生效";
            btnUnapprove.UseVisualStyleBackColor = false;
            btnUnapprove.Click += btnUnapprove_Click;
            // 
            // btnAnnualStats
            // 
            btnAnnualStats.BackColor = Color.FromArgb(59, 129, 148);
            btnAnnualStats.FlatStyle = FlatStyle.Flat;
            btnAnnualStats.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            btnAnnualStats.ForeColor = Color.White;
            btnAnnualStats.Location = new Point(590, 8);
            btnAnnualStats.Name = "btnAnnualStats";
            btnAnnualStats.Size = new Size(100, 27);
            btnAnnualStats.TabIndex = 5;
            btnAnnualStats.Tag = "btn-modify";
            btnAnnualStats.Text = "年度假別統計";
            btnAnnualStats.UseVisualStyleBackColor = false;
            btnAnnualStats.Click += btnAnnualStats_Click;
            // 
            // btnPrint
            // 
            btnPrint.BackColor = Color.FromArgb(140, 140, 140);
            btnPrint.FlatStyle = FlatStyle.Flat;
            btnPrint.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            btnPrint.ForeColor = Color.White;
            btnPrint.Location = new Point(698, 8);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(75, 27);
            btnPrint.TabIndex = 6;
            btnPrint.Tag = "btn-modify";
            btnPrint.Text = "列印";
            btnPrint.UseVisualStyleBackColor = false;
            btnPrint.Click += btnPrint_Click;
            // 
            // btnOverview
            // 
            btnOverview.BackColor = Color.FromArgb(140, 140, 140);
            btnOverview.FlatStyle = FlatStyle.Flat;
            btnOverview.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            btnOverview.ForeColor = Color.White;
            btnOverview.Location = new Point(781, 8);
            btnOverview.Name = "btnOverview";
            btnOverview.Size = new Size(75, 27);
            btnOverview.TabIndex = 7;
            btnOverview.Tag = "btn-modify";
            btnOverview.Text = "總覽";
            btnOverview.UseVisualStyleBackColor = false;
            btnOverview.Click += btnOverview_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.FromArgb(140, 140, 140);
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            btnExit.ForeColor = Color.White;
            btnExit.Location = new Point(862, 8);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 27);
            btnExit.TabIndex = 8;
            btnExit.Tag = "btn-modify";
            btnExit.Text = "關閉";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // lbl日期
            // 
            lbl日期.Location = new Point(8, 48);
            lbl日期.Name = "lbl日期";
            lbl日期.Size = new Size(75, 21);
            lbl日期.TabIndex = 9;
            lbl日期.Text = "日期";
            lbl日期.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txt日期
            // 
            txt日期.BackColor = SystemColors.Control;
            txt日期.Location = new Point(90, 48);
            txt日期.Name = "txt日期";
            txt日期.ReadOnly = true;
            txt日期.Size = new Size(150, 23);
            txt日期.TabIndex = 10;
            // 
            // lbl週次
            // 
            lbl週次.Location = new Point(260, 48);
            lbl週次.Name = "lbl週次";
            lbl週次.Size = new Size(60, 21);
            lbl週次.TabIndex = 11;
            lbl週次.Text = "週次";
            lbl週次.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txt週次
            // 
            txt週次.BackColor = SystemColors.Control;
            txt週次.Location = new Point(322, 48);
            txt週次.Name = "txt週次";
            txt週次.ReadOnly = true;
            txt週次.Size = new Size(100, 23);
            txt週次.TabIndex = 12;
            // 
            // lbl例假日
            // 
            lbl例假日.Location = new Point(450, 48);
            lbl例假日.Name = "lbl例假日";
            lbl例假日.Size = new Size(60, 21);
            lbl例假日.TabIndex = 13;
            lbl例假日.Text = "例假日";
            lbl例假日.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // chk例假日
            // 
            chk例假日.Location = new Point(514, 51);
            chk例假日.Name = "chk例假日";
            chk例假日.Size = new Size(20, 20);
            chk例假日.TabIndex = 14;
            // 
            // lbl人事經辦
            // 
            lbl人事經辦.Location = new Point(8, 78);
            lbl人事經辦.Name = "lbl人事經辦";
            lbl人事經辦.Size = new Size(75, 21);
            lbl人事經辦.TabIndex = 15;
            lbl人事經辦.Text = "人事經辦";
            lbl人事經辦.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cmb人事經辦
            // 
            cmb人事經辦.Location = new Point(90, 78);
            cmb人事經辦.Name = "cmb人事經辦";
            cmb人事經辦.Size = new Size(180, 24);
            cmb人事經辦.TabIndex = 16;
            // 
            // lbl核准生效
            // 
            lbl核准生效.Location = new Point(300, 78);
            lbl核准生效.Name = "lbl核准生效";
            lbl核准生效.Size = new Size(65, 21);
            lbl核准生效.TabIndex = 17;
            lbl核准生效.Text = "核准生效";
            lbl核准生效.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // chk核准生效
            // 
            chk核准生效.Enabled = false;
            chk核准生效.Location = new Point(370, 81);
            chk核准生效.Name = "chk核准生效";
            chk核准生效.Size = new Size(20, 20);
            chk核准生效.TabIndex = 18;
            // 
            // lbl核准人
            // 
            lbl核准人.Location = new Point(450, 78);
            lbl核准人.Name = "lbl核准人";
            lbl核准人.Size = new Size(60, 21);
            lbl核准人.TabIndex = 19;
            lbl核准人.Text = "核准人";
            lbl核准人.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txt核准人
            // 
            txt核准人.BackColor = SystemColors.Control;
            txt核准人.Location = new Point(514, 78);
            txt核准人.Name = "txt核准人";
            txt核准人.ReadOnly = true;
            txt核准人.Size = new Size(180, 23);
            txt核准人.TabIndex = 20;
            // 
            // lbl公告事項
            // 
            lbl公告事項.Location = new Point(8, 108);
            lbl公告事項.Name = "lbl公告事項";
            lbl公告事項.Size = new Size(75, 38);
            lbl公告事項.TabIndex = 21;
            lbl公告事項.Text = "公告事項";
            lbl公告事項.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txt公告事項
            // 
            txt公告事項.BorderStyle = BorderStyle.FixedSingle;
            txt公告事項.Location = new Point(90, 108);
            txt公告事項.Multiline = true;
            txt公告事項.Name = "txt公告事項";
            txt公告事項.Size = new Size(950, 38);
            txt公告事項.TabIndex = 22;
            // 
            // panelLeave
            // 
            panelLeave.Controls.Add(dataGridViewLeave);
            panelLeave.Controls.Add(lbl請假紀錄表);
            panelLeave.Dock = DockStyle.Top;
            panelLeave.Location = new Point(0, 150);
            panelLeave.Name = "panelLeave";
            panelLeave.Padding = new Padding(8, 4, 8, 4);
            panelLeave.Size = new Size(1050, 178);
            panelLeave.TabIndex = 1;
            // 
            // dataGridViewLeave
            // 
            dataGridViewLeave.AllowUserToAddRows = false;
            dataGridViewLeave.AllowUserToDeleteRows = false;
            dataGridViewLeave.BackgroundColor = Color.White;
            dataGridViewLeave.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewLeave.Columns.AddRange(new DataGridViewColumn[] { colLeaveEmpNo, colLeaveName, colLeavePersonal, colLeaveSick, colLeaveAnnual, colLeaveMaternity, colLeaveOfficial, colLeavePhysiological, colLeaveFamily, colLeaveAbsent, colLeaveRemark, colLeaveDeductFactor });
            dataGridViewLeave.Dock = DockStyle.Fill;
            dataGridViewLeave.Location = new Point(8, 28);
            dataGridViewLeave.Name = "dataGridViewLeave";
            dataGridViewLeave.ReadOnly = true;
            dataGridViewLeave.RowHeadersVisible = false;
            dataGridViewLeave.RowTemplate.Height = 24;
            dataGridViewLeave.Size = new Size(1034, 146);
            dataGridViewLeave.TabIndex = 1;
            // 
            // colLeaveEmpNo
            // 
            colLeaveEmpNo.HeaderText = "員工編號";
            colLeaveEmpNo.Name = "colLeaveEmpNo";
            colLeaveEmpNo.ReadOnly = true;
            colLeaveEmpNo.Width = 80;
            // 
            // colLeaveName
            // 
            colLeaveName.HeaderText = "姓名";
            colLeaveName.Name = "colLeaveName";
            colLeaveName.ReadOnly = true;
            colLeaveName.Width = 70;
            // 
            // colLeavePersonal
            // 
            colLeavePersonal.HeaderText = "事假";
            colLeavePersonal.Name = "colLeavePersonal";
            colLeavePersonal.ReadOnly = true;
            colLeavePersonal.Width = 55;
            // 
            // colLeaveSick
            // 
            colLeaveSick.HeaderText = "病假";
            colLeaveSick.Name = "colLeaveSick";
            colLeaveSick.ReadOnly = true;
            colLeaveSick.Width = 55;
            // 
            // colLeaveAnnual
            // 
            colLeaveAnnual.HeaderText = "特休假";
            colLeaveAnnual.Name = "colLeaveAnnual";
            colLeaveAnnual.ReadOnly = true;
            colLeaveAnnual.Width = 60;
            // 
            // colLeaveMaternity
            // 
            colLeaveMaternity.HeaderText = "產假";
            colLeaveMaternity.Name = "colLeaveMaternity";
            colLeaveMaternity.ReadOnly = true;
            colLeaveMaternity.Width = 55;
            // 
            // colLeaveOfficial
            // 
            colLeaveOfficial.HeaderText = "公假";
            colLeaveOfficial.Name = "colLeaveOfficial";
            colLeaveOfficial.ReadOnly = true;
            colLeaveOfficial.Width = 55;
            // 
            // colLeavePhysiological
            // 
            colLeavePhysiological.HeaderText = "生理假";
            colLeavePhysiological.Name = "colLeavePhysiological";
            colLeavePhysiological.ReadOnly = true;
            colLeavePhysiological.Width = 60;
            // 
            // colLeaveFamily
            // 
            colLeaveFamily.HeaderText = "親情假";
            colLeaveFamily.Name = "colLeaveFamily";
            colLeaveFamily.ReadOnly = true;
            colLeaveFamily.Width = 60;
            // 
            // colLeaveAbsent
            // 
            colLeaveAbsent.HeaderText = "曠職";
            colLeaveAbsent.Name = "colLeaveAbsent";
            colLeaveAbsent.ReadOnly = true;
            colLeaveAbsent.Width = 55;
            // 
            // colLeaveRemark
            // 
            colLeaveRemark.HeaderText = "備註";
            colLeaveRemark.Name = "colLeaveRemark";
            colLeaveRemark.ReadOnly = true;
            colLeaveRemark.Width = 150;
            // 
            // colLeaveDeductFactor
            // 
            colLeaveDeductFactor.HeaderText = "請假扣款乘數";
            colLeaveDeductFactor.Name = "colLeaveDeductFactor";
            colLeaveDeductFactor.ReadOnly = true;
            colLeaveDeductFactor.Width = 90;
            // 
            // lbl請假紀錄表
            // 
            lbl請假紀錄表.Dock = DockStyle.Top;
            lbl請假紀錄表.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            lbl請假紀錄表.Location = new Point(8, 4);
            lbl請假紀錄表.Name = "lbl請假紀錄表";
            lbl請假紀錄表.Size = new Size(1034, 24);
            lbl請假紀錄表.TabIndex = 2;
            lbl請假紀錄表.Text = "請假紀錄表";
            lbl請假紀錄表.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panelAttend
            // 
            panelAttend.Controls.Add(dataGridViewAttend);
            panelAttend.Controls.Add(lbl出勤紀錄表);
            panelAttend.Dock = DockStyle.Fill;
            panelAttend.Location = new Point(0, 328);
            panelAttend.Name = "panelAttend";
            panelAttend.Padding = new Padding(8, 4, 8, 8);
            panelAttend.Size = new Size(1050, 272);
            panelAttend.TabIndex = 2;
            // 
            // dataGridViewAttend
            // 
            dataGridViewAttend.AllowUserToAddRows = false;
            dataGridViewAttend.AllowUserToDeleteRows = false;
            dataGridViewAttend.BackgroundColor = Color.White;
            dataGridViewAttend.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewAttend.Columns.AddRange(new DataGridViewColumn[] { colAttEmpNo, colAttName, colAttCard, colAttShift, colAttNormalIn, colAttNormalOut, colAttOTIn, colAttOTOut, colAttHours, colAttLeaveHours, colAttLate, colAttForgetCard, colAttLeaveType });
            dataGridViewAttend.Dock = DockStyle.Fill;
            dataGridViewAttend.Location = new Point(8, 28);
            dataGridViewAttend.Name = "dataGridViewAttend";
            dataGridViewAttend.ReadOnly = true;
            dataGridViewAttend.RowHeadersVisible = false;
            dataGridViewAttend.RowTemplate.Height = 24;
            dataGridViewAttend.Size = new Size(1034, 236);
            dataGridViewAttend.TabIndex = 1;
            // 
            // colAttEmpNo
            // 
            colAttEmpNo.HeaderText = "員工編號";
            colAttEmpNo.Name = "colAttEmpNo";
            colAttEmpNo.ReadOnly = true;
            colAttEmpNo.Width = 80;
            // 
            // colAttName
            // 
            colAttName.HeaderText = "姓名";
            colAttName.Name = "colAttName";
            colAttName.ReadOnly = true;
            colAttName.Width = 70;
            // 
            // colAttCard
            // 
            colAttCard.HeaderText = "卡號";
            colAttCard.Name = "colAttCard";
            colAttCard.ReadOnly = true;
            colAttCard.Width = 70;
            // 
            // colAttShift
            // 
            colAttShift.HeaderText = "班次";
            colAttShift.Name = "colAttShift";
            colAttShift.ReadOnly = true;
            colAttShift.Width = 70;
            // 
            // colAttNormalIn
            // 
            colAttNormalIn.HeaderText = "正規上班";
            colAttNormalIn.Name = "colAttNormalIn";
            colAttNormalIn.ReadOnly = true;
            colAttNormalIn.Width = 70;
            // 
            // colAttNormalOut
            // 
            colAttNormalOut.HeaderText = "正規下班";
            colAttNormalOut.Name = "colAttNormalOut";
            colAttNormalOut.ReadOnly = true;
            colAttNormalOut.Width = 70;
            // 
            // colAttOTIn
            // 
            colAttOTIn.HeaderText = "加班上班";
            colAttOTIn.Name = "colAttOTIn";
            colAttOTIn.ReadOnly = true;
            colAttOTIn.Width = 70;
            // 
            // colAttOTOut
            // 
            colAttOTOut.HeaderText = "加班下班";
            colAttOTOut.Name = "colAttOTOut";
            colAttOTOut.ReadOnly = true;
            colAttOTOut.Width = 70;
            // 
            // colAttHours
            // 
            colAttHours.HeaderText = "出勤時數";
            colAttHours.Name = "colAttHours";
            colAttHours.ReadOnly = true;
            colAttHours.Width = 70;
            // 
            // colAttLeaveHours
            // 
            colAttLeaveHours.HeaderText = "請休時數";
            colAttLeaveHours.Name = "colAttLeaveHours";
            colAttLeaveHours.ReadOnly = true;
            colAttLeaveHours.Width = 70;
            // 
            // colAttLate
            // 
            colAttLate.HeaderText = "遲到分鐘數";
            colAttLate.Name = "colAttLate";
            colAttLate.ReadOnly = true;
            colAttLate.Width = 80;
            // 
            // colAttForgetCard
            // 
            colAttForgetCard.HeaderText = "忘卡";
            colAttForgetCard.Name = "colAttForgetCard";
            colAttForgetCard.ReadOnly = true;
            colAttForgetCard.Width = 55;
            // 
            // colAttLeaveType
            // 
            colAttLeaveType.HeaderText = "假別";
            colAttLeaveType.Name = "colAttLeaveType";
            colAttLeaveType.ReadOnly = true;
            colAttLeaveType.Width = 70;
            // 
            // lbl出勤紀錄表
            // 
            lbl出勤紀錄表.Dock = DockStyle.Top;
            lbl出勤紀錄表.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            lbl出勤紀錄表.Location = new Point(8, 4);
            lbl出勤紀錄表.Name = "lbl出勤紀錄表";
            lbl出勤紀錄表.Size = new Size(1034, 24);
            lbl出勤紀錄表.TabIndex = 2;
            lbl出勤紀錄表.Text = "出勤紀錄表";
            lbl出勤紀錄表.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // CalendarVacationControl
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelAttend);
            Controls.Add(panelLeave);
            Controls.Add(panelHeader);
            Font = new Font("微軟正黑體", 9F);
            Margin = new Padding(4);
            Name = "CalendarVacationControl";
            Size = new Size(1050, 600);
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelLeave.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewLeave).EndInit();
            panelAttend.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewAttend).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private Label lblTitle;
        private Button btnEdit;
        private Button btnSave;
        private Button btnApprove;
        private Button btnUnapprove;
        private Button btnAnnualStats;
        private Button btnPrint;
        private Button btnOverview;
        private Button btnExit;
        private Label lbl日期; private TextBox txt日期;
        private Label lbl週次; private TextBox txt週次;
        private Label lbl例假日; private CheckBox chk例假日;
        private Label lbl人事經辦; private ComboBox cmb人事經辦;
        private Label lbl核准生效; private CheckBox chk核准生效;
        private Label lbl核准人; private TextBox txt核准人;
        private Label lbl公告事項; private TextBox txt公告事項;
        private Panel panelLeave;
        private Label lbl請假紀錄表;
        private DataGridView dataGridViewLeave;
        private DataGridViewTextBoxColumn colLeaveEmpNo;
        private DataGridViewTextBoxColumn colLeaveName;
        private DataGridViewTextBoxColumn colLeavePersonal;
        private DataGridViewTextBoxColumn colLeaveSick;
        private DataGridViewTextBoxColumn colLeaveAnnual;
        private DataGridViewTextBoxColumn colLeaveMaternity;
        private DataGridViewTextBoxColumn colLeaveOfficial;
        private DataGridViewTextBoxColumn colLeavePhysiological;
        private DataGridViewTextBoxColumn colLeaveFamily;
        private DataGridViewTextBoxColumn colLeaveAbsent;
        private DataGridViewTextBoxColumn colLeaveRemark;
        private DataGridViewTextBoxColumn colLeaveDeductFactor;
        private Panel panelAttend;
        private Label lbl出勤紀錄表;
        private DataGridView dataGridViewAttend;
        private DataGridViewTextBoxColumn colAttEmpNo;
        private DataGridViewTextBoxColumn colAttName;
        private DataGridViewTextBoxColumn colAttCard;
        private DataGridViewTextBoxColumn colAttShift;
        private DataGridViewTextBoxColumn colAttNormalIn;
        private DataGridViewTextBoxColumn colAttNormalOut;
        private DataGridViewTextBoxColumn colAttOTIn;
        private DataGridViewTextBoxColumn colAttOTOut;
        private DataGridViewTextBoxColumn colAttHours;
        private DataGridViewTextBoxColumn colAttLeaveHours;
        private DataGridViewTextBoxColumn colAttLate;
        private DataGridViewTextBoxColumn colAttForgetCard;
        private DataGridViewTextBoxColumn colAttLeaveType;
    }
}
