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
        public CommonRep<A材料> ItemList(string itemNo = "")
        {
            CommonRep<A材料> commonRep = new CommonRep<A材料>();
            try
            {
                ItemRepository itemRepo = new ItemRepository();
                if (string.IsNullOrEmpty(itemNo))
                {
                    commonRep.resultList = itemRepo.GetList(null, "", "");
                }
                else
                {
                    commonRep.resultList = itemRepo.GetListBy(new A材料() { 產品編號 = itemNo }, "產品編號");
                }
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }

        [Route("api/ItemListByKeywordSerial")]
        public CommonRep<A材料> ItemListByKeywordSerial(string keyword1 = "",
                                                        string keyword2 = "",                                                       
                                                        string keyword3 = "",
                                                        string projSerial = "")
        {
            CommonRep<A材料> commonRep = new CommonRep<A材料>();
            try
            {
                ItemRepository itemRepo = new ItemRepository();
                commonRep.resultList = itemRepo.GetList(null, "", "");
                if (!string.IsNullOrEmpty(keyword1))
                {
                    commonRep.resultList = commonRep.resultList.Where(x=>x.品名規格.IndexOf(keyword1) != -1).ToList();
                }
                if (!string.IsNullOrEmpty(keyword2))
                {
                    commonRep.resultList = commonRep.resultList.Where(x => x.品名規格.IndexOf(keyword2) != -1).ToList();
                }
                if (!string.IsNullOrEmpty(keyword3))
                {
                    commonRep.resultList = commonRep.resultList.Where(x => x.品名規格.IndexOf(keyword3) != -1).ToList();
                }

                if (string.IsNullOrEmpty(projSerial))
                {
                    //commonRep.resultList = commonRep.resultList.Where(x => x.專案.IndexOf(projSerial) != -1).ToList();
                }
                //else
                //{
                //    commonRep.resultList = itemRepo.GetListBy(new A材料() { 產品編號 = itemNo }, "產品編號");
                //}
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }
        [Route("api/GetPartCodeList"), HttpGet]
        public CommonRep<A材料品項代號> GetPartCodeList()
        {
            CommonRep<A材料品項代號> commonRep = new CommonRep<A材料品項代號>();
            try
            {
                commonRep.resultList = new A材料品項代號Repository().GetList(null, "", "");
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }
        [Route("api/GetMaterialCategoryList"), HttpGet]
        public CommonRep<A材料分類> GetMaterialCategoryList()
        {
            CommonRep<A材料分類> commonRep = new CommonRep<A材料分類>();
            try
            {
                commonRep.resultList = new A材料分類Repository().GetList(null, "", "");
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }
        [Route("api/GetMaterialFormulaList"), HttpGet]
        public CommonRep<A材料計算公式> GetMaterialFormulaList()
        {
            CommonRep<A材料計算公式> commonRep = new CommonRep<A材料計算公式>();
            try
            {
                commonRep.resultList = new A材料計算公式Repository().GetList(null, "", "");
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }
        [Route("api/AddPartCode"), HttpPost]
        public CommonRep<string> AddPartCode([FromBody] A材料品項代號 form)
        {
            CommonRep<string> commonRep = new CommonRep<string>();
            ItemMiddle itemMiddle = new ItemMiddle();
            try
            {
                itemMiddle.insertPartCode(form);
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }
        [Route("api/AddStockCard"), HttpPost]
        public CommonRep<string> AddStockCard([FromBody] A材料庫存卡 form)
        {
            CommonRep<string> commonRep = new CommonRep<string>();
            ItemMiddle itemMiddle = new ItemMiddle();
            try
            {
                itemMiddle.insertStockCard(form);
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }
        [Route("api/GetNextTempPartCode"), HttpGet]
        public CommonRep<string> GetNextTempPartCode()
        {
            CommonRep<string> commonRep = new CommonRep<string>();
            ItemMiddle itemMiddle = new ItemMiddle();
            try
            {
                commonRep.result = itemMiddle.getNextTempPartCode();
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }
        [Route("api/GetStockCardList"), HttpGet]
        public CommonRep<A材料庫存卡> GetStockCardList(string productNo)
        {
            CommonRep<A材料庫存卡> commonRep = new CommonRep<A材料庫存卡>();
            try
            {
                commonRep.resultList = new A材料庫存卡Repository()
                    .GetListByItemNo(productNo);
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }
        [Route("api/GetMaterialRequisitionListByBomNo"), HttpGet]
        public CommonRep<A材料庫存卡> GetMaterialRequisitionListByBomNo(string bomNo)
        {
            CommonRep<A材料庫存卡> commonRep = new CommonRep<A材料庫存卡>();
            try
            {
                commonRep.resultList = new A材料庫存卡Repository()
                    .GetRequisitionListByBomNo(bomNo);
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
        [Route("api/SaveUpdateItem"), HttpPost]
        public CommonRep<string> SaveUpdateItem([FromBody]A材料 form)
        {
            CommonRep<string> commonRep = new CommonRep<string>();
            ItemMiddle itemMiddle = new ItemMiddle();
            try
            {
                itemMiddle.saveUpdateItem(form);
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }
        [Route("api/GetStockSummaryList"), HttpGet]
        public CommonRep<A材料庫存彙總> GetStockSummaryList(string keyword1 = "", string keyword2 = "", string keyword3 = "", string projSerial = "")
        {
            CommonRep<A材料庫存彙總> commonRep = new CommonRep<A材料庫存彙總>();
            ItemMiddle itemMiddle = new ItemMiddle();
            try
            {
                commonRep.resultList = itemMiddle.getStockSummaryList(keyword1, keyword2, keyword3, projSerial);
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }
        [Route("api/ValidateItem"), HttpGet]
        public CommonRep<string> ValidateItem(string itemNo, bool validate, string user)
        {
            CommonRep<string> commonRep = new CommonRep<string>();
            ItemMiddle itemMiddle = new ItemMiddle();
            try
            {
                int execCnt = itemMiddle.validateItem(itemNo, validate, user);
                if (execCnt == 0)
                {
                    commonRep.ErrorMessage = "核准料品失敗，請洽系統人員";
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
        [Route("api/ToggleDisableItem"), HttpGet]
        public CommonRep<String> ToggleDisableItem(string itemNo)
        {
            CommonRep<string> commonRep = new CommonRep<string>();
            ItemMiddle itemMiddle = new ItemMiddle();
            try
            {
                itemMiddle.toggleDisableItem(itemNo);
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }
        [Route("api/DeleteItem"), HttpGet]
        public CommonRep<string> DeleteItem(string itemNo)
        {
            CommonRep<string> commonRep = new CommonRep<string>();
            ItemMiddle itemMiddle = new ItemMiddle();
            try
            {
                itemMiddle.deleteItem(itemNo);
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
