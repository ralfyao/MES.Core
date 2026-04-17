using MES.Core.Model;
using MES.WebAPI.MiddleWare;
using MES.WebAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MES.WebAPI.Controllers
{
    [ApiController]
    public class HRController : ControllerBase
    {
        [Route("api/EmployeeByAccount"), HttpGet]
        public CommonRep<H員工清冊> EmployeeByAccount(string account)
        {
            CommonRep<H員工清冊> commonRep = new CommonRep<H員工清冊>();
            HRMiddle hrMiddle = new HRMiddle();
            try
            {
                commonRep.result = hrMiddle.getEmployeeByAccount(account);
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }
        [Route("api/SaveUpdateJournal"), HttpPost]
        public CommonRep<string> SaveUpdateJournal([FromBody] 工作紀錄A form)
        {
            CommonRep<string> commonRep = new CommonRep<string>();
            HRMiddle hRMiddle = new HRMiddle();
            try
            {
                hRMiddle.saveUpdateJournal(form);
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }
        [Route("api/JournalByNo"), HttpGet]
        public CommonRep<工作紀錄A> JournalByNo(string journalNo)
        {
            CommonRep<工作紀錄A> commonRep = new CommonRep<工作紀錄A>();
            HRMiddle hRMiddle = new HRMiddle();
            try
            {
                commonRep.result = hRMiddle.getJournalByNo(journalNo);
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
