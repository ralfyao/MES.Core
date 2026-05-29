namespace DigiERP.Forms.Customer.SalesOrder
{
    partial class FrmTransToShippingOrder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            btnTransShippingOrder = new Button();
            識別 = new DataGridViewTextBoxColumn();
            勾選 = new DataGridViewCheckBoxColumn();
            單號 = new DataGridViewTextBoxColumn();
            日期 = new DataGridViewTextBoxColumn();
            產品編號 = new DataGridViewTextBoxColumn();
            品名規格 = new DataGridViewTextBoxColumn();
            已出貨數量 = new DataGridViewTextBoxColumn();
            訂單數量 = new DataGridViewTextBoxColumn();
            建檔 = new DataGridViewTextBoxColumn();
            報價單號 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { 識別, 勾選, 單號, 日期, 產品編號, 品名規格, 已出貨數量, 訂單數量, 建檔, 報價單號 });
            dataGridView1.Location = new Point(20, 20);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(872, 284);
            dataGridView1.TabIndex = 0;
            // 
            // btnTransShippingOrder
            // 
            btnTransShippingOrder.Location = new Point(816, 316);
            btnTransShippingOrder.Name = "btnTransShippingOrder";
            btnTransShippingOrder.Size = new Size(75, 23);
            btnTransShippingOrder.TabIndex = 1;
            btnTransShippingOrder.Text = "轉出貨單";
            btnTransShippingOrder.UseVisualStyleBackColor = true;
            btnTransShippingOrder.Click += btnTransShippingOrder_Click;
            // 
            // 識別
            // 
            識別.HeaderText = "識別";
            識別.Name = "識別";
            識別.Visible = false;
            // 
            // 勾選
            // 
            勾選.HeaderText = "勾選";
            勾選.Name = "勾選";
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
            // 產品編號
            // 
            產品編號.HeaderText = "產品編號";
            產品編號.Name = "產品編號";
            產品編號.ReadOnly = true;
            // 
            // 品名規格
            // 
            品名規格.HeaderText = "品名規格";
            品名規格.Name = "品名規格";
            品名規格.ReadOnly = true;
            // 
            // 已出貨數量
            // 
            已出貨數量.HeaderText = "已出貨數量";
            已出貨數量.Name = "已出貨數量";
            已出貨數量.ReadOnly = true;
            // 
            // 訂單數量
            // 
            訂單數量.HeaderText = "訂單數量";
            訂單數量.Name = "訂單數量";
            訂單數量.ReadOnly = true;
            // 
            // 建檔
            // 
            建檔.HeaderText = "建檔";
            建檔.Name = "建檔";
            建檔.ReadOnly = true;
            // 
            // 報價單號
            // 
            報價單號.HeaderText = "報價單號";
            報價單號.Name = "報價單號";
            報價單號.ReadOnly = true;
            // 
            // FrmTransToShippingOrder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(903, 361);
            Controls.Add(btnTransShippingOrder);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "FrmTransToShippingOrder";
            Text = "轉開出貨單";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnTransShippingOrder;
        private DataGridViewTextBoxColumn 識別;
        private DataGridViewCheckBoxColumn 勾選;
        private DataGridViewTextBoxColumn 單號;
        private DataGridViewTextBoxColumn 日期;
        private DataGridViewTextBoxColumn 產品編號;
        private DataGridViewTextBoxColumn 品名規格;
        private DataGridViewTextBoxColumn 已出貨數量;
        private DataGridViewTextBoxColumn 訂單數量;
        private DataGridViewTextBoxColumn 建檔;
        private DataGridViewTextBoxColumn 報價單號;
    }
}