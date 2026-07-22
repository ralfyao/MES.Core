using DigiERP.Common;
using DigiERP.Forms.Production;
using DigiERP.Models;
using MES.Core.Model;
using MES.WebAPI.Controllers;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace DigiERP.UserControl.Production
{
    public partial class DesignAuditMaintainControl : CommonUserControl
    {
        private static string id = "3F7C6A18-9E2D-4B6A-8C1F-5D4E9B7A2C63";

        private readonly Dictionary<string, Control> _fields = new Dictionary<string, Control>();
        private 設計派案 _header;
        private bool _isNew;
        private bool _editing;

        public DesignAuditMaintainControl()
        {
            if (!chkPrivilege(id))
            {
                MessageBox.Show("非授權使用者無法使用此功能!");
                Dispose();
                return;
            }
            InitializeComponent();
            BuildHeaderFields();
            LoadStaticLists();
            disableAllControls(true);
        }

        // ── 載入固定清單：審查人員下拉(職務=設計)、審查項目下拉(設計審查項目表) ──
        private void LoadStaticLists()
        {
            var staffRep = new ProjectProgressController().GetDesignStaffList();
            var staffList = staffRep.resultList ?? new List<成本單位人員配置>();
            if (_fields.TryGetValue("審查人員", out var c) && c is ComboBox combo)
            {
                combo.DisplayMember = "姓名";
                combo.ValueMember = "員工編號";
                combo.DataSource = staffList;
                combo.SelectedIndex = -1;
            }

            var itemRep = new ProjectProgressController().GetDesignReviewItemList();
            foreach (var x in itemRep.resultList ?? new List<設計審查項目表>())
            {
                EnsureReviewItemInList(x.審查項目);
            }
        }

        private void EnsureReviewItemInList(string text)
        {
            if (string.IsNullOrEmpty(text)) return;
            if (!colReviewItem.Items.Contains(text)) colReviewItem.Items.Add(text);
        }

        // ── 表頭欄位以資料驅動的方式動態建立(對應設計派案表)，
        //    避免手刻十餘組 Label+TextBox 版面 ─────────────────────────
        private void BuildHeaderFields()
        {
            var rows = new (string Caption, string Key, string Type)[][]
            {
                new (string, string, string)[]
                {
                    ("審查起日", "審查日期", "date"),
                    ("清單編號", "清單編號", "text"),
                    ("設計人員", "設計人員", "text"),
                    ("工程識別碼", "工程表識別碼", "text"),
                },
                new (string, string, string)[]
                {
                    ("專案序號", "專案序號", "text"),
                    ("模組名稱", "模組名稱", "text"),
                    ("審查人員", "審查人員", "combo"),
                    ("同意驗收", "審圖通過", "bool"),
                    ("已發行", "已發行", "bool"),
                },
                new (string, string, string)[]
                {
                    ("模組編碼", "模組編碼", "text"),
                    ("製圖檔名", "製圖檔名", "text"),
                    ("發行人員", "發行人員", "text"),
                    ("發行日期", "圖檔發行日", "text"),
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
                        Size = new Size(80, 24),
                        TextAlign = ContentAlignment.MiddleLeft,
                    };
                    panelHeader.Controls.Add(lbl);

                    Control input;
                    if (type == "bool")
                    {
                        input = new CheckBox { Location = new Point(x + 84, y + 6), Size = new Size(24, 24), Enabled = false };
                        x += 130;
                    }
                    else if (type == "combo")
                    {
                        input = new ComboBox { Location = new Point(x + 84, y + 3), Size = new Size(340, 26), DropDownStyle = ComboBoxStyle.DropDownList, Enabled = false };
                        x += 440;
                    }
                    else
                    {
                        input = new TextBox { Location = new Point(x + 84, y + 3), Size = new Size(340, 26), ReadOnly = true };
                        x += 440;
                    }
                    panelHeader.Controls.Add(input);
                    _fields[key] = input;
                }
                y += 38;
            }
        }

        // ── 新增：開啟空白畫面後立即跳出設計派案挑選視窗，帶入表頭並進入編輯 ──
        internal void LoadNew()
        {
            _header = null;
            _isNew = true;
            _editing = false;
            FillHeader(null);
            FillDetailGrid(new List<設計審查明細>());
            RefreshButtonStates();

            var rep = new ProjectProgressController().GetPendingDesignAssignmentList();
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }
            using var frm = new FrmSelectPendingDesign(rep.resultList ?? new List<設計派案>());
            if (frm.ShowDialog(FindForm()) != DialogResult.OK) return;

            _header = frm.SelectedItem;
            _editing = true;
            FillHeader(_header);
            RefreshButtonStates();
        }

        // ── 從總覽點選清單編號：載入既有的審查清單表頭與明細 ────────────
        internal void LoadData(string listNo)
        {
            var headerRep = new ProjectProgressController().GetDesignAssignmentByListNo(listNo);
            if (!string.IsNullOrEmpty(headerRep.ErrorMessage))
            {
                MessageBox.Show(headerRep.ErrorMessage);
                return;
            }
            _header = headerRep.result;
            _isNew = false;
            _editing = false;
            FillHeader(_header);

            var detailRep = new ProjectProgressController().GetDesignAuditDetailList(listNo);
            if (!string.IsNullOrEmpty(detailRep.ErrorMessage))
            {
                MessageBox.Show(detailRep.ErrorMessage);
                return;
            }
            FillDetailGrid(detailRep.resultList ?? new List<設計審查明細>());
            RefreshButtonStates();
        }

        private void FillHeader(設計派案 h)
        {
            SetText("清單編號", h?.清單編號);
            SetText("專案序號", h?.專案序號);
            SetText("模組編碼", h?.模組編碼);
            SetText("模組名稱", h?.模組名稱);
            SetText("設計人員", h?.設計人員);
            SetText("工程表識別碼", h?.工程表識別碼);
            SetText("製圖檔名", h?.製圖檔名);
            SetText("圖檔發行日", h?.圖檔發行日);
            SetText("審查日期", h?.審查日期);
            SetText("審查人員", h?.審查人員);
            SetBool("審圖通過", h?.審圖通過);
            SetText("發行人員", h?.發行人員);
            SetBool("已發行", h?.已發行);
        }

        private void FillDetailGrid(List<設計審查明細> list)
        {
            dataGridView1.Rows.Clear();
            foreach (var x in list)
            {
                EnsureReviewItemInList(x.審查項目);
                int idx = dataGridView1.Rows.Add();
                var row = dataGridView1.Rows[idx];
                row.Cells[colReviewItem.Index].Value = x.審查項目;
                row.Cells[colFirstReview.Index].Value = x.初審意見;
                row.Cells[colSecondReview.Index].Value = x.複審一意見;
                row.Cells[colThirdReview.Index].Value = x.複審二意見;
                row.Cells[colMatch.Index].Value = x.符合;
            }
        }

        private List<設計審查明細> CollectDetailGrid()
        {
            var list = new List<設計審查明細>();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.IsNewRow) continue;
                string reviewItem = row.Cells[colReviewItem.Index].Value?.ToString();
                if (string.IsNullOrWhiteSpace(reviewItem)) continue;
                list.Add(new 設計審查明細
                {
                    審查項目 = reviewItem,
                    初審意見 = row.Cells[colFirstReview.Index].Value?.ToString(),
                    複審一意見 = row.Cells[colSecondReview.Index].Value?.ToString(),
                    複審二意見 = row.Cells[colThirdReview.Index].Value?.ToString(),
                    符合 = row.Cells[colMatch.Index].Value is bool b && b,
                });
            }
            return list;
        }

        private string GetText(string key)
        {
            if (!_fields.TryGetValue(key, out var c)) return null;
            if (c is TextBox tb) return tb.Text;
            if (c is ComboBox cmb) return cmb.SelectedValue?.ToString();
            return null;
        }
        private void SetText(string key, string value)
        {
            if (!_fields.TryGetValue(key, out var c)) return;
            if (c is TextBox tb) tb.Text = value ?? "";
            else if (c is ComboBox cmb)
            {
                if (!string.IsNullOrEmpty(value))
                    cmb.SelectedValue = value;
            }
        }
        private bool? GetBool(string key) => _fields.TryGetValue(key, out var c) && c is CheckBox cb ? cb.Checked : (bool?)null;
        private void SetBool(string key, bool? value) { if (_fields.TryGetValue(key, out var c) && c is CheckBox cb) cb.Checked = value ?? false; }

        // ── 跟其他 Maintain 畫面一致：按「修改」前，除了 修改/關閉 以外的
        //    按鈕與所有表頭欄位/表身明細都是 Disable，按「修改」後才整批打開 ──
        private void disableAllControls(bool disable)
        {
            bool enabled = !disable;

            foreach (var c in _fields.Values)
            {
                if (c is TextBox tb) tb.ReadOnly = disable;
                else c.Enabled = enabled;
            }

            dataGridView1.ReadOnly = disable;
            dataGridView1.AllowUserToAddRows = enabled;
            dataGridView1.AllowUserToDeleteRows = enabled;

            btnRefresh.Enabled = enabled;
            btnOverview.Enabled = enabled;
            btnSelectItem.Enabled = enabled;
            btnSave.Enabled = enabled;

            // 列印：商業邏輯尚未實作，維持停用
            btnPrint.Enabled = false;

            // btnEdit(修改)/btnClose(關閉) 不在此批次控制之列，各自獨立管理
        }

        // ── 依目前狀態(尚未選取/檢視中/編輯中)刷新按鈕與欄位的可用狀態 ──────
        private void RefreshButtonStates()
        {
            bool hasHeader = _header != null;

            bool canApprove = AppSession.User.name?.ToUpper() == "ADMIN" || AppSession.User.is核准(Guid.Parse(id));

            disableAllControls(!_editing);
            btnEdit.Enabled = hasHeader && !_editing;
            btnSave.Enabled = hasHeader && _editing;
            btnSelectItem.Enabled = hasHeader && _editing;
            btnActivate.Enabled = hasHeader && !string.IsNullOrEmpty(_header?.清單編號) && _header?.審圖通過 != true && canApprove;
            btnDeactivate.Enabled = hasHeader && !string.IsNullOrEmpty(_header?.清單編號) && _header?.審圖通過 == true && canApprove;
            btnDrawingToBom.Enabled = hasHeader && !string.IsNullOrEmpty(_header?.清單編號);
        }

        // ── 選擇審查項目：從設計審查項目主檔勾選制式檢核項目，加入表身明細 ──
        private void btnSelectItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_header?.清單編號))
            {
                MessageBox.Show("請先Keyin審查日期並取得清單編號", "清單編號不得為空白", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (_header?.審圖通過 == true)
            {
                MessageBox.Show("已通過審圖無法修改", "操作異常", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var rep = new ProjectProgressController().GetDesignReviewItemList();
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }
            using var frm = new FrmSelectReviewItem(rep.resultList ?? new List<設計審查項目表>());
            if (frm.ShowDialog(FindForm()) != DialogResult.OK) return;

            foreach (var item in frm.SelectedItems)
            {
                EnsureReviewItemInList(item.審查項目);
                int idx = dataGridView1.Rows.Add();
                dataGridView1.Rows[idx].Cells[colReviewItem.Index].Value = item.審查項目;
            }
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

            _header.審查日期 = GetText("審查日期");
            _header.審查人員 = GetText("審查人員");
            _header.審圖通過 = GetBool("審圖通過");
            _header.已發行 = GetBool("已發行");
            if (((bool)_header.審圖通過))
            {
                _header.審查人員 = AppSession.User.name;
                _header.審查日期 = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                SetText("審查日期", _header.審查人員);
                SetText("審查人員", _header.審查日期);
            }
            else
            {
                SetText("審查日期", string.Empty);
                SetText("審查人員", string.Empty);
            }

            if (((bool)_header.已發行))
            {
                _header.發行人員 = AppSession.User.name;
                _header.圖檔發行日 = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                SetText("發行人員", AppSession.User.name);
                SetText("圖檔發行日", _header.圖檔發行日);
            }
            else
            {
                SetText("審查日期", string.Empty);
                SetText("審查人員", string.Empty);
            }
            var req = new MES.WebAPI.Models.SaveDesignAuditReq
            {
                header = _header,
                details = CollectDetailGrid(),
            };
            var rep = new ProjectProgressController().SaveDesignAudit(req);
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }

            MessageBox.Show("已儲存");
            _isNew = false;
            _editing = false;
            LoadData(rep.result);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            if (_header != null && !string.IsNullOrEmpty(_header.清單編號))
            {
                LoadData(_header.清單編號);
            }
            else
            {
                LoadNew();
            }
        }

        private void btnPrint_Click(object sender, EventArgs e) => MessageBox.Show("此功能尚未開放");

        // ── 圖面發行轉BOM：依序檢查已發行/審圖通過/核准權限，通過後將設計派案
        //    轉為專案模組用料清單表頭，標記已發行，並開啟BOM維護畫面 ──────────
        private void btnDrawingToBom_Click(object sender, EventArgs e)
        {
            if (_header == null || string.IsNullOrEmpty(_header.清單編號)) return;

            if (_header.已發行 == true)
            {
                MessageBox.Show("本項模組圖面已發行，不得重複執行!", "作業管控機制", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (_header.審圖通過 != true)
            {
                MessageBox.Show("本項模組尚未生效，不能發行轉BOM!", "作業管控機制", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool canApprove = AppSession.User.name?.ToUpper() == "ADMIN" || AppSession.User.is核准(Guid.Parse(id));
            if (!canApprove)
            {
                MessageBox.Show("抱歉：非經授權，不得進入!", "權限管理", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var rep = new ProjectProgressController().TransferDrawingToBom(new MES.WebAPI.Models.TransferDrawingToBomReq
            {
                listNo = _header.清單編號,
                operatorName = AppSession.User.name,
            });
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }

            _editing = false;
            LoadData(_header.清單編號);
            OpenModuleMaterialMaintain(rep.result);
        }

        // ── 開啟(或切回)該BOM編號的專案模組用料清單維護頁籤 ─────────────────
        private void OpenModuleMaterialMaintain(string bomNo)
        {
            if (!(Parent is TabPage) || !(((TabPage)Parent).Parent is TabControl)) return;
            TabControl tabControl = (TabControl)((TabPage)Parent).Parent;
            string tabName = "ModuleMaterialMaintain_" + bomNo;
            foreach (TabPage page in tabControl.TabPages)
            {
                if (page.Name == tabName)
                {
                    tabControl.SelectedTab = page;
                    return;
                }
            }
            var ctrl = new ModuleMaterialMaintainControl();
            if (ctrl.IsDisposed) return;
            ctrl.LoadData(bomNo);
            ctrl.Dock = DockStyle.Fill;
            var tab = new TabPage("專案模組用料清單") { Name = tabName };
            tab.Controls.Add(ctrl);
            tabControl.TabPages.Add(tab);
            tabControl.SelectedTab = tab;
            tabControl.SizeMode = TabSizeMode.Fixed;
            tabControl.ItemSize = new Size(120, 30);
        }

        // ── 取消生效：按鈕僅在具備「核准」授權且已生效時才會被啟用，
        //    再次確認後清空審圖通過/發行人員/圖檔發行日 ───────────────────
        private void btnDeactivate_Click(object sender, EventArgs e)
        {
            if (_header == null || string.IsNullOrEmpty(_header.清單編號)) return;

            var confirm = MessageBox.Show("圖面如已發行轉BOM，您確定仍要取消生效", "請選擇", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes) return;

            var rep = new ProjectProgressController().DeactivateDesignAudit(new MES.WebAPI.Models.ActivateDesignAuditReq
            {
                listNo = _header.清單編號,
            });
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }

            _editing = false;
            LoadData(_header.清單編號);
        }

        // ── 生效：按鈕僅在具備本表單「核准」授權時才會被啟用(見 RefreshButtonStates)，
        //    設定審圖通過/發行人員/圖檔發行日 ─────────────────────────────
        private void btnActivate_Click(object sender, EventArgs e)
        {
            if (_header == null || string.IsNullOrEmpty(_header.清單編號)) return;

            var rep = new ProjectProgressController().ActivateDesignAudit(new MES.WebAPI.Models.ActivateDesignAuditReq
            {
                listNo = _header.清單編號,
                issuer = AppSession.User.name,
            });
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }

            _editing = false;
            LoadData(_header.清單編號);
        }

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
