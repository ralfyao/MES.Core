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
    }
}
