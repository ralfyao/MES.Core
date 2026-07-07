using System.Drawing;
using System.Windows.Forms;

namespace DigiERP.UserControl.Inventory.StockIn
{
    partial class FrmSelectAccountingSubject
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            panelTop = new Panel();
            txtSearch = new TextBox();
            lblSearch = new Label();
            dgvSubject = new DataGridView();
            colCode = new DataGridViewTextBoxColumn();
            colName = new DataGridViewTextBoxColumn();
            colDebitCredit = new DataGridViewTextBoxColumn();
            panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSubject).BeginInit();
            SuspendLayout();

            // panelTop
            panelTop.BackColor = Color.FromArgb(255, 229, 204);
            panelTop.Controls.Add(txtSearch);
            panelTop.Controls.Add(lblSearch);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(450, 40);
            panelTop.TabIndex = 0;

            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("微軟正黑體", 10F);
            lblSearch.Location = new Point(8, 12);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(64, 18);
            lblSearch.TabIndex = 0;
            lblSearch.Text = "搜尋";

            txtSearch.Font = new Font("微軟正黑體", 10F);
            txtSearch.Location = new Point(56, 8);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(260, 25);
            txtSearch.TabIndex = 1;
            txtSearch.TextChanged += txtSearch_TextChanged;

            // dgvSubject
            dgvSubject.AllowUserToAddRows = false;
            dgvSubject.AllowUserToDeleteRows = false;
            dgvSubject.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSubject.BackgroundColor = Color.White;
            dgvSubject.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(255, 229, 204);
            dgvSubject.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSubject.Columns.AddRange(new DataGridViewColumn[] { colCode, colName, colDebitCredit });
            dgvSubject.Dock = DockStyle.Fill;
            dgvSubject.Font = new Font("微軟正黑體", 10F);
            dgvSubject.Location = new Point(0, 40);
            dgvSubject.Name = "dgvSubject";
            dgvSubject.ReadOnly = true;
            dgvSubject.RowHeadersVisible = false;
            dgvSubject.RowTemplate.Height = 26;
            dgvSubject.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSubject.Size = new Size(450, 610);
            dgvSubject.TabIndex = 1;
            dgvSubject.CellDoubleClick += dgvSubject_CellDoubleClick;

            colCode.FillWeight = 90F; colCode.HeaderText = "會科代碼"; colCode.Name = "colCode";
            colName.FillWeight = 200F; colName.HeaderText = "會科名稱"; colName.Name = "colName";
            colDebitCredit.FillWeight = 60F; colDebitCredit.HeaderText = "借貸"; colDebitCredit.Name = "colDebitCredit";

            // FrmSelectAccountingSubject
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(450, 650);
            Controls.Add(dgvSubject);
            Controls.Add(panelTop);
            Font = new Font("微軟正黑體", 10F);
            MinimumSize = new Size(350, 300);
            Name = "FrmSelectAccountingSubject";
            StartPosition = FormStartPosition.CenterParent;
            Text = "會計科目選擇";
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSubject).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop;
        private Label lblSearch;
        private TextBox txtSearch;
        private DataGridView dgvSubject;
        private DataGridViewTextBoxColumn colCode;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn colDebitCredit;
    }
}
