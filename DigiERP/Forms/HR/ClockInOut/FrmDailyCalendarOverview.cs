using MES.Core.Model;
using MES.WebAPI.Controllers;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DigiERP.Forms.HR.ClockInOut
{
    // ── 每日卡鐘總覽(日曆總覽)：比照 PITS-2025.accdb 之「H-每日卡鐘總覽」表單，
    //    列出 H日曆 全部日期(含週次/例假日)；雙擊某一天會關閉本視窗並切換回
    //    「每日出勤表」該天資料(比照原表單「日期」欄位 OnDblClick 巨集：
    //    OpenForm H-每日出勤表 WhereCondition=[日期]=目前選取日 → Close 本表單) ──
    public partial class FrmDailyCalendarOverview : Form
    {
        // ── 雙擊選定的日期；呼叫端 ShowDialog 回傳 OK 時據此切換 ────────────
        public string SelectedDate { get; private set; }

        public FrmDailyCalendarOverview()
        {
            InitializeComponent();
        }

        private void FrmDailyCalendarOverview_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            var rep = new HRController().GetCalendarList();
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }
            dataGridView1.Rows.Clear();
            string[] weekdayNames = { "日", "一", "二", "三", "四", "五", "六" };
            foreach (var x in rep.resultList ?? new List<H日曆>())
            {
                int i = dataGridView1.Rows.Add();
                var row = dataGridView1.Rows[i];
                row.Cells[colDate.Index].Value = x.日期;
                row.Cells[colWeekday.Index].Value = DateTime.TryParse(x.日期, out var d) ? weekdayNames[(int)d.DayOfWeek] : "";
                row.Cells[colHoliday.Index].Value = x.例假日 ?? false;
            }
        }

        // ── 最後一筆記錄：捲動並選取清單最後一列 ───────────────────────────
        private void btnLast_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0) return;
            var row = dataGridView1.Rows[dataGridView1.Rows.Count - 1];
            dataGridView1.CurrentCell = row.Cells[colDate.Index];
            dataGridView1.FirstDisplayedScrollingRowIndex = row.Index;
        }

        // ── 雙擊：切換回該天的每日出勤表 ─────────────────────────────────
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            string date = dataGridView1.Rows[e.RowIndex].Cells[colDate.Index].Value?.ToString();
            if (string.IsNullOrEmpty(date)) return;
            SelectedDate = date;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
