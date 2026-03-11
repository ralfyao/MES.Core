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
    public class SupplierRepository : AbstractRepository<B廠商設定>
    {
        public override int Insert(B廠商設定 t)
        {
            int execCnt = 0 ;
            try
            {
                using(var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    conn.Open();
                    string sql = $@"INSERT INTO dbo.B廠商設定
                                (
                                    廠商編號,
                                    廠商簡稱,
                                    廠商名稱,
                                    國別,
                                    公司地址,
                                    工廠地址,
                                    統一編號,
                                    聯絡人,
                                    職稱,
                                    手機,
                                    電話,
                                    傳真,
                                    電郵,
                                    所屬業別,
                                    管理分類,
                                    等級,
                                    備註,
                                    R1,
                                    R2,
                                    R3,
                                    停用,
                                    建檔,
                                    建檔日,
                                    修改,
                                    修改日,
                                    核准,
                                    核准日
                                )
                                VALUES
                                (   
	                                @廠商編號,	-- nvarchar(20)
                                    @廠商簡稱,	-- nvarchar(20)
                                    @廠商名稱,	-- nvarchar(100)
                                    @國別	,	-- nvarchar(20)
                                    @公司地址,	-- nvarchar(100)
                                    @工廠地址,	-- nvarchar(100)
                                    @統一編號,	-- nvarchar(10)
                                    @聯絡人	,	-- nvarchar(10)
                                    @職稱	,	-- nvarchar(10)
                                    @手機	,	-- nvarchar(20)
                                    @電話	,	-- nvarchar(20)
                                    @傳真	,	-- nvarchar(20)
                                    @電郵	,	-- nvarchar(50)
                                    @所屬業別,	-- nvarchar(20)
                                    @管理分類,	-- nvarchar(10)
                                    @等級	,	-- nvarchar(10)
                                    @備註	,	-- nvarchar(100)
                                    @R1		,	-- nvarchar(50)
                                    @R2		,	-- nvarchar(50)
                                    @R3		,	-- nvarchar(50)
                                    @停用	,	-- bit
                                    @建檔	,	-- nvarchar(20)
                                    @建檔日	,	-- smalldatetime
                                    @修改	,	-- nvarchar(20)
                                    @修改日	,	-- smalldatetime
                                    @核准	,	-- nvarchar(20)
                                    @核准日		-- smalldatetime
                                    )";
                    DynamicParameters dynamicParameters = new DynamicParameters(t);
                    execCnt += conn.Execute(sql, dynamicParameters);
                }
            }
            catch (Exception)
            {

                throw;
            }
            return execCnt ;
        }

        public override int Update(B廠商設定 t)
        {
            int execCnt = 0;
            try
            {
                using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    conn.Open();
                    string sql = $@" DELETE FROM dbo.B廠商設定 WHERE 廠商編號=@廠商編號;
                                INSERT INTO dbo.B廠商設定
                                (
                                    廠商編號,
                                    廠商簡稱,
                                    廠商名稱,
                                    國別,
                                    公司地址,
                                    工廠地址,
                                    統一編號,
                                    聯絡人,
                                    職稱,
                                    手機,
                                    電話,
                                    傳真,
                                    電郵,
                                    所屬業別,
                                    管理分類,
                                    等級,
                                    備註,
                                    R1,
                                    R2,
                                    R3,
                                    停用,
                                    建檔,
                                    建檔日,
                                    修改,
                                    修改日,
                                    核准,
                                    核准日
                                )
                                VALUES
                                (   
	                                @廠商編號,	-- nvarchar(20)
                                    @廠商簡稱,	-- nvarchar(20)
                                    @廠商名稱,	-- nvarchar(100)
                                    @國別	,	-- nvarchar(20)
                                    @公司地址,	-- nvarchar(100)
                                    @工廠地址,	-- nvarchar(100)
                                    @統一編號,	-- nvarchar(10)
                                    @聯絡人	,	-- nvarchar(10)
                                    @職稱	,	-- nvarchar(10)
                                    @手機	,	-- nvarchar(20)
                                    @電話	,	-- nvarchar(20)
                                    @傳真	,	-- nvarchar(20)
                                    @電郵	,	-- nvarchar(50)
                                    @所屬業別,	-- nvarchar(20)
                                    @管理分類,	-- nvarchar(10)
                                    @等級	,	-- nvarchar(10)
                                    @備註	,	-- nvarchar(100)
                                    @R1		,	-- nvarchar(50)
                                    @R2		,	-- nvarchar(50)
                                    @R3		,	-- nvarchar(50)
                                    @停用	,	-- bit
                                    @建檔	,	-- nvarchar(20)
                                    @建檔日	,	-- smalldatetime
                                    @修改	,	-- nvarchar(20)
                                    @修改日	,	-- smalldatetime
                                    @核准	,	-- nvarchar(20)
                                    @核准日		-- smalldatetime
                                    )";
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
