using DigiERP.Common;
using MES.Core.Model;
using MES.WebAPI.Controllers;
using MES.WebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DigiERP.UserControl.Supplier.Procurement
{
    public partial class ProcurementControl : CommonUserControl
    {
        private static string id = "6E4C2F1D-8A3B-4E6F-9C7D-2B5A9E1F0C3D";

        private enum ViewMode { Open, WithoutDetail, Closed }

        private ViewMode _mode = ViewMode.Open;
        private List<B採購單> _orderList = new List<B採購單>();
        private Dictionary<string, B廠商設定> _supplierMap = new Dictionary<string, B廠商設定>();

        public ProcurementControl()
        {
            if (!chkPrivilege(id))
            {
                MessageBox.Show("非授權使用者無法使用此功能!");
                Dispose();
                return;
            }
            InitializeComponent();
            initGrid();
        }

        // ── 讀取廠商簡稱/名稱對照表 ──────────────────────────────────────
        private void initSupplierMap()
        {
            var rep = new SupplierController().GetAllSupplierList();
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }
            _supplierMap = (rep.resultList ?? new List<B廠商設定>())
                .Where(s => !string.IsNullOrEmpty(s.廠商編號))
                .GroupBy(s => s.廠商編號!)
                .ToDictionary(g => g.Key, g => g.First());
        }

        // ── 依目前模式（未結案／未輸入明細／已結案）重新載入資料 ─────────────
        private void initGrid()
        {
            initSupplierMap();

            bool closed = _mode == ViewMode.Closed;
            bool onlyWithoutDetail = _mode == ViewMode.WithoutDetail;
            var rep = new ProcurementController().AllPurchasesList("", closed, onlyWithoutDetail);
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }
            _orderList = rep.resultList ?? new List<B採購單>();

            lblTitle.Text = _mode switch
            {
                ViewMode.WithoutDetail => "採購單總覽-未輸入明細",
                ViewMode.Closed => "採購單總覽-已結案",
                _ => "採購單總覽-未結案",
            };

            ApplyFilter();
        }

        // ── 依查詢欄位篩選快取清單並重繪表格 ────────────────────────────────
        private void ApplyFilter()
        {
            string no = txtNo.Text.Trim();
            string supplier = txtSupplier.Text.Trim();
            string project = txtProject.Text.Trim();
            string itemName = txtItemName.Text.Trim();

            var list = _orderList;
            if (!string.IsNullOrEmpty(no))
            {
                list = list.Where(x => (x.單號 ?? "").Contains(no)).ToList();
            }
            if (!string.IsNullOrEmpty(supplier))
            {
                list = list.Where(x =>
                {
                    _supplierMap.TryGetValue(x.廠商編號 ?? "", out var s);
                    return (x.廠商編號 ?? "").Contains(supplier)
                        || (s?.廠商簡稱 ?? "").Contains(supplier)
                        || (s?.廠商名稱 ?? "").Contains(supplier);
                }).ToList();
            }

            var rows = new List<(B採購單 header, B採購明細? line)>();
            foreach (var header in list)
            {
                var lines = header.procurementList ?? new List<B採購明細>();
                if (!string.IsNullOrEmpty(project))
                {
                    lines = lines.Where(x => (x.專案序號 ?? "").Contains(project)).ToList();
                }
                if (!string.IsNullOrEmpty(itemName))
                {
                    lines = lines.Where(x => (x.品名規格 ?? "").Contains(itemName)).ToList();
                }
                if (lines.Count == 0)
                {
                    if (string.IsNullOrEmpty(project) && string.IsNullOrEmpty(itemName))
                    {
                        rows.Add((header, null));
                    }
                    continue;
                }
                foreach (var line in lines)
                {
                    rows.Add((header, line));
                }
            }
            FillGrid(rows);
        }

        private void FillGrid(List<(B採購單 header, B採購明細? line)> rows)
        {
            dataGridView1.Rows.Clear();
            foreach (var (header, line) in rows)
            {
                _supplierMap.TryGetValue(header.廠商編號 ?? "", out var supplier);
                var row = new DataGridViewRow();
                row.CreateCells(dataGridView1);
                int i = 0;
                row.Cells[i++].Value = header.單號;
                row.Cells[i++].Value = header.日期;
                row.Cells[i++].Value = header.廠商編號;
                row.Cells[i++].Value = supplier?.廠商簡稱;
                row.Cells[i++].Value = header.採購類別;
                row.Cells[i++].Value = supplier?.廠商名稱;
                row.Cells[i++].Value = line?.結案 ?? header.結案 ?? false;
                row.Cells[i++].Value = line?.專案序號;
                row.Cells[i++].Value = line?.品項編號;
                row.Cells[i++].Value = line?.品名規格;
                row.Cells[i++].Value = line?.採購數量;
                row.Cells[i++].Value = header.採購人員;
                row.Cells[i++].Value = header.核准;
                dataGridView1.Rows.Add(row);
            }
        }

        // ── 查詢欄位 ────────────────────────────────────────────────────
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        // ── 「未輸入明細」／「查詢已結案」為切換式檢視，再按一次回到未結案 ────
        private void btnWithoutDetail_Click(object sender, EventArgs e)
        {
            _mode = _mode == ViewMode.WithoutDetail ? ViewMode.Open : ViewMode.WithoutDetail;
            ClearSearch();
            initGrid();
        }

        private void btnClosed_Click(object sender, EventArgs e)
        {
            _mode = _mode == ViewMode.Closed ? ViewMode.Open : ViewMode.Closed;
            ClearSearch();
            initGrid();
        }

        private void ClearSearch()
        {
            txtNo.Text = "";
            txtSupplier.Text = "";
            txtProject.Text = "";
            txtItemName.Text = "";
        }

        // ── 新增：開啟採購單維護畫面 ───────────────────────────────────────
        private void btnAdd_Click(object sender, EventArgs e)
        {
            OpenMaintainControl(null, "新增");
        }

        // ── 雙擊列表：開啟該筆採購單進行檢視／修改 ───────────────────────────
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            string no = dataGridView1.Rows[e.RowIndex].Cells[colNo.Index].Value?.ToString();
            if (string.IsNullOrEmpty(no)) return;
            var header = _orderList.FirstOrDefault(x => x.單號 == no);
            OpenMaintainControl(header ?? new B採購單 { 單號 = no }, "修改");
        }

        private void OpenMaintainControl(B採購單 header, string mode)
        {
            for (int i = panel2.Controls.Count - 1; i >= 0; i--)
            {
                if (panel2.Controls[i] is ProcurementMaintainControl m)
                {
                    panel2.Controls.RemoveAt(i);
                    m.Dispose();
                }
            }
            var maintain = header != null ? new ProcurementMaintainControl(header) : new ProcurementMaintainControl();
            maintain.Dock = DockStyle.Fill;
            panel2.Controls.Add(maintain);
            dataGridView1.Visible = false;

            var lblMode = FindDescendant(maintain, "lblMode") as Label;
            if (lblMode != null)
            {
                lblMode.Text = mode;
            }
            maintain.initForm();
            maintain.Visible = true;
        }

        // ── lblMode 巢狀在 panelToolbar 底下，需遞迴往下找，非僅限直接子控制項 ──
        private static Control FindDescendant(Control parent, string name)
        {
            foreach (Control c in parent.Controls)
            {
                if (c.Name == name) return c;
                var found = FindDescendant(c, name);
                if (found != null) return found;
            }
            return null;
        }

        // ── 關閉 — 回到列表，或若是獨立頁籤則直接關閉該頁籤 ───────────────
        private void btnExit_Click(object sender, EventArgs e)
        {
            var parentCtrl = Parent;
            if (parentCtrl is TabPage tabPage && tabPage.Parent is TabControl tabControl)
            {
                tabControl.TabPages.Remove(tabPage);
                Dispose();
                return;
            }
            if (parentCtrl != null)
            {
                parentCtrl.Controls.Remove(this);
            }
            Dispose();
        }

        // ── Grid 回顯時重刷 ──────────────────────────────────────────────
        private void dataGridView1_VisibleChanged(object sender, EventArgs e)
        {
            if (dataGridView1.Visible) initGrid();
        }
    }
}
