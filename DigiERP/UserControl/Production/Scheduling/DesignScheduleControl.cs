using DigiERP.Common;
using MES.Core.Model;
using MES.WebAPI.Controllers;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DigiERP.UserControl.Production
{
    public partial class DesignScheduleControl : CommonUserControl
    {
        private static string id = "6F1A9C38-2D7E-4B54-9C8A-3E7F1B6D4A29";
        private const double 每週應計工時 = 40;

        public DesignScheduleControl()
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

        // ── 讓查詢起日/第一~六週日期方塊對齊 dataGridView1 的基準日以前~第六週欄位 ──
        private void PositionDateHeaders()
        {
            Label[] labels = { lblChipStart, lblChipWeek1, lblChipWeek2, lblChipWeek3, lblChipWeek4, lblChipWeek5, lblChipWeek6 };
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

        internal void LoadData(DateTime 查詢起日, DateTime 第一週, DateTime 第二週, DateTime 第三週, DateTime 第四週, DateTime 第五週, DateTime 第六週)
        {
            // ── 顯示查詢頁帶入的查詢起日與第一~六週日期 ──────────────────
            lblChipStart.Text = 查詢起日.ToString("yyyy/M/d");
            lblChipWeek1.Text = 第一週.ToString("yyyy/M/d");
            lblChipWeek2.Text = 第二週.ToString("yyyy/M/d");
            lblChipWeek3.Text = 第三週.ToString("yyyy/M/d");
            lblChipWeek4.Text = 第四週.ToString("yyyy/M/d");
            lblChipWeek5.Text = 第五週.ToString("yyyy/M/d");
            lblChipWeek6.Text = 第六週.ToString("yyyy/M/d");

            var rep = new ProjectProgressController().GetDesignScheduleList(查詢起日, 第一週, 第二週, 第三週, 第四週, 第五週, 第六週);
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }
            var list = rep.resultList ?? new List<設計週排程表>();
            FillGrid(list);
            FillSummary(list);
            PositionDateHeaders();
        }

        private void FillGrid(List<設計週排程表> list)
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
                row.Cells[i++].Value = x.設計人員;
                row.Cells[i++].Value = x.未排;
                row.Cells[i++].Value = x.過期;
                row.Cells[i++].Value = x.第一週;
                row.Cells[i++].Value = x.第二週;
                row.Cells[i++].Value = x.第三週;
                row.Cells[i++].Value = x.第四週;
                row.Cells[i++].Value = x.第五週;
                row.Cells[i++].Value = x.第六週;
                dataGridView1.Rows.Add(row);
            }
        }

        // ── 每週派案工時(S0-S6)＝各週欄位加總；每周應計工時固定40；負荷率＝S/40 ──
        private void FillSummary(List<設計週排程表> list)
        {
            double s0 = 0, s1 = 0, s2 = 0, s3 = 0, s4 = 0, s5 = 0, s6 = 0;
            foreach (var x in list)
            {
                s0 += x.過期 ?? 0;
                s1 += x.第一週 ?? 0;
                s2 += x.第二週 ?? 0;
                s3 += x.第三週 ?? 0;
                s4 += x.第四週 ?? 0;
                s5 += x.第五週 ?? 0;
                s6 += x.第六週 ?? 0;
            }

            dataGridView2.Rows.Clear();

            var rowHours = new DataGridViewRow();
            rowHours.CreateCells(dataGridView2);
            rowHours.Cells[0].Value = "每週派案工時";
            rowHours.Cells[1].Value = s0;
            rowHours.Cells[2].Value = s1;
            rowHours.Cells[3].Value = s2;
            rowHours.Cells[4].Value = s3;
            rowHours.Cells[5].Value = s4;
            rowHours.Cells[6].Value = s5;
            rowHours.Cells[7].Value = s6;
            dataGridView2.Rows.Add(rowHours);

            var rowCapacity = new DataGridViewRow();
            rowCapacity.CreateCells(dataGridView2);
            rowCapacity.Cells[0].Value = "每周應計工時";
            rowCapacity.Cells[1].Value = 每週應計工時;
            rowCapacity.Cells[2].Value = 每週應計工時;
            rowCapacity.Cells[3].Value = 每週應計工時;
            rowCapacity.Cells[4].Value = 每週應計工時;
            rowCapacity.Cells[5].Value = 每週應計工時;
            rowCapacity.Cells[6].Value = 每週應計工時;
            rowCapacity.Cells[7].Value = 每週應計工時;
            dataGridView2.Rows.Add(rowCapacity);

            var rowLoad = new DataGridViewRow();
            rowLoad.CreateCells(dataGridView2);
            rowLoad.Cells[0].Value = "負荷率";
            rowLoad.Cells[1].Value = (s0 / 每週應計工時).ToString("P0");
            rowLoad.Cells[2].Value = (s1 / 每週應計工時).ToString("P0");
            rowLoad.Cells[3].Value = (s2 / 每週應計工時).ToString("P0");
            rowLoad.Cells[4].Value = (s3 / 每週應計工時).ToString("P0");
            rowLoad.Cells[5].Value = (s4 / 每週應計工時).ToString("P0");
            rowLoad.Cells[6].Value = (s5 / 每週應計工時).ToString("P0");
            rowLoad.Cells[7].Value = (s6 / 每週應計工時).ToString("P0");
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
