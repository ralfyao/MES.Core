using MES.Core.Model;
using MES.WebAPI.MiddleWare;
using MES.WebAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace MES.WebAPI.Controllers
{
    [ApiController]
    public class VoucherController : ControllerBase
    {
        [Route("api/GetVoucherNo"), HttpGet]
        public CommonRep<string> GetVoucherNo()
        {
            CommonRep<string> commonRep = new CommonRep<string>();
            VoucherMiddle voucherMiddle = new VoucherMiddle();
            try
            {
                commonRep.result = voucherMiddle.getFormNo();
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }

        [Route("api/GetAccountingSubjectList"), HttpGet]
        public CommonRep<F會計科目> GetAccountingSubjectList()
        {
            CommonRep<F會計科目> commonRep = new CommonRep<F會計科目>();
            VoucherMiddle voucherMiddle = new VoucherMiddle();
            try
            {
                commonRep.resultList = voucherMiddle.getAccountingSubjectList();
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }

        [Route("api/CreateVoucher"), HttpPost]
        public CommonRep<string> CreateVoucher([FromBody] F會計傳票 form)
        {
            CommonRep<string> commonRep = new CommonRep<string>();
            VoucherMiddle voucherMiddle = new VoucherMiddle();
            try
            {
                voucherMiddle.createVoucher(form);
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
