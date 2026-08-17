using System.Drawing;
using System.Windows.Forms;

namespace DigiERP.Forms.HR.ClockInOut
{
    partial class FrmDailyCalendarOverview
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            panelHeader = new Panel();
            lblTitle = new Label();
            btnLast = new Button();
            btnExit = new Button();
            lblHint = new Label();
            panelBody = new Panel();
            dataGridView1 = new DataGridView();
            colDate = new DataGridViewTextBoxColumn();
            colWeekday = new DataGridViewTextBoxColumn();
            colHoliday = new DataGridViewCheckBoxColumn();
            panelHeader.SuspendLayout();
            panelBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            //
            // panelHeader
            //
            panelHeader.BackColor = Color.Moccasin;
            panelHeader.Controls.Add(lblTitle);
            panelHeader.Controls.Add(btnLast);
            panelHeader.Controls.Add(btnExit);
            panelHeader.Controls.Add(lblHint);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(560, 56);
            panelHeader.TabIndex = 0;
            //
            // lblTitle
            //
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("微軟正黑體", 14F, FontStyle.Bold);
            lblTitle.ForeColor = Color.Firebrick;
            lblTitle.Location = new Point(10, 16);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(100, 24);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "日曆總覽";
            //
            // btnLast
            //
            btnLast.BackColor = Color.Gainsboro;
            btnLast.FlatStyle = FlatStyle.Flat;
            btnLast.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            btnLast.Location = new Point(230, 12);
            btnLast.Name = "btnLast";
            btnLast.Size = new Size(100, 32);
            btnLast.TabIndex = 1;
            btnLast.Text = "最後一筆記錄";
            btnLast.UseVisualStyleBackColor = false;
            btnLast.Click += btnLast_Click;
            //
            // btnExit
            //
            btnExit.BackColor = Color.Gainsboro;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            btnExit.Location = new Point(450, 12);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(100, 32);
            btnExit.TabIndex = 2;
            btnExit.Text = "關閉";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            //
            // lblHint
            //
            lblHint.AutoSize = true;
            lblHint.Font = new Font("微軟正黑體", 8F);
            lblHint.ForeColor = Color.DimGray;
            lblHint.Location = new Point(10, 42);
            lblHint.Name = "lblHint";
            lblHint.Size = new Size(220, 15);
            lblHint.TabIndex = 3;
            lblHint.Text = "雙擊某一天可切換回該天的每日出勤表";
            //
            // panelBody
            //
            panelBody.Controls.Add(dataGridView1);
            panelBody.Dock = DockStyle.Fill;
            panelBody.Location = new Point(0, 56);
            panelBody.Name = "panelBody";
            panelBody.Size = new Size(560, 500);
            panelBody.TabIndex = 1;
            //
            // dataGridView1
            //
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colDate, colWeekday, colHoliday });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Font = new Font("微軟正黑體", 10F);
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 26;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(560, 500);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            //
            // colDate
            //
            colDate.HeaderText = "日期";
            colDate.Name = "colDate";
            colDate.ReadOnly = true;
            //
            // colWeekday
            //
            colWeekday.FillWeight = 50F;
            colWeekday.HeaderText = "週次";
            colWeekday.Name = "colWeekday";
            colWeekday.ReadOnly = true;
            //
            // colHoliday
            //
            colHoliday.FillWeight = 60F;
            colHoliday.HeaderText = "例假日";
            colHoliday.Name = "colHoliday";
            colHoliday.ReadOnly = true;
            //
            // FrmDailyCalendarOverview
            //
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 556);
            Controls.Add(panelBody);
            Controls.Add(panelHeader);
            Font = new Font("微軟正黑體", 10F);
            MinimumSize = new Size(450, 400);
            Name = "FrmDailyCalendarOverview";
            StartPosition = FormStartPosition.CenterParent;
            Text = "每日卡鐘管理 - 日曆總覽";
            Load += FrmDailyCalendarOverview_Load;
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelBody.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private Label lblTitle;
        private Button btnLast;
        private Button btnExit;
        private Label lblHint;
        private Panel panelBody;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn colDate;
        private DataGridViewTextBoxColumn colWeekday;
        private DataGridViewCheckBoxColumn colHoliday;
    }
}
