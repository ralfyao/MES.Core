using DigiERP.Common;
using DigiERP.Forms.HR.Overtime;
using DigiERP.Models;
using DigiERP.UserControl.Accounting;
using MES.Core.Model;
using MES.WebAPI.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DigiERP.UserControl.HR.EmployeeSalary
{
    // ── 薪資月結：比照 PITS-2025.accdb 之「H-薪資月結」(表頭 H員工月)+
    //    表身(H員工月工時成本，一個月份每位員工一筆)建置；以清單瀏覽方式
    //    ◄/► 依年月切換，比照原巨集：
    //      新增(Command170) → 需具編輯權限(原巨集「系統權限.編修」，此處簡化
    //             為 chkEditPrivilege)才可開新的空白月份
    //      修改(Command31) → 需具編輯權限，已結帳月份需先取消結帳才能修改
    //      結帳(Command28) → 需具編輯權限；本月已結帳、或前一個月尚未結帳
    //             皆擋下；結帳時自動轉出會計傳票(借:6111 薪資費用/貸:2191
    //             應付薪資，金額為 SUM(應領金額-請假扣款-遲到扣款))，比照原
    //             巨集「自轉傳票」+「傳票明細-薪資月結」/「傳票明細-薪資費用」
    //      取消結帳(Command29) → 需具編輯權限+二次確認；刪除自動產生的會計
    //             傳票，清空核准/核准日/月結/傳票
    //      月工資成本導入(Command30) → 需本月已結帳才可使用，原巨集指向未
    //             建置之「H-人工成本重整」，故維持尚未開放
    //      查詢(原「列印」按鈕，實際 Caption 為「查詢」) → 開啟(或切換至)
    //             「薪資月結總覽」頁籤(原巨集為開啟另一唯讀物件並關閉本表單，
    //             此處改採頁籤方式，比照加班申請單「總覽」慣例)
    //      關閉(Command362) → 關閉本頁籤 ─────────────────────────────────
    public partial class EmployeeSalaryCloseControl : CommonUserControl
    {
        private static string id = "819B1BF8-646F-4DDB-9027-4D3BB59FA538";

        private List<H員工月> _headerList = new List<H員工月>();
        private int _currentIndex = -1;
        private bool _editing;
        private bool _loading;
        private string _mode = "修改";
        private List<H員工清冊> _employeeList = new List<H員工清冊>();
        private Dictionary<string, string> _empNameMap = new Dictionary<string, string>();

        public EmployeeSalaryCloseControl()
        {
            if (!chkPrivilege(id))
            {
                MessageBox.Show("非授權使用者無法使用此功能!");
                Dispose();
                return;
            }
            InitializeComponent();
            InitEmployeeCombo();
            InitEmpNameMap();
            LoadList();
        }

        // ── 表身工號：點選跳出選取視窗(沿用加班模組已建置的 FrmSelectOvertimeEmployee)，
        //    來源為狀況正常之員工 ─────────────────────────────────────────
        private void InitEmployeeCombo()
        {
            var rep = new GeneralExpensesController().GetActiveEmployeeList();
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }
            _employeeList = rep.resultList ?? new List<H員工清冊>();
            colEmpNo.Items.Clear();
            foreach (var x in _employeeList.Where(x => !string.IsNullOrEmpty(x.工號)))
            {
                colEmpNo.Items.Add(x.工號);
            }
        }

        // ── 工號→姓名對照表：涵蓋全部員工(含已離職)，供既有明細帶出姓名用 ──────
        private void InitEmpNameMap()
        {
            var rep = new HRController().GetAllEmployeeBasicList();
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }
            var all = rep.resultList ?? new List<H員工清冊>();
            _empNameMap = all.Where(x => !string.IsNullOrEmpty(x.工號))
                .GroupBy(x => x.工號)
                .ToDictionary(g => g.Key, g => g.First().姓名);
        }

        private void LoadList()
        {
            var rep = new HRController().GetSalaryCloseList();
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }
            _headerList = rep.resultList ?? new List<H員工月>();
            if (_headerList.Count > 0)
            {
                DisplayCurrent(_headerList.Count - 1);
            }
            else
            {
                NewRecord();
            }
        }

        // ── 供「薪資月結總覽」點選年月時呼叫：直接跳轉至該筆月結 ─────────────
        internal void LoadByYearMonth(string yearMonth)
        {
            if (string.IsNullOrEmpty(yearMonth)) return;
            if (_headerList.Count == 0) LoadList();
            int idx = _headerList.FindIndex(x => x.年月 == yearMonth);
            if (idx >= 0) DisplayCurrent(idx);
        }

        // ── 供「薪資月結總覽」的「新增」按鈕呼叫(比照原巨集 Command173) ──────
        internal void StartNew() => NewRecord();

        private void UpdateRecordInfo()
        {
            if (_mode == "新增")
            {
                lblRecordInfo.Text = $"新增中(尚未儲存) / 共 {_headerList.Count} 筆";
            }
            else
            {
                lblRecordInfo.Text = _headerList.Count == 0
                    ? "第 0 筆 / 共 0 筆"
                    : $"第 {_currentIndex + 1} 筆 / 共 {_headerList.Count} 筆";
            }
        }

        private void DisplayCurrent(int index)
        {
            if (_headerList.Count == 0) { NewRecord(); return; }
            if (index < 0) index = 0;
            if (index > _headerList.Count - 1) index = _headerList.Count - 1;
            _currentIndex = index;

            var rep = new HRController().GetSalaryCloseByPeriod(_headerList[_currentIndex].年月);
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }
            var form = rep.result ?? _headerList[_currentIndex];
            _mode = "修改";
            PopulateForm(form);
            SetEditing(false);
        }

        private void PopulateForm(H員工月 form)
        {
            _loading = true;
            if (DateTime.TryParse(form.年月 + "/01", out var ym)) dtYearMonth.Value = ym;
            if (DateTime.TryParse(form.月底日, out var med)) dtMonthEndDate.Value = med;
            chkClosed.Checked = form.月結 ?? false;
            txtVoucher.Text = form.傳票;
            txtCreator.Text = form.建檔;
            txtCreateDate.Text = form.建檔日;
            txtModifier.Text = form.修改;
            txtModifyDate.Text = form.修改日;
            txtApprover.Text = form.核准;
            txtApproveDate.Text = form.核准日;
            FillGrid(form.detailList ?? new List<H員工月工時成本>());
            UpdateRecordInfo();
            _loading = false;
        }

        private void FillGrid(List<H員工月工時成本> list)
        {
            dataGridView1.Rows.Clear();
            foreach (var x in list)
            {
                int i = dataGridView1.Rows.Add();
                FillRow(dataGridView1.Rows[i], x);
            }
        }

        private void FillRow(DataGridViewRow row, H員工月工時成本 x)
        {
            row.Cells[colId.Index].Value = x.識別;
            if (!string.IsNullOrEmpty(x.工號) && !colEmpNo.Items.Contains(x.工號))
            {
                colEmpNo.Items.Add(x.工號);
            }
            row.Cells[colEmpNo.Index].Value = x.工號;
            row.Cells[colName.Index].Value = _empNameMap.TryGetValue(x.工號 ?? "", out var nm) ? nm : "";
            row.Cells[colAmount.Index].Value = x.應領金額;
            row.Cells[colLeaveDeduct.Index].Value = x.請假扣款;
            row.Cells[colLateDeduct.Index].Value = x.遲到扣款;
            row.Cells[colAttendHours.Index].Value = x.出勤時數;
            RecalcLaborCost(row);
        }

        // ── 工時成本 = (應領金額-請假扣款-遲到扣款)/出勤時數(比照原巨集
        //    表身「工時成本」欄位公式) ────────────────────────────────────
        private void RecalcLaborCost(DataGridViewRow row)
        {
            double.TryParse(row.Cells[colAmount.Index].Value?.ToString(), out var amount);
            double.TryParse(row.Cells[colLeaveDeduct.Index].Value?.ToString(), out var leave);
            double.TryParse(row.Cells[colLateDeduct.Index].Value?.ToString(), out var late);
            double.TryParse(row.Cells[colAttendHours.Index].Value?.ToString(), out var hours);
            row.Cells[colLaborCost.Index].Value = hours != 0 ? Math.Round((amount - leave - late) / hours, 2) : (double?)null;
        }

        private void UpdateSummary()
        {
            double sumAmount = 0, sumLeave = 0, sumLate = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                double.TryParse(row.Cells[colAmount.Index].Value?.ToString(), out var a);
                double.TryParse(row.Cells[colLeaveDeduct.Index].Value?.ToString(), out var l);
                double.TryParse(row.Cells[colLateDeduct.Index].Value?.ToString(), out var t);
                sumAmount += a;
                sumLeave += l;
                sumLate += t;
            }
            lblSumAmount.Text = $"應領金額合計：{sumAmount:0.##}";
            lblSumLeaveDeduct.Text = $"請假扣款合計：{sumLeave:0.##}";
            lblSumLateDeduct.Text = $"遲到扣款合計：{sumLate:0.##}";
        }

        // ── 新增：開一個空白月份，年月預設為既有最後一筆的下個月(無資料時為
        //    本月)，月底日自動算為當月最後一天 ────────────────────────────
        private void btnNew_Click(object sender, EventArgs e) => NewRecord();

        private void NewRecord()
        {
            _loading = true;
            _mode = "新增";
            _currentIndex = _headerList.Count;

            DateTime ym = DateTime.Today;
            if (_headerList.Count > 0 && DateTime.TryParse(_headerList[_headerList.Count - 1].年月 + "/01", out var last))
            {
                ym = last.AddMonths(1);
            }
            dtYearMonth.Value = new DateTime(ym.Year, ym.Month, 1);
            dtMonthEndDate.Value = new DateTime(ym.Year, ym.Month, 1).AddMonths(1).AddDays(-1);
            chkClosed.Checked = false;
            txtVoucher.Text = "";
            txtCreator.Text = AppSession.User?.name;
            txtCreateDate.Text = DateTime.Today.ToString("yyyy/MM/dd");
            txtModifier.Text = "";
            txtModifyDate.Text = "";
            txtApprover.Text = "";
            txtApproveDate.Text = "";
            dataGridView1.Rows.Clear();
            UpdateSummary();
            UpdateRecordInfo();
            _loading = false;
            SetEditing(true);
        }

        // ── 鎖定/解鎖：比照全站「唯讀→修改解鎖→儲存」慣例；表格層級的
        //    ReadOnly 會覆蓋所有欄位層級設定，兩者都要切換 ───────────────────
        private void SetEditing(bool editing)
        {
            _editing = editing;
            dtYearMonth.Enabled = editing && _mode == "新增"; // 既有月份的年月不可更改
            dtMonthEndDate.Enabled = editing;
            dataGridView1.ReadOnly = !editing;
            foreach (DataGridViewColumn col in dataGridView1.Columns)
            {
                if (col == colId || col == colName || col == colLaborCost) continue;
                col.ReadOnly = !editing;
            }
            panelGridTool.Visible = editing;

            bool isNew = _mode == "新增";
            bool closed = chkClosed.Checked;
            btnPrev.Enabled = !editing;
            btnNext.Enabled = !editing;
            btnNew.Enabled = !editing;
            btnModify.Visible = !editing && !isNew && !closed && chkEditPrivilege(id);
            btnSave.Visible = editing;
            btnCloseMonth.Visible = !editing && !isNew && !closed && chkEditPrivilege(id);
            btnReopenMonth.Visible = !editing && !isNew && closed && chkEditPrivilege(id);
            btnCostImport.Enabled = !editing;
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            if (chkClosed.Checked)
            {
                MessageBox.Show("本月已結帳，請先取消結帳才能修改！");
                return;
            }
            SetEditing(true);
        }

        // ── 年月切換：新增模式下自動帶出當月最後一天為月底日(比照原巨集
        //    年月欄位以 Short Date 顯示、月底日獨立欄位之慣例) ─────────────
        private void dtYearMonth_ValueChanged(object sender, EventArgs e)
        {
            if (_loading || _mode != "新增") return;
            dtMonthEndDate.Value = new DateTime(dtYearMonth.Value.Year, dtYearMonth.Value.Month, 1).AddMonths(1).AddDays(-1);
        }

        // ── 表身新增/刪除明細列 ──────────────────────────────────────────
        private void btnAddDetailRow_Click(object sender, EventArgs e)
        {
            int i = dataGridView1.Rows.Add();
            dataGridView1.CurrentCell = dataGridView1.Rows[i].Cells[colEmpNo.Index];
        }

        private void btnDeleteDetailRow_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null || dataGridView1.CurrentRow.IsNewRow) return;
            dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
            UpdateSummary();
        }

        // ── 攔截工號下拉的原生下拉清單，改開選取視窗(沿用加班模組) ───────────
        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dataGridView1.CurrentCell?.ColumnIndex != colEmpNo.Index || e.Control is not ComboBox combo) return;
            combo.DropDown -= EmployeeCombo_DropDown;
            combo.DropDown += EmployeeCombo_DropDown;
        }

        private void EmployeeCombo_DropDown(object sender, EventArgs e)
        {
            var combo = (ComboBox)sender;
            BeginInvoke(new Action(() =>
            {
                combo.DroppedDown = false;
                using var frm = new FrmSelectOvertimeEmployee(_employeeList);
                if (frm.ShowDialog(FindForm()) == DialogResult.OK && frm.SelectedItem != null)
                {
                    combo.Text = frm.SelectedItem.工號;
                    if (dataGridView1.CurrentRow != null)
                    {
                        dataGridView1.CurrentRow.Cells[colName.Index].Value = frm.SelectedItem.姓名;
                    }
                }
            }));
        }

        // ── 下拉選單選定後立即提交，避免選完未離開儲存格就存檔導致漏存 ────────
        private void dataGridView1_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dataGridView1.IsCurrentCellDirty && dataGridView1.CurrentCell?.ColumnIndex == colEmpNo.Index)
            {
                dataGridView1.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        // ── 工號選定後自動帶出姓名；應領金額/請假扣款/遲到扣款/出勤時數
        //    異動後重新計算工時成本 ──────────────────────────────────────
        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var row = dataGridView1.Rows[e.RowIndex];
            if (e.ColumnIndex == colEmpNo.Index)
            {
                string empNo = row.Cells[colEmpNo.Index].Value?.ToString();
                row.Cells[colName.Index].Value = _empNameMap.TryGetValue(empNo ?? "", out var nm) ? nm : "";
            }
            else if (e.ColumnIndex == colAmount.Index || e.ColumnIndex == colLeaveDeduct.Index ||
                     e.ColumnIndex == colLateDeduct.Index || e.ColumnIndex == colAttendHours.Index)
            {
                RecalcLaborCost(row);
                UpdateSummary();
            }
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (_currentIndex > 0) DisplayCurrent(_currentIndex - 1);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (_currentIndex < _headerList.Count - 1) DisplayCurrent(_currentIndex + 1);
        }

        // ── 儲存：新增或修改依 _mode 判斷，表身整批刪除重建 ─────────────────
        private void btnSave_Click(object sender, EventArgs e)
        {
            bool isNew = _mode == "新增";
            var form = new H員工月
            {
                年月 = dtYearMonth.Value.ToString("yyyy/MM"),
                月底日 = dtMonthEndDate.Value.ToString("yyyy/MM/dd"),
                建檔 = txtCreator.Text,
                修改 = AppSession.User?.name,
                detailList = new List<H員工月工時成本>(),
            };
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.IsNewRow) continue;
                string empNo = row.Cells[colEmpNo.Index].Value?.ToString();
                if (string.IsNullOrEmpty(empNo)) continue;
                double.TryParse(row.Cells[colAmount.Index].Value?.ToString(), out var amount);
                double.TryParse(row.Cells[colLeaveDeduct.Index].Value?.ToString(), out var leave);
                double.TryParse(row.Cells[colLateDeduct.Index].Value?.ToString(), out var late);
                double.TryParse(row.Cells[colAttendHours.Index].Value?.ToString(), out var hours);
                form.detailList.Add(new H員工月工時成本
                {
                    識別 = ToInt(row.Cells[colId.Index].Value),
                    工號 = empNo,
                    應領金額 = amount,
                    請假扣款 = leave,
                    遲到扣款 = late,
                    出勤時數 = hours,
                });
            }

            var rep = new HRController().SaveSalaryClose(form, isNew);
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }
            _mode = "修改";
            MessageBox.Show("儲存成功!");

            var listRep = new HRController().GetSalaryCloseList();
            _headerList = listRep.resultList ?? new List<H員工月>();
            int idx = _headerList.FindIndex(x => x.年月 == form.年月);
            DisplayCurrent(idx >= 0 ? idx : _headerList.Count - 1);
        }

        // ── 結帳：後端已處理已結帳/前一個月未結帳的擋下與會計傳票自動轉出，
        //    這裡僅呼叫並依回傳結果顯示訊息(比照原巨集 MsgBox 文字) ──────────
        private void btnCloseMonth_Click(object sender, EventArgs e)
        {
            if (_currentIndex < 0 || _headerList.Count == 0) return;
            string yearMonth = _headerList[_currentIndex].年月;
            var rep = new HRController().CloseSalaryMonth(yearMonth, AppSession.User?.name);
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }
            MessageBox.Show("月結完畢!");
            var listRep = new HRController().GetSalaryCloseList();
            _headerList = listRep.resultList ?? new List<H員工月>();
            int idx = _headerList.FindIndex(x => x.年月 == yearMonth);
            DisplayCurrent(idx >= 0 ? idx : _currentIndex);
        }

        // ── 取消結帳：二次確認，刪除自動產生的會計傳票 ─────────────────────
        private void btnReopenMonth_Click(object sender, EventArgs e)
        {
            if (_currentIndex < 0 || _headerList.Count == 0) return;
            if (MessageBox.Show("您確定要取消結帳", "請選擇", MessageBoxButtons.YesNo) != DialogResult.Yes) return;
            string yearMonth = _headerList[_currentIndex].年月;
            var rep = new HRController().ReopenSalaryMonth(yearMonth, AppSession.User?.name);
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }
            MessageBox.Show("月結已取消!");
            var listRep = new HRController().GetSalaryCloseList();
            _headerList = listRep.resultList ?? new List<H員工月>();
            int idx = _headerList.FindIndex(x => x.年月 == yearMonth);
            DisplayCurrent(idx >= 0 ? idx : _currentIndex);
        }

        // ── 月工資成本導入：需本月已結帳，開啟(或切換至)「人工成本重整」頁籤
        //    (比照原巨集開啟「H-人工成本重整」，並依目前開啟的年月帶入) ──────
        private void btnCostImport_Click(object sender, EventArgs e)
        {
            if (!chkClosed.Checked)
            {
                MessageBox.Show("本月薪資尚未結帳，請月結後再進行此操作！");
                return;
            }
            if (_currentIndex < 0 || _headerList.Count == 0) return;
            string yearMonth = _headerList[_currentIndex].年月;

            if (!(Parent is TabPage) || !(((TabPage)Parent).Parent is TabControl)) return;
            TabControl tabControl = (TabControl)((TabPage)Parent).Parent;
            const string tabName = "LaborCostReallocation";
            foreach (TabPage page in tabControl.TabPages)
            {
                if (page.Name == tabName)
                {
                    tabControl.SelectedTab = page;
                    if (page.Controls.Count > 0 && page.Controls[0] is LaborCostReallocationControl existing)
                    {
                        existing.LoadData(yearMonth);
                    }
                    return;
                }
            }
            var ctrl = new LaborCostReallocationControl { Dock = DockStyle.Fill };
            var tab = new TabPage("人工成本重整") { Name = tabName };
            tab.Controls.Add(ctrl);
            tabControl.TabPages.Add(tab);
            tabControl.SelectedTab = tab;
            ctrl.LoadData(yearMonth);
        }

        // ── 傳票雙擊：開啟(或切換至)會計傳票查詢頁籤(未預先帶入單號篩選) ──────
        private void txtVoucher_DoubleClick(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtVoucher.Text)) return;
            if (!(Parent is TabPage) || !(((TabPage)Parent).Parent is TabControl)) return;
            TabControl tabControl = (TabControl)((TabPage)Parent).Parent;
            const string tabName = "SalaryVoucherQuery";
            foreach (TabPage page in tabControl.TabPages)
            {
                if (page.Name == tabName)
                {
                    tabControl.SelectedTab = page;
                    return;
                }
            }
            var ctrl = new VoucherQueryControl { Dock = DockStyle.Fill };
            var tab = new TabPage("會計傳票查詢") { Name = tabName };
            tab.Controls.Add(ctrl);
            tabControl.TabPages.Add(tab);
            tabControl.SelectedTab = tab;
        }

        // ── 查詢：開啟(或切換至)「薪資月結總覽」頁籤 ────────────────────────
        private void btnQuery_Click(object sender, EventArgs e)
        {
            if (!(Parent is TabPage) || !(((TabPage)Parent).Parent is TabControl)) return;
            TabControl tabControl = (TabControl)((TabPage)Parent).Parent;
            const string tabName = "SalaryCloseOverview";
            foreach (TabPage page in tabControl.TabPages)
            {
                if (page.Name == tabName)
                {
                    tabControl.SelectedTab = page;
                    return;
                }
            }
            var ctrl = new EmployeeSalaryCloseOverviewControl { Dock = DockStyle.Fill };
            var tab = new TabPage("薪資月結總覽") { Name = tabName };
            tab.Controls.Add(ctrl);
            tabControl.TabPages.Add(tab);
            tabControl.SelectedTab = tab;
        }

        private static int ToInt(object value)
        {
            return int.TryParse(value?.ToString(), out var v) ? v : 0;
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
