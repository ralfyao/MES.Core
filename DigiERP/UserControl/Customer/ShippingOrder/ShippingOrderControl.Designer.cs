namespace DigiERP.UserControl.Customer.ShippingOrder
{
    partial class ShippingOrderControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShippingOrderControl));
            panel1 = new Panel();
            btnAdd = new Button();
            btnQuery = new Button();
            txtQueryCustomer = new DigiERP.Common.CommonTextBox();
            txtQueryShipOrder = new DigiERP.Common.CommonTextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            識別 = new DataGridViewTextBoxColumn();
            單號 = new DataGridViewTextBoxColumn();
            日期 = new DataGridViewTextBoxColumn();
            客戶編號 = new DataGridViewTextBoxColumn();
            客戶簡稱 = new DataGridViewTextBoxColumn();
            客戶名稱 = new DataGridViewTextBoxColumn();
            出貨單總額 = new DataGridViewTextBoxColumn();
            原定交貨日期 = new DataGridViewTextBoxColumn();
            交易條件 = new DataGridViewTextBoxColumn();
            運輸方式 = new DataGridViewTextBoxColumn();
            貿易條件 = new DataGridViewTextBoxColumn();
            業代 = new DataGridViewTextBoxColumn();
            業務人員 = new DataGridViewTextBoxColumn();
            核准 = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(btnQuery);
            panel1.Controls.Add(txtQueryCustomer);
            panel1.Controls.Add(txtQueryShipOrder);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1484, 112);
            panel1.TabIndex = 0;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            btnAdd.Location = new Point(700, 56);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(104, 40);
            btnAdd.TabIndex = 9;
            btnAdd.Text = "新增";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnQuery
            // 
            btnQuery.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            btnQuery.Location = new Point(580, 56);
            btnQuery.Name = "btnQuery";
            btnQuery.Size = new Size(104, 40);
            btnQuery.TabIndex = 8;
            btnQuery.Text = "查詢";
            btnQuery.UseVisualStyleBackColor = true;
            // 
            // txtQueryCustomer
            // 
            txtQueryCustomer.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            txtQueryCustomer.Location = new Point(368, 60);
            txtQueryCustomer.Name = "txtQueryCustomer";
            txtQueryCustomer.Size = new Size(192, 32);
            txtQueryCustomer.TabIndex = 7;
            // 
            // txtQueryShipOrder
            // 
            txtQueryShipOrder.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            txtQueryShipOrder.Location = new Point(368, 8);
            txtQueryShipOrder.Name = "txtQueryShipOrder";
            txtQueryShipOrder.Size = new Size(192, 32);
            txtQueryShipOrder.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft JhengHei UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label3.Location = new Point(268, 64);
            label3.Name = "label3";
            label3.Size = new Size(96, 26);
            label3.TabIndex = 5;
            label3.Text = "客戶查詢";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft JhengHei UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label2.Location = new Point(268, 12);
            label2.Name = "label2";
            label2.Size = new Size(96, 26);
            label2.TabIndex = 4;
            label2.Text = "單號查詢";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label1.Location = new Point(132, 44);
            label1.Name = "label1";
            label1.Size = new Size(117, 26);
            label1.TabIndex = 3;
            label1.Text = "出貨單總覽";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(8, 8);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(108, 96);
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
            panel2.Size = new Size(1484, 741);
            panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { 識別, 單號, 日期, 客戶編號, 客戶簡稱, 客戶名稱, 出貨單總額, 原定交貨日期, 交易條件, 運輸方式, 貿易條件, 業代, 業務人員, 核准 });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1484, 741);
            dataGridView1.TabIndex = 0;
            dataGridView1.VisibleChanged += dataGridView1_VisibleChanged;
            // 
            // 識別
            // 
            識別.HeaderText = "識別";
            識別.Name = "識別";
            識別.ReadOnly = true;
            識別.Visible = false;
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
            // 客戶簡稱
            // 
            客戶簡稱.HeaderText = "客戶簡稱";
            客戶簡稱.Name = "客戶簡稱";
            客戶簡稱.ReadOnly = true;
            // 
            // 客戶名稱
            // 
            客戶名稱.HeaderText = "客戶名稱";
            客戶名稱.Name = "客戶名稱";
            客戶名稱.ReadOnly = true;
            // 
            // 出貨單總額
            // 
            出貨單總額.HeaderText = "出貨單總額";
            出貨單總額.Name = "出貨單總額";
            出貨單總額.ReadOnly = true;
            // 
            // 原定交貨日期
            // 
            原定交貨日期.HeaderText = "原定交貨日期";
            原定交貨日期.Name = "原定交貨日期";
            原定交貨日期.ReadOnly = true;
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
            // ShippingOrderControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleTurquoise;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "ShippingOrderControl";
            Size = new Size(1484, 853);
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
        private DigiERP.Common.CommonTextBox txtQueryCustomer;
        private DigiERP.Common.CommonTextBox txtQueryShipOrder;
        private Label label3;
        private Label label2;
        private Button btnQuery;
        private Button btnAdd;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn 識別;
        private DataGridViewTextBoxColumn 單號;
        private DataGridViewTextBoxColumn 日期;
        private DataGridViewTextBoxColumn 客戶編號;
        private DataGridViewTextBoxColumn 客戶簡稱;
        private DataGridViewTextBoxColumn 客戶名稱;
        private DataGridViewTextBoxColumn 出貨單總額;
        private DataGridViewTextBoxColumn 原定交貨日期;
        private DataGridViewTextBoxColumn 交易條件;
        private DataGridViewTextBoxColumn 運輸方式;
        private DataGridViewTextBoxColumn 貿易條件;
        private DataGridViewTextBoxColumn 業代;
        private DataGridViewTextBoxColumn 業務人員;
        private DataGridViewTextBoxColumn 核准;
    }
}
