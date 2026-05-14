using DigiERP.Common;
using DigiERP.UserControl.Common;
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
        /// <summary>
        /// 填充國別下拉選單的資料
        /// </summary>
        /// <param name="cboCountry"></param>
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

        public static void initAgentList(ComboBox cboAgentList)
        {
            List<C轉介代理> agentList = new CustomerController().GetGetAgentOptionList().resultList;
            cboAgentList.DataSource = agentList;
            cboAgentList.ValueMember = "AGENT";
            cboAgentList.DisplayMember = "AGENT";
        }

        internal static void initIndustryCodeList(IndustryCodeSelect industryCodeSelect1)
        {
            List<C產業代碼> industryCodeList = new CustomerController().getIndustryCodeLis().resultList;
            industryCodeSelect1.SetDataSource(industryCodeList);
            //throw new NotImplementedException();
        }

        internal static void initStatusSelect(RFQStatusSelect cboStatusSelect)
        {
            List<C客戶動態> cs = new CustomerController().GetCustStatusList().resultList;
            cboStatusSelect.SetDataSource(cs);
        }
    }
}
