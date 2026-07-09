using System.Drawing;
using System.Windows.Forms;

namespace DigiERP.UserControl.Production
{
    partial class ElecControlProgressControl
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            panel1 = new Panel();
            lblTitle = new Label();
            btnExit = new Button();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            colProjectNo = new DataGridViewTextBoxColumn();
            colProcess = new DataGridViewTextBoxColumn();
            colStartDate = new DataGridViewTextBoxColumn();
            colPlannedFinishDate = new DataGridViewTextBoxColumn();
            colActualFinishDate = new DataGridViewTextBoxColumn();
            colStdDays = new DataGridViewTextBoxColumn();
            colFinishDays = new DataGridViewTextBoxColumn();
            colOverdueDays = new DataGridViewTextBoxColumn();
            colEfficiency = new DataGridViewTextBoxColumn();
            colWarning = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Cornsilk;
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
            lblTitle.Location = new Point(20, 16);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(143, 24);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "專案電控進度表";
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
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colProjectNo, colProcess, colStartDate, colPlannedFinishDate, colActualFinishDate, colStdDays, colFinishDays, colOverdueDays, colEfficiency, colWarning });
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
            // colProcess
            // 
            colProcess.FillWeight = 150F;
            colProcess.HeaderText = "電控工序";
            colProcess.Name = "colProcess";
            colProcess.ReadOnly = true;
            // 
            // colStartDate
            // 
            colStartDate.HeaderText = "開工日期";
            colStartDate.Name = "colStartDate";
            colStartDate.ReadOnly = true;
            // 
            // colPlannedFinishDate
            // 
            colPlannedFinishDate.HeaderText = "預交日期";
            colPlannedFinishDate.Name = "colPlannedFinishDate";
            colPlannedFinishDate.ReadOnly = true;
            // 
            // colActualFinishDate
            // 
            colActualFinishDate.HeaderText = "完工日期";
            colActualFinishDate.Name = "colActualFinishDate";
            colActualFinishDate.ReadOnly = true;
            // 
            // colStdDays
            // 
            dataGridViewCellStyle1.ForeColor = Color.DarkOrange;
            colStdDays.DefaultCellStyle = dataGridViewCellStyle1;
            colStdDays.HeaderText = "標準期程天數";
            colStdDays.Name = "colStdDays";
            colStdDays.ReadOnly = true;
            // 
            // colFinishDays
            // 
            dataGridViewCellStyle2.ForeColor = Color.DarkOrange;
            colFinishDays.DefaultCellStyle = dataGridViewCellStyle2;
            colFinishDays.HeaderText = "完工期程天數";
            colFinishDays.Name = "colFinishDays";
            colFinishDays.ReadOnly = true;
            // 
            // colOverdueDays
            // 
            dataGridViewCellStyle3.ForeColor = Color.DarkOrange;
            colOverdueDays.DefaultCellStyle = dataGridViewCellStyle3;
            colOverdueDays.HeaderText = "逾期天數";
            colOverdueDays.Name = "colOverdueDays";
            colOverdueDays.ReadOnly = true;
            // 
            // colEfficiency
            // 
            dataGridViewCellStyle4.ForeColor = Color.DarkOrange;
            colEfficiency.DefaultCellStyle = dataGridViewCellStyle4;
            colEfficiency.HeaderText = "達交效率值";
            colEfficiency.Name = "colEfficiency";
            colEfficiency.ReadOnly = true;
            // 
            // colWarning
            // 
            colWarning.HeaderText = "警示訊號";
            colWarning.Name = "colWarning";
            colWarning.ReadOnly = true;
            // 
            // ElecControlProgressControl
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("微軟正黑體", 10F);
            Margin = new Padding(4);
            Name = "ElecControlProgressControl";
            Size = new Size(1900, 656);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblTitle;
        private Button btnExit;
        private Panel panel2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn colProjectNo;
        private DataGridViewTextBoxColumn colProcess;
        private DataGridViewTextBoxColumn colStartDate;
        private DataGridViewTextBoxColumn colPlannedFinishDate;
        private DataGridViewTextBoxColumn colActualFinishDate;
        private DataGridViewTextBoxColumn colStdDays;
        private DataGridViewTextBoxColumn colFinishDays;
        private DataGridViewTextBoxColumn colOverdueDays;
        private DataGridViewTextBoxColumn colEfficiency;
        private DataGridViewTextBoxColumn colWarning;
    }
}
