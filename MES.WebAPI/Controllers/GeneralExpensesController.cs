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

        [Route("api/GetExpenseCertImportList"), HttpGet]
        public CommonRep<F其他收支明細> GetExpenseCertImportList(string supplierNo, DateTime? from, DateTime? to)
        {
            CommonRep<F其他收支明細> commonRep = new CommonRep<F其他收支明細>();
            GeneralExpensesMiddle generalExpensesMiddle = new GeneralExpensesMiddle();
            try
            {
                commonRep.resultList = generalExpensesMiddle.getExpenseCertImportList(supplierNo, from, to);
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }

        [Route("api/GetGeneralExpensesNo"), HttpGet]
        public CommonRep<string> GetGeneralExpensesNo()
        {
            CommonRep<string> commonRep = new CommonRep<string>();
            GeneralExpensesMiddle generalExpensesMiddle = new GeneralExpensesMiddle();
            try
            {
                commonRep.result = generalExpensesMiddle.getGeneralExpensesNo();
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }

        [Route("api/GetGeneralExpensesByNo"), HttpGet]
        public CommonRep<F總務支出單> GetGeneralExpensesByNo(string 單號)
        {
            CommonRep<F總務支出單> commonRep = new CommonRep<F總務支出單>();
            GeneralExpensesMiddle generalExpensesMiddle = new GeneralExpensesMiddle();
            try
            {
                commonRep.result = generalExpensesMiddle.getGeneralExpensesByNo(單號);
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }

        [Route("api/SaveGeneralExpenses"), HttpPost]
        public CommonRep<string> SaveGeneralExpenses([FromBody] F總務支出單 form)
        {
            CommonRep<string> commonRep = new CommonRep<string>();
            GeneralExpensesMiddle generalExpensesMiddle = new GeneralExpensesMiddle();
            try
            {
                int execCnt = generalExpensesMiddle.saveGeneralExpenses(form);
                if (execCnt == 0)
                {
                    commonRep.ErrorMessage = "新增失敗，請洽系統人員";
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

        [Route("api/UpdateGeneralExpenses"), HttpPost]
        public CommonRep<string> UpdateGeneralExpenses([FromBody] F總務支出單 form)
        {
            CommonRep<string> commonRep = new CommonRep<string>();
            GeneralExpensesMiddle generalExpensesMiddle = new GeneralExpensesMiddle();
            try
            {
                int execCnt = generalExpensesMiddle.updateGeneralExpenses(form);
                if (execCnt == 0)
                {
                    commonRep.ErrorMessage = "修改失敗，請洽系統人員";
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

        [Route("api/ValidateGeneralExpenses"), HttpGet]
        public CommonRep<string> ValidateGeneralExpenses(string 單號, bool validate, string account)
        {
            CommonRep<string> commonRep = new CommonRep<string>();
            GeneralExpensesMiddle generalExpensesMiddle = new GeneralExpensesMiddle();
            try
            {
                int execCnt = generalExpensesMiddle.doValidateGeneralExpenses(單號, validate, account);
                if (execCnt == 0)
                {
                    commonRep.ErrorMessage = "覆核失敗，請洽系統人員";
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

        [Route("api/GetActiveEmployeeList"), HttpGet]
        public CommonRep<H員工清冊> GetActiveEmployeeList()
        {
            CommonRep<H員工清冊> commonRep = new CommonRep<H員工清冊>();
            GeneralExpensesMiddle generalExpensesMiddle = new GeneralExpensesMiddle();
            try
            {
                commonRep.resultList = generalExpensesMiddle.getActiveEmployeeList();
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }

        [Route("api/DeleteGeneralExpenses"), HttpGet]
        public CommonRep<string> DeleteGeneralExpenses(string 單號)
        {
            CommonRep<string> commonRep = new CommonRep<string>();
            GeneralExpensesMiddle generalExpensesMiddle = new GeneralExpensesMiddle();
            try
            {
                int execCnt = generalExpensesMiddle.deleteGeneralExpenses(單號);
                if (execCnt == 0)
                {
                    commonRep.ErrorMessage = "刪除失敗，請洽系統人員";
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
    }
}
