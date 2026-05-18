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

namespace DigiERP.UserControl.Common
{
    public partial class PriceCondControl : CommonUserControl
    {
        public PriceCondControl()
        {
            InitializeComponent();
            initPriceCondList();
            TabStop = true;
        }
        public CommonComboBox InnerComboBox
        {
            get { return cboPriceCond; }
        }
        private CustomerController _customerController;
        public string txType { get; set; }

        private void initPriceCondList()
        {
            // throw new NotImplementedException();
            if (null == _customerController)
            {
                _customerController = new CustomerController();
            }
            CommonRep<F訂單交易條件> commonRep = _customerController.GetTxCondition(txType);
            if (!string.IsNullOrEmpty(commonRep.ErrorMessage))
            {
                MessageBox.Show(commonRep.ErrorMessage);
                return;
            }
            commonRep.resultList.Insert(0, new F訂單交易條件() { 條文名稱 = "", 條文編號 = "", 識別碼 = -1 });
            cboPriceCond.DataSource = commonRep.resultList;
            cboPriceCond.DisplayMember = "條文編號";
            cboPriceCond.ValueMember = "條文編號";
        }
        public void SetPriceCond(string priceCond)
        {
            initPriceCondList();
            foreach (var item in cboPriceCond.Items)
            {
                if (((F訂單交易條件)item).條文編號 == priceCond)
                {
                    cboPriceCond.SelectedItem = item;
                    cboPriceCond.Text = ((F訂單交易條件)item).條文編號;
                    lblPriceCond.Text = ((F訂單交易條件)item).條文名稱;
                    return;
                }
            }
            lblPriceCond.Text = string.Empty;
        }
        public string GetPriceCond()
        {
            return cboPriceCond.Text;
        }

        private void lblPriceCond_Click(object sender, EventArgs e)
        {

        }

        private void cboPriceCond_SelectedIndexChanged(object sender, EventArgs e)
        {
            F訂單交易條件 item = (F訂單交易條件)cboPriceCond.SelectedItem;
            lblPriceCond.Text = item.條文名稱;
        }
    }
}
