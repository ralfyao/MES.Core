using Dapper;
using MES.Core.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MES.Core.Repository.Impl
{
    public class AccountRepository : AbstractRepository<account>
    {
        public override int Insert(account t)
        {
            int retCode = 0;
            string insSQL = $@"INSERT INTO account(
　                                [帳號]
                                 ,[密碼]
                                 ,[姓名]
                                 ,[停用]
                                 ,[寄件允許]
                                ) 
                                VALUES
                                (
　                                 @帳號
                                 ,@密碼
                                 ,@姓名
                                 ,@停用
                                 ,@寄件允許
                                )";
            using (var conn = new SqlConnection(IRepository<string>.ConnStr))
            {
                try
                {
                    conn.Open();
                    DynamicParameters dynamicParameters = new DynamicParameters(t);
                    retCode += conn.Execute(insSQL, dynamicParameters);
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return retCode;
        }

        public override int Update(account t)
        {
            int retCode = 0;
            string insSQL = $@"DELETE FROM account WHERE 帳號=@帳號;
                               INSERT INTO account(
　                                [帳號]
                                 ,[密碼]
                                 ,[姓名]
                                 ,[停用]
                                 ,[寄件允許]
                                ) 
                                VALUES
                                (
　                                 @帳號
                                 ,@密碼
                                 ,@姓名
                                 ,@停用
                                 ,@寄件允許
                                )";
            using (var conn = new SqlConnection(IRepository<string>.ConnStr))
            {
                conn.Open();
                using (var tran = conn.BeginTransaction())
                {
                    try
                    {
                        DynamicParameters dynamicParameters = new DynamicParameters(t);
                        retCode += conn.Execute(insSQL, dynamicParameters, tran);
                        tran.Commit();
                    }
                    catch (Exception)
                    {
                        tran.Rollback();
                        throw;
                    }
                }
                
            }
            return retCode;
        }
    }
}
