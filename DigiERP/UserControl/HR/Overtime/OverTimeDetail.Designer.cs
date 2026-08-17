using System.Drawing;
using System.Windows.Forms;

namespace DigiERP.UserControl.HR.Overtime
{
    partial class OverTimeDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OverTimeDetail));
            panelHeader = new Panel();
            pictureBox1 = new PictureBox();
            lblTitle = new Label();
            btnFirst = new Button();
            btnPrev = new Button();
            btnNext = new Button();
            btnLast = new Button();
            btnClose = new Button();
            panelFormHeader = new Panel();
            lblEmpNo = new Label();
            txtEmpNo = new TextBox();
            lblName = new Label();
            txtName = new TextBox();
            lblTitleJob = new Label();
            txtTitleJob = new TextBox();
            lblDept = new Label();
            txtDept = new TextBox();
            lblHrNo = new Label();
            txtHrNo = new TextBox();
            lblCardNo = new Label();
            txtCardNo = new TextBox();
            lblStartDate = new Label();
            dtStartDate = new DateTimePicker();
            lblEndDate = new Label();
            dtEndDate = new DateTimePicker();
            btnQuery = new Button();
            panelBody = new Panel();
            dataGridView1 = new DataGridView();
            colDate = new DataGridViewTextBoxColumn();
            colShift = new DataGridViewTextBoxColumn();
            colOtStart = new DataGridViewTextBoxColumn();
            colOtEnd = new DataGridViewTextBoxColumn();
            colHours = new DataGridViewTextBoxColumn();
            colReason = new DataGridViewTextBoxColumn();
            colOtHours = new DataGridViewTextBoxColumn();
            colOtPay = new DataGridViewTextBoxColumn();
            colHourlyPay = new DataGridViewTextBoxColumn();
            panelFooter = new Panel();
            lblSumHours = new Label();
            lblSumPay = new Label();
            panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelFormHeader.SuspendLayout();
            panelBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panelFooter.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.Yellow;
            panelHeader.Controls.Add(pictureBox1);
            panelHeader.Controls.Add(lblTitle);
            panelHeader.Controls.Add(btnFirst);
            panelHeader.Controls.Add(btnPrev);
            panelHeader.Controls.Add(btnNext);
            panelHeader.Controls.Add(btnLast);
            panelHeader.Controls.Add(btnClose);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1360, 56);
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
            lblTitle.Size = new Size(143, 24);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "員工加班紀錄表";
            // 
            // btnFirst
            // 
            btnFirst.BackColor = Color.Gainsboro;
            btnFirst.FlatStyle = FlatStyle.Flat;
            btnFirst.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            btnFirst.Location = new Point(940, 12);
            btnFirst.Name = "btnFirst";
            btnFirst.Size = new Size(40, 32);
            btnFirst.TabIndex = 2;
            btnFirst.Text = "|◄";
            btnFirst.UseVisualStyleBackColor = false;
            btnFirst.Click += btnFirst_Click;
            // 
            // btnPrev
            // 
            btnPrev.BackColor = Color.Gainsboro;
            btnPrev.FlatStyle = FlatStyle.Flat;
            btnPrev.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            btnPrev.Location = new Point(984, 12);
            btnPrev.Name = "btnPrev";
            btnPrev.Size = new Size(40, 32);
            btnPrev.TabIndex = 3;
            btnPrev.Text = "◄";
            btnPrev.UseVisualStyleBackColor = false;
            btnPrev.Click += btnPrev_Click;
            // 
            // btnNext
            // 
            btnNext.BackColor = Color.Gainsboro;
            btnNext.FlatStyle = FlatStyle.Flat;
            btnNext.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            btnNext.Location = new Point(1028, 12);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(40, 32);
            btnNext.TabIndex = 4;
            btnNext.Text = "►";
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click;
            // 
            // btnLast
            // 
            btnLast.BackColor = Color.Gainsboro;
            btnLast.FlatStyle = FlatStyle.Flat;
            btnLast.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            btnLast.Location = new Point(1072, 12);
            btnLast.Name = "btnLast";
            btnLast.Size = new Size(40, 32);
            btnLast.TabIndex = 5;
            btnLast.Text = "►|";
            btnLast.UseVisualStyleBackColor = false;
            btnLast.Click += btnLast_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Gainsboro;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            btnClose.Location = new Point(1260, 12);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(90, 32);
            btnClose.TabIndex = 6;
            btnClose.Text = "關閉";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // panelFormHeader
            // 
            panelFormHeader.Controls.Add(lblEmpNo);
            panelFormHeader.Controls.Add(txtEmpNo);
            panelFormHeader.Controls.Add(lblName);
            panelFormHeader.Controls.Add(txtName);
            panelFormHeader.Controls.Add(lblTitleJob);
            panelFormHeader.Controls.Add(txtTitleJob);
            panelFormHeader.Controls.Add(lblDept);
            panelFormHeader.Controls.Add(txtDept);
            panelFormHeader.Controls.Add(lblHrNo);
            panelFormHeader.Controls.Add(txtHrNo);
            panelFormHeader.Controls.Add(lblCardNo);
            panelFormHeader.Controls.Add(txtCardNo);
            panelFormHeader.Controls.Add(lblStartDate);
            panelFormHeader.Controls.Add(dtStartDate);
            panelFormHeader.Controls.Add(lblEndDate);
            panelFormHeader.Controls.Add(dtEndDate);
            panelFormHeader.Controls.Add(btnQuery);
            panelFormHeader.Dock = DockStyle.Top;
            panelFormHeader.Location = new Point(0, 56);
            panelFormHeader.Name = "panelFormHeader";
            panelFormHeader.Size = new Size(1360, 96);
            panelFormHeader.TabIndex = 1;
            // 
            // lblEmpNo
            // 
            lblEmpNo.AutoSize = true;
            lblEmpNo.Font = new Font("微軟正黑體", 9F);
            lblEmpNo.Location = new Point(16, 15);
            lblEmpNo.Name = "lblEmpNo";
            lblEmpNo.Size = new Size(34, 16);
            lblEmpNo.TabIndex = 0;
            lblEmpNo.Text = "工號:";
            // 
            // txtEmpNo
            // 
            txtEmpNo.Font = new Font("微軟正黑體", 9F);
            txtEmpNo.Location = new Point(76, 12);
            txtEmpNo.Name = "txtEmpNo";
            txtEmpNo.ReadOnly = true;
            txtEmpNo.Size = new Size(110, 23);
            txtEmpNo.TabIndex = 1;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("微軟正黑體", 9F);
            lblName.Location = new Point(206, 15);
            lblName.Name = "lblName";
            lblName.Size = new Size(34, 16);
            lblName.TabIndex = 2;
            lblName.Text = "姓名:";
            // 
            // txtName
            // 
            txtName.Font = new Font("微軟正黑體", 9F);
            txtName.Location = new Point(266, 12);
            txtName.Name = "txtName";
            txtName.ReadOnly = true;
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 3;
            // 
            // lblTitleJob
            // 
            lblTitleJob.AutoSize = true;
            lblTitleJob.Font = new Font("微軟正黑體", 9F);
            lblTitleJob.Location = new Point(386, 15);
            lblTitleJob.Name = "lblTitleJob";
            lblTitleJob.Size = new Size(34, 16);
            lblTitleJob.TabIndex = 4;
            lblTitleJob.Text = "職稱:";
            // 
            // txtTitleJob
            // 
            txtTitleJob.Font = new Font("微軟正黑體", 9F);
            txtTitleJob.Location = new Point(446, 12);
            txtTitleJob.Name = "txtTitleJob";
            txtTitleJob.ReadOnly = true;
            txtTitleJob.Size = new Size(100, 23);
            txtTitleJob.TabIndex = 5;
            // 
            // lblDept
            // 
            lblDept.AutoSize = true;
            lblDept.Font = new Font("微軟正黑體", 9F);
            lblDept.Location = new Point(566, 15);
            lblDept.Name = "lblDept";
            lblDept.Size = new Size(46, 16);
            lblDept.TabIndex = 6;
            lblDept.Text = "單位別:";
            // 
            // txtDept
            // 
            txtDept.Font = new Font("微軟正黑體", 9F);
            txtDept.Location = new Point(636, 12);
            txtDept.Name = "txtDept";
            txtDept.ReadOnly = true;
            txtDept.Size = new Size(100, 23);
            txtDept.TabIndex = 7;
            // 
            // lblHrNo
            // 
            lblHrNo.AutoSize = true;
            lblHrNo.Font = new Font("微軟正黑體", 9F);
            lblHrNo.Location = new Point(16, 55);
            lblHrNo.Name = "lblHrNo";
            lblHrNo.Size = new Size(58, 16);
            lblHrNo.TabIndex = 8;
            lblHrNo.Text = "人事編號:";
            // 
            // txtHrNo
            // 
            txtHrNo.Font = new Font("微軟正黑體", 9F);
            txtHrNo.Location = new Point(96, 52);
            txtHrNo.Name = "txtHrNo";
            txtHrNo.ReadOnly = true;
            txtHrNo.Size = new Size(100, 23);
            txtHrNo.TabIndex = 9;
            // 
            // lblCardNo
            // 
            lblCardNo.AutoSize = true;
            lblCardNo.Font = new Font("微軟正黑體", 9F);
            lblCardNo.Location = new Point(206, 55);
            lblCardNo.Name = "lblCardNo";
            lblCardNo.Size = new Size(34, 16);
            lblCardNo.TabIndex = 10;
            lblCardNo.Text = "卡號:";
            // 
            // txtCardNo
            // 
            txtCardNo.Font = new Font("微軟正黑體", 9F);
            txtCardNo.Location = new Point(266, 52);
            txtCardNo.Name = "txtCardNo";
            txtCardNo.ReadOnly = true;
            txtCardNo.Size = new Size(100, 23);
            txtCardNo.TabIndex = 11;
            // 
            // lblStartDate
            // 
            lblStartDate.AutoSize = true;
            lblStartDate.Font = new Font("微軟正黑體", 9F);
            lblStartDate.Location = new Point(756, 15);
            lblStartDate.Name = "lblStartDate";
            lblStartDate.Size = new Size(58, 16);
            lblStartDate.TabIndex = 12;
            lblStartDate.Text = "查詢起日:";
            // 
            // dtStartDate
            // 
            dtStartDate.Font = new Font("微軟正黑體", 9F);
            dtStartDate.Format = DateTimePickerFormat.Short;
            dtStartDate.Location = new Point(836, 12);
            dtStartDate.Name = "dtStartDate";
            dtStartDate.Size = new Size(130, 23);
            dtStartDate.TabIndex = 13;
            // 
            // lblEndDate
            // 
            lblEndDate.AutoSize = true;
            lblEndDate.Font = new Font("微軟正黑體", 9F);
            lblEndDate.Location = new Point(756, 55);
            lblEndDate.Name = "lblEndDate";
            lblEndDate.Size = new Size(58, 16);
            lblEndDate.TabIndex = 14;
            lblEndDate.Text = "查詢迄日:";
            // 
            // dtEndDate
            // 
            dtEndDate.Font = new Font("微軟正黑體", 9F);
            dtEndDate.Format = DateTimePickerFormat.Short;
            dtEndDate.Location = new Point(836, 52);
            dtEndDate.Name = "dtEndDate";
            dtEndDate.Size = new Size(130, 23);
            dtEndDate.TabIndex = 15;
            // 
            // btnQuery
            // 
            btnQuery.BackColor = Color.SteelBlue;
            btnQuery.FlatStyle = FlatStyle.Flat;
            btnQuery.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            btnQuery.ForeColor = Color.White;
            btnQuery.Location = new Point(986, 12);
            btnQuery.Name = "btnQuery";
            btnQuery.Size = new Size(80, 65);
            btnQuery.TabIndex = 16;
            btnQuery.Text = "查詢";
            btnQuery.UseVisualStyleBackColor = false;
            btnQuery.Click += btnQuery_Click;
            // 
            // panelBody
            // 
            panelBody.Controls.Add(dataGridView1);
            panelBody.Controls.Add(panelFooter);
            panelBody.Dock = DockStyle.Fill;
            panelBody.Location = new Point(0, 152);
            panelBody.Name = "panelBody";
            panelBody.Size = new Size(1360, 548);
            panelBody.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colDate, colShift, colOtStart, colOtEnd, colHours, colReason, colOtHours, colOtPay, colHourlyPay });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Font = new Font("微軟正黑體", 9F);
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 26;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1360, 508);
            dataGridView1.TabIndex = 0;
            // 
            // colDate
            // 
            colDate.HeaderText = "日期";
            colDate.Name = "colDate";
            colDate.ReadOnly = true;
            colDate.Width = 90;
            // 
            // colShift
            // 
            colShift.HeaderText = "班次";
            colShift.Name = "colShift";
            colShift.ReadOnly = true;
            colShift.Width = 80;
            // 
            // colOtStart
            // 
            colOtStart.HeaderText = "加班上班";
            colOtStart.Name = "colOtStart";
            colOtStart.ReadOnly = true;
            colOtStart.Width = 70;
            // 
            // colOtEnd
            // 
            colOtEnd.HeaderText = "加班下班";
            colOtEnd.Name = "colOtEnd";
            colOtEnd.ReadOnly = true;
            colOtEnd.Width = 70;
            // 
            // colHours
            // 
            colHours.HeaderText = "時數";
            colHours.Name = "colHours";
            colHours.ReadOnly = true;
            colHours.Width = 60;
            // 
            // colReason
            // 
            colReason.HeaderText = "加班事由";
            colReason.Name = "colReason";
            colReason.ReadOnly = true;
            colReason.Width = 110;
            // 
            // colOtHours
            // 
            colOtHours.HeaderText = "加班時數";
            colOtHours.Name = "colOtHours";
            colOtHours.ReadOnly = true;
            colOtHours.Width = 70;
            // 
            // colOtPay
            // 
            colOtPay.HeaderText = "加班費";
            colOtPay.Name = "colOtPay";
            colOtPay.ReadOnly = true;
            colOtPay.Width = 70;
            // 
            // colHourlyPay
            // 
            colHourlyPay.HeaderText = "時薪";
            colHourlyPay.Name = "colHourlyPay";
            colHourlyPay.ReadOnly = true;
            colHourlyPay.Width = 70;
            // 
            // panelFooter
            // 
            panelFooter.BackColor = Color.WhiteSmoke;
            panelFooter.Controls.Add(lblSumHours);
            panelFooter.Controls.Add(lblSumPay);
            panelFooter.Dock = DockStyle.Bottom;
            panelFooter.Location = new Point(0, 508);
            panelFooter.Name = "panelFooter";
            panelFooter.Size = new Size(1360, 40);
            panelFooter.TabIndex = 1;
            // 
            // lblSumHours
            // 
            lblSumHours.AutoSize = true;
            lblSumHours.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            lblSumHours.Location = new Point(16, 10);
            lblSumHours.Name = "lblSumHours";
            lblSumHours.Size = new Size(114, 18);
            lblSumHours.TabIndex = 0;
            lblSumHours.Text = "合計加班時數：0";
            // 
            // lblSumPay
            // 
            lblSumPay.AutoSize = true;
            lblSumPay.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            lblSumPay.ForeColor = Color.Firebrick;
            lblSumPay.Location = new Point(220, 10);
            lblSumPay.Name = "lblSumPay";
            lblSumPay.Size = new Size(100, 18);
            lblSumPay.TabIndex = 1;
            lblSumPay.Text = "合計加班費：0";
            // 
            // OverTimeDetail
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelBody);
            Controls.Add(panelFormHeader);
            Controls.Add(panelHeader);
            Font = new Font("微軟正黑體", 10F);
            Margin = new Padding(4);
            Name = "OverTimeDetail";
            Size = new Size(1360, 700);
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelFormHeader.ResumeLayout(false);
            panelFormHeader.PerformLayout();
            panelBody.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panelFooter.ResumeLayout(false);
            panelFooter.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private PictureBox pictureBox1;
        private Label lblTitle;
        private Button btnFirst;
        private Button btnPrev;
        private Button btnNext;
        private Button btnLast;
        private Button btnClose;
        private Panel panelFormHeader;
        private Label lblEmpNo;
        private TextBox txtEmpNo;
        private Label lblName;
        private TextBox txtName;
        private Label lblTitleJob;
        private TextBox txtTitleJob;
        private Label lblDept;
        private TextBox txtDept;
        private Label lblHrNo;
        private TextBox txtHrNo;
        private Label lblCardNo;
        private TextBox txtCardNo;
        private Label lblStartDate;
        private DateTimePicker dtStartDate;
        private Label lblEndDate;
        private DateTimePicker dtEndDate;
        private Button btnQuery;
        private Panel panelBody;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn colDate;
        private DataGridViewTextBoxColumn colShift;
        private DataGridViewTextBoxColumn colOtStart;
        private DataGridViewTextBoxColumn colOtEnd;
        private DataGridViewTextBoxColumn colHours;
        private DataGridViewTextBoxColumn colReason;
        private DataGridViewTextBoxColumn colOtHours;
        private DataGridViewTextBoxColumn colOtPay;
        private DataGridViewTextBoxColumn colHourlyPay;
        private Panel panelFooter;
        private Label lblSumHours;
        private Label lblSumPay;
    }
}
