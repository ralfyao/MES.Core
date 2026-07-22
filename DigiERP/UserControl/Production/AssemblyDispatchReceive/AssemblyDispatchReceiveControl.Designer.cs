using System.Drawing;
using System.Windows.Forms;

namespace DigiERP.UserControl.Production
{
    partial class AssemblyDispatchReceiveControl
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AssemblyDispatchReceiveControl));
            panel1 = new Panel();
            lblTitle = new Label();
            btnEdit = new Button();
            btnSave = new Button();
            btnPrint = new Button();
            btnExit = new Button();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            colProjectNo = new DataGridViewTextBoxColumn();
            colModuleCode = new DataGridViewTextBoxColumn();
            colModuleName = new DataGridViewTextBoxColumn();
            colDrawingFile = new DataGridViewTextBoxColumn();
            colIssueDate = new DataGridViewTextBoxColumn();
            colAssemblyStaff = new DataGridViewTextBoxColumn();
            colStartDate = new DigiERP.Common.DataGridViewDateTimePickerColumn();
            colDueDate = new DigiERP.Common.DataGridViewDateTimePickerColumn();
            colFinishDate = new DigiERP.Common.DataGridViewDateTimePickerColumn();
            colCloseReport = new DataGridViewTextBoxColumn();
            colPurpose = new DataGridViewTextBoxColumn();
            colBomNo = new DataGridViewTextBoxColumn();
            panel3 = new Panel();
            lblNote = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Honeydew;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(lblTitle);
            panel1.Controls.Add(btnEdit);
            panel1.Controls.Add(btnSave);
            panel1.Controls.Add(btnPrint);
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
            lblTitle.Font = new Font("微軟正黑體", 14F, FontStyle.Bold);
            lblTitle.Location = new Point(64, 16);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(181, 24);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "組裝派案及領料作業";
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.LightSteelBlue;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            btnEdit.Location = new Point(1500, 12);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(90, 32);
            btnEdit.TabIndex = 1;
            btnEdit.Text = "修改";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.LightSteelBlue;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            btnSave.Location = new Point(1598, 12);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(90, 32);
            btnSave.TabIndex = 2;
            btnSave.Text = "儲存";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnPrint
            // 
            btnPrint.BackColor = Color.LightGray;
            btnPrint.FlatStyle = FlatStyle.Flat;
            btnPrint.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            btnPrint.Location = new Point(1696, 12);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(90, 32);
            btnPrint.TabIndex = 3;
            btnPrint.Text = "列印";
            btnPrint.UseVisualStyleBackColor = false;
            btnPrint.Click += btnPrint_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.LightSteelBlue;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            btnExit.Location = new Point(1794, 12);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(98, 32);
            btnExit.TabIndex = 4;
            btnExit.Text = "關閉";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridView1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 56);
            panel2.Name = "panel2";
            panel2.Size = new Size(1900, 564);
            panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colProjectNo, colModuleCode, colModuleName, colDrawingFile, colIssueDate, colAssemblyStaff, colStartDate, colDueDate, colFinishDate, colCloseReport, colPurpose, colBomNo });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Font = new Font("微軟正黑體", 9F);
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 26;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1900, 564);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // colProjectNo
            // 
            colProjectNo.HeaderText = "專案序號";
            colProjectNo.Name = "colProjectNo";
            colProjectNo.ReadOnly = true;
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
            // colDrawingFile
            // 
            dataGridViewCellStyle3.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = Color.Blue;
            colDrawingFile.DefaultCellStyle = dataGridViewCellStyle3;
            colDrawingFile.FillWeight = 180F;
            colDrawingFile.HeaderText = "製圖檔名(或測試作業名稱)";
            colDrawingFile.Name = "colDrawingFile";
            colDrawingFile.ReadOnly = true;
            // 
            // colIssueDate
            // 
            colIssueDate.HeaderText = "圖檔發行日";
            colIssueDate.Name = "colIssueDate";
            colIssueDate.ReadOnly = true;
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
            // colCloseReport
            // 
            colCloseReport.FillWeight = 150F;
            colCloseReport.HeaderText = "結案回報";
            colCloseReport.Name = "colCloseReport";
            // 
            // colPurpose
            // 
            colPurpose.HeaderText = "用途";
            colPurpose.Name = "colPurpose";
            // 
            // colBomNo
            // 
            colBomNo.HeaderText = "BOM編號";
            colBomNo.Name = "colBomNo";
            colBomNo.ReadOnly = true;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Honeydew;
            panel3.Controls.Add(lblNote);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 620);
            panel3.Name = "panel3";
            panel3.Size = new Size(1900, 36);
            panel3.TabIndex = 2;
            // 
            // lblNote
            // 
            lblNote.AutoSize = true;
            lblNote.ForeColor = Color.DimGray;
            lblNote.Location = new Point(8, 8);
            lblNote.Name = "lblNote";
            lblNote.Size = new Size(574, 18);
            lblNote.TabIndex = 0;
            lblNote.Text = "※如欲開啟該項專案模組的零配件領料清單，請點擊該項的『製圖檔名』欄位(藍色粗體字)！";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(4, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(56, 48);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // AssemblyDispatchReceiveControl
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Font = new Font("微軟正黑體", 10F);
            Margin = new Padding(4);
            Name = "AssemblyDispatchReceiveControl";
            Size = new Size(1900, 656);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblTitle;
        private Button btnEdit;
        private Button btnSave;
        private Button btnPrint;
        private Button btnExit;
        private Panel panel2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn colProjectNo;
        private DataGridViewTextBoxColumn colModuleCode;
        private DataGridViewTextBoxColumn colModuleName;
        private DataGridViewTextBoxColumn colDrawingFile;
        private DataGridViewTextBoxColumn colIssueDate;
        private DataGridViewTextBoxColumn colAssemblyStaff;
        private DigiERP.Common.DataGridViewDateTimePickerColumn colStartDate;
        private DigiERP.Common.DataGridViewDateTimePickerColumn colDueDate;
        private DigiERP.Common.DataGridViewDateTimePickerColumn colFinishDate;
        private DataGridViewTextBoxColumn colCloseReport;
        private DataGridViewTextBoxColumn colPurpose;
        private DataGridViewTextBoxColumn colBomNo;
        private Panel panel3;
        private Label lblNote;
        private PictureBox pictureBox1;
    }
}
