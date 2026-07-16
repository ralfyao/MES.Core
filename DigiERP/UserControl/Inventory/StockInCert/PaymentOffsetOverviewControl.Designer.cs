using System.Drawing;
using System.Windows.Forms;

namespace DigiERP.UserControl.Inventory.StockInCert
{
    partial class PaymentOffsetOverviewControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaymentOffsetOverviewControl));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            lblTitle = new Label();
            btnWithin60 = new Button();
            btnOver60 = new Button();
            btnAdd = new Button();
            btnExit = new Button();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            colNo = new DataGridViewTextBoxColumn();
            colDate = new DataGridViewTextBoxColumn();
            colSupplierNo = new DataGridViewTextBoxColumn();
            colSupplierName = new DataGridViewTextBoxColumn();
            colCurrency = new DataGridViewTextBoxColumn();
            colOrigUntaxed = new DataGridViewTextBoxColumn();
            colAmount = new DataGridViewTextBoxColumn();
            colOrigOffset = new DataGridViewTextBoxColumn();
            colTwdOffset = new DataGridViewTextBoxColumn();
            colAllowance = new DataGridViewTextBoxColumn();
            colExDiff = new DataGridViewTextBoxColumn();
            colReviewer = new DataGridViewTextBoxColumn();
            colReviewDate = new DataGridViewTextBoxColumn();
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
            panel1.Controls.Add(btnWithin60);
            panel1.Controls.Add(btnOver60);
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(btnExit);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1600, 56);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(4, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(48, 48);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("微軟正黑體", 14F, FontStyle.Bold);
            lblTitle.Location = new Point(60, 16);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(124, 24);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "付款沖帳總覽";
            // 
            // btnWithin60
            // 
            btnWithin60.BackColor = Color.SteelBlue;
            btnWithin60.FlatStyle = FlatStyle.Flat;
            btnWithin60.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            btnWithin60.ForeColor = Color.White;
            btnWithin60.Location = new Point(340, 12);
            btnWithin60.Name = "btnWithin60";
            btnWithin60.Size = new Size(100, 32);
            btnWithin60.TabIndex = 1;
            btnWithin60.Text = "60天內";
            btnWithin60.UseVisualStyleBackColor = false;
            btnWithin60.Click += btnWithin60_Click;
            // 
            // btnOver60
            // 
            btnOver60.BackColor = Color.YellowGreen;
            btnOver60.FlatStyle = FlatStyle.Flat;
            btnOver60.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            btnOver60.ForeColor = Color.White;
            btnOver60.Location = new Point(450, 12);
            btnOver60.Name = "btnOver60";
            btnOver60.Size = new Size(110, 32);
            btnOver60.TabIndex = 2;
            btnOver60.Text = "超過60天";
            btnOver60.UseVisualStyleBackColor = false;
            btnOver60.Click += btnOver60_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Gainsboro;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            btnAdd.Location = new Point(1400, 12);
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
            btnExit.Location = new Point(1490, 12);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(90, 32);
            btnExit.TabIndex = 4;
            btnExit.Text = "關閉";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridView1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 56);
            panel2.Name = "panel2";
            panel2.Size = new Size(1600, 600);
            panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colNo, colDate, colSupplierNo, colSupplierName, colCurrency, colOrigUntaxed, colAmount, colOrigOffset, colTwdOffset, colAllowance, colExDiff, colReviewer, colReviewDate });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Font = new Font("微軟正黑體", 9F);
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 26;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1600, 600);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // colNo
            // 
            colNo.HeaderText = "單號";
            colNo.Name = "colNo";
            colNo.ReadOnly = true;
            // 
            // colDate
            // 
            colDate.HeaderText = "日期";
            colDate.Name = "colDate";
            colDate.ReadOnly = true;
            // 
            // colSupplierNo
            // 
            colSupplierNo.HeaderText = "廠商編號";
            colSupplierNo.Name = "colSupplierNo";
            colSupplierNo.ReadOnly = true;
            // 
            // colSupplierName
            // 
            colSupplierName.FillWeight = 160F;
            colSupplierName.HeaderText = "廠商名稱";
            colSupplierName.Name = "colSupplierName";
            colSupplierName.ReadOnly = true;
            // 
            // colCurrency
            // 
            colCurrency.HeaderText = "幣別";
            colCurrency.Name = "colCurrency";
            colCurrency.ReadOnly = true;
            // 
            // colOrigUntaxed
            // 
            colOrigUntaxed.HeaderText = "原幣未稅";
            colOrigUntaxed.Name = "colOrigUntaxed";
            colOrigUntaxed.ReadOnly = true;
            // 
            // colAmount
            // 
            colAmount.HeaderText = "台幣應收";
            colAmount.Name = "colAmount";
            colAmount.ReadOnly = true;
            // 
            // colOrigOffset
            // 
            colOrigOffset.HeaderText = "原幣沖帳";
            colOrigOffset.Name = "colOrigOffset";
            colOrigOffset.ReadOnly = true;
            // 
            // colTwdOffset
            // 
            colTwdOffset.HeaderText = "台幣沖帳";
            colTwdOffset.Name = "colTwdOffset";
            colTwdOffset.ReadOnly = true;
            // 
            // colAllowance
            // 
            colAllowance.HeaderText = "折讓金額";
            colAllowance.Name = "colAllowance";
            colAllowance.ReadOnly = true;
            // 
            // colExDiff
            // 
            colExDiff.HeaderText = "匯差";
            colExDiff.Name = "colExDiff";
            colExDiff.ReadOnly = true;
            // 
            // colReviewer
            // 
            colReviewer.HeaderText = "覆核人員";
            colReviewer.Name = "colReviewer";
            colReviewer.ReadOnly = true;
            // 
            // colReviewDate
            // 
            colReviewDate.HeaderText = "覆核日";
            colReviewDate.Name = "colReviewDate";
            colReviewDate.ReadOnly = true;
            // 
            // PaymentOffsetOverviewControl
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("微軟正黑體", 10F);
            Margin = new Padding(4);
            Name = "PaymentOffsetOverviewControl";
            Size = new Size(1600, 656);
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
        private Button btnWithin60;
        private Button btnOver60;
        private Button btnAdd;
        private Button btnExit;
        private Panel panel2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn colNo;
        private DataGridViewTextBoxColumn colDate;
        private DataGridViewTextBoxColumn colSupplierNo;
        private DataGridViewTextBoxColumn colSupplierName;
        private DataGridViewTextBoxColumn colCurrency;
        private DataGridViewTextBoxColumn colOrigUntaxed;
        private DataGridViewTextBoxColumn colAmount;
        private DataGridViewTextBoxColumn colOrigOffset;
        private DataGridViewTextBoxColumn colTwdOffset;
        private DataGridViewTextBoxColumn colAllowance;
        private DataGridViewTextBoxColumn colExDiff;
        private DataGridViewTextBoxColumn colReviewer;
        private DataGridViewTextBoxColumn colReviewDate;
    }
}
