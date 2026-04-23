using MES.Core.Model;
using MES.Core.Repository.Impl;
using MES.WebAPI.MiddleWare;
using MES.WebAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MES.WebAPI.Controllers
{
    [ApiController]
    public class ItemController : ControllerBase
    {
        [Route("api/ItemList")]
        public CommonRep<A材料> ItemList()
        {
            CommonRep<A材料> commonRep = new CommonRep<A材料>();
            try
            {
                ItemRepository itemRepo = new ItemRepository();
                commonRep.resultList = itemRepo.GetList(null, "", "");
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }
        [Route("api/ItemTypeList"), HttpGet]
        public CommonRep<string> GetItemTypeList()
        {
            CommonRep<string> commonRep = new CommonRep<string>();
            ItemMiddle itemMiddle = new ItemMiddle();
            try
            {
                commonRep.resultList = itemMiddle.getItemTypeList();
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
