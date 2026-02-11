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
    public class PrivilegeRepository : AbstractRepository<Privilege>
    {
        private static ILog _logger = LogManager.GetLogger(typeof(PrivilegeRepository));
        public PrivilegeRepository() 
        {
            XmlConfigurator.Configure(new FileInfo(AppDomain.CurrentDomain.BaseDirectory + @"\log4net.config"));
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

        public override int Insert(Privilege t)
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

        public override int Update(Privilege t)
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
