using System.Drawing;
using System.Windows.Forms;

namespace DigiERP.UserControl.Accounts.Payment
{
    partial class GeneralExpensesControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GeneralExpensesControl));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            lblTitle = new Label();
            btnOpen = new Button();
            btnClosed = new Button();
            btnAdd = new Button();
            btnExit = new Button();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            colNo = new DataGridViewTextBoxColumn();
            colDate = new DataGridViewTextBoxColumn();
            colSupplierNo = new DataGridViewTextBoxColumn();
            colSupplierShortName = new DataGridViewTextBoxColumn();
            colPurchaseType = new DataGridViewTextBoxColumn();
            colTerms = new DataGridViewTextBoxColumn();
            colClosed = new DataGridViewCheckBoxColumn();
            colItemNo = new DataGridViewTextBoxColumn();
            colItemName = new DataGridViewTextBoxColumn();
            colHandler = new DataGridViewTextBoxColumn();
            colApproval = new DataGridViewTextBoxColumn();
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
            panel1.Controls.Add(lblTitle);
            panel1.Controls.Add(btnOpen);
            panel1.Controls.Add(btnClosed);
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(btnExit);
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
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("微軟正黑體", 14F, FontStyle.Bold);
            lblTitle.ForeColor = Color.Firebrick;
            lblTitle.Location = new Point(80, 18);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(208, 24);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "總務支出單總覽-未結案";
            // 
            // btnOpen
            // 
            btnOpen.BackColor = Color.SteelBlue;
            btnOpen.FlatStyle = FlatStyle.Flat;
            btnOpen.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            btnOpen.ForeColor = Color.White;
            btnOpen.Location = new Point(1063, 14);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(100, 32);
            btnOpen.TabIndex = 1;
            btnOpen.Text = "未結案";
            btnOpen.UseVisualStyleBackColor = false;
            btnOpen.Click += btnOpen_Click;
            // 
            // btnClosed
            // 
            btnClosed.BackColor = Color.SeaGreen;
            btnClosed.FlatStyle = FlatStyle.Flat;
            btnClosed.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            btnClosed.ForeColor = Color.White;
            btnClosed.Location = new Point(1173, 14);
            btnClosed.Name = "btnClosed";
            btnClosed.Size = new Size(100, 32);
            btnClosed.TabIndex = 2;
            btnClosed.Text = "已結案";
            btnClosed.UseVisualStyleBackColor = false;
            btnClosed.Click += btnClosed_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Gainsboro;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            btnAdd.Location = new Point(1283, 14);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(80, 32);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "新增";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Gainsboro;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            btnExit.Location = new Point(1373, 14);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(80, 32);
            btnExit.TabIndex = 4;
            btnExit.Text = "EXIT";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Visible = false;
            btnExit.Click += btnExit_Click;
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
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colNo, colDate, colSupplierNo, colSupplierShortName, colPurchaseType, colTerms, colClosed, colItemNo, colItemName, colHandler, colApproval });
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
            colSupplierNo.FillWeight = 80F;
            colSupplierNo.HeaderText = "廠商編號";
            colSupplierNo.Name = "colSupplierNo";
            colSupplierNo.ReadOnly = true;
            // 
            // colSupplierShortName
            // 
            colSupplierShortName.FillWeight = 110F;
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
            // colTerms
            // 
            colTerms.FillWeight = 90F;
            colTerms.HeaderText = "交易條件";
            colTerms.Name = "colTerms";
            colTerms.ReadOnly = true;
            // 
            // colClosed
            // 
            colClosed.FillWeight = 50F;
            colClosed.HeaderText = "結案";
            colClosed.Name = "colClosed";
            colClosed.ReadOnly = true;
            // 
            // colItemNo
            // 
            colItemNo.HeaderText = "項目編號";
            colItemNo.Name = "colItemNo";
            colItemNo.ReadOnly = true;
            // 
            // colItemName
            // 
            colItemName.FillWeight = 160F;
            colItemName.HeaderText = "項目名稱";
            colItemName.Name = "colItemName";
            colItemName.ReadOnly = true;
            // 
            // colHandler
            // 
            colHandler.FillWeight = 80F;
            colHandler.HeaderText = "承辦";
            colHandler.Name = "colHandler";
            colHandler.ReadOnly = true;
            // 
            // colApproval
            // 
            colApproval.FillWeight = 80F;
            colApproval.HeaderText = "核准";
            colApproval.Name = "colApproval";
            colApproval.ReadOnly = true;
            // 
            // GeneralExpensesControl
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("微軟正黑體", 10F);
            Margin = new Padding(4);
            Name = "GeneralExpensesControl";
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
        private PictureBox pictureBox1;
        private Label lblTitle;
        private Button btnOpen;
        private Button btnClosed;
        private Button btnAdd;
        private Button btnExit;
        private Panel panel2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn colNo;
        private DataGridViewTextBoxColumn colDate;
        private DataGridViewTextBoxColumn colSupplierNo;
        private DataGridViewTextBoxColumn colSupplierShortName;
        private DataGridViewTextBoxColumn colPurchaseType;
        private DataGridViewTextBoxColumn colTerms;
        private DataGridViewCheckBoxColumn colClosed;
        private DataGridViewTextBoxColumn colItemNo;
        private DataGridViewTextBoxColumn colItemName;
        private DataGridViewTextBoxColumn colHandler;
        private DataGridViewTextBoxColumn colApproval;
    }
}
