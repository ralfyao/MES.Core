using MES.Core.Model;
using MES.WebAPI.MiddleWare;
using MES.WebAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace MES.WebAPI.Controllers
{
    [ApiController]
    public class UserPrivilegeController : ControllerBase
    {
        [Route("api/GetUserPrivilegeByAccount")]
        public CommonRep<A使用者授權> GetUserPrivilegeByAccount(string account = "")
        {
            CommonRep<A使用者授權> commonRep = new CommonRep<A使用者授權>();
            UserMiddle userMiddle = new UserMiddle();
            try
            {
                commonRep.resultList = userMiddle.getPrivilegeByAccount(account);
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex + ex.StackTrace;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }
        [Route("api/SaveAccount"), HttpPost]
        public CommonRep<int> SaveAccount([FromBody] account user)
        {
            CommonRep<int> commonRep = new CommonRep<int>();
            UserMiddle userMiddle = new UserMiddle();
            try
            {
                commonRep.result = userMiddle.saveAccount(user);
            }
            catch (Exception)
            {

                throw;
            }
            return commonRep;
        }

        public CommonRep<int> SaveUserPrivilege(List<A使用者授權> saveList)
        {
            CommonRep<int> rep = new CommonRep<int>();
            UserMiddle userMiddle = new UserMiddle();
            try
            {
                rep.result = userMiddle.saveUserPrivilege(saveList);
            }
            catch (Exception ex)
            {
                rep.ErrorMessage = ex + ex.StackTrace;
                rep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return rep;
        }
    }
}
