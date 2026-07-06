using MES.Core.Model;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace DigiERP.Forms.Supplier
{
    public partial class FrmPrintPurchaseRFQ : Form
    {
        // ── 資料直接取自呼叫端目前畫面上的內容（含尚未儲存的新列），
        //    不重新查詢資料庫，避免新增未儲存時列印出空白內容 ──────────────
        public FrmPrintPurchaseRFQ(B廠商設定 supplier, B廠商供料 quote, string itemNo, string itemSpec)
        {
            InitializeComponent();
            PopulateData(supplier, quote, itemNo, itemSpec);
        }

        private void PopulateData(B廠商設定 supplier, B廠商供料 quote, string itemNo, string itemSpec)
        {
            lblSupplierNo.Text = supplier?.廠商編號 ?? "";
            lblSupplierName.Text = supplier?.廠商名稱 ?? "";
            lblTaxId.Text = supplier?.統一編號 ?? "";
            lblFax.Text = supplier?.傳真 ?? "";
            lblContact.Text = supplier?.聯絡人 ?? "";
            lblPhone.Text = supplier?.電話 ?? "";
            lblInquiryDate.Text = quote?.詢價日期 ?? "";
            lblInquiryPerson.Text = quote?.詢價人員 ?? "";
            lblSupplierPartNo.Text = quote?.廠商品號 ?? "";
            lblMinQty.Text = quote?.最低採購量?.ToString("0.00") ?? "";
            lblValidDate.Text = quote?.報價有效日期 ?? "";

            dgvItems.Rows.Clear();
            int idx = dgvItems.Rows.Add();
            var row = dgvItems.Rows[idx];
            row.Cells[colProductNo.Index].Value = itemNo;
            row.Cells[colSpec.Index].Value = itemSpec;
            row.Cells[colQty.Index].Value = quote?.最低採購量?.ToString("0.00") ?? "";
            row.Cells[colUnit.Index].Value = quote?.採購單位 ?? "";
            row.Cells[colUnitPrice.Index].Value = (quote?.單價 ?? 0) > 0 ? quote.單價.ToString() : "";
            row.Cells[colCurrency.Index].Value = quote?.幣別 ?? "";
            row.Cells[colAmount.Index].Value = (quote?.最低採購量 > 0 && quote?.單價 > 0)
                ? (quote.最低採購量 * quote.單價).ToString()
                : "";
        }

        // ── 將整張表單截圖轉成 PDF，供使用者另存 ─────────────────────────
        private void btnPreviewPrint_Click(object sender, EventArgs e)
        {
            btnPreviewPrint.Visible = false;
            btnPreviewPrint.Text = "";
            //btnExit.Text = "";

            Bitmap bmp = new Bitmap(ClientSize.Width, ClientSize.Height);
            DrawToBitmap(bmp, new Rectangle(0, 0, ClientSize.Width, ClientSize.Height));

            PdfDocument doc = new PdfDocument();
            PdfPage page = doc.AddPage();
            // 依畫面實際寬高比例設定頁面尺寸，避免預設 A4 直向頁面把寬版表單擠壓變窄
            page.Width = XUnit.FromPoint(bmp.Width);
            page.Height = XUnit.FromPoint(bmp.Height);
            using (XGraphics gfx = XGraphics.FromPdfPage(page))
            using (MemoryStream ms = new MemoryStream())
            {
                bmp.Save(ms, ImageFormat.Png);
                ms.Position = 0;
                XImage img = XImage.FromStream(ms);
                gfx.DrawImage(img, 0, 0, page.Width, page.Height);
            }

            btnPreviewPrint.Text = "預覽列印";
            //btnExit.Text = "EXIT";

            string fileName = $"詢價單{DateTime.Now:yyyyMMddHHmmssfff}.pdf";
            doc.Save(fileName);
            byte[] pdfBytes = File.ReadAllBytes(fileName);
            using SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "PDF Files (*.pdf)|*.pdf";
            sfd.FileName = fileName;
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllBytes(sfd.FileName, pdfBytes);
                MessageBox.Show("PDF已儲存");
            }

            btnPreviewPrint.Visible = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmPrintPurchaseRFQ_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("您是否要關閉視窗?", "確認", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Dispose();
                Close();
            }
        }

        private void panelContent_Click(object sender, EventArgs e)
        {
            FrmPrintPurchaseRFQ_Click(null, null);
        }
    }
}
