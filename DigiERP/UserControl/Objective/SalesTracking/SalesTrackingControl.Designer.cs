using System.Drawing;
using System.Windows.Forms;

namespace DigiERP.UserControl.Objective.SalesTracking
{
    partial class SalesTrackingControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesTrackingControl));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            lblTitle = new Label();
            dtStart = new DateTimePicker();
            lblTilde = new Label();
            dtEnd = new DateTimePicker();
            btnReview = new Button();
            btnReset = new Button();
            btnExit = new Button();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            colCustomer = new DataGridViewTextBoxColumn();
            colCountry = new DataGridViewTextBoxColumn();
            colYear = new DataGridViewTextBoxColumn();
            colContactCount = new DataGridViewTextBoxColumn();
            colRfqCount = new DataGridViewTextBoxColumn();
            colRfqContactCount = new DataGridViewTextBoxColumn();
            colQuoteCount = new DataGridViewTextBoxColumn();
            colCurrency = new DataGridViewTextBoxColumn();
            colExRate = new DataGridViewTextBoxColumn();
            colQuoteOrigAmt = new DataGridViewTextBoxColumn();
            colQuoteTwdAmt = new DataGridViewTextBoxColumn();
            colOrderCount = new DataGridViewTextBoxColumn();
            colOrderOrigAmt = new DataGridViewTextBoxColumn();
            colOrderTwdAmt = new DataGridViewTextBoxColumn();
            colQtyRate = new DataGridViewTextBoxColumn();
            colAmtRate = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(lblTitle);
            panel1.Controls.Add(dtStart);
            panel1.Controls.Add(lblTilde);
            panel1.Controls.Add(dtEnd);
            panel1.Controls.Add(btnReview);
            panel1.Controls.Add(btnReset);
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
            pictureBox1.Size = new Size(48, 48);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("微軟正黑體", 14F, FontStyle.Bold);
            lblTitle.Location = new Point(60, 16);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(143, 24);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "客戶活動力分析";
            // 
            // dtStart
            // 
            dtStart.Format = DateTimePickerFormat.Short;
            dtStart.Location = new Point(400, 14);
            dtStart.Name = "dtStart";
            dtStart.Size = new Size(140, 25);
            dtStart.TabIndex = 1;
            // 
            // lblTilde
            // 
            lblTilde.AutoSize = true;
            lblTilde.Font = new Font("微軟正黑體", 12F, FontStyle.Bold);
            lblTilde.Location = new Point(546, 16);
            lblTilde.Name = "lblTilde";
            lblTilde.Size = new Size(22, 21);
            lblTilde.TabIndex = 2;
            lblTilde.Text = "~";
            // 
            // dtEnd
            // 
            dtEnd.Format = DateTimePickerFormat.Short;
            dtEnd.Location = new Point(572, 14);
            dtEnd.Name = "dtEnd";
            dtEnd.Size = new Size(140, 25);
            dtEnd.TabIndex = 3;
            // 
            // btnReview
            // 
            btnReview.BackColor = Color.DimGray;
            btnReview.FlatStyle = FlatStyle.Flat;
            btnReview.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            btnReview.ForeColor = Color.White;
            btnReview.Location = new Point(760, 12);
            btnReview.Name = "btnReview";
            btnReview.Size = new Size(110, 32);
            btnReview.TabIndex = 4;
            btnReview.Text = "REVIEW";
            btnReview.UseVisualStyleBackColor = false;
            btnReview.Click += btnReview_Click;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.DimGray;
            btnReset.FlatStyle = FlatStyle.Flat;
            btnReset.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            btnReset.ForeColor = Color.White;
            btnReset.Location = new Point(890, 12);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(110, 32);
            btnReset.TabIndex = 5;
            btnReset.Text = "RESET";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.DimGray;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            btnExit.ForeColor = Color.White;
            btnExit.Location = new Point(1020, 12);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(110, 32);
            btnExit.TabIndex = 6;
            btnExit.Text = "EXIT";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridView1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 56);
            panel2.Name = "panel2";
            panel2.Size = new Size(1900, 600);
            panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colCustomer, colCountry, colYear, colContactCount, colRfqCount, colRfqContactCount, colQuoteCount, colCurrency, colExRate, colQuoteOrigAmt, colQuoteTwdAmt, colOrderCount, colOrderOrigAmt, colOrderTwdAmt, colQtyRate, colAmtRate });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Font = new Font("微軟正黑體", 9F);
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 26;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1900, 600);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // colCustomer
            // 
            colCustomer.FillWeight = 180F;
            colCustomer.HeaderText = "客戶";
            colCustomer.Name = "colCustomer";
            colCustomer.ReadOnly = true;
            // 
            // colCountry
            // 
            colCountry.HeaderText = "國別";
            colCountry.Name = "colCountry";
            colCountry.ReadOnly = true;
            // 
            // colYear
            // 
            colYear.HeaderText = "建檔年度";
            colYear.Name = "colYear";
            colYear.ReadOnly = true;
            // 
            // colContactCount
            // 
            colContactCount.HeaderText = "連絡次數";
            colContactCount.Name = "colContactCount";
            colContactCount.ReadOnly = true;
            // 
            // colRfqCount
            // 
            colRfqCount.HeaderText = "詢問函筆數";
            colRfqCount.Name = "colRfqCount";
            colRfqCount.ReadOnly = true;
            // 
            // colRfqContactCount
            // 
            colRfqContactCount.HeaderText = "詢問往來次數";
            colRfqContactCount.Name = "colRfqContactCount";
            colRfqContactCount.ReadOnly = true;
            // 
            // colQuoteCount
            // 
            colQuoteCount.HeaderText = "報價單筆數";
            colQuoteCount.Name = "colQuoteCount";
            colQuoteCount.ReadOnly = true;
            // 
            // colCurrency
            // 
            colCurrency.HeaderText = "幣別";
            colCurrency.Name = "colCurrency";
            colCurrency.ReadOnly = true;
            // 
            // colExRate
            // 
            colExRate.HeaderText = "匯率";
            colExRate.Name = "colExRate";
            colExRate.ReadOnly = true;
            // 
            // colQuoteOrigAmt
            // 
            colQuoteOrigAmt.HeaderText = "報價原幣金額";
            colQuoteOrigAmt.Name = "colQuoteOrigAmt";
            colQuoteOrigAmt.ReadOnly = true;
            // 
            // colQuoteTwdAmt
            // 
            colQuoteTwdAmt.HeaderText = "報價台幣金額";
            colQuoteTwdAmt.Name = "colQuoteTwdAmt";
            colQuoteTwdAmt.ReadOnly = true;
            // 
            // colOrderCount
            // 
            colOrderCount.HeaderText = "訂單筆數";
            colOrderCount.Name = "colOrderCount";
            colOrderCount.ReadOnly = true;
            // 
            // colOrderOrigAmt
            // 
            colOrderOrigAmt.HeaderText = "訂單原幣金額";
            colOrderOrigAmt.Name = "colOrderOrigAmt";
            colOrderOrigAmt.ReadOnly = true;
            // 
            // colOrderTwdAmt
            // 
            colOrderTwdAmt.HeaderText = "訂單台幣金額";
            colOrderTwdAmt.Name = "colOrderTwdAmt";
            colOrderTwdAmt.ReadOnly = true;
            // 
            // colQtyRate
            // 
            colQtyRate.HeaderText = "單數成交率";
            colQtyRate.Name = "colQtyRate";
            colQtyRate.ReadOnly = true;
            // 
            // colAmtRate
            // 
            colAmtRate.HeaderText = "金額成交率";
            colAmtRate.Name = "colAmtRate";
            colAmtRate.ReadOnly = true;
            // 
            // SalesTrackingControl
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("微軟正黑體", 10F);
            Margin = new Padding(4);
            Name = "SalesTrackingControl";
            Size = new Size(1900, 656);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label lblTitle;
        private DateTimePicker dtStart;
        private Label lblTilde;
        private DateTimePicker dtEnd;
        private Button btnReview;
        private Button btnReset;
        private Button btnExit;
        private Panel panel2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn colCustomer;
        private DataGridViewTextBoxColumn colCountry;
        private DataGridViewTextBoxColumn colYear;
        private DataGridViewTextBoxColumn colContactCount;
        private DataGridViewTextBoxColumn colRfqCount;
        private DataGridViewTextBoxColumn colRfqContactCount;
        private DataGridViewTextBoxColumn colQuoteCount;
        private DataGridViewTextBoxColumn colCurrency;
        private DataGridViewTextBoxColumn colExRate;
        private DataGridViewTextBoxColumn colQuoteOrigAmt;
        private DataGridViewTextBoxColumn colQuoteTwdAmt;
        private DataGridViewTextBoxColumn colOrderCount;
        private DataGridViewTextBoxColumn colOrderOrigAmt;
        private DataGridViewTextBoxColumn colOrderTwdAmt;
        private DataGridViewTextBoxColumn colQtyRate;
        private DataGridViewTextBoxColumn colAmtRate;
    }
}
