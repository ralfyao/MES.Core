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
    }
}
