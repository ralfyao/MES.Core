namespace DigiERP.Forms.Customer.SalesOrder
{
    partial class FrmCustSelect
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
            客戶編號 = new DataGridViewTextBoxColumn();
            客戶名稱 = new DataGridViewTextBoxColumn();
            客戶簡稱 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { 客戶編號, 客戶名稱, 客戶簡稱 });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(393, 285);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.Leave += dataGridView1_Leave;
            // 
            // 客戶編號
            // 
            客戶編號.HeaderText = "客戶編號";
            客戶編號.Name = "客戶編號";
            客戶編號.ReadOnly = true;
            // 
            // 客戶名稱
            // 
            客戶名稱.HeaderText = "客戶名稱";
            客戶名稱.Name = "客戶名稱";
            客戶名稱.ReadOnly = true;
            // 
            // 客戶簡稱
            // 
            客戶簡稱.HeaderText = "客戶簡稱";
            客戶簡稱.Name = "客戶簡稱";
            客戶簡稱.ReadOnly = true;
            // 
            // FrmCustSelect
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(393, 285);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmCustSelect";
            Text = "客戶選擇";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn 客戶編號;
        private DataGridViewTextBoxColumn 客戶名稱;
        private DataGridViewTextBoxColumn 客戶簡稱;
    }
}