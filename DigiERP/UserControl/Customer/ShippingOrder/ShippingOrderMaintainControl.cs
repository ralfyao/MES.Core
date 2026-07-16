using DigiERP.Common;
using DigiERP.Forms.Customer.SalesOrder;
using DigiERP.Forms.Customer.ShippingOrder;
using DigiERP.Models;
using DigiERP.UserControl.Common;
using DigiERP.UserControl.Common.Customer;
using DigiERP.Util;
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
        // 沿用 ShippingOrderControl (出貨單列表) 已註冊的權限 GUID
        private static string id = "CF770F40-EA82-4FBF-9D2D-EAD798440F3E";

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
            initController();
            lblSalesName.Text = "";
            lblTotalSum.Text = "0";
            lblAuditDate.Text = "";
            lblAuditor.Text = "";
            lblCreateDate.Text = "";
            lblCreator.Text = "";
            lblModifier.Text = "";
            lblModifyDate.Text = "";
            if (lblMode.Text == "修改")
            {
                if (form != null)
                {
                    initController();
                    initCustomer();
                    dtORDERDATE.Value = DateTime.Parse(form?.日期 == null ? "1900-01-01" : form?.日期);
                    txtOrderNo.Text = form?.單號;
                    cboCustId.Items.Add(form?.客戶編號 ?? ""); cboCustId.Text = form?.客戶編號;
                    lblCustAlias.Text = _customer?.欄位2;
                    txtCustName.Text = _customer?.COMPANY;
                    txtCommission.Text = form?.佣金?.ToString();
                    dtShippingDate.Value = DateTime.Parse(form?.原定交貨日期 == null ? "1900-01-01" : form.原定交貨日期);
                    cboTaxType.Items.Add(form?.稅別 ?? ""); cboTaxType.Text = form?.稅別 ?? "";
                    cboTaxRate.Items.Add(form?.稅率 ?? ""); cboTaxRate.Text = form?.稅率 ?? "";
                    txtAmountSum.Text = form?.總額?.ToString();
                    txtAddress.Text = form?.交貨地址;
                    txtBankCode.Text = _customer?.CREDIBILITY;
                    txtCountry.Text = (form?.指配國別 ?? (_customer?.COUNTRY ?? ""));
                    txtDestination.Text = form?.目的港;
                    cboSales.Items.Add(form?.業務員 ?? ""); cboSales.Text = form?.業務員 ?? "";
                    lblSalesName.Text = form?.業務人員;
                    txtRemark.Text = form?.Remark;
                    //cboPaymentTerm.Items.Add(form.付款方式 ?? ""); cboPaymentTerm.Text = form.付款方式 ?? "";
                    lblAuditor.Text = string.IsNullOrEmpty(form?.核准) ? "" : form?.核准;
                    lblAuditDate.Text = string.IsNullOrEmpty(form?.核准日) ? "" : form?.核准日;
                    lblCreator.Text = string.IsNullOrEmpty(form?.建檔) ? "" : form?.建檔;
                    lblCreateDate.Text = string.IsNullOrEmpty(form?.建檔日) ? "" : form?.建檔日;
                    lblModifier.Text = string.IsNullOrEmpty(form?.修改) ? "" : form?.修改;
                    lblModifyDate.Text = string.IsNullOrEmpty(form?.修改日) ? "" : form?.修改日;
                    initGrid();
                    if (!string.IsNullOrEmpty(form?.核准))
                    {
                        btnVerify.Visible = false;
                        btnCancelVerify.Visible = true;
                        btnPrint.Visible = true;
                    }
                    else
                    {
                        btnVerify.Visible = true;
                        btnCancelVerify.Visible = false;
                        btnPrint.Visible = false;
                    }
                }
                disableControls(true);
                btnModify.Visible = chkEditPrivilege(id);
            }
            else if (lblMode.Text == "新增")
            {
                dtORDERDATE.Value = DateTime.Now;
                var shippingOrderRep = _customerController.GetShippingOrderNo();
                if (!string.IsNullOrEmpty(shippingOrderRep.ErrorMessage))
                {
                    MessageBox.Show(shippingOrderRep.ErrorMessage);
                    return;
                }
                txtOrderNo.Text = shippingOrderRep.result;
                disableControls(false);
                btnModify.Visible = false;
            }
            initCurrency();
            initExRate();
            initPaymentTerm();
            initShipMethod();
            initPriceCond();
            initSales();
            //throw new NotImplementedException();
        }

        private void initExRate()
        {
            var exRateRep = _customerController.GetExRateList(form?.幣別 ?? "");
            if (!string.IsNullOrEmpty(exRateRep.ErrorMessage))
            {
                MessageBox.Show(exRateRep.ErrorMessage);
                return;
            }
            var exRate = exRateRep.resultList.FirstOrDefault() ?? new F匯率();
            txtExRate.Text = (exRate.匯率 == null ? "0" : exRate.匯率);
        }
        private void initSales()
        {
            var salesRep = _customerController.getSalesList();
            if (!string.IsNullOrEmpty(salesRep.ErrorMessage))
            {
                MessageBox.Show(salesRep.ErrorMessage);
                return;
            }
            salesRep.resultList.Insert(0, new H員工清冊());
            cboSales.DataSource = salesRep.resultList;
            cboSales.DisplayMember = "工號";
            cboSales.ValueMember = "工號";
            lblSalesName.Text = "";
            if (lblMode.Text == "新增")
            {
                form.業務員 = "";
            }
            foreach (var item in cboSales.Items)
            {
                if (((H員工清冊)item).工號 != null && ((H員工清冊)item).工號.Trim() == form?.業務員?.Trim())
                {
                    cboSales.SelectedItem = item;
                    cboSales.Text = ((H員工清冊)item).工號;
                    lblSalesName.Text = ((H員工清冊)item).姓名;
                    break;
                }
            }
        }

        private void initPriceCond()
        {
            string priceConddStr = form.價格條件 ?? "";
            PriceCondControl priceCond = new PriceCondControl("T");
            cboTradeCond.DataSource = priceCond.selectionItems;
            cboTradeCond.DisplayMember = "條文編號";
            cboTradeCond.ValueMember = "條文編號";
            if (string.IsNullOrEmpty(form.價格條件))
            {
                form.價格條件 = priceConddStr;
            }
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
            priceCond.SetPriceCond(form?.價格條件?.Trim() ?? "");
            lblTradeCond.Text = priceCond.GetPriceCondTxt();
        }

        private void initShipMethod()
        {
            string shipMethodStr = form.交貨方式 ?? "";
            PriceCondControl shipMethod = new PriceCondControl("D");
            cboShipMethod.DataSource = shipMethod.selectionItems;
            cboShipMethod.DisplayMember = "條文編號";
            cboShipMethod.ValueMember = "條文編號";
            if (string.IsNullOrEmpty(form.交貨方式))
            {
                form.交貨方式 = shipMethodStr;
            }
            foreach (var item in cboShipMethod.Items)
            {
                if (((F訂單交易條件)item).條文編號.Trim() == form?.交貨方式?.Trim())
                {
                    cboShipMethod.SelectedItem = item;
                    cboShipMethod.Text = ((F訂單交易條件)item).條文編號;
                    break;
                }
            }
            shipMethod.SetPriceCond(form?.交貨方式?.Trim() ?? "");
            lblShippingMethod.Text = shipMethod.GetPriceCondTxt();
        }

        private void initPaymentTerm()
        {
            string paymentTermStr = form.付款方式 ?? "";
            PriceCondControl paymentTerm = new PriceCondControl("P,Y");
            cboPaymentTerm.DataSource = paymentTerm.selectionItems;
            cboPaymentTerm.DisplayMember = "條文編號";
            cboPaymentTerm.ValueMember = "條文編號";
            if (string.IsNullOrEmpty(form.付款方式))
            {
                form.付款方式 = paymentTermStr;
            }
            foreach (var item in cboPaymentTerm.Items)
            {
                if (((F訂單交易條件)item).條文編號.Trim() == form.付款方式?.Trim())
                {
                    cboPaymentTerm.SelectedItem = item;
                    cboPaymentTerm.Text = ((F訂單交易條件)item).條文編號;
                    break;
                }
            }
            //cboShipMethod.SelectedItem = new F訂單交易條件() { 條文編號 = form?.付款方式?.Trim() ?? "" };
            paymentTerm.SetPriceCond(form?.付款方式?.Trim() ?? "");
            lblPaymentTerm.Text = paymentTerm.GetPriceCondTxt();
        }

        private void initCurrency()
        {
            CurrencySelect currencySelect = new CurrencySelect();
            currencySelect.initCurrencyList();
            cboCurrency.DataSource = currencySelect.currencyList;
            cboCurrency.DisplayMember = "CURRENCY";
            cboCurrency.ValueMember = "CURRENCY";
            foreach (var item in cboCurrency.Items)
            {
                if (((F幣別)item).CURRENCY == form?.幣別?.Trim())
                {
                    cboCurrency.SelectedItem = item;
                }
            }
        }

        private void disableControls(bool enable)
        {
            bool isDisable = !enable;
            btnSODistribute.Enabled = isDisable;
            btnSearch.Enabled = isDisable;
            btnVerify.Enabled = isDisable;
            btnCancelVerify.Enabled = isDisable;
            btnPrint.Enabled = isDisable;
            btnSubmit.Enabled = isDisable;
            txtCommission.Enabled = isDisable;
            dtShippingDate.Enabled = isDisable;
            cboTaxType.Enabled = isDisable;
            cboTaxRate.Enabled = isDisable;
            txtCustName.Enabled = isDisable;
            cboCurrency.Enabled = isDisable;
            txtExRate.Enabled = isDisable;
            txtAmountSum.Enabled = isDisable;
            txtAddress.Enabled = isDisable;
            txtBankCode.Enabled = isDisable;
            btnCheck.Enabled = isDisable;
            txtCountry.Enabled = false;
            txtDestination.Enabled = isDisable;
            cboTradeCond.Enabled = isDisable;
            cboSales.Enabled = isDisable;
            txtRemark.Enabled = isDisable;
            cboShipMethod.Enabled = isDisable;
            cboPaymentTerm.Enabled = isDisable;
            dataGridView1.Enabled = isDisable;
            //throw new NotImplementedException();
        }

        private void initGrid()
        {
            int index = 0;
            dataGridView1.Rows.Clear();
            decimal totalSum = 0.0m;
            if (form?.shipOrderLists == null)
                return;
            foreach (var item in form.shipOrderLists)
            {
                index = 0;
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGridView1);
                row.Cells[index++].Value = item.識別碼 ?? 0;
                row.Cells[index++].Value = item.產品編號;
                row.Cells[index++].Value = item.品名規格;
                row.Cells[index++].Value = item.單位;
                row.Cells[index++].Value = item.數量2;
                row.Cells[index++].Value = item.單價2;
                row.Cells[index++].Value = item.金額2;
                row.Cells[index++].Value = item.描述;
                row.Cells[index++].Value = item.樣品別;
                row.Cells[index++].Value = item.倉庫別;
                row.Cells[index++].Value = item.ORDNO;
                totalSum += item.金額2 ?? 0;
                dataGridView1.Rows.Add(row);
            }
            lblTotalSum.Text = totalSum.ToString();
            //throw new NotImplementedException();
        }

        private void initCustomer()
        {
            if (string.IsNullOrEmpty(form?.客戶編號))
                return;
            var custRep = _customerController.GetCustomer(new C客戶設定() { 正航編號 = form?.客戶編號 });
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

        private void btnModify_Click(object sender, EventArgs e)
        {
            disableControls(false);
        }

        private void ShippingOrderMaintainControl_Load(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            CollectUserInput();
            if (MessageBox.Show($"確定{lblMode.Text}?", "確認", MessageBoxButtons.YesNo) == DialogResult.No)
                return;
            if (lblMode.Text == "新增")
            {
                form.稅率 = form.稅率.Replace("%", "");
                var rep = _customerController.SaveShippingOrder(form);
                if (!string.IsNullOrEmpty(rep.ErrorMessage))
                {
                    MessageBox.Show(rep.ErrorMessage);
                    return;
                }
            }
            else if (lblMode.Text == "修改")
            {
                var rep = _customerController.UpdateShippingOrder(form);
                if (!string.IsNullOrEmpty(rep.ErrorMessage))
                {
                    MessageBox.Show(rep.ErrorMessage);
                    return;
                }
            }
            MessageBox.Show(lblMode.Text + "成功!");
            btnClose_Click(null, null);
        }

        private void CollectUserInput()
        {
            //throw new NotImplementedException();
            if (form == null)
            {
                form = new C出貨單();
                form.shipOrderLists = new List<C出貨單明細>();
            }
            form.單號 = txtOrderNo.Text;
            form.日期 = dtORDERDATE.Value.ToString("yyyy-MM-dd");
            form.客戶編號 = cboCustId.Text;
            form.業務員 = cboSales.Text;
            form.幣別 = string.IsNullOrEmpty(cboCurrency.Text) ? ((F幣別)cboCurrency?.SelectedItem)?.CURRENCY : cboCurrency.Text;
            try
            {
                form.匯率 = decimal.Parse(txtExRate.Text);
            }
            catch { }
            form.稅別 = cboTaxType.Text;
            form.稅率 = cboTaxRate.Text;
            form.總額 = ControlUtil.decimalParse(txtAmountSum.Text);
            form.佣金 = ControlUtil.decimalParse(txtCommission.Text);
            form.原定交貨日期 = dtShippingDate.Value.ToString("yyyy-MM-dd");
            form.交貨地址 = txtAddress.Text;
            form.指配國別 = txtCountry.Text;
            form.目的港 = txtDestination.Text;
            form.價格條件 = string.IsNullOrEmpty(cboTradeCond.Text) ? (((F訂單交易條件)(cboTradeCond?.SelectedItem ?? ("" ?? "")))?.條文編號 ?? "") : cboTradeCond.Text;
            form.交貨方式 = string.IsNullOrEmpty(cboShipMethod.Text) ? (((F訂單交易條件)(cboShipMethod?.SelectedItem ?? ("" ?? "")))?.條文編號 ?? "") : cboShipMethod.Text;
            form.付款方式 = string.IsNullOrEmpty(cboPaymentTerm.Text) ? (((F訂單交易條件)(cboPaymentTerm?.SelectedItem ?? ("" ?? "")))?.條文編號 ?? "") : cboPaymentTerm.Text;
            form.交貨日期 = null;
            form.Remark = txtRemark.Text;
            if (lblMode.Text == "修改")
            {
                form.修改 = AppSession.User.username;
                form.修改日 = DateTime.Now.ToString("yyyy-MM-dd");
            }
            else if (lblMode.Text == "新增")
            {
                form.建檔 = lblCreator.Text;
                form.建檔日 = lblCreateDate.Text;
            }
            if (form.shipOrderLists == null)
                form.shipOrderLists = new List<C出貨單明細>();
            form.shipOrderLists.Clear();
            int index = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                C出貨單明細 item = new C出貨單明細();
                index = 1;
                //DataGridViewRow row = new DataGridViewRow();
                //row.CreateCells(dataGridView1);
                //index++;
                item.產品編號 = row.Cells[index++].Value?.ToString();
                item.品名規格 = row.Cells[index++].Value?.ToString();
                try
                {
                    item.數量2 = decimal.Parse(row.Cells[index++].Value?.ToString());
                }
                catch (Exception)
                {
                    item.數量2 = 0;
                }
                item.單位 = row.Cells[index++].Value.ToString();
                try
                {
                    item.單價2 = decimal.Parse(row.Cells[index++].Value.ToString());
                }
                catch (Exception)
                {
                    item.單價2 = 0;
                }
                try
                {
                    item.金額2 = decimal.Parse(row.Cells[index++].Value.ToString());
                }
                catch (Exception)
                {
                    item.金額2 = 0;
                }
                item.描述 = row.Cells[index++].Value?.ToString();
                item.樣品別 = row.Cells[index++].Value?.ToString();
                item.倉庫別 = row.Cells[index++].Value?.ToString();
                item.ORDNO = row.Cells[index++].Value?.ToString();
                form.shipOrderLists.Add(item);
                //dataGridView1.Rows.Add(row);
            }
        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("確定覆核?", "確認", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var rep = _customerController.ValidateShipOrder(form.單號, true, AppSession.User.username);
                if (!string.IsNullOrEmpty(rep.ErrorMessage))
                {
                    MessageBox.Show(rep.ErrorMessage);
                    return;
                }
                MessageBox.Show("覆核成功!");
                btnCancelVerify.Visible = true;
                btnPrint.Visible = true;
                btnVerify.Visible = false;
            }
        }

        private void btnCancelVerify_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("確定取消覆核?", "確認", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var rep = _customerController.ValidateShipOrder(form.單號, true, AppSession.User.username);
                if (!string.IsNullOrEmpty(rep.ErrorMessage))
                {
                    MessageBox.Show(rep.ErrorMessage);
                    return;
                }
                MessageBox.Show("取消覆核成功!");
                btnCancelVerify.Visible = false;
                btnPrint.Visible = false;
                btnVerify.Visible = true;
            }
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBankCode.Text))
            {
                MessageBox.Show("收款帳號不可為空!");
                return;
            }
            FrmBankDetail frmBankDetail = new FrmBankDetail();
            frmBankDetail.bankCode = txtBankCode.Text;
            frmBankDetail.initData();
            frmBankDetail.ShowDialog();
        }
        FrmCustSelect popup;

        private void btnSearch_Click(object sender, EventArgs e)
        {
            popup = new FrmCustSelect();
            //{
            popup.FormBorderStyle = FormBorderStyle.None;
            popup.StartPosition = FormStartPosition.Manual;

            // 定位在 ComboBox 下方
            var location = cboCustId.PointToScreen(Point.Empty);
            popup.Location = new Point(location.X, location.Y - popup.Height);
            popup.Size = new Size(popup.Width, 600);
            if (popup.ShowDialog() == DialogResult.OK)
            {
                cboCustId.Items.Clear();
                cboCustId.Items.Add(popup.CustId);
                cboCustId.Text = popup.CustId;
                lblCustAlias.Text = popup.CustAlias;
                txtCustName.Text = popup.CustName;
                var customerRep = _customerController.getCustomerList(popup.CustName);
                if (!string.IsNullOrEmpty(customerRep.ErrorMessage))
                {
                    MessageBox.Show(customerRep.ErrorMessage);
                    return;
                }
                var customer = customerRep.resultList.FirstOrDefault();
                if (customer != null)
                {
                    txtCountry.Text = customer.COUNTRY;
                    txtBankCode.Text = customer.CREDIBILITY;
                    //cboCurrency.Items.Add(new F幣別() { CURRENCY = customer.CURRENCY})
                }
            }
        }

        private void cboTradeCond_SelectedIndexChanged(object sender, EventArgs e)
        {
            form.價格條件 = ((F訂單交易條件)cboTradeCond.SelectedItem)?.條文編號 ?? "";
            PriceCondControl priceCond = new PriceCondControl();
            priceCond.txType = "T";
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
            priceCond.SetPriceCond((form?.價格條件?.Trim() ?? ""));
            lblTradeCond.Text = priceCond.GetPriceCondTxt();
            //initPriceCond();
        }

        private void cboShipMethod_SelectedIndexChanged(object sender, EventArgs e)
        {
            form.交貨方式 = ((F訂單交易條件)cboShipMethod.SelectedItem)?.條文編號 ?? "";
            PriceCondControl priceCond = new PriceCondControl();
            priceCond.txType = "D";
            foreach (var item in cboShipMethod.Items)
            {
                if (((F訂單交易條件)item).條文編號.Trim() == form?.價格條件?.Trim())
                {
                    cboShipMethod.SelectedItem = item;
                    cboShipMethod.Text = ((F訂單交易條件)item).條文編號;
                    break;
                }
            }
            priceCond.SetPriceCond(form?.交貨方式 ?? "");
            lblShippingMethod.Text = priceCond.GetPriceCond();
        }

        private void cboPaymentTerm_SelectedIndexChanged(object sender, EventArgs e)
        {
            form.付款方式 = ((F訂單交易條件)cboPaymentTerm.SelectedItem)?.條文編號 ?? "";
            PriceCondControl priceCond = new PriceCondControl();
            priceCond.txType = "P,Y";
            foreach (var item in cboPaymentTerm.Items)
            {
                if (((F訂單交易條件)item).條文編號.Trim() == form?.價格條件?.Trim())
                {
                    cboPaymentTerm.SelectedItem = item;
                    cboPaymentTerm.Text = ((F訂單交易條件)item).條文編號;
                    break;
                }
            }
            priceCond.SetPriceCond(form?.付款方式 ?? "");
            lblPaymentTerm.Text = priceCond.GetPriceCond();
        }

        private void cboSales_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(((H員工清冊)cboSales.SelectedItem)?.工號))
                {
                    return;
                }
                form.業務員 = ((H員工清冊)cboSales.SelectedItem)?.工號 ?? "";
                foreach (var item in cboSales.Items)
                {
                    if (((H員工清冊)item).工號?.Trim() == form.業務員?.Trim())
                    {
                        lblSalesName.Text = ((H員工清冊)item)?.姓名;
                        //cboPaymentTerm.SelectedItem = item;
                        //cboPaymentTerm.Text = ((F訂單交易條件)item).條文編號;
                        break;
                    }
                }
            }
            catch
            {
                var salesRep = _customerController.getSalesList();
                if (!string.IsNullOrEmpty(salesRep.ErrorMessage))
                {
                    MessageBox.Show(salesRep.ErrorMessage);
                    return;
                }
                foreach (var item in salesRep.resultList)
                {
                    if (((H員工清冊)item).工號?.Trim() == form.業務員?.Trim())
                    {
                        lblSalesName.Text = ((H員工清冊)item)?.姓名;
                        //cboPaymentTerm.SelectedItem = item;
                        //cboPaymentTerm.Text = ((F訂單交易條件)item).條文編號;
                        break;
                    }
                }
            }

        }

        private void cboCurrency_SelectedIndexChanged(object sender, EventArgs e)
        {
            var exRateListRep = _customerController.GetExRateList(((F幣別)cboCurrency?.SelectedItem)?.CURRENCY ?? "");
            if (!string.IsNullOrEmpty(exRateListRep.ErrorMessage))
            {
                MessageBox.Show(exRateListRep.ErrorMessage);
                return;
            }
            txtExRate.Text = exRateListRep.resultList.FirstOrDefault()?.匯率;
        }

        private void dataGridView1_VisibleChanged(object sender, EventArgs e)
        {

        }

        private void btnSODistribute_Click(object sender, EventArgs e)
        {
            FrmSalesOrderSelect frmSalesOrderSelect = new FrmSalesOrderSelect();
            frmSalesOrderSelect.custId = cboCustId.Text;
            frmSalesOrderSelect.initDataGrid();
            if (frmSalesOrderSelect.ShowDialog(this) == DialogResult.OK)
            {
                DataGridViewRow row = new DataGridViewRow();
                int index = 1;
                row.CreateCells(dataGridView1);
                row.Cells[index++].Value = frmSalesOrderSelect.selectedOrderLine.產品編號;
                row.Cells[index++].Value = frmSalesOrderSelect.selectedOrderLine.品名規格;
                row.Cells[index++].Value = frmSalesOrderSelect.selectedOrderLine.數量1;
                row.Cells[index++].Value = frmSalesOrderSelect.selectedOrderLine.單位;
                row.Cells[index++].Value = frmSalesOrderSelect.selectedOrderLine.單價1;
                row.Cells[index++].Value = frmSalesOrderSelect.selectedOrderLine.數量1 * frmSalesOrderSelect.selectedOrderLine.單價1;
                index++;
                index++;
                index++;
                row.Cells[index++].Value = frmSalesOrderSelect.selectedOrderLine.單號;
                dataGridView1.Rows.Add(row);
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            FrmShippingOrderPrint frm = new FrmShippingOrderPrint();
            frm.custId = cboCustId.Text;
            frm.shippingOrder = form;
            frm.initData();
            frm.ShowDialog();
        }
    }
}
