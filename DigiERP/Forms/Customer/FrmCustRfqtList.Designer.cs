namespace DigiERP.Forms.Customer
{
    partial class FrmCustRfqtList
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
            label1 = new Label();
            lblCustNo = new Label();
            lblCustAlias = new Label();
            label4 = new Label();
            lblCustCompany = new Label();
            label3 = new Label();
            dataGridView1 = new DataGridView();
            RFQNO = new DataGridViewTextBoxColumn();
            MACHINE = new DataGridViewTextBoxColumn();
            詢問函日期 = new DataGridViewTextBoxColumn();
            STATUS = new DataGridViewTextBoxColumn();
            RESULT = new DataGridViewTextBoxColumn();
            報價單號 = new DataGridViewTextBoxColumn();
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
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { RFQNO, MACHINE, 詢問函日期, STATUS, RESULT, 報價單號 });
            dataGridView1.Location = new Point(16, 112);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1056, 280);
            dataGridView1.TabIndex = 6;
            // 
            // RFQNO
            // 
            dataGridViewCellStyle1.ForeColor = Color.Black;
            RFQNO.DefaultCellStyle = dataGridViewCellStyle1;
            RFQNO.HeaderText = "RFQNO";
            RFQNO.Name = "RFQNO";
            RFQNO.ReadOnly = true;
            // 
            // MACHINE
            // 
            dataGridViewCellStyle2.ForeColor = Color.Black;
            MACHINE.DefaultCellStyle = dataGridViewCellStyle2;
            MACHINE.HeaderText = "MACHINE";
            MACHINE.Name = "MACHINE";
            MACHINE.ReadOnly = true;
            // 
            // 詢問函日期
            // 
            dataGridViewCellStyle3.ForeColor = Color.Black;
            詢問函日期.DefaultCellStyle = dataGridViewCellStyle3;
            詢問函日期.HeaderText = "詢問函日期";
            詢問函日期.Name = "詢問函日期";
            詢問函日期.ReadOnly = true;
            // 
            // STATUS
            // 
            dataGridViewCellStyle4.ForeColor = Color.Black;
            STATUS.DefaultCellStyle = dataGridViewCellStyle4;
            STATUS.HeaderText = "STATUS";
            STATUS.Name = "STATUS";
            STATUS.ReadOnly = true;
            // 
            // RESULT
            // 
            dataGridViewCellStyle5.ForeColor = Color.Black;
            RESULT.DefaultCellStyle = dataGridViewCellStyle5;
            RESULT.HeaderText = "RESULT";
            RESULT.Name = "RESULT";
            RESULT.ReadOnly = true;
            // 
            // 報價單號
            // 
            dataGridViewCellStyle6.ForeColor = Color.Black;
            報價單號.DefaultCellStyle = dataGridViewCellStyle6;
            報價單號.HeaderText = "報價單號";
            報價單號.Name = "報價單號";
            報價單號.ReadOnly = true;
            // 
            // FrmCustRfqtList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.DarkSeaGreen;
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
            Name = "FrmCustRfqtList";
            Text = "詢問函歷程";
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
        private DataGridViewTextBoxColumn RFQNO;
        private DataGridViewTextBoxColumn MACHINE;
        private DataGridViewTextBoxColumn 詢問函日期;
        private DataGridViewTextBoxColumn STATUS;
        private DataGridViewTextBoxColumn RESULT;
    }
}