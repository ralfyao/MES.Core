using System.Drawing;
using System.Windows.Forms;

namespace DigiERP.UserControl.Production
{
    partial class AbnormalCorrectionReportOverviewControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AbnormalCorrectionReportOverviewControl));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            lblTitle = new Label();
            btnExit = new Button();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            colFormNo = new DataGridViewTextBoxColumn();
            colDate = new DataGridViewTextBoxColumn();
            colProjectNo = new DataGridViewTextBoxColumn();
            colModuleCode = new DataGridViewTextBoxColumn();
            colModuleName = new DataGridViewTextBoxColumn();
            colPartNo = new DataGridViewTextBoxColumn();
            colPartName = new DataGridViewTextBoxColumn();
            colSourceDoc = new DataGridViewTextBoxColumn();
            colAbnormalSource = new DataGridViewTextBoxColumn();
            colDesignChange = new DataGridViewCheckBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            lblTitle.Size = new Size(118, 23);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "異常報告總覽";
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.CornflowerBlue;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            btnExit.ForeColor = Color.White;
            btnExit.Location = new Point(1780, 12);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(100, 32);
            btnExit.TabIndex = 1;
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
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colFormNo, colDate, colProjectNo, colModuleCode, colModuleName, colPartNo, colPartName, colSourceDoc, colAbnormalSource, colDesignChange });
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
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // colFormNo
            // 
            colFormNo.HeaderText = "單號";
            colFormNo.Name = "colFormNo";
            colFormNo.ReadOnly = true;
            // 
            // colDate
            // 
            colDate.HeaderText = "日期";
            colDate.Name = "colDate";
            colDate.ReadOnly = true;
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
            // colPartNo
            // 
            colPartNo.HeaderText = "零件號碼";
            colPartNo.Name = "colPartNo";
            colPartNo.ReadOnly = true;
            // 
            // colPartName
            // 
            colPartName.FillWeight = 150F;
            colPartName.HeaderText = "品名";
            colPartName.Name = "colPartName";
            colPartName.ReadOnly = true;
            // 
            // colSourceDoc
            // 
            colSourceDoc.FillWeight = 150F;
            colSourceDoc.HeaderText = "來源單據";
            colSourceDoc.Name = "colSourceDoc";
            colSourceDoc.ReadOnly = true;
            // 
            // colAbnormalSource
            // 
            colAbnormalSource.HeaderText = "異常來源";
            colAbnormalSource.Name = "colAbnormalSource";
            colAbnormalSource.ReadOnly = true;
            // 
            // colDesignChange
            // 
            colDesignChange.HeaderText = "設變";
            colDesignChange.Name = "colDesignChange";
            colDesignChange.ReadOnly = true;
            // 
            // AbnormalCorrectionReportOverviewControl
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("微軟正黑體", 10F);
            Margin = new Padding(4);
            Name = "AbnormalCorrectionReportOverviewControl";
            Size = new Size(1900, 656);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label lblTitle;
        private Button btnExit;
        private Panel panel2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn colFormNo;
        private DataGridViewTextBoxColumn colDate;
        private DataGridViewTextBoxColumn colProjectNo;
        private DataGridViewTextBoxColumn colModuleCode;
        private DataGridViewTextBoxColumn colModuleName;
        private DataGridViewTextBoxColumn colPartNo;
        private DataGridViewTextBoxColumn colPartName;
        private DataGridViewTextBoxColumn colSourceDoc;
        private DataGridViewTextBoxColumn colAbnormalSource;
        private DataGridViewCheckBoxColumn colDesignChange;
    }
}
