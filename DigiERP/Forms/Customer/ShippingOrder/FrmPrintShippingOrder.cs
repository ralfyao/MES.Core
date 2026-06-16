using DigiERP.UserControl.Common;
using MES.Core.Model;
using MES.WebAPI.Controllers;
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

namespace DigiERP.Forms.Customer.ShippingOrder
{
    public partial class FrmPrintShippingOrder : Form
    {
        public C出貨單 shippingOrder { get; set; }
        public C客戶設定 customer { get; set; }
        public string remark;
        private CustomerController _controller { get; set; }
        public FrmPrintShippingOrder()
        {
            InitializeComponent();
        }

        public void initController()
        {
            this._controller = new CustomerController();
        }

        public void initData()
        {
            txtCustNo.Text = customer.正航編號;
            txtCustName.Text = customer.欄位2;
            txtContact.Text = customer.CONTACTPERSON;
            txtTel.Text = customer.TEL;
            txtSales.Text = shippingOrder.業務人員;
            txtCurrency.Text = shippingOrder.幣別;
            txtEmail.Text = customer.EMAIL;
            txtOrderDate.Text = DateTime.Parse(shippingOrder.日期 ?? "1900-01-01").ToString("yyyy/MM/dd");
            txtOrderNo.Text = shippingOrder.單號;
            txtAddress.Text = customer.ADDRESS;
            initFourConditions();
            initGrid();
            txtRemark.Text = remark;
        }

        private void initGrid()
        {
            int index = 0;
            int rowIdx = 1;
            decimal amount = 0;
            foreach (var item in shippingOrder.shipOrderLists)
            {
                index = 0;
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGridView1);
                row.Cells[index++].Value = rowIdx;
                row.Cells[index++].Value = item.產品編號;
                row.Cells[index++].Value = item.品名規格;
                row.Cells[index++].Value = item.數量2;
                row.Cells[index++].Value = item.單位;
                row.Cells[index++].Value = item.單價2;
                row.Cells[index++].Value = item.數量2 * item.單價2; amount += (decimal)((item.數量2 ?? 0) * (item.單價2 ?? 0));
                row.Cells[index++].Value = item.描述;
                dataGridView1.Rows.Add(row);
                rowIdx++;
            }
            txtAmount.Text = amount.ToString();
            if (shippingOrder.稅率 == "5%")
            {
                txtTax.Text = (amount * .05m).ToString();
                txtTotalAmount.Text = (amount * 1.05m).ToString();
            }
            else
            {
                txtTax.Text = "0";
                txtTotalAmount.Text = (amount).ToString();
            }
            //throw new NotImplementedException();
        }

        private void initFourConditions()
        {
            PriceCondControl priceCondControl = new PriceCondControl();
            priceCondControl.txType = "T";//價格條件
            priceCondControl.SetPriceCond(shippingOrder.價格條件);
            txtPriceCond.Text = priceCondControl.GetPriceCond();

            priceCondControl.txType = "D";//交貨方式
            priceCondControl.SetPriceCond(shippingOrder.交貨方式);
            txtShipMethod.Text = priceCondControl.GetPriceCond();

            priceCondControl.txType = "P,Y";//付款條件
            priceCondControl.SetPriceCond(shippingOrder.付款方式);
            txtPaymentTerm.Text = priceCondControl.GetPriceCond();

            txtShipDate.Text = shippingOrder.原定交貨日期;
            //throw new NotImplementedException();
        }

        private void FrmPrintShippingOrder_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("確認關閉?", "確認", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Dispose();
                Close();
            }
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            btnPreview.Text = "";
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
            string fileName = $"ShippingOrder{DateTime.Now.ToString("yyyyMMddHHmmssfff")}.pdf";
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
            btnPreview.Text = "預覽列印";
        }
    }
}
