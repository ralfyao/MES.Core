using DigiERP.Common;
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

        private void FillGrid(List<A材料> list, Dictionary<string, A材料庫存彙總> summaryMap)
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
    }
}
