using log4net;
using log4net.Config;
using MES.Core.Model;
using MES.MiddleWare.Modules;
using MES.WebAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Globalization;

namespace MES.WebAPI.Controllers
{
    /// <summary>
    /// 負責維護
    /// 1. 客戶資料
    /// 2. 客戶詢問函
    /// 3. 客戶報價單
    /// 的後端程式
    /// </summary>
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private static ILog logger = LogManager.GetLogger(typeof(ProductionController));
        private static object lockSOObj = new object();
        private static object lockRfqObj = new object();
        #region 客戶資料維護
        public CustomerController()
        {
            XmlConfigurator.Configure(new FileInfo(AppDomain.CurrentDomain.BaseDirectory + @"\log4net.config"));
        }
        /// <summary>
        /// 帶出所有客戶
        /// </summary>
        /// <returns></returns>
        [Route("api/GetCustList"), HttpGet]
        public CommonRep<C客戶設定> getCustomerList()
        {
            CommonRep<C客戶設定> commonRep = new CommonRep<C客戶設定>();
            CustomerMiddle custMiddle = new CustomerMiddle();
            try
            {
                commonRep.resultList = custMiddle.getCustomerList();
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }
        /// <summary>
        /// 帶出國別下拉資料
        /// </summary>
        /// <returns></returns>
        [Route("api/GetCountryList"), HttpGet]
        public CommonRep<C客戶國別> getCountryList()
        {
            CommonRep<C客戶國別> commonRep = new CommonRep<C客戶國別>();
            CustomerMiddle custMiddle = new CustomerMiddle();
            try
            {
                commonRep.resultList = custMiddle.getCountryList();
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }
        /// <summary>
        /// 帶出產業別下拉資料
        /// </summary>
        /// <returns></returns>
        [Route("api/GetIndustryCodeList"), HttpGet]
        public CommonRep<C產業代碼> getIndustryCodeLis()
        {
            CommonRep<C產業代碼> commonRep = new CommonRep<C產業代碼>();
            CustomerMiddle custMiddle = new CustomerMiddle();
            try
            {
                commonRep.resultList = custMiddle.getIncustryCodeList();
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }
        /// <summary>
        /// 帶出銀行下拉資料
        /// </summary>
        /// <returns></returns>
        [Route("api/GetBankCodeList"), HttpGet]
        public CommonRep<F銀行設定> getBankCodeList()
        {
            CommonRep<F銀行設定> commonRep = new CommonRep<F銀行設定>();
            CustomerMiddle custMiddle = new CustomerMiddle();
            try
            {
                commonRep.resultList = custMiddle.getBankCodeList();
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }
        /// <summary>
        /// 寫入客戶資料
        /// </summary>
        /// <param name="cust"></param>
        /// <returns></returns>
        [Route("api/SaveCustomer"), HttpPost]
        public CommonRep<C客戶設定> SaveCustomer([FromBody] C客戶設定 cust)
        {

            CommonRep<C客戶設定> commonRep = new CommonRep<C客戶設定>();
            CustomerMiddle custMiddle = new CustomerMiddle();
            try
            {
                int retCode = custMiddle.insertCustomer(cust);
                if (retCode != 0)
                {
                    commonRep.ErrorMessage = "寫入客戶資料失敗，請洽系統管理員";
                    commonRep.WorkStatus = WorkStatus.Fail.ToString();
                }
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }
        /// <summary>
        /// 更新客戶資料
        /// </summary>
        /// <param name="cust"></param>
        /// <returns></returns>
        [Route("api/UpdateCustomer"), HttpPost]
        public CommonRep<C客戶設定> UpdateCustomer([FromBody] C客戶設定 cust)
        {
            CommonRep<C客戶設定> commonRep = new CommonRep<C客戶設定>();
            try
            {
                CustomerMiddle custMiddle = new CustomerMiddle();
                int retCode = custMiddle.updateCustomer(cust);
                if (retCode != 0)
                {
                    commonRep.ErrorMessage = "更新客戶資料失敗，請洽系統管理員";
                    commonRep.WorkStatus = WorkStatus.Fail.ToString();
                }
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }
        /// <summary>
        /// 依識別碼取得單一客戶資料
        /// </summary>
        /// <param name="cust"></param>
        /// <returns></returns>
        [Route("api/GetCustomer"), HttpGet]
        public CommonRep<C客戶設定> GetCustomer([FromBody] C客戶設定 cust)
        {
            CommonRep<C客戶設定> commonRep = new CommonRep<C客戶設定>();
            try
            {
                CustomerMiddle custMiddle = new CustomerMiddle();
                commonRep.result = custMiddle.getCustomer(cust.識別);
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }
        /// <summary>
        /// 銀行下拉選單資料
        /// </summary>
        /// <returns></returns>
        [Route("api/GetBankList"), HttpGet]
        public CommonRep<F銀行設定> GetBankList()
        {
            CommonRep<F銀行設定> commonRep = new CommonRep<F銀行設定>();
            try
            {
                CustomerMiddle custMiddle = new CustomerMiddle();
                commonRep.resultList = custMiddle.getBankCodeList();
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }
        /// <summary>
        /// 刪除客戶資料
        /// </summary>
        /// <param name="cust"></param>
        /// <returns></returns>
        [Route("api/DeleteCustomer"), HttpPost]
        public CommonRep<C客戶設定> DeleteCustomer([FromBody] C客戶設定 cust)
        {
            CommonRep<C客戶設定> commonRep = new CommonRep<C客戶設定>();
            try
            {
                CustomerMiddle custMiddle = new CustomerMiddle();
                int retCode = custMiddle.deleteCustomer(cust);
                if (retCode != 0)
                {
                    commonRep.ErrorMessage = "刪除客戶資料失敗，請洽系統管理員";
                    commonRep.WorkStatus = WorkStatus.Fail.ToString();
                }
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }
        /// <summary>
        /// 停用/啟用客戶資料
        /// </summary>
        /// <param name="cust"></param>
        /// <returns></returns>
        [Route("api/UpdateCustomerExpiry"), HttpPost]
        public CommonRep<C客戶設定> UpdateCustomerExpiry([FromBody] C客戶設定 cust)
        {
            CommonRep<C客戶設定> commonRep = new CommonRep<C客戶設定>();
            try
            {
                CustomerMiddle customerMiddle = new CustomerMiddle();
                int retCode = customerMiddle.setCustomerExpiry(cust);
                if (retCode != 0)
                {
                    commonRep.ErrorMessage = "停用客戶失敗，請洽系統管理員";
                    commonRep.WorkStatus = WorkStatus.Fail.ToString();
                }
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }
        /// <summary>
        /// 取得客戶的公司列表
        /// </summary>
        /// <returns></returns>
        [Route("api/GetCompanyList"), HttpGet]
        public CommonRep<string> getCompanyList()
        {
            CommonRep<string> commonRep = new CommonRep<string>();
            try
            {
                CustomerMiddle customerMiddle = new CustomerMiddle();
                List<C客戶設定> allCustomers = customerMiddle.getCustomerList();
                foreach (var item in allCustomers)
                {
                    if (commonRep.resultList == null)
                        commonRep.resultList = new List<string>();
                    if (!string.IsNullOrEmpty(item.COMPANY))
                        commonRep.resultList.Add(item.COMPANY);
                }
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }
        /// <summary>
        /// 取得業務清單
        /// </summary>
        /// <returns></returns>
        [Route("api/GetSalesList"), HttpGet]
        public CommonRep<H員工清冊> getSalesList()
        {
            CommonRep<H員工清冊> commonRep = new CommonRep<H員工清冊>();
            CustomerMiddle customerMiddle = new CustomerMiddle();
            try
            {
                commonRep.resultList = customerMiddle.getSalesList();
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }
        /// <summary>
        /// 取得單一客戶資料
        /// </summary>
        /// <param name="companyName"></param>
        /// <returns></returns>
        [Route("api/GetUniqueCust"), HttpGet]
        public CommonRep<C客戶設定> GetUniqueCust(string companyName)
        {
            CommonRep<C客戶設定> commonRep = new CommonRep<C客戶設定>();
            try
            {
                CustomerMiddle customerMiddle = new CustomerMiddle();
                commonRep.result = customerMiddle.getCustByName(companyName);
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }
        /// <summary>
        /// 取得客戶的聯絡人清單
        /// </summary>
        /// <param name="companyName"></param>
        /// <returns></returns>
        [Route("api/GetContactList"), HttpGet]
        public CommonRep<C客戶連絡人清單> GetContactList(string? companyName)
        {
            CommonRep<C客戶連絡人清單> commonRep = new CommonRep<C客戶連絡人清單>();
            try
            {
                CustomerMiddle middle = new CustomerMiddle();
                commonRep.resultList = middle.getContactList(companyName);
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }
        /// <summary>
        /// 取得銷售潛力清單
        /// </summary>
        /// <returns></returns>
        [Route("api/GetRankingList"), HttpGet]
        public CommonRep<C成交潛力值> GetRankingList()
        {
            CommonRep<C成交潛力值> commonRep = new CommonRep<C成交潛力值>();
            CustomerMiddle customerMiddle = new CustomerMiddle();
            try
            {
                commonRep.resultList = customerMiddle.getRankingList();
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }
        /// <summary>
        /// 取得客戶狀態清單
        /// </summary>
        /// <returns></returns>
        [Route("api/GetCustStatusList"), HttpGet]
        public CommonRep<C客戶動態> GetCustStatusList()
        {
            CommonRep<C客戶動態> commonRep = new CommonRep<C客戶動態>();
            CustomerMiddle customerMiddle = new CustomerMiddle();
            try
            {
                commonRep.resultList = customerMiddle.getCustStatusList();
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }
        /// <summary>
        /// 取得轉介代理清單
        /// </summary>
        /// <returns></returns>
        [Route("api/GetAgentOptionList"), HttpGet]
        public CommonRep<C轉介代理> GetGetAgentOptionList()
        {
            CommonRep<C轉介代理> commonRep = new CommonRep<C轉介代理>();
            CustomerMiddle customerMiddle = new CustomerMiddle();
            try
            {
                commonRep.resultList = customerMiddle.getAgentOptionList();
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }
        #endregion
        #region 詢價單
        /// <summary>
        /// 取得客戶詢問清單
        /// </summary>
        /// <returns></returns>
        [Route("api/GetSalesRecordList"), HttpGet]
        public CommonRep<C客戶詢問函> GetSalesRecordList()
        {
            CommonRep<C客戶詢問函> commonRep = new CommonRep<C客戶詢問函>();
            CustomerMiddle customerMiddle = new CustomerMiddle();
            try
            {
                commonRep.resultList = customerMiddle.getSalesRecordList();
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }
        /// <summary>
        /// 客戶詢問單取號
        /// </summary>
        /// <returns></returns>
        [Route("api/GetRfqNo"), HttpGet]
        public CommonRep<string> GetRfqNo()
        {
            CommonRep<string> commonRep = new CommonRep<string>();
            try
            {
                CustomerMiddle customerMiddle = new CustomerMiddle();
                commonRep.result = customerMiddle.getRfqNo();
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }
        [Route("api/GetRfq"), HttpGet]
        public CommonRep<C客戶詢問函> GetRfq(string? rfqno)
        {
            CommonRep< C客戶詢問函> commonRep = new CommonRep<C客戶詢問函>();
            try
            {
                CustomerMiddle customerMiddle = new CustomerMiddle();
                commonRep.result = customerMiddle.getRfq(rfqno);
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }
        /// <summary>
        /// 取得業務工作紀錄
        /// </summary>
        /// <param name="rfqNo"></param>
        /// <returns></returns>
        [Route("api/GetSalesWorkRecordList"), HttpGet]
        public CommonRep<工作紀錄A> GetSalesWorkRecordList(string rfqNo)
        {
            CommonRep<工作紀錄A> commonRep = new CommonRep<工作紀錄A>();
            try
            {
                CustomerMiddle customerMiddle = new CustomerMiddle();
                commonRep.resultList = customerMiddle.geRfqSalesWorkRecordList(rfqNo).ToList();
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }
        /// <summary>
        /// 寫入客戶詢問函
        /// </summary>
        /// <param name="custInqForm"></param>
        /// <returns></returns>
        [Route("api/SaveRfq"), HttpPost]
        public CommonRep<C客戶詢問函> SaveRfq([FromBody] C客戶詢問函 custInqForm)
        {
            CommonRep<C客戶詢問函> commonRep = new CommonRep<C客戶詢問函>();
            try
            {
                lock (lockRfqObj)
                {
                    CustomerMiddle customerMiddle = new CustomerMiddle();
                    int retCode = customerMiddle.insertRfq(custInqForm);
                    if (retCode == 0)
                    {
                        commonRep.ErrorMessage = "寫入客戶資料失敗，請洽系統管理員";
                        commonRep.WorkStatus = WorkStatus.Fail.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }
        /// <summary>
        /// 更新客戶詢問函
        /// </summary>
        /// <param name="custInqForm"></param>
        /// <returns></returns>
        [Route("api/UpdateRfq"), HttpPost]
        public CommonRep<C客戶詢問函> UpdateRfq([FromBody] C客戶詢問函 custInqForm)
        {
            CommonRep<C客戶詢問函> commonRep = new CommonRep<C客戶詢問函>();
            try
            {
                lock (lockRfqObj)
                {
                    CustomerMiddle customerMiddle = new CustomerMiddle();
                    int retCode = customerMiddle.UpdateRfq(custInqForm);
                    if (retCode != 0)
                    {
                        commonRep.ErrorMessage = "更新客戶資料失敗，請洽系統管理員";
                        commonRep.WorkStatus = WorkStatus.Fail.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }
        /// <summary>
        /// 刪除客戶詢問函
        /// </summary>
        /// <param name="rfqNo"></param>
        /// <returns></returns>
        [Route("api/DeleteRfq"), HttpGet]
        public CommonRep<C客戶詢問函> DeleteRfq(string rfqNo)
        {
            CommonRep<C客戶詢問函> commonRep = new CommonRep<C客戶詢問函>();
            try
            {
                lock (lockRfqObj)
                {
                    CustomerMiddle customerMiddle = new CustomerMiddle();
                    int retCode = customerMiddle.DeleteRfq(rfqNo);
                    if (retCode != 0)
                    {
                        commonRep.ErrorMessage = "刪除客戶資料失敗，請洽系統管理員";
                        commonRep.WorkStatus = WorkStatus.Fail.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }
        #endregion
        #region 報價單
        /// <summary>
        /// 產生報價單號
        /// </summary>
        /// <returns></returns>
        [Route("api/GetQuono"), HttpGet]
        public CommonRep<string> GetQuono()
        {
            CommonRep<string> commonRep = new CommonRep<string>();
            CustomerMiddle customerMiddle = new CustomerMiddle();
            try
            {
                commonRep.result = customerMiddle.getQuono();
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }
        /// <summary>
        /// 依詢問單找報價單
        /// </summary>
        /// <param name="rfqNo"></param>
        /// <returns></returns>
        [Route("api/GetQuotationList"), HttpGet]
        public CommonRep<C報價單> GetQuotationList(string? rfqNo)
        {
            CommonRep<C報價單> commonRep = new CommonRep<C報價單>();
            try
            {
                CustomerMiddle customerMiddle = new CustomerMiddle();
                if (!string.IsNullOrEmpty(rfqNo))
                {
                    commonRep.resultList = customerMiddle.getQuotationList(rfqNo).ToList();
                }
                else
                {
                    commonRep.resultList = customerMiddle.getQuotationList(rfqNo).ToList();
                }
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }
        /// <summary>
        /// 找尋報價單細項資料
        /// </summary>
        /// <param name="quono"></param>
        /// <returns></returns>
        [Route("api/GetQuotationDetailList"), HttpGet]
        public CommonRep<C報價明細> GetQuotationDetailList(string quono)
        {
            CommonRep<C報價明細> commonRep = new CommonRep<C報價明細>();
            try
            {
                CustomerMiddle customerMiddle = new CustomerMiddle();
                commonRep.resultList = customerMiddle.getQuotationDetailList(quono).ToList();
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }
        /// <summary>
        /// 機台類別清單
        /// </summary>
        /// <returns></returns>
        [Route("api/GetEqpType"), HttpGet]
        public CommonRep<A機台類型> GetEqpType()
        {
            CommonRep<A機台類型> commonRep = new CommonRep<A機台類型>();
            try
            {
                CustomerMiddle customerMiddle = new CustomerMiddle();
                commonRep.resultList = customerMiddle.getEqpType();
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }
        /// <summary>
        /// 幣別清單
        /// </summary>
        /// <returns></returns>
        [Route("api/GetCurrencyList"), HttpGet]
        public CommonRep<F幣別> GetCurrencyList()
        {
            CommonRep<F幣別> commonRep = new CommonRep<F幣別>();
            try
            {
                CustomerMiddle customerMiddle = new CustomerMiddle();
                commonRep.resultList = customerMiddle.getCurrencyList();
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
                //throw;
            }
            return commonRep;
        }
        /// <summary>
        /// 匯率清單
        /// </summary>
        /// <param name="currency"></param>
        /// <returns></returns>
        [Route("api/GetExRateList"), HttpGet]
        public CommonRep<F匯率> GetExRateList(string currency)
        {
            CommonRep<F匯率> commonRep = new CommonRep<F匯率>();
            try
            {
                CustomerMiddle customerMiddle = new CustomerMiddle();
                commonRep.resultList = customerMiddle.getExRateList(currency);
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }
        /// <summary>
        /// 稅率清單
        /// </summary>
        /// <param name="currency"></param>
        /// <returns></returns>
        [Route("api/GetTaxRateList"), HttpGet]
        public CommonRep<string> GetTaxRateList()
        {
            CommonRep<string> commonRep = new CommonRep<string>();
            try
            {
                CustomerMiddle customerMiddle = new CustomerMiddle();
                commonRep.resultList = new string[] { "0", "0.05" }.ToList();
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }
        /// <summary>
        /// 報價單下拉選單資料來源-訂單交易條件
        /// T:價格條件
        /// R:交期要求
        /// D:交貨方式
        /// Y:付款條件
        /// </summary>
        /// <param name="condition"></param>
        /// <returns></returns>
        [Route("api/GetTxCondition"), HttpGet]
        public CommonRep<F訂單交易條件> GetTxCondition(string condition)
        {
            CommonRep<F訂單交易條件> commonRep = new CommonRep<F訂單交易條件>();
            try
            {
                CustomerMiddle customerMiddle = new CustomerMiddle();
                string[] typeArr = condition.Split(',');
                foreach(var type in typeArr)
                {
                    commonRep.resultList.AddRange(customerMiddle.getTxCondition(type));
                }
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }
        /// <summary>
        /// 儲存報價單
        /// </summary>
        /// <param name="form"></param>
        /// <returns></returns>
        [Route("api/SaveQuotation"), HttpPost]
        public CommonRep<C報價單> SaveQuotation([FromBody] C報價單 form)
        {
            CommonRep<C報價單> commonRep = new CommonRep<C報價單>();
            CustomerMiddle customerMiddle = new CustomerMiddle();
            int retCode = 0;
            try
            {
                retCode = customerMiddle.saveQuotation(form);
                if (retCode == 0)
                {
                    commonRep.ErrorMessage = "寫入客戶資料失敗，請洽系統管理員";
                    commonRep.WorkStatus = WorkStatus.Fail.ToString();
                }
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }
        /// <summary>
        /// 更新報價單
        /// </summary>
        /// <param name="form"></param>
        /// <returns></returns>
        [Route("api/UpdateQuotation"), HttpPost]
        public CommonRep<C報價單> UpdateQuotation([FromBody] C報價單 form)
        {
            CommonRep<C報價單> commonRep = new CommonRep<C報價單>();
            CustomerMiddle customerMiddle = new CustomerMiddle();
            int retCode = 0;
            try
            {
                retCode = customerMiddle.updateQuotation(form);
                if (retCode == 0)
                {
                    commonRep.ErrorMessage = "寫入客戶資料失敗，請洽系統管理員";
                    commonRep.WorkStatus = WorkStatus.Fail.ToString();
                }
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }
        /// <summary>
        /// 刪除報價單
        /// </summary>
        /// <param name="quono"></param>
        /// <returns></returns>
        [Route("api/DeleteQuotation"), HttpGet]
        public CommonRep<C報價單> DeleteQuotation(string quono)
        {
            CommonRep<C報價單> commonRep = new CommonRep<C報價單>();
            C報價單 quo = new C報價單();
            quo.QUONO = quono;
            CustomerMiddle customerMiddle = new CustomerMiddle();
            int retCode = 0;
            try
            {
                retCode = customerMiddle.deleteQuotation(quo);
                if (retCode != 0)
                {
                    commonRep.ErrorMessage = "寫入客戶資料失敗，請洽系統管理員";
                    commonRep.WorkStatus = WorkStatus.Fail.ToString();
                }
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }
        /// <summary>
        /// 依單號取得報價單
        /// </summary>
        /// <param name="quono"></param>
        /// <returns></returns>
        [Route("api/GetQuotation"), HttpGet]
        public CommonRep<C報價單> GetQuotation(string? quono)
        {
            CommonRep<C報價單> commonRep = new CommonRep<C報價單>();
            C報價單 quo = new C報價單();
            quo.QUONO = quono;
            CustomerMiddle customerMiddle = new CustomerMiddle();
            int retCode = 0;
            try
            {
                quo = customerMiddle.getQuotation(quo);
                commonRep.result = quo;
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }
        /// <summary>
        /// 停用/啟用報價單
        /// </summary>
        /// <param name="quono"></param>
        /// <param name="type"></param>
        /// <param name="account"></param>
        /// <returns></returns>
        [Route("api/UpdateQuotationExpiry"), HttpGet]
        public CommonRep<C報價單> UpdateQuotationExpiry(string? quono, string? type, string? account)
        {
            CommonRep<C報價單> commonRep = new CommonRep<C報價單>();
            try
            {
                CustomerMiddle customerMiddle = new CustomerMiddle();
                commonRep.result = customerMiddle.updateQuotationExpiry(quono, type, account);
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }
        /// <summary>
        /// 取得單一客戶資料
        /// </summary>
        /// <param name="company"></param>
        /// <returns></returns>
        [Route("api/GetCompany"), HttpGet]
        public CommonRep<C客戶設定> GetCompany(string? company)
        {
            CommonRep<C客戶設定> commonRep = new CommonRep<C客戶設定>();
            C客戶設定 quo = new C客戶設定();
            quo.COMPANY = company;
            CustomerMiddle customerMiddle = new CustomerMiddle();
            int retCode = 0;
            try
            {
                quo = customerMiddle.getCompany(quo);
                commonRep.result = quo;
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }
        /// <summary>
        /// 報價單轉開訂單
        /// </summary>
        /// <param name="form"></param>
        /// <returns></returns>
        [Route("api/TransferToSalesOrder"), HttpPost]
        public CommonRep<string> TransferToSalesOrder([FromBody] C報價單 form)
        {
            CommonRep<string> commonRep = new   CommonRep<string>();
            CustomerMiddle customerMiddle = new CustomerMiddle();
            try
            {
                int retCode = 0;
                retCode = customerMiddle.transferToSalesOrder(form);
                if (retCode == 0)
                {
                    commonRep.ErrorMessage = "寫入訂單資料失敗，請洽系統管理員";
                    commonRep.WorkStatus = WorkStatus.Fail.ToString();
                }
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }
        #endregion
        #region 訂單
        /// <summary>
        /// 取得訂單列表
        /// </summary>
        /// <returns></returns>
        [Route("api/GetSalesOrderList"), HttpGet]
        public CommonRep<C訂單> GetSalesOrderList()
        {
            CommonRep<C訂單> list = new CommonRep<C訂單>();
            CustomerMiddle customerMiddle = new CustomerMiddle();
            try
            {
                list.resultList = customerMiddle.getSalesOrderList();
            }
            catch (Exception ex)
            {
                list.ErrorMessage = ex.Message;
                list.WorkStatus = WorkStatus.Fail.ToString();
            }
            return list;
        }
        [Route("api/GetCustNumberList"), HttpGet]
        public CommonRep<C客戶設定> GetCustNumberList()
        {
            CommonRep<C客戶設定> commonRep = new CommonRep<C客戶設定>();
            CustomerMiddle customerMiddle = new CustomerMiddle();
            try
            {
                commonRep.resultList = customerMiddle.getCustomerNumberList();
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }
        [Route("api/UpdateSalesOrderCloseFlag"), HttpGet]
        public CommonRep<C訂單> UpdateSalesOrderCloseFlag(bool flag, string orderNo)
        {
            CommonRep<C訂單> commonRep = new CommonRep<C訂單>();
            try
            {
                CustomerMiddle customerMiddle = new CustomerMiddle();
                commonRep.result = customerMiddle.updateSalesOrderCloseFlag(flag, orderNo);//TO-DO
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }
        /// <summary>
        /// 儲存訂單
        /// </summary>
        /// <param name="form"></param>
        /// <returns></returns>
        [Route("api/SaveSalesOrder"), HttpPost]
        public CommonRep<C訂單> SaveSalesOrder([FromBody] C訂單 form)
        {
            CommonRep<C訂單> commonRep = new CommonRep<C訂單>();
            try
            {
                lock (lockSOObj)
                {
                    CustomerMiddle customerMiddle = new CustomerMiddle();
                    int retCode = 0;
                    retCode = customerMiddle.saveSalesOrder(form);
                    if (retCode == 0)
                    {
                        commonRep.ErrorMessage = "寫入訂單資料失敗，請洽系統管理員";
                        commonRep.WorkStatus = WorkStatus.Fail.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }
        /// <summary>
        /// 更新訂單
        /// </summary>
        /// <param name="form"></param>
        /// <returns></returns>
        [Route("api/UpdateSalesOrder"), HttpPost]
        public CommonRep<C訂單> UpdateSalesOrder([FromBody] C訂單 form)
        {
            CommonRep<C訂單> commonRep = new CommonRep<C訂單>();
            try
            {
                lock (lockSOObj)
                {
                    CustomerMiddle customerMiddle = new CustomerMiddle();
                    int retCode = 0;
                    retCode = customerMiddle.updateSalesOrder(form);
                    if (retCode == 0)
                    {
                        commonRep.ErrorMessage = "更新訂單資料失敗，請洽系統管理員";
                        commonRep.WorkStatus = WorkStatus.Fail.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }
        /// <summary>
        /// 產生訂單號碼
        /// </summary>
        /// <returns></returns>
        [Route("api/GetSalesOrderNo"), HttpGet]
        public CommonRep<string> GetSalesOrderNo()
        {
            CommonRep<string> commonRep = new CommonRep<string>();
            CustomerMiddle customerMiddle = new CustomerMiddle();
            try
            {
                commonRep.result = customerMiddle.getSalesOrderNo();
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }
        /// <summary>
        /// 刪除訂單
        /// </summary>
        /// <param name="salesOrderNo"></param>
        /// <returns></returns>
        [Route("api/DeleteSalesOrderNo"), HttpGet]
        public CommonRep<C訂單> DeleteSalesOrderNo(string salesOrderNo)
        {
            CommonRep<C訂單> commonRep = new CommonRep<C訂單>();
            try
            {
                lock (lockSOObj)
                {
                    CustomerMiddle customerMiddle = new CustomerMiddle();
                    int retCode = 0;
                    retCode = customerMiddle.deleteSalesOrder(salesOrderNo);
                    if (retCode == 0)
                    {
                        commonRep.ErrorMessage = "刪除訂單資料失敗，請洽系統管理員";
                        commonRep.WorkStatus = WorkStatus.Fail.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }
        /// <summary>
        /// 取得稅別
        /// </summary>
        /// <returns></returns>
        [Route("api/GetTaxType"), HttpGet]
        public CommonRep<string> GetTaxType()
        {
            CommonRep<string> commonRep = new CommonRep<string>();
            CustomerMiddle customerMiddle = new CustomerMiddle();
            try
            {
                commonRep.resultList = new string[] { "應稅", "零稅率", "免稅" }.ToList();
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }
        [Route("api/GetInstallmentType"), HttpGet]
        public CommonRep<F款項期別> GetInstallmentType()
        {
            CommonRep<F款項期別> commonRep = new CommonRep<F款項期別>();
            CustomerMiddle customerMiddle = new CustomerMiddle();
            try
            {
                commonRep.resultList = customerMiddle.getInstallmentType();
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }
        [Route("api/GetBankInfo"), HttpGet]
        public CommonRep<F銀行設定> GetBankInfo(string? bankAccount)
        {
            CommonRep<F銀行設定> commonRep = new CommonRep<F銀行設定>();
            CustomerMiddle customerMiddle = new CustomerMiddle();
            try
            {
                commonRep.result = customerMiddle.getBankInfo(bankAccount);
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }
        [Route("api/GetQuotationDistributionList"), HttpGet]
        public CommonRep<C報價明細> GetBankInfo(string? custNo, string? orderDate)
        {
            CommonRep<C報價明細> commonRep = new CommonRep<C報價明細>();
            CustomerMiddle customerMiddle = new CustomerMiddle();
            orderDate = DateTime.ParseExact(orderDate, "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture).ToString("yyyy-MM-dd");
            try
            {
                commonRep.resultList = customerMiddle.getQuotationDistrubutionList(custNo, orderDate);
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }
        [Route("api/TransferToShipOrder")]
        public CommonRep<C訂單> TransferToShipOrder([FromBody] C訂單 form)
        {
            CommonRep<C訂單> commonRep = new CommonRep<C訂單>();
            CustomerMiddle customerMiddle = new CustomerMiddle();
            try
            {
                int execCnt = customerMiddle.transferToShipOrder(form);
                if (execCnt == 0)
                {
                    commonRep.ErrorMessage = "寫入出貨單有誤，請洽系統人員";
                    commonRep.WorkStatus = WorkStatus.Fail.ToString();
                }
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }
        #endregion
        #region 出貨單
        [Route("api/GetShippingOrderList"), HttpGet]
        public CommonRep<C出貨單> GetShippingOrderList()
        {
            CommonRep<C出貨單> commonRep = new CommonRep<C出貨單>();
            CustomerMiddle customerMiddle = new CustomerMiddle();
            try
            {
                commonRep.resultList = customerMiddle.getShippingOrderList();
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }
        [Route("api/GetWarehouseList"), HttpGet]
        public CommonRep<F庫別> GetWarehouseList()
        {
            CommonRep<F庫別> commonRep = new CommonRep<F庫別>();
            try
            {
                commonRep.resultList = new CustomerMiddle().getWarehouseList();
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }
        #endregion
    }
}
