namespace DigiERP.Forms.Customer
{
    partial class FrmCustQuotList
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            label1 = new Label();
            lblCustNo = new Label();
            lblCustAlias = new Label();
            label4 = new Label();
            lblCustCompany = new Label();
            label3 = new Label();
            dataGridView1 = new DataGridView();
            報價單號 = new DataGridViewTextBoxColumn();
            產品編號 = new DataGridViewTextBoxColumn();
            品名規格 = new DataGridViewTextBoxColumn();
            詢問函編號 = new DataGridViewTextBoxColumn();
            單價 = new DataGridViewTextBoxColumn();
            報價日期 = new DataGridViewTextBoxColumn();
            報價有效日期 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label1.Location = new Point(8, 8);
            label1.Name = "label1";
            label1.Size = new Size(86, 24);
            label1.TabIndex = 0;
            label1.Text = "客戶編號";
            // 
            // lblCustNo
            // 
            lblCustNo.AutoSize = true;
            lblCustNo.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            lblCustNo.Location = new Point(96, 8);
            lblCustNo.Name = "lblCustNo";
            lblCustNo.Size = new Size(100, 24);
            lblCustNo.TabIndex = 1;
            lblCustNo.Text = "lblCustNo";
            // 
            // lblCustAlias
            // 
            lblCustAlias.AutoSize = true;
            lblCustAlias.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            lblCustAlias.Location = new Point(320, 8);
            lblCustAlias.Name = "lblCustAlias";
            lblCustAlias.Size = new Size(115, 24);
            lblCustAlias.TabIndex = 3;
            lblCustAlias.Text = "lblCustAlias";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label4.Location = new Point(232, 8);
            label4.Name = "label4";
            label4.Size = new Size(86, 24);
            label4.TabIndex = 2;
            label4.Text = "客戶簡稱";
            // 
            // lblCustCompany
            // 
            lblCustCompany.AutoSize = true;
            lblCustCompany.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            lblCustCompany.Location = new Point(96, 48);
            lblCustCompany.Name = "lblCustCompany";
            lblCustCompany.Size = new Size(160, 24);
            lblCustCompany.TabIndex = 5;
            lblCustCompany.Text = "lblCustCompany";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label3.Location = new Point(8, 48);
            label3.Name = "label3";
            label3.Size = new Size(86, 24);
            label3.TabIndex = 4;
            label3.Text = "客戶全名";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { 報價單號, 產品編號, 品名規格, 詢問函編號, 單價, 報價日期, 報價有效日期 });
            dataGridView1.Location = new Point(16, 112);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1056, 280);
            dataGridView1.TabIndex = 6;
            // 
            // 報價單號
            // 
            dataGridViewCellStyle1.ForeColor = Color.Black;
            報價單號.DefaultCellStyle = dataGridViewCellStyle1;
            報價單號.HeaderText = "報價單號";
            報價單號.Name = "報價單號";
            報價單號.ReadOnly = true;
            // 
            // 產品編號
            // 
            dataGridViewCellStyle2.ForeColor = Color.Black;
            產品編號.DefaultCellStyle = dataGridViewCellStyle2;
            產品編號.HeaderText = "產品編號";
            產品編號.Name = "產品編號";
            產品編號.ReadOnly = true;
            // 
            // 品名規格
            // 
            dataGridViewCellStyle3.ForeColor = Color.Black;
            品名規格.DefaultCellStyle = dataGridViewCellStyle3;
            品名規格.HeaderText = "品名規格";
            品名規格.Name = "品名規格";
            品名規格.ReadOnly = true;
            // 
            // 詢問函編號
            // 
            dataGridViewCellStyle4.ForeColor = Color.Black;
            詢問函編號.DefaultCellStyle = dataGridViewCellStyle4;
            詢問函編號.HeaderText = "詢問函編號";
            詢問函編號.Name = "詢問函編號";
            詢問函編號.ReadOnly = true;
            // 
            // 單價
            // 
            dataGridViewCellStyle5.ForeColor = Color.Black;
            單價.DefaultCellStyle = dataGridViewCellStyle5;
            單價.HeaderText = "單價";
            單價.Name = "單價";
            單價.ReadOnly = true;
            // 
            // 報價日期
            // 
            dataGridViewCellStyle6.ForeColor = Color.Black;
            報價日期.DefaultCellStyle = dataGridViewCellStyle6;
            報價日期.HeaderText = "報價日期";
            報價日期.Name = "報價日期";
            報價日期.ReadOnly = true;
            // 
            // 報價有效日期
            // 
            dataGridViewCellStyle7.ForeColor = Color.Black;
            報價有效日期.DefaultCellStyle = dataGridViewCellStyle7;
            報價有效日期.HeaderText = "報價有效日期";
            報價有效日期.Name = "報價有效日期";
            報價有效日期.ReadOnly = true;
            // 
            // FrmCustQuotList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.LightCoral;
            ClientSize = new Size(1086, 403);
            Controls.Add(dataGridView1);
            Controls.Add(lblCustCompany);
            Controls.Add(label3);
            Controls.Add(lblCustAlias);
            Controls.Add(label4);
            Controls.Add(lblCustNo);
            Controls.Add(label1);
            Cursor = Cursors.SizeNESW;
            ForeColor = SystemColors.ButtonHighlight;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "FrmCustQuotList";
            Text = "報價歷程";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblCustNo;
        private Label lblCustAlias;
        private Label label4;
        private Label lblCustCompany;
        private Label label3;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn 報價單號;
        private DataGridViewTextBoxColumn 產品編號;
        private DataGridViewTextBoxColumn 品名規格;
        private DataGridViewTextBoxColumn 詢問函編號;
        private DataGridViewTextBoxColumn 單價;
        private DataGridViewTextBoxColumn 報價日期;
        private DataGridViewTextBoxColumn 報價有效日期;
    }
}