using System.Drawing;
using System.Windows.Forms;

namespace DigiERP.UserControl.Production
{
    partial class ModuleProcurementProgressControl
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModuleProcurementProgressControl));
            panel1 = new Panel();
            lblTitle = new Label();
            btnExit = new Button();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            colProjectNo = new DataGridViewTextBoxColumn();
            colModuleCode = new DataGridViewTextBoxColumn();
            colModuleName = new DataGridViewTextBoxColumn();
            colPartCount = new DataGridViewTextBoxColumn();
            colInquiryCount = new DataGridViewTextBoxColumn();
            colPurchaseCount = new DataGridViewTextBoxColumn();
            colStockInCount = new DataGridViewTextBoxColumn();
            colStockInRatio = new DataGridViewTextBoxColumn();
            colShortageRatio = new DataGridViewTextBoxColumn();
            colSignal = new DataGridViewTextBoxColumn();
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
            lblTitle.Location = new Point(80, 16);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(181, 24);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "模組零件採購進度表";
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
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colProjectNo, colModuleCode, colModuleName, colPartCount, colInquiryCount, colPurchaseCount, colStockInCount, colStockInRatio, colShortageRatio, colSignal });
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
            colModuleName.FillWeight = 150F;
            colModuleName.HeaderText = "模組名稱";
            colModuleName.Name = "colModuleName";
            colModuleName.ReadOnly = true;
            // 
            // colPartCount
            // 
            colPartCount.HeaderText = "零件筆數";
            colPartCount.Name = "colPartCount";
            colPartCount.ReadOnly = true;
            // 
            // colInquiryCount
            // 
            colInquiryCount.HeaderText = "詢價筆數";
            colInquiryCount.Name = "colInquiryCount";
            colInquiryCount.ReadOnly = true;
            // 
            // colPurchaseCount
            // 
            colPurchaseCount.HeaderText = "採購筆數";
            colPurchaseCount.Name = "colPurchaseCount";
            colPurchaseCount.ReadOnly = true;
            // 
            // colStockInCount
            // 
            colStockInCount.HeaderText = "入庫筆數";
            colStockInCount.Name = "colStockInCount";
            colStockInCount.ReadOnly = true;
            // 
            // colStockInRatio
            // 
            dataGridViewCellStyle1.ForeColor = Color.DarkOrange;
            colStockInRatio.DefaultCellStyle = dataGridViewCellStyle1;
            colStockInRatio.HeaderText = "購料進度";
            colStockInRatio.Name = "colStockInRatio";
            colStockInRatio.ReadOnly = true;
            // 
            // colShortageRatio
            // 
            dataGridViewCellStyle2.ForeColor = Color.DarkOrange;
            colShortageRatio.DefaultCellStyle = dataGridViewCellStyle2;
            colShortageRatio.HeaderText = "缺料比例";
            colShortageRatio.Name = "colShortageRatio";
            colShortageRatio.ReadOnly = true;
            // 
            // colSignal
            // 
            colSignal.FillWeight = 220F;
            colSignal.HeaderText = "採購信號";
            colSignal.Name = "colSignal";
            colSignal.ReadOnly = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(4, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(60, 48);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // ModuleProcurementProgressControl
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("微軟正黑體", 10F);
            Margin = new Padding(4);
            Name = "ModuleProcurementProgressControl";
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
        private Button btnExit;
        private Panel panel2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn colProjectNo;
        private DataGridViewTextBoxColumn colModuleCode;
        private DataGridViewTextBoxColumn colModuleName;
        private DataGridViewTextBoxColumn colPartCount;
        private DataGridViewTextBoxColumn colInquiryCount;
        private DataGridViewTextBoxColumn colPurchaseCount;
        private DataGridViewTextBoxColumn colStockInCount;
        private DataGridViewTextBoxColumn colStockInRatio;
        private DataGridViewTextBoxColumn colShortageRatio;
        private DataGridViewTextBoxColumn colSignal;
        private PictureBox pictureBox1;
    }
}
