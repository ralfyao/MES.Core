using DigiERP.Common;
using MES.Core.Model;
using MES.WebAPI.Controllers;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DigiERP.UserControl.Production
{
    public partial class PostProcessSchedulingControl : CommonUserControl
    {
        private static string id = "3F7B2E14-8A6D-4C90-B1E5-7D4A9C2F6B38";
        private const double 每週可承載量 = 60;

        public PostProcessSchedulingControl()
        {
            if (!chkPrivilege(id))
            {
                MessageBox.Show("非授權使用者無法使用此功能!");
                Dispose();
                return;
            }
            InitializeComponent();
            dataGridView1.Resize += (s, e) => PositionGroupHeaders();
            PositionGroupHeaders();
        }

        // ── 讓特殊塑型/精密加工/防變形/表面處理群組標題對齊 dataGridView1 對應2欄位 ──
        private void PositionGroupHeaders()
        {
            (Label label, int startColIndex)[] groups = new (Label, int)[]
            {
                (lblGrpSpecial, colSpecialSchedule.Index),
                (lblGrpPrecision, colPrecisionSchedule.Index),
                (lblGrpAntiDeform, colAntiDeformSchedule.Index),
                (lblGrpSurface, colSurfaceSchedule.Index),
            };

            foreach (var g in groups)
            {
                int x = 0;
                for (int i = 0; i < g.startColIndex; i++) x += dataGridView1.Columns[i].Width;
                int w = dataGridView1.Columns[g.startColIndex].Width + dataGridView1.Columns[g.startColIndex + 1].Width;
                g.label.Left = x;
                g.label.Width = w;
                g.label.Top = 0;
            }
        }

        internal void LoadData()
        {
            var rep = new ProjectProgressController().GetPostProcessScheduleList();
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }
            var list = rep.resultList ?? new List<後製程週排程表>();
            FillGrid(list);
            FillSummary(list);
            PositionGroupHeaders();
        }

        private void FillGrid(List<後製程週排程表> list)
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
                row.Cells[i++].Value = x.領料日;
                row.Cells[i++].Value = x.預交日期2;
                row.Cells[i++].Value = x.開工日期2;
                row.Cells[i++].Value = x.預交日期3;
                row.Cells[i++].Value = x.開工日期3;
                row.Cells[i++].Value = x.預交日期4;
                row.Cells[i++].Value = x.開工日期4;
                row.Cells[i++].Value = x.預交日期5;
                row.Cells[i++].Value = x.開工日期5;
                dataGridView1.Rows.Add(row);
            }
        }

        // ── 每欄筆數＝有值之筆數(日期非工時，故以筆數計)；每週可承載量固定60；負荷率＝筆數/60 ──
        private void FillSummary(List<後製程週排程表> list)
        {
            int sSpecialSchedule = 0, sSpecialOutwork = 0;
            int sPrecisionSchedule = 0, sPrecisionOutwork = 0;
            int sAntiDeformSchedule = 0, sAntiDeformOutwork = 0;
            int sSurfaceSchedule = 0, sSurfaceOutwork = 0;

            foreach (var x in list)
            {
                if (!string.IsNullOrEmpty(x.預交日期2)) sSpecialSchedule++;
                if (!string.IsNullOrEmpty(x.開工日期2)) sSpecialOutwork++;
                if (!string.IsNullOrEmpty(x.預交日期3)) sPrecisionSchedule++;
                if (!string.IsNullOrEmpty(x.開工日期3)) sPrecisionOutwork++;
                if (!string.IsNullOrEmpty(x.預交日期4)) sAntiDeformSchedule++;
                if (!string.IsNullOrEmpty(x.開工日期4)) sAntiDeformOutwork++;
                if (!string.IsNullOrEmpty(x.預交日期5)) sSurfaceSchedule++;
                if (!string.IsNullOrEmpty(x.開工日期5)) sSurfaceOutwork++;
            }

            dataGridView2.Rows.Clear();

            var rowCount = new DataGridViewRow();
            rowCount.CreateCells(dataGridView2);
            rowCount.Cells[0].Value = "每週加工筆數";
            rowCount.Cells[1].Value = sSpecialSchedule;
            rowCount.Cells[2].Value = sSpecialOutwork;
            rowCount.Cells[3].Value = sPrecisionSchedule;
            rowCount.Cells[4].Value = sPrecisionOutwork;
            rowCount.Cells[5].Value = sAntiDeformSchedule;
            rowCount.Cells[6].Value = sAntiDeformOutwork;
            rowCount.Cells[7].Value = sSurfaceSchedule;
            rowCount.Cells[8].Value = sSurfaceOutwork;
            dataGridView2.Rows.Add(rowCount);

            var rowCapacity = new DataGridViewRow();
            rowCapacity.CreateCells(dataGridView2);
            rowCapacity.Cells[0].Value = "每週可承載量";
            for (int c = 1; c <= 8; c++) rowCapacity.Cells[c].Value = 每週可承載量;
            dataGridView2.Rows.Add(rowCapacity);

            var rowLoad = new DataGridViewRow();
            rowLoad.CreateCells(dataGridView2);
            rowLoad.Cells[0].Value = "負荷率";
            rowLoad.Cells[1].Value = (sSpecialSchedule / 每週可承載量).ToString("P0");
            rowLoad.Cells[2].Value = (sSpecialOutwork / 每週可承載量).ToString("P0");
            rowLoad.Cells[3].Value = (sPrecisionSchedule / 每週可承載量).ToString("P0");
            rowLoad.Cells[4].Value = (sPrecisionOutwork / 每週可承載量).ToString("P0");
            rowLoad.Cells[5].Value = (sAntiDeformSchedule / 每週可承載量).ToString("P0");
            rowLoad.Cells[6].Value = (sAntiDeformOutwork / 每週可承載量).ToString("P0");
            rowLoad.Cells[7].Value = (sSurfaceSchedule / 每週可承載量).ToString("P0");
            rowLoad.Cells[8].Value = (sSurfaceOutwork / 每週可承載量).ToString("P0");
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
