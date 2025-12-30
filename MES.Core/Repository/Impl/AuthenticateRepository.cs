using Dapper;
using log4net;
using log4net.Core;
using log4net.Repository.Hierarchy;
using MES.Core.Model;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Metadata;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MES.Core.Repository.Impl
{
    public class AuthenticateRepository : IRepository<Authenticate>
    {
        private static ILog logger = LogManager.GetLogger(typeof(AuthenticateRepository));
        public int Delete(Authenticate t)
        {
            int delCnt = 0;
            try
            {
                string sql = @"DELETE FROM Authenticate WHERE Account=@Account";

                var parameters = new DynamicParameters(t);
                using (var conn = new SqlConnection(IRepository<Authenticate>.ConnStr))
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
            //throw new NotImplementedException();
        }

        public List<Authenticate> GetList(Authenticate t)
        {
            List <Authenticate> authList = new List<Authenticate>();
            try
            {
                using (var conn = new SqlConnection(IRepository<Authenticate>.ConnStr))
                {
                    conn.Open();
                    string sql = "SELECT * FROM Authenticate WHERE 1=1 ";
                    if (t != null)
                    {
                        sql += " AND Account like @Account + '%'";
                    }
                    var parameters = new DynamicParameters(t);
                    var result = conn.Query<Authenticate>(sql, parameters);
                    authList.AddRange(result);
                }
            }
            catch (Exception ex) 
            {
                logger.Error(ex);
            }
            return authList;
        }

        public List<Authenticate> GetListBy(Authenticate t, string propName)
        {
            List<Authenticate> list = new List<Authenticate>();
            try
            {
                string sql = @"SELECT * FROM Authenticate WHERE 1=1";
                if (t != null)
                {
                    using (var conn = new SqlConnection(IRepository<Authenticate>.ConnStr))
                    {
                        conn.Open();
                        var parameters = new DynamicParameters(t);
                        sql += $" AND {propName} = @{propName}";
                        list = conn.Query<Authenticate>(sql, parameters).ToList();
                    }
                }
                else
                {
                    using (var conn = new SqlConnection(IRepository<Authenticate>.ConnStr))
                    {
                        conn.Open();
                        list = conn.Query<Authenticate>(sql).ToList();
                    }
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex + ex.StackTrace);
            }
            return list;
        }

        public List<Authenticate> GetListBy(Authenticate t, List<string> propName)
        {
            List<Authenticate> list = new List<Authenticate>();
            try
            {
                string sql = @"SELECT * FROM Authenticate WHERE 1=1";
                if (t != null)
                {
                    using (var conn = new SqlConnection(IRepository<Authenticate>.ConnStr))
                    {
                        conn.Open();
                        var parameters = new DynamicParameters(t);
                        propName.ForEach(x =>
                        {
                            if (!string.IsNullOrEmpty(x))
                            {
                                sql += $" AND {x} = @{x}";
                            }
                        });
                        list = conn.Query<Authenticate>(sql, parameters).ToList();
                    }
                }
                else
                {
                    using (var conn = new SqlConnection(IRepository<Authenticate>.ConnStr))
                    {
                        conn.Open();
                        list = conn.Query<Authenticate>(sql).ToList();
                    }
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex + ex.StackTrace);
            }
            return list;
        }

        public List<Authenticate> GetListLike(Authenticate t, string propName)
        {
            List<Authenticate> list = new List<Authenticate>();
            try
            {
                string sql = @"SELECT * FROM Authenticate WHERE 1=1";
                if (t != null)
                {
                    using (var conn = new SqlConnection(IRepository<Authenticate>.ConnStr))
                    {
                        conn.Open();
                        var parameters = new DynamicParameters(t);
                        sql += $" AND {propName} like @{propName}+'%'";
                        list = conn.Query<Authenticate>(sql, parameters).ToList();
                    }
                }
                else
                {
                    using (var conn = new SqlConnection(IRepository<Authenticate>.ConnStr))
                    {
                        conn.Open();
                        list = conn.Query<Authenticate>(sql).ToList();
                    }
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex + ex.StackTrace);
            }
            return list;
        }

        public Authenticate? GetUnique(Authenticate t)
        {
            Authenticate? data = new Authenticate();
            try
            {
                using (var conn = new SqlConnection(IRepository<Authenticate>.ConnStr))
                {
                    conn.Open();
                    data = conn.QueryFirstOrDefault<Authenticate>("SELECT * FROM Authenticate WHERE Account = @Account",
                        new { 
                            Account = t.Account == null ? "" :t.Account,
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

        public int Insert(Authenticate t)
        {
            int insertCnt = 0;
            try
            {
                var sql = @"INSERT INTO Authenticate
                            (
                                Account,
                                AccountName,
                                Password,
                                Privilege,
                                LastModifier,
                                LastModifyDate
                            )
                            VALUES
                            (   
	                            @Account,
                                @AccountName,
                                @Password,
                                @Privilege,
                                @LastModifier,
                                GETDATE()  
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
            //throw new NotImplementedException();
        }

        public int Update(Authenticate t)
        {
            int updateCnt = 0;
            try
            {
                var sql = @"UPDATE Authenticate
                               SET Password = @Password,
                                   AccountName=@AccountName,
                                   Privilege = @Privilege,
                                   LastModifier = @LastModifier
                             WHERE Account=@Account";
                var parameters = new DynamicParameters(t);
                using (var conn = new SqlConnection(IRepository<Authenticate>.ConnStr))
                {
                    conn.Open();
                    updateCnt = conn.Execute(sql, parameters);
                }
            }
            catch(Exception ex)
            {
                logger.Error(ex);
            }
            return updateCnt;
            //throw new NotImplementedException();
        }
    }
}
