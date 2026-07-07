using DigiERP.Common;
using MES.Core.Model;
using MES.WebAPI.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DigiERP.UserControl.Inventory.StockInCert
{
    public partial class StockInCertControl : CommonUserControl
    {
        private static string id = "8D2A5C41-3F7B-4E9A-B168-6C0D2E5F9A73";

        private List<F付款> _fullList = new List<F付款>();
        private Dictionary<string, B廠商設定> _supplierMap = new Dictionary<string, B廠商設定>();
        private bool _showClosed = false;

        public StockInCertControl()
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

        // ── 廠商名稱對照表：依廠商編號帶出 ──────────────────────────────────
        private void initSupplierMap()
        {
            var rep = new SupplierController().GetAllSupplierList();
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }
            _supplierMap = (rep.resultList ?? new List<B廠商設定>())
                .Where(x => !string.IsNullOrEmpty(x.廠商編號))
                .GroupBy(x => x.廠商編號!)
                .ToDictionary(g => g.Key, g => g.First());
        }

        private void initGrid()
        {
            initSupplierMap();

            var rep = new StockInController().QueryAllIncomeCertReg();
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }
            _fullList = rep.resultList ?? new List<F付款>();

            lblTitle.Text = _showClosed ? "進項憑證沖銷總覽-已結案" : "進項憑證沖銷總覽-未結案";
            FillGrid();
        }

        private void FillGrid()
        {
            var list = _fullList.Where(x => (x.結案 ?? false) == _showClosed).ToList();

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
                row.Cells[i++].Value = supplier?.廠商名稱;
                row.Cells[i++].Value = x.幣別;
                row.Cells[i++].Value = x.類別;
                row.Cells[i++].Value = x.付款日期;
                row.Cells[i++].Value = x.發票號碼;
                row.Cells[i++].Value = x.MACHINENO;
                row.Cells[i++].Value = x.銀轉金額;
                row.Cells[i++].Value = x.付票金額;
                row.Cells[i++].Value = x.付款總額;
                row.Cells[i++].Value = x.傳票;
                row.Cells[i++].Value = x.結案 ?? false;
                dataGridView1.Rows.Add(row);
            }
        }

        // ── 未結案／已結案：切換式檢視 ─────────────────────────────────────
        private void btnOpen_Click(object sender, EventArgs e)
        {
            _showClosed = false;
            initGrid();
        }

        private void btnClosed_Click(object sender, EventArgs e)
        {
            _showClosed = true;
            initGrid();
        }

        // ── 新增：尚未提供維護畫面 ─────────────────────────────────────────
        private void btnAdd_Click(object sender, EventArgs e) => MessageBox.Show("此功能尚未開放");

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
