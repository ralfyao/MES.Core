using MES.Core.Model;
using MES.Core.Repository.Impl;
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
        [Route("api/ActivateSupplier"), HttpGet]
        public CommonRep<string> ActivateSupplier(string formNo, bool validate, string user)
        {
            CommonRep<string> commonRep = new CommonRep<string>();
            SupplierMiddle supplierMiddle = new SupplierMiddle();
            try
            {
                int execCnt = 0;
                execCnt = supplierMiddle.activateSupplier(formNo, validate, user);
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
                foreach (var item in commonRep.resultList)
                {
                    item.品名規格 = supplierMiddle.get品名規格(item.品項編號);
                }
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }
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
        [Route("api/AddSupplierQuotation"), HttpPost]
        public CommonRep<B廠商供料> AddSupplierQuotation([FromBody] B廠商供料 form)
        {
            CommonRep<B廠商供料> commonRep = new CommonRep<B廠商供料>();
            SupplierQuotationRepository supplierQuotationRepository = new SupplierQuotationRepository();
            try
            {
                int execCnt = supplierQuotationRepository.Insert(form);
                if (execCnt == 0)
                {
                    commonRep.ErrorMessage = "新增廠商供料失敗，請洽系統人員";
                    commonRep.WorkStatus= WorkStatus.Fail.ToString();
                }
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }
        [Route("api/QuotationByItem"), HttpGet]
        public CommonRep<廠商供料List> QuotationByItem(string itemNo)
        {
            CommonRep<廠商供料List> commonRep = new CommonRep<廠商供料List>();
            SupplierMiddle supplierMiddle = new SupplierMiddle();
            try
            {
                commonRep.result = supplierMiddle.getQuotationByItem(itemNo);
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }
        [Route("api/UpdateSupplierQuotationList"), HttpPost]
        public CommonRep<string> UpdateSupplierQuotationList([FromBody] List<B廠商供料> list)
        {
            CommonRep<string> listData = new CommonRep<string>();
            SupplierMiddle supplierMiddle = new SupplierMiddle();
            try
            {
                foreach (var item in list)
                {
                    if (item.詢價日期.IndexOf("Invalid") != -1)
                    {
                        item.詢價日期 = "1900/01/01";
                    }
                    if (item.報價有效日期.IndexOf("Invalid") != -1)
                    {
                        item.報價有效日期 = "1900/01/01";
                    }
                    item.詢價日期 = DateTime.Parse(item.詢價日期).ToString("yyyy-MM-dd");
                    item.報價有效日期 = DateTime.Parse(item.報價有效日期).ToString("yyyy-MM-dd");
                    if (item.識別 == null)
                    {
                        supplierMiddle.insertSupplierQuotation(item);
                    } 
                    else
                    {
                        supplierMiddle.updateSupplierQuotation(item);
                    }
                }
            }
            catch (Exception ex)
            {
                listData.ErrorMessage = ex.Message;
                listData.WorkStatus = WorkStatus.Fail.ToString();
            }
            return listData;
        }
        [Route("api/DeleteSupplierQuotation"), HttpPost]
        public CommonRep<string> DeleteSupplierQuotation([FromBody]B廠商供料 form)
        {
            CommonRep<string> commonRep = new CommonRep<string>();
            SupplierMiddle supplierMiddle = new SupplierMiddle();
            try
            {
                int execCnt = supplierMiddle.deleteSupplierQuotation(form);
                if (execCnt == 0)
                {
                    commonRep.ErrorMessage = "刪除詢價失敗，請洽系統人員";
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
