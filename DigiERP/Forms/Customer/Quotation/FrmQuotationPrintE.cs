using MES.Core.Model;
using MES.WebAPI.Controllers;
using MES.WebAPI.Models;
using PdfSharp.Pdf;
using PdfSharp.Drawing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace DigiERP.Forms.Customer.Quotation
{
    public partial class FrmQuotationPrintE : Form
    {
        public C報價單 quotation = new C報價單();
        private C客戶設定 _customer;
        private CustomerController _customerController;
        private HRController _hrController;
        public FrmQuotationPrintE()
        {
            InitializeComponent();
        }

        private void FrmQuotationPrintE_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("確認關閉視窗?", "確認", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Dispose();
                Close();
            }
            //throw new NotImplementedException();
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
            string fileName = $"Quotation{DateTime.Now.ToString("yyyyMMddHHmmssfff")}.pdf";
            doc.Save(fileName);
            byte[] pdfBytes = File.ReadAllBytes(".\\"+fileName);
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

        private void initController()
        {
            if (_customerController == null)
            {
                _customerController = new CustomerController();
            }
            if (_hrController == null)
            {
                _hrController = new HRController();
            }
        }

        public void GetData()
        {
            initController();
            CommonRep<C客戶詢問函> rfqRep = _customerController.GetRfq(quotation.RFQNO);
            if (!string.IsNullOrEmpty(rfqRep.ErrorMessage))
            {
                MessageBox.Show(rfqRep.ErrorMessage);
                return;
            }
            if (!string.IsNullOrEmpty(rfqRep.result.COMPANY))
            {
                if (_customer == null)
                    _customer = new C客戶設定();
                _customer.COMPANY = quotation.COMPANY ?? rfqRep.result.COMPANY;
                CommonRep<C客戶設定> custRep = _customerController.getCustomerList(_customer.COMPANY);
                if (!string.IsNullOrEmpty(custRep.ErrorMessage))
                {
                    MessageBox.Show(custRep.ErrorMessage);
                    return;
                }
                if (custRep.resultList.Count() > 0)
                    _customer = custRep.resultList[0];
                lblCustomer.Text = _customer.COMPANY??"";
                lblQuono.Text = quotation.QUONO ?? "";
                lblRanking.Text = quotation.RANKING ?? "";
                lblTel.Text = _customer.TEL ?? "";
                lblCurrency.Text = quotation.CURRENCY ?? "";
                lblQuoDate.Text = quotation.QUODATE ?? "";
                lblEmail.Text = _customer.EMAIL ?? "";
                lblPriceBase.Text = quotation.priceCondText;
                lbDeliveryMethod.Text = quotation.deliveryMethodText;
                lblPaymentTerm.Text = quotation.paymentTermText;
                lblDeliveryDate.Text = quotation.deliveryDateText;
                lblConDate.Text = quotation.CONDATE;
                initDataGrid(quotation);
                txtRemark.Text = quotation.Remark;
                var salesRep = _hrController.GetWorkerByNumber(quotation.SALES);
                if (!string.IsNullOrEmpty(salesRep.ErrorMessage))
                {
                    MessageBox.Show(salesRep.ErrorMessage);
                    return;
                }
                txtSales.Text = salesRep.result?.姓名;
            }
            //throw new NotImplementedException();
        }

        private void initDataGrid(C報價單 quotation)
        {
            int index = 0;
            int lineNo = 1;
            dataGridView1.Rows.Clear();
            foreach(var item in quotation.quotationDetailFormList)
            {
                index = 0;
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGridView1);
                row.Cells[index++].Value = lineNo++;
                row.Cells[index++].Value = item.產品編號;
                row.Cells[index++].Value = item.品名規格;
                row.Cells[index++].Value = item.數量;
                row.Cells[index++].Value = item.單位;
                row.Cells[index++].Value = item.單價;
                row.Cells[index++].Value = item.數量 * item.單價;
            }
            //throw new NotImplementedException();
        }
    }
}
