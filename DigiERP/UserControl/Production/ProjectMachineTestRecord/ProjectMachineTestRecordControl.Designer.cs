using System.Drawing;
using System.Windows.Forms;

namespace DigiERP.UserControl.Production
{
    partial class ProjectMachineTestRecordControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjectMachineTestRecordControl));
            panel1 = new Panel();
            lblTitle = new Label();
            btnExit = new Button();
            panelContext = new Panel();
            splitContainer1 = new SplitContainer();
            dataGridView1 = new DataGridView();
            colModuleCode = new DataGridViewTextBoxColumn();
            colModuleName = new DataGridViewTextBoxColumn();
            colDrawingFile = new DataGridViewTextBoxColumn();
            colAssemblyStaff = new DataGridViewComboBoxColumn();
            colStartDate = new DataGridViewTextBoxColumn();
            colDueDate = new DataGridViewTextBoxColumn();
            colFinishDate = new DataGridViewTextBoxColumn();
            colCloseReport = new DataGridViewComboBoxColumn();
            dataGridView2 = new DataGridView();
            colTestDate = new DataGridViewTextBoxColumn();
            colTester = new DataGridViewTextBoxColumn();
            colModuleCode2 = new DataGridViewTextBoxColumn();
            colModuleName2 = new DataGridViewTextBoxColumn();
            colTaskCategory = new DataGridViewTextBoxColumn();
            colWorkItem = new DataGridViewTextBoxColumn();
            colTestStatus = new DataGridViewTextBoxColumn();
            colAction = new DataGridViewTextBoxColumn();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Honeydew;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(lblTitle);
            panel1.Controls.Add(btnExit);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1900, 56);
            panel1.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("微軟正黑體", 13F, FontStyle.Bold);
            lblTitle.Location = new Point(64, 16);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(172, 23);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "專案機台組測紀錄表";
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.LightSteelBlue;
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
            panelContext.BackColor = Color.Honeydew;
            panelContext.Dock = DockStyle.Top;
            panelContext.Location = new Point(0, 56);
            panelContext.Name = "panelContext";
            panelContext.Size = new Size(1900, 110);
            panelContext.TabIndex = 1;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 166);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(dataGridView1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(dataGridView2);
            splitContainer1.Size = new Size(1900, 570);
            splitContainer1.SplitterDistance = 280;
            splitContainer1.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colModuleCode, colModuleName, colDrawingFile, colAssemblyStaff, colStartDate, colDueDate, colFinishDate, colCloseReport });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Font = new Font("微軟正黑體", 9F);
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 26;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1900, 280);
            dataGridView1.TabIndex = 0;
            dataGridView1.DataError += dataGridView1_DataError;
            //
            // colModuleCode
            // 
            colModuleCode.HeaderText = "模組";
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
            // colDrawingFile
            // 
            colDrawingFile.FillWeight = 180F;
            colDrawingFile.HeaderText = "製圖檔名(或測試作業名稱)";
            colDrawingFile.Name = "colDrawingFile";
            colDrawingFile.ReadOnly = true;
            // 
            // colAssemblyStaff
            // 
            colAssemblyStaff.HeaderText = "組裝人員";
            colAssemblyStaff.Name = "colAssemblyStaff";
            //
            // colStartDate
            // 
            colStartDate.HeaderText = "開工日期";
            colStartDate.Name = "colStartDate";
            colStartDate.ReadOnly = true;
            // 
            // colDueDate
            // 
            colDueDate.HeaderText = "預交日期";
            colDueDate.Name = "colDueDate";
            colDueDate.ReadOnly = true;
            // 
            // colFinishDate
            // 
            colFinishDate.HeaderText = "完工日期";
            colFinishDate.Name = "colFinishDate";
            colFinishDate.ReadOnly = true;
            // 
            // colCloseReport
            // 
            colCloseReport.HeaderText = "結案回報";
            colCloseReport.Name = "colCloseReport";
            colCloseReport.Items.AddRange(new object[] { "", "合規", "特採", "設變" });
            //
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.BackgroundColor = Color.White;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { colTestDate, colTester, colModuleCode2, colModuleName2, colTaskCategory, colWorkItem, colTestStatus, colAction });
            dataGridView2.Dock = DockStyle.Fill;
            dataGridView2.Font = new Font("微軟正黑體", 9F);
            dataGridView2.Location = new Point(0, 0);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.RowHeadersVisible = false;
            dataGridView2.RowTemplate.Height = 26;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.Size = new Size(1900, 286);
            dataGridView2.TabIndex = 0;
            // 
            // colTestDate
            // 
            colTestDate.HeaderText = "日期";
            colTestDate.Name = "colTestDate";
            colTestDate.ReadOnly = true;
            // 
            // colTester
            // 
            colTester.HeaderText = "組測人員";
            colTester.Name = "colTester";
            colTester.ReadOnly = true;
            // 
            // colModuleCode2
            // 
            colModuleCode2.HeaderText = "模組";
            colModuleCode2.Name = "colModuleCode2";
            colModuleCode2.ReadOnly = true;
            // 
            // colModuleName2
            // 
            colModuleName2.FillWeight = 150F;
            colModuleName2.HeaderText = "模組名稱";
            colModuleName2.Name = "colModuleName2";
            colModuleName2.ReadOnly = true;
            // 
            // colTaskCategory
            // 
            colTaskCategory.HeaderText = "任務分類";
            colTaskCategory.Name = "colTaskCategory";
            colTaskCategory.ReadOnly = true;
            // 
            // colWorkItem
            // 
            colWorkItem.FillWeight = 220F;
            colWorkItem.HeaderText = "工作項目(含零配件組裝)";
            colWorkItem.Name = "colWorkItem";
            colWorkItem.ReadOnly = true;
            // 
            // colTestStatus
            // 
            colTestStatus.HeaderText = "組測狀態";
            colTestStatus.Name = "colTestStatus";
            colTestStatus.ReadOnly = true;
            // 
            // colAction
            // 
            colAction.FillWeight = 150F;
            colAction.HeaderText = "處置措施";
            colAction.Name = "colAction";
            colAction.ReadOnly = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(4, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(60, 48);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // ProjectMachineTestRecordControl
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(splitContainer1);
            Controls.Add(panelContext);
            Controls.Add(panel1);
            Font = new Font("微軟正黑體", 10F);
            Margin = new Padding(4);
            Name = "ProjectMachineTestRecordControl";
            Size = new Size(1900, 736);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblTitle;
        private Button btnExit;
        private Panel panelContext;
        private SplitContainer splitContainer1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn colModuleCode;
        private DataGridViewTextBoxColumn colModuleName;
        private DataGridViewTextBoxColumn colDrawingFile;
        private DataGridViewComboBoxColumn colAssemblyStaff;
        private DataGridViewTextBoxColumn colStartDate;
        private DataGridViewTextBoxColumn colDueDate;
        private DataGridViewTextBoxColumn colFinishDate;
        private DataGridViewComboBoxColumn colCloseReport;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn colTestDate;
        private DataGridViewTextBoxColumn colTester;
        private DataGridViewTextBoxColumn colModuleCode2;
        private DataGridViewTextBoxColumn colModuleName2;
        private DataGridViewTextBoxColumn colTaskCategory;
        private DataGridViewTextBoxColumn colWorkItem;
        private DataGridViewTextBoxColumn colTestStatus;
        private DataGridViewTextBoxColumn colAction;
        private PictureBox pictureBox1;
    }
}
