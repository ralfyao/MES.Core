using DigiERP.Models;
using MES.Core.Model;
using MES.WebAPI.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DigiERP.Forms.HR.CostUnit
{
    // ── 成本單位：比照 PITS-2025.accdb 之「A-成本單位」(表頭 A成本單位)+
    //    「A-成本單位人員配置」子表單(表身，一個成本單位可配置多位人員及其
    //    核准/編修/報表/輸出權限)建置；以清單瀏覽方式前一筆/下一筆依「職務」
    //    切換，比照原巨集：
    //      前一筆記錄(Command28)／下一筆記錄(Command27) → GoToRecord
    //      新增職務(Command30) → 需具「系統權限.核准」(此處對應「核准」旗標，
    //             與一般的「編修」旗標分開判斷)才能開一張空白職務
    //      編修記錄(Command32) → 需具「系統權限.編修」才能解鎖編輯目前記錄
    //      儲存記錄(Command29) → SaveRecord；此處以「職務」為業務鍵，新增時
    //             會先檢查職務是否已存在，表身整批刪除重建
    //      關閉表單(Command31) → 關閉本視窗 ─────────────────────────────
    public partial class FrmCostUnit : Form
    {
        private static string id = "2CD1EED1-B7A9-408D-8593-DBF7FF2AE12B";

        private List<string> _positionList = new List<string>();
        private int _currentIndex = -1;
        private string _mode = "修改";
        private bool _loading;
        private Dictionary<string, string> _accountNameMap = new Dictionary<string, string>();

        public FrmCostUnit()
        {
            InitializeComponent();
            InitAccountCombo();
            LoadList();
        }

        // ── 是否具備「核准」權限(比照原巨集「系統權限.核准」，用於新增職務) ───
        private static bool HasApprovePrivilege(string privilegeId)
        {
            if (AppSession.User?.name?.ToUpper() == "ADMIN") return true;
            var p = AppSession.User?.privilegeList?.FirstOrDefault(x => x.授權子表單?.ToString().ToLower() == privilegeId.ToLower());
            return p != null && ((p.高管 ?? false) || (p.核准 ?? false));
        }

        // ── 是否具備「編修」權限(比照原巨集「系統權限.編修」，用於編修/儲存) ───
        private static bool HasEditPrivilege(string privilegeId)
        {
            if (AppSession.User?.name?.ToUpper() == "ADMIN") return true;
            var p = AppSession.User?.privilegeList?.FirstOrDefault(x => x.授權子表單?.ToString().ToLower() == privilegeId.ToLower());
            return p != null && ((p.高管 ?? false) || (p.編修 ?? false));
        }

        // ── 表身員工編號下拉：來源為未停用之帳號(比照原巨集 RowSource) ───────
        private void InitAccountCombo()
        {
            var rep = new UserPrivilegeController().GetActiveAccountList();
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }
            var accounts = rep.resultList ?? new List<account>();
            _accountNameMap = accounts.Where(x => !string.IsNullOrEmpty(x.帳號))
                .GroupBy(x => x.帳號)
                .ToDictionary(g => g.Key, g => g.First().姓名);
            colAccount.Items.Clear();
            foreach (var x in accounts.Where(x => !string.IsNullOrEmpty(x.帳號)))
            {
                colAccount.Items.Add(x.帳號);
            }
        }

        private void LoadList()
        {
            var rep = new HRController().GetCostUnitList();
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }
            _positionList = rep.resultList ?? new List<string>();
            if (_positionList.Count > 0)
            {
                DisplayCurrent(_positionList.Count - 1);
            }
            else
            {
                NewRecord();
            }
        }

        private void UpdateRecordInfo()
        {
            if (_mode == "新增")
            {
                lblRecordInfo.Text = $"新增中(尚未儲存) / 共 {_positionList.Count} 筆";
            }
            else
            {
                lblRecordInfo.Text = _positionList.Count == 0
                    ? "第 0 筆 / 共 0 筆"
                    : $"第 {_currentIndex + 1} 筆 / 共 {_positionList.Count} 筆";
            }
        }

        private void DisplayCurrent(int index)
        {
            if (_positionList.Count == 0) { NewRecord(); return; }
            if (index < 0) index = 0;
            if (index > _positionList.Count - 1) index = _positionList.Count - 1;
            _currentIndex = index;

            var rep = new HRController().GetCostUnitByPosition(_positionList[_currentIndex]);
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }
            var form = rep.result;
            if (form == null) return;
            _mode = "修改";
            PopulateForm(form);
            SetEditing(false);
        }

        private void PopulateForm(A成本單位 form)
        {
            _loading = true;
            txtPosition.Text = form.職務;
            numHeadcount.Value = form.標準編制 ?? 0;
            txtParentUnit1.Text = form.上一級單位;
            txtParentUnit2.Text = form.上兩級單位;
            txtOperationFunction.Text = form.操作功能;
            FillGrid(form.detailList ?? new List<成本單位人員配置>());
            UpdateRecordInfo();
            _loading = false;
        }

        private void FillGrid(List<成本單位人員配置> list)
        {
            dataGridView1.Rows.Clear();
            foreach (var x in list)
            {
                int i = dataGridView1.Rows.Add();
                var row = dataGridView1.Rows[i];
                row.Cells[colId.Index].Value = x.識別碼;
                if (!string.IsNullOrEmpty(x.員工編號) && !colAccount.Items.Contains(x.員工編號))
                {
                    colAccount.Items.Add(x.員工編號);
                }
                row.Cells[colAccount.Index].Value = x.員工編號;
                row.Cells[colName.Index].Value = x.姓名;
                row.Cells[colApprove.Index].Value = x.核准 ?? false;
                row.Cells[colEdit.Index].Value = x.編修 ?? false;
                row.Cells[colReport.Index].Value = x.報表 ?? false;
                row.Cells[colOutput.Index].Value = x.輸出 ?? false;
                row.Cells[colNote.Index].Value = x.註記;
                row.Cells[colDelegateExpiry.Index].Value = x.職務代理效期?.ToString("yyyy/MM/dd");
                row.Cells[colMachineNo.Index].Value = x.機號;
            }
        }

        // ── 新增職務：需具「核准」權限(比照原巨集) ──────────────────────────
        private void btnNew_Click(object sender, EventArgs e)
        {
            if (!HasApprovePrivilege(id))
            {
                MessageBox.Show("抱歉：非經授權，無法操作！");
                return;
            }
            NewRecord();
        }

        private void NewRecord()
        {
            _loading = true;
            _mode = "新增";
            _currentIndex = _positionList.Count;
            txtPosition.Text = "";
            numHeadcount.Value = 0;
            txtParentUnit1.Text = "";
            txtParentUnit2.Text = "";
            txtOperationFunction.Text = "";
            dataGridView1.Rows.Clear();
            UpdateRecordInfo();
            _loading = false;
            SetEditing(true);
        }

        // ── 鎖定/解鎖：表格層級的 ReadOnly 會覆蓋所有欄位層級設定，兩者都要切換 ──
        private void SetEditing(bool editing)
        {
            txtPosition.ReadOnly = !(editing && _mode == "新增"); // 職務為業務鍵，既有記錄不可更改
            numHeadcount.Enabled = editing;
            txtParentUnit1.ReadOnly = !editing;
            txtParentUnit2.ReadOnly = !editing;
            txtOperationFunction.ReadOnly = !editing;
            dataGridView1.ReadOnly = !editing;
            foreach (DataGridViewColumn col in dataGridView1.Columns)
            {
                if (col == colId || col == colName) continue;
                col.ReadOnly = !editing;
            }
            panelGridTool.Visible = editing;

            bool isNew = _mode == "新增";
            btnPrev.Enabled = !editing;
            btnNext.Enabled = !editing;
            btnNew.Enabled = !editing;
            btnModify.Visible = !editing && !isNew && HasEditPrivilege(id);
            btnSave.Visible = editing;
        }

        // ── 編修記錄：需具「編修」權限(比照原巨集) ──────────────────────────
        private void btnModify_Click(object sender, EventArgs e)
        {
            if (!HasEditPrivilege(id))
            {
                MessageBox.Show("抱歉：非經授權，無法操作！");
                return;
            }
            SetEditing(true);
        }

        private void btnAddDetailRow_Click(object sender, EventArgs e)
        {
            int i = dataGridView1.Rows.Add();
            dataGridView1.CurrentCell = dataGridView1.Rows[i].Cells[colAccount.Index];
        }

        private void btnDeleteDetailRow_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null || dataGridView1.CurrentRow.IsNewRow) return;
            dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
        }

        // ── 下拉選單選定後立即提交，避免選完未離開儲存格就存檔導致漏存 ────────
        private void dataGridView1_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dataGridView1.IsCurrentCellDirty && dataGridView1.CurrentCell?.ColumnIndex == colAccount.Index)
            {
                dataGridView1.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        // ── 員工編號選定後自動帶出姓名(比照原巨集 DLookUp(帳號→姓名)) ─────────
        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex != colAccount.Index) return;
            var row = dataGridView1.Rows[e.RowIndex];
            string account = row.Cells[colAccount.Index].Value?.ToString();
            row.Cells[colName.Index].Value = _accountNameMap.TryGetValue(account ?? "", out var nm) ? nm : "";
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (_currentIndex > 0) DisplayCurrent(_currentIndex - 1);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (_currentIndex < _positionList.Count - 1) DisplayCurrent(_currentIndex + 1);
        }

        // ── 儲存記錄：新增或修改依 _mode 判斷，表身整批刪除重建 ──────────────
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPosition.Text))
            {
                MessageBox.Show("請輸入職務!");
                return;
            }

            bool isNew = _mode == "新增";
            var form = new A成本單位
            {
                職務 = txtPosition.Text.Trim(),
                標準編制 = (int)numHeadcount.Value,
                上一級單位 = txtParentUnit1.Text,
                上兩級單位 = txtParentUnit2.Text,
                操作功能 = txtOperationFunction.Text,
                detailList = new List<成本單位人員配置>(),
            };
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.IsNewRow) continue;
                string acct = row.Cells[colAccount.Index].Value?.ToString();
                if (string.IsNullOrEmpty(acct)) continue;
                DateTime.TryParse(row.Cells[colDelegateExpiry.Index].Value?.ToString(), out var expiry);
                form.detailList.Add(new 成本單位人員配置
                {
                    識別碼 = ToInt(row.Cells[colId.Index].Value),
                    員工編號 = acct,
                    核准 = ToBool(row.Cells[colApprove.Index].Value),
                    編修 = ToBool(row.Cells[colEdit.Index].Value),
                    報表 = ToBool(row.Cells[colReport.Index].Value),
                    輸出 = ToBool(row.Cells[colOutput.Index].Value),
                    註記 = row.Cells[colNote.Index].Value?.ToString(),
                    職務代理效期 = expiry == default ? (DateTime?)null : expiry,
                    機號 = row.Cells[colMachineNo.Index].Value?.ToString(),
                });
            }

            var rep = new HRController().SaveCostUnit(form, isNew);
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }
            _mode = "修改";
            MessageBox.Show("儲存成功!");

            var listRep = new HRController().GetCostUnitList();
            _positionList = listRep.resultList ?? new List<string>();
            int idx = _positionList.IndexOf(form.職務);
            DisplayCurrent(idx >= 0 ? idx : _positionList.Count - 1);
        }

        private static int ToInt(object value) => int.TryParse(value?.ToString(), out var v) ? v : 0;

        private static bool ToBool(object value) => value is bool b && b;

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
