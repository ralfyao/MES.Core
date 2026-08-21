using DigiERP.Common;
using MES.Core.Model;
using MES.WebAPI.Controllers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace DigiERP.UserControl.HR.ProjectHour
{
    // ── 專案累計工作時數：比照 PITS-2025.accdb 之「Y-專案累計工作時數」表單，
    //    純唯讀清單，資料來源為原查詢「專案累計工作時數」(工令單 LEFT JOIN
    //    工作紀錄A LEFT JOIN dbo_EMPL 取姓名，dbo_EMPL 在 CHINYO 不存在，已
    //    修正為 H員工清冊)，依專案序號+員工編號彙總「本日工時」/「本日工時*
    //    單價」為工時合計/工時成本合計，僅列出實際有登載工作紀錄者；原巨集
    //    僅有兩顆按鈕：匯出至Excel(RunCommand ExportExcel)、EXIT(關閉) ──────
    public partial class ProjectHourControl : CommonUserControl
    {
        private static string id = "3F3455EA-A04A-40C3-8066-3CFFF5B9A815";

        public ProjectHourControl()
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
            var rep = new HRController().GetProjectAccumulatedHourList();
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }
            dataGridView1.Rows.Clear();
            foreach (var x in rep.resultList ?? new List<專案累計工作時數列表>())
            {
                int i = dataGridView1.Rows.Add();
                var row = dataGridView1.Rows[i];
                row.Cells[colProjectNo.Index].Value = x.專案序號;
                row.Cells[colCustomer.Index].Value = x.客戶簡稱;
                row.Cells[colModel.Index].Value = x.機台型號;
                row.Cells[colMachineName.Index].Value = x.機台名稱;
                row.Cells[colEmpNo.Index].Value = x.員工編號;
                row.Cells[colName.Index].Value = x.姓名;
                row.Cells[colHours.Index].Value = x.工時合計;
                row.Cells[colCost.Index].Value = x.工時成本合計;
                row.Cells[colClosed.Index].Value = x.結案 ?? false;
            }
        }

        // ── 匯出至Excel：比照原巨集 RunCommand(ExportExcel)，改以 CSV 格式輸出
        //    (UTF-8 含 BOM，Excel 可直接開啟且中文不會亂碼)，避免額外引入
        //    Excel 函式庫相依性 ─────────────────────────────────────────────
        private void btnExport_Click(object sender, EventArgs e)
        {
            using var dlg = new SaveFileDialog
            {
                Filter = "CSV 檔案 (*.csv)|*.csv",
                FileName = "專案累計工作時數_" + DateTime.Today.ToString("yyyyMMdd") + ".csv",
            };
            if (dlg.ShowDialog(this) != DialogResult.OK) return;

            try
            {
                var sb = new StringBuilder();
                sb.AppendLine(string.Join(",", "專案序號", "客戶簡稱", "機台型號", "機台名稱", "員工編號", "姓名", "工時合計", "工時成本", "結案"));
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.IsNewRow) continue;
                    sb.AppendLine(string.Join(",",
                        CsvCell(row.Cells[colProjectNo.Index].Value),
                        CsvCell(row.Cells[colCustomer.Index].Value),
                        CsvCell(row.Cells[colModel.Index].Value),
                        CsvCell(row.Cells[colMachineName.Index].Value),
                        CsvCell(row.Cells[colEmpNo.Index].Value),
                        CsvCell(row.Cells[colName.Index].Value),
                        CsvCell(row.Cells[colHours.Index].Value),
                        CsvCell(row.Cells[colCost.Index].Value),
                        CsvCell(row.Cells[colClosed.Index].Value)));
                }
                File.WriteAllText(dlg.FileName, sb.ToString(), new UTF8Encoding(true));
                MessageBox.Show("匯出成功!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("匯出失敗: " + ex.Message);
            }
        }

        private static string CsvCell(object value)
        {
            string text = value?.ToString() ?? "";
            if (text.Contains(',') || text.Contains('"') || text.Contains('\n'))
            {
                text = "\"" + text.Replace("\"", "\"\"") + "\"";
            }
            return text;
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
