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
    }
}
