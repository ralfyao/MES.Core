using System.Drawing;
using System.Windows.Forms;

namespace DigiERP.UserControl.Production
{
    partial class DesignAuditControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DesignAuditControl));
            panel1 = new Panel();
            lblTitle = new Label();
            btnAdd = new Button();
            btnExit = new Button();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            colListNo = new DataGridViewTextBoxColumn();
            colProjectNo = new DataGridViewTextBoxColumn();
            colModuleCode = new DataGridViewTextBoxColumn();
            colModuleName = new DataGridViewTextBoxColumn();
            colDesigner = new DataGridViewTextBoxColumn();
            colDrawingFile = new DataGridViewTextBoxColumn();
            colDrawingIssueDate = new DataGridViewTextBoxColumn();
            colAuditPassed = new DataGridViewCheckBoxColumn();
            colIssuer = new DataGridViewTextBoxColumn();
            colChangeOrder = new DataGridViewTextBoxColumn();
            colIssued = new DataGridViewCheckBoxColumn();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Cornsilk;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(lblTitle);
            panel1.Controls.Add(btnAdd);
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
            lblTitle.Location = new Point(76, 16);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(86, 24);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "審圖總覽";
            //
            // btnAdd
            //
            btnAdd.BackColor = Color.LightSteelBlue;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            btnAdd.Location = new Point(190, 12);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(90, 32);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "新增";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
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
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colListNo, colProjectNo, colModuleCode, colModuleName, colDesigner, colDrawingFile, colDrawingIssueDate, colAuditPassed, colIssuer, colChangeOrder, colIssued });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Font = new Font("微軟正黑體", 9F);
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 26;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1900, 600);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            //
            // colListNo
            // 
            colListNo.HeaderText = "清單編號";
            colListNo.Name = "colListNo";
            colListNo.ReadOnly = true;
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
            // colDesigner
            // 
            colDesigner.HeaderText = "設計人員";
            colDesigner.Name = "colDesigner";
            colDesigner.ReadOnly = true;
            // 
            // colDrawingFile
            // 
            colDrawingFile.FillWeight = 150F;
            colDrawingFile.HeaderText = "製圖檔名";
            colDrawingFile.Name = "colDrawingFile";
            colDrawingFile.ReadOnly = true;
            // 
            // colDrawingIssueDate
            // 
            colDrawingIssueDate.HeaderText = "圖檔發行日";
            colDrawingIssueDate.Name = "colDrawingIssueDate";
            colDrawingIssueDate.ReadOnly = true;
            // 
            // colAuditPassed
            // 
            colAuditPassed.HeaderText = "審圖通過";
            colAuditPassed.Name = "colAuditPassed";
            colAuditPassed.ReadOnly = true;
            // 
            // colIssuer
            // 
            colIssuer.HeaderText = "發行人員";
            colIssuer.Name = "colIssuer";
            colIssuer.ReadOnly = true;
            // 
            // colChangeOrder
            // 
            colChangeOrder.HeaderText = "設變";
            colChangeOrder.Name = "colChangeOrder";
            colChangeOrder.ReadOnly = true;
            // 
            // colIssued
            // 
            colIssued.HeaderText = "已發行";
            colIssued.Name = "colIssued";
            colIssued.ReadOnly = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(4, 8);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(64, 40);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // DesignAuditControl
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("微軟正黑體", 10F);
            Margin = new Padding(4);
            Name = "DesignAuditControl";
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
        private Button btnAdd;
        private Button btnExit;
        private Panel panel2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn colListNo;
        private DataGridViewTextBoxColumn colProjectNo;
        private DataGridViewTextBoxColumn colModuleCode;
        private DataGridViewTextBoxColumn colModuleName;
        private DataGridViewTextBoxColumn colDesigner;
        private DataGridViewTextBoxColumn colDrawingFile;
        private DataGridViewTextBoxColumn colDrawingIssueDate;
        private DataGridViewCheckBoxColumn colAuditPassed;
        private DataGridViewTextBoxColumn colIssuer;
        private DataGridViewTextBoxColumn colChangeOrder;
        private DataGridViewCheckBoxColumn colIssued;
        private PictureBox pictureBox1;
    }
}
