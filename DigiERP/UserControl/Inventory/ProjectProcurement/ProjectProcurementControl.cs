using DigiERP.Common;
using MES.Core.Model;
using MES.WebAPI.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DigiERP.UserControl.Inventory.ProjectProcurement
{
    public partial class ProjectProcurementControl : CommonUserControl
    {
        private static string id = "9C4E7B2A-3D6F-4A81-B5E9-7C2D4F8A9E16";

        private static readonly string[] PartTypes = { "市購品", "自製/在庫料", "自製/需購料" };
        private static readonly string[] AcceptanceResults = { "", "合格允收", "不合格" };

        private List<採購計畫> _list = new List<採購計畫>();
        private HashSet<int> _dirtyRows = new HashSet<int>();

        public ProjectProcurementControl()
        {
            if (!chkPrivilege(id))
            {
                MessageBox.Show("非授權使用者無法使用此功能!");
                Dispose();
                return;
            }
            InitializeComponent();
            colPartType.Items.AddRange(PartTypes);
            colAcceptance.Items.AddRange(AcceptanceResults);
            initGrid();
        }

        private void initGrid()
        {
            initLookups();

            var rep = new ProjectProcurementController().GetProjectProcurementList();
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }
            _list = rep.resultList ?? new List<採購計畫>();
            FillGrid(_list);
        }

        private void initLookups()
        {
            var empRep = new GeneralExpensesController().GetActiveEmployeeList();
            if (!string.IsNullOrEmpty(empRep.ErrorMessage))
            {
                MessageBox.Show(empRep.ErrorMessage);
                return;
            }
            var employees = empRep.resultList ?? new List<H員工清冊>();
            colPurchaser.Items.Clear();
            colWarehouseStaff.Items.Clear();
            foreach (var no in employees.Select(x => x.工號?.Trim()).Where(no => !string.IsNullOrEmpty(no)).Distinct())
            {
                colPurchaser.Items.Add(no);
                colWarehouseStaff.Items.Add(no);
            }
        }

        // ── 若資料庫的值不在目前下拉清單中，強制塞入清單以完整顯示 ──────────
        private static void EnsureComboItem(DataGridViewComboBoxColumn col, string value)
        {
            if (string.IsNullOrEmpty(value)) return;
            if (!col.Items.Contains(value))
            {
                col.Items.Add(value);
            }
        }

        private void FillGrid(List<採購計畫> list)
        {
            dataGridView1.Rows.Clear();
            _dirtyRows.Clear();
            foreach (var x in list)
            {
                string partType = x.零件分類?.Trim();
                string purchaser = x.採購人員?.Trim();
                string warehouseStaff = x.倉管人員?.Trim();
                string acceptance = x.驗收合格?.Trim() ?? "";
                EnsureComboItem(colPartType, partType);
                EnsureComboItem(colPurchaser, purchaser);
                EnsureComboItem(colWarehouseStaff, warehouseStaff);
                EnsureComboItem(colAcceptance, acceptance);

                int i = dataGridView1.Rows.Add();
                var row = dataGridView1.Rows[i];
                row.Cells[colProjectNo.Index].Value = x.專案序號;
                row.Cells[colModuleCode.Index].Value = x.模組編碼;
                row.Cells[colModuleName.Index].Value = x.模組名稱;
                row.Cells[colPartNo.Index].Value = x.零件號碼;
                row.Cells[colPartName.Index].Value = x.品名;
                row.Cells[colDesc.Index].Value = x.描述;
                row.Cells[colQty.Index].Value = x.數量;
                row.Cells[colPartType.Index].Value = partType;
                row.Cells[colPurchaser.Index].Value = purchaser;
                row.Cells[colActualPurchaseDate.Index].Value = x.實際採購日;
                row.Cells[colExpectedArrival.Index].Value = x.預計到貨日;
                row.Cells[colWarehouseStaff.Index].Value = warehouseStaff;
                row.Cells[colStockInDate.Index].Value = x.入庫移轉日;
                row.Cells[colControlNo.Index].Value = x.零件管制單號;
                row.Cells[colAcceptance.Index].Value = acceptance;
                row.Cells[colPurchaseId.Index].Value = x.採購識別碼;
            }
        }

        // ── 修改：解鎖表格，允許編輯採購追蹤欄位 ───────────────────────────
        private void btnModify_Click(object sender, EventArgs e)
        {
            dataGridView1.ReadOnly = false;
            _dirtyRows.Clear();
        }

        private void btnClearFilter_Click(object sender, EventArgs e)
        {
            initGrid();
        }

        // ── 複式篩選：依專案序號／模組編碼／零件號碼過濾目前清單 ──────────────
        private void btnMultiFilter_Click(object sender, EventArgs e)
        {
            using var frm = new FrmProjectProcurementFilter(_list);
            if (frm.ShowDialog(this) != DialogResult.OK) return;
            var filtered = _list.Where(x =>
                (string.IsNullOrEmpty(frm.ProjectNo) || (x.專案序號 ?? "").Contains(frm.ProjectNo)) &&
                (string.IsNullOrEmpty(frm.ModuleCode) || (x.模組編碼 ?? "").Contains(frm.ModuleCode)) &&
                (string.IsNullOrEmpty(frm.PartNo) || (x.零件號碼 ?? "").Contains(frm.PartNo))
            ).ToList();
            FillGrid(filtered);
        }

        private void btnPrint_Click(object sender, EventArgs e) => MessageBox.Show("此功能尚未開放");

        // ── 點擊「查詢進貨」按鈕欄或雙擊入庫移轉日：開啟進貨查詢（待開發） ──
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (e.ColumnIndex == colInquiry.Index)
            {
                MessageBox.Show("此功能尚未開放");
            }
        }

        private void dataGridView1_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dataGridView1.IsCurrentCellDirty)
            {
                dataGridView1.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            _dirtyRows.Add(e.RowIndex);
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
        }

        private 採購計畫 CollectRowData(DataGridViewRow row)
        {
            return new 採購計畫
            {
                採購識別碼 = row.Cells[colPurchaseId.Index].Value?.ToString(),
                零件分類 = row.Cells[colPartType.Index].Value?.ToString(),
                採購人員 = row.Cells[colPurchaser.Index].Value?.ToString(),
                實際採購日 = row.Cells[colActualPurchaseDate.Index].Value?.ToString(),
                預計到貨日 = row.Cells[colExpectedArrival.Index].Value?.ToString(),
                倉管人員 = row.Cells[colWarehouseStaff.Index].Value?.ToString(),
                入庫移轉日 = row.Cells[colStockInDate.Index].Value?.ToString(),
                驗收合格 = row.Cells[colAcceptance.Index].Value?.ToString(),
            };
        }

        // ── 只更新實際有異動之列，且僅更新採購追蹤欄位 ─────────────────────
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_dirtyRows.Count == 0)
            {
                MessageBox.Show("沒有資料異動，無需儲存");
                return;
            }
            if (MessageBox.Show("確定儲存?", "確認", MessageBoxButtons.YesNo) == DialogResult.No) return;

            foreach (int rowIndex in _dirtyRows)
            {
                if (rowIndex >= dataGridView1.Rows.Count) continue;
                var row = dataGridView1.Rows[rowIndex];
                string purchaseId = row.Cells[colPurchaseId.Index].Value?.ToString();
                if (string.IsNullOrEmpty(purchaseId)) continue;
                var form = CollectRowData(row);
                var rep = new ProjectProcurementController().UpdateProjectProcurement(form);
                if (!string.IsNullOrEmpty(rep.ErrorMessage))
                {
                    MessageBox.Show(rep.ErrorMessage);
                    return;
                }
            }
            MessageBox.Show("儲存成功!");
            dataGridView1.ReadOnly = true;
            _dirtyRows.Clear();
            initGrid();
        }

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
    }
}
