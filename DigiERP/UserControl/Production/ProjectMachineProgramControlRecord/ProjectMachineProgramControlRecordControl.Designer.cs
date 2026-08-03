using System.Drawing;
using System.Windows.Forms;

namespace DigiERP.UserControl.Production
{
    partial class ProjectMachineProgramControlRecordControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjectMachineProgramControlRecordControl));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            lblTitle = new Label();
            btnExit = new Button();
            panelContext = new Panel();
            splitContainer1 = new SplitContainer();
            dataGridView1 = new DataGridView();
            colProcess = new DataGridViewTextBoxColumn();
            colDesc = new DataGridViewTextBoxColumn();
            colStaff = new DataGridViewTextBoxColumn();
            colStartDate = new DataGridViewTextBoxColumn();
            colPlanFinishDate = new DataGridViewTextBoxColumn();
            colActualFinishDate = new DataGridViewTextBoxColumn();
            lblScheduleTitle = new Label();
            dataGridView2 = new DataGridView();
            colLogDate = new DataGridViewTextBoxColumn();
            colLogStaff = new DataGridViewTextBoxColumn();
            colLogModuleCode = new DataGridViewTextBoxColumn();
            colLogProcess = new DataGridViewTextBoxColumn();
            colLogTaskCategory = new DataGridViewTextBoxColumn();
            colLogWorkItem = new DataGridViewTextBoxColumn();
            colLogTestStatus = new DataGridViewTextBoxColumn();
            colLogAction = new DataGridViewTextBoxColumn();
            lblHistoryTitle = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 224, 192);
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
            pictureBox1.Size = new Size(48, 48);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("微軟正黑體", 13F, FontStyle.Bold);
            lblTitle.ForeColor = Color.Firebrick;
            lblTitle.Location = new Point(60, 16);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(172, 23);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "專案機台程控紀錄表";
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Gainsboro;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            btnExit.Location = new Point(1794, 12);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(98, 32);
            btnExit.TabIndex = 1;
            btnExit.Text = "關閉";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // panelContext
            // 
            panelContext.BackColor = Color.FromArgb(255, 224, 192);
            panelContext.Dock = DockStyle.Top;
            panelContext.Location = new Point(0, 56);
            panelContext.Name = "panelContext";
            panelContext.Size = new Size(1900, 160);
            panelContext.TabIndex = 1;
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
            splitContainer1.Panel1.Controls.Add(lblScheduleTitle);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(dataGridView2);
            splitContainer1.Panel2.Controls.Add(lblHistoryTitle);
            splitContainer1.Size = new Size(1900, 520);
            splitContainer1.SplitterDistance = 260;
            splitContainer1.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colProcess, colDesc, colStaff, colStartDate, colPlanFinishDate, colActualFinishDate });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Font = new Font("微軟正黑體", 9F);
            dataGridView1.Location = new Point(0, 26);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 26;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1900, 234);
            dataGridView1.TabIndex = 0;
            //
            // colProcess
            //
            colProcess.HeaderText = "電控工序";
            colProcess.Name = "colProcess";
            //
            // colDesc
            //
            colDesc.FillWeight = 200F;
            colDesc.HeaderText = "簡要描述";
            colDesc.Name = "colDesc";
            //
            // colStaff
            //
            colStaff.HeaderText = "程控人員";
            colStaff.Name = "colStaff";
            //
            // colStartDate
            //
            colStartDate.HeaderText = "開始作業日期";
            colStartDate.Name = "colStartDate";
            //
            // colPlanFinishDate
            //
            colPlanFinishDate.HeaderText = "預計完成日期";
            colPlanFinishDate.Name = "colPlanFinishDate";
            //
            // colActualFinishDate
            //
            colActualFinishDate.HeaderText = "實際完成日期";
            colActualFinishDate.Name = "colActualFinishDate";
            //
            // lblScheduleTitle
            // 
            lblScheduleTitle.BackColor = Color.Gainsboro;
            lblScheduleTitle.Dock = DockStyle.Top;
            lblScheduleTitle.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            lblScheduleTitle.Location = new Point(0, 0);
            lblScheduleTitle.Name = "lblScheduleTitle";
            lblScheduleTitle.Padding = new Padding(6, 4, 0, 4);
            lblScheduleTitle.Size = new Size(1900, 26);
            lblScheduleTitle.TabIndex = 1;
            lblScheduleTitle.Text = "專案程控排程";
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.BackgroundColor = Color.White;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { colLogDate, colLogStaff, colLogModuleCode, colLogProcess, colLogTaskCategory, colLogWorkItem, colLogTestStatus, colLogAction });
            dataGridView2.Dock = DockStyle.Fill;
            dataGridView2.Font = new Font("微軟正黑體", 9F);
            dataGridView2.Location = new Point(0, 26);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.RowHeadersVisible = false;
            dataGridView2.RowTemplate.Height = 26;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.Size = new Size(1900, 230);
            dataGridView2.TabIndex = 0;
            //
            // colLogDate
            //
            colLogDate.HeaderText = "日期";
            colLogDate.Name = "colLogDate";
            //
            // colLogStaff
            //
            colLogStaff.HeaderText = "程控人員";
            colLogStaff.Name = "colLogStaff";
            //
            // colLogModuleCode
            //
            colLogModuleCode.HeaderText = "模組";
            colLogModuleCode.Name = "colLogModuleCode";
            //
            // colLogProcess
            //
            colLogProcess.FillWeight = 150F;
            colLogProcess.HeaderText = "電控工序";
            colLogProcess.Name = "colLogProcess";
            //
            // colLogTaskCategory
            //
            colLogTaskCategory.HeaderText = "任務分類";
            colLogTaskCategory.Name = "colLogTaskCategory";
            //
            // colLogWorkItem
            //
            colLogWorkItem.FillWeight = 220F;
            colLogWorkItem.HeaderText = "工作項目";
            colLogWorkItem.Name = "colLogWorkItem";
            //
            // colLogTestStatus
            //
            colLogTestStatus.FillWeight = 150F;
            colLogTestStatus.HeaderText = "實測狀態";
            colLogTestStatus.Name = "colLogTestStatus";
            //
            // colLogAction
            //
            colLogAction.FillWeight = 150F;
            colLogAction.HeaderText = "處置措施";
            colLogAction.Name = "colLogAction";
            //
            // lblHistoryTitle
            // 
            lblHistoryTitle.BackColor = Color.Gainsboro;
            lblHistoryTitle.Dock = DockStyle.Top;
            lblHistoryTitle.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            lblHistoryTitle.Location = new Point(0, 0);
            lblHistoryTitle.Name = "lblHistoryTitle";
            lblHistoryTitle.Padding = new Padding(6, 4, 0, 4);
            lblHistoryTitle.Size = new Size(1900, 26);
            lblHistoryTitle.TabIndex = 1;
            lblHistoryTitle.Text = "專案程控履歷";
            // 
            // ProjectMachineProgramControlRecordControl
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(splitContainer1);
            Controls.Add(panelContext);
            Controls.Add(panel1);
            Font = new Font("微軟正黑體", 10F);
            Margin = new Padding(4);
            Name = "ProjectMachineProgramControlRecordControl";
            Size = new Size(1900, 736);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label lblTitle;
        private Button btnExit;
        private Panel panelContext;
        private SplitContainer splitContainer1;
        private Label lblScheduleTitle;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn colProcess;
        private DataGridViewTextBoxColumn colDesc;
        private DataGridViewTextBoxColumn colStaff;
        private DataGridViewTextBoxColumn colStartDate;
        private DataGridViewTextBoxColumn colPlanFinishDate;
        private DataGridViewTextBoxColumn colActualFinishDate;
        private Label lblHistoryTitle;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn colLogDate;
        private DataGridViewTextBoxColumn colLogStaff;
        private DataGridViewTextBoxColumn colLogModuleCode;
        private DataGridViewTextBoxColumn colLogProcess;
        private DataGridViewTextBoxColumn colLogTaskCategory;
        private DataGridViewTextBoxColumn colLogWorkItem;
        private DataGridViewTextBoxColumn colLogTestStatus;
        private DataGridViewTextBoxColumn colLogAction;
    }
}
