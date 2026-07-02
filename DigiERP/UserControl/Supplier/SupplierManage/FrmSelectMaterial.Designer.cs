namespace DigiERP.UserControl.Supplier.SupplierManage
{
    partial class FrmSelectMaterial
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
            dgvMaterial = new DataGridView();
            colProductNo = new DataGridViewTextBoxColumn();
            colType = new DataGridViewTextBoxColumn();
            colCategory = new DataGridViewTextBoxColumn();
            colSpec = new DataGridViewTextBoxColumn();
            colProductCode = new DataGridViewTextBoxColumn();
            colUnit = new DataGridViewTextBoxColumn();
            panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMaterial).BeginInit();
            SuspendLayout();

            // panelTop
            panelTop.BackColor = Color.FromArgb(255, 229, 204);
            panelTop.Controls.Add(btnSelect);
            panelTop.Controls.Add(txtSearch);
            panelTop.Controls.Add(lblSearch);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(900, 46);
            panelTop.TabIndex = 0;

            // lblSearch
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("微軟正黑體", 10F);
            lblSearch.Location = new Point(8, 14);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(64, 18);
            lblSearch.TabIndex = 0;
            lblSearch.Text = "搜尋料號";

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

            // dgvMaterial
            dgvMaterial.AllowUserToAddRows = false;
            dgvMaterial.AllowUserToDeleteRows = false;
            dgvMaterial.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMaterial.BackgroundColor = Color.White;
            dgvMaterial.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMaterial.Columns.AddRange(new DataGridViewColumn[] {
                colProductNo, colType, colCategory, colSpec, colProductCode, colUnit
            });
            dgvMaterial.Dock = DockStyle.Fill;
            dgvMaterial.Font = new Font("微軟正黑體", 10F);
            dgvMaterial.Location = new Point(0, 46);
            dgvMaterial.Name = "dgvMaterial";
            dgvMaterial.ReadOnly = true;
            dgvMaterial.RowHeadersVisible = false;
            dgvMaterial.RowTemplate.Height = 26;
            dgvMaterial.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMaterial.Size = new Size(900, 484);
            dgvMaterial.TabIndex = 1;
            dgvMaterial.CellDoubleClick += dgvMaterial_CellDoubleClick;

            // colProductNo
            colProductNo.FillWeight = 90F;
            colProductNo.HeaderText = "產品編號";
            colProductNo.Name = "colProductNo";

            // colType
            colType.FillWeight = 60F;
            colType.HeaderText = "品別";
            colType.Name = "colType";

            // colCategory
            colCategory.FillWeight = 70F;
            colCategory.HeaderText = "大分類";
            colCategory.Name = "colCategory";

            // colSpec
            colSpec.FillWeight = 200F;
            colSpec.HeaderText = "品名規格";
            colSpec.Name = "colSpec";

            // colProductCode
            colProductCode.FillWeight = 90F;
            colProductCode.HeaderText = "產品代號";
            colProductCode.Name = "colProductCode";

            // colUnit
            colUnit.FillWeight = 60F;
            colUnit.HeaderText = "採購單位";
            colUnit.Name = "colUnit";

            // FrmSelectMaterial
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 530);
            Controls.Add(dgvMaterial);
            Controls.Add(panelTop);
            Font = new Font("微軟正黑體", 10F);
            FormBorderStyle = FormBorderStyle.Sizable;
            MinimumSize = new Size(700, 400);
            Name = "FrmSelectMaterial";
            StartPosition = FormStartPosition.CenterParent;
            Text = "選取品項";
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMaterial).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop;
        private Label lblSearch;
        private TextBox txtSearch;
        private Button btnSelect;
        private DataGridView dgvMaterial;
        private DataGridViewTextBoxColumn colProductNo;
        private DataGridViewTextBoxColumn colType;
        private DataGridViewTextBoxColumn colCategory;
        private DataGridViewTextBoxColumn colSpec;
        private DataGridViewTextBoxColumn colProductCode;
        private DataGridViewTextBoxColumn colUnit;
    }
}
