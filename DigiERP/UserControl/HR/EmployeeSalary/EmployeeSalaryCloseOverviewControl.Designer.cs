using System.Drawing;
using System.Windows.Forms;

namespace DigiERP.UserControl.HR.EmployeeSalary
{
    partial class EmployeeSalaryCloseOverviewControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeSalaryCloseOverviewControl));
            panelHeader = new Panel();
            pictureBox1 = new PictureBox();
            lblTitle = new Label();
            btnNew = new Button();
            btnExit = new Button();
            panelBody = new Panel();
            dataGridView1 = new DataGridView();
            colYearMonth = new DataGridViewTextBoxColumn();
            colMonthEndDate = new DataGridViewTextBoxColumn();
            colCreator = new DataGridViewTextBoxColumn();
            colCreateDate = new DataGridViewTextBoxColumn();
            colApprover = new DataGridViewTextBoxColumn();
            colApproveDate = new DataGridViewTextBoxColumn();
            colClosed = new DataGridViewCheckBoxColumn();
            colModifier = new DataGridViewTextBoxColumn();
            colModifyDate = new DataGridViewTextBoxColumn();
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
            panelHeader.Controls.Add(btnNew);
            panelHeader.Controls.Add(btnExit);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1200, 56);
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
            lblTitle.Location = new Point(58, 16);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(124, 24);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "薪資月結總覽";
            // 
            // btnNew
            // 
            btnNew.BackColor = Color.LightSteelBlue;
            btnNew.FlatStyle = FlatStyle.Flat;
            btnNew.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            btnNew.Location = new Point(980, 12);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(90, 32);
            btnNew.TabIndex = 2;
            btnNew.Text = "新增";
            btnNew.UseVisualStyleBackColor = false;
            btnNew.Click += btnNew_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Gainsboro;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            btnExit.Location = new Point(1090, 12);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(100, 32);
            btnExit.TabIndex = 3;
            btnExit.Text = "關閉";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // panelBody
            // 
            panelBody.Controls.Add(dataGridView1);
            panelBody.Dock = DockStyle.Fill;
            panelBody.Location = new Point(0, 56);
            panelBody.Name = "panelBody";
            panelBody.Size = new Size(1200, 600);
            panelBody.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colYearMonth, colMonthEndDate, colCreator, colCreateDate, colApprover, colApproveDate, colClosed, colModifier, colModifyDate });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Font = new Font("微軟正黑體", 9F);
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 26;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1200, 600);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // colYearMonth
            // 
            colYearMonth.HeaderText = "結帳年月";
            colYearMonth.Name = "colYearMonth";
            colYearMonth.ReadOnly = true;
            // 
            // colMonthEndDate
            // 
            colMonthEndDate.HeaderText = "月底日期";
            colMonthEndDate.Name = "colMonthEndDate";
            colMonthEndDate.ReadOnly = true;
            // 
            // colCreator
            // 
            colCreator.HeaderText = "建檔";
            colCreator.Name = "colCreator";
            colCreator.ReadOnly = true;
            // 
            // colCreateDate
            // 
            colCreateDate.HeaderText = "建檔日";
            colCreateDate.Name = "colCreateDate";
            colCreateDate.ReadOnly = true;
            // 
            // colApprover
            // 
            colApprover.HeaderText = "結帳";
            colApprover.Name = "colApprover";
            colApprover.ReadOnly = true;
            // 
            // colApproveDate
            // 
            colApproveDate.HeaderText = "結帳日";
            colApproveDate.Name = "colApproveDate";
            colApproveDate.ReadOnly = true;
            // 
            // colClosed
            // 
            colClosed.HeaderText = "月結";
            colClosed.Name = "colClosed";
            colClosed.ReadOnly = true;
            // 
            // colModifier
            // 
            colModifier.HeaderText = "修改";
            colModifier.Name = "colModifier";
            colModifier.ReadOnly = true;
            // 
            // colModifyDate
            // 
            colModifyDate.HeaderText = "修改日";
            colModifyDate.Name = "colModifyDate";
            colModifyDate.ReadOnly = true;
            // 
            // EmployeeSalaryCloseOverviewControl
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelBody);
            Controls.Add(panelHeader);
            Font = new Font("微軟正黑體", 10F);
            Margin = new Padding(4);
            Name = "EmployeeSalaryCloseOverviewControl";
            Size = new Size(1200, 656);
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
        private Button btnNew;
        private Button btnExit;
        private Panel panelBody;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn colYearMonth;
        private DataGridViewTextBoxColumn colMonthEndDate;
        private DataGridViewTextBoxColumn colCreator;
        private DataGridViewTextBoxColumn colCreateDate;
        private DataGridViewTextBoxColumn colApprover;
        private DataGridViewTextBoxColumn colApproveDate;
        private DataGridViewCheckBoxColumn colClosed;
        private DataGridViewTextBoxColumn colModifier;
        private DataGridViewTextBoxColumn colModifyDate;
    }
}
