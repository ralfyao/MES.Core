using System.Drawing;
using System.Windows.Forms;

namespace DigiERP.UserControl.Production
{
    partial class ProcurementSchedulingControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProcurementSchedulingControl));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            lblTitle = new Label();
            lblChipStart = new Label();
            lblChipWeek1 = new Label();
            lblChipWeek2 = new Label();
            lblChipWeek3 = new Label();
            lblChipWeek4 = new Label();
            btnExit = new Button();
            panel3 = new Panel();
            dataGridView2 = new DataGridView();
            colSumLabel = new DataGridViewTextBoxColumn();
            colSumOverdue = new DataGridViewTextBoxColumn();
            colSumWeek1 = new DataGridViewTextBoxColumn();
            colSumWeek2 = new DataGridViewTextBoxColumn();
            colSumWeek3 = new DataGridViewTextBoxColumn();
            colSumWeek4 = new DataGridViewTextBoxColumn();
            colSumUnscheduled = new DataGridViewTextBoxColumn();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            colProjectNo = new DataGridViewTextBoxColumn();
            colModuleCode = new DataGridViewTextBoxColumn();
            colModuleName = new DataGridViewTextBoxColumn();
            colPartName = new DataGridViewTextBoxColumn();
            colPartNo = new DataGridViewTextBoxColumn();
            colActualPurchaseDate = new DataGridViewTextBoxColumn();
            colOverdue = new DataGridViewTextBoxColumn();
            colWeek1 = new DataGridViewTextBoxColumn();
            colWeek2 = new DataGridViewTextBoxColumn();
            colWeek3 = new DataGridViewTextBoxColumn();
            colWeek4 = new DataGridViewTextBoxColumn();
            colUnscheduled = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            panel1.Controls.Add(lblChipStart);
            panel1.Controls.Add(lblChipWeek1);
            panel1.Controls.Add(lblChipWeek2);
            panel1.Controls.Add(lblChipWeek3);
            panel1.Controls.Add(lblChipWeek4);
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
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("微軟正黑體", 14F, FontStyle.Bold);
            lblTitle.Location = new Point(80, 16);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(113, 24);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "週排程-採購";
            // 
            // lblChipStart
            // 
            lblChipStart.BackColor = Color.PaleGreen;
            lblChipStart.Font = new Font("微軟正黑體", 9F);
            lblChipStart.Location = new Point(1144, 28);
            lblChipStart.Name = "lblChipStart";
            lblChipStart.Size = new Size(144, 26);
            lblChipStart.TabIndex = 1;
            lblChipStart.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblChipWeek1
            // 
            lblChipWeek1.BackColor = Color.PaleGreen;
            lblChipWeek1.Font = new Font("微軟正黑體", 9F);
            lblChipWeek1.Location = new Point(1292, 28);
            lblChipWeek1.Name = "lblChipWeek1";
            lblChipWeek1.Size = new Size(152, 26);
            lblChipWeek1.TabIndex = 2;
            lblChipWeek1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblChipWeek2
            // 
            lblChipWeek2.BackColor = Color.PaleGreen;
            lblChipWeek2.Font = new Font("微軟正黑體", 9F);
            lblChipWeek2.Location = new Point(1448, 26);
            lblChipWeek2.Name = "lblChipWeek2";
            lblChipWeek2.Size = new Size(148, 26);
            lblChipWeek2.TabIndex = 3;
            lblChipWeek2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblChipWeek3
            // 
            lblChipWeek3.BackColor = Color.PaleGreen;
            lblChipWeek3.Font = new Font("微軟正黑體", 9F);
            lblChipWeek3.Location = new Point(1596, 26);
            lblChipWeek3.Name = "lblChipWeek3";
            lblChipWeek3.Size = new Size(152, 26);
            lblChipWeek3.TabIndex = 4;
            lblChipWeek3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblChipWeek4
            // 
            lblChipWeek4.BackColor = Color.PaleGreen;
            lblChipWeek4.Font = new Font("微軟正黑體", 9F);
            lblChipWeek4.Location = new Point(1752, 24);
            lblChipWeek4.Name = "lblChipWeek4";
            lblChipWeek4.Size = new Size(144, 26);
            lblChipWeek4.TabIndex = 5;
            lblChipWeek4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.LightSteelBlue;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            btnExit.Location = new Point(1780, 12);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(110, 32);
            btnExit.TabIndex = 6;
            btnExit.Text = "EXIT";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Visible = false;
            btnExit.Click += btnExit_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.PaleGreen;
            panel3.Controls.Add(dataGridView2);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 500);
            panel3.Name = "panel3";
            panel3.Size = new Size(1900, 156);
            panel3.TabIndex = 2;
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.BackgroundColor = Color.White;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { colSumLabel, colSumOverdue, colSumWeek1, colSumWeek2, colSumWeek3, colSumWeek4, colSumUnscheduled });
            dataGridView2.Font = new Font("微軟正黑體", 9F);
            dataGridView2.Location = new Point(808, 8);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.RowHeadersVisible = false;
            dataGridView2.RowTemplate.Height = 26;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.Size = new Size(1088, 122);
            dataGridView2.TabIndex = 0;
            // 
            // colSumLabel
            // 
            colSumLabel.FillWeight = 130F;
            colSumLabel.HeaderText = "";
            colSumLabel.Name = "colSumLabel";
            colSumLabel.ReadOnly = true;
            // 
            // colSumOverdue
            // 
            colSumOverdue.HeaderText = "基準日以前";
            colSumOverdue.Name = "colSumOverdue";
            colSumOverdue.ReadOnly = true;
            // 
            // colSumWeek1
            // 
            colSumWeek1.HeaderText = "第一週";
            colSumWeek1.Name = "colSumWeek1";
            colSumWeek1.ReadOnly = true;
            // 
            // colSumWeek2
            // 
            colSumWeek2.HeaderText = "第二週";
            colSumWeek2.Name = "colSumWeek2";
            colSumWeek2.ReadOnly = true;
            // 
            // colSumWeek3
            // 
            colSumWeek3.HeaderText = "第三週";
            colSumWeek3.Name = "colSumWeek3";
            colSumWeek3.ReadOnly = true;
            // 
            // colSumWeek4
            // 
            colSumWeek4.HeaderText = "第四週";
            colSumWeek4.Name = "colSumWeek4";
            colSumWeek4.ReadOnly = true;
            // 
            // colSumUnscheduled
            // 
            colSumUnscheduled.HeaderText = "未入排程";
            colSumUnscheduled.Name = "colSumUnscheduled";
            colSumUnscheduled.ReadOnly = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridView1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 56);
            panel2.Name = "panel2";
            panel2.Size = new Size(1900, 444);
            panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colProjectNo, colModuleCode, colModuleName, colPartName, colPartNo, colActualPurchaseDate, colOverdue, colWeek1, colWeek2, colWeek3, colWeek4, colUnscheduled });
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
            // colPartName
            // 
            colPartName.FillWeight = 130F;
            colPartName.HeaderText = "品名";
            colPartName.Name = "colPartName";
            colPartName.ReadOnly = true;
            // 
            // colPartNo
            // 
            colPartNo.HeaderText = "零件號碼";
            colPartNo.Name = "colPartNo";
            colPartNo.ReadOnly = true;
            // 
            // colActualPurchaseDate
            // 
            colActualPurchaseDate.HeaderText = "實際採購日";
            colActualPurchaseDate.Name = "colActualPurchaseDate";
            colActualPurchaseDate.ReadOnly = true;
            // 
            // colOverdue
            // 
            colOverdue.HeaderText = "基準日以前";
            colOverdue.Name = "colOverdue";
            colOverdue.ReadOnly = true;
            // 
            // colWeek1
            // 
            colWeek1.HeaderText = "第一週";
            colWeek1.Name = "colWeek1";
            colWeek1.ReadOnly = true;
            // 
            // colWeek2
            // 
            colWeek2.HeaderText = "第二週";
            colWeek2.Name = "colWeek2";
            colWeek2.ReadOnly = true;
            // 
            // colWeek3
            // 
            colWeek3.HeaderText = "第三週";
            colWeek3.Name = "colWeek3";
            colWeek3.ReadOnly = true;
            // 
            // colWeek4
            // 
            colWeek4.HeaderText = "第四週";
            colWeek4.Name = "colWeek4";
            colWeek4.ReadOnly = true;
            // 
            // colUnscheduled
            // 
            colUnscheduled.HeaderText = "未入排程";
            colUnscheduled.Name = "colUnscheduled";
            colUnscheduled.ReadOnly = true;
            // 
            // ProcurementSchedulingControl
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Font = new Font("微軟正黑體", 10F);
            Margin = new Padding(4);
            Name = "ProcurementSchedulingControl";
            Size = new Size(1900, 656);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private Label lblChipStart;
        private Label lblChipWeek1;
        private Label lblChipWeek2;
        private Label lblChipWeek3;
        private Label lblChipWeek4;
        private Button btnExit;
        private Panel panel2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn colProjectNo;
        private DataGridViewTextBoxColumn colModuleCode;
        private DataGridViewTextBoxColumn colModuleName;
        private DataGridViewTextBoxColumn colPartName;
        private DataGridViewTextBoxColumn colPartNo;
        private DataGridViewTextBoxColumn colActualPurchaseDate;
        private DataGridViewTextBoxColumn colUnscheduled;
        private DataGridViewTextBoxColumn colOverdue;
        private DataGridViewTextBoxColumn colWeek1;
        private DataGridViewTextBoxColumn colWeek2;
        private DataGridViewTextBoxColumn colWeek3;
        private DataGridViewTextBoxColumn colWeek4;
        private Panel panel3;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn colSumLabel;
        private DataGridViewTextBoxColumn colSumOverdue;
        private DataGridViewTextBoxColumn colSumWeek1;
        private DataGridViewTextBoxColumn colSumWeek2;
        private DataGridViewTextBoxColumn colSumWeek3;
        private DataGridViewTextBoxColumn colSumWeek4;
        private DataGridViewTextBoxColumn colSumUnscheduled;
    }
}
