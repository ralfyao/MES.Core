using System.Drawing;
using System.Windows.Forms;

namespace DigiERP.UserControl.Production
{
    partial class ProjectProgressControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjectProgressControl));
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            lblTitle = new Label();
            btnScheduleQuery = new Button();
            btnExit = new Button();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            colProjectNo = new DataGridViewTextBoxColumn();
            colD = new DataGridViewTextBoxColumn();
            colDS = new DataGridViewTextBoxColumn();
            colDF = new DataGridViewTextBoxColumn();
            colDP = new DataGridViewTextBoxColumn();
            colP = new DataGridViewTextBoxColumn();
            colPS = new DataGridViewTextBoxColumn();
            colPF = new DataGridViewTextBoxColumn();
            colPP = new DataGridViewTextBoxColumn();
            colM = new DataGridViewTextBoxColumn();
            colM1S = new DataGridViewTextBoxColumn();
            colM1F = new DataGridViewTextBoxColumn();
            colM2S = new DataGridViewTextBoxColumn();
            colM2F = new DataGridViewTextBoxColumn();
            colM3S = new DataGridViewTextBoxColumn();
            colM3F = new DataGridViewTextBoxColumn();
            colM4S = new DataGridViewTextBoxColumn();
            colM4F = new DataGridViewTextBoxColumn();
            colM5S = new DataGridViewTextBoxColumn();
            colM5F = new DataGridViewTextBoxColumn();
            colASP = new DataGridViewTextBoxColumn();
            colAF = new DataGridViewTextBoxColumn();
            colAUF = new DataGridViewTextBoxColumn();
            colE = new DataGridViewTextBoxColumn();
            colES = new DataGridViewTextBoxColumn();
            colEF = new DataGridViewTextBoxColumn();
            colEUF = new DataGridViewTextBoxColumn();
            panelGroupHeader = new Panel();
            lblGrpFlow = new Label();
            lblGrpDesign = new Label();
            lblGrpPurchase = new Label();
            lblGrpProcess = new Label();
            lblGrpMachine = new Label();
            lblGrpSpecial = new Label();
            lblGrpPrecision = new Label();
            lblGrpAntiDeform = new Label();
            lblGrpSurface = new Label();
            lblGrpAssembly = new Label();
            lblGrpElectrical = new Label();
            panelFooter = new Panel();
            lblFooter1 = new Label();
            lblFooter2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panelGroupHeader.SuspendLayout();
            panelFooter.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Cornsilk;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(lblTitle);
            panel1.Controls.Add(btnScheduleQuery);
            panel1.Controls.Add(btnExit);
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
            pictureBox1.Size = new Size(56, 44);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("微軟正黑體", 14F, FontStyle.Bold);
            lblTitle.Location = new Point(62, 16);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(143, 24);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "專案進度追蹤表";
            // 
            // btnScheduleQuery
            // 
            btnScheduleQuery.BackColor = Color.SeaGreen;
            btnScheduleQuery.FlatStyle = FlatStyle.Flat;
            btnScheduleQuery.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            btnScheduleQuery.ForeColor = Color.White;
            btnScheduleQuery.Location = new Point(300, 12);
            btnScheduleQuery.Name = "btnScheduleQuery";
            btnScheduleQuery.Size = new Size(140, 32);
            btnScheduleQuery.TabIndex = 1;
            btnScheduleQuery.Text = "專案排程查詢";
            btnScheduleQuery.UseVisualStyleBackColor = false;
            btnScheduleQuery.Click += btnScheduleQuery_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.LightSteelBlue;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            btnExit.Location = new Point(1780, 12);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(110, 32);
            btnExit.TabIndex = 2;
            btnExit.Text = "EXIT";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Visible = false;
            btnExit.Click += btnExit_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridView1);
            panel2.Controls.Add(panelGroupHeader);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 56);
            panel2.Name = "panel2";
            panel2.Size = new Size(1900, 600);
            panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colProjectNo, colD, colDS, colDF, colDP, colP, colPS, colPF, colPP, colM, colM1S, colM1F, colM2S, colM2F, colM3S, colM3F, colM4S, colM4F, colM5S, colM5F, colASP, colAF, colAUF, colE, colES, colEF, colEUF });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Font = new Font("微軟正黑體", 9F);
            dataGridView1.Location = new Point(0, 26);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 26;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1900, 574);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.VisibleChanged += dataGridView1_VisibleChanged;
            // 
            // colProjectNo
            // 
            dataGridViewCellStyle6.ForeColor = Color.Green;
            colProjectNo.DefaultCellStyle = dataGridViewCellStyle6;
            colProjectNo.FillWeight = 90F;
            colProjectNo.HeaderText = "專案序號";
            colProjectNo.Name = "colProjectNo";
            colProjectNo.ReadOnly = true;
            // 
            // colD
            // 
            colD.FillWeight = 65F;
            colD.HeaderText = "模組數";
            colD.Name = "colD";
            colD.ReadOnly = true;
            // 
            // colDS
            // 
            colDS.FillWeight = 65F;
            colDS.HeaderText = "已開工";
            colDS.Name = "colDS";
            colDS.ReadOnly = true;
            // 
            // colDF
            // 
            colDF.FillWeight = 65F;
            colDF.HeaderText = "已審圖";
            colDF.Name = "colDF";
            colDF.ReadOnly = true;
            // 
            // colDP
            // 
            dataGridViewCellStyle7.ForeColor = Color.Red;
            colDP.DefaultCellStyle = dataGridViewCellStyle7;
            colDP.FillWeight = 65F;
            colDP.HeaderText = "進度";
            colDP.Name = "colDP";
            colDP.ReadOnly = true;
            // 
            // colP
            // 
            colP.FillWeight = 65F;
            colP.HeaderText = "零件數";
            colP.Name = "colP";
            colP.ReadOnly = true;
            // 
            // colPS
            // 
            colPS.FillWeight = 65F;
            colPS.HeaderText = "已採購";
            colPS.Name = "colPS";
            colPS.ReadOnly = true;
            // 
            // colPF
            // 
            colPF.FillWeight = 65F;
            colPF.HeaderText = "已入庫";
            colPF.Name = "colPF";
            colPF.ReadOnly = true;
            // 
            // colPP
            // 
            dataGridViewCellStyle8.ForeColor = Color.Red;
            colPP.DefaultCellStyle = dataGridViewCellStyle8;
            colPP.FillWeight = 65F;
            colPP.HeaderText = "進度";
            colPP.Name = "colPP";
            colPP.ReadOnly = true;
            // 
            // colM
            // 
            colM.FillWeight = 65F;
            colM.HeaderText = "已領料";
            colM.Name = "colM";
            colM.ReadOnly = true;
            // 
            // colM1S
            // 
            colM1S.FillWeight = 70F;
            colM1S.HeaderText = "開工數";
            colM1S.Name = "colM1S";
            colM1S.ReadOnly = true;
            // 
            // colM1F
            // 
            colM1F.FillWeight = 70F;
            colM1F.HeaderText = "完工數";
            colM1F.Name = "colM1F";
            colM1F.ReadOnly = true;
            // 
            // colM2S
            // 
            colM2S.FillWeight = 70F;
            colM2S.HeaderText = "開工數";
            colM2S.Name = "colM2S";
            colM2S.ReadOnly = true;
            // 
            // colM2F
            // 
            colM2F.FillWeight = 70F;
            colM2F.HeaderText = "完工數";
            colM2F.Name = "colM2F";
            colM2F.ReadOnly = true;
            // 
            // colM3S
            // 
            colM3S.FillWeight = 70F;
            colM3S.HeaderText = "開工數";
            colM3S.Name = "colM3S";
            colM3S.ReadOnly = true;
            // 
            // colM3F
            // 
            colM3F.FillWeight = 70F;
            colM3F.HeaderText = "完工數";
            colM3F.Name = "colM3F";
            colM3F.ReadOnly = true;
            // 
            // colM4S
            // 
            colM4S.FillWeight = 70F;
            colM4S.HeaderText = "開工數";
            colM4S.Name = "colM4S";
            colM4S.ReadOnly = true;
            // 
            // colM4F
            // 
            colM4F.FillWeight = 70F;
            colM4F.HeaderText = "完工數";
            colM4F.Name = "colM4F";
            colM4F.ReadOnly = true;
            // 
            // colM5S
            // 
            colM5S.FillWeight = 70F;
            colM5S.HeaderText = "開工數";
            colM5S.Name = "colM5S";
            colM5S.ReadOnly = true;
            // 
            // colM5F
            // 
            colM5F.FillWeight = 70F;
            colM5F.HeaderText = "完工數";
            colM5F.Name = "colM5F";
            colM5F.ReadOnly = true;
            // 
            // colASP
            // 
            colASP.FillWeight = 70F;
            colASP.HeaderText = "模組開工";
            colASP.Name = "colASP";
            colASP.ReadOnly = true;
            // 
            // colAF
            // 
            colAF.FillWeight = 65F;
            colAF.HeaderText = "已完測";
            colAF.Name = "colAF";
            colAF.ReadOnly = true;
            // 
            // colAUF
            // 
            dataGridViewCellStyle9.ForeColor = Color.Red;
            colAUF.DefaultCellStyle = dataGridViewCellStyle9;
            colAUF.FillWeight = 65F;
            colAUF.HeaderText = "進度";
            colAUF.Name = "colAUF";
            colAUF.ReadOnly = true;
            // 
            // colE
            // 
            colE.FillWeight = 65F;
            colE.HeaderText = "排程數";
            colE.Name = "colE";
            colE.ReadOnly = true;
            // 
            // colES
            // 
            colES.FillWeight = 65F;
            colES.HeaderText = "已開工";
            colES.Name = "colES";
            colES.ReadOnly = true;
            // 
            // colEF
            // 
            colEF.FillWeight = 65F;
            colEF.HeaderText = "已完測";
            colEF.Name = "colEF";
            colEF.ReadOnly = true;
            // 
            // colEUF
            // 
            dataGridViewCellStyle10.ForeColor = Color.Red;
            colEUF.DefaultCellStyle = dataGridViewCellStyle10;
            colEUF.FillWeight = 65F;
            colEUF.HeaderText = "進度";
            colEUF.Name = "colEUF";
            colEUF.ReadOnly = true;
            // 
            // panelGroupHeader
            // 
            panelGroupHeader.BackColor = Color.Tan;
            panelGroupHeader.Controls.Add(lblGrpFlow);
            panelGroupHeader.Controls.Add(lblGrpDesign);
            panelGroupHeader.Controls.Add(lblGrpPurchase);
            panelGroupHeader.Controls.Add(lblGrpProcess);
            panelGroupHeader.Controls.Add(lblGrpMachine);
            panelGroupHeader.Controls.Add(lblGrpSpecial);
            panelGroupHeader.Controls.Add(lblGrpPrecision);
            panelGroupHeader.Controls.Add(lblGrpAntiDeform);
            panelGroupHeader.Controls.Add(lblGrpSurface);
            panelGroupHeader.Controls.Add(lblGrpAssembly);
            panelGroupHeader.Controls.Add(lblGrpElectrical);
            panelGroupHeader.Dock = DockStyle.Top;
            panelGroupHeader.Location = new Point(0, 0);
            panelGroupHeader.Name = "panelGroupHeader";
            panelGroupHeader.Size = new Size(1900, 26);
            panelGroupHeader.TabIndex = 1;
            // 
            // lblGrpFlow
            // 
            lblGrpFlow.BackColor = Color.Tan;
            lblGrpFlow.BorderStyle = BorderStyle.FixedSingle;
            lblGrpFlow.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            lblGrpFlow.Location = new Point(0, 0);
            lblGrpFlow.Name = "lblGrpFlow";
            lblGrpFlow.Size = new Size(96, 26);
            lblGrpFlow.TabIndex = 0;
            lblGrpFlow.Text = "作業流程";
            lblGrpFlow.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblGrpDesign
            // 
            lblGrpDesign.BackColor = Color.Tan;
            lblGrpDesign.BorderStyle = BorderStyle.FixedSingle;
            lblGrpDesign.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            lblGrpDesign.Location = new Point(96, 0);
            lblGrpDesign.Name = "lblGrpDesign";
            lblGrpDesign.Size = new Size(268, 26);
            lblGrpDesign.TabIndex = 1;
            lblGrpDesign.Text = "設計";
            lblGrpDesign.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblGrpPurchase
            // 
            lblGrpPurchase.BackColor = Color.Tan;
            lblGrpPurchase.BorderStyle = BorderStyle.FixedSingle;
            lblGrpPurchase.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            lblGrpPurchase.Location = new Point(350, 0);
            lblGrpPurchase.Name = "lblGrpPurchase";
            lblGrpPurchase.Size = new Size(282, 26);
            lblGrpPurchase.TabIndex = 2;
            lblGrpPurchase.Text = "採購";
            lblGrpPurchase.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblGrpProcess
            // 
            lblGrpProcess.BackColor = Color.Tan;
            lblGrpProcess.BorderStyle = BorderStyle.FixedSingle;
            lblGrpProcess.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            lblGrpProcess.Location = new Point(632, 0);
            lblGrpProcess.Name = "lblGrpProcess";
            lblGrpProcess.Size = new Size(68, 26);
            lblGrpProcess.TabIndex = 3;
            lblGrpProcess.Text = "加工";
            lblGrpProcess.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblGrpMachine
            // 
            lblGrpMachine.BackColor = Color.Tan;
            lblGrpMachine.BorderStyle = BorderStyle.FixedSingle;
            lblGrpMachine.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            lblGrpMachine.Location = new Point(700, 0);
            lblGrpMachine.Name = "lblGrpMachine";
            lblGrpMachine.Size = new Size(144, 26);
            lblGrpMachine.TabIndex = 4;
            lblGrpMachine.Text = "機械加工";
            lblGrpMachine.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblGrpSpecial
            // 
            lblGrpSpecial.BackColor = Color.Tan;
            lblGrpSpecial.BorderStyle = BorderStyle.FixedSingle;
            lblGrpSpecial.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            lblGrpSpecial.Location = new Point(844, 0);
            lblGrpSpecial.Name = "lblGrpSpecial";
            lblGrpSpecial.Size = new Size(144, 26);
            lblGrpSpecial.TabIndex = 5;
            lblGrpSpecial.Text = "特殊塑型";
            lblGrpSpecial.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblGrpPrecision
            // 
            lblGrpPrecision.BackColor = Color.Tan;
            lblGrpPrecision.BorderStyle = BorderStyle.FixedSingle;
            lblGrpPrecision.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            lblGrpPrecision.Location = new Point(988, 0);
            lblGrpPrecision.Name = "lblGrpPrecision";
            lblGrpPrecision.Size = new Size(144, 26);
            lblGrpPrecision.TabIndex = 6;
            lblGrpPrecision.Text = "精密加工";
            lblGrpPrecision.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblGrpAntiDeform
            // 
            lblGrpAntiDeform.BackColor = Color.Tan;
            lblGrpAntiDeform.BorderStyle = BorderStyle.FixedSingle;
            lblGrpAntiDeform.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            lblGrpAntiDeform.Location = new Point(1132, 0);
            lblGrpAntiDeform.Name = "lblGrpAntiDeform";
            lblGrpAntiDeform.Size = new Size(148, 26);
            lblGrpAntiDeform.TabIndex = 7;
            lblGrpAntiDeform.Text = "防變形";
            lblGrpAntiDeform.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblGrpSurface
            // 
            lblGrpSurface.BackColor = Color.Tan;
            lblGrpSurface.BorderStyle = BorderStyle.FixedSingle;
            lblGrpSurface.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            lblGrpSurface.Location = new Point(1280, 0);
            lblGrpSurface.Name = "lblGrpSurface";
            lblGrpSurface.Size = new Size(144, 26);
            lblGrpSurface.TabIndex = 8;
            lblGrpSurface.Text = "表面處理";
            lblGrpSurface.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblGrpAssembly
            // 
            lblGrpAssembly.BackColor = Color.Tan;
            lblGrpAssembly.BorderStyle = BorderStyle.FixedSingle;
            lblGrpAssembly.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            lblGrpAssembly.Location = new Point(1424, 0);
            lblGrpAssembly.Name = "lblGrpAssembly";
            lblGrpAssembly.Size = new Size(204, 26);
            lblGrpAssembly.TabIndex = 9;
            lblGrpAssembly.Text = "組測";
            lblGrpAssembly.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblGrpElectrical
            // 
            lblGrpElectrical.BackColor = Color.Tan;
            lblGrpElectrical.BorderStyle = BorderStyle.FixedSingle;
            lblGrpElectrical.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            lblGrpElectrical.Location = new Point(1628, 0);
            lblGrpElectrical.Name = "lblGrpElectrical";
            lblGrpElectrical.Size = new Size(272, 26);
            lblGrpElectrical.TabIndex = 10;
            lblGrpElectrical.Text = "電控";
            lblGrpElectrical.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelFooter
            // 
            panelFooter.BackColor = Color.LightYellow;
            panelFooter.Controls.Add(lblFooter1);
            panelFooter.Controls.Add(lblFooter2);
            panelFooter.Dock = DockStyle.Bottom;
            panelFooter.Location = new Point(0, 656);
            panelFooter.Name = "panelFooter";
            panelFooter.Size = new Size(1900, 44);
            panelFooter.TabIndex = 2;
            // 
            // lblFooter1
            // 
            lblFooter1.AutoSize = true;
            lblFooter1.Font = new Font("微軟正黑體", 14.25F);
            lblFooter1.ForeColor = Color.Green;
            lblFooter1.Location = new Point(8, 12);
            lblFooter1.Name = "lblFooter1";
            lblFooter1.Size = new Size(595, 24);
            lblFooter1.TabIndex = 0;
            lblFooter1.Text = "※點擊專案序號(綠標)，即可開啟專案管控表查詢各工作站之明細現況!";
            // 
            // lblFooter2
            // 
            lblFooter2.AutoSize = true;
            lblFooter2.Font = new Font("微軟正黑體", 14.25F);
            lblFooter2.ForeColor = Color.DarkRed;
            lblFooter2.Location = new Point(660, 12);
            lblFooter2.Name = "lblFooter2";
            lblFooter2.Size = new Size(650, 24);
            lblFooter2.TabIndex = 1;
            lblFooter2.Text = "※點擊進度(紅標%)，即可開啟該專案所屬各模組進度以利追蹤後續作業程序!";
            // 
            // ProjectProgressControl
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panelFooter);
            Controls.Add(panel1);
            Font = new Font("微軟正黑體", 10F);
            Margin = new Padding(4);
            Name = "ProjectProgressControl";
            Size = new Size(1900, 700);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panelGroupHeader.ResumeLayout(false);
            panelFooter.ResumeLayout(false);
            panelFooter.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblTitle;
        private Button btnScheduleQuery;
        private Button btnExit;
        private Panel panel2;
        private Panel panelGroupHeader;
        private Label lblGrpFlow;
        private Label lblGrpDesign;
        private Label lblGrpPurchase;
        private Label lblGrpProcess;
        private Label lblGrpMachine;
        private Label lblGrpSpecial;
        private Label lblGrpPrecision;
        private Label lblGrpAntiDeform;
        private Label lblGrpSurface;
        private Label lblGrpAssembly;
        private Label lblGrpElectrical;
        private Panel panelFooter;
        private Label lblFooter1;
        private Label lblFooter2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn colProjectNo;
        private DataGridViewTextBoxColumn colD;
        private DataGridViewTextBoxColumn colDS;
        private DataGridViewTextBoxColumn colDF;
        private DataGridViewTextBoxColumn colDP;
        private DataGridViewTextBoxColumn colP;
        private DataGridViewTextBoxColumn colPS;
        private DataGridViewTextBoxColumn colPF;
        private DataGridViewTextBoxColumn colPP;
        private DataGridViewTextBoxColumn colM;
        private DataGridViewTextBoxColumn colM1S;
        private DataGridViewTextBoxColumn colM1F;
        private DataGridViewTextBoxColumn colM2S;
        private DataGridViewTextBoxColumn colM2F;
        private DataGridViewTextBoxColumn colM3S;
        private DataGridViewTextBoxColumn colM3F;
        private DataGridViewTextBoxColumn colM4S;
        private DataGridViewTextBoxColumn colM4F;
        private DataGridViewTextBoxColumn colM5S;
        private DataGridViewTextBoxColumn colM5F;
        private DataGridViewTextBoxColumn colASP;
        private DataGridViewTextBoxColumn colAF;
        private DataGridViewTextBoxColumn colAUF;
        private DataGridViewTextBoxColumn colE;
        private DataGridViewTextBoxColumn colES;
        private DataGridViewTextBoxColumn colEF;
        private DataGridViewTextBoxColumn colEUF;
        private PictureBox pictureBox1;
    }
}
