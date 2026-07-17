using System.Drawing;
using System.Windows.Forms;

namespace DigiERP.UserControl.Objective.ARWriteOff
{
    partial class FrmARImport
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
            panel1 = new Panel();
            btnFilter = new Button();
            dtFrom = new DateTimePicker();
            lblTilde = new Label();
            dtTo = new DateTimePicker();
            btnConfirm = new Button();
            btnClose = new Button();
            dataGridView1 = new DataGridView();
            colSource = new DataGridViewTextBoxColumn();
            colAccDate = new DataGridViewTextBoxColumn();
            colDocType = new DataGridViewTextBoxColumn();
            colOffsetCode = new DataGridViewTextBoxColumn();
            colInvoiceNo = new DataGridViewTextBoxColumn();
            colTerm = new DataGridViewTextBoxColumn();
            colCheck = new DataGridViewCheckBoxColumn();
            colCurrency = new DataGridViewTextBoxColumn();
            colOrigUntaxed = new DataGridViewTextBoxColumn();
            colTwdUntaxed = new DataGridViewTextBoxColumn();
            colTax = new DataGridViewTextBoxColumn();
            colAmount = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            //
            // panel1
            //
            panel1.BackColor = Color.Cornsilk;
            panel1.Controls.Add(btnFilter);
            panel1.Controls.Add(dtFrom);
            panel1.Controls.Add(lblTilde);
            panel1.Controls.Add(dtTo);
            panel1.Controls.Add(btnConfirm);
            panel1.Controls.Add(btnClose);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1200, 52);
            panel1.TabIndex = 0;
            //
            // btnFilter
            //
            btnFilter.BackColor = Color.SteelBlue;
            btnFilter.FlatStyle = FlatStyle.Flat;
            btnFilter.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            btnFilter.ForeColor = Color.White;
            btnFilter.Location = new Point(10, 10);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(120, 32);
            btnFilter.TabIndex = 0;
            btnFilter.Text = "日期區間篩選";
            btnFilter.UseVisualStyleBackColor = false;
            btnFilter.Click += btnFilter_Click;
            //
            // dtFrom
            //
            dtFrom.Format = DateTimePickerFormat.Short;
            dtFrom.Location = new Point(140, 14);
            dtFrom.Name = "dtFrom";
            dtFrom.ShowCheckBox = true;
            dtFrom.Checked = false;
            dtFrom.Size = new Size(130, 25);
            dtFrom.TabIndex = 1;
            //
            // lblTilde
            //
            lblTilde.AutoSize = true;
            lblTilde.Location = new Point(276, 18);
            lblTilde.Name = "lblTilde";
            lblTilde.Size = new Size(16, 18);
            lblTilde.TabIndex = 2;
            lblTilde.Text = "~";
            //
            // dtTo
            //
            dtTo.Format = DateTimePickerFormat.Short;
            dtTo.Location = new Point(298, 14);
            dtTo.Name = "dtTo";
            dtTo.ShowCheckBox = true;
            dtTo.Checked = false;
            dtTo.Size = new Size(130, 25);
            dtTo.TabIndex = 3;
            //
            // btnConfirm
            //
            btnConfirm.BackColor = Color.SeaGreen;
            btnConfirm.FlatStyle = FlatStyle.Flat;
            btnConfirm.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            btnConfirm.ForeColor = Color.White;
            btnConfirm.Location = new Point(990, 10);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(100, 32);
            btnConfirm.TabIndex = 4;
            btnConfirm.Text = "確定導入";
            btnConfirm.UseVisualStyleBackColor = false;
            btnConfirm.Click += btnConfirm_Click;
            //
            // btnClose
            //
            btnClose.BackColor = Color.Gainsboro;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
            btnClose.Location = new Point(1096, 10);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 32);
            btnClose.TabIndex = 5;
            btnClose.Text = "離開";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            //
            // dataGridView1
            //
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colSource, colAccDate, colDocType, colOffsetCode, colInvoiceNo, colTerm, colCheck, colCurrency, colOrigUntaxed, colTwdUntaxed, colTax, colAmount });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Font = new Font("微軟正黑體", 9F);
            dataGridView1.Location = new Point(0, 52);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 26;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1200, 548);
            dataGridView1.TabIndex = 1;
            //
            // colSource
            //
            colSource.HeaderText = "帳款來源";
            colSource.Name = "colSource";
            colSource.ReadOnly = true;
            //
            // colAccDate
            //
            colAccDate.HeaderText = "帳款日期";
            colAccDate.Name = "colAccDate";
            colAccDate.ReadOnly = true;
            //
            // colDocType
            //
            colDocType.HeaderText = "憑證種類";
            colDocType.Name = "colDocType";
            colDocType.ReadOnly = true;
            //
            // colOffsetCode
            //
            colOffsetCode.HeaderText = "請款單號";
            colOffsetCode.Name = "colOffsetCode";
            colOffsetCode.ReadOnly = true;
            //
            // colInvoiceNo
            //
            colInvoiceNo.HeaderText = "發票號碼";
            colInvoiceNo.Name = "colInvoiceNo";
            colInvoiceNo.ReadOnly = true;
            //
            // colTerm
            //
            colTerm.HeaderText = "帳期";
            colTerm.Name = "colTerm";
            colTerm.ReadOnly = true;
            //
            // colCheck
            //
            colCheck.HeaderText = "勾選";
            colCheck.Name = "colCheck";
            //
            // colCurrency
            //
            colCurrency.HeaderText = "幣別";
            colCurrency.Name = "colCurrency";
            colCurrency.ReadOnly = true;
            //
            // colOrigUntaxed
            //
            colOrigUntaxed.HeaderText = "原幣未稅";
            colOrigUntaxed.Name = "colOrigUntaxed";
            colOrigUntaxed.ReadOnly = true;
            //
            // colTwdUntaxed
            //
            colTwdUntaxed.HeaderText = "台幣未稅";
            colTwdUntaxed.Name = "colTwdUntaxed";
            colTwdUntaxed.ReadOnly = true;
            //
            // colTax
            //
            colTax.HeaderText = "稅";
            colTax.Name = "colTax";
            colTax.ReadOnly = true;
            colTax.Visible = false;
            //
            // colAmount
            //
            colAmount.HeaderText = "應付金額";
            colAmount.Name = "colAmount";
            colAmount.ReadOnly = true;
            //
            // FrmARImport
            //
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 600);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Font = new Font("微軟正黑體", 10F);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "FrmARImport";
            StartPosition = FormStartPosition.CenterParent;
            Text = "F-廠商應付款清單";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnFilter;
        private DateTimePicker dtFrom;
        private Label lblTilde;
        private DateTimePicker dtTo;
        private Button btnConfirm;
        private Button btnClose;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn colSource;
        private DataGridViewTextBoxColumn colAccDate;
        private DataGridViewTextBoxColumn colDocType;
        private DataGridViewTextBoxColumn colOffsetCode;
        private DataGridViewTextBoxColumn colInvoiceNo;
        private DataGridViewTextBoxColumn colTerm;
        private DataGridViewCheckBoxColumn colCheck;
        private DataGridViewTextBoxColumn colCurrency;
        private DataGridViewTextBoxColumn colOrigUntaxed;
        private DataGridViewTextBoxColumn colTwdUntaxed;
        private DataGridViewTextBoxColumn colTax;
        private DataGridViewTextBoxColumn colAmount;
    }
}
