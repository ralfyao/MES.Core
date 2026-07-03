namespace DigiERP.Forms.Inventory
{
    partial class FrmSelectMaterialCategory
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
            dgvCategory = new DataGridView();
            colCategoryCode = new DataGridViewTextBoxColumn();
            colCategoryName = new DataGridViewTextBoxColumn();
            panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCategory).BeginInit();
            SuspendLayout();

            // panelTop
            panelTop.BackColor = Color.FromArgb(255, 229, 204);
            panelTop.Controls.Add(btnSelect);
            panelTop.Controls.Add(txtSearch);
            panelTop.Controls.Add(lblSearch);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(560, 46);
            panelTop.TabIndex = 0;

            // lblSearch
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("微軟正黑體", 10F);
            lblSearch.Location = new Point(8, 14);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(64, 18);
            lblSearch.TabIndex = 0;
            lblSearch.Text = "搜尋分類";

            // txtSearch
            txtSearch.Font = new Font("微軟正黑體", 10F);
            txtSearch.Location = new Point(80, 10);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(220, 25);
            txtSearch.TabIndex = 1;
            txtSearch.TextChanged += txtSearch_TextChanged;

            // btnSelect
            btnSelect.BackColor = Color.SeaGreen;
            btnSelect.FlatStyle = FlatStyle.Flat;
            btnSelect.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            btnSelect.ForeColor = Color.White;
            btnSelect.Location = new Point(320, 6);
            btnSelect.Name = "btnSelect";
            btnSelect.Size = new Size(90, 34);
            btnSelect.TabIndex = 2;
            btnSelect.Text = "選取";
            btnSelect.UseVisualStyleBackColor = false;
            btnSelect.Click += btnSelect_Click;

            // dgvCategory
            dgvCategory.AllowUserToAddRows = false;
            dgvCategory.AllowUserToDeleteRows = false;
            dgvCategory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCategory.BackgroundColor = Color.White;
            dgvCategory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategory.Columns.AddRange(new DataGridViewColumn[] { colCategoryCode, colCategoryName });
            dgvCategory.Dock = DockStyle.Fill;
            dgvCategory.Font = new Font("微軟正黑體", 10F);
            dgvCategory.Location = new Point(0, 46);
            dgvCategory.Name = "dgvCategory";
            dgvCategory.ReadOnly = true;
            dgvCategory.RowHeadersVisible = false;
            dgvCategory.RowTemplate.Height = 26;
            dgvCategory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCategory.Size = new Size(560, 434);
            dgvCategory.TabIndex = 1;
            dgvCategory.CellDoubleClick += dgvCategory_CellDoubleClick;

            // colCategoryCode
            colCategoryCode.FillWeight = 60F;
            colCategoryCode.HeaderText = "大分類";
            colCategoryCode.Name = "colCategoryCode";

            // colCategoryName
            colCategoryName.FillWeight = 140F;
            colCategoryName.HeaderText = "分類名稱";
            colCategoryName.Name = "colCategoryName";

            // FrmSelectMaterialCategory
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 480);
            Controls.Add(dgvCategory);
            Controls.Add(panelTop);
            Font = new Font("微軟正黑體", 10F);
            FormBorderStyle = FormBorderStyle.Sizable;
            MinimumSize = new Size(420, 360);
            Name = "FrmSelectMaterialCategory";
            StartPosition = FormStartPosition.CenterParent;
            Text = "選取材料大分類";
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCategory).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop;
        private Label lblSearch;
        private TextBox txtSearch;
        private Button btnSelect;
        private DataGridView dgvCategory;
        private DataGridViewTextBoxColumn colCategoryCode;
        private DataGridViewTextBoxColumn colCategoryName;
    }
}
