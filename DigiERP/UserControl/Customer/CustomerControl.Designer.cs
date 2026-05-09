
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
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { COMPANY, CONTACTPERSON, 正航編號, COUNTRY, INDUSTRY, 中名稱分類, 英文, MACHINEISSUE, MA, MEMO, CREDATE, 識別 });
            dataGridView1.Location = new Point(2, 57);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Microsoft JhengHei UI", 14.1428576F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.DefaultCellStyle.Font = new Font("新細明體", 14.1428576F, FontStyle.Regular, GraphicsUnit.Point, 136);
            dataGridView1.Size = new Size(979, 471);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellDoubleClick += dataGridView1_CellClick;
            // 
            // COMPANY
            // 
            COMPANY.HeaderText = "客戶名稱";
            COMPANY.MinimumWidth = 8;
            COMPANY.Name = "COMPANY";
            COMPANY.ReadOnly = true;
            COMPANY.Width = 80;
            // 
            // CONTACTPERSON
            // 
            CONTACTPERSON.HeaderText = "主要聯絡人";
            CONTACTPERSON.MinimumWidth = 8;
            CONTACTPERSON.Name = "CONTACTPERSON";
            CONTACTPERSON.ReadOnly = true;
            CONTACTPERSON.Width = 92;
            // 
            // 正航編號
            // 
            正航編號.HeaderText = "客戶編號";
            正航編號.MinimumWidth = 8;
            正航編號.Name = "正航編號";
            正航編號.ReadOnly = true;
            正航編號.Width = 80;
            // 
            // COUNTRY
            // 
            COUNTRY.HeaderText = "國別區域";
            COUNTRY.MinimumWidth = 8;
            COUNTRY.Name = "COUNTRY";
            COUNTRY.ReadOnly = true;
            COUNTRY.Width = 80;
            // 
            // INDUSTRY
            // 
            INDUSTRY.HeaderText = "業別";
            INDUSTRY.MinimumWidth = 8;
            INDUSTRY.Name = "INDUSTRY";
            INDUSTRY.ReadOnly = true;
            INDUSTRY.Width = 56;
            // 
            // 中名稱分類
            // 
            中名稱分類.HeaderText = "所屬業別";
            中名稱分類.MinimumWidth = 8;
            中名稱分類.Name = "中名稱分類";
            中名稱分類.ReadOnly = true;
            中名稱分類.Width = 80;
            // 
            // 英文
            // 
            英文.HeaderText = "所屬業別(英文)";
            英文.MinimumWidth = 8;
            英文.Name = "英文";
            英文.ReadOnly = true;
            英文.Width = 112;
            // 
            // MACHINEISSUE
            // 
            MACHINEISSUE.HeaderText = "管理分類";
            MACHINEISSUE.MinimumWidth = 8;
            MACHINEISSUE.Name = "MACHINEISSUE";
            MACHINEISSUE.ReadOnly = true;
            MACHINEISSUE.Width = 80;
            // 
            // MA
            // 
            MA.HeaderText = "電郵";
            MA.MinimumWidth = 8;
            MA.Name = "MA";
            MA.ReadOnly = true;
            MA.Width = 56;
            // 
            // MEMO
            // 
            MEMO.HeaderText = "啟用日期";
            MEMO.MinimumWidth = 8;
            MEMO.Name = "MEMO";
            MEMO.ReadOnly = true;
            MEMO.Width = 80;
            // 
            // CREDATE
            // 
            CREDATE.HeaderText = "停用日期";
            CREDATE.MinimumWidth = 8;
            CREDATE.Name = "CREDATE";
            CREDATE.ReadOnly = true;
            CREDATE.Width = 80;
            // 
            // 識別
            // 
            識別.HeaderText = "識別";
            識別.Name = "識別";
            識別.Visible = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(dataGridView1);
            panel1.Location = new Point(2, 144);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1003, 530);
            panel1.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label1.Location = new Point(80, 16);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(86, 24);
            label1.TabIndex = 5;
            label1.Text = "客戶維護";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(16, 8);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(48, 40);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            button1.Location = new Point(208, 8);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(97, 39);
            button1.TabIndex = 7;
            button1.Text = "新增客戶";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.AutoScroll = true;
            panel2.Controls.Add(button1);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1005, 48);
            panel2.TabIndex = 6;
            // 
            // CustomerControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(2);
            Name = "CustomerControl";
            Size = new Size(1020, 685);
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
        private DataGridViewTextBoxColumn COMPANY;
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
    }
}
