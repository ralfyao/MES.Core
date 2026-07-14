using MES.Core.Model;
using MES.WebAPI.MiddleWare;
using MES.WebAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace MES.WebAPI.Controllers
{
    [ApiController]
    public class SalesTrackingController : ControllerBase
    {
        [Route("api/GetSalesTrackingList"), HttpGet]
        public CommonRep<客戶活動力分析> GetSalesTrackingList(DateTime 起日, DateTime 迄日)
        {
            CommonRep<客戶活動力分析> commonRep = new CommonRep<客戶活動力分析>();
            SalesTrackingMiddle salesTrackingMiddle = new SalesTrackingMiddle();
            try
            {
                commonRep.resultList = salesTrackingMiddle.getSalesTrackingList(起日, 迄日);
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
