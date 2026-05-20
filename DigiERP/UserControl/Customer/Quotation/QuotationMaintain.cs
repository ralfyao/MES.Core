using DigiERP.Common;
using DigiERP.Forms.Customer.Quotation;
using DigiERP.Models;
using DigiERP.UserControl.Common.Customer;
using MES.Core.Model;
using MES.WebAPI.Controllers;
using MES.WebAPI.Models;
using Microsoft.AspNetCore.Components.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigiERP.UserControl.Customer.Quotation
{
    public partial class QuotationMaintain : CommonUserControl
    {
        public C報價單 form;
        public string mode;
        public QuotationMaintain(C報價單 form)
        {
            this.form = form;
            InitializeComponent();
            initForm();
            init();
        }

        private void init()
        {
            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                _customerController = new CustomerController();
            }
            currencySelect1.CurrencyChanged += CurrencySelect1_CurrencyChanged;
            priceCond.InnerComboBox.TabIndex = 191;
            ETDRequest.InnerComboBox.TabIndex = 194;
            shipMethod.InnerComboBox.TabIndex = 197;
            payMethod.InnerComboBox.TabIndex = 200;
        }

        public QuotationMaintain()
        {
            InitializeComponent();
            initForm();
            init();
        }
        public void disableControls(bool isDisable)
        {
            priceCond.Enabled = !isDisable;
            lblMode.Enabled = !isDisable;
            label1.Enabled = !isDisable;
            label2.Enabled = !isDisable;
            label3.Enabled = !isDisable;
            label4.Enabled = !isDisable;
            dtAvailableDate.Enabled = !isDisable;
            currencySelect1.Enabled = !isDisable;
            label5.Enabled = !isDisable;
            txtRFQNO.Enabled = !isDisable;
            label6.Enabled = !isDisable;
            salesSelect1.Enabled = !isDisable;
            txtCustNo.Enabled = !isDisable;
            label7.Enabled = !isDisable;
            txtCustAlias.Enabled = !isDisable;
            label8.Enabled = !isDisable;
            label9.Enabled = !isDisable;
            txtCompany.Enabled = !isDisable;
            label10.Enabled = !isDisable;
            label11.Enabled = !isDisable;
            label12.Enabled = !isDisable;
            exRate.Enabled = !isDisable;
            cboContactList.Enabled = !isDisable;
            label13.Enabled = !isDisable;
            cboMType.Enabled = !isDisable;
            txtAddress.Enabled = !isDisable;
            label14.Enabled = !isDisable;
            label15.Enabled = !isDisable;
            cboTaxRate.Enabled = !isDisable;
            label16.Enabled = !isDisable;
            label17.Enabled = !isDisable;
            ETDRequest.Enabled = !isDisable;
            label18.Enabled = !isDisable;
            shipMethod.Enabled = !isDisable;
            label19.Enabled = !isDisable;
            payMethod.Enabled = !isDisable;
            label20.Enabled = !isDisable;
            txtXomment.Enabled = !isDisable;
            dataGridView1.Enabled = !isDisable;
            btnAddDetail.Enabled = !isDisable;
            label21.Enabled = !isDisable;
            lblSummary.Enabled = !isDisable;
            label22.Enabled = !isDisable;
            label23.Enabled = !isDisable;
            label24.Enabled = !isDisable;
            label25.Enabled = !isDisable;
            label26.Enabled = !isDisable;
            label27.Enabled = !isDisable;
            lblCreator.Enabled = !isDisable;
            lblCreateDate.Enabled = !isDisable;
            lblModifyDate.Enabled = !isDisable;
            lblModifier.Enabled = !isDisable;
            lblApprover.Enabled = !isDisable;
            lblApproveDate.Enabled = !isDisable;
            label28.Enabled = !isDisable;
            label29.Enabled = !isDisable;
            lblQuotationSummary.Enabled = !isDisable;
            lblNTD.Enabled = !isDisable;
            txtId.Enabled = !isDisable;
            btnSubmit.Enabled = !isDisable;
            btnTransferToCustOrder.Enabled = !isDisable;
            btnQueryTransferedOrder.Enabled = !isDisable;
            btnDelete.Enabled = !isDisable;
            btnCopy.Enabled = !isDisable;
            btnActrivate.Enabled = !isDisable;
            btnDeactivate.Enabled = !isDisable;
            btnPrintC.Enabled = !isDisable;
            btnPrintE.Enabled = !isDisable;
        }
        private CustomerController _customerController;
        private C客戶設定 _customer;
        private void CurrencySelect1_CurrencyChanged(object sender, EventArgs e)
        {
            CommonRep<F匯率> commonRep = _customerController.GetExRateList(currencySelect1.GetCurrency());
            if (!string.IsNullOrEmpty(commonRep.ErrorMessage))
            {
                MessageBox.Show(commonRep.ErrorMessage);
                return;
            }
            if (commonRep.resultList.Count() > 0)
                exRate.Value = decimal.Parse(commonRep.resultList[0]?.匯率 == null ? "0" : commonRep.resultList[0]?.匯率);
            else
                exRate.Value = 0;
            //txtCurrency.Text = currencySelect1.GetCurrency();
        }
        private C客戶詢問函 rfq;
        public void SetRfqNo(string rfqNo)
        {
            txtRFQNO.Text = rfqNo;
        }
        public void SetCustNo(string custNo)
        {
            txtCustNo.Text = custNo;
        }
        public void SetCustAlias(string custAlias)
        {
            txtCustAlias.Text = custAlias;
        }
        public void initForm()
        {
            currencySelect1.initCurrencyList();
            priceCond.txType = "T";
            ETDRequest.txType = "R";
            shipMethod.txType = "D";
            payMethod.txType = "P,Y";
            if (lblMode.Text == "修改")
            {
                txtId.Text = form.IDNO;
                CommonRep<C報價單> quotationRep = _customerController.GetQuotation(form.QUONO);
                if (!string.IsNullOrEmpty(quotationRep.ErrorMessage))
                {
                    MessageBox.Show(quotationRep.ErrorMessage);
                    return;
                }
                form = quotationRep.result;
                //// 客戶資訊在詢問函內
                initCustFromRfq(form.RFQNO);
                dtQUODATE.Value = !string.IsNullOrEmpty(form.QUODATE) ? DateTime.Parse(form.QUODATE) : DateTime.Parse("1900-01-01");
                txtQUONO.Text = form.QUONO;
                txtCustNo.Text = _customer?.正航編號;
                txtRFQNO.Text = form.RFQNO;
                txtCustAlias.Text = _customer?.欄位2;
                dtAvailableDate.Value = !string.IsNullOrEmpty(form.CONDATE) ? DateTime.Parse(form.CONDATE) : DateTime.Parse("1900-01-01");
                txtCompany.Text = string.IsNullOrEmpty(_customer?.COMPANY) ? rfq?.COMPANY : _customer?.COMPANY;
                // 幣別
                currencySelect1.SetCurrency(form.CURRENCY);
                // 匯率
                SetExRate(form.CURRENCY);
                // 聯絡人
                SetContacct(form.CONTACT);
                // 機台類型
                SetMType(form.MTYPE);
                // 價格條件
                priceCond.SetPriceCond(form.價格條件);
                // 交期要求
                ETDRequest.SetPriceCond(form.交貨日期);
                // 交貨方式
                shipMethod.SetPriceCond(form.交貨方式);
                // 付款方式
                payMethod.SetPriceCond(form.付款方式);
                // 備註
                txtXomment.Text = form.Remark;
                // 業務
                salesSelect1.SetSalesCode(form.SALES);
                int index = 0;
                dataGridView1.Rows.Clear();
                foreach (var item in form.quotationDetailFormList)
                {
                    index = 0;
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dataGridView1);
                    row.Cells[index++].Value = item.產品編號;
                    row.Cells[index++].Value = item.品名規格;
                    row.Cells[index++].Value = item.數量;
                    row.Cells[index++].Value = item.單位;
                    row.Cells[index++].Value = item.單價;
                    row.Cells[index++].Value = item.金額;
                    row.Cells[index++].Value = item.描述;
                    dataGridView1.Rows.Add(row);
                }
                disableControls(true);
                btnDialog.Visible = true;
                btnTransferToCustOrder.Visible = true;
                btnQueryTransferedOrder.Visible = true;
                btnDelete.Visible = true;
                btnCopy.Visible = true;
                btnActrivate.Visible = true;
                btnDeactivate.Visible = true;
                btnPrintC.Visible = true;
                btnPrintE.Visible = true;
                // 顯示生效或取消生效按鈕
                if (string.IsNullOrEmpty(form.核准日))
                {
                    btnActrivate.Visible = true;
                    btnDeactivate.Visible = false;
                }
                else
                {
                    btnActrivate.Visible = false;
                    btnDeactivate.Visible = true;
                }
            }
            else
            {
                dtQUODATE.Value = DateTime.Now;
                if (_customerController == null)
                    _customerController = new CustomerController();
                CommonRep<string> commonRepQuono = _customerController.GetQuono();
                if (!string.IsNullOrEmpty(commonRepQuono.ErrorMessage))
                {
                    MessageBox.Show(commonRepQuono.ErrorMessage);
                    Dispose();
                    return;
                }
                txtQUONO.Text = commonRepQuono.result;
                if (form == null)
                {
                    txtCustNo.Text = string.Empty;
                    txtCustAlias.Text = string.Empty;
                    txtCompany.Text = string.Empty;
                }
                else
                {
                    //// 客戶資訊在詢問函內
                    if (form.RFQNO != null)
                    {
                        initCustFromRfq(form.RFQNO);
                        txtRFQNO.Text = form.RFQNO;
                        txtCustNo.Text = _customer?.正航編號;
                        txtCustAlias.Text = _customer?.欄位2;
                        salesSelect1.SetSalesCode(form.SALES);
                        txtCompany.Text = _customer.COMPANY;
                    }
                }
                dtAvailableDate.Value = DateTime.Parse("1900-01-01");
                // 幣別
                currencySelect1.SetCurrency(string.Empty);
                // 匯率
                SetExRate(string.Empty);
                // 聯絡人
                SetContacct(string.Empty);
                // 機台類型
                SetMType(string.Empty);
                // 價格條件
                priceCond.SetPriceCond(string.Empty);
                // 交期要求
                ETDRequest.SetPriceCond(string.Empty);
                // 交貨方式
                shipMethod.SetPriceCond(string.Empty);
                // 付款方式
                payMethod.SetPriceCond(string.Empty);
                // 備註
                txtXomment.Text = string.Empty;
                btnDialog.Visible = false;
                btnTransferToCustOrder.Visible = false;
                btnQueryTransferedOrder.Visible = false;
                btnDelete.Visible = false;
                btnCopy.Visible = false;
                btnActrivate.Visible = false;
                btnDeactivate.Visible = false;
                btnPrintC.Visible = false;
                btnPrintE.Visible = false;
                disableControls(false);
            }
            lblCreator.Text = form?.建檔;
            lblCreateDate.Text = form?.建檔日;
            lblModifier.Text = form?.修改;
            lblModifyDate.Text = form?.修改日;
            lblApprover.Text = form?.核准;
            lblApproveDate.Text = form?.核准日;
            lblSummary.Text = summaryGridView();
        }

        private void initCustFromRfq(string? rFQNO)
        {
            // 客戶資訊在詢問函內
            CommonRep<C客戶詢問函> rfqRep = _customerController.GetRfq(rFQNO);
            if (!string.IsNullOrEmpty(rfqRep.ErrorMessage))
            {
                MessageBox.Show(rfqRep.ErrorMessage);
                return;
            }
            rfq = rfqRep.result;

            CommonRep<C客戶設定> commonRep = _customerController.getCustomerList(rfq?.COMPANY);//.GetCustomer(new C客戶設定() { COMPANY = rfq?.COMPANY });
            if (!string.IsNullOrEmpty(commonRep.ErrorMessage))
            {
                MessageBox.Show(commonRep.ErrorMessage);
                return;
            }
            else
            {
                if (commonRep.resultList.Count() > 0)
                    _customer = commonRep.resultList[0];
                else
                {
                    //commonRep = _customerController.getCustomerList(rfq?.Cust);
                }
            }
        }

        private string summaryGridView()
        {
            float summary = 0f;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                try
                {
                    summary += float.Parse((row.Cells[5].Value != null ? row.Cells[5].Value.ToString() : "0"));
                }
                catch { }
            }
            return summary.ToString();
            //throw new NotImplementedException();
        }

        private void SetMType(string? mTYPE)
        {
            CommonRep<A機台類型> commonRep = _customerController.GetEqpType();
            if (!string.IsNullOrEmpty(commonRep.ErrorMessage))
            {
                MessageBox.Show(commonRep.ErrorMessage);
                return;
            }
            cboMType.DataSource = commonRep.resultList;
            cboMType.DisplayMember = "TYPEID";
            cboMType.ValueMember = "TYPEID";
            foreach (var item in commonRep.resultList)
            {
                if (((A機台類型)item).TYPEID == mTYPE)
                {
                    cboMType.SelectedItem = item;
                    cboMType.Text = item.TYPEID;
                }
            }
        }

        private void SetContacct(string? contact)
        {
            CommonRep<C客戶連絡人清單> commonRepContactList = _customerController.GetContactList(contact);
            if (!string.IsNullOrEmpty(commonRepContactList.ErrorMessage))
            {
                MessageBox.Show(commonRepContactList.ErrorMessage);
                return;
            }
            cboContactList.DataSource = commonRepContactList.resultList;
            cboContactList.ValueMember = "姓名";
            cboContactList.DisplayMember = "姓名";
            foreach (var item in cboContactList.Items)
            {
                if (((C客戶連絡人清單)item).姓名 == contact)
                {
                    cboContactList.SelectedItem = item;
                }
            }
        }

        private void SetExRate(string currency)
        {
            if (_customerController == null)
                _customerController = new CustomerController();
            CommonRep<F匯率> commonRepExRate = _customerController.GetExRateList(currency);
            if (!string.IsNullOrEmpty(commonRepExRate.ErrorMessage))
            {
                MessageBox.Show(commonRepExRate.ErrorMessage);
                return;
            }
            exRate.Value = decimal.Parse(commonRepExRate.resultList[0]?.匯率 == null ? "0" : commonRepExRate.resultList[0]?.匯率);
        }

        private void commonTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            var dataGridView = (from c in Parent.Controls.Cast<Control>() where c.GetType() == typeof(DataGridView) select c).FirstOrDefault();
            if (dataGridView != null)
            {
                dataGridView.Visible = true;
            }
        }

        private void btnAddDetail_Click(object sender, EventArgs e)
        {
            FrmAddQuotation frm = new FrmAddQuotation();
            frm.QUONO = txtQUONO.Text;
            var result = frm.ShowDialog();
            if (result == DialogResult.OK)
            {
                C報價明細 data = frm.GetData();
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGridView1);
                int index = 0;
                row.Cells[index++].Value = data.產品編號;
                row.Cells[index++].Value = data.品名規格;
                row.Cells[index++].Value = data.數量;
                row.Cells[index++].Value = data.單位;
                row.Cells[index++].Value = data.單價;
                row.Cells[index++].Value = data.金額;
                row.Cells[index++].Value = data.描述;
                dataGridView1.Rows.Add(row);
            }
            lblSummary.Text = summaryGridView();
            lblSummary_TextChanged(sender, e);
            //summaryDetailGrid();
        }

        private void lblSummary_TextChanged(object sender, EventArgs e)
        {
            lblQuotationSummary.Text = lblSummary.Text.Trim();
            lblNTD.Text = (decimal.Parse(lblSummary.Text.Trim()) * exRate.Value).ToString();
        }

        private void btnDialog_Click(object sender, EventArgs e)
        {
            FrmDialog frm = new FrmDialog();
            frm.QUONO = txtQUONO.Text;
            frm.CustNo = txtCustNo.Text;
            frm.COMPANY = txtCompany.Text;
            frm.IDNO = txtId.Text;
            frm.initData();
            frm.ShowDialog();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            GetData();
            Submit();
        }

        private void Submit()
        {
            if (string.IsNullOrEmpty(txtRFQNO.Text))
            {
                MessageBox.Show("客戶詢問單號不可為空!");
                return;
            }
            if (MessageBox.Show("確定" + lblMode.Text + "?", "確認", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                CommonRep<C報價單> execResult = null;
                if (lblMode.Text == "修改")
                {
                    execResult = _customerController.UpdateQuotation(form);
                }
                else if (lblMode.Text == "新增")
                {
                    execResult = _customerController.SaveQuotation(form);
                }
                if (string.IsNullOrEmpty(execResult.ErrorMessage))
                {
                    MessageBox.Show("執行" + lblMode.Text + "成功");
                    button1_Click(null, null);
                }
                else
                {
                    MessageBox.Show(execResult.ErrorMessage);
                }
            }
        }

        private void GetData()
        {
            form.IDNO = txtId.Text;
            form.QUONO = txtQUONO.Text.Trim();
            form.QUODATE = dtQUODATE.Value.ToString("yyyy-MM-dd");
            form.MTYPE = cboMType.Text;
            form.CURRENCY = currencySelect1.GetCurrency();
            form.AMOUNT = decimal.Parse(lblQuotationSummary.Text);
            form.RFQNO = txtRFQNO.Text;
            form.CONDATE = dtAvailableDate.Value.ToString("yyyy-MM-dd");
            form.ADDRESS = txtAddress.Text;
            form.價格條件 = priceCond.GetPriceCond();
            form.交貨方式 = shipMethod.GetPriceCond();
            form.付款方式 = payMethod.GetPriceCond();
            form.交貨日期 = ETDRequest.GetPriceCond();
            form.Remark = txtXomment.Text;
            form.稅率 = !string.IsNullOrEmpty(cboTaxRate.Text.Trim()) ? double.Parse(cboTaxRate.Text.Replace("%", "")) / 100.0 : 0;
            if (lblMode.Text == "建檔")
            {
                form.建檔 = AppSession.User.username;
                form.建檔日 = DateTime.Now.ToString("yyyy-MM-dd");
            }
            if (lblMode.Text == "修改")
            {
                form.修改 = AppSession.User.username;
                form.修改日 = DateTime.Now.ToString("yyyy-MM-dd");
            }
            form.quotationDetailFormList = summaryDetailGrid();
        }

        private List<C報價明細>? summaryDetailGrid()
        {
            List<C報價明細> list = new List<C報價明細>();
            try
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    int idex = 0;
                    C報價明細 data = new C報價明細();
                    data.QUONO = txtQUONO.Text;
                    data.產品編號 = row.Cells[idex++].Value.ToString();
                    data.品名規格 = row.Cells[idex++].Value.ToString();
                    data.數量 = decimal.Parse(row.Cells[idex++].Value.ToString());
                    data.單位 = row.Cells[idex++].Value.ToString();
                    data.單價 = decimal.Parse(row.Cells[idex++].Value.ToString());
                    data.金額 = data.數量 * data.單價;
                    data.描述 = row.Cells[idex++].Value.ToString();
                    list.Add(data);
                }
            }
            catch (Exception)
            {

                throw;
            }
            return list;
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            disableControls(false);
        }

        private void btnTransferToCustOrder_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCustNo.Text))
            {
                MessageBox.Show("沒有客戶帳號，不允許送出報價單!");
                return;
            }
            if (MessageBox.Show("確定新增報價單?", "確認", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (_customerController == null)
                    _customerController = new CustomerController();
                C訂單 salesOrder = new C訂單();
                CommonRep<string> soNoRep = _customerController.GetSalesOrderNo();
                if (!string.IsNullOrEmpty(soNoRep.ErrorMessage))
                {
                    MessageBox.Show(soNoRep.ErrorMessage);
                    return;
                }
                salesOrder.單號 = soNoRep.result;
                FrmCust frm = this.FindForm() as FrmCust;

                if (frm != null)
                {
                    frm.OpenNewAddSalesOrder(salesOrder);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("確認刪除?", "確認", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (_customerController == null)
                {
                    _customerController = new CustomerController();
                }
                CommonRep<C報價單> deleteRep = _customerController.DeleteQuotation(txtQUONO.Text);
                if (!string.IsNullOrEmpty(deleteRep.ErrorMessage))
                {
                    MessageBox.Show(deleteRep.ErrorMessage);
                    return;
                }
                MessageBox.Show("執行成功!");
            }
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("確定複製?", "確認", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (_customerController == null)
                    _customerController = new CustomerController();
                CommonRep<string> quonoRep = _customerController.GetQuono();
                if (!string.IsNullOrEmpty(quonoRep.ErrorMessage))
                {
                    MessageBox.Show(quonoRep.ErrorMessage);
                    return;
                }
                form.QUONO = quonoRep.result;
                CommonRep<C報價單> commonRep = _customerController.SaveQuotation(form);
                if (!string.IsNullOrEmpty(commonRep.ErrorMessage))
                {
                    MessageBox.Show(commonRep.ErrorMessage);
                    return;
                }
                else
                {
                    MessageBox.Show("複製成功!");
                    txtQUONO.Text = quonoRep.result;
                }
            }
        }

        private void btnActrivate_Click(object sender, EventArgs e)
        {
            toggleValidateForm();
        }

        private void toggleValidateForm()
        {
            if (_customerController == null)
            {
                _customerController = new CustomerController();
            }
            CommonRep<string> commonRep = _customerController.ValidateQuotation(txtQUONO.Text, string.IsNullOrEmpty(form.核准日), AppSession.User.username);
            if (!string.IsNullOrEmpty(commonRep.ErrorMessage))
            {
                MessageBox.Show(commonRep.ErrorMessage);
                return;
            }
            CommonRep<C報價單> formRep = _customerController.GetQuotation(txtQUONO.Text);
            if (!string.IsNullOrEmpty(formRep.ErrorMessage))
            {
                MessageBox.Show(formRep.ErrorMessage);
            }
            else
            {
                form = formRep.result;
                initForm();
                MessageBox.Show((!string.IsNullOrEmpty(form.核准日) ? "生效成功" : "取消失效成功"));
            }
        }

        private void btnDeactivate_Click(object sender, EventArgs e)
        {
            toggleValidateForm();
        }

        private void btnQueryTransferedOrder_Click(object sender, EventArgs e)
        {
            FrmQuoTransSO frmQuoTransSO = new FrmQuoTransSO();
            frmQuoTransSO.quotationNo = txtQUONO.Text;
            frmQuoTransSO.queryData();
            frmQuoTransSO.ShowDialog();
        }
    }
}
