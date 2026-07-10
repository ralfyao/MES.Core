using DigiERP.Common;
using MES.Core.Model;
using MES.WebAPI.Controllers;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DigiERP.UserControl.Production
{
    public partial class MachiningSchedulingControl : CommonUserControl
    {
        private static string id = "1E5A8C29-6D3F-4B71-9C4A-2E7D5B8F1A63";
        private const double 每週可承載量 = 40;

        public MachiningSchedulingControl()
        {
            if (!chkPrivilege(id))
            {
                MessageBox.Show("非授權使用者無法使用此功能!");
                Dispose();
                return;
            }
            InitializeComponent();
            dataGridView1.Resize += (s, e) => PositionDateHeaders();
            PositionDateHeaders();
        }

        // ── 讓基準日以前/第一~四週日期方塊對齊 dataGridView1 對應欄位 ──────
        private void PositionDateHeaders()
        {
            Label[] labels = { lblChipStart, lblChipWeek1, lblChipWeek2, lblChipWeek3, lblChipWeek4 };
            int startColIndex = colOverdue.Index;
            int x = 0;
            for (int i = 0; i < startColIndex; i++) x += dataGridView1.Columns[i].Width;
            for (int i = 0; i < labels.Length; i++)
            {
                int w = dataGridView1.Columns[startColIndex + i].Width;
                labels[i].Left = x;
                labels[i].Width = w;
                labels[i].Top = 15;
                x += w;
            }
        }

        internal void LoadData(DateTime 基準日以前, DateTime 第一週, DateTime 第二週, DateTime 第三週, DateTime 第四週)
        {
            lblChipStart.Text = 基準日以前.ToString("yyyy/M/d");
            lblChipWeek1.Text = 第一週.ToString("yyyy/M/d");
            lblChipWeek2.Text = 第二週.ToString("yyyy/M/d");
            lblChipWeek3.Text = 第三週.ToString("yyyy/M/d");
            lblChipWeek4.Text = 第四週.ToString("yyyy/M/d");

            var rep = new ProjectProgressController().GetMachiningScheduleList(基準日以前, 第一週, 第二週, 第三週, 第四週);
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }
            var list = rep.resultList ?? new List<加工週排程表>();
            FillGrid(list);
            FillSummary(list);
            PositionDateHeaders();
        }

        private void FillGrid(List<加工週排程表> list)
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
                row.Cells[i++].Value = x.零件號碼;
                row.Cells[i++].Value = x.品名;
                row.Cells[i++].Value = x.驗收日期;
                row.Cells[i++].Value = x.預計到貨日;
                row.Cells[i++].Value = x.過期;
                row.Cells[i++].Value = x.第一週;
                row.Cells[i++].Value = x.第二週;
                row.Cells[i++].Value = x.第三週;
                row.Cells[i++].Value = x.第四週;
                row.Cells[i++].Value = x.未排;
                dataGridView1.Rows.Add(row);
            }
        }

        // ── 每週加工筆數(S0-S4,S未排)＝各欄位有預交日期1之筆數(此處為日期而非工時，故以筆數計)；
        // 每週可承載量固定40；負荷率＝S/40 ───────────────────────────
        private void FillSummary(List<加工週排程表> list)
        {
            int s0 = 0, s1 = 0, s2 = 0, s3 = 0, s4 = 0, sUnscheduled = 0;
            foreach (var x in list)
            {
                if (!string.IsNullOrEmpty(x.過期)) s0++;
                if (!string.IsNullOrEmpty(x.第一週)) s1++;
                if (!string.IsNullOrEmpty(x.第二週)) s2++;
                if (!string.IsNullOrEmpty(x.第三週)) s3++;
                if (!string.IsNullOrEmpty(x.第四週)) s4++;
                if (!string.IsNullOrEmpty(x.未排)) sUnscheduled++;
            }

            dataGridView2.Rows.Clear();

            var rowCount = new DataGridViewRow();
            rowCount.CreateCells(dataGridView2);
            rowCount.Cells[0].Value = "每週加工筆數";
            rowCount.Cells[1].Value = s0;
            rowCount.Cells[2].Value = s1;
            rowCount.Cells[3].Value = s2;
            rowCount.Cells[4].Value = s3;
            rowCount.Cells[5].Value = s4;
            rowCount.Cells[6].Value = sUnscheduled;
            dataGridView2.Rows.Add(rowCount);

            var rowCapacity = new DataGridViewRow();
            rowCapacity.CreateCells(dataGridView2);
            rowCapacity.Cells[0].Value = "每週可承載量";
            rowCapacity.Cells[1].Value = 每週可承載量;
            rowCapacity.Cells[2].Value = 每週可承載量;
            rowCapacity.Cells[3].Value = 每週可承載量;
            rowCapacity.Cells[4].Value = 每週可承載量;
            rowCapacity.Cells[5].Value = 每週可承載量;
            rowCapacity.Cells[6].Value = 每週可承載量;
            dataGridView2.Rows.Add(rowCapacity);

            var rowLoad = new DataGridViewRow();
            rowLoad.CreateCells(dataGridView2);
            rowLoad.Cells[0].Value = "負荷率";
            rowLoad.Cells[1].Value = (s0 / 每週可承載量).ToString("P0");
            rowLoad.Cells[2].Value = (s1 / 每週可承載量).ToString("P0");
            rowLoad.Cells[3].Value = (s2 / 每週可承載量).ToString("P0");
            rowLoad.Cells[4].Value = (s3 / 每週可承載量).ToString("P0");
            rowLoad.Cells[5].Value = (s4 / 每週可承載量).ToString("P0");
            rowLoad.Cells[6].Value = (sUnscheduled / 每週可承載量).ToString("P0");
            dataGridView2.Rows.Add(rowLoad);
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
