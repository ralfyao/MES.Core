using System.Drawing;
using System.Windows.Forms;

namespace DigiERP.UserControl.Inventory.StockIn
{
    partial class StockInControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockInControl));
            panel1 = new Panel();
            btnExit = new Button();
            btnSave = new Button();
            btnAdd = new Button();
            lblItemName = new Label();
            txtItemName = new TextBox();
            lblProject = new Label();
            txtProject = new TextBox();
            lblSupplier = new Label();
            txtSupplier = new TextBox();
            btnDateFilter = new Button();
            lblTilde = new Label();
            dtTo = new DateTimePicker();
            dtFrom = new DateTimePicker();
            lblTitle = new Label();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            colNo = new DataGridViewTextBoxColumn();
            colDate = new DataGridViewTextBoxColumn();
            colSupplierNo = new DataGridViewTextBoxColumn();
            colSupplierShortName = new DataGridViewTextBoxColumn();
            colWarehouseWorker = new DataGridViewTextBoxColumn();
            colPurchaseReview = new DataGridViewTextBoxColumn();
            colProject = new DataGridViewTextBoxColumn();
            colItemNo = new DataGridViewTextBoxColumn();
            colItemSpec = new DataGridViewTextBoxColumn();
            colReceiveQty = new DataGridViewTextBoxColumn();
            colQualifiedQty = new DataGridViewTextBoxColumn();
            colSpecialQty = new DataGridViewTextBoxColumn();
            colReturnQty = new DataGridViewTextBoxColumn();
            colInvoiceNo = new DataGridViewTextBoxColumn();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnExit);
            panel1.Controls.Add(btnSave);
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(lblItemName);
            panel1.Controls.Add(txtItemName);
            panel1.Controls.Add(lblProject);
            panel1.Controls.Add(txtProject);
            panel1.Controls.Add(lblSupplier);
            panel1.Controls.Add(txtSupplier);
            panel1.Controls.Add(btnDateFilter);
            panel1.Controls.Add(lblTilde);
            panel1.Controls.Add(dtTo);
            panel1.Controls.Add(dtFrom);
            panel1.Controls.Add(lblTitle);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1720, 56);
            panel1.TabIndex = 0;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Gainsboro;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            btnExit.Location = new Point(1630, 10);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(80, 32);
            btnExit.TabIndex = 13;
            btnExit.Text = "EXIT";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Visible = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Gainsboro;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            btnSave.Location = new Point(1540, 10);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(80, 32);
            btnSave.TabIndex = 12;
            btnSave.Text = "儲存";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Visible = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Gainsboro;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            btnAdd.Location = new Point(1450, 10);
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
            lblItemName.Location = new Point(972, 18);
            lblItemName.Name = "lblItemName";
            lblItemName.Size = new Size(64, 18);
            lblItemName.TabIndex = 9;
            lblItemName.Text = "品名查詢";
            // 
            // txtItemName
            // 
            txtItemName.Font = new Font("微軟正黑體", 10F);
            txtItemName.Location = new Point(1037, 14);
            txtItemName.Name = "txtItemName";
            txtItemName.Size = new Size(150, 25);
            txtItemName.TabIndex = 10;
            txtItemName.TextChanged += txtSearch_TextChanged;
            // 
            // lblProject
            // 
            lblProject.AutoSize = true;
            lblProject.Font = new Font("微軟正黑體", 10F);
            lblProject.Location = new Point(772, 18);
            lblProject.Name = "lblProject";
            lblProject.Size = new Size(64, 18);
            lblProject.TabIndex = 7;
            lblProject.Text = "專案查詢";
            // 
            // txtProject
            // 
            txtProject.Font = new Font("微軟正黑體", 10F);
            txtProject.Location = new Point(837, 14);
            txtProject.Name = "txtProject";
            txtProject.Size = new Size(120, 25);
            txtProject.TabIndex = 8;
            txtProject.TextChanged += txtSearch_TextChanged;
            // 
            // lblSupplier
            // 
            lblSupplier.AutoSize = true;
            lblSupplier.Font = new Font("微軟正黑體", 10F);
            lblSupplier.Location = new Point(572, 18);
            lblSupplier.Name = "lblSupplier";
            lblSupplier.Size = new Size(64, 18);
            lblSupplier.TabIndex = 5;
            lblSupplier.Text = "廠商查詢";
            // 
            // txtSupplier
            // 
            txtSupplier.Font = new Font("微軟正黑體", 10F);
            txtSupplier.Location = new Point(637, 14);
            txtSupplier.Name = "txtSupplier";
            txtSupplier.Size = new Size(120, 25);
            txtSupplier.TabIndex = 6;
            txtSupplier.TextChanged += txtSearch_TextChanged;
            // 
            // btnDateFilter
            // 
            btnDateFilter.BackColor = Color.SteelBlue;
            btnDateFilter.FlatStyle = FlatStyle.Flat;
            btnDateFilter.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            btnDateFilter.ForeColor = Color.White;
            btnDateFilter.Location = new Point(448, 10);
            btnDateFilter.Name = "btnDateFilter";
            btnDateFilter.Size = new Size(110, 32);
            btnDateFilter.TabIndex = 4;
            btnDateFilter.Text = "日期區間篩選";
            btnDateFilter.UseVisualStyleBackColor = false;
            btnDateFilter.Click += btnDateFilter_Click;
            // 
            // lblTilde
            // 
            lblTilde.AutoSize = true;
            lblTilde.Font = new Font("微軟正黑體", 10F);
            lblTilde.Location = new Point(300, 18);
            lblTilde.Name = "lblTilde";
            lblTilde.Size = new Size(18, 18);
            lblTilde.TabIndex = 2;
            lblTilde.Text = "~";
            // 
            // dtTo
            // 
            dtTo.Format = DateTimePickerFormat.Short;
            dtTo.Location = new Point(320, 14);
            dtTo.Name = "dtTo";
            dtTo.Size = new Size(115, 25);
            dtTo.TabIndex = 3;
            // 
            // dtFrom
            // 
            dtFrom.Format = DateTimePickerFormat.Short;
            dtFrom.Location = new Point(180, 14);
            dtFrom.Name = "dtFrom";
            dtFrom.Size = new Size(115, 25);
            dtFrom.TabIndex = 1;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("微軟正黑體", 14F, FontStyle.Bold);
            lblTitle.ForeColor = Color.Firebrick;
            lblTitle.Location = new Point(68, 16);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(105, 24);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "進貨單總覽";
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridView1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 56);
            panel2.Name = "panel2";
            panel2.Size = new Size(1720, 600);
            panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colNo, colDate, colSupplierNo, colSupplierShortName, colWarehouseWorker, colPurchaseReview, colProject, colItemNo, colItemSpec, colReceiveQty, colQualifiedQty, colSpecialQty, colReturnQty, colInvoiceNo });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Font = new Font("微軟正黑體", 10F);
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 26;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1720, 600);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
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
            colDate.FillWeight = 75F;
            colDate.HeaderText = "日期";
            colDate.Name = "colDate";
            colDate.ReadOnly = true;
            // 
            // colSupplierNo
            // 
            colSupplierNo.FillWeight = 75F;
            colSupplierNo.HeaderText = "廠商編號";
            colSupplierNo.Name = "colSupplierNo";
            colSupplierNo.ReadOnly = true;
            // 
            // colSupplierShortName
            // 
            colSupplierShortName.HeaderText = "廠商簡稱";
            colSupplierShortName.Name = "colSupplierShortName";
            colSupplierShortName.ReadOnly = true;
            // 
            // colWarehouseWorker
            // 
            colWarehouseWorker.FillWeight = 80F;
            colWarehouseWorker.HeaderText = "倉管人員";
            colWarehouseWorker.Name = "colWarehouseWorker";
            colWarehouseWorker.ReadOnly = true;
            // 
            // colPurchaseReview
            // 
            colPurchaseReview.FillWeight = 80F;
            colPurchaseReview.HeaderText = "採購覆核";
            colPurchaseReview.Name = "colPurchaseReview";
            colPurchaseReview.ReadOnly = true;
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
            colItemNo.FillWeight = 120F;
            colItemNo.HeaderText = "品項編號";
            colItemNo.Name = "colItemNo";
            colItemNo.ReadOnly = true;
            // 
            // colItemSpec
            // 
            colItemSpec.FillWeight = 260F;
            colItemSpec.HeaderText = "品名規格";
            colItemSpec.Name = "colItemSpec";
            colItemSpec.ReadOnly = true;
            // 
            // colReceiveQty
            // 
            colReceiveQty.FillWeight = 80F;
            colReceiveQty.HeaderText = "收貨數量";
            colReceiveQty.Name = "colReceiveQty";
            colReceiveQty.ReadOnly = true;
            // 
            // colQualifiedQty
            // 
            colQualifiedQty.FillWeight = 80F;
            colQualifiedQty.HeaderText = "合格數量";
            colQualifiedQty.Name = "colQualifiedQty";
            colQualifiedQty.ReadOnly = true;
            // 
            // colSpecialQty
            // 
            colSpecialQty.FillWeight = 80F;
            colSpecialQty.HeaderText = "特採數量";
            colSpecialQty.Name = "colSpecialQty";
            colSpecialQty.ReadOnly = true;
            // 
            // colReturnQty
            // 
            colReturnQty.FillWeight = 80F;
            colReturnQty.HeaderText = "退回數量";
            colReturnQty.Name = "colReturnQty";
            colReturnQty.ReadOnly = true;
            // 
            // colInvoiceNo
            // 
            colInvoiceNo.FillWeight = 110F;
            colInvoiceNo.HeaderText = "進項憑證編號";
            colInvoiceNo.Name = "colInvoiceNo";
            colInvoiceNo.ReadOnly = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(4, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(64, 48);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // StockInControl
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("微軟正黑體", 10F);
            Margin = new Padding(4);
            Name = "StockInControl";
            Size = new Size(1720, 656);
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
        private DateTimePicker dtFrom;
        private Label lblTilde;
        private DateTimePicker dtTo;
        private Button btnDateFilter;
        private Label lblSupplier;
        private TextBox txtSupplier;
        private Label lblProject;
        private TextBox txtProject;
        private Label lblItemName;
        private TextBox txtItemName;
        private Button btnAdd;
        private Button btnSave;
        private Button btnExit;
        private Panel panel2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn colNo;
        private DataGridViewTextBoxColumn colDate;
        private DataGridViewTextBoxColumn colSupplierNo;
        private DataGridViewTextBoxColumn colSupplierShortName;
        private DataGridViewTextBoxColumn colWarehouseWorker;
        private DataGridViewTextBoxColumn colPurchaseReview;
        private DataGridViewTextBoxColumn colProject;
        private DataGridViewTextBoxColumn colItemNo;
        private DataGridViewTextBoxColumn colItemSpec;
        private DataGridViewTextBoxColumn colReceiveQty;
        private DataGridViewTextBoxColumn colQualifiedQty;
        private DataGridViewTextBoxColumn colSpecialQty;
        private DataGridViewTextBoxColumn colReturnQty;
        private DataGridViewTextBoxColumn colInvoiceNo;
        private PictureBox pictureBox1;
    }
}
