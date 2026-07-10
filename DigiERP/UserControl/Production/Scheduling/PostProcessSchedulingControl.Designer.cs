using System.Drawing;
using System.Windows.Forms;

namespace DigiERP.UserControl.Production
{
    partial class PostProcessSchedulingControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PostProcessSchedulingControl));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            lblTitle = new Label();
            btnExit = new Button();
            panelGroupHeader = new Panel();
            lblGrpSpecial = new Label();
            lblGrpPrecision = new Label();
            lblGrpAntiDeform = new Label();
            lblGrpSurface = new Label();
            panel3 = new Panel();
            dataGridView2 = new DataGridView();
            colSumLabel = new DataGridViewTextBoxColumn();
            colSumSpecialSchedule = new DataGridViewTextBoxColumn();
            colSumSpecialOutwork = new DataGridViewTextBoxColumn();
            colSumPrecisionSchedule = new DataGridViewTextBoxColumn();
            colSumPrecisionOutwork = new DataGridViewTextBoxColumn();
            colSumAntiDeformSchedule = new DataGridViewTextBoxColumn();
            colSumAntiDeformOutwork = new DataGridViewTextBoxColumn();
            colSumSurfaceSchedule = new DataGridViewTextBoxColumn();
            colSumSurfaceOutwork = new DataGridViewTextBoxColumn();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            colProjectNo = new DataGridViewTextBoxColumn();
            colModuleCode = new DataGridViewTextBoxColumn();
            colModuleName = new DataGridViewTextBoxColumn();
            colPartNo = new DataGridViewTextBoxColumn();
            colPartName = new DataGridViewTextBoxColumn();
            colMaterialDate = new DataGridViewTextBoxColumn();
            colSpecialSchedule = new DataGridViewTextBoxColumn();
            colSpecialOutwork = new DataGridViewTextBoxColumn();
            colPrecisionSchedule = new DataGridViewTextBoxColumn();
            colPrecisionOutwork = new DataGridViewTextBoxColumn();
            colAntiDeformSchedule = new DataGridViewTextBoxColumn();
            colAntiDeformOutwork = new DataGridViewTextBoxColumn();
            colSurfaceSchedule = new DataGridViewTextBoxColumn();
            colSurfaceOutwork = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelGroupHeader.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.PaleGreen;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(lblTitle);
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
            pictureBox1.Size = new Size(68, 48);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("微軟正黑體", 14F, FontStyle.Bold);
            lblTitle.Location = new Point(80, 16);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(132, 24);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "週排程-後製程";
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.LightSteelBlue;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            btnExit.Location = new Point(1780, 12);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(110, 32);
            btnExit.TabIndex = 1;
            btnExit.Text = "EXIT";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Visible = false;
            btnExit.Click += btnExit_Click;
            // 
            // panelGroupHeader
            // 
            panelGroupHeader.BackColor = Color.PaleGreen;
            panelGroupHeader.Controls.Add(lblGrpSpecial);
            panelGroupHeader.Controls.Add(lblGrpPrecision);
            panelGroupHeader.Controls.Add(lblGrpAntiDeform);
            panelGroupHeader.Controls.Add(lblGrpSurface);
            panelGroupHeader.Dock = DockStyle.Top;
            panelGroupHeader.Location = new Point(0, 56);
            panelGroupHeader.Name = "panelGroupHeader";
            panelGroupHeader.Size = new Size(1900, 26);
            panelGroupHeader.TabIndex = 1;
            // 
            // lblGrpSpecial
            // 
            lblGrpSpecial.BackColor = Color.SeaGreen;
            lblGrpSpecial.BorderStyle = BorderStyle.Fixed3D;
            lblGrpSpecial.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            lblGrpSpecial.ForeColor = Color.White;
            lblGrpSpecial.Location = new Point(860, 0);
            lblGrpSpecial.Name = "lblGrpSpecial";
            lblGrpSpecial.Size = new Size(256, 26);
            lblGrpSpecial.TabIndex = 0;
            lblGrpSpecial.Text = "特殊塑型";
            lblGrpSpecial.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblGrpPrecision
            // 
            lblGrpPrecision.BackColor = Color.SeaGreen;
            lblGrpPrecision.BorderStyle = BorderStyle.Fixed3D;
            lblGrpPrecision.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            lblGrpPrecision.ForeColor = Color.White;
            lblGrpPrecision.Location = new Point(1116, 0);
            lblGrpPrecision.Name = "lblGrpPrecision";
            lblGrpPrecision.Size = new Size(260, 26);
            lblGrpPrecision.TabIndex = 1;
            lblGrpPrecision.Text = "精密加工";
            lblGrpPrecision.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblGrpAntiDeform
            // 
            lblGrpAntiDeform.BackColor = Color.SeaGreen;
            lblGrpAntiDeform.BorderStyle = BorderStyle.Fixed3D;
            lblGrpAntiDeform.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            lblGrpAntiDeform.ForeColor = Color.White;
            lblGrpAntiDeform.Location = new Point(1376, 0);
            lblGrpAntiDeform.Name = "lblGrpAntiDeform";
            lblGrpAntiDeform.Size = new Size(264, 26);
            lblGrpAntiDeform.TabIndex = 2;
            lblGrpAntiDeform.Text = "防變形";
            lblGrpAntiDeform.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblGrpSurface
            // 
            lblGrpSurface.BackColor = Color.SeaGreen;
            lblGrpSurface.BorderStyle = BorderStyle.Fixed3D;
            lblGrpSurface.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            lblGrpSurface.ForeColor = Color.White;
            lblGrpSurface.Location = new Point(1636, 0);
            lblGrpSurface.Name = "lblGrpSurface";
            lblGrpSurface.Size = new Size(264, 26);
            lblGrpSurface.TabIndex = 3;
            lblGrpSurface.Text = "表面處理";
            lblGrpSurface.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            panel3.BackColor = Color.PaleGreen;
            panel3.Controls.Add(dataGridView2);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 526);
            panel3.Name = "panel3";
            panel3.Size = new Size(1900, 130);
            panel3.TabIndex = 3;
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.BackgroundColor = Color.White;
            dataGridView2.ColumnHeadersVisible = false;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { colSumLabel, colSumSpecialSchedule, colSumSpecialOutwork, colSumPrecisionSchedule, colSumPrecisionOutwork, colSumAntiDeformSchedule, colSumAntiDeformOutwork, colSumSurfaceSchedule, colSumSurfaceOutwork });
            dataGridView2.Font = new Font("微軟正黑體", 9F);
            dataGridView2.Location = new Point(556, 8);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.RowHeadersVisible = false;
            dataGridView2.RowTemplate.Height = 26;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.Size = new Size(1340, 96);
            dataGridView2.TabIndex = 0;
            // 
            // colSumLabel
            // 
            colSumLabel.FillWeight = 130F;
            colSumLabel.HeaderText = "";
            colSumLabel.Name = "colSumLabel";
            colSumLabel.ReadOnly = true;
            // 
            // colSumSpecialSchedule
            // 
            colSumSpecialSchedule.HeaderText = "預計排程日";
            colSumSpecialSchedule.Name = "colSumSpecialSchedule";
            colSumSpecialSchedule.ReadOnly = true;
            // 
            // colSumSpecialOutwork
            // 
            colSumSpecialOutwork.HeaderText = "委外派工日";
            colSumSpecialOutwork.Name = "colSumSpecialOutwork";
            colSumSpecialOutwork.ReadOnly = true;
            // 
            // colSumPrecisionSchedule
            // 
            colSumPrecisionSchedule.HeaderText = "預計排程日";
            colSumPrecisionSchedule.Name = "colSumPrecisionSchedule";
            colSumPrecisionSchedule.ReadOnly = true;
            // 
            // colSumPrecisionOutwork
            // 
            colSumPrecisionOutwork.HeaderText = "委外派工日";
            colSumPrecisionOutwork.Name = "colSumPrecisionOutwork";
            colSumPrecisionOutwork.ReadOnly = true;
            // 
            // colSumAntiDeformSchedule
            // 
            colSumAntiDeformSchedule.HeaderText = "預計排程日";
            colSumAntiDeformSchedule.Name = "colSumAntiDeformSchedule";
            colSumAntiDeformSchedule.ReadOnly = true;
            // 
            // colSumAntiDeformOutwork
            // 
            colSumAntiDeformOutwork.HeaderText = "委外派工日";
            colSumAntiDeformOutwork.Name = "colSumAntiDeformOutwork";
            colSumAntiDeformOutwork.ReadOnly = true;
            // 
            // colSumSurfaceSchedule
            // 
            colSumSurfaceSchedule.HeaderText = "預計排程日";
            colSumSurfaceSchedule.Name = "colSumSurfaceSchedule";
            colSumSurfaceSchedule.ReadOnly = true;
            // 
            // colSumSurfaceOutwork
            // 
            colSumSurfaceOutwork.HeaderText = "委外派工日";
            colSumSurfaceOutwork.Name = "colSumSurfaceOutwork";
            colSumSurfaceOutwork.ReadOnly = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridView1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 82);
            panel2.Name = "panel2";
            panel2.Size = new Size(1900, 444);
            panel2.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colProjectNo, colModuleCode, colModuleName, colPartNo, colPartName, colMaterialDate, colSpecialSchedule, colSpecialOutwork, colPrecisionSchedule, colPrecisionOutwork, colAntiDeformSchedule, colAntiDeformOutwork, colSurfaceSchedule, colSurfaceOutwork });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Font = new Font("微軟正黑體", 9F);
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 26;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1900, 444);
            dataGridView1.TabIndex = 0;
            // 
            // colProjectNo
            // 
            colProjectNo.HeaderText = "專案序號";
            colProjectNo.Name = "colProjectNo";
            colProjectNo.ReadOnly = true;
            // 
            // colModuleCode
            // 
            colModuleCode.HeaderText = "模組";
            colModuleCode.Name = "colModuleCode";
            colModuleCode.ReadOnly = true;
            // 
            // colModuleName
            // 
            colModuleName.FillWeight = 130F;
            colModuleName.HeaderText = "模組名稱";
            colModuleName.Name = "colModuleName";
            colModuleName.ReadOnly = true;
            // 
            // colPartNo
            // 
            colPartNo.HeaderText = "零件號碼";
            colPartNo.Name = "colPartNo";
            colPartNo.ReadOnly = true;
            // 
            // colPartName
            // 
            colPartName.FillWeight = 130F;
            colPartName.HeaderText = "零件品名";
            colPartName.Name = "colPartName";
            colPartName.ReadOnly = true;
            // 
            // colMaterialDate
            // 
            colMaterialDate.HeaderText = "領料日";
            colMaterialDate.Name = "colMaterialDate";
            colMaterialDate.ReadOnly = true;
            // 
            // colSpecialSchedule
            // 
            colSpecialSchedule.HeaderText = "預計排程日";
            colSpecialSchedule.Name = "colSpecialSchedule";
            colSpecialSchedule.ReadOnly = true;
            // 
            // colSpecialOutwork
            // 
            colSpecialOutwork.HeaderText = "委外派工日";
            colSpecialOutwork.Name = "colSpecialOutwork";
            colSpecialOutwork.ReadOnly = true;
            // 
            // colPrecisionSchedule
            // 
            colPrecisionSchedule.HeaderText = "預計排程日";
            colPrecisionSchedule.Name = "colPrecisionSchedule";
            colPrecisionSchedule.ReadOnly = true;
            // 
            // colPrecisionOutwork
            // 
            colPrecisionOutwork.HeaderText = "委外派工日";
            colPrecisionOutwork.Name = "colPrecisionOutwork";
            colPrecisionOutwork.ReadOnly = true;
            // 
            // colAntiDeformSchedule
            // 
            colAntiDeformSchedule.HeaderText = "預計排程日";
            colAntiDeformSchedule.Name = "colAntiDeformSchedule";
            colAntiDeformSchedule.ReadOnly = true;
            // 
            // colAntiDeformOutwork
            // 
            colAntiDeformOutwork.HeaderText = "委外派工日";
            colAntiDeformOutwork.Name = "colAntiDeformOutwork";
            colAntiDeformOutwork.ReadOnly = true;
            // 
            // colSurfaceSchedule
            // 
            colSurfaceSchedule.HeaderText = "預計排程日";
            colSurfaceSchedule.Name = "colSurfaceSchedule";
            colSurfaceSchedule.ReadOnly = true;
            // 
            // colSurfaceOutwork
            // 
            colSurfaceOutwork.HeaderText = "委外派工日";
            colSurfaceOutwork.Name = "colSurfaceOutwork";
            colSurfaceOutwork.ReadOnly = true;
            // 
            // PostProcessSchedulingControl
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(panelGroupHeader);
            Controls.Add(panel1);
            Font = new Font("微軟正黑體", 10F);
            Margin = new Padding(4);
            Name = "PostProcessSchedulingControl";
            Size = new Size(1900, 656);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelGroupHeader.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label lblTitle;
        private Button btnExit;
        private Panel panelGroupHeader;
        private Label lblGrpSpecial;
        private Label lblGrpPrecision;
        private Label lblGrpAntiDeform;
        private Label lblGrpSurface;
        private Panel panel2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn colProjectNo;
        private DataGridViewTextBoxColumn colModuleCode;
        private DataGridViewTextBoxColumn colModuleName;
        private DataGridViewTextBoxColumn colPartNo;
        private DataGridViewTextBoxColumn colPartName;
        private DataGridViewTextBoxColumn colMaterialDate;
        private DataGridViewTextBoxColumn colSpecialSchedule;
        private DataGridViewTextBoxColumn colSpecialOutwork;
        private DataGridViewTextBoxColumn colPrecisionSchedule;
        private DataGridViewTextBoxColumn colPrecisionOutwork;
        private DataGridViewTextBoxColumn colAntiDeformSchedule;
        private DataGridViewTextBoxColumn colAntiDeformOutwork;
        private DataGridViewTextBoxColumn colSurfaceSchedule;
        private DataGridViewTextBoxColumn colSurfaceOutwork;
        private Panel panel3;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn colSumLabel;
        private DataGridViewTextBoxColumn colSumSpecialSchedule;
        private DataGridViewTextBoxColumn colSumSpecialOutwork;
        private DataGridViewTextBoxColumn colSumPrecisionSchedule;
        private DataGridViewTextBoxColumn colSumPrecisionOutwork;
        private DataGridViewTextBoxColumn colSumAntiDeformSchedule;
        private DataGridViewTextBoxColumn colSumAntiDeformOutwork;
        private DataGridViewTextBoxColumn colSumSurfaceSchedule;
        private DataGridViewTextBoxColumn colSumSurfaceOutwork;
    }
}
