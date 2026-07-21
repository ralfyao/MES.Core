using System.Drawing;
using System.Windows.Forms;

namespace DigiERP.UserControl.Production
{
    partial class DesignDispatchControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DesignDispatchControl));
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
            colCheckCategory = new DataGridViewTextBoxColumn();
            colDrawingHours = new DataGridViewTextBoxColumn();
            colDesigner = new DataGridViewComboBoxColumn();
            colDrawingType = new DataGridViewTextBoxColumn();
            colDrawingFile = new DataGridViewTextBoxColumn();
            colPlannedFinish = new DigiERP.Common.DataGridViewDateTimePickerColumn();
            colActualStart = new DigiERP.Common.DataGridViewDateTimePickerColumn();
            colDrawingIssueDate = new DigiERP.Common.DataGridViewDateTimePickerColumn();
            colAuditPassed = new DataGridViewCheckBoxColumn();
            colListNo = new DataGridViewTextBoxColumn();
            colCustName = new DataGridViewTextBoxColumn();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gainsboro;
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
            lblTitle.Location = new Point(72, 16);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(86, 24);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "設計派案";
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
            btnPrint.Enabled = false;
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
            btnExit.Size = new Size(90, 32);
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
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colProjectNo, colModuleCode, colModuleName, colCheckCategory, colDrawingHours, colDesigner, colDrawingType, colDrawingFile, colPlannedFinish, colActualStart, colDrawingIssueDate, colAuditPassed, colListNo, colCustName });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Font = new Font("微軟正黑體", 9F);
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 26;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1900, 600);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            dataGridView1.DataError += dataGridView1_DataError;
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
            // colCheckCategory
            // 
            colCheckCategory.HeaderText = "檢查分類";
            colCheckCategory.Name = "colCheckCategory";
            colCheckCategory.ReadOnly = true;
            // 
            // colDrawingHours
            // 
            colDrawingHours.HeaderText = "製圖工時";
            colDrawingHours.Name = "colDrawingHours";
            colDrawingHours.ReadOnly = true;
            // 
            // colDesigner
            // 
            colDesigner.HeaderText = "設計人員";
            colDesigner.Name = "colDesigner";
            colDesigner.ReadOnly = true;
            // 
            // colDrawingType
            // 
            colDrawingType.HeaderText = "設計圖類";
            colDrawingType.Name = "colDrawingType";
            colDrawingType.ReadOnly = true;
            // 
            // colDrawingFile
            // 
            colDrawingFile.FillWeight = 150F;
            colDrawingFile.HeaderText = "製圖檔名";
            colDrawingFile.Name = "colDrawingFile";
            colDrawingFile.ReadOnly = true;
            // 
            // colPlannedFinish
            // 
            colPlannedFinish.HeaderText = "排程預交日";
            colPlannedFinish.Name = "colPlannedFinish";
            colPlannedFinish.ReadOnly = true;
            // 
            // colActualStart
            // 
            colActualStart.HeaderText = "實際開工日";
            colActualStart.Name = "colActualStart";
            colActualStart.ReadOnly = true;
            // 
            // colDrawingIssueDate
            // 
            colDrawingIssueDate.HeaderText = "圖檔發行日";
            colDrawingIssueDate.Name = "colDrawingIssueDate";
            colDrawingIssueDate.ReadOnly = true;
            // 
            // colAuditPassed
            // 
            colAuditPassed.HeaderText = "審圖";
            colAuditPassed.Name = "colAuditPassed";
            colAuditPassed.ReadOnly = true;
            // 
            // colListNo
            // 
            colListNo.HeaderText = "設計審查清單";
            colListNo.Name = "colListNo";
            colListNo.ReadOnly = true;
            // 
            // colCustName
            // 
            colCustName.HeaderText = "客戶簡稱";
            colCustName.Name = "colCustName";
            colCustName.ReadOnly = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(4, 8);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(56, 40);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // DesignDispatchControl
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("微軟正黑體", 10F);
            Margin = new Padding(4);
            Name = "DesignDispatchControl";
            Size = new Size(1900, 656);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private DataGridViewTextBoxColumn colCheckCategory;
        private DataGridViewTextBoxColumn colDrawingHours;
        private DataGridViewComboBoxColumn colDesigner;
        private DataGridViewTextBoxColumn colDrawingType;
        private DataGridViewTextBoxColumn colDrawingFile;
        private DigiERP.Common.DataGridViewDateTimePickerColumn colPlannedFinish;
        private DigiERP.Common.DataGridViewDateTimePickerColumn colActualStart;
        private DigiERP.Common.DataGridViewDateTimePickerColumn colDrawingIssueDate;
        private DataGridViewCheckBoxColumn colAuditPassed;
        private DataGridViewTextBoxColumn colListNo;
        private DataGridViewTextBoxColumn colCustName;
        private PictureBox pictureBox1;
    }
}
