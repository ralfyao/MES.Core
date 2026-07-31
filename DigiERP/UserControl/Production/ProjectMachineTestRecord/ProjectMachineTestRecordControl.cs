using DigiERP.Common;
using MES.Core.Model;
using MES.WebAPI.Controllers;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace DigiERP.UserControl.Production
{
    // ── 專案機台組測紀錄表：由「組裝派案及領料作業」雙擊專案序號開啟；
    //    表頭取自工令單 LEFT JOIN 產品規格單；下方兩個明細清單畫面先行
    //    建置，資料來源日後再串接 ─────────────────────────────────────
    public partial class ProjectMachineTestRecordControl : CommonUserControl
    {
        private static string id = "5AA93422-F493-4BB7-A895-04409897CCE3";

        private readonly Dictionary<string, TextBox> _fields = new Dictionary<string, TextBox>();

        public ProjectMachineTestRecordControl()
        {
            if (!chkPrivilege(id))
            {
                MessageBox.Show("非授權使用者無法使用此功能!");
                Dispose();
                return;
            }
            InitializeComponent();
            BuildContextFields();
            initAssemblyStaffCombo();
        }

        // ── 組裝人員下拉：職務='組測'的成本單位人員配置(對應到 H員工清冊 取姓名) ──
        private void initAssemblyStaffCombo()
        {
            var rep = new ProjectProgressController().GetAssemblyTestStaffList();
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }
            colAssemblyStaff.Items.Clear();
            colAssemblyStaff.Items.Add("");
            foreach (var name in (rep.resultList ?? new List<成本單位人員配置>()).Select(x => x.姓名).Where(n => !string.IsNullOrEmpty(n)).Distinct())
            {
                colAssemblyStaff.Items.Add(name);
            }
        }

        // ── 表頭：專案序號/機台類型/機台型號/機台名稱/客戶簡稱/國家地區/
        //    驗機日期/交貨日期/廠驗/裝機，以及MQC/FQC/OQC三項按鈕+顯示欄位 ──
        private void BuildContextFields()
        {
            var rows = new (string Caption, string Key)[][]
            {
                new (string, string)[] { ("專案序號", "專案序號"), ("機台類型", "機台類型"), ("客戶簡稱", "客戶簡稱"), ("交貨日期", "交貨日期"), ("裝機", "裝機") },
                new (string, string)[] { ("機台型號", "機台型號"), ("", ""), ("國家地區", "國家地區"), ("驗機日期", "驗機日期"), ("廠驗", "廠驗") },
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

            var buttonRows = new (string ButtonText, string Key)[]
            {
                ("油壓單元", "MQC油壓委外單元"),
                ("製成參數表", "FQC製成參數"),
                ("出機檢查表", "OQC出機檢查"),
            };

            int by = 8;
            int bx = 1112;
            foreach (var (buttonText, key) in buttonRows)
            {
                var btn = new Button
                {
                    Text = buttonText,
                    Location = new Point(bx, by),
                    Size = new Size(110, 26),
                    BackColor = Color.LightSteelBlue,
                    FlatStyle = FlatStyle.Flat,
                };
                btn.Click += (s, e) => MessageBox.Show("此功能尚未開放");
                panelContext.Controls.Add(btn);

                var input = new TextBox
                {
                    Location = new Point(bx + 114, by + 1),
                    Size = new Size(300, 26),
                    ReadOnly = true,
                };
                panelContext.Controls.Add(input);
                _fields[key] = input;
                by += 32;
            }
        }

        // ── 由「組裝派案及領料作業」雙擊專案序號開啟：載入表頭資料 ─────────
        internal void LoadData(string projectNo)
        {
            var rep = new ProjectProgressController().GetProjectMachineTestRecordHeader(projectNo);
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }

            var h = rep.result;
            SetText("專案序號", h?.專案序號);
            SetText("機台類型", h?.機台類型);
            SetText("機台型號", h?.機台型號);
            SetText("機台名稱", h?.機台名稱);
            SetText("客戶簡稱", h?.客戶簡稱);
            SetText("國家地區", h?.國家地區);
            SetText("驗機日期", h?.驗機日期);
            SetText("交貨日期", h?.交貨日期);
            SetText("廠驗", h?.廠驗);
            SetText("裝機", h?.裝機);
            SetText("FQC製成參數", h?.FQC製成參數);
            SetText("OQC出機檢查", h?.OQC出機檢查);
            SetText("MQC油壓委外單元", h?.MQC油壓委外單元);

            var moduleRep = new ProjectProgressController().GetModuleMaterialList(projectNo);
            if (!string.IsNullOrEmpty(moduleRep.ErrorMessage))
            {
                MessageBox.Show(moduleRep.ErrorMessage);
                return;
            }
            FillModuleGrid(moduleRep.resultList ?? new List<專案模組用料清單>());

            var workLogRep = new ProjectProgressController().GetAssemblyTestWorkLogList(projectNo);
            if (!string.IsNullOrEmpty(workLogRep.ErrorMessage))
            {
                MessageBox.Show(workLogRep.ErrorMessage);
                return;
            }
            FillWorkLogGrid(workLogRep.resultList ?? new List<組測工作紀錄清單>());
        }

        // ── 第二個明細清單：資料來源為工作紀錄A(職務='組測') ──────────────
        private void FillWorkLogGrid(List<組測工作紀錄清單> list)
        {
            dataGridView2.Rows.Clear();
            foreach (var x in list)
            {
                int i = dataGridView2.Rows.Add();
                var row = dataGridView2.Rows[i];
                row.Cells[colTestDate.Index].Value = x.日期;
                row.Cells[colTester.Index].Value = x.組測人員;
                row.Cells[colModuleCode2.Index].Value = x.模組編碼;
                row.Cells[colModuleName2.Index].Value = x.模組名稱;
                row.Cells[colTaskCategory.Index].Value = x.任務分類;
                row.Cells[colWorkItem.Index].Value = x.組裝零件;
                row.Cells[colTestStatus.Index].Value = x.工作簡述;
                row.Cells[colAction.Index].Value = x.特別註記;
            }
        }

        // ── 第一個明細清單：資料來源為專案模組用料清單(即「組裝派案」) ──────
        private void FillModuleGrid(List<專案模組用料清單> list)
        {
            dataGridView1.Rows.Clear();
            foreach (var x in list)
            {
                // 既有資料可能是離職/未在組測人員清單內的舊值，先補進選項避免指派時值無效
                string assemblyStaff = x.組裝人員 ?? "";
                if (!string.IsNullOrEmpty(assemblyStaff) && !colAssemblyStaff.Items.Contains(assemblyStaff))
                {
                    colAssemblyStaff.Items.Add(assemblyStaff);
                }
                string closeReport = x.結案回報 ?? "";
                if (!string.IsNullOrEmpty(closeReport) && !colCloseReport.Items.Contains(closeReport))
                {
                    colCloseReport.Items.Add(closeReport);
                }

                int i = dataGridView1.Rows.Add();
                var row = dataGridView1.Rows[i];
                row.Cells[colModuleCode.Index].Value = x.模組編碼;
                row.Cells[colModuleName.Index].Value = x.模組名稱;
                row.Cells[colDrawingFile.Index].Value = x.製圖檔名;
                row.Cells[colAssemblyStaff.Index].Value = assemblyStaff;
                row.Cells[colStartDate.Index].Value = x.開工日期;
                row.Cells[colDueDate.Index].Value = x.預交日期;
                row.Cells[colFinishDate.Index].Value = x.完工日期;
                row.Cells[colCloseReport.Index].Value = closeReport;
            }
        }

        // ── 防呆：避免下拉欄位值不在選項清單內時跳出預設錯誤對話方塊 ─────────
        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
        }

        private void SetText(string key, string value)
        {
            if (_fields.TryGetValue(key, out var tb)) tb.Text = value ?? "";
        }

        private void btnExit_Click(object sender, System.EventArgs e)
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
