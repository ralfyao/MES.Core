using DigiERP.Common;
using MES.Core.Model;
using MES.WebAPI.Controllers;
using System.Collections.Generic;
using System.Drawing;
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

            dataGridView1.Rows.Clear();
            dataGridView2.Rows.Clear();
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
