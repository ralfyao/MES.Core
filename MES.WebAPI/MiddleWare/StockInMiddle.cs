using Dapper;
using MES.Core.Model;
using MES.Core.Repository;
using MES.Core.Repository.Impl;
using System.Data.SqlClient;

namespace MES.WebAPI.MiddleWare
{
    public class StockInMiddle
    {
        public string SQL_INSERT_B進貨驗收單 = $@"INSERT INTO dbo.B進貨驗收單
                                                (
                                                    單號,
                                                    日期,
                                                    倉管人員,
                                                    備註,
                                                    建檔,
                                                    建檔日,
                                                    修改,
                                                    修改日,
                                                    核准,
                                                    核准日,
                                                    採購覆核,
                                                    覆核日,
                                                    傳票
                                                )
                                                VALUES
                                                (   
                                                    @單號		,
                                                    @日期		,
                                                    @倉管人員	,
                                                    @備註		,
                                                    @建檔		,
                                                    @建檔日		,
                                                    @修改		,
                                                    @修改日		,
                                                    @核准		,
                                                    @核准日		,
                                                    @採購覆核	,
                                                    @覆核日		,
                                                    @傳票		
                                                )";
        public string SQL_INSERT_B進退貨驗收明細 = $@"INSERT INTO dbo.B進退貨驗收明細
                                                        (
                                                            單號,
                                                            廠商編號,
                                                            品項編號,
                                                            品名規格,
                                                            批號,
                                                            收貨數量,
                                                            合格數量,
                                                            特採數量,
                                                            退回數量,
                                                            實際單價,
                                                            折讓金額,
                                                            付款金額,
                                                            樣品,
                                                            採購單號,
                                                            退貨單號,
                                                            包裝單號,
                                                            勾選
                                                        )
                                                        VALUES
                                                        (   @單號,    -- 單號 - nvarchar(20)
                                                            @廠商編號,    -- 廠商編號 - nvarchar(20)
                                                            @品項編號,    -- 品項編號 - nvarchar(30)
                                                            @品名規格,    -- 品名規格 - nvarchar(50)
                                                            @批號,    -- 批號 - nvarchar(30)
                                                            @收貨數量, -- 收貨數量 - float
                                                            @合格數量, -- 合格數量 - float
                                                            @特採數量, -- 特採數量 - float
                                                            @退回數量, -- 退回數量 - float
                                                            @實際單價, -- 實際單價 - float
                                                            @折讓金額, -- 折讓金額 - float
                                                            @付款金額, -- 付款金額 - float
                                                            @樣品, -- 樣品 - bit
                                                            @採購單號,    -- 採購單號 - nvarchar(20)
                                                            @退貨單號,    -- 退貨單號 - nvarchar(10)
                                                            @包裝單號,    -- 包裝單號 - nvarchar(10)
                                                            @勾選 -- 勾選 - bit
                                                            )";
        public List<B進貨驗收單> allStockInLists(string stockInNo = "")
        {
            List<B進貨驗收單> list = new List<B進貨驗收單>();
            StockInRepository repository = new StockInRepository();
            try
            {
                if (string.IsNullOrEmpty(stockInNo))
                {
                    list = repository.GetList(null, "", "");
                }
                else
                {
                    list = repository.GetListBy(new B進貨驗收單() {  單號 = stockInNo }, "", "");
                }
            }
            catch (Exception)
            {

                throw;
            }
            return list;
        }

        public string getFormNo()
        {
            string formNo = string.Empty;
            try
            {
                using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    conn.Open();
                    string sql = $@"SELECT COUNT(0) FROM B進貨驗收單 WHERE 單號 LIKE 'PR{DateTime.Now.ToString("yyyyMMdd")}%'";
                    var data = conn.Query<int>(sql).FirstOrDefault();
                    if (data == null)
                        data = 0;
                    return $"PR{DateTime.Now.ToString("yyyyMMdd")}{(++data).ToString("00")}";
                }
            }
            catch (Exception)
            {

                throw;
            }
            return formNo;
        }
        public List<H員工清冊> queryWareHouseWorker()
        {
            List<H員工清冊> list = new List<H員工清冊>();
            HumanResourceRepository humanResourceRepository = new HumanResourceRepository();
            try
            {
                list = humanResourceRepository.GetList(null, "", "").Where(x => x.職能 == "倉管" && x.狀況 == "正常" ).ToList();
            }
            catch (Exception)
            {
                throw;
            }
            return list;
        }

        // ── 進貨單總覽清單：依日期區間查詢，未指定區間則不限制 ─────────────────
        public List<B進退貨驗收明細> getStockInListView(DateTime? from, DateTime? to)
        {
            List<B進退貨驗收明細> list = new List<B進退貨驗收明細>();
            try
            {
                string sql = $@"SELECT
                                    dbo_B進退貨驗收明細.廠商編號,
                                    dbo_B進退貨驗收明細.品項編號,
                                    dbo_B進退貨驗收明細.品名規格,
                                    dbo_B進退貨驗收明細.收貨數量,
                                    dbo_B進退貨驗收明細.合格數量,
                                    dbo_B進退貨驗收明細.特採數量,
                                    dbo_B進退貨驗收明細.退回數量,
                                    dbo_B進退貨驗收明細.勾選,
                                    dbo_B進貨驗收單.單號,
                                    dbo_B進貨驗收單.日期,
                                    dbo_B進貨驗收單.倉管人員,
                                    dbo_B進貨驗收單.採購覆核,
                                    dbo_EMPL.姓名,
                                    dbo_B進退貨驗收明細.包裝單號 AS 專案序號,
                                    dbo_B廠商設定.廠商簡稱,
                                    dbo_B進退貨驗收明細.退貨單號
                                FROM
                                    (
                                        (
                                            B進退貨驗收明細 dbo_B進退貨驗收明細
                                            RIGHT JOIN B進貨驗收單 dbo_B進貨驗收單 ON dbo_B進退貨驗收明細.單號 = dbo_B進貨驗收單.單號
                                        )
                                        LEFT JOIN dbo.H員工清冊 dbo_EMPL ON dbo_B進貨驗收單.倉管人員 = dbo_EMPL.工號
                                    )
                                    LEFT JOIN B廠商設定 dbo_B廠商設定 ON dbo_B進退貨驗收明細.廠商編號 = dbo_B廠商設定.廠商編號
                                WHERE (@From IS NULL OR dbo_B進貨驗收單.日期 >= @From)
                                  AND (@To IS NULL OR dbo_B進貨驗收單.日期 <= @To)
                                ORDER BY dbo_B進貨驗收單.日期 DESC";
                using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    conn.Open();
                    list = conn.Query<B進退貨驗收明細>(sql, new { From = from, To = to }).ToList();
                }
            }
            catch (Exception)
            {

                throw;
            }
            return list;
        }

        // ── 進項憑證核銷導入：依廠商編號查詢已覆核且尚未退貨的進貨驗收明細，供付款明細導入使用 ──
        public List<B進退貨驗收明細> getIncomeCertImportList_StockIn(string supplierNo, DateTime? from, DateTime? to)
        {
            List<B進退貨驗收明細> list = new List<B進退貨驗收明細>();
            try
            {
                string sql = $@"SELECT
                                    dbo_B進退貨驗收明細.廠商編號,
                                    dbo_B進退貨驗收明細.品項編號,
                                    dbo_B進退貨驗收明細.品名規格,
                                    dbo_B進退貨驗收明細.收貨數量,
                                    dbo_B進退貨驗收明細.實際單價,
                                    dbo_B進退貨驗收明細.付款金額,
                                    dbo_B進退貨驗收明細.勾選,
                                    dbo_B進貨驗收單.單號,
                                    dbo_B進貨驗收單.日期,
                                    dbo_B進貨驗收單.倉管人員,
                                    dbo_B進貨驗收單.採購覆核,
                                    dbo_EMPL.姓名,
                                    dbo_B進退貨驗收明細.退貨單號
                                FROM B進退貨驗收明細 dbo_B進退貨驗收明細
                                RIGHT JOIN B進貨驗收單 dbo_B進貨驗收單 ON dbo_B進退貨驗收明細.單號 = dbo_B進貨驗收單.單號
                                LEFT JOIN H員工清冊 dbo_EMPL ON dbo_B進貨驗收單.倉管人員 = dbo_EMPL.工號
                                LEFT JOIN B廠商設定 dbo_B廠商設定 ON dbo_B進退貨驗收明細.廠商編號 = dbo_B廠商設定.廠商編號
                                WHERE dbo_B進退貨驗收明細.廠商編號=@supplierNo
                                  AND dbo_B進貨驗收單.採購覆核 IS NOT NULL
                                  AND dbo_B進退貨驗收明細.退貨單號 IS NULL
                                  AND (@from IS NULL OR dbo_B進貨驗收單.日期 >= @from)
                                  AND (@to IS NULL OR dbo_B進貨驗收單.日期 <= @to)
                                ORDER BY dbo_B進貨驗收單.日期 DESC";
                using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    conn.Open();
                    list = conn.Query<B進退貨驗收明細>(sql, new { supplierNo, from, to }).ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
            return list;
        }

        public List<B進退貨驗收明細> getStockInDetail(string 單號)
        {
            List<B進退貨驗收明細> list = new List<B進退貨驗收明細>();
            try
            {
                string sql = $@"SELECT * FROM B進退貨驗收明細 WHERE 單號='{單號}'";
                using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    conn.Open();
                    list = conn.Query<B進退貨驗收明細>(sql).ToList();
                }
            }
            catch (Exception)
            {

                throw;
            }
            return list;
        }

        public void saveUpdateStockInForm(B進貨驗收單 form)
        {
            try
            {
                DynamicParameters dynamicParameters = new DynamicParameters(form);
                using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    conn.Open();
                    using (var tran = conn.BeginTransaction())
                    {
                        conn.Execute($@"DELETE FROM B進貨驗收單 WHERE 單號=@單號", dynamicParameters, tran);
                        conn.Execute(SQL_INSERT_B進貨驗收單, dynamicParameters, tran);
                        foreach(var item in form.detailList)
                        {
                            if (string.IsNullOrEmpty(item.單號))
                            {
                                item.單號 = form.單號;
                            }
                            dynamicParameters = new DynamicParameters(item);
                            conn.Execute($@"DELETE FROM B進退貨驗收明細 WHERE 識別碼=@識別碼", dynamicParameters, tran);
                            conn.Execute(SQL_INSERT_B進退貨驗收明細, dynamicParameters, tran);
                        }
                        tran.Commit();
                    }
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public void deleteStockInForm(B進貨驗收單 form)
        {
            try
            {
                DynamicParameters dynamicParameters = new DynamicParameters(form);
                using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    conn.Open();
                    using (var tran = conn.BeginTransaction())
                    {
                        conn.Execute($@"DELETE FROM B進貨驗收單 WHERE 單號=@單號", dynamicParameters, tran);
                        //conn.Execute(SQL_INSERT_B進貨驗收單, dynamicParameters, tran);
                        foreach (var item in form.detailList)
                        {
                            if (string.IsNullOrEmpty(item.單號))
                            {
                                item.單號 = form.單號;
                            }
                            dynamicParameters = new DynamicParameters(item);
                            conn.Execute($@"DELETE FROM B進退貨驗收明細 WHERE 識別碼=@識別碼", dynamicParameters, tran);
                            //conn.Execute(SQL_INSERT_B進退貨驗收明細, dynamicParameters, tran);
                        }
                        tran.Commit();
                    }
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public List<B進退貨驗收明細> queryAvailableProcItem()
        {
            List<B進退貨驗收明細> list = new List<B進退貨驗收明細>();
            try
            {
                string strSQL = $@"SELECT a.識別 識別碼
                                          ,品項編號
                                          ,品名規格
                                          ,a.單號
                                          ,數量 採購數量
                                          ,樣品
	                                      ,b.廠商編號
	                                      ,c.廠商簡稱
                                          ,b.交貨日期 預交日期
                                      FROM B採購明細 a
                                      LEFT OUTER JOIN B採購單 b ON a.單號=b.單號
                                      LEFT OUTER JOIN dbo.B廠商設定 AS c ON b.廠商編號=c.廠商編號
                                     where a.結案=0";
                using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    conn.Open();
                    list = conn.Query<B進退貨驗收明細>(strSQL).ToList();
                }
            }
            catch (Exception)
            {

                throw;
            }
            return list;
        }

        public List<F付款> getAllIncomeCertReg()
        {
            List<F付款> list = new List<F付款>();
            try
            {
                using(var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    conn.Open();
                    list = conn.Query<F付款>("SELECT * FROM F付款").ToList();
                    foreach(var item in list)
                    {
                        item.detailList = getIncomeCertRegDetailList(item.單號);
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
            return list;
        }

        private List<F付款明細> getIncomeCertRegDetailList(string? 單號)
        {
            List<F付款明細> list = new List<F付款明細>();
            try
            {
                using(var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    conn.Open();
                    list = conn.Query<F付款明細>($"SELECT * FROM F付款明細 WHERE 單號='{單號}'").ToList();
                }
            }
            catch (Exception)
            {

                throw;
            }
            return list;
        }

        public string getIncomeCertRegNo()
        {
            try
            {
                using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    conn.Open();
                    int formCnt = conn.Query<int>($@"SELECT COUNT(0) FROM dbo.F付款 
                                                      WHERE 單號 LIKE 'AP{DateTime.Now.ToString("yyyyMM")}%'").FirstOrDefault();
                    return $@"AP{DateTime.Now.ToString("yyyyMM")}{(++formCnt).ToString("000")}";
                }
            }
            catch (Exception)
            {

                throw;
            }
            return "";
        }

        public void saveUpdateIncomeRegForm(F付款 form)
        {
            try
            {
                using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    conn.Open();
                    using(var tran = conn.BeginTransaction())
                    {
                        string sql = $@"INSERT INTO dbo.F付款
                                        (
                                            日期,
                                            單號,
                                            廠商編號,
                                            幣別,
                                            匯率,
                                            請款人員,
                                            付款日期,
                                            類別,
                                            付現金額,
                                            銀轉金額,
                                            匯費,
                                            銀存編碼,
                                            付票金額,
                                            票據號碼,
                                            付款總額,
                                            MACHINENO,
                                            發票號碼,
                                            備註,
                                            建檔,
                                            建檔日,
                                            修改,
                                            修改日,
                                            核准,
                                            核准日,
                                            傳票,
                                            結案
                                        )
                                        VALUES
                                        (   @日期,-- 日期 - smalldatetime
                                            @單號,-- 單號 - nvarchar(20)
                                            @廠商編號,-- 廠商編號 - nvarchar(20)
                                            @幣別,-- 幣別 - nvarchar(10)
                                            @匯率,-- 匯率 - numeric(10, 2)
                                            @請款人員,-- 請款人員 - nvarchar(20)
                                            @付款日期,-- 付款日期 - smalldatetime
                                            @類別,-- 類別 - nvarchar(20)
                                            @付現金額,-- 付現金額 - numeric(18, 2)
                                            @銀轉金額,-- 銀轉金額 - numeric(18, 2)
                                            @匯費,-- 匯費 - numeric(18, 2)
                                            @銀存編碼,-- 銀存編碼 - varchar(30)
                                            @付票金額,-- 付票金額 - numeric(18, 2)
                                            @票據號碼,-- 票據號碼 - varchar(50)
                                            @付款總額,-- 付款總額 - numeric(18, 2)
                                            @MACHINENO,-- MACHINENO - nvarchar(50)
                                            @發票號碼,-- 發票號碼 - varchar(20)
                                            @備註,-- 備註 - nvarchar(max)
                                            @建檔,-- 建檔 - nvarchar(20)
                                            @建檔日,-- 建檔日 - smalldatetime
                                            @修改,-- 修改 - nvarchar(20)
                                            @修改日,-- 修改日 - smalldatetime
                                            @核准,-- 核准 - nvarchar(20)
                                            @核准日,-- 核准日 - smalldatetime
                                            @傳票,-- 傳票 - nvarchar(30)
                                            @結案-- 結案 - nchar(10)
                                            )";
                        DynamicParameters dynamicParameters = new DynamicParameters(form);
                        conn.Execute(sql, dynamicParameters, tran);
                        foreach(var item in form.detailList)
                        {
                            if (string.IsNullOrEmpty(item.單號))
                                item.單號 = form.單號;
                            sql = $@"INSERT INTO dbo.F付款明細
                                    (
                                        單號,
                                        帳款來源,
                                        沖帳碼,
                                        原幣收帳金額,
                                        台幣換算金額,
                                        說明,
                                        專案序號
                                    )
                                    VALUES
                                    (   @單號,-- 單號 - varchar(50)
                                        @帳款來源,-- 帳款來源 - nchar(30)
                                        @沖帳碼,-- 沖帳碼 - nvarchar(50)
                                        @原幣收帳金額,-- 原幣收帳金額 - numeric(18, 0)
                                        @台幣換算金額,-- 台幣換算金額 - numeric(18, 0)
                                        @說明,-- 說明 - nvarchar(50)
                                        @專案序號-- 專案序號 - nvarchar(20)
                                        )";
                            dynamicParameters = new DynamicParameters(item);
                            conn.Execute(sql, dynamicParameters, tran);
                        }
                        tran.Commit();
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public F付款 getIncomeCertRegByNo(string no)
        {
            try
            {
                using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    conn.Open();
                    var form = conn.QueryFirstOrDefault<F付款>("SELECT * FROM F付款 WHERE 單號=@no", new { no });
                    if (form != null)
                    {
                        form.detailList = getIncomeCertRegDetailList(form.單號);
                    }
                    return form;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void updateIncomeRegForm(F付款 form)
        {
            try
            {
                using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    conn.Open();
                    using (var tran = conn.BeginTransaction())
                    {
                        conn.Execute("DELETE FROM F付款 WHERE 單號=@單號; DELETE FROM F付款明細 WHERE 單號=@單號",
                            new { 單號 = form.單號 }, tran);

                        string sql = $@"INSERT INTO dbo.F付款
                                        (
                                            日期,
                                            單號,
                                            廠商編號,
                                            幣別,
                                            匯率,
                                            請款人員,
                                            付款日期,
                                            類別,
                                            付現金額,
                                            銀轉金額,
                                            匯費,
                                            銀存編碼,
                                            付票金額,
                                            票據號碼,
                                            付款總額,
                                            MACHINENO,
                                            發票號碼,
                                            備註,
                                            建檔,
                                            建檔日,
                                            修改,
                                            修改日,
                                            核准,
                                            核准日,
                                            傳票,
                                            結案
                                        )
                                        VALUES
                                        (   @日期, @單號, @廠商編號, @幣別, @匯率, @請款人員, @付款日期, @類別,
                                            @付現金額, @銀轉金額, @匯費, @銀存編碼, @付票金額, @票據號碼, @付款總額,
                                            @MACHINENO, @發票號碼, @備註, @建檔, @建檔日, @修改, @修改日, @核准, @核准日,
                                            @傳票, @結案
                                            )";
                        DynamicParameters dynamicParameters = new DynamicParameters(form);
                        conn.Execute(sql, dynamicParameters, tran);
                        foreach (var item in form.detailList)
                        {
                            if (string.IsNullOrEmpty(item.單號))
                                item.單號 = form.單號;
                            sql = $@"INSERT INTO dbo.F付款明細
                                    (
                                        單號,
                                        帳款來源,
                                        沖帳碼,
                                        原幣收帳金額,
                                        台幣換算金額,
                                        說明,
                                        專案序號
                                    )
                                    VALUES
                                    (   @單號, @帳款來源, @沖帳碼, @原幣收帳金額, @台幣換算金額, @說明, @專案序號
                                        )";
                            dynamicParameters = new DynamicParameters(item);
                            conn.Execute(sql, dynamicParameters, tran);
                        }
                        tran.Commit();
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void deleteIncomeRegForm(string no)
        {
            try
            {
                using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    conn.Open();
                    conn.Execute("DELETE FROM F付款 WHERE 單號=@no; DELETE FROM F付款明細 WHERE 單號=@no", new { no });
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void validateIncomeRegForm(string no, bool approve, string user)
        {
            try
            {
                using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    conn.Open();
                    if (approve)
                    {
                        conn.Execute("UPDATE F付款 SET 核准=@user, 核准日=@date WHERE 單號=@no",
                            new { user, date = DateTime.Now.ToString("yyyy-MM-dd"), no });
                    }
                    else
                    {
                        conn.Execute("UPDATE F付款 SET 核准=NULL, 核准日=NULL WHERE 單號=@no", new { no });
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        // ── 單筆結案：對單筆進項憑證(F付款)執行沖款，比照 Access 巨集「單筆付款-H/B」與「廠商帳付款結案-single」 ──
        public string doSingleClose(string sourceNo, string user)
        {
            try
            {
                using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    conn.Open();
                    var source = conn.QueryFirstOrDefault<F付款>("SELECT * FROM F付款 WHERE 單號=@sourceNo", new { sourceNo });
                    if (source == null) throw new Exception("查無此進項憑證資料!");

                    string prefix = "BP" + DateTime.Now.ToString("yyyyMM");
                    var maxNo = conn.QueryFirstOrDefault<string>(
                        "SELECT MAX(單號) FROM F沖款付 WHERE LEFT(單號,8)=@prefix", new { prefix });
                    string cn = string.IsNullOrEmpty(maxNo)
                        ? prefix + "001"
                        : prefix + (int.Parse(maxNo.Substring(8)) + 1).ToString("000");

                    using (var tran = conn.BeginTransaction())
                    {
                        conn.Execute(@"INSERT INTO F沖款付 (日期, 單號, 廠商編號, 幣別)
                                       VALUES (@日期, @單號, @廠商編號, @幣別)",
                            new { 日期 = DateTime.Now.ToString("yyyy-MM-dd"), 單號 = cn, source.廠商編號, source.幣別 }, tran);

                        conn.Execute(@"INSERT INTO F收支沖帳明細
                                       (單號, 收付別, 帳款來源, 收款性質, 帳款日期, 沖帳碼, 原幣未稅, 台幣未稅, 稅, 金額)
                                       SELECT @cn, 收付別, 帳款來源, 收款性質, 帳款日期, 請款單號, 原幣未稅, 未稅, 稅, 金額
                                       FROM F帳款管理 WHERE 請款單號=@sourceNo",
                            new { cn, sourceNo }, tran);

                        conn.Execute("UPDATE F帳款管理 SET 結案=1 WHERE 請款單號=@sourceNo",
                            new { sourceNo }, tran);

                        tran.Commit();
                    }
                    return cn;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        // ── 依進項憑證單號，反查是否已執行過單筆結案（沖帳明細之沖帳碼=來源單號），有的話回傳對應的 F沖款付 單號 ──
        public string getFundOffsetNoBySource(string sourceNo)
        {
            try
            {
                using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    conn.Open();
                    return conn.QueryFirstOrDefault<string>(
                        "SELECT TOP 1 單號 FROM F收支沖帳明細 WHERE 沖帳碼=@sourceNo", new { sourceNo });
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        // ── 付款沖帳總覽：依單號彙總各筆沖帳明細金額，供出納付款列表使用 ──────────
        public List<付款沖帳總覽> getPaymentOffsetOverviewList()
        {
            string sql = @"
SELECT
    dbo_F沖款付.單號,
    dbo_F沖款付.日期,
    dbo_F沖款付.廠商編號,
    dbo_B廠商設定.廠商名稱,
    dbo_F沖款付.幣別,
    Sum(dbo_F收支沖帳明細.原幣未稅) AS 原幣未稅之總計,
    Sum(dbo_F收支沖帳明細.金額) AS 金額之總計,
    Sum(dbo_F收支沖帳明細.原幣沖帳金額) AS 原幣沖帳金額之總計,
    Sum(dbo_F收支沖帳明細.台幣沖帳金額) AS 台幣沖帳金額之總計,
    Sum(dbo_F收支沖帳明細.折讓金額) AS 折讓金額之總計,
    Sum(dbo_F收支沖帳明細.匯差) AS 匯差之總計,
    dbo_F沖款付.核准,
    dbo_F沖款付.核准日
FROM F沖款付 dbo_F沖款付
LEFT JOIN F收支沖帳明細 dbo_F收支沖帳明細 ON dbo_F沖款付.單號 = dbo_F收支沖帳明細.單號
LEFT JOIN B廠商設定 dbo_B廠商設定 ON dbo_F沖款付.廠商編號 = dbo_B廠商設定.廠商編號
GROUP BY
    dbo_F沖款付.單號,
    dbo_F沖款付.日期,
    dbo_F沖款付.廠商編號,
    dbo_B廠商設定.廠商名稱,
    dbo_F沖款付.幣別,
    dbo_F沖款付.核准,
    dbo_F沖款付.核准日";
            using (var conn = new SqlConnection(IRepository<string>.ConnStr))
            {
                conn.Open();
                return conn.Query<付款沖帳總覽>(sql).ToList();
            }
        }

        public F沖款付 getFundOffsetByNo(string no)
        {
            try
            {
                using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    conn.Open();
                    var form = conn.QueryFirstOrDefault<F沖款付>("SELECT * FROM F沖款付 WHERE 單號=@no", new { no });
                    if (form != null)
                    {
                        form.detailList = conn.Query<F收支沖帳明細>("SELECT * FROM F收支沖帳明細 WHERE 單號=@no", new { no }).ToList();
                    }
                    return form;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static string SQL_INSERT_F沖款付 = $@"INSERT INTO dbo.F沖款付
                                                    ( 日期, 單號, 廠商編號, 幣別, 匯率, 傳票, 備註, 付現金額, 匯費,
                                                      銀轉金額, 銀存編碼, 付票金額, 票據號碼, 付款總額,
                                                      建檔, 建檔日, 修改, 修改日, 核准, 核准日 )
                                                    VALUES
                                                    ( @日期, @單號, @廠商編號, @幣別, @匯率, @傳票, @備註, @付現金額, @匯費,
                                                      @銀轉金額, @銀存編碼, @付票金額, @票據號碼, @付款總額,
                                                      @建檔, @建檔日, @修改, @修改日, @核准, @核准日 )";

        public static string SQL_INSERT_F收支沖帳明細 = $@"INSERT INTO dbo.F收支沖帳明細
                                                    ( 單號, 收付別, 帳款來源, 收款性質, 帳款日期, 沖帳碼,
                                                      原幣未稅, 台幣未稅, 稅, 金額, 原幣沖帳金額, 台幣沖帳金額,
                                                      折讓金額, 匯差, 備註, 帳務識別碼 )
                                                    VALUES
                                                    ( @單號, @收付別, @帳款來源, @收款性質, @帳款日期, @沖帳碼,
                                                      @原幣未稅, @台幣未稅, @稅, @金額, @原幣沖帳金額, @台幣沖帳金額,
                                                      @折讓金額, @匯差, @備註, @帳務識別碼 )";

        public void saveFundOffset(F沖款付 form)
        {
            try
            {
                using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    conn.Open();
                    using (var tran = conn.BeginTransaction())
                    {
                        DynamicParameters dynamicParameters = new DynamicParameters(form);
                        conn.Execute(SQL_INSERT_F沖款付, dynamicParameters, tran);
                        foreach (var item in form.detailList)
                        {
                            if (string.IsNullOrEmpty(item.單號))
                                item.單號 = form.單號;
                            dynamicParameters = new DynamicParameters(item);
                            conn.Execute(SQL_INSERT_F收支沖帳明細, dynamicParameters, tran);
                        }
                        tran.Commit();
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void updateFundOffset(F沖款付 form)
        {
            try
            {
                using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    conn.Open();
                    using (var tran = conn.BeginTransaction())
                    {
                        conn.Execute("DELETE FROM F沖款付 WHERE 單號=@單號; DELETE FROM F收支沖帳明細 WHERE 單號=@單號",
                            new { 單號 = form.單號 }, tran);
                        DynamicParameters dynamicParameters = new DynamicParameters(form);
                        conn.Execute(SQL_INSERT_F沖款付, dynamicParameters, tran);
                        foreach (var item in form.detailList)
                        {
                            if (string.IsNullOrEmpty(item.單號))
                                item.單號 = form.單號;
                            dynamicParameters = new DynamicParameters(item);
                            conn.Execute(SQL_INSERT_F收支沖帳明細, dynamicParameters, tran);
                        }
                        tran.Commit();
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void deleteFundOffset(string no)
        {
            try
            {
                using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    conn.Open();
                    conn.Execute("DELETE FROM F沖款付 WHERE 單號=@no; DELETE FROM F收支沖帳明細 WHERE 單號=@no", new { no });
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void validateFundOffset(string no, bool approve, string user)
        {
            try
            {
                using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    conn.Open();
                    if (approve)
                    {
                        conn.Execute("UPDATE F沖款付 SET 核准=@user, 核准日=@date WHERE 單號=@no",
                            new { user, date = DateTime.Now.ToString("yyyy-MM-dd"), no });
                    }
                    else
                    {
                        conn.Execute("UPDATE F沖款付 SET 核准=NULL, 核准日=NULL WHERE 單號=@no", new { no });
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
