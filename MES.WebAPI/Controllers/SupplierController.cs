using MES.Core.Model;
using MES.WebAPI.MiddleWare;
using MES.WebAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace MES.WebAPI.Controllers
{
    [ApiController]
    public class SupplierController : ControllerBase
    {
        [Route("api/GetSupplierList"), HttpGet]
        public CommonRep<B廠商設定> GetSupplierList(string? supplierNo = "", string supplierName = "")
        {
            CommonRep<B廠商設定> commonRep = new CommonRep<B廠商設定>();
            try
            {
                commonRep.resultList = new SupplierMiddle().getSupplierList(supplierNo, supplierName);
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }
        [Route("api/GetAllSupplierList"), HttpGet]
        public CommonRep<B廠商設定> GetAllSupplierList(string? supplierNo = "", string supplierName = "")
        {
            CommonRep<B廠商設定> commonRep = new CommonRep<B廠商設定>();
            try
            {
                commonRep.resultList = new SupplierMiddle().getAllSupplierList(supplierNo, supplierName);
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }
        [Route("api/UpdateSupplier"), HttpPost]
        public CommonRep<string> UpdateSupplier([FromBody] B廠商設定 form)
        {
            CommonRep<string> commonRep = new CommonRep<string>();
            SupplierMiddle supplierMiddle = new SupplierMiddle();
            try
            {
                int execCnt = 0;
                execCnt = supplierMiddle.updateSupplier(form);
                if (execCnt == 0)
                {
                    commonRep.ErrorMessage = "更新供應商失敗，請洽系統人員";
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
        [Route("api/SaveSupplier"), HttpPost]
        public CommonRep<string> SaveSupplier([FromBody] B廠商設定 form)
        {
            CommonRep<string> commonRep = new CommonRep<string>();
            SupplierMiddle supplierMiddle = new SupplierMiddle();
            try
            {
                int execCnt = 0;
                execCnt = supplierMiddle.insertSupplier(form);
                if (execCnt == 0)
                {
                    commonRep.ErrorMessage = "新增供應商失敗，請洽系統人員";
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
        [Route("api/DeleteSupplier"), HttpPost]
        public CommonRep<string> DeleteSupplier([FromBody] B廠商設定 form)
        {
            CommonRep<string> commonRep = new CommonRep<string>();
            SupplierMiddle supplierMiddle = new SupplierMiddle();
            try
            {
                int execCnt = 0;
                execCnt = supplierMiddle.deleteSupplier(form);
                if (execCnt == 0)
                {
                    commonRep.ErrorMessage = "刪除供應商失敗，請洽系統人員";
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
        [Route("api/GetSupplierNo"), HttpGet]
        public CommonRep<string> GetSupplierNo()
        {
            CommonRep<string> commonRep = new CommonRep<string>();
            try
            {
                commonRep.result = new SupplierMiddle().getSupplierNo();
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }
        [Route("api/SaveSupplierEvaluate"), HttpPost]
        public CommonRep<string> SaveSupplierEvaluate([FromBody] B廠商評鑑 form)
        {
            CommonRep<string> commonRep = new CommonRep<string>();
            SupplierMiddle supplierMiddle = new SupplierMiddle();
            try
            {
                int execCnt = 0;
                execCnt = supplierMiddle.insertSupplierEvaluate(form);
                if (execCnt == 0)
                {
                    commonRep.ErrorMessage = "新增供應商評鑑失敗，請洽系統人員";
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
        [Route("api/EvaluateSupplier"), HttpGet]
        public CommonRep<string> EvaluateSupplier(string formNo, bool validate, string user)
        {
            CommonRep<string> commonRep = new CommonRep<string>();
            SupplierMiddle supplierMiddle = new SupplierMiddle();
            try
            {
                int execCnt = 0;
                execCnt = supplierMiddle.validateSupplierEvaluate(formNo, validate, user);
                if (execCnt == 0)
                {
                    commonRep.ErrorMessage = "核准供應商評鑑失敗，請洽系統人員";
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
        [Route("api/ValidateSupplier"), HttpGet]
        public CommonRep<string> ValidateSupplier(string formNo, bool validate, string user)
        {
            CommonRep<string> commonRep = new CommonRep<string>();
            SupplierMiddle supplierMiddle = new SupplierMiddle();
            try
            {
                int execCnt = 0;
                execCnt = supplierMiddle.validateSupplier(formNo, validate, user);
                if (execCnt == 0)
                {
                    commonRep.ErrorMessage = "核准供應商失敗，請洽系統人員";
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
        [Route("api/GetSupplierQuotationList"), HttpGet]
        public CommonRep<B廠商供料> GetSupplierQuotationList()
        {
            CommonRep<B廠商供料> commonRep = new CommonRep<B廠商供料>();
            SupplierMiddle supplierMiddle = new SupplierMiddle();
            try
            {
                commonRep.resultList = supplierMiddle.getSupplierQuotationList();
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
