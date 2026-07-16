using MES.Core.Model;
using MES.Core.Repository.Impl;
using MES.WebAPI.MiddleWare;
using MES.WebAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MES.WebAPI.Controllers
{
    [ApiController]
    public class StockInController : ControllerBase
    {
        [Route("api/AllStockInList"), HttpGet]
        public CommonRep<B進貨驗收單> AllStockInList()
        {
            CommonRep<B進貨驗收單> commonRep = new CommonRep<B進貨驗收單>();
            StockInMiddle stockInMiddle = new StockInMiddle();
            SupplierMiddle supplierMiddle = new SupplierMiddle();
            ItemRepository itemRepository = new ItemRepository();
            ProcurementMiddle procurementMiddle = new ProcurementMiddle();
            try
            {
                commonRep.resultList = stockInMiddle.allStockInLists();
                foreach (var item in commonRep.resultList)
                {
                    item.detailList = stockInMiddle.getStockInDetail(item.單號);
                }
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }
        [Route("api/StockInListView"), HttpGet]
        public CommonRep<B進退貨驗收明細> StockInListView(DateTime? from = null, DateTime? to = null)
        {
            CommonRep<B進退貨驗收明細> commonRep = new CommonRep<B進退貨驗收明細>();
            StockInMiddle stockInMiddle = new StockInMiddle();
            try
            {
                commonRep.resultList = stockInMiddle.getStockInListView(from, to);
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }
        [Route("api/StockInDetailList"), HttpGet]
        public CommonRep<B進退貨驗收明細> StockInDetailList(string stockInNo)
        {
            CommonRep<B進退貨驗收明細> commonRep = new CommonRep<B進退貨驗收明細>();
            StockInMiddle stockInMiddle = new StockInMiddle();
            SupplierMiddle supplierMiddle = new SupplierMiddle();
            ItemRepository itemRepository = new ItemRepository();
            ProcurementMiddle procurementMiddle = new ProcurementMiddle();
            try
            {
                //commonRep.resultList = stockInMiddle.allStockInLists(stockInNo);
                //foreach (var item in commonRep.resultList)
                //{
                commonRep.resultList = stockInMiddle.getStockInDetail(stockInNo);
                commonRep.resultList.ForEach(item2 =>
                    {
                        item2.廠商簡稱 = supplierMiddle.getSupplierList(item2.廠商編號).FirstOrDefault()?.廠商簡稱;
                        item2.單位 = itemRepository.GetListBy(new A材料() { 產品編號 = item2.品項編號 }, "產品編號").FirstOrDefault()?.庫存單位;
                        item2.採購數量 = (float?)procurementMiddle.getPurchaseDetailList(item2.採購單號).Where(x => x.品項編號 == item2.品項編號).ToList().FirstOrDefault()?.數量 ?? 0;
                    });
                //}
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }
        [Route("api/GetFormNo"), HttpGet]
        public CommonRep<string> GetFormNo()
        {
            CommonRep<string> commonRep = new CommonRep<string>();
            StockInMiddle stockInMiddle = new StockInMiddle();
            try
            {
                commonRep.result = stockInMiddle.getFormNo();
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }
        [Route("api/GetWarehouseWorkers"), HttpGet]
        public CommonRep<H員工清冊> GetWarehouseWorkers()
        {
            CommonRep<H員工清冊> commonRep = new CommonRep<H員工清冊>();
            StockInMiddle stockInMiddle = new StockInMiddle();
            try
            {
                commonRep.resultList = stockInMiddle.queryWareHouseWorker();
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }
        [Route("api/SaveUpdateStockInForm"), HttpPost]
        public CommonRep<string> SaveUpdateStockInForm([FromBody] B進貨驗收單 form)
        {
            CommonRep<string> commonRep = new CommonRep<string>();
            StockInMiddle stockInMiddle = new StockInMiddle();
            try
            {
                stockInMiddle.saveUpdateStockInForm(form);
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }
        [Route("api/DeleteStockInForm"), HttpPost]
        public CommonRep<string> DeleteStockInForm([FromBody] B進貨驗收單 form)
        {
            CommonRep<string> commonRep = new CommonRep<string>();
            StockInMiddle stockInMiddle = new StockInMiddle();
            try
            {
                stockInMiddle.deleteStockInForm(form);
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }
        [Route("api/QueryAvailableProcItem"), HttpGet]
        public CommonRep<B進退貨驗收明細> AvailableProcItems()
        {
            CommonRep<B進退貨驗收明細> commonRep = new CommonRep<B進退貨驗收明細>();
            StockInMiddle stockInMiddle = new StockInMiddle();
            try
            {
                commonRep.resultList = stockInMiddle.queryAvailableProcItem();
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }
        [Route("api/QueryAllIncomeCertReg"), HttpGet]
        public CommonRep<F付款> QueryAllIncomeCertReg()
        {
            CommonRep<F付款> commonRep = new CommonRep<F付款>();
            StockInMiddle stockInMiddle = new StockInMiddle();
            try
            {
                commonRep.resultList = stockInMiddle.getAllIncomeCertReg();
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }
        [Route("api/IncomeCertRegNo"), HttpGet]
        public CommonRep<string> GetIncomeCertRegNo()
        {
            CommonRep<string> commonRep = new CommonRep<string>();
            StockInMiddle stockInMiddle = new StockInMiddle();
            try
            {
                commonRep.result = stockInMiddle.getIncomeCertRegNo();
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }
        [Route("api/GetPaymentOffsetOverviewList"), HttpGet]
        public CommonRep<付款沖帳總覽> GetPaymentOffsetOverviewList()
        {
            CommonRep<付款沖帳總覽> commonRep = new CommonRep<付款沖帳總覽>();
            StockInMiddle stockInMiddle = new StockInMiddle();
            try
            {
                commonRep.resultList = stockInMiddle.getPaymentOffsetOverviewList();
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }
        [Route("api/GetIncomeCertImportList_StockIn"), HttpGet]
        public CommonRep<B進退貨驗收明細> GetIncomeCertImportList_StockIn(string supplierNo, DateTime? from, DateTime? to)
        {
            CommonRep<B進退貨驗收明細> commonRep = new CommonRep<B進退貨驗收明細>();
            StockInMiddle stockInMiddle = new StockInMiddle();
            try
            {
                commonRep.resultList = stockInMiddle.getIncomeCertImportList_StockIn(supplierNo, from, to);
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }
        [Route("api/DoSingleClose"), HttpPost]
        public CommonRep<string> DoSingleClose(string sourceNo, string user)
        {
            CommonRep<string> commonRep = new CommonRep<string>();
            StockInMiddle stockInMiddle = new StockInMiddle();
            try
            {
                commonRep.result = stockInMiddle.doSingleClose(sourceNo, user);
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }
        [Route("api/GetFundOffsetNoBySource"), HttpGet]
        public CommonRep<string> GetFundOffsetNoBySource(string sourceNo)
        {
            CommonRep<string> commonRep = new CommonRep<string>();
            StockInMiddle stockInMiddle = new StockInMiddle();
            try
            {
                commonRep.result = stockInMiddle.getFundOffsetNoBySource(sourceNo);
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }
        [Route("api/GetFundOffsetByNo"), HttpGet]
        public CommonRep<F沖款付> GetFundOffsetByNo(string no)
        {
            CommonRep<F沖款付> commonRep = new CommonRep<F沖款付>();
            StockInMiddle stockInMiddle = new StockInMiddle();
            try
            {
                commonRep.result = stockInMiddle.getFundOffsetByNo(no);
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }
        [Route("api/SaveFundOffset"), HttpPost]
        public CommonRep<string> SaveFundOffset([FromBody] F沖款付 form)
        {
            CommonRep<string> commonRep = new CommonRep<string>();
            StockInMiddle stockInMiddle = new StockInMiddle();
            try
            {
                stockInMiddle.saveFundOffset(form);
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }
        [Route("api/UpdateFundOffset"), HttpPost]
        public CommonRep<string> UpdateFundOffset([FromBody] F沖款付 form)
        {
            CommonRep<string> commonRep = new CommonRep<string>();
            StockInMiddle stockInMiddle = new StockInMiddle();
            try
            {
                stockInMiddle.updateFundOffset(form);
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }
        [Route("api/DeleteFundOffset"), HttpPost]
        public CommonRep<string> DeleteFundOffset(string no)
        {
            CommonRep<string> commonRep = new CommonRep<string>();
            StockInMiddle stockInMiddle = new StockInMiddle();
            try
            {
                stockInMiddle.deleteFundOffset(no);
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }
        [Route("api/ValidateFundOffset"), HttpPost]
        public CommonRep<string> ValidateFundOffset(string no, bool approve, string user)
        {
            CommonRep<string> commonRep = new CommonRep<string>();
            StockInMiddle stockInMiddle = new StockInMiddle();
            try
            {
                stockInMiddle.validateFundOffset(no, approve, user);
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }
        [Route("api/GetIncomeCertRegByNo"), HttpGet]
        public CommonRep<F付款> GetIncomeCertRegByNo(string no)
        {
            CommonRep<F付款> commonRep = new CommonRep<F付款>();
            StockInMiddle stockInMiddle = new StockInMiddle();
            try
            {
                commonRep.result = stockInMiddle.getIncomeCertRegByNo(no);
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }
        [Route("api/UpdateIncomeRegForm"), HttpPost]
        public CommonRep<string> UpdateIncomeRegForm([FromBody] F付款 form)
        {
            CommonRep<string> commonRep = new CommonRep<string>();
            StockInMiddle stockInMiddle = new StockInMiddle();
            try
            {
                stockInMiddle.updateIncomeRegForm(form);
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }
        [Route("api/DeleteIncomeRegForm"), HttpPost]
        public CommonRep<string> DeleteIncomeRegForm(string no)
        {
            CommonRep<string> commonRep = new CommonRep<string>();
            StockInMiddle stockInMiddle = new StockInMiddle();
            try
            {
                stockInMiddle.deleteIncomeRegForm(no);
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }
        [Route("api/ValidateIncomeRegForm"), HttpPost]
        public CommonRep<string> ValidateIncomeRegForm(string no, bool approve, string user)
        {
            CommonRep<string> commonRep = new CommonRep<string>();
            StockInMiddle stockInMiddle = new StockInMiddle();
            try
            {
                stockInMiddle.validateIncomeRegForm(no, approve, user);
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }
        [Route("api/SaveUpdateIncomeRegNo"), HttpPost]
        public CommonRep<string> SaveUpdateIncomeRegNo([FromBody] F付款 form)
        {
            CommonRep<string> commonRep = new CommonRep<string>();
            StockInMiddle stockInMiddle = new StockInMiddle();
            try
            {
                stockInMiddle.saveUpdateIncomeRegForm(form);
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
