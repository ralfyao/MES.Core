namespace DigiERP.UserControl.Customer.RFQ
{
    partial class RFQControl
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
            panel1 = new Panel();
            cboCountry = new ComboBox();
            label3 = new Label();
            txtCustomerQuery = new DigiERP.Common.CommonTextBox();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            詢問單號 = new DataGridViewTextBoxColumn();
            詢問單日期 = new DataGridViewTextBoxColumn();
            客戶名稱 = new DataGridViewTextBoxColumn();
            聯絡人 = new DataGridViewTextBoxColumn();
            國別 = new DataGridViewTextBoxColumn();
            詢單業別 = new DataGridViewTextBoxColumn();
            追蹤狀況 = new DataGridViewTextBoxColumn();
            成交機率 = new DataGridViewTextBoxColumn();
            預計再訪日 = new DataGridViewTextBoxColumn();
            業務人員 = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(cboCountry);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtCustomerQuery);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2, 2, 2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(974, 69);
            panel1.TabIndex = 0;
            // 
            // cboCountry
            // 
            cboCountry.FormattingEnabled = true;
            cboCountry.Location = new Point(616, 19);
            cboCountry.Name = "cboCountry";
            cboCountry.Size = new Size(151, 23);
            cboCountry.TabIndex = 13;
            cboCountry.SelectedIndexChanged += cboCountry_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label3.Location = new Point(496, 19);
            label3.Name = "label3";
            label3.Size = new Size(86, 24);
            label3.TabIndex = 12;
            label3.Text = "國別查詢";
            // 
            // txtCustomerQuery
            // 
            txtCustomerQuery.Location = new Point(386, 24);
            txtCustomerQuery.Margin = new Padding(2, 2, 2, 2);
            txtCustomerQuery.Name = "txtCustomerQuery";
            txtCustomerQuery.Size = new Size(98, 23);
            txtCustomerQuery.TabIndex = 3;
            txtCustomerQuery.Leave += txtCustomerQuery_Leave;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft JhengHei UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label2.Location = new Point(299, 23);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(86, 24);
            label2.TabIndex = 2;
            label2.Text = "客戶查詢";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label1.Location = new Point(68, 19);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(229, 30);
            label1.TabIndex = 1;
            label1.Text = "詢問函聯絡追蹤管理";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Require;
            pictureBox1.Location = new Point(12, 13);
            pictureBox1.Margin = new Padding(2, 2, 2, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(50, 49);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridView1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 69);
            panel2.Margin = new Padding(2, 2, 2, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(974, 411);
            panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { 詢問單號, 詢問單日期, 客戶名稱, 聯絡人, 國別, 詢單業別, 追蹤狀況, 成交機率, 預計再訪日, 業務人員 });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Margin = new Padding(2, 2, 2, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(974, 411);
            dataGridView1.TabIndex = 0;
            // 
            // 詢問單號
            // 
            詢問單號.HeaderText = "詢問單號";
            詢問單號.MinimumWidth = 6;
            詢問單號.Name = "詢問單號";
            詢問單號.ReadOnly = true;
            // 
            // 詢問單日期
            // 
            詢問單日期.HeaderText = "詢問單日期";
            詢問單日期.MinimumWidth = 6;
            詢問單日期.Name = "詢問單日期";
            詢問單日期.ReadOnly = true;
            // 
            // 客戶名稱
            // 
            客戶名稱.HeaderText = "客戶名稱";
            客戶名稱.MinimumWidth = 6;
            客戶名稱.Name = "客戶名稱";
            客戶名稱.ReadOnly = true;
            // 
            // 聯絡人
            // 
            聯絡人.HeaderText = "聯絡人";
            聯絡人.MinimumWidth = 6;
            聯絡人.Name = "聯絡人";
            聯絡人.ReadOnly = true;
            // 
            // 國別
            // 
            國別.HeaderText = "國別";
            國別.MinimumWidth = 6;
            國別.Name = "國別";
            國別.ReadOnly = true;
            // 
            // 詢單業別
            // 
            詢單業別.HeaderText = "詢單業別";
            詢單業別.MinimumWidth = 6;
            詢單業別.Name = "詢單業別";
            詢單業別.ReadOnly = true;
            // 
            // 追蹤狀況
            // 
            追蹤狀況.HeaderText = "追蹤狀況";
            追蹤狀況.MinimumWidth = 6;
            追蹤狀況.Name = "追蹤狀況";
            追蹤狀況.ReadOnly = true;
            // 
            // 成交機率
            // 
            成交機率.HeaderText = "成交機率";
            成交機率.MinimumWidth = 6;
            成交機率.Name = "成交機率";
            成交機率.ReadOnly = true;
            // 
            // 預計再訪日
            // 
            預計再訪日.HeaderText = "預計再訪日";
            預計再訪日.MinimumWidth = 6;
            預計再訪日.Name = "預計再訪日";
            預計再訪日.ReadOnly = true;
            // 
            // 業務人員
            // 
            業務人員.HeaderText = "業務人員";
            業務人員.MinimumWidth = 6;
            業務人員.Name = "業務人員";
            業務人員.ReadOnly = true;
            // 
            // RFQControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Wheat;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "RFQControl";
            Size = new Size(974, 480);
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
        private Panel panel2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn 詢問單號;
        private DataGridViewTextBoxColumn 詢問單日期;
        private DataGridViewTextBoxColumn 客戶名稱;
        private DataGridViewTextBoxColumn 聯絡人;
        private DataGridViewTextBoxColumn 國別;
        private DataGridViewTextBoxColumn 詢單業別;
        private DataGridViewTextBoxColumn 追蹤狀況;
        private DataGridViewTextBoxColumn 成交機率;
        private DataGridViewTextBoxColumn 預計再訪日;
        private DataGridViewTextBoxColumn 業務人員;
        private Label label2;
        private DigiERP.Common.CommonTextBox txtCustomerQuery;
        private ComboBox cboCountry;
        private Label label3;
    }
}
