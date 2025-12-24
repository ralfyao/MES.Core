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
    public class PrivilegeRepository : IRepository<Privilege>
    {
        private static ILog _logger = LogManager.GetLogger(typeof(PrivilegeRepository));
        public PrivilegeRepository() 
        {
            XmlConfigurator.Configure(new FileInfo(AppDomain.CurrentDomain.BaseDirectory + @"\log4net.config"));
        }
        public int Delete(Privilege t)
        {
            int delCnt = 0;
            try
            {
                string sql = @"DELETE FROM Privilege WHERE ID=@ID";

                var parameters = new DynamicParameters(t);
                using (var conn = new SqlConnection(IRepository<Authenticate>.ConnStr))
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

        public int DeleteBy(Privilege? t, string propName)
        {
            int delCnt = 0;
            try
            {
                string sql = @"DELETE FROM Privilege WHERE 1=1";
                if (t != null)
                {
                    sql += $" AND {propName} = @{propName}";
                }
                else
                {
                    return 0;
                }
                var parameters = new DynamicParameters(t);
                using (var conn = new SqlConnection(IRepository<Authenticate>.ConnStr))
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

        public List<Privilege> GetList(Privilege t)
        {
            List<Privilege> list = new List<Privilege>();
            try
            {
                string sql = @"SELECT * FROM Privilege WHERE 1=1";
                if (t != null)
                {
                    sql += " AND ID like @id+'%'"; 
                }
                using (var conn = new SqlConnection(IRepository<Privilege>.ConnStr))
                {
                    conn.Open();
                    if (t != null)
                    {
                        var result = conn.Query<Privilege>(sql, new
                        {
                            id = t.ID
                        });
                        list = result.ToList();
                    }
                    else
                    {
                        var result = conn.Query<Privilege>(sql, null);
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


        public List<Privilege> GetListBy(Privilege t, string propName)
        {
            List<Privilege> list = new List<Privilege>();
            try
            {
                string sql = @"SELECT * FROM Privilege WHERE 1=1";
                if (t != null)
                {
                    sql += $" AND {propName} = @{propName}";
                }
                var parameters = new DynamicParameters(t);
                using (var conn = new SqlConnection(IRepository<Privilege>.ConnStr))
                {
                    conn.Open();
                    var result = conn.Query<Privilege>(sql, parameters);
                    list = result.ToList();
                }
            }
            catch (Exception ex)
            {
                _logger.Error(ex + ex.StackTrace);
            }
            return list;
        }

        public List<Privilege> GetListLike(Privilege t, string propName)
        {
            List<Privilege> list = new List<Privilege>();
            try
            {
                string sql = @"SELECT * FROM Privilege WHERE 1=1";
                if (t != null)
                {
                    sql += $" AND {propName} LIKE @ {propName}+'%'";
                }
                var parameters = new DynamicParameters(t);
                using (var conn = new SqlConnection(IRepository<Privilege>.ConnStr))
                {
                    conn.Open();
                    var result = conn.Query<Privilege>(sql, parameters);
                    list = result.ToList();
                }
            }
            catch (Exception ex)
            {
                _logger.Error(ex + ex.StackTrace);
            }
            return list;
        }

        public Privilege GetUnique(Privilege t)
        {
            Privilege list = new Privilege();
            try
            {
                string sql = @"SELECT * FROM Privilege WHERE 1=1 AND ID = @id";
                using (var conn = new SqlConnection(IRepository<Privilege>.ConnStr))
                {
                    conn.Open();
                    var result = conn.QueryFirstOrDefault<Privilege>(sql, new
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

        public int Insert(Privilege t)
        {
            int insertCnt = 0;
            try
            {
                var sql = @"  INSERT INTO dbo.Privilege
                              (
                                  PrivilegeName,
                                  PrivilegeDesc,
                                  CreateUser,
                                  CreateDate
                              )
                              VALUES
                              (   
	                              @PrivilegeName,
                                  @PrivilegeDesc,
                                  @CreateUser,
                                  GETDATE()
                              )
                        SELECT @@IDENTITY;";
                var parameters = new DynamicParameters(t);
                using (var conn = new SqlConnection(IRepository<Privilege>.ConnStr))
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

        public int Update(Privilege t)
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
                using (var conn = new SqlConnection(IRepository<Authenticate>.ConnStr))
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
