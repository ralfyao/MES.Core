namespace DigiERP.UserControl.Customer.CAR
{
    partial class CARControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CARControl));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            panel1 = new Panel();
            btn重新整理 = new Button();
            btn回覆記錄登載 = new Button();
            cboCustId = new DigiERP.Common.CommonComboBox();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            orderNo = new DataGridViewTextBoxColumn();
            date = new DataGridViewTextBoxColumn();
            custId = new DataGridViewTextBoxColumn();
            projectSerial = new DataGridViewTextBoxColumn();
            eqpModel = new DataGridViewTextBoxColumn();
            eqpName = new DataGridViewTextBoxColumn();
            carType = new DataGridViewTextBoxColumn();
            carContent = new DataGridViewTextBoxColumn();
            solution = new DataGridViewTextBoxColumn();
            replyDate = new DataGridViewTextBoxColumn();
            customerReaction = new DataGridViewTextBoxColumn();
            satisfacation = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btn重新整理);
            panel1.Controls.Add(btn回覆記錄登載);
            panel1.Controls.Add(cboCustId);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1567, 112);
            panel1.TabIndex = 0;
            // 
            // btn重新整理
            // 
            btn重新整理.BackColor = Color.SkyBlue;
            btn重新整理.Location = new Point(956, 32);
            btn重新整理.Name = "btn重新整理";
            btn重新整理.Size = new Size(156, 52);
            btn重新整理.TabIndex = 5;
            btn重新整理.Text = "重新整理";
            btn重新整理.UseVisualStyleBackColor = false;
            // 
            // btn回覆記錄登載
            // 
            btn回覆記錄登載.BackColor = Color.CornflowerBlue;
            btn回覆記錄登載.ForeColor = SystemColors.ButtonFace;
            btn回覆記錄登載.Location = new Point(732, 32);
            btn回覆記錄登載.Name = "btn回覆記錄登載";
            btn回覆記錄登載.Size = new Size(212, 52);
            btn回覆記錄登載.TabIndex = 4;
            btn回覆記錄登載.Text = "回覆記錄登載";
            btn回覆記錄登載.UseVisualStyleBackColor = false;
            // 
            // cboCustId
            // 
            cboCustId.FormattingEnabled = true;
            cboCustId.Location = new Point(504, 40);
            cboCustId.Name = "cboCustId";
            cboCustId.Size = new Size(172, 32);
            cboCustId.TabIndex = 3;
            cboCustId.MouseClick += cboCustId_MouseClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(356, 44);
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
            label1.Size = new Size(133, 37);
            label1.TabIndex = 1;
            label1.Text = "客戶訴願";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 8);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(120, 100);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridView1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 112);
            panel2.Name = "panel2";
            panel2.Size = new Size(1567, 727);
            panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { orderNo, date, custId, projectSerial, eqpModel, eqpName, carType, carContent, solution, replyDate, customerReaction, satisfacation });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(1567, 727);
            dataGridView1.TabIndex = 0;
            // 
            // orderNo
            // 
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            orderNo.DefaultCellStyle = dataGridViewCellStyle1;
            orderNo.HeaderText = "單號";
            orderNo.Name = "orderNo";
            orderNo.ReadOnly = true;
            // 
            // date
            // 
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            date.DefaultCellStyle = dataGridViewCellStyle2;
            date.HeaderText = "日期";
            date.Name = "date";
            date.ReadOnly = true;
            // 
            // custId
            // 
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            custId.DefaultCellStyle = dataGridViewCellStyle3;
            custId.HeaderText = "客戶簡稱";
            custId.Name = "custId";
            custId.ReadOnly = true;
            // 
            // projectSerial
            // 
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            projectSerial.DefaultCellStyle = dataGridViewCellStyle4;
            projectSerial.HeaderText = "專案序號";
            projectSerial.Name = "projectSerial";
            projectSerial.ReadOnly = true;
            // 
            // eqpModel
            // 
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            eqpModel.DefaultCellStyle = dataGridViewCellStyle5;
            eqpModel.HeaderText = "機台型號";
            eqpModel.Name = "eqpModel";
            eqpModel.ReadOnly = true;
            // 
            // eqpName
            // 
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            eqpName.DefaultCellStyle = dataGridViewCellStyle6;
            eqpName.HeaderText = "機台名稱";
            eqpName.Name = "eqpName";
            eqpName.ReadOnly = true;
            // 
            // carType
            // 
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            carType.DefaultCellStyle = dataGridViewCellStyle7;
            carType.HeaderText = "訴願類別";
            carType.Name = "carType";
            carType.ReadOnly = true;
            // 
            // carContent
            // 
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            carContent.DefaultCellStyle = dataGridViewCellStyle8;
            carContent.HeaderText = "訴求內容";
            carContent.Name = "carContent";
            carContent.ReadOnly = true;
            // 
            // solution
            // 
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            solution.DefaultCellStyle = dataGridViewCellStyle9;
            solution.HeaderText = "解決對策";
            solution.Name = "solution";
            solution.ReadOnly = true;
            // 
            // replyDate
            // 
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.True;
            replyDate.DefaultCellStyle = dataGridViewCellStyle10;
            replyDate.HeaderText = "回覆日期";
            replyDate.Name = "replyDate";
            replyDate.ReadOnly = true;
            // 
            // customerReaction
            // 
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.True;
            customerReaction.DefaultCellStyle = dataGridViewCellStyle11;
            customerReaction.HeaderText = "客戶反映";
            customerReaction.Name = "customerReaction";
            customerReaction.ReadOnly = true;
            // 
            // satisfacation
            // 
            dataGridViewCellStyle12.WrapMode = DataGridViewTriState.True;
            satisfacation.DefaultCellStyle = dataGridViewCellStyle12;
            satisfacation.HeaderText = "滿意度評分";
            satisfacation.Name = "satisfacation";
            satisfacation.ReadOnly = true;
            // 
            // CARControl
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PeachPuff;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            Name = "CARControl";
            Size = new Size(1567, 839);
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
        private DigiERP.Common.CommonComboBox cboCustId;
        private Label label2;
        private DataGridView dataGridView1;
        private Button btn回覆記錄登載;
        private DataGridViewTextBoxColumn orderNo;
        private DataGridViewTextBoxColumn date;
        private DataGridViewTextBoxColumn custId;
        private DataGridViewTextBoxColumn projectSerial;
        private DataGridViewTextBoxColumn eqpModel;
        private DataGridViewTextBoxColumn eqpName;
        private DataGridViewTextBoxColumn carType;
        private DataGridViewTextBoxColumn carContent;
        private DataGridViewTextBoxColumn solution;
        private DataGridViewTextBoxColumn replyDate;
        private DataGridViewTextBoxColumn customerReaction;
        private DataGridViewTextBoxColumn satisfacation;
        private Button btn重新整理;
    }
}
