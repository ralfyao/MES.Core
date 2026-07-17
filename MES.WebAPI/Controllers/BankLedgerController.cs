using MES.Core.Model;
using MES.WebAPI.MiddleWare;
using MES.WebAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace MES.WebAPI.Controllers
{
    [ApiController]
    public class BankLedgerController : ControllerBase
    {
        [Route("api/GetBankLedgerByLinkNo"), HttpGet]
        public CommonRep<F銀行明細> GetBankLedgerByLinkNo(string linkNo)
        {
            CommonRep<F銀行明細> commonRep = new CommonRep<F銀行明細>();
            BankLedgerMiddle bankLedgerMiddle = new BankLedgerMiddle();
            try
            {
                commonRep.result = bankLedgerMiddle.getBankLedgerByLinkNo(linkNo);
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }

        [Route("api/SaveBankLedger"), HttpPost]
        public CommonRep<string> SaveBankLedger([FromBody] F銀行明細 form)
        {
            CommonRep<string> commonRep = new CommonRep<string>();
            BankLedgerMiddle bankLedgerMiddle = new BankLedgerMiddle();
            try
            {
                bankLedgerMiddle.saveBankLedger(form);
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }

        [Route("api/UpdateBankLedger"), HttpPost]
        public CommonRep<string> UpdateBankLedger([FromBody] F銀行明細 form)
        {
            CommonRep<string> commonRep = new CommonRep<string>();
            BankLedgerMiddle bankLedgerMiddle = new BankLedgerMiddle();
            try
            {
                bankLedgerMiddle.updateBankLedger(form);
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
