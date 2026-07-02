using MES.Core.Model;
using MES.WebAPI.Controllers;

namespace DigiERP.UserControl.Supplier.SupplierManage
{
    public partial class FrmSelectMaterial : Form
    {
        public A材料? Selected { get; private set; }

        private List<A材料> _fullList = new List<A材料>();

        public FrmSelectMaterial()
        {
            InitializeComponent();
            LoadMaterialList();
        }

        private void LoadMaterialList()
        {
            var rep = new ItemController().ItemList();
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }
            _fullList = rep.resultList ?? new List<A材料>();
            FillGrid(_fullList);
        }

        private void FillGrid(List<A材料> list)
        {
            dgvMaterial.Rows.Clear();
            foreach (var m in list)
            {
                int idx = dgvMaterial.Rows.Add();
                var row = dgvMaterial.Rows[idx];
                row.Cells[colProductNo.Index].Value = m.產品編號;
                row.Cells[colType.Index].Value = m.品別;
                row.Cells[colCategory.Index].Value = m.大分類;
                row.Cells[colSpec.Index].Value = m.品名規格;
                row.Cells[colProductCode.Index].Value = m.產品代號;
                row.Cells[colUnit.Index].Value = m.採購單位;
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
                (x.產品編號 ?? "").IndexOf(keyword, StringComparison.OrdinalIgnoreCase) != -1 ||
                (x.產品代號 ?? "").IndexOf(keyword, StringComparison.OrdinalIgnoreCase) != -1 ||
                (x.品名規格 ?? "").IndexOf(keyword, StringComparison.OrdinalIgnoreCase) != -1
            ).ToList();
            FillGrid(filtered);
        }

        private void dgvMaterial_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectCurrentRow(e.RowIndex);
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (dgvMaterial.CurrentRow != null)
            {
                SelectCurrentRow(dgvMaterial.CurrentRow.Index);
            }
        }

        private void SelectCurrentRow(int rowIndex)
        {
            if (rowIndex < 0 || dgvMaterial.Rows[rowIndex].IsNewRow) return;
            var row = dgvMaterial.Rows[rowIndex];
            Selected = new A材料
            {
                產品編號 = row.Cells[colProductNo.Index].Value?.ToString(),
                品別 = row.Cells[colType.Index].Value?.ToString(),
                大分類 = row.Cells[colCategory.Index].Value?.ToString(),
                品名規格 = row.Cells[colSpec.Index].Value?.ToString(),
                產品代號 = row.Cells[colProductCode.Index].Value?.ToString(),
                採購單位 = row.Cells[colUnit.Index].Value?.ToString(),
            };
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
