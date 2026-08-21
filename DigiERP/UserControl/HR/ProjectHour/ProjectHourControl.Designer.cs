using System.Drawing;
using System.Windows.Forms;

namespace DigiERP.UserControl.HR.ProjectHour
{
    partial class ProjectHourControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjectHourControl));
            panelHeader = new Panel();
            pictureBox1 = new PictureBox();
            lblTitle = new Label();
            btnExport = new Button();
            btnExit = new Button();
            panelBody = new Panel();
            dataGridView1 = new DataGridView();
            colProjectNo = new DataGridViewTextBoxColumn();
            colCustomer = new DataGridViewTextBoxColumn();
            colModel = new DataGridViewTextBoxColumn();
            colMachineName = new DataGridViewTextBoxColumn();
            colEmpNo = new DataGridViewTextBoxColumn();
            colName = new DataGridViewTextBoxColumn();
            colHours = new DataGridViewTextBoxColumn();
            colCost = new DataGridViewTextBoxColumn();
            colClosed = new DataGridViewCheckBoxColumn();
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
            panelHeader.Controls.Add(btnExport);
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
            lblTitle.Size = new Size(180, 24);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "專案累計工作時數";
            //
            // btnExport
            //
            btnExport.BackColor = Color.LightSteelBlue;
            btnExport.FlatStyle = FlatStyle.Flat;
            btnExport.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            btnExport.Location = new Point(1000, 12);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(90, 32);
            btnExport.TabIndex = 2;
            btnExport.Text = "匯出至Excel";
            btnExport.UseVisualStyleBackColor = false;
            btnExport.Click += btnExport_Click;
            //
            // btnExit
            //
            btnExit.BackColor = Color.Gainsboro;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            btnExit.Location = new Point(1096, 12);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(90, 32);
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
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colProjectNo, colCustomer, colModel, colMachineName, colEmpNo, colName, colHours, colCost, colClosed });
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
            //
            // colProjectNo
            //
            colProjectNo.HeaderText = "專案序號";
            colProjectNo.Name = "colProjectNo";
            colProjectNo.ReadOnly = true;
            colProjectNo.Width = 110;
            //
            // colCustomer
            //
            colCustomer.HeaderText = "客戶簡稱";
            colCustomer.Name = "colCustomer";
            colCustomer.ReadOnly = true;
            colCustomer.Width = 100;
            //
            // colModel
            //
            colModel.HeaderText = "機台型號";
            colModel.Name = "colModel";
            colModel.ReadOnly = true;
            colModel.Width = 110;
            //
            // colMachineName
            //
            colMachineName.HeaderText = "機台名稱";
            colMachineName.Name = "colMachineName";
            colMachineName.ReadOnly = true;
            colMachineName.Width = 140;
            //
            // colEmpNo
            //
            colEmpNo.HeaderText = "員工編號";
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
            // colHours
            //
            colHours.HeaderText = "工時合計";
            colHours.Name = "colHours";
            colHours.ReadOnly = true;
            colHours.Width = 90;
            //
            // colCost
            //
            colCost.HeaderText = "工時成本";
            colCost.Name = "colCost";
            colCost.ReadOnly = true;
            colCost.Width = 100;
            //
            // colClosed
            //
            colClosed.HeaderText = "結案";
            colClosed.Name = "colClosed";
            colClosed.ReadOnly = true;
            colClosed.Width = 60;
            //
            // ProjectHourControl
            //
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelBody);
            Controls.Add(panelHeader);
            Font = new Font("微軟正黑體", 10F);
            Margin = new Padding(4);
            Name = "ProjectHourControl";
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
        private Button btnExport;
        private Button btnExit;
        private Panel panelBody;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn colProjectNo;
        private DataGridViewTextBoxColumn colCustomer;
        private DataGridViewTextBoxColumn colModel;
        private DataGridViewTextBoxColumn colMachineName;
        private DataGridViewTextBoxColumn colEmpNo;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn colHours;
        private DataGridViewTextBoxColumn colCost;
        private DataGridViewCheckBoxColumn colClosed;
    }
}
