using DigiERP.Common;
using MES.Core.Model;
using MES.WebAPI.Controllers;

namespace DigiERP.UserControl.Supplier.SupplierEvaluate
{
    public partial class SupplierEvaluateControl : CommonUserControl
    {
        private static string id = "7B2E5A19-4C6D-4F0B-9A3E-1D8C6F2B9A54";
        private SupplierController _controller;
        private List<B廠商評鑑> _evaluateList = new List<B廠商評鑑>();
        private Dictionary<string, string> _supplierShortNameMap = new Dictionary<string, string>();

        public SupplierEvaluateControl()
        {
            if (!chkPrivilege(id))
            {
                MessageBox.Show("非授權使用者無法使用此功能!");
                Dispose();
                return;
            }
            InitializeComponent();
            initController();
            initGrid();
        }

        private void initController()
        {
            _controller ??= new SupplierController();
        }

        private void initGrid()
        {
            initController();

            var supplierRep = _controller.GetAllSupplierList();
            if (!string.IsNullOrEmpty(supplierRep.ErrorMessage))
            {
                MessageBox.Show(supplierRep.ErrorMessage);
                return;
            }
            _supplierShortNameMap = (supplierRep.resultList ?? new List<B廠商設定>())
                .Where(s => !string.IsNullOrEmpty(s.廠商編號))
                .ToDictionary(s => s.廠商編號!, s => s.廠商簡稱 ?? "");

            var rep = _controller.GetSupplierEvaluateList();
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }
            _evaluateList = rep.resultList ?? new List<B廠商評鑑>();
            FillGrid(_evaluateList);
        }

        private void FillGrid(List<B廠商評鑑> list)
        {
            dataGridView1.Rows.Clear();
            foreach (var e in list)
            {
                var row = new DataGridViewRow();
                row.CreateCells(dataGridView1);
                int i = 0;
                row.Cells[i++].Value = e.單號;
                row.Cells[i++].Value = e.日期;
                row.Cells[i++].Value = e.廠商編號;
                row.Cells[i++].Value = !string.IsNullOrEmpty(e.廠商編號) && _supplierShortNameMap.TryGetValue(e.廠商編號, out var shortName) ? shortName : "";
                row.Cells[i++].Value = e.評鑑人員;
                row.Cells[i++].Value = e.覆審人員;
                row.Cells[i++].Value = e.覆審日期;
                row.Cells[i++].Value = e.核准;
                row.Cells[i++].Value = e.核准日;
                dataGridView1.Rows.Add(row);
            }
        }

        // ── 搜尋 ────────────────────────────────────────────────────────
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string no = txtSearchNo.Text.Trim().ToLower();
            string supplierNo = txtSearchSupplierNo.Text.Trim().ToLower();
            var filtered = _evaluateList.Where(x =>
                (string.IsNullOrEmpty(no) || (x.單號 ?? "").ToLower().Contains(no)) &&
                (string.IsNullOrEmpty(supplierNo) || (x.廠商編號 ?? "").ToLower().Contains(supplierNo))
            ).ToList();
            FillGrid(filtered);
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) btnSearch_Click(sender, e);
        }

        // ── Grid 回顯時重刷 ──────────────────────────────────────────────
        private void dataGridView1_VisibleChanged(object sender, EventArgs e)
        {
            if (dataGridView1.Visible) initGrid();
        }
    }
}
