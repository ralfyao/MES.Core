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
    public class ProductSpecRepository:IRepository<ProductSpec>
    {
        private static ILog logger = LogManager.GetLogger(typeof(ProductSpecRepository));
        public ProductSpecRepository() 
        {
            XmlConfigurator.Configure(new FileInfo(AppDomain.CurrentDomain.BaseDirectory + @"\log4net.config"));
        }

        public int Delete(ProductSpec t)
        {
            int delCnt = 0;
            try
            {
                string sql = @"DELETE FROM ProductSpec WHERE ID=@ID";

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

        public List<ProductSpec> GetList(ProductSpec t)
        {
            List<ProductSpec> prodList = new List<ProductSpec>();
            try
            {
                using (var conn = new SqlConnection(IRepository<ProductSpec>.ConnStr))
                {
                    conn.Open();
                    string sql = "SELECT * FROM ProductSpec WHERE 1=1 ";
                    if (t != null)
                    {
                        sql += " AND ProductSpecId like @ProductSpecId + '%'";
                    }
                    var parameters = new DynamicParameters(t);
                    var result = conn.Query<ProductSpec>(sql, parameters);
                    prodList.AddRange(result);
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex);
            }
            return prodList;
        }

        public List<ProductSpec> GetListBy(ProductSpec t, string propName)
        {
            List<ProductSpec> list = new List<ProductSpec>();
            try
            {
                string sql = @"SELECT * FROM ProductSpec WHERE 1=1";
                if (t != null)
                {
                    using (var conn = new SqlConnection(IRepository<ProductSpec>.ConnStr))
                    {
                        conn.Open();
                        var parameters = new DynamicParameters(t);
                        sql += $" AND {propName} = @{propName}";
                        list = conn.Query<ProductSpec>(sql, parameters).ToList();
                    }
                }
                else
                {
                    using (var conn = new SqlConnection(IRepository<Product>.ConnStr))
                    {
                        conn.Open();
                        list = conn.Query<ProductSpec>(sql).ToList();
                    }
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex + ex.StackTrace);
            }
            return list;
        }

        public List<ProductSpec> GetListBy(ProductSpec t, List<string> propName)
        {
            List<ProductSpec> list = new List<ProductSpec>();
            try
            {
                string sql = @"SELECT * FROM Product WHERE 1=1";
                if (t != null)
                {
                    using (var conn = new SqlConnection(IRepository<ProductSpec>.ConnStr))
                    {
                        conn.Open();
                        var parameters = new DynamicParameters(t);
                        propName.ForEach(x => {
                            if (!string.IsNullOrEmpty(x))
                                sql += $" AND {x} = @{x}";
                        });
                        list = conn.Query<ProductSpec>(sql, parameters).ToList();
                    }
                }
                else
                {
                    using (var conn = new SqlConnection(IRepository<ProductSpec>.ConnStr))
                    {
                        conn.Open();
                        list = conn.Query<ProductSpec>(sql).ToList();
                    }
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex + ex.StackTrace);
            }
            return list;
        }
        public List<ProductSpec> GetListBy(ProductSpec t, List<string> propName, string fields ="*")
        {
            List<ProductSpec> list = new List<ProductSpec>();
            try
            {
                string sql = $@"SELECT {(string.IsNullOrEmpty(fields)?"*":fields)} FROM Product WHERE 1=1";
                if (t != null)
                {
                    using (var conn = new SqlConnection(IRepository<ProductSpec>.ConnStr))
                    {
                        conn.Open();
                        var parameters = new DynamicParameters(t);
                        propName.ForEach(x => {
                            if (!string.IsNullOrEmpty(x))
                                sql += $" AND {x} = @{x}";
                        });
                        list = conn.Query<ProductSpec>(sql, parameters).ToList();
                    }
                }
                else
                {
                    using (var conn = new SqlConnection(IRepository<ProductSpec>.ConnStr))
                    {
                        conn.Open();
                        list = conn.Query<ProductSpec>(sql).ToList();
                    }
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex + ex.StackTrace);
            }
            return list;
        }

        public List<ProductSpec> GetListLike(ProductSpec t, string propName)
        {
            List<ProductSpec> list = new List<ProductSpec>();
            try
            {
                string sql = @"SELECT * FROM Product WHERE 1=1";
                if (t != null)
                {
                    using (var conn = new SqlConnection(IRepository<ProductSpec>.ConnStr))
                    {
                        conn.Open();
                        var parameters = new DynamicParameters(t);
                        sql += $" AND {propName} like @{propName}+'%'";
                        list = conn.Query<ProductSpec>(sql, parameters).ToList();
                    }
                }
                else
                {
                    using (var conn = new SqlConnection(IRepository<ProductSpec>.ConnStr))
                    {
                        conn.Open();
                        list = conn.Query<ProductSpec>(sql).ToList();
                    }
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex + ex.StackTrace);
            }
            return list;
        }

        public ProductSpec GetUnique(ProductSpec t)
        {
            ProductSpec? data = new ProductSpec();
            try
            {
                using (var conn = new SqlConnection(IRepository<ProductSpec>.ConnStr))
                {
                    conn.Open();
                    data = conn.QueryFirstOrDefault<ProductSpec>("SELECT * FROM ProductSpec WHERE ID = @ID",
                        new
                        {
                            ID = t.ID,
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

        public int Insert(ProductSpec t)
        {
            int insertCnt = 0;
            try
            {
                var sql = @"INSERT INTO dbo.ProductSpec
                            (
                                ProductSpecId,
                                ProductSpecName,
                                ProductSpecValue,
                                ProductSpecMaxValue,
                                ProductSpecMinValue,
                                CreateUser,
                                CreateDate,
                                ModifyUser,
                                ModifyDate
                            )
                            VALUES
                            (   
                                @ProductSpecId,
                                @ProductSpecName,
                                @ProductSpecValue,
                                @ProductSpecMaxValue,
                                @ProductSpecMinValue,
                                @CreateUser,
                                GETDATE(),
                                @ModifyUser,
                                GETDATE()
                                )
                        SELECT @@IDENTITY;";
                using (var conn = new SqlConnection(IRepository<ProductSpec>.ConnStr))
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

        public int Update(ProductSpec t)
        {
            int updateCnt = 0;
            try
            {
                var sql = @"UPDATE dbo.Product
                                SET 
	                            ProductGroupId      = @ProductGroupId,
                                ProductSpecName     = @ProductSpecName,
                                ProductSpecValue    = @ProductSpecValue,
                                CreateUser          = @CreateUser,
                                CreateDate          = @CreateDate,
                                ModifyUser          = @ModifyUser,
                                ModifyDate          = @ModifyDate
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
