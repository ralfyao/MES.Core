using DigiERP.Common;
using System.Drawing;
using System.Windows.Forms;

namespace DigiERP.Forms.HR.CostUnit
{
    partial class FrmCostUnit
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
            lblRecordInfo = new Label();
            btnPrev = new Button();
            btnNext = new Button();
            btnNew = new Button();
            btnModify = new Button();
            btnSave = new Button();
            btnExit = new Button();
            panelFormHeader = new Panel();
            lblPosition = new Label();
            txtPosition = new TextBox();
            lblHeadcount = new Label();
            numHeadcount = new NumericUpDown();
            lblParentUnit1 = new Label();
            txtParentUnit1 = new TextBox();
            lblParentUnit2 = new Label();
            txtParentUnit2 = new TextBox();
            lblOperationFunction = new Label();
            txtOperationFunction = new TextBox();
            panelBody = new Panel();
            dataGridView1 = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colAccount = new DataGridViewComboBoxColumn();
            colName = new DataGridViewTextBoxColumn();
            colApprove = new DataGridViewCheckBoxColumn();
            colEdit = new DataGridViewCheckBoxColumn();
            colReport = new DataGridViewCheckBoxColumn();
            colOutput = new DataGridViewCheckBoxColumn();
            colNote = new DataGridViewTextBoxColumn();
            colDelegateExpiry = new DataGridViewDateTimePickerColumn();
            colMachineNo = new DataGridViewTextBoxColumn();
            panelGridTool = new Panel();
            btnAddDetailRow = new Button();
            btnDeleteDetailRow = new Button();
            lblStaffTitle = new Label();
            panelHeader.SuspendLayout();
            panelFormHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numHeadcount).BeginInit();
            panelBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panelGridTool.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.LightGreen;
            panelHeader.Controls.Add(lblTitle);
            panelHeader.Controls.Add(lblRecordInfo);
            panelHeader.Controls.Add(btnPrev);
            panelHeader.Controls.Add(btnNext);
            panelHeader.Controls.Add(btnNew);
            panelHeader.Controls.Add(btnModify);
            panelHeader.Controls.Add(btnSave);
            panelHeader.Controls.Add(btnExit);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1000, 56);
            panelHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("微軟正黑體", 13F, FontStyle.Bold);
            lblTitle.ForeColor = Color.Firebrick;
            lblTitle.Location = new Point(16, 4);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(82, 23);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "成本單位";
            // 
            // lblRecordInfo
            // 
            lblRecordInfo.AutoSize = true;
            lblRecordInfo.Font = new Font("微軟正黑體", 9F);
            lblRecordInfo.Location = new Point(16, 30);
            lblRecordInfo.Name = "lblRecordInfo";
            lblRecordInfo.Size = new Size(92, 16);
            lblRecordInfo.TabIndex = 1;
            lblRecordInfo.Text = "第 0 筆 / 共 0 筆";
            // 
            // btnPrev
            // 
            btnPrev.BackColor = Color.Gainsboro;
            btnPrev.FlatStyle = FlatStyle.Flat;
            btnPrev.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            btnPrev.Location = new Point(170, 12);
            btnPrev.Name = "btnPrev";
            btnPrev.Size = new Size(70, 32);
            btnPrev.TabIndex = 2;
            btnPrev.Text = "前一筆";
            btnPrev.UseVisualStyleBackColor = false;
            btnPrev.Click += btnPrev_Click;
            // 
            // btnNext
            // 
            btnNext.BackColor = Color.Gainsboro;
            btnNext.FlatStyle = FlatStyle.Flat;
            btnNext.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            btnNext.Location = new Point(246, 12);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(70, 32);
            btnNext.TabIndex = 3;
            btnNext.Text = "下一筆";
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click;
            // 
            // btnNew
            // 
            btnNew.BackColor = Color.LightSteelBlue;
            btnNew.FlatStyle = FlatStyle.Flat;
            btnNew.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            btnNew.Location = new Point(326, 12);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(90, 32);
            btnNew.TabIndex = 4;
            btnNew.Text = "新增職務";
            btnNew.UseVisualStyleBackColor = false;
            btnNew.Click += btnNew_Click;
            // 
            // btnModify
            // 
            btnModify.BackColor = Color.SteelBlue;
            btnModify.FlatStyle = FlatStyle.Flat;
            btnModify.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            btnModify.ForeColor = Color.White;
            btnModify.Location = new Point(422, 12);
            btnModify.Name = "btnModify";
            btnModify.Size = new Size(80, 32);
            btnModify.TabIndex = 5;
            btnModify.Text = "編修記錄";
            btnModify.UseVisualStyleBackColor = false;
            btnModify.Click += btnModify_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.SeaGreen;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(422, 12);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(80, 32);
            btnSave.TabIndex = 6;
            btnSave.Text = "儲存記錄";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Visible = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Gainsboro;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            btnExit.Location = new Point(880, 12);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(100, 32);
            btnExit.TabIndex = 7;
            btnExit.Text = "關閉表單";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // panelFormHeader
            // 
            panelFormHeader.Controls.Add(lblPosition);
            panelFormHeader.Controls.Add(txtPosition);
            panelFormHeader.Controls.Add(lblHeadcount);
            panelFormHeader.Controls.Add(numHeadcount);
            panelFormHeader.Controls.Add(lblParentUnit1);
            panelFormHeader.Controls.Add(txtParentUnit1);
            panelFormHeader.Controls.Add(lblParentUnit2);
            panelFormHeader.Controls.Add(txtParentUnit2);
            panelFormHeader.Controls.Add(lblOperationFunction);
            panelFormHeader.Controls.Add(txtOperationFunction);
            panelFormHeader.Dock = DockStyle.Top;
            panelFormHeader.Location = new Point(0, 56);
            panelFormHeader.Name = "panelFormHeader";
            panelFormHeader.Size = new Size(1000, 96);
            panelFormHeader.TabIndex = 1;
            // 
            // lblPosition
            // 
            lblPosition.AutoSize = true;
            lblPosition.Font = new Font("微軟正黑體", 9F);
            lblPosition.Location = new Point(16, 15);
            lblPosition.Name = "lblPosition";
            lblPosition.Size = new Size(34, 16);
            lblPosition.TabIndex = 0;
            lblPosition.Text = "職務:";
            // 
            // txtPosition
            // 
            txtPosition.Font = new Font("微軟正黑體", 9F);
            txtPosition.Location = new Point(76, 12);
            txtPosition.MaxLength = 12;
            txtPosition.Name = "txtPosition";
            txtPosition.Size = new Size(150, 23);
            txtPosition.TabIndex = 1;
            // 
            // lblHeadcount
            // 
            lblHeadcount.AutoSize = true;
            lblHeadcount.Font = new Font("微軟正黑體", 9F);
            lblHeadcount.Location = new Point(246, 15);
            lblHeadcount.Name = "lblHeadcount";
            lblHeadcount.Size = new Size(58, 16);
            lblHeadcount.TabIndex = 2;
            lblHeadcount.Text = "標準編制:";
            // 
            // numHeadcount
            // 
            numHeadcount.Font = new Font("微軟正黑體", 9F);
            numHeadcount.Location = new Point(326, 12);
            numHeadcount.Maximum = new decimal(new int[] { 999, 0, 0, 0 });
            numHeadcount.Name = "numHeadcount";
            numHeadcount.Size = new Size(100, 23);
            numHeadcount.TabIndex = 3;
            // 
            // lblParentUnit1
            // 
            lblParentUnit1.AutoSize = true;
            lblParentUnit1.Font = new Font("微軟正黑體", 9F);
            lblParentUnit1.Location = new Point(16, 55);
            lblParentUnit1.Name = "lblParentUnit1";
            lblParentUnit1.Size = new Size(70, 16);
            lblParentUnit1.TabIndex = 4;
            lblParentUnit1.Text = "上一級單位:";
            // 
            // txtParentUnit1
            // 
            txtParentUnit1.Font = new Font("微軟正黑體", 9F);
            txtParentUnit1.Location = new Point(96, 52);
            txtParentUnit1.MaxLength = 12;
            txtParentUnit1.Name = "txtParentUnit1";
            txtParentUnit1.Size = new Size(150, 23);
            txtParentUnit1.TabIndex = 5;
            // 
            // lblParentUnit2
            // 
            lblParentUnit2.AutoSize = true;
            lblParentUnit2.Font = new Font("微軟正黑體", 9F);
            lblParentUnit2.Location = new Point(266, 55);
            lblParentUnit2.Name = "lblParentUnit2";
            lblParentUnit2.Size = new Size(70, 16);
            lblParentUnit2.TabIndex = 6;
            lblParentUnit2.Text = "上兩級單位:";
            // 
            // txtParentUnit2
            // 
            txtParentUnit2.Font = new Font("微軟正黑體", 9F);
            txtParentUnit2.Location = new Point(346, 52);
            txtParentUnit2.MaxLength = 12;
            txtParentUnit2.Name = "txtParentUnit2";
            txtParentUnit2.Size = new Size(150, 23);
            txtParentUnit2.TabIndex = 7;
            // 
            // lblOperationFunction
            // 
            lblOperationFunction.AutoSize = true;
            lblOperationFunction.Font = new Font("微軟正黑體", 9F);
            lblOperationFunction.Location = new Point(516, 55);
            lblOperationFunction.Name = "lblOperationFunction";
            lblOperationFunction.Size = new Size(82, 16);
            lblOperationFunction.TabIndex = 8;
            lblOperationFunction.Text = "操作功能權限:";
            // 
            // txtOperationFunction
            // 
            txtOperationFunction.Font = new Font("微軟正黑體", 9F);
            txtOperationFunction.Location = new Point(616, 52);
            txtOperationFunction.MaxLength = 150;
            txtOperationFunction.Name = "txtOperationFunction";
            txtOperationFunction.Size = new Size(330, 23);
            txtOperationFunction.TabIndex = 9;
            // 
            // panelBody
            // 
            panelBody.Controls.Add(dataGridView1);
            panelBody.Controls.Add(panelGridTool);
            panelBody.Controls.Add(lblStaffTitle);
            panelBody.Dock = DockStyle.Fill;
            panelBody.Location = new Point(0, 152);
            panelBody.Name = "panelBody";
            panelBody.Size = new Size(1000, 448);
            panelBody.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colId, colAccount, colName, colApprove, colEdit, colReport, colOutput, colNote, colDelegateExpiry, colMachineNo });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Font = new Font("微軟正黑體", 9F);
            dataGridView1.Location = new Point(0, 70);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 26;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1000, 378);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellEndEdit += dataGridView1_CellEndEdit;
            dataGridView1.CurrentCellDirtyStateChanged += dataGridView1_CurrentCellDirtyStateChanged;
            // 
            // colId
            // 
            colId.HeaderText = "識別碼";
            colId.Name = "colId";
            colId.ReadOnly = true;
            colId.Visible = false;
            // 
            // colAccount
            // 
            colAccount.HeaderText = "員工編號";
            colAccount.Name = "colAccount";
            colAccount.ReadOnly = true;
            colAccount.Width = 90;
            // 
            // colName
            // 
            colName.HeaderText = "姓名";
            colName.Name = "colName";
            colName.ReadOnly = true;
            colName.Width = 90;
            // 
            // colApprove
            // 
            colApprove.HeaderText = "核准權";
            colApprove.Name = "colApprove";
            colApprove.ReadOnly = true;
            colApprove.Width = 60;
            // 
            // colEdit
            // 
            colEdit.HeaderText = "新增編修";
            colEdit.Name = "colEdit";
            colEdit.ReadOnly = true;
            colEdit.Width = 70;
            // 
            // colReport
            // 
            colReport.HeaderText = "報表列印";
            colReport.Name = "colReport";
            colReport.ReadOnly = true;
            colReport.Width = 70;
            // 
            // colOutput
            // 
            colOutput.HeaderText = "資料輸出";
            colOutput.Name = "colOutput";
            colOutput.ReadOnly = true;
            colOutput.Width = 70;
            // 
            // colNote
            // 
            colNote.HeaderText = "註記";
            colNote.Name = "colNote";
            colNote.ReadOnly = true;
            colNote.Width = 150;
            // 
            // colDelegateExpiry
            // 
            colDelegateExpiry.HeaderText = "職務代理效期";
            colDelegateExpiry.Name = "colDelegateExpiry";
            colDelegateExpiry.ReadOnly = true;
            // 
            // colMachineNo
            // 
            colMachineNo.HeaderText = "機號";
            colMachineNo.Name = "colMachineNo";
            colMachineNo.ReadOnly = true;
            colMachineNo.Width = 90;
            // 
            // panelGridTool
            // 
            panelGridTool.Controls.Add(btnAddDetailRow);
            panelGridTool.Controls.Add(btnDeleteDetailRow);
            panelGridTool.Dock = DockStyle.Top;
            panelGridTool.Location = new Point(0, 30);
            panelGridTool.Name = "panelGridTool";
            panelGridTool.Size = new Size(1000, 40);
            panelGridTool.TabIndex = 0;
            // 
            // btnAddDetailRow
            // 
            btnAddDetailRow.BackColor = Color.LightSteelBlue;
            btnAddDetailRow.FlatStyle = FlatStyle.Flat;
            btnAddDetailRow.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            btnAddDetailRow.Location = new Point(10, 4);
            btnAddDetailRow.Name = "btnAddDetailRow";
            btnAddDetailRow.Size = new Size(90, 32);
            btnAddDetailRow.TabIndex = 0;
            btnAddDetailRow.Text = "新增人員";
            btnAddDetailRow.UseVisualStyleBackColor = false;
            btnAddDetailRow.Click += btnAddDetailRow_Click;
            // 
            // btnDeleteDetailRow
            // 
            btnDeleteDetailRow.BackColor = Color.Gainsboro;
            btnDeleteDetailRow.FlatStyle = FlatStyle.Flat;
            btnDeleteDetailRow.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            btnDeleteDetailRow.Location = new Point(106, 4);
            btnDeleteDetailRow.Name = "btnDeleteDetailRow";
            btnDeleteDetailRow.Size = new Size(90, 32);
            btnDeleteDetailRow.TabIndex = 1;
            btnDeleteDetailRow.Text = "刪除人員";
            btnDeleteDetailRow.UseVisualStyleBackColor = false;
            btnDeleteDetailRow.Click += btnDeleteDetailRow_Click;
            // 
            // lblStaffTitle
            // 
            lblStaffTitle.AutoSize = true;
            lblStaffTitle.Dock = DockStyle.Top;
            lblStaffTitle.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            lblStaffTitle.Location = new Point(0, 0);
            lblStaffTitle.Name = "lblStaffTitle";
            lblStaffTitle.Padding = new Padding(10, 6, 0, 6);
            lblStaffTitle.Size = new Size(130, 30);
            lblStaffTitle.TabIndex = 2;
            lblStaffTitle.Text = "成本單位人員配置";
            // 
            // FrmCostUnit
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 600);
            Controls.Add(panelBody);
            Controls.Add(panelFormHeader);
            Controls.Add(panelHeader);
            Font = new Font("微軟正黑體", 10F);
            MinimumSize = new Size(800, 500);
            Name = "FrmCostUnit";
            StartPosition = FormStartPosition.CenterParent;
            Text = "成本單位";
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelFormHeader.ResumeLayout(false);
            panelFormHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numHeadcount).EndInit();
            panelBody.ResumeLayout(false);
            panelBody.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panelGridTool.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private Label lblTitle;
        private Label lblRecordInfo;
        private Button btnPrev;
        private Button btnNext;
        private Button btnNew;
        private Button btnModify;
        private Button btnSave;
        private Button btnExit;
        private Panel panelFormHeader;
        private Label lblPosition;
        private TextBox txtPosition;
        private Label lblHeadcount;
        private NumericUpDown numHeadcount;
        private Label lblParentUnit1;
        private TextBox txtParentUnit1;
        private Label lblParentUnit2;
        private TextBox txtParentUnit2;
        private Label lblOperationFunction;
        private TextBox txtOperationFunction;
        private Panel panelBody;
        private Label lblStaffTitle;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewComboBoxColumn colAccount;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewCheckBoxColumn colApprove;
        private DataGridViewCheckBoxColumn colEdit;
        private DataGridViewCheckBoxColumn colReport;
        private DataGridViewCheckBoxColumn colOutput;
        private DataGridViewTextBoxColumn colNote;
        private DataGridViewDateTimePickerColumn colDelegateExpiry;
        private DataGridViewTextBoxColumn colMachineNo;
        private Panel panelGridTool;
        private Button btnAddDetailRow;
        private Button btnDeleteDetailRow;
    }
}
