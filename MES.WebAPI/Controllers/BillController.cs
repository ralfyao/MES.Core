using MES.Core.Model;
using MES.WebAPI.MiddleWare;
using MES.WebAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace MES.WebAPI.Controllers
{
    [ApiController]
    public class BillController : ControllerBase
    {
        [Route("api/GetBillList"), HttpGet]
        public CommonRep<F票據異動> GetBillList()
        {
            CommonRep<F票據異動> commonRep = new CommonRep<F票據異動>();
            BillMiddle billMiddle = new BillMiddle();
            try
            {
                commonRep.resultList = billMiddle.getBillList();
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }

        [Route("api/GetBillByNo"), HttpGet]
        public CommonRep<F票據異動> GetBillByNo(string billNo)
        {
            CommonRep<F票據異動> commonRep = new CommonRep<F票據異動>();
            BillMiddle billMiddle = new BillMiddle();
            try
            {
                commonRep.result = billMiddle.getBillByNo(billNo);
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }

        [Route("api/SaveBill"), HttpPost]
        public CommonRep<string> SaveBill([FromBody] F票據異動 form)
        {
            CommonRep<string> commonRep = new CommonRep<string>();
            BillMiddle billMiddle = new BillMiddle();
            try
            {
                billMiddle.saveBill(form);
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }

        [Route("api/UpdateBill"), HttpPost]
        public CommonRep<string> UpdateBill([FromBody] F票據異動 form)
        {
            CommonRep<string> commonRep = new CommonRep<string>();
            BillMiddle billMiddle = new BillMiddle();
            try
            {
                billMiddle.updateBill(form);
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
