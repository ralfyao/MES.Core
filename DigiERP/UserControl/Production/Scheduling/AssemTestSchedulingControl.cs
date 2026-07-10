using DigiERP.Common;
using MES.Core.Model;
using MES.WebAPI.Controllers;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DigiERP.UserControl.Production
{
    public partial class AssemTestSchedulingControl : CommonUserControl
    {
        private static string id = "5C8E1A47-3B9D-4F62-A7E8-1D5C4B9A6F23";
        private const double 每週可承載量 = 60;

        public AssemTestSchedulingControl()
        {
            if (!chkPrivilege(id))
            {
                MessageBox.Show("非授權使用者無法使用此功能!");
                Dispose();
                return;
            }
            InitializeComponent();
            dataGridView1.Resize += (s, e) => PositionWeekHeaders();
            PositionWeekHeaders();
        }

        // ── 讓第一~四週標籤對齊 dataGridView1 對應之進料排程/加工排程2欄位 ──
        private void PositionWeekHeaders()
        {
            (Label label, int startColIndex)[] weeks = new (Label, int)[]
            {
                (lblWeek1, colWeek1P.Index),
                (lblWeek2, colWeek2P.Index),
                (lblWeek3, colWeek3P.Index),
                (lblWeek4, colWeek4P.Index),
            };

            foreach (var w in weeks)
            {
                int x = 0;
                for (int i = 0; i < w.startColIndex; i++) x += dataGridView1.Columns[i].Width;
                int width = dataGridView1.Columns[w.startColIndex].Width + dataGridView1.Columns[w.startColIndex + 1].Width;
                w.label.Left = x;
                w.label.Width = width;
            }
        }

        internal void LoadData(DateTime 基準日以前, DateTime 第一週, DateTime 第二週, DateTime 第三週, DateTime 第四週)
        {
            lblWeek1.Text = "第一週：" + 第一週.ToString("yyyy/M/d");
            lblWeek2.Text = "第二週：" + 第二週.ToString("yyyy/M/d");
            lblWeek3.Text = "第三週：" + 第三週.ToString("yyyy/M/d");
            lblWeek4.Text = "第四週：" + 第四週.ToString("yyyy/M/d");

            var rep = new ProjectProgressController().GetAssemTestScheduleList(基準日以前, 第一週, 第二週, 第三週, 第四週);
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }
            var list = rep.resultList ?? new List<組測週排程表>();
            FillGrid(list);
            FillSummary(list);
            PositionWeekHeaders();
        }

        private void FillGrid(List<組測週排程表> list)
        {
            dataGridView1.Rows.Clear();
            foreach (var x in list)
            {
                var row = new DataGridViewRow();
                row.CreateCells(dataGridView1);
                int i = 0;
                row.Cells[i++].Value = x.專案序號;
                row.Cells[i++].Value = x.模組編碼;
                row.Cells[i++].Value = x.零件號碼;
                row.Cells[i++].Value = x.品名;
                row.Cells[i++].Value = x.零件分類;
                row.Cells[i++].Value = x.驗收合格;
                row.Cells[i++].Value = x.零件管制單號;
                row.Cells[i++].Value = x.P1;
                row.Cells[i++].Value = x.W1;
                row.Cells[i++].Value = x.P2;
                row.Cells[i++].Value = x.W2;
                row.Cells[i++].Value = x.P3;
                row.Cells[i++].Value = x.W3;
                row.Cells[i++].Value = x.P4;
                row.Cells[i++].Value = x.W4;
                dataGridView1.Rows.Add(row);
            }
        }

        // ── 每週加工筆數＝該週進料排程或加工排程任一有值之筆數；每週可承載量固定60；負荷率＝筆數/60 ──
        private void FillSummary(List<組測週排程表> list)
        {
            int s1 = 0, s2 = 0, s3 = 0, s4 = 0;
            foreach (var x in list)
            {
                if (!string.IsNullOrEmpty(x.P1) || !string.IsNullOrEmpty(x.W1)) s1++;
                if (!string.IsNullOrEmpty(x.P2) || !string.IsNullOrEmpty(x.W2)) s2++;
                if (!string.IsNullOrEmpty(x.P3) || !string.IsNullOrEmpty(x.W3)) s3++;
                if (!string.IsNullOrEmpty(x.P4) || !string.IsNullOrEmpty(x.W4)) s4++;
            }

            dataGridView2.Rows.Clear();

            var rowCount = new DataGridViewRow();
            rowCount.CreateCells(dataGridView2);
            rowCount.Cells[0].Value = "每週加工筆數";
            rowCount.Cells[1].Value = s1;
            rowCount.Cells[2].Value = s2;
            rowCount.Cells[3].Value = s3;
            rowCount.Cells[4].Value = s4;
            dataGridView2.Rows.Add(rowCount);

            var rowCapacity = new DataGridViewRow();
            rowCapacity.CreateCells(dataGridView2);
            rowCapacity.Cells[0].Value = "每週可承載量";
            rowCapacity.Cells[1].Value = 每週可承載量;
            rowCapacity.Cells[2].Value = 每週可承載量;
            rowCapacity.Cells[3].Value = 每週可承載量;
            rowCapacity.Cells[4].Value = 每週可承載量;
            dataGridView2.Rows.Add(rowCapacity);

            var rowLoad = new DataGridViewRow();
            rowLoad.CreateCells(dataGridView2);
            rowLoad.Cells[0].Value = "負荷率";
            rowLoad.Cells[1].Value = (s1 / 每週可承載量).ToString("P0");
            rowLoad.Cells[2].Value = (s2 / 每週可承載量).ToString("P0");
            rowLoad.Cells[3].Value = (s3 / 每週可承載量).ToString("P0");
            rowLoad.Cells[4].Value = (s4 / 每週可承載量).ToString("P0");
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
