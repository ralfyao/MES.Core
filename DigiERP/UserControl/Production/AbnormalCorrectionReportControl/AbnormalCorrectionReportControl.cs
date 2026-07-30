using DigiERP.Common;
using DigiERP.Forms.Production;
using DigiERP.Models;
using MES.Core.Model;
using MES.WebAPI.Controllers;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace DigiERP.UserControl.Production
{
    // ── 異常矯正措施報告：由「組裝派案及領料作業」結案回報選擇『設計變更』時
    //    開啟，依來源單據(製圖檔名，已去除『售後維修』字樣)載入(或新建)一筆
    //    報告；客戶簡稱/機台型號/機台類型/機台名稱為唯讀，依專案序號從工令單
    //    查詢帶出，不寫回本表 ─────────────────────────────────────────
    public partial class AbnormalCorrectionReportControl : CommonUserControl
    {
        private static string id = "AA96E25E-4B39-4BE8-85AC-0B4A4DC6587C";

        private readonly Dictionary<string, Control> _fields = new Dictionary<string, Control>();
        private readonly Dictionary<string, Label> _footerFields = new Dictionary<string, Label>();
        private 異常矯正措施報告 _header;
        private bool _editing;
        private List<成本單位人員配置> _designStaffList = new List<成本單位人員配置>();
        private List<成本單位人員配置> _salesStaffList = new List<成本單位人員配置>();

        public AbnormalCorrectionReportControl()
        {
            if (!chkPrivilege(id))
            {
                MessageBox.Show("非授權使用者無法使用此功能!");
                Dispose();
                return;
            }
            InitializeComponent();
            BuildContextFields();
            BuildTextAreaFields();
            BuildSideFields();
            BuildFooterFields();

            var designStaffRep = new ProjectProgressController().GetDesignStaffList();
            _designStaffList = designStaffRep.resultList ?? new List<成本單位人員配置>();
            var salesStaffRep = new ProjectProgressController().GetSalesStaffList();
            _salesStaffList = salesStaffRep.resultList ?? new List<成本單位人員配置>();

            disableAllControls(true);
        }

        // ── 表頭：日期/單號/機台型號(DLookUp)/客戶簡稱(DLookUp)/專案序號/
        //    機台名稱(DLookUp)/機台類型(DLookUp)/模組編碼/零件號碼/品名/數量 ──
        private void BuildContextFields()
        {
            var rows = new (string Caption, string Key, bool ReadOnly)[][]
            {
                new (string, string, bool)[]
                {
                    ("日期", "日期", false),
                    ("單號", "單號", false),
                    ("機台型號", "機台型號", true),
                },
                new (string, string, bool)[]
                {
                    ("客戶簡稱", "客戶簡稱", true),
                    ("專案序號", "專案序號", true),
                    ("機台名稱", "機台名稱", true),
                },
                new (string, string, bool)[]
                {
                    ("機台類型", "機台類型", true),
                    ("模組編碼", "模組編碼", true),
                    ("零件號碼", "零件號碼", false),
                },
                new (string, string, bool)[]
                {
                    ("品名", "品名", false),
                    ("數量", "數量", false),
                },
            };

            int y = 8;
            foreach (var row in rows)
            {
                int x = 8;
                foreach (var (caption, key, isReadOnly) in row)
                {
                    var lbl = new Label
                    {
                        Text = caption,
                        Location = new Point(x, y + 4),
                        AutoSize = false,
                        Size = new Size(80, 24),
                        TextAlign = ContentAlignment.MiddleLeft,
                    };
                    panelContext.Controls.Add(lbl);

                    var input = new TextBox
                    {
                        Location = new Point(x + 84, y + 3),
                        Size = new Size(260, 26),
                        ReadOnly = true,
                    };
                    panelContext.Controls.Add(input);
                    _fields[key] = input;
                    x += 350;
                }
                y += 32;
            }
        }

        // ── 左側四大段落：異常狀況/原因分析/矯正措施/預防對策(多行) ────────
        private void BuildTextAreaFields()
        {
            string[] keys = { "異常狀況", "原因分析", "矯正措施", "預防對策" };
            int y = 8;
            foreach (var key in keys)
            {
                var lbl = new Label
                {
                    Text = key,
                    Location = new Point(8, y),
                    AutoSize = false,
                    Size = new Size(90, 90),
                    TextAlign = ContentAlignment.TopLeft,
                };
                panelLeft.Controls.Add(lbl);

                var input = new TextBox
                {
                    Location = new Point(102, y),
                    Size = new Size(560, 90),
                    Multiline = true,
                    ScrollBars = ScrollBars.Vertical,
                    ReadOnly = true,
                };
                panelLeft.Controls.Add(input);
                _fields[key] = input;
                y += 98;
            }
        }

        // ── 右側：檢查人員/異常來源/來源單據/分析人員(設計人員)/決策人員/設計變更 ──
        private void BuildSideFields()
        {
            var rows = new (string Caption, string Key, bool Picker)[]
            {
                ("檢查人員", "檢查人員", true),
                ("異常來源", "異常來源", false),
                ("來源單據", "來源單據", false),
                ("分析人員", "設計人員", true),
                ("決策人員", "決策人員", true),
            };

            int y = 8;
            foreach (var (caption, key, isPicker) in rows)
            {
                var lbl = new Label
                {
                    Text = caption,
                    Location = new Point(8, y + 4),
                    AutoSize = false,
                    Size = new Size(80, 24),
                    TextAlign = ContentAlignment.MiddleLeft,
                };
                panelRight.Controls.Add(lbl);

                var input = new TextBox
                {
                    Location = new Point(96, y + 3),
                    Size = new Size(180, 26),
                    ReadOnly = true,
                };
                if (isPicker)
                {
                    input.Click += (s, e) => OpenStaffPicker(key, (TextBox)s);
                }
                panelRight.Controls.Add(input);
                _fields[key] = input;
                y += 34;
            }

            var chkLbl = new Label
            {
                Text = "設計變更",
                Location = new Point(8, y + 4),
                AutoSize = false,
                Size = new Size(80, 24),
                TextAlign = ContentAlignment.MiddleLeft,
            };
            panelRight.Controls.Add(chkLbl);

            var chk = new CheckBox
            {
                Location = new Point(96, y + 4),
                AutoSize = true,
                Enabled = false,
            };
            panelRight.Controls.Add(chk);
            _fields["設計變更"] = chk;
        }

        // ── 表單尾：建檔/建檔日/修改/修改日/核准/核准日，僅顯示不可編輯 ─────
        private void BuildFooterFields()
        {
            var cols = new (string Caption, string Key)[]
            {
                ("建檔人員", "建檔"),
                ("建檔日", "建檔日"),
                ("修改人員", "修改"),
                ("修改日", "修改日"),
                ("核准人員", "核准"),
                ("核准日", "核准日"),
            };

            int x = 8;
            foreach (var (caption, key) in cols)
            {
                var lbl = new Label
                {
                    Text = caption,
                    Location = new Point(x, 14),
                    AutoSize = false,
                    Size = new Size(70, 20),
                    TextAlign = ContentAlignment.MiddleLeft,
                    ForeColor = Color.DimGray,
                };
                panelFooter.Controls.Add(lbl);

                var val = new Label
                {
                    Location = new Point(x + 74, 14),
                    AutoSize = false,
                    Size = new Size(180, 20),
                    TextAlign = ContentAlignment.MiddleLeft,
                    BorderStyle = BorderStyle.FixedSingle,
                };
                panelFooter.Controls.Add(val);
                _footerFields[key] = val;
                x += 264;
            }
        }

        // ── 檢查人員/分析人員(設計人員欄位)：職務='設計'名單；決策人員：職務='業務'名單 ──
        private void OpenStaffPicker(string key, TextBox target)
        {
            if (!_editing) return;
            var list = key == "決策人員" ? _salesStaffList : _designStaffList;
            using var frm = new FrmSelectStaff(list);
            if (frm.ShowDialog(FindForm()) != DialogResult.OK) return;
            target.Text = frm.SelectedItem.姓名;
        }

        // ── 由「組裝派案及領料作業」開啟：依來源單據(製圖檔名)載入(或新建)一筆報告 ──
        internal void LoadBySourceDoc(string sourceDoc, string projectNo, string moduleCode, string moduleName)
        {
            var rep = new ProjectProgressController().GetAbnormalCorrectionReportBySourceDoc(sourceDoc);
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }

            _header = rep.result ?? new 異常矯正措施報告
            {
                來源單據 = sourceDoc,
                專案序號 = projectNo,
                模組編碼 = moduleCode,
                模組名稱 = moduleName,
                日期 = DateTime.Now.ToString("yyyy/MM/dd"),
                設計變更 = true,
            };
            _editing = false;
            FillFields(_header);

            var workOrderRep = new ProjectProgressController().GetWorkOrderByProjectNo(projectNo);
            var workOrder = workOrderRep.result;
            SetText("客戶簡稱", workOrder?.客戶簡稱);
            SetText("機台型號", workOrder?.機台型號);
            SetText("機台類型", workOrder?.機台類型);
            SetText("機台名稱", workOrder?.機台名稱);

            RefreshButtonStates();
        }

        private void FillFields(異常矯正措施報告 h)
        {
            SetText("日期", h?.日期);
            SetText("單號", h?.單號);
            SetText("專案序號", h?.專案序號);
            SetText("模組編碼", h?.模組編碼);
            SetText("零件號碼", h?.零件號碼);
            SetText("品名", h?.品名);
            SetText("數量", h?.數量?.ToString());
            SetText("異常狀況", h?.異常狀況);
            SetText("原因分析", h?.原因分析);
            SetText("矯正措施", h?.矯正措施);
            SetText("預防對策", h?.預防對策);
            SetText("檢查人員", h?.檢查人員);
            SetText("異常來源", h?.異常來源);
            SetText("來源單據", h?.來源單據);
            SetText("設計人員", h?.設計人員);
            SetText("決策人員", h?.決策人員);
            if (_fields.TryGetValue("設計變更", out var chkCtrl) && chkCtrl is CheckBox chk)
            {
                chk.Checked = h?.設計變更 ?? true;
            }

            SetFooterText("建檔", h?.建檔);
            SetFooterText("建檔日", h?.建檔日);
            SetFooterText("修改", h?.修改);
            SetFooterText("修改日", h?.修改日);
            SetFooterText("核准", h?.核准);
            SetFooterText("核准日", h?.核准日);
        }

        private void SetText(string key, string value) { if (_fields.TryGetValue(key, out var c) && c is TextBox tb) tb.Text = value ?? ""; }
        private string GetText(string key) => _fields.TryGetValue(key, out var c) && c is TextBox tb ? tb.Text : null;
        private void SetFooterText(string key, string value) { if (_footerFields.TryGetValue(key, out var lbl)) lbl.Text = value ?? ""; }

        // ── 跟其他 Maintain 畫面一致：按「修改」前，可編輯欄位皆為 Disable；
        //    專案序號/模組編碼/機台型號等context欄位恆唯讀 ───────────────
        private void disableAllControls(bool disable)
        {
            string[] editableKeys =
            {
                "日期", "單號", "零件號碼", "品名", "數量",
                "異常狀況", "原因分析", "矯正措施", "預防對策",
                "檢查人員", "異常來源", "設計人員", "決策人員",
            };
            foreach (var key in editableKeys)
            {
                if (_fields.TryGetValue(key, out var c) && c is TextBox tb) tb.ReadOnly = disable;
            }
            if (_fields.TryGetValue("設計變更", out var chkCtrl) && chkCtrl is CheckBox chk)
            {
                chk.Enabled = !disable;
            }

            btnSave.Enabled = !disable;
        }

        private void RefreshButtonStates()
        {
            bool hasHeader = _header != null;
            disableAllControls(!_editing);
            btnEdit.Enabled = hasHeader && !_editing;
            btnSave.Enabled = hasHeader && _editing;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (_header == null) return;
            _editing = true;
            RefreshButtonStates();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_header == null) return;

            _header.日期 = GetText("日期");
            _header.單號 = GetText("單號");
            _header.零件號碼 = GetText("零件號碼");
            _header.品名 = GetText("品名");
            _header.數量 = short.TryParse(GetText("數量"), out var qty) ? qty : (short?)null;
            _header.異常狀況 = GetText("異常狀況");
            _header.原因分析 = GetText("原因分析");
            _header.矯正措施 = GetText("矯正措施");
            _header.預防對策 = GetText("預防對策");
            _header.檢查人員 = GetText("檢查人員");
            _header.異常來源 = GetText("異常來源");
            _header.設計人員 = GetText("設計人員");
            _header.決策人員 = GetText("決策人員");
            if (_fields.TryGetValue("設計變更", out var chkCtrl) && chkCtrl is CheckBox chk)
            {
                _header.設計變更 = chk.Checked;
            }

            var rep = new ProjectProgressController().SaveAbnormalCorrectionReport(new MES.WebAPI.Models.SaveAbnormalCorrectionReportReq
            {
                form = _header,
                operatorName = AppSession.User.name,
            });
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }

            MessageBox.Show("已儲存");
            _editing = false;
            LoadBySourceDoc(_header.來源單據, _header.專案序號, _header.模組編碼, _header.模組名稱);
        }

        private void btnActivate_Click(object sender, EventArgs e) => MessageBox.Show("此功能尚未開放");
        private void btnDeactivate_Click(object sender, EventArgs e) => MessageBox.Show("此功能尚未開放");
        private void btnPrint_Click(object sender, EventArgs e) => MessageBox.Show("此功能尚未開放");
        private void btnOverview_Click(object sender, EventArgs e) => MessageBox.Show("此功能尚未開放");

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
