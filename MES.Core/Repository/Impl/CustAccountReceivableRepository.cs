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
    public class CustAccountReceivableRepository : AbstractRepository<F收款分期>
    {
        public override int Insert(F收款分期 t)
        {
            int execCnt = 0;
            string sql = $@"insert INTO　dbo.F收款分期
                            (
                                單號,
                                款項期別,
                                成數,
                                金額,
                                請款單號
                            )
                            VALUES
                            (   
                                @單號,
                                @款項期別,
                                @成數,
                                @金額,
                                @請款單號
                            )";
            using(var conn = new SqlConnection(IRepository<string>.ConnStr))
            {
                conn.Open();
                DynamicParameters dp = new DynamicParameters(t);
                try
                {
                    execCnt += conn.Execute(sql, dp);
                } 
                catch(Exception ex)
                {
                    execCnt = 0;
                }
            }
            return execCnt;
        }

        public override int Update(F收款分期 t)
        {
            int execCnt = 0;
            string sql = $@"UPDATE dbo.F收款分期
                               SET 款項期別=@款項期別,
                                   成數=@成數,
                                   金額=@金額,
                                   請款單號=@請款單號
                             WHERE 單號=@單號";
            using (var conn = new SqlConnection(IRepository<string>.ConnStr))
            {
                conn.Open();
                DynamicParameters dp = new DynamicParameters(t);
                try
                {
                    execCnt += conn.Execute(sql, dp);
                }
                catch (Exception ex)
                {
                    execCnt = 0;
                }
            }
            return execCnt;
        }
    }
}
