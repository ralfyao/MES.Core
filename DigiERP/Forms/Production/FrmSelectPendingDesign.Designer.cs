using System.Drawing;
using System.Windows.Forms;

namespace DigiERP.Forms.Production
{
    partial class FrmSelectPendingDesign
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
            panelToolbar = new Panel();
            lblTitle = new Label();
            btnConfirm = new Button();
            dataGridView1 = new DataGridView();
            colProjectNo = new DataGridViewTextBoxColumn();
            colModuleCode = new DataGridViewTextBoxColumn();
            colModuleName = new DataGridViewTextBoxColumn();
            colDesigner = new DataGridViewTextBoxColumn();
            colDrawingFile = new DataGridViewTextBoxColumn();
            colDrawingIssueDate = new DataGridViewTextBoxColumn();
            panelToolbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            //
            // panelToolbar
            //
            panelToolbar.BackColor = Color.FromArgb(230, 230, 250);
            panelToolbar.Controls.Add(lblTitle);
            panelToolbar.Controls.Add(btnConfirm);
            panelToolbar.Dock = DockStyle.Top;
            panelToolbar.Location = new Point(0, 0);
            panelToolbar.Name = "panelToolbar";
            panelToolbar.Size = new Size(1000, 48);
            panelToolbar.TabIndex = 0;
            //
            // lblTitle
            //
            lblTitle.Font = new Font("微軟正黑體", 12F, FontStyle.Bold);
            lblTitle.Location = new Point(16, 12);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(260, 24);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "選擇審查項目(設計派案)";
            //
            // btnConfirm
            //
            btnConfirm.BackColor = Color.FromArgb(198, 216, 255);
            btnConfirm.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            btnConfirm.Location = new Point(860, 6);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(120, 36);
            btnConfirm.TabIndex = 1;
            btnConfirm.Text = "確定選擇";
            btnConfirm.UseVisualStyleBackColor = false;
            btnConfirm.Click += btnConfirm_Click;
            //
            // dataGridView1
            //
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(230, 230, 250);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colProjectNo, colModuleCode, colModuleName, colDesigner, colDrawingFile, colDrawingIssueDate });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Font = new Font("微軟正黑體", 10F);
            dataGridView1.Location = new Point(0, 48);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 28;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1000, 552);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            //
            // colProjectNo
            //
            colProjectNo.HeaderText = "專案序號";
            colProjectNo.Name = "colProjectNo";
            colProjectNo.ReadOnly = true;
            //
            // colModuleCode
            //
            colModuleCode.HeaderText = "模組編碼";
            colModuleCode.Name = "colModuleCode";
            colModuleCode.ReadOnly = true;
            //
            // colModuleName
            //
            colModuleName.FillWeight = 150F;
            colModuleName.HeaderText = "模組名稱";
            colModuleName.Name = "colModuleName";
            colModuleName.ReadOnly = true;
            //
            // colDesigner
            //
            colDesigner.HeaderText = "設計人員";
            colDesigner.Name = "colDesigner";
            colDesigner.ReadOnly = true;
            //
            // colDrawingFile
            //
            colDrawingFile.FillWeight = 150F;
            colDrawingFile.HeaderText = "製圖檔名";
            colDrawingFile.Name = "colDrawingFile";
            colDrawingFile.ReadOnly = true;
            //
            // colDrawingIssueDate
            //
            colDrawingIssueDate.HeaderText = "圖檔發行日";
            colDrawingIssueDate.Name = "colDrawingIssueDate";
            colDrawingIssueDate.ReadOnly = true;
            //
            // FrmSelectPendingDesign
            //
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 600);
            Controls.Add(dataGridView1);
            Controls.Add(panelToolbar);
            Font = new Font("微軟正黑體", 10F);
            MinimumSize = new Size(700, 400);
            Name = "FrmSelectPendingDesign";
            StartPosition = FormStartPosition.CenterParent;
            Text = "選擇審查項目";
            panelToolbar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelToolbar;
        private Label lblTitle;
        private Button btnConfirm;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn colProjectNo;
        private DataGridViewTextBoxColumn colModuleCode;
        private DataGridViewTextBoxColumn colModuleName;
        private DataGridViewTextBoxColumn colDesigner;
        private DataGridViewTextBoxColumn colDrawingFile;
        private DataGridViewTextBoxColumn colDrawingIssueDate;
    }
}
