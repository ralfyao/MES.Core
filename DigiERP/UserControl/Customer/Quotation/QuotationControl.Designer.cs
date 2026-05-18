namespace DigiERP.UserControl.Customer.Quotation
{
    partial class QuotationControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuotationControl));
            panel1 = new Panel();
            button1 = new Button();
            txtItemName = new TextBox();
            label4 = new Label();
            txtCompany = new TextBox();
            label3 = new Label();
            txtQUONO = new TextBox();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            單號 = new DataGridViewTextBoxColumn();
            日期 = new DataGridViewTextBoxColumn();
            客戶 = new DataGridViewTextBoxColumn();
            聯絡人 = new DataGridViewTextBoxColumn();
            機台類別 = new DataGridViewTextBoxColumn();
            明細查詢 = new DataGridViewImageColumn();
            報價總額 = new DataGridViewTextBoxColumn();
            業代 = new DataGridViewTextBoxColumn();
            業務人員 = new DataGridViewTextBoxColumn();
            來源單據 = new DataGridViewTextBoxColumn();
            報價有效日期 = new DataGridViewTextBoxColumn();
            button2 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.PaleTurquoise;
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(txtItemName);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtCompany);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtQUONO);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1564, 96);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            button1.Location = new Point(1400, 16);
            button1.Name = "button1";
            button1.Size = new Size(104, 40);
            button1.TabIndex = 8;
            button1.Text = "新增";
            button1.UseVisualStyleBackColor = true;
            // 
            // txtItemName
            // 
            txtItemName.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            txtItemName.Location = new Point(952, 21);
            txtItemName.Name = "txtItemName";
            txtItemName.Size = new Size(328, 32);
            txtItemName.TabIndex = 7;
            txtItemName.Leave += txtItemName_Leave;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label4.Location = new Point(864, 24);
            label4.Name = "label4";
            label4.Size = new Size(86, 24);
            label4.TabIndex = 6;
            label4.Text = "品名查詢";
            // 
            // txtCompany
            // 
            txtCompany.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            txtCompany.Location = new Point(528, 19);
            txtCompany.Name = "txtCompany";
            txtCompany.Size = new Size(328, 32);
            txtCompany.TabIndex = 5;
            txtCompany.Leave += txtCompany_Leave;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label3.Location = new Point(440, 24);
            label3.Name = "label3";
            label3.Size = new Size(86, 24);
            label3.TabIndex = 4;
            label3.Text = "客戶查詢";
            // 
            // txtQUONO
            // 
            txtQUONO.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            txtQUONO.Location = new Point(296, 19);
            txtQUONO.Name = "txtQUONO";
            txtQUONO.Size = new Size(128, 32);
            txtQUONO.TabIndex = 3;
            txtQUONO.Leave += txtQUONO_Leave_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label2.Location = new Point(208, 24);
            label2.Name = "label2";
            label2.Size = new Size(86, 24);
            label2.TabIndex = 2;
            label2.Text = "單號查詢";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label1.Location = new Point(96, 24);
            label1.Name = "label1";
            label1.Size = new Size(96, 26);
            label1.TabIndex = 1;
            label1.Text = "報價總覽";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(8, 8);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(80, 64);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridView1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 96);
            panel2.Name = "panel2";
            panel2.Size = new Size(1564, 694);
            panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { 單號, 日期, 客戶, 聯絡人, 機台類別, 明細查詢, 報價總額, 業代, 業務人員, 來源單據, 報價有效日期 });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1564, 694);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick_1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.CellMouseEnter += dataGridView1_CellMouseEnter;
            dataGridView1.CellMouseLeave += dataGridView1_CellMouseLeave;
            // 
            // 單號
            // 
            單號.HeaderText = "單號";
            單號.Name = "單號";
            單號.ReadOnly = true;
            // 
            // 日期
            // 
            日期.HeaderText = "日期";
            日期.Name = "日期";
            日期.ReadOnly = true;
            // 
            // 客戶
            // 
            客戶.HeaderText = "客戶";
            客戶.Name = "客戶";
            客戶.ReadOnly = true;
            // 
            // 聯絡人
            // 
            聯絡人.HeaderText = "聯絡人";
            聯絡人.Name = "聯絡人";
            聯絡人.ReadOnly = true;
            // 
            // 機台類別
            // 
            機台類別.HeaderText = "機台類別";
            機台類別.Name = "機台類別";
            機台類別.ReadOnly = true;
            // 
            // 明細查詢
            // 
            明細查詢.HeaderText = "明細查詢";
            明細查詢.Image = (Image)resources.GetObject("明細查詢.Image");
            明細查詢.Name = "明細查詢";
            明細查詢.ReadOnly = true;
            // 
            // 報價總額
            // 
            報價總額.HeaderText = "報價總額";
            報價總額.Name = "報價總額";
            報價總額.ReadOnly = true;
            // 
            // 業代
            // 
            業代.HeaderText = "業代";
            業代.Name = "業代";
            業代.ReadOnly = true;
            // 
            // 業務人員
            // 
            業務人員.HeaderText = "業務人員";
            業務人員.Name = "業務人員";
            業務人員.ReadOnly = true;
            // 
            // 來源單據
            // 
            來源單據.HeaderText = "來源單據";
            來源單據.Name = "來源單據";
            來源單據.ReadOnly = true;
            // 
            // 報價有效日期
            // 
            報價有效日期.HeaderText = "報價有效日期";
            報價有效日期.Name = "報價有效日期";
            報價有效日期.ReadOnly = true;
            // 
            // button2
            // 
            button2.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            button2.Location = new Point(1288, 16);
            button2.Name = "button2";
            button2.Size = new Size(104, 40);
            button2.TabIndex = 9;
            button2.Text = "查詢";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // QuotationControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "QuotationControl";
            Size = new Size(1564, 790);
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
        private DataGridView dataGridView1;
        private PictureBox pictureBox1;
        private Label label1;
        private TextBox txtQUONO;
        private Label label2;
        private TextBox txtCompany;
        private Label label3;
        private Label label4;
        private TextBox txtItemName;
        private Button button1;
        private DataGridViewTextBoxColumn 單號;
        private DataGridViewTextBoxColumn 日期;
        private DataGridViewTextBoxColumn 客戶;
        private DataGridViewTextBoxColumn 聯絡人;
        private DataGridViewTextBoxColumn 機台類別;
        private DataGridViewImageColumn 明細查詢;
        private DataGridViewTextBoxColumn 報價總額;
        private DataGridViewTextBoxColumn 業代;
        private DataGridViewTextBoxColumn 業務人員;
        private DataGridViewTextBoxColumn 來源單據;
        private DataGridViewTextBoxColumn 報價有效日期;
        private Button button2;
    }
}
