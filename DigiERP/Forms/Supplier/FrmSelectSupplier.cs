using MES.Core.Model;
using MES.WebAPI.Controllers;

namespace DigiERP.UserControl.Supplier.SupplierManage
{
    public partial class FrmSelectSupplier : Form
    {
        public B廠商設定? Selected { get; private set; }

        private List<B廠商設定> _fullList = new List<B廠商設定>();

        public FrmSelectSupplier()
        {
            InitializeComponent();
            LoadSupplierList();
        }

        private void LoadSupplierList()
        {
            var rep = new SupplierController().GetAllSupplierList();
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }
            _fullList = rep.resultList ?? new List<B廠商設定>();
            FillGrid(_fullList);
        }

        private void FillGrid(List<B廠商設定> list)
        {
            dgvSupplier.Rows.Clear();
            foreach (var s in list)
            {
                int idx = dgvSupplier.Rows.Add();
                var row = dgvSupplier.Rows[idx];
                row.Cells[colSupplierNo.Index].Value = s.廠商編號;
                row.Cells[colShortName.Index].Value = s.廠商簡稱;
                row.Cells[colName.Index].Value = s.廠商名稱;
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim();
            if (string.IsNullOrEmpty(keyword))
            {
                FillGrid(_fullList);
                return;
            }
            var filtered = _fullList.Where(x =>
                (x.廠商編號 ?? "").IndexOf(keyword, StringComparison.OrdinalIgnoreCase) != -1 ||
                (x.廠商簡稱 ?? "").IndexOf(keyword, StringComparison.OrdinalIgnoreCase) != -1 ||
                (x.廠商名稱 ?? "").IndexOf(keyword, StringComparison.OrdinalIgnoreCase) != -1
            ).ToList();
            FillGrid(filtered);
        }

        private void dgvSupplier_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectCurrentRow(e.RowIndex);
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (dgvSupplier.CurrentRow != null)
            {
                SelectCurrentRow(dgvSupplier.CurrentRow.Index);
            }
        }

        private void SelectCurrentRow(int rowIndex)
        {
            if (rowIndex < 0 || dgvSupplier.Rows[rowIndex].IsNewRow) return;
            string? supplierNo = dgvSupplier.Rows[rowIndex].Cells[colSupplierNo.Index].Value?.ToString();
            Selected = _fullList.FirstOrDefault(x => x.廠商編號 == supplierNo);
            if (Selected == null) return;
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
