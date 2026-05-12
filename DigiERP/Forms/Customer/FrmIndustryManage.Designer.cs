namespace DigiERP.Forms.Customer
{
    partial class FrmIndustryManage
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
            大分類 = new DataGridViewTextBoxColumn();
            大分類名稱 = new DataGridViewTextBoxColumn();
            中分類碼 = new DataGridViewTextBoxColumn();
            中分類名稱 = new DataGridViewTextBoxColumn();
            英文 = new DataGridViewTextBoxColumn();
            內容 = new DataGridViewTextBoxColumn();
            其他 = new DataGridViewTextBoxColumn();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { 大分類, 大分類名稱, 中分類碼, 中分類名稱, 英文, 內容, 其他 });
            dataGridView1.Location = new Point(24, 64);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(928, 376);
            dataGridView1.TabIndex = 0;
            // 
            // 大分類
            // 
            大分類.HeaderText = "大分類";
            大分類.MinimumWidth = 6;
            大分類.Name = "大分類";
            大分類.ReadOnly = true;
            大分類.Width = 125;
            // 
            // 大分類名稱
            // 
            大分類名稱.HeaderText = "大分類名稱";
            大分類名稱.MinimumWidth = 6;
            大分類名稱.Name = "大分類名稱";
            大分類名稱.ReadOnly = true;
            大分類名稱.Width = 125;
            // 
            // 中分類碼
            // 
            中分類碼.HeaderText = "中分類碼";
            中分類碼.MinimumWidth = 6;
            中分類碼.Name = "中分類碼";
            中分類碼.ReadOnly = true;
            中分類碼.Width = 125;
            // 
            // 中分類名稱
            // 
            中分類名稱.HeaderText = "中分類名稱";
            中分類名稱.MinimumWidth = 6;
            中分類名稱.Name = "中分類名稱";
            中分類名稱.ReadOnly = true;
            中分類名稱.Width = 125;
            // 
            // 英文
            // 
            英文.HeaderText = "英文";
            英文.MinimumWidth = 6;
            英文.Name = "英文";
            英文.ReadOnly = true;
            英文.Width = 125;
            // 
            // 內容
            // 
            內容.HeaderText = "內容";
            內容.MinimumWidth = 6;
            內容.Name = "內容";
            內容.ReadOnly = true;
            內容.Width = 125;
            // 
            // 其他
            // 
            其他.HeaderText = "其他";
            其他.MinimumWidth = 6;
            其他.Name = "其他";
            其他.ReadOnly = true;
            其他.Width = 125;
            // 
            // button1
            // 
            button1.Location = new Point(24, 16);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 1;
            button1.Text = "新增";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // FrmIndustryManage
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(985, 482);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "FrmIndustryManage";
            Text = "業別管理";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn 大分類;
        private DataGridViewTextBoxColumn 大分類名稱;
        private DataGridViewTextBoxColumn 中分類碼;
        private DataGridViewTextBoxColumn 中分類名稱;
        private DataGridViewTextBoxColumn 英文;
        private DataGridViewTextBoxColumn 內容;
        private DataGridViewTextBoxColumn 其他;
        private Button button1;
    }
}