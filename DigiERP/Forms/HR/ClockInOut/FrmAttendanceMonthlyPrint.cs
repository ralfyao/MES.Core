using MES.Core.Model;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace DigiERP.Forms.HR.ClockInOut
{
    // ── 員工月出勤明細表列印預覽：比照 PITS-2025.accdb 之報表「員工月出勤明細表」
    //    (表頭 EMPL 查詢 + 子報表 Report.考勤記錄查詢，與 AttendanceCheckControl
    //    的表身資料來源相同)，依查詢起訖日的天數自動分頁 ─────────────────────
    public partial class FrmAttendanceMonthlyPrint : Form
    {
        private const int PageWidth = 1500;
        private const int PageHeight = 1000;
        private const int RowsPerPage = 15;

        public string EmpNo { get; set; }
        public string Name { get; set; }
        public string HRNo { get; set; }
        public string CardNo { get; set; }
        public string Dept { get; set; }
        public string JobTitle { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public List<考勤核對列表> Records { get; set; } = new List<考勤核對列表>();

        private readonly List<Panel> _pages = new List<Panel>();

        public FrmAttendanceMonthlyPrint()
        {
            InitializeComponent();
        }

        private void FrmAttendanceMonthlyPrint_Load(object sender, EventArgs e)
        {
            BuildPages();
            LayoutPages();

            // ── DataGridView 一旦真正建立控制代碼(加入可視畫面後)，就會自動把
            //    目前儲存格重設回(0,0)並用選取色畫出來；BeginInvoke 延到該次
            //    版面配置/顯示流程結束後，才能真正把選取狀態清掉 ──────────────
            BeginInvoke(new Action(ClearAllGridSelections));
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

        private Panel CreatePage(int pageNo, int totalPages)
        {
            var pnl = new Panel
            {
                Size = new Size(PageWidth, PageHeight),
                BackColor = Color.White,
                BorderStyle = BorderStyle.FixedSingle,
            };
            var lblPageNo = new Label
            {
                Text = $"第{pageNo}頁，共{totalPages}頁",
                AutoSize = false,
                Size = new Size(200, 24),
                TextAlign = ContentAlignment.MiddleRight,
                Anchor = AnchorStyles.Bottom | AnchorStyles.Right,
                Location = new Point(PageWidth - 216, PageHeight - 28),
            };
            pnl.Controls.Add(lblPageNo);
            _pages.Add(pnl);
            return pnl;
        }

        private void BuildPages()
        {
            var records = Records ?? new List<考勤核對列表>();
            var chunks = records
                .Select((x, i) => new { x, i })
                .GroupBy(p => p.i / RowsPerPage)
                .Select(g => g.Select(p => p.x).ToList())
                .ToList();
            if (chunks.Count == 0) chunks.Add(new List<考勤核對列表>());

            int total = chunks.Count;
            for (int i = 0; i < total; i++)
            {
                BuildPage(i + 1, total, chunks[i]);
            }
        }

        private void BuildPage(int pageNo, int totalPages, List<考勤核對列表> rows)
        {
            var pnl = CreatePage(pageNo, totalPages);

            var lblTitle = new Label
            {
                Text = "員工月出勤明細表",
                Font = new Font("標楷體", 16F, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter,
                Location = new Point(16, 16),
                Size = new Size(PageWidth - 32, 36),
            };
            pnl.Controls.Add(lblTitle);

            int y = 60;
            y = AddFieldRow(pnl, y,
                ("員工編號", EmpNo, 200), ("姓名", Name, 200), ("人事編號", HRNo, 200), ("卡號", CardNo, 200));
            y = AddFieldRow(pnl, y,
                ("部門", Dept, 300), ("職稱", JobTitle, 300),
                ("起日", StartDate, 200), ("迄日", EndDate, 200));

            y += 8;
            var grid = new DataGridView
            {
                Location = new Point(16, y),
                Size = new Size(PageWidth - 32, PageHeight - y - 140),
                AllowUserToAddRows = false,
                AllowUserToDeleteRows = false,
                ReadOnly = true,
                RowHeadersVisible = false,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None,
                ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize,
                SelectionMode = DataGridViewSelectionMode.FullRowSelect,
                BackgroundColor = Color.White,
                Font = new Font("微軟正黑體", 8.5F),
            };
            grid.RowTemplate.Height = 22;

            AddCol(grid, "日期", 90);
            AddCol(grid, "週", 32);
            AddCol(grid, "例假", 38);
            AddCol(grid, "班次", 55);
            AddCol(grid, "正規上班", 65);
            AddCol(grid, "正規下班", 65);
            AddCol(grid, "加班上班", 65);
            AddCol(grid, "加班下班", 65);
            AddCol(grid, "出勤時數", 60);
            AddCol(grid, "請休時數", 60);
            AddCol(grid, "遲到分", 50);
            AddCol(grid, "早退分", 50);
            AddCol(grid, "加班時數", 55);
            AddCol(grid, "忘卡", 38);
            AddCol(grid, "假別", 55);
            AddCol(grid, "備註", 200);

            string[] weekdayNames = { "日", "一", "二", "三", "四", "五", "六" };
            foreach (var x in rows)
            {
                int i = grid.Rows.Add();
                var row = grid.Rows[i];
                int c = 0;
                row.Cells[c++].Value = x.日期;
                row.Cells[c++].Value = DateTime.TryParse(x.日期, out var d) ? weekdayNames[(int)d.DayOfWeek] : "";
                row.Cells[c++].Value = (x.例假日 ?? false) ? "V" : "";
                row.Cells[c++].Value = x.班次;
                row.Cells[c++].Value = x.正規上班;
                row.Cells[c++].Value = x.正規下班;
                row.Cells[c++].Value = x.加班上班;
                row.Cells[c++].Value = x.加班下班;
                row.Cells[c++].Value = x.出勤時數;
                row.Cells[c++].Value = x.請休時數;
                row.Cells[c++].Value = x.遲到分鐘數;
                row.Cells[c++].Value = x.早退分鐘數;
                row.Cells[c++].Value = x.核准時數;
                row.Cells[c++].Value = x.忘卡;
                row.Cells[c++].Value = x.假別;
                row.Cells[c++].Value = x.備註;
            }
            pnl.Controls.Add(grid);

            // ── 頁尾區段：列印時間 + 承認/查閱/核對/本人確認 簽核欄，每頁皆顯示
            //    (比照原 Access 報表 頁尾區段 為 Page Footer，每頁重複列印) ────────
            int fy = PageHeight - 120;
            var lblPrintTime = new Label
            {
                Text = $"列印時間：{DateTime.Now:yyyy/MM/dd HH:mm}",
                Location = new Point(16, fy),
                Size = new Size(300, 24),
            };
            pnl.Controls.Add(lblPrintTime);

            int sx = 16, sw = (PageWidth - 32) / 4;
            AddSignatureBox(pnl, "承認:", sx, fy + 30, sw);
            AddSignatureBox(pnl, "查閱:", sx + sw, fy + 30, sw);
            AddSignatureBox(pnl, "核對:", sx + sw * 2, fy + 30, sw);
            AddSignatureBox(pnl, "本人確認:", sx + sw * 3, fy + 30, sw);
        }

        private void AddCol(DataGridView grid, string header, int width)
        {
            grid.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = header, Width = width, ReadOnly = true });
        }

        private int AddFieldRow(Panel pnl, int y, params (string Label, string Value, int Width)[] fields)
        {
            int x = 16;
            const int rowH = 32;
            foreach (var (label, value, width) in fields)
            {
                var lbl = new Label
                {
                    Text = label,
                    Location = new Point(x, y),
                    AutoSize = false,
                    Size = new Size(70, 22),
                    Font = new Font(Font, FontStyle.Bold),
                };
                pnl.Controls.Add(lbl);
                var box = new Label
                {
                    Text = value,
                    BorderStyle = BorderStyle.FixedSingle,
                    Location = new Point(x + 72, y - 2),
                    Size = new Size(width - 72, 24),
                    TextAlign = ContentAlignment.MiddleLeft,
                };
                pnl.Controls.Add(box);
                x += width + 10;
            }
            return y + rowH;
        }

        private void AddSignatureBox(Panel pnl, string label, int x, int y, int width)
        {
            var lbl = new Label
            {
                Text = label,
                Location = new Point(x, y),
                AutoSize = false,
                Size = new Size(width - 10, 22),
            };
            pnl.Controls.Add(lbl);
            var box = new Label
            {
                BorderStyle = BorderStyle.FixedSingle,
                Location = new Point(x, y + 24),
                Size = new Size(width - 10, 50),
            };
            pnl.Controls.Add(box);
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

        private IEnumerable<DataGridView> FindGrids(Control root)
        {
            foreach (Control c in root.Controls)
            {
                if (c is DataGridView dgv) yield return dgv;
            }
        }

        private void ClearGridSelection(DataGridView grid)
        {
            grid.ClearSelection();
            grid.CurrentCell = null;
        }

        // ── 產生 PDF：每頁各自截圖後插入對應的 PdfPage ───────────────────────
        private void btnPrint_Click(object sender, EventArgs e)
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

            string fileName = $"員工月出勤明細表_{EmpNo}_{DateTime.Now:yyyyMMddHHmmss}.pdf";
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
