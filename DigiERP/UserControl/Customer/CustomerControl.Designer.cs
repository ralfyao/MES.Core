
using DigiERP.Common;

namespace DigiERP.UserControl
{
    partial class CustomerControl : CommonUserControl
    {
        /// <summary> 
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public AutoScaleMode AutoScaleMode { get; private set; }

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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerControl));
            dataGridView1 = new DataGridView();
            COMPANY = new DataGridViewTextBoxColumn();
            chk = new DataGridViewCheckBoxColumn();
            CONTACTPERSON = new DataGridViewTextBoxColumn();
            正航編號 = new DataGridViewTextBoxColumn();
            COUNTRY = new DataGridViewTextBoxColumn();
            INDUSTRY = new DataGridViewTextBoxColumn();
            中名稱分類 = new DataGridViewTextBoxColumn();
            英文 = new DataGridViewTextBoxColumn();
            MACHINEISSUE = new DataGridViewTextBoxColumn();
            MA = new DataGridViewTextBoxColumn();
            MEMO = new DataGridViewTextBoxColumn();
            CREDATE = new DataGridViewTextBoxColumn();
            識別 = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            panel2 = new Panel();
            button2 = new Button();
            btnCancelCheck = new Button();
            cboCountry = new ComboBox();
            label3 = new Label();
            txtCustQueryFIeld = new TextBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { COMPANY, chk, CONTACTPERSON, 正航編號, COUNTRY, INDUSTRY, 中名稱分類, 英文, MACHINEISSUE, MA, MEMO, CREDATE, 識別 });
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new Point(0, 119);
            dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Microsoft JhengHei UI", 14.1428576F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.DefaultCellStyle.Font = new Font("新細明體", 14.1428576F, FontStyle.Regular, GraphicsUnit.Point, 136);
            dataGridView1.Size = new Size(1376, 678);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.CellDoubleClick += dataGridView1_CellClick;
            dataGridView1.CellValueChanged += dataGridView1_CellValueChanged;
            dataGridView1.CurrentCellDirtyStateChanged += dataGridView1_CurrentCellDirtyStateChanged;
            // 
            // COMPANY
            // 
            COMPANY.HeaderText = "客戶名稱";
            COMPANY.MinimumWidth = 8;
            COMPANY.Name = "COMPANY";
            COMPANY.ReadOnly = true;
            // 
            // chk
            // 
            chk.HeaderText = "勾選";
            chk.MinimumWidth = 6;
            chk.Name = "chk";
            // 
            // CONTACTPERSON
            // 
            CONTACTPERSON.HeaderText = "主要聯絡人";
            CONTACTPERSON.MinimumWidth = 8;
            CONTACTPERSON.Name = "CONTACTPERSON";
            CONTACTPERSON.ReadOnly = true;
            // 
            // 正航編號
            // 
            正航編號.HeaderText = "客戶編號";
            正航編號.MinimumWidth = 8;
            正航編號.Name = "正航編號";
            正航編號.ReadOnly = true;
            // 
            // COUNTRY
            // 
            COUNTRY.HeaderText = "國別區域";
            COUNTRY.MinimumWidth = 8;
            COUNTRY.Name = "COUNTRY";
            COUNTRY.ReadOnly = true;
            // 
            // INDUSTRY
            // 
            INDUSTRY.HeaderText = "業別";
            INDUSTRY.MinimumWidth = 8;
            INDUSTRY.Name = "INDUSTRY";
            INDUSTRY.ReadOnly = true;
            // 
            // 中名稱分類
            // 
            中名稱分類.HeaderText = "所屬業別";
            中名稱分類.MinimumWidth = 8;
            中名稱分類.Name = "中名稱分類";
            中名稱分類.ReadOnly = true;
            // 
            // 英文
            // 
            英文.HeaderText = "所屬業別(英文)";
            英文.MinimumWidth = 8;
            英文.Name = "英文";
            英文.ReadOnly = true;
            // 
            // MACHINEISSUE
            // 
            MACHINEISSUE.HeaderText = "管理分類";
            MACHINEISSUE.MinimumWidth = 8;
            MACHINEISSUE.Name = "MACHINEISSUE";
            MACHINEISSUE.ReadOnly = true;
            // 
            // MA
            // 
            MA.HeaderText = "電郵";
            MA.MinimumWidth = 8;
            MA.Name = "MA";
            MA.ReadOnly = true;
            // 
            // MEMO
            // 
            MEMO.HeaderText = "啟用日期";
            MEMO.MinimumWidth = 8;
            MEMO.Name = "MEMO";
            MEMO.ReadOnly = true;
            // 
            // CREDATE
            // 
            CREDATE.HeaderText = "停用日期";
            CREDATE.MinimumWidth = 8;
            CREDATE.Name = "CREDATE";
            CREDATE.ReadOnly = true;
            // 
            // 識別
            // 
            識別.HeaderText = "識別";
            識別.MinimumWidth = 6;
            識別.Name = "識別";
            識別.Visible = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(dataGridView1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1376, 772);
            panel1.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label1.Location = new Point(103, 20);
            label1.Name = "label1";
            label1.Size = new Size(86, 24);
            label1.TabIndex = 5;
            label1.Text = "客戶維護";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(21, 10);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(62, 51);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            button1.Location = new Point(267, 10);
            button1.Name = "button1";
            button1.Size = new Size(125, 49);
            button1.TabIndex = 7;
            button1.Text = "新增客戶";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.AutoScroll = true;
            panel2.Controls.Add(button2);
            panel2.Controls.Add(btnCancelCheck);
            panel2.Controls.Add(cboCountry);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(txtCustQueryFIeld);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(4, 4, 4, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1376, 61);
            panel2.TabIndex = 6;
            // 
            // button2
            // 
            button2.Font = new Font("Microsoft JhengHei UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 136);
            button2.Location = new Point(1101, 13);
            button2.Margin = new Padding(2, 2, 2, 2);
            button2.Name = "button2";
            button2.Size = new Size(131, 32);
            button2.TabIndex = 13;
            button2.Text = "匯出勾選資料";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // btnCancelCheck
            // 
            btnCancelCheck.Font = new Font("Microsoft JhengHei UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 136);
            btnCancelCheck.Location = new Point(989, 13);
            btnCancelCheck.Margin = new Padding(2, 2, 2, 2);
            btnCancelCheck.Name = "btnCancelCheck";
            btnCancelCheck.Size = new Size(100, 32);
            btnCancelCheck.TabIndex = 12;
            btnCancelCheck.Text = "取消勾選";
            btnCancelCheck.UseVisualStyleBackColor = true;
            btnCancelCheck.Click += btnCancelCheck_Click;
            // 
            // cboCountry
            // 
            cboCountry.FormattingEnabled = true;
            cboCountry.Location = new Point(816, 16);
            cboCountry.Name = "cboCountry";
            cboCountry.Size = new Size(151, 23);
            cboCountry.TabIndex = 11;
            cboCountry.SelectedIndexChanged += cboCountry_SelectedIndexChanged;
            cboCountry.Leave += cboCountry_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label3.Location = new Point(696, 16);
            label3.Name = "label3";
            label3.Size = new Size(86, 24);
            label3.TabIndex = 10;
            label3.Text = "國別查詢";
            // 
            // txtCustQueryFIeld
            // 
            txtCustQueryFIeld.Location = new Point(528, 17);
            txtCustQueryFIeld.Name = "txtCustQueryFIeld";
            txtCustQueryFIeld.Size = new Size(144, 23);
            txtCustQueryFIeld.TabIndex = 9;
            txtCustQueryFIeld.Leave += txtCustQueryFIeld_Leave;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label2.Location = new Point(408, 16);
            label2.Name = "label2";
            label2.Size = new Size(86, 24);
            label2.TabIndex = 8;
            label2.Text = "客戶查詢";
            // 
            // CustomerControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "CustomerControl";
            Size = new Size(1376, 772);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dataGridView1;
        private Panel panel1;
        private CustomerMaintainControl customerMaintainControl;
        private Label label1;
        private PictureBox pictureBox1;
        private Button button1;
        private Panel panel2;
        private Panel panel3;
        private TextBox txtCustQueryFIeld;
        private Label label2;
        private ComboBox cboCountry;
        private Label label3;
        private DataGridViewTextBoxColumn COMPANY;
        private DataGridViewCheckBoxColumn chk;
        private DataGridViewTextBoxColumn CONTACTPERSON;
        private DataGridViewTextBoxColumn 正航編號;
        private DataGridViewTextBoxColumn COUNTRY;
        private DataGridViewTextBoxColumn INDUSTRY;
        private DataGridViewTextBoxColumn 中名稱分類;
        private DataGridViewTextBoxColumn 英文;
        private DataGridViewTextBoxColumn MACHINEISSUE;
        private DataGridViewTextBoxColumn MA;
        private DataGridViewTextBoxColumn MEMO;
        private DataGridViewTextBoxColumn CREDATE;
        private DataGridViewTextBoxColumn 識別;
        private Button btnCancelCheck;
        private Button button2;
    }
}
