using DigiERP.Common;
using DigiERP.Models;
using MES.Core.Model;
using MES.WebAPI.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DigiERP.UserControl.HR.Overtime
{
    // ── 員工加班紀錄表：比照 PITS-2025.accdb 之「H-員工加班紀錄表」表單，
    //    表頭顯示員工基本資料(工號/姓名/職稱/單位別/人事編號/卡號)，以
    //    首/前/次/末筆按鈕於全部員工間切換(RecordSource 為全部員工，無篩選)；
    //    表身為查詢起訖日範圍內該員工的加班紀錄+加班費(比照原「加班分鐘核對-1」
    //    查詢，唯該查詢誤將判斷字串植為「假日班」，其真正來源查詢「加班分鐘核對
    //    帳簿」比對的是「國定假日」，此處採用與 AttendanceCheckControl 一致、
    //    已修正的正確版本)；原巨集「員工別加班紀錄表」按鈕依「財管權限」核准與否
    //    決定開啟全部員工或僅鎖定登入者本人資料，此處簡化為 chkEditPrivilege ──
    public partial class OverTimeDetail : CommonUserControl
    {
        private static string id = "26605F40-7572-4AD2-8B8E-59D67CDC158F";

        private List<H員工清冊> _employeeList = new List<H員工清冊>();
        private int _currentIndex = -1;

        public OverTimeDetail()
        {
            if (!chkPrivilege(id))
            {
                MessageBox.Show("非授權使用者無法使用此功能!");
                Dispose();
                return;
            }
            InitializeComponent();
            dtStartDate.Value = DateTime.Today.AddDays(-31);
            dtEndDate.Value = DateTime.Today;
            LoadData(null);
        }

        // ── 進入點：empNo 有值時鎖定該員工(比照原巨集未具財管權限時
        //    WhereCondition=[工號]=登入者)；否則具編輯權限者瀏覽全部員工，
        //    否則同樣鎖定為目前登入者本人 ─────────────────────────────────
        internal void LoadData(string empNo)
        {
            var rep = new HRController().GetAllEmployeeBasicList();
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }
            var all = rep.resultList ?? new List<H員工清冊>();

            string targetEmpNo = empNo;
            if (string.IsNullOrEmpty(targetEmpNo) && !chkEditPrivilege(id))
            {
                targetEmpNo = AppSession.User?.empNo;
            }

            if (!string.IsNullOrEmpty(targetEmpNo))
            {
                _employeeList = all.Where(x => x.工號 == targetEmpNo).ToList();
                if (_employeeList.Count == 0)
                {
                    // ── 查無鎖定對象(例如登入者未綁定工號)時，退回瀏覽全部員工 ──
                    _employeeList = all;
                }
            }
            else
            {
                _employeeList = all;
            }

            bool canBrowseAll = _employeeList.Count > 1;
            btnFirst.Enabled = canBrowseAll;
            btnPrev.Enabled = canBrowseAll;
            btnNext.Enabled = canBrowseAll;
            btnLast.Enabled = canBrowseAll;

            DisplayCurrent(0);
        }

        private void DisplayCurrent(int index)
        {
            if (_employeeList.Count == 0)
            {
                _currentIndex = -1;
                txtEmpNo.Text = txtName.Text = txtTitleJob.Text = txtDept.Text = txtHrNo.Text = txtCardNo.Text = "";
                dataGridView1.Rows.Clear();
                UpdateSummary();
                return;
            }
            if (index < 0) index = 0;
            if (index > _employeeList.Count - 1) index = _employeeList.Count - 1;
            _currentIndex = index;

            var emp = _employeeList[_currentIndex];
            txtEmpNo.Text = emp.工號;
            txtName.Text = emp.姓名;
            txtTitleJob.Text = emp.職稱;
            txtDept.Text = emp.部門;
            txtHrNo.Text = emp.人事編號;
            txtCardNo.Text = emp.卡號;

            LoadGrid();
        }

        private void LoadGrid()
        {
            if (_currentIndex < 0) return;
            string empNo = _employeeList[_currentIndex].工號;
            var rep = new HRController().GetEmployeeOvertimeRecordList(
                empNo, dtStartDate.Value.ToString("yyyy/MM/dd"), dtEndDate.Value.ToString("yyyy/MM/dd"));
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }
            dataGridView1.Rows.Clear();
            foreach (var x in rep.resultList ?? new List<員工加班紀錄列表>())
            {
                int i = dataGridView1.Rows.Add();
                var row = dataGridView1.Rows[i];
                row.Cells[colDate.Index].Value = x.日期;
                row.Cells[colShift.Index].Value = x.班次;
                row.Cells[colOtStart.Index].Value = x.加班上班;
                row.Cells[colOtEnd.Index].Value = x.加班下班;
                row.Cells[colHours.Index].Value = x.時數;
                row.Cells[colReason.Index].Value = x.加班事由;
                row.Cells[colOtHours.Index].Value = x.加班時數;
                row.Cells[colOtPay.Index].Value = x.加班費;
                row.Cells[colHourlyPay.Index].Value = x.時薪;
            }
            UpdateSummary();
        }

        // ── 合計加班時數/加班費(比照原表單尾 Sum([加班時數])/Sum([加班費])) ────
        private void UpdateSummary()
        {
            double sumHours = 0, sumPay = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                double.TryParse(row.Cells[colOtHours.Index].Value?.ToString(), out var h);
                double.TryParse(row.Cells[colOtPay.Index].Value?.ToString(), out var p);
                sumHours += h;
                sumPay += p;
            }
            lblSumHours.Text = $"合計加班時數：{sumHours:0.##}";
            lblSumPay.Text = $"合計加班費：{sumPay:0.##}";
        }

        private void btnFirst_Click(object sender, EventArgs e) => DisplayCurrent(0);

        private void btnPrev_Click(object sender, EventArgs e) => DisplayCurrent(_currentIndex - 1);

        private void btnNext_Click(object sender, EventArgs e) => DisplayCurrent(_currentIndex + 1);

        private void btnLast_Click(object sender, EventArgs e) => DisplayCurrent(_employeeList.Count - 1);

        // ── 查詢：原巨集查詢起訖日欄位無 AfterUpdate 事件(僅切換員工記錄時
        //    才會連動重新查詢表身)，此處另外提供「查詢」鍵手動套用起訖日 ─────
        private void btnQuery_Click(object sender, EventArgs e) => LoadGrid();

        private void btnClose_Click(object sender, EventArgs e)
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
