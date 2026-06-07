using DigiERP.UserControl.Common;
using MES.Core.Model;
using MES.WebAPI.Controllers;
using MES.WebAPI.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigiERP.Forms.Customer.SalesOrder
{
    public partial class FrmPrintSalesOrderCT : CommonForm
    {
        public C訂單 form { get; set; }
        private CustomerController _customerController;
        private C客戶設定 _customer { get; set; }
        public FrmPrintSalesOrderCT()
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
                lblCustomerName.Text = form.客戶全稱;
                lblContact.Text = _customer?.CONTACTPERSON;
                lblEmail.Text = _customer?.EMAIL;
                lblDate.Text = form.日期;
                lblTel.Text = _customer?.TEL;
                lblFax.Text = _customer?.FAX;
                lblSONo.Text = form.單號;
                lblAddress.Text = _customer?.ADDRESS;
                priceCond.SetPriceCond(form.價格條件??"");
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
                if (form.稅率!= "0%")
                {
                    try
                    {
                        if (form.稅率!= null)
                        {
                            decimal taxRate = decimal.Parse(form.稅率?.Replace("%", ""));
                            lblTax.Text = (form.訂單總額加總() * taxRate).ToString();
                            lblTotalAmount.Text = (form.訂單總額加總() * (1 + taxRate)).ToString();
                        }
                        else
                        {
                            lblTax.Text = "0";
                            lblTotalAmount.Text = form.訂單總額加總().ToString();
                        }
                    }
                    catch (Exception)
                    {

                        throw;
                    }
                }
                else
                {
                    lblTax.Text = "0";
                    lblTotalAmount.Text = form.訂單總額加總().ToString();
                }
                lblAudit.Text = form.核准;
                lblSales.Text = form.業務人員;
                lblModifyDate.Text = form.修改日;
                foreach(var item in form.orderListDetail)
                {
                    int index = 1;
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dataGridView1);
                    row.Cells[index++].Value = item.產品編號;
                    row.Cells[index++].Value = item.品名規格;
                    row.Cells[index++].Value = item.數量1;
                    row.Cells[index++].Value = item.單位;
                    row.Cells[index++].Value = item.單價1;
                    row.Cells[index++].Value = item.單價1 * item.數量1;
                    dataGridView1.Rows.Add(row);
                }
            }
            //throw new NotImplementedException();
        }

        private void lblEmail_Click(object sender, EventArgs e)
        {

        }
    }
}
