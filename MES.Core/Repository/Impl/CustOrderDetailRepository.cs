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
    public class CustOrderDetailRepository : AbstractRepository<C訂單明細>
    {
        public override int Insert(C訂單明細 t)
        {
            int execCnt = 0;
            string sql = $@"INSERT INTO dbo.C訂單明細
                                        (
                                            單號,
                                            產品編號,
                                            品名規格,
                                            數量1,
                                            單位,
                                            單價1,
                                            金額1,
                                            樣品別,
                                            描述,
                                            QUONO,
                                            專案序號,
                                            佣金率,
                                            MTYPE
                                        )
                                        VALUES
                                        (   
                                            @單號,
                                            @產品編號,
                                            @品名規格,
                                            @數量1,
                                            @單位,
                                            @單價1,
                                            @金額1,
                                            @樣品別,
                                            @描述,
                                            @QUONO,
                                            @專案序號,
                                            @佣金率,
                                            @MTYPE
                                            )";
            try
            {
                using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    conn.Open();
                    DynamicParameters parameters = new DynamicParameters(t);
                    execCnt = conn.Execute(sql, parameters);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return execCnt;
        }

        public override int Update(C訂單明細 t)
        {
            int execCnt = 0;
            string sql = $@"UPDATE dbo.C訂單明細
                                        SET
                                            單號        = @單號,   ,
                                            產品編號    = @產品編號,  ,
                                            品名規格    = @品名規格,  ,
                                            數量1       = @數量1,   ,
                                            單位        = @單位,   ,
                                            單價1       = @單價1,   ,
                                            金額1       = @金額1,   ,
                                            樣品別      = @樣品別,    ,
                                            描述        = @描述,   ,
                                            QUONO       = @QUONO,     ,
                                            專案序號    = @專案序號,         ,
                                            佣金率      = @佣金率,    ,
                                            MTYPE       @MTYPE
                                        WHERE 識別碼=@識別碼;";
            try
            {
                using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    conn.Open();
                    DynamicParameters parameters = new DynamicParameters(t);
                    execCnt = conn.Execute(sql, parameters);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return execCnt;
        }
    }
}
