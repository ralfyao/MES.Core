using MES.Core.Model;
using MES.MiddleWare.Modules;
using MES.WebAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace MES.WebAPI.Controllers
{
    [ApiController]
    public class ARController : ControllerBase
    {
        #region 應收入帳
        /// <summary>
        /// 產生應收單號
        /// </summary>
        /// <returns></returns>
        [Route("api/GetArNo"), HttpGet]
        public CommonRep<string> GetArNo()
        {
            CommonRep<string> commonRep = new CommonRep<string>();
            ARMiddle arMiddle = new ARMiddle();
            try
            {
                commonRep.result = arMiddle.getARNo();
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }
        /// <summary>
        /// 產生應收單號
        /// </summary>
        /// <returns></returns>
        [Route("api/GetArList"), HttpGet]
        public CommonRep<F收款> GetArList()
        {
            CommonRep<F收款> commonRep = new CommonRep<F收款>();
            ARMiddle arMiddle = new ARMiddle();
            try
            {
                commonRep.resultList = arMiddle.getARList();
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }
        /// <summary>
        /// 帳款來源與沖帳碼
        /// </summary>
        /// <returns></returns>
        [Route("api/GetARAccountSourceAndCode"), HttpGet]
        public CommonRep<F帳款管理> GetAccountSourceAndCode(string? custNo)
        {
            
            CommonRep<F帳款管理> commonRep = new CommonRep<F帳款管理>();
            ARMiddle arMiddle = new ARMiddle();
            try
            {
                commonRep.resultList = arMiddle.getAccountSourceAndCode(custNo, "應收");
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }
        /// <summary>
        /// 儲存應收入帳單
        /// </summary>
        /// <param name="form"></param>
        /// <returns></returns>
        [Route("api/SaveAR"), HttpPost]
        public CommonRep<F收款> SaveAR([FromBody] F收款 form)
        {
            CommonRep<F收款> commonRep = new CommonRep<F收款>();
            if (form == null)
            {
                commonRep.ErrorMessage = "送出表單為NULL!";
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
                return commonRep;
            }
            try
            {
                ARMiddle aRMiddle = new ARMiddle();
                int execCnt = aRMiddle.saveAR(form);
                if (execCnt == 0)
                {
                    commonRep.ErrorMessage = "執行寫入發生錯誤，請洽系統人員!";
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
        /// 修改應收入帳單
        /// </summary>
        /// <param name="form"></param>
        /// <returns></returns>
        [Route("api/UpdateAR"), HttpPost]
        public CommonRep<F收款> UpdateAR([FromBody] F收款 form)
        {
            CommonRep<F收款> commonRep = new CommonRep<F收款>();
            if (form == null)
            {
                commonRep.ErrorMessage = "送出表單為NULL!";
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
                return commonRep;
            }
            try
            {
                ARMiddle aRMiddle = new ARMiddle();
                int execCnt = aRMiddle.updateAR(form);
                if (execCnt == 0)
                {
                    commonRep.ErrorMessage = "執行寫入發生錯誤，請洽系統人員!";
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
        /// 刪除應收入帳單
        /// </summary>
        /// <param name="form"></param>
        /// <returns></returns>
        [Route("api/DeleteAR"), HttpPost]
        public CommonRep<F收款> DeleteAR([FromBody] F收款 form)
        {
            CommonRep<F收款> commonRep = new CommonRep<F收款>();
            if (form == null)
            {
                commonRep.ErrorMessage = "送出表單為NULL!";
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
                return commonRep;
            }
            try
            {
                ARMiddle aRMiddle = new ARMiddle();
                int execCnt = aRMiddle.deleteAR(form.單號);
                if (execCnt == 0)
                {
                    commonRep.ErrorMessage = "執行寫入發生錯誤，請洽系統人員!";
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
        [Route("api/GetItemNumberList"), HttpGet]
        public CommonRep<F收支項目設定> GetItemNumberList()
        {
            CommonRep<F收支項目設定> commonRep = new CommonRep<F收支項目設定>();
            ARMiddle aRMiddle = new ARMiddle();
            try
            {
                commonRep.resultList = aRMiddle.getItemNumberList();
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }
        [Route("api/GetOtherIncomeNo"), HttpGet] 
        public CommonRep<string> GetOtherIncomeNo()
        {
            CommonRep<string> commonRep = new CommonRep<string>();
            ARMiddle arMiddle = new ARMiddle();
            try
            {
                commonRep.result = arMiddle.getOtherIncomeNo();
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }
        /// <summary>
        /// 儲存其他收入單
        /// </summary>
        /// <param name="form"></param>
        /// <returns></returns>
        [Route("api/SaveOtherIncome"), HttpPost]
        public CommonRep<F其他收入單> SaveOtherIncome([FromBody] F其他收入單 form)
        {
            CommonRep<F其他收入單> commonRep = new CommonRep<F其他收入單>();
            if (form == null)
            {
                commonRep.ErrorMessage = "送出表單為NULL!";
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
                return commonRep;
            }
            try
            {
                ARMiddle aRMiddle = new ARMiddle();
                int execCnt = aRMiddle.saveOtherIncome(form);
                if (execCnt == 0)
                {
                    commonRep.ErrorMessage = "執行寫入發生錯誤，請洽系統人員!";
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
        /// 修改其他收入單
        /// </summary>
        /// <param name="form"></param>
        /// <returns></returns>
        [Route("api/UpdateOtherIncome"), HttpPost]
        public CommonRep<F其他收入單> UpdateOtherIncome([FromBody] F其他收入單 form)
        {
            CommonRep<F其他收入單> commonRep = new CommonRep<F其他收入單>();
            if (form == null)
            {
                commonRep.ErrorMessage = "送出表單為NULL!";
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
                return commonRep;
            }
            try
            {
                ARMiddle aRMiddle = new ARMiddle();
                int execCnt = aRMiddle.updateOtherIncome(form);
                if (execCnt == 0)
                {
                    commonRep.ErrorMessage = "執行寫入發生錯誤，請洽系統人員!";
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
        /// 刪除其他收入單
        /// </summary>
        /// <param name="form"></param>
        /// <returns></returns>
        [Route("api/DeleteOtherIncome"), HttpPost]
        public CommonRep<F其他收入單> DeleteOtherIncome([FromBody] F其他收入單 form)
        {
            CommonRep<F其他收入單> commonRep = new CommonRep<F其他收入單>();
            if (form == null)
            {
                commonRep.ErrorMessage = "送出表單為NULL!";
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
                return commonRep;
            }
            try
            {
                ARMiddle aRMiddle = new ARMiddle();
                int execCnt = aRMiddle.deleteOtherIncome(form);
                if (execCnt == 0)
                {
                    commonRep.ErrorMessage = "執行寫入發生錯誤，請洽系統人員!";
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
        [Route("api/GetOtherIncomeList"), HttpGet]
        public CommonRep<F其他收入單> GetOtherIncomeList()
        {
            CommonRep<F其他收入單> commonRep = new CommonRep<F其他收入單>();
            try
            {
                ARMiddle aRMiddle = new ARMiddle();
                commonRep.resultList = aRMiddle.getOtherIncomeList();
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
