using MES.Core.Model;
using MES.WebAPI.MiddleWare;
using MES.WebAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace MES.WebAPI.Controllers
{
    [ApiController]
    public class AccountController : ControllerBase
    {
        [Route("api/GetAccount")]
        public CommonRep<account> GetAccount(string account = "")
        {
            CommonRep<account> commonRep = new CommonRep<account>();
            try
            {
                commonRep.result = new HRMiddle().getAccount(account);
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message + ex.StackTrace;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
                throw;
            }
            return commonRep;
        }

        public CommonRep<string> UpdatePassword(string account, string newPassword)
        {
            CommonRep<string> commonRep = new CommonRep<string>();
            HRMiddle userMiddle = new HRMiddle();
            try
            {
                int retCode = userMiddle.UpdatePassword(account, newPassword);
                if (retCode == 0)
                {
                    commonRep.ErrorMessage = "變更密碼失敗，請洽系統人員";
                    commonRep.WorkStatus = WorkStatus.Fail.ToString();
                }
                else
                {
                    commonRep.result = newPassword;
                }
            }
            catch (Exception ex)
            {
                //_logger.Error(ex + ex.StackTrace);
                commonRep.ErrorMessage = ex + ex.StackTrace;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }
    }
}
