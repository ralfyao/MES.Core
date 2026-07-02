namespace DigiERP.UserControl.Supplier.SupplierEvaluate
{
    partial class SupplierEvaluateControl
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
            panel1 = new Panel();
            btnSearch = new Button();
            txtSearchSupplierNo = new TextBox();
            lblSearchSupplierNo = new Label();
            txtSearchNo = new TextBox();
            lblSearchNo = new Label();
            lblTitle = new Label();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            colNo = new DataGridViewTextBoxColumn();
            colDate = new DataGridViewTextBoxColumn();
            colSupplierNo = new DataGridViewTextBoxColumn();
            colSupplierShortName = new DataGridViewTextBoxColumn();
            colEvaluator = new DataGridViewTextBoxColumn();
            colReviewer = new DataGridViewTextBoxColumn();
            colReviewDate = new DataGridViewTextBoxColumn();
            colApproved = new DataGridViewTextBoxColumn();
            colApproveDate = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 192, 128);
            panel1.Controls.Add(btnSearch);
            panel1.Controls.Add(txtSearchSupplierNo);
            panel1.Controls.Add(lblSearchSupplierNo);
            panel1.Controls.Add(txtSearchNo);
            panel1.Controls.Add(lblSearchNo);
            panel1.Controls.Add(lblTitle);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1497, 112);
            panel1.TabIndex = 0;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.SteelBlue;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(568, 64);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(100, 40);
            btnSearch.TabIndex = 4;
            btnSearch.Text = "查詢";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearchSupplierNo
            // 
            txtSearchSupplierNo.Font = new Font("微軟正黑體", 10F);
            txtSearchSupplierNo.Location = new Point(332, 72);
            txtSearchSupplierNo.Name = "txtSearchSupplierNo";
            txtSearchSupplierNo.Size = new Size(220, 25);
            txtSearchSupplierNo.TabIndex = 3;
            txtSearchSupplierNo.KeyDown += txtSearch_KeyDown;
            // 
            // lblSearchSupplierNo
            // 
            lblSearchSupplierNo.AutoSize = true;
            lblSearchSupplierNo.Font = new Font("微軟正黑體", 10F);
            lblSearchSupplierNo.Location = new Point(262, 76);
            lblSearchSupplierNo.Name = "lblSearchSupplierNo";
            lblSearchSupplierNo.Size = new Size(64, 18);
            lblSearchSupplierNo.TabIndex = 2;
            lblSearchSupplierNo.Text = "廠商編號";
            // 
            // txtSearchNo
            // 
            txtSearchNo.Font = new Font("微軟正黑體", 10F);
            txtSearchNo.Location = new Point(86, 72);
            txtSearchNo.Name = "txtSearchNo";
            txtSearchNo.Size = new Size(160, 25);
            txtSearchNo.TabIndex = 1;
            txtSearchNo.KeyDown += txtSearch_KeyDown;
            // 
            // lblSearchNo
            // 
            lblSearchNo.AutoSize = true;
            lblSearchNo.Font = new Font("微軟正黑體", 10F);
            lblSearchNo.Location = new Point(16, 76);
            lblSearchNo.Name = "lblSearchNo";
            lblSearchNo.Size = new Size(64, 18);
            lblSearchNo.TabIndex = 0;
            lblSearchNo.Text = "評鑑單號";
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("微軟正黑體", 18F, FontStyle.Bold);
            lblTitle.Location = new Point(16, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(200, 32);
            lblTitle.TabIndex = 5;
            lblTitle.Text = "廠商評鑑一覽表";
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridView1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 112);
            panel2.Name = "panel2";
            panel2.Size = new Size(1497, 564);
            panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colNo, colDate, colSupplierNo, colSupplierShortName, colEvaluator, colReviewer, colReviewDate, colApproved, colApproveDate });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Font = new Font("微軟正黑體", 10F);
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 28;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1497, 564);
            dataGridView1.TabIndex = 0;
            dataGridView1.VisibleChanged += dataGridView1_VisibleChanged;
            // 
            // colNo
            // 
            colNo.FillWeight = 70F;
            colNo.HeaderText = "評鑑單號";
            colNo.Name = "colNo";
            colNo.ReadOnly = true;
            // 
            // colDate
            // 
            colDate.FillWeight = 70F;
            colDate.HeaderText = "評鑑日期";
            colDate.Name = "colDate";
            colDate.ReadOnly = true;
            // 
            // colSupplierNo
            // 
            colSupplierNo.FillWeight = 70F;
            colSupplierNo.HeaderText = "廠商編號";
            colSupplierNo.Name = "colSupplierNo";
            colSupplierNo.ReadOnly = true;
            // 
            // colSupplierShortName
            // 
            colSupplierShortName.FillWeight = 90F;
            colSupplierShortName.HeaderText = "廠商簡稱";
            colSupplierShortName.Name = "colSupplierShortName";
            colSupplierShortName.ReadOnly = true;
            // 
            // colEvaluator
            // 
            colEvaluator.FillWeight = 70F;
            colEvaluator.HeaderText = "評鑑人員";
            colEvaluator.Name = "colEvaluator";
            colEvaluator.ReadOnly = true;
            // 
            // colReviewer
            // 
            colReviewer.FillWeight = 70F;
            colReviewer.HeaderText = "覆審人員";
            colReviewer.Name = "colReviewer";
            colReviewer.ReadOnly = true;
            // 
            // colReviewDate
            // 
            colReviewDate.FillWeight = 70F;
            colReviewDate.HeaderText = "覆審日期";
            colReviewDate.Name = "colReviewDate";
            colReviewDate.ReadOnly = true;
            // 
            // colApproved
            // 
            colApproved.FillWeight = 60F;
            colApproved.HeaderText = "核准";
            colApproved.Name = "colApproved";
            colApproved.ReadOnly = true;
            // 
            // colApproveDate
            // 
            colApproveDate.FillWeight = 70F;
            colApproveDate.HeaderText = "核准日";
            colApproveDate.Name = "colApproveDate";
            colApproveDate.ReadOnly = true;
            // 
            // SupplierEvaluateControl
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("微軟正黑體", 10F);
            Margin = new Padding(4);
            Name = "SupplierEvaluateControl";
            Size = new Size(1497, 676);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblTitle;
        private Label lblSearchNo;
        private TextBox txtSearchNo;
        private Label lblSearchSupplierNo;
        private TextBox txtSearchSupplierNo;
        private Button btnSearch;
        private Panel panel2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn colNo;
        private DataGridViewTextBoxColumn colDate;
        private DataGridViewTextBoxColumn colSupplierNo;
        private DataGridViewTextBoxColumn colSupplierShortName;
        private DataGridViewTextBoxColumn colEvaluator;
        private DataGridViewTextBoxColumn colReviewer;
        private DataGridViewTextBoxColumn colReviewDate;
        private DataGridViewTextBoxColumn colApproved;
        private DataGridViewTextBoxColumn colApproveDate;
    }
}
