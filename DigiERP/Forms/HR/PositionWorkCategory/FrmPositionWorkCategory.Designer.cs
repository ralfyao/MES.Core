using System.Drawing;
using System.Windows.Forms;

namespace DigiERP.Forms.HR.PositionWorkCategory
{
    partial class FrmPositionWorkCategory
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
            panelBody = new Panel();
            dataGridView1 = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colCode = new DataGridViewTextBoxColumn();
            colCategory = new DataGridViewTextBoxColumn();
            colPoints = new DataGridViewComboBoxColumn();
            colDesc = new DataGridViewTextBoxColumn();
            panelGridTool = new Panel();
            btnAddDetailRow = new Button();
            btnDeleteDetailRow = new Button();
            lblGridTitle = new Label();
            panelHeader.SuspendLayout();
            panelFormHeader.SuspendLayout();
            panelBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panelGridTool.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.Moccasin;
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
            panelHeader.Size = new Size(900, 56);
            panelHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("微軟正黑體", 13F, FontStyle.Bold);
            lblTitle.ForeColor = Color.Firebrick;
            lblTitle.Location = new Point(16, 4);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(118, 23);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "職務工作類別";
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
            btnExit.Location = new Point(780, 12);
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
            panelFormHeader.Dock = DockStyle.Top;
            panelFormHeader.Location = new Point(0, 56);
            panelFormHeader.Name = "panelFormHeader";
            panelFormHeader.Size = new Size(900, 50);
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
            // panelBody
            // 
            panelBody.Controls.Add(dataGridView1);
            panelBody.Controls.Add(panelGridTool);
            panelBody.Controls.Add(lblGridTitle);
            panelBody.Dock = DockStyle.Fill;
            panelBody.Location = new Point(0, 106);
            panelBody.Name = "panelBody";
            panelBody.Size = new Size(900, 494);
            panelBody.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colId, colCode, colCategory, colPoints, colDesc });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Font = new Font("微軟正黑體", 9F);
            dataGridView1.Location = new Point(0, 70);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 26;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(900, 424);
            dataGridView1.TabIndex = 1;
            // 
            // colId
            // 
            colId.HeaderText = "識別碼";
            colId.Name = "colId";
            colId.ReadOnly = true;
            colId.Visible = false;
            // 
            // colCode
            // 
            colCode.HeaderText = "代碼";
            colCode.MaxInputLength = 3;
            colCode.Name = "colCode";
            colCode.ReadOnly = true;
            colCode.Width = 70;
            // 
            // colCategory
            // 
            colCategory.HeaderText = "分類名稱";
            colCategory.MaxInputLength = 30;
            colCategory.Name = "colCategory";
            colCategory.ReadOnly = true;
            colCategory.Width = 200;
            // 
            // colPoints
            // 
            colPoints.HeaderText = "積分點數";
            colPoints.Name = "colPoints";
            colPoints.ReadOnly = true;
            colPoints.Width = 90;
            // 
            // colDesc
            // 
            colDesc.HeaderText = "說明";
            colDesc.MaxInputLength = 30;
            colDesc.Name = "colDesc";
            colDesc.ReadOnly = true;
            colDesc.Width = 250;
            // 
            // panelGridTool
            // 
            panelGridTool.Controls.Add(btnAddDetailRow);
            panelGridTool.Controls.Add(btnDeleteDetailRow);
            panelGridTool.Dock = DockStyle.Top;
            panelGridTool.Location = new Point(0, 30);
            panelGridTool.Name = "panelGridTool";
            panelGridTool.Size = new Size(900, 40);
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
            btnAddDetailRow.Text = "新增分類";
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
            btnDeleteDetailRow.Text = "刪除分類";
            btnDeleteDetailRow.UseVisualStyleBackColor = false;
            btnDeleteDetailRow.Click += btnDeleteDetailRow_Click;
            // 
            // lblGridTitle
            // 
            lblGridTitle.AutoSize = true;
            lblGridTitle.Dock = DockStyle.Top;
            lblGridTitle.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            lblGridTitle.Location = new Point(0, 0);
            lblGridTitle.Name = "lblGridTitle";
            lblGridTitle.Padding = new Padding(10, 6, 0, 6);
            lblGridTitle.Size = new Size(102, 30);
            lblGridTitle.TabIndex = 2;
            lblGridTitle.Text = "職務分類點數";
            // 
            // FrmPositionWorkCategory
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 600);
            Controls.Add(panelBody);
            Controls.Add(panelFormHeader);
            Controls.Add(panelHeader);
            Font = new Font("微軟正黑體", 10F);
            MinimumSize = new Size(700, 480);
            Name = "FrmPositionWorkCategory";
            StartPosition = FormStartPosition.CenterParent;
            Text = "職務工作類別";
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelFormHeader.ResumeLayout(false);
            panelFormHeader.PerformLayout();
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
        private Panel panelBody;
        private Label lblGridTitle;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colCode;
        private DataGridViewTextBoxColumn colCategory;
        private DataGridViewComboBoxColumn colPoints;
        private DataGridViewTextBoxColumn colDesc;
        private Panel panelGridTool;
        private Button btnAddDetailRow;
        private Button btnDeleteDetailRow;
    }
}
