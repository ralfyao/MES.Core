namespace DigiERP.UserControl.SalesOrder
{
    partial class OrderControl : System.Windows.Forms.UserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderControl));
            panel1 = new Panel();
            btnAdd = new Button();
            cboCountry = new DigiERP.Common.CommonComboBox();
            label4 = new Label();
            txtItemName = new DigiERP.Common.CommonTextBox();
            label3 = new Label();
            btnQuery = new Button();
            txtCustomer = new DigiERP.Common.CommonTextBox();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            單號 = new DataGridViewTextBoxColumn();
            日期 = new DataGridViewTextBoxColumn();
            客戶編號 = new DataGridViewTextBoxColumn();
            客戶全稱 = new DataGridViewTextBoxColumn();
            國別 = new DataGridViewTextBoxColumn();
            訂單總額 = new DataGridViewTextBoxColumn();
            預交日期 = new DataGridViewTextBoxColumn();
            交易條件 = new DataGridViewTextBoxColumn();
            運輸方式 = new DataGridViewTextBoxColumn();
            貿易條件 = new DataGridViewTextBoxColumn();
            業代 = new DataGridViewTextBoxColumn();
            業務人員 = new DataGridViewTextBoxColumn();
            核准 = new DataGridViewTextBoxColumn();
            結案 = new DataGridViewCheckBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(cboCountry);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtItemName);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(btnQuery);
            panel1.Controls.Add(txtCustomer);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1328, 96);
            panel1.TabIndex = 1;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(688, 64);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 10;
            btnAdd.Text = "新增";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // cboCountry
            // 
            cboCountry.FormattingEnabled = true;
            cboCountry.Location = new Point(320, 35);
            cboCountry.Name = "cboCountry";
            cboCountry.Size = new Size(121, 23);
            cboCountry.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label4.Location = new Point(224, 35);
            label4.Name = "label4";
            label4.Size = new Size(86, 24);
            label4.TabIndex = 8;
            label4.Text = "國別查詢";
            // 
            // txtItemName
            // 
            txtItemName.Location = new Point(320, 64);
            txtItemName.Name = "txtItemName";
            txtItemName.Size = new Size(264, 23);
            txtItemName.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label3.Location = new Point(224, 64);
            label3.Name = "label3";
            label3.Size = new Size(86, 24);
            label3.TabIndex = 6;
            label3.Text = "品名查詢";
            // 
            // btnQuery
            // 
            btnQuery.Location = new Point(600, 64);
            btnQuery.Name = "btnQuery";
            btnQuery.Size = new Size(75, 23);
            btnQuery.TabIndex = 5;
            btnQuery.Text = "查詢";
            btnQuery.UseVisualStyleBackColor = true;
            btnQuery.Click += btnQuery_Click;
            // 
            // txtCustomer
            // 
            txtCustomer.Location = new Point(320, 8);
            txtCustomer.Name = "txtCustomer";
            txtCustomer.Size = new Size(264, 23);
            txtCustomer.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label2.Location = new Point(224, 8);
            label2.Name = "label2";
            label2.Size = new Size(86, 24);
            label2.TabIndex = 3;
            label2.Text = "客戶查詢";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label1.Location = new Point(104, 32);
            label1.Name = "label1";
            label1.Size = new Size(96, 26);
            label1.TabIndex = 2;
            label1.Text = "訂單總覽";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(8, 8);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(88, 80);
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
            panel2.Size = new Size(1328, 633);
            panel2.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { 單號, 日期, 客戶編號, 客戶全稱, 國別, 訂單總額, 預交日期, 交易條件, 運輸方式, 貿易條件, 業代, 業務人員, 核准, 結案 });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1328, 633);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellContentDoubleClick += dataGridView1_CellContentDoubleClick;
            dataGridView1.VisibleChanged += dataGridView1_VisibleChanged;
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
            // 客戶編號
            // 
            客戶編號.HeaderText = "客戶編號";
            客戶編號.Name = "客戶編號";
            客戶編號.ReadOnly = true;
            // 
            // 客戶全稱
            // 
            客戶全稱.HeaderText = "客戶全稱";
            客戶全稱.Name = "客戶全稱";
            客戶全稱.ReadOnly = true;
            // 
            // 國別
            // 
            國別.HeaderText = "國別";
            國別.Name = "國別";
            國別.ReadOnly = true;
            // 
            // 訂單總額
            // 
            訂單總額.HeaderText = "訂單總額";
            訂單總額.Name = "訂單總額";
            訂單總額.ReadOnly = true;
            // 
            // 預交日期
            // 
            預交日期.HeaderText = "預交日期";
            預交日期.Name = "預交日期";
            預交日期.ReadOnly = true;
            // 
            // 交易條件
            // 
            交易條件.HeaderText = "交易條件";
            交易條件.Name = "交易條件";
            交易條件.ReadOnly = true;
            // 
            // 運輸方式
            // 
            運輸方式.HeaderText = "運輸方式";
            運輸方式.Name = "運輸方式";
            運輸方式.ReadOnly = true;
            // 
            // 貿易條件
            // 
            貿易條件.HeaderText = "貿易條件";
            貿易條件.Name = "貿易條件";
            貿易條件.ReadOnly = true;
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
            // 核准
            // 
            核准.HeaderText = "核准";
            核准.Name = "核准";
            核准.ReadOnly = true;
            // 
            // 結案
            // 
            結案.HeaderText = "結案";
            結案.Name = "結案";
            // 
            // OrderControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "OrderControl";
            Size = new Size(1328, 729);
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
        private Label label1;
        private DigiERP.Common.CommonComboBox cboCountry;
        private Label label4;
        private DigiERP.Common.CommonTextBox txtItemName;
        private Label label3;
        private Button btnQuery;
        private DigiERP.Common.CommonTextBox txtCustomer;
        private Label label2;
        private Button btnAdd;
        private Panel panel2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn 單號;
        private DataGridViewTextBoxColumn 日期;
        private DataGridViewTextBoxColumn 客戶編號;
        private DataGridViewTextBoxColumn 客戶全稱;
        private DataGridViewTextBoxColumn 國別;
        private DataGridViewTextBoxColumn 訂單總額;
        private DataGridViewTextBoxColumn 預交日期;
        private DataGridViewTextBoxColumn 交易條件;
        private DataGridViewTextBoxColumn 運輸方式;
        private DataGridViewTextBoxColumn 貿易條件;
        private DataGridViewTextBoxColumn 業代;
        private DataGridViewTextBoxColumn 業務人員;
        private DataGridViewTextBoxColumn 核准;
        private DataGridViewCheckBoxColumn 結案;
    }
}
