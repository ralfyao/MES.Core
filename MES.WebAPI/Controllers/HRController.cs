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
        // ── 員工清冊總覽：H員工基本資料 RIGHT JOIN H員工清冊 ON 工號 ─────────────
        [Route("api/GetEmployeeList"), HttpGet]
        public CommonRep<員工清冊列表> GetEmployeeList()
        {
            CommonRep<員工清冊列表> commonRep = new CommonRep<員工清冊列表>();
            HRMiddle hrMiddle = new HRMiddle();
            try
            {
                commonRep.resultList = hrMiddle.getEmployeeList();
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }
        // ── 新增員工：寫入 H員工清冊 ──────────────────────────────────────
        [Route("api/SaveEmployee"), HttpPost]
        public CommonRep<string> SaveEmployee([FromBody] H員工清冊 form)
        {
            CommonRep<string> commonRep = new CommonRep<string>();
            HumanResourceRepository humanResourceRepository = new HumanResourceRepository();
            try
            {
                // ── 工號重複檢查：H員工清冊 已存在相同工號則拒絕新增 ──────────
                var existing = humanResourceRepository.GetListBy(new H員工清冊() { 工號 = form.工號 }, "工號").FirstOrDefault();
                if (existing != null)
                {
                    commonRep.ErrorMessage = "工號已存在!";
                    commonRep.WorkStatus = WorkStatus.Fail.ToString();
                    return commonRep;
                }

                int retCode = humanResourceRepository.Insert(form);
                if (retCode != 0)
                {
                    commonRep.ErrorMessage = "新增員工失敗!";
                    commonRep.WorkStatus = WorkStatus.Fail.ToString();
                }
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }
        // ── 更新員工個資：寫入 H員工清冊(修改員工個資) ─────────────────────
        [Route("api/UpdateEmployee"), HttpPost]
        public CommonRep<string> UpdateEmployee([FromBody] H員工清冊 form)
        {
            CommonRep<string> commonRep = new CommonRep<string>();
            HumanResourceRepository humanResourceRepository = new HumanResourceRepository();
            try
            {
                int retCode = humanResourceRepository.Update(form);
                if (retCode != 0)
                {
                    commonRep.ErrorMessage = "修改員工個資失敗!";
                    commonRep.WorkStatus = WorkStatus.Fail.ToString();
                }
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }
        // ── 修改員工個資「狀況」改為離職時，同步寫入最新一筆核薪紀錄的離職日 ──
        [Route("api/UpdateLatestSalaryResignDate"), HttpGet]
        public CommonRep<string> UpdateLatestSalaryResignDate(string empNo, string resignDate)
        {
            CommonRep<string> commonRep = new CommonRep<string>();
            HRMiddle hrMiddle = new HRMiddle();
            try
            {
                hrMiddle.updateLatestSalaryResignDate(empNo, resignDate);
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }
        // ── 每日出勤表 ────────────────────────────────────────────────────
        [Route("api/GetCalendarByDate"), HttpGet]
        public CommonRep<H日曆> GetCalendarByDate(string date)
        {
            CommonRep<H日曆> commonRep = new CommonRep<H日曆>();
            HRMiddle hrMiddle = new HRMiddle();
            try
            {
                commonRep.result = hrMiddle.getCalendarByDate(date);
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }
        [Route("api/GetCalendarList"), HttpGet]
        public CommonRep<H日曆> GetCalendarList()
        {
            CommonRep<H日曆> commonRep = new CommonRep<H日曆>();
            HRMiddle hrMiddle = new HRMiddle();
            try
            {
                commonRep.resultList = hrMiddle.getCalendarList();
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }
        [Route("api/GetCalendarDateList"), HttpGet]
        public CommonRep<string> GetCalendarDateList()
        {
            CommonRep<string> commonRep = new CommonRep<string>();
            HRMiddle hrMiddle = new HRMiddle();
            try
            {
                commonRep.resultList = hrMiddle.getCalendarDateList();
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }
        // ── 員工考勤核對(H-出勤卡) ──────────────────────────────────────────
        [Route("api/GetAttendanceCheckList"), HttpGet]
        public CommonRep<考勤核對列表> GetAttendanceCheckList(string empNo, string startDate, string endDate)
        {
            CommonRep<考勤核對列表> commonRep = new CommonRep<考勤核對列表>();
            HRMiddle hrMiddle = new HRMiddle();
            try
            {
                commonRep.resultList = hrMiddle.getAttendanceCheckList(empNo, startDate, endDate);
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }
        [Route("api/ImportClockData"), HttpGet]
        public CommonRep<string> ImportClockData(string date)
        {
            CommonRep<string> commonRep = new CommonRep<string>();
            HRMiddle hrMiddle = new HRMiddle();
            try
            {
                hrMiddle.importClockData(date);
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }
        [Route("api/SaveCalendar"), HttpPost]
        public CommonRep<string> SaveCalendar([FromBody] H日曆 form)
        {
            CommonRep<string> commonRep = new CommonRep<string>();
            HRMiddle hrMiddle = new HRMiddle();
            try
            {
                hrMiddle.saveCalendar(form);
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }
        // ── 日曆總覽(CalendarControl)：儲存含 公告事項/人事經辦/核准生效/核准人 ──
        [Route("api/SaveCalendarFull"), HttpPost]
        public CommonRep<string> SaveCalendarFull([FromBody] H日曆 form)
        {
            CommonRep<string> commonRep = new CommonRep<string>();
            HRMiddle hrMiddle = new HRMiddle();
            try
            {
                hrMiddle.saveCalendarFull(form);
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }
        [Route("api/GetAttendanceList"), HttpGet]
        public CommonRep<考勤紀錄列表> GetAttendanceList(string date)
        {
            CommonRep<考勤紀錄列表> commonRep = new CommonRep<考勤紀錄列表>();
            HRMiddle hrMiddle = new HRMiddle();
            try
            {
                commonRep.resultList = hrMiddle.getAttendanceList(date);
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }
        [Route("api/SaveAttendance"), HttpPost]
        public CommonRep<string> SaveAttendance([FromBody] H考勤紀錄 form)
        {
            CommonRep<string> commonRep = new CommonRep<string>();
            HRMiddle hrMiddle = new HRMiddle();
            try
            {
                hrMiddle.saveAttendance(form);
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }
        [Route("api/DeleteAttendance"), HttpGet]
        public CommonRep<string> DeleteAttendance(int id)
        {
            CommonRep<string> commonRep = new CommonRep<string>();
            HRMiddle hrMiddle = new HRMiddle();
            try
            {
                hrMiddle.deleteAttendance(id);
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }
        // ── 員工薪給結構(核薪紀錄) ────────────────────────────────────────
        [Route("api/GetEmployeeSalaryList"), HttpGet]
        public CommonRep<H員工基本資料> GetEmployeeSalaryList(string empNo)
        {
            CommonRep<H員工基本資料> commonRep = new CommonRep<H員工基本資料>();
            HRMiddle hrMiddle = new HRMiddle();
            try
            {
                commonRep.resultList = hrMiddle.getEmployeeSalaryList(empNo);
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }
        [Route("api/SaveEmployeeSalary"), HttpPost]
        public CommonRep<string> SaveEmployeeSalary([FromBody] H員工基本資料 form)
        {
            CommonRep<string> commonRep = new CommonRep<string>();
            HRMiddle hrMiddle = new HRMiddle();
            try
            {
                hrMiddle.saveEmployeeSalary(form);
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }
        [Route("api/ValidateEmployeeSalary"), HttpGet]
        public CommonRep<string> ValidateEmployeeSalary(int id, bool approve, string account)
        {
            CommonRep<string> commonRep = new CommonRep<string>();
            HRMiddle hrMiddle = new HRMiddle();
            try
            {
                hrMiddle.validateEmployeeSalary(id, approve, account);
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }
        [Route("api/DeleteEmployeeSalary"), HttpGet]
        public CommonRep<string> DeleteEmployeeSalary(int id)
        {
            CommonRep<string> commonRep = new CommonRep<string>();
            HRMiddle hrMiddle = new HRMiddle();
            try
            {
                hrMiddle.deleteEmployeeSalary(id);
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }
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

        [Route("api/GetPositionList"), HttpGet]
        public CommonRep<H職務工作分類> getPositionList(string position)
        {
            CommonRep<H職務工作分類> commonRep = new CommonRep<H職務工作分類>();
            HumanResourcePositionRepository humanResourceRepository = new HumanResourcePositionRepository();
            try
            {
                commonRep.resultList = humanResourceRepository.GetListBy(new H職務工作分類() { 職務 = position }, "職務");
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
