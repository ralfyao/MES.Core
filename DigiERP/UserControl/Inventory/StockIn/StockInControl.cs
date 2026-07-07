using DigiERP.Common;
using MES.Core.Model;
using MES.WebAPI.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DigiERP.UserControl.Inventory.StockIn
{
    public partial class StockInControl : CommonUserControl
    {
        private static string id = "3F8A1C7E-6B2D-4A19-9E5C-7D4F0B2A8C61";

        // ── 資料來源為單一 JOIN 查詢（B進退貨驗收明細/B進貨驗收單/H員工清冊/B廠商設定），已在後端組好 ──
        private List<B進退貨驗收明細> _rowList = new List<B進退貨驗收明細>();

        public StockInControl()
        {
            if (!chkPrivilege(id))
            {
                MessageBox.Show("非授權使用者無法使用此功能!");
                Dispose();
                return;
            }
            InitializeComponent();
        }

        // ── 日期區間篩選：預設不帶出資料，按下此按鈕才查詢 ──────────────────
        private void btnDateFilter_Click(object sender, EventArgs e)
        {
            if (dtFrom.Value.Date > dtTo.Value.Date)
            {
                MessageBox.Show("起始日期不能大於結束日期");
                return;
            }

            var rep = new StockInController().StockInListView(dtFrom.Value.Date, dtTo.Value.Date);
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }

            _rowList = rep.resultList ?? new List<B進退貨驗收明細>();
            ApplyFilter();
        }

        // ── 廠商／專案／品名查詢：於已依日期區間查詢出的清單上再次篩選 ────────
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        private void ApplyFilter()
        {
            string supplier = txtSupplier.Text.Trim();
            string project = txtProject.Text.Trim();
            string itemName = txtItemName.Text.Trim();

            var rows = _rowList.Where(x =>
                (string.IsNullOrEmpty(supplier) || (x.廠商編號 ?? "").Contains(supplier) || (x.廠商簡稱 ?? "").Contains(supplier)) &&
                (string.IsNullOrEmpty(project) || (x.專案序號 ?? "").Contains(project)) &&
                (string.IsNullOrEmpty(itemName) || (x.品名規格 ?? "").Contains(itemName))
            ).ToList();

            FillGrid(rows);
        }

        private void FillGrid(List<B進退貨驗收明細> rows)
        {
            dataGridView1.Rows.Clear();
            foreach (var x in rows)
            {
                var row = new DataGridViewRow();
                row.CreateCells(dataGridView1);
                int i = 0;
                row.Cells[i++].Value = x.單號;
                row.Cells[i++].Value = x.日期;
                row.Cells[i++].Value = x.廠商編號;
                row.Cells[i++].Value = x.廠商簡稱;
                row.Cells[i++].Value = x.姓名;
                row.Cells[i++].Value = x.採購覆核;
                row.Cells[i++].Value = x.專案序號;
                row.Cells[i++].Value = x.品項編號;
                row.Cells[i++].Value = x.品名規格;
                row.Cells[i++].Value = x.收貨數量;
                row.Cells[i++].Value = x.合格數量;
                row.Cells[i++].Value = x.特採數量;
                row.Cells[i++].Value = x.退回數量;
                row.Cells[i++].Value = x.退貨單號;
                dataGridView1.Rows.Add(row);
            }
        }

        // ── 新增：開啟進貨單維護畫面 ───────────────────────────────────────
        private void btnAdd_Click(object sender, EventArgs e)
        {
            OpenMaintainControl(null, "新增");
        }

        // ── 雙擊列表：開啟該筆進貨單進行檢視／修改 ───────────────────────────
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            string no = dataGridView1.Rows[e.RowIndex].Cells[colNo.Index].Value?.ToString();
            if (string.IsNullOrEmpty(no)) return;
            OpenMaintainControl(new B進貨驗收單 { 單號 = no }, "修改");
        }

        private void OpenMaintainControl(B進貨驗收單 header, string mode)
        {
            for (int i = panel2.Controls.Count - 1; i >= 0; i--)
            {
                if (panel2.Controls[i] is StockInMaintainControl m)
                {
                    panel2.Controls.RemoveAt(i);
                    m.Dispose();
                }
            }
            var maintain = header != null ? new StockInMaintainControl(header) : new StockInMaintainControl();
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

        private void btnSave_Click(object sender, EventArgs e) => MessageBox.Show("此功能尚未開放");

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
    }
}
