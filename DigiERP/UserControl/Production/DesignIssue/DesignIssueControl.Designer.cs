using System.Drawing;
using System.Windows.Forms;

namespace DigiERP.UserControl.Production
{
    partial class DesignIssueControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DesignIssueControl));
            panel1 = new Panel();
            lblTitle = new Label();
            lblProjectNoFilter = new Label();
            txtProjectNoFilter = new TextBox();
            lblPartNoFilter = new Label();
            txtPartNoFilter = new TextBox();
            lblPartNameFilter = new Label();
            txtPartNameFilter = new TextBox();
            btnClearFilter = new Button();
            btnExit = new Button();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            colBomNo = new DataGridViewTextBoxColumn();
            colProjectNo = new DataGridViewTextBoxColumn();
            colModuleCode = new DataGridViewTextBoxColumn();
            colModuleName = new DataGridViewTextBoxColumn();
            colPartNo = new DataGridViewTextBoxColumn();
            colPartName = new DataGridViewTextBoxColumn();
            colDesc = new DataGridViewTextBoxColumn();
            colQty = new DataGridViewTextBoxColumn();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightBlue;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(lblTitle);
            panel1.Controls.Add(lblProjectNoFilter);
            panel1.Controls.Add(txtProjectNoFilter);
            panel1.Controls.Add(lblPartNoFilter);
            panel1.Controls.Add(txtPartNoFilter);
            panel1.Controls.Add(lblPartNameFilter);
            panel1.Controls.Add(txtPartNameFilter);
            panel1.Controls.Add(btnClearFilter);
            panel1.Controls.Add(btnExit);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1900, 56);
            panel1.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("微軟正黑體", 13F, FontStyle.Bold);
            lblTitle.Location = new Point(64, 16);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(118, 23);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "專案用料總覽";
            // 
            // lblProjectNoFilter
            // 
            lblProjectNoFilter.AutoSize = true;
            lblProjectNoFilter.Location = new Point(230, 6);
            lblProjectNoFilter.Name = "lblProjectNoFilter";
            lblProjectNoFilter.Size = new Size(92, 18);
            lblProjectNoFilter.TabIndex = 1;
            lblProjectNoFilter.Text = "專案序號篩選";
            // 
            // txtProjectNoFilter
            // 
            txtProjectNoFilter.Location = new Point(230, 26);
            txtProjectNoFilter.Name = "txtProjectNoFilter";
            txtProjectNoFilter.PlaceholderText = "未篩選";
            txtProjectNoFilter.Size = new Size(160, 25);
            txtProjectNoFilter.TabIndex = 2;
            txtProjectNoFilter.TextChanged += FilterField_TextChanged;
            // 
            // lblPartNoFilter
            // 
            lblPartNoFilter.AutoSize = true;
            lblPartNoFilter.Location = new Point(404, 6);
            lblPartNoFilter.Name = "lblPartNoFilter";
            lblPartNoFilter.Size = new Size(92, 18);
            lblPartNoFilter.TabIndex = 3;
            lblPartNoFilter.Text = "零件號碼篩選";
            // 
            // txtPartNoFilter
            // 
            txtPartNoFilter.Location = new Point(404, 26);
            txtPartNoFilter.Name = "txtPartNoFilter";
            txtPartNoFilter.PlaceholderText = "未篩選";
            txtPartNoFilter.Size = new Size(160, 25);
            txtPartNoFilter.TabIndex = 4;
            txtPartNoFilter.TextChanged += FilterField_TextChanged;
            // 
            // lblPartNameFilter
            // 
            lblPartNameFilter.AutoSize = true;
            lblPartNameFilter.Location = new Point(578, 6);
            lblPartNameFilter.Name = "lblPartNameFilter";
            lblPartNameFilter.Size = new Size(64, 18);
            lblPartNameFilter.TabIndex = 5;
            lblPartNameFilter.Text = "品名篩選";
            // 
            // txtPartNameFilter
            // 
            txtPartNameFilter.Location = new Point(578, 26);
            txtPartNameFilter.Name = "txtPartNameFilter";
            txtPartNameFilter.PlaceholderText = "未篩選";
            txtPartNameFilter.Size = new Size(160, 25);
            txtPartNameFilter.TabIndex = 6;
            txtPartNameFilter.TextChanged += FilterField_TextChanged;
            // 
            // btnClearFilter
            // 
            btnClearFilter.BackColor = Color.SlateGray;
            btnClearFilter.FlatStyle = FlatStyle.Flat;
            btnClearFilter.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            btnClearFilter.ForeColor = Color.White;
            btnClearFilter.Location = new Point(760, 12);
            btnClearFilter.Name = "btnClearFilter";
            btnClearFilter.Size = new Size(100, 32);
            btnClearFilter.TabIndex = 7;
            btnClearFilter.Text = "清除篩選";
            btnClearFilter.UseVisualStyleBackColor = false;
            btnClearFilter.Click += btnClearFilter_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.LightSteelBlue;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            btnExit.Location = new Point(1780, 12);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(110, 32);
            btnExit.TabIndex = 8;
            btnExit.Text = "關閉";
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
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colBomNo, colProjectNo, colModuleCode, colModuleName, colPartNo, colPartName, colDesc, colQty });
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
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // colBomNo
            // 
            colBomNo.HeaderText = "BOM編號";
            colBomNo.Name = "colBomNo";
            colBomNo.ReadOnly = true;
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
            // colPartNo
            // 
            colPartNo.HeaderText = "零件號碼";
            colPartNo.Name = "colPartNo";
            colPartNo.ReadOnly = true;
            // 
            // colPartName
            // 
            colPartName.FillWeight = 150F;
            colPartName.HeaderText = "品名";
            colPartName.Name = "colPartName";
            colPartName.ReadOnly = true;
            // 
            // colDesc
            // 
            colDesc.FillWeight = 200F;
            colDesc.HeaderText = "描述";
            colDesc.Name = "colDesc";
            colDesc.ReadOnly = true;
            // 
            // colQty
            // 
            colQty.HeaderText = "數量";
            colQty.Name = "colQty";
            colQty.ReadOnly = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(4, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(56, 48);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // DesignIssueControl
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("微軟正黑體", 10F);
            Margin = new Padding(4);
            Name = "DesignIssueControl";
            Size = new Size(1900, 656);
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
        private Label lblProjectNoFilter;
        private TextBox txtProjectNoFilter;
        private Label lblPartNoFilter;
        private TextBox txtPartNoFilter;
        private Label lblPartNameFilter;
        private TextBox txtPartNameFilter;
        private Button btnClearFilter;
        private Button btnExit;
        private Panel panel2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn colBomNo;
        private DataGridViewTextBoxColumn colProjectNo;
        private DataGridViewTextBoxColumn colModuleCode;
        private DataGridViewTextBoxColumn colModuleName;
        private DataGridViewTextBoxColumn colPartNo;
        private DataGridViewTextBoxColumn colPartName;
        private DataGridViewTextBoxColumn colDesc;
        private DataGridViewTextBoxColumn colQty;
        private PictureBox pictureBox1;
    }
}
