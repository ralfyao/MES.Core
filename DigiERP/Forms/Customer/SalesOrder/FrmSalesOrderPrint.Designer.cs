namespace DigiERP.Forms.Customer.SalesOrder
{
    partial class FrmSalesOrderPrint
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSalesOrderPrint));
            label1 = new Label();
            lblSalesOrderNo = new Label();
            lblCustNo = new Label();
            label3 = new Label();
            label2 = new Label();
            label4 = new Label();
            lblCompany = new Label();
            txtComment = new TextBox();
            dataGridView1 = new DataGridView();
            品項編號 = new DataGridViewTextBoxColumn();
            數量 = new DataGridViewTextBoxColumn();
            訂單單價 = new DataGridViewTextBoxColumn();
            總金額 = new DataGridViewTextBoxColumn();
            請款選項 = new DataGridViewComboBoxColumn();
            專案序號 = new DataGridViewTextBoxColumn();
            btnCorderP = new Button();
            btnCorderT = new Button();
            btnPerformaInvoiceT = new Button();
            btnPerformaInvoiceP = new Button();
            button1 = new Button();
            btnInvoiceP = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 12);
            label1.Name = "label1";
            label1.Size = new Size(48, 24);
            label1.TabIndex = 0;
            label1.Text = "單號";
            // 
            // lblSalesOrderNo
            // 
            lblSalesOrderNo.AutoSize = true;
            lblSalesOrderNo.Location = new Point(80, 12);
            lblSalesOrderNo.Name = "lblSalesOrderNo";
            lblSalesOrderNo.Size = new Size(157, 24);
            lblSalesOrderNo.TabIndex = 1;
            lblSalesOrderNo.Text = "lblSalesOrderNo";
            // 
            // lblCustNo
            // 
            lblCustNo.AutoSize = true;
            lblCustNo.Location = new Point(320, 12);
            lblCustNo.Name = "lblCustNo";
            lblCustNo.Size = new Size(100, 24);
            lblCustNo.TabIndex = 3;
            lblCustNo.Text = "lblCustNo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(252, 12);
            label3.Name = "label3";
            label3.Size = new Size(48, 24);
            label3.TabIndex = 2;
            label3.Text = "客戶";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 52);
            label2.Name = "label2";
            label2.Size = new Size(136, 24);
            label2.TabIndex = 4;
            label2.Text = "備註(補充說明)";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(172, 52);
            label4.Name = "label4";
            label4.Size = new Size(48, 24);
            label4.TabIndex = 5;
            label4.Text = "名稱";
            // 
            // lblCompany
            // 
            lblCompany.AutoSize = true;
            lblCompany.Location = new Point(228, 52);
            lblCompany.Name = "lblCompany";
            lblCompany.Size = new Size(119, 24);
            lblCompany.TabIndex = 6;
            lblCompany.Text = "lblCompany";
            // 
            // txtComment
            // 
            txtComment.Location = new Point(16, 88);
            txtComment.Multiline = true;
            txtComment.Name = "txtComment";
            txtComment.Size = new Size(504, 188);
            txtComment.TabIndex = 7;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { 品項編號, 數量, 訂單單價, 總金額, 請款選項, 專案序號 });
            dataGridView1.Location = new Point(16, 296);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(504, 188);
            dataGridView1.TabIndex = 8;
            // 
            // 品項編號
            // 
            品項編號.HeaderText = "品項編號";
            品項編號.Name = "品項編號";
            品項編號.ReadOnly = true;
            // 
            // 數量
            // 
            數量.HeaderText = "數量";
            數量.Name = "數量";
            數量.ReadOnly = true;
            // 
            // 訂單單價
            // 
            訂單單價.HeaderText = "訂單單價";
            訂單單價.Name = "訂單單價";
            訂單單價.ReadOnly = true;
            // 
            // 總金額
            // 
            總金額.HeaderText = "總金額";
            總金額.Name = "總金額";
            總金額.ReadOnly = true;
            // 
            // 請款選項
            // 
            請款選項.HeaderText = "請款選項";
            請款選項.Items.AddRange(new object[] { "", "是", "否" });
            請款選項.Name = "請款選項";
            // 
            // 專案序號
            // 
            專案序號.HeaderText = "專案序號";
            專案序號.Name = "專案序號";
            專案序號.ReadOnly = true;
            // 
            // btnCorderP
            // 
            btnCorderP.BackColor = Color.Bisque;
            btnCorderP.Location = new Point(16, 492);
            btnCorderP.Name = "btnCorderP";
            btnCorderP.Size = new Size(148, 32);
            btnCorderP.TabIndex = 9;
            btnCorderP.Text = "中文訂單%";
            btnCorderP.UseVisualStyleBackColor = false;
            // 
            // btnCorderT
            // 
            btnCorderT.BackColor = Color.DarkOrange;
            btnCorderT.Location = new Point(16, 528);
            btnCorderT.Name = "btnCorderT";
            btnCorderT.Size = new Size(148, 32);
            btnCorderT.TabIndex = 10;
            btnCorderT.Text = "中文訂單T";
            btnCorderT.UseVisualStyleBackColor = false;
            btnCorderT.Click += btnCorderT_Click;
            // 
            // btnPerformaInvoiceT
            // 
            btnPerformaInvoiceT.BackColor = Color.OrangeRed;
            btnPerformaInvoiceT.Location = new Point(172, 528);
            btnPerformaInvoiceT.Name = "btnPerformaInvoiceT";
            btnPerformaInvoiceT.Size = new Size(204, 32);
            btnPerformaInvoiceT.TabIndex = 12;
            btnPerformaInvoiceT.Text = "Performa InvoiceT";
            btnPerformaInvoiceT.UseVisualStyleBackColor = false;
            btnPerformaInvoiceT.Click += btnPerformaInvoiceT_Click;
            // 
            // btnPerformaInvoiceP
            // 
            btnPerformaInvoiceP.BackColor = Color.LightSalmon;
            btnPerformaInvoiceP.Location = new Point(172, 492);
            btnPerformaInvoiceP.Name = "btnPerformaInvoiceP";
            btnPerformaInvoiceP.Size = new Size(204, 32);
            btnPerformaInvoiceP.TabIndex = 11;
            btnPerformaInvoiceP.Text = "Performa Invoice%";
            btnPerformaInvoiceP.UseVisualStyleBackColor = false;
            btnPerformaInvoiceP.Click += btnPerformaInvoiceP_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.DodgerBlue;
            button1.Location = new Point(376, 528);
            button1.Name = "button1";
            button1.Size = new Size(148, 32);
            button1.TabIndex = 14;
            button1.Text = "Invoice T";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnInvoiceP
            // 
            btnInvoiceP.BackColor = Color.SkyBlue;
            btnInvoiceP.Location = new Point(376, 492);
            btnInvoiceP.Name = "btnInvoiceP";
            btnInvoiceP.Size = new Size(148, 32);
            btnInvoiceP.TabIndex = 13;
            btnInvoiceP.Text = "Invoice %";
            btnInvoiceP.UseVisualStyleBackColor = false;
            btnInvoiceP.Click += btnInvoiceP_Click;
            // 
            // FrmSalesOrderPrint
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(539, 565);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(btnInvoiceP);
            Controls.Add(btnPerformaInvoiceT);
            Controls.Add(btnPerformaInvoiceP);
            Controls.Add(btnCorderT);
            Controls.Add(btnCorderP);
            Controls.Add(txtComment);
            Controls.Add(lblCompany);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(lblCustNo);
            Controls.Add(label3);
            Controls.Add(lblSalesOrderNo);
            Controls.Add(label1);
            Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5);
            Name = "FrmSalesOrderPrint";
            Text = "訂單列印";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        public Label lblSalesOrderNo;
        public Label lblCustNo;
        private Label label3;
        private Label label2;
        private Label label4;
        public Label lblCompany;
        private TextBox txtComment;
        private DataGridView dataGridView1;
        private Button btnCorderP;
        private Button btnCorderT;
        private Button btnPerformaInvoiceT;
        private Button btnPerformaInvoiceP;
        private Button button1;
        private Button btnInvoiceP;
        private DataGridViewTextBoxColumn 品項編號;
        private DataGridViewTextBoxColumn 數量;
        private DataGridViewTextBoxColumn 訂單單價;
        private DataGridViewTextBoxColumn 總金額;
        private DataGridViewComboBoxColumn 請款選項;
        private DataGridViewTextBoxColumn 專案序號;
    }
}