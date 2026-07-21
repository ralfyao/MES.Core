using DigiERP.Common;
using DigiERP.Forms.Production;
using MES.Core.Model;
using MES.WebAPI.Controllers;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace DigiERP.UserControl.Production
{
    public partial class DesignDispatchControl : CommonUserControl
    {
        private static string id = "9D2E5A47-1C8B-4F3D-A6E9-7B4C1D8F2A56";

        private static readonly string[] EditableColumns =
        {
            "colDrawingHours", "colDesigner", "colDrawingType",
            "colDrawingFile", "colPlannedFinish", "colActualStart", "colDrawingIssueDate",
        };

        private bool _editing;
        private List<模組圖檢查> _checkCategoryList = new List<模組圖檢查>();

        public DesignDispatchControl()
        {
            if (!chkPrivilege(id))
            {
                MessageBox.Show("非授權使用者無法使用此功能!");
                Dispose();
                return;
            }
            InitializeComponent();

            var staffRep = new ProjectProgressController().GetDesignStaffList();
            colDesigner.DataSource = staffRep.resultList ?? new List<成本單位人員配置>();
            colDesigner.DisplayMember = "姓名";
            colDesigner.ValueMember = "員工編號";

            var checkCategoryRep = new ProjectProgressController().GetModuleDrawingCheckList();
            _checkCategoryList = checkCategoryRep.resultList ?? new List<模組圖檢查>();

            SetEditMode(false);
            LoadData();
        }

        internal void LoadData()
        {
            var rep = new ProjectProgressController().GetAllDesignAssignmentList();
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }
            FillGrid(rep.resultList ?? new List<設計派案>());
        }

        private void FillGrid(List<設計派案> list)
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
                row.Cells[i++].Value = x.檢查分類;
                row.Cells[i++].Value = x.製圖;
                row.Cells[i++].Value = x.設計人員;
                row.Cells[i++].Value = x.設計圖類;
                row.Cells[i++].Value = x.製圖檔名;
                row.Cells[i++].Value = x.預計完工日;
                row.Cells[i++].Value = x.實際開工日;
                row.Cells[i++].Value = x.圖檔發行日;
                row.Cells[i++].Value = x.審圖通過 ?? false;
                row.Cells[i++].Value = x.清單編號;
                row.Cells[i++].Value = x.客戶簡稱;
                row.Tag = x;
                dataGridView1.Rows.Add(row);
            }
        }

        // ── 設計人員為下拉欄位，若儲存值不在職務=設計的名單中(如離職/舊資料)，
        //    ComboBox 找不到對應項目時 WinForms 預設會跳例外對話方塊，這裡直接吃掉 ──
        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
        }

        // ── 點選「檢查分類」欄位：跳出選擇視窗，列出模組圖檢查全部資料供挑選 ──
        // ── 點選「設計人員」欄位：開啟工作內容撰寫，依本列設計派案資料預帶欄位 ──
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!_editing || e.RowIndex < 0) return;

            if (e.ColumnIndex == colCheckCategory.Index)
            {
                var checkCategoryRep = new ProjectProgressController().GetModuleDrawingCheckList();
                _checkCategoryList = checkCategoryRep.resultList ?? new List<模組圖檢查>();
                using var frm = new FrmSelectDrawingCheckCategory(_checkCategoryList);
                if (frm.ShowDialog(FindForm()) != DialogResult.OK) return;

                dataGridView1.Rows[e.RowIndex].Cells[colCheckCategory.Index].Value = frm.SelectedItem.檢查分類;
            }
            else if (e.ColumnIndex == colDesigner.Index)
            {
                var row = dataGridView1.Rows[e.RowIndex].Tag as 設計派案;
                using var frm = new FrmWorkLogEntry(row);
                frm.ShowDialog(FindForm());
            }
        }

        // ── 雙擊「設計審查清單」欄位：開啟(或切回)該清單編號的審查維護頁籤 ──
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex != colListNo.Index) return;
            string listNo = dataGridView1.Rows[e.RowIndex].Cells[colListNo.Index].Value?.ToString();
            if (string.IsNullOrEmpty(listNo)) return;
            OpenDesignAuditMaintain(listNo);
        }

        private void OpenDesignAuditMaintain(string listNo)
        {
            if (!(Parent is TabPage) || !(((TabPage)Parent).Parent is TabControl)) return;
            TabControl tabControl = (TabControl)((TabPage)Parent).Parent;
            string tabName = "DesignAuditMaintain_" + listNo;
            foreach (TabPage page in tabControl.TabPages)
            {
                if (page.Name == tabName)
                {
                    tabControl.SelectedTab = page;
                    return;
                }
            }
            var ctrl = new DesignAuditMaintainControl();
            if (ctrl.IsDisposed) return;
            ctrl.LoadData(listNo);
            ctrl.Dock = DockStyle.Fill;
            var tab = new TabPage(listNo + " 設計審查清單") { Name = tabName };
            tab.Controls.Add(ctrl);
            tabControl.TabPages.Add(tab);
            tabControl.SelectedTab = tab;
            tabControl.SizeMode = TabSizeMode.Fixed;
            tabControl.ItemSize = new Size(120, 30);
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

        private void btnEdit_Click(object sender, EventArgs e) => SetEditMode(true);

        private void btnSave_Click(object sender, EventArgs e)
        {
            var list = new List<設計派案>();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                var orig = row.Tag as 設計派案;
                if (orig == null) continue;

                orig.檢查分類 = row.Cells[colCheckCategory.Index].Value?.ToString();
                orig.製圖 = row.Cells[colDrawingHours.Index].Value?.ToString();
                orig.設計人員 = row.Cells[colDesigner.Index].Value?.ToString();
                orig.設計圖類 = row.Cells[colDrawingType.Index].Value?.ToString();
                orig.製圖檔名 = row.Cells[colDrawingFile.Index].Value?.ToString();
                orig.預計完工日 = row.Cells[colPlannedFinish.Index].Value?.ToString();
                orig.實際開工日 = row.Cells[colActualStart.Index].Value?.ToString();
                orig.圖檔發行日 = row.Cells[colDrawingIssueDate.Index].Value?.ToString();
                list.Add(orig);
            }

            var rep = new ProjectProgressController().SaveDesignAssignmentBatch(list);
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }

            MessageBox.Show("已儲存");
            SetEditMode(false);
            LoadData();
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
