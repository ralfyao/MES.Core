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
        #endregion
    }
}
