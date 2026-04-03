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
    public class MiscMfgRepository : AbstractRepository<零件申請單>
    {
        public static string INSERT_零件申請單_SQL = @"INSERT INTO dbo.零件申請單
                                            (
                                                單號,
                                                申請日期,
                                                申請人,
                                                客戶簡稱,
                                                專案序號,
                                                機台型號,
                                                機台類型,
                                                機台名稱,
                                                交貨日期,
                                                保固效期,
                                                收費機制,
                                                運送方式,
                                                建檔,
                                                修改,
                                                核准,
                                                建檔日,
                                                修改日,
                                                核准日,
                                                主旨,
                                                申請用途,
                                                客戶編號
                                            )
                                            VALUES
                                            (   
	                                            @單號	,	-- nvarchar(30)
                                                @申請日期	,	-- smalldatetime
                                                @申請人	,	-- nvarchar(30)
                                                @客戶簡稱	,	-- nvarchar(150)
                                                @專案序號	,	-- nvarchar(20)
                                                @機台型號	,	-- nvarchar(255)
                                                @機台類型	,	-- nvarchar(20)
                                                @機台名稱	,	-- nvarchar(255)
                                                @交貨日期	,	-- smalldatetime
                                                @保固效期	,	-- smalldatetime
                                                @收費機制	,	-- nvarchar(30)
                                                @運送方式	,	-- nvarchar(30)
                                                @建檔	,	-- nvarchar(30)
                                                @修改	,	-- nvarchar(30)
                                                @核准	,	-- nvarchar(30)
                                                @建檔日	,	-- smalldatetime
                                                @修改日	,	-- smalldatetime
                                                @核准日	,	-- smalldatetime
                                                @主旨	,	-- nvarchar(255)
                                                @申請用途	,	-- nvarchar(150)
                                                @客戶編號		-- nvarchar(50)
                                                )";
        public static string INSERT_零件申請明細_SQL = @"INSERT INTO dbo.零件申請明細
                                                        (
                                                            單號,
                                                            零件分類,
                                                            零件號碼,
                                                            品名,
                                                            描述,
                                                            數量,
                                                            單位,
                                                            備註,
                                                            附屬模組,
                                                            模組編碼,
                                                            BOM編號,
                                                            BOM表識別碼
                                                        )
                                                        VALUES
                                                        (   
	                                                        @單號		,	-- nvarchar(30)
                                                            @零件分類	,		-- nvarchar(30)
                                                            @零件號碼	,		-- nvarchar(50)
                                                            @品名		,	-- nvarchar(50)
                                                            @描述		,	-- nvarchar(50)
                                                            @數量		,	-- smallint
                                                            @單位		,	-- nvarchar(10)
                                                            @備註		,	-- nvarchar(50)
                                                            @附屬模組	,		-- nvarchar(50)
                                                            @模組編碼	,		-- nvarchar(20)
                                                            @BOM編號	,		-- nvarchar(30)
                                                            @BOM表識別碼		-- int
                                                            )";
        public static string DELETE_零件申請_SQL = $@"DELETE FROM 零件申請單 WHERE 單號=@單號; DELETE FROM 零件申請明細 WHERE 單號=@單號;";
        public override int Insert(零件申請單 t)
        {
            int execCnt = 0;
            try
            {
                using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    conn.Open();
                    using (var tran =  conn.BeginTransaction())
                    {
                        string sql = INSERT_零件申請單_SQL;
                        DynamicParameters dynamicParameters = new DynamicParameters(t);
                        execCnt += conn.Execute(sql, dynamicParameters, tran);
                        foreach(var item in t.detailList)
                        {
                            sql = INSERT_零件申請明細_SQL;
                            item.單號 = t.單號;
                            dynamicParameters = new DynamicParameters(item);
                            execCnt += conn.Execute(sql, dynamicParameters, tran);
                        }
                        tran.Commit();
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
            return execCnt;
        }
        public override int Update(零件申請單 t)
        {
            int execCnt = 0;
            try
            {
                using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    conn.Open();
                    using (var tran = conn.BeginTransaction())
                    {
                        string sql = DELETE_零件申請_SQL;
                        DynamicParameters dynamicParameters = new DynamicParameters(t);
                        execCnt += conn.Execute(sql, dynamicParameters, tran);
                        sql = INSERT_零件申請單_SQL;
                        execCnt += conn.Execute(sql, dynamicParameters, tran);
                        foreach (var item in t.detailList)
                        {
                            sql = INSERT_零件申請明細_SQL;
                            dynamicParameters = new DynamicParameters(item);
                            execCnt += conn.Execute(sql, dynamicParameters, tran);
                        }
                        tran.Commit();
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
            return execCnt;
        }
        public string GetMiscMfgNo()
        {
            string mfgNo = string.Empty;
            try
            {
                using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    conn.Open();
                    string sql = $@"SELECT COUNT(0) COUNT FROM 零件申請單 WHERE 單號 LIKE 'G{DateTime.Now.Year - 1911}%'";
                    var result = conn.Query<int>(sql);
                    int count = 0;
                    foreach(var item in result)
                    {
                        count = item;
                    }
                    count++;
                    mfgNo = "G" + (DateTime.Now.Year - 1911) + count.ToString("000");
                }
            }
            catch (Exception)
            {

                throw;
            }
            return mfgNo;
        }
        public int updateSalesOrderMachineNo(零件申請單 form)
        {
            int execCnt = 0;
            try
            {
                using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    conn.Open();
                    DynamicParameters dynamicParameters = new DynamicParameters(form);
                    execCnt += conn.Execute($@"UPDATE C訂單 SET MACHINENO=@單號 WHERE 單號=@訂單編號", dynamicParameters);
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
