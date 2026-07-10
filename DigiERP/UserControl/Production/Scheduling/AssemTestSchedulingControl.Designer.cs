using System.Drawing;
using System.Windows.Forms;

namespace DigiERP.UserControl.Production
{
    partial class AssemTestSchedulingControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AssemTestSchedulingControl));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            lblTitle = new Label();
            lblWeek1 = new Label();
            lblWeek2 = new Label();
            lblWeek3 = new Label();
            lblWeek4 = new Label();
            btnExit = new Button();
            panel3 = new Panel();
            dataGridView2 = new DataGridView();
            colSumLabel = new DataGridViewTextBoxColumn();
            colSumWeek1 = new DataGridViewTextBoxColumn();
            colSumWeek2 = new DataGridViewTextBoxColumn();
            colSumWeek3 = new DataGridViewTextBoxColumn();
            colSumWeek4 = new DataGridViewTextBoxColumn();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            colProjectNo = new DataGridViewTextBoxColumn();
            colModuleCode = new DataGridViewTextBoxColumn();
            colPartNo = new DataGridViewTextBoxColumn();
            colPartName = new DataGridViewTextBoxColumn();
            colPartType = new DataGridViewTextBoxColumn();
            colAcceptance = new DataGridViewTextBoxColumn();
            colControlNo = new DataGridViewTextBoxColumn();
            colWeek1P = new DataGridViewTextBoxColumn();
            colWeek1W = new DataGridViewTextBoxColumn();
            colWeek2P = new DataGridViewTextBoxColumn();
            colWeek2W = new DataGridViewTextBoxColumn();
            colWeek3P = new DataGridViewTextBoxColumn();
            colWeek3W = new DataGridViewTextBoxColumn();
            colWeek4P = new DataGridViewTextBoxColumn();
            colWeek4W = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            //
            // panel1
            //
            panel1.BackColor = Color.PaleGreen;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(lblTitle);
            panel1.Controls.Add(lblWeek1);
            panel1.Controls.Add(lblWeek2);
            panel1.Controls.Add(lblWeek3);
            panel1.Controls.Add(lblWeek4);
            panel1.Controls.Add(btnExit);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1900, 56);
            panel1.TabIndex = 0;
            //
            // pictureBox1
            //
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(4, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(68, 48);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            //
            // lblTitle
            //
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("微軟正黑體", 14F, FontStyle.Bold);
            lblTitle.Location = new Point(80, 16);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(146, 24);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "週排程-組裝測試";
            //
            // lblWeek1
            //
            lblWeek1.BackColor = Color.PaleGreen;
            lblWeek1.Font = new Font("微軟正黑體", 9F);
            lblWeek1.Location = new Point(1100, 28);
            lblWeek1.Name = "lblWeek1";
            lblWeek1.Size = new Size(196, 26);
            lblWeek1.TabIndex = 1;
            lblWeek1.TextAlign = ContentAlignment.MiddleCenter;
            //
            // lblWeek2
            //
            lblWeek2.BackColor = Color.PaleGreen;
            lblWeek2.Font = new Font("微軟正黑體", 9F);
            lblWeek2.Location = new Point(1296, 28);
            lblWeek2.Name = "lblWeek2";
            lblWeek2.Size = new Size(196, 26);
            lblWeek2.TabIndex = 2;
            lblWeek2.TextAlign = ContentAlignment.MiddleCenter;
            //
            // lblWeek3
            //
            lblWeek3.BackColor = Color.PaleGreen;
            lblWeek3.Font = new Font("微軟正黑體", 9F);
            lblWeek3.Location = new Point(1492, 28);
            lblWeek3.Name = "lblWeek3";
            lblWeek3.Size = new Size(196, 26);
            lblWeek3.TabIndex = 3;
            lblWeek3.TextAlign = ContentAlignment.MiddleCenter;
            //
            // lblWeek4
            //
            lblWeek4.BackColor = Color.PaleGreen;
            lblWeek4.Font = new Font("微軟正黑體", 9F);
            lblWeek4.Location = new Point(1688, 28);
            lblWeek4.Name = "lblWeek4";
            lblWeek4.Size = new Size(196, 26);
            lblWeek4.TabIndex = 4;
            lblWeek4.TextAlign = ContentAlignment.MiddleCenter;
            //
            // btnExit
            //
            btnExit.BackColor = Color.LightSteelBlue;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            btnExit.Location = new Point(1780, 12);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(110, 32);
            btnExit.TabIndex = 5;
            btnExit.Text = "EXIT";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Visible = false;
            btnExit.Click += btnExit_Click;
            //
            // panel3
            //
            panel3.BackColor = Color.PaleGreen;
            panel3.Controls.Add(dataGridView2);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 500);
            panel3.Name = "panel3";
            panel3.Size = new Size(1900, 156);
            panel3.TabIndex = 2;
            //
            // dataGridView2
            //
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.BackgroundColor = Color.White;
            dataGridView2.ColumnHeadersVisible = false;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { colSumLabel, colSumWeek1, colSumWeek2, colSumWeek3, colSumWeek4 });
            dataGridView2.Font = new Font("微軟正黑體", 9F);
            dataGridView2.Location = new Point(656, 8);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.RowHeadersVisible = false;
            dataGridView2.RowTemplate.Height = 26;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.Size = new Size(1088, 96);
            dataGridView2.TabIndex = 0;
            //
            // colSumLabel
            //
            colSumLabel.FillWeight = 130F;
            colSumLabel.HeaderText = "";
            colSumLabel.Name = "colSumLabel";
            colSumLabel.ReadOnly = true;
            //
            // colSumWeek1
            //
            colSumWeek1.HeaderText = "第一週";
            colSumWeek1.Name = "colSumWeek1";
            colSumWeek1.ReadOnly = true;
            //
            // colSumWeek2
            //
            colSumWeek2.HeaderText = "第二週";
            colSumWeek2.Name = "colSumWeek2";
            colSumWeek2.ReadOnly = true;
            //
            // colSumWeek3
            //
            colSumWeek3.HeaderText = "第三週";
            colSumWeek3.Name = "colSumWeek3";
            colSumWeek3.ReadOnly = true;
            //
            // colSumWeek4
            //
            colSumWeek4.HeaderText = "第四週";
            colSumWeek4.Name = "colSumWeek4";
            colSumWeek4.ReadOnly = true;
            //
            // panel2
            //
            panel2.Controls.Add(dataGridView1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 56);
            panel2.Name = "panel2";
            panel2.Size = new Size(1900, 444);
            panel2.TabIndex = 1;
            //
            // dataGridView1
            //
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colProjectNo, colModuleCode, colPartNo, colPartName, colPartType, colAcceptance, colControlNo, colWeek1P, colWeek1W, colWeek2P, colWeek2W, colWeek3P, colWeek3W, colWeek4P, colWeek4W });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Font = new Font("微軟正黑體", 9F);
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 26;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1900, 444);
            dataGridView1.TabIndex = 0;
            //
            // colProjectNo
            //
            colProjectNo.HeaderText = "專案序號";
            colProjectNo.Name = "colProjectNo";
            colProjectNo.ReadOnly = true;
            //
            // colModuleCode
            //
            colModuleCode.HeaderText = "模組";
            colModuleCode.Name = "colModuleCode";
            colModuleCode.ReadOnly = true;
            //
            // colPartNo
            //
            colPartNo.HeaderText = "零件號碼";
            colPartNo.Name = "colPartNo";
            colPartNo.ReadOnly = true;
            //
            // colPartName
            //
            colPartName.FillWeight = 130F;
            colPartName.HeaderText = "品名";
            colPartName.Name = "colPartName";
            colPartName.ReadOnly = true;
            //
            // colPartType
            //
            colPartType.HeaderText = "零件分類";
            colPartType.Name = "colPartType";
            colPartType.ReadOnly = true;
            //
            // colAcceptance
            //
            colAcceptance.HeaderText = "驗收合格";
            colAcceptance.Name = "colAcceptance";
            colAcceptance.ReadOnly = true;
            //
            // colControlNo
            //
            colControlNo.HeaderText = "零件管制單號";
            colControlNo.Name = "colControlNo";
            colControlNo.ReadOnly = true;
            //
            // colWeek1P
            //
            colWeek1P.HeaderText = "進料排程";
            colWeek1P.Name = "colWeek1P";
            colWeek1P.ReadOnly = true;
            //
            // colWeek1W
            //
            colWeek1W.HeaderText = "加工排程";
            colWeek1W.Name = "colWeek1W";
            colWeek1W.ReadOnly = true;
            //
            // colWeek2P
            //
            colWeek2P.HeaderText = "進料排程";
            colWeek2P.Name = "colWeek2P";
            colWeek2P.ReadOnly = true;
            //
            // colWeek2W
            //
            colWeek2W.HeaderText = "加工排程";
            colWeek2W.Name = "colWeek2W";
            colWeek2W.ReadOnly = true;
            //
            // colWeek3P
            //
            colWeek3P.HeaderText = "進料排程";
            colWeek3P.Name = "colWeek3P";
            colWeek3P.ReadOnly = true;
            //
            // colWeek3W
            //
            colWeek3W.HeaderText = "加工排程";
            colWeek3W.Name = "colWeek3W";
            colWeek3W.ReadOnly = true;
            //
            // colWeek4P
            //
            colWeek4P.HeaderText = "進料排程";
            colWeek4P.Name = "colWeek4P";
            colWeek4P.ReadOnly = true;
            //
            // colWeek4W
            //
            colWeek4W.HeaderText = "加工排程";
            colWeek4W.Name = "colWeek4W";
            colWeek4W.ReadOnly = true;
            //
            // AssemTestSchedulingControl
            //
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Font = new Font("微軟正黑體", 10F);
            Margin = new Padding(4);
            Name = "AssemTestSchedulingControl";
            Size = new Size(1900, 656);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label lblTitle;
        private Label lblWeek1;
        private Label lblWeek2;
        private Label lblWeek3;
        private Label lblWeek4;
        private Button btnExit;
        private Panel panel2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn colProjectNo;
        private DataGridViewTextBoxColumn colModuleCode;
        private DataGridViewTextBoxColumn colPartNo;
        private DataGridViewTextBoxColumn colPartName;
        private DataGridViewTextBoxColumn colPartType;
        private DataGridViewTextBoxColumn colAcceptance;
        private DataGridViewTextBoxColumn colControlNo;
        private DataGridViewTextBoxColumn colWeek1P;
        private DataGridViewTextBoxColumn colWeek1W;
        private DataGridViewTextBoxColumn colWeek2P;
        private DataGridViewTextBoxColumn colWeek2W;
        private DataGridViewTextBoxColumn colWeek3P;
        private DataGridViewTextBoxColumn colWeek3W;
        private DataGridViewTextBoxColumn colWeek4P;
        private DataGridViewTextBoxColumn colWeek4W;
        private Panel panel3;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn colSumLabel;
        private DataGridViewTextBoxColumn colSumWeek1;
        private DataGridViewTextBoxColumn colSumWeek2;
        private DataGridViewTextBoxColumn colSumWeek3;
        private DataGridViewTextBoxColumn colSumWeek4;
    }
}
