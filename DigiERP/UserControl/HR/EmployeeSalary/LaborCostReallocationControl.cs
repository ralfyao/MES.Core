using DigiERP.Common;
using MES.Core.Model;
using MES.WebAPI.Controllers;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DigiERP.UserControl.HR.EmployeeSalary
{
    // ── 人工成本重整：比照 PITS-2025.accdb 之「H-人工成本重整」表單，資料來源
    //    為查詢「H月工時成本」(H員工月工時成本 LEFT JOIN H員工清冊 取姓名，
    //    篩選目前開啟的年月)；「人工成本重整」按鈕比照原巨集「更新單價-人工」
    //    +「H人工成本單價導入」查詢邏輯：依此清單每一列算出的工時成本
    //    ((應領金額-請假扣款-遲到扣款)/出勤時數)，寫回 工作紀錄A.單價(該員工
    //    當月所有工作紀錄)，供各專案工作紀錄的實際人工成本計算使用；僅本月
    //    已結帳才可從「薪資月結」畫面呼叫進入(比照原巨集「月工資成本導入」
    //    按鈕的擋帳條件) ─────────────────────────────────────────────────
    public partial class LaborCostReallocationControl : CommonUserControl
    {
        private static string id = "D0B11A12-3F8C-4A2A-BBFE-64A31CFB5036";

        private string _yearMonth;

        public LaborCostReallocationControl()
        {
            if (!chkPrivilege(id))
            {
                MessageBox.Show("非授權使用者無法使用此功能!");
                Dispose();
                return;
            }
            InitializeComponent();
        }

        // ── 進入點：由「薪資月結」的「月工資成本導入」按鈕呼叫，帶入目前
        //    開啟的年月(比照原巨集依賴 [Forms]![H-薪資月結]![年月]) ─────────
        internal void LoadData(string yearMonth)
        {
            _yearMonth = yearMonth;
            lblYearMonth.Text = "年月：" + yearMonth;
            var rep = new HRController().GetSalaryCloseByPeriod(yearMonth);
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }
            dataGridView1.Rows.Clear();
            foreach (var x in rep.result?.detailList ?? new List<H員工月工時成本>())
            {
                int i = dataGridView1.Rows.Add();
                var row = dataGridView1.Rows[i];
                row.Cells[colEmpNo.Index].Value = x.工號;
                row.Cells[colAmount.Index].Value = x.應領金額;
                row.Cells[colLeaveDeduct.Index].Value = x.請假扣款;
                row.Cells[colLateDeduct.Index].Value = x.遲到扣款;
                row.Cells[colAttendHours.Index].Value = x.出勤時數;
                double.TryParse(x.應領金額?.ToString(), out var amount);
                double.TryParse(x.請假扣款?.ToString(), out var leave);
                double.TryParse(x.遲到扣款?.ToString(), out var late);
                double.TryParse(x.出勤時數?.ToString(), out var hours);
                row.Cells[colLaborCost.Index].Value = hours != 0 ? Math.Round((amount - leave - late) / hours, 2) : (double?)null;
            }
            LoadEmployeeNames();
        }

        // ── 姓名：依工號對照 H員工清冊(涵蓋全部員工，含已離職) ─────────────
        private void LoadEmployeeNames()
        {
            var rep = new HRController().GetAllEmployeeBasicList();
            if (!string.IsNullOrEmpty(rep.ErrorMessage)) return;
            var map = new Dictionary<string, string>();
            foreach (var x in rep.resultList ?? new List<H員工清冊>())
            {
                if (!string.IsNullOrEmpty(x.工號) && !map.ContainsKey(x.工號)) map[x.工號] = x.姓名;
            }
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                string empNo = row.Cells[colEmpNo.Index].Value?.ToString();
                row.Cells[colName.Index].Value = map.TryGetValue(empNo ?? "", out var nm) ? nm : "";
            }
        }

        // ── 人工成本重整：將本清單每位員工的工時成本寫回 工作紀錄A.單價 ──────
        private void btnRecalc_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_yearMonth)) return;
            if (MessageBox.Show("確定要執行人工成本重整?", "請選擇", MessageBoxButtons.YesNo) != DialogResult.Yes) return;

            var rep = new HRController().RecalcLaborCost(_yearMonth);
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }
            MessageBox.Show(rep.result);
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
