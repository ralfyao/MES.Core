using DigiERP.Common;
using DigiERP.Forms.HR.ClockInOut;
using MES.Core.Model;
using MES.WebAPI.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DigiERP.UserControl.HR.ClockInOut
{
    // ── 員工考勤核對：比照 PITS-2025.accdb 之「H-出勤卡」表單，依員工編號 +
    //    查詢起訖日(預設今天往前30天~今天)列出區間內每一天的出勤紀錄(當天無
    //    打卡紀錄亦列出空白列)；純查詢/核對用途，不提供編輯 ────────────────
    public partial class AttendanceCheckControl : CommonUserControl
    {
        private static string id = "44B635F8-A189-4FC1-BA64-E8BEF13D18BC";

        private string _empNo;
        private List<string> _empNoList = new List<string>();
        private H員工清冊 _employee;
        private List<考勤核對列表> _records = new List<考勤核對列表>();

        public AttendanceCheckControl()
        {
            if (!chkPrivilege(id))
            {
                MessageBox.Show("非授權使用者無法使用此功能!");
                Dispose();
                return;
            }
            InitializeComponent();
        }

        // ── 進入點：empNo 為 null 時取員工清冊第一位(比照原 Access 無指定條件開啟) ──
        internal void LoadData(string empNo)
        {
            dtpStartDate.Value = DateTime.Today.AddDays(-31);
            dtpEndDate.Value = DateTime.Today;
            LoadEmpNoList();
            if (string.IsNullOrEmpty(empNo)) empNo = _empNoList.FirstOrDefault();
            _empNo = empNo;
            LoadHeader();
            LoadGrid();
        }

        private void LoadEmpNoList()
        {
            var rep = new HRController().GetEmployeeList();
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }
            _empNoList = (rep.resultList ?? new List<員工清冊列表>())
                .Select(x => x.工號)
                .Where(x => !string.IsNullOrEmpty(x))
                .Distinct()
                .OrderBy(x => x)
                .ToList();
        }

        private void LoadHeader()
        {
            if (string.IsNullOrEmpty(_empNo)) return;
            var rep = new HRController().GetWorkerByNumber(_empNo);
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }
            var x = rep.result ?? new H員工清冊 { 工號 = _empNo };
            _employee = x;
            txtEmpNo.Text = x.工號;
            txtName.Text = x.姓名;
            txtJobTitle.Text = x.職稱;
            txtDept.Text = x.部門;
        }

        private void LoadGrid()
        {
            if (string.IsNullOrEmpty(_empNo))
            {
                dataGridView1.Rows.Clear();
                return;
            }
            string startDate = dtpStartDate.Value.ToString("yyyy/MM/dd");
            string endDate = dtpEndDate.Value.ToString("yyyy/MM/dd");
            var rep = new HRController().GetAttendanceCheckList(_empNo, startDate, endDate);
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }
            _records = rep.resultList ?? new List<考勤核對列表>();
            dataGridView1.Rows.Clear();
            string[] weekdayNames = { "日", "一", "二", "三", "四", "五", "六" };
            foreach (var x in _records)
            {
                int i = dataGridView1.Rows.Add();
                var row = dataGridView1.Rows[i];
                row.Cells[colDate.Index].Value = x.日期;
                row.Cells[colWeekday.Index].Value = DateTime.TryParse(x.日期, out var d) ? weekdayNames[(int)d.DayOfWeek] : "";
                row.Cells[colHoliday.Index].Value = x.例假日 ?? false;
                row.Cells[colShift.Index].Value = x.班次;
                row.Cells[colRegStart.Index].Value = x.正規上班;
                row.Cells[colRegEnd.Index].Value = x.正規下班;
                row.Cells[colOtStart.Index].Value = x.加班上班;
                row.Cells[colOtEnd.Index].Value = x.加班下班;
                row.Cells[colWorkHours.Index].Value = x.出勤時數;
                row.Cells[colLeaveHours.Index].Value = x.請休時數;
                row.Cells[colLate.Index].Value = x.遲到分鐘數;
                row.Cells[colEarlyLeave.Index].Value = x.早退分鐘數;
                row.Cells[colForgotCard.Index].Value = x.忘卡;
                row.Cells[colOtHours.Index].Value = x.核准時數;
                row.Cells[colLeaveType.Index].Value = x.假別;
                row.Cells[colNote.Index].Value = x.備註;
            }
        }

        private void btnRequery_Click(object sender, EventArgs e)
        {
            LoadGrid();
        }

        private void btnFirst_Click(object sender, EventArgs e) => GoToEmployee(0);
        private void btnPrev_Click(object sender, EventArgs e) => GoToEmployee(_empNoList.IndexOf(_empNo) - 1);
        private void btnNext_Click(object sender, EventArgs e) => GoToEmployee(_empNoList.IndexOf(_empNo) + 1);
        private void btnLast_Click(object sender, EventArgs e) => GoToEmployee(_empNoList.Count - 1);

        private void GoToEmployee(int index)
        {
            if (_empNoList.Count == 0) return;
            if (index < 0 || index >= _empNoList.Count) return;
            _empNo = _empNoList[index];
            LoadHeader();
            LoadGrid();
        }

        // ── 列印：開啟「員工月出勤明細表」預覽視窗，比照原 Access 報表版面
        //    (表頭 EMPL 查詢 + 子報表 考勤記錄查詢)，並可另存為 PDF ────────────
        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_empNo))
            {
                MessageBox.Show("請先選取一位員工!");
                return;
            }
            using var frm = new FrmAttendanceMonthlyPrint
            {
                EmpNo = _employee?.工號 ?? _empNo,
                Name = _employee?.姓名,
                HRNo = _employee?.人事編號,
                CardNo = _employee?.卡號,
                Dept = _employee?.部門,
                JobTitle = _employee?.職稱,
                StartDate = dtpStartDate.Value.ToString("yyyy/MM/dd"),
                EndDate = dtpEndDate.Value.ToString("yyyy/MM/dd"),
                Records = _records,
            };
            frm.ShowDialog(this);
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
