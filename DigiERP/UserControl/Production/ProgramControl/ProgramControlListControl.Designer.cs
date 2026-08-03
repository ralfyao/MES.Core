using System.Drawing;
using System.Windows.Forms;

namespace DigiERP.UserControl.Production.ProgramControl
{
    partial class ProgramControlListControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProgramControlListControl));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            lblTitle = new Label();
            btnModify = new Button();
            btnSave = new Button();
            btnPrint = new Button();
            btnClose = new Button();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            colProjectNo = new DataGridViewTextBoxColumn();
            colProcess = new DataGridViewComboBoxColumn();
            colDesc = new DataGridViewTextBoxColumn();
            colStaff = new DataGridViewComboBoxColumn();
            colStartDate = new DigiERP.Common.DataGridViewDateTimePickerColumn();
            colPlanFinishDate = new DigiERP.Common.DataGridViewDateTimePickerColumn();
            colActualFinishDate = new DigiERP.Common.DataGridViewDateTimePickerColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 224, 192);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(lblTitle);
            panel1.Controls.Add(btnModify);
            panel1.Controls.Add(btnSave);
            panel1.Controls.Add(btnPrint);
            panel1.Controls.Add(btnClose);
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
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("微軟正黑體", 13F, FontStyle.Bold);
            lblTitle.ForeColor = Color.Firebrick;
            lblTitle.Location = new Point(60, 16);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(82, 23);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "電控排程";
            // 
            // btnModify
            // 
            btnModify.BackColor = Color.Gainsboro;
            btnModify.FlatStyle = FlatStyle.Flat;
            btnModify.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            btnModify.Location = new Point(1480, 12);
            btnModify.Name = "btnModify";
            btnModify.Size = new Size(98, 32);
            btnModify.TabIndex = 1;
            btnModify.Text = "修改";
            btnModify.UseVisualStyleBackColor = false;
            btnModify.Click += btnModify_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Gainsboro;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            btnSave.Location = new Point(1584, 12);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(98, 32);
            btnSave.TabIndex = 2;
            btnSave.Text = "儲存";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnPrint
            // 
            btnPrint.BackColor = Color.Gainsboro;
            btnPrint.FlatStyle = FlatStyle.Flat;
            btnPrint.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            btnPrint.Location = new Point(1688, 12);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(98, 32);
            btnPrint.TabIndex = 3;
            btnPrint.Text = "列印";
            btnPrint.UseVisualStyleBackColor = false;
            btnPrint.Click += btnPrint_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Gainsboro;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            btnClose.Location = new Point(1792, 12);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(98, 32);
            btnClose.TabIndex = 4;
            btnClose.Text = "關閉";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
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
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colProjectNo, colProcess, colDesc, colStaff, colStartDate, colPlanFinishDate, colActualFinishDate });
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
            dataGridView1.DataError += dataGridView1_DataError;
            dataGridView1.EditingControlShowing += dataGridView1_EditingControlShowing;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // colProjectNo
            // 
            colProjectNo.HeaderText = "專案序號";
            colProjectNo.Name = "colProjectNo";
            colProjectNo.ReadOnly = true;
            // 
            // colProcess
            // 
            colProcess.HeaderText = "電控工序";
            colProcess.Name = "colProcess";
            colProcess.ReadOnly = true;
            // 
            // colDesc
            // 
            colDesc.FillWeight = 200F;
            colDesc.HeaderText = "簡要描述(或測試作業名稱)";
            colDesc.Name = "colDesc";
            colDesc.ReadOnly = true;
            // 
            // colStaff
            // 
            colStaff.HeaderText = "程控人員";
            colStaff.Name = "colStaff";
            colStaff.ReadOnly = true;
            // 
            // colStartDate
            // 
            colStartDate.HeaderText = "開始作業日期";
            colStartDate.Name = "colStartDate";
            colStartDate.ReadOnly = true;
            // 
            // colPlanFinishDate
            // 
            colPlanFinishDate.HeaderText = "預計完成日期";
            colPlanFinishDate.Name = "colPlanFinishDate";
            colPlanFinishDate.ReadOnly = true;
            // 
            // colActualFinishDate
            // 
            colActualFinishDate.HeaderText = "實際完成日期";
            colActualFinishDate.Name = "colActualFinishDate";
            colActualFinishDate.ReadOnly = true;
            // 
            // ProgramControlListControl
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("微軟正黑體", 10F);
            Margin = new Padding(4);
            Name = "ProgramControlListControl";
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
        private Button btnModify;
        private Button btnSave;
        private Button btnPrint;
        private Button btnClose;
        private Panel panel2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn colProjectNo;
        private DataGridViewComboBoxColumn colProcess;
        private DataGridViewTextBoxColumn colDesc;
        private DataGridViewComboBoxColumn colStaff;
        private DigiERP.Common.DataGridViewDateTimePickerColumn colStartDate;
        private DigiERP.Common.DataGridViewDateTimePickerColumn colPlanFinishDate;
        private DigiERP.Common.DataGridViewDateTimePickerColumn colActualFinishDate;
    }
}
