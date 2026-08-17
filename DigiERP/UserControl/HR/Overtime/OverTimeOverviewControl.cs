using DigiERP.Common;
using MES.Core.Model;
using MES.WebAPI.Controllers;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DigiERP.UserControl.HR.Overtime
{
    // ── 加班申請明細查詢：比照 PITS-2025.accdb 之「H-加班申請明細查詢」表單，
    //    純唯讀清單，資料來源為 H加班申請單 LEFT JOIN H核准加班明細 ON 單據編號
    //    (一張申請單可展開多列，每段加班一列)，按單據編號遞減排序；原巨集無任何
    //    篩選欄位，僅有 EXIT(關閉)與「員工別加班紀錄表」兩顆按鈕。原「加班申請單」
    //    表單之「總覽」按鈕(原巨集為 OpenForm 本物件 ReadOnly 後 Close 加班申請單)
    //    在本站改採頁籤方式開啟(比照「員工考勤核對」慣例)，故本頁「關閉」為移除
    //    自身頁籤，而非結束整個加班申請單作業 ─────────────────────────────
    public partial class OverTimeOverviewControl : CommonUserControl
    {
        private static string id = "4C7B7E2C-D123-44F1-A607-239F1C6073EA";

        public OverTimeOverviewControl()
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
            var rep = new HRController().GetOvertimeApplyDetailQuery();
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }
            dataGridView1.Rows.Clear();
            foreach (var x in rep.resultList ?? new List<加班申請明細查詢>())
            {
                int i = dataGridView1.Rows.Add();
                var row = dataGridView1.Rows[i];
                row.Cells[colNo.Index].Value = x.單據編號;
                row.Cells[colCostUnit.Index].Value = x.申請單位;
                row.Cells[colApplicant.Index].Value = x.申請人;
                row.Cells[colEmpNo.Index].Value = x.員工編號;
                row.Cells[colEmpName.Index].Value = x.姓名;
                row.Cells[colOtDate.Index].Value = x.加班日期;
                row.Cells[colStart.Index].Value = x.起;
                row.Cells[colEnd.Index].Value = x.訖;
                row.Cells[colHours.Index].Value = x.時數;
                row.Cells[colReason.Index].Value = x.加班事由;
                row.Cells[colApproved.Index].Value = x.核准生效 ?? false;
                row.Cells[colApprover.Index].Value = x.核准人;
            }
        }

        // ── 點選單據編號：切換回「加班申請單」頁籤並跳轉至該筆申請單 ────────
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex != colNo.Index) return;
            string no = dataGridView1.Rows[e.RowIndex].Cells[colNo.Index].Value?.ToString();
            if (string.IsNullOrEmpty(no)) return;
            OpenOvertimeApply(no);
        }

        private void OpenOvertimeApply(string no)
        {
            if (!(Parent is TabPage) || !(((TabPage)Parent).Parent is TabControl)) return;
            TabControl tabControl = (TabControl)((TabPage)Parent).Parent;
            foreach (TabPage page in tabControl.TabPages)
            {
                if (page.Controls.Count > 0 && page.Controls[0] is OverTimeControl existing)
                {
                    tabControl.SelectedTab = page;
                    existing.LoadByNo(no);
                    return;
                }
            }
            // ── 找不到既有「加班申請單」頁籤(理論上不會發生，因總覽必由該頁籤
            //    開啟)，保底另開一個新頁籤 ────────────────────────────────
            var ctrl = new OverTimeControl { Dock = DockStyle.Fill };
            var tab = new TabPage("加班申請單");
            tab.Controls.Add(ctrl);
            tabControl.TabPages.Add(tab);
            tabControl.SelectedTab = tab;
            ctrl.LoadByNo(no);
        }

        // ── 員工別加班紀錄表：開啟(或切換至)頁籤，比照原巨集依「財管權限」
        //    核准與否決定瀏覽全部員工或僅鎖定登入者本人(已於 OverTimeDetail
        //    內部依 chkEditPrivilege 判斷) ───────────────────────────────
        private void btnStaffReport_Click(object sender, EventArgs e)
        {
            if (!(Parent is TabPage) || !(((TabPage)Parent).Parent is TabControl)) return;
            TabControl tabControl = (TabControl)((TabPage)Parent).Parent;
            const string tabName = "OvertimeStaffReport";
            foreach (TabPage page in tabControl.TabPages)
            {
                if (page.Name == tabName)
                {
                    tabControl.SelectedTab = page;
                    return;
                }
            }
            var ctrl = new OverTimeDetail { Dock = DockStyle.Fill };
            var tab = new TabPage("員工加班紀錄表") { Name = tabName };
            tab.Controls.Add(ctrl);
            tabControl.TabPages.Add(tab);
            tabControl.SelectedTab = tab;
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
