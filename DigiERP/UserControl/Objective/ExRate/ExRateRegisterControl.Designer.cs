using System.Drawing;
using System.Windows.Forms;

namespace DigiERP.UserControl.Objective.ExRate
{
    partial class ExRateRegisterControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExRateRegisterControl));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            lblTitle = new Label();
            btnPrev = new Button();
            btnNext = new Button();
            btnExit = new Button();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colDate = new DigiERP.Common.DataGridViewDateTimePickerColumn();
            colRate = new DataGridViewTextBoxColumn();
            txtCurrency = new TextBox();
            lblCurrencyCap = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.MistyRose;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(lblTitle);
            panel1.Controls.Add(btnPrev);
            panel1.Controls.Add(btnNext);
            panel1.Controls.Add(btnExit);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(400, 56);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(4, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(48, 48);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("微軟正黑體", 14F, FontStyle.Bold);
            lblTitle.ForeColor = Color.Black;
            lblTitle.Location = new Point(60, 16);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(86, 24);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "匯率設定";
            // 
            // btnPrev
            // 
            btnPrev.BackColor = Color.LightSteelBlue;
            btnPrev.FlatStyle = FlatStyle.Flat;
            btnPrev.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            btnPrev.Location = new Point(200, 12);
            btnPrev.Name = "btnPrev";
            btnPrev.Size = new Size(48, 32);
            btnPrev.TabIndex = 1;
            btnPrev.Text = "◄";
            btnPrev.UseVisualStyleBackColor = false;
            btnPrev.Click += btnPrev_Click;
            // 
            // btnNext
            // 
            btnNext.BackColor = Color.LightSteelBlue;
            btnNext.FlatStyle = FlatStyle.Flat;
            btnNext.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            btnNext.Location = new Point(254, 12);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(48, 32);
            btnNext.TabIndex = 2;
            btnNext.Text = "►";
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.SteelBlue;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            btnExit.ForeColor = Color.White;
            btnExit.Location = new Point(340, 12);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(48, 32);
            btnExit.TabIndex = 3;
            btnExit.Text = "✕";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Visible = false;
            btnExit.Click += btnExit_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(dataGridView1);
            panel2.Controls.Add(txtCurrency);
            panel2.Controls.Add(lblCurrencyCap);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 56);
            panel2.Name = "panel2";
            panel2.Size = new Size(400, 544);
            panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colId, colDate, colRate });
            dataGridView1.Location = new Point(16, 56);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 30;
            dataGridView1.RowTemplate.Height = 28;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataGridView1.Size = new Size(360, 460);
            dataGridView1.TabIndex = 2;
            dataGridView1.CurrentCellDirtyStateChanged += dataGridView1_CurrentCellDirtyStateChanged;
            dataGridView1.CellValueChanged += dataGridView1_CellValueChanged;
            dataGridView1.RowValidated += dataGridView1_RowValidated;
            // 
            // colId
            // 
            colId.HeaderText = "識別";
            colId.Name = "colId";
            colId.Visible = false;
            // 
            // colDate
            // 
            colDate.HeaderText = "日期";
            colDate.Name = "colDate";
            // 
            // colRate
            // 
            colRate.HeaderText = "匯率";
            colRate.Name = "colRate";
            // 
            // txtCurrency
            // 
            txtCurrency.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            txtCurrency.Location = new Point(140, 16);
            txtCurrency.Name = "txtCurrency";
            txtCurrency.ReadOnly = true;
            txtCurrency.Size = new Size(220, 25);
            txtCurrency.TabIndex = 1;
            txtCurrency.TextAlign = HorizontalAlignment.Center;
            // 
            // lblCurrencyCap
            // 
            lblCurrencyCap.AutoSize = true;
            lblCurrencyCap.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            lblCurrencyCap.ForeColor = Color.Navy;
            lblCurrencyCap.Location = new Point(16, 20);
            lblCurrencyCap.Name = "lblCurrencyCap";
            lblCurrencyCap.Size = new Size(84, 18);
            lblCurrencyCap.TabIndex = 0;
            lblCurrencyCap.Text = "CURRENCY";
            // 
            // ExRateRegisterControl
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("微軟正黑體", 10F);
            Margin = new Padding(4);
            Name = "ExRateRegisterControl";
            Size = new Size(400, 600);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label lblTitle;
        private Button btnPrev;
        private Button btnNext;
        private Button btnExit;
        private Panel panel2;
        private Label lblCurrencyCap;
        private TextBox txtCurrency;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn colId;
        private DigiERP.Common.DataGridViewDateTimePickerColumn colDate;
        private DataGridViewTextBoxColumn colRate;
    }
}
