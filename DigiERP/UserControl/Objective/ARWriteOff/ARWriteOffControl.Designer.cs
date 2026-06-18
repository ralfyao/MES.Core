namespace DigiERP.UserControl.Objective.ARWriteOff
{
    partial class ARWriteOffControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ARWriteOffControl));
            panel1 = new Panel();
            btn新增 = new Button();
            btn超過60天 = new Button();
            btn60天內 = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            orderNo = new DataGridViewTextBoxColumn();
            date = new DataGridViewTextBoxColumn();
            custNo = new DataGridViewTextBoxColumn();
            currency = new DataGridViewTextBoxColumn();
            oriCurrencyAmt = new DataGridViewTextBoxColumn();
            NTDAR = new DataGridViewTextBoxColumn();
            oriCurrencyWriteOff = new DataGridViewTextBoxColumn();
            NTDWriteOff = new DataGridViewTextBoxColumn();
            discount = new DataGridViewTextBoxColumn();
            exRateDiff = new DataGridViewTextBoxColumn();
            auditor = new DataGridViewTextBoxColumn();
            auditDate = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btn新增);
            panel1.Controls.Add(btn超過60天);
            panel1.Controls.Add(btn60天內);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1497, 108);
            panel1.TabIndex = 0;
            // 
            // btn新增
            // 
            btn新增.BackColor = Color.Gray;
            btn新增.ForeColor = SystemColors.ButtonHighlight;
            btn新增.Location = new Point(956, 36);
            btn新增.Name = "btn新增";
            btn新增.Size = new Size(156, 44);
            btn新增.TabIndex = 9;
            btn新增.Text = "新增";
            btn新增.UseVisualStyleBackColor = false;
            // 
            // btn超過60天
            // 
            btn超過60天.BackColor = Color.LimeGreen;
            btn超過60天.Location = new Point(684, 32);
            btn超過60天.Name = "btn超過60天";
            btn超過60天.Size = new Size(172, 56);
            btn超過60天.TabIndex = 8;
            btn超過60天.Text = "超過60天";
            btn超過60天.UseVisualStyleBackColor = false;
            // 
            // btn60天內
            // 
            btn60天內.BackColor = Color.FromArgb(128, 128, 255);
            btn60天內.Location = new Point(440, 36);
            btn60天內.Name = "btn60天內";
            btn60天內.Size = new Size(172, 52);
            btn60天內.TabIndex = 7;
            btn60天內.Text = "60天內";
            btn60天內.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label1.Location = new Point(112, 36);
            label1.Name = "label1";
            label1.Size = new Size(162, 37);
            label1.TabIndex = 6;
            label1.Text = "沖款收總覽";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(92, 84);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridView1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 108);
            panel2.Name = "panel2";
            panel2.Size = new Size(1497, 511);
            panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { orderNo, date, custNo, currency, oriCurrencyAmt, NTDAR, oriCurrencyWriteOff, NTDWriteOff, discount, exRateDiff, auditor, auditDate });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(1497, 511);
            dataGridView1.TabIndex = 0;
            // 
            // orderNo
            // 
            orderNo.HeaderText = "單號";
            orderNo.Name = "orderNo";
            orderNo.ReadOnly = true;
            // 
            // date
            // 
            date.HeaderText = "日期";
            date.Name = "date";
            date.ReadOnly = true;
            // 
            // custNo
            // 
            custNo.HeaderText = "客戶編號";
            custNo.Name = "custNo";
            custNo.ReadOnly = true;
            // 
            // currency
            // 
            currency.HeaderText = "幣別";
            currency.Name = "currency";
            currency.ReadOnly = true;
            // 
            // oriCurrencyAmt
            // 
            oriCurrencyAmt.HeaderText = "原幣未稅";
            oriCurrencyAmt.Name = "oriCurrencyAmt";
            oriCurrencyAmt.ReadOnly = true;
            // 
            // NTDAR
            // 
            NTDAR.HeaderText = "台幣應收";
            NTDAR.Name = "NTDAR";
            NTDAR.ReadOnly = true;
            // 
            // oriCurrencyWriteOff
            // 
            oriCurrencyWriteOff.HeaderText = "原幣沖帳";
            oriCurrencyWriteOff.Name = "oriCurrencyWriteOff";
            oriCurrencyWriteOff.ReadOnly = true;
            // 
            // NTDWriteOff
            // 
            NTDWriteOff.HeaderText = "台幣沖帳";
            NTDWriteOff.Name = "NTDWriteOff";
            NTDWriteOff.ReadOnly = true;
            // 
            // discount
            // 
            discount.HeaderText = "折讓金額";
            discount.Name = "discount";
            discount.ReadOnly = true;
            // 
            // exRateDiff
            // 
            exRateDiff.HeaderText = "匯差";
            exRateDiff.Name = "exRateDiff";
            exRateDiff.ReadOnly = true;
            // 
            // auditor
            // 
            auditor.HeaderText = "覆核人員";
            auditor.Name = "auditor";
            auditor.ReadOnly = true;
            // 
            // auditDate
            // 
            auditDate.HeaderText = "覆核日期";
            auditDate.Name = "auditDate";
            auditDate.ReadOnly = true;
            // 
            // ARWriteOffControl
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            Name = "ARWriteOffControl";
            Size = new Size(1497, 619);
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
        private Button btn超過60天;
        private Button btn60天內;
        private Button btn新增;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn orderNo;
        private DataGridViewTextBoxColumn date;
        private DataGridViewTextBoxColumn custNo;
        private DataGridViewTextBoxColumn currency;
        private DataGridViewTextBoxColumn oriCurrencyAmt;
        private DataGridViewTextBoxColumn NTDAR;
        private DataGridViewTextBoxColumn oriCurrencyWriteOff;
        private DataGridViewTextBoxColumn NTDWriteOff;
        private DataGridViewTextBoxColumn discount;
        private DataGridViewTextBoxColumn exRateDiff;
        private DataGridViewTextBoxColumn auditor;
        private DataGridViewTextBoxColumn auditDate;
    }
}
