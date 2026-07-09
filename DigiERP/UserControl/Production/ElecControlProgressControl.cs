using DigiERP.Common;
using MES.Core.Model;
using MES.WebAPI.Controllers;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DigiERP.UserControl.Production
{
    public partial class ElecControlProgressControl : CommonUserControl
    {
        private static string id = "4A8C1F26-7B3D-4E95-9A2C-6D5F8B1E3C74";

        public ElecControlProgressControl()
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
            var rep = new ProjectProgressController().GetElecControlProgressList(projectNo);
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }
            FillGrid(rep.resultList ?? new List<電控排程進度表>());
        }

        private void FillGrid(List<電控排程進度表> list)
        {
            dataGridView1.Rows.Clear();
            foreach (var x in list)
            {
                var row = new DataGridViewRow();
                row.CreateCells(dataGridView1);
                int i = 0;
                row.Cells[i++].Value = x.專案序號;
                row.Cells[i++].Value = x.電控工序;
                row.Cells[i++].Value = x.開始作業日期;
                row.Cells[i++].Value = x.預計完成日期;
                row.Cells[i++].Value = x.實際完成日期;
                row.Cells[i++].Value = x.標準期程天數;
                row.Cells[i++].Value = x.完工期程天數;
                row.Cells[i++].Value = x.逾期天數;
                row.Cells[i++].Value = x.達交效率值;
                row.Cells[i++].Value = x.警示訊號;
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
