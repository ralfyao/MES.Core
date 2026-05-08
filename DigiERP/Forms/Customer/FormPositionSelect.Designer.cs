namespace DigiERP.Forms.Customer
{
    partial class FormPositionSelect
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
            分類 = new DataGridViewTextBoxColumn();
            說明 = new DataGridViewTextBoxColumn();
            職務 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { 代號, 分類, 說明, 職務 });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(501, 253);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // 代號
            // 
            代號.HeaderText = "代號";
            代號.Name = "代號";
            代號.ReadOnly = true;
            // 
            // 分類
            // 
            分類.HeaderText = "分類";
            分類.Name = "分類";
            分類.ReadOnly = true;
            // 
            // 說明
            // 
            說明.HeaderText = "說明";
            說明.Name = "說明";
            說明.ReadOnly = true;
            // 
            // 職務
            // 
            職務.HeaderText = "職務";
            職務.Name = "職務";
            職務.ReadOnly = true;
            // 
            // FormPositionSelect
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(501, 253);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormPositionSelect";
            Text = "FormBankCodeSelect";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn 代號;
        private DataGridViewTextBoxColumn 代號名稱;
        private DataGridViewTextBoxColumn 帳號;
        private DataGridViewTextBoxColumn 分類;
        private DataGridViewTextBoxColumn 說明;
        private DataGridViewTextBoxColumn 職務;
    }
}