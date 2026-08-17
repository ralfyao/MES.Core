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
    // ── 每日出勤紀錄表：表頭資料來源為 H日曆(一天一筆)，表身為 H考勤紀錄
    //    (一天可多筆，一位員工一筆，LEFT JOIN H員工清冊 取姓名，並依 H請假紀錄
    //    推算假別)，比照 PITS-2025.accdb 之「H-每日出勤表」/「H-每日出勤紀錄」
    //    表單版面與邏輯建置 ──────────────────────────────────────────────
    public partial class ClockInOutControl : CommonUserControl
    {
        private static string id = "243B3696-7660-4FED-B1A9-DE475FCC83B3";

        private string _date;
        private bool _editing;
        private bool _loading;
        private List<string> _dateList = new List<string>();

        public ClockInOutControl()
        {
            if (!chkPrivilege(id))
            {
                MessageBox.Show("非授權使用者無法使用此功能!");
                Dispose();
                return;
            }
            InitializeComponent();
            LoadData(null);
        }

        internal void LoadData(string date)
        {
            if (string.IsNullOrEmpty(date)) date = DateTime.Today.ToString("yyyy/MM/dd");
            _date = date;
            InitEmpNoCombo();
            LoadDateList();
            LoadHeader();
            LoadGrid();
            SetEditing(false);
        }

        // ── 員工編號下拉：來源為 員工清冊列表(工號) ──────────────────────────
        private void InitEmpNoCombo()
        {
            var rep = new HRController().GetEmployeeList();
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }
            var empNos = (rep.resultList ?? new List<員工清冊列表>())
                .Select(x => x.工號)
                .Where(x => !string.IsNullOrEmpty(x))
                .Distinct()
                .OrderBy(x => x)
                .ToArray();
            colEmpNo.Items.Clear();
            colEmpNo.Items.AddRange(empNos);
        }

        // ── 依日期排序取得全部已建立表頭的日期，供 ◄/► 切換上一天/下一天使用 ──
        private void LoadDateList()
        {
            var rep = new HRController().GetCalendarDateList();
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }
            _dateList = rep.resultList ?? new List<string>();
        }

        private void LoadHeader()
        {
            _loading = true;
            var rep = new HRController().GetCalendarByDate(_date);
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                _loading = false;
                return;
            }
            var x = rep.result ?? new H日曆 { 日期 = _date };
            dtpDate.Value = DateTime.TryParse(x.日期, out var d) ? d : DateTime.Today;
            chkHoliday.Checked = x.例假日 ?? false;
            chkImported.Checked = x.導入卡鐘資料 ?? false;
            txtImportTime.Text = x.導入時間;
            UpdateWeekdayLabel();
            _loading = false;
        }

        // ── 週次：比照原 Access 表單 IIf(Weekday([日期])...) 公式換算星期文字 ──
        private void UpdateWeekdayLabel()
        {
            string[] names = { "日", "一", "二", "三", "四", "五", "六" };
            lblWeekday.Text = names[(int)dtpDate.Value.DayOfWeek];
        }

        private void LoadGrid()
        {
            var rep = new HRController().GetAttendanceList(_date);
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }
            dataGridView1.Rows.Clear();
            foreach (var x in rep.resultList ?? new List<考勤紀錄列表>())
            {
                FillRow(x);
            }
        }

        private void FillRow(考勤紀錄列表 x)
        {
            int i = dataGridView1.Rows.Add();
            var row = dataGridView1.Rows[i];
            row.Cells[colId.Index].Value = x.識別碼;
            if (!string.IsNullOrEmpty(x.員工編號) && !colEmpNo.Items.Contains(x.員工編號))
            {
                colEmpNo.Items.Add(x.員工編號);
            }
            row.Cells[colEmpNo.Index].Value = x.員工編號;
            row.Cells[colName.Index].Value = x.姓名;
            row.Cells[colCardNo.Index].Value = x.卡號;
            row.Cells[colShift.Index].Value = x.班次;
            row.Cells[colRegularStart.Index].Value = x.正規上班;
            row.Cells[colRegularEnd.Index].Value = x.正規下班;
            row.Cells[colOvertimeStart.Index].Value = x.加班上班;
            row.Cells[colOvertimeEnd.Index].Value = x.加班下班;
            row.Cells[colWorkHours.Index].Value = ToComboText(colWorkHours, x.出勤時數?.ToString());
            row.Cells[colLeaveHours.Index].Value = ToComboText(colLeaveHours, x.請休時數?.ToString());
            row.Cells[colLateMinutes.Index].Value = x.遲到分鐘數;
            row.Cells[colForgotCard.Index].Value = ToComboText(colForgotCard, x.忘卡?.ToString());
            row.Cells[colLeaveType.Index].Value = x.假別;
        }

        // ── 員工編號選定後自動帶出姓名(比照全站 PIC/人員選取自動帶名慣例) ──────
        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != colEmpNo.Index || e.RowIndex < 0) return;
            var row = dataGridView1.Rows[e.RowIndex];
            string empNo = row.Cells[colEmpNo.Index].Value?.ToString();
            if (string.IsNullOrEmpty(empNo)) return;
            var rep = new HRController().GetWorkerByNumber(empNo);
            if (string.IsNullOrEmpty(rep.ErrorMessage) && rep.result != null)
            {
                row.Cells[colName.Index].Value = rep.result.姓名;
                if (string.IsNullOrEmpty(row.Cells[colCardNo.Index].Value?.ToString()))
                {
                    row.Cells[colCardNo.Index].Value = rep.result.卡號;
                }
            }
        }

        // ── 鎖定/解鎖：比照全站「唯讀→修改解鎖→儲存」慣例 ───────────────────
        private void SetEditing(bool editing)
        {
            _editing = editing;
            chkHoliday.Enabled = editing;
            foreach (DataGridViewColumn col in dataGridView1.Columns)
            {
                if (col == colId || col == colName || col == colLeaveType || col == colDelete) continue;
                col.ReadOnly = !editing;
            }
            dataGridView1.AllowUserToAddRows = false;
            btnAddRow.Enabled = editing;
            btnModify.Visible = !editing && chkEditPrivilege(id);
            btnSave.Visible = editing;
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            SetEditing(true);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var header = new H日曆
            {
                日期 = dtpDate.Value.ToString("yyyy/MM/dd"),
                例假日 = chkHoliday.Checked,
            };
            var headerRep = new HRController().SaveCalendar(header);
            if (!string.IsNullOrEmpty(headerRep.ErrorMessage))
            {
                MessageBox.Show(headerRep.ErrorMessage);
                return;
            }

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.IsNewRow) continue;
                string empNo = row.Cells[colEmpNo.Index].Value?.ToString();
                if (string.IsNullOrEmpty(empNo)) continue;

                var form = new H考勤紀錄
                {
                    識別碼 = ToInt(row.Cells[colId.Index].Value),
                    員工編號 = empNo,
                    日期 = _date,
                    班次 = row.Cells[colShift.Index].Value?.ToString(),
                    正規上班 = row.Cells[colRegularStart.Index].Value?.ToString(),
                    正規下班 = row.Cells[colRegularEnd.Index].Value?.ToString(),
                    加班上班 = row.Cells[colOvertimeStart.Index].Value?.ToString(),
                    加班下班 = row.Cells[colOvertimeEnd.Index].Value?.ToString(),
                    出勤時數 = ToNullableDouble(row.Cells[colWorkHours.Index].Value),
                    請休時數 = ToNullableDouble(row.Cells[colLeaveHours.Index].Value),
                    遲到分鐘數 = ToNullableInt(row.Cells[colLateMinutes.Index].Value),
                    卡號 = row.Cells[colCardNo.Index].Value?.ToString(),
                    忘卡 = ToNullableInt(row.Cells[colForgotCard.Index].Value),
                };
                var rep = new HRController().SaveAttendance(form);
                if (!string.IsNullOrEmpty(rep.ErrorMessage))
                {
                    MessageBox.Show(rep.ErrorMessage);
                    return;
                }
            }
            MessageBox.Show("儲存成功!");
            LoadGrid();
            SetEditing(false);
        }

        // ── 下拉欄位防呆：資料庫值 Trim 後若不在既有選項中，強制加入清單，
        //    避免「DataGridViewComboBoxCell 值無效」例外(比照全站慣例) ────────
        private static string ToComboText(DataGridViewComboBoxColumn col, string value)
        {
            if (string.IsNullOrEmpty(value)) return null;
            value = value.Trim();
            if (!col.Items.Contains(value)) col.Items.Add(value);
            return value;
        }

        private static int ToInt(object value) => int.TryParse(value?.ToString(), out var i) ? i : 0;
        private static int? ToNullableInt(object value) => int.TryParse(value?.ToString(), out var i) ? i : (int?)null;
        private static double? ToNullableDouble(object value) => double.TryParse(value?.ToString(), out var d) ? d : (double?)null;

        // ── 新增一筆：直接進入編輯模式新增一列空白紀錄 ─────────────────────
        private void btnAddRow_Click(object sender, EventArgs e)
        {
            if (!_editing)
            {
                MessageBox.Show("請先按「修改」再新增!");
                return;
            }
            int i = dataGridView1.Rows.Add();
            dataGridView1.Rows[i].Cells[colId.Index].Value = 0;
        }

        // ── 刪除：需先進入修改模式才可刪除 ──────────────────────────────────
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex != colDelete.Index) return;
            if (!_editing)
            {
                MessageBox.Show("刪除紀錄前,請先按修改鍵!");
                return;
            }
            var row = dataGridView1.Rows[e.RowIndex];
            int id2 = ToInt(row.Cells[colId.Index].Value);
            if (id2 == 0)
            {
                dataGridView1.Rows.Remove(row);
                return;
            }
            if (MessageBox.Show("確定要刪除此筆紀錄?", "請選擇", MessageBoxButtons.YesNo) != DialogResult.Yes) return;
            var rep = new HRController().DeleteAttendance(id2);
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }
            LoadGrid();
        }

        // ── 日期切換：重新載入該日表頭與表身 ───────────────────────────────
        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            UpdateWeekdayLabel();
            if (_loading) return;
            LoadData(dtpDate.Value.ToString("yyyy/MM/dd"));
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            GoToAdjacentDate(-1);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            GoToAdjacentDate(1);
        }

        private void GoToAdjacentDate(int step)
        {
            // ── 依已建立表頭的日期清單切換；若目前日期不在清單中(尚未建檔)，
            //    直接以曆日前進/後退一天 ───────────────────────────────────
            int idx = _dateList.IndexOf(_date);
            string target;
            if (idx >= 0 && idx + step >= 0 && idx + step < _dateList.Count)
            {
                target = _dateList[idx + step];
            }
            else
            {
                target = DateTime.TryParse(_date, out var d) ? d.AddDays(step).ToString("yyyy/MM/dd") : _date;
            }
            LoadData(target);
        }

        // ── 導入卡鐘資料：解析 H卡鐘 原始刷卡字串寫入 H考勤紀錄，比照原 Access
        //    表單邏輯，同一天僅能導入一次(以 H日曆.導入卡鐘資料 為防呆旗標) ────
        private void btnImportClock_Click(object sender, EventArgs e)
        {
            if (chkImported.Checked)
            {
                MessageBox.Show("卡鐘出勤紀錄已經導入過了!");
                return;
            }
            if (MessageBox.Show("確定要導入本日卡鐘刷卡資料?", "請選擇", MessageBoxButtons.YesNo) != DialogResult.Yes) return;

            var rep = new HRController().ImportClockData(_date);
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }
            MessageBox.Show("卡鐘資料導入完成!");
            LoadHeader();
            LoadGrid();
        }

        // ── 員工考勤核對：開啟(或切換至)「員工考勤核對」頁籤，比照原 Access
        //    表單開啟時不帶條件；若目前表身有選取列，改以該列員工為預設查詢對象 ──
        private void btnAttendanceCheck_Click(object sender, EventArgs e)
        {
            string empNo = null;
            if (dataGridView1.CurrentRow != null && !dataGridView1.CurrentRow.IsNewRow)
            {
                empNo = dataGridView1.CurrentRow.Cells[colEmpNo.Index].Value?.ToString();
            }

            if (!(Parent is TabPage) || !(((TabPage)Parent).Parent is TabControl)) return;
            TabControl tabControl = (TabControl)((TabPage)Parent).Parent;
            const string tabName = "AttendanceCheck";
            foreach (TabPage page in tabControl.TabPages)
            {
                if (page.Name == tabName)
                {
                    tabControl.SelectedTab = page;
                    if (page.Controls.Count > 0 && page.Controls[0] is AttendanceCheckControl existing)
                    {
                        existing.LoadData(empNo);
                    }
                    return;
                }
            }
            var ctrl = new AttendanceCheckControl { Dock = DockStyle.Fill };
            var tab = new TabPage("員工考勤核對") { Name = tabName };
            tab.Controls.Add(ctrl);
            tabControl.TabPages.Add(tab);
            tabControl.SelectedTab = tab;
            ctrl.LoadData(empNo);
        }

        // ── 列印：原 Access 表單此按鈕尚未串接任何動作，本頁暫以提示取代 ─────
        private void btnPrint_Click(object sender, EventArgs e)
        {
            MessageBox.Show("此功能尚未開放!");
        }

        // ── 總覽：開啟「H-每日卡鐘總覽」(日曆總覽)視窗；比照原 Access「日期」
        //    欄位雙擊巨集，選定某天後切換回本頁該天的每日出勤表 ────────────
        private void btnOverview_Click(object sender, EventArgs e)
        {
            using var frm = new FrmDailyCalendarOverview();
            if (frm.ShowDialog(this) == DialogResult.OK && !string.IsNullOrEmpty(frm.SelectedDate))
            {
                LoadData(frm.SelectedDate);
            }
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
