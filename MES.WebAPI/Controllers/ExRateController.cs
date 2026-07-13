using MES.Core.Model;
using MES.WebAPI.MiddleWare;
using MES.WebAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace MES.WebAPI.Controllers
{
    [ApiController]
    public class ExRateController : ControllerBase
    {
        [Route("api/GetAllExRateList"), HttpGet]
        public CommonRep<F匯率> GetAllExRateList()
        {
            CommonRep<F匯率> commonRep = new CommonRep<F匯率>();
            ExRateMiddle exRateMiddle = new ExRateMiddle();
            try
            {
                commonRep.resultList = exRateMiddle.getAllExRateList();
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }

        [Route("api/SaveExRate"), HttpPost]
        public CommonRep<int> SaveExRate([FromBody] F匯率 form)
        {
            CommonRep<int> commonRep = new CommonRep<int>();
            ExRateMiddle exRateMiddle = new ExRateMiddle();
            try
            {
                commonRep.result = exRateMiddle.saveExRate(form);
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
