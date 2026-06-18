namespace DigiERP.UserControl.Customer.EQPCSustService
{
    partial class EQPCustServiceControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EQPCustServiceControl));
            panel1 = new Panel();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            btnAdd = new Button();
            OrderNo = new DataGridViewTextBoxColumn();
            Date = new DataGridViewTextBoxColumn();
            CustNo = new DataGridViewTextBoxColumn();
            CustName = new DataGridViewTextBoxColumn();
            ProjectNo = new DataGridViewTextBoxColumn();
            EQPNo = new DataGridViewTextBoxColumn();
            Events = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SpringGreen;
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1451, 100);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridView1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 100);
            panel2.Name = "panel2";
            panel2.Size = new Size(1451, 655);
            panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(8, 8);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 80);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label1.Location = new Point(124, 28);
            label1.Name = "label1";
            label1.Size = new Size(133, 37);
            label1.TabIndex = 1;
            label1.Text = "機台客服";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { OrderNo, Date, CustNo, CustName, ProjectNo, EQPNo, Events });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(1451, 655);
            dataGridView1.TabIndex = 0;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(1072, 28);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(160, 52);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "ADD";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // OrderNo
            // 
            OrderNo.HeaderText = "單號";
            OrderNo.Name = "OrderNo";
            OrderNo.ReadOnly = true;
            // 
            // Date
            // 
            Date.HeaderText = "日期";
            Date.Name = "Date";
            Date.ReadOnly = true;
            // 
            // CustNo
            // 
            CustNo.HeaderText = "客戶編號";
            CustNo.Name = "CustNo";
            CustNo.ReadOnly = true;
            // 
            // CustName
            // 
            CustName.HeaderText = "客戶名稱";
            CustName.Name = "CustName";
            CustName.ReadOnly = true;
            // 
            // ProjectNo
            // 
            ProjectNo.HeaderText = "專案序號";
            ProjectNo.Name = "ProjectNo";
            ProjectNo.ReadOnly = true;
            // 
            // EQPNo
            // 
            EQPNo.HeaderText = "機台型號";
            EQPNo.Name = "EQPNo";
            EQPNo.ReadOnly = true;
            // 
            // Events
            // 
            Events.HeaderText = "Events";
            Events.Name = "Events";
            Events.ReadOnly = true;
            // 
            // EQPCustServiceControl
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            Name = "EQPCustServiceControl";
            Size = new Size(1451, 755);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label label1;
        private DataGridView dataGridView1;
        private Button btnAdd;
        private DataGridViewTextBoxColumn OrderNo;
        private DataGridViewTextBoxColumn Date;
        private DataGridViewTextBoxColumn CustNo;
        private DataGridViewTextBoxColumn CustName;
        private DataGridViewTextBoxColumn ProjectNo;
        private DataGridViewTextBoxColumn EQPNo;
        private DataGridViewTextBoxColumn Events;
    }
}
