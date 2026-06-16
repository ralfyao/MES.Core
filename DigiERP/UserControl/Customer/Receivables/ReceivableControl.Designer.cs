namespace DigiERP.UserControl.Customer.Receivables
{
    partial class ReceivableControl
    {
        /// <summary> 
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 元件設計工具產生的程式碼

        /// <summary> 
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReceivableControl));
            panel1 = new Panel();
            button2 = new Button();
            button1 = new Button();
            btnClosed = new Button();
            btnUnClosed = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            OrderNo = new DataGridViewTextBoxColumn();
            Date = new DataGridViewTextBoxColumn();
            CustNo = new DataGridViewTextBoxColumn();
            CustName = new DataGridViewTextBoxColumn();
            Currency = new DataGridViewTextBoxColumn();
            Category = new DataGridViewTextBoxColumn();
            InvoiceDate = new DataGridViewTextBoxColumn();
            InvoceNo = new DataGridViewTextBoxColumn();
            CertCategory = new DataGridViewTextBoxColumn();
            UnTaxAmount = new DataGridViewTextBoxColumn();
            Tax = new DataGridViewTextBoxColumn();
            ReceivableAmount = new DataGridViewTextBoxColumn();
            Subpoena = new DataGridViewTextBoxColumn();
            Auudit = new DataGridViewTextBoxColumn();
            Closed = new DataGridViewCheckBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(btnClosed);
            panel1.Controls.Add(btnUnClosed);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1355, 100);
            panel1.TabIndex = 0;
            // 
            // button2
            // 
            button2.BackColor = Color.Gray;
            button2.Font = new Font("Microsoft JhengHei UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 136);
            button2.ForeColor = SystemColors.Control;
            button2.Location = new Point(940, 32);
            button2.Name = "button2";
            button2.Size = new Size(128, 36);
            button2.TabIndex = 5;
            button2.Text = "關閉";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Gray;
            button1.Font = new Font("Microsoft JhengHei UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 136);
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(796, 32);
            button1.Name = "button1";
            button1.Size = new Size(128, 36);
            button1.TabIndex = 4;
            button1.Text = "新增";
            button1.UseVisualStyleBackColor = false;
            // 
            // btnClosed
            // 
            btnClosed.BackColor = Color.DarkSeaGreen;
            btnClosed.Font = new Font("Microsoft JhengHei UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 136);
            btnClosed.ForeColor = SystemColors.Control;
            btnClosed.Location = new Point(448, 32);
            btnClosed.Name = "btnClosed";
            btnClosed.Size = new Size(128, 36);
            btnClosed.TabIndex = 3;
            btnClosed.Text = "已結案";
            btnClosed.UseVisualStyleBackColor = false;
            // 
            // btnUnClosed
            // 
            btnUnClosed.BackColor = Color.DodgerBlue;
            btnUnClosed.Font = new Font("Microsoft JhengHei UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 136);
            btnUnClosed.ForeColor = SystemColors.Control;
            btnUnClosed.Location = new Point(292, 32);
            btnUnClosed.Name = "btnUnClosed";
            btnUnClosed.Size = new Size(128, 36);
            btnUnClosed.TabIndex = 2;
            btnUnClosed.Text = "未結案";
            btnUnClosed.UseVisualStyleBackColor = false;
            btnUnClosed.Click += btnUnClosed_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label1.Location = new Point(116, 36);
            label1.Name = "label1";
            label1.Size = new Size(138, 26);
            label1.TabIndex = 1;
            label1.Text = "應收立帳總覽";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(8, 8);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(96, 84);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridView1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 100);
            panel2.Name = "panel2";
            panel2.Size = new Size(1355, 535);
            panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { OrderNo, Date, CustNo, CustName, Currency, Category, InvoiceDate, InvoceNo, CertCategory, UnTaxAmount, Tax, ReceivableAmount, Subpoena, Auudit, Closed });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(1355, 535);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.VisibleChanged += dataGridView1_VisibleChanged;
            // 
            // OrderNo
            // 
            OrderNo.HeaderText = "單號";
            OrderNo.Name = "OrderNo";
            OrderNo.ReadOnly = true;
            // 
            // Date
            // 
            Date.HeaderText = "日期";
            Date.Name = "Date";
            Date.ReadOnly = true;
            // 
            // CustNo
            // 
            CustNo.HeaderText = "客戶編號";
            CustNo.Name = "CustNo";
            CustNo.ReadOnly = true;
            // 
            // CustName
            // 
            CustName.HeaderText = "客戶名稱";
            CustName.Name = "CustName";
            CustName.ReadOnly = true;
            // 
            // Currency
            // 
            Currency.HeaderText = "幣別";
            Currency.Name = "Currency";
            Currency.ReadOnly = true;
            // 
            // Category
            // 
            Category.HeaderText = "類別";
            Category.Name = "Category";
            Category.ReadOnly = true;
            // 
            // InvoiceDate
            // 
            InvoiceDate.HeaderText = "發票日期";
            InvoiceDate.Name = "InvoiceDate";
            InvoiceDate.ReadOnly = true;
            // 
            // InvoceNo
            // 
            InvoceNo.HeaderText = "發票號碼";
            InvoceNo.Name = "InvoceNo";
            InvoceNo.ReadOnly = true;
            // 
            // CertCategory
            // 
            CertCategory.HeaderText = "憑證種類";
            CertCategory.Name = "CertCategory";
            CertCategory.ReadOnly = true;
            // 
            // UnTaxAmount
            // 
            UnTaxAmount.HeaderText = "未稅金額";
            UnTaxAmount.Name = "UnTaxAmount";
            UnTaxAmount.ReadOnly = true;
            // 
            // Tax
            // 
            Tax.HeaderText = "稅額";
            Tax.Name = "Tax";
            Tax.ReadOnly = true;
            // 
            // ReceivableAmount
            // 
            ReceivableAmount.HeaderText = "應收總額";
            ReceivableAmount.Name = "ReceivableAmount";
            ReceivableAmount.ReadOnly = true;
            // 
            // Subpoena
            // 
            Subpoena.HeaderText = "傳票";
            Subpoena.Name = "Subpoena";
            Subpoena.ReadOnly = true;
            // 
            // Auudit
            // 
            Auudit.HeaderText = "核准";
            Auudit.Name = "Auudit";
            Auudit.ReadOnly = true;
            // 
            // Closed
            // 
            Closed.HeaderText = "結案";
            Closed.Name = "Closed";
            Closed.ReadOnly = true;
            // 
            // ReceivableControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Khaki;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "ReceivableControl";
            Size = new Size(1355, 635);
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
        private DataGridView dataGridView1;
        private Label label1;
        private Button btnUnClosed;
        private Button btnClosed;
        private Button button2;
        private Button button1;
        private DataGridViewTextBoxColumn OrderNo;
        private DataGridViewTextBoxColumn Date;
        private DataGridViewTextBoxColumn CustNo;
        private DataGridViewTextBoxColumn CustName;
        private DataGridViewTextBoxColumn Currency;
        private DataGridViewTextBoxColumn Category;
        private DataGridViewTextBoxColumn InvoiceDate;
        private DataGridViewTextBoxColumn InvoceNo;
        private DataGridViewTextBoxColumn CertCategory;
        private DataGridViewTextBoxColumn UnTaxAmount;
        private DataGridViewTextBoxColumn Tax;
        private DataGridViewTextBoxColumn ReceivableAmount;
        private DataGridViewTextBoxColumn Subpoena;
        private DataGridViewTextBoxColumn Auudit;
        private DataGridViewCheckBoxColumn Closed;
    }
}
