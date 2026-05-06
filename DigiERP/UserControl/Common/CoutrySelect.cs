using MES.Core.Model;
using MES.WebAPI.Controllers;
using MES.WebAPI.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigiERP.UserControl.Common
{
    public partial class CoutrySelect : System.Windows.Forms.UserControl
    {
        private string _countryCode { get; set; }
        public void SetCountryCode(string countryCode)
        {
            _countryCode = countryCode;
            cboCountryList.SelectedValue = countryCode;
        }
        public string GetCountryCode()
        {
            return _countryCode;
        }
        public CoutrySelect()
        {
            InitializeComponent();
        }

        public void inflateDropDownList()
        {
            CustomerController customerController = new CustomerController();
            CommonRep<C客戶國別> commonRep = customerController.getCountryList();
            var list = new List<object>();
            list.Add(new
            {
                國別 = string.Empty,
                CODE = string.Empty,
            });
            foreach (var country in commonRep.resultList)
            {
                list.Add(new
                {
                    國別 = country.國別,
                    CODE = country.CODE,
                });
            }
            cboCountryList.DataSource = list;
            cboCountryList.DisplayMember = "國別";
            cboCountryList.ValueMember = "CODE";

            lblCountryName.Text = string.Empty;
        }

        private void cboCountryList_SelectedIndexChanged(object sender, EventArgs e)
        {
            dynamic item = cboCountryList.SelectedItem;
            lblCountryName.Text = item.CODE;
        }
    }
}
