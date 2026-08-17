using DigiERP.Common;
using DigiERP.Forms.HR.Overtime;
using DigiERP.Models;
using MES.Core.Model;
using MES.WebAPI.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DigiERP.UserControl.HR.Overtime
{
    // ── 加班申請單：比照 PITS-2025.accdb 之「H-加班申請單」(表頭 H加班申請單)+
    //    「H-核准加班明細」(表身，一張單可多筆加班區段)建置；以清單瀏覽方式
    //    ◄/► 切換各張申請單，比照原巨集：
    //      新增 → 開新的空白單(Add 模式，直接可編輯)
    //      修改 → 需具編輯權限且尚未核准生效(原巨集另需符合「系統權限」核准，
    //             此處簡化為 chkEditPrivilege)
    //      儲存 → 單據編號僅新單為空時才產生，規則為同一申請日期下 DMax 遞增
    //             末2位序號(無則 "OT"+申請日期8碼+"01")
    //      生效/取消生效 → 需具編輯權限(原巨集另需符合「財管權限」核准，此處
    //             簡化為 chkEditPrivilege)；生效寫入登入者姓名為核准人，
    //             取消生效清空核准人
    //      刪除 → 需具編輯權限且尚未核准生效
    //      總覽 → 開啟清單挑選視窗，雙擊跳轉至該筆申請單(原巨集邏輯為開啟
    //             「H-加班申請明細查詢」另一唯讀物件，此處改為清單挑選)
    //      列印／員工別加班紀錄表 → 原巨集查無實際掛載邏輯(列印無事件、員工別
    //             加班紀錄表另指向未建置之「H-員工加班紀錄表」)，故維持尚未開放 ──
    public partial class OverTimeControl : CommonUserControl
    {
        private static string id = "FAAF5B8E-E5EF-48A8-9B00-45C7F01E4385";

        private List<H加班申請單> _headerList = new List<H加班申請單>();
        private int _currentIndex = -1;
        private bool _editing;
        private bool _loading;
        private string _mode = "修改";
        private Dictionary<string, string> _empNameMap = new Dictionary<string, string>();
        private List<H員工清冊> _employeeList = new List<H員工清冊>();
        private List<H加班事由> _reasonList = new List<H加班事由>();

        public OverTimeControl()
        {
            if (!chkPrivilege(id))
            {
                MessageBox.Show("非授權使用者無法使用此功能!");
                Dispose();
                return;
            }
            InitializeComponent();
            InitCostUnitCombo();
            InitApplicantCombo();
            InitEmployeeCombo();
            InitEmpNameMap();
            InitReasonCombo();
            LoadList();
        }

        // ── 申請單位下拉：來源為 A成本單位.職務(比照原巨集 RowSource) ────────
        private void InitCostUnitCombo()
        {
            var rep = new HRController().GetCostUnitList();
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }
            cboCostUnit.Items.Clear();
            cboCostUnit.Items.AddRange((rep.resultList ?? new List<string>()).ToArray());
        }

        // ── 申請人下拉：來源為未停用帳號之姓名(比照原巨集 RowSource) ─────────
        private void InitApplicantCombo()
        {
            var rep = new UserPrivilegeController().GetActiveAccountList();
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }
            var names = (rep.resultList ?? new List<account>())
                .Select(x => x.姓名)
                .Where(x => !string.IsNullOrEmpty(x))
                .Distinct()
                .ToArray();
            cboApplicant.Items.Clear();
            cboApplicant.Items.AddRange(names);
        }

        // ── 表身員工編號：點選跳出選取視窗(FrmSelectOvertimeEmployee)，來源為
        //    狀況正常之員工(比照原巨集「在職員工資料查詢」)，不使用原生下拉
        //    清單；新增明細只能挑選在職員工 ─────────────────────────────────
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

        // ── 工號→姓名對照表：涵蓋全部員工(含已離職)，供既有明細帶出姓名用；
        //    若只用在職員工清單，歷史明細若填的是已離職員工，姓名會顯示空白 ────
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

        // ── 表身加班事由：點選跳出選取視窗(FrmSelectOvertimeReason)，來源為
        //    H加班事由 主檔，帶回「加班事由代碼」(比照原 Access ComboBox 直接
        //    綁定 dbo_H加班事由 表格、預設 BoundColumn=第1欄=加班事由代碼) ───────
        private void InitReasonCombo()
        {
            var rep = new HRController().GetOvertimeReasonList();
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }
            _reasonList = rep.resultList ?? new List<H加班事由>();
            colReason.Items.Clear();
            foreach (var x in _reasonList)
            {
                if (!string.IsNullOrEmpty(x.加班事由代碼)) colReason.Items.Add(x.加班事由代碼);
            }
        }

        // ── 攔截員工編號/加班事由下拉的原生下拉清單，改開選取視窗 ─────────────
        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (e.Control is not ComboBox combo) return;
            combo.DropDown -= EmployeeCombo_DropDown;
            combo.DropDown -= ReasonCombo_DropDown;
            if (dataGridView1.CurrentCell?.ColumnIndex == colEmpNo.Index)
            {
                combo.DropDown += EmployeeCombo_DropDown;
            }
            else if (dataGridView1.CurrentCell?.ColumnIndex == colReason.Index)
            {
                combo.DropDown += ReasonCombo_DropDown;
            }
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

        private void ReasonCombo_DropDown(object sender, EventArgs e)
        {
            var combo = (ComboBox)sender;
            BeginInvoke(new Action(() =>
            {
                combo.DroppedDown = false;
                using var frm = new FrmSelectOvertimeReason(_reasonList);
                if (frm.ShowDialog(FindForm()) == DialogResult.OK && frm.SelectedItem != null)
                {
                    combo.Text = frm.SelectedItem.加班事由代碼;
                }
            }));
        }

        // ── 供「加班申請明細查詢」總覽點選單號時呼叫：直接跳轉至該筆申請單 ──────
        internal void LoadByNo(string no)
        {
            if (string.IsNullOrEmpty(no)) return;
            if (_headerList.Count == 0)
            {
                LoadList();
            }
            int idx = _headerList.FindIndex(x => x.單據編號 == no);
            if (idx >= 0) DisplayCurrent(idx);
        }

        // ── 載入全部申請單表頭(供 ◄/► 切換)，並跳到最後一筆 ────────────────
        private void LoadList()
        {
            var rep = new HRController().GetOvertimeApplyList();
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }
            _headerList = rep.resultList ?? new List<H加班申請單>();
            if (_headerList.Count > 0)
            {
                DisplayCurrent(_headerList.Count - 1);
            }
            else
            {
                NewRecord();
            }
        }

        // ── 新增中的一筆尚未真正存在(未點儲存前不計入總筆數)，避免顯示
        //    「第 X 筆 / 共 Y 筆」時 X > Y 造成新增資料看似已經生效 ───────────
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

        // ── 切換至清單中第 index 筆，重新查詢表頭+表身完整資料 ─────────────
        private void DisplayCurrent(int index)
        {
            if (_headerList.Count == 0) { NewRecord(); return; }
            if (index < 0) index = 0;
            if (index > _headerList.Count - 1) index = _headerList.Count - 1;
            _currentIndex = index;

            var rep = new HRController().GetOvertimeApplyByNo(_headerList[_currentIndex].單據編號);
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

        private void PopulateForm(H加班申請單 form)
        {
            _loading = true;
            txtNo.Text = form.單據編號;
            dtDate.Value = DateTime.TryParse(form.申請日期, out var d) ? d : DateTime.Today;
            cboCostUnit.Text = form.申請單位;
            cboApplicant.Text = form.申請人;
            chkApproved.Checked = form.核准生效 ?? false;
            txtApprover.Text = form.核准人;
            FillGrid(form.detailList ?? new List<H核准加班明細>());
            UpdateRecordInfo();
            _loading = false;
        }

        private void FillGrid(List<H核准加班明細> list)
        {
            dataGridView1.Rows.Clear();
            foreach (var x in list)
            {
                int i = dataGridView1.Rows.Add();
                var row = dataGridView1.Rows[i];
                row.Cells[colId.Index].Value = x.識別碼;
                if (!string.IsNullOrEmpty(x.員工編號) && !colEmpNo.Items.Contains(x.員工編號))
                {
                    colEmpNo.Items.Add(x.員工編號);
                }
                row.Cells[colEmpNo.Index].Value = x.員工編號;
                row.Cells[colName.Index].Value = _empNameMap.TryGetValue(x.員工編號 ?? "", out var nm) ? nm : "";
                row.Cells[colOtDate.Index].Value = x.加班日期;
                row.Cells[colStart.Index].Value = x.起;
                row.Cells[colEnd.Index].Value = x.訖;
                row.Cells[colHours.Index].Value = ToComboText(colHours, x.時數?.ToString("0.0"));
                row.Cells[colReason.Index].Value = ToComboText(colReason, x.加班事由);
                row.Cells[colDetail.Index].Value = x.加班內容詳述;
                row.Cells[colRemark.Index].Value = x.備註;
            }
        }

        // ── 依 Trim 後之值比對是否已存在於 Items，不存在則強制加入，避免
        //    DataGridViewComboBoxCell 值無效例外(比照全站慣例) ───────────────
        private static string ToComboText(DataGridViewComboBoxColumn col, string value)
        {
            if (string.IsNullOrEmpty(value)) return value;
            string trimmed = value.Trim();
            if (!col.Items.Contains(trimmed)) col.Items.Add(trimmed);
            return trimmed;
        }

        // ── 新增：開一張空白申請單，比照原巨集 Add 模式，直接可編輯 ────────
        private void btnNew_Click(object sender, EventArgs e)
        {
            NewRecord();
        }

        private void NewRecord()
        {
            _loading = true;
            _mode = "新增";
            _currentIndex = _headerList.Count;
            dtDate.Value = DateTime.Today;
            cboCostUnit.SelectedIndex = -1;
            cboApplicant.SelectedIndex = -1;
            chkApproved.Checked = false;
            txtApprover.Text = "";
            dataGridView1.Rows.Clear();
            UpdateRecordInfo();
            _loading = false;
            RefreshNoPreview();
            SetEditing(true);
        }

        // ── 單據編號預覽：比照原巨集「日期」欄位 AfterUpdate，僅新增模式下
        //    依目前選定日期即時算出(實際仍以儲存交易內產生的編號為準) ────────
        private void RefreshNoPreview()
        {
            if (_mode != "新增") return;
            var rep = new HRController().GetOvertimeApplyNoPreview(dtDate.Value.ToString("yyyy/MM/dd"));
            txtNo.Text = string.IsNullOrEmpty(rep.ErrorMessage) ? rep.result : "";
        }

        // ── 鎖定/解鎖：比照全站「唯讀→修改解鎖→儲存」慣例 ───────────────────
        private void SetEditing(bool editing)
        {
            _editing = editing;
            dtDate.Enabled = editing;
            cboCostUnit.Enabled = editing;
            cboApplicant.Enabled = editing;
            // ── 表格層級的 ReadOnly 會覆蓋所有欄位層級設定，兩者都要切換，
            //    否則欄位 ReadOnly=false 也無法真正編輯(下拉選單點了沒反應) ──
            dataGridView1.ReadOnly = !editing;
            foreach (DataGridViewColumn col in dataGridView1.Columns)
            {
                if (col == colId || col == colName) continue;
                col.ReadOnly = !editing;
            }
            panelGridTool.Visible = editing;

            bool isNew = _mode == "新增";
            bool approved = chkApproved.Checked;
            btnPrev.Enabled = !editing;
            btnNext.Enabled = !editing;
            btnNew.Enabled = !editing;
            btnDelete.Visible = !editing && !isNew && chkEditPrivilege(id);
            btnModify.Visible = !editing && !isNew && !approved && chkEditPrivilege(id);
            btnSave.Visible = editing;
            btnValidate.Visible = !editing && !isNew && !approved && chkEditPrivilege(id);
            btnInvalidate.Visible = !editing && !isNew && approved && chkEditPrivilege(id);
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            if (chkApproved.Checked)
            {
                MessageBox.Show("已經生效核准，無法修改！");
                return;
            }
            SetEditing(true);
        }

        // ── 表身新增明細列 ──────────────────────────────────────────────
        private void btnAddDetailRow_Click(object sender, EventArgs e)
        {
            int i = dataGridView1.Rows.Add();
            dataGridView1.Rows[i].Cells[colOtDate.Index].Value = dtDate.Value.ToString("yyyy/MM/dd");
            dataGridView1.CurrentCell = dataGridView1.Rows[i].Cells[colEmpNo.Index];
        }

        private void btnDeleteDetailRow_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null || dataGridView1.CurrentRow.IsNewRow) return;
            dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
        }

        // ── 下拉選單選定後立即提交(比照全站慣例)，避免使用者選完員工編號/時數/
        //    加班事由後未離開儲存格就直接按「儲存」，導致選取值來不及寫回
        //    Cell.Value，儲存時被誤判為空白而整列被略過 ─────────────────────
        private void dataGridView1_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dataGridView1.IsCurrentCellDirty &&
                (dataGridView1.CurrentCell?.ColumnIndex == colEmpNo.Index ||
                 dataGridView1.CurrentCell?.ColumnIndex == colHours.Index ||
                 dataGridView1.CurrentCell?.ColumnIndex == colReason.Index))
            {
                dataGridView1.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        // ── 員工編號選定後自動帶出姓名(比照全站 PIC/人員選取自動帶名慣例)，
        //    起/訖都有輸入後自動算出時數 ──────────────────────────────────
        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (e.ColumnIndex == colEmpNo.Index)
            {
                var row = dataGridView1.Rows[e.RowIndex];
                string empNo = row.Cells[colEmpNo.Index].Value?.ToString();
                row.Cells[colName.Index].Value = _empNameMap.TryGetValue(empNo ?? "", out var nm) ? nm : "";
            }
            else if (e.ColumnIndex == colStart.Index || e.ColumnIndex == colEnd.Index)
            {
                RecalcHours(e.RowIndex);
            }
        }

        // ── 時數自動計算：起/訖都有值時，依時間差換算小時、四捨五入至最接近
        //    的 0.5 小時(比照表身時數下拉選單的 0.5 級距) ──────────────────
        private void RecalcHours(int rowIndex)
        {
            var row = dataGridView1.Rows[rowIndex];
            string startText = row.Cells[colStart.Index].Value?.ToString();
            string endText = row.Cells[colEnd.Index].Value?.ToString();
            if (string.IsNullOrEmpty(startText) || string.IsNullOrEmpty(endText)) return;
            if (!TimeSpan.TryParse(startText, out var start) || !TimeSpan.TryParse(endText, out var end)) return;

            double minutes = (end - start).TotalMinutes;
            if (minutes < 0) minutes += 24 * 60; // ── 訖早於起，視為跨夜 ──
            double hours = Math.Round(minutes / 60.0 * 2, MidpointRounding.AwayFromZero) / 2.0;
            row.Cells[colHours.Index].Value = ToComboText(colHours, hours.ToString("0.0"));
        }

        // ── 日期切換：新增模式下重新預覽單據編號(比照原巨集「日期」欄位
        //    AfterUpdate)；修改既有單時不重算(單據不因日期變更而重新編號) ──────
        private void dtDate_ValueChanged(object sender, EventArgs e)
        {
            if (_loading) return;
            RefreshNoPreview();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (_currentIndex > 0) DisplayCurrent(_currentIndex - 1);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (_currentIndex < _headerList.Count - 1) DisplayCurrent(_currentIndex + 1);
        }

        // ── 儲存：新單呼叫 SaveOvertimeApply(交易內產生單據編號)，
        //    既有單呼叫 UpdateOvertimeApply；表身整批刪除重建 ─────────────
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cboCostUnit.SelectedIndex < 0 && string.IsNullOrEmpty(cboCostUnit.Text))
            {
                MessageBox.Show("請選擇申請單位!");
                return;
            }
            if (cboApplicant.SelectedIndex < 0 && string.IsNullOrEmpty(cboApplicant.Text))
            {
                MessageBox.Show("請選擇申請人!");
                return;
            }

            bool isNew = _mode == "新增";
            var form = new H加班申請單
            {
                // ── 單據編號僅供畫面預覽，新單一律交由後端於儲存交易內產生
                //    最終權威編號(避免多人同時新增造成編號衝突) ──────────────
                單據編號 = isNew ? null : txtNo.Text,
                申請單位 = cboCostUnit.Text,
                申請日期 = dtDate.Value.ToString("yyyy/MM/dd"),
                申請人 = cboApplicant.Text,
                detailList = new List<H核准加班明細>(),
            };
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.IsNewRow) continue;
                string empNo = row.Cells[colEmpNo.Index].Value?.ToString();
                if (string.IsNullOrEmpty(empNo)) continue;
                double.TryParse(row.Cells[colHours.Index].Value?.ToString(), out var hours);
                form.detailList.Add(new H核准加班明細
                {
                    識別碼 = ToInt(row.Cells[colId.Index].Value),
                    員工編號 = empNo,
                    加班日期 = row.Cells[colOtDate.Index].Value?.ToString(),
                    起 = row.Cells[colStart.Index].Value?.ToString(),
                    訖 = row.Cells[colEnd.Index].Value?.ToString(),
                    時數 = hours,
                    加班事由 = row.Cells[colReason.Index].Value?.ToString(),
                    加班內容詳述 = row.Cells[colDetail.Index].Value?.ToString(),
                    備註 = row.Cells[colRemark.Index].Value?.ToString(),
                });
            }

            if (isNew)
            {
                var rep = new HRController().SaveOvertimeApply(form);
                if (!string.IsNullOrEmpty(rep.ErrorMessage))
                {
                    MessageBox.Show(rep.ErrorMessage);
                    return;
                }
                form.單據編號 = rep.result;
            }
            else
            {
                var rep = new HRController().UpdateOvertimeApply(form);
                if (!string.IsNullOrEmpty(rep.ErrorMessage))
                {
                    MessageBox.Show(rep.ErrorMessage);
                    return;
                }
            }
            _mode = "修改";
            MessageBox.Show("儲存成功!");

            var listRep = new HRController().GetOvertimeApplyList();
            _headerList = listRep.resultList ?? new List<H加班申請單>();
            int idx = _headerList.FindIndex(x => x.單據編號 == form.單據編號);
            DisplayCurrent(idx >= 0 ? idx : _headerList.Count - 1);
        }

        // ── 生效：核准人員為空才寫入登入者姓名，已生效則提示按錯(比照原巨集) ──
        private void btnValidate_Click(object sender, EventArgs e)
        {
            if (_mode == "新增") return;
            if (!string.IsNullOrEmpty(txtApprover.Text))
            {
                MessageBox.Show("提醒您集中精神，已經生效,您按錯囉!");
                return;
            }
            var rep = new HRController().ValidateOvertimeApply(txtNo.Text, true, AppSession.User?.name);
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }
            MessageBox.Show("生效成功!");
            DisplayCurrent(_currentIndex);
        }

        // ── 取消生效：需二次確認，清空核准人員(比照原巨集) ─────────────────
        private void btnInvalidate_Click(object sender, EventArgs e)
        {
            if (_mode == "新增") return;
            if (MessageBox.Show("您確定要取消生效", "請選擇", MessageBoxButtons.YesNo) != DialogResult.Yes) return;
            var rep = new HRController().ValidateOvertimeApply(txtNo.Text, false, null);
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }
            DisplayCurrent(_currentIndex);
        }

        // ── 刪除：已核准無法刪除(比照原巨集) ──────────────────────────────
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_mode == "新增") return;
            if (chkApproved.Checked)
            {
                MessageBox.Show("已經生效核准，無法修改！");
                return;
            }
            if (MessageBox.Show("您確定要刪除本申請單", "請選擇", MessageBoxButtons.YesNo) != DialogResult.Yes) return;

            var rep = new HRController().DeleteOvertimeApply(txtNo.Text);
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }
            MessageBox.Show("刪除成功!");
            var listRep = new HRController().GetOvertimeApplyList();
            _headerList = listRep.resultList ?? new List<H加班申請單>();
            if (_headerList.Count == 0) NewRecord();
            else DisplayCurrent(Math.Min(_currentIndex, _headerList.Count - 1));
        }

        // ── 總覽：開啟(或切換至)「加班申請明細查詢」頁籤(比照原巨集開啟
        //    「H-加班申請明細查詢」物件；原巨集另會關閉本表單，此處改採頁籤
        //    方式保留本頁，比照「員工考勤核對」慣例) ─────────────────────────
        private void btnOverview_Click(object sender, EventArgs e)
        {
            if (!(Parent is TabPage) || !(((TabPage)Parent).Parent is TabControl)) return;
            TabControl tabControl = (TabControl)((TabPage)Parent).Parent;
            const string tabName = "OvertimeOverview";
            foreach (TabPage page in tabControl.TabPages)
            {
                if (page.Name == tabName)
                {
                    tabControl.SelectedTab = page;
                    return;
                }
            }
            var ctrl = new OverTimeOverviewControl { Dock = DockStyle.Fill };
            var tab = new TabPage("加班申請明細查詢") { Name = tabName };
            tab.Controls.Add(ctrl);
            tabControl.TabPages.Add(tab);
            tabControl.SelectedTab = tab;
        }

        // ── 員工別加班紀錄表：開啟(或切換至)頁籤，比照原巨集依「財管權限」
        //    核准與否決定瀏覽全部員工或僅鎖定登入者本人(已於 OverTimeDetail
        //    內部依 chkEditPrivilege 判斷) ───────────────────────────────
        private void btnStaffReport_Click(object sender, EventArgs e)
        {
            OpenStaffReportTab();
        }

        private void OpenStaffReportTab()
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

        private void btnPrint_Click(object sender, EventArgs e) => MessageBox.Show("此功能尚未開放");

        private static int ToInt(object value)
        {
            return int.TryParse(value?.ToString(), out var v) ? v : 0;
        }

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
