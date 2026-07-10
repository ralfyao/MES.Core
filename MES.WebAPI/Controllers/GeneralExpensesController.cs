using MES.Core.Model;
using MES.WebAPI.MiddleWare;
using MES.WebAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace MES.WebAPI.Controllers
{
    [ApiController]
    public class GeneralExpensesController : ControllerBase
    {
        [Route("api/GetGeneralExpensesList"), HttpGet]
        public CommonRep<總務支出單列表> GetGeneralExpensesList()
        {
            CommonRep<總務支出單列表> commonRep = new CommonRep<總務支出單列表>();
            GeneralExpensesMiddle generalExpensesMiddle = new GeneralExpensesMiddle();
            try
            {
                commonRep.resultList = generalExpensesMiddle.getGeneralExpensesList();
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
