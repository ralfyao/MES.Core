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
        #region 採購單
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
        public CommonRep<B採購單> AllPurchasesList(string purchaseOrderNo = "")
        {
            CommonRep<B採購單> commonRep = new CommonRep<B採購單>();
            ProcurementMiddle procurement = new ProcurementMiddle();
            try
            {
                commonRep.resultList = procurement.getPurchaseOrderList(purchaseOrderNo);
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
        [Route("api/VoidPurchaseOrderItem"), HttpGet]
        public CommonRep<string> VoidPurchaseOrderItem(string itemId)
        {
            CommonRep<string> commonRep = new CommonRep<string>();
            ProcurementMiddle procurementMiddle = new ProcurementMiddle();
            try
            {
                procurementMiddle.voidPurchaseOrderItem(itemId);
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }
        [Route("api/EvaluatePurchaseOrder"), HttpGet]
        public CommonRep<string> EvaluatePurchaseOrder(string formNo, bool validate, string user)
        {
            CommonRep<string> commonRep = new CommonRep<string>();
            ProcurementMiddle procurementMiddle = new ProcurementMiddle();
            try
            {
                procurementMiddle.evaluatePurchaseOrder(formNo, validate, user);
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }
        #endregion
        #region 請購單
        [Route("api/AllPurchaseRequestList"), HttpGet]
        public CommonRep<B請購需求> AllPurchaseRequestList(string reqNo = null)
        {
            CommonRep<B請購需求> commonRep = new CommonRep<B請購需求>();
            ProcurementMiddle procurementMiddle = new ProcurementMiddle();
            try
            {
                commonRep.resultList = procurementMiddle.getAllPurchaseRequestList(reqNo).OrderByDescending(x => x.日期).ToList();
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }
        [Route("api/AllDepartmentList"), HttpGet]
        public CommonRep<A成本單位> AllDepartmentList()
        {
            CommonRep<A成本單位> commonRep = new CommonRep<A成本單位>();
            ProcurementMiddle procurementMiddle = new ProcurementMiddle();
            try
            {
                commonRep.resultList = procurementMiddle.getAllDepartmentList();
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }
        [Route("api/SavePurchaseRequest"), HttpPost]
        public CommonRep<string> SavePurchaseRequest([FromBody] B請購需求 form)
        {
            CommonRep<string> commonRep = new CommonRep<string>();
            ProcurementMiddle procurementMiddle = new ProcurementMiddle();
            try
            {
                procurementMiddle.savePurchaseRequest(form);
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }
        [Route("api/DeletePurchaseRequest"), HttpGet]
        public CommonRep<string> DeletePurchaseRequest(string formSerial)
        {
            CommonRep<string> commonRep = new CommonRep<string>();
            ProcurementMiddle procurementMiddle = new ProcurementMiddle();
            try
            {
                procurementMiddle.deletePurchaseRequest(formSerial);
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }
        #endregion
    }
}
