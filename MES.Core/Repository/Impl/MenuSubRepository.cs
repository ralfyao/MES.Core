using Dapper;
using log4net.Config;
using log4net;
using MES.Core.Model;
using System.Data.SqlClient;

namespace MES.Core.Repository.Impl
{
    public class MenuSubRepository : IRepository<MenuSub>
    {
        private static ILog _logger = LogManager.GetLogger(typeof(MenuSubRepository));
        public MenuSubRepository()
        {
            XmlConfigurator.Configure(new FileInfo(AppDomain.CurrentDomain.BaseDirectory + @"\log4net.config"));
        }
        public int Delete(MenuSub t)
        {
            int delCnt = 0;
            try
            {
                string sql = @"DELETE FROM MenuSub WHERE ID=@ID";

                var parameters = new DynamicParameters(t);
                using (var conn = new SqlConnection(IRepository<MenuSub>.ConnStr))
                {
                    conn.Open();
                    delCnt = conn.Execute(sql, t);
                }
            }
            catch (Exception ex)
            {
                _logger.Error(ex + ex.StackTrace);
            }
            return delCnt;
        }

        public List<MenuSub> GetListBy(MenuSub t, string propertyName)
        {
            List<MenuSub> list = new List<MenuSub>();
            try
            {
                string sql = @"SELECT * FROM MenuSub WHERE 1=1";
                if (t != null)
                {
                    var parameters = new DynamicParameters(t);
                    using (var conn = new SqlConnection(IRepository<MenuSub>.ConnStr))
                    {
                        conn.Open();
                        sql += $" AND {propertyName} = @{propertyName}";
                        list = conn.Query<MenuSub>(sql, parameters).ToList();
                    }
                }
                else
                {
                    using (var conn = new SqlConnection(IRepository<MenuSub>.ConnStr))
                    {
                        conn.Open();
                        list = conn.Query<MenuSub>(sql).ToList();
                    }
                }
            }
            catch (Exception ex)
            {
                _logger.Error(ex + ex.StackTrace);
            }
            return list;
        }

        public List<MenuSub> GetListBy(MenuSub t, string propName, string fields = "")
        {
            List<MenuSub> list = new List<MenuSub>();
            try
            {
                string sql = $@"SELECT {(string.IsNullOrEmpty(fields) ? "*" : fields)} FROM MenuSub WHERE 1=1";
                if (t != null)
                {
                    sql += $" AND {propName} = @{propName}";
                }
                var parameters = new DynamicParameters(t);
                using (var conn = new SqlConnection(IRepository<MenuSub>.ConnStr))
                {
                    conn.Open();
                    var result = conn.Query<MenuSub>(sql, parameters);
                    list = result.ToList();
                }
            }
            catch (Exception ex)
            {
                _logger.Error(ex + ex.StackTrace);
            }
            return list;
        }

        public List<MenuSub> GetList(MenuSub t)
        {
            List<MenuSub> list = new List<MenuSub>();
            try
            {
                string sql = @"SELECT * FROM MenuSub WHERE 1=1";
                if (t != null)
                {
                    sql += " AND ID like @id+'%'";
                }
                using (var conn = new SqlConnection(IRepository<MenuSub>.ConnStr))
                {
                    conn.Open();
                    if (t != null)
                    {
                        var result = conn.Query<MenuSub>(sql, new
                        {
                            id = t.ID
                        });
                        list = result.ToList();
                    }
                    else
                    {
                        var result = conn.Query<MenuSub>(sql);
                        list = result.ToList();
                    }
                }
            }
            catch (Exception ex)
            {
                _logger.Error(ex + ex.StackTrace);
            }
            return list;
        }

        public MenuSub GetUnique(MenuSub t)
        {
            MenuSub list = new MenuSub();
            try
            {
                string sql = @"SELECT * FROM MenuSub WHERE 1=1 AND ID = @id";
                using (var conn = new SqlConnection(IRepository<MenuSub>.ConnStr))
                {
                    conn.Open();
                    var result = conn.QueryFirstOrDefault<MenuSub>(sql, new
                    {
                        id = t.ID
                    });
                    list = result;
                }
            }
            catch (Exception ex)
            {
                _logger.Error(ex + ex.StackTrace);
                //throw;
            }
            return list;
        }

        public int Insert(MenuSub t)
        {
            int insertCnt = 0;
            try
            {
                var sql = @"  
                                INSERT INTO dbo.MenuSub
                                (
                                    [MenuID]
                                    ,[MenuSubID]
                                    ,[MenuSubName]
                                    ,[MenuSubUrl]
                                    ,[CreateUser]
                                    ,[CreateDate]
                                )
                              VALUES
                              (   
                                  @MenuID,
                                  @MenuSubID,
                                  @MenuSubName,
                                  @MenuSubUrl,
                                  @CreateUser,
                                  @CreateDate
                              )
                        SELECT @@IDENTITY;";
                var parameters = new DynamicParameters(t);
                using (var conn = new SqlConnection(IRepository<MenuSub>.ConnStr))
                {
                    var result = conn.QueryFirstOrDefault<int>(sql, parameters);
                    return result;
                }
            }
            catch (Exception ex)
            {
                _logger.Error(ex);
            }
            return insertCnt;
        }

        public int Update(MenuSub t)
        {
            int updateCnt = 0;
            try
            {
                var sql = @"UPDATE MenuSub
                               SET MenuID=@MenuID,
                                   MenuName=@MenuName,
                                   MenuSubID=@MenuSubID,
                                   MenuSubUrl=@MenuSubUrl,
                                   CreateUser=@CreateUser,
                                   CreateDate=getdate()
                             WHERE ID=@ID";
                var parameters = new DynamicParameters(t);
                using (var conn = new SqlConnection(IRepository<Menu>.ConnStr))
                {
                    conn.Open();
                    updateCnt = conn.Execute(sql, parameters);
                }
            }
            catch (Exception ex)
            {
                _logger.Error(ex);
            }
            return updateCnt;
        }

        public List<MenuSub> GetListLike(MenuSub t, string propName)
        {
            List<MenuSub> list = new List<MenuSub>();
            try
            {
                string sql = @"SELECT * FROM MenuSub WHERE 1=1";
                if (t != null)
                {
                    using (var conn = new SqlConnection(IRepository<MenuSub>.ConnStr))
                    {
                        conn.Open();
                        var parameters = new DynamicParameters(t);
                        sql += $" AND {propName} like @{propName}+'%'";
                        list = conn.Query<MenuSub>(sql, parameters).ToList();
                    }
                }
                else
                {
                    using (var conn = new SqlConnection(IRepository<MenuSub>.ConnStr))
                    {
                        conn.Open();
                        list = conn.Query<MenuSub>(sql).ToList();
                    }
                }
            }
            catch (Exception ex)
            {
                _logger.Error(ex + ex.StackTrace);
            }
            return list;
        }

        public List<MenuSub> GetListBy(MenuSub t, List<string> propName)
        {
            List<MenuSub> list = new List<MenuSub>();
            try
            {
                string sql = @"SELECT * FROM MenuSub WHERE 1=1";
                if (t != null)
                {
                    var parameters = new DynamicParameters(t);
                    using (var conn = new SqlConnection(IRepository<MenuSub>.ConnStr))
                    {
                        conn.Open();
                        propName.ForEach(x =>
                        {
                            if (!string.IsNullOrEmpty(x))
                            {
                                sql += $" AND {x} = @{x}";
                            }
                        });
                        list = conn.Query<MenuSub>(sql, parameters).ToList();
                    }
                }
                else
                {
                    using (var conn = new SqlConnection(IRepository<MenuSub>.ConnStr))
                    {
                        conn.Open();
                        list = conn.Query<MenuSub>(sql).ToList();
                    }
                }
            }
            catch (Exception ex)
            {
                _logger.Error(ex + ex.StackTrace);
            }
            return list;
        }
    }
}
