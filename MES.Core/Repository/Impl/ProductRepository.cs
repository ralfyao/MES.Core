using Dapper;
using log4net;
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
    public class ProductRepository : IRepository<Product>
    {
        private static ILog logger = LogManager.GetLogger(typeof(ProductRepository));
        public int Delete(Product t)
        {
            int delCnt = 0;
            try
            {
                string sql = @"DELETE FROM Product WHERE ID=@ID";

                var parameters = new DynamicParameters(t);
                using (var conn = new SqlConnection(IRepository<Product>.ConnStr))
                {
                    conn.Open();
                    delCnt = conn.Execute(sql, t);
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex + ex.StackTrace);
            }
            return delCnt;
        }

        public List<Product> GetList(Product t)
        {
            List<Product> prodList = new List<Product>();
            try
            {
                using (var conn = new SqlConnection(IRepository<Authenticate>.ConnStr))
                {
                    conn.Open();
                    string sql = "SELECT * FROM Product WHERE 1=1 ";
                    if (t != null)
                    {
                        sql += " AND ProductId like @ProductId + '%'";
                    }
                    var parameters = new DynamicParameters(t);
                    var result = conn.Query<Product>(sql, parameters);
                    prodList.AddRange(result);
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex);
            }
            return prodList;
        }

        public List<Product> GetListBy(Product t, string propName)
        {
            List<Product> list = new List<Product>();
            try
            {
                string sql = @"SELECT * FROM Product WHERE 1=1";
                if (t != null)
                {
                    using (var conn = new SqlConnection(IRepository<Product>.ConnStr))
                    {
                        conn.Open();
                        var parameters = new DynamicParameters(t);
                        sql += $" AND {propName} = @{propName}";
                        list = conn.Query<Product>(sql, parameters).ToList();
                    }
                }
                else
                {
                    using (var conn = new SqlConnection(IRepository<Product>.ConnStr))
                    {
                        conn.Open();
                        list = conn.Query<Product>(sql).ToList();
                    }
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex + ex.StackTrace);
            }
            return list;
        }

        public List<Product> GetListLike(Product t, string propName)
        {
            List<Product> list = new List<Product>();
            try
            {
                string sql = @"SELECT * FROM Product WHERE 1=1";
                if (t != null)
                {
                    using (var conn = new SqlConnection(IRepository<Product>.ConnStr))
                    {
                        conn.Open();
                        var parameters = new DynamicParameters(t);
                        sql += $" AND {propName} like @{propName}+'%'";
                        list = conn.Query<Product>(sql, parameters).ToList();
                    }
                }
                else
                {
                    using (var conn = new SqlConnection(IRepository<Product>.ConnStr))
                    {
                        conn.Open();
                        list = conn.Query<Product>(sql).ToList();
                    }
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex + ex.StackTrace);
            }
            return list;
        }

        public Product GetUnique(Product t)
        {
            Product? data = new Product();
            try
            {
                using (var conn = new SqlConnection(IRepository<Product>.ConnStr))
                {
                    conn.Open();
                    data = conn.QueryFirstOrDefault<Product>("SELECT * FROM Product WHERE ID = @ID",
                        new
                        {
                            Account = t.ID,
                        }
                    );
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex);
            }
            return data;
        }

        public int Insert(Product t)
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

        public int Update(Product t)
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
