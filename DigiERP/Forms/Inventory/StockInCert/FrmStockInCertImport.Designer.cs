using System.Drawing;
using System.Windows.Forms;

namespace DigiERP.UserControl.Inventory.StockInCert
{
    partial class FrmStockInCertImport
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
            colNo = new DataGridViewTextBoxColumn();
            colDate = new DataGridViewTextBoxColumn();
            colHandler = new DataGridViewTextBoxColumn();
            colVerify = new DataGridViewTextBoxColumn();
            colItemNo = new DataGridViewTextBoxColumn();
            colDesc = new DataGridViewTextBoxColumn();
            colCheck = new DataGridViewCheckBoxColumn();
            colUntaxed = new DataGridViewTextBoxColumn();
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
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colNo, colDate, colHandler, colVerify, colItemNo, colDesc, colCheck, colUntaxed, colTax, colAmount });
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
            // colNo
            //
            colNo.HeaderText = "單號";
            colNo.Name = "colNo";
            colNo.ReadOnly = true;
            //
            // colDate
            //
            colDate.HeaderText = "日期";
            colDate.Name = "colDate";
            colDate.ReadOnly = true;
            //
            // colHandler
            //
            colHandler.HeaderText = "經辦";
            colHandler.Name = "colHandler";
            colHandler.ReadOnly = true;
            //
            // colVerify
            //
            colVerify.HeaderText = "覆核";
            colVerify.Name = "colVerify";
            colVerify.ReadOnly = true;
            //
            // colItemNo
            //
            colItemNo.HeaderText = "項目編號";
            colItemNo.Name = "colItemNo";
            colItemNo.ReadOnly = true;
            //
            // colDesc
            //
            colDesc.FillWeight = 220F;
            colDesc.HeaderText = "品名規格";
            colDesc.Name = "colDesc";
            colDesc.ReadOnly = true;
            //
            // colCheck
            //
            colCheck.HeaderText = "勾選";
            colCheck.Name = "colCheck";
            //
            // colUntaxed
            //
            colUntaxed.HeaderText = "未稅金額";
            colUntaxed.Name = "colUntaxed";
            colUntaxed.ReadOnly = true;
            //
            // colTax
            //
            colTax.HeaderText = "稅額";
            colTax.Name = "colTax";
            colTax.ReadOnly = true;
            //
            // colAmount
            //
            colAmount.HeaderText = "付款金額";
            colAmount.Name = "colAmount";
            colAmount.ReadOnly = true;
            //
            // FrmStockInCertImport
            //
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 600);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Font = new Font("微軟正黑體", 10F);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "FrmStockInCertImport";
            StartPosition = FormStartPosition.CenterParent;
            Text = "進貨憑證核銷";
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
        private DataGridViewTextBoxColumn colNo;
        private DataGridViewTextBoxColumn colDate;
        private DataGridViewTextBoxColumn colHandler;
        private DataGridViewTextBoxColumn colVerify;
        private DataGridViewTextBoxColumn colItemNo;
        private DataGridViewTextBoxColumn colDesc;
        private DataGridViewCheckBoxColumn colCheck;
        private DataGridViewTextBoxColumn colUntaxed;
        private DataGridViewTextBoxColumn colTax;
        private DataGridViewTextBoxColumn colAmount;
    }
}
