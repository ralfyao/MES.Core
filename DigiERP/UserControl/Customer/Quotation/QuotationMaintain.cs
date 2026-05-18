using DigiERP.Common;
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

namespace DigiERP.UserControl.Customer.Quotation
{
    public partial class QuotationMaintain : CommonUserControl
    {
        public C報價單 form;
        public string mode;
        public QuotationMaintain()
        {
            InitializeComponent();
            initForm();
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
                exRate.Value =decimal.Parse(commonRep.resultList[0]?.匯率 == null ? "0" : commonRep.resultList[0]?.匯率);
            else
                exRate.Value = 0;
            //txtCurrency.Text = currencySelect1.GetCurrency();
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
                CommonRep<C客戶設定> commonRep = _customerController.GetCustomer(new C客戶設定() { COMPANY = form.COMPANY });
                if (!string.IsNullOrEmpty(commonRep.ErrorMessage))
                {
                    MessageBox.Show(commonRep.ErrorMessage);
                    return;
                }
                else
                {
                    _customer = commonRep.result;
                }
                dtQUODATE.Value = !string.IsNullOrEmpty(form.QUODATE) ? DateTime.Parse(form.QUODATE) : DateTime.Parse("1900-01-01");
                txtQUONO.Text           = form.QUONO;
                txtCustNo.Text          = _customer?.正航編號;
                txtCustAlias.Text       = _customer?.欄位2;
                dtAvailableDate.Value   = !string.IsNullOrEmpty(form.CONDATE) ? DateTime.Parse(form.CONDATE) : DateTime.Parse("1900-01-01");
                txtCompany.Text         = _customer?.COMPANY;
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
                int index = 0;
                dataGridView1.Rows.Clear();
                foreach(var item in form.quotationDetailFormList)
                {

                }
            }
            else
            {
                dtQUODATE.Value = DateTime.Parse("1900-01-01");
                txtQUONO.Text               = string.Empty;
                txtCustNo.Text              = string.Empty;
                txtCustAlias.Text           = string.Empty;
                dtAvailableDate.Value       = DateTime.Parse("1900-01-01");
                txtCompany.Text             = string.Empty;
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
            }
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
            CommonRep<F匯率> commonRepExRate = _customerController.GetExRateList(currency);
            if (!string.IsNullOrEmpty(commonRepExRate.ErrorMessage))
            {
                MessageBox.Show(commonRepExRate.ErrorMessage);
                return;
            }
            exRate.Value = decimal.Parse(commonRepExRate.resultList[0]?.匯率 == null ? "0" : commonRepExRate.resultList[0]?.匯率) ;
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
    }
}
