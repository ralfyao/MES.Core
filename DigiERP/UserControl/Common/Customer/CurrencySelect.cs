using DigiERP.Common;
using MES.Core.Model;
using MES.WebAPI.Controllers;
using MES.WebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigiERP.UserControl.Common.Customer
{
    public class CurrencySelect:CommonComboBox
    {
        private Color backColor;
        protected override void OnEnter(EventArgs e)
        {
            base.OnEnter(e);
            backColor = this.BackColor;
            this.BackColor = Color.LightYellow;
        }
        protected override void OnLeave(EventArgs e)
        {
            base.OnLeave(e);

            this.BackColor = backColor;
        }

        private List<F幣別> currencyList { get; set; }
        private CustomerController _customerController;
        public CurrencySelect()
        {
            _customerController = new CustomerController();
            //initCurrencyList();
        }

        public void initCurrencyList()
        {
            CommonRep<F幣別> commonRep = _customerController.GetCurrencyList();
            if (!string.IsNullOrEmpty(commonRep.ErrorMessage))
            {
                MessageBox.Show(commonRep.ErrorMessage);
                return;
            }
            commonRep.resultList.Insert(0, new F幣別 { CURRENCY = "" });
            currencyList = commonRep.resultList;
            this.DataSource = currencyList; 
        }
        public void SetCurrency(string currency)
        {
            DisplayMember = "CURRENCY";
            ValueMember = "CURRENCY";
            foreach (var item in this.Items)
            {
                if (((F幣別)item).CURRENCY == currency)
                {
                    this.SelectedItem = item;
                }
            }
        }
        public string GetCurrency()
        {
            return this.Text;
        }
        public event EventHandler CurrencyChanged;

        protected override void OnSelectedIndexChanged(EventArgs e)
        {
            base.OnSelectedIndexChanged(e);

            CurrencyChanged?.Invoke(this, EventArgs.Empty);
        }
    }
}
