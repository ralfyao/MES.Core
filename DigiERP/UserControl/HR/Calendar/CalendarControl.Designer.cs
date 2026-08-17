using System.Drawing;
using System.Windows.Forms;

namespace DigiERP.UserControl.HR.Calendar
{
    partial class CalendarControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalendarControl));
            panelHeader = new Panel();
            lblTitle = new Label();
            btnLast = new Button();
            btnModify = new Button();
            btnSave = new Button();
            btnAddRow = new Button();
            btnExit = new Button();
            panelBody = new Panel();
            dataGridView1 = new DataGridView();
            colDate = new DataGridViewTextBoxColumn();
            colWeekday = new DataGridViewTextBoxColumn();
            colHoliday = new DataGridViewCheckBoxColumn();
            colNotice = new DataGridViewTextBoxColumn();
            colHRHandler = new DataGridViewTextBoxColumn();
            colApproved = new DataGridViewCheckBoxColumn();
            colApprover = new DataGridViewTextBoxColumn();
            pictureBox1 = new PictureBox();
            panelHeader.SuspendLayout();
            panelBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.Moccasin;
            panelHeader.Controls.Add(pictureBox1);
            panelHeader.Controls.Add(lblTitle);
            panelHeader.Controls.Add(btnLast);
            panelHeader.Controls.Add(btnModify);
            panelHeader.Controls.Add(btnSave);
            panelHeader.Controls.Add(btnAddRow);
            panelHeader.Controls.Add(btnExit);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1200, 56);
            panelHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("微軟正黑體", 14F, FontStyle.Bold);
            lblTitle.ForeColor = Color.Firebrick;
            lblTitle.Location = new Point(63, 16);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(124, 24);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "日行事曆一覽";
            // 
            // btnLast
            // 
            btnLast.BackColor = Color.Gainsboro;
            btnLast.FlatStyle = FlatStyle.Flat;
            btnLast.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            btnLast.Location = new Point(280, 12);
            btnLast.Name = "btnLast";
            btnLast.Size = new Size(100, 32);
            btnLast.TabIndex = 1;
            btnLast.Text = "最後一筆記錄";
            btnLast.UseVisualStyleBackColor = false;
            btnLast.Click += btnLast_Click;
            // 
            // btnModify
            // 
            btnModify.BackColor = Color.SteelBlue;
            btnModify.FlatStyle = FlatStyle.Flat;
            btnModify.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            btnModify.ForeColor = Color.White;
            btnModify.Location = new Point(390, 12);
            btnModify.Name = "btnModify";
            btnModify.Size = new Size(100, 32);
            btnModify.TabIndex = 2;
            btnModify.Text = "增修日曆天";
            btnModify.UseVisualStyleBackColor = false;
            btnModify.Click += btnModify_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.SeaGreen;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(500, 12);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(90, 32);
            btnSave.TabIndex = 3;
            btnSave.Text = "儲存";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Visible = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnAddRow
            // 
            btnAddRow.BackColor = Color.LightSteelBlue;
            btnAddRow.FlatStyle = FlatStyle.Flat;
            btnAddRow.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            btnAddRow.Location = new Point(600, 12);
            btnAddRow.Name = "btnAddRow";
            btnAddRow.Size = new Size(100, 32);
            btnAddRow.TabIndex = 4;
            btnAddRow.Text = "新增一筆";
            btnAddRow.UseVisualStyleBackColor = false;
            btnAddRow.Visible = false;
            btnAddRow.Click += btnAddRow_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Gainsboro;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            btnExit.Location = new Point(1090, 12);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(100, 32);
            btnExit.TabIndex = 5;
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
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colDate, colWeekday, colHoliday, colNotice, colHRHandler, colApproved, colApprover });
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
            // colDate
            // 
            colDate.HeaderText = "日期";
            colDate.Name = "colDate";
            colDate.ReadOnly = true;
            // 
            // colWeekday
            // 
            colWeekday.HeaderText = "週次";
            colWeekday.Name = "colWeekday";
            colWeekday.ReadOnly = true;
            colWeekday.Width = 50;
            // 
            // colHoliday
            // 
            colHoliday.HeaderText = "例假日";
            colHoliday.Name = "colHoliday";
            colHoliday.ReadOnly = true;
            colHoliday.Width = 60;
            // 
            // colNotice
            // 
            colNotice.HeaderText = "公告事項";
            colNotice.Name = "colNotice";
            colNotice.ReadOnly = true;
            colNotice.Width = 350;
            // 
            // colHRHandler
            // 
            colHRHandler.HeaderText = "人事經辦";
            colHRHandler.Name = "colHRHandler";
            colHRHandler.ReadOnly = true;
            colHRHandler.Width = 90;
            // 
            // colApproved
            // 
            colApproved.HeaderText = "核准生效";
            colApproved.Name = "colApproved";
            colApproved.ReadOnly = true;
            colApproved.Width = 70;
            // 
            // colApprover
            // 
            colApprover.HeaderText = "核准人";
            colApprover.Name = "colApprover";
            colApprover.ReadOnly = true;
            colApprover.Width = 90;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(4, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(56, 48);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // CalendarControl
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelBody);
            Controls.Add(panelHeader);
            Font = new Font("微軟正黑體", 10F);
            Margin = new Padding(4);
            Name = "CalendarControl";
            Size = new Size(1200, 656);
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelBody.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private Label lblTitle;
        private Button btnLast;
        private Button btnModify;
        private Button btnSave;
        private Button btnAddRow;
        private Button btnExit;
        private Panel panelBody;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn colDate;
        private DataGridViewTextBoxColumn colWeekday;
        private DataGridViewCheckBoxColumn colHoliday;
        private DataGridViewTextBoxColumn colNotice;
        private DataGridViewTextBoxColumn colHRHandler;
        private DataGridViewCheckBoxColumn colApproved;
        private DataGridViewTextBoxColumn colApprover;
        private PictureBox pictureBox1;
    }
}
