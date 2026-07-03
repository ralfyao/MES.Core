namespace DigiERP.UserControl.Inventory
{
    partial class PartsControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PartsControl));
            panel1 = new Panel();
            button1 = new Button();
            btn新增同級料品支援 = new Button();
            btn加工材料代號新增 = new Button();
            btn未核准品項清單 = new Button();
            btnQueryByPartDesc = new Button();
            pictureBox1 = new PictureBox();
            lblTitle = new Label();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            colNo = new DataGridViewTextBoxColumn();
            colType = new DataGridViewTextBoxColumn();
            colSource = new DataGridViewTextBoxColumn();
            colCategory = new DataGridViewTextBoxColumn();
            colSubCategory = new DataGridViewTextBoxColumn();
            colProductCode = new DataGridViewTextBoxColumn();
            colSpec = new DataGridViewTextBoxColumn();
            colLength = new DataGridViewTextBoxColumn();
            colWidth = new DataGridViewTextBoxColumn();
            colThickness = new DataGridViewTextBoxColumn();
            colInnerDia = new DataGridViewTextBoxColumn();
            colOuterDia = new DataGridViewTextBoxColumn();
            colStockInTotal = new DataGridViewTextBoxColumn();
            colStockOutTotal = new DataGridViewTextBoxColumn();
            colCardCount = new DataGridViewTextBoxColumn();
            colBalance = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 255, 192);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(btn新增同級料品支援);
            panel1.Controls.Add(btn加工材料代號新增);
            panel1.Controls.Add(btn未核准品項清單);
            panel1.Controls.Add(btnQueryByPartDesc);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(lblTitle);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1497, 76);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(224, 224, 224);
            button1.Location = new Point(884, 16);
            button1.Name = "button1";
            button1.Size = new Size(132, 36);
            button1.TabIndex = 6;
            button1.Text = "新增料品";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            //
            // btn新增同級料品支援
            // 
            btn新增同級料品支援.BackColor = Color.FromArgb(0, 192, 0);
            btn新增同級料品支援.ForeColor = SystemColors.ButtonHighlight;
            btn新增同級料品支援.Location = new Point(711, 16);
            btn新增同級料品支援.Name = "btn新增同級料品支援";
            btn新增同級料品支援.Size = new Size(161, 36);
            btn新增同級料品支援.TabIndex = 5;
            btn新增同級料品支援.Text = "新增同級料品支援";
            btn新增同級料品支援.UseVisualStyleBackColor = false;
            // 
            // btn加工材料代號新增
            // 
            btn加工材料代號新增.BackColor = Color.FromArgb(192, 255, 255);
            btn加工材料代號新增.Location = new Point(548, 16);
            btn加工材料代號新增.Name = "btn加工材料代號新增";
            btn加工材料代號新增.Size = new Size(148, 36);
            btn加工材料代號新增.TabIndex = 4;
            btn加工材料代號新增.Text = "加工材料代號新增";
            btn加工材料代號新增.UseVisualStyleBackColor = false;
            btn加工材料代號新增.Click += btn加工材料代號新增_Click;
            // 
            // btn未核准品項清單
            // 
            btn未核准品項清單.BackColor = Color.FromArgb(192, 255, 192);
            btn未核准品項清單.Location = new Point(404, 16);
            btn未核准品項清單.Name = "btn未核准品項清單";
            btn未核准品項清單.Size = new Size(132, 36);
            btn未核准品項清單.TabIndex = 3;
            btn未核准品項清單.Text = "未核准品項清單";
            btn未核准品項清單.UseVisualStyleBackColor = false;
            btn未核准品項清單.Click += btn未核准品項清單_Click;
            // 
            // btnQueryByPartDesc
            // 
            btnQueryByPartDesc.BackColor = Color.FromArgb(255, 192, 192);
            btnQueryByPartDesc.Location = new Point(296, 16);
            btnQueryByPartDesc.Name = "btnQueryByPartDesc";
            btnQueryByPartDesc.Size = new Size(92, 36);
            btnQueryByPartDesc.TabIndex = 2;
            btnQueryByPartDesc.Text = "品名搜尋";
            btnQueryByPartDesc.UseVisualStyleBackColor = false;
            btnQueryByPartDesc.Click += btnQueryByPartDesc_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(8, 8);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(72, 60);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("微軟正黑體", 18F, FontStyle.Bold);
            lblTitle.Location = new Point(92, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(196, 32);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "材料庫存查詢";
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridView1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 76);
            panel2.Name = "panel2";
            panel2.Size = new Size(1497, 600);
            panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colNo, colType, colSource, colCategory, colSubCategory, colProductCode, colSpec, colLength, colWidth, colThickness, colInnerDia, colOuterDia, colStockInTotal, colStockOutTotal, colCardCount, colBalance });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Font = new Font("微軟正黑體", 10F);
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 28;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1497, 600);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            dataGridView1.VisibleChanged += dataGridView1_VisibleChanged;
            // 
            // colNo
            // 
            colNo.FillWeight = 80F;
            colNo.HeaderText = "料品編號";
            colNo.Name = "colNo";
            colNo.ReadOnly = true;
            // 
            // colType
            // 
            colType.FillWeight = 60F;
            colType.HeaderText = "品別";
            colType.Name = "colType";
            colType.ReadOnly = true;
            // 
            // colSource
            // 
            colSource.FillWeight = 60F;
            colSource.HeaderText = "來源";
            colSource.Name = "colSource";
            colSource.ReadOnly = true;
            // 
            // colCategory
            // 
            colCategory.FillWeight = 60F;
            colCategory.HeaderText = "大分類";
            colCategory.Name = "colCategory";
            colCategory.ReadOnly = true;
            // 
            // colSubCategory
            // 
            colSubCategory.FillWeight = 60F;
            colSubCategory.HeaderText = "小分類";
            colSubCategory.Name = "colSubCategory";
            colSubCategory.ReadOnly = true;
            // 
            // colProductCode
            // 
            colProductCode.FillWeight = 80F;
            colProductCode.HeaderText = "材料產品代號";
            colProductCode.Name = "colProductCode";
            colProductCode.ReadOnly = true;
            // 
            // colSpec
            // 
            colSpec.FillWeight = 160F;
            colSpec.HeaderText = "品名規格";
            colSpec.Name = "colSpec";
            colSpec.ReadOnly = true;
            // 
            // colLength
            // 
            colLength.FillWeight = 50F;
            colLength.HeaderText = "長";
            colLength.Name = "colLength";
            colLength.ReadOnly = true;
            // 
            // colWidth
            // 
            colWidth.FillWeight = 50F;
            colWidth.HeaderText = "寬";
            colWidth.Name = "colWidth";
            colWidth.ReadOnly = true;
            // 
            // colThickness
            // 
            colThickness.FillWeight = 50F;
            colThickness.HeaderText = "厚度";
            colThickness.Name = "colThickness";
            colThickness.ReadOnly = true;
            // 
            // colInnerDia
            // 
            colInnerDia.FillWeight = 50F;
            colInnerDia.HeaderText = "內徑";
            colInnerDia.Name = "colInnerDia";
            colInnerDia.ReadOnly = true;
            // 
            // colOuterDia
            // 
            colOuterDia.FillWeight = 50F;
            colOuterDia.HeaderText = "外徑";
            colOuterDia.Name = "colOuterDia";
            colOuterDia.ReadOnly = true;
            // 
            // colStockInTotal
            // 
            colStockInTotal.FillWeight = 70F;
            colStockInTotal.HeaderText = "入庫總計";
            colStockInTotal.Name = "colStockInTotal";
            colStockInTotal.ReadOnly = true;
            // 
            // colStockOutTotal
            // 
            colStockOutTotal.FillWeight = 70F;
            colStockOutTotal.HeaderText = "出庫總計";
            colStockOutTotal.Name = "colStockOutTotal";
            colStockOutTotal.ReadOnly = true;
            // 
            // colCardCount
            // 
            colCardCount.FillWeight = 70F;
            colCardCount.HeaderText = "庫存卡筆數";
            colCardCount.Name = "colCardCount";
            colCardCount.ReadOnly = true;
            // 
            // colBalance
            // 
            colBalance.FillWeight = 70F;
            colBalance.HeaderText = "結餘";
            colBalance.Name = "colBalance";
            colBalance.ReadOnly = true;
            // 
            // PartsControl
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("微軟正黑體", 10F);
            Margin = new Padding(4);
            Name = "PartsControl";
            Size = new Size(1497, 676);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblTitle;
        private Panel panel2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn colNo;
        private DataGridViewTextBoxColumn colType;
        private DataGridViewTextBoxColumn colSource;
        private DataGridViewTextBoxColumn colCategory;
        private DataGridViewTextBoxColumn colSubCategory;
        private DataGridViewTextBoxColumn colProductCode;
        private DataGridViewTextBoxColumn colSpec;
        private DataGridViewTextBoxColumn colLength;
        private DataGridViewTextBoxColumn colWidth;
        private DataGridViewTextBoxColumn colThickness;
        private DataGridViewTextBoxColumn colInnerDia;
        private DataGridViewTextBoxColumn colOuterDia;
        private DataGridViewTextBoxColumn colStockInTotal;
        private DataGridViewTextBoxColumn colStockOutTotal;
        private DataGridViewTextBoxColumn colCardCount;
        private DataGridViewTextBoxColumn colBalance;
        private PictureBox pictureBox1;
        private Button btn未核准品項清單;
        private Button btnQueryByPartDesc;
        private Button btn加工材料代號新增;
        private Button btn新增同級料品支援;
        private Button button1;
    }
}
