using MES.Core.Model;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System.Drawing.Imaging;

namespace DigiERP.Forms.Customer.EQPShipping
{
    public partial class FrmEQPShippingPrint : Form
    {
        public 專案機台交貨單 DeliveryOrder { get; set; } = new 專案機台交貨單();
        public string Consignee { get; set; } = "";

        public FrmEQPShippingPrint()
        {
            InitializeComponent();
        }

        private void FrmEQPShippingPrint_Load(object sender, EventArgs e)
        {
            //string logoPath = Path.Combine(Application.StartupPath, "Resources", "logo-en.png");
            //if (File.Exists(logoPath))
            //    picLogo.Image = Image.FromFile(logoPath);

            initData();
        }

        public void initData()
        {
            var d = DeliveryOrder;
            if (d == null) return;

            txtDate.Text = d.日期 ?? "";
            txtDONo.Text = d.單號 ?? "";
            txtSerialNo.Text = d.專案序號 ?? "";
            txtConsignee.Text = Consignee;
            txtPostalAdd.Text = d.單據地址 ?? "";
            txtDeliveryAdd.Text = d.交貨地址 ?? "";
            txtAttn.Text = d.聯絡人 ?? "";
            txtTel.Text = d.電話 ?? "";
            txtPONumber.Text = d.訂購單號 ?? "";
            txtPINumber.Text = d.發票單號 ?? "";
            txtContainer.Text = d.Container ?? "";
            txtContainerType.Text = d.ContainerType ?? "";
            txtDeliveryTerm.Text = d.Trade ?? "";
            txtContainerPort.Text = d.ContainerPort ?? "";
            txtDestPort.Text = d.DestinationPort ?? "";
            txtInsurance.Text = d.Insurance ?? "";
            txtPacking.Text = d.Packing ?? "";
            txtETD.Text = d.ETD ?? "";
            txtETA.Text = d.ETA ?? "";
            txtCutOff.Text = d.CustomsClose ?? "";
            txtCertOfOrigin.Text = d.CertOfOrigin ?? "";
            txtTypesOfBL.Text = d.TypesOfBL ?? "";
            txtSurrenderBL.Text = d.SurrenderBL ?? "";
            txtForwarder.Text = d.Forwarder ?? "";
            txtShipName.Text = d.Ship ?? "";
            txtDoc.Text = d.Doc ?? "";
            txtVoyage.Text = d.Voyage ?? "";
            // Mark field: stored as "comboValue|textValue"
            txtMark.Text = (d.Mark ?? "").Replace("|", " ");
            txtTotal.Text = d.Total ?? "";
            txtPackingRight.Text = d.Packing ?? "";
            txtCaseNo.Text = d.CaseNo ?? "";

            initGrid();
            buildShippingMark();
        }

        private void initGrid()
        {
            var d = DeliveryOrder;
            decimal totalAmount = 0m, totalNW = 0m, totalGW = 0m;
            string cy2 = "";
            int rowNo = 1;
            dgvItems.Rows.Clear();
            foreach (var item in d.專案機台裝箱明細 ?? new List<專案機台裝箱明細>())
            {
                int idx = dgvItems.Rows.Add();
                var row = dgvItems.Rows[idx];
                row.Cells[colNo.Index].Value = rowNo++;
                row.Cells[colDesc.Index].Value = item.Description;
                row.Cells[colQTY.Index].Value = item.QTY?.ToString("N0");
                row.Cells[colUnit.Index].Value = item.Unit;
                row.Cells[colCy1.Index].Value = item.Dollar1;
                row.Cells[colUnitPrice.Index].Value = item.UnitPrice?.ToString("N2");
                row.Cells[colCy2.Index].Value = item.Dollar2;
                row.Cells[colAmount.Index].Value = item.Amount?.ToString("N2");
                row.Cells[colNW.Index].Value = item.NWkgs?.ToString("N3");
                row.Cells[colGW.Index].Value = item.GWkgs?.ToString("N3");
                row.Cells[colDim.Index].Value = item.Dimensioncm;
                row.Cells[colHS.Index].Value = item.HSCode;
                totalAmount += item.Amount ?? 0m;
                totalNW += item.NWkgs ?? 0m;
                totalGW += item.GWkgs ?? 0m;
                if (!string.IsNullOrEmpty(item.Dollar2)) cy2 = item.Dollar2;
            }
            txtTotalAmount.Text = $"{cy2} {totalAmount:N2}".Trim();
            txtTotalNW.Text = totalNW.ToString("N3");
            txtTotalGW.Text = totalGW.ToString("N3");
        }

        private void buildShippingMark()
        {
            var d = DeliveryOrder;
            string mark = (d.Mark ?? "").Replace("|", "\r\n");
            string destPort = d.DestinationPort ?? "";
            string caseNo = d.CaseNo ?? "";
            txtShipMarkContent.Text =
                $"{mark}\r\n\r\n{destPort}\r\nNo. / {caseNo}\r\nMADE IN TAIWAN";
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            string origText = btnPrint.Text;
            btnPrint.Text = "";
            Application.DoEvents();

            Bitmap bmp = new Bitmap(ClientSize.Width, ClientSize.Height);
            DrawToBitmap(bmp, new Rectangle(0, 0, ClientSize.Width, ClientSize.Height));

            using MemoryStream ms = new MemoryStream();
            bmp.Save(ms, ImageFormat.Png);
            ms.Position = 0;

            PdfDocument doc = new PdfDocument();
            PdfPage page = doc.AddPage();
            page.Orientation = PdfSharp.PageOrientation.Portrait;

            using (XGraphics gfx = XGraphics.FromPdfPage(page))
            {
                ms.Position = 0;
                XImage img = XImage.FromStream(ms);
                gfx.DrawImage(img, 0, 0, page.Width, page.Height);
            }

            string fileName = $"DeliveryOrder{DateTime.Now:yyyyMMddHHmmssfff}.pdf";
            doc.Save(fileName);

            using SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "PDF Files (*.pdf)|*.pdf";
            sfd.FileName = fileName;
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllBytes(sfd.FileName, File.ReadAllBytes(fileName));
                MessageBox.Show("PDF已儲存");
            }

            btnPrint.Text = origText;
        }

        private void btnPreviewPrint_Click(object sender, EventArgs e)
        {
            btnPreviewPrint.Text = "";
            //throw new NotImplementedException();

            Bitmap bmp = new Bitmap(this.ClientSize.Width, this.ClientSize.Height);
            this.DrawToBitmap(bmp, new Rectangle(0, 0, this.ClientSize.Width, this.ClientSize.Height));
            byte[] imageBytes;

            using (MemoryStream ms = new MemoryStream())
            {
                bmp.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                imageBytes = ms.ToArray();
            }
            PdfDocument doc = new PdfDocument();
            PdfPage page = doc.AddPage();

            using (XGraphics gfx = XGraphics.FromPdfPage(page))
            {
                using (MemoryStream ms = new MemoryStream(imageBytes))
                {
                    bmp.Save(ms, ImageFormat.Png);
                    ms.Position = 0;

                    XImage img = XImage.FromStream(ms);

                    gfx.DrawImage(img, 0, 0,
                        page.Width,
                        page.Height);
                }
            }
            string fileName = $"EQPShipping{DateTime.Now.ToString("yyyyMMddHHmmssfff")}.pdf";
            doc.Save(fileName);
            byte[] pdfBytes = File.ReadAllBytes(".\\" + fileName);
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "PDF Files (*.pdf)|*.pdf";
                sfd.FileName = fileName;

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllBytes(sfd.FileName, pdfBytes);

                    MessageBox.Show("PDF已儲存");
                }
            }
        }

        private void FrmEQPShippingPrint_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("請問是否關閉頁面?", "確認", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Dispose();
                Close();
            }
        }
    }
}
