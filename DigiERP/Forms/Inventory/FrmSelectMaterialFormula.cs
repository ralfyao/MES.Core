using MES.Core.Model;
using MES.WebAPI.Controllers;

namespace DigiERP.Forms.Inventory
{
    public partial class FrmSelectMaterialFormula : Form
    {
        public A材料計算公式? Selected { get; private set; }

        private List<A材料計算公式> _fullList = new List<A材料計算公式>();

        public FrmSelectMaterialFormula()
        {
            InitializeComponent();
            LoadList();
        }

        private void LoadList()
        {
            var rep = new ItemController().GetMaterialFormulaList();
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }
            _fullList = rep.resultList ?? new List<A材料計算公式>();
            FillGrid(_fullList);
        }

        private void FillGrid(List<A材料計算公式> list)
        {
            dgvFormula.Rows.Clear();
            foreach (var f in list)
            {
                int idx = dgvFormula.Rows.Add();
                var row = dgvFormula.Rows[idx];
                row.Cells[colFormulaCode.Index].Value = f.公式代號;
                row.Cells[colFormulaDesc.Index].Value = f.公式說明;
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
                (x.公式代號 ?? "").IndexOf(keyword, StringComparison.OrdinalIgnoreCase) != -1 ||
                (x.公式說明 ?? "").IndexOf(keyword, StringComparison.OrdinalIgnoreCase) != -1
            ).ToList();
            FillGrid(filtered);
        }

        private void dgvFormula_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectCurrentRow(e.RowIndex);
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (dgvFormula.CurrentRow != null)
            {
                SelectCurrentRow(dgvFormula.CurrentRow.Index);
            }
        }

        private void SelectCurrentRow(int rowIndex)
        {
            if (rowIndex < 0 || dgvFormula.Rows[rowIndex].IsNewRow) return;
            string? code = dgvFormula.Rows[rowIndex].Cells[colFormulaCode.Index].Value?.ToString();
            Selected = _fullList.FirstOrDefault(x => x.公式代號 == code);
            if (Selected == null) return;
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
