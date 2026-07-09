using DigiERP.Common;
using MES.Core.Model;
using MES.WebAPI.Controllers;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DigiERP.UserControl.Production
{
    public partial class ModuleProcurementProgressControl : CommonUserControl
    {
        private static string id = "3D7E9B41-6A2C-4F58-9D1E-7C4A8B2F6E15";

        public ModuleProcurementProgressControl()
        {
            if (!chkPrivilege(id))
            {
                MessageBox.Show("非授權使用者無法使用此功能!");
                Dispose();
                return;
            }
            InitializeComponent();
        }

        internal void LoadData(string projectNo)
        {
            var rep = new ProjectProgressController().GetModuleProcurementProgressList(projectNo);
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }
            FillGrid(rep.resultList ?? new List<模組零件採購進度表>());
        }

        private void FillGrid(List<模組零件採購進度表> list)
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
                row.Cells[i++].Value = x.數量之筆數;
                row.Cells[i++].Value = x.開始詢價日之筆數;
                row.Cells[i++].Value = x.實際採購日之筆數;
                row.Cells[i++].Value = x.入庫移轉日之筆數;
                row.Cells[i++].Value = x.入庫比例;
                row.Cells[i++].Value = x.缺料比例;
                row.Cells[i++].Value = x.採購信號;
                dataGridView1.Rows.Add(row);
            }
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
