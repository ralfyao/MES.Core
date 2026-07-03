namespace DigiERP.Forms.Inventory
{
    partial class FrmAddPartCode
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
            panelTitle = new Panel();
            btnAdd = new Button();
            lblTitle = new Label();
            panelHeader = new Panel();
            lblHeaderProductCode = new Label();
            lblHeaderCategory = new Label();
            lblHeaderSubCategory = new Label();
            lblHeaderSubCategoryName = new Label();
            lblHeaderDensity = new Label();
            lblHeaderFormula = new Label();
            panelInput = new Panel();
            txtProductCode = new TextBox();
            txtCategory = new TextBox();
            btnPickCategory = new Button();
            txtSubCategory = new TextBox();
            txtSubCategoryName = new TextBox();
            txtDensity = new TextBox();
            txtFormula = new TextBox();
            btnPickFormula = new Button();
            panelTitle.SuspendLayout();
            panelHeader.SuspendLayout();
            panelInput.SuspendLayout();
            SuspendLayout();

            // panelTitle
            panelTitle.BackColor = Color.FromArgb(255, 255, 192);
            panelTitle.Controls.Add(btnAdd);
            panelTitle.Controls.Add(lblTitle);
            panelTitle.Dock = DockStyle.Top;
            panelTitle.Location = new Point(0, 0);
            panelTitle.Name = "panelTitle";
            panelTitle.Size = new Size(980, 40);
            panelTitle.TabIndex = 0;

            // lblTitle
            lblTitle.Font = new Font("微軟正黑體", 12F, FontStyle.Bold);
            lblTitle.Location = new Point(8, 8);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(140, 24);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "材料品項代號";

            // btnAdd
            btnAdd.BackColor = Color.SteelBlue;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(800, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(96, 32);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "新增";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;

            // panelHeader
            panelHeader.BackColor = Color.FromArgb(230, 230, 250);
            panelHeader.Controls.Add(lblHeaderProductCode);
            panelHeader.Controls.Add(lblHeaderCategory);
            panelHeader.Controls.Add(lblHeaderSubCategory);
            panelHeader.Controls.Add(lblHeaderSubCategoryName);
            panelHeader.Controls.Add(lblHeaderDensity);
            panelHeader.Controls.Add(lblHeaderFormula);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 40);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(980, 28);
            panelHeader.TabIndex = 1;

            // lblHeaderProductCode
            lblHeaderProductCode.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            lblHeaderProductCode.Location = new Point(8, 5);
            lblHeaderProductCode.Name = "lblHeaderProductCode";
            lblHeaderProductCode.Size = new Size(230, 18);
            lblHeaderProductCode.TabIndex = 0;
            lblHeaderProductCode.Text = "材料產品代號";
            lblHeaderProductCode.TextAlign = ContentAlignment.MiddleCenter;

            // lblHeaderCategory
            lblHeaderCategory.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            lblHeaderCategory.Location = new Point(240, 5);
            lblHeaderCategory.Name = "lblHeaderCategory";
            lblHeaderCategory.Size = new Size(120, 18);
            lblHeaderCategory.TabIndex = 1;
            lblHeaderCategory.Text = "大分類";
            lblHeaderCategory.TextAlign = ContentAlignment.MiddleCenter;

            // lblHeaderSubCategory
            lblHeaderSubCategory.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            lblHeaderSubCategory.Location = new Point(362, 5);
            lblHeaderSubCategory.Name = "lblHeaderSubCategory";
            lblHeaderSubCategory.Size = new Size(120, 18);
            lblHeaderSubCategory.TabIndex = 2;
            lblHeaderSubCategory.Text = "小分類";
            lblHeaderSubCategory.TextAlign = ContentAlignment.MiddleCenter;

            // lblHeaderSubCategoryName
            lblHeaderSubCategoryName.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            lblHeaderSubCategoryName.Location = new Point(484, 5);
            lblHeaderSubCategoryName.Name = "lblHeaderSubCategoryName";
            lblHeaderSubCategoryName.Size = new Size(140, 18);
            lblHeaderSubCategoryName.TabIndex = 3;
            lblHeaderSubCategoryName.Text = "小分類名稱";
            lblHeaderSubCategoryName.TextAlign = ContentAlignment.MiddleCenter;

            // lblHeaderDensity
            lblHeaderDensity.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            lblHeaderDensity.Location = new Point(626, 5);
            lblHeaderDensity.Name = "lblHeaderDensity";
            lblHeaderDensity.Size = new Size(190, 18);
            lblHeaderDensity.TabIndex = 4;
            lblHeaderDensity.Text = "密度";
            lblHeaderDensity.TextAlign = ContentAlignment.MiddleCenter;

            // lblHeaderFormula
            lblHeaderFormula.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            lblHeaderFormula.Location = new Point(818, 5);
            lblHeaderFormula.Name = "lblHeaderFormula";
            lblHeaderFormula.Size = new Size(140, 18);
            lblHeaderFormula.TabIndex = 5;
            lblHeaderFormula.Text = "公式代號";
            lblHeaderFormula.TextAlign = ContentAlignment.MiddleCenter;

            // panelInput
            panelInput.BackColor = Color.White;
            panelInput.Controls.Add(txtProductCode);
            panelInput.Controls.Add(txtCategory);
            panelInput.Controls.Add(btnPickCategory);
            panelInput.Controls.Add(txtSubCategory);
            panelInput.Controls.Add(txtSubCategoryName);
            panelInput.Controls.Add(txtDensity);
            panelInput.Controls.Add(txtFormula);
            panelInput.Controls.Add(btnPickFormula);
            panelInput.Dock = DockStyle.Fill;
            panelInput.Location = new Point(0, 68);
            panelInput.Name = "panelInput";
            panelInput.Size = new Size(980, 60);
            panelInput.TabIndex = 2;

            // txtProductCode
            txtProductCode.Font = new Font("微軟正黑體", 10F);
            txtProductCode.Location = new Point(8, 8);
            txtProductCode.Name = "txtProductCode";
            txtProductCode.Size = new Size(228, 25);
            txtProductCode.TabIndex = 0;

            // txtCategory
            txtCategory.BackColor = Color.WhiteSmoke;
            txtCategory.Font = new Font("微軟正黑體", 10F);
            txtCategory.Location = new Point(240, 8);
            txtCategory.Name = "txtCategory";
            txtCategory.ReadOnly = true;
            txtCategory.Size = new Size(92, 25);
            txtCategory.TabIndex = 1;

            // btnPickCategory
            btnPickCategory.FlatStyle = FlatStyle.Flat;
            btnPickCategory.Font = new Font("Segoe MDL2 Assets", 8F);
            btnPickCategory.Location = new Point(332, 8);
            btnPickCategory.Name = "btnPickCategory";
            btnPickCategory.Size = new Size(28, 25);
            btnPickCategory.TabIndex = 2;
            btnPickCategory.Text = "";
            btnPickCategory.UseVisualStyleBackColor = true;
            btnPickCategory.Click += btnPickCategory_Click;

            // txtSubCategory
            txtSubCategory.Font = new Font("微軟正黑體", 10F);
            txtSubCategory.Location = new Point(362, 8);
            txtSubCategory.Name = "txtSubCategory";
            txtSubCategory.Size = new Size(120, 25);
            txtSubCategory.TabIndex = 3;

            // txtSubCategoryName
            txtSubCategoryName.Font = new Font("微軟正黑體", 10F);
            txtSubCategoryName.Location = new Point(484, 8);
            txtSubCategoryName.Name = "txtSubCategoryName";
            txtSubCategoryName.Size = new Size(140, 25);
            txtSubCategoryName.TabIndex = 4;

            // txtDensity
            txtDensity.Font = new Font("微軟正黑體", 10F);
            txtDensity.Location = new Point(626, 8);
            txtDensity.Name = "txtDensity";
            txtDensity.Size = new Size(190, 25);
            txtDensity.TabIndex = 5;

            // txtFormula
            txtFormula.BackColor = Color.WhiteSmoke;
            txtFormula.Font = new Font("微軟正黑體", 10F);
            txtFormula.Location = new Point(818, 8);
            txtFormula.Name = "txtFormula";
            txtFormula.ReadOnly = true;
            txtFormula.Size = new Size(112, 25);
            txtFormula.TabIndex = 6;

            // btnPickFormula
            btnPickFormula.FlatStyle = FlatStyle.Flat;
            btnPickFormula.Font = new Font("Segoe MDL2 Assets", 8F);
            btnPickFormula.Location = new Point(930, 8);
            btnPickFormula.Name = "btnPickFormula";
            btnPickFormula.Size = new Size(28, 25);
            btnPickFormula.TabIndex = 7;
            btnPickFormula.Text = "";
            btnPickFormula.UseVisualStyleBackColor = true;
            btnPickFormula.Click += btnPickFormula_Click;

            // FrmAddPartCode
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(980, 128);
            Controls.Add(panelInput);
            Controls.Add(panelHeader);
            Controls.Add(panelTitle);
            Font = new Font("微軟正黑體", 10F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmAddPartCode";
            StartPosition = FormStartPosition.CenterParent;
            Text = "A-材料品項代號";
            panelTitle.ResumeLayout(false);
            panelHeader.ResumeLayout(false);
            panelInput.ResumeLayout(false);
            panelInput.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTitle;
        private Label lblTitle;
        private Button btnAdd;
        private Panel panelHeader;
        private Label lblHeaderProductCode;
        private Label lblHeaderCategory;
        private Label lblHeaderSubCategory;
        private Label lblHeaderSubCategoryName;
        private Label lblHeaderDensity;
        private Label lblHeaderFormula;
        private Panel panelInput;
        private TextBox txtProductCode;
        private TextBox txtCategory;
        private Button btnPickCategory;
        private TextBox txtSubCategory;
        private TextBox txtSubCategoryName;
        private TextBox txtDensity;
        private TextBox txtFormula;
        private Button btnPickFormula;
    }
}
