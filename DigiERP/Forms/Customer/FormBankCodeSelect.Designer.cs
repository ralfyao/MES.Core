namespace DigiERP.Forms.Customer
{
    partial class FormBankCodeSelect
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
            代號 = new DataGridViewTextBoxColumn();
            代號名稱 = new DataGridViewTextBoxColumn();
            帳號 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { 代號, 代號名稱, 帳號 });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(501, 302);
            dataGridView1.TabIndex = 0;
            // 
            // 代號
            // 
            代號.HeaderText = "代號";
            代號.Name = "代號";
            代號.ReadOnly = true;
            // 
            // 代號名稱
            // 
            代號名稱.HeaderText = "代號名稱";
            代號名稱.Name = "代號名稱";
            代號名稱.ReadOnly = true;
            // 
            // 帳號
            // 
            帳號.HeaderText = "帳號";
            帳號.Name = "帳號";
            帳號.ReadOnly = true;
            // 
            // FormBankCodeSelect
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(501, 302);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormBankCodeSelect";
            Text = "FormBankCodeSelect";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn 代號;
        private DataGridViewTextBoxColumn 代號名稱;
        private DataGridViewTextBoxColumn 帳號;
    }
}