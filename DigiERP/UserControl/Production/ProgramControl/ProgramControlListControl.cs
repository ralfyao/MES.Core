using DigiERP.Common;
using DigiERP.Forms.Production;
using MES.Core.Model;
using MES.WebAPI.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DigiERP.UserControl.Production.ProgramControl
{
    // ── 電控排程：列表維護畫面，資料來源為 專案電控排程 ─────────────────
    public partial class ProgramControlListControl : CommonUserControl
    {
        private static string id = "3D9A5C6E-2B8F-4A1D-9E7C-5F6A8B9C0D1E";

        private List<設計模組表> _elecControlProcessList = new List<設計模組表>();
        private List<成本單位人員配置> _programControlStaffList = new List<成本單位人員配置>();

        public ProgramControlListControl()
        {
            if (!chkPrivilege(id))
            {
                MessageBox.Show("非授權使用者無法使用此功能!");
                Dispose();
                return;
            }
            InitializeComponent();
            initElecControlProcessCombo();
            initProgramControlStaffCombo();
            LoadData();
        }

        // ── 電控工序下拉：設計模組表中檢查分類='電控'的模組名稱 ───────────
        private void initElecControlProcessCombo()
        {
            var rep = new ProjectProgressController().GetElecControlProcessList();
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }
            _elecControlProcessList = rep.resultList ?? new List<設計模組表>();
        }

        // ── 程控人員下拉：職務為程控的成本單位人員配置(對應到 H員工清冊 取姓名) ────
        private void initProgramControlStaffCombo()
        {
            var rep = new ProjectProgressController().GetProgramControlStaffList();
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }
            _programControlStaffList = rep.resultList ?? new List<成本單位人員配置>();
        }

        // ── 程控人員下拉改為跳出選取視窗(FrmSelectStaff)，不使用原生下拉清單 ──────
        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dataGridView1.CurrentCell?.ColumnIndex != colStaff.Index || e.Control is not ComboBox combo) return;
            combo.DropDown -= StaffCombo_DropDown;
            combo.DropDown += StaffCombo_DropDown;
        }

        private void StaffCombo_DropDown(object sender, EventArgs e)
        {
            var combo = (ComboBox)sender;
            BeginInvoke(new Action(() =>
            {
                combo.DroppedDown = false;
                using var frm = new FrmSelectStaff(_programControlStaffList);
                if (frm.ShowDialog(FindForm()) == DialogResult.OK && frm.SelectedItem != null)
                {
                    combo.Text = frm.SelectedItem.姓名;
                }
            }));
        }

        private void LoadData()
        {
            var rep = new ProjectProgressController().GetProgramControlScheduleList();
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }

            colProcess.Items.Clear();
            colProcess.Items.Add("");
            foreach (var name in _elecControlProcessList.Select(m => m.模組名稱).Where(n => !string.IsNullOrEmpty(n)).Distinct())
            {
                colProcess.Items.Add(name);
            }

            colStaff.Items.Clear();
            colStaff.Items.Add("");
            foreach (var name in _programControlStaffList.Select(s => s.姓名).Where(n => !string.IsNullOrEmpty(n)).Distinct())
            {
                colStaff.Items.Add(name);
            }

            dataGridView1.Rows.Clear();
            foreach (var x in rep.resultList ?? new List<專案電控排程>())
            {
                string process = (x.電控工序 ?? "").Trim();
                if (!string.IsNullOrEmpty(process) && !colProcess.Items.Contains(process)) colProcess.Items.Add(process);

                string staff = (x.程控人員 ?? "").Trim();
                if (!string.IsNullOrEmpty(staff) && !colStaff.Items.Contains(staff)) colStaff.Items.Add(staff);

                int i = dataGridView1.Rows.Add();
                var row = dataGridView1.Rows[i];
                row.Cells[colProjectNo.Index].Value = x.專案序號;
                row.Cells[colProcess.Index].Value = process;
                row.Cells[colDesc.Index].Value = x.簡要描述;
                row.Cells[colStaff.Index].Value = staff;
                row.Cells[colStartDate.Index].Value = x.開始作業日期;
                row.Cells[colPlanFinishDate.Index].Value = x.預計完成日期;
                row.Cells[colActualFinishDate.Index].Value = x.實際完成日期;
                row.Tag = x.識別碼;
            }

            disableControls(false);
        }

        // ── 鎖定/解鎖：開啟畫面預設鎖定，需按「修改」才能編輯 ──────────────
        private void disableControls(bool enable)
        {
            dataGridView1.ReadOnly = !enable;
            colProjectNo.ReadOnly = !enable;
            colProcess.ReadOnly = !enable;
            colDesc.ReadOnly = !enable;
            colStaff.ReadOnly = !enable;
            colStartDate.ReadOnly = !enable;
            colPlanFinishDate.ReadOnly = !enable;
            colActualFinishDate.ReadOnly = !enable;
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
        }

        // ── 鎖定(檢視)狀態下點選專案序號，開啟(或切換至)專案機台程控紀錄表頁籤 ────
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!dataGridView1.ReadOnly) return;
            if (e.RowIndex < 0 || dataGridView1.Columns[e.ColumnIndex] != colProjectNo) return;
            string projectNo = dataGridView1.Rows[e.RowIndex].Cells[colProjectNo.Index].Value?.ToString();
            if (string.IsNullOrEmpty(projectNo)) return;

            if (!(Parent is TabPage) || !(((TabPage)Parent).Parent is TabControl)) return;
            TabControl tabControl = (TabControl)((TabPage)Parent).Parent;
            string tabName = "ProjectMachineProgramControlRecord_" + projectNo;
            foreach (TabPage page in tabControl.TabPages)
            {
                if (page.Name == tabName)
                {
                    tabControl.SelectedTab = page;
                    return;
                }
            }
            var ctrl = new ProjectMachineProgramControlRecordControl { Dock = DockStyle.Fill };
            var tab = new TabPage("專案機台程控紀錄表-" + projectNo) { Name = tabName };
            tab.Controls.Add(ctrl);
            tabControl.TabPages.Add(tab);
            tabControl.SelectedTab = tab;
            ctrl.LoadData(projectNo);
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            disableControls(true);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var list = new List<專案電控排程>();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.IsNewRow) continue;
                int id = row.Tag is int tagId ? tagId : 0;
                list.Add(new 專案電控排程
                {
                    識別碼 = id,
                    專案序號 = row.Cells[colProjectNo.Index].Value as string,
                    電控工序 = row.Cells[colProcess.Index].Value as string,
                    簡要描述 = row.Cells[colDesc.Index].Value as string,
                    程控人員 = row.Cells[colStaff.Index].Value as string,
                    開始作業日期 = row.Cells[colStartDate.Index].Value as string,
                    預計完成日期 = row.Cells[colPlanFinishDate.Index].Value as string,
                    實際完成日期 = row.Cells[colActualFinishDate.Index].Value as string,
                });
            }

            var rep = new ProjectProgressController().SaveProgramControlScheduleList(list);
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }

            MessageBox.Show("儲存成功!");
            LoadData();
        }

        private void btnPrint_Click(object sender, EventArgs e) => MessageBox.Show("此功能尚未開放");

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
