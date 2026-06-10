using DigiERP.Common;
using DigiERP.UserControl.Common;
using MES.Core.Model;
using MES.WebAPI.Controllers;
using MES.WebAPI.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigiERP.UserControl.Customer.ShippingOrder
{
    public partial class ShippingOrderMaintainControl : CommonUserControl
    {
        public C出貨單 form { get; set; }
        public string custId { get; set; }
        private CustomerController _customerController { get; set; }
        public ShippingOrderMaintainControl()
        {
            InitializeComponent();
            initController();
        }

        private void initController()
        {
            if (_customerController == null)
                _customerController = new CustomerController();
            //throw new NotImplementedException();
        }

        public ShippingOrderMaintainControl(C出貨單 form)
        {
            InitializeComponent();
            this.form = form;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            var dataGridView = (from c in Parent.Controls.Cast<Control>() where c.GetType() == typeof(DataGridView) select c).FirstOrDefault();
            if (dataGridView != null)
            {
                dataGridView.Visible = true;
            }
        }
        private C客戶設定 _customer { get; set; }
        internal void initForm()
        {
            if (form != null)
            {
                initController();
                initCustomer();
                dtORDERDATE.Value =DateTime.Parse( form.日期 == null ? "1900-01-01" : form.日期);
                txtOrderNo.Text = form.單號;
                cboCustId.Items.Add(form.客戶編號??""); cboCustId.Text = form.客戶編號;
                lblCustAlias.Text = _customer?.欄位2;
                txtCustName.Text = _customer?.COMPANY;
                txtCommission.Text = form.佣金?.ToString();
                dtShippingDate.Value = DateTime.Parse(form.原定交貨日期 == null ? "1900-01-01" : form.原定交貨日期);
                cboTaxType.Items.Add(form.稅別 ?? ""); cboTaxType.Text = form.稅別 ?? "";
                cboTaxRate.Items.Add(form.稅率 ?? ""); cboTaxRate.Text = form.稅率 ?? "";
                cboCurrency.Items.Add(form.幣別 ?? ""); cboCurrency.Text = form.幣別 ?? "";
                var exRateRep = _customerController.GetExRateList(form.幣別??"");
                if (!string.IsNullOrEmpty(exRateRep.ErrorMessage))
                {
                    MessageBox.Show(exRateRep.ErrorMessage);
                    return;
                }
                var exRate = exRateRep.resultList.FirstOrDefault()??new F匯率();
                txtExRate.Text = (exRate.匯率 == null ? "0" : exRate.匯率);
                txtAmountSum.Text = form.總額?.ToString();
                txtAddress.Text = form.交貨地址;
                txtBankCode.Text = _customer?.CREDIBILITY;
                txtCountry.Text = form.指配國別;
                txtDestination.Text = form.目的港;
                //cboShipMethod.Items.Add(form.交貨方式 ?? ""); cboShipMethod.Text = form.交貨方式?.Trim() ?? "";
                //cboTradeCond.Items.Add(form.價格條件 ?? ""); cboTradeCond.Text = form.價格條件?.Trim() ?? "";
                cboSales.Items.Add(form?.業務員??"");
                lblSalesName.Text = form.業務人員;
                txtRemark.Text = form.Remark;
                //cboPaymentTerm.Items.Add(form.付款方式 ?? ""); cboPaymentTerm.Text = form.付款方式 ?? "";
                lblAuditor.Text = string.IsNullOrEmpty(form.核准) ? "" : form.核准;
                lblAuditDate.Text = string.IsNullOrEmpty(form.核准日) ? "" : form.核准日;
                lblCreator.Text = string.IsNullOrEmpty(form.建檔) ? "" : form.建檔;
                lblCreateDate.Text = string.IsNullOrEmpty(form.建檔日) ? "" : form.建檔日;
                lblModifier.Text = string.IsNullOrEmpty(form.修改) ? "" : form.修改;
                lblModifyDate.Text = string.IsNullOrEmpty(form.修改日) ? "" : form.修改日;
                PriceCondControl paymentTerm = new PriceCondControl("P,Y");
                cboPaymentTerm.DataSource = paymentTerm.selectionItems;
                cboPaymentTerm.DisplayMember = "條文編號";
                cboPaymentTerm.ValueMember = "條文編號";
                foreach (var item in cboPaymentTerm.Items)
                {
                    if (((F訂單交易條件)item).條文編號.Trim() == form?.付款方式?.Trim())
                    {
                        cboPaymentTerm.SelectedItem = item;
                        cboPaymentTerm.Text = ((F訂單交易條件)item).條文編號;
                        break;
                    }
                }
                //cboShipMethod.SelectedItem = new F訂單交易條件() { 條文編號 = form?.付款方式?.Trim() ?? "" };
                paymentTerm.SetPriceCond(form.付款方式?.Trim() ?? "");
                lblPaymentTerm.Text = paymentTerm.GetPriceCondTxt();

                PriceCondControl shipMethod = new PriceCondControl("D");
                cboShipMethod.DataSource = shipMethod.selectionItems;
                cboShipMethod.DisplayMember = "條文編號";
                cboShipMethod.ValueMember = "條文編號";
                foreach (var item in cboShipMethod.Items)
                {
                    if (((F訂單交易條件)item).條文編號.Trim() == form?.交貨方式?.Trim())
                    {
                        cboShipMethod.SelectedItem = item;
                        cboShipMethod.Text = ((F訂單交易條件)item).條文編號;
                        break;
                    }
                }
                shipMethod.SetPriceCond(form.交貨方式?.Trim() ?? "");
                lblShippingMethod.Text = shipMethod.GetPriceCondTxt();

                PriceCondControl priceCond = new PriceCondControl("T");
                cboTradeCond.DataSource = priceCond.selectionItems;
                cboTradeCond.DisplayMember = "條文編號";
                cboTradeCond.ValueMember = "條文編號";
                foreach (var item in cboTradeCond.Items)
                {
                    if (((F訂單交易條件)item).條文編號.Trim() == form?.價格條件?.Trim())
                    {
                        cboTradeCond.SelectedItem = item;
                        cboTradeCond.Text = ((F訂單交易條件)item).條文編號;
                        break;
                    }
                }
                //cboShipMethod.SelectedItem = new F訂單交易條件() { 條文編號 = form?.價格條件?.Trim()??"" };
                priceCond.SetPriceCond(form.價格條件?.Trim() ?? "");
                lblTradeCond.Text = priceCond.GetPriceCondTxt();

                initGrid();
            }
            //throw new NotImplementedException();
        }

        private void initGrid()
        {
            int index = 0;
            dataGridView1.Rows.Clear();
            decimal totalSum = 0.0m;
            if (form.shipOrderLists == null)
                return;
            foreach(var item in form.shipOrderLists)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGridView1);
                row.Cells[index++].Value = item.識別碼;
                row.Cells[index++].Value = item.產品編號;
                row.Cells[index++].Value = item.品名規格;
                row.Cells[index++].Value = item.單位;
                row.Cells[index++].Value = item.數量2;
                row.Cells[index++].Value = item.單價2;
                row.Cells[index++].Value = item.金額2;
                row.Cells[index++].Value = item.描述 ;
                row.Cells[index++].Value = item.樣品別;
                row.Cells[index++].Value = item.倉庫別;
                row.Cells[index++].Value = item.ORDNO;
                totalSum += item.金額2??0;
                dataGridView1.Rows.Add(row);
            }
            lblTotalSum.Text = totalSum.ToString();
            //throw new NotImplementedException();
        }

        private void initCustomer()
        {
            if (string.IsNullOrEmpty(form.客戶編號))
                return;
            var custRep = _customerController.GetCustomer(new C客戶設定() { 正航編號 = form.客戶編號 });
            if (!string.IsNullOrEmpty(custRep.ErrorMessage))
            {
                MessageBox.Show(custRep.ErrorMessage);
                return;
            }
            _customer = custRep.result;
            //throw new NotImplementedException();
        }

        private void lblCustAlias_Click(object sender, EventArgs e)
        {

        }
    }
}
