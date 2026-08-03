using DigiERP.Common;
using MES.Core.Model;
using MES.WebAPI.Controllers;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DigiERP.UserControl.Production
{
    // ── 電控排程：列表維護畫面，資料來源為 專案電控排程 ─────────────────
    public partial class ProgramControlListControl : CommonUserControl
    {
        private static string id = "3D9A5C6E-2B8F-4A1D-9E7C-5F6A8B9C0D1E";

        public ProgramControlListControl()
        {
            if (!chkPrivilege(id))
            {
                MessageBox.Show("非授權使用者無法使用此功能!");
                Dispose();
                return;
            }
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            var rep = new ProjectProgressController().GetProgramControlScheduleList();
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }

            dataGridView1.Rows.Clear();
            foreach (var x in rep.resultList ?? new List<專案電控排程>())
            {
                int i = dataGridView1.Rows.Add();
                var row = dataGridView1.Rows[i];
                row.Cells[colProjectNo.Index].Value = x.專案序號;
                row.Cells[colProcess.Index].Value = x.電控工序;
                row.Cells[colDesc.Index].Value = x.簡要描述;
                row.Cells[colStaff.Index].Value = x.程控人員;
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
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
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
