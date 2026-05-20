namespace DigiERP.Forms.Customer.Quotation
{
    partial class FrmQuoTransSO
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
            單號 = new DataGridViewTextBoxColumn();
            日期 = new DataGridViewTextBoxColumn();
            產品編號 = new DataGridViewTextBoxColumn();
            數量 = new DataGridViewTextBoxColumn();
            單位 = new DataGridViewTextBoxColumn();
            單價 = new DataGridViewTextBoxColumn();
            金額 = new DataGridViewTextBoxColumn();
            專案序號 = new DataGridViewTextBoxColumn();
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
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { 單號, 日期, 產品編號, 數量, 單位, 單價, 金額, 專案序號, 建檔, 報價單號 });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(945, 450);
            dataGridView1.TabIndex = 0;
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
            // 數量
            // 
            數量.HeaderText = "數量";
            數量.Name = "數量";
            數量.ReadOnly = true;
            // 
            // 單位
            // 
            單位.HeaderText = "單位";
            單位.Name = "單位";
            單位.ReadOnly = true;
            // 
            // 單價
            // 
            單價.HeaderText = "單價";
            單價.Name = "單價";
            單價.ReadOnly = true;
            // 
            // 金額
            // 
            金額.HeaderText = "金額";
            金額.Name = "金額";
            金額.ReadOnly = true;
            // 
            // 專案序號
            // 
            專案序號.HeaderText = "專案序號";
            專案序號.Name = "專案序號";
            專案序號.ReadOnly = true;
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
            // FrmQuoTransSO
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(945, 450);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "FrmQuoTransSO";
            Text = "查詢已轉訂單";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn 單號;
        private DataGridViewTextBoxColumn 日期;
        private DataGridViewTextBoxColumn 產品編號;
        private DataGridViewTextBoxColumn 數量;
        private DataGridViewTextBoxColumn 單位;
        private DataGridViewTextBoxColumn 單價;
        private DataGridViewTextBoxColumn 金額;
        private DataGridViewTextBoxColumn 專案序號;
        private DataGridViewTextBoxColumn 建檔;
        private DataGridViewTextBoxColumn 報價單號;
    }
}