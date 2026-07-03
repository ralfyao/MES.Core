namespace DigiERP.Forms.Inventory
{
    partial class FrmSelectMaterialFormula
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
            dgvFormula = new DataGridView();
            colFormulaCode = new DataGridViewTextBoxColumn();
            colFormulaDesc = new DataGridViewTextBoxColumn();
            panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFormula).BeginInit();
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
            lblSearch.Text = "搜尋公式";

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

            // dgvFormula
            dgvFormula.AllowUserToAddRows = false;
            dgvFormula.AllowUserToDeleteRows = false;
            dgvFormula.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvFormula.BackgroundColor = Color.White;
            dgvFormula.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFormula.Columns.AddRange(new DataGridViewColumn[] { colFormulaCode, colFormulaDesc });
            dgvFormula.Dock = DockStyle.Fill;
            dgvFormula.Font = new Font("微軟正黑體", 10F);
            dgvFormula.Location = new Point(0, 46);
            dgvFormula.Name = "dgvFormula";
            dgvFormula.ReadOnly = true;
            dgvFormula.RowHeadersVisible = false;
            dgvFormula.RowTemplate.Height = 26;
            dgvFormula.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvFormula.Size = new Size(560, 434);
            dgvFormula.TabIndex = 1;
            dgvFormula.CellDoubleClick += dgvFormula_CellDoubleClick;

            // colFormulaCode
            colFormulaCode.FillWeight = 60F;
            colFormulaCode.HeaderText = "公式代號";
            colFormulaCode.Name = "colFormulaCode";

            // colFormulaDesc
            colFormulaDesc.FillWeight = 200F;
            colFormulaDesc.HeaderText = "公式說明";
            colFormulaDesc.Name = "colFormulaDesc";

            // FrmSelectMaterialFormula
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 480);
            Controls.Add(dgvFormula);
            Controls.Add(panelTop);
            Font = new Font("微軟正黑體", 10F);
            FormBorderStyle = FormBorderStyle.Sizable;
            MinimumSize = new Size(420, 360);
            Name = "FrmSelectMaterialFormula";
            StartPosition = FormStartPosition.CenterParent;
            Text = "選取材料計算公式";
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFormula).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop;
        private Label lblSearch;
        private TextBox txtSearch;
        private Button btnSelect;
        private DataGridView dgvFormula;
        private DataGridViewTextBoxColumn colFormulaCode;
        private DataGridViewTextBoxColumn colFormulaDesc;
    }
}
