using Dapper;
using log4net;
using log4net.Config;
using MES.Core.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MES.Core.Repository.Impl
{
    public class AuthenticatePrivilegeRepository : IRepository<AuthenticatePrivilege>
    {
        private readonly ILog _logger = LogManager.GetLogger(typeof(AuthenticatePrivilegeRepository));
        public AuthenticatePrivilegeRepository() 
        {
            XmlConfigurator.Configure(new FileInfo(AppDomain.CurrentDomain.BaseDirectory + @"\log4net.config"));
        }
        public int Delete(AuthenticatePrivilege t)
        {
            int delCnt = 0;
            try
            {
                string sql = @"DELETE FROM AuthenticatePrivilege WHERE ID=@ID";

                var parameters = new DynamicParameters(t);
                using (var conn = new SqlConnection(IRepository<AuthenticatePrivilege>.ConnStr))
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

        public List<AuthenticatePrivilege> GetList(AuthenticatePrivilege t)
        {
            List<AuthenticatePrivilege> list = new List<AuthenticatePrivilege>();
            try
            {
                string sql = @"SELECT * FROM AuthenticatePrivilege WHERE 1=1";
                if (t != null)
                {
                    sql += " AND ID like @id+'%'";
                }
                using (var conn = new SqlConnection(IRepository<AuthenticatePrivilege>.ConnStr))
                {
                    conn.Open();
                    if (t != null)
                    {
                        var result = conn.Query<AuthenticatePrivilege>(sql, new
                        {
                            id = t.ID
                        });
                        list = result.ToList();
                    }
                    else
                    {
                        var result = conn.Query<AuthenticatePrivilege>(sql, null);
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

        public List<AuthenticatePrivilege> GetListBy(AuthenticatePrivilege t, string propName)
        {
            List<AuthenticatePrivilege> list = new List<AuthenticatePrivilege>();
            try
            {
                string sql = @"SELECT * FROM AuthenticatePrivilege WHERE 1=1";
                if (t != null)
                {
                    sql += $" AND {propName} = @{propName}";
                }
                var parameters = new DynamicParameters(t);
                using (var conn = new SqlConnection(IRepository<AuthenticatePrivilege>.ConnStr))
                {
                    conn.Open();
                    var result = conn.Query<AuthenticatePrivilege>(sql, parameters);
                    list = result.ToList();
                }
            }
            catch (Exception ex)
            {
                _logger.Error(ex + ex.StackTrace);
            }
            return list;
        }

        public List<AuthenticatePrivilege> GetListBy(AuthenticatePrivilege t, List<string> propName)
        {
            List<AuthenticatePrivilege> list = new List<AuthenticatePrivilege>();
            try
            {
                string sql = @"SELECT * FROM AuthenticatePrivilege WHERE 1=1";
                if (t != null)
                {
                    propName.ForEach(x =>
                    {
                        if (!string.IsNullOrEmpty(x))
                        {
                            sql += $" AND {x} = @{x}";
                        }
                    });
                }
                var parameters = new DynamicParameters(t);
                using (var conn = new SqlConnection(IRepository<AuthenticatePrivilege>.ConnStr))
                {
                    conn.Open();
                    var result = conn.Query<AuthenticatePrivilege>(sql, parameters);
                    list = result.ToList();
                }
            }
            catch (Exception ex)
            {
                _logger.Error(ex + ex.StackTrace);
            }
            return list;
        }

        public List<AuthenticatePrivilege> GetListLike(AuthenticatePrivilege t, string propName)
        {
            List<AuthenticatePrivilege> list = new List<AuthenticatePrivilege>();
            try
            {
                string sql = @"SELECT * FROM AuthenticatePrivilege WHERE 1=1";
                if (t != null)
                {
                    sql += $" AND {propName} LIKE @ {propName}+'%'";
                }
                var parameters = new DynamicParameters(t);
                using (var conn = new SqlConnection(IRepository<AuthenticatePrivilege>.ConnStr))
                {
                    conn.Open();
                    var result = conn.Query<AuthenticatePrivilege>(sql, parameters);
                    list = result.ToList();
                }
            }
            catch (Exception ex)
            {
                _logger.Error(ex + ex.StackTrace);
            }
            return list;
        }

        public AuthenticatePrivilege GetUnique(AuthenticatePrivilege t)
        {
            AuthenticatePrivilege list = new AuthenticatePrivilege();
            try
            {
                string sql = @"SELECT * FROM AuthenticatePrivilege WHERE 1=1 AND ID = @id";
                using (var conn = new SqlConnection(IRepository<AuthenticatePrivilege>.ConnStr))
                {
                    conn.Open();
                    var result = conn.QueryFirstOrDefault<AuthenticatePrivilege>(sql, new
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

        public int Insert(AuthenticatePrivilege t)
        {
            int insertCnt = 0;
            try
            {
                var sql = @"  INSERT INTO dbo.AuthenticatePrivilege
                              (
                                  AuthenticatePrivilegeName,
                                  PrivilegeNameMapped,
                                  ModifyUser,
                                  ModifyDate
                              )
                              VALUES
                              (   
	                              @AuthenticatePrivilegeName,
                                  @PrivilegeNameMapped,
                                  @ModifyUser,
                                  GETDATE()
                              )
                        SELECT @@IDENTITY;";
                var parameters = new DynamicParameters(t);
                using (var conn = new SqlConnection(IRepository<AuthenticatePrivilege>.ConnStr))
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

        public int Update(AuthenticatePrivilege t)
        {
            int updateCnt = 0;
            try
            {
                var sql = @"UPDATE AuthenticatePrivilege
                               SET AuthenticatePrivilegeName = @AuthenticatePrivilegeName,
                                   PrivilegeNameMapped = @PrivilegeNameMapped,
                                   ModifyUser = @ModifyUser,
                                   ModifyDate = GETDATE(),
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
