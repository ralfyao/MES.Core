using log4net;
using log4net.Config;
using MES.Core.Model;
using MES.MiddleWare;
using MES.WebAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace MES.WebAPI.Controllers
{
    public class ProductionController : ControllerBase
    {
        private static ILog logger = LogManager.GetLogger(typeof(ProductionController));
        public ProductionController() 
        {
            XmlConfigurator.Configure(new FileInfo(AppDomain.CurrentDomain.BaseDirectory + @"\log4net.config"));
        }
        #region 產品
        /// <summary>
        /// 產品列表
        /// </summary>
        /// <returns></returns>
        [Route("api/ProductList"), HttpGet]
        public CommonRep<Product> ProductList()
        {
            CommonRep<Product> commonRep = new CommonRep<Product>();
            try
            {
                ProductMiddle productMiddle = new ProductMiddle();
                commonRep.resultList = productMiddle.GetProducts();
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex + ex.StackTrace;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
                logger.Error(commonRep.ErrorMessage);
            }
            return commonRep;
        }
        #endregion
        #region 產品規格
        /// <summary>
        /// 產品規格列表
        /// </summary>
        /// <returns></returns>
        [Route("api/ProductSpecList"), HttpGet]
        public CommonRep<ProductSpec> ProductSpecList()
        {
            CommonRep<ProductSpec> commonRep = new CommonRep<ProductSpec>();
            ProductMiddle productMiddle = new ProductMiddle();
            try
            {
                commonRep.resultList = productMiddle.GetProductSpecs();
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex + ex.StackTrace;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
                logger.Error(commonRep.ErrorMessage);
            }
            return commonRep;
        }
        [Route("api/AddProductSpec"), HttpPost]
        public CommonRep<int> ProductSpecAdd([FromBody]ProductSpecReq spec) 
        {
            CommonRep<int> commonRep = new CommonRep<int>();
            try
            {
                spec.productSpecId = Guid.NewGuid().ToString();
                ProductMiddle productMiddle = new ProductMiddle();
                commonRep.result = productMiddle.AddProductSpec(spec);
                if (commonRep.result == 0)
                {
                    commonRep.ErrorMessage = "寫入資料有誤";
                }
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex + ex.StackTrace;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
                logger.Error(commonRep.ErrorMessage);
            }
            return commonRep;
        }
        [Route("api/GetWorkOrdersByCustId"), HttpGet]
        public CommonRep<工令單> GetWorkOrdersByCustId(string custId)
        {
            CommonRep<工令單> commonRep = new CommonRep<工令單>();
            ProductionMiddle productionMiddle = new ProductionMiddle();
            try
            {
                commonRep.resultList = productionMiddle.getWorkOrdersByCustId(custId);
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex + ex.StackTrace;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
                logger.Error(commonRep.ErrorMessage);
            }
            return commonRep;
            //throw new NotImplementedException();
        }
        [Route("api/GetProjectShippingOrder"), HttpGet]
        public CommonRep<專案機台交貨單> GetProjectShippingOrder(string projectSerial)
        {
            CommonRep<專案機台交貨單> commonRep = new CommonRep<專案機台交貨單>();
            ProductionMiddle productionMiddle = new ProductionMiddle();
            try
            {
                commonRep.resultList = productionMiddle.getProjectShippingOrderBySerial(projectSerial);
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex + ex.StackTrace;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
                logger.Error(commonRep.ErrorMessage);
            }
            return commonRep;
        }
        [Route("api/GetKeyword"), HttpGet]
        public CommonRep<string> GetKeyword(string kyType)
        {
            CommonRep<string> commonRep = new CommonRep<string>();
            ProductionMiddle productionMiddle = new ProductionMiddle();
            try
            {
                commonRep.resultList = productionMiddle.getKeyword(kyType);
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex + ex.StackTrace;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
                logger.Error(commonRep.ErrorMessage);
            }
            return commonRep;
        }
        [Route("api/GetKeywordDetail"), HttpGet]
        public CommonRep<string> GetKeywordDetail(string kyType)
        {
            CommonRep<string> commonRep = new CommonRep<string>();
            ProductionMiddle productionMiddle = new ProductionMiddle();
            try
            {
                commonRep.resultList = productionMiddle.getKeywordDetail(kyType);
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex + ex.StackTrace;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
                logger.Error(commonRep.ErrorMessage);
            }
            return commonRep;
        }
        [Route("api/GetKeywordDetailByCategory"), HttpGet]
        public CommonRep<string> GetKeywordDetailByCategory(string category)
        {
            CommonRep<string> commonRep = new CommonRep<string>();
            ProductionMiddle productionMiddle = new ProductionMiddle();
            try
            {
                commonRep.resultList = productionMiddle.getKeywordDetailByCategory(category);
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex + ex.StackTrace;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
                logger.Error(commonRep.ErrorMessage);
            }
            return commonRep;
        }

        [Route("api/GetWorkOrdersByCustIdAndProjSerial"), HttpGet]
        public CommonRep<工令單> GetWorkOrdersByProjSerial(string projSerial)
        {
            CommonRep<工令單> commonRep = new CommonRep<工令單>();
            ProductionMiddle productionMiddle = new ProductionMiddle();
            try
            {
                commonRep.result = productionMiddle.getWorkOrdersByProjSerial(projSerial);
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex + ex.StackTrace;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
                logger.Error(commonRep.ErrorMessage);
            }
            return commonRep;
        }

        [Route("api/GetWorkOrdersByCustIdAndProjSerial"), HttpGet]
        public CommonRep<C機台客服> GetEqpServiceListByProjSerial(string? 專案序號)
        {
            CommonRep<C機台客服> commonRep = new CommonRep<C機台客服>();
            ProductionMiddle productionMiddle = new ProductionMiddle();
            try
            {
                commonRep.resultList = productionMiddle.getEqpServiceListByProjSerial(專案序號);
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex + ex.StackTrace;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
                logger.Error(commonRep.ErrorMessage);
            }
            return commonRep;
        }
        #endregion
    }
}
