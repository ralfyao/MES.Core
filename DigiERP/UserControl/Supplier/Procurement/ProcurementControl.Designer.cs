using System.Drawing;
using System.Windows.Forms;

namespace DigiERP.UserControl.Supplier.Procurement
{
    partial class ProcurementControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProcurementControl));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            btnExit = new Button();
            btnAdd = new Button();
            lblItemName = new Label();
            txtItemName = new TextBox();
            lblProject = new Label();
            txtProject = new TextBox();
            lblSupplier = new Label();
            txtSupplier = new TextBox();
            lblNo = new Label();
            txtNo = new TextBox();
            btnClosed = new Button();
            btnWithoutDetail = new Button();
            lblTitle = new Label();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            colNo = new DataGridViewTextBoxColumn();
            colDate = new DataGridViewTextBoxColumn();
            colSupplierNo = new DataGridViewTextBoxColumn();
            colSupplierShortName = new DataGridViewTextBoxColumn();
            colPurchaseType = new DataGridViewTextBoxColumn();
            colSupplierName = new DataGridViewTextBoxColumn();
            colClosed = new DataGridViewCheckBoxColumn();
            colProject = new DataGridViewTextBoxColumn();
            colItemNo = new DataGridViewTextBoxColumn();
            colItemSpec = new DataGridViewTextBoxColumn();
            colPurchaseQty = new DataGridViewTextBoxColumn();
            colPurchaser = new DataGridViewTextBoxColumn();
            colReviewer = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Cornsilk;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnExit);
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(lblItemName);
            panel1.Controls.Add(txtItemName);
            panel1.Controls.Add(lblProject);
            panel1.Controls.Add(txtProject);
            panel1.Controls.Add(lblSupplier);
            panel1.Controls.Add(txtSupplier);
            panel1.Controls.Add(lblNo);
            panel1.Controls.Add(txtNo);
            panel1.Controls.Add(btnClosed);
            panel1.Controls.Add(btnWithoutDetail);
            panel1.Controls.Add(lblTitle);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1467, 64);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(4, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(68, 56);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Gainsboro;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            btnExit.Location = new Point(1363, 14);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(80, 32);
            btnExit.TabIndex = 12;
            btnExit.Text = "EXIT";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Visible = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Gainsboro;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            btnAdd.Location = new Point(1273, 14);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(80, 32);
            btnAdd.TabIndex = 11;
            btnAdd.Text = "新增";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // lblItemName
            // 
            lblItemName.AutoSize = true;
            lblItemName.Font = new Font("微軟正黑體", 10F);
            lblItemName.Location = new Point(1033, 20);
            lblItemName.Name = "lblItemName";
            lblItemName.Size = new Size(64, 18);
            lblItemName.TabIndex = 9;
            lblItemName.Text = "品名查詢";
            // 
            // txtItemName
            // 
            txtItemName.Font = new Font("微軟正黑體", 10F);
            txtItemName.Location = new Point(1103, 16);
            txtItemName.Name = "txtItemName";
            txtItemName.Size = new Size(150, 25);
            txtItemName.TabIndex = 10;
            txtItemName.TextChanged += txtSearch_TextChanged;
            // 
            // lblProject
            // 
            lblProject.AutoSize = true;
            lblProject.Font = new Font("微軟正黑體", 10F);
            lblProject.Location = new Point(848, 20);
            lblProject.Name = "lblProject";
            lblProject.Size = new Size(64, 18);
            lblProject.TabIndex = 7;
            lblProject.Text = "專案查詢";
            // 
            // txtProject
            // 
            txtProject.Font = new Font("微軟正黑體", 10F);
            txtProject.Location = new Point(918, 16);
            txtProject.Name = "txtProject";
            txtProject.Size = new Size(110, 25);
            txtProject.TabIndex = 8;
            txtProject.TextChanged += txtSearch_TextChanged;
            // 
            // lblSupplier
            // 
            lblSupplier.AutoSize = true;
            lblSupplier.Font = new Font("微軟正黑體", 10F);
            lblSupplier.Location = new Point(664, 20);
            lblSupplier.Name = "lblSupplier";
            lblSupplier.Size = new Size(64, 18);
            lblSupplier.TabIndex = 5;
            lblSupplier.Text = "廠商查詢";
            // 
            // txtSupplier
            // 
            txtSupplier.Font = new Font("微軟正黑體", 10F);
            txtSupplier.Location = new Point(733, 16);
            txtSupplier.Name = "txtSupplier";
            txtSupplier.Size = new Size(110, 25);
            txtSupplier.TabIndex = 6;
            txtSupplier.TextChanged += txtSearch_TextChanged;
            // 
            // lblNo
            // 
            lblNo.AutoSize = true;
            lblNo.Font = new Font("微軟正黑體", 10F);
            lblNo.Location = new Point(474, 20);
            lblNo.Name = "lblNo";
            lblNo.Size = new Size(64, 18);
            lblNo.TabIndex = 3;
            lblNo.Text = "單號查詢";
            // 
            // txtNo
            // 
            txtNo.Font = new Font("微軟正黑體", 10F);
            txtNo.Location = new Point(548, 16);
            txtNo.Name = "txtNo";
            txtNo.Size = new Size(110, 25);
            txtNo.TabIndex = 4;
            txtNo.TextChanged += txtSearch_TextChanged;
            // 
            // btnClosed
            // 
            btnClosed.BackColor = Color.SeaGreen;
            btnClosed.FlatStyle = FlatStyle.Flat;
            btnClosed.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            btnClosed.ForeColor = Color.White;
            btnClosed.Location = new Point(367, 14);
            btnClosed.Name = "btnClosed";
            btnClosed.Size = new Size(100, 32);
            btnClosed.TabIndex = 2;
            btnClosed.Text = "查詢已結案";
            btnClosed.UseVisualStyleBackColor = false;
            btnClosed.Click += btnClosed_Click;
            // 
            // btnWithoutDetail
            // 
            btnWithoutDetail.BackColor = Color.Firebrick;
            btnWithoutDetail.FlatStyle = FlatStyle.Flat;
            btnWithoutDetail.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            btnWithoutDetail.ForeColor = Color.White;
            btnWithoutDetail.Location = new Point(263, 14);
            btnWithoutDetail.Name = "btnWithoutDetail";
            btnWithoutDetail.Size = new Size(101, 32);
            btnWithoutDetail.TabIndex = 1;
            btnWithoutDetail.Text = "未輸入明細";
            btnWithoutDetail.UseVisualStyleBackColor = false;
            btnWithoutDetail.Click += btnWithoutDetail_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("微軟正黑體", 14F, FontStyle.Bold);
            lblTitle.ForeColor = Color.Firebrick;
            lblTitle.Location = new Point(75, 18);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(170, 24);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "採購單總覽-未結案";
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridView1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 64);
            panel2.Name = "panel2";
            panel2.Size = new Size(1467, 600);
            panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colNo, colDate, colSupplierNo, colSupplierShortName, colPurchaseType, colSupplierName, colClosed, colProject, colItemNo, colItemSpec, colPurchaseQty, colPurchaser, colReviewer });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Font = new Font("微軟正黑體", 10F);
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 26;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1467, 600);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            dataGridView1.VisibleChanged += dataGridView1_VisibleChanged;
            // 
            // colNo
            // 
            colNo.FillWeight = 90F;
            colNo.HeaderText = "單號";
            colNo.Name = "colNo";
            colNo.ReadOnly = true;
            // 
            // colDate
            // 
            colDate.FillWeight = 70F;
            colDate.HeaderText = "日期";
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
            // colPurchaseType
            // 
            colPurchaseType.FillWeight = 80F;
            colPurchaseType.HeaderText = "採購類別";
            colPurchaseType.Name = "colPurchaseType";
            colPurchaseType.ReadOnly = true;
            // 
            // colSupplierName
            // 
            colSupplierName.FillWeight = 150F;
            colSupplierName.HeaderText = "廠商名稱";
            colSupplierName.Name = "colSupplierName";
            colSupplierName.ReadOnly = true;
            // 
            // colClosed
            // 
            colClosed.FillWeight = 50F;
            colClosed.HeaderText = "結案";
            colClosed.Name = "colClosed";
            colClosed.ReadOnly = true;
            // 
            // colProject
            // 
            colProject.FillWeight = 80F;
            colProject.HeaderText = "專案序號";
            colProject.Name = "colProject";
            colProject.ReadOnly = true;
            // 
            // colItemNo
            // 
            colItemNo.FillWeight = 110F;
            colItemNo.HeaderText = "品項編號";
            colItemNo.Name = "colItemNo";
            colItemNo.ReadOnly = true;
            // 
            // colItemSpec
            // 
            colItemSpec.FillWeight = 220F;
            colItemSpec.HeaderText = "品名規格";
            colItemSpec.Name = "colItemSpec";
            colItemSpec.ReadOnly = true;
            // 
            // colPurchaseQty
            // 
            colPurchaseQty.FillWeight = 80F;
            colPurchaseQty.HeaderText = "採購數量";
            colPurchaseQty.Name = "colPurchaseQty";
            colPurchaseQty.ReadOnly = true;
            // 
            // colPurchaser
            // 
            colPurchaser.FillWeight = 80F;
            colPurchaser.HeaderText = "採購人員";
            colPurchaser.Name = "colPurchaser";
            colPurchaser.ReadOnly = true;
            // 
            // colReviewer
            // 
            colReviewer.FillWeight = 80F;
            colReviewer.HeaderText = "覆核人員";
            colReviewer.Name = "colReviewer";
            colReviewer.ReadOnly = true;
            // 
            // ProcurementControl
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("微軟正黑體", 10F);
            Margin = new Padding(4);
            Name = "ProcurementControl";
            Size = new Size(1467, 664);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblTitle;
        private Button btnWithoutDetail;
        private Button btnClosed;
        private Label lblNo;
        private TextBox txtNo;
        private Label lblSupplier;
        private TextBox txtSupplier;
        private Label lblProject;
        private TextBox txtProject;
        private Label lblItemName;
        private TextBox txtItemName;
        private Button btnAdd;
        private Button btnExit;
        private Panel panel2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn colNo;
        private DataGridViewTextBoxColumn colDate;
        private DataGridViewTextBoxColumn colSupplierNo;
        private DataGridViewTextBoxColumn colSupplierShortName;
        private DataGridViewTextBoxColumn colPurchaseType;
        private DataGridViewTextBoxColumn colSupplierName;
        private DataGridViewCheckBoxColumn colClosed;
        private DataGridViewTextBoxColumn colProject;
        private DataGridViewTextBoxColumn colItemNo;
        private DataGridViewTextBoxColumn colItemSpec;
        private DataGridViewTextBoxColumn colPurchaseQty;
        private DataGridViewTextBoxColumn colPurchaser;
        private DataGridViewTextBoxColumn colReviewer;
        private PictureBox pictureBox1;
    }
}
