namespace DigiERP.Forms.Customer
{
    partial class FrmCustEqpList
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
            label1 = new Label();
            lblCustNo = new Label();
            lblCustAlias = new Label();
            label4 = new Label();
            lblCustCompany = new Label();
            label3 = new Label();
            dataGridView1 = new DataGridView();
            查修單號 = new DataGridViewTextBoxColumn();
            專案序號 = new DataGridViewTextBoxColumn();
            事件Events = new DataGridViewTextBoxColumn();
            服務日期 = new DataGridViewTextBoxColumn();
            客戶反映 = new DataGridViewTextBoxColumn();
            公司回覆 = new DataGridViewTextBoxColumn();
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
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { 查修單號, 專案序號, 事件Events, 服務日期, 客戶反映, 公司回覆 });
            dataGridView1.Cursor = Cursors.Default;
            dataGridView1.Location = new Point(16, 112);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1056, 280);
            dataGridView1.TabIndex = 6;
            // 
            // 查修單號
            // 
            查修單號.HeaderText = "查修單號";
            查修單號.Name = "查修單號";
            查修單號.ReadOnly = true;
            // 
            // 專案序號
            // 
            專案序號.HeaderText = "專案序號";
            專案序號.Name = "專案序號";
            專案序號.ReadOnly = true;
            // 
            // 事件Events
            // 
            事件Events.HeaderText = "事件Events";
            事件Events.Name = "事件Events";
            事件Events.ReadOnly = true;
            // 
            // 服務日期
            // 
            服務日期.HeaderText = "服務日期";
            服務日期.Name = "服務日期";
            服務日期.ReadOnly = true;
            // 
            // 客戶反映
            // 
            客戶反映.HeaderText = "客戶反映";
            客戶反映.Name = "客戶反映";
            客戶反映.ReadOnly = true;
            // 
            // 公司回覆
            // 
            公司回覆.HeaderText = "公司回覆";
            公司回覆.Name = "公司回覆";
            公司回覆.ReadOnly = true;
            // 
            // FrmCustEqpList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1086, 403);
            Controls.Add(dataGridView1);
            Controls.Add(lblCustCompany);
            Controls.Add(label3);
            Controls.Add(lblCustAlias);
            Controls.Add(label4);
            Controls.Add(lblCustNo);
            Controls.Add(label1);
            Cursor = Cursors.SizeNESW;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "FrmCustEqpList";
            Text = "機台客服履歷";
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
        private DataGridViewTextBoxColumn 查修單號;
        private DataGridViewTextBoxColumn 專案序號;
        private DataGridViewTextBoxColumn 事件Events;
        private DataGridViewTextBoxColumn 服務日期;
        private DataGridViewTextBoxColumn 客戶反映;
        private DataGridViewTextBoxColumn 公司回覆;
    }
}