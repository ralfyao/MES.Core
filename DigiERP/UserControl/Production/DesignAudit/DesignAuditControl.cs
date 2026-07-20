using DigiERP.Common;
using MES.Core.Model;
using MES.WebAPI.Controllers;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DigiERP.UserControl.Production
{
    public partial class DesignAuditControl : CommonUserControl
    {
        private static string id = "AD12E9F6-7A3A-40B7-B22A-A4902F1AE5A9";

        public DesignAuditControl()
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

        internal void LoadData()
        {
            var rep = new ProjectProgressController().GetDesignAuditList();
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }
            FillGrid(rep.resultList ?? new List<設計審圖總覽>());
        }

        private void FillGrid(List<設計審圖總覽> list)
        {
            dataGridView1.Rows.Clear();
            foreach (var x in list)
            {
                var row = new DataGridViewRow();
                row.CreateCells(dataGridView1);
                int i = 0;
                row.Cells[i++].Value = x.清單編號;
                row.Cells[i++].Value = x.專案序號;
                row.Cells[i++].Value = x.模組編碼;
                row.Cells[i++].Value = x.模組名稱;
                row.Cells[i++].Value = x.設計人員;
                row.Cells[i++].Value = x.製圖檔名;
                row.Cells[i++].Value = x.圖檔發行日;
                row.Cells[i++].Value = x.審圖通過 ?? false;
                row.Cells[i++].Value = x.發行人員;
                row.Cells[i++].Value = x.設變;
                row.Cells[i++].Value = x.已發行 ?? false;
                dataGridView1.Rows.Add(row);
            }
        }

        // ── 雙擊清單列：開啟該筆審查清單的維護畫面 ─────────────────────────
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            string listNo = dataGridView1.Rows[e.RowIndex].Cells[colListNo.Index].Value?.ToString();
            if (string.IsNullOrEmpty(listNo)) return;
            OpenMaintain(listNo);
        }

        // ── 新增：開啟空白的審查清單維護畫面，供選擇審查項目後建立新單 ──────
        private void btnAdd_Click(object sender, EventArgs e)
        {
            OpenMaintain(null);
        }

        private void OpenMaintain(string listNo)
        {
            if (!(Parent is TabPage) || !(((TabPage)Parent).Parent is TabControl)) return;
            TabControl tabControl = (TabControl)((TabPage)Parent).Parent;
            string tabName = string.IsNullOrEmpty(listNo) ? "DesignAuditMaintain_New" : "DesignAuditMaintain_" + listNo;
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
            if (string.IsNullOrEmpty(listNo)) ctrl.LoadNew();
            else ctrl.LoadData(listNo);
            ctrl.Dock = DockStyle.Fill;
            var tab = new TabPage(string.IsNullOrEmpty(listNo) ? "新增審查清單" : listNo + " 設計審查清單") { Name = tabName };
            tab.Controls.Add(ctrl);
            tabControl.TabPages.Add(tab);
            tabControl.SelectedTab = tab;
            tabControl.SizeMode = TabSizeMode.Fixed;
            tabControl.ItemSize = new System.Drawing.Size(120, 30);
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
