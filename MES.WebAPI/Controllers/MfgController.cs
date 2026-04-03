using MES.Core.Model;
using MES.WebAPI.MiddleWare;
using MES.WebAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace MES.WebAPI.Controllers
{
    [ApiController]
    public class MfgController : ControllerBase
    {
        #region 零件申請單
        /// <summary>
        /// 零件申請單取號
        /// </summary>
        /// <returns></returns>
        [Route("api/GetMiscMfgNo"), HttpGet]
        public CommonRep<string> GetMiscMfgNo()
        {
            CommonRep<string> commonRep = new CommonRep<string>();
            MfgMiddle mfgMiddle = new MfgMiddle();
            try
            {
                commonRep.result = mfgMiddle.getMiscMfgNo();
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }
        [Route("api/CreateMiscMfgOrder"), HttpPost]
        public CommonRep<string> CreateMiscMfgOrder([FromBody] 零件申請單 form)
        {
            CommonRep<string> commonRep = new CommonRep<string>();
            MfgMiddle mfgMiddle = new MfgMiddle();
            try
            {
                int execCnt = mfgMiddle.createMiscMfgOrder(form);
                execCnt += mfgMiddle.updateSalesOrderMachineNo(form);
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
