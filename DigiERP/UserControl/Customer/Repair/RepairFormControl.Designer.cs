namespace DigiERP.UserControl.Customer.Repair
{
    partial class RepairFormControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RepairFormControl));
            DataGridViewCellStyle dataGridViewCellStyle29 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle30 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle31 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle32 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle33 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle34 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle35 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle36 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle37 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle38 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle39 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle40 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle41 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle42 = new DataGridViewCellStyle();
            panel1 = new Panel();
            btn新增 = new Button();
            btn查詢 = new Button();
            btn重新整理 = new Button();
            cboCustId = new DigiERP.Common.CommonComboBox();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            colOrderNo = new DataGridViewTextBoxColumn();
            colDate = new DataGridViewTextBoxColumn();
            colCustId = new DataGridViewTextBoxColumn();
            colProjectSerial = new DataGridViewTextBoxColumn();
            colEqpModel = new DataGridViewTextBoxColumn();
            colEqpName = new DataGridViewTextBoxColumn();
            colServiceType = new DataGridViewTextBoxColumn();
            colRepairLocation = new DataGridViewTextBoxColumn();
            colDesiredDate = new DataGridViewTextBoxColumn();
            colActualDate = new DataGridViewTextBoxColumn();
            colCloseDate = new DataGridViewTextBoxColumn();
            colInspector = new DataGridViewTextBoxColumn();
            colTransferParts = new DataGridViewTextBoxColumn();
            colApprover = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btn新增);
            panel1.Controls.Add(btn查詢);
            panel1.Controls.Add(btn重新整理);
            panel1.Controls.Add(cboCustId);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1654, 112);
            panel1.TabIndex = 0;
            // 
            // btn新增
            // 
            btn新增.BackColor = Color.CornflowerBlue;
            btn新增.ForeColor = SystemColors.ButtonFace;
            btn新增.Location = new Point(1000, 32);
            btn新增.Name = "btn新增";
            btn新增.Size = new Size(120, 52);
            btn新增.TabIndex = 6;
            btn新增.Text = "新增";
            btn新增.UseVisualStyleBackColor = false;
            btn新增.Click += btn新增_Click;
            // 
            // btn查詢
            // 
            btn查詢.BackColor = Color.SteelBlue;
            btn查詢.ForeColor = SystemColors.ButtonFace;
            btn查詢.Location = new Point(724, 32);
            btn查詢.Name = "btn查詢";
            btn查詢.Size = new Size(120, 52);
            btn查詢.TabIndex = 5;
            btn查詢.Text = "查詢";
            btn查詢.UseVisualStyleBackColor = false;
            btn查詢.Click += btn查詢_Click;
            // 
            // btn重新整理
            // 
            btn重新整理.BackColor = Color.SkyBlue;
            btn重新整理.Location = new Point(868, 32);
            btn重新整理.Name = "btn重新整理";
            btn重新整理.Size = new Size(120, 52);
            btn重新整理.TabIndex = 4;
            btn重新整理.Text = "重新整理";
            btn重新整理.UseVisualStyleBackColor = false;
            btn重新整理.Click += btn重新整理_Click;
            // 
            // cboCustId
            // 
            cboCustId.FormattingEnabled = true;
            cboCustId.Location = new Point(512, 40);
            cboCustId.Name = "cboCustId";
            cboCustId.Size = new Size(200, 32);
            cboCustId.TabIndex = 3;
            cboCustId.MouseClick += cboCustId_MouseClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(380, 44);
            label2.Name = "label2";
            label2.Size = new Size(86, 24);
            label2.TabIndex = 2;
            label2.Text = "客戶篩選";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label1.Location = new Point(144, 36);
            label1.Name = "label1";
            label1.Size = new Size(220, 37);
            label1.TabIndex = 1;
            label1.Text = "維修服務管控表";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 8);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(120, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridView1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 112);
            panel2.Name = "panel2";
            panel2.Size = new Size(1654, 796);
            panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colOrderNo, colDate, colCustId, colProjectSerial, colEqpModel, colEqpName, colServiceType, colRepairLocation, colDesiredDate, colActualDate, colCloseDate, colInspector, colTransferParts, colApprover });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(1654, 796);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            dataGridView1.VisibleChanged += dataGridView1_VisibleChanged;
            // 
            // colOrderNo
            // 
            dataGridViewCellStyle29.WrapMode = DataGridViewTriState.True;
            colOrderNo.DefaultCellStyle = dataGridViewCellStyle29;
            colOrderNo.HeaderText = "單號";
            colOrderNo.Name = "colOrderNo";
            colOrderNo.ReadOnly = true;
            // 
            // colDate
            // 
            dataGridViewCellStyle30.WrapMode = DataGridViewTriState.True;
            colDate.DefaultCellStyle = dataGridViewCellStyle30;
            colDate.HeaderText = "申請日期";
            colDate.Name = "colDate";
            colDate.ReadOnly = true;
            // 
            // colCustId
            // 
            dataGridViewCellStyle31.WrapMode = DataGridViewTriState.True;
            colCustId.DefaultCellStyle = dataGridViewCellStyle31;
            colCustId.HeaderText = "客戶簡稱";
            colCustId.Name = "colCustId";
            colCustId.ReadOnly = true;
            // 
            // colProjectSerial
            // 
            dataGridViewCellStyle32.WrapMode = DataGridViewTriState.True;
            colProjectSerial.DefaultCellStyle = dataGridViewCellStyle32;
            colProjectSerial.HeaderText = "專案序號";
            colProjectSerial.Name = "colProjectSerial";
            colProjectSerial.ReadOnly = true;
            // 
            // colEqpModel
            // 
            dataGridViewCellStyle33.WrapMode = DataGridViewTriState.True;
            colEqpModel.DefaultCellStyle = dataGridViewCellStyle33;
            colEqpModel.HeaderText = "機台型號";
            colEqpModel.Name = "colEqpModel";
            colEqpModel.ReadOnly = true;
            // 
            // colEqpName
            // 
            dataGridViewCellStyle34.WrapMode = DataGridViewTriState.True;
            colEqpName.DefaultCellStyle = dataGridViewCellStyle34;
            colEqpName.HeaderText = "機台名稱";
            colEqpName.Name = "colEqpName";
            colEqpName.ReadOnly = true;
            // 
            // colServiceType
            // 
            dataGridViewCellStyle35.WrapMode = DataGridViewTriState.True;
            colServiceType.DefaultCellStyle = dataGridViewCellStyle35;
            colServiceType.HeaderText = "服務型態";
            colServiceType.Name = "colServiceType";
            colServiceType.ReadOnly = true;
            // 
            // colRepairLocation
            // 
            dataGridViewCellStyle36.WrapMode = DataGridViewTriState.True;
            colRepairLocation.DefaultCellStyle = dataGridViewCellStyle36;
            colRepairLocation.HeaderText = "維修地點";
            colRepairLocation.Name = "colRepairLocation";
            colRepairLocation.ReadOnly = true;
            // 
            // colDesiredDate
            // 
            dataGridViewCellStyle37.WrapMode = DataGridViewTriState.True;
            colDesiredDate.DefaultCellStyle = dataGridViewCellStyle37;
            colDesiredDate.HeaderText = "希望服務日期";
            colDesiredDate.Name = "colDesiredDate";
            colDesiredDate.ReadOnly = true;
            // 
            // colActualDate
            // 
            dataGridViewCellStyle38.WrapMode = DataGridViewTriState.True;
            colActualDate.DefaultCellStyle = dataGridViewCellStyle38;
            colActualDate.HeaderText = "實際服務日期";
            colActualDate.Name = "colActualDate";
            colActualDate.ReadOnly = true;
            // 
            // colCloseDate
            // 
            dataGridViewCellStyle39.WrapMode = DataGridViewTriState.True;
            colCloseDate.DefaultCellStyle = dataGridViewCellStyle39;
            colCloseDate.HeaderText = "維修結案日期";
            colCloseDate.Name = "colCloseDate";
            colCloseDate.ReadOnly = true;
            // 
            // colInspector
            // 
            dataGridViewCellStyle40.WrapMode = DataGridViewTriState.True;
            colInspector.DefaultCellStyle = dataGridViewCellStyle40;
            colInspector.HeaderText = "維修人員";
            colInspector.Name = "colInspector";
            colInspector.ReadOnly = true;
            // 
            // colTransferParts
            // 
            dataGridViewCellStyle41.WrapMode = DataGridViewTriState.True;
            colTransferParts.DefaultCellStyle = dataGridViewCellStyle41;
            colTransferParts.HeaderText = "轉零件申請";
            colTransferParts.Name = "colTransferParts";
            colTransferParts.ReadOnly = true;
            // 
            // colApprover
            // 
            dataGridViewCellStyle42.WrapMode = DataGridViewTriState.True;
            colApprover.DefaultCellStyle = dataGridViewCellStyle42;
            colApprover.HeaderText = "核准";
            colApprover.Name = "colApprover";
            colApprover.ReadOnly = true;
            // 
            // RepairFormControl
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(192, 255, 192);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            Name = "RepairFormControl";
            Size = new Size(1654, 908);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private DigiERP.Common.CommonComboBox cboCustId;
        private Button btn查詢;
        private Button btn重新整理;
        private Button btn新增;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn colOrderNo;
        private DataGridViewTextBoxColumn colDate;
        private DataGridViewTextBoxColumn colCustId;
        private DataGridViewTextBoxColumn colProjectSerial;
        private DataGridViewTextBoxColumn colEqpModel;
        private DataGridViewTextBoxColumn colEqpName;
        private DataGridViewTextBoxColumn colServiceType;
        private DataGridViewTextBoxColumn colRepairLocation;
        private DataGridViewTextBoxColumn colDesiredDate;
        private DataGridViewTextBoxColumn colActualDate;
        private DataGridViewTextBoxColumn colCloseDate;
        private DataGridViewTextBoxColumn colInspector;
        private DataGridViewTextBoxColumn colTransferParts;
        private DataGridViewTextBoxColumn colApprover;
    }
}
