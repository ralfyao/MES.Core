using MES.Core.Model;
using MES.WebAPI.Controllers;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DigiERP.UserControl.Inventory.StockIn
{
    // ── 採購分配：列出尚未結案的採購明細，供進貨單挑選帶入 ────────────────────
    public partial class FrmSelectAvailablePurchaseItem : Form
    {
        public B進退貨驗收明細? Selected { get; private set; }

        private List<B進退貨驗收明細> _fullList = new List<B進退貨驗收明細>();

        public FrmSelectAvailablePurchaseItem()
        {
            InitializeComponent();
            LoadList();
        }

        private void LoadList()
        {
            var rep = new StockInController().AvailableProcItems();
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }
            _fullList = rep.resultList ?? new List<B進退貨驗收明細>();
            FillGrid(_fullList);
        }

        private void FillGrid(List<B進退貨驗收明細> list)
        {
            dgvItems.Rows.Clear();
            foreach (var x in list)
            {
                int idx = dgvItems.Rows.Add();
                var row = dgvItems.Rows[idx];
                row.Cells[colPurchaseNo.Index].Value = x.單號;
                row.Cells[colItemNo.Index].Value = x.品項編號;
                row.Cells[colSpec.Index].Value = x.品名規格;
                row.Cells[colSupplierNo.Index].Value = x.廠商編號;
                row.Cells[colSupplierShortName.Index].Value = x.廠商簡稱;
                row.Cells[colPurchaseQty.Index].Value = x.採購數量;
                row.Tag = x;
            }
        }

        private void txtSearch_TextChanged(object sender, System.EventArgs e)
        {
            string keyword = txtSearch.Text.Trim();
            if (string.IsNullOrEmpty(keyword))
            {
                FillGrid(_fullList);
                return;
            }
            var filtered = _fullList.Where(x =>
                (x.單號 ?? "").Contains(keyword) ||
                (x.品項編號 ?? "").Contains(keyword) ||
                (x.品名規格 ?? "").Contains(keyword) ||
                (x.廠商編號 ?? "").Contains(keyword) ||
                (x.廠商簡稱 ?? "").Contains(keyword)
            ).ToList();
            FillGrid(filtered);
        }

        private void dgvItems_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectCurrentRow(e.RowIndex);
        }

        private void btnSelect_Click(object sender, System.EventArgs e)
        {
            if (dgvItems.CurrentRow != null)
            {
                SelectCurrentRow(dgvItems.CurrentRow.Index);
            }
        }

        private void SelectCurrentRow(int rowIndex)
        {
            if (rowIndex < 0 || dgvItems.Rows[rowIndex].IsNewRow) return;
            Selected = dgvItems.Rows[rowIndex].Tag as B進退貨驗收明細;
            if (Selected == null) return;
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
