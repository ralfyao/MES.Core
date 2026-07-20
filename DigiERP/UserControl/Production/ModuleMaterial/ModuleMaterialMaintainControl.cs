using DigiERP.Common;
using DigiERP.Models;
using MES.Core.Model;
using MES.WebAPI.Controllers;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace DigiERP.UserControl.Production
{
    public partial class ModuleMaterialMaintainControl : CommonUserControl
    {
        private static string id = "6A8E1C3F-4B7D-4A29-9C6E-3F1D8A5B7E42";

        private readonly Dictionary<string, Control> _fields = new Dictionary<string, Control>();
        private readonly Dictionary<string, Label> _footerFields = new Dictionary<string, Label>();
        private 專案模組用料清單 _header;
        private bool _editing;

        public ModuleMaterialMaintainControl()
        {
            if (!chkPrivilege(id))
            {
                MessageBox.Show("非授權使用者無法使用此功能!");
                Dispose();
                return;
            }
            InitializeComponent();
            BuildHeaderFields();
            BuildFooterFields();
            disableAllControls(true);
        }

        // ── 表頭欄位(設計轉入資料，唯讀)＋組裝進度欄位(可編輯) ──────────────
        private void BuildHeaderFields()
        {
            var rows = new (string Caption, string Key, string Type)[][]
            {
                new (string, string, string)[]
                {
                    ("專案序號", "專案序號", "readonly"),
                    ("BOM編號", "BOM編號", "readonly"),
                    ("圖檔發行日", "圖檔發行日", "readonly"),
                },
                new (string, string, string)[]
                {
                    ("模組編碼", "模組編碼", "readonly"),
                    ("模組名稱", "模組名稱", "readonly"),
                    ("發行人員", "發行人員", "readonly"),
                },
                new (string, string, string)[]
                {
                    ("設計人員", "設計人員", "readonly"),
                    ("製圖檔名", "製圖檔名", "readonly"),
                    ("審查清單編號", "審查清單編號", "readonly"),
                },
                new (string, string, string)[]
                {
                    ("組裝人員", "組裝人員", "text"),
                    ("開工日期", "開工日期", "text"),
                    ("預交日期", "預交日期", "text"),
                    ("完工日期", "完工日期", "text"),
                },
                new (string, string, string)[]
                {
                    ("結案回報", "結案回報", "text"),
                    ("用途", "用途", "text"),
                },
            };

            int y = 10;
            foreach (var row in rows)
            {
                int x = 10;
                foreach (var (caption, key, type) in row)
                {
                    var lbl = new Label
                    {
                        Text = caption,
                        Location = new Point(x, y + 4),
                        AutoSize = false,
                        Size = new Size(90, 24),
                        TextAlign = ContentAlignment.MiddleLeft,
                    };
                    panelHeader.Controls.Add(lbl);

                    var input = new TextBox
                    {
                        Location = new Point(x + 94, y + 3),
                        Size = new Size(330, 26),
                        ReadOnly = true,
                    };
                    panelHeader.Controls.Add(input);
                    _fields[key] = input;
                    x += 430;
                }
                y += 32;
            }
        }

        // ── 表單尾：建檔/修改/核准 人員與日期，僅顯示不可編輯 ──────────────
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

            int x = 10;
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

        // ── 由「圖面發行轉BOM」轉入後開啟：依BOM編號載入表頭與明細 ─────────
        internal void LoadData(string bomNo)
        {
            var headerRep = new ProjectProgressController().GetModuleMaterialByBomNo(bomNo);
            if (!string.IsNullOrEmpty(headerRep.ErrorMessage))
            {
                MessageBox.Show(headerRep.ErrorMessage);
                return;
            }
            _header = headerRep.result;
            _editing = false;
            FillHeader(_header);

            var detailRep = new ProjectProgressController().GetModuleBomDetailList(bomNo);
            if (!string.IsNullOrEmpty(detailRep.ErrorMessage))
            {
                MessageBox.Show(detailRep.ErrorMessage);
                return;
            }
            FillDetailGrid(detailRep.resultList ?? new List<專案模組BOM明細>());
            RefreshButtonStates();
        }

        private void FillHeader(專案模組用料清單 h)
        {
            SetText("專案序號", h?.專案序號);
            SetText("BOM編號", h?.BOM編號);
            SetText("圖檔發行日", h?.圖檔發行日);
            SetText("模組編碼", h?.模組編碼);
            SetText("模組名稱", h?.模組名稱);
            SetText("發行人員", h?.發行人員);
            SetText("設計人員", h?.設計人員);
            SetText("製圖檔名", h?.製圖檔名);
            SetText("審查清單編號", h?.審查清單編號);
            SetText("組裝人員", h?.組裝人員);
            SetText("開工日期", h?.開工日期);
            SetText("預交日期", h?.預交日期);
            SetText("完工日期", h?.完工日期);
            SetText("結案回報", h?.結案回報);
            SetText("用途", h?.用途);

            SetFooterText("建檔", h?.建檔);
            SetFooterText("建檔日", h?.建檔日);
            SetFooterText("修改", h?.修改);
            SetFooterText("修改日", h?.修改日);
            SetFooterText("核准", h?.核准);
            SetFooterText("核准日", h?.核准日);
        }

        private void FillDetailGrid(List<專案模組BOM明細> list)
        {
            dataGridView1.Rows.Clear();
            foreach (var x in list)
            {
                int idx = dataGridView1.Rows.Add();
                var row = dataGridView1.Rows[idx];
                row.Cells[colBallNo.Index].Value = x.球號;
                row.Cells[colPartNo.Index].Value = x.零件號碼;
                row.Cells[colPartName.Index].Value = x.品名;
                row.Cells[colDesc.Index].Value = x.描述;
                row.Cells[colQty.Index].Value = x.數量;
                row.Cells[colLastModDate.Index].Value = x.最後修改日期;
                row.Cells[colParentPartNo.Index].Value = x.上一階品號;
                row.Cells[colNoNeedPrep.Index].Value = x.不需備料 ?? false;
                row.Cells[colRemark.Index].Value = x.備註;
                row.Cells[colChecked.Index].Value = x.勾選 ?? false;
            }
        }

        private List<專案模組BOM明細> CollectDetailGrid()
        {
            var list = new List<專案模組BOM明細>();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.IsNewRow) continue;
                string partNo = row.Cells[colPartNo.Index].Value?.ToString();
                if (string.IsNullOrWhiteSpace(partNo)) continue;
                short? ballNo = short.TryParse(row.Cells[colBallNo.Index].Value?.ToString(), out var b) ? b : (short?)null;
                short? qty = short.TryParse(row.Cells[colQty.Index].Value?.ToString(), out var q) ? q : (short?)null;
                list.Add(new 專案模組BOM明細
                {
                    球號 = ballNo,
                    零件號碼 = partNo,
                    品名 = row.Cells[colPartName.Index].Value?.ToString(),
                    描述 = row.Cells[colDesc.Index].Value?.ToString(),
                    數量 = qty,
                    上一階品號 = row.Cells[colParentPartNo.Index].Value?.ToString(),
                    不需備料 = row.Cells[colNoNeedPrep.Index].Value is bool nb && nb,
                    備註 = row.Cells[colRemark.Index].Value?.ToString(),
                    勾選 = row.Cells[colChecked.Index].Value is bool cb && cb,
                });
            }
            return list;
        }

        private void SetText(string key, string value) { if (_fields.TryGetValue(key, out var c) && c is TextBox tb) tb.Text = value ?? ""; }
        private string GetText(string key) => _fields.TryGetValue(key, out var c) && c is TextBox tb ? tb.Text : null;
        private void SetFooterText(string key, string value) { if (_footerFields.TryGetValue(key, out var lbl)) lbl.Text = value ?? ""; }

        // ── 跟其他 Maintain 畫面一致：按「修改」前，除了 修改/關閉/總覽 以外的
        //    按鈕與可編輯欄位/表身明細都是 Disable ─────────────────────────
        private void disableAllControls(bool disable)
        {
            bool enabled = !disable;

            // 專案序號~審查清單編號等識別欄位恆唯讀，僅組裝相關欄位隨編輯模式切換
            string[] editableKeys = { "組裝人員", "開工日期", "預交日期", "完工日期", "結案回報", "用途" };
            foreach (var key in editableKeys)
            {
                if (_fields.TryGetValue(key, out var c) && c is TextBox tb) tb.ReadOnly = disable;
            }

            dataGridView1.ReadOnly = disable;
            dataGridView1.AllowUserToAddRows = enabled;
            dataGridView1.AllowUserToDeleteRows = enabled;

            btnSave.Enabled = enabled;
            btnAddBomItem.Enabled = enabled;

            // btnEdit(修改)/btnClose(關閉)/btnOverview(總覽) 不在此批次控制之列
        }

        private void RefreshButtonStates()
        {
            bool hasHeader = _header != null;
            disableAllControls(!_editing);
            btnEdit.Enabled = hasHeader && !_editing;
            btnSave.Enabled = hasHeader && _editing;
            btnAddBomItem.Enabled = hasHeader && _editing;
        }

        // ── 新增BOM材料明細：於表身加入一筆空白可編輯列 ─────────────────────
        private void btnAddBomItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add();
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

            _header.組裝人員 = GetText("組裝人員");
            _header.開工日期 = GetText("開工日期");
            _header.預交日期 = GetText("預交日期");
            _header.完工日期 = GetText("完工日期");
            _header.結案回報 = GetText("結案回報");
            _header.用途 = GetText("用途");

            var rep = new ProjectProgressController().SaveModuleMaterial(new MES.WebAPI.Models.SaveModuleMaterialReq
            {
                header = _header,
                details = CollectDetailGrid(),
                operatorName = AppSession.User.name,
            });
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }

            MessageBox.Show("已儲存");
            _editing = false;
            LoadData(_header.BOM編號);
        }

        private void btnActivate_Click(object sender, EventArgs e) => MessageBox.Show("此功能尚未開放");
        private void btnDeactivate_Click(object sender, EventArgs e) => MessageBox.Show("此功能尚未開放");

        // ── 總覽：切回(或開啟)審圖總覽頁籤 ─────────────────────────────
        private void btnOverview_Click(object sender, EventArgs e)
        {
            if (!(Parent is TabPage) || !(((TabPage)Parent).Parent is TabControl)) return;
            TabControl tabControl = (TabControl)((TabPage)Parent).Parent;
            const string tabName = "DesignAuditOverview";
            foreach (TabPage page in tabControl.TabPages)
            {
                if (page.Name == tabName)
                {
                    tabControl.SelectedTab = page;
                    return;
                }
            }
            var ctrl = new DesignAuditControl();
            if (ctrl.IsDisposed) return;
            ctrl.Dock = DockStyle.Fill;
            var tab = new TabPage("審圖總覽") { Name = tabName };
            tab.Controls.Add(ctrl);
            tabControl.TabPages.Add(tab);
            tabControl.SelectedTab = tab;
            tabControl.SizeMode = TabSizeMode.Fixed;
            tabControl.ItemSize = new Size(120, 30);
        }

        private void btnClose_Click(object sender, EventArgs e)
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
