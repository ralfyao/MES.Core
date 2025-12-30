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
    public class PrivilegeMenuRepository : IRepository<PrivilegeMenu>
    {
        private static ILog _logger = LogManager.GetLogger(typeof(PrivilegeMenuRepository));
        public PrivilegeMenuRepository()
        {
            XmlConfigurator.Configure(new FileInfo(AppDomain.CurrentDomain.BaseDirectory + @"\log4net.config"));
        }
        public int Delete(PrivilegeMenu t)
        {
            int delCnt = 0;
            try
            {
                string sql = @"DELETE FROM PrivilegeMenu WHERE ID=@ID";

                var parameters = new DynamicParameters(t);
                using (var conn = new SqlConnection(IRepository<PrivilegeMenu>.ConnStr))
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

        public int DeleteBy(PrivilegeMenu t, string propName)
        {
            int delCnt = 0;
            try
            {
                string sql = @"DELETE FROM PrivilegeMenu WHERE 1=1";
                if (t != null)
                {
                    sql += $" AND {propName} = @{propName}";
                }
                else
                {
                    return 0;
                }
                var parameters = new DynamicParameters(t);
                using (var conn = new SqlConnection(IRepository<PrivilegeMenu>.ConnStr))
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


        public List<PrivilegeMenu> GetList(PrivilegeMenu t)
        {
            List<PrivilegeMenu> list = new List<PrivilegeMenu>();
            try
            {
                string sql = @"SELECT * FROM PrivilegeMenu WHERE 1=1";
                if (t != null)
                {
                    sql += " AND ID like @id+'%'";
                }
                using (var conn = new SqlConnection(IRepository<PrivilegeMenu>.ConnStr))
                {
                    conn.Open();
                    var result = conn.Query<PrivilegeMenu>(sql, new
                    {
                        id = t.ID
                    });
                    list = result.ToList();
                }
            }
            catch (Exception ex)
            {
                _logger.Error(ex + ex.StackTrace);
            }
            return list;
        }

        public List<PrivilegeMenu> GetListBy(PrivilegeMenu t, string propName)
        {
            List<PrivilegeMenu> list = new List<PrivilegeMenu>();
            try
            {
                string sql = @"SELECT * FROM PrivilegeMenu WHERE 1=1";
                if (t != null)
                {
                    sql += $" AND {propName} = @{propName}";
                }
                var parameters = new DynamicParameters(t);
                using (var conn = new SqlConnection(IRepository<Privilege>.ConnStr))
                {
                    conn.Open();
                    var result = conn.Query<PrivilegeMenu>(sql, parameters);
                    list = result.ToList();
                }
            }
            catch (Exception ex)
            {
                _logger.Error(ex + ex.StackTrace);
            }
            return list;
        }

        public List<PrivilegeMenu> GetListBy(PrivilegeMenu t, List<string> propName)
        {
            List<PrivilegeMenu> list = new List<PrivilegeMenu>();
            try
            {
                string sql = @"SELECT * FROM PrivilegeMenu WHERE 1=1";
                if (t != null)
                {
                    propName.ForEach(x => {
                        if (!string.IsNullOrEmpty(x))
                        {
                            sql += $" AND {x} = @{x}";
                        }
                    });
                }
                var parameters = new DynamicParameters(t);
                using (var conn = new SqlConnection(IRepository<Privilege>.ConnStr))
                {
                    conn.Open();
                    var result = conn.Query<PrivilegeMenu>(sql, parameters);
                    list = result.ToList();
                }
            }
            catch (Exception ex)
            {
                _logger.Error(ex + ex.StackTrace);
            }
            return list;
        }

        public List<PrivilegeMenu> GetListLike(PrivilegeMenu t, string propName)
        {
            List<PrivilegeMenu> list = new List<PrivilegeMenu>();
            try
            {
                string sql = @"SELECT * FROM PrivilegeMenu WHERE 1=1";
                if (t != null)
                {
                    sql += $" AND {propName} LIKE @{propName}+'%'";
                }
                var parameters = new DynamicParameters(t);
                using (var conn = new SqlConnection(IRepository<Privilege>.ConnStr))
                {
                    conn.Open();
                    var result = conn.Query<PrivilegeMenu>(sql, parameters);
                    list = result.ToList();
                }
            }
            catch (Exception ex)
            {
                _logger.Error(ex + ex.StackTrace);
            }
            return list;
        }

        public PrivilegeMenu GetUnique(PrivilegeMenu t)
        {
            PrivilegeMenu list = new PrivilegeMenu();
            try
            {
                string sql = @"SELECT * FROM Privilege WHERE 1=1 AND ID = @id";
                using (var conn = new SqlConnection(IRepository<PrivilegeMenu>.ConnStr))
                {
                    conn.Open();
                    var result = conn.QueryFirstOrDefault<PrivilegeMenu>(sql, new
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

        public int Insert(PrivilegeMenu t)
        {
            int insertCnt = 0;
            try
            {
                var sql = @"  INSERT INTO dbo.PrivilegeMenu
                              (
                                  PrivilegeName,
                                  MenuID,
                                  MenuSubID,
                                  CreateUser,
                                  CreateDate
                              )
                              VALUES
                              (   
	                              @PrivilegeName,
                                  @MenuID,
                                  @MenuSubID,
                                  @CreateUser,
                                  @CreateDate
                              )
                        SELECT @@IDENTITY;";
                var parameters = new DynamicParameters(t);
                using (var conn = new SqlConnection(IRepository<PrivilegeMenu>.ConnStr))
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

        public int Update(PrivilegeMenu t)
        {
            int updateCnt = 0;
            try
            {
                var sql = @"UPDATE Privilege
                               SET PrivilegeName = @PrivilegeName,
                                   PrivilegeDesc = @PrivilegeDesc,
                                   CreateUser = @CreateUser,
                                   CreateDate = @CreateDate,
                             WHERE ID=@ID";
                var parameters = new DynamicParameters(t);
                using (var conn = new SqlConnection(IRepository<PrivilegeMenu>.ConnStr))
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
    }
}
