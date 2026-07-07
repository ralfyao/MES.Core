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

namespace DigiERP.Forms.Supplier
{
    public partial class FrmPrintPurchaseOrder : Form
    {
        // ── 資料直接取自呼叫端目前畫面上的內容，不重新查詢資料庫 ─────────────
        public FrmPrintPurchaseOrder(B採購單 form, B廠商設定 supplier, string purchaserName)
        {
            InitializeComponent();
            PopulateData(form, supplier, purchaserName);
        }

        private void PopulateData(B採購單 form, B廠商設定 supplier, string purchaserName)
        {
            lblSupplierName.Text = supplier?.廠商名稱 ?? "";
            lblTaxId.Text = supplier?.統一編號 ?? "";
            lblFax.Text = supplier?.傳真 ?? "";
            lblContact.Text = supplier?.聯絡人 ?? "";
            lblPhone.Text = supplier?.電話 ?? "";
            lblSupplierNo.Text = form?.廠商編號 ?? "";
            lblOrderDate.Text = form?.日期 ?? "";
            lblCurrency.Text = form?.幣別 ?? "";
            lblOrderNo.Text = form?.單號 ?? "";
            lblDeliveryAddr.Text = form?.送貨地址 ?? "";
            lblDeliveryDate.Text = form?.交貨日期 ?? "";
            lblNote.Text = form?.注意事項 ?? "";
            lblApprover.Text = form?.核准 ?? "";
            lblHandler.Text = purchaserName ?? "";

            var list = form?.procurementList ?? new List<B採購明細>();
            dgvItems.Rows.Clear();
            double sumUntaxed = 0;
            int seq = 1;
            foreach (var item in list)
            {
                int idx = dgvItems.Rows.Add();
                var row = dgvItems.Rows[idx];
                row.Cells[colSeq.Index].Value = seq++;
                row.Cells[colProductNo.Index].Value = item.品項編號;
                row.Cells[colSpec.Index].Value = item.品名規格;
                row.Cells[colQty.Index].Value = item.數量?.ToString("0.00");
                row.Cells[colUnit.Index].Value = "";
                row.Cells[colUnitPrice.Index].Value = item.單價?.ToString("0.0");
                row.Cells[colAmount.Index].Value = item.未稅金額?.ToString("0");
                row.Cells[colNote.Index].Value = item.備註;
                row.Cells[colProject.Index].Value = item.專案序號;
                sumUntaxed += item.未稅金額 ?? 0;
            }

            double taxRate = form?.營業稅率 ?? 0;
            double tax = sumUntaxed * taxRate;
            lblSumUntaxed.Text = sumUntaxed.ToString("0");
            lblTax.Text = tax.ToString("0");
            lblGrandTotal.Text = (sumUntaxed + tax).ToString("0");
        }

        // ── 將整張表單截圖轉成 PDF，供使用者另存 ─────────────────────────
        private void btnPreviewPrint_Click(object sender, EventArgs e)
        {
            btnPreviewPrint.Visible = false;
            //btnExit.Visible = false;

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

            btnPreviewPrint.Visible = true;
            //btnExit.Visible = true;

            string fileName = $"採購單{DateTime.Now:yyyyMMddHHmmssfff}.pdf";
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
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void panelContent_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("請問是否要關閉視窗?", "確認", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Dispose();
                Close();
            }
        }
    }
}
