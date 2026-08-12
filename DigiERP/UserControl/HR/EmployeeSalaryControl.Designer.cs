using System.Drawing;
using System.Windows.Forms;

namespace DigiERP.UserControl.HR
{
    partial class EmployeeSalaryControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeSalaryControl));
            panelHeader = new Panel();
            lblTitle = new Label();
            btnPrev = new Button();
            btnNext = new Button();
            btnModify = new Button();
            btnSave = new Button();
            btnValidate = new Button();
            btnInvalidate = new Button();
            btnPrint = new Button();
            btnOverview = new Button();
            btnExit = new Button();
            panelInfo = new Panel();
            lblEmpNoT = new Label();
            txtEmpNo = new TextBox();
            lblNameT = new Label();
            txtName = new TextBox();
            lblCardNoT = new Label();
            txtCardNo = new TextBox();
            lblBirthdayT = new Label();
            txtBirthday = new TextBox();
            lblDeptT = new Label();
            txtDept = new TextBox();
            lblJobTitleT = new Label();
            txtJobTitle = new TextBox();
            lblHRNoT = new Label();
            txtHRNo = new TextBox();
            lblStatusT = new Label();
            txtStatus = new TextBox();
            btnEditPersonal = new Button();
            panelBody = new Panel();
            panelSalaryFooter = new Panel();
            lblTotalT = new Label();
            txtTotal = new TextBox();
            lblApproverT = new Label();
            txtApprover = new TextBox();
            lblMaintainerT = new Label();
            txtMaintainer = new TextBox();
            panelSalaryFields = new Panel();
            lblGradeT = new Label();
            numGrade = new NumericUpDown();
            lblRankT = new Label();
            numRank = new NumericUpDown();
            lblSalaryDateT = new Label();
            txtSalaryDate = new TextBox();
            lblResignDateT = new Label();
            txtResignDate = new TextBox();
            lblBaseSalaryT = new Label();
            numBaseSalary = new NumericUpDown();
            lblInsuranceGradeT = new Label();
            numInsuranceGrade = new NumericUpDown();
            lblPositionAllowanceT = new Label();
            numPositionAllowance = new NumericUpDown();
            lblDependentsT = new Label();
            numDependents = new NumericUpDown();
            lblSupervisorAllowanceT = new Label();
            numSupervisorAllowance = new NumericUpDown();
            lblLaborInsT = new Label();
            numLaborIns = new NumericUpDown();
            lblMealAllowanceT = new Label();
            numMealAllowance = new NumericUpDown();
            lblHealthInsT = new Label();
            numHealthIns = new NumericUpDown();
            lblDailyWageT = new Label();
            numDailyWage = new NumericUpDown();
            lblDependentInsT = new Label();
            numDependentIns = new NumericUpDown();
            lblHourlyWageT = new Label();
            numHourlyWage = new NumericUpDown();
            lblPensionSelfT = new Label();
            numPensionSelf = new NumericUpDown();
            lblBonusT = new Label();
            numBonus = new NumericUpDown();
            lblOtherDeductT = new Label();
            numOtherDeduct = new NumericUpDown();
            lblOtherAddT = new Label();
            numOtherAdd = new NumericUpDown();
            lblPensionCompanyT = new Label();
            numPensionCompany = new NumericUpDown();
            lblRemark = new Label();
            lblNote1T = new Label();
            txtNote1 = new TextBox();
            lblNote2T = new Label();
            txtNote2 = new TextBox();
            lblNote3T = new Label();
            txtNote3 = new TextBox();
            lblIdT = new Label();
            txtId = new TextBox();
            btnDeleteRecord = new Button();
            panelSalaryNav = new Panel();
            lblRecInfo = new Label();
            btnRecPrev = new Button();
            btnRecNext = new Button();
            btnRecNew = new Button();
            pictureBox1 = new PictureBox();
            panelHeader.SuspendLayout();
            panelInfo.SuspendLayout();
            panelBody.SuspendLayout();
            panelSalaryFooter.SuspendLayout();
            panelSalaryFields.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numGrade).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numRank).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numBaseSalary).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numInsuranceGrade).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numPositionAllowance).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numDependents).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numSupervisorAllowance).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numLaborIns).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numMealAllowance).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numHealthIns).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numDailyWage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numDependentIns).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numHourlyWage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numPensionSelf).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numBonus).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numOtherDeduct).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numOtherAdd).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numPensionCompany).BeginInit();
            panelSalaryNav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.Moccasin;
            panelHeader.Controls.Add(pictureBox1);
            panelHeader.Controls.Add(lblTitle);
            panelHeader.Controls.Add(btnPrev);
            panelHeader.Controls.Add(btnNext);
            panelHeader.Controls.Add(btnModify);
            panelHeader.Controls.Add(btnSave);
            panelHeader.Controls.Add(btnValidate);
            panelHeader.Controls.Add(btnInvalidate);
            panelHeader.Controls.Add(btnPrint);
            panelHeader.Controls.Add(btnOverview);
            panelHeader.Controls.Add(btnExit);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1060, 56);
            panelHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("微軟正黑體", 14F, FontStyle.Bold);
            lblTitle.ForeColor = Color.Firebrick;
            lblTitle.Location = new Point(70, 16);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(162, 24);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "員工薪資核定紀錄";
            // 
            // btnPrev
            // 
            btnPrev.BackColor = Color.Gainsboro;
            btnPrev.FlatStyle = FlatStyle.Flat;
            btnPrev.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            btnPrev.Location = new Point(300, 12);
            btnPrev.Name = "btnPrev";
            btnPrev.Size = new Size(40, 32);
            btnPrev.TabIndex = 1;
            btnPrev.Text = "◄";
            btnPrev.UseVisualStyleBackColor = false;
            btnPrev.Click += btnPrev_Click;
            // 
            // btnNext
            // 
            btnNext.BackColor = Color.Gainsboro;
            btnNext.FlatStyle = FlatStyle.Flat;
            btnNext.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            btnNext.Location = new Point(345, 12);
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
            btnModify.Location = new Point(410, 12);
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
            btnSave.Location = new Point(505, 12);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(90, 32);
            btnSave.TabIndex = 4;
            btnSave.Text = "儲存";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnValidate
            // 
            btnValidate.BackColor = Color.DarkOrange;
            btnValidate.FlatStyle = FlatStyle.Flat;
            btnValidate.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            btnValidate.ForeColor = Color.White;
            btnValidate.Location = new Point(600, 12);
            btnValidate.Name = "btnValidate";
            btnValidate.Size = new Size(90, 32);
            btnValidate.TabIndex = 5;
            btnValidate.Text = "生效";
            btnValidate.UseVisualStyleBackColor = false;
            btnValidate.Click += btnValidate_Click;
            // 
            // btnInvalidate
            // 
            btnInvalidate.BackColor = Color.Gainsboro;
            btnInvalidate.FlatStyle = FlatStyle.Flat;
            btnInvalidate.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            btnInvalidate.Location = new Point(700, 12);
            btnInvalidate.Name = "btnInvalidate";
            btnInvalidate.Size = new Size(90, 32);
            btnInvalidate.TabIndex = 6;
            btnInvalidate.Text = "取消生效";
            btnInvalidate.UseVisualStyleBackColor = false;
            btnInvalidate.Click += btnInvalidate_Click;
            // 
            // btnPrint
            // 
            btnPrint.BackColor = Color.Gainsboro;
            btnPrint.FlatStyle = FlatStyle.Flat;
            btnPrint.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            btnPrint.Location = new Point(700, 12);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(90, 32);
            btnPrint.TabIndex = 7;
            btnPrint.Text = "列印";
            btnPrint.UseVisualStyleBackColor = false;
            btnPrint.Visible = false;
            btnPrint.Click += btnPrint_Click;
            // 
            // btnOverview
            // 
            btnOverview.BackColor = Color.Gainsboro;
            btnOverview.FlatStyle = FlatStyle.Flat;
            btnOverview.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            btnOverview.Location = new Point(870, 12);
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
            btnExit.Location = new Point(965, 12);
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
            panelInfo.Controls.Add(lblEmpNoT);
            panelInfo.Controls.Add(txtEmpNo);
            panelInfo.Controls.Add(lblNameT);
            panelInfo.Controls.Add(txtName);
            panelInfo.Controls.Add(lblCardNoT);
            panelInfo.Controls.Add(txtCardNo);
            panelInfo.Controls.Add(lblBirthdayT);
            panelInfo.Controls.Add(txtBirthday);
            panelInfo.Controls.Add(lblDeptT);
            panelInfo.Controls.Add(txtDept);
            panelInfo.Controls.Add(lblJobTitleT);
            panelInfo.Controls.Add(txtJobTitle);
            panelInfo.Controls.Add(lblHRNoT);
            panelInfo.Controls.Add(txtHRNo);
            panelInfo.Controls.Add(lblStatusT);
            panelInfo.Controls.Add(txtStatus);
            panelInfo.Controls.Add(btnEditPersonal);
            panelInfo.Dock = DockStyle.Top;
            panelInfo.Location = new Point(0, 56);
            panelInfo.Name = "panelInfo";
            panelInfo.Size = new Size(1060, 76);
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
            // lblCardNoT
            // 
            lblCardNoT.AutoSize = true;
            lblCardNoT.Font = new Font("微軟正黑體", 9F);
            lblCardNoT.Location = new Point(210, 10);
            lblCardNoT.Name = "lblCardNoT";
            lblCardNoT.Size = new Size(55, 16);
            lblCardNoT.TabIndex = 4;
            lblCardNoT.Text = "出勤卡號";
            // 
            // txtCardNo
            // 
            txtCardNo.BackColor = Color.WhiteSmoke;
            txtCardNo.Font = new Font("微軟正黑體", 9F);
            txtCardNo.Location = new Point(210, 30);
            txtCardNo.Name = "txtCardNo";
            txtCardNo.ReadOnly = true;
            txtCardNo.Size = new Size(90, 23);
            txtCardNo.TabIndex = 5;
            // 
            // lblBirthdayT
            // 
            lblBirthdayT.AutoSize = true;
            lblBirthdayT.Font = new Font("微軟正黑體", 9F);
            lblBirthdayT.Location = new Point(310, 10);
            lblBirthdayT.Name = "lblBirthdayT";
            lblBirthdayT.Size = new Size(31, 16);
            lblBirthdayT.TabIndex = 6;
            lblBirthdayT.Text = "生日";
            // 
            // txtBirthday
            // 
            txtBirthday.BackColor = Color.WhiteSmoke;
            txtBirthday.Font = new Font("微軟正黑體", 9F);
            txtBirthday.Location = new Point(310, 30);
            txtBirthday.Name = "txtBirthday";
            txtBirthday.ReadOnly = true;
            txtBirthday.Size = new Size(90, 23);
            txtBirthday.TabIndex = 7;
            // 
            // lblDeptT
            // 
            lblDeptT.AutoSize = true;
            lblDeptT.Font = new Font("微軟正黑體", 9F);
            lblDeptT.Location = new Point(410, 10);
            lblDeptT.Name = "lblDeptT";
            lblDeptT.Size = new Size(31, 16);
            lblDeptT.TabIndex = 8;
            lblDeptT.Text = "部門";
            // 
            // txtDept
            // 
            txtDept.BackColor = Color.WhiteSmoke;
            txtDept.Font = new Font("微軟正黑體", 9F);
            txtDept.Location = new Point(410, 30);
            txtDept.Name = "txtDept";
            txtDept.ReadOnly = true;
            txtDept.Size = new Size(90, 23);
            txtDept.TabIndex = 9;
            // 
            // lblJobTitleT
            // 
            lblJobTitleT.AutoSize = true;
            lblJobTitleT.Font = new Font("微軟正黑體", 9F);
            lblJobTitleT.Location = new Point(510, 10);
            lblJobTitleT.Name = "lblJobTitleT";
            lblJobTitleT.Size = new Size(31, 16);
            lblJobTitleT.TabIndex = 10;
            lblJobTitleT.Text = "職稱";
            // 
            // txtJobTitle
            // 
            txtJobTitle.BackColor = Color.WhiteSmoke;
            txtJobTitle.Font = new Font("微軟正黑體", 9F);
            txtJobTitle.Location = new Point(510, 30);
            txtJobTitle.Name = "txtJobTitle";
            txtJobTitle.ReadOnly = true;
            txtJobTitle.Size = new Size(90, 23);
            txtJobTitle.TabIndex = 11;
            // 
            // lblHRNoT
            // 
            lblHRNoT.AutoSize = true;
            lblHRNoT.Font = new Font("微軟正黑體", 9F);
            lblHRNoT.Location = new Point(610, 10);
            lblHRNoT.Name = "lblHRNoT";
            lblHRNoT.Size = new Size(55, 16);
            lblHRNoT.TabIndex = 12;
            lblHRNoT.Text = "人事編號";
            // 
            // txtHRNo
            // 
            txtHRNo.BackColor = Color.WhiteSmoke;
            txtHRNo.Font = new Font("微軟正黑體", 9F);
            txtHRNo.Location = new Point(610, 30);
            txtHRNo.Name = "txtHRNo";
            txtHRNo.ReadOnly = true;
            txtHRNo.Size = new Size(90, 23);
            txtHRNo.TabIndex = 13;
            // 
            // lblStatusT
            // 
            lblStatusT.AutoSize = true;
            lblStatusT.Font = new Font("微軟正黑體", 9F);
            lblStatusT.Location = new Point(710, 10);
            lblStatusT.Name = "lblStatusT";
            lblStatusT.Size = new Size(31, 16);
            lblStatusT.TabIndex = 14;
            lblStatusT.Text = "狀況";
            // 
            // txtStatus
            // 
            txtStatus.BackColor = Color.WhiteSmoke;
            txtStatus.Font = new Font("微軟正黑體", 9F);
            txtStatus.Location = new Point(710, 30);
            txtStatus.Name = "txtStatus";
            txtStatus.ReadOnly = true;
            txtStatus.Size = new Size(90, 23);
            txtStatus.TabIndex = 15;
            // 
            // btnEditPersonal
            // 
            btnEditPersonal.BackColor = Color.SteelBlue;
            btnEditPersonal.FlatStyle = FlatStyle.Flat;
            btnEditPersonal.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            btnEditPersonal.ForeColor = Color.White;
            btnEditPersonal.Location = new Point(820, 26);
            btnEditPersonal.Name = "btnEditPersonal";
            btnEditPersonal.Size = new Size(120, 30);
            btnEditPersonal.TabIndex = 16;
            btnEditPersonal.Text = "修改員工個資";
            btnEditPersonal.UseVisualStyleBackColor = false;
            btnEditPersonal.Click += btnEditPersonal_Click;
            // 
            // panelBody
            // 
            panelBody.BackColor = Color.LightYellow;
            panelBody.Controls.Add(panelSalaryFooter);
            panelBody.Controls.Add(panelSalaryFields);
            panelBody.Controls.Add(panelSalaryNav);
            panelBody.Dock = DockStyle.Fill;
            panelBody.Location = new Point(0, 132);
            panelBody.Name = "panelBody";
            panelBody.Size = new Size(1060, 460);
            panelBody.TabIndex = 2;
            // 
            // panelSalaryFooter
            // 
            panelSalaryFooter.BackColor = Color.Moccasin;
            panelSalaryFooter.Controls.Add(lblTotalT);
            panelSalaryFooter.Controls.Add(txtTotal);
            panelSalaryFooter.Controls.Add(lblApproverT);
            panelSalaryFooter.Controls.Add(txtApprover);
            panelSalaryFooter.Controls.Add(lblMaintainerT);
            panelSalaryFooter.Controls.Add(txtMaintainer);
            panelSalaryFooter.Dock = DockStyle.Bottom;
            panelSalaryFooter.Location = new Point(0, 410);
            panelSalaryFooter.Name = "panelSalaryFooter";
            panelSalaryFooter.Size = new Size(1060, 50);
            panelSalaryFooter.TabIndex = 2;
            // 
            // lblTotalT
            // 
            lblTotalT.AutoSize = true;
            lblTotalT.BackColor = Color.LightSkyBlue;
            lblTotalT.Font = new Font("微軟正黑體", 9F);
            lblTotalT.Location = new Point(8, 16);
            lblTotalT.Name = "lblTotalT";
            lblTotalT.Size = new Size(55, 16);
            lblTotalT.TabIndex = 0;
            lblTotalT.Text = "薪資合計";
            // 
            // txtTotal
            // 
            txtTotal.BackColor = Color.Beige;
            txtTotal.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            txtTotal.Location = new Point(92, 12);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(120, 23);
            txtTotal.TabIndex = 1;
            // 
            // lblApproverT
            // 
            lblApproverT.AutoSize = true;
            lblApproverT.BackColor = Color.LightSkyBlue;
            lblApproverT.Font = new Font("微軟正黑體", 9F);
            lblApproverT.Location = new Point(578, 16);
            lblApproverT.Name = "lblApproverT";
            lblApproverT.Size = new Size(55, 16);
            lblApproverT.TabIndex = 2;
            lblApproverT.Text = "核准人員";
            // 
            // txtApprover
            // 
            txtApprover.BackColor = Color.WhiteSmoke;
            txtApprover.Font = new Font("微軟正黑體", 9F);
            txtApprover.Location = new Point(650, 12);
            txtApprover.Name = "txtApprover";
            txtApprover.ReadOnly = true;
            txtApprover.Size = new Size(110, 23);
            txtApprover.TabIndex = 3;
            // 
            // lblMaintainerT
            // 
            lblMaintainerT.AutoSize = true;
            lblMaintainerT.BackColor = Color.LightSkyBlue;
            lblMaintainerT.Font = new Font("微軟正黑體", 9F);
            lblMaintainerT.Location = new Point(780, 16);
            lblMaintainerT.Name = "lblMaintainerT";
            lblMaintainerT.Size = new Size(55, 16);
            lblMaintainerT.TabIndex = 4;
            lblMaintainerT.Text = "建檔維護";
            // 
            // txtMaintainer
            // 
            txtMaintainer.BackColor = Color.WhiteSmoke;
            txtMaintainer.Font = new Font("微軟正黑體", 9F);
            txtMaintainer.Location = new Point(852, 12);
            txtMaintainer.Name = "txtMaintainer";
            txtMaintainer.ReadOnly = true;
            txtMaintainer.Size = new Size(110, 23);
            txtMaintainer.TabIndex = 5;
            // 
            // panelSalaryFields
            // 
            panelSalaryFields.AutoScroll = true;
            panelSalaryFields.BackColor = Color.LightYellow;
            panelSalaryFields.Controls.Add(lblGradeT);
            panelSalaryFields.Controls.Add(numGrade);
            panelSalaryFields.Controls.Add(lblRankT);
            panelSalaryFields.Controls.Add(numRank);
            panelSalaryFields.Controls.Add(lblSalaryDateT);
            panelSalaryFields.Controls.Add(txtSalaryDate);
            panelSalaryFields.Controls.Add(lblResignDateT);
            panelSalaryFields.Controls.Add(txtResignDate);
            panelSalaryFields.Controls.Add(lblBaseSalaryT);
            panelSalaryFields.Controls.Add(numBaseSalary);
            panelSalaryFields.Controls.Add(lblInsuranceGradeT);
            panelSalaryFields.Controls.Add(numInsuranceGrade);
            panelSalaryFields.Controls.Add(lblPositionAllowanceT);
            panelSalaryFields.Controls.Add(numPositionAllowance);
            panelSalaryFields.Controls.Add(lblDependentsT);
            panelSalaryFields.Controls.Add(numDependents);
            panelSalaryFields.Controls.Add(lblSupervisorAllowanceT);
            panelSalaryFields.Controls.Add(numSupervisorAllowance);
            panelSalaryFields.Controls.Add(lblLaborInsT);
            panelSalaryFields.Controls.Add(numLaborIns);
            panelSalaryFields.Controls.Add(lblMealAllowanceT);
            panelSalaryFields.Controls.Add(numMealAllowance);
            panelSalaryFields.Controls.Add(lblHealthInsT);
            panelSalaryFields.Controls.Add(numHealthIns);
            panelSalaryFields.Controls.Add(lblDailyWageT);
            panelSalaryFields.Controls.Add(numDailyWage);
            panelSalaryFields.Controls.Add(lblDependentInsT);
            panelSalaryFields.Controls.Add(numDependentIns);
            panelSalaryFields.Controls.Add(lblHourlyWageT);
            panelSalaryFields.Controls.Add(numHourlyWage);
            panelSalaryFields.Controls.Add(lblPensionSelfT);
            panelSalaryFields.Controls.Add(numPensionSelf);
            panelSalaryFields.Controls.Add(lblBonusT);
            panelSalaryFields.Controls.Add(numBonus);
            panelSalaryFields.Controls.Add(lblOtherDeductT);
            panelSalaryFields.Controls.Add(numOtherDeduct);
            panelSalaryFields.Controls.Add(lblOtherAddT);
            panelSalaryFields.Controls.Add(numOtherAdd);
            panelSalaryFields.Controls.Add(lblPensionCompanyT);
            panelSalaryFields.Controls.Add(numPensionCompany);
            panelSalaryFields.Controls.Add(lblRemark);
            panelSalaryFields.Controls.Add(lblNote1T);
            panelSalaryFields.Controls.Add(txtNote1);
            panelSalaryFields.Controls.Add(lblNote2T);
            panelSalaryFields.Controls.Add(txtNote2);
            panelSalaryFields.Controls.Add(lblNote3T);
            panelSalaryFields.Controls.Add(txtNote3);
            panelSalaryFields.Controls.Add(lblIdT);
            panelSalaryFields.Controls.Add(txtId);
            panelSalaryFields.Controls.Add(btnDeleteRecord);
            panelSalaryFields.Dock = DockStyle.Fill;
            panelSalaryFields.Location = new Point(0, 36);
            panelSalaryFields.Name = "panelSalaryFields";
            panelSalaryFields.Size = new Size(1060, 424);
            panelSalaryFields.TabIndex = 1;
            // 
            // lblGradeT
            // 
            lblGradeT.AutoSize = true;
            lblGradeT.BackColor = Color.LightSkyBlue;
            lblGradeT.Font = new Font("微軟正黑體", 9F);
            lblGradeT.Location = new Point(8, 12);
            lblGradeT.Name = "lblGradeT";
            lblGradeT.Size = new Size(31, 16);
            lblGradeT.TabIndex = 0;
            lblGradeT.Text = "職等";
            // 
            // numGrade
            // 
            numGrade.Font = new Font("微軟正黑體", 9F);
            numGrade.Location = new Point(92, 8);
            numGrade.Maximum = new decimal(new int[] { 999, 0, 0, 0 });
            numGrade.Minimum = new decimal(new int[] { 999, 0, 0, int.MinValue });
            numGrade.Name = "numGrade";
            numGrade.ReadOnly = true;
            numGrade.Size = new Size(85, 23);
            numGrade.TabIndex = 1;
            // 
            // lblRankT
            // 
            lblRankT.AutoSize = true;
            lblRankT.BackColor = Color.LightSkyBlue;
            lblRankT.Font = new Font("微軟正黑體", 9F);
            lblRankT.Location = new Point(195, 12);
            lblRankT.Name = "lblRankT";
            lblRankT.Size = new Size(31, 16);
            lblRankT.TabIndex = 2;
            lblRankT.Text = "職級";
            // 
            // numRank
            // 
            numRank.Font = new Font("微軟正黑體", 9F);
            numRank.Location = new Point(272, 8);
            numRank.Maximum = new decimal(new int[] { 999, 0, 0, 0 });
            numRank.Minimum = new decimal(new int[] { 999, 0, 0, int.MinValue });
            numRank.Name = "numRank";
            numRank.ReadOnly = true;
            numRank.Size = new Size(85, 23);
            numRank.TabIndex = 3;
            // 
            // lblSalaryDateT
            // 
            lblSalaryDateT.AutoSize = true;
            lblSalaryDateT.BackColor = Color.LightSkyBlue;
            lblSalaryDateT.Font = new Font("微軟正黑體", 9F);
            lblSalaryDateT.Location = new Point(372, 12);
            lblSalaryDateT.Name = "lblSalaryDateT";
            lblSalaryDateT.Size = new Size(79, 16);
            lblSalaryDateT.TabIndex = 4;
            lblSalaryDateT.Text = "薪給生效起日";
            // 
            // txtSalaryDate
            // 
            txtSalaryDate.Font = new Font("微軟正黑體", 9F);
            txtSalaryDate.Location = new Point(465, 8);
            txtSalaryDate.Name = "txtSalaryDate";
            txtSalaryDate.ReadOnly = true;
            txtSalaryDate.Size = new Size(100, 23);
            txtSalaryDate.TabIndex = 5;
            // 
            // lblResignDateT
            // 
            lblResignDateT.AutoSize = true;
            lblResignDateT.BackColor = Color.LightSkyBlue;
            lblResignDateT.Font = new Font("微軟正黑體", 9F);
            lblResignDateT.Location = new Point(578, 12);
            lblResignDateT.Name = "lblResignDateT";
            lblResignDateT.Size = new Size(120, 16);
            lblResignDateT.TabIndex = 6;
            lblResignDateT.Text = "薪給有效訖日/離職日";
            // 
            // txtResignDate
            // 
            txtResignDate.Font = new Font("微軟正黑體", 9F);
            txtResignDate.Location = new Point(720, 8);
            txtResignDate.Name = "txtResignDate";
            txtResignDate.ReadOnly = true;
            txtResignDate.Size = new Size(100, 23);
            txtResignDate.TabIndex = 7;
            // 
            // lblBaseSalaryT
            // 
            lblBaseSalaryT.AutoSize = true;
            lblBaseSalaryT.BackColor = Color.LightSkyBlue;
            lblBaseSalaryT.Font = new Font("微軟正黑體", 9F);
            lblBaseSalaryT.Location = new Point(8, 48);
            lblBaseSalaryT.Name = "lblBaseSalaryT";
            lblBaseSalaryT.Size = new Size(31, 16);
            lblBaseSalaryT.TabIndex = 8;
            lblBaseSalaryT.Text = "底薪";
            // 
            // numBaseSalary
            // 
            numBaseSalary.Font = new Font("微軟正黑體", 9F);
            numBaseSalary.Location = new Point(92, 44);
            numBaseSalary.Maximum = new decimal(new int[] { 9999999, 0, 0, 0 });
            numBaseSalary.Name = "numBaseSalary";
            numBaseSalary.ReadOnly = true;
            numBaseSalary.Size = new Size(85, 23);
            numBaseSalary.TabIndex = 9;
            // 
            // lblInsuranceGradeT
            // 
            lblInsuranceGradeT.AutoSize = true;
            lblInsuranceGradeT.BackColor = Color.LightSkyBlue;
            lblInsuranceGradeT.Font = new Font("微軟正黑體", 9F);
            lblInsuranceGradeT.Location = new Point(195, 48);
            lblInsuranceGradeT.Name = "lblInsuranceGradeT";
            lblInsuranceGradeT.Size = new Size(55, 16);
            lblInsuranceGradeT.TabIndex = 10;
            lblInsuranceGradeT.Text = "投保金額";
            // 
            // numInsuranceGrade
            // 
            numInsuranceGrade.Font = new Font("微軟正黑體", 9F);
            numInsuranceGrade.Location = new Point(272, 44);
            numInsuranceGrade.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            numInsuranceGrade.Name = "numInsuranceGrade";
            numInsuranceGrade.ReadOnly = true;
            numInsuranceGrade.Size = new Size(85, 23);
            numInsuranceGrade.TabIndex = 11;
            // 
            // lblPositionAllowanceT
            // 
            lblPositionAllowanceT.AutoSize = true;
            lblPositionAllowanceT.BackColor = Color.LightSkyBlue;
            lblPositionAllowanceT.Font = new Font("微軟正黑體", 9F);
            lblPositionAllowanceT.Location = new Point(8, 84);
            lblPositionAllowanceT.Name = "lblPositionAllowanceT";
            lblPositionAllowanceT.Size = new Size(55, 16);
            lblPositionAllowanceT.TabIndex = 12;
            lblPositionAllowanceT.Text = "職務加給";
            // 
            // numPositionAllowance
            // 
            numPositionAllowance.Font = new Font("微軟正黑體", 9F);
            numPositionAllowance.Location = new Point(92, 80);
            numPositionAllowance.Maximum = new decimal(new int[] { 9999999, 0, 0, 0 });
            numPositionAllowance.Name = "numPositionAllowance";
            numPositionAllowance.ReadOnly = true;
            numPositionAllowance.Size = new Size(85, 23);
            numPositionAllowance.TabIndex = 13;
            // 
            // lblDependentsT
            // 
            lblDependentsT.AutoSize = true;
            lblDependentsT.BackColor = Color.LightSkyBlue;
            lblDependentsT.Font = new Font("微軟正黑體", 9F);
            lblDependentsT.Location = new Point(195, 84);
            lblDependentsT.Name = "lblDependentsT";
            lblDependentsT.Size = new Size(55, 16);
            lblDependentsT.TabIndex = 14;
            lblDependentsT.Text = "眷保口數";
            // 
            // numDependents
            // 
            numDependents.Font = new Font("微軟正黑體", 9F);
            numDependents.Location = new Point(272, 80);
            numDependents.Maximum = new decimal(new int[] { 99, 0, 0, 0 });
            numDependents.Name = "numDependents";
            numDependents.ReadOnly = true;
            numDependents.Size = new Size(85, 23);
            numDependents.TabIndex = 15;
            // 
            // lblSupervisorAllowanceT
            // 
            lblSupervisorAllowanceT.AutoSize = true;
            lblSupervisorAllowanceT.BackColor = Color.LightSkyBlue;
            lblSupervisorAllowanceT.Font = new Font("微軟正黑體", 9F);
            lblSupervisorAllowanceT.Location = new Point(8, 120);
            lblSupervisorAllowanceT.Name = "lblSupervisorAllowanceT";
            lblSupervisorAllowanceT.Size = new Size(55, 16);
            lblSupervisorAllowanceT.TabIndex = 16;
            lblSupervisorAllowanceT.Text = "主管津貼";
            // 
            // numSupervisorAllowance
            // 
            numSupervisorAllowance.Font = new Font("微軟正黑體", 9F);
            numSupervisorAllowance.Location = new Point(92, 116);
            numSupervisorAllowance.Maximum = new decimal(new int[] { 9999999, 0, 0, 0 });
            numSupervisorAllowance.Name = "numSupervisorAllowance";
            numSupervisorAllowance.ReadOnly = true;
            numSupervisorAllowance.Size = new Size(85, 23);
            numSupervisorAllowance.TabIndex = 17;
            // 
            // lblLaborInsT
            // 
            lblLaborInsT.AutoSize = true;
            lblLaborInsT.BackColor = Color.LightSkyBlue;
            lblLaborInsT.Font = new Font("微軟正黑體", 9F);
            lblLaborInsT.Location = new Point(195, 120);
            lblLaborInsT.Name = "lblLaborInsT";
            lblLaborInsT.Size = new Size(43, 16);
            lblLaborInsT.TabIndex = 18;
            lblLaborInsT.Text = "勞保費";
            // 
            // numLaborIns
            // 
            numLaborIns.Font = new Font("微軟正黑體", 9F);
            numLaborIns.Location = new Point(272, 116);
            numLaborIns.Maximum = new decimal(new int[] { 9999999, 0, 0, 0 });
            numLaborIns.Name = "numLaborIns";
            numLaborIns.ReadOnly = true;
            numLaborIns.Size = new Size(85, 23);
            numLaborIns.TabIndex = 19;
            // 
            // lblMealAllowanceT
            // 
            lblMealAllowanceT.AutoSize = true;
            lblMealAllowanceT.BackColor = Color.LightSkyBlue;
            lblMealAllowanceT.Font = new Font("微軟正黑體", 9F);
            lblMealAllowanceT.Location = new Point(8, 156);
            lblMealAllowanceT.Name = "lblMealAllowanceT";
            lblMealAllowanceT.Size = new Size(67, 16);
            lblMealAllowanceT.TabIndex = 20;
            lblMealAllowanceT.Text = "每日伙食費";
            // 
            // numMealAllowance
            // 
            numMealAllowance.Font = new Font("微軟正黑體", 9F);
            numMealAllowance.Location = new Point(92, 152);
            numMealAllowance.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            numMealAllowance.Name = "numMealAllowance";
            numMealAllowance.ReadOnly = true;
            numMealAllowance.Size = new Size(85, 23);
            numMealAllowance.TabIndex = 21;
            // 
            // lblHealthInsT
            // 
            lblHealthInsT.AutoSize = true;
            lblHealthInsT.BackColor = Color.LightSkyBlue;
            lblHealthInsT.Font = new Font("微軟正黑體", 9F);
            lblHealthInsT.Location = new Point(195, 156);
            lblHealthInsT.Name = "lblHealthInsT";
            lblHealthInsT.Size = new Size(43, 16);
            lblHealthInsT.TabIndex = 22;
            lblHealthInsT.Text = "健保費";
            // 
            // numHealthIns
            // 
            numHealthIns.Font = new Font("微軟正黑體", 9F);
            numHealthIns.Location = new Point(272, 152);
            numHealthIns.Maximum = new decimal(new int[] { 9999999, 0, 0, 0 });
            numHealthIns.Name = "numHealthIns";
            numHealthIns.ReadOnly = true;
            numHealthIns.Size = new Size(85, 23);
            numHealthIns.TabIndex = 23;
            // 
            // lblDailyWageT
            // 
            lblDailyWageT.AutoSize = true;
            lblDailyWageT.BackColor = Color.LightSkyBlue;
            lblDailyWageT.Font = new Font("微軟正黑體", 9F);
            lblDailyWageT.Location = new Point(8, 192);
            lblDailyWageT.Name = "lblDailyWageT";
            lblDailyWageT.Size = new Size(31, 16);
            lblDailyWageT.TabIndex = 24;
            lblDailyWageT.Text = "日薪";
            // 
            // numDailyWage
            // 
            numDailyWage.Font = new Font("微軟正黑體", 9F);
            numDailyWage.Location = new Point(92, 188);
            numDailyWage.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            numDailyWage.Name = "numDailyWage";
            numDailyWage.ReadOnly = true;
            numDailyWage.Size = new Size(85, 23);
            numDailyWage.TabIndex = 25;
            // 
            // lblDependentInsT
            // 
            lblDependentInsT.AutoSize = true;
            lblDependentInsT.BackColor = Color.LightSkyBlue;
            lblDependentInsT.Font = new Font("微軟正黑體", 9F);
            lblDependentInsT.Location = new Point(195, 192);
            lblDependentInsT.Name = "lblDependentInsT";
            lblDependentInsT.Size = new Size(43, 16);
            lblDependentInsT.TabIndex = 26;
            lblDependentInsT.Text = "眷保費";
            // 
            // numDependentIns
            // 
            numDependentIns.Font = new Font("微軟正黑體", 9F);
            numDependentIns.Location = new Point(272, 188);
            numDependentIns.Maximum = new decimal(new int[] { 9999999, 0, 0, 0 });
            numDependentIns.Name = "numDependentIns";
            numDependentIns.ReadOnly = true;
            numDependentIns.Size = new Size(85, 23);
            numDependentIns.TabIndex = 27;
            // 
            // lblHourlyWageT
            // 
            lblHourlyWageT.AutoSize = true;
            lblHourlyWageT.BackColor = Color.LightSkyBlue;
            lblHourlyWageT.Font = new Font("微軟正黑體", 9F);
            lblHourlyWageT.Location = new Point(8, 228);
            lblHourlyWageT.Name = "lblHourlyWageT";
            lblHourlyWageT.Size = new Size(31, 16);
            lblHourlyWageT.TabIndex = 28;
            lblHourlyWageT.Text = "時薪";
            // 
            // numHourlyWage
            // 
            numHourlyWage.DecimalPlaces = 2;
            numHourlyWage.Font = new Font("微軟正黑體", 9F);
            numHourlyWage.Location = new Point(92, 224);
            numHourlyWage.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
            numHourlyWage.Name = "numHourlyWage";
            numHourlyWage.ReadOnly = true;
            numHourlyWage.Size = new Size(85, 23);
            numHourlyWage.TabIndex = 29;
            // 
            // lblPensionSelfT
            // 
            lblPensionSelfT.AutoSize = true;
            lblPensionSelfT.BackColor = Color.LightSkyBlue;
            lblPensionSelfT.Font = new Font("微軟正黑體", 9F);
            lblPensionSelfT.Location = new Point(195, 228);
            lblPensionSelfT.Name = "lblPensionSelfT";
            lblPensionSelfT.Size = new Size(55, 16);
            lblPensionSelfT.TabIndex = 30;
            lblPensionSelfT.Text = "退休自提";
            // 
            // numPensionSelf
            // 
            numPensionSelf.Font = new Font("微軟正黑體", 9F);
            numPensionSelf.Location = new Point(272, 224);
            numPensionSelf.Maximum = new decimal(new int[] { 9999999, 0, 0, 0 });
            numPensionSelf.Name = "numPensionSelf";
            numPensionSelf.ReadOnly = true;
            numPensionSelf.Size = new Size(85, 23);
            numPensionSelf.TabIndex = 31;
            // 
            // lblBonusT
            // 
            lblBonusT.AutoSize = true;
            lblBonusT.BackColor = Color.LightSkyBlue;
            lblBonusT.Font = new Font("微軟正黑體", 9F);
            lblBonusT.Location = new Point(8, 264);
            lblBonusT.Name = "lblBonusT";
            lblBonusT.Size = new Size(55, 16);
            lblBonusT.TabIndex = 32;
            lblBonusT.Text = "專業獎金";
            // 
            // numBonus
            // 
            numBonus.Font = new Font("微軟正黑體", 9F);
            numBonus.Location = new Point(92, 260);
            numBonus.Maximum = new decimal(new int[] { 9999999, 0, 0, 0 });
            numBonus.Name = "numBonus";
            numBonus.ReadOnly = true;
            numBonus.Size = new Size(85, 23);
            numBonus.TabIndex = 33;
            // 
            // lblOtherDeductT
            // 
            lblOtherDeductT.AutoSize = true;
            lblOtherDeductT.BackColor = Color.LightSkyBlue;
            lblOtherDeductT.Font = new Font("微軟正黑體", 9F);
            lblOtherDeductT.Location = new Point(195, 264);
            lblOtherDeductT.Name = "lblOtherDeductT";
            lblOtherDeductT.Size = new Size(55, 16);
            lblOtherDeductT.TabIndex = 34;
            lblOtherDeductT.Text = "其他減項";
            // 
            // numOtherDeduct
            // 
            numOtherDeduct.Font = new Font("微軟正黑體", 9F);
            numOtherDeduct.Location = new Point(272, 260);
            numOtherDeduct.Maximum = new decimal(new int[] { 9999999, 0, 0, 0 });
            numOtherDeduct.Name = "numOtherDeduct";
            numOtherDeduct.ReadOnly = true;
            numOtherDeduct.Size = new Size(85, 23);
            numOtherDeduct.TabIndex = 35;
            // 
            // lblOtherAddT
            // 
            lblOtherAddT.AutoSize = true;
            lblOtherAddT.BackColor = Color.LightSkyBlue;
            lblOtherAddT.Font = new Font("微軟正黑體", 9F);
            lblOtherAddT.Location = new Point(8, 300);
            lblOtherAddT.Name = "lblOtherAddT";
            lblOtherAddT.Size = new Size(55, 16);
            lblOtherAddT.TabIndex = 36;
            lblOtherAddT.Text = "其他加項";
            // 
            // numOtherAdd
            // 
            numOtherAdd.Font = new Font("微軟正黑體", 9F);
            numOtherAdd.Location = new Point(92, 296);
            numOtherAdd.Maximum = new decimal(new int[] { 9999999, 0, 0, 0 });
            numOtherAdd.Name = "numOtherAdd";
            numOtherAdd.ReadOnly = true;
            numOtherAdd.Size = new Size(85, 23);
            numOtherAdd.TabIndex = 37;
            // 
            // lblPensionCompanyT
            // 
            lblPensionCompanyT.AutoSize = true;
            lblPensionCompanyT.BackColor = Color.LightSkyBlue;
            lblPensionCompanyT.Font = new Font("微軟正黑體", 9F);
            lblPensionCompanyT.Location = new Point(195, 300);
            lblPensionCompanyT.Name = "lblPensionCompanyT";
            lblPensionCompanyT.Size = new Size(55, 16);
            lblPensionCompanyT.TabIndex = 38;
            lblPensionCompanyT.Text = "退休公提";
            // 
            // numPensionCompany
            // 
            numPensionCompany.Font = new Font("微軟正黑體", 9F);
            numPensionCompany.Location = new Point(272, 296);
            numPensionCompany.Maximum = new decimal(new int[] { 9999999, 0, 0, 0 });
            numPensionCompany.Name = "numPensionCompany";
            numPensionCompany.ReadOnly = true;
            numPensionCompany.Size = new Size(85, 23);
            numPensionCompany.TabIndex = 39;
            // 
            // lblRemark
            // 
            lblRemark.Font = new Font("微軟正黑體", 8F);
            lblRemark.ForeColor = Color.DimGray;
            lblRemark.Location = new Point(8, 336);
            lblRemark.Name = "lblRemark";
            lblRemark.Size = new Size(560, 34);
            lblRemark.TabIndex = 40;
            lblRemark.Text = "※專業獎金包含本業所需證照、專業等級認證或公司認可之特殊才能與高階技術，為非工資項目，不計入加班費及請假扣款之時薪。";
            // 
            // lblNote1T
            // 
            lblNote1T.AutoSize = true;
            lblNote1T.Font = new Font("微軟正黑體", 9F);
            lblNote1T.ForeColor = Color.RoyalBlue;
            lblNote1T.Location = new Point(578, 44);
            lblNote1T.Name = "lblNote1T";
            lblNote1T.Size = new Size(43, 16);
            lblNote1T.TabIndex = 41;
            lblNote1T.Text = "備註一";
            // 
            // txtNote1
            // 
            txtNote1.Font = new Font("微軟正黑體", 9F);
            txtNote1.Location = new Point(578, 64);
            txtNote1.Multiline = true;
            txtNote1.Name = "txtNote1";
            txtNote1.ReadOnly = true;
            txtNote1.Size = new Size(300, 50);
            txtNote1.TabIndex = 42;
            // 
            // lblNote2T
            // 
            lblNote2T.AutoSize = true;
            lblNote2T.Font = new Font("微軟正黑體", 9F);
            lblNote2T.ForeColor = Color.RoyalBlue;
            lblNote2T.Location = new Point(578, 124);
            lblNote2T.Name = "lblNote2T";
            lblNote2T.Size = new Size(43, 16);
            lblNote2T.TabIndex = 45;
            lblNote2T.Text = "備註二";
            // 
            // txtNote2
            // 
            txtNote2.Font = new Font("微軟正黑體", 9F);
            txtNote2.Location = new Point(578, 144);
            txtNote2.Multiline = true;
            txtNote2.Name = "txtNote2";
            txtNote2.ReadOnly = true;
            txtNote2.Size = new Size(300, 50);
            txtNote2.TabIndex = 46;
            // 
            // lblNote3T
            // 
            lblNote3T.AutoSize = true;
            lblNote3T.Font = new Font("微軟正黑體", 9F);
            lblNote3T.ForeColor = Color.RoyalBlue;
            lblNote3T.Location = new Point(578, 204);
            lblNote3T.Name = "lblNote3T";
            lblNote3T.Size = new Size(43, 16);
            lblNote3T.TabIndex = 47;
            lblNote3T.Text = "備註三";
            // 
            // txtNote3
            // 
            txtNote3.Font = new Font("微軟正黑體", 9F);
            txtNote3.Location = new Point(578, 224);
            txtNote3.Multiline = true;
            txtNote3.Name = "txtNote3";
            txtNote3.ReadOnly = true;
            txtNote3.Size = new Size(300, 50);
            txtNote3.TabIndex = 48;
            // 
            // lblIdT
            // 
            lblIdT.AutoSize = true;
            lblIdT.Font = new Font("微軟正黑體", 9F);
            lblIdT.Location = new Point(890, 44);
            lblIdT.Name = "lblIdT";
            lblIdT.Size = new Size(43, 16);
            lblIdT.TabIndex = 43;
            lblIdT.Text = "識別碼";
            lblIdT.Visible = false;
            // 
            // txtId
            // 
            txtId.BackColor = Color.WhiteSmoke;
            txtId.Font = new Font("微軟正黑體", 9F);
            txtId.Location = new Point(890, 64);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(66, 23);
            txtId.TabIndex = 44;
            txtId.Visible = false;
            // 
            // btnDeleteRecord
            // 
            btnDeleteRecord.BackColor = Color.IndianRed;
            btnDeleteRecord.FlatStyle = FlatStyle.Flat;
            btnDeleteRecord.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            btnDeleteRecord.ForeColor = Color.White;
            btnDeleteRecord.Location = new Point(578, 284);
            btnDeleteRecord.Name = "btnDeleteRecord";
            btnDeleteRecord.Size = new Size(130, 32);
            btnDeleteRecord.TabIndex = 49;
            btnDeleteRecord.Text = "刪除此筆紀錄";
            btnDeleteRecord.UseVisualStyleBackColor = false;
            btnDeleteRecord.Click += btnDeleteRecord_Click;
            // 
            // panelSalaryNav
            // 
            panelSalaryNav.BackColor = Color.Moccasin;
            panelSalaryNav.Controls.Add(lblRecInfo);
            panelSalaryNav.Controls.Add(btnRecPrev);
            panelSalaryNav.Controls.Add(btnRecNext);
            panelSalaryNav.Controls.Add(btnRecNew);
            panelSalaryNav.Dock = DockStyle.Top;
            panelSalaryNav.Location = new Point(0, 0);
            panelSalaryNav.Name = "panelSalaryNav";
            panelSalaryNav.Size = new Size(1060, 36);
            panelSalaryNav.TabIndex = 0;
            // 
            // lblRecInfo
            // 
            lblRecInfo.AutoSize = true;
            lblRecInfo.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            lblRecInfo.Location = new Point(10, 10);
            lblRecInfo.Name = "lblRecInfo";
            lblRecInfo.Size = new Size(77, 16);
            lblRecInfo.TabIndex = 0;
            lblRecInfo.Text = "薪資紀錄 0/0";
            lblRecInfo.Visible = false;
            // 
            // btnRecPrev
            // 
            btnRecPrev.FlatStyle = FlatStyle.Flat;
            btnRecPrev.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            btnRecPrev.Location = new Point(150, 4);
            btnRecPrev.Name = "btnRecPrev";
            btnRecPrev.Size = new Size(34, 28);
            btnRecPrev.TabIndex = 1;
            btnRecPrev.Text = "◄";
            btnRecPrev.UseVisualStyleBackColor = true;
            btnRecPrev.Visible = false;
            btnRecPrev.Click += btnRecPrev_Click;
            // 
            // btnRecNext
            // 
            btnRecNext.FlatStyle = FlatStyle.Flat;
            btnRecNext.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            btnRecNext.Location = new Point(190, 4);
            btnRecNext.Name = "btnRecNext";
            btnRecNext.Size = new Size(34, 28);
            btnRecNext.TabIndex = 2;
            btnRecNext.Text = "►";
            btnRecNext.UseVisualStyleBackColor = true;
            btnRecNext.Visible = false;
            btnRecNext.Click += btnRecNext_Click;
            // 
            // btnRecNew
            // 
            btnRecNew.FlatStyle = FlatStyle.Flat;
            btnRecNew.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            btnRecNew.Location = new Point(240, 4);
            btnRecNew.Name = "btnRecNew";
            btnRecNew.Size = new Size(90, 28);
            btnRecNew.TabIndex = 3;
            btnRecNew.Text = "新增一筆";
            btnRecNew.UseVisualStyleBackColor = true;
            btnRecNew.Visible = false;
            btnRecNew.Click += btnRecNew_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(4, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(56, 48);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // EmployeeSalaryControl
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelBody);
            Controls.Add(panelInfo);
            Controls.Add(panelHeader);
            Font = new Font("微軟正黑體", 10F);
            Margin = new Padding(4);
            Name = "EmployeeSalaryControl";
            Size = new Size(1060, 592);
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelInfo.ResumeLayout(false);
            panelInfo.PerformLayout();
            panelBody.ResumeLayout(false);
            panelSalaryFooter.ResumeLayout(false);
            panelSalaryFooter.PerformLayout();
            panelSalaryFields.ResumeLayout(false);
            panelSalaryFields.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numGrade).EndInit();
            ((System.ComponentModel.ISupportInitialize)numRank).EndInit();
            ((System.ComponentModel.ISupportInitialize)numBaseSalary).EndInit();
            ((System.ComponentModel.ISupportInitialize)numInsuranceGrade).EndInit();
            ((System.ComponentModel.ISupportInitialize)numPositionAllowance).EndInit();
            ((System.ComponentModel.ISupportInitialize)numDependents).EndInit();
            ((System.ComponentModel.ISupportInitialize)numSupervisorAllowance).EndInit();
            ((System.ComponentModel.ISupportInitialize)numLaborIns).EndInit();
            ((System.ComponentModel.ISupportInitialize)numMealAllowance).EndInit();
            ((System.ComponentModel.ISupportInitialize)numHealthIns).EndInit();
            ((System.ComponentModel.ISupportInitialize)numDailyWage).EndInit();
            ((System.ComponentModel.ISupportInitialize)numDependentIns).EndInit();
            ((System.ComponentModel.ISupportInitialize)numHourlyWage).EndInit();
            ((System.ComponentModel.ISupportInitialize)numPensionSelf).EndInit();
            ((System.ComponentModel.ISupportInitialize)numBonus).EndInit();
            ((System.ComponentModel.ISupportInitialize)numOtherDeduct).EndInit();
            ((System.ComponentModel.ISupportInitialize)numOtherAdd).EndInit();
            ((System.ComponentModel.ISupportInitialize)numPensionCompany).EndInit();
            panelSalaryNav.ResumeLayout(false);
            panelSalaryNav.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private Label lblTitle;
        private Button btnPrev;
        private Button btnNext;
        private Button btnModify;
        private Button btnSave;
        private Button btnValidate;
        private Button btnInvalidate;
        private Button btnPrint;
        private Button btnOverview;
        private Button btnExit;
        private Panel panelInfo;
        private Label lblEmpNoT;
        private TextBox txtEmpNo;
        private Label lblNameT;
        private TextBox txtName;
        private Label lblCardNoT;
        private TextBox txtCardNo;
        private Label lblBirthdayT;
        private TextBox txtBirthday;
        private Label lblDeptT;
        private TextBox txtDept;
        private Label lblJobTitleT;
        private TextBox txtJobTitle;
        private Label lblHRNoT;
        private TextBox txtHRNo;
        private Label lblStatusT;
        private TextBox txtStatus;
        private Button btnEditPersonal;
        private Panel panelBody;
        private Panel panelSalaryNav;
        private Label lblRecInfo;
        private Button btnRecPrev;
        private Button btnRecNext;
        private Button btnRecNew;
        private Panel panelSalaryFields;
        private Label lblGradeT;
        private NumericUpDown numGrade;
        private Label lblRankT;
        private NumericUpDown numRank;
        private Label lblSalaryDateT;
        private TextBox txtSalaryDate;
        private Label lblResignDateT;
        private TextBox txtResignDate;
        private Label lblBaseSalaryT;
        private NumericUpDown numBaseSalary;
        private Label lblInsuranceGradeT;
        private NumericUpDown numInsuranceGrade;
        private Label lblPositionAllowanceT;
        private NumericUpDown numPositionAllowance;
        private Label lblDependentsT;
        private NumericUpDown numDependents;
        private Label lblSupervisorAllowanceT;
        private NumericUpDown numSupervisorAllowance;
        private Label lblLaborInsT;
        private NumericUpDown numLaborIns;
        private Label lblMealAllowanceT;
        private NumericUpDown numMealAllowance;
        private Label lblHealthInsT;
        private NumericUpDown numHealthIns;
        private Label lblDailyWageT;
        private NumericUpDown numDailyWage;
        private Label lblDependentInsT;
        private NumericUpDown numDependentIns;
        private Label lblHourlyWageT;
        private NumericUpDown numHourlyWage;
        private Label lblPensionSelfT;
        private NumericUpDown numPensionSelf;
        private Label lblBonusT;
        private NumericUpDown numBonus;
        private Label lblOtherDeductT;
        private NumericUpDown numOtherDeduct;
        private Label lblOtherAddT;
        private NumericUpDown numOtherAdd;
        private Label lblPensionCompanyT;
        private NumericUpDown numPensionCompany;
        private Label lblRemark;
        private Label lblNote1T;
        private TextBox txtNote1;
        private Label lblNote2T;
        private TextBox txtNote2;
        private Label lblNote3T;
        private TextBox txtNote3;
        private Label lblIdT;
        private TextBox txtId;
        private Button btnDeleteRecord;
        private Panel panelSalaryFooter;
        private Label lblTotalT;
        private TextBox txtTotal;
        private Label lblApproverT;
        private TextBox txtApprover;
        private Label lblMaintainerT;
        private TextBox txtMaintainer;
        private PictureBox pictureBox1;
    }
}
