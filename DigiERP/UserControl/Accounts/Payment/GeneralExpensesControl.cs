using DigiERP.Common;
using MES.Core.Model;
using MES.WebAPI.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DigiERP.UserControl.Accounts.Payment
{
    public partial class GeneralExpensesControl : CommonUserControl
    {
        private static string id = "8F2D6A19-4C7E-4B3D-9A1F-6E5C8D2B7A94";

        private enum ViewMode { Open, Closed }

        private ViewMode _mode = ViewMode.Open;
        private List<總務支出單列表> _list = new List<總務支出單列表>();
        private Dictionary<string, B廠商設定> _supplierMap = new Dictionary<string, B廠商設定>();

        public GeneralExpensesControl()
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

        // ── 讀取廠商簡稱對照表 ────────────────────────────────────────────
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

        // ── 依目前模式（未結案／已結案）重新載入資料 ─────────────────────────
        private void initGrid()
        {
            initSupplierMap();

            var rep = new GeneralExpensesController().GetGeneralExpensesList();
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }
            _list = rep.resultList ?? new List<總務支出單列表>();

            lblTitle.Text = _mode == ViewMode.Closed ? "總務支出單總覽-已結案" : "總務支出單總覽-未結案";

            ApplyFilter();
        }

        private void ApplyFilter()
        {
            bool closed = _mode == ViewMode.Closed;
            var list = _list.Where(x => !string.IsNullOrEmpty(x.結案) == closed).ToList();
            FillGrid(list);
        }

        private void FillGrid(List<總務支出單列表> list)
        {
            dataGridView1.Rows.Clear();
            foreach (var x in list)
            {
                _supplierMap.TryGetValue(x.廠商編號 ?? "", out var supplier);
                var row = new DataGridViewRow();
                row.CreateCells(dataGridView1);
                int i = 0;
                row.Cells[i++].Value = x.單號;
                row.Cells[i++].Value = x.日期;
                row.Cells[i++].Value = x.廠商編號;
                row.Cells[i++].Value = supplier?.廠商簡稱;
                row.Cells[i++].Value = x.採購類別;
                row.Cells[i++].Value = x.交易條件;
                row.Cells[i++].Value = !string.IsNullOrEmpty(x.結案);
                row.Cells[i++].Value = x.項目編號;
                row.Cells[i++].Value = x.項目名稱;
                row.Cells[i++].Value = x.姓名;
                row.Cells[i++].Value = x.核准;
                dataGridView1.Rows.Add(row);
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            _mode = ViewMode.Open;
            initGrid();
            lblTitle.Text = "總務支出單總覽-未結案";
        }

        private void btnClosed_Click(object sender, EventArgs e)
        {
            _mode = ViewMode.Closed;
            initGrid();
            lblTitle.Text = "總務支出單總覽-已結案";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            OpenMaintainTab(null, "新增");
        }

        // ── 點選單號欄位：於頁籤中開啟該筆總務支出單 ───────────────────────
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex != colNo.Index) return;
            string no = dataGridView1.Rows[e.RowIndex].Cells[colNo.Index].Value?.ToString();
            if (string.IsNullOrEmpty(no)) return;
            OpenMaintainTab(no, "修改");
        }

        private void OpenMaintainTab(string no, string mode)
        {
            if (!(Parent is TabPage) || !(((TabPage)Parent).Parent is TabControl)) return;
            TabControl tabControl = (TabControl)((TabPage)Parent).Parent;
            string tabName = mode == "新增" ? "GeneralExpensesMaintain_New" : $"GeneralExpensesMaintain_{no}";
            foreach (TabPage page in tabControl.TabPages)
            {
                if (page.Name == tabName)
                {
                    tabControl.SelectedTab = page;
                    return;
                }
            }
            var ctrl = new GeneralExpensesMaintainControl();
            ctrl.Dock = DockStyle.Fill;
            ctrl.Saved += (s, args) => initGrid();
            var tab = new TabPage(mode == "新增" ? "總務支出單-新增" : $"總務支出單-{no}") { Name = tabName };
            tab.Controls.Add(ctrl);
            tabControl.TabPages.Add(tab);
            tabControl.SelectedTab = tab;
            tabControl.SizeMode = TabSizeMode.Fixed;
            tabControl.ItemSize = new System.Drawing.Size(120, 30);
            ctrl.LoadData(mode, no);
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
