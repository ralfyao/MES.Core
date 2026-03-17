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
    public class SupplierQuotationRepository : AbstractRepository<B廠商供料>
    {
        public override int Insert(B廠商供料 t)
        {
            int execCnt = 0;
            try
            {
                string sql = $@"INSERT INTO dbo.B廠商供料
                                (
                                    廠商編號,
                                    詢價日期,
                                    品項編號,
                                    採購單位,
                                    最低採購量,
                                    最大採購量,
                                    單價,
                                    幣別,
                                    詢價人員,
                                    報價有效日期,
                                    廠商品號
                                )
                                VALUES
                                (   
	                                @廠商編號,		-- nvarchar(20)
                                    @詢價日期,		-- smalldatetime
                                    @品項編號,		-- nvarchar(30)
                                    @採購單位,		-- nvarchar(10)
                                    @最低採購量,	-- int
                                    @最大採購量,	-- int
                                    @單價,		-- float
                                    @幣別,		-- nvarchar(10)
                                    @詢價人員,		-- nvarchar(10)
                                    @報價有效日期, -- smalldatetime
                                    @廠商品號		-- nvarchar(50)
                                    )";
                using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    conn.Open();
                    DynamicParameters dynamicParameters = new DynamicParameters(t);
                    execCnt += conn.Execute(sql, dynamicParameters);
                }
            }
            catch (Exception)
            {

                throw;
            }
            return execCnt;
        }

        public override int Update(B廠商供料 t)
        {
            int execCnt = 0;
            try
            {
                string sql = $@"UPDATE dbo.B廠商供料
                                 SET   廠商編號 = @廠商編號,
                                    詢價日期 = @詢價日期,
                                    品項編號 = @品項編號,
                                    採購單位 = @採購單位,
                                    最低採購量 = @最低採購量,
                                    最大採購量 = @最大採購量,
                                    單價 = @單價,
                                    幣別 = @幣別,
                                    詢價人員 = @詢價人員,
                                    報價有效日期 = @報價有效日期,
                                    廠商品號 = @廠商品號
                               WHERE 識別 = @識別";
                using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    conn.Open();
                    DynamicParameters dynamicParameters = new DynamicParameters(t);
                    execCnt += conn.Execute(sql, dynamicParameters);
                }
            }
            catch (Exception)
            {

                throw;
            }
            return execCnt;
        }
    }
}
