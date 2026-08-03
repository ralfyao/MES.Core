using DigiERP.Common;
using MES.Core.Model;
using MES.WebAPI.Controllers;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DigiERP.UserControl.Production
{
    // ── 異常報告總覽：列出所有異常矯正措施報告 ─────────────────────────
    public partial class AbnormalCorrectionReportOverviewControl : CommonUserControl
    {
        private static string id = "6E1F3A2B-9C4D-4E7F-8A1B-2C3D4E5F6A7B";

        public AbnormalCorrectionReportOverviewControl()
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
            var rep = new ProjectProgressController().GetAbnormalCorrectionReportList();
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }

            dataGridView1.Rows.Clear();
            foreach (var x in rep.resultList ?? new List<異常矯正措施報告>())
            {
                int i = dataGridView1.Rows.Add();
                var row = dataGridView1.Rows[i];
                row.Cells[colFormNo.Index].Value = x.單號;
                row.Cells[colDate.Index].Value = x.日期;
                row.Cells[colProjectNo.Index].Value = x.專案序號;
                row.Cells[colModuleCode.Index].Value = x.模組編碼;
                row.Cells[colModuleName.Index].Value = x.模組名稱;
                row.Cells[colPartNo.Index].Value = x.零件號碼;
                row.Cells[colPartName.Index].Value = x.品名;
                row.Cells[colSourceDoc.Index].Value = x.來源單據;
                row.Cells[colAbnormalSource.Index].Value = x.異常來源;
                row.Cells[colDesignChange.Index].Value = x.設計變更 ?? false;
            }
        }

        // ── 點選單號，開啟(或切換至)該筆異常矯正措施報告頁籤 ──────────────
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || dataGridView1.Columns[e.ColumnIndex] != colFormNo) return;
            string sourceDoc = dataGridView1.Rows[e.RowIndex].Cells[colSourceDoc.Index].Value?.ToString();
            string projectNo = dataGridView1.Rows[e.RowIndex].Cells[colProjectNo.Index].Value?.ToString();
            string moduleCode = dataGridView1.Rows[e.RowIndex].Cells[colModuleCode.Index].Value?.ToString();
            string moduleName = dataGridView1.Rows[e.RowIndex].Cells[colModuleName.Index].Value?.ToString();
            if (string.IsNullOrEmpty(sourceDoc)) return;

            if (!(Parent is TabPage) || !(((TabPage)Parent).Parent is TabControl)) return;
            TabControl tabControl = (TabControl)((TabPage)Parent).Parent;
            string tabName = "AbnormalCorrection_" + sourceDoc;
            foreach (TabPage page in tabControl.TabPages)
            {
                if (page.Name == tabName)
                {
                    tabControl.SelectedTab = page;
                    return;
                }
            }
            var ctrl = new AbnormalCorrectionReportControl { Dock = DockStyle.Fill };
            var tab = new TabPage("異常矯正單-" + sourceDoc) { Name = tabName };
            tab.Controls.Add(ctrl);
            tabControl.TabPages.Add(tab);
            tabControl.SelectedTab = tab;
            ctrl.LoadBySourceDoc(sourceDoc, projectNo, moduleCode, moduleName);
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
