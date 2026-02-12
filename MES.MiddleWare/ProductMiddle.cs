using log4net;
using log4net.Config;
using MES.Core.Model;
using MES.Core.Repository.Impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MES.MiddleWare
{
    public class ProductMiddle
    {
        private static ILog logger = LogManager.GetLogger(typeof(ProductMiddle));
        public ProductMiddle()
        {
            XmlConfigurator.Configure(new FileInfo(AppDomain.CurrentDomain.BaseDirectory + @"\log4net.config"));
        }
        public List<Product> GetProducts()
        {
            List<Product> products = new List<Product>();
            try
            {
                ProductRepository productRepository = new ProductRepository();
                return productRepository.GetList(null);
            }
            catch (Exception ex)
            {
                logger.Error(ex+ex.StackTrace);
                throw ex;
            }
            return products;
        }
        public List<ProductSpec> GetProductSpecs()
        {
            List<ProductSpec> productSpecs = new List<ProductSpec>();
            try
            {
                ProductSpecRepository productSpecRepository = new ProductSpecRepository();
                
                return productSpecRepository.GetList(null);
            }
            catch (Exception ex)
            {
                logger.Error(ex + ex.StackTrace);
                throw ex;
            }
            return productSpecs;
        }
        public int AddProductSpec(ProductSpecReq spec)
        {
            int addCnt = 0;
            ProductSpecRepository productSpecRepository = new ProductSpecRepository();
            try
            {
                ProductSpec productSpec = new ProductSpec();
                //productSpec.ID = Guid.NewGuid();
                productSpec.ProductSpecId = spec.productSpecId;
                productSpec.ProductSpecName = spec.productSpecName;
                productSpec.ProductSpecValue = spec.productSpecValue;
                productSpec.ProductSpecMaxValue = spec.productSpecMaxValue;
                productSpec.ProductSpecMinValue = spec.productSpecMinValue;
                productSpec.CreateUser = spec.createUser;
                productSpec.ModifyUser = spec.modifyUser;
                addCnt = productSpecRepository.Insert(productSpec);
            }
            catch (Exception ex)
            {
                logger.Error(ex + ex.StackTrace);
                return addCnt;
            }
            return addCnt;
        }
    }
}
