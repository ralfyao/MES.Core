using DigiERP.Common;
using MES.Core.Model;
using MES.WebAPI.Controllers;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DigiERP.UserControl.HR.EmployeeSalary
{
    // ── 薪資月結總覽：比照 PITS-2025.accdb 之「H-薪資月結總覽」表單，列出
    //    H員工月 全部年月(結帳年月/月底日期/建檔/建檔日/結帳/結帳日/月結/
    //    修改/修改日)；點選「結帳年月」欄位會切回「薪資月結」頁籤並跳轉至
    //    該筆(原巨集為雙擊 年月 欄位 OpenForm H-薪資月結 ReadOnly，此處改採
    //    頁籤切換，比照「加班申請明細查詢」點選單號跳轉之慣例)；「新增」
    //    按鈕(原 Command173)同樣需具編輯權限，切到「薪資月結」頁籤並開一
    //    張空白月份 ─────────────────────────────────────────────────────
    public partial class EmployeeSalaryCloseOverviewControl : CommonUserControl
    {
        private static string id = "B2FEB47C-A30C-49FE-BC5F-98787F5937F8";

        public EmployeeSalaryCloseOverviewControl()
        {
            if (!chkPrivilege(id))
            {
                MessageBox.Show("非授權使用者無法使用此功能!");
                Dispose();
                return;
            }
            InitializeComponent();
            btnNew.Visible = chkEditPrivilege(id);
            LoadData();
        }

        private void LoadData()
        {
            var rep = new HRController().GetSalaryCloseList();
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }
            dataGridView1.Rows.Clear();
            foreach (var x in rep.resultList ?? new List<H員工月>())
            {
                int i = dataGridView1.Rows.Add();
                var row = dataGridView1.Rows[i];
                row.Cells[colYearMonth.Index].Value = x.年月;
                row.Cells[colMonthEndDate.Index].Value = x.月底日;
                row.Cells[colCreator.Index].Value = x.建檔;
                row.Cells[colCreateDate.Index].Value = x.建檔日;
                row.Cells[colApprover.Index].Value = x.核准;
                row.Cells[colApproveDate.Index].Value = x.核准日;
                row.Cells[colClosed.Index].Value = x.月結 ?? false;
                row.Cells[colModifier.Index].Value = x.修改;
                row.Cells[colModifyDate.Index].Value = x.修改日;
            }
        }

        // ── 點選結帳年月：切回「薪資月結」頁籤並跳轉至該筆 ──────────────────
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex != colYearMonth.Index) return;
            string yearMonth = dataGridView1.Rows[e.RowIndex].Cells[colYearMonth.Index].Value?.ToString();
            if (string.IsNullOrEmpty(yearMonth)) return;

            var existing = FindSalaryCloseControl();
            if (existing != null)
            {
                existing.LoadByYearMonth(yearMonth);
                return;
            }
            var ctrl = OpenSalaryCloseTab();
            ctrl?.LoadByYearMonth(yearMonth);
        }

        // ── 新增：需具編輯權限(原巨集「系統權限.編修」)，切到「薪資月結」
        //    頁籤並開一張空白月份(比照原巨集 Command173) ──────────────────
        private void btnNew_Click(object sender, EventArgs e)
        {
            if (!chkEditPrivilege(id))
            {
                MessageBox.Show("非經授權，不得進入！");
                return;
            }
            var existing = FindSalaryCloseControl();
            if (existing != null)
            {
                existing.StartNew();
                return;
            }
            var ctrl = OpenSalaryCloseTab();
            ctrl?.StartNew();
        }

        private EmployeeSalaryCloseControl FindSalaryCloseControl()
        {
            if (!(Parent is TabPage) || !(((TabPage)Parent).Parent is TabControl)) return null;
            TabControl tabControl = (TabControl)((TabPage)Parent).Parent;
            foreach (TabPage page in tabControl.TabPages)
            {
                if (page.Controls.Count > 0 && page.Controls[0] is EmployeeSalaryCloseControl existing)
                {
                    tabControl.SelectedTab = page;
                    return existing;
                }
            }
            return null;
        }

        private EmployeeSalaryCloseControl OpenSalaryCloseTab()
        {
            if (!(Parent is TabPage) || !(((TabPage)Parent).Parent is TabControl)) return null;
            TabControl tabControl = (TabControl)((TabPage)Parent).Parent;
            var ctrl = new EmployeeSalaryCloseControl { Dock = DockStyle.Fill };
            var tab = new TabPage("薪資月結");
            tab.Controls.Add(ctrl);
            tabControl.TabPages.Add(tab);
            tabControl.SelectedTab = tab;
            return ctrl;
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
