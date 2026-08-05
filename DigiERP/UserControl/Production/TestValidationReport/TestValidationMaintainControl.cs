using DigiERP.Common;
using DigiERP.Models;
using MES.Core.Model;
using MES.WebAPI.Controllers;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace DigiERP.UserControl.Production.TestValidationReport
{
    // ── 賣方廠驗收單：由「試機驗收單總覽」點選專案序號開啟；表頭取自
    //    賣方廠驗收單 RIGHT JOIN 工令單/產品規格單；機台驗收規範為固定 10 列，
    //    「TEST AND TRIAL PARAMETERS 焊接測試數據」「Corrective Action Report
    //    改正措施內容」兩個明細畫面先行建置，資料來源日後再串接 ────────────
    public partial class TestValidationMaintainControl : CommonUserControl
    {
        private static string id = "4A6B7C8D-1E2F-4A3B-9C5D-6E7F8A9B0C1D";

        private readonly Dictionary<string, TextBox> _fields = new Dictionary<string, TextBox>();
        private readonly Dictionary<string, DateTimePicker> _dateFields = new Dictionary<string, DateTimePicker>();
        private readonly Dictionary<string, Label> _footerFields = new Dictionary<string, Label>();

        // ── 結關日期/開始/結束改為 DateTimePicker，而非一般文字欄位 ────────────
        private static readonly HashSet<string> _dateKeys = new HashSet<string> { "結關日期", "開始", "結束" };
        private 試機驗收單 _header;
        private bool _editing;
        private string _projectNo;

        // ── 機台驗收規範固定 10 列：Specification 內容依畫面上的 DLookUp 對應
        //    (第 1-6 列對應驗收規範說明1-6；第 7-10 列對應驗收規範項目3-6) ────
        private DataGridView dataGridViewSpec;
        private DataGridViewTextBoxColumn colReqLabel;
        private DataGridViewTextBoxColumn colSpec;
        private DataGridViewTextBoxColumn colResult;
        private DataGridViewCheckBoxColumn colOK;

        private DataGridView dataGridViewWeldTest;
        private DataGridView dataGridViewCorrective;
        private DataGridViewComboBoxColumn colPIC;
        private List<account> _picStaffList = new List<account>();

        // ── 列印用：與頁籤畫面共用同一份已載入資料(不重新查詢) ────────────────
        private List<專案焊接測試數據> _weldTestList = new List<專案焊接測試數據>();
        private List<專案改正措施內容> _correctiveList = new List<專案改正措施內容>();

        public TestValidationMaintainControl()
        {
            if (!chkPrivilege(id))
            {
                MessageBox.Show("非授權使用者無法使用此功能!");
                Dispose();
                return;
            }
            InitializeComponent();
            initPICStaffList();
            BuildHeaderFields();
            BuildSpecGrid();
            BuildWeldTestPlaceholder();
            BuildRunningTestFields();
            BuildDescriptionFields();
            BuildCorrectivePlaceholder();
            BuildFooterFields();
            disableAllControls(true);
        }

        // ── 改正措施內容「人員 PIC」下拉：來源為未停用的 account ────────────
        private void initPICStaffList()
        {
            var rep = new ProjectProgressController().GetPICStaffList();
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }
            _picStaffList = rep.resultList ?? new List<account>();
        }

        // ── 表頭：專案序號/廠驗日期/客戶名稱(DLookup)/機台型號(DLookup)/聯絡人/電話/
        //    結關日期/機台名稱(DLookup)/控制器型號/焊接電壓(DLookup組合)/檢查開始/結束 ──
        private void BuildHeaderFields()
        {
            var rows = new (string Caption, string Key, bool ReadOnly)[][]
            {
                new (string, string, bool)[]
                {
                    ("專案序號", "專案序號", true),
                    ("廠驗日期", "日期", false),
                    ("客戶名稱", "客戶名稱", true),
                },
                new (string, string, bool)[]
                {
                    ("機台型號", "機台型號", true),
                    ("聯絡人", "聯絡人", false),
                    ("電話", "電話", false),
                    ("結關日期", "結關日期", false),
                },
                new (string, string, bool)[]
                {
                    ("機台名稱", "機台名稱", true),
                    ("控制器型號", "控制器型號", false),
                },
                new (string, string, bool)[]
                {
                    ("焊接電壓", "焊接電壓組合", true),
                    ("檢查開始", "開始", false),
                    ("結束", "結束", false),
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
                    panelScroll.Controls.Add(lbl);

                    if (_dateKeys.Contains(key))
                    {
                        var dtp = new DateTimePicker
                        {
                            Location = new Point(x + 84, y + 3),
                            Size = new Size(260, 26),
                            Format = DateTimePickerFormat.Custom,
                            CustomFormat = "yyyy/MM/dd",
                            Enabled = false,
                        };
                        panelScroll.Controls.Add(dtp);
                        _dateFields[key] = dtp;
                    }
                    else
                    {
                        var input = new TextBox
                        {
                            Location = new Point(x + 84, y + 3),
                            Size = new Size(260, 26),
                            ReadOnly = true,
                        };
                        panelScroll.Controls.Add(input);
                        _fields[key] = input;
                    }
                    x += 350;
                }
                y += 32;
            }
        }

        // ── 機台驗收規範：固定 10 列 ─────────────────────────────
        private void BuildSpecGrid()
        {
            var lblTitle = new Label
            {
                Text = "Requirement 要求 / Specification 內容 / Result 結果 / OK",
                Location = new Point(8, 144),
                AutoSize = false,
                Size = new Size(1880, 24),
                BackColor = Color.Gainsboro,
                Font = new Font(Font, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleLeft,
            };
            panelScroll.Controls.Add(lblTitle);

            dataGridViewSpec = new DataGridView
            {
                Location = new Point(8, 172),
                Size = new Size(1880, 300),
                AllowUserToAddRows = false,
                AllowUserToDeleteRows = false,
                RowHeadersVisible = false,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                SelectionMode = DataGridViewSelectionMode.FullRowSelect,
                BackgroundColor = Color.White,
            };
            colReqLabel = new DataGridViewTextBoxColumn { HeaderText = "Requirement 要求", Name = "colReqLabel", ReadOnly = true };
            colSpec = new DataGridViewTextBoxColumn { HeaderText = "Specification 內容", Name = "colSpec", ReadOnly = true, FillWeight = 260 };
            colResult = new DataGridViewTextBoxColumn { HeaderText = "Result 結果", Name = "colResult", FillWeight = 260 };
            colOK = new DataGridViewCheckBoxColumn
            {
                HeaderText = "OK",
                Name = "colOK",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.None,
                Width = 60,
                MinimumWidth = 60,
                Resizable = DataGridViewTriState.False,
            };
            dataGridViewSpec.Columns.AddRange(colReqLabel, colSpec, colResult, colOK);
            dataGridViewSpec.DataError += (s, e) => e.ThrowException = false;
            panelScroll.Controls.Add(dataGridViewSpec);

            for (int i = 1; i <= 10; i++)
            {
                dataGridViewSpec.Rows.Add("機台驗收規範-" + i, "", "", false);
            }
        }

        // ── TEST AND TRIAL PARAMETERS 焊接測試數據：資料來源為 專案焊接測試數據，
        //    依專案序號查詢(目前僅顯示，尚未開放編輯/儲存) ────────────────
        private void BuildWeldTestPlaceholder()
        {
            var lblTitle = new Label
            {
                Text = "TEST AND TRIAL PARAMETERS 焊接測試數據",
                Location = new Point(8, 484),
                AutoSize = false,
                Size = new Size(1880, 24),
                BackColor = Color.Gainsboro,
                Font = new Font(Font, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleLeft,
            };
            panelScroll.Controls.Add(lblTitle);

            dataGridViewWeldTest = new DataGridView
            {
                Location = new Point(8, 512),
                Size = new Size(1880, 160),
                AllowUserToAddRows = false,
                AllowUserToDeleteRows = false,
                RowHeadersVisible = false,
                ReadOnly = true,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None,
                BackgroundColor = Color.White,
            };
            dataGridViewWeldTest.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Model", Name = "colWeldModel", Width = 100 });
            for (int i = 1; i <= 24; i++)
            {
                string colName = "A" + i.ToString("00");
                dataGridViewWeldTest.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = colName, Name = "col" + colName, Width = 70 });
            }
            panelScroll.Controls.Add(dataGridViewWeldTest);
        }

        // ── 焊接測試數據：資料來源為 專案焊接測試數據，依專案序號查詢 ─────────
        private void FillWeldTestGrid(string projectNo)
        {
            dataGridViewWeldTest.Rows.Clear();

            var rep = new ProjectProgressController().GetWeldTestDataList(projectNo);
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }

            _weldTestList = rep.resultList ?? new List<專案焊接測試數據>();
            foreach (var x in _weldTestList)
            {
                dataGridViewWeldTest.Rows.Add(
                    x.Model, x.A01, x.A02, x.A03, x.A04, x.A05, x.A06, x.A07, x.A08, x.A09, x.A10,
                    x.A11, x.A12, x.A13, x.A14, x.A15, x.A16, x.A17, x.A18, x.A19, x.A20,
                    x.A21, x.A22, x.A23, x.A24);
            }
        }

        // ── Running Test 實際測試：Model型號1-3/Qty.數量1-3/Time時間1-3 ──────
        private void BuildRunningTestFields()
        {
            var lblTitle = new Label
            {
                Text = "Running Test 實際測試",
                Location = new Point(8, 684),
                AutoSize = false,
                Size = new Size(200, 90),
                Font = new Font(Font, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleLeft,
            };
            panelScroll.Controls.Add(lblTitle);

            var rows = new (string ModelCaption, string ModelKey, string QtyCaption, string QtyKey, string TimeCaption, string TimeKey)[]
            {
                ("Model型號1", "實測型號1", "Qty.數量1", "實測數量1", "Time時間1", "實測時間1"),
                ("Model型號2", "實測型號2", "Qty.數量2", "實測數量2", "Time時間2", "實測時間2"),
                ("Model型號3", "實測型號3", "Qty.數量3", "實測數量3", "Time時間3", "實測時間3"),
            };

            int y = 684;
            foreach (var (modelCap, modelKey, qtyCap, qtyKey, timeCap, timeKey) in rows)
            {
                AddInlineField(modelCap, modelKey, 216, y, 130, 220);
                AddInlineField(qtyCap, qtyKey, 576, y, 100, 150);
                AddInlineField(timeCap, timeKey, 936, y, 100, 150);
                y += 30;
            }
        }

        private void AddInlineField(string caption, string key, int x, int y, int lblWidth, int inputWidth)
        {
            var lbl = new Label
            {
                Text = caption,
                Location = new Point(x, y + 3),
                AutoSize = false,
                Size = new Size(lblWidth, 24),
                TextAlign = ContentAlignment.MiddleLeft,
            };
            panelScroll.Controls.Add(lbl);

            var input = new TextBox
            {
                Location = new Point(x + lblWidth + 4, y),
                Size = new Size(inputWidth, 26),
                ReadOnly = true,
            };
            panelScroll.Controls.Add(input);
            _fields[key] = input;
        }

        // ── Description and Result 驗收內容說明及結果(內容說明結果)、
        //    內容說明結果1(第二段說明) ───────────────────────────────
        private void BuildDescriptionFields()
        {
            var lbl1 = new Label
            {
                Text = "Description and Result 驗收內容說明及結果",
                Location = new Point(8, 780),
                AutoSize = false,
                Size = new Size(400, 24),
                Font = new Font(Font, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleLeft,
            };
            panelScroll.Controls.Add(lbl1);

            var input1 = new TextBox
            {
                Location = new Point(8, 808),
                Size = new Size(1880, 80),
                Multiline = true,
                ScrollBars = ScrollBars.Vertical,
                ReadOnly = true,
            };
            panelScroll.Controls.Add(input1);
            _fields["內容說明結果"] = input1;

            var lbl2 = new Label
            {
                Text = "內容說明結果1",
                Location = new Point(8, 896),
                AutoSize = false,
                Size = new Size(400, 24),
                Font = new Font(Font, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleLeft,
            };
            panelScroll.Controls.Add(lbl2);

            var input2 = new TextBox
            {
                Location = new Point(8, 924),
                Size = new Size(1880, 80),
                Multiline = true,
                ScrollBars = ScrollBars.Vertical,
                ReadOnly = true,
            };
            panelScroll.Controls.Add(input2);
            _fields["內容說明結果1"] = input2;
        }

        // ── Corrective Action Report 改正措施內容：資料來源為 專案改正措施內容，
        //    依專案序號查詢(目前僅顯示，尚未開放編輯/儲存) ────────────────
        private void BuildCorrectivePlaceholder()
        {
            var lblTitle = new Label
            {
                Text = "Corrective Action Report 改正措施內容",
                Location = new Point(8, 1012),
                AutoSize = false,
                Size = new Size(1880, 24),
                BackColor = Color.Gainsboro,
                Font = new Font(Font, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleLeft,
            };
            panelScroll.Controls.Add(lblTitle);

            dataGridViewCorrective = new DataGridView
            {
                Location = new Point(8, 1040),
                Size = new Size(1880, 160),
                AllowUserToAddRows = true,
                AllowUserToDeleteRows = false,
                RowHeadersVisible = false,
                ReadOnly = true,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                BackgroundColor = Color.White,
            };
            dataGridViewCorrective.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "事項 Agenda", Name = "colAgenda" });
            dataGridViewCorrective.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "事項(中文轉譯)", Name = "colAgendaCN", FillWeight = 150 });
            dataGridViewCorrective.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "照片 Ref", Name = "colPhotoRef" });
            dataGridViewCorrective.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "說明 Description", Name = "colDesc", FillWeight = 150 });
            dataGridViewCorrective.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "說明(中文轉譯)", Name = "colDescCN", FillWeight = 150 });
            colPIC = new DataGridViewComboBoxColumn { HeaderText = "人員 PIC", Name = "colPIC" };
            colPIC.Items.Add("");
            foreach (var name in _picStaffList.Select(a => a.姓名).Where(n => !string.IsNullOrEmpty(n)).Distinct())
            {
                colPIC.Items.Add(name);
            }
            dataGridViewCorrective.Columns.Add(colPIC);
            dataGridViewCorrective.Columns.Add(new DigiERP.Common.DataGridViewDateTimePickerColumn { HeaderText = "日期 Date", Name = "colDate" });
            dataGridViewCorrective.DataError += (s, e) => e.ThrowException = false;
            panelScroll.Controls.Add(dataGridViewCorrective);
        }

        // ── Corrective Action Report 改正措施內容：資料來源為 專案改正措施內容 ────
        private void FillCorrectiveGrid(string projectNo)
        {
            dataGridViewCorrective.Rows.Clear();

            var rep = new ProjectProgressController().GetCorrectiveActionList(projectNo);
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }

            _correctiveList = rep.resultList ?? new List<專案改正措施內容>();
            foreach (var x in _correctiveList)
            {
                string pic = (x.人員PIC ?? "").Trim();
                if (!string.IsNullOrEmpty(pic) && !colPIC.Items.Contains(pic)) colPIC.Items.Add(pic);
                int i = dataGridViewCorrective.Rows.Add(x.事項Agenda, x.事項中文轉譯, x.照片Ref, x.說明Description, x.說明中文轉譯, pic, x.日期Date);
                dataGridViewCorrective.Rows[i].Tag = x.識別碼;
            }
        }

        // ── 改正措施內容：允許使用者自行新增列，識別碼來自載入時存於 Tag 的值(0=新增) ──
        private List<專案改正措施內容> CollectCorrectiveGrid()
        {
            var list = new List<專案改正措施內容>();
            foreach (DataGridViewRow row in dataGridViewCorrective.Rows)
            {
                if (row.IsNewRow) continue;
                int id = row.Tag is int tagId ? tagId : 0;
                list.Add(new 專案改正措施內容
                {
                    識別碼 = id,
                    專案序號 = _projectNo,
                    事項Agenda = row.Cells["colAgenda"].Value as string,
                    事項中文轉譯 = row.Cells["colAgendaCN"].Value as string,
                    照片Ref = row.Cells["colPhotoRef"].Value as string,
                    說明Description = row.Cells["colDesc"].Value as string,
                    說明中文轉譯 = row.Cells["colDescCN"].Value as string,
                    人員PIC = row.Cells["colPIC"].Value as string,
                    日期Date = row.Cells["colDate"].Value as string,
                });
            }
            return list;
        }

        // ── 表單尾：核准/核准日/修改/修改日/建檔/建檔日，僅顯示不可編輯 ─────────
        private void BuildFooterFields()
        {
            var cols = new (string Caption, string Key)[]
            {
                ("核准人員", "核准"),
                ("核准日", "核准日"),
                ("修改人員", "修改"),
                ("修改日", "修改日"),
                ("建檔人員", "建檔"),
                ("建檔日", "建檔日"),
            };

            int y = 1212;
            int x = 8;
            foreach (var (caption, key) in cols)
            {
                var lbl = new Label
                {
                    Text = caption,
                    Location = new Point(x, y),
                    AutoSize = false,
                    Size = new Size(70, 20),
                    TextAlign = ContentAlignment.MiddleLeft,
                    ForeColor = Color.DimGray,
                };
                panelScroll.Controls.Add(lbl);

                var val = new Label
                {
                    Location = new Point(x + 74, y),
                    AutoSize = false,
                    Size = new Size(180, 20),
                    TextAlign = ContentAlignment.MiddleLeft,
                    BorderStyle = BorderStyle.FixedSingle,
                };
                panelScroll.Controls.Add(val);
                _footerFields[key] = val;
                x += 264;
            }
        }

        // ── 由「試機驗收單總覽」點選專案序號開啟：載入表頭+機台驗收規範資料 ──────
        internal void LoadData(string projectNo)
        {
            _projectNo = projectNo;
            var rep = new ProjectProgressController().GetTestValidationReportByProjectNo(projectNo);
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }

            _header = rep.result ?? new 試機驗收單 { 專案序號 = projectNo, 日期 = DateTime.Now.ToString("yyyy/MM/dd") };
            FillFields(_header);
            FillWeldTestGrid(projectNo);
            FillCorrectiveGrid(projectNo);
            SetProjectNoEditable(false);
            _editing = false;
            RefreshButtonStates();
        }

        // ── 由「試機驗收單總覽」按 ADD 開啟：全新空白單，專案序號需由使用者輸入 ──
        internal void LoadBlank()
        {
            _projectNo = null;
            _header = new 試機驗收單 { 日期 = DateTime.Now.ToString("yyyy/MM/dd") };
            FillFields(_header);
            dataGridViewWeldTest.Rows.Clear();
            dataGridViewCorrective.Rows.Clear();
            _weldTestList = new List<專案焊接測試數據>();
            _correctiveList = new List<專案改正措施內容>();
            SetProjectNoEditable(true);
            _editing = true;
            RefreshButtonStates();
        }

        private void SetProjectNoEditable(bool editable)
        {
            if (_fields.TryGetValue("專案序號", out var tb)) tb.ReadOnly = !editable;
        }

        private void FillFields(試機驗收單 h)
        {
            SetText("專案序號", h?.專案序號);
            SetText("日期", h?.日期);
            SetText("客戶名稱", h?.客戶名稱);
            SetText("機台型號", h?.機台型號);
            SetText("聯絡人", h?.聯絡人);
            SetText("電話", h?.電話);
            SetDate("結關日期", h?.結關日期);
            SetText("機台名稱", h?.機台名稱);
            SetText("控制器型號", h?.控制器型號);
            SetText("焊接電壓組合", string.Join(" ", new[] { h?.焊接電壓v, h?.焊接電壓hz, h?.焊接電壓 }).Trim());
            SetDate("開始", h?.開始);
            SetDate("結束", h?.結束);

            SetText("實測型號1", h?.實測型號1);
            SetText("實測數量1", h?.實測數量1?.ToString());
            SetText("實測時間1", h?.實測時間1?.ToString());
            SetText("實測型號2", h?.實測型號2);
            SetText("實測數量2", h?.實測數量2?.ToString());
            SetText("實測時間2", h?.實測時間2?.ToString());
            SetText("實測型號3", h?.實測型號3);
            SetText("實測數量3", h?.實測數量3?.ToString());
            SetText("實測時間3", h?.實測時間3?.ToString());

            SetText("內容說明結果", h?.內容說明結果);
            SetText("內容說明結果1", h?.內容說明結果1);

            SetFooterText("核准", h?.核准);
            SetFooterText("核准日", h?.核准日);
            SetFooterText("修改", h?.修改);
            SetFooterText("修改日", h?.修改日);
            SetFooterText("建檔", h?.建檔);
            SetFooterText("建檔日", h?.建檔日);

            FillSpecGrid(h);
        }

        // ── 機台驗收規範 10 列：第1-6列對應驗收規範說明1-6；第7-10列對應驗收規範項目3-6
        //    (畫面上原始 DLookUp 公式即為此對應，非我方臆測) ────────────────
        private void FillSpecGrid(試機驗收單 h)
        {
            string[] specs = h == null ? new string[10] : new[]
            {
                h.驗收規範說明1, h.驗收規範說明2, h.驗收規範說明3, h.驗收規範說明4, h.驗收規範說明5, h.驗收規範說明6,
                h.驗收規範項目3, h.驗收規範項目4, h.驗收規範項目5, h.驗收規範項目6,
            };
            string[] results = h == null ? new string[10] : new[] { h.S1, h.S2, h.S3, h.S4, h.S5, h.S6, h.S7, h.S8, h.S9, h.S10 };
            bool?[] oks = h == null ? new bool?[10] : new[]
            {
                h.規範確認1, h.規範確認2, h.規範確認3, h.規範確認4, h.規範確認5,
                h.規範確認6, h.規範確認7, h.規範確認8, h.規範確認9, h.規範確認10,
            };

            for (int i = 0; i < 10; i++)
            {
                var row = dataGridViewSpec.Rows[i];
                row.Cells[colSpec.Index].Value = specs[i];
                row.Cells[colResult.Index].Value = results[i];
                row.Cells[colOK.Index].Value = oks[i] ?? false;
            }
        }

        private void SetText(string key, string value)
        {
            if (_fields.TryGetValue(key, out var tb)) tb.Text = value ?? "";
        }

        private string GetText(string key) => _fields.TryGetValue(key, out var tb) ? tb.Text : null;

        private void SetDate(string key, string value)
        {
            if (!_dateFields.TryGetValue(key, out var dtp)) return;
            dtp.Value = DateTime.TryParse(value, out var dt) ? dt : DateTime.Now;
        }

        private string GetDateText(string key) => _dateFields.TryGetValue(key, out var dtp) ? dtp.Value.ToString("yyyy/MM/dd") : null;

        private void SetFooterText(string key, string value)
        {
            if (_footerFields.TryGetValue(key, out var lbl)) lbl.Text = value ?? "";
        }

        // ── 開啟畫面預設鎖定；專案序號/客戶名稱/機台型號/機台名稱/焊接電壓(DLookup)
        //    恆唯讀；其餘欄位隨 disable 狀態切換 ─────────────────────────
        private void disableAllControls(bool disable)
        {
            string[] editableKeys =
            {
                "日期", "聯絡人", "電話", "控制器型號",
                "實測型號1", "實測數量1", "實測時間1",
                "實測型號2", "實測數量2", "實測時間2",
                "實測型號3", "實測數量3", "實測時間3",
                "內容說明結果", "內容說明結果1",
            };
            foreach (var key in editableKeys)
            {
                if (_fields.TryGetValue(key, out var tb)) tb.ReadOnly = disable;
            }
            foreach (var dtp in _dateFields.Values)
            {
                dtp.Enabled = !disable;
            }
            dataGridViewSpec.ReadOnly = disable;
            dataGridViewCorrective.ReadOnly = disable;
        }

        private void RefreshButtonStates()
        {
            disableAllControls(!_editing);
            btnSave.Enabled = _editing;
        }

        // ── 已覆核(核准/核准日尚未清空)的紀錄需先按「取消覆核」才能修改 ─────────
        private void btnModify_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(_header?.核准) || !string.IsNullOrEmpty(_header?.核准日))
            {
                MessageBox.Show("請先取消覆核");
                return;
            }
            _editing = true;
            RefreshButtonStates();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_header == null) return;

            string projectNo = GetText("專案序號");
            if (string.IsNullOrEmpty(projectNo))
            {
                MessageBox.Show("請先輸入專案序號");
                return;
            }
            _header.專案序號 = projectNo;
            _projectNo = projectNo;
            _header.日期 = GetText("日期");
            _header.聯絡人 = GetText("聯絡人");
            _header.電話 = GetText("電話");
            _header.結關日期 = GetDateText("結關日期");
            _header.控制器型號 = GetText("控制器型號");
            _header.開始 = GetDateText("開始");
            _header.結束 = GetDateText("結束");
            _header.實測型號1 = GetText("實測型號1");
            _header.實測數量1 = int.TryParse(GetText("實測數量1"), out var q1) ? q1 : (int?)null;
            _header.實測時間1 = int.TryParse(GetText("實測時間1"), out var t1) ? t1 : (int?)null;
            _header.實測型號2 = GetText("實測型號2");
            _header.實測數量2 = int.TryParse(GetText("實測數量2"), out var q2) ? q2 : (int?)null;
            _header.實測時間2 = int.TryParse(GetText("實測時間2"), out var t2) ? t2 : (int?)null;
            _header.實測型號3 = GetText("實測型號3");
            _header.實測數量3 = int.TryParse(GetText("實測數量3"), out var q3) ? q3 : (int?)null;
            _header.實測時間3 = int.TryParse(GetText("實測時間3"), out var t3) ? t3 : (int?)null;
            _header.內容說明結果 = GetText("內容說明結果");
            _header.內容說明結果1 = GetText("內容說明結果1");

            var results = new string[10];
            var oks = new bool?[10];
            for (int i = 0; i < 10; i++)
            {
                var row = dataGridViewSpec.Rows[i];
                results[i] = row.Cells[colResult.Index].Value as string;
                oks[i] = row.Cells[colOK.Index].Value is bool b && b;
            }
            _header.S1 = results[0]; _header.S2 = results[1]; _header.S3 = results[2]; _header.S4 = results[3]; _header.S5 = results[4];
            _header.S6 = results[5]; _header.S7 = results[6]; _header.S8 = results[7]; _header.S9 = results[8]; _header.S10 = results[9];
            _header.規範確認1 = oks[0]; _header.規範確認2 = oks[1]; _header.規範確認3 = oks[2]; _header.規範確認4 = oks[3]; _header.規範確認5 = oks[4];
            _header.規範確認6 = oks[5]; _header.規範確認7 = oks[6]; _header.規範確認8 = oks[7]; _header.規範確認9 = oks[8]; _header.規範確認10 = oks[9];

            bool isNew = string.IsNullOrEmpty(_header.建檔);
            if (isNew)
            {
                _header.建檔 = AppSession.User?.username;
                _header.建檔日 = DateTime.Now.ToString("yyyy/MM/dd");
            }
            _header.修改 = AppSession.User?.username;
            _header.修改日 = DateTime.Now.ToString("yyyy/MM/dd");

            var rep = new ProjectProgressController().SaveTestValidationReport(_header);
            if (!string.IsNullOrEmpty(rep.ErrorMessage))
            {
                MessageBox.Show(rep.ErrorMessage);
                return;
            }

            var correctiveList = CollectCorrectiveGrid();
            if (correctiveList.Count > 0)
            {
                var correctiveRep = new ProjectProgressController().SaveCorrectiveActionList(correctiveList);
                if (!string.IsNullOrEmpty(correctiveRep.ErrorMessage))
                {
                    MessageBox.Show(correctiveRep.ErrorMessage);
                    return;
                }
            }

            MessageBox.Show("儲存成功!");
            _editing = false;
            LoadData(_projectNo);
        }

        // ── 覆核：寫入核准/核准日 ──────────────────────────────────
        private void btnApprove_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_projectNo)) return;
            var rep = new ProjectProgressController().ValidateTestValidationReport(_projectNo, true, AppSession.User?.username);
            if (!string.IsNullOrEmpty(rep.ErrorMessage)) { MessageBox.Show(rep.ErrorMessage); return; }
            MessageBox.Show("覆核成功!");
            LoadData(_projectNo);
        }

        // ── 取消覆核：清空核准/核准日 ────────────────────────────────
        private void btnCancelApprove_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_projectNo)) return;
            var rep = new ProjectProgressController().ValidateTestValidationReport(_projectNo, false, AppSession.User?.username);
            if (!string.IsNullOrEmpty(rep.ErrorMessage)) { MessageBox.Show(rep.ErrorMessage); return; }
            MessageBox.Show("取消覆核成功!");
            LoadData(_projectNo);
        }

        // ── 覆核完成(核准/核准日已有值)才能列印；列印前先跳出焊接測試數據登錄視窗，
        //    確定後存檔並帶到列印表單上顯示 ─────────────────────────────
        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_header?.核准) || string.IsNullOrEmpty(_header?.核准日))
            {
                MessageBox.Show("請先完成覆核才能列印");
                return;
            }

            var existing = _weldTestList.Count > 0 ? _weldTestList[0] : null;
            using var entryFrm = new DigiERP.Forms.Production.TestValidationReport.FrmWeldTestDataEntry(_projectNo, existing);
            if (entryFrm.ShowDialog(FindForm()) != DialogResult.OK) return;

            var saveRep = new ProjectProgressController().SaveWeldTestData(entryFrm.Result);
            if (!string.IsNullOrEmpty(saveRep.ErrorMessage))
            {
                MessageBox.Show(saveRep.ErrorMessage);
                return;
            }

            FillWeldTestGrid(_projectNo);

            var frm = new DigiERP.Forms.Production.TestValidationReport.FrmTestValidationPrint
            {
                Header = _header,
                WeldTestList = _weldTestList,
                CorrectiveList = _correctiveList,
            };
            frm.Show();
        }

        // ── 開啟(或切換至)試機驗收單總覽頁籤 ───────────────────────────
        private void btnOverview_Click(object sender, EventArgs e)
        {
            if (!(Parent is TabPage) || !(((TabPage)Parent).Parent is TabControl)) return;
            TabControl tabControl = (TabControl)((TabPage)Parent).Parent;
            const string tabName = "TestValidationReportOverview";
            foreach (TabPage page in tabControl.TabPages)
            {
                if (page.Name == tabName)
                {
                    tabControl.SelectedTab = page;
                    return;
                }
            }
            var ctrl = new TestValidationReportControl { Dock = DockStyle.Fill };
            var tab = new TabPage("試機驗收單總覽") { Name = tabName };
            tab.Controls.Add(ctrl);
            tabControl.TabPages.Add(tab);
            tabControl.SelectedTab = tab;
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
