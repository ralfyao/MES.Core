using MES.Core.Model;
using MES.WebAPI.Controllers;
using MES.WebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigiERP.Util
{
    public class ControlUtil
    {
        public static void initCountrySelect(ComboBox cboCountry)
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
            cboCountry.DataSource = list;
            cboCountry.DisplayMember = "國別";
            cboCountry.ValueMember = "CODE";
        }
    }
}
