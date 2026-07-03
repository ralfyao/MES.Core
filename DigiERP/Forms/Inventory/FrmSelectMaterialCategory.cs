using MES.Core.Model;
using MES.WebAPI.Controllers;

namespace DigiERP.Forms.Inventory
{
    public partial class FrmSelectMaterialCategory : Form
    {
        public A材料分類? Selected { get; private set; }

        private List<A材料分類> _fullList = new List<A材料分類>();

        public FrmSelectMaterialCategory()
        {
            InitializeComponent();
            LoadList();
        }

        private void LoadList()
        {
            var rep = new ItemController().GetMaterialCategoryList();
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }
            _fullList = rep.resultList ?? new List<A材料分類>();
            FillGrid(_fullList);
        }

        private void FillGrid(List<A材料分類> list)
        {
            dgvCategory.Rows.Clear();
            foreach (var c in list)
            {
                int idx = dgvCategory.Rows.Add();
                var row = dgvCategory.Rows[idx];
                row.Cells[colCategoryCode.Index].Value = c.大分類;
                row.Cells[colCategoryName.Index].Value = c.分類名稱;
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
                (x.大分類 ?? "").IndexOf(keyword, StringComparison.OrdinalIgnoreCase) != -1 ||
                (x.分類名稱 ?? "").IndexOf(keyword, StringComparison.OrdinalIgnoreCase) != -1
            ).ToList();
            FillGrid(filtered);
        }

        private void dgvCategory_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectCurrentRow(e.RowIndex);
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (dgvCategory.CurrentRow != null)
            {
                SelectCurrentRow(dgvCategory.CurrentRow.Index);
            }
        }

        private void SelectCurrentRow(int rowIndex)
        {
            if (rowIndex < 0 || dgvCategory.Rows[rowIndex].IsNewRow) return;
            string? code = dgvCategory.Rows[rowIndex].Cells[colCategoryCode.Index].Value?.ToString();
            Selected = _fullList.FirstOrDefault(x => x.大分類 == code);
            if (Selected == null) return;
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
