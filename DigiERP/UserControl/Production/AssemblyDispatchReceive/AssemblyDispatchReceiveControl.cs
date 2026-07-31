using DigiERP.Common;
using DigiERP.Forms.Production;
using DigiERP.Models;
using MES.Core.Model;
using MES.WebAPI.Controllers;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DigiERP.UserControl.Production
{
    // ── 組裝派案及領料作業：列出全部專案模組用料清單，可編修組裝人員/日期/
    //    結案回報/用途；點擊『製圖檔名』欄位可開啟該BOM編號的零配件領料清單 ──
    public partial class AssemblyDispatchReceiveControl : CommonUserControl
    {
        private static string id = "03641277-5CC8-4CA9-8592-F4F5FEE61693";

        // ── 完工日期不在此列：一旦選定結案回報即自動填入並直接寫回資料庫，恆唯讀 ──
        private static readonly string[] EditableColumns =
        {
            "colIssueDate", "colAssemblyStaff", "colStartDate", "colDueDate", "colCloseReport", "colPurpose",
        };

        private bool _editing;
        private string _currentProjectNo;
        private string _selectedProjectNo;
        private List<成本單位人員配置> _staffList = new List<成本單位人員配置>();

        public AssemblyDispatchReceiveControl()
        {
            if (!chkPrivilege(id))
            {
                MessageBox.Show("非授權使用者無法使用此功能!");
                Dispose();
                return;
            }
            InitializeComponent();

            var staffRep = new CustomerController().get組測維修人員List();
            _staffList = staffRep.resultList ?? new List<成本單位人員配置>();

            SetEditMode(false);
            LoadData();
        }

        // ── projectNo 為空時載入全部清單；有帶入時僅篩選該專案序號 ──────────
        internal void LoadData(string projectNo = null)
        {
            _currentProjectNo = projectNo;
            var rep = string.IsNullOrEmpty(projectNo)
                ? new ProjectProgressController().GetModuleMaterialFullList()
                : new ProjectProgressController().GetModuleMaterialList(projectNo);
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }
            FillGrid(rep.resultList ?? new List<專案模組用料清單>());
        }

        private void FillGrid(List<專案模組用料清單> list)
        {
            dataGridView1.Rows.Clear();
            foreach (var x in list)
            {
                var row = new DataGridViewRow();
                row.CreateCells(dataGridView1);
                int i = 0;
                row.Cells[i++].Value = x.專案序號;
                row.Cells[i++].Value = x.模組編碼;
                row.Cells[i++].Value = x.模組名稱;
                row.Cells[i++].Value = x.製圖檔名;
                row.Cells[i++].Value = x.圖檔發行日;
                row.Cells[i++].Value = x.組裝人員;
                row.Cells[i++].Value = x.開工日期;
                row.Cells[i++].Value = x.預交日期;
                row.Cells[i++].Value = x.完工日期;
                row.Cells[i++].Value = x.結案回報;
                row.Cells[i++].Value = x.用途;
                row.Cells[i++].Value = x.BOM編號;
                row.Tag = x;
                dataGridView1.Rows.Add(row);
            }
        }

        // ── 點選『專案序號』欄位：不受修改模式限制(編修中除外)，僅記錄選取的
        //    專案序號，待按下「修改」後才依此專案序號篩選並刷新清單；點選
        //    『製圖檔名』欄位：不受修改模式限制，直接開啟該BOM編號的零配件
        //    領料清單(專案模組用料維護畫面)；點選『組裝人員』欄位：修改模式下
        //    跳出人員選擇視窗(顯示姓名+員工編號)，選定後帶入儲存格 ─────────
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (e.ColumnIndex == colProjectNo.Index)
            {
                if (_editing)
                {
                    MessageBox.Show("請先儲存或取消修改後再切換專案序號");
                    return;
                }
                string projectNo = dataGridView1.Rows[e.RowIndex].Cells[colProjectNo.Index].Value?.ToString();
                if (string.IsNullOrEmpty(projectNo)) return;
                _selectedProjectNo = projectNo;
                return;
            }

            if (e.ColumnIndex == colDrawingFile.Index)
            {
                string closeReport = dataGridView1.Rows[e.RowIndex].Cells[colCloseReport.Index].Value?.ToString();
                if (!string.IsNullOrEmpty(closeReport))
                {
                    MessageBox.Show("已完工結案回報，無法再修編！");
                    return;
                }

                string bomNo = dataGridView1.Rows[e.RowIndex].Cells[colBomNo.Index].Value?.ToString();
                if (string.IsNullOrEmpty(bomNo)) return;
                bomNo = bomNo.Replace("售後維修", "").Replace("廠驗追加", "");
                if (string.IsNullOrEmpty(bomNo)) return;

                using var frm = new FrmMaterialRequisitionList(bomNo);
                frm.ShowDialog(FindForm());
                return;
            }

            if (!_editing) return;

            if (e.ColumnIndex == colAssemblyStaff.Index)
            {
                using var frm = new FrmSelectStaff(_staffList);
                if (frm.ShowDialog(FindForm()) != DialogResult.OK) return;
                dataGridView1.Rows[e.RowIndex].Cells[colAssemblyStaff.Index].Value = frm.SelectedItem.姓名;
            }
        }

        // ── 雙擊『專案序號』欄位：開啟(或切回)該專案的專案機台組測紀錄表頁籤 ──
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex != colProjectNo.Index) return;
            string projectNo = dataGridView1.Rows[e.RowIndex].Cells[colProjectNo.Index].Value?.ToString();
            if (string.IsNullOrEmpty(projectNo)) return;
            OpenProjectMachineTestRecord(projectNo);
        }

        private void OpenProjectMachineTestRecord(string projectNo)
        {
            if (!(Parent is TabPage) || !(((TabPage)Parent).Parent is TabControl)) return;
            TabControl tabControl = (TabControl)((TabPage)Parent).Parent;
            string tabName = "ProjectMachineTestRecord_" + projectNo;
            foreach (TabPage page in tabControl.TabPages)
            {
                if (page.Name == tabName)
                {
                    tabControl.SelectedTab = page;
                    return;
                }
            }
            var ctrl = new ProjectMachineTestRecordControl();
            if (ctrl.IsDisposed) return;
            ctrl.LoadData(projectNo);
            ctrl.Dock = DockStyle.Fill;
            var tab = new TabPage(projectNo + " 專案機台組測紀錄表") { Name = tabName };
            tab.Controls.Add(ctrl);
            tabControl.TabPages.Add(tab);
            tabControl.SelectedTab = tab;
            tabControl.SizeMode = TabSizeMode.Normal;
        }

        // ── 跟其他 Maintain 畫面一致：按「修改」前，可編輯欄位皆為 Disable ──
        private void SetEditMode(bool editing)
        {
            _editing = editing;
            foreach (var name in EditableColumns)
            {
                dataGridView1.Columns[name].ReadOnly = !editing;
            }
            btnSave.Enabled = editing;
        }

        // ── 修改：先依上次點選的專案序號篩選並刷新清單，再解鎖可編輯欄位 ────
        private void btnEdit_Click(object sender, EventArgs e)
        {
            LoadData(_selectedProjectNo);
            SetEditMode(true);
        }

        // ── 結案回報為下拉欄位，若儲存值不在合規/特採/設計變更選項中(如舊資料)，
        //    ComboBox 找不到對應項目時 WinForms 預設會跳例外對話方塊，這裡直接吃掉 ──
        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
        }

        // ── 結案回報下拉選單選取後立即提交，才能在 CellValueChanged 判斷值 ──
        private void dataGridView1_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dataGridView1.IsCurrentCellDirty && dataGridView1.CurrentCell?.ColumnIndex == colCloseReport.Index)
            {
                dataGridView1.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        // ── 結案回報一經選定(合規/特採/設計變更任一)：完工日期自動填入今日並
        //    立即寫回資料庫(不等按「儲存」)；選擇『設計變更』時額外開啟(或
        //    切回)異常矯正措施報告頁籤，來源單據取自製圖檔名，並去除其中的
        //    『售後維修』、『廠驗追加』字樣 ─────────────────────────────
        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex != colCloseReport.Index) return;

            var row = dataGridView1.Rows[e.RowIndex];
            string closeReport = row.Cells[colCloseReport.Index].Value?.ToString();
            if (string.IsNullOrEmpty(closeReport)) return;

            string bomNo = row.Cells[colBomNo.Index].Value?.ToString();
            if (string.IsNullOrEmpty(bomNo)) return;

            string finishDate = DateTime.Now.ToString("yyyy/MM/dd");
            row.Cells[colFinishDate.Index].Value = finishDate;

            var updateRep = new ProjectProgressController().UpdateFinishDateByBomNo(new MES.WebAPI.Models.UpdateFinishDateReq
            {
                bomNo = bomNo,
                finishDate = finishDate,
                operatorName = AppSession.User.name,
            });
            if (!string.IsNullOrEmpty(updateRep.ErrorMessage))
            {
                MessageBox.Show(updateRep.ErrorMessage);
            }

            if (closeReport != "設計變更") return;

            string sourceDoc = row.Cells[colDrawingFile.Index].Value?.ToString();
            string projectNo = row.Cells[colProjectNo.Index].Value?.ToString();
            string moduleCode = row.Cells[colModuleCode.Index].Value?.ToString();
            string moduleName = row.Cells[colModuleName.Index].Value?.ToString();
            if (string.IsNullOrEmpty(sourceDoc)) return;
            sourceDoc = sourceDoc.Replace("售後維修", "").Replace("廠驗追加", "");
            if (string.IsNullOrEmpty(sourceDoc)) return;

            OpenAbnormalCorrectionReport(sourceDoc, projectNo, moduleCode, moduleName);
        }

        private void OpenAbnormalCorrectionReport(string sourceDoc, string projectNo, string moduleCode, string moduleName)
        {
            if (!(Parent is TabPage) || !(((TabPage)Parent).Parent is TabControl)) return;
            TabControl tabControl = (TabControl)((TabPage)Parent).Parent;
            string tabName = "AbnormalCorrectionReport_" + sourceDoc;
            foreach (TabPage page in tabControl.TabPages)
            {
                if (page.Name == tabName)
                {
                    tabControl.SelectedTab = page;
                    return;
                }
            }
            var ctrl = new AbnormalCorrectionReportControl();
            if (ctrl.IsDisposed) return;
            ctrl.LoadBySourceDoc(sourceDoc, projectNo, moduleCode, moduleName);
            ctrl.Dock = DockStyle.Fill;
            var tab = new TabPage(sourceDoc + " 異常矯正措施報告") { Name = tabName };
            tab.Controls.Add(ctrl);
            tabControl.TabPages.Add(tab);
            tabControl.SelectedTab = tab;
            tabControl.SizeMode = TabSizeMode.Normal;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var list = new List<專案模組用料清單>();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                var orig = row.Tag as 專案模組用料清單;
                if (orig == null) continue;

                orig.圖檔發行日 = row.Cells[colIssueDate.Index].Value?.ToString();
                orig.組裝人員 = row.Cells[colAssemblyStaff.Index].Value?.ToString();
                orig.開工日期 = row.Cells[colStartDate.Index].Value?.ToString();
                orig.預交日期 = row.Cells[colDueDate.Index].Value?.ToString();
                orig.完工日期 = row.Cells[colFinishDate.Index].Value?.ToString();
                orig.結案回報 = row.Cells[colCloseReport.Index].Value?.ToString();
                orig.用途 = row.Cells[colPurpose.Index].Value?.ToString();
                list.Add(orig);
            }

            var rep = new ProjectProgressController().SaveModuleMaterialHeaderBatch(new MES.WebAPI.Models.SaveModuleMaterialHeaderBatchReq
            {
                list = list,
                operatorName = AppSession.User.name,
            });
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }

            MessageBox.Show("已儲存");
            SetEditMode(false);
            LoadData(_currentProjectNo);
        }

        private void btnPrint_Click(object sender, EventArgs e) => MessageBox.Show("此功能尚未開放");

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
