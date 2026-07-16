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

        [Route("api/GetVoucherByNo"), HttpGet]
        public CommonRep<F會計傳票> GetVoucherByNo(string no)
        {
            CommonRep<F會計傳票> commonRep = new CommonRep<F會計傳票>();
            VoucherMiddle voucherMiddle = new VoucherMiddle();
            try
            {
                commonRep.result = voucherMiddle.getVoucherByNo(no);
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }

        [Route("api/PostVoucher"), HttpPost]
        public CommonRep<string> PostVoucher(string no, string user)
        {
            CommonRep<string> commonRep = new CommonRep<string>();
            VoucherMiddle voucherMiddle = new VoucherMiddle();
            try
            {
                voucherMiddle.postVoucher(no, user);
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }

        [Route("api/CancelPostVoucher"), HttpPost]
        public CommonRep<string> CancelPostVoucher(string no)
        {
            CommonRep<string> commonRep = new CommonRep<string>();
            VoucherMiddle voucherMiddle = new VoucherMiddle();
            try
            {
                voucherMiddle.cancelPostVoucher(no);
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }

        [Route("api/GetVoucherQueryList"), HttpGet]
        public CommonRep<會計傳票查詢清單> GetVoucherQueryList(string dateFrom, string dateTo, string accountCode, string status)
        {
            CommonRep<會計傳票查詢清單> commonRep = new CommonRep<會計傳票查詢清單>();
            VoucherMiddle voucherMiddle = new VoucherMiddle();
            try
            {
                commonRep.resultList = voucherMiddle.getVoucherQueryList(dateFrom, dateTo, accountCode, status);
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }

        [Route("api/GetVoucherQueryListByNoLike"), HttpGet]
        public CommonRep<會計傳票查詢清單> GetVoucherQueryListByNoLike(string pattern)
        {
            CommonRep<會計傳票查詢清單> commonRep = new CommonRep<會計傳票查詢清單>();
            VoucherMiddle voucherMiddle = new VoucherMiddle();
            try
            {
                commonRep.resultList = voucherMiddle.getVoucherQueryListByNoLike(pattern);
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }

        [Route("api/GetVoucherDetailForQuery"), HttpGet]
        public CommonRep<F會計傳票明細> GetVoucherDetailForQuery(string no)
        {
            CommonRep<F會計傳票明細> commonRep = new CommonRep<F會計傳票明細>();
            VoucherMiddle voucherMiddle = new VoucherMiddle();
            try
            {
                commonRep.resultList = voucherMiddle.getVoucherDetailForQuery(no);
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
