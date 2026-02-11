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
    }
}
