namespace DigiERP.Forms.Customer.SalesOrder
{
    partial class FrmQuotationDistribution
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
            識別 = new DataGridViewTextBoxColumn();
            勾選 = new DataGridViewCheckBoxColumn();
            產品編號 = new DataGridViewTextBoxColumn();
            產品規格 = new DataGridViewTextBoxColumn();
            數量 = new DataGridViewTextBoxColumn();
            單位 = new DataGridViewTextBoxColumn();
            單價 = new DataGridViewTextBoxColumn();
            報價單號 = new DataGridViewTextBoxColumn();
            btnOK = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { 識別, 勾選, 產品編號, 產品規格, 數量, 單位, 單價, 報價單號 });
            dataGridView1.Location = new Point(24, 24);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(744, 312);
            dataGridView1.TabIndex = 0;
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
            // 產品編號
            // 
            產品編號.HeaderText = "產品編號";
            產品編號.Name = "產品編號";
            產品編號.ReadOnly = true;
            // 
            // 產品規格
            // 
            產品規格.HeaderText = "產品規格";
            產品規格.Name = "產品規格";
            產品規格.ReadOnly = true;
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
            // 報價單號
            // 
            報價單號.HeaderText = "報價單號";
            報價單號.Name = "報價單號";
            報價單號.ReadOnly = true;
            // 
            // btnOK
            // 
            btnOK.Location = new Point(692, 352);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(75, 23);
            btnOK.TabIndex = 1;
            btnOK.Text = "帶入";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // FrmQuotationDistribution
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 396);
            Controls.Add(btnOK);
            Controls.Add(dataGridView1);
            Name = "FrmQuotationDistribution";
            Text = "報價單分配";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnOK;
        private DataGridViewTextBoxColumn 識別;
        private DataGridViewCheckBoxColumn 勾選;
        private DataGridViewTextBoxColumn 產品編號;
        private DataGridViewTextBoxColumn 產品規格;
        private DataGridViewTextBoxColumn 數量;
        private DataGridViewTextBoxColumn 單位;
        private DataGridViewTextBoxColumn 單價;
        private DataGridViewTextBoxColumn 報價單號;
    }
}