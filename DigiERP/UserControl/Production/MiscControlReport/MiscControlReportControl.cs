using DigiERP.Common;
using MES.Core.Model;
using MES.WebAPI.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DigiERP.UserControl.Production.MiscControlReport
{
    // ── 零件管制報告總覽：列出已建立零件管制單號的採購計畫，可依專案序號/零件號碼/品名篩選 ──
    public partial class MiscControlReportControl : CommonUserControl
    {
        private static string id = "1E8E7C43-A48D-4C8D-85D2-D07D6A185D7E";

        private List<採購計畫> _fullList = new List<採購計畫>();

        public MiscControlReportControl()
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

        private void LoadData()
        {
            var rep = new ProjectProcurementController().GetMiscControlReportList();
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }
            _fullList = rep.resultList ?? new List<採購計畫>();
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

        private void FillGrid(List<採購計畫> list)
        {
            dataGridView1.Rows.Clear();
            foreach (var x in list)
            {
                int i = dataGridView1.Rows.Add();
                var row = dataGridView1.Rows[i];
                row.Cells[colControlNo.Index].Value = x.零件管制單號;
                row.Cells[colProjectNo.Index].Value = x.專案序號;
                row.Cells[colModuleCode.Index].Value = x.模組編碼;
                row.Cells[colModuleName.Index].Value = x.模組名稱;
                row.Cells[colPartNo.Index].Value = x.零件號碼;
                row.Cells[colPartName.Index].Value = x.品名;
                row.Cells[colPartType.Index].Value = x.零件分類;
                row.Cells[colQty.Index].Value = x.數量;
                row.Cells[colAcceptance.Index].Value = x.驗收合格;
            }
        }

        private void FilterField_TextChanged(object sender, EventArgs e) => ApplyFilter();

        private void btnClearFilter_Click(object sender, EventArgs e)
        {
            txtProjectNoFilter.Text = "";
            txtPartNoFilter.Text = "";
            txtPartNameFilter.Text = "";
        }

        // ── 點選零件管制單號，開啟(或切換至)零件管制報告書頁籤 ────────────────
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || dataGridView1.Columns[e.ColumnIndex] != colControlNo) return;
            string controlNo = dataGridView1.Rows[e.RowIndex].Cells[colControlNo.Index].Value?.ToString();
            if (string.IsNullOrEmpty(controlNo)) return;

            if (!(Parent is TabPage) || !(((TabPage)Parent).Parent is TabControl)) return;
            TabControl tabControl = (TabControl)((TabPage)Parent).Parent;
            string tabName = "MiscControlOrder_" + controlNo;
            foreach (TabPage page in tabControl.TabPages)
            {
                if (page.Name == tabName)
                {
                    tabControl.SelectedTab = page;
                    return;
                }
            }
            var ctrl = new MiscControlOrderControl { Dock = DockStyle.Fill };
            var tab = new TabPage("零件管制報告書-" + controlNo) { Name = tabName };
            tab.Controls.Add(ctrl);
            tabControl.TabPages.Add(tab);
            tabControl.SelectedTab = tab;
            tabControl.SizeMode = TabSizeMode.Normal;
            ctrl.LoadData(controlNo);
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
