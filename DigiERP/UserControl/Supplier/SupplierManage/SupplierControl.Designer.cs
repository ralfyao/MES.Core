namespace DigiERP.UserControl.Supplier.SupplierManage
{
    partial class SupplierControl
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region 元件設計工具產生的程式碼

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SupplierControl));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            chkHideDisabled = new CheckBox();
            btnSearch = new Button();
            txtSearchName = new TextBox();
            lblSearchName = new Label();
            txtSearchNo = new TextBox();
            lblSearchNo = new Label();
            btn新增 = new Button();
            lblTitle = new Label();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            colNo = new DataGridViewTextBoxColumn();
            colShortName = new DataGridViewTextBoxColumn();
            colName = new DataGridViewTextBoxColumn();
            colTaxNo = new DataGridViewTextBoxColumn();
            colPhone = new DataGridViewTextBoxColumn();
            colFax = new DataGridViewTextBoxColumn();
            colContact = new DataGridViewTextBoxColumn();
            colTitle = new DataGridViewTextBoxColumn();
            colIndustry = new DataGridViewTextBoxColumn();
            colGrade = new DataGridViewTextBoxColumn();
            colApproved = new DataGridViewTextBoxColumn();
            colDisabled = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 255, 192);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(chkHideDisabled);
            panel1.Controls.Add(btnSearch);
            panel1.Controls.Add(txtSearchName);
            panel1.Controls.Add(lblSearchName);
            panel1.Controls.Add(txtSearchNo);
            panel1.Controls.Add(lblSearchNo);
            panel1.Controls.Add(btn新增);
            panel1.Controls.Add(lblTitle);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1497, 112);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(8, 8);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(76, 56);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // chkHideDisabled
            // 
            chkHideDisabled.AutoSize = true;
            chkHideDisabled.Font = new Font("微軟正黑體", 10F);
            chkHideDisabled.Location = new Point(792, 84);
            chkHideDisabled.Name = "chkHideDisabled";
            chkHideDisabled.Size = new Size(83, 22);
            chkHideDisabled.TabIndex = 7;
            chkHideDisabled.Text = "隱藏停用";
            chkHideDisabled.CheckedChanged += chkHideDisabled_CheckedChanged;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.SteelBlue;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(568, 64);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(100, 40);
            btnSearch.TabIndex = 6;
            btnSearch.Text = "查詢";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearchName
            // 
            txtSearchName.Font = new Font("微軟正黑體", 10F);
            txtSearchName.Location = new Point(332, 72);
            txtSearchName.Name = "txtSearchName";
            txtSearchName.Size = new Size(220, 25);
            txtSearchName.TabIndex = 5;
            txtSearchName.KeyDown += txtSearch_KeyDown;
            // 
            // lblSearchName
            // 
            lblSearchName.AutoSize = true;
            lblSearchName.Font = new Font("微軟正黑體", 10F);
            lblSearchName.Location = new Point(262, 76);
            lblSearchName.Name = "lblSearchName";
            lblSearchName.Size = new Size(64, 18);
            lblSearchName.TabIndex = 4;
            lblSearchName.Text = "廠商名稱";
            // 
            // txtSearchNo
            // 
            txtSearchNo.Font = new Font("微軟正黑體", 10F);
            txtSearchNo.Location = new Point(86, 72);
            txtSearchNo.Name = "txtSearchNo";
            txtSearchNo.Size = new Size(160, 25);
            txtSearchNo.TabIndex = 3;
            txtSearchNo.KeyDown += txtSearch_KeyDown;
            // 
            // lblSearchNo
            // 
            lblSearchNo.AutoSize = true;
            lblSearchNo.Font = new Font("微軟正黑體", 10F);
            lblSearchNo.Location = new Point(16, 76);
            lblSearchNo.Name = "lblSearchNo";
            lblSearchNo.Size = new Size(64, 18);
            lblSearchNo.TabIndex = 2;
            lblSearchNo.Text = "廠商編號";
            // 
            // btn新增
            // 
            btn新增.BackColor = Color.FromArgb(70, 160, 70);
            btn新增.FlatStyle = FlatStyle.Flat;
            btn新增.Font = new Font("微軟正黑體", 12F, FontStyle.Bold);
            btn新增.ForeColor = Color.White;
            btn新增.Location = new Point(680, 64);
            btn新增.Name = "btn新增";
            btn新增.Size = new Size(104, 40);
            btn新增.TabIndex = 1;
            btn新增.Text = "新增";
            btn新增.UseVisualStyleBackColor = false;
            btn新增.Click += btn新增_Click;
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("微軟正黑體", 18F, FontStyle.Bold);
            lblTitle.Location = new Point(88, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(152, 32);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "廠商一覽表";
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridView1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 112);
            panel2.Name = "panel2";
            panel2.Size = new Size(1497, 564);
            panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colNo, colShortName, colName, colTaxNo, colPhone, colFax, colContact, colTitle, colIndustry, colGrade, colApproved, colDisabled });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Font = new Font("微軟正黑體", 10F);
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 28;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1497, 564);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            dataGridView1.VisibleChanged += dataGridView1_VisibleChanged;
            // 
            // colNo
            // 
            colNo.FillWeight = 60F;
            colNo.HeaderText = "廠商編號";
            colNo.Name = "colNo";
            colNo.ReadOnly = true;
            // 
            // colShortName
            // 
            colShortName.FillWeight = 60F;
            colShortName.HeaderText = "廠商簡稱";
            colShortName.Name = "colShortName";
            colShortName.ReadOnly = true;
            // 
            // colName
            // 
            colName.FillWeight = 120F;
            colName.HeaderText = "廠商名稱";
            colName.Name = "colName";
            colName.ReadOnly = true;
            // 
            // colTaxNo
            // 
            colTaxNo.FillWeight = 70F;
            colTaxNo.HeaderText = "統一編號";
            colTaxNo.Name = "colTaxNo";
            colTaxNo.ReadOnly = true;
            // 
            // colPhone
            // 
            colPhone.FillWeight = 80F;
            colPhone.HeaderText = "電話";
            colPhone.Name = "colPhone";
            colPhone.ReadOnly = true;
            // 
            // colFax
            // 
            colFax.FillWeight = 80F;
            colFax.HeaderText = "傳真";
            colFax.Name = "colFax";
            colFax.ReadOnly = true;
            // 
            // colContact
            // 
            colContact.FillWeight = 60F;
            colContact.HeaderText = "聯絡人";
            colContact.Name = "colContact";
            colContact.ReadOnly = true;
            // 
            // colTitle
            // 
            colTitle.FillWeight = 60F;
            colTitle.HeaderText = "職稱";
            colTitle.Name = "colTitle";
            colTitle.ReadOnly = true;
            // 
            // colIndustry
            // 
            colIndustry.FillWeight = 60F;
            colIndustry.HeaderText = "業別";
            colIndustry.Name = "colIndustry";
            colIndustry.ReadOnly = true;
            // 
            // colGrade
            // 
            colGrade.FillWeight = 40F;
            colGrade.HeaderText = "等級";
            colGrade.Name = "colGrade";
            colGrade.ReadOnly = true;
            // 
            // colApproved
            // 
            colApproved.FillWeight = 50F;
            colApproved.HeaderText = "核准";
            colApproved.Name = "colApproved";
            colApproved.ReadOnly = true;
            // 
            // colDisabled
            // 
            colDisabled.FillWeight = 40F;
            colDisabled.HeaderText = "停用";
            colDisabled.Name = "colDisabled";
            colDisabled.ReadOnly = true;
            // 
            // SupplierControl
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("微軟正黑體", 10F);
            Margin = new Padding(4);
            Name = "SupplierControl";
            Size = new Size(1497, 676);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSearchNo;
        private System.Windows.Forms.TextBox txtSearchNo;
        private System.Windows.Forms.Label lblSearchName;
        private System.Windows.Forms.TextBox txtSearchName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btn新增;
        private System.Windows.Forms.CheckBox chkHideDisabled;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colShortName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTaxNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFax;
        private System.Windows.Forms.DataGridViewTextBoxColumn colContact;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIndustry;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGrade;
        private System.Windows.Forms.DataGridViewTextBoxColumn colApproved;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDisabled;
        private PictureBox pictureBox1;
    }
}
