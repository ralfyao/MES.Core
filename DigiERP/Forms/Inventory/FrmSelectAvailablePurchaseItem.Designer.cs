using System.Drawing;
using System.Windows.Forms;

namespace DigiERP.UserControl.Inventory.StockIn
{
    partial class FrmSelectAvailablePurchaseItem
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
            btnSelect = new Button();
            txtSearch = new TextBox();
            lblSearch = new Label();
            dgvItems = new DataGridView();
            colPurchaseNo = new DataGridViewTextBoxColumn();
            colItemNo = new DataGridViewTextBoxColumn();
            colSpec = new DataGridViewTextBoxColumn();
            colSupplierNo = new DataGridViewTextBoxColumn();
            colSupplierShortName = new DataGridViewTextBoxColumn();
            colPurchaseQty = new DataGridViewTextBoxColumn();
            panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvItems).BeginInit();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.FromArgb(255, 229, 204);
            panelTop.Controls.Add(btnSelect);
            panelTop.Controls.Add(txtSearch);
            panelTop.Controls.Add(lblSearch);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(900, 46);
            panelTop.TabIndex = 0;
            // 
            // btnSelect
            // 
            btnSelect.BackColor = Color.SeaGreen;
            btnSelect.FlatStyle = FlatStyle.Flat;
            btnSelect.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
            btnSelect.ForeColor = Color.White;
            btnSelect.Location = new Point(360, 6);
            btnSelect.Name = "btnSelect";
            btnSelect.Size = new Size(90, 34);
            btnSelect.TabIndex = 2;
            btnSelect.Text = "選取";
            btnSelect.UseVisualStyleBackColor = false;
            btnSelect.Click += btnSelect_Click;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("微軟正黑體", 10F);
            txtSearch.Location = new Point(60, 10);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(280, 25);
            txtSearch.TabIndex = 1;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("微軟正黑體", 10F);
            lblSearch.Location = new Point(8, 14);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(36, 18);
            lblSearch.TabIndex = 0;
            lblSearch.Text = "搜尋";
            // 
            // dgvItems
            // 
            dgvItems.AllowUserToAddRows = false;
            dgvItems.AllowUserToDeleteRows = false;
            dgvItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvItems.BackgroundColor = Color.White;
            dgvItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvItems.Columns.AddRange(new DataGridViewColumn[] { colPurchaseNo, colItemNo, colSpec, colSupplierNo, colSupplierShortName, colPurchaseQty });
            dgvItems.Dock = DockStyle.Fill;
            dgvItems.Font = new Font("微軟正黑體", 10F);
            dgvItems.Location = new Point(0, 46);
            dgvItems.Name = "dgvItems";
            dgvItems.ReadOnly = true;
            dgvItems.RowHeadersVisible = false;
            dgvItems.RowTemplate.Height = 26;
            dgvItems.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvItems.Size = new Size(900, 484);
            dgvItems.TabIndex = 1;
            dgvItems.CellDoubleClick += dgvItems_CellDoubleClick;
            // 
            // colPurchaseNo
            // 
            colPurchaseNo.FillWeight = 90F;
            colPurchaseNo.HeaderText = "採購單號";
            colPurchaseNo.Name = "colPurchaseNo";
            colPurchaseNo.ReadOnly = true;
            // 
            // colItemNo
            // 
            colItemNo.FillWeight = 110F;
            colItemNo.HeaderText = "品項編號";
            colItemNo.Name = "colItemNo";
            colItemNo.ReadOnly = true;
            // 
            // colSpec
            // 
            colSpec.FillWeight = 260F;
            colSpec.HeaderText = "品名規格";
            colSpec.Name = "colSpec";
            colSpec.ReadOnly = true;
            // 
            // colSupplierNo
            // 
            colSupplierNo.FillWeight = 80F;
            colSupplierNo.HeaderText = "廠商編號";
            colSupplierNo.Name = "colSupplierNo";
            colSupplierNo.ReadOnly = true;
            // 
            // colSupplierShortName
            // 
            colSupplierShortName.HeaderText = "廠商簡稱";
            colSupplierShortName.Name = "colSupplierShortName";
            colSupplierShortName.ReadOnly = true;
            // 
            // colPurchaseQty
            // 
            colPurchaseQty.FillWeight = 80F;
            colPurchaseQty.HeaderText = "採購數量";
            colPurchaseQty.Name = "colPurchaseQty";
            colPurchaseQty.ReadOnly = true;
            // 
            // FrmSelectAvailablePurchaseItem
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 530);
            Controls.Add(dgvItems);
            Controls.Add(panelTop);
            Font = new Font("微軟正黑體", 10F);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MinimumSize = new Size(700, 400);
            Name = "FrmSelectAvailablePurchaseItem";
            StartPosition = FormStartPosition.CenterParent;
            Text = "採購分配 - 選取待驗收項目";
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvItems).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop;
        private Label lblSearch;
        private TextBox txtSearch;
        private Button btnSelect;
        private DataGridView dgvItems;
        private DataGridViewTextBoxColumn colPurchaseNo;
        private DataGridViewTextBoxColumn colItemNo;
        private DataGridViewTextBoxColumn colSpec;
        private DataGridViewTextBoxColumn colSupplierNo;
        private DataGridViewTextBoxColumn colSupplierShortName;
        private DataGridViewTextBoxColumn colPurchaseQty;
    }
}
