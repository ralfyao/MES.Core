namespace DigiERP.Forms.Inventory
{
    partial class FrmMaterialItemCode
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
            panel1 = new Panel();
            btnAddPartCode = new Button();
            lblTitle = new Label();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            colProductCode = new DataGridViewTextBoxColumn();
            colCategory = new DataGridViewButtonColumn();
            colSubCategory = new DataGridViewTextBoxColumn();
            colSubCategoryName = new DataGridViewTextBoxColumn();
            colDensity = new DataGridViewTextBoxColumn();
            colFormula = new DataGridViewButtonColumn();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();

            // panel1
            panel1.BackColor = Color.FromArgb(255, 255, 192);
            panel1.Controls.Add(btnAddPartCode);
            panel1.Controls.Add(lblTitle);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(900, 56);
            panel1.TabIndex = 0;

            // lblTitle
            lblTitle.Font = new Font("微軟正黑體", 14F, FontStyle.Bold);
            lblTitle.Location = new Point(16, 14);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(160, 28);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "材料品項代號";

            // btnAddPartCode
            btnAddPartCode.BackColor = Color.SteelBlue;
            btnAddPartCode.FlatStyle = FlatStyle.Flat;
            btnAddPartCode.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            btnAddPartCode.ForeColor = Color.White;
            btnAddPartCode.Location = new Point(700, 12);
            btnAddPartCode.Name = "btnAddPartCode";
            btnAddPartCode.Size = new Size(180, 34);
            btnAddPartCode.TabIndex = 1;
            btnAddPartCode.Text = "新增材料產品代號";
            btnAddPartCode.UseVisualStyleBackColor = false;
            btnAddPartCode.Click += btnAddPartCode_Click;

            // panel2
            panel2.Controls.Add(dataGridView1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 56);
            panel2.Name = "panel2";
            panel2.Size = new Size(900, 464);
            panel2.TabIndex = 1;

            // dataGridView1
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] {
                colProductCode, colCategory, colSubCategory, colSubCategoryName, colDensity, colFormula
            });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Font = new Font("微軟正黑體", 10F);
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 28;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(900, 464);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;

            // colProductCode
            colProductCode.FillWeight = 120F;
            colProductCode.HeaderText = "材料產品代號";
            colProductCode.Name = "colProductCode";
            colProductCode.ReadOnly = true;

            // colCategory
            colCategory.FillWeight = 80F;
            colCategory.HeaderText = "大分類";
            colCategory.Name = "colCategory";
            colCategory.Text = "選取";
            colCategory.UseColumnTextForButtonValue = false;

            // colSubCategory
            colSubCategory.FillWeight = 60F;
            colSubCategory.HeaderText = "小分類";
            colSubCategory.Name = "colSubCategory";
            colSubCategory.ReadOnly = true;

            // colSubCategoryName
            colSubCategoryName.FillWeight = 100F;
            colSubCategoryName.HeaderText = "小分類名稱";
            colSubCategoryName.Name = "colSubCategoryName";
            colSubCategoryName.ReadOnly = true;

            // colDensity
            colDensity.FillWeight = 90F;
            colDensity.HeaderText = "密度";
            colDensity.Name = "colDensity";
            colDensity.ReadOnly = true;

            // colFormula
            colFormula.FillWeight = 80F;
            colFormula.HeaderText = "公式代號";
            colFormula.Name = "colFormula";
            colFormula.Text = "選取";
            colFormula.UseColumnTextForButtonValue = false;

            // FrmMaterialItemCode
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 520);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("微軟正黑體", 10F);
            FormBorderStyle = FormBorderStyle.Sizable;
            MinimumSize = new Size(700, 400);
            Name = "FrmMaterialItemCode";
            StartPosition = FormStartPosition.CenterParent;
            Text = "A-材料品項代號";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblTitle;
        private Button btnAddPartCode;
        private Panel panel2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn colProductCode;
        private DataGridViewButtonColumn colCategory;
        private DataGridViewTextBoxColumn colSubCategory;
        private DataGridViewTextBoxColumn colSubCategoryName;
        private DataGridViewTextBoxColumn colDensity;
        private DataGridViewButtonColumn colFormula;
    }
}
