using DigiERP.Common;
using MES.Core.Model;
using MES.WebAPI.Controllers;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DigiERP.UserControl.Production.TestValidationReport
{
    // ── 試機驗收單總覽：賣方廠驗收單 為主表，聯集工令單/產品規格單資料 ────────
    public partial class TestValidationReportControl : CommonUserControl
    {
        private static string id = "9F1E4D2A-7B3C-4A6E-8D5F-1C2B3A4D5E6F";

        public TestValidationReportControl()
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
            var rep = new ProjectProgressController().GetTestValidationReportList();
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }

            dataGridView1.Rows.Clear();
            foreach (var x in rep.resultList ?? new List<試機驗收單>())
            {
                int i = dataGridView1.Rows.Add();
                var row = dataGridView1.Rows[i];
                row.Cells[colProjectNo.Index].Value = x.專案序號;
                row.Cells[colAcceptDate.Index].Value = x.日期;
                row.Cells[colCustomerName.Index].Value = x.客戶名稱;
                row.Cells[colContact.Index].Value = x.聯絡人;
                row.Cells[colMachineModel.Index].Value = x.機台型號;
                row.Cells[colMachineName.Index].Value = x.機台名稱;
                row.Cells[colResult.Index].Value = x.內容說明結果;
                row.Cells[colCloseDate.Index].Value = x.結關日期;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e) => MessageBox.Show("此功能尚未開放");

        // ── 點選專案序號，開啟(或切換至)對應的賣方廠驗收單頁籤 ──────────────
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || dataGridView1.Columns[e.ColumnIndex] != colProjectNo) return;
            string projectNo = dataGridView1.Rows[e.RowIndex].Cells[colProjectNo.Index].Value?.ToString();
            if (string.IsNullOrEmpty(projectNo)) return;

            if (!(Parent is TabPage) || !(((TabPage)Parent).Parent is TabControl)) return;
            TabControl tabControl = (TabControl)((TabPage)Parent).Parent;
            string tabName = "TestValidationReport_" + projectNo;
            foreach (TabPage page in tabControl.TabPages)
            {
                if (page.Name == tabName)
                {
                    tabControl.SelectedTab = page;
                    return;
                }
            }
            var ctrl = new TestValidationMaintainControl { Dock = DockStyle.Fill };
            var tab = new TabPage("賣方廠驗收單-" + projectNo) { Name = tabName };
            tab.Controls.Add(ctrl);
            tabControl.TabPages.Add(tab);
            tabControl.SelectedTab = tab;
            ctrl.LoadData(projectNo);
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
