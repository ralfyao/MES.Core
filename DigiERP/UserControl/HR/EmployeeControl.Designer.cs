using System.Drawing;
using System.Windows.Forms;

namespace DigiERP.UserControl.HR
{
    partial class EmployeeControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeControl));
            panel1 = new Panel();
            lblTitle = new Label();
            btnActiveQuery = new Button();
            btnRestore = new Button();
            btnAdd = new Button();
            btnExit = new Button();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            colEmpNo = new DataGridViewTextBoxColumn();
            colName = new DataGridViewTextBoxColumn();
            colDept = new DataGridViewTextBoxColumn();
            colHRNo = new DataGridViewTextBoxColumn();
            colCardNo = new DataGridViewTextBoxColumn();
            colBirthday = new DataGridViewTextBoxColumn();
            colStatus = new DataGridViewTextBoxColumn();
            colGrade = new DataGridViewTextBoxColumn();
            colRank = new DataGridViewTextBoxColumn();
            colSalaryDate = new DataGridViewTextBoxColumn();
            colResignDate = new DataGridViewTextBoxColumn();
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
            panel1.Controls.Add(btnActiveQuery);
            panel1.Controls.Add(btnRestore);
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(btnExit);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1600, 64);
            panel1.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("微軟正黑體", 14F, FontStyle.Bold);
            lblTitle.ForeColor = Color.Firebrick;
            lblTitle.Location = new Point(88, 16);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(86, 24);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "員工清冊";
            // 
            // btnActiveQuery
            // 
            btnActiveQuery.BackColor = Color.SteelBlue;
            btnActiveQuery.FlatStyle = FlatStyle.Flat;
            btnActiveQuery.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            btnActiveQuery.ForeColor = Color.White;
            btnActiveQuery.Location = new Point(200, 14);
            btnActiveQuery.Name = "btnActiveQuery";
            btnActiveQuery.Size = new Size(110, 32);
            btnActiveQuery.TabIndex = 1;
            btnActiveQuery.Text = "在職者查詢";
            btnActiveQuery.UseVisualStyleBackColor = false;
            btnActiveQuery.Click += btnActiveQuery_Click;
            // 
            // btnRestore
            // 
            btnRestore.BackColor = Color.Gainsboro;
            btnRestore.FlatStyle = FlatStyle.Flat;
            btnRestore.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            btnRestore.Location = new Point(320, 14);
            btnRestore.Name = "btnRestore";
            btnRestore.Size = new Size(90, 32);
            btnRestore.TabIndex = 2;
            btnRestore.Text = "復原";
            btnRestore.UseVisualStyleBackColor = false;
            btnRestore.Click += btnRestore_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Gainsboro;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            btnAdd.Location = new Point(420, 14);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(110, 32);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "新增員工";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Gainsboro;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            btnExit.Location = new Point(540, 14);
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
            panel2.Location = new Point(0, 64);
            panel2.Name = "panel2";
            panel2.Size = new Size(1600, 600);
            panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colEmpNo, colName, colDept, colHRNo, colCardNo, colBirthday, colStatus, colGrade, colRank, colSalaryDate, colResignDate });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Font = new Font("微軟正黑體", 10F);
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 26;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1600, 600);
            dataGridView1.TabIndex = 0;
            // 
            // colEmpNo
            // 
            colEmpNo.FillWeight = 70F;
            colEmpNo.HeaderText = "工號";
            colEmpNo.Name = "colEmpNo";
            colEmpNo.ReadOnly = true;
            // 
            // colName
            // 
            colName.FillWeight = 90F;
            colName.HeaderText = "姓名";
            colName.Name = "colName";
            colName.ReadOnly = true;
            // 
            // colDept
            // 
            colDept.FillWeight = 140F;
            colDept.HeaderText = "部門";
            colDept.Name = "colDept";
            colDept.ReadOnly = true;
            // 
            // colHRNo
            // 
            colHRNo.FillWeight = 90F;
            colHRNo.HeaderText = "人事編號";
            colHRNo.Name = "colHRNo";
            colHRNo.ReadOnly = true;
            // 
            // colCardNo
            // 
            colCardNo.FillWeight = 90F;
            colCardNo.HeaderText = "卡號";
            colCardNo.Name = "colCardNo";
            colCardNo.ReadOnly = true;
            // 
            // colBirthday
            // 
            colBirthday.FillWeight = 90F;
            colBirthday.HeaderText = "生日";
            colBirthday.Name = "colBirthday";
            colBirthday.ReadOnly = true;
            // 
            // colStatus
            // 
            colStatus.FillWeight = 80F;
            colStatus.HeaderText = "在職狀況";
            colStatus.Name = "colStatus";
            colStatus.ReadOnly = true;
            // 
            // colGrade
            // 
            colGrade.FillWeight = 60F;
            colGrade.HeaderText = "職等";
            colGrade.Name = "colGrade";
            colGrade.ReadOnly = true;
            // 
            // colRank
            // 
            colRank.FillWeight = 60F;
            colRank.HeaderText = "職級";
            colRank.Name = "colRank";
            colRank.ReadOnly = true;
            // 
            // colSalaryDate
            // 
            colSalaryDate.FillWeight = 90F;
            colSalaryDate.HeaderText = "核薪日";
            colSalaryDate.Name = "colSalaryDate";
            colSalaryDate.ReadOnly = true;
            // 
            // colResignDate
            // 
            colResignDate.FillWeight = 90F;
            colResignDate.HeaderText = "離職日";
            colResignDate.Name = "colResignDate";
            colResignDate.ReadOnly = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(4, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(64, 56);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // EmployeeControl
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("微軟正黑體", 10F);
            Margin = new Padding(4);
            Name = "EmployeeControl";
            Size = new Size(1600, 664);
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
        private Button btnActiveQuery;
        private Button btnRestore;
        private Button btnAdd;
        private Button btnExit;
        private Panel panel2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn colEmpNo;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn colDept;
        private DataGridViewTextBoxColumn colHRNo;
        private DataGridViewTextBoxColumn colCardNo;
        private DataGridViewTextBoxColumn colBirthday;
        private DataGridViewTextBoxColumn colStatus;
        private DataGridViewTextBoxColumn colGrade;
        private DataGridViewTextBoxColumn colRank;
        private DataGridViewTextBoxColumn colSalaryDate;
        private DataGridViewTextBoxColumn colResignDate;
        private PictureBox pictureBox1;
    }
}
