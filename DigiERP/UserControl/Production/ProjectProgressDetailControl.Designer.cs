using System.Drawing;
using System.Windows.Forms;

namespace DigiERP.UserControl.Production
{
    partial class ProjectProgressDetailControl
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
            panel1 = new Panel();
            lblTitle = new Label();
            btnOverview = new Button();
            btnClose = new Button();
            panelHeader = new Panel();
            label1 = new Label();
            lblProjectNo = new Label();
            txtProjectNo = new TextBox();
            lblOrderDate = new Label();
            txtOrderDate = new TextBox();
            lblCustShort = new Label();
            txtCustShort = new TextBox();
            lblCustName = new Label();
            txtCustName = new TextBox();
            lblMachineModel = new Label();
            txtMachineModel = new TextBox();
            lblMachineType = new Label();
            txtMachineType = new TextBox();
            lblInspectDate = new Label();
            txtInspectDate = new TextBox();
            lblDeliveryDate = new Label();
            txtDeliveryDate = new TextBox();
            lblMachineName = new Label();
            txtMachineName = new TextBox();
            panel2 = new Panel();
            dataGridView5 = new DataGridView();
            colECProcess = new DataGridViewTextBoxColumn();
            colECDesc = new DataGridViewTextBoxColumn();
            colECPerson = new DataGridViewTextBoxColumn();
            colECStartDate = new DataGridViewTextBoxColumn();
            colECPlannedFinishDate = new DataGridViewTextBoxColumn();
            colECActualFinishDate = new DataGridViewTextBoxColumn();
            panelElectricTitle = new Panel();
            lblElectricTitle = new Label();
            dataGridView4 = new DataGridView();
            colMUModule = new DataGridViewTextBoxColumn();
            colMUModuleName = new DataGridViewTextBoxColumn();
            colMUDrawingFile = new DataGridViewTextBoxColumn();
            colMUIssueDate = new DataGridViewTextBoxColumn();
            colMUAssemblyPerson = new DataGridViewTextBoxColumn();
            colMUStartDate = new DataGridViewTextBoxColumn();
            colMUPreDeliveryDate = new DataGridViewTextBoxColumn();
            colMUFinishDate = new DataGridViewTextBoxColumn();
            colMUCloseReport = new DataGridViewTextBoxColumn();
            colMUPurpose = new DataGridViewTextBoxColumn();
            panelModuleTitle = new Panel();
            lblModuleTitle = new Label();
            dataGridView3 = new DataGridView();
            colPS3Module = new DataGridViewTextBoxColumn();
            colPS3PartNo = new DataGridViewTextBoxColumn();
            colPS3PartName = new DataGridViewTextBoxColumn();
            colPS3Unit1 = new DataGridViewTextBoxColumn();
            colPS3Start1 = new DataGridViewTextBoxColumn();
            colPS3Finish1 = new DataGridViewTextBoxColumn();
            colPS3Unit2 = new DataGridViewTextBoxColumn();
            colPS3Start2 = new DataGridViewTextBoxColumn();
            colPS3Finish2 = new DataGridViewTextBoxColumn();
            colPS3Unit3 = new DataGridViewTextBoxColumn();
            colPS3Start3 = new DataGridViewTextBoxColumn();
            colPS3Finish3 = new DataGridViewTextBoxColumn();
            colPS3Unit4 = new DataGridViewTextBoxColumn();
            colPS3Start4 = new DataGridViewTextBoxColumn();
            colPS3Finish4 = new DataGridViewTextBoxColumn();
            colPS3Unit5 = new DataGridViewTextBoxColumn();
            colPS3Start5 = new DataGridViewTextBoxColumn();
            colPS3Finish5 = new DataGridViewTextBoxColumn();
            panelProcessTitle = new Panel();
            lblProcessTitle = new Label();
            dataGridView2 = new DataGridView();
            colPPModule = new DataGridViewTextBoxColumn();
            colPPPartNo = new DataGridViewTextBoxColumn();
            colPPPartName = new DataGridViewTextBoxColumn();
            colPPDesc = new DataGridViewTextBoxColumn();
            colPPQty = new DataGridViewTextBoxColumn();
            colPPPartType = new DataGridViewTextBoxColumn();
            colPPBuyer = new DataGridViewTextBoxColumn();
            colPPActualDate = new DataGridViewTextBoxColumn();
            colPPExpectedDate = new DataGridViewTextBoxColumn();
            colPPStockInDate = new DataGridViewTextBoxColumn();
            colPPControlNo = new DataGridViewTextBoxColumn();
            panelPurchaseTitle = new Panel();
            lblPurchaseTitle = new Label();
            dataGridView1 = new DataGridView();
            colModuleCode = new DataGridViewTextBoxColumn();
            colModuleName = new DataGridViewTextBoxColumn();
            colDesigner = new DataGridViewTextBoxColumn();
            colDesignType = new DataGridViewTextBoxColumn();
            colDrawingFile = new DataGridViewTextBoxColumn();
            colActualStart = new DataGridViewTextBoxColumn();
            colPlannedFinish = new DataGridViewTextBoxColumn();
            colDrawingIssueDate = new DataGridViewTextBoxColumn();
            colReviewPass = new DataGridViewTextBoxColumn();
            colListNo = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            panelHeader.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView5).BeginInit();
            panelElectricTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).BeginInit();
            panelModuleTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            panelProcessTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            panelPurchaseTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Cornsilk;
            panel1.Controls.Add(lblTitle);
            panel1.Controls.Add(btnOverview);
            panel1.Controls.Add(btnClose);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1900, 56);
            panel1.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("微軟正黑體", 14F, FontStyle.Bold);
            lblTitle.Location = new Point(20, 16);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(105, 24);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "專案管控表";
            // 
            // btnOverview
            // 
            btnOverview.BackColor = Color.SeaGreen;
            btnOverview.FlatStyle = FlatStyle.Flat;
            btnOverview.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            btnOverview.ForeColor = Color.White;
            btnOverview.Location = new Point(1680, 12);
            btnOverview.Name = "btnOverview";
            btnOverview.Size = new Size(90, 32);
            btnOverview.TabIndex = 1;
            btnOverview.Text = "總覽";
            btnOverview.UseVisualStyleBackColor = false;
            btnOverview.Visible = false;
            btnOverview.Click += btnOverview_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.LightSteelBlue;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            btnClose.Location = new Point(1780, 12);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(100, 32);
            btnClose.TabIndex = 2;
            btnClose.Text = "關閉";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Visible = false;
            btnClose.Click += btnClose_Click;
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.LightYellow;
            panelHeader.Controls.Add(label1);
            panelHeader.Controls.Add(lblProjectNo);
            panelHeader.Controls.Add(txtProjectNo);
            panelHeader.Controls.Add(lblOrderDate);
            panelHeader.Controls.Add(txtOrderDate);
            panelHeader.Controls.Add(lblCustShort);
            panelHeader.Controls.Add(txtCustShort);
            panelHeader.Controls.Add(lblCustName);
            panelHeader.Controls.Add(txtCustName);
            panelHeader.Controls.Add(lblMachineModel);
            panelHeader.Controls.Add(txtMachineModel);
            panelHeader.Controls.Add(lblMachineType);
            panelHeader.Controls.Add(txtMachineType);
            panelHeader.Controls.Add(lblInspectDate);
            panelHeader.Controls.Add(txtInspectDate);
            panelHeader.Controls.Add(lblDeliveryDate);
            panelHeader.Controls.Add(txtDeliveryDate);
            panelHeader.Controls.Add(lblMachineName);
            panelHeader.Controls.Add(txtMachineName);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 56);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1900, 124);
            panelHeader.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("微軟正黑體", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 136);
            label1.Location = new Point(12, 104);
            label1.Name = "label1";
            label1.Size = new Size(60, 17);
            label1.TabIndex = 18;
            label1.Text = "設計進度";
            // 
            // lblProjectNo
            // 
            lblProjectNo.AutoSize = true;
            lblProjectNo.ForeColor = Color.Green;
            lblProjectNo.Location = new Point(10, 12);
            lblProjectNo.Name = "lblProjectNo";
            lblProjectNo.Size = new Size(64, 18);
            lblProjectNo.TabIndex = 0;
            lblProjectNo.Text = "專案序號";
            // 
            // txtProjectNo
            // 
            txtProjectNo.BackColor = Color.WhiteSmoke;
            txtProjectNo.Location = new Point(84, 8);
            txtProjectNo.Name = "txtProjectNo";
            txtProjectNo.ReadOnly = true;
            txtProjectNo.Size = new Size(200, 25);
            txtProjectNo.TabIndex = 1;
            // 
            // lblOrderDate
            // 
            lblOrderDate.AutoSize = true;
            lblOrderDate.Location = new Point(300, 12);
            lblOrderDate.Name = "lblOrderDate";
            lblOrderDate.Size = new Size(64, 18);
            lblOrderDate.TabIndex = 2;
            lblOrderDate.Text = "訂單日期";
            // 
            // txtOrderDate
            // 
            txtOrderDate.BackColor = Color.WhiteSmoke;
            txtOrderDate.Location = new Point(374, 8);
            txtOrderDate.Name = "txtOrderDate";
            txtOrderDate.ReadOnly = true;
            txtOrderDate.Size = new Size(200, 25);
            txtOrderDate.TabIndex = 3;
            // 
            // lblCustShort
            // 
            lblCustShort.AutoSize = true;
            lblCustShort.Location = new Point(590, 12);
            lblCustShort.Name = "lblCustShort";
            lblCustShort.Size = new Size(64, 18);
            lblCustShort.TabIndex = 4;
            lblCustShort.Text = "客戶簡稱";
            // 
            // txtCustShort
            // 
            txtCustShort.BackColor = Color.WhiteSmoke;
            txtCustShort.Location = new Point(664, 8);
            txtCustShort.Name = "txtCustShort";
            txtCustShort.ReadOnly = true;
            txtCustShort.Size = new Size(200, 25);
            txtCustShort.TabIndex = 5;
            // 
            // lblCustName
            // 
            lblCustName.AutoSize = true;
            lblCustName.Location = new Point(880, 12);
            lblCustName.Name = "lblCustName";
            lblCustName.Size = new Size(64, 18);
            lblCustName.TabIndex = 6;
            lblCustName.Text = "客戶名稱";
            // 
            // txtCustName
            // 
            txtCustName.BackColor = Color.WhiteSmoke;
            txtCustName.Location = new Point(954, 8);
            txtCustName.Name = "txtCustName";
            txtCustName.ReadOnly = true;
            txtCustName.Size = new Size(280, 25);
            txtCustName.TabIndex = 7;
            // 
            // lblMachineModel
            // 
            lblMachineModel.AutoSize = true;
            lblMachineModel.Location = new Point(10, 44);
            lblMachineModel.Name = "lblMachineModel";
            lblMachineModel.Size = new Size(64, 18);
            lblMachineModel.TabIndex = 8;
            lblMachineModel.Text = "機台型號";
            // 
            // txtMachineModel
            // 
            txtMachineModel.BackColor = Color.WhiteSmoke;
            txtMachineModel.Location = new Point(84, 40);
            txtMachineModel.Name = "txtMachineModel";
            txtMachineModel.ReadOnly = true;
            txtMachineModel.Size = new Size(200, 25);
            txtMachineModel.TabIndex = 9;
            // 
            // lblMachineType
            // 
            lblMachineType.AutoSize = true;
            lblMachineType.Location = new Point(300, 44);
            lblMachineType.Name = "lblMachineType";
            lblMachineType.Size = new Size(64, 18);
            lblMachineType.TabIndex = 10;
            lblMachineType.Text = "機台類型";
            // 
            // txtMachineType
            // 
            txtMachineType.BackColor = Color.WhiteSmoke;
            txtMachineType.Location = new Point(374, 40);
            txtMachineType.Name = "txtMachineType";
            txtMachineType.ReadOnly = true;
            txtMachineType.Size = new Size(200, 25);
            txtMachineType.TabIndex = 11;
            // 
            // lblInspectDate
            // 
            lblInspectDate.AutoSize = true;
            lblInspectDate.Location = new Point(590, 44);
            lblInspectDate.Name = "lblInspectDate";
            lblInspectDate.Size = new Size(64, 18);
            lblInspectDate.TabIndex = 12;
            lblInspectDate.Text = "驗機日期";
            // 
            // txtInspectDate
            // 
            txtInspectDate.BackColor = Color.WhiteSmoke;
            txtInspectDate.Location = new Point(664, 40);
            txtInspectDate.Name = "txtInspectDate";
            txtInspectDate.ReadOnly = true;
            txtInspectDate.Size = new Size(200, 25);
            txtInspectDate.TabIndex = 13;
            // 
            // lblDeliveryDate
            // 
            lblDeliveryDate.AutoSize = true;
            lblDeliveryDate.Location = new Point(880, 44);
            lblDeliveryDate.Name = "lblDeliveryDate";
            lblDeliveryDate.Size = new Size(64, 18);
            lblDeliveryDate.TabIndex = 14;
            lblDeliveryDate.Text = "交貨日期";
            // 
            // txtDeliveryDate
            // 
            txtDeliveryDate.BackColor = Color.WhiteSmoke;
            txtDeliveryDate.Location = new Point(954, 40);
            txtDeliveryDate.Name = "txtDeliveryDate";
            txtDeliveryDate.ReadOnly = true;
            txtDeliveryDate.Size = new Size(200, 25);
            txtDeliveryDate.TabIndex = 15;
            // 
            // lblMachineName
            // 
            lblMachineName.AutoSize = true;
            lblMachineName.Location = new Point(10, 76);
            lblMachineName.Name = "lblMachineName";
            lblMachineName.Size = new Size(64, 18);
            lblMachineName.TabIndex = 16;
            lblMachineName.Text = "機台名稱";
            // 
            // txtMachineName
            // 
            txtMachineName.BackColor = Color.WhiteSmoke;
            txtMachineName.Location = new Point(84, 72);
            txtMachineName.Name = "txtMachineName";
            txtMachineName.ReadOnly = true;
            txtMachineName.Size = new Size(480, 25);
            txtMachineName.TabIndex = 17;
            // 
            // panel2
            // 
            panel2.AutoScroll = true;
            panel2.Controls.Add(dataGridView5);
            panel2.Controls.Add(panelElectricTitle);
            panel2.Controls.Add(dataGridView4);
            panel2.Controls.Add(panelModuleTitle);
            panel2.Controls.Add(dataGridView3);
            panel2.Controls.Add(panelProcessTitle);
            panel2.Controls.Add(dataGridView2);
            panel2.Controls.Add(panelPurchaseTitle);
            panel2.Controls.Add(dataGridView1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 180);
            panel2.Name = "panel2";
            panel2.Size = new Size(1900, 1059);
            panel2.TabIndex = 2;
            // 
            // dataGridView5
            // 
            dataGridView5.AllowUserToAddRows = false;
            dataGridView5.AllowUserToDeleteRows = false;
            dataGridView5.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView5.BackgroundColor = Color.White;
            dataGridView5.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView5.Columns.AddRange(new DataGridViewColumn[] { colECProcess, colECDesc, colECPerson, colECStartDate, colECPlannedFinishDate, colECActualFinishDate });
            dataGridView5.Dock = DockStyle.Top;
            dataGridView5.Font = new Font("微軟正黑體", 9F);
            dataGridView5.Location = new Point(0, 874);
            dataGridView5.Name = "dataGridView5";
            dataGridView5.ReadOnly = true;
            dataGridView5.RowHeadersVisible = false;
            dataGridView5.RowTemplate.Height = 26;
            dataGridView5.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView5.Size = new Size(1900, 150);
            dataGridView5.TabIndex = 8;
            // 
            // colECProcess
            // 
            colECProcess.HeaderText = "電控工序";
            colECProcess.Name = "colECProcess";
            colECProcess.ReadOnly = true;
            // 
            // colECDesc
            // 
            colECDesc.FillWeight = 200F;
            colECDesc.HeaderText = "簡要描述";
            colECDesc.Name = "colECDesc";
            colECDesc.ReadOnly = true;
            // 
            // colECPerson
            // 
            colECPerson.HeaderText = "程控人員";
            colECPerson.Name = "colECPerson";
            colECPerson.ReadOnly = true;
            // 
            // colECStartDate
            // 
            colECStartDate.HeaderText = "開始作業日期";
            colECStartDate.Name = "colECStartDate";
            colECStartDate.ReadOnly = true;
            // 
            // colECPlannedFinishDate
            // 
            colECPlannedFinishDate.HeaderText = "預計完成日期";
            colECPlannedFinishDate.Name = "colECPlannedFinishDate";
            colECPlannedFinishDate.ReadOnly = true;
            // 
            // colECActualFinishDate
            // 
            colECActualFinishDate.HeaderText = "實際完成日期";
            colECActualFinishDate.Name = "colECActualFinishDate";
            colECActualFinishDate.ReadOnly = true;
            // 
            // panelElectricTitle
            // 
            panelElectricTitle.BackColor = Color.LightSalmon;
            panelElectricTitle.Controls.Add(lblElectricTitle);
            panelElectricTitle.Dock = DockStyle.Top;
            panelElectricTitle.Location = new Point(0, 848);
            panelElectricTitle.Name = "panelElectricTitle";
            panelElectricTitle.Size = new Size(1900, 26);
            panelElectricTitle.TabIndex = 7;
            // 
            // lblElectricTitle
            // 
            lblElectricTitle.AutoSize = true;
            lblElectricTitle.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            lblElectricTitle.Location = new Point(8, 4);
            lblElectricTitle.Name = "lblElectricTitle";
            lblElectricTitle.Size = new Size(55, 16);
            lblElectricTitle.TabIndex = 0;
            lblElectricTitle.Text = "電控排程";
            // 
            // dataGridView4
            // 
            dataGridView4.AllowUserToAddRows = false;
            dataGridView4.AllowUserToDeleteRows = false;
            dataGridView4.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView4.BackgroundColor = Color.White;
            dataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView4.Columns.AddRange(new DataGridViewColumn[] { colMUModule, colMUModuleName, colMUDrawingFile, colMUIssueDate, colMUAssemblyPerson, colMUStartDate, colMUPreDeliveryDate, colMUFinishDate, colMUCloseReport, colMUPurpose });
            dataGridView4.Dock = DockStyle.Top;
            dataGridView4.Font = new Font("微軟正黑體", 9F);
            dataGridView4.Location = new Point(0, 698);
            dataGridView4.Name = "dataGridView4";
            dataGridView4.ReadOnly = true;
            dataGridView4.RowHeadersVisible = false;
            dataGridView4.RowTemplate.Height = 26;
            dataGridView4.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView4.Size = new Size(1900, 150);
            dataGridView4.TabIndex = 6;
            // 
            // colMUModule
            // 
            colMUModule.HeaderText = "模組";
            colMUModule.Name = "colMUModule";
            colMUModule.ReadOnly = true;
            // 
            // colMUModuleName
            // 
            colMUModuleName.FillWeight = 150F;
            colMUModuleName.HeaderText = "模組名稱";
            colMUModuleName.Name = "colMUModuleName";
            colMUModuleName.ReadOnly = true;
            // 
            // colMUDrawingFile
            // 
            colMUDrawingFile.FillWeight = 200F;
            colMUDrawingFile.HeaderText = "製圖檔名(或測試作業名稱)";
            colMUDrawingFile.Name = "colMUDrawingFile";
            colMUDrawingFile.ReadOnly = true;
            // 
            // colMUIssueDate
            // 
            colMUIssueDate.HeaderText = "圖檔發行日";
            colMUIssueDate.Name = "colMUIssueDate";
            colMUIssueDate.ReadOnly = true;
            // 
            // colMUAssemblyPerson
            // 
            colMUAssemblyPerson.HeaderText = "組測人員";
            colMUAssemblyPerson.Name = "colMUAssemblyPerson";
            colMUAssemblyPerson.ReadOnly = true;
            // 
            // colMUStartDate
            // 
            colMUStartDate.HeaderText = "開工日期";
            colMUStartDate.Name = "colMUStartDate";
            colMUStartDate.ReadOnly = true;
            // 
            // colMUPreDeliveryDate
            // 
            colMUPreDeliveryDate.HeaderText = "預交日期";
            colMUPreDeliveryDate.Name = "colMUPreDeliveryDate";
            colMUPreDeliveryDate.ReadOnly = true;
            // 
            // colMUFinishDate
            // 
            colMUFinishDate.HeaderText = "完工日期";
            colMUFinishDate.Name = "colMUFinishDate";
            colMUFinishDate.ReadOnly = true;
            // 
            // colMUCloseReport
            // 
            colMUCloseReport.HeaderText = "結案回報";
            colMUCloseReport.Name = "colMUCloseReport";
            colMUCloseReport.ReadOnly = true;
            // 
            // colMUPurpose
            // 
            colMUPurpose.HeaderText = "維修用途";
            colMUPurpose.Name = "colMUPurpose";
            colMUPurpose.ReadOnly = true;
            // 
            // panelModuleTitle
            // 
            panelModuleTitle.BackColor = Color.Aquamarine;
            panelModuleTitle.Controls.Add(lblModuleTitle);
            panelModuleTitle.Dock = DockStyle.Top;
            panelModuleTitle.Location = new Point(0, 672);
            panelModuleTitle.Name = "panelModuleTitle";
            panelModuleTitle.Size = new Size(1900, 26);
            panelModuleTitle.TabIndex = 5;
            panelModuleTitle.Click += panelModuleTitle_Click;
            //
            // lblModuleTitle
            //
            lblModuleTitle.AutoSize = true;
            lblModuleTitle.Cursor = Cursors.Hand;
            lblModuleTitle.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            lblModuleTitle.Location = new Point(8, 4);
            lblModuleTitle.Name = "lblModuleTitle";
            lblModuleTitle.Size = new Size(55, 16);
            lblModuleTitle.TabIndex = 0;
            lblModuleTitle.Text = "組測進度";
            lblModuleTitle.Click += panelModuleTitle_Click;
            // 
            // dataGridView3
            // 
            dataGridView3.AllowUserToAddRows = false;
            dataGridView3.AllowUserToDeleteRows = false;
            dataGridView3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView3.BackgroundColor = Color.White;
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Columns.AddRange(new DataGridViewColumn[] { colPS3Module, colPS3PartNo, colPS3PartName, colPS3Unit1, colPS3Start1, colPS3Finish1, colPS3Unit2, colPS3Start2, colPS3Finish2, colPS3Unit3, colPS3Start3, colPS3Finish3, colPS3Unit4, colPS3Start4, colPS3Finish4, colPS3Unit5, colPS3Start5, colPS3Finish5 });
            dataGridView3.Dock = DockStyle.Top;
            dataGridView3.Font = new Font("微軟正黑體", 9F);
            dataGridView3.Location = new Point(0, 492);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.ReadOnly = true;
            dataGridView3.RowHeadersVisible = false;
            dataGridView3.RowTemplate.Height = 26;
            dataGridView3.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView3.Size = new Size(1900, 180);
            dataGridView3.TabIndex = 4;
            // 
            // colPS3Module
            // 
            colPS3Module.HeaderText = "模組";
            colPS3Module.Name = "colPS3Module";
            colPS3Module.ReadOnly = true;
            // 
            // colPS3PartNo
            // 
            colPS3PartNo.HeaderText = "零件號碼";
            colPS3PartNo.Name = "colPS3PartNo";
            colPS3PartNo.ReadOnly = true;
            // 
            // colPS3PartName
            // 
            colPS3PartName.FillWeight = 140F;
            colPS3PartName.HeaderText = "品名";
            colPS3PartName.Name = "colPS3PartName";
            colPS3PartName.ReadOnly = true;
            // 
            // colPS3Unit1
            // 
            colPS3Unit1.HeaderText = "機械加工";
            colPS3Unit1.Name = "colPS3Unit1";
            colPS3Unit1.ReadOnly = true;
            // 
            // colPS3Start1
            // 
            colPS3Start1.HeaderText = "開工日期1";
            colPS3Start1.Name = "colPS3Start1";
            colPS3Start1.ReadOnly = true;
            // 
            // colPS3Finish1
            // 
            colPS3Finish1.HeaderText = "完工日期1";
            colPS3Finish1.Name = "colPS3Finish1";
            colPS3Finish1.ReadOnly = true;
            // 
            // colPS3Unit2
            // 
            colPS3Unit2.HeaderText = "特殊塑型";
            colPS3Unit2.Name = "colPS3Unit2";
            colPS3Unit2.ReadOnly = true;
            // 
            // colPS3Start2
            // 
            colPS3Start2.HeaderText = "開工日期2";
            colPS3Start2.Name = "colPS3Start2";
            colPS3Start2.ReadOnly = true;
            // 
            // colPS3Finish2
            // 
            colPS3Finish2.HeaderText = "完工日期2";
            colPS3Finish2.Name = "colPS3Finish2";
            colPS3Finish2.ReadOnly = true;
            // 
            // colPS3Unit3
            // 
            colPS3Unit3.HeaderText = "精密加工";
            colPS3Unit3.Name = "colPS3Unit3";
            colPS3Unit3.ReadOnly = true;
            // 
            // colPS3Start3
            // 
            colPS3Start3.HeaderText = "開工日期3";
            colPS3Start3.Name = "colPS3Start3";
            colPS3Start3.ReadOnly = true;
            // 
            // colPS3Finish3
            // 
            colPS3Finish3.HeaderText = "完工日期3";
            colPS3Finish3.Name = "colPS3Finish3";
            colPS3Finish3.ReadOnly = true;
            // 
            // colPS3Unit4
            // 
            colPS3Unit4.HeaderText = "防變形";
            colPS3Unit4.Name = "colPS3Unit4";
            colPS3Unit4.ReadOnly = true;
            // 
            // colPS3Start4
            // 
            colPS3Start4.HeaderText = "開工日期4";
            colPS3Start4.Name = "colPS3Start4";
            colPS3Start4.ReadOnly = true;
            // 
            // colPS3Finish4
            // 
            colPS3Finish4.HeaderText = "完工日期4";
            colPS3Finish4.Name = "colPS3Finish4";
            colPS3Finish4.ReadOnly = true;
            // 
            // colPS3Unit5
            // 
            colPS3Unit5.HeaderText = "表面處理";
            colPS3Unit5.Name = "colPS3Unit5";
            colPS3Unit5.ReadOnly = true;
            // 
            // colPS3Start5
            // 
            colPS3Start5.HeaderText = "開工日期5";
            colPS3Start5.Name = "colPS3Start5";
            colPS3Start5.ReadOnly = true;
            // 
            // colPS3Finish5
            // 
            colPS3Finish5.HeaderText = "完工日期5";
            colPS3Finish5.Name = "colPS3Finish5";
            colPS3Finish5.ReadOnly = true;
            // 
            // panelProcessTitle
            // 
            panelProcessTitle.BackColor = Color.LightGreen;
            panelProcessTitle.Controls.Add(lblProcessTitle);
            panelProcessTitle.Dock = DockStyle.Top;
            panelProcessTitle.Location = new Point(0, 466);
            panelProcessTitle.Name = "panelProcessTitle";
            panelProcessTitle.Size = new Size(1900, 26);
            panelProcessTitle.TabIndex = 3;
            // 
            // lblProcessTitle
            // 
            lblProcessTitle.AutoSize = true;
            lblProcessTitle.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            lblProcessTitle.Location = new Point(8, 4);
            lblProcessTitle.Name = "lblProcessTitle";
            lblProcessTitle.Size = new Size(55, 16);
            lblProcessTitle.TabIndex = 0;
            lblProcessTitle.Text = "加工排程";
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.BackgroundColor = Color.White;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { colPPModule, colPPPartNo, colPPPartName, colPPDesc, colPPQty, colPPPartType, colPPBuyer, colPPActualDate, colPPExpectedDate, colPPStockInDate, colPPControlNo });
            dataGridView2.Dock = DockStyle.Top;
            dataGridView2.Font = new Font("微軟正黑體", 9F);
            dataGridView2.Location = new Point(0, 266);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.RowHeadersVisible = false;
            dataGridView2.RowTemplate.Height = 26;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.Size = new Size(1900, 200);
            dataGridView2.TabIndex = 2;
            // 
            // colPPModule
            // 
            colPPModule.FillWeight = 90F;
            colPPModule.HeaderText = "模組";
            colPPModule.Name = "colPPModule";
            colPPModule.ReadOnly = true;
            // 
            // colPPPartNo
            // 
            colPPPartNo.HeaderText = "零件號碼";
            colPPPartNo.Name = "colPPPartNo";
            colPPPartNo.ReadOnly = true;
            // 
            // colPPPartName
            // 
            colPPPartName.FillWeight = 140F;
            colPPPartName.HeaderText = "品名";
            colPPPartName.Name = "colPPPartName";
            colPPPartName.ReadOnly = true;
            // 
            // colPPDesc
            // 
            colPPDesc.FillWeight = 160F;
            colPPDesc.HeaderText = "描述";
            colPPDesc.Name = "colPPDesc";
            colPPDesc.ReadOnly = true;
            // 
            // colPPQty
            // 
            colPPQty.FillWeight = 70F;
            colPPQty.HeaderText = "數量";
            colPPQty.Name = "colPPQty";
            colPPQty.ReadOnly = true;
            // 
            // colPPPartType
            // 
            colPPPartType.HeaderText = "零件分類";
            colPPPartType.Name = "colPPPartType";
            colPPPartType.ReadOnly = true;
            // 
            // colPPBuyer
            // 
            colPPBuyer.FillWeight = 90F;
            colPPBuyer.HeaderText = "採購人員";
            colPPBuyer.Name = "colPPBuyer";
            colPPBuyer.ReadOnly = true;
            // 
            // colPPActualDate
            // 
            colPPActualDate.HeaderText = "實際採購日";
            colPPActualDate.Name = "colPPActualDate";
            colPPActualDate.ReadOnly = true;
            // 
            // colPPExpectedDate
            // 
            colPPExpectedDate.HeaderText = "預計到貨日";
            colPPExpectedDate.Name = "colPPExpectedDate";
            colPPExpectedDate.ReadOnly = true;
            // 
            // colPPStockInDate
            // 
            colPPStockInDate.HeaderText = "入庫移轉日";
            colPPStockInDate.Name = "colPPStockInDate";
            colPPStockInDate.ReadOnly = true;
            // 
            // colPPControlNo
            // 
            colPPControlNo.FillWeight = 110F;
            colPPControlNo.HeaderText = "零件管制單號";
            colPPControlNo.Name = "colPPControlNo";
            colPPControlNo.ReadOnly = true;
            // 
            // panelPurchaseTitle
            // 
            panelPurchaseTitle.BackColor = Color.LightSteelBlue;
            panelPurchaseTitle.Controls.Add(lblPurchaseTitle);
            panelPurchaseTitle.Dock = DockStyle.Top;
            panelPurchaseTitle.Location = new Point(0, 240);
            panelPurchaseTitle.Name = "panelPurchaseTitle";
            panelPurchaseTitle.Size = new Size(1900, 26);
            panelPurchaseTitle.TabIndex = 1;
            // 
            // lblPurchaseTitle
            // 
            lblPurchaseTitle.AutoSize = true;
            lblPurchaseTitle.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            lblPurchaseTitle.Location = new Point(8, 4);
            lblPurchaseTitle.Name = "lblPurchaseTitle";
            lblPurchaseTitle.Size = new Size(55, 16);
            lblPurchaseTitle.TabIndex = 0;
            lblPurchaseTitle.Text = "採購進度";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colModuleCode, colModuleName, colDesigner, colDesignType, colDrawingFile, colActualStart, colPlannedFinish, colDrawingIssueDate, colReviewPass, colListNo });
            dataGridView1.Dock = DockStyle.Top;
            dataGridView1.Font = new Font("微軟正黑體", 9F);
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 26;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1900, 240);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            //
            // colModuleCode
            // 
            colModuleCode.HeaderText = "模組編碼";
            colModuleCode.Name = "colModuleCode";
            colModuleCode.ReadOnly = true;
            // 
            // colModuleName
            // 
            colModuleName.FillWeight = 150F;
            colModuleName.HeaderText = "模組名稱";
            colModuleName.Name = "colModuleName";
            colModuleName.ReadOnly = true;
            // 
            // colDesigner
            // 
            colDesigner.FillWeight = 90F;
            colDesigner.HeaderText = "設計人員";
            colDesigner.Name = "colDesigner";
            colDesigner.ReadOnly = true;
            // 
            // colDesignType
            // 
            colDesignType.FillWeight = 90F;
            colDesignType.HeaderText = "設計圖類";
            colDesignType.Name = "colDesignType";
            colDesignType.ReadOnly = true;
            // 
            // colDrawingFile
            // 
            colDrawingFile.FillWeight = 150F;
            colDrawingFile.HeaderText = "製圖檔名";
            colDrawingFile.Name = "colDrawingFile";
            colDrawingFile.ReadOnly = true;
            // 
            // colActualStart
            // 
            colActualStart.FillWeight = 110F;
            colActualStart.HeaderText = "實際開工日";
            colActualStart.Name = "colActualStart";
            colActualStart.ReadOnly = true;
            // 
            // colPlannedFinish
            // 
            colPlannedFinish.FillWeight = 110F;
            colPlannedFinish.HeaderText = "預計完工日";
            colPlannedFinish.Name = "colPlannedFinish";
            colPlannedFinish.ReadOnly = true;
            // 
            // colDrawingIssueDate
            // 
            colDrawingIssueDate.FillWeight = 110F;
            colDrawingIssueDate.HeaderText = "圖檔發行日";
            colDrawingIssueDate.Name = "colDrawingIssueDate";
            colDrawingIssueDate.ReadOnly = true;
            // 
            // colReviewPass
            // 
            colReviewPass.FillWeight = 90F;
            colReviewPass.HeaderText = "審圖通過";
            colReviewPass.Name = "colReviewPass";
            colReviewPass.ReadOnly = true;
            // 
            // colListNo
            // 
            colListNo.FillWeight = 110F;
            colListNo.HeaderText = "設計審查清單";
            colListNo.Name = "colListNo";
            colListNo.ReadOnly = true;
            // 
            // ProjectProgressDetailControl
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panelHeader);
            Controls.Add(panel1);
            Font = new Font("微軟正黑體", 10F);
            Margin = new Padding(4);
            Name = "ProjectProgressDetailControl";
            Size = new Size(1900, 1239);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView5).EndInit();
            panelElectricTitle.ResumeLayout(false);
            panelElectricTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).EndInit();
            panelModuleTitle.ResumeLayout(false);
            panelModuleTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            panelProcessTitle.ResumeLayout(false);
            panelProcessTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            panelPurchaseTitle.ResumeLayout(false);
            panelPurchaseTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblTitle;
        private Button btnOverview;
        private Button btnClose;
        private Panel panelHeader;
        private Label lblProjectNo;
        private TextBox txtProjectNo;
        private Label lblOrderDate;
        private TextBox txtOrderDate;
        private Label lblCustShort;
        private TextBox txtCustShort;
        private Label lblCustName;
        private TextBox txtCustName;
        private Label lblMachineModel;
        private TextBox txtMachineModel;
        private Label lblMachineType;
        private TextBox txtMachineType;
        private Label lblInspectDate;
        private TextBox txtInspectDate;
        private Label lblDeliveryDate;
        private TextBox txtDeliveryDate;
        private Label lblMachineName;
        private TextBox txtMachineName;
        private Panel panel2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn colModuleCode;
        private DataGridViewTextBoxColumn colModuleName;
        private DataGridViewTextBoxColumn colDesigner;
        private DataGridViewTextBoxColumn colDesignType;
        private DataGridViewTextBoxColumn colDrawingFile;
        private DataGridViewTextBoxColumn colActualStart;
        private DataGridViewTextBoxColumn colPlannedFinish;
        private DataGridViewTextBoxColumn colDrawingIssueDate;
        private DataGridViewTextBoxColumn colReviewPass;
        private DataGridViewTextBoxColumn colListNo;
        private Panel panelPurchaseTitle;
        private Label lblPurchaseTitle;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn colPPModule;
        private DataGridViewTextBoxColumn colPPPartNo;
        private DataGridViewTextBoxColumn colPPPartName;
        private DataGridViewTextBoxColumn colPPDesc;
        private DataGridViewTextBoxColumn colPPQty;
        private DataGridViewTextBoxColumn colPPPartType;
        private DataGridViewTextBoxColumn colPPBuyer;
        private DataGridViewTextBoxColumn colPPActualDate;
        private DataGridViewTextBoxColumn colPPExpectedDate;
        private DataGridViewTextBoxColumn colPPStockInDate;
        private DataGridViewTextBoxColumn colPPControlNo;
        private Label label1;
        private Panel panelProcessTitle;
        private Label lblProcessTitle;
        private DataGridView dataGridView3;
        private DataGridViewTextBoxColumn colPS3Module;
        private DataGridViewTextBoxColumn colPS3PartNo;
        private DataGridViewTextBoxColumn colPS3PartName;
        private DataGridViewTextBoxColumn colPS3Unit1;
        private DataGridViewTextBoxColumn colPS3Start1;
        private DataGridViewTextBoxColumn colPS3Finish1;
        private DataGridViewTextBoxColumn colPS3Unit2;
        private DataGridViewTextBoxColumn colPS3Start2;
        private DataGridViewTextBoxColumn colPS3Finish2;
        private DataGridViewTextBoxColumn colPS3Unit3;
        private DataGridViewTextBoxColumn colPS3Start3;
        private DataGridViewTextBoxColumn colPS3Finish3;
        private DataGridViewTextBoxColumn colPS3Unit4;
        private DataGridViewTextBoxColumn colPS3Start4;
        private DataGridViewTextBoxColumn colPS3Finish4;
        private DataGridViewTextBoxColumn colPS3Unit5;
        private DataGridViewTextBoxColumn colPS3Start5;
        private DataGridViewTextBoxColumn colPS3Finish5;
        private Panel panelModuleTitle;
        private Label lblModuleTitle;
        private DataGridView dataGridView4;
        private DataGridViewTextBoxColumn colMUModule;
        private DataGridViewTextBoxColumn colMUModuleName;
        private DataGridViewTextBoxColumn colMUDrawingFile;
        private DataGridViewTextBoxColumn colMUIssueDate;
        private DataGridViewTextBoxColumn colMUAssemblyPerson;
        private DataGridViewTextBoxColumn colMUStartDate;
        private DataGridViewTextBoxColumn colMUPreDeliveryDate;
        private DataGridViewTextBoxColumn colMUFinishDate;
        private DataGridViewTextBoxColumn colMUCloseReport;
        private DataGridViewTextBoxColumn colMUPurpose;
        private Panel panelElectricTitle;
        private Label lblElectricTitle;
        private DataGridView dataGridView5;
        private DataGridViewTextBoxColumn colECProcess;
        private DataGridViewTextBoxColumn colECDesc;
        private DataGridViewTextBoxColumn colECPerson;
        private DataGridViewTextBoxColumn colECStartDate;
        private DataGridViewTextBoxColumn colECPlannedFinishDate;
        private DataGridViewTextBoxColumn colECActualFinishDate;
    }
}
