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
    public class ProcurementDataRepository : AbstractRepository<B採購單>
    {
        public static string SQL_INSERT_B採購單 = $@"INSERT INTO dbo.B採購單
                                                        (
                                                            單號,
                                                            日期,
                                                            廠商編號,
                                                            聯絡人,
                                                            營業稅率,
                                                            幣別,
                                                            匯率,
                                                            採購人員,
                                                            採購類別,
                                                            交易條件,
                                                            運輸方式,
                                                            送貨地址,
                                                            貿易條件,
                                                            交貨日期,
                                                            結案,
                                                            建檔,
                                                            建檔日,
                                                            修改,
                                                            修改日,
                                                            核准,
                                                            核准日,
                                                            注意事項
                                                        )
                                                        VALUES
                                                        (   
                                                            @單號       ,  -- 單號         - nvarchar(20)
                                                            @日期       ,    -- 日期         - smalldatetime
                                                            @廠商編號   ,    -- 廠商編號     - nvarchar(20)
                                                            @聯絡人     ,    -- 聯絡人       - nvarchar(20)
                                                            @營業稅率   ,    -- 營業稅率     - numeric(10, 2)
                                                            @幣別       ,    -- 幣別         - nvarchar(10)
                                                            @匯率       ,    -- 匯率         - numeric(10, 2)
                                                            @採購人員   ,    -- 採購人員     - nvarchar(10)
                                                            @採購類別   ,    -- 採購類別     - nvarchar(20)
                                                            @交易條件   ,    -- 交易條件     - nvarchar(10)
                                                            @運輸方式   ,    -- 運輸方式     - nvarchar(10)
                                                            @送貨地址   ,    -- 送貨地址     - nvarchar(max)
                                                            @貿易條件   ,    -- 貿易條件     - nvarchar(10)
                                                            @交貨日期   ,    -- 交貨日期     - smalldatetime
                                                            @結案       ,    -- 結案         - nvarchar(10)
                                                            @建檔       ,    -- 建檔         - nvarchar(20)
                                                            @建檔日     ,    -- 建檔日       - smalldatetime
                                                            @修改       ,    -- 修改         - nvarchar(20)
                                                            @修改日     ,    -- 修改日       - smalldatetime
                                                            @核准       ,    -- 核准         - nvarchar(20)
                                                            @核准日     ,    -- 核准日       - smalldatetime
                                                            @注意事項        -- 注意事項     - nvarchar(max)
                                                            )";
        public static string SQL_INSERT_B採購單明細 = $@" INSERT INTO dbo.B採購明細
                                                          (
                                                              單號,
                                                              品項編號,
                                                              品名規格,
                                                              數量,
                                                              單價,
                                                              原幣未稅,
                                                              未稅金額,
                                                              稅額,
                                                              採購金額,
                                                              交貨日期,
                                                              樣品,
                                                              備註,
                                                              請購序號,
                                                              專案序號,
                                                              結案,
                                                              代工類別,
                                                              正公差,
                                                              勾選,
                                                              採購識別碼
                                                          )
                                                          VALUES
                                                            (
                                                              @單號,
                                                              @品項編號,
                                                              @品名規格,
                                                              @數量,
                                                              @單價,
                                                              @原幣未稅,
                                                              @未稅金額,
                                                              @稅額,
                                                              @採購金額,
                                                              @交貨日期,
                                                              @樣品,
                                                              @備註,
                                                              @請購序號,
                                                              @專案序號,
                                                              @結案,
                                                              @代工類別,
                                                              @正公差,
                                                              @勾選,
                                                              @採購識別碼
                                                            )";
        public override int Insert(B採購單 t)
        {
            int execCnt = 0;
            try
            {
                using(var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    conn.Open();
                    using(var tran = conn.BeginTransaction())
                    {
                        DynamicParameters dynamicParameters = new DynamicParameters(t);
                        execCnt += conn.Execute(SQL_INSERT_B採購單, dynamicParameters, tran);
                        foreach(var item in t.procurementList)
                        {
                            item.單號 = t.單號;
                            dynamicParameters = new DynamicParameters(item);
                            execCnt += conn.Execute(SQL_INSERT_B採購單明細, dynamicParameters, tran);
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
        public void setIdColumn(string v)
        {
            this.theId = v;
        }

        public override int Update(B採購單 t)
        {
            int execCnt = 0;
            try
            {
                // 規避掉一些奇奇怪怪的資料.......
                if (t.建檔日 == "Invalid Date")
                {
                    t.建檔日 = DateTime.Now.ToString("yyyy-MM-dd");
                }
                if (t.核准日 == "Invalid Date")
                {
                    t.核准日 = null;
                }

                if (t.交貨日期 == "Invalid Date")
                {
                    t.交貨日期 = null;
                }
                using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    conn.Open();
                    using (var tran = conn.BeginTransaction())
                    {
                        DynamicParameters dynamicParameters = new DynamicParameters(t);
                        conn.Execute($@"DELETE FROM B採購單 WHERE 單號 = @單號;
                                        DELETE FROM B採購明細 WHERE 單號 = @單號", dynamicParameters, tran);
                        execCnt += conn.Execute(SQL_INSERT_B採購單, dynamicParameters, tran);
                        foreach (var item in t.procurementList)
                        {
                            item.單號 = t.單號;
                            // 規避掉一些奇奇怪怪的資料.......
                            if (item.交貨日期 == "Invalid Date")
                            {
                                item.交貨日期 = null;
                            }
                            dynamicParameters = new DynamicParameters(item);
                            execCnt += conn.Execute(SQL_INSERT_B採購單明細, dynamicParameters, tran);
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
    }
}
