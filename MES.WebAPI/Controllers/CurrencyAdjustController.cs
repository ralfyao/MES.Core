using MES.Core.Model;
using MES.WebAPI.MiddleWare;
using MES.WebAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace MES.WebAPI.Controllers
{
    [ApiController]
    public class CurrencyAdjustController : ControllerBase
    {
        [Route("api/GetCurrencyAdjustList"), HttpGet]
        public CommonRep<資金調節總覽> GetCurrencyAdjustList()
        {
            CommonRep<資金調節總覽> commonRep = new CommonRep<資金調節總覽>();
            CurrencyAdjustMiddle currencyAdjustMiddle = new CurrencyAdjustMiddle();
            try
            {
                commonRep.resultList = currencyAdjustMiddle.getCurrencyAdjustList();
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }

        [Route("api/GetFundAdjustNo"), HttpGet]
        public CommonRep<string> GetFundAdjustNo()
        {
            CommonRep<string> commonRep = new CommonRep<string>();
            try
            {
                commonRep.result = new CurrencyAdjustMiddle().getFundAdjustNo();
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }

        [Route("api/GetFundAdjustByNo"), HttpGet]
        public CommonRep<F資金調節> GetFundAdjustByNo(string no)
        {
            CommonRep<F資金調節> commonRep = new CommonRep<F資金調節>();
            try
            {
                commonRep.result = new CurrencyAdjustMiddle().getFundAdjustByNo(no);
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }

        [Route("api/SaveFundAdjust"), HttpPost]
        public CommonRep<F資金調節> SaveFundAdjust([FromBody] F資金調節 form)
        {
            CommonRep<F資金調節> commonRep = new CommonRep<F資金調節>();
            try
            {
                new CurrencyAdjustMiddle().saveFundAdjust(form);
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }

        [Route("api/UpdateFundAdjust"), HttpPost]
        public CommonRep<F資金調節> UpdateFundAdjust([FromBody] F資金調節 form)
        {
            CommonRep<F資金調節> commonRep = new CommonRep<F資金調節>();
            try
            {
                new CurrencyAdjustMiddle().updateFundAdjust(form);
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }

        [Route("api/ValidateFundAdjust"), HttpPost]
        public CommonRep<F資金調節> ValidateFundAdjust(string no, bool approve, string user)
        {
            CommonRep<F資金調節> commonRep = new CommonRep<F資金調節>();
            try
            {
                new CurrencyAdjustMiddle().doValidateFundAdjust(no, approve, user);
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }

        [Route("api/DeleteFundAdjust"), HttpPost]
        public CommonRep<F資金調節> DeleteFundAdjust(string no)
        {
            CommonRep<F資金調節> commonRep = new CommonRep<F資金調節>();
            try
            {
                new CurrencyAdjustMiddle().deleteFundAdjust(no);
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
