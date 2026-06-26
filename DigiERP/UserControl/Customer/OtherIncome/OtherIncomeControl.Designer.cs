namespace DigiERP.UserControl.Customer.OtherIncome
{
    partial class OtherIncomeControl
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 元件設計工具產生的程式碼

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle15 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle16 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle17 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle18 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle19 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle20 = new DataGridViewCellStyle();
            panel1 = new Panel();
            btn新增 = new Button();
            btn查詢 = new Button();
            cboCustId = new DigiERP.Common.CommonComboBox();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            colOrderNo = new DataGridViewTextBoxColumn();
            colDate = new DataGridViewTextBoxColumn();
            colCustId = new DataGridViewTextBoxColumn();
            colSales = new DataGridViewTextBoxColumn();
            colCurrency = new DataGridViewTextBoxColumn();
            colTaxType = new DataGridViewTextBoxColumn();
            colTotal = new DataGridViewTextBoxColumn();
            colPayment = new DataGridViewTextBoxColumn();
            colClosed = new DataGridViewTextBoxColumn();
            colApprover = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 192, 192);
            panel1.Controls.Add(btn新增);
            panel1.Controls.Add(btn查詢);
            panel1.Controls.Add(cboCustId);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1654, 112);
            panel1.TabIndex = 0;
            // 
            // btn新增
            // 
            btn新增.BackColor = Color.CornflowerBlue;
            btn新增.ForeColor = SystemColors.ButtonFace;
            btn新增.Location = new Point(1000, 32);
            btn新增.Name = "btn新增";
            btn新增.Size = new Size(120, 52);
            btn新增.TabIndex = 6;
            btn新增.Text = "新增";
            btn新增.UseVisualStyleBackColor = false;
            btn新增.Click += btn新增_Click;
            // 
            // btn查詢
            // 
            btn查詢.BackColor = Color.SteelBlue;
            btn查詢.ForeColor = SystemColors.ButtonFace;
            btn查詢.Location = new Point(860, 32);
            btn查詢.Name = "btn查詢";
            btn查詢.Size = new Size(120, 52);
            btn查詢.TabIndex = 5;
            btn查詢.Text = "查詢";
            btn查詢.UseVisualStyleBackColor = false;
            btn查詢.Click += btn查詢_Click;
            // 
            // cboCustId
            // 
            cboCustId.FormattingEnabled = true;
            cboCustId.Location = new Point(648, 40);
            cboCustId.Name = "cboCustId";
            cboCustId.Size = new Size(200, 32);
            cboCustId.TabIndex = 3;
            cboCustId.MouseClick += cboCustId_MouseClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(552, 44);
            label2.Name = "label2";
            label2.Size = new Size(86, 24);
            label2.TabIndex = 2;
            label2.Text = "客戶篩選";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label1.Location = new Point(144, 36);
            label1.Name = "label1";
            label1.Size = new Size(249, 37);
            label1.TabIndex = 1;
            label1.Text = "其他收入列表總覽";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.able;
            pictureBox1.Location = new Point(12, 8);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(120, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridView1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 112);
            panel2.Name = "panel2";
            panel2.Size = new Size(1654, 796);
            panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colOrderNo, colDate, colCustId, colSales, colCurrency, colTaxType, colTotal, colPayment, colClosed, colApprover });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(1654, 796);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            dataGridView1.VisibleChanged += dataGridView1_VisibleChanged;
            // 
            // colOrderNo
            // 
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.True;
            colOrderNo.DefaultCellStyle = dataGridViewCellStyle11;
            colOrderNo.HeaderText = "單號";
            colOrderNo.Name = "colOrderNo";
            colOrderNo.ReadOnly = true;
            // 
            // colDate
            // 
            dataGridViewCellStyle12.WrapMode = DataGridViewTriState.True;
            colDate.DefaultCellStyle = dataGridViewCellStyle12;
            colDate.HeaderText = "日期";
            colDate.Name = "colDate";
            colDate.ReadOnly = true;
            // 
            // colCustId
            // 
            dataGridViewCellStyle13.WrapMode = DataGridViewTriState.True;
            colCustId.DefaultCellStyle = dataGridViewCellStyle13;
            colCustId.HeaderText = "客戶編號";
            colCustId.Name = "colCustId";
            colCustId.ReadOnly = true;
            // 
            // colSales
            // 
            dataGridViewCellStyle14.WrapMode = DataGridViewTriState.True;
            colSales.DefaultCellStyle = dataGridViewCellStyle14;
            colSales.HeaderText = "業務員";
            colSales.Name = "colSales";
            colSales.ReadOnly = true;
            // 
            // colCurrency
            // 
            dataGridViewCellStyle15.WrapMode = DataGridViewTriState.True;
            colCurrency.DefaultCellStyle = dataGridViewCellStyle15;
            colCurrency.HeaderText = "幣別";
            colCurrency.Name = "colCurrency";
            colCurrency.ReadOnly = true;
            // 
            // colTaxType
            // 
            dataGridViewCellStyle16.WrapMode = DataGridViewTriState.True;
            colTaxType.DefaultCellStyle = dataGridViewCellStyle16;
            colTaxType.HeaderText = "稅別";
            colTaxType.Name = "colTaxType";
            colTaxType.ReadOnly = true;
            // 
            // colTotal
            // 
            dataGridViewCellStyle17.WrapMode = DataGridViewTriState.True;
            colTotal.DefaultCellStyle = dataGridViewCellStyle17;
            colTotal.HeaderText = "總額";
            colTotal.Name = "colTotal";
            colTotal.ReadOnly = true;
            // 
            // colPayment
            // 
            dataGridViewCellStyle18.WrapMode = DataGridViewTriState.True;
            colPayment.DefaultCellStyle = dataGridViewCellStyle18;
            colPayment.HeaderText = "付款方式";
            colPayment.Name = "colPayment";
            colPayment.ReadOnly = true;
            // 
            // colClosed
            // 
            dataGridViewCellStyle19.WrapMode = DataGridViewTriState.True;
            colClosed.DefaultCellStyle = dataGridViewCellStyle19;
            colClosed.HeaderText = "結案";
            colClosed.Name = "colClosed";
            colClosed.ReadOnly = true;
            // 
            // colApprover
            // 
            dataGridViewCellStyle20.WrapMode = DataGridViewTriState.True;
            colApprover.DefaultCellStyle = dataGridViewCellStyle20;
            colApprover.HeaderText = "核准";
            colApprover.Name = "colApprover";
            colApprover.ReadOnly = true;
            // 
            // OtherIncomeControl
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(192, 255, 192);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            Name = "OtherIncomeControl";
            Size = new Size(1654, 908);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private DigiERP.Common.CommonComboBox cboCustId;
        private Button btn查詢;
        private Button btn新增;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn colOrderNo;
        private DataGridViewTextBoxColumn colDate;
        private DataGridViewTextBoxColumn colCustId;
        private DataGridViewTextBoxColumn colSales;
        private DataGridViewTextBoxColumn colCurrency;
        private DataGridViewTextBoxColumn colTaxType;
        private DataGridViewTextBoxColumn colTotal;
        private DataGridViewTextBoxColumn colPayment;
        private DataGridViewTextBoxColumn colClosed;
        private DataGridViewTextBoxColumn colApprover;
    }
}
