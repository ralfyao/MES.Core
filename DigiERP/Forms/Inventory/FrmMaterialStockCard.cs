using MES.Core.Model;
using MES.WebAPI.Controllers;

namespace DigiERP.Forms.Inventory
{
    public partial class FrmMaterialStockCard : Form
    {
        private readonly string _productNo;
        private ItemController _controller;
        private A材料? _currentItem;
        private bool _editMode = false;

        public FrmMaterialStockCard(string productNo)
        {
            InitializeComponent();
            _productNo = productNo;
            _controller = new ItemController();
            initOperatorCombo();
            initHeader();
            initGrid();
        }

        // ── 異動人員下拉：H員工清冊，狀況不為離職 ─────────────────────────
        private void initOperatorCombo()
        {
            var rep = new HRController().AllWorkers();
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }
            var names = (rep.resultList ?? new List<H員工清冊>())
                .Where(x => x.狀況 != "離職")
                .Select(x => x.姓名)
                .Where(n => !string.IsNullOrEmpty(n))
                .Distinct()
                .ToArray();
            colOperator.Items.Clear();
            colOperator.Items.AddRange(names);
        }

        private void initHeader()
        {
            var rep = _controller.ItemList(_productNo);
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }
            var item = (rep.resultList ?? new List<A材料>()).FirstOrDefault();
            _currentItem = item;
            if (item == null) return;

            txtCode.Text = item.產品編號 ?? "";
            txtType.Text = item.品別 ?? "";
            txtCategory.Text = item.大分類 ?? "";
            txtSubCategory.Text = item.小分類 ?? "";
            txtProductCode.Text = item.產品代號 ?? "";
            txtSpec.Text = item.品名規格 ?? "";
            txtLength.Text = item.外尺寸長?.ToString() ?? "0";
            txtWidth.Text = item.外尺寸寬?.ToString() ?? "0";
            txtThickness.Text = item.厚度?.ToString() ?? "0";
            txtOuterDia.Text = item.外徑?.ToString() ?? "0";
            txtInnerDia.Text = item.內徑?.ToString() ?? "0";
        }

        private void initGrid()
        {
            var rep = _controller.GetStockCardList(_productNo);
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }
            var list = rep.resultList ?? new List<A材料庫存卡>();

            _editMode = false;
            dataGridView1.AllowUserToAddRows = false;

            dataGridView1.Rows.Clear();
            foreach (var c in list)
            {
                var row = new DataGridViewRow();
                row.CreateCells(dataGridView1);
                int i = 0;
                row.Cells[i++].Value = c.異動日期;
                row.Cells[i++].Value = c.摘要;
                row.Cells[i++].Value = c.來源用途;
                row.Cells[i++].Value = c.單位;
                row.Cells[i++].Value = c.入庫;
                row.Cells[i++].Value = c.出庫;
                row.Cells[i++].Value = c.儲位;
                row.Cells[i++].Value = c.異動人員;
                row.Cells[i++].Value = c.備註;
                dataGridView1.Rows.Add(row);
                dataGridView1.Rows[dataGridView1.Rows.Count - 1].ReadOnly = true;
            }

            decimal stockIn = list.Sum(x => x.入庫 ?? 0);
            decimal stockOut = list.Sum(x => x.出庫 ?? 0);
            txtStockInTotal.Text = stockIn.ToString("0.00");
            txtStockOutTotal.Text = stockOut.ToString("0.0000");
            txtBalance.Text = (stockIn - stockOut).ToString("0.00");
        }

        // ── 編修料品：開啟品項維護視窗，帶入這個產品編號的現有資料 ─────────
        private void btnEditPart_Click(object sender, EventArgs e)
        {
            using var frm = new FrmAddPart(_currentItem);
            if (frm.ShowDialog(this) == DialogResult.OK)
            {
                initHeader();
            }
        }

        // ── 異動編修：解鎖新增一列庫存異動 ───────────────────────────────
        private void btnEditTransaction_Click(object sender, EventArgs e)
        {
            _editMode = true;
            dataGridView1.AllowUserToAddRows = true;
            if (dataGridView1.Rows.Count > 0)
            {
                dataGridView1.CurrentCell = dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[colDate.Index];
            }
        }

        // ── 儲存紀錄：只寫入新增的那幾列，既有紀錄不動 ───────────────────
        private void btnSaveRecord_Click(object sender, EventArgs e)
        {
            if (!_editMode)
            {
                MessageBox.Show("請先按「異動編修」才能新增庫存紀錄!");
                return;
            }

            var newRows = dataGridView1.Rows.Cast<DataGridViewRow>()
                .Where(r => !r.IsNewRow && !r.ReadOnly)
                .ToList();

            if (newRows.Count == 0)
            {
                MessageBox.Show("沒有新增的庫存資料可以儲存!");
                return;
            }

            foreach (var row in newRows)
            {
                var card = new A材料庫存卡
                {
                    產品編號 = _productNo,
                    異動日期 = row.Cells[colDate.Index].Value?.ToString(),
                    摘要 = row.Cells[colSummary.Index].Value?.ToString(),
                    來源用途 = row.Cells[colSource.Index].Value?.ToString(),
                    單位 = row.Cells[colUnit.Index].Value?.ToString(),
                    入庫 = decimal.TryParse(row.Cells[colStockIn.Index].Value?.ToString(), out var stockIn) ? stockIn : (decimal?)null,
                    出庫 = decimal.TryParse(row.Cells[colStockOut.Index].Value?.ToString(), out var stockOut) ? stockOut : (decimal?)null,
                    儲位 = row.Cells[colLocation.Index].Value?.ToString(),
                    異動人員 = row.Cells[colOperator.Index].Value?.ToString(),
                    備註 = row.Cells[colRemark.Index].Value?.ToString(),
                };

                var rep = _controller.AddStockCard(card);
                if (!string.IsNullOrEmpty(rep.ErrorMessage))
                {
                    MessageBox.Show(rep.ErrorMessage);
                    return;
                }
            }

            MessageBox.Show("儲存成功");
            initGrid();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
