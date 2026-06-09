using DigiERP.UserControl.Common;
using MES.Core.Model;
using MES.WebAPI.Controllers;
using MES.WebAPI.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigiERP.Forms.Customer.SalesOrder
{
    public partial class FrmPrintSalesOrderIT : CommonForm
    {
        public C訂單 form { get; set; }
        private CustomerController _customerController;
        private C客戶設定 _customer { get; set; }
        public decimal percent = 1;
        public FrmPrintSalesOrderIT()
        {
            InitializeComponent();
            initController();
            initControls();
            initData();
        }
        private PriceCondControl priceCond;
        private PriceCondControl ETDRequest;
        private PriceCondControl shipMethod;
        private PriceCondControl payMethod;
        public void initControls()
        {
            priceCond = new PriceCondControl();
            ETDRequest = new PriceCondControl();
            shipMethod = new PriceCondControl();
            payMethod = new PriceCondControl();

            priceCond.txType = "T";
            ETDRequest.txType = "R";
            shipMethod.txType = "D";
            payMethod.txType = "P,Y";
        }

        private void initController()
        {
            if (_customerController == null)
            {
                _customerController = new CustomerController();
            }
            //throw new NotImplementedException();
        }

        public void initData()
        {
            if (form != null)
            {
                CommonRep<C客戶設定> customerRep = _customerController.getCustomerList(form.客戶全稱);
                if (!string.IsNullOrEmpty(customerRep.ErrorMessage))
                {
                    MessageBox.Show(customerRep.ErrorMessage);
                    return;
                }
                _customer = customerRep.resultList.FirstOrDefault();
                // 客戶名稱
                lblCustomerName.Text = form.客戶全稱;
                // 聯絡人
                lblContact.Text = _customer?.CONTACTPERSON;
                // Email
                lblEmail.Text = _customer?.EMAIL;
                // 單據日期
                lblDate.Text = DateTime.Parse(form.日期).ToString("yyyy/MM/dd");
                // 連絡電話
                lblTel.Text = _customer?.TEL;
                // 傳真
                lblFax.Text = _customer?.FAX;
                // 單號
                lblSONo.Text = form.單號;
                // 出貨地址
                lblAddress.Text = _customer?.ADDRESS;
                priceCond.SetPriceCond(form.價格條件 ?? "");
                // 交期要求
                ETDRequest.SetPriceCond(form.交貨日期 ?? "");
                // 交貨方式
                shipMethod.SetPriceCond(form.交貨方式 ?? "");
                // 付款方式
                payMethod.SetPriceCond(form.付款方式 ?? "");
                lblPriceCond.Text = priceCond.GetPriceCondTxt();
                lblShipMethod.Text = shipMethod.GetPriceCondTxt();
                lblPaymentTerm.Text = payMethod.GetPriceCondTxt();
                lblETDRequest.Text = ETDRequest.GetPriceCondTxt();
                lblAmountSum.Text = form.訂單總額加總().ToString();
                
                lblAudit.Text = form.核准;
                lblSales.Text = form.業務人員;
                lblModifyDate.Text = form.修改日;
                int rowIdx = 1;
                decimal totalAmount = 0.0m;
                foreach (var item in form.orderPrintListDetail)
                {
                    int index = 1;
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dataGridView1);
                    row.Cells[index - 1].Value = rowIdx;
                    row.Cells[index++].Value = item.產品編號;
                    row.Cells[index++].Value = item.品名規格;
                    row.Cells[index++].Value = item.數量1;
                    row.Cells[index++].Value = item.單位;
                    row.Cells[index++].Value = item.單價1 * percent;
                    row.Cells[index++].Value = item.單價1 * percent * item.數量1;
                    row.Cells[index++].Value = item.專案序號;
                    totalAmount += (decimal)(item.單價1 * percent * item.數量1);
                    dataGridView1.Rows.Add(row);
                    rowIdx++;
                }
                lblAmountSum.Text = totalAmount.ToString();
                if (_customer == null)
                    return;
                var bankInfo = _customerController.GetBankInfo(_customer.CREDIBILITY);
                if (!string.IsNullOrEmpty(bankInfo.ErrorMessage))
                {
                    MessageBox.Show(bankInfo.ErrorMessage);
                    return;
                }
                lblAccountWithBank.Text = bankInfo.result?.Bankname;
                lblBankAddress.Text = bankInfo.result?.銀行地址;
                lblBankSwiftCode.Text = bankInfo.result?.SwiftCode;
                lblAccountNumber.Text = bankInfo.result?.帳號;
            }
            
            //throw new NotImplementedException();
        }

        private void lblEmail_Click(object sender, EventArgs e)
        {

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
            string fileName = $"SalesOrder{DateTime.Now.ToString("yyyyMMddHHmmssfff")}.pdf";
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

        private void FrmPrintSalesOrderCT_Load(object sender, EventArgs e)
        {

        }

        private void FrmPrintSalesOrderCT_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("確認關閉視窗?", "確認", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Dispose();
                Close();
            }
        }
    }
}
