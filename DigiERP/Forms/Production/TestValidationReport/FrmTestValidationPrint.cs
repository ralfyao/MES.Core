using MES.Core.Model;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace DigiERP.Forms.Production.TestValidationReport
{
    // ── 賣方廠驗收單列印預覽：畫面內容/資料來源與維護頁籤一致，共固定 3 頁 ────────
    public partial class FrmTestValidationPrint : Form
    {
        private const int PageWidth = 900;
        private const int PageHeight = 1240;
        private const int TotalPages = 3;

        public 試機驗收單 Header { get; set; }
        public List<專案焊接測試數據> WeldTestList { get; set; } = new List<專案焊接測試數據>();
        public List<專案改正措施內容> CorrectiveList { get; set; } = new List<專案改正措施內容>();

        private readonly List<Panel> _pages = new List<Panel>();

        // ── TEST AND TRIAL PARAMETERS 焊接測試數據 A01~A16 對應的實際欄位名稱 ──────
        private static readonly string[] WeldTestColumnCaptions =
        {
            "Motor Speed", "Weld P\nkgf/cm²", "Clamp P", "SQZ",
            "Weld KA1", "Weld Time1", "Cool Time1",
            "Weld KA2", "Weld Time2", "Cool Time2",
            "Weld KA3", "Weld Time3", "Hold Time",
            "Pri.kA", "Sec.kA", "Peel Test",
        };

        public FrmTestValidationPrint()
        {
            InitializeComponent();
        }

        private void FrmTestValidationPrint_Load(object sender, EventArgs e)
        {
            BuildPage1();
            BuildPage2();
            BuildPage3();
            LayoutPages();

            // ── DataGridView 一旦真正建立控制代碼(加入可視畫面後)，就會自動把
            //    目前儲存格重設回(0,0)並用選取色畫出來；BeginInvoke 延到該次
            //    版面配置/顯示流程結束後，才能真正把選取狀態清掉 ──────────────
            BeginInvoke(new Action(ClearAllGridSelections));
        }

        private void ClearAllGridSelections()
        {
            foreach (var pnl in _pages)
            {
                foreach (var grid in FindGrids(pnl))
                {
                    ClearGridSelection(grid);
                }
            }
        }

        private System.Collections.Generic.IEnumerable<DataGridView> FindGrids(Control root)
        {
            foreach (Control c in root.Controls)
            {
                if (c is DataGridView dgv) yield return dgv;
            }
        }

        private Panel CreatePage(int pageNo)
        {
            var pnl = new Panel
            {
                Size = new Size(PageWidth, PageHeight),
                BackColor = Color.White,
                BorderStyle = BorderStyle.FixedSingle,
            };
            var lblPageNo = new Label
            {
                Text = $"第{pageNo}頁，共{TotalPages}頁",
                AutoSize = false,
                Size = new Size(160, 24),
                TextAlign = ContentAlignment.MiddleRight,
                Anchor = AnchorStyles.Bottom | AnchorStyles.Right,
                Location = new Point(PageWidth - 168, PageHeight - 28),
            };
            pnl.Controls.Add(lblPageNo);
            _pages.Add(pnl);
            return pnl;
        }

        private void LayoutPages()
        {
            int y = 20;
            foreach (var pnl in _pages)
            {
                pnl.Location = new Point((panelScroll.ClientSize.Width - PageWidth) / 2 < 0 ? 20 : (panelScroll.ClientSize.Width - PageWidth) / 2, y);
                panelScroll.Controls.Add(pnl);
                y += PageHeight + 20;
            }
        }

        // ── 第 1 頁：表頭 + 機台驗收規範(6列) + Welding Result / Machine Spec ────────
        private void BuildPage1()
        {
            var h = Header ?? new 試機驗收單();
            var pnl = CreatePage(1);

            var picLogo = new PictureBox
            {
                Location = new Point(16, 16),
                Size = new Size(280, 90),
                SizeMode = PictureBoxSizeMode.Zoom,
                BorderStyle = BorderStyle.None,
            };
            string logoPath = Path.Combine(Application.StartupPath, "Resources", "LOGO.png");
            if (File.Exists(logoPath)) picLogo.Image = Image.FromFile(logoPath);
            pnl.Controls.Add(picLogo);

            var lblTitle = new Label
            {
                Text = "SELLER SITE ACCEPTANCE\nTEST REPORT\n賣方廠驗收單",
                Font = new Font(Font.FontFamily, 13F, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter,
                Location = new Point(300, 16),
                Size = new Size(400, 70),
            };
            pnl.Controls.Add(lblTitle);

            AddStaticBox(pnl, "M1103", 720, 16, 160, 24);
            AddStaticBox(pnl, "Ver.4(161211)", 720, 44, 160, 24);

            int y = 116;
            y = AddFieldRow(pnl, y, ("Company客戶名稱", h.客戶名稱, 300), ("Date日期", h.日期, 200));
            y = AddFieldRow(pnl, y, ("Cont. Person聯絡人", h.聯絡人, 300), ("Tel電話", h.電話, 200));
            y = AddFieldRow(pnl, y, ("Serial No.專案序號", h.專案序號, 220), ("Model機台型號", h.機台型號, 260));
            y = AddFieldRow(pnl, y, ("Machine機台名稱", h.機台名稱, 800));
            y = AddFieldRow(pnl, y,
                ("Power電源", string.Join(" ", h.焊接電壓v, h.焊接電壓hz, h.焊接電壓).Trim(), 300),
                ("Weld Ctrl控制器型號", h.控制器型號, 300));
            y = AddFieldRow(pnl, y, ("Insp. Start開始", h.開始, 300), ("Insp. Finish結束", h.結束, 300));

            y += 8;
            var specTable = new DataGridView
            {
                Location = new Point(16, y),
                Size = new Size(860, 220),
                ReadOnly = true,
                AllowUserToAddRows = false,
                AllowUserToDeleteRows = false,
                RowHeadersVisible = false,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
            };
            specTable.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Requirement 要求", Name = "colReq" });
            specTable.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Specification 內容", Name = "colSpec", FillWeight = 200 });
            specTable.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Result 結果", Name = "colResult", FillWeight = 150 });
            specTable.Columns.Add(new DataGridViewCheckBoxColumn { HeaderText = "Cfm", Name = "colCfm", AutoSizeMode = DataGridViewAutoSizeColumnMode.None, Width = 50 });

            string[] reqItems = { h.驗收規範項目1, h.驗收規範項目2, h.驗收規範項目3, h.驗收規範項目4, h.驗收規範項目5, h.驗收規範項目6 };
            string[] specDescs = { h.驗收規範說明1, h.驗收規範說明2, h.驗收規範說明3, h.驗收規範說明4, h.驗收規範說明5, h.驗收規範說明6 };
            string[] results = { h.S1, h.S2, h.S3, h.S4, h.S5, h.S6 };
            bool?[] cfm = { h.規範確認1, h.規範確認2, h.規範確認3, h.規範確認4, h.規範確認5, h.規範確認6 };
            for (int i = 0; i < 6; i++)
            {
                specTable.Rows.Add(reqItems[i], specDescs[i], results[i], cfm[i] ?? false);
            }
            ClearGridSelection(specTable);
            pnl.Controls.Add(specTable);
            y += specTable.Height + 8;

            var weldTable = new DataGridView
            {
                Location = new Point(16, y),
                Size = new Size(860, 140),
                ReadOnly = true,
                AllowUserToAddRows = false,
                AllowUserToDeleteRows = false,
                RowHeadersVisible = false,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
            };
            weldTable.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Machine Spec 機台驗收規範", Name = "colGroup" });
            weldTable.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Specification 內容", Name = "colSpec2", FillWeight = 200 });
            weldTable.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Result 結果", Name = "colResult2", FillWeight = 150 });
            weldTable.Columns.Add(new DataGridViewCheckBoxColumn { HeaderText = "Cfm", Name = "colCfm2", AutoSizeMode = DataGridViewAutoSizeColumnMode.None, Width = 50 });
            weldTable.Rows.Add("強度 Weld Strength", "Peel test", h.強度, true);
            weldTable.Rows.Add("尺寸 Dimension", "Not applicable", h.尺寸, true);
            weldTable.Rows.Add("外觀 Appearance", "Visual", h.外觀, true);
            weldTable.Rows.Add("生產力 Productive", "生產時間 Cycle Time", h.生產速率, true);
            ClearGridSelection(weldTable);
            pnl.Controls.Add(weldTable);
        }

        // ── 第 2 頁：焊接測試數據 + Running Test + Description + 改正措施內容 ──────
        private void BuildPage2()
        {
            var h = Header ?? new 試機驗收單();
            var pnl = CreatePage(2);

            var lblTitle1 = new Label
            {
                Text = "TEST AND TRIAL PARAMETERS 焊接測試數據",
                BackColor = Color.Gainsboro,
                Font = new Font(Font, FontStyle.Bold),
                Location = new Point(16, 16),
                Size = new Size(860, 24),
                TextAlign = ContentAlignment.MiddleLeft,
            };
            pnl.Controls.Add(lblTitle1);

            var weldGrid = new DataGridView
            {
                Location = new Point(16, 44),
                Size = new Size(860, 140),
                ReadOnly = true,
                AllowUserToAddRows = false,
                AllowUserToDeleteRows = false,
                RowHeadersVisible = false,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None,
            };
            weldGrid.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Model", Name = "colModel", Width = 60 });
            foreach (var caption in WeldTestColumnCaptions)
            {
                weldGrid.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = caption, Width = 50 });
            }
            foreach (var x in WeldTestList)
            {
                weldGrid.Rows.Add(x.Model, x.A01, x.A02, x.A03, x.A04, x.A05, x.A06, x.A07, x.A08, x.A09, x.A10, x.A11, x.A12, x.A13, x.A14, x.A15, x.A16);
            }
            ClearGridSelection(weldGrid);
            pnl.Controls.Add(weldGrid);

            int y = 200;
            var lblRunning = new Label
            {
                Text = "Running Test 實際測試",
                Font = new Font(Font, FontStyle.Bold),
                Location = new Point(16, y),
                AutoSize = true,
            };
            pnl.Controls.Add(lblRunning);
            y += 28;
            y = AddFieldRow(pnl, y, ("Model型號1", h.實測型號1, 220), ("Qty.數量1", h.實測數量1?.ToString(), 150), ("Time時間1", h.實測時間1?.ToString(), 150));
            y = AddFieldRow(pnl, y, ("Model型號2", h.實測型號2, 220), ("Qty.數量2", h.實測數量2?.ToString(), 150), ("Time時間2", h.實測時間2?.ToString(), 150));
            y = AddFieldRow(pnl, y, ("Model型號3", h.實測型號3, 220), ("Qty.數量3", h.實測數量3?.ToString(), 150), ("Time時間3", h.實測時間3?.ToString(), 150));

            y += 8;
            y = AddTextAreaRow(pnl, y, "Description and Result 驗收內容說明及結果", h.內容說明結果);
            y = AddTextAreaRow(pnl, y, "內容說明結果1", h.內容說明結果1);

            y += 8;
            var lblTitle2 = new Label
            {
                Text = "Corrective Action Report 改正措施內容",
                BackColor = Color.Gainsboro,
                Font = new Font(Font, FontStyle.Bold),
                Location = new Point(16, y),
                Size = new Size(860, 24),
                TextAlign = ContentAlignment.MiddleLeft,
            };
            pnl.Controls.Add(lblTitle2);
            y += 28;

            var correctiveGrid = new DataGridView
            {
                Location = new Point(16, y),
                Size = new Size(860, 160),
                ReadOnly = true,
                AllowUserToAddRows = false,
                AllowUserToDeleteRows = false,
                RowHeadersVisible = false,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
            };
            correctiveGrid.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "S/N", Name = "colSN", AutoSizeMode = DataGridViewAutoSizeColumnMode.None, Width = 40 });
            correctiveGrid.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "事項 Agenda", Name = "colAgenda", FillWeight = 150 });
            correctiveGrid.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "照片 Ref", Name = "colPhotoRef" });
            correctiveGrid.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "說明 Description", Name = "colDesc", FillWeight = 200 });
            correctiveGrid.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "人員 PIC", Name = "colPIC" });
            correctiveGrid.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "日期 Date", Name = "colDate" });
            int sn = 1;
            foreach (var x in CorrectiveList)
            {
                correctiveGrid.Rows.Add(sn++, x.事項Agenda, x.照片Ref, x.說明Description, x.人員PIC, x.日期Date);
            }
            ClearGridSelection(correctiveGrid);
            pnl.Controls.Add(correctiveGrid);
        }

        // ── 第 3 頁：Buyer/Dahching Representative + 驗收證明文字 + 頁尾 ────────────
        private void BuildPage3()
        {
            var h = Header ?? new 試機驗收單();
            var pnl = CreatePage(3);

            int y = 16;
            y = AddFieldRow(pnl, y, ("Buyer Representative", h.Buyer, 400), ("Dahching Representative", h.Dahching, 400));

            y += 16;
            var lblCert = new Label
            {
                Text = $"This is to certify that machine model  {h.機台型號}  , serial No.  {h.專案序號}  has passed the " +
                       "Factory Acceptance Test in Dahching Electric Industrial Co., Ltd and approved to ship after " +
                       "completing above mentioned correction report.",
                Location = new Point(16, y),
                Size = new Size(860, 80),
                AutoSize = false,
            };
            pnl.Controls.Add(lblCert);
            y += 88;

            string weekday = DateTime.TryParse(h.結關日期, out var closeDate) ? closeDate.ToString("dddd") : "";
            var lblEta = new Label
            {
                Text = $"The estimated delivery / cut off date on {weekday} {h.結關日期}",
                Location = new Point(16, y),
                Size = new Size(860, 24),
                AutoSize = false,
            };
            pnl.Controls.Add(lblEta);
            y += 32;

            y = AddFieldRow(pnl, y, ("Buyer", h.客戶名稱, 500));
            y += 40;

            var lblSig = new Label
            {
                Text = "Authorized Signature",
                Location = new Point(600, y),
                AutoSize = true,
                TextAlign = ContentAlignment.MiddleLeft,
            };
            pnl.Controls.Add(lblSig);

            var lblNow = new Label
            {
                Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm"),
                AutoSize = false,
                Size = new Size(200, 24),
                Anchor = AnchorStyles.Bottom | AnchorStyles.Left,
                Location = new Point(16, PageHeight - 28),
            };
            pnl.Controls.Add(lblNow);
        }

        // ── 共用小工具：一列多個「標題+內容」欄位 ───────────────────────
        private int AddFieldRow(Panel pnl, int y, params (string Caption, string Value, int Width)[] fields)
        {
            int x = 16;
            foreach (var (caption, value, width) in fields)
            {
                var lbl = new Label
                {
                    Text = caption,
                    BackColor = Color.Gainsboro,
                    Location = new Point(x, y),
                    Size = new Size(120, 24),
                    TextAlign = ContentAlignment.MiddleLeft,
                };
                pnl.Controls.Add(lbl);

                var box = new Label
                {
                    Text = value ?? "",
                    BorderStyle = BorderStyle.FixedSingle,
                    Location = new Point(x + 122, y),
                    Size = new Size(width - 122, 24),
                    TextAlign = ContentAlignment.MiddleLeft,
                };
                pnl.Controls.Add(box);
                x += width + 8;
            }
            return y + 28;
        }

        private int AddTextAreaRow(Panel pnl, int y, string caption, string value)
        {
            var lbl = new Label
            {
                Text = caption,
                Font = new Font(Font, FontStyle.Bold),
                Location = new Point(16, y),
                AutoSize = true,
            };
            pnl.Controls.Add(lbl);
            y += 24;

            var box = new Label
            {
                Text = value ?? "",
                BorderStyle = BorderStyle.FixedSingle,
                Location = new Point(16, y),
                Size = new Size(860, 48),
                TextAlign = ContentAlignment.TopLeft,
            };
            pnl.Controls.Add(box);
            return y + 56;
        }

        // ── 純顯示用Grid：清除目前選取儲存格，避免第一格被選取藍底蓋住文字 ────────
        private void ClearGridSelection(DataGridView grid)
        {
            grid.ClearSelection();
            grid.CurrentCell = null;
        }

        private void AddStaticBox(Panel pnl, string text, int x, int y, int w, int h)
        {
            var box = new Label
            {
                Text = text,
                BorderStyle = BorderStyle.FixedSingle,
                Location = new Point(x, y),
                Size = new Size(w, h),
                TextAlign = ContentAlignment.MiddleCenter,
            };
            pnl.Controls.Add(box);
        }

        // ── 產生 PDF：每頁各自截圖後插入對應的 PdfPage，右下角頁碼已內建於畫面上 ──
        private void btnPreviewPrint_Click(object sender, EventArgs e)
        {
            ClearAllGridSelections();

            var doc = new PdfDocument();
            foreach (var pnl in _pages)
            {
                var bmp = new Bitmap(pnl.Width, pnl.Height);
                pnl.DrawToBitmap(bmp, new Rectangle(0, 0, pnl.Width, pnl.Height));

                using var ms = new MemoryStream();
                bmp.Save(ms, ImageFormat.Png);
                ms.Position = 0;

                var page = doc.AddPage();
                page.Width = XUnit.FromPoint(pnl.Width);
                page.Height = XUnit.FromPoint(pnl.Height);
                using var gfx = XGraphics.FromPdfPage(page);
                var img = XImage.FromStream(ms);
                gfx.DrawImage(img, 0, 0, page.Width, page.Height);
            }

            string fileName = $"賣方廠驗收單_{Header?.專案序號}_{DateTime.Now:yyyyMMddHHmmss}.pdf";
            using var sfd = new SaveFileDialog { Filter = "PDF Files (*.pdf)|*.pdf", FileName = fileName };
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                doc.Save(sfd.FileName);
                MessageBox.Show("PDF已產生");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
