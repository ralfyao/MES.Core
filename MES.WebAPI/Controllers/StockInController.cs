using MES.Core.Model;
using MES.WebAPI.MiddleWare;
using MES.WebAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MES.WebAPI.Controllers
{
    [ApiController]
    public class StockInController : ControllerBase
    {
        [Route("api/AllStockInList"), HttpGet]
        public CommonRep<B進貨驗收單> AllStockInList()
        {
            CommonRep<B進貨驗收單> commonRep = new CommonRep<B進貨驗收單>();
            StockInMiddle stockInMiddle = new StockInMiddle();
            try
            {
                commonRep.resultList = stockInMiddle.allStockInLists();
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }
        [Route("api/GetFormNo"), HttpGet]
        public CommonRep<string> GetFormNo()
        {
            CommonRep<string> commonRep = new CommonRep<string>();
            StockInMiddle stockInMiddle = new StockInMiddle();
            try
            {
                commonRep.result = stockInMiddle.getFormNo();
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
