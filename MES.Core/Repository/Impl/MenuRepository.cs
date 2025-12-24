using Dapper;
using log4net.Config;
using log4net;
using MES.Core.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MES.Core.Repository.Impl
{
    public class MenuRepository : IRepository<Menu>
    {
        private static ILog _logger = LogManager.GetLogger(typeof(MenuRepository));
        public MenuRepository()
        {
            XmlConfigurator.Configure(new FileInfo(AppDomain.CurrentDomain.BaseDirectory + @"\log4net.config"));
        }
        public int Delete(Menu t)
        {
            int delCnt = 0;
            try
            {
                string sql = @"DELETE FROM Menu WHERE ID=@ID";

                var parameters = new DynamicParameters(t);
                using (var conn = new SqlConnection(IRepository<Menu>.ConnStr))
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

        public List<Menu> GetListBy(Menu t, string propName)
        {
            List<Menu> list = new List<Menu>();
            try
            {
                string sql = @"SELECT * FROM Menu WHERE 1=1";
                if (t != null)
                {
                    sql += $" AND {propName} = @{propName}";
                }
                var parameters = new DynamicParameters(t);
                using (var conn = new SqlConnection(IRepository<Menu>.ConnStr))
                {
                    conn.Open();
                    var result = conn.Query<Menu>(sql, parameters);
                    list = result.ToList();
                }
            }
            catch (Exception ex)
            {
                _logger.Error(ex + ex.StackTrace);
            }
            return list;
        }

        public List<Menu> GetList(Menu t)
        {
            List<Menu> list = new List<Menu>();
            try
            {
                string sql = @"SELECT * FROM Menu WHERE 1=1";
                if (t.ID != null && t.ID != 0)
                {
                    sql += " AND ID like @id+'%'";
                }
                using (var conn = new SqlConnection(IRepository<Menu>.ConnStr))
                {
                    conn.Open();
                    if (t != null && t.ID != 0)
                    {
                        var result = conn.Query<Menu>(sql, new
                        {
                            id = t.ID
                        });
                        list = result.ToList();
                    } else
                    {
                        var result = conn.Query<Menu>(sql);
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

        public Menu GetUnique(Menu t)
        {
            Menu list = new Menu();
            try
            {
                string sql = @"SELECT * FROM Menu WHERE 1=1 AND ID = @id";
                using (var conn = new SqlConnection(IRepository<Menu>.ConnStr))
                {
                    conn.Open();
                    var result = conn.QueryFirstOrDefault<Menu>(sql, new
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

        public int Insert(Menu t)
        {
            int insertCnt = 0;
            try
            {
                var sql = @"  
                                INSERT INTO dbo.Menu
                                (
                                    MenuID,
                                    MenuName,
                                    MenuSubID,
                                    CreateUser,
                                    CreateDate
                                )
                              VALUES
                              (   
                                  @MenuID,
                                  @MenuName,
                                  @MenuSubID,
                                  @CreateUser,
                                  @CreateDate
                              )
                        SELECT @@IDENTITY;";
                var parameters = new DynamicParameters(t);
                using (var conn = new SqlConnection(IRepository<Menu>.ConnStr))
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

        public int Update(Menu t)
        {
            int updateCnt = 0;
            try
            {
                var sql = @"UPDATE Menu
                               SET 
                                   MenuID=@MenuID,
                                   MenuName=@MenuName,
                                   MenuSubID=@MenuSubID,
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

        public List<Menu> GetListLike(Menu t, string propName)
        {
            List<Menu> list = new List<Menu>();
            try
            {
                string sql = @"SELECT * FROM Menu WHERE 1=1";
                if (t != null)
                {
                    sql += $" AND {propName} LIKE @{propName} +'%'";
                }
                var parameters = new DynamicParameters(t);
                using (var conn = new SqlConnection(IRepository<Menu>.ConnStr))
                {
                    conn.Open();
                    var result = conn.Query<Menu>(sql, parameters);
                    list = result.ToList();
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
