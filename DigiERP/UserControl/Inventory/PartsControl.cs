using DigiERP.Common;
using DigiERP.Forms.Inventory;
using MES.Core.Model;
using MES.WebAPI.Controllers;

namespace DigiERP.UserControl.Inventory
{
    public partial class PartsControl : CommonUserControl
    {
        private static string id = "3F8C21E4-6A9B-4D3E-9F52-1C7B8A4E6D91";
        private ItemController _controller;
        private List<A材料> _itemList = new List<A材料>();

        public PartsControl()
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
            _controller ??= new ItemController();
        }

        private void initGrid()
        {
            initController();
            var rep = _controller.ItemList();
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }
            _itemList = rep.resultList ?? new List<A材料>();

            var summaryRep = _controller.GetStockSummaryList();
            if (!string.IsNullOrEmpty(summaryRep.ErrorMessage))
            {
                MessageBox.Show(summaryRep.ErrorMessage);
                return;
            }
            var summaryMap = (summaryRep.resultList ?? new List<A材料庫存彙總>())
                .Where(x => !string.IsNullOrEmpty(x.產品編號))
                .ToDictionary(x => x.產品編號!, x => x);

            FillGrid(_itemList, summaryMap);
        }

        public void FillGrid(List<A材料> list, Dictionary<string, A材料庫存彙總> summaryMap)
        {
            dataGridView1.Rows.Clear();
            foreach (var m in list)
            {
                var row = new DataGridViewRow();
                row.CreateCells(dataGridView1);
                int i = 0;
                row.Cells[i++].Value = m.產品編號;
                row.Cells[i++].Value = m.品別;
                row.Cells[i++].Value = m.來源屬性;
                row.Cells[i++].Value = m.大分類;
                row.Cells[i++].Value = m.小分類;
                row.Cells[i++].Value = m.產品代號;
                row.Cells[i++].Value = m.品名規格;
                row.Cells[i++].Value = m.外尺寸長;
                row.Cells[i++].Value = m.外尺寸寬;
                row.Cells[i++].Value = m.厚度;
                row.Cells[i++].Value = m.內徑;
                row.Cells[i++].Value = m.外徑;

                var summary = !string.IsNullOrEmpty(m.產品編號) && summaryMap.TryGetValue(m.產品編號, out var s) ? s : null;
                row.Cells[i++].Value = summary?.入庫總計 ?? 0;
                row.Cells[i++].Value = summary?.出庫總計 ?? 0;
                row.Cells[i++].Value = summary?.庫存卡筆數 ?? 0;
                row.Cells[i++].Value = summary?.結餘 ?? 0;

                dataGridView1.Rows.Add(row);
            }
        }

        // ── Grid 回顯時重刷 ──────────────────────────────────────────────
        private void dataGridView1_VisibleChanged(object sender, EventArgs e)
        {
            if (dataGridView1.Visible) initGrid();
        }

        // ── 點選品別：跳出該產品編號的料品編修視窗；其他欄位跳出材料庫存卡 ────
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            string? productNo = dataGridView1.Rows[e.RowIndex].Cells[colNo.Index].Value?.ToString();
            if (string.IsNullOrEmpty(productNo)) return;

            if (e.ColumnIndex == colType.Index)
            {
                var item = _itemList.FirstOrDefault(x => x.產品編號 == productNo);
                using var editFrm = new FrmAddPart(item);
                if (editFrm.ShowDialog(this) == DialogResult.OK)
                {
                    initGrid();
                }
                return;
            }

            using var frm = new FrmMaterialStockCard(productNo);
            frm.ShowDialog(this);
        }
        // ── 依條件查詢料品清單 ──────────────────────────────────────────────
        private void btnQueryByPartDesc_Click(object sender, EventArgs e)
        {
            FrmPartsQuery frmQuery = new FrmPartsQuery();
            if (frmQuery.ShowDialog(this) == DialogResult.OK)
            {
                FillGrid(frmQuery.summaryRepList, frmQuery.summaryAggregateRepList);
            }
        }

        // ── 材料品項代號新增：跳出 A材料品項代號 列表視窗 ─────────────────────
        private void btn加工材料代號新增_Click(object sender, EventArgs e)
        {
            using var frm = new FrmMaterialItemCode();
            frm.ShowDialog(this);
        }

        // ── 新增品號：跳出品項維護新增視窗，儲存後重新查詢列表 ─────────────
        private void button1_Click(object sender, EventArgs e)
        {
            using var frm = new FrmAddPart();
            if (frm.ShowDialog(this) == DialogResult.OK)
            {
                initGrid();
            }
        }

        private void btn未核准品項清單_Click(object sender, EventArgs e)
        {
            _itemList = _itemList.Where(x => string.IsNullOrEmpty(x.核准)).ToList();
            var summaryRep = _controller.GetStockSummaryList();
            if (!string.IsNullOrEmpty(summaryRep.ErrorMessage))
            {
                MessageBox.Show(summaryRep.ErrorMessage);
                return;
            }
            var summaryMap = (summaryRep.resultList ?? new List<A材料庫存彙總>())
                .Where(x => !string.IsNullOrEmpty(x.產品編號))
                .ToDictionary(x => x.產品編號!, x => x);
            FillGrid(_itemList, summaryMap);
        }
    }
}
