namespace DigiERP.Forms.Auth
{
    partial class FrmPrivilege
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
            commonTextBox1 = new Common.CommonTextBox();
            commonTextBox2 = new Common.CommonTextBox();
            label2 = new Label();
            label3 = new Label();
            dataGridView1 = new DataGridView();
            功能ID = new DataGridViewTextBoxColumn();
            選單ID = new DataGridViewTextBoxColumn();
            功能名稱 = new DataGridViewTextBoxColumn();
            選單名稱 = new DataGridViewTextBoxColumn();
            高管 = new DataGridViewCheckBoxColumn();
            核准 = new DataGridViewCheckBoxColumn();
            編修 = new DataGridViewCheckBoxColumn();
            列印 = new DataGridViewCheckBoxColumn();
            輸出 = new DataGridViewCheckBoxColumn();
            查詢 = new DataGridViewCheckBoxColumn();
            註記 = new DataGridViewTextBoxColumn();
            職務代理效期 = new DataGridViewTextBoxColumn();
            機號 = new DataGridViewTextBoxColumn();
            btnSave = new Button();
            commonTextBox3 = new Common.CommonTextBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 12);
            label1.Name = "label1";
            label1.Size = new Size(67, 24);
            label1.TabIndex = 0;
            label1.Text = "帳號：";
            // 
            // commonTextBox1
            // 
            commonTextBox1.Enabled = false;
            commonTextBox1.Location = new Point(84, 8);
            commonTextBox1.Name = "commonTextBox1";
            commonTextBox1.Size = new Size(188, 32);
            commonTextBox1.TabIndex = 1;
            // 
            // commonTextBox2
            // 
            commonTextBox2.Enabled = false;
            commonTextBox2.Location = new Point(84, 52);
            commonTextBox2.Name = "commonTextBox2";
            commonTextBox2.Size = new Size(188, 32);
            commonTextBox2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 56);
            label2.Name = "label2";
            label2.Size = new Size(67, 24);
            label2.TabIndex = 2;
            label2.Text = "姓名：";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 104);
            label3.Name = "label3";
            label3.Size = new Size(105, 24);
            label3.TabIndex = 4;
            label3.Text = "權限列表：";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { 功能ID, 選單ID, 功能名稱, 選單名稱, 高管, 核准, 編修, 列印, 輸出, 查詢, 註記, 職務代理效期, 機號 });
            dataGridView1.Location = new Point(20, 140);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1180, 372);
            dataGridView1.TabIndex = 5;
            // 
            // 功能ID
            // 
            功能ID.HeaderText = "功能ID";
            功能ID.Name = "功能ID";
            功能ID.Visible = false;
            // 
            // 選單ID
            // 
            選單ID.HeaderText = "選單ID";
            選單ID.Name = "選單ID";
            選單ID.Visible = false;
            // 
            // 功能名稱
            // 
            功能名稱.HeaderText = "功能名稱";
            功能名稱.Name = "功能名稱";
            功能名稱.ReadOnly = true;
            // 
            // 選單名稱
            // 
            選單名稱.HeaderText = "選單名稱";
            選單名稱.Name = "選單名稱";
            選單名稱.ReadOnly = true;
            // 
            // 高管
            // 
            高管.HeaderText = "高管";
            高管.Name = "高管";
            // 
            // 核准
            // 
            核准.HeaderText = "核准";
            核准.Name = "核准";
            // 
            // 編修
            // 
            編修.HeaderText = "編修";
            編修.Name = "編修";
            // 
            // 列印
            // 
            列印.HeaderText = "列印";
            列印.Name = "列印";
            // 
            // 輸出
            // 
            輸出.HeaderText = "輸出";
            輸出.Name = "輸出";
            // 
            // 查詢
            // 
            查詢.HeaderText = "查詢";
            查詢.Name = "查詢";
            // 
            // 註記
            // 
            註記.HeaderText = "註記";
            註記.Name = "註記";
            // 
            // 職務代理效期
            // 
            職務代理效期.HeaderText = "職務代理效期";
            職務代理效期.Name = "職務代理效期";
            // 
            // 機號
            // 
            機號.HeaderText = "機號";
            機號.Name = "機號";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(132, 100);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(104, 36);
            btnSave.TabIndex = 6;
            btnSave.Text = "儲存";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // commonTextBox3
            // 
            commonTextBox3.Enabled = false;
            commonTextBox3.Location = new Point(376, 8);
            commonTextBox3.Name = "commonTextBox3";
            commonTextBox3.Size = new Size(188, 32);
            commonTextBox3.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(304, 12);
            label4.Name = "label4";
            label4.Size = new Size(67, 24);
            label4.TabIndex = 7;
            label4.Text = "職務：";
            // 
            // FrmPrivilege
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1216, 532);
            Controls.Add(commonTextBox3);
            Controls.Add(label4);
            Controls.Add(btnSave);
            Controls.Add(dataGridView1);
            Controls.Add(label3);
            Controls.Add(commonTextBox2);
            Controls.Add(label2);
            Controls.Add(commonTextBox1);
            Controls.Add(label1);
            Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(5);
            Name = "FrmPrivilege";
            Text = "系統權限";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Common.CommonTextBox commonTextBox1;
        private Common.CommonTextBox commonTextBox2;
        private Label label2;
        private Label label3;
        private DataGridView dataGridView1;
        private Button btnSave;
        private DataGridViewTextBoxColumn 功能ID;
        private DataGridViewTextBoxColumn 選單ID;
        private DataGridViewTextBoxColumn 功能名稱;
        private DataGridViewTextBoxColumn 選單名稱;
        private DataGridViewCheckBoxColumn 高管;
        private DataGridViewCheckBoxColumn 核准;
        private DataGridViewCheckBoxColumn 編修;
        private DataGridViewCheckBoxColumn 列印;
        private DataGridViewCheckBoxColumn 輸出;
        private DataGridViewCheckBoxColumn 查詢;
        private DataGridViewTextBoxColumn 註記;
        private DataGridViewTextBoxColumn 職務代理效期;
        private DataGridViewTextBoxColumn 機號;
        private Common.CommonTextBox commonTextBox3;
        private Label label4;
    }
}