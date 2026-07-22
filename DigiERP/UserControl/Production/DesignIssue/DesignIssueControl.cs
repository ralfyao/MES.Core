using DigiERP.Common;
using MES.Core.Model;
using MES.WebAPI.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DigiERP.UserControl.Production
{
    // ── 圖面發行總覽：列出「圖面發行轉BOM」建立後尚未指定用途的專案模組用料清單明細，
    //    可依專案序號/零件號碼/品名篩選，雙擊列進入該BOM編號的組裝維護畫面 ──────────
    public partial class DesignIssueControl : CommonUserControl
    {
        private static string id = "F3AE5F18-706F-48C6-B7A6-665FB3F04BA3";

        private List<專案用料總覽> _fullList = new List<專案用料總覽>();

        public DesignIssueControl()
        {
            if (!chkPrivilege(id))
            {
                MessageBox.Show("非授權使用者無法使用此功能!");
                Dispose();
                return;
            }
            InitializeComponent();
            LoadData();
        }

        internal void LoadData()
        {
            var rep = new ProjectProgressController().GetModuleMaterialOverviewList();
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }
            _fullList = rep.resultList ?? new List<專案用料總覽>();
            ApplyFilter();
        }

        // ── 專案序號/零件號碼/品名 為模糊篩選，未輸入的欄位不參與過濾 ─────────
        private void ApplyFilter()
        {
            string projectNo = txtProjectNoFilter.Text.Trim();
            string partNo = txtPartNoFilter.Text.Trim();
            string partName = txtPartNameFilter.Text.Trim();

            var filtered = _fullList.Where(x =>
                (string.IsNullOrEmpty(projectNo) || (x.專案序號 ?? "").Contains(projectNo, StringComparison.OrdinalIgnoreCase)) &&
                (string.IsNullOrEmpty(partNo) || (x.零件號碼 ?? "").Contains(partNo, StringComparison.OrdinalIgnoreCase)) &&
                (string.IsNullOrEmpty(partName) || (x.品名 ?? "").Contains(partName, StringComparison.OrdinalIgnoreCase)))
                .ToList();

            FillGrid(filtered);
        }

        private void FillGrid(List<專案用料總覽> list)
        {
            dataGridView1.Rows.Clear();
            foreach (var x in list)
            {
                var row = new DataGridViewRow();
                row.CreateCells(dataGridView1);
                int i = 0;
                row.Cells[i++].Value = x.BOM編號;
                row.Cells[i++].Value = x.專案序號;
                row.Cells[i++].Value = x.模組編碼;
                row.Cells[i++].Value = x.模組名稱;
                row.Cells[i++].Value = x.零件號碼;
                row.Cells[i++].Value = x.品名;
                row.Cells[i++].Value = x.描述;
                row.Cells[i++].Value = x.數量;
                dataGridView1.Rows.Add(row);
            }
        }

        private void FilterField_TextChanged(object sender, EventArgs e) => ApplyFilter();

        private void btnClearFilter_Click(object sender, EventArgs e)
        {
            txtProjectNoFilter.Text = "";
            txtPartNoFilter.Text = "";
            txtPartNameFilter.Text = "";
        }

        // ── 雙擊列：開啟(或切回)該BOM編號的專案模組用料維護畫面 ─────────────
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            string bomNo = dataGridView1.Rows[e.RowIndex].Cells[colBomNo.Index].Value?.ToString();
            if (string.IsNullOrEmpty(bomNo)) return;
            OpenModuleMaterialMaintain(bomNo);
        }

        private void OpenModuleMaterialMaintain(string bomNo)
        {
            if (!(Parent is TabPage) || !(((TabPage)Parent).Parent is TabControl)) return;
            TabControl tabControl = (TabControl)((TabPage)Parent).Parent;
            string tabName = "ModuleMaterialMaintain_" + bomNo;
            foreach (TabPage page in tabControl.TabPages)
            {
                if (page.Name == tabName)
                {
                    tabControl.SelectedTab = page;
                    return;
                }
            }
            var ctrl = new ModuleMaterialMaintainControl();
            if (ctrl.IsDisposed) return;
            ctrl.LoadData(bomNo);
            ctrl.Dock = DockStyle.Fill;
            var tab = new TabPage(bomNo + " 專案模組用料") { Name = tabName };
            tab.Controls.Add(ctrl);
            tabControl.TabPages.Add(tab);
            tabControl.SelectedTab = tab;
            tabControl.SizeMode = TabSizeMode.Fixed;
            tabControl.ItemSize = new System.Drawing.Size(120, 30);
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
