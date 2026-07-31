using System.Drawing;
using System.Windows.Forms;

namespace DigiERP.UserControl.Production.MiscControlReport
{
    partial class MiscControlOrderControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MiscControlOrderControl));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            lblTitle = new Label();
            btnDelete = new Button();
            btnModify = new Button();
            btnSave = new Button();
            btnActivate = new Button();
            btnCancelActivate = new Button();
            btnOverview = new Button();
            btnClose = new Button();
            panel2 = new Panel();
            lblControlNo = new Label();
            txtControlNo = new TextBox();
            lblStockInDate = new Label();
            txtStockInDate = new TextBox();
            lblPartNo = new Label();
            txtPartNo = new TextBox();
            lblNote = new Label();
            lblProjectNo = new Label();
            txtProjectNo = new TextBox();
            lblAcceptDate = new Label();
            txtAcceptDate = new TextBox();
            lblPartName = new Label();
            txtPartName = new TextBox();
            lblModuleCode = new Label();
            txtModuleCode = new TextBox();
            lblAcceptStaff = new Label();
            cboAcceptStaff = new ComboBox();
            lblDesc = new Label();
            txtDesc = new TextBox();
            lblModuleName = new Label();
            txtModuleName = new TextBox();
            lblWarehouseStaff = new Label();
            cboWarehouseStaff = new ComboBox();
            lblQty = new Label();
            txtQty = new TextBox();
            lblAcceptResult = new Label();
            cboAcceptResult = new ComboBox();
            splitContainer1 = new SplitContainer();
            dataGridView1 = new DataGridView();
            colProcessType = new DataGridViewTextBoxColumn();
            colWorkStation = new DataGridViewComboBoxColumn();
            colProductionUnit = new DataGridViewComboBoxColumn();
            colOperator = new DataGridViewComboBoxColumn();
            colStartDate = new DigiERP.Common.DataGridViewDateTimePickerColumn();
            colDueDate = new DigiERP.Common.DataGridViewDateTimePickerColumn();
            colFinishDate = new DigiERP.Common.DataGridViewDateTimePickerColumn();
            colFinishQty = new DigiERP.Common.DataGridViewNumericUpDownColumn();
            lblProcessTitle = new Label();
            dataGridView2 = new DataGridView();
            colCheckDate = new DigiERP.Common.DataGridViewDateTimePickerColumn();
            colChecker = new DataGridViewComboBoxColumn();
            colSizeSpec = new DataGridViewComboBoxColumn();
            colGeoSpec = new DataGridViewComboBoxColumn();
            colMaterialSpec = new DataGridViewComboBoxColumn();
            colSurfaceSpec = new DataGridViewComboBoxColumn();
            colHardnessSpec = new DataGridViewComboBoxColumn();
            colBurrTrim = new DataGridViewComboBoxColumn();
            colMicroCrack = new DataGridViewComboBoxColumn();
            panelNote = new Panel();
            lblReasonCap = new Label();
            txtReasonNote = new TextBox();
            lblInspectTitle = new Label();
            panel4 = new Panel();
            lblApproverCap = new Label();
            txtApprover = new TextBox();
            lblApproveDateCap = new Label();
            txtApproveDate = new TextBox();
            lblModifierCap = new Label();
            txtModifier = new TextBox();
            lblModifyDateCap = new Label();
            txtModifyDate = new TextBox();
            lblCreatorCap = new Label();
            txtCreator = new TextBox();
            lblCreateDateCap = new Label();
            txtCreateDate = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            panelNote.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Honeydew;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(lblTitle);
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(btnModify);
            panel1.Controls.Add(btnSave);
            panel1.Controls.Add(btnActivate);
            panel1.Controls.Add(btnCancelActivate);
            panel1.Controls.Add(btnOverview);
            panel1.Controls.Add(btnClose);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1900, 56);
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
            lblTitle.Size = new Size(136, 23);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "零件管制報告書";
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Firebrick;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(340, 12);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(98, 32);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "刪除紀錄";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnModify
            // 
            btnModify.BackColor = Color.Gainsboro;
            btnModify.FlatStyle = FlatStyle.Flat;
            btnModify.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            btnModify.Location = new Point(444, 12);
            btnModify.Name = "btnModify";
            btnModify.Size = new Size(98, 32);
            btnModify.TabIndex = 2;
            btnModify.Text = "修改";
            btnModify.UseVisualStyleBackColor = false;
            btnModify.Click += btnModify_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Gainsboro;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            btnSave.Location = new Point(548, 12);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(98, 32);
            btnSave.TabIndex = 3;
            btnSave.Text = "儲存";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnActivate
            // 
            btnActivate.BackColor = Color.Gainsboro;
            btnActivate.FlatStyle = FlatStyle.Flat;
            btnActivate.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            btnActivate.Location = new Point(652, 12);
            btnActivate.Name = "btnActivate";
            btnActivate.Size = new Size(98, 32);
            btnActivate.TabIndex = 4;
            btnActivate.Text = "生效";
            btnActivate.UseVisualStyleBackColor = false;
            btnActivate.Click += btnActivate_Click;
            // 
            // btnCancelActivate
            // 
            btnCancelActivate.BackColor = Color.Gainsboro;
            btnCancelActivate.FlatStyle = FlatStyle.Flat;
            btnCancelActivate.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            btnCancelActivate.Location = new Point(756, 12);
            btnCancelActivate.Name = "btnCancelActivate";
            btnCancelActivate.Size = new Size(98, 32);
            btnCancelActivate.TabIndex = 5;
            btnCancelActivate.Text = "取消生效";
            btnCancelActivate.UseVisualStyleBackColor = false;
            btnCancelActivate.Click += btnCancelActivate_Click;
            // 
            // btnOverview
            // 
            btnOverview.BackColor = Color.Gainsboro;
            btnOverview.FlatStyle = FlatStyle.Flat;
            btnOverview.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            btnOverview.Location = new Point(860, 12);
            btnOverview.Name = "btnOverview";
            btnOverview.Size = new Size(98, 32);
            btnOverview.TabIndex = 6;
            btnOverview.Text = "總覽";
            btnOverview.UseVisualStyleBackColor = false;
            btnOverview.Click += btnOverview_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Gainsboro;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            btnClose.Location = new Point(964, 12);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(98, 32);
            btnClose.TabIndex = 7;
            btnClose.Text = "關閉";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Honeydew;
            panel2.Controls.Add(lblControlNo);
            panel2.Controls.Add(txtControlNo);
            panel2.Controls.Add(lblStockInDate);
            panel2.Controls.Add(txtStockInDate);
            panel2.Controls.Add(lblPartNo);
            panel2.Controls.Add(txtPartNo);
            panel2.Controls.Add(lblNote);
            panel2.Controls.Add(lblProjectNo);
            panel2.Controls.Add(txtProjectNo);
            panel2.Controls.Add(lblAcceptDate);
            panel2.Controls.Add(txtAcceptDate);
            panel2.Controls.Add(lblPartName);
            panel2.Controls.Add(txtPartName);
            panel2.Controls.Add(lblModuleCode);
            panel2.Controls.Add(txtModuleCode);
            panel2.Controls.Add(lblAcceptStaff);
            panel2.Controls.Add(cboAcceptStaff);
            panel2.Controls.Add(lblDesc);
            panel2.Controls.Add(txtDesc);
            panel2.Controls.Add(lblModuleName);
            panel2.Controls.Add(txtModuleName);
            panel2.Controls.Add(lblWarehouseStaff);
            panel2.Controls.Add(cboWarehouseStaff);
            panel2.Controls.Add(lblQty);
            panel2.Controls.Add(txtQty);
            panel2.Controls.Add(lblAcceptResult);
            panel2.Controls.Add(cboAcceptResult);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 56);
            panel2.Name = "panel2";
            panel2.Size = new Size(1900, 160);
            panel2.TabIndex = 1;
            // 
            // lblControlNo
            // 
            lblControlNo.AutoSize = true;
            lblControlNo.Location = new Point(8, 12);
            lblControlNo.Name = "lblControlNo";
            lblControlNo.Size = new Size(92, 18);
            lblControlNo.TabIndex = 0;
            lblControlNo.Text = "零件管制單號";
            // 
            // txtControlNo
            // 
            txtControlNo.Location = new Point(100, 8);
            txtControlNo.Name = "txtControlNo";
            txtControlNo.ReadOnly = true;
            txtControlNo.Size = new Size(160, 25);
            txtControlNo.TabIndex = 1;
            // 
            // lblStockInDate
            // 
            lblStockInDate.AutoSize = true;
            lblStockInDate.Location = new Point(280, 12);
            lblStockInDate.Name = "lblStockInDate";
            lblStockInDate.Size = new Size(78, 18);
            lblStockInDate.TabIndex = 2;
            lblStockInDate.Text = "入庫移轉日";
            // 
            // txtStockInDate
            // 
            txtStockInDate.Location = new Point(372, 8);
            txtStockInDate.Name = "txtStockInDate";
            txtStockInDate.ReadOnly = true;
            txtStockInDate.Size = new Size(160, 25);
            txtStockInDate.TabIndex = 3;
            // 
            // lblPartNo
            // 
            lblPartNo.AutoSize = true;
            lblPartNo.Location = new Point(552, 12);
            lblPartNo.Name = "lblPartNo";
            lblPartNo.Size = new Size(64, 18);
            lblPartNo.TabIndex = 4;
            lblPartNo.Text = "零件號碼";
            // 
            // txtPartNo
            // 
            txtPartNo.Location = new Point(644, 8);
            txtPartNo.Name = "txtPartNo";
            txtPartNo.ReadOnly = true;
            txtPartNo.Size = new Size(300, 25);
            txtPartNo.TabIndex = 5;
            // 
            // lblNote
            // 
            lblNote.ForeColor = Color.Red;
            lblNote.Location = new Point(1220, 4);
            lblNote.Name = "lblNote";
            lblNote.Size = new Size(408, 148);
            lblNote.TabIndex = 6;
            lblNote.Text = "※驗收結果如選擇『轉設計變更』時，請務必請主管按生效，以自動開立「異常矯正措施報告」。";
            // 
            // lblProjectNo
            // 
            lblProjectNo.AutoSize = true;
            lblProjectNo.Location = new Point(8, 48);
            lblProjectNo.Name = "lblProjectNo";
            lblProjectNo.Size = new Size(64, 18);
            lblProjectNo.TabIndex = 7;
            lblProjectNo.Text = "專案序號";
            // 
            // txtProjectNo
            // 
            txtProjectNo.Location = new Point(100, 44);
            txtProjectNo.Name = "txtProjectNo";
            txtProjectNo.ReadOnly = true;
            txtProjectNo.Size = new Size(160, 25);
            txtProjectNo.TabIndex = 8;
            // 
            // lblAcceptDate
            // 
            lblAcceptDate.AutoSize = true;
            lblAcceptDate.Location = new Point(280, 48);
            lblAcceptDate.Name = "lblAcceptDate";
            lblAcceptDate.Size = new Size(64, 18);
            lblAcceptDate.TabIndex = 9;
            lblAcceptDate.Text = "驗收日期";
            // 
            // txtAcceptDate
            // 
            txtAcceptDate.Location = new Point(372, 44);
            txtAcceptDate.Name = "txtAcceptDate";
            txtAcceptDate.ReadOnly = true;
            txtAcceptDate.Size = new Size(160, 25);
            txtAcceptDate.TabIndex = 10;
            // 
            // lblPartName
            // 
            lblPartName.AutoSize = true;
            lblPartName.Location = new Point(552, 48);
            lblPartName.Name = "lblPartName";
            lblPartName.Size = new Size(36, 18);
            lblPartName.TabIndex = 11;
            lblPartName.Text = "品名";
            // 
            // txtPartName
            // 
            txtPartName.Location = new Point(644, 44);
            txtPartName.Name = "txtPartName";
            txtPartName.ReadOnly = true;
            txtPartName.Size = new Size(300, 25);
            txtPartName.TabIndex = 12;
            // 
            // lblModuleCode
            // 
            lblModuleCode.AutoSize = true;
            lblModuleCode.Location = new Point(8, 84);
            lblModuleCode.Name = "lblModuleCode";
            lblModuleCode.Size = new Size(64, 18);
            lblModuleCode.TabIndex = 13;
            lblModuleCode.Text = "模組編碼";
            // 
            // txtModuleCode
            // 
            txtModuleCode.Location = new Point(100, 80);
            txtModuleCode.Name = "txtModuleCode";
            txtModuleCode.ReadOnly = true;
            txtModuleCode.Size = new Size(160, 25);
            txtModuleCode.TabIndex = 14;
            // 
            // lblAcceptStaff
            // 
            lblAcceptStaff.AutoSize = true;
            lblAcceptStaff.Location = new Point(280, 84);
            lblAcceptStaff.Name = "lblAcceptStaff";
            lblAcceptStaff.Size = new Size(64, 18);
            lblAcceptStaff.TabIndex = 15;
            lblAcceptStaff.Text = "驗收人員";
            // 
            // cboAcceptStaff
            // 
            cboAcceptStaff.Enabled = false;
            cboAcceptStaff.FormattingEnabled = true;
            cboAcceptStaff.Location = new Point(372, 80);
            cboAcceptStaff.Name = "cboAcceptStaff";
            cboAcceptStaff.Size = new Size(160, 25);
            cboAcceptStaff.TabIndex = 16;
            // 
            // lblDesc
            // 
            lblDesc.AutoSize = true;
            lblDesc.Location = new Point(552, 84);
            lblDesc.Name = "lblDesc";
            lblDesc.Size = new Size(36, 18);
            lblDesc.TabIndex = 17;
            lblDesc.Text = "描述";
            // 
            // txtDesc
            // 
            txtDesc.Location = new Point(644, 80);
            txtDesc.Name = "txtDesc";
            txtDesc.ReadOnly = true;
            txtDesc.Size = new Size(300, 25);
            txtDesc.TabIndex = 18;
            // 
            // lblModuleName
            // 
            lblModuleName.AutoSize = true;
            lblModuleName.Location = new Point(8, 120);
            lblModuleName.Name = "lblModuleName";
            lblModuleName.Size = new Size(64, 18);
            lblModuleName.TabIndex = 19;
            lblModuleName.Text = "模組名稱";
            // 
            // txtModuleName
            // 
            txtModuleName.Location = new Point(100, 116);
            txtModuleName.Name = "txtModuleName";
            txtModuleName.ReadOnly = true;
            txtModuleName.Size = new Size(160, 25);
            txtModuleName.TabIndex = 20;
            // 
            // lblWarehouseStaff
            // 
            lblWarehouseStaff.AutoSize = true;
            lblWarehouseStaff.Location = new Point(280, 120);
            lblWarehouseStaff.Name = "lblWarehouseStaff";
            lblWarehouseStaff.Size = new Size(64, 18);
            lblWarehouseStaff.TabIndex = 21;
            lblWarehouseStaff.Text = "倉管人員";
            // 
            // cboWarehouseStaff
            // 
            cboWarehouseStaff.Enabled = false;
            cboWarehouseStaff.FormattingEnabled = true;
            cboWarehouseStaff.Location = new Point(372, 116);
            cboWarehouseStaff.Name = "cboWarehouseStaff";
            cboWarehouseStaff.Size = new Size(160, 25);
            cboWarehouseStaff.TabIndex = 22;
            // 
            // lblQty
            // 
            lblQty.AutoSize = true;
            lblQty.Location = new Point(552, 120);
            lblQty.Name = "lblQty";
            lblQty.Size = new Size(36, 18);
            lblQty.TabIndex = 23;
            lblQty.Text = "數量";
            // 
            // txtQty
            // 
            txtQty.Location = new Point(644, 116);
            txtQty.Name = "txtQty";
            txtQty.ReadOnly = true;
            txtQty.Size = new Size(140, 25);
            txtQty.TabIndex = 24;
            // 
            // lblAcceptResult
            // 
            lblAcceptResult.AutoSize = true;
            lblAcceptResult.Location = new Point(804, 120);
            lblAcceptResult.Name = "lblAcceptResult";
            lblAcceptResult.Size = new Size(64, 18);
            lblAcceptResult.TabIndex = 25;
            lblAcceptResult.Text = "驗收結果";
            // 
            // cboAcceptResult
            // 
            cboAcceptResult.Enabled = false;
            cboAcceptResult.FormattingEnabled = true;
            cboAcceptResult.Location = new Point(896, 116);
            cboAcceptResult.Name = "cboAcceptResult";
            cboAcceptResult.Size = new Size(160, 25);
            cboAcceptResult.TabIndex = 26;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 216);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(dataGridView1);
            splitContainer1.Panel1.Controls.Add(lblProcessTitle);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(dataGridView2);
            splitContainer1.Panel2.Controls.Add(panelNote);
            splitContainer1.Panel2.Controls.Add(lblInspectTitle);
            splitContainer1.Size = new Size(1900, 464);
            splitContainer1.SplitterDistance = 230;
            splitContainer1.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colProcessType, colWorkStation, colProductionUnit, colOperator, colStartDate, colDueDate, colFinishDate, colFinishQty });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Font = new Font("微軟正黑體", 9F);
            dataGridView1.Location = new Point(0, 26);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 26;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1900, 204);
            dataGridView1.TabIndex = 0;
            dataGridView1.DataError += dataGridView1_DataError;
            // 
            // colProcessType
            // 
            colProcessType.HeaderText = "製程別";
            colProcessType.Name = "colProcessType";
            colProcessType.ReadOnly = true;
            // 
            // colWorkStation
            // 
            colWorkStation.HeaderText = "工作站";
            colWorkStation.Name = "colWorkStation";
            //
            // colProductionUnit
            //
            colProductionUnit.HeaderText = "產製單位";
            colProductionUnit.Name = "colProductionUnit";
            //
            // colOperator
            //
            colOperator.HeaderText = "作業人員";
            colOperator.Name = "colOperator";
            //
            // colStartDate
            //
            colStartDate.HeaderText = "開工日期";
            colStartDate.Name = "colStartDate";
            //
            // colDueDate
            //
            colDueDate.HeaderText = "預交日期";
            colDueDate.Name = "colDueDate";
            //
            // colFinishDate
            //
            colFinishDate.HeaderText = "完工日期";
            colFinishDate.Name = "colFinishDate";
            //
            // colFinishQty
            //
            colFinishQty.HeaderText = "完工數量";
            colFinishQty.Name = "colFinishQty";
            // 
            // lblProcessTitle
            // 
            lblProcessTitle.BackColor = Color.Gainsboro;
            lblProcessTitle.Dock = DockStyle.Top;
            lblProcessTitle.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            lblProcessTitle.Location = new Point(0, 0);
            lblProcessTitle.Name = "lblProcessTitle";
            lblProcessTitle.Padding = new Padding(6, 4, 0, 4);
            lblProcessTitle.Size = new Size(1900, 26);
            lblProcessTitle.TabIndex = 1;
            lblProcessTitle.Text = "零件生產工序";
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = true;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.BackgroundColor = Color.White;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { colCheckDate, colChecker, colSizeSpec, colGeoSpec, colMaterialSpec, colSurfaceSpec, colHardnessSpec, colBurrTrim, colMicroCrack });
            dataGridView2.Dock = DockStyle.Fill;
            dataGridView2.Font = new Font("微軟正黑體", 9F);
            dataGridView2.Location = new Point(0, 26);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersVisible = false;
            dataGridView2.RowTemplate.Height = 26;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.Size = new Size(1900, 170);
            dataGridView2.TabIndex = 0;
            dataGridView2.CellClick += dataGridView2_CellClick;
            dataGridView2.DataError += dataGridView2_DataError;
            //
            // colCheckDate
            //
            colCheckDate.HeaderText = "檢查日期";
            colCheckDate.Name = "colCheckDate";
            //
            // colChecker
            //
            colChecker.HeaderText = "檢查人員";
            colChecker.Name = "colChecker";
            //
            // colSizeSpec
            //
            colSizeSpec.HeaderText = "尺寸精度";
            colSizeSpec.Name = "colSizeSpec";
            //
            // colGeoSpec
            //
            colGeoSpec.HeaderText = "幾何精度";
            colGeoSpec.Name = "colGeoSpec";
            //
            // colMaterialSpec
            //
            colMaterialSpec.HeaderText = "材質標準";
            colMaterialSpec.Name = "colMaterialSpec";
            //
            // colSurfaceSpec
            //
            colSurfaceSpec.HeaderText = "表面工藝";
            colSurfaceSpec.Name = "colSurfaceSpec";
            //
            // colHardnessSpec
            //
            colHardnessSpec.HeaderText = "硬度要求";
            colHardnessSpec.Name = "colHardnessSpec";
            //
            // colBurrTrim
            //
            colBurrTrim.HeaderText = "毛邊修整";
            colBurrTrim.Name = "colBurrTrim";
            //
            // colMicroCrack
            //
            colMicroCrack.HeaderText = "微觀裂痕";
            colMicroCrack.Name = "colMicroCrack";
            // 
            // panelNote
            // 
            panelNote.Controls.Add(lblReasonCap);
            panelNote.Controls.Add(txtReasonNote);
            panelNote.Dock = DockStyle.Bottom;
            panelNote.Location = new Point(0, 196);
            panelNote.Name = "panelNote";
            panelNote.Size = new Size(1900, 34);
            panelNote.TabIndex = 3;
            // 
            // lblReasonCap
            // 
            lblReasonCap.AutoSize = true;
            lblReasonCap.BackColor = Color.Gold;
            lblReasonCap.Location = new Point(8, 8);
            lblReasonCap.Name = "lblReasonCap";
            lblReasonCap.Size = new Size(64, 18);
            lblReasonCap.TabIndex = 0;
            lblReasonCap.Text = "查檢說明";
            // 
            // txtReasonNote
            // 
            txtReasonNote.Location = new Point(100, 4);
            txtReasonNote.Name = "txtReasonNote";
            txtReasonNote.ReadOnly = true;
            txtReasonNote.Size = new Size(1780, 25);
            txtReasonNote.TabIndex = 1;
            // 
            // lblInspectTitle
            // 
            lblInspectTitle.BackColor = Color.Gainsboro;
            lblInspectTitle.Dock = DockStyle.Top;
            lblInspectTitle.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            lblInspectTitle.Location = new Point(0, 0);
            lblInspectTitle.Name = "lblInspectTitle";
            lblInspectTitle.Padding = new Padding(6, 4, 0, 4);
            lblInspectTitle.Size = new Size(1900, 26);
            lblInspectTitle.TabIndex = 2;
            lblInspectTitle.Text = "零件檢驗履歷";
            // 
            // panel4
            // 
            panel4.BackColor = Color.Honeydew;
            panel4.Controls.Add(lblApproverCap);
            panel4.Controls.Add(txtApprover);
            panel4.Controls.Add(lblApproveDateCap);
            panel4.Controls.Add(txtApproveDate);
            panel4.Controls.Add(lblModifierCap);
            panel4.Controls.Add(txtModifier);
            panel4.Controls.Add(lblModifyDateCap);
            panel4.Controls.Add(txtModifyDate);
            panel4.Controls.Add(lblCreatorCap);
            panel4.Controls.Add(txtCreator);
            panel4.Controls.Add(lblCreateDateCap);
            panel4.Controls.Add(txtCreateDate);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(0, 680);
            panel4.Name = "panel4";
            panel4.Size = new Size(1900, 56);
            panel4.TabIndex = 3;
            // 
            // lblApproverCap
            // 
            lblApproverCap.AutoSize = true;
            lblApproverCap.Location = new Point(10, 18);
            lblApproverCap.Name = "lblApproverCap";
            lblApproverCap.Size = new Size(64, 18);
            lblApproverCap.TabIndex = 0;
            lblApproverCap.Text = "核准人員";
            // 
            // txtApprover
            // 
            txtApprover.Location = new Point(92, 14);
            txtApprover.Name = "txtApprover";
            txtApprover.ReadOnly = true;
            txtApprover.Size = new Size(120, 25);
            txtApprover.TabIndex = 1;
            // 
            // lblApproveDateCap
            // 
            lblApproveDateCap.AutoSize = true;
            lblApproveDateCap.Location = new Point(226, 18);
            lblApproveDateCap.Name = "lblApproveDateCap";
            lblApproveDateCap.Size = new Size(50, 18);
            lblApproveDateCap.TabIndex = 2;
            lblApproveDateCap.Text = "核准日";
            // 
            // txtApproveDate
            // 
            txtApproveDate.Location = new Point(288, 14);
            txtApproveDate.Name = "txtApproveDate";
            txtApproveDate.ReadOnly = true;
            txtApproveDate.Size = new Size(120, 25);
            txtApproveDate.TabIndex = 3;
            // 
            // lblModifierCap
            // 
            lblModifierCap.AutoSize = true;
            lblModifierCap.Location = new Point(430, 18);
            lblModifierCap.Name = "lblModifierCap";
            lblModifierCap.Size = new Size(64, 18);
            lblModifierCap.TabIndex = 4;
            lblModifierCap.Text = "修改人員";
            // 
            // txtModifier
            // 
            txtModifier.Location = new Point(512, 14);
            txtModifier.Name = "txtModifier";
            txtModifier.ReadOnly = true;
            txtModifier.Size = new Size(120, 25);
            txtModifier.TabIndex = 5;
            // 
            // lblModifyDateCap
            // 
            lblModifyDateCap.AutoSize = true;
            lblModifyDateCap.Location = new Point(646, 18);
            lblModifyDateCap.Name = "lblModifyDateCap";
            lblModifyDateCap.Size = new Size(50, 18);
            lblModifyDateCap.TabIndex = 6;
            lblModifyDateCap.Text = "修改日";
            // 
            // txtModifyDate
            // 
            txtModifyDate.Location = new Point(708, 14);
            txtModifyDate.Name = "txtModifyDate";
            txtModifyDate.ReadOnly = true;
            txtModifyDate.Size = new Size(120, 25);
            txtModifyDate.TabIndex = 7;
            // 
            // lblCreatorCap
            // 
            lblCreatorCap.AutoSize = true;
            lblCreatorCap.Location = new Point(850, 18);
            lblCreatorCap.Name = "lblCreatorCap";
            lblCreatorCap.Size = new Size(64, 18);
            lblCreatorCap.TabIndex = 8;
            lblCreatorCap.Text = "建檔人員";
            // 
            // txtCreator
            // 
            txtCreator.Location = new Point(932, 14);
            txtCreator.Name = "txtCreator";
            txtCreator.ReadOnly = true;
            txtCreator.Size = new Size(120, 25);
            txtCreator.TabIndex = 9;
            // 
            // lblCreateDateCap
            // 
            lblCreateDateCap.AutoSize = true;
            lblCreateDateCap.Location = new Point(1066, 18);
            lblCreateDateCap.Name = "lblCreateDateCap";
            lblCreateDateCap.Size = new Size(50, 18);
            lblCreateDateCap.TabIndex = 10;
            lblCreateDateCap.Text = "建檔日";
            // 
            // txtCreateDate
            // 
            txtCreateDate.Location = new Point(1128, 14);
            txtCreateDate.Name = "txtCreateDate";
            txtCreateDate.ReadOnly = true;
            txtCreateDate.Size = new Size(120, 25);
            txtCreateDate.TabIndex = 11;
            // 
            // MiscControlOrderControl
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(splitContainer1);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("微軟正黑體", 10F);
            Margin = new Padding(4);
            Name = "MiscControlOrderControl";
            Size = new Size(1900, 736);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            panelNote.ResumeLayout(false);
            panelNote.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label lblTitle;
        private Button btnDelete;
        private Button btnModify;
        private Button btnSave;
        private Button btnActivate;
        private Button btnCancelActivate;
        private Button btnOverview;
        private Button btnClose;
        private Panel panel2;
        private Label lblControlNo;
        private TextBox txtControlNo;
        private Label lblStockInDate;
        private TextBox txtStockInDate;
        private Label lblPartNo;
        private TextBox txtPartNo;
        private Label lblNote;
        private Label lblProjectNo;
        private TextBox txtProjectNo;
        private Label lblAcceptDate;
        private TextBox txtAcceptDate;
        private Label lblPartName;
        private TextBox txtPartName;
        private Label lblModuleCode;
        private TextBox txtModuleCode;
        private Label lblAcceptStaff;
        private ComboBox cboAcceptStaff;
        private Label lblDesc;
        private TextBox txtDesc;
        private Label lblModuleName;
        private TextBox txtModuleName;
        private Label lblWarehouseStaff;
        private ComboBox cboWarehouseStaff;
        private Label lblQty;
        private TextBox txtQty;
        private Label lblAcceptResult;
        private ComboBox cboAcceptResult;
        private SplitContainer splitContainer1;
        private Label lblProcessTitle;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn colProcessType;
        private DataGridViewComboBoxColumn colWorkStation;
        private DataGridViewComboBoxColumn colProductionUnit;
        private DataGridViewComboBoxColumn colOperator;
        private DigiERP.Common.DataGridViewDateTimePickerColumn colStartDate;
        private DigiERP.Common.DataGridViewDateTimePickerColumn colDueDate;
        private DigiERP.Common.DataGridViewDateTimePickerColumn colFinishDate;
        private DigiERP.Common.DataGridViewNumericUpDownColumn colFinishQty;
        private Label lblInspectTitle;
        private DataGridView dataGridView2;
        private DigiERP.Common.DataGridViewDateTimePickerColumn colCheckDate;
        private DataGridViewComboBoxColumn colChecker;
        private DataGridViewComboBoxColumn colSizeSpec;
        private DataGridViewComboBoxColumn colGeoSpec;
        private DataGridViewComboBoxColumn colMaterialSpec;
        private DataGridViewComboBoxColumn colSurfaceSpec;
        private DataGridViewComboBoxColumn colHardnessSpec;
        private DataGridViewComboBoxColumn colBurrTrim;
        private DataGridViewComboBoxColumn colMicroCrack;
        private Panel panelNote;
        private Label lblReasonCap;
        private TextBox txtReasonNote;
        private Panel panel4;
        private Label lblApproverCap;
        private TextBox txtApprover;
        private Label lblApproveDateCap;
        private TextBox txtApproveDate;
        private Label lblModifierCap;
        private TextBox txtModifier;
        private Label lblModifyDateCap;
        private TextBox txtModifyDate;
        private Label lblCreatorCap;
        private TextBox txtCreator;
        private Label lblCreateDateCap;
        private TextBox txtCreateDate;
    }
}
