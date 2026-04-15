using MES.Core.Model;
using MES.WebAPI.MiddleWare;
using MES.WebAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MES.WebAPI.Controllers
{
    [ApiController]
    public class ProcurementController : ControllerBase
    {
        [Route("api/GetPONo"), HttpGet]
        public CommonRep<string> GetPoNo()
        {
            CommonRep<string> commonRep = new CommonRep<string>();
            ProcurementMiddle procurement = new ProcurementMiddle();
            try
            {
                commonRep.result = procurement.getPoNo();
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }
        [Route("api/AllPurchasesList"), HttpGet]
        public CommonRep<B採購單> AllPurchasesList()
        {
            CommonRep<B採購單> commonRep = new CommonRep<B採購單>();
            ProcurementMiddle procurement = new ProcurementMiddle();
            try
            {
                commonRep.resultList = procurement.getPurchaseOrderList();
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }
        [Route("api/GetProcurementorList"), HttpGet]
        public CommonRep<H員工清冊> GetProcurementorList()
        {
            CommonRep<H員工清冊> commonRep = new CommonRep<H員工清冊>();
            ProcurementMiddle procurement = new ProcurementMiddle();
            try
            {
                commonRep.resultList = procurement.getProcurementorList();
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }
        [Route("api/CreatePurchaseOrder"), HttpPost]
        public CommonRep<string> CreatePurchaseOrder([FromBody] B採購單 form)
        {
            CommonRep<string> commonRep = new CommonRep<string>();
            ProcurementMiddle procurementMiddle = new ProcurementMiddle();
            try
            {
                procurementMiddle.createPurchaseOrder(form);
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }
        [Route("api/UpdatePurchaseOrder"), HttpPost]
        public CommonRep<string> UpdatePurchaseOrder([FromBody] B採購單 form)
        {
            CommonRep<string> commonRep = new CommonRep<string>();
            ProcurementMiddle procurementMiddle = new ProcurementMiddle();
            try
            {
                procurementMiddle.updatePurchaseOrder(form);
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }
        [Route("api/DeletePurchaseOrder"), HttpGet]
        public CommonRep<string> DeletePurchaseOrder(string purchaseOrderNo)
        {
            CommonRep<string> commonRep = new CommonRep<string>();
            ProcurementMiddle procurementMiddle = new ProcurementMiddle();
            try
            {
                procurementMiddle.deletePurchaseOrder(purchaseOrderNo);
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }

        [Route("api/VoidPurchaseOrder"), HttpGet]
        public CommonRep<string> VoidPurchaseOrder(string purchaseOrderNo)
        {
            CommonRep<string> commonRep = new CommonRep<string>();
            ProcurementMiddle procurementMiddle = new ProcurementMiddle();
            try
            {
                procurementMiddle.voidPurchaseOrder(purchaseOrderNo);
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
