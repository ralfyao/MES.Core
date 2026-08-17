using System.Drawing;
using System.Windows.Forms;

namespace DigiERP.UserControl.HR.Overtime
{
    partial class OverTimeOverviewControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OverTimeOverviewControl));
            panelHeader = new Panel();
            pictureBox1 = new PictureBox();
            lblTitle = new Label();
            btnStaffReport = new Button();
            btnExit = new Button();
            panelBody = new Panel();
            dataGridView1 = new DataGridView();
            colNo = new DataGridViewTextBoxColumn();
            colCostUnit = new DataGridViewTextBoxColumn();
            colApplicant = new DataGridViewTextBoxColumn();
            colEmpNo = new DataGridViewTextBoxColumn();
            colEmpName = new DataGridViewTextBoxColumn();
            colOtDate = new DataGridViewTextBoxColumn();
            colStart = new DataGridViewTextBoxColumn();
            colEnd = new DataGridViewTextBoxColumn();
            colHours = new DataGridViewTextBoxColumn();
            colReason = new DataGridViewTextBoxColumn();
            colApproved = new DataGridViewCheckBoxColumn();
            colApprover = new DataGridViewTextBoxColumn();
            panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = SystemColors.ActiveCaption;
            panelHeader.Controls.Add(pictureBox1);
            panelHeader.Controls.Add(lblTitle);
            panelHeader.Controls.Add(btnStaffReport);
            panelHeader.Controls.Add(btnExit);
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
            lblTitle.Font = new Font("微軟正黑體", 14F, FontStyle.Bold);
            lblTitle.ForeColor = Color.Firebrick;
            lblTitle.Location = new Point(58, 16);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(162, 24);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "加班申請明細查詢";
            // 
            // btnStaffReport
            // 
            btnStaffReport.BackColor = Color.Lavender;
            btnStaffReport.FlatStyle = FlatStyle.Flat;
            btnStaffReport.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            btnStaffReport.Location = new Point(1000, 12);
            btnStaffReport.Name = "btnStaffReport";
            btnStaffReport.Size = new Size(130, 32);
            btnStaffReport.TabIndex = 2;
            btnStaffReport.Text = "員工別加班紀錄表";
            btnStaffReport.UseVisualStyleBackColor = false;
            btnStaffReport.Click += btnStaffReport_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Gainsboro;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            btnExit.Location = new Point(1260, 12);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(90, 32);
            btnExit.TabIndex = 3;
            btnExit.Text = "關閉";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // panelBody
            // 
            panelBody.Controls.Add(dataGridView1);
            panelBody.Dock = DockStyle.Fill;
            panelBody.Location = new Point(0, 56);
            panelBody.Name = "panelBody";
            panelBody.Size = new Size(1360, 600);
            panelBody.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colNo, colCostUnit, colApplicant, colEmpNo, colEmpName, colOtDate, colStart, colEnd, colHours, colReason, colApproved, colApprover });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Font = new Font("微軟正黑體", 9F);
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 26;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1360, 600);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            //
            // colNo
            // 
            colNo.HeaderText = "單據編號";
            colNo.Name = "colNo";
            colNo.ReadOnly = true;
            // 
            // colCostUnit
            // 
            colCostUnit.HeaderText = "申請單位";
            colCostUnit.Name = "colCostUnit";
            colCostUnit.ReadOnly = true;
            colCostUnit.Width = 80;
            // 
            // colApplicant
            // 
            colApplicant.HeaderText = "申請人";
            colApplicant.Name = "colApplicant";
            colApplicant.ReadOnly = true;
            colApplicant.Width = 80;
            // 
            // colEmpNo
            // 
            colEmpNo.HeaderText = "員工編號";
            colEmpNo.Name = "colEmpNo";
            colEmpNo.ReadOnly = true;
            colEmpNo.Width = 90;
            // 
            // colEmpName
            // 
            colEmpName.HeaderText = "員工姓名";
            colEmpName.Name = "colEmpName";
            colEmpName.ReadOnly = true;
            colEmpName.Width = 80;
            // 
            // colOtDate
            // 
            colOtDate.HeaderText = "加班日期";
            colOtDate.Name = "colOtDate";
            colOtDate.ReadOnly = true;
            colOtDate.Width = 90;
            // 
            // colStart
            // 
            colStart.HeaderText = "起";
            colStart.Name = "colStart";
            colStart.ReadOnly = true;
            colStart.Width = 60;
            // 
            // colEnd
            // 
            colEnd.HeaderText = "訖";
            colEnd.Name = "colEnd";
            colEnd.ReadOnly = true;
            colEnd.Width = 60;
            // 
            // colHours
            // 
            colHours.HeaderText = "時數";
            colHours.Name = "colHours";
            colHours.ReadOnly = true;
            colHours.Width = 60;
            // 
            // colReason
            // 
            colReason.HeaderText = "加班事由";
            colReason.Name = "colReason";
            colReason.ReadOnly = true;
            colReason.Width = 110;
            // 
            // colApproved
            // 
            colApproved.HeaderText = "生效";
            colApproved.Name = "colApproved";
            colApproved.ReadOnly = true;
            colApproved.Width = 50;
            // 
            // colApprover
            // 
            colApprover.HeaderText = "核准人";
            colApprover.Name = "colApprover";
            colApprover.ReadOnly = true;
            colApprover.Width = 90;
            // 
            // OverTimeOverviewControl
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelBody);
            Controls.Add(panelHeader);
            Font = new Font("微軟正黑體", 10F);
            Margin = new Padding(4);
            Name = "OverTimeOverviewControl";
            Size = new Size(1360, 656);
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelBody.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private PictureBox pictureBox1;
        private Label lblTitle;
        private Button btnStaffReport;
        private Button btnExit;
        private Panel panelBody;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn colNo;
        private DataGridViewTextBoxColumn colCostUnit;
        private DataGridViewTextBoxColumn colApplicant;
        private DataGridViewTextBoxColumn colEmpNo;
        private DataGridViewTextBoxColumn colEmpName;
        private DataGridViewTextBoxColumn colOtDate;
        private DataGridViewTextBoxColumn colStart;
        private DataGridViewTextBoxColumn colEnd;
        private DataGridViewTextBoxColumn colHours;
        private DataGridViewTextBoxColumn colReason;
        private DataGridViewCheckBoxColumn colApproved;
        private DataGridViewTextBoxColumn colApprover;
    }
}
