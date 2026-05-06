namespace DigiERP.Forms.Customer
{
    partial class FormIndustryCodeSelect
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
            industryCode = new DataGridViewTextBoxColumn();
            industryCodeName = new DataGridViewTextBoxColumn();
            englishDesc = new DataGridViewTextBoxColumn();
            Others = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { industryCode, industryCodeName, englishDesc, Others });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(779, 450);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // industryCode
            // 
            industryCode.HeaderText = "中分類碼";
            industryCode.MinimumWidth = 8;
            industryCode.Name = "industryCode";
            industryCode.ReadOnly = true;
            industryCode.Width = 118;
            // 
            // industryCodeName
            // 
            industryCodeName.HeaderText = "中分類名稱";
            industryCodeName.MinimumWidth = 8;
            industryCodeName.Name = "industryCodeName";
            industryCodeName.ReadOnly = true;
            industryCodeName.Width = 136;
            // 
            // englishDesc
            // 
            englishDesc.HeaderText = "英文";
            englishDesc.MinimumWidth = 8;
            englishDesc.Name = "englishDesc";
            englishDesc.ReadOnly = true;
            englishDesc.Width = 82;
            // 
            // Others
            // 
            Others.HeaderText = "其他";
            Others.MinimumWidth = 8;
            Others.Name = "Others";
            Others.ReadOnly = true;
            Others.Width = 82;
            // 
            // FormIndustryCodeSelect
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(779, 450);
            ControlBox = false;
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormIndustryCodeSelect";
            Text = "FormIndustryCodeSelect";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn industryCode;
        private DataGridViewTextBoxColumn industryCodeName;
        private DataGridViewTextBoxColumn englishDesc;
        private DataGridViewTextBoxColumn Others;
    }
}