using DigiERP.Common;
using MES.Core.Model;
using MES.WebAPI.Controllers;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DigiERP.UserControl.HR.Calendar
{
    // ── 日曆總覽：比照 PITS-2025.accdb 之「H-日曆總覽」表單，列出 H日曆 全部
    //    日期(含週次/例假日/公告事項/人事經辦/核准生效/核准人)；「增修日曆天」
    //    解鎖編輯並跳到最後一筆記錄(比照原巨集 Close→重開Edit模式→GoToRecord
    //    Last)，「儲存」批次寫回後重新鎖定(比照原巨集 SaveRecord→重開ReadOnly
    //    模式) ──────────────────────────────────────────────────────────
    public partial class CalendarControl : CommonUserControl
    {
        private static string id = "D629C23A-8A97-45A3-910A-9E20499A67E3";

        private bool _editing;

        public CalendarControl()
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
                row.Cells[colNotice.Index].Value = x.公告事項;
                row.Cells[colHRHandler.Index].Value = x.人事經辦;
                row.Cells[colApproved.Index].Value = x.核准生效 ?? false;
                row.Cells[colApprover.Index].Value = x.核准人;
            }
            SetEditing(false);
        }

        // ── 鎖定/解鎖：比照全站「唯讀→修改解鎖→儲存」慣例 ───────────────────
        private void SetEditing(bool editing)
        {
            _editing = editing;
            // ── 表格層級的 ReadOnly 會覆蓋所有欄位層級設定，兩者都要切換，
            //    否則欄位 ReadOnly=false 也無法真正編輯 ──────────────────────
            dataGridView1.ReadOnly = !editing;
            foreach (DataGridViewColumn col in dataGridView1.Columns)
            {
                if (col == colWeekday) continue;
                col.ReadOnly = !editing;
            }
            btnModify.Visible = !editing && chkEditPrivilege(id);
            btnSave.Visible = editing;
            btnAddRow.Visible = editing;
        }

        // ── 增修日曆天：解鎖編輯並跳到最後一筆記錄 ──────────────────────────
        private void btnModify_Click(object sender, EventArgs e)
        {
            SetEditing(true);
            ScrollToLastRow();
        }

        private void ScrollToLastRow()
        {
            if (dataGridView1.Rows.Count == 0) return;
            var row = dataGridView1.Rows[dataGridView1.Rows.Count - 1];
            dataGridView1.CurrentCell = row.Cells[colDate.Index];
            dataGridView1.FirstDisplayedScrollingRowIndex = row.Index;
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            ScrollToLastRow();
        }

        // ── 新增一筆：預設日期為目前最後一筆的隔天 ─────────────────────────
        private void btnAddRow_Click(object sender, EventArgs e)
        {
            string nextDate = DateTime.Today.ToString("yyyy/MM/dd");
            if (dataGridView1.Rows.Count > 0)
            {
                var lastDate = dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[colDate.Index].Value?.ToString();
                if (DateTime.TryParse(lastDate, out var d)) nextDate = d.AddDays(1).ToString("yyyy/MM/dd");
            }
            int i = dataGridView1.Rows.Add();
            dataGridView1.Rows[i].Cells[colDate.Index].Value = nextDate;
            dataGridView1.Rows[i].Cells[colWeekday.Index].Value =
                DateTime.TryParse(nextDate, out var nd) ? new[] { "日", "一", "二", "三", "四", "五", "六" }[(int)nd.DayOfWeek] : "";
            ScrollToLastRow();
        }

        // ── 儲存：批次寫回每一列(依日期是否已存在判斷新增或更新) ──────────────
        private void btnSave_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.IsNewRow) continue;
                string date = row.Cells[colDate.Index].Value?.ToString();
                if (string.IsNullOrEmpty(date)) continue;

                var form = new H日曆
                {
                    日期 = date,
                    例假日 = ToBool(row.Cells[colHoliday.Index].Value),
                    公告事項 = row.Cells[colNotice.Index].Value?.ToString(),
                    人事經辦 = row.Cells[colHRHandler.Index].Value?.ToString(),
                    核准生效 = ToBool(row.Cells[colApproved.Index].Value),
                    核准人 = row.Cells[colApprover.Index].Value?.ToString(),
                };
                var rep = new HRController().SaveCalendarFull(form);
                if (!string.IsNullOrEmpty(rep.ErrorMessage))
                {
                    MessageBox.Show(rep.ErrorMessage);
                    return;
                }
            }
            MessageBox.Show("儲存成功!");
            LoadData();
        }

        private static bool ToBool(object value) => value is bool b && b;

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
