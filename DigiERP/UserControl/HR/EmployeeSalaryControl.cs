using DigiERP.Common;
using DigiERP.Forms.HR;
using DigiERP.Models;
using MES.Core.Model;
using MES.WebAPI.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DigiERP.UserControl.HR
{
    // ── 員工薪資核定紀錄：由「員工清冊」點選工號開啟；表頭資料來源為 H員工清冊，
    //    表身(可多筆核薪歷程，一次僅顯示一筆並附上下筆切換)資料來源為
    //    H員工基本資料，比照 PITS-2025.accdb 之「H-員工薪給結構」/
    //    「H-員工核薪履歷」表單版面與邏輯建置 ──────────────────────────────
    public partial class EmployeeSalaryControl : CommonUserControl
    {
        private static string id = "1B4E7C92-3A6D-4F58-9E1A-8C2D5B6A9F03";

        private string _empNo;
        private bool _editing;
        private List<string> _empNoList = new List<string>();
        private List<H員工基本資料> _salaryList = new List<H員工基本資料>();
        private int _currentIndex = -1;

        public EmployeeSalaryControl()
        {
            if (!chkPrivilege(id))
            {
                MessageBox.Show("非授權使用者無法使用此功能!");
                Dispose();
                return;
            }
            InitializeComponent();
            HookRecalcEvents();
            LoadData(string.Empty);
        }

        internal void LoadData(string empNo)
        {
            if (string.IsNullOrEmpty(empNo))
            {
                empNo = AppSession.User.empNo;
            }
            _empNo = empNo;
            //if (string.IsNullOrEmpty(_empNo))
            //    return;
            LoadEmpNoList();
            LoadHeader();
            LoadSalaryList();
            SetEditing(false);
        }

        // ── 依工號排序取得全部員工工號清單，供 ◄/► 切換上一位/下一位員工使用 ──
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
            var rep = new HRController().GetWorkerByNumber(_empNo);
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }
            var x = rep.result ?? new H員工清冊 { 工號 = _empNo };
            txtEmpNo.Text = x.工號;
            txtName.Text = x.姓名;
            txtCardNo.Text = x.卡號;
            txtBirthday.Text = x.生日;
            txtDept.Text = x.部門;
            txtJobTitle.Text = x.職稱;
            txtHRNo.Text = x.人事編號;
            txtStatus.Text = x.狀況;
        }

        private void LoadSalaryList()
        {
            var rep = new HRController().GetEmployeeSalaryList(_empNo);
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }
            _salaryList = rep.resultList ?? new List<H員工基本資料>();
            _currentIndex = _salaryList.Count > 0 ? 0 : -1;
            DisplayCurrent();
        }

        // ── 依 _currentIndex 顯示當前這一筆核薪紀錄(單筆表單，同 Access 單一表單檢視) ──
        private void DisplayCurrent()
        {
            lblRecInfo.Text = $"薪資紀錄 {(_currentIndex >= 0 ? _currentIndex + 1 : 0)}/{_salaryList.Count}";
            btnRecPrev.Enabled = _currentIndex > 0;
            btnRecNext.Enabled = _currentIndex >= 0 && _currentIndex < _salaryList.Count - 1;

            if (_currentIndex < 0 || _currentIndex >= _salaryList.Count)
            {
                ClearFields();
                UpdateValidateButtonsVisibility();
                return;
            }

            var x = _salaryList[_currentIndex];
            txtId.Text = x.識別碼.ToString();
            numGrade.Value = x.職等 ?? 0;
            numRank.Value = x.職級 ?? 0;
            txtSalaryDate.Text = x.核薪日;
            txtResignDate.Text = x.離職日;
            numBaseSalary.Value = x.本薪 ?? 0;
            numPositionAllowance.Value = x.職務加給 ?? 0;
            numSupervisorAllowance.Value = x.主管津貼 ?? 0;
            numMealAllowance.Value = x.每日伙食津貼 ?? 0;
            numDailyWage.Value = x.日薪 ?? 0;
            numHourlyWage.Value = (decimal)(x.時薪 ?? 0);
            numBonus.Value = x.全勤獎金 ?? 0;
            numOtherAdd.Value = x.其他加項 ?? 0;
            numInsuranceGrade.Value = x.投保等級 ?? 0;
            numDependents.Value = x.眷保口數 ?? 0;
            numLaborIns.Value = x.勞保 ?? 0;
            numHealthIns.Value = x.健保 ?? 0;
            numDependentIns.Value = x.眷保 ?? 0;
            numPensionSelf.Value = x.退休金自提 ?? 0;
            numPensionCompany.Value = x.退休公司提 ?? 0;
            numOtherDeduct.Value = x.其他減項 ?? 0;
            txtNote1.Text = x.備註一;
            txtNote2.Text = x.備註二;
            txtNote3.Text = x.備註三;
            txtApprover.Text = x.核准人員;
            txtMaintainer.Text = x.建檔維護;
            RecalcTotal();
            UpdateValidateButtonsVisibility();
        }

        // ── 生效/取消生效 只允許同時看到一個：已核准就只顯示「取消生效」，
        //    未核准就只顯示「生效」 ────────────────────────────────────────
        private void UpdateValidateButtonsVisibility()
        {
            bool hasRecord = _currentIndex >= 0;
            bool approved = hasRecord && !string.IsNullOrEmpty(txtApprover.Text);
            btnValidate.Visible = hasRecord && !approved;
            btnInvalidate.Visible = hasRecord && approved;
        }

        private void ClearFields()
        {
            txtId.Text = "";
            numGrade.Value = 0; numRank.Value = 0;
            txtSalaryDate.Text = ""; txtResignDate.Text = "";
            numBaseSalary.Value = 0; numPositionAllowance.Value = 0; numSupervisorAllowance.Value = 0;
            numMealAllowance.Value = 0; numDailyWage.Value = 0; numHourlyWage.Value = 0;
            numBonus.Value = 0; numOtherAdd.Value = 0; numInsuranceGrade.Value = 0;
            numDependents.Value = 0; numLaborIns.Value = 0; numHealthIns.Value = 0;
            numDependentIns.Value = 0; numPensionSelf.Value = 0; numPensionCompany.Value = 0;
            numOtherDeduct.Value = 0;
            txtNote1.Text = ""; txtNote2.Text = ""; txtNote3.Text = "";
            txtApprover.Text = ""; txtMaintainer.Text = "";
            txtTotal.Text = "0";
        }

        // ── 薪資合計：=[本薪]+[職務加給]+[主管津貼]+[全勤獎金]+[其他加項]+[每日伙食費]*30
        //    (與 Access 原表單計算控制項公式一致，*30 僅乘每日伙食費) ────────────
        private void HookRecalcEvents()
        {
            foreach (var num in new[] { numBaseSalary, numPositionAllowance, numSupervisorAllowance, numBonus, numOtherAdd, numMealAllowance })
            {
                num.ValueChanged += (s, e) => RecalcTotal();
            }
        }

        private void RecalcTotal()
        {
            decimal total = numBaseSalary.Value + numPositionAllowance.Value + numSupervisorAllowance.Value
                           + numBonus.Value + numOtherAdd.Value + numMealAllowance.Value * 30;
            txtTotal.Text = total.ToString();
        }

        // ── 鎖定/解鎖：比照全站「唯讀→修改解鎖→儲存」慣例 ───────────────────
        private void SetEditing(bool editing)
        {
            _editing = editing;
            foreach (var num in new[] { numGrade, numRank, numBaseSalary, numPositionAllowance, numSupervisorAllowance,
                                         numMealAllowance, numDailyWage, numHourlyWage, numBonus, numOtherAdd,
                                         numInsuranceGrade, numDependents, numLaborIns, numHealthIns, numDependentIns,
                                         numPensionSelf, numPensionCompany, numOtherDeduct })
            {
                num.ReadOnly = !editing;
            }
            txtSalaryDate.ReadOnly = !editing;
            txtResignDate.ReadOnly = !editing;
            txtNote1.ReadOnly = !editing;
            txtNote2.ReadOnly = !editing;
            txtNote3.ReadOnly = !editing;

            btnModify.Visible = !editing && chkEditPrivilege(id);
            btnSave.Visible = editing;
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            if (_currentIndex < 0)
            {
                MessageBox.Show("請先按「新增一筆」建立核薪紀錄!");
                return;
            }
            SetEditing(true);
        }

        private H員工基本資料 BuildFormFromFields()
        {
            return new H員工基本資料
            {
                識別碼 = int.TryParse(txtId.Text, out var idVal) ? idVal : 0,
                工號 = _empNo,
                職等 = (int)numGrade.Value,
                職級 = (int)numRank.Value,
                核薪日 = txtSalaryDate.Text,
                離職日 = txtResignDate.Text,
                本薪 = (int)numBaseSalary.Value,
                職務加給 = (int)numPositionAllowance.Value,
                主管津貼 = (int)numSupervisorAllowance.Value,
                每日伙食津貼 = (int)numMealAllowance.Value,
                日薪 = (int)numDailyWage.Value,
                時薪 = (double)numHourlyWage.Value,
                全勤獎金 = (int)numBonus.Value,
                其他加項 = (int)numOtherAdd.Value,
                投保等級 = (int)numInsuranceGrade.Value,
                眷保口數 = (int)numDependents.Value,
                勞保 = (int)numLaborIns.Value,
                健保 = (int)numHealthIns.Value,
                眷保 = (int)numDependentIns.Value,
                退休金自提 = (int)numPensionSelf.Value,
                退休公司提 = (int)numPensionCompany.Value,
                其他減項 = (int)numOtherDeduct.Value,
                備註一 = txtNote1.Text,
                備註二 = txtNote2.Text,
                備註三 = txtNote3.Text,
                建檔維護 = AppSession.User?.username,
            };
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var form = BuildFormFromFields();
            bool wasNew = form.識別碼 == 0;
            var rep = new HRController().SaveEmployeeSalary(form);
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }
            MessageBox.Show("儲存成功!");
            int keepId = form.識別碼;
            LoadSalaryListKeepPosition(wasNew, keepId);
            SetEditing(false);
        }

        private void LoadSalaryListKeepPosition(bool wasNew, int keepId)
        {
            var rep = new HRController().GetEmployeeSalaryList(_empNo);
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }
            _salaryList = rep.resultList ?? new List<H員工基本資料>();
            if (wasNew)
            {
                _currentIndex = _salaryList.Count - 1;
            }
            else
            {
                int idx = _salaryList.FindIndex(x => x.識別碼 == keepId);
                _currentIndex = idx >= 0 ? idx : (_salaryList.Count > 0 ? 0 : -1);
            }
            DisplayCurrent();
        }

        // ── 新增一筆：比照原表單，新記錄可直接編輯 ──────────────────────────
        private void btnRecNew_Click(object sender, EventArgs e)
        {
            var blank = new H員工基本資料 { 識別碼 = 0, 工號 = _empNo };
            _salaryList.Add(blank);
            _currentIndex = _salaryList.Count - 1;
            DisplayCurrent();
            SetEditing(true);
        }

        private void btnRecPrev_Click(object sender, EventArgs e)
        {
            if (_currentIndex > 0) { _currentIndex--; DisplayCurrent(); SetEditing(false); }
        }

        private void btnRecNext_Click(object sender, EventArgs e)
        {
            if (_currentIndex < _salaryList.Count - 1) { _currentIndex++; DisplayCurrent(); SetEditing(false); }
        }

        // ── 生效：核准人員為空才寫入登入者姓名，已生效則提示按錯 ────────────
        private void btnValidate_Click(object sender, EventArgs e)
        {
            if (_currentIndex < 0 || string.IsNullOrEmpty(txtId.Text) || txtId.Text == "0")
            {
                MessageBox.Show("請先儲存後再生效!");
                return;
            }
            int id2 = int.Parse(txtId.Text);
            if (!string.IsNullOrEmpty(txtApprover.Text))
            {
                MessageBox.Show("提醒您集中精神，已經生效,您按錯囉!");
                return;
            }
            var rep = new HRController().ValidateEmployeeSalary(id2, true, AppSession.User?.username);
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }
            LoadSalaryListKeepPosition(false, id2);
        }

        // ── 取消生效：需二次確認，清空核准人員 ─────────────────────────────
        private void btnInvalidate_Click(object sender, EventArgs e)
        {
            if (_currentIndex < 0 || string.IsNullOrEmpty(txtId.Text) || txtId.Text == "0") return;
            int id2 = int.Parse(txtId.Text);
            if (MessageBox.Show("您確定要取消生效", "請選擇", MessageBoxButtons.YesNo) != DialogResult.Yes) return;
            var rep = new HRController().ValidateEmployeeSalary(id2, false, null);
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }
            LoadSalaryListKeepPosition(false, id2);
        }

        // ── 刪除此筆紀錄：已核准無法刪除；需先進入修改模式才可刪除 ───────────
        private void btnDeleteRecord_Click(object sender, EventArgs e)
        {
            if (_currentIndex < 0) return;
            if (!_editing)
            {
                MessageBox.Show("刪除紀錄前,請先按修改鍵!");
                return;
            }
            if (!string.IsNullOrEmpty(txtApprover.Text))
            {
                MessageBox.Show("已核准無法刪除，請洽後台管理員！");
                return;
            }
            if (txtId.Text == "0" || string.IsNullOrEmpty(txtId.Text))
            {
                _salaryList.RemoveAt(_currentIndex);
                _currentIndex = _salaryList.Count > 0 ? Math.Min(_currentIndex, _salaryList.Count - 1) : -1;
                DisplayCurrent();
                SetEditing(false);
                return;
            }
            if (MessageBox.Show("確定要刪除此筆紀錄?", "請選擇", MessageBoxButtons.YesNo) != DialogResult.Yes) return;
            var rep = new HRController().DeleteEmployeeSalary(int.Parse(txtId.Text));
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }
            LoadSalaryList();
            SetEditing(false);
        }

        // ── 列印：原 Access 表單此按鈕尚未串接任何動作，本頁暫以提示取代 ─────
        private void btnPrint_Click(object sender, EventArgs e)
        {
            MessageBox.Show("此功能尚未開放!");
        }

        // ── 修改員工個資：開啟 FrmEmployeeMaintain 編輯模式，儲存後回填表頭 ──
        private void btnEditPersonal_Click(object sender, EventArgs e)
        {
            using var frm = new FrmEmployeeMaintain(_empNo);
            if (frm.ShowDialog(this) == DialogResult.OK)
            {
                LoadHeader();
            }
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            GoToAdjacentEmployee(-1);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            GoToAdjacentEmployee(1);
        }

        private void GoToAdjacentEmployee(int step)
        {
            int idx = _empNoList.IndexOf(_empNo);
            if (idx < 0) return;
            int newIdx = idx + step;
            if (newIdx < 0 || newIdx >= _empNoList.Count) return;
            LoadData(_empNoList[newIdx]);
        }

        // ── 總覽/關閉：關閉本頁籤，切換至(或開啟)員工清冊列表頁籤 ────────────
        private void btnOverview_Click(object sender, EventArgs e)
        {
            CloseAndGoToList();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            CloseAndGoToList();
        }

        private void CloseAndGoToList()
        {
            if (!(Parent is TabPage) || !(((TabPage)Parent).Parent is TabControl)) { Dispose(); return; }
            TabControl tabControl = (TabControl)((TabPage)Parent).Parent;
            var selfTab = (TabPage)Parent;
            foreach (TabPage page in tabControl.TabPages)
            {
                if (page != selfTab && page.Controls.Count > 0 && page.Controls[0] is EmployeeControl)
                {
                    tabControl.SelectedTab = page;
                    break;
                }
            }
            tabControl.TabPages.Remove(selfTab);
            Dispose();
        }
    }
}
