namespace DigiERP.UserControl.Customer.SalesOrder
{
    partial class OrderMaintainControl
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
            lblMode = new Label();
            label1 = new Label();
            button1 = new Button();
            btnModify = new Button();
            label2 = new Label();
            dtORDERDATE = new DigiERP.Common.CommonDateTimePicker();
            txtOrderNo = new DigiERP.Common.CommonTextBox();
            label3 = new Label();
            label13 = new Label();
            cboCustId = new DigiERP.Common.CommonComboBox();
            dataGridView1 = new DataGridView();
            label4 = new Label();
            label5 = new Label();
            款項期別 = new DataGridViewTextBoxColumn();
            成數 = new DataGridViewTextBoxColumn();
            金額 = new DataGridViewTextBoxColumn();
            立帳單號 = new DataGridViewTextBoxColumn();
            轉立帳單 = new DataGridViewTextBoxColumn();
            label6 = new Label();
            commonDateTimePicker1 = new DigiERP.Common.CommonDateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblMode
            // 
            lblMode.AutoSize = true;
            lblMode.BackColor = Color.Lime;
            lblMode.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            lblMode.Location = new Point(8, 8);
            lblMode.Margin = new Padding(2, 0, 2, 0);
            lblMode.Name = "lblMode";
            lblMode.Size = new Size(85, 24);
            lblMode.TabIndex = 158;
            lblMode.Text = "lblMode";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Lime;
            label1.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label1.Location = new Point(58, 8);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(48, 24);
            label1.TabIndex = 159;
            label1.Text = "訂單";
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(1416, 8);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(20, 22);
            button1.TabIndex = 160;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnModify
            // 
            btnModify.BackColor = Color.FromArgb(192, 0, 0);
            btnModify.ForeColor = SystemColors.ButtonHighlight;
            btnModify.Location = new Point(144, 8);
            btnModify.Name = "btnModify";
            btnModify.Size = new Size(75, 23);
            btnModify.TabIndex = 226;
            btnModify.Text = "修改";
            btnModify.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft JhengHei UI", 14.25F);
            label2.Location = new Point(8, 48);
            label2.Name = "label2";
            label2.Size = new Size(48, 24);
            label2.TabIndex = 225;
            label2.Text = "日期";
            // 
            // dtORDERDATE
            // 
            dtORDERDATE.Enabled = false;
            dtORDERDATE.Font = new Font("Microsoft JhengHei UI", 14.25F);
            dtORDERDATE.Location = new Point(56, 44);
            dtORDERDATE.Name = "dtORDERDATE";
            dtORDERDATE.Size = new Size(184, 32);
            dtORDERDATE.TabIndex = 224;
            dtORDERDATE.Value = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            // 
            // txtOrderNo
            // 
            txtOrderNo.Enabled = false;
            txtOrderNo.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            txtOrderNo.Location = new Point(302, 44);
            txtOrderNo.Name = "txtOrderNo";
            txtOrderNo.Size = new Size(144, 32);
            txtOrderNo.TabIndex = 228;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft JhengHei UI", 14.25F);
            label3.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            label3.Location = new Point(248, 46);
            label3.Name = "label3";
            label3.Size = new Size(48, 24);
            label3.TabIndex = 227;
            label3.Text = "單號";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Microsoft JhengHei UI", 14.25F);
            label13.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            label13.Location = new Point(456, 45);
            label13.Name = "label13";
            label13.Size = new Size(86, 24);
            label13.TabIndex = 230;
            label13.Text = "客戶編號";
            // 
            // cboCustId
            // 
            cboCustId.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            cboCustId.FormattingEnabled = true;
            cboCustId.Location = new Point(544, 40);
            cboCustId.Name = "cboCustId";
            cboCustId.Size = new Size(121, 32);
            cboCustId.TabIndex = 231;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { 款項期別, 成數, 金額, 立帳單號, 轉立帳單 });
            dataGridView1.Location = new Point(952, 40);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(464, 320);
            dataGridView1.TabIndex = 232;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft JhengHei UI", 14.25F);
            label4.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            label4.Location = new Point(675, 44);
            label4.Name = "label4";
            label4.Size = new Size(86, 24);
            label4.TabIndex = 233;
            label4.Text = "客戶簡稱";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft JhengHei UI", 14.25F);
            label5.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            label5.Location = new Point(766, 45);
            label5.Name = "label5";
            label5.Size = new Size(115, 24);
            label5.TabIndex = 234;
            label5.Text = "lblCustAlias";
            // 
            // 款項期別
            // 
            款項期別.HeaderText = "款項期別";
            款項期別.Name = "款項期別";
            款項期別.ReadOnly = true;
            // 
            // 成數
            // 
            成數.HeaderText = "成數";
            成數.Name = "成數";
            成數.ReadOnly = true;
            // 
            // 金額
            // 
            金額.HeaderText = "金額";
            金額.Name = "金額";
            金額.ReadOnly = true;
            // 
            // 立帳單號
            // 
            立帳單號.HeaderText = "立帳單號";
            立帳單號.Name = "立帳單號";
            立帳單號.ReadOnly = true;
            // 
            // 轉立帳單
            // 
            轉立帳單.HeaderText = "";
            轉立帳單.Name = "轉立帳單";
            轉立帳單.ReadOnly = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft JhengHei UI", 14.25F);
            label6.Location = new Point(8, 88);
            label6.Name = "label6";
            label6.Size = new Size(86, 24);
            label6.TabIndex = 236;
            label6.Text = "預交日期";
            // 
            // commonDateTimePicker1
            // 
            commonDateTimePicker1.Enabled = false;
            commonDateTimePicker1.Font = new Font("Microsoft JhengHei UI", 14.25F);
            commonDateTimePicker1.Location = new Point(56, 84);
            commonDateTimePicker1.Name = "commonDateTimePicker1";
            commonDateTimePicker1.Size = new Size(184, 32);
            commonDateTimePicker1.TabIndex = 235;
            commonDateTimePicker1.Value = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            // 
            // OrderMaintainControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label6);
            Controls.Add(commonDateTimePicker1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(dataGridView1);
            Controls.Add(cboCustId);
            Controls.Add(label13);
            Controls.Add(txtOrderNo);
            Controls.Add(label3);
            Controls.Add(btnModify);
            Controls.Add(label2);
            Controls.Add(dtORDERDATE);
            Controls.Add(button1);
            Controls.Add(lblMode);
            Controls.Add(label1);
            Name = "OrderMaintainControl";
            Size = new Size(1446, 762);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMode;
        private Label label1;
        private Button button1;
        private Button btnModify;
        private Label label2;
        private DigiERP.Common.CommonDateTimePicker dtORDERDATE;
        private DigiERP.Common.CommonTextBox txtOrderNo;
        private Label label3;
        private Label label13;
        private DigiERP.Common.CommonComboBox cboCustId;
        private DataGridView dataGridView1;
        private Label label4;
        private Label label5;
        private DataGridViewTextBoxColumn 款項期別;
        private DataGridViewTextBoxColumn 成數;
        private DataGridViewTextBoxColumn 金額;
        private DataGridViewTextBoxColumn 立帳單號;
        private DataGridViewTextBoxColumn 轉立帳單;
        private Label label6;
        private DigiERP.Common.CommonDateTimePicker commonDateTimePicker1;
    }
}
