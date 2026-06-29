namespace DigiERP.UserControl.Customer.EQPShipping
{
    partial class EQPShippingControl
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region 元件設計工具產生的程式碼

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EQPShippingControl));
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle15 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle16 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle17 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle18 = new DataGridViewCellStyle();
            panel1 = new Panel();
            btn新增 = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            colOrderNo = new DataGridViewTextBoxColumn();
            colDate = new DataGridViewTextBoxColumn();
            colProjectSerial = new DataGridViewTextBoxColumn();
            colETD = new DataGridViewTextBoxColumn();
            colETA = new DataGridViewTextBoxColumn();
            colDestinationPort = new DataGridViewTextBoxColumn();
            colContact = new DataGridViewTextBoxColumn();
            colForwarder = new DataGridViewTextBoxColumn();
            colApprover = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 224, 192);
            panel1.Controls.Add(btn新增);
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
            btn新增.Location = new Point(560, 32);
            btn新增.Name = "btn新增";
            btn新增.Size = new Size(120, 52);
            btn新增.TabIndex = 1;
            btn新增.Text = "新增";
            btn新增.UseVisualStyleBackColor = false;
            btn新增.Click += btn新增_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label1.Location = new Point(144, 36);
            label1.Name = "label1";
            label1.Size = new Size(278, 37);
            label1.TabIndex = 0;
            label1.Text = "專案機台交貨單總覽";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 8);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(84, 84);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
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
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colOrderNo, colDate, colProjectSerial, colETD, colETA, colDestinationPort, colContact, colForwarder, colApprover });
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
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.True;
            colOrderNo.DefaultCellStyle = dataGridViewCellStyle10;
            colOrderNo.HeaderText = "單號";
            colOrderNo.Name = "colOrderNo";
            colOrderNo.ReadOnly = true;
            // 
            // colDate
            // 
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.True;
            colDate.DefaultCellStyle = dataGridViewCellStyle11;
            colDate.HeaderText = "日期";
            colDate.Name = "colDate";
            colDate.ReadOnly = true;
            // 
            // colProjectSerial
            // 
            dataGridViewCellStyle12.WrapMode = DataGridViewTriState.True;
            colProjectSerial.DefaultCellStyle = dataGridViewCellStyle12;
            colProjectSerial.HeaderText = "專案序號";
            colProjectSerial.Name = "colProjectSerial";
            colProjectSerial.ReadOnly = true;
            // 
            // colETD
            // 
            dataGridViewCellStyle13.WrapMode = DataGridViewTriState.True;
            colETD.DefaultCellStyle = dataGridViewCellStyle13;
            colETD.HeaderText = "ETD";
            colETD.Name = "colETD";
            colETD.ReadOnly = true;
            // 
            // colETA
            // 
            dataGridViewCellStyle14.WrapMode = DataGridViewTriState.True;
            colETA.DefaultCellStyle = dataGridViewCellStyle14;
            colETA.HeaderText = "ETA";
            colETA.Name = "colETA";
            colETA.ReadOnly = true;
            // 
            // colDestinationPort
            // 
            dataGridViewCellStyle15.WrapMode = DataGridViewTriState.True;
            colDestinationPort.DefaultCellStyle = dataGridViewCellStyle15;
            colDestinationPort.HeaderText = "目的港";
            colDestinationPort.Name = "colDestinationPort";
            colDestinationPort.ReadOnly = true;
            // 
            // colContact
            // 
            dataGridViewCellStyle16.WrapMode = DataGridViewTriState.True;
            colContact.DefaultCellStyle = dataGridViewCellStyle16;
            colContact.HeaderText = "聯絡人";
            colContact.Name = "colContact";
            colContact.ReadOnly = true;
            // 
            // colForwarder
            // 
            dataGridViewCellStyle17.WrapMode = DataGridViewTriState.True;
            colForwarder.DefaultCellStyle = dataGridViewCellStyle17;
            colForwarder.HeaderText = "承攬業";
            colForwarder.Name = "colForwarder";
            colForwarder.ReadOnly = true;
            // 
            // colApprover
            // 
            dataGridViewCellStyle18.WrapMode = DataGridViewTriState.True;
            colApprover.DefaultCellStyle = dataGridViewCellStyle18;
            colApprover.HeaderText = "核准";
            colApprover.Name = "colApprover";
            colApprover.ReadOnly = true;
            // 
            // EQPShippingControl
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(192, 255, 192);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            Name = "EQPShippingControl";
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
        private Button btn新增;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn colOrderNo;
        private DataGridViewTextBoxColumn colDate;
        private DataGridViewTextBoxColumn colProjectSerial;
        private DataGridViewTextBoxColumn colETD;
        private DataGridViewTextBoxColumn colETA;
        private DataGridViewTextBoxColumn colDestinationPort;
        private DataGridViewTextBoxColumn colContact;
        private DataGridViewTextBoxColumn colForwarder;
        private DataGridViewTextBoxColumn colApprover;
    }
}
