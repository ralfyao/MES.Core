using System.Drawing;
using System.Windows.Forms;

namespace DigiERP.UserControl.Production.TestValidationReport
{
    partial class TestValidationReportControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestValidationReportControl));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            lblTitle = new Label();
            btnAdd = new Button();
            btnExit = new Button();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            colProjectNo = new DataGridViewTextBoxColumn();
            colAcceptDate = new DataGridViewTextBoxColumn();
            colCustomerName = new DataGridViewTextBoxColumn();
            colContact = new DataGridViewTextBoxColumn();
            colMachineModel = new DataGridViewTextBoxColumn();
            colMachineName = new DataGridViewTextBoxColumn();
            colResult = new DataGridViewTextBoxColumn();
            colCloseDate = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Azure;
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
            lblTitle.Size = new Size(136, 23);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "試機驗收單總覽";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.LightSteelBlue;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            btnAdd.Location = new Point(1648, 12);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(120, 32);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "ADD";
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
            btnExit.Size = new Size(120, 32);
            btnExit.TabIndex = 2;
            btnExit.Text = "EXIT";
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
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colProjectNo, colAcceptDate, colCustomerName, colContact, colMachineModel, colMachineName, colResult, colCloseDate });
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
            // colProjectNo
            // 
            colProjectNo.HeaderText = "專案序號";
            colProjectNo.Name = "colProjectNo";
            colProjectNo.ReadOnly = true;
            // 
            // colAcceptDate
            // 
            colAcceptDate.HeaderText = "驗收日期";
            colAcceptDate.Name = "colAcceptDate";
            colAcceptDate.ReadOnly = true;
            // 
            // colCustomerName
            // 
            colCustomerName.FillWeight = 150F;
            colCustomerName.HeaderText = "客戶名稱";
            colCustomerName.Name = "colCustomerName";
            colCustomerName.ReadOnly = true;
            // 
            // colContact
            // 
            colContact.HeaderText = "聯絡人";
            colContact.Name = "colContact";
            colContact.ReadOnly = true;
            // 
            // colMachineModel
            // 
            colMachineModel.HeaderText = "機台型號";
            colMachineModel.Name = "colMachineModel";
            colMachineModel.ReadOnly = true;
            // 
            // colMachineName
            // 
            colMachineName.FillWeight = 150F;
            colMachineName.HeaderText = "機台名稱";
            colMachineName.Name = "colMachineName";
            colMachineName.ReadOnly = true;
            // 
            // colResult
            // 
            colResult.FillWeight = 220F;
            colResult.HeaderText = "內容說明結果";
            colResult.Name = "colResult";
            colResult.ReadOnly = true;
            // 
            // colCloseDate
            // 
            colCloseDate.HeaderText = "結關日期";
            colCloseDate.Name = "colCloseDate";
            colCloseDate.ReadOnly = true;
            // 
            // TestValidationReportControl
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("微軟正黑體", 10F);
            Margin = new Padding(4);
            Name = "TestValidationReportControl";
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
        private Button btnAdd;
        private Button btnExit;
        private Panel panel2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn colProjectNo;
        private DataGridViewTextBoxColumn colAcceptDate;
        private DataGridViewTextBoxColumn colCustomerName;
        private DataGridViewTextBoxColumn colContact;
        private DataGridViewTextBoxColumn colMachineModel;
        private DataGridViewTextBoxColumn colMachineName;
        private DataGridViewTextBoxColumn colResult;
        private DataGridViewTextBoxColumn colCloseDate;
    }
}
