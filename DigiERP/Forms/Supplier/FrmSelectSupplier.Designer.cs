namespace DigiERP.UserControl.Supplier.SupplierManage
{
    partial class FrmSelectSupplier
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
            panelTop = new Panel();
            btnSelect = new Button();
            txtSearch = new TextBox();
            lblSearch = new Label();
            dgvSupplier = new DataGridView();
            colSupplierNo = new DataGridViewTextBoxColumn();
            colShortName = new DataGridViewTextBoxColumn();
            colName = new DataGridViewTextBoxColumn();
            panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSupplier).BeginInit();
            SuspendLayout();

            // panelTop
            panelTop.BackColor = Color.FromArgb(255, 229, 204);
            panelTop.Controls.Add(btnSelect);
            panelTop.Controls.Add(txtSearch);
            panelTop.Controls.Add(lblSearch);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(700, 46);
            panelTop.TabIndex = 0;

            // lblSearch
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("微軟正黑體", 10F);
            lblSearch.Location = new Point(8, 14);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(64, 18);
            lblSearch.TabIndex = 0;
            lblSearch.Text = "搜尋廠商";

            // txtSearch
            txtSearch.Font = new Font("微軟正黑體", 10F);
            txtSearch.Location = new Point(80, 10);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(260, 25);
            txtSearch.TabIndex = 1;
            txtSearch.TextChanged += txtSearch_TextChanged;

            // btnSelect
            btnSelect.BackColor = Color.SeaGreen;
            btnSelect.FlatStyle = FlatStyle.Flat;
            btnSelect.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            btnSelect.ForeColor = Color.White;
            btnSelect.Location = new Point(360, 6);
            btnSelect.Name = "btnSelect";
            btnSelect.Size = new Size(90, 34);
            btnSelect.TabIndex = 2;
            btnSelect.Text = "選取";
            btnSelect.UseVisualStyleBackColor = false;
            btnSelect.Click += btnSelect_Click;

            // dgvSupplier
            dgvSupplier.AllowUserToAddRows = false;
            dgvSupplier.AllowUserToDeleteRows = false;
            dgvSupplier.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSupplier.BackgroundColor = Color.White;
            dgvSupplier.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSupplier.Columns.AddRange(new DataGridViewColumn[] { colSupplierNo, colShortName, colName });
            dgvSupplier.Dock = DockStyle.Fill;
            dgvSupplier.Font = new Font("微軟正黑體", 10F);
            dgvSupplier.Location = new Point(0, 46);
            dgvSupplier.Name = "dgvSupplier";
            dgvSupplier.ReadOnly = true;
            dgvSupplier.RowHeadersVisible = false;
            dgvSupplier.RowTemplate.Height = 26;
            dgvSupplier.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSupplier.Size = new Size(700, 484);
            dgvSupplier.TabIndex = 1;
            dgvSupplier.CellDoubleClick += dgvSupplier_CellDoubleClick;

            // colSupplierNo
            colSupplierNo.FillWeight = 70F;
            colSupplierNo.HeaderText = "廠商編號";
            colSupplierNo.Name = "colSupplierNo";

            // colShortName
            colShortName.FillWeight = 80F;
            colShortName.HeaderText = "廠商簡稱";
            colShortName.Name = "colShortName";

            // colName
            colName.FillWeight = 200F;
            colName.HeaderText = "廠商名稱";
            colName.Name = "colName";

            // FrmSelectSupplier
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 530);
            Controls.Add(dgvSupplier);
            Controls.Add(panelTop);
            Font = new Font("微軟正黑體", 10F);
            FormBorderStyle = FormBorderStyle.Sizable;
            MinimumSize = new Size(500, 400);
            Name = "FrmSelectSupplier";
            StartPosition = FormStartPosition.CenterParent;
            Text = "選取廠商";
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSupplier).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop;
        private Label lblSearch;
        private TextBox txtSearch;
        private Button btnSelect;
        private DataGridView dgvSupplier;
        private DataGridViewTextBoxColumn colSupplierNo;
        private DataGridViewTextBoxColumn colShortName;
        private DataGridViewTextBoxColumn colName;
    }
}
