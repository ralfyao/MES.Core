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
            pictureBox1 = new PictureBox();
            label1 = new Label();
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
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1328, 96);
            panel1.TabIndex = 1;
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
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { 單號, 日期, 客戶編號, 客戶全稱, 國別, 訂單總額, 預交日期, 交易條件, 運輸方式, 貿易條件, 業代, 業務人員, 核准 });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 96);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1328, 633);
            dataGridView1.TabIndex = 2;
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
            // OrderControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Name = "OrderControl";
            Size = new Size(1328, 729);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
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
    }
}
