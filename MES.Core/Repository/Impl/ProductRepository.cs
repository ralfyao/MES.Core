using Dapper;
using log4net;
using log4net.Config;
using log4net.Repository.Hierarchy;
using MES.Core.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MES.Core.Repository.Impl
{
    public class ProductRepository : AbstractRepository<Product>
    {
        private static ILog logger = LogManager.GetLogger(typeof(ProductRepository));
        public ProductRepository()
        {
            XmlConfigurator.Configure(new FileInfo(AppDomain.CurrentDomain.BaseDirectory + @"\log4net.config"));
        }
        public override int Insert(Product t)
        {
            int insertCnt = 0;
            try
            {
                var sql = @"INSERT INTO dbo.Product
                            (
                                ID,
                                ProductId,
                                ProductName,
                                ProductDescription,
                                ProductVersion,
                                ProductSpec,
                                CreateUser,
                                CreateDate,
                                ModifyUser,
                                ModifyDate
                            )
                            VALUES
                            (   @ID                     ,
                                @ProductId              ,
                                @ProductName            ,
                                @ProductDescription     ,
                                @ProductVersion         ,
                                @ProductSpec            ,
                                @CreateUser             ,
                                @CreateDate             ,
                                @ModifyUser             ,
                                @ModifyDate             
                                )
                        SELECT @@IDENTITY;";
                using (var conn = new SqlConnection(IRepository<Authenticate>.ConnStr))
                {
                    conn.Open();
                    var result = conn.QueryFirstOrDefault<int>(sql, t);
                    return result;
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex);
            }
            return insertCnt;
        }

        public override int Update(Product t)
        {
            int updateCnt = 0;
            try
            {
                var sql = @"UPDATE dbo.Product
                                SET 
	                            ProductId				= @ProductId				,
                                ProductName				= @ProductName				,
                                ProductDescription		= @ProductDescription		,
                                ProductVersion			= @ProductVersion			,		
                                ProductSpec				= @ProductSpec				,
                                CreateUser				= @CreateUser				,
                                CreateDate				= @CreateDate				,
                                ModifyUser				= @ModifyUser				,
                                ModifyDate				= @ModifyDate
	                            WHERE ID=@ID";
                var parameters = new DynamicParameters(t);
                using (var conn = new SqlConnection(IRepository<Authenticate>.ConnStr))
                {
                    conn.Open();
                    updateCnt = conn.Execute(sql, parameters);
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex);
            }
            return updateCnt;
        }
    }
}
