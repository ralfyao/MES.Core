using DigiERP.Models;
using MES.Core.Model;
using MES.WebAPI.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DigiERP.Forms.HR.PositionWorkCategory
{
    // ── 職務工作類別：比照 PITS-2025.accdb 之「A-職務工作類別」建置；表頭
    //    與「A-成本單位」共用同一張表(A成本單位，以「職務」瀏覽)，但本表單
    //    只顯示「職務」欄位，表身改為「A-職務分類績效點數」子表單(對應
    //    H職務工作分類：代碼/分類名稱/積分點數/說明)。比照原巨集：
    //      前一筆/下一筆(Command27/28) → GoToRecord
    //      新增職務(Command30) → 需具「系統權限.核准」，僅新增 A成本單位.職務
    //             一筆(不影響「成本單位」畫面管理的人員配置資料)
    //      編修記錄(Command32) → 需具「系統權限.編修」，解鎖分類點數表身編輯
    //      儲存記錄(Command29) → SaveRecord，分類點數表身整批刪除重建
    //      關閉表單(Command31) → 關閉本視窗 ─────────────────────────────
    public partial class FrmPositionWorkCategory : Form
    {
        private static string id = "2F10D2BB-2A5F-4950-89B4-86A6C0B410FB";

        private List<string> _positionList = new List<string>();
        private int _currentIndex = -1;
        private string _mode = "修改";

        public FrmPositionWorkCategory()
        {
            InitializeComponent();
            colPoints.Items.Clear();
            colPoints.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
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

            string position = _positionList[_currentIndex];
            var rep = new HRController().getPositionList(position);
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }
            _mode = "修改";
            txtPosition.Text = position;
            FillGrid(rep.resultList ?? new List<H職務工作分類>());
            UpdateRecordInfo();
            SetEditing(false);
        }

        private void FillGrid(List<H職務工作分類> list)
        {
            dataGridView1.Rows.Clear();
            foreach (var x in list)
            {
                int i = dataGridView1.Rows.Add();
                var row = dataGridView1.Rows[i];
                row.Cells[colId.Index].Value = x.識別碼;
                row.Cells[colCode.Index].Value = x.代碼;
                row.Cells[colCategory.Index].Value = x.分類;
                string pts = x.積分點數?.ToString();
                if (!string.IsNullOrEmpty(pts) && !colPoints.Items.Contains(pts)) colPoints.Items.Add(pts);
                row.Cells[colPoints.Index].Value = pts;
                row.Cells[colDesc.Index].Value = x.說明;
            }
        }

        // ── 新增職務：需具「核准」權限，僅新增 A成本單位.職務一筆 ──────────
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
            _mode = "新增";
            _currentIndex = _positionList.Count;
            txtPosition.Text = "";
            dataGridView1.Rows.Clear();
            UpdateRecordInfo();
            SetEditing(true);
        }

        // ── 鎖定/解鎖：表格層級的 ReadOnly 會覆蓋所有欄位層級設定，兩者都要切換 ──
        private void SetEditing(bool editing)
        {
            txtPosition.ReadOnly = !(editing && _mode == "新增"); // 職務為業務鍵，既有記錄不可更改
            dataGridView1.ReadOnly = !editing;
            foreach (DataGridViewColumn col in dataGridView1.Columns)
            {
                if (col == colId) continue;
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
            dataGridView1.CurrentCell = dataGridView1.Rows[i].Cells[colCode.Index];
        }

        private void btnDeleteDetailRow_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null || dataGridView1.CurrentRow.IsNewRow) return;
            dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (_currentIndex > 0) DisplayCurrent(_currentIndex - 1);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (_currentIndex < _positionList.Count - 1) DisplayCurrent(_currentIndex + 1);
        }

        // ── 儲存記錄：新增時先建立 A成本單位.職務(不動人員配置)，既有職務則
        //    僅儲存分類點數表身(整批刪除重建) ──────────────────────────────
        private void btnSave_Click(object sender, EventArgs e)
        {
            string position = txtPosition.Text.Trim();
            if (string.IsNullOrEmpty(position))
            {
                MessageBox.Show("請輸入職務!");
                return;
            }

            bool isNew = _mode == "新增";
            if (isNew)
            {
                var createRep = new HRController().CreateCostUnitPosition(position);
                if (!string.IsNullOrEmpty(createRep.ErrorMessage))
                {
                    MessageBox.Show(createRep.ErrorMessage);
                    return;
                }
            }

            var list = new List<H職務工作分類>();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.IsNewRow) continue;
                string code = row.Cells[colCode.Index].Value?.ToString();
                string category = row.Cells[colCategory.Index].Value?.ToString();
                if (string.IsNullOrEmpty(code) && string.IsNullOrEmpty(category)) continue;
                int.TryParse(row.Cells[colPoints.Index].Value?.ToString(), out var pts);
                list.Add(new H職務工作分類
                {
                    識別碼 = ToInt(row.Cells[colId.Index].Value),
                    職務 = position,
                    代碼 = code,
                    分類 = category,
                    積分點數 = pts,
                    說明 = row.Cells[colDesc.Index].Value?.ToString(),
                });
            }

            var saveRep = new HRController().SavePositionWorkCategoryList(position, list);
            if (!string.IsNullOrEmpty(saveRep.ErrorMessage))
            {
                MessageBox.Show(saveRep.ErrorMessage);
                return;
            }
            _mode = "修改";
            MessageBox.Show("儲存成功!");

            var listRep = new HRController().GetCostUnitList();
            _positionList = listRep.resultList ?? new List<string>();
            int idx = _positionList.IndexOf(position);
            DisplayCurrent(idx >= 0 ? idx : _positionList.Count - 1);
        }

        private static int ToInt(object value) => int.TryParse(value?.ToString(), out var v) ? v : 0;

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
