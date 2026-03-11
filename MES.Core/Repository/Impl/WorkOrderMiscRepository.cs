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
    public class WorkOrderMiscRepository : AbstractRepository<零件申請單>
    {
        public override int Insert(零件申請單 t)
        {
            int execCnt = 0;
            try
            {
                string sql = $@"INSERT INTO dbo.零件申請單
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
	                                @單號		    -- nvarchar(30)
                                    @申請日期		-- smalldatetime
                                    @申請人		    -- nvarchar(30)
                                    @客戶簡稱		-- nvarchar(150)
                                    @專案序號		-- nvarchar(20)
                                    @機台型號		-- nvarchar(255)
                                    @機台類型		-- nvarchar(20)
                                    @機台名稱		-- nvarchar(255)
                                    @交貨日期		-- smalldatetime
                                    @保固效期		-- smalldatetime
                                    @收費機制		-- nvarchar(30)
                                    @運送方式		-- nvarchar(30)
                                    @建檔		    -- nvarchar(30)
                                    @修改		    -- nvarchar(30)
                                    @核准		    -- nvarchar(30)
                                    GETDATE()	    -- smalldatetime
                                    @修改日		    -- smalldatetime
                                    @核准日		    -- smalldatetime
                                    @主旨		    -- nvarchar(255)
                                    @申請用途		-- nvarchar(150)
                                    @客戶編號		-- nvarchar(50)
                                    )";
                using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    conn.Open();
                    DynamicParameters dynamicParameters = new DynamicParameters(t);
                    using (var tran = conn.BeginTransaction())
                    {
                        execCnt += conn.Execute(sql, dynamicParameters, tran);
                        foreach (var item in t.detailList) 
                        {
                            item.單號 = t.單號;
                            sql = $@"INSERT INTO dbo.零件申請明細
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
	                                    @單號				-- nvarchar(30)
                                        @零件分類				-- nvarchar(30)
                                        @零件號碼				-- nvarchar(50)
                                        @品名				-- nvarchar(50)
                                        @描述				-- nvarchar(50)
                                        @數量				-- smallint
                                        @單位				-- nvarchar(10)
                                        @備註				-- nvarchar(50)
                                        @附屬模組				-- nvarchar(50)
                                        @模組編碼				-- nvarchar(20)
                                        @BOM編號				-- nvarchar(30)
                                        @BOM表識別碼			-- int
                                        )";
                            dynamicParameters = new DynamicParameters(item);
                            execCnt += conn.Execute(sql, dynamicParameters, tran);
                        }
                        foreach (var item in t.detailBRGList)
                        {
                            item.單號 = t.單號;
                            sql = $@"INSERT INTO dbo.零件申請BRG
                                    (
                                        單號,
                                        零件分類,
                                        零件號碼,
                                        品名,
                                        描述,
                                        附屬模組,
                                        選項,
                                        模組編碼,
                                        BOM表識別碼,
                                        BOM編號
                                    )
                                    VALUES
                                    (   
	                                    @單號		-- nvarchar(30)
                                        @零件分類		-- nvarchar(30)
                                        @零件號碼		-- nvarchar(50)
                                        @品名		-- nvarchar(50)
                                        @描述		-- nvarchar(50)
                                        @附屬模組		-- nvarchar(50)
                                        @選項		-- bit
                                        @模組編碼		-- nvarchar(20)
                                        @BOM表識別碼 -- int
                                        @BOM編號		-- nvarchar(30)
                                        )";
                            dynamicParameters = new DynamicParameters(item);
                            execCnt += conn.Execute(sql, dynamicParameters, tran);
                        }
                        tran.Commit();
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return execCnt;
        }

        public override int Update(零件申請單 t)
        {
            int execCnt = 0;
            try
            {
                string sql = $@"UPDATE dbo.零件申請單
                                  SET      客戶編號 =  @   客戶編號     ,
                                         申請日期   =  @ 申請日期         ,
                                        申請人      =  @申請人         ,
                                        客戶簡稱    =  @客戶簡稱    ,
                                        專案序號    =  @專案序號    ,
                                        機台型號    =  @機台型號    ,
                                        機台類型    =  @機台類型    ,
                                        機台名稱    =  @機台名稱    ,
                                        交貨日期    =  @交貨日期    ,
                                        保固效期    =  @保固效期    ,
                                        收費機制    =  @收費機制    ,
                                        運送方式    =  @運送方式    ,
                                        建檔        =  @建檔          ,
                                        修改        =  @修改          ,
                                        核准        =  @核准          ,
                                        建檔日      =  @建檔日         ,
                                        修改日      =  @修改日         ,
                                        核准日      =  @核准日         ,
                                        主旨        =  @主旨          ,
                                        申請用途    =  @申請用途        
                                 WHERE  單號=@單號";
                using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    conn.Open();
                    using (var tran = conn.BeginTransaction())
                    {
                        DynamicParameters dynamicParameters = new DynamicParameters(t);
                        execCnt += conn.Execute(sql, dynamicParameters, tran);
                        execCnt += conn.Execute("DELETE FROM 零件申請明細 WHERE 單號=@單號", dynamicParameters, tran);
                        foreach (var item in t.detailList)
                        {
                            item.單號 = t.單號;
                            sql = $@"INSERT INTO dbo.零件申請明細
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
	                                    @單號				-- nvarchar(30)
                                        @零件分類				-- nvarchar(30)
                                        @零件號碼				-- nvarchar(50)
                                        @品名				-- nvarchar(50)
                                        @描述				-- nvarchar(50)
                                        @數量				-- smallint
                                        @單位				-- nvarchar(10)
                                        @備註				-- nvarchar(50)
                                        @附屬模組				-- nvarchar(50)
                                        @模組編碼				-- nvarchar(20)
                                        @BOM編號				-- nvarchar(30)
                                        @BOM表識別碼			-- int
                                        )";
                            dynamicParameters = new DynamicParameters(item);
                            execCnt += conn.Execute(sql, dynamicParameters, tran);
                        }
                        execCnt += conn.Execute("DELETE FROM 零件申請BRG WHERE 單號=@單號", dynamicParameters, tran);
                        foreach (var item in t.detailBRGList)
                        {
                            item.單號 = t.單號;
                            sql = $@"INSERT INTO dbo.零件申請BRG
                                    (
                                        單號,
                                        零件分類,
                                        零件號碼,
                                        品名,
                                        描述,
                                        附屬模組,
                                        選項,
                                        模組編碼,
                                        BOM表識別碼,
                                        BOM編號
                                    )
                                    VALUES
                                    (   
	                                    @單號		-- nvarchar(30)
                                        @零件分類		-- nvarchar(30)
                                        @零件號碼		-- nvarchar(50)
                                        @品名		-- nvarchar(50)
                                        @描述		-- nvarchar(50)
                                        @附屬模組		-- nvarchar(50)
                                        @選項		-- bit
                                        @模組編碼		-- nvarchar(20)
                                        @BOM表識別碼 -- int
                                        @BOM編號		-- nvarchar(30)
                                        )";
                            dynamicParameters = new DynamicParameters(item);
                            execCnt += conn.Execute(sql, dynamicParameters, tran);
                        }
                        tran.Commit();
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return execCnt;
        }

        public int DeleteAll(零件申請單 t)
        {
            int execCnt = 0;
            try
            {
                string sql = $@"DELETE FROM dbo.零件申請單
                                 WHERE  單號=@單號";
                using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    conn.Open();
                    using (var tran = conn.BeginTransaction())
                    {
                        DynamicParameters dynamicParameters = new DynamicParameters(t);
                        execCnt += conn.Execute(sql, dynamicParameters, tran);
                        execCnt += conn.Execute("DELETE FROM 零件申請明細 WHERE 單號=@單號", dynamicParameters, tran);
                        execCnt += conn.Execute("DELETE FROM 零件申請BRG WHERE 單號=@單號", dynamicParameters, tran);
                        
                        tran.Commit();
                    }
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
