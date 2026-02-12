using log4net;
using log4net.Config;
using MES.Core.Model;
using MES.MiddleWare.Modules;
using MES.WebAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace MES.WebAPI.Controllers
{
    /// <summary>
    /// 負責維護客戶資料的後端程式
    /// </summary>
    public class CustomerController : ControllerBase
    {
        private static ILog logger = LogManager.GetLogger(typeof(ProductionController));
        public CustomerController()
        {
            XmlConfigurator.Configure(new FileInfo(AppDomain.CurrentDomain.BaseDirectory + @"\log4net.config"));
        }
        /// <summary>
        /// 帶出所有客戶
        /// </summary>
        /// <returns></returns>
        [Route("api/GetCustList"),  HttpGet]
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
        public CommonRep<C客戶設定> SaveCustomer([FromBody]C客戶設定 cust)
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
        public CommonRep<C客戶連絡人清單> GetContactList(string companyName)
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
        /// 
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
                throw;
            }
            return commonRep;
        }
        [Route("api/GetQuotationList"), HttpGet]
        public CommonRep<C報價單> GetQuotationList(string rfqNo)
        {
            CommonRep<C報價單> commonRep = new CommonRep<C報價單>();
            try
            {
                CustomerMiddle customerMiddle = new CustomerMiddle();
                commonRep.resultList = customerMiddle.getQuotationList(rfqNo).ToList();
            }
            catch (Exception ex)
            {
                throw;
            }
            return commonRep;
        }

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
                throw;
            }
            return commonRep;
        }
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
                throw;
            }
            return commonRep;
        }
    }
}
