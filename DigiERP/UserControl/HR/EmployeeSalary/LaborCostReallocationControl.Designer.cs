using System.Drawing;
using System.Windows.Forms;

namespace DigiERP.UserControl.HR.EmployeeSalary
{
    partial class LaborCostReallocationControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LaborCostReallocationControl));
            panelHeader = new Panel();
            pictureBox1 = new PictureBox();
            lblTitle = new Label();
            lblYearMonth = new Label();
            btnRecalc = new Button();
            btnExit = new Button();
            lblHint = new Label();
            panelBody = new Panel();
            dataGridView1 = new DataGridView();
            colEmpNo = new DataGridViewTextBoxColumn();
            colName = new DataGridViewTextBoxColumn();
            colAmount = new DataGridViewTextBoxColumn();
            colLeaveDeduct = new DataGridViewTextBoxColumn();
            colLateDeduct = new DataGridViewTextBoxColumn();
            colAttendHours = new DataGridViewTextBoxColumn();
            colLaborCost = new DataGridViewTextBoxColumn();
            panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            //
            // panelHeader
            //
            panelHeader.BackColor = Color.Moccasin;
            panelHeader.Controls.Add(pictureBox1);
            panelHeader.Controls.Add(lblTitle);
            panelHeader.Controls.Add(lblYearMonth);
            panelHeader.Controls.Add(btnRecalc);
            panelHeader.Controls.Add(btnExit);
            panelHeader.Controls.Add(lblHint);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1100, 76);
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
            lblTitle.Location = new Point(58, 4);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(120, 24);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "人工成本重整";
            //
            // lblYearMonth
            //
            lblYearMonth.AutoSize = true;
            lblYearMonth.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            lblYearMonth.Location = new Point(190, 8);
            lblYearMonth.Name = "lblYearMonth";
            lblYearMonth.Size = new Size(90, 19);
            lblYearMonth.TabIndex = 2;
            lblYearMonth.Text = "年月：";
            //
            // btnRecalc
            //
            btnRecalc.BackColor = Color.DarkGreen;
            btnRecalc.FlatStyle = FlatStyle.Flat;
            btnRecalc.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            btnRecalc.ForeColor = Color.White;
            btnRecalc.Location = new Point(790, 12);
            btnRecalc.Name = "btnRecalc";
            btnRecalc.Size = new Size(120, 32);
            btnRecalc.TabIndex = 3;
            btnRecalc.Text = "人工成本重整";
            btnRecalc.UseVisualStyleBackColor = false;
            btnRecalc.Click += btnRecalc_Click;
            //
            // btnExit
            //
            btnExit.BackColor = Color.Gainsboro;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            btnExit.Location = new Point(920, 12);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(100, 32);
            btnExit.TabIndex = 4;
            btnExit.Text = "關閉";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            //
            // lblHint
            //
            lblHint.AutoSize = true;
            lblHint.Font = new Font("微軟正黑體", 8F);
            lblHint.ForeColor = Color.DimGray;
            lblHint.Location = new Point(58, 32);
            lblHint.Name = "lblHint";
            lblHint.Size = new Size(400, 15);
            lblHint.TabIndex = 5;
            lblHint.Text = "審視出勤時數如有異常，請先檢查出勤紀錄表是否登載完整，再進行重整。";
            //
            // panelBody
            //
            panelBody.Controls.Add(dataGridView1);
            panelBody.Dock = DockStyle.Fill;
            panelBody.Location = new Point(0, 76);
            panelBody.Name = "panelBody";
            panelBody.Size = new Size(1100, 524);
            panelBody.TabIndex = 1;
            //
            // dataGridView1
            //
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colEmpNo, colName, colAmount, colLeaveDeduct, colLateDeduct, colAttendHours, colLaborCost });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Font = new Font("微軟正黑體", 9F);
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 26;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1100, 524);
            dataGridView1.TabIndex = 0;
            //
            // colEmpNo
            //
            colEmpNo.HeaderText = "工號";
            colEmpNo.Name = "colEmpNo";
            colEmpNo.ReadOnly = true;
            colEmpNo.Width = 90;
            //
            // colName
            //
            colName.HeaderText = "姓名";
            colName.Name = "colName";
            colName.ReadOnly = true;
            colName.Width = 90;
            //
            // colAmount
            //
            colAmount.HeaderText = "應領金額";
            colAmount.Name = "colAmount";
            colAmount.ReadOnly = true;
            colAmount.Width = 100;
            //
            // colLeaveDeduct
            //
            colLeaveDeduct.HeaderText = "請假扣款";
            colLeaveDeduct.Name = "colLeaveDeduct";
            colLeaveDeduct.ReadOnly = true;
            colLeaveDeduct.Width = 90;
            //
            // colLateDeduct
            //
            colLateDeduct.HeaderText = "遲到扣款";
            colLateDeduct.Name = "colLateDeduct";
            colLateDeduct.ReadOnly = true;
            colLateDeduct.Width = 90;
            //
            // colAttendHours
            //
            colAttendHours.HeaderText = "出勤時數";
            colAttendHours.Name = "colAttendHours";
            colAttendHours.ReadOnly = true;
            colAttendHours.Width = 90;
            //
            // colLaborCost
            //
            colLaborCost.HeaderText = "工時成本";
            colLaborCost.Name = "colLaborCost";
            colLaborCost.ReadOnly = true;
            colLaborCost.Width = 90;
            //
            // LaborCostReallocationControl
            //
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelBody);
            Controls.Add(panelHeader);
            Font = new Font("微軟正黑體", 10F);
            Margin = new Padding(4);
            Name = "LaborCostReallocationControl";
            Size = new Size(1100, 600);
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
        private Label lblYearMonth;
        private Button btnRecalc;
        private Button btnExit;
        private Label lblHint;
        private Panel panelBody;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn colEmpNo;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn colAmount;
        private DataGridViewTextBoxColumn colLeaveDeduct;
        private DataGridViewTextBoxColumn colLateDeduct;
        private DataGridViewTextBoxColumn colAttendHours;
        private DataGridViewTextBoxColumn colLaborCost;
    }
}
