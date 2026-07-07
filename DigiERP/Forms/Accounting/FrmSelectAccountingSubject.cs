using MES.Core.Model;
using MES.WebAPI.Controllers;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DigiERP.UserControl.Inventory.StockIn
{
    // ── 會計科目選擇：資料來源為 F會計科目 ──────────────────────────────────
    public partial class FrmSelectAccountingSubject : Form
    {
        public F會計科目? Selected { get; private set; }

        private List<F會計科目> _fullList = new List<F會計科目>();

        public FrmSelectAccountingSubject()
        {
            InitializeComponent();
            LoadList();
        }

        private void LoadList()
        {
            var rep = new VoucherController().GetAccountingSubjectList();
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }
            _fullList = rep.resultList ?? new List<F會計科目>();
            FillGrid(_fullList);
        }

        private void FillGrid(List<F會計科目> list)
        {
            dgvSubject.Rows.Clear();
            foreach (var x in list)
            {
                int idx = dgvSubject.Rows.Add();
                var row = dgvSubject.Rows[idx];
                row.Cells[colCode.Index].Value = x.會科代碼;
                row.Cells[colName.Index].Value = x.會科名稱;
                row.Cells[colDebitCredit.Index].Value = x.借貸;
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
                (x.會科代碼 ?? "").Contains(keyword) ||
                (x.會科名稱 ?? "").Contains(keyword)
            ).ToList();
            FillGrid(filtered);
        }

        private void dgvSubject_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectCurrentRow(e.RowIndex);
        }

        private void SelectCurrentRow(int rowIndex)
        {
            if (rowIndex < 0 || dgvSubject.Rows[rowIndex].IsNewRow) return;
            Selected = dgvSubject.Rows[rowIndex].Tag as F會計科目;
            if (Selected == null) return;
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
