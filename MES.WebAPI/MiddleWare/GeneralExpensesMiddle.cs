
using Dapper;
using MES.Core.Model;
using MES.Core.Repository;
using MES.Core.Repository.Impl;
using System.Data.SqlClient;

namespace MES.WebAPI.MiddleWare
{
    public class GeneralExpensesMiddle
    {
        public List<總務支出單列表> getGeneralExpensesList()
        {
            string sql = @"
                    SELECT
                        dbo_F總務支出單.單號,
                        dbo_F總務支出單.日期,
                        dbo_F總務支出單.廠商編號,
                        dbo_F總務支出單.採購人員,
                        dbo_F總務支出單.採購類別,
                        dbo_F總務支出單.交易條件,
                        dbo_F其他收支明細.項目編號,
                        dbo_F收支項目設定.項目名稱,
                        dbo_F總務支出單.結案,
                        dbo_F總務支出單.核准,
                        dbo_EMPL.姓名
                    FROM
                        (
                            (
                                F總務支出單 dbo_F總務支出單
                                LEFT JOIN F其他收支明細 dbo_F其他收支明細 ON dbo_F總務支出單.單號 = dbo_F其他收支明細.單號
                            )
                            LEFT JOIN dbo.H員工清冊 AS dbo_EMPL ON dbo_F總務支出單.採購人員 = dbo_EMPL.工號
                        )
                        LEFT JOIN F收支項目設定 dbo_F收支項目設定 ON dbo_F其他收支明細.項目編號 = dbo_F收支項目設定.項目編號
                    ORDER BY dbo_F總務支出單.單號 DESC";

            using (var conn = new SqlConnection(IRepository<string>.ConnStr))
            {
                conn.Open();
                return conn.Query<總務支出單列表>(sql).ToList();
            }
        }

        // ── 產生下一個總務支出單單號：GE + 年月 + 3碼流水號 ──────────────────
        public string getGeneralExpensesNo()
        {
            using (var conn = new SqlConnection(IRepository<string>.ConnStr))
            {
                conn.Open();
                string prefix = $"GE{DateTime.Now:yyyyMM}";
                string sql = "SELECT COUNT(0) FROM F總務支出單 WHERE 單號 LIKE @prefix + '%'";
                int count = conn.Query<int>(sql, new { prefix }).First();
                return $"{prefix}{(count + 1):000}";
            }
        }

        // ── 總務憑證核銷導入：依廠商編號查詢尚未核銷的總務支出明細，供付款明細導入使用 ──
        public List<F其他收支明細> getExpenseCertImportList(string supplierNo, DateTime? from, DateTime? to)
        {
            string sql = @"
                    SELECT
                        dbo_F總務支出單.廠商編號,
                        dbo_F其他收支明細.項目編號,
                        dbo_F其他收支明細.備註,
                        dbo_F其他收支明細.原幣未稅,
                        dbo_F其他收支明細.未稅,
                        dbo_F其他收支明細.稅,
                        dbo_F其他收支明細.金額,
                        dbo_F其他收支明細.專案序號,
                        dbo_F總務支出單.單號,
                        dbo_F總務支出單.日期,
                        dbo_F總務支出單.採購人員,
                        dbo_F總務支出單.核准,
                        dbo_EMPL.姓名,
                        dbo_F其他收支明細.憑證編號,
                        dbo_F其他收支明細.勾選
                    FROM F總務支出單 dbo_F總務支出單
                    RIGHT JOIN F其他收支明細 dbo_F其他收支明細 ON dbo_F總務支出單.單號 = dbo_F其他收支明細.單號
                    LEFT JOIN B廠商設定 dbo_B廠商設定 ON dbo_F總務支出單.廠商編號 = dbo_B廠商設定.廠商編號
                    LEFT JOIN H員工清冊 dbo_EMPL ON dbo_F總務支出單.採購人員 = dbo_EMPL.工號
                    WHERE dbo_F總務支出單.廠商編號=@supplierNo AND dbo_F其他收支明細.憑證編號 IS NULL
                      AND (@from IS NULL OR dbo_F總務支出單.日期 >= @from)
                      AND (@to IS NULL OR dbo_F總務支出單.日期 <= @to)
                    ORDER BY dbo_F總務支出單.日期 DESC";

            using (var conn = new SqlConnection(IRepository<string>.ConnStr))
            {
                conn.Open();
                return conn.Query<F其他收支明細>(sql, new { supplierNo, from, to }).ToList();
            }
        }

        // ── 依單號取得單頭與明細 ──────────────────────────────────────────
        public F總務支出單 getGeneralExpensesByNo(string 單號)
        {
            using (var conn = new SqlConnection(IRepository<string>.ConnStr))
            {
                conn.Open();
                var header = conn.Query<F總務支出單>("SELECT * FROM F總務支出單 WHERE 單號 = @單號", new { 單號 }).FirstOrDefault();
                if (header == null) return null;
                header.detailList = conn.Query<F其他收支明細>("SELECT * FROM F其他收支明細 WHERE 單號 = @單號", new { 單號 }).ToList();
                return header;
            }
        }

        public int saveGeneralExpenses(F總務支出單 form)
        {
            return new GeneralExpensesDataRepository().Insert(form);
        }

        public int updateGeneralExpenses(F總務支出單 form)
        {
            return new GeneralExpensesDataRepository().Update(form);
        }

        // ── 覆核／取消覆核：設定核准人員與核准日 ──────────────────────────
        public int doValidateGeneralExpenses(string 單號, bool validate, string account)
        {
            using (var conn = new SqlConnection(IRepository<string>.ConnStr))
            {
                conn.Open();
                string sql = @"UPDATE F總務支出單 SET 核准 = @核准, 核准日 = @核准日 WHERE 單號 = @單號";
                return conn.Execute(sql, new
                {
                    核准 = validate ? account : "",
                    核准日 = validate ? DateTime.Now.ToString("yyyy-MM-dd") : null,
                    單號
                });
            }
        }

        // ── 採購人員下拉：狀況正常之員工 ──────────────────────────────────
        public List<H員工清冊> getActiveEmployeeList()
        {
            using (var conn = new SqlConnection(IRepository<string>.ConnStr))
            {
                conn.Open();
                return conn.Query<H員工清冊>("SELECT * FROM dbo.H員工清冊 WHERE 狀況 = '正常'").ToList();
            }
        }

        public int deleteGeneralExpenses(string 單號)
        {
            using (var conn = new SqlConnection(IRepository<string>.ConnStr))
            {
                conn.Open();
                string sql = @"DELETE FROM F其他收支明細 WHERE 單號 = @單號;
                               DELETE FROM F總務支出單 WHERE 單號 = @單號";
                return conn.Execute(sql, new { 單號 });
            }
        }
    }
}
