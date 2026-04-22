using MES.Core.Model;
using MES.Core.Repository.Impl;
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
        [Route("api/AllWorkers"), HttpGet]
        public CommonRep<H員工清冊> AllWorkers()
        {
            CommonRep<H員工清冊> commonRep = new CommonRep<H員工清冊>();
            HumanResourceRepository humanResourceRepository = new HumanResourceRepository();
            try
            {
                commonRep.resultList = humanResourceRepository.GetList(null, "", "");
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }
        [Route("api/GetWorkerByNumber"), HttpGet]
        public CommonRep<H員工清冊> GetWorkerByNumber(string workerNumber)
        {
            CommonRep<H員工清冊> commonRep = new CommonRep<H員工清冊>();
            HumanResourceRepository humanResourceRepository = new HumanResourceRepository();
            try
            {
                commonRep.result = humanResourceRepository.GetListBy(new H員工清冊() { 工號 = workerNumber }, "工號").FirstOrDefault();
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
