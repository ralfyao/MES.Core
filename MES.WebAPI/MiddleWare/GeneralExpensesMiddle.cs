
using Dapper;
using MES.Core.Model;
using MES.Core.Repository;
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
    }
}
