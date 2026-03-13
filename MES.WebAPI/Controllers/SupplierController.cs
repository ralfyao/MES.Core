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
    }
}
