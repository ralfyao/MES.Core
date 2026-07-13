using DigiERP.Common;
using MES.Core.Model;
using MES.WebAPI.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DigiERP.UserControl.Inventory.ToBuy
{
    public partial class ToButListControl : CommonUserControl
    {
        private static string id = "6D1B4A29-9E7C-4A3D-8B5F-2C6E9A1D4F87";

        private static readonly string[] Categories = { "客戶訂購", "專案增購", "安全庫存", "機台零件", "售後維修" };

        private enum ViewMode { Open, Closed, None }
        private ViewMode _mode = ViewMode.None;

        private List<B請購需求> _list = new List<B請購需求>();
        private Dictionary<string, A材料> _itemMap = new Dictionary<string, A材料>();
        private Dictionary<string, B廠商設定> _supplierMap = new Dictionary<string, B廠商設定>();
        private HashSet<int> _dirtyRows = new HashSet<int>();

        public ToButListControl()
        {
            if (!chkPrivilege(id))
            {
                MessageBox.Show("非授權使用者無法使用此功能!");
                Dispose();
                return;
            }
            InitializeComponent();
            colCategory.Items.AddRange(Categories);
            initGrid();
        }

        // ── 依目前模式（未結案／已結案）重新載入資料 ─────────────────────────
        private void initGrid()
        {
            initLookups();

            var rep = new ProcurementController().AllPurchaseRequestList();
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }
            _list = rep.resultList ?? new List<B請購需求>();
            ApplyFilter();
        }

        private void ApplyFilter()
        {
            //bool closed = _mode == ViewMode.Closed;
            var list = _list.ToList();
            if (_mode == ViewMode.Closed)
            {
                list = _list.Where(x=>x.結案 == true).ToList();
            }
            else if (_mode == ViewMode.Open)
            {
                list = _list.Where(x => x.結案 == false).ToList();
            }
            FillGrid(list);
        }

        private void initLookups()
        {
            var itemRep = new ItemController().ItemList();
            if (!string.IsNullOrEmpty(itemRep.ErrorMessage))
            {
                MessageBox.Show(itemRep.ErrorMessage);
                return;
            }
            var items = itemRep.resultList ?? new List<A材料>();
            _itemMap = items.Where(x => !string.IsNullOrEmpty(x.產品編號))
                .GroupBy(x => x.產品編號!.Trim())
                .ToDictionary(g => g.Key, g => g.First());
            colItemNo.Items.Clear();
            colItemNo.Items.AddRange(_itemMap.Keys.ToList());
            //foreach (var itemNo in _itemMap.Keys) colItemNo.Items.Add(itemNo);

            var supplierRep = new SupplierController().GetAllSupplierList();
            if (!string.IsNullOrEmpty(supplierRep.ErrorMessage))
            {
                MessageBox.Show(supplierRep.ErrorMessage);
                return;
            }
            var suppliers = supplierRep.resultList ?? new List<B廠商設定>();
            _supplierMap = suppliers.Where(x => !string.IsNullOrEmpty(x.廠商編號))
                .GroupBy(x => x.廠商編號!.Trim())
                .ToDictionary(g => g.Key, g => g.First());
            colSupplierNo.Items.Clear();
            foreach (var supplierNo in _supplierMap.Keys) colSupplierNo.Items.Add(supplierNo);

            var empRep = new GeneralExpensesController().GetActiveEmployeeList();
            if (!string.IsNullOrEmpty(empRep.ErrorMessage))
            {
                MessageBox.Show(empRep.ErrorMessage);
                return;
            }
            var employees = empRep.resultList ?? new List<H員工清冊>();
            colRequester.Items.Clear();
            foreach (var no in employees.Select(x => x.工號?.Trim()).Where(no => !string.IsNullOrEmpty(no)).Distinct())
            {
                colRequester.Items.Add(no);
            }
            colDept.Items.Clear();
            foreach (var d in employees.Select(x => x.部門?.Trim()).Where(d => !string.IsNullOrEmpty(d)).Distinct().OrderBy(d => d))
            {
                colDept.Items.Add(d);
            }
        }

        // ── 若儲存格值不在下拉清單中，保底避免拋例外（正常情況已由 EnsureComboItem 補入清單）──
        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
        }

        // ── 若資料庫的值不在目前下拉清單中（如主檔已停用/異動），強制塞入清單以完整顯示 ──
        private static void EnsureComboItem(DataGridViewComboBoxColumn col, string value)
        {
            if (string.IsNullOrEmpty(value)) return;
            if (!col.Items.Contains(value))
            {
                col.Items.Add(value);
            }
        }

        private void FillGrid(List<B請購需求> list)
        {
            dataGridView1.Rows.Clear();
            _dirtyRows.Clear();
            foreach (var x in list)
            {
                int i = dataGridView1.Rows.Add();
                var row = dataGridView1.Rows[i];
                string dept = x.請購部門?.Trim();
                string requester = x.請購人員?.Trim();
                string category = x.請購類別?.Trim();
                string itemNo = x.品項編號?.Trim();
                string supplierNo = x.指定供應廠商?.Trim();
                EnsureComboItem(colDept, dept);
                EnsureComboItem(colRequester, requester);
                EnsureComboItem(colCategory, category);
                EnsureComboItem(colItemNo, itemNo);
                EnsureComboItem(colSupplierNo, supplierNo);

                row.Cells[colDate.Index].Value = x.日期;
                row.Cells[colDept.Index].Value = dept;
                row.Cells[colRequester.Index].Value = requester;
                row.Cells[colCategory.Index].Value = category;
                row.Cells[colItemNo.Index].Value = itemNo;
                row.Cells[colItemName.Index].Value = x.品名規格;
                row.Cells[colUnit.Index].Value = x.單位;
                row.Cells[colQty.Index].Value = x.數量;
                row.Cells[colUrgent.Index].Value = x.緊急 ?? false;
                row.Cells[colNeedDate.Index].Value = x.需求日期;
                row.Cells[colPurpose.Index].Value = x.用途;
                row.Cells[colSupplierNo.Index].Value = supplierNo;
                row.Cells[colSupplierName.Index].Value = x.廠商簡稱;
                row.Cells[colRemark.Index].Value = x.註記;
                row.Cells[colPoNo.Index].Value = x.採購單號;
                row.Cells[colClosed.Index].Value = x.結案 ?? false;
                row.Cells[colSerial.Index].Value = x.請購序號;
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            _mode = ViewMode.Open;
            initGrid();
        }

        private void btnClosed_Click(object sender, EventArgs e)
        {
            _mode = ViewMode.Closed;
            initGrid();
        }

        // ── 修改：解鎖表格，允許新增列或編輯既有資料 ───────────────────────
        private void btnModify_Click(object sender, EventArgs e)
        {
            dataGridView1.ReadOnly = false;
            dataGridView1.AllowUserToAddRows = true;
            _dirtyRows.Clear();
        }

        // ── 項目編號選定後帶出品名／依請購類別帶出單位 ──────────────────────
        private void RecalcItemFields(DataGridViewRow row)
        {
            string itemNo = row.Cells[colItemNo.Index].Value?.ToString();
            _itemMap.TryGetValue(itemNo ?? "", out var item);
            row.Cells[colItemName.Index].Value = item?.品名規格;
            if (item == null) return;
            string category = row.Cells[colCategory.Index].Value?.ToString();
            row.Cells[colUnit.Index].Value = category switch
            {
                "客戶訂購" or "專案增購" => item.採購單位,
                "安全庫存" or "機台零件" => item.庫存單位,
                "售後維修" => item.銷售單位,
                _ => row.Cells[colUnit.Index].Value?.ToString()
            };
        }

        private void RecalcSupplierName(DataGridViewRow row)
        {
            string supplierNo = row.Cells[colSupplierNo.Index].Value?.ToString();
            _supplierMap.TryGetValue(supplierNo ?? "", out var supplier);
            row.Cells[colSupplierName.Index].Value = supplier?.廠商簡稱;
        }

        // ── 下拉選定後立即提交，觸發 CellValueChanged ──────────────────────
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
            var row = dataGridView1.Rows[e.RowIndex];
            if (e.ColumnIndex == colItemNo.Index || e.ColumnIndex == colCategory.Index)
            {
                RecalcItemFields(row);
            }
            else if (e.ColumnIndex == colSupplierNo.Index)
            {
                RecalcSupplierName(row);
            }
        }

        private B請購需求 CollectRowData(DataGridViewRow row)
        {
            int? serial = int.TryParse(row.Cells[colSerial.Index].Value?.ToString(), out var s) ? s : (int?)null;
            float.TryParse(row.Cells[colQty.Index].Value?.ToString(), out var qty);
            return new B請購需求
            {
                請購序號 = serial,
                日期 = row.Cells[colDate.Index].Value?.ToString(),
                請購部門 = row.Cells[colDept.Index].Value?.ToString(),
                請購人員 = row.Cells[colRequester.Index].Value?.ToString(),
                請購類別 = row.Cells[colCategory.Index].Value?.ToString(),
                品項編號 = row.Cells[colItemNo.Index].Value?.ToString(),
                品名規格 = row.Cells[colItemName.Index].Value?.ToString(),
                單位 = row.Cells[colUnit.Index].Value?.ToString(),
                數量 = qty,
                緊急 = row.Cells[colUrgent.Index].Value as bool? ?? false,
                需求日期 = row.Cells[colNeedDate.Index].Value?.ToString(),
                用途 = row.Cells[colPurpose.Index].Value?.ToString(),
                指定供應廠商 = row.Cells[colSupplierNo.Index].Value?.ToString(),
                廠商簡稱 = row.Cells[colSupplierName.Index].Value?.ToString(),
                註記 = row.Cells[colRemark.Index].Value?.ToString(),
                採購單號 = row.Cells[colPoNo.Index].Value?.ToString(),
                結案 = row.Cells[colClosed.Index].Value as bool? ?? false,
            };
        }

        // ── 只儲存實際有異動（新增或修改）之列 ──────────────────────────
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
                if (row.IsNewRow) continue;
                var form = CollectRowData(row);
                var rep = new ProcurementController().SavePurchaseRequest(form);
                if (!string.IsNullOrEmpty(rep.ErrorMessage))
                {
                    MessageBox.Show(rep.ErrorMessage);
                    return;
                }
            }
            MessageBox.Show("儲存成功!");
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
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
