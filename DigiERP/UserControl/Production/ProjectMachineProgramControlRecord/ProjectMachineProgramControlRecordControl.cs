using DigiERP.Common;
using MES.Core.Model;
using MES.WebAPI.Controllers;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace DigiERP.UserControl.Production
{
    // ── 專案機台程控紀錄表：由「電控排程」點選專案序號開啟；
    //    表頭取自產品規格單 LEFT JOIN 工令單；下方兩個明細清單(M-專案程控排程/
    //    M-專案程控履歷)畫面先行建置，資料來源日後再串接 ─────────────────
    public partial class ProjectMachineProgramControlRecordControl : CommonUserControl
    {
        private static string id = "7C2E9A14-6D5B-4F83-A1E2-3B4C5D6E7F80";

        private readonly Dictionary<string, TextBox> _fields = new Dictionary<string, TextBox>();
        private readonly Dictionary<string, CheckBox> _checkFields = new Dictionary<string, CheckBox>();
        private string _currentProjectNo;

        public ProjectMachineProgramControlRecordControl()
        {
            if (!chkPrivilege(id))
            {
                MessageBox.Show("非授權使用者無法使用此功能!");
                Dispose();
                return;
            }
            InitializeComponent();
            BuildContextFields();
        }

        // ── 表頭：專案序號/機台類型/客戶簡稱/交貨日期/機台型號/國家地區/驗機日期/
        //    機台名稱(唯讀文字)，以及 自動化程控/廠驗/裝機 與 6 項資料夾項目勾選 ──
        private void BuildContextFields()
        {
            var rows = new (string Caption, string Key)[][]
            {
                new (string, string)[] { ("專案序號", "專案序號"), ("機台類型", "機台類型"), ("客戶簡稱", "客戶簡稱"), ("交貨日期", "交貨日期") },
                new (string, string)[] { ("機台型號", "機台型號"), ("", ""), ("國家地區", "國家地區"), ("驗機日期", "驗機日期") },
                new (string, string)[] { ("機台名稱", "機台名稱") },
            };

            int y = 8;
            foreach (var row in rows)
            {
                int x = 8;
                foreach (var (caption, key) in row)
                {
                    if (!string.IsNullOrEmpty(caption))
                    {
                        var lbl = new Label
                        {
                            Text = caption,
                            Location = new Point(x, y + 4),
                            AutoSize = false,
                            Size = new Size(70, 24),
                            TextAlign = ContentAlignment.MiddleLeft,
                        };
                        panelContext.Controls.Add(lbl);

                        var input = new TextBox
                        {
                            Location = new Point(x + 74, y + 3),
                            Size = new Size(190, 26),
                            ReadOnly = true,
                        };
                        panelContext.Controls.Add(input);
                        _fields[key] = input;
                    }
                    x += 274;
                }
                y += 32;
            }

            // ── 自動化程控/廠驗/裝機：勾選框(唯讀顯示) ──────────────────
            var checkRows = new (string Caption, string Key, int Row)[]
            {
                ("MQC-自動化程控", "MQC自動化程控", 0),
                ("廠驗", "廠驗", 1),
                ("裝機", "裝機", 1),
            };
            foreach (var (caption, key, rowIdx) in checkRows)
            {
                int cx = rowIdx == 0 ? 1112 : (key == "廠驗" ? 1112 : 1330);
                var chk = new CheckBox
                {
                    Text = caption,
                    Location = new Point(cx, 8 + rowIdx * 32 + 3),
                    AutoSize = true,
                    Enabled = false,
                    ForeColor = rowIdx == 0 ? Color.SeaGreen : SystemColors.ControlText,
                    Font = rowIdx == 0 ? new Font(Font, FontStyle.Bold) : Font,
                };
                panelContext.Controls.Add(chk);
                _checkFields[key] = chk;
            }

            // ── 檢查回存說明書資料夾項目：6 項勾選框(唯讀顯示) ───────────────
            var folderLbl = new Label
            {
                Text = "檢查回存說明書資料夾項目",
                Location = new Point(8, 112),
                AutoSize = false,
                Size = new Size(190, 24),
                TextAlign = ContentAlignment.MiddleLeft,
            };
            panelContext.Controls.Add(folderLbl);

            var folderItems = new (string Caption, string Key)[]
            {
                ("I/O表", "IO表"),
                ("電控迴路圖", "電控迴路圖"),
                ("PLC階梯圖原始檔", "PLC階梯圖原始檔"),
                ("人機介面原始檔", "人機介面原始檔"),
                ("電控箱配置圖", "電控箱配置圖"),
                ("電控用料表", "電控用料表"),
            };
            int fx = 204;
            foreach (var (caption, key) in folderItems)
            {
                var chk = new CheckBox
                {
                    Text = caption,
                    Location = new Point(fx, 112),
                    AutoSize = true,
                    Enabled = true,
                    Tag = key,
                };
                chk.CheckedChanged += FolderItemCheckBox_CheckedChanged;
                panelContext.Controls.Add(chk);
                _checkFields[key] = chk;
                fx += 190;
            }
        }

        // ── 檢查回存說明書資料夾項目：勾選即時寫回 產品規格單，其餘欄位皆不可修改 ────
        private void FolderItemCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_currentProjectNo)) return;
            var chk = (CheckBox)sender;
            string fieldKey = (string)chk.Tag;

            var rep = new ProjectProgressController().UpdateProductSpecFolderItem(_currentProjectNo, fieldKey, chk.Checked);
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
            }
        }

        // ── 由「電控排程」點選專案序號開啟：載入表頭資料 ───────────────────
        internal void LoadData(string projectNo)
        {
            // ── 載入期間先清空，避免 SetCheck 觸發勾選框事件回寫資料庫 ────────
            _currentProjectNo = null;

            var rep = new ProjectProgressController().GetProjectMachineProgramControlHeader(projectNo);
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }

            var h = rep.result;
            SetText("專案序號", h?.專案序號);
            SetText("機台類型", h?.機台類型);
            SetText("客戶簡稱", h?.客戶簡稱);
            SetText("交貨日期", h?.交貨日期);
            SetText("機台型號", h?.機台型號);
            SetText("國家地區", h?.國家地區);
            SetText("驗機日期", h?.驗機日期);
            SetText("機台名稱", h?.機台名稱);

            SetCheck("MQC自動化程控", ParseAccessBool(h?.MQC自動化程控));
            SetCheck("廠驗", ParseAccessBool(h?.廠驗));
            SetCheck("裝機", ParseAccessBool(h?.裝機));
            SetCheck("IO表", h?.IO表 ?? false);
            SetCheck("電控迴路圖", h?.電控迴路圖 ?? false);
            SetCheck("PLC階梯圖原始檔", h?.PLC階梯圖原始檔 ?? false);
            SetCheck("人機介面原始檔", h?.人機介面原始檔 ?? false);
            SetCheck("電控箱配置圖", h?.電控箱配置圖 ?? false);
            SetCheck("電控用料表", h?.電控用料表 ?? false);

            FillScheduleGrid(projectNo);
            FillWorkLogGrid(projectNo);

            _currentProjectNo = projectNo;
        }

        // ── 專案程控履歷：資料來源為 工作日誌/工作紀錄明細-組/工令單(職務='程控')。
        //    畫面標題與實際欄位對應為位置對應(非欄名逐字對應)：
        //    程控人員←組測人員(姓名)/模組←模組編碼/電控工序←模組名稱/
        //    實測狀態←工作簡述/處置措施←特別註記 ──────────────────────
        private void FillWorkLogGrid(string projectNo)
        {
            dataGridView2.Rows.Clear();

            var rep = new ProjectProgressController().GetProgramControlWorkLogList(projectNo);
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }

            foreach (var x in rep.resultList ?? new List<組測工作紀錄清單>())
            {
                int i = dataGridView2.Rows.Add();
                var row = dataGridView2.Rows[i];
                row.Cells[colLogDate.Index].Value = x.日期;
                row.Cells[colLogStaff.Index].Value = x.組測人員;
                row.Cells[colLogModuleCode.Index].Value = x.模組編碼;
                row.Cells[colLogProcess.Index].Value = x.模組名稱;
                row.Cells[colLogTaskCategory.Index].Value = x.任務分類;
                row.Cells[colLogWorkItem.Index].Value = x.組裝零件;
                row.Cells[colLogTestStatus.Index].Value = x.工作簡述;
                row.Cells[colLogAction.Index].Value = x.特別註記;
            }
        }

        // ── 專案程控排程：資料來源為 專案電控排程，依專案序號查詢 ──────────
        private void FillScheduleGrid(string projectNo)
        {
            dataGridView1.Rows.Clear();

            var rep = new ProjectProgressController().GetElectricScheduleList(projectNo);
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }

            foreach (var x in rep.resultList ?? new List<專案電控排程>())
            {
                int i = dataGridView1.Rows.Add();
                var row = dataGridView1.Rows[i];
                row.Cells[colProcess.Index].Value = x.電控工序;
                row.Cells[colDesc.Index].Value = x.簡要描述;
                row.Cells[colStaff.Index].Value = x.程控人員;
                row.Cells[colStartDate.Index].Value = x.開始作業日期;
                row.Cells[colPlanFinishDate.Index].Value = x.預計完成日期;
                row.Cells[colActualFinishDate.Index].Value = x.實際完成日期;
            }
        }

        // ── 廠驗/裝機/MQC-自動化程控 於資料庫中為文字欄位(非 bit)，
        //    判斷常見的 Access Yes/No 遷移文字值(True/-1/1)視為已勾選 ──────
        private static bool ParseAccessBool(string value)
        {
            if (string.IsNullOrWhiteSpace(value)) return false;
            return value.Trim().Equals("True", StringComparison.OrdinalIgnoreCase)
                || value.Trim() == "-1"
                || value.Trim() == "1";
        }

        private void SetText(string key, string value)
        {
            if (_fields.TryGetValue(key, out var tb)) tb.Text = value ?? "";
        }

        private void SetCheck(string key, bool value)
        {
            if (_checkFields.TryGetValue(key, out var chk)) chk.Checked = value;
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
