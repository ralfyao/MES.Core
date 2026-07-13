
using Dapper;
using MES.Core.Model;
using MES.Core.Repository;
using System.Data.SqlClient;

namespace MES.WebAPI.MiddleWare
{
    public class ExRateMiddle
    {
        public List<F匯率> getAllExRateList()
        {
            using (var conn = new SqlConnection(IRepository<string>.ConnStr))
            {
                conn.Open();
                return conn.Query<F匯率>("SELECT * FROM F匯率 ORDER BY CURRENCY, 日期").ToList();
            }
        }

        // ── 識別=0 表尚未存檔之新資料列，新增後回傳系統配發之識別碼；否則依識別碼更新 ──
        public int saveExRate(F匯率 form)
        {
            using (var conn = new SqlConnection(IRepository<string>.ConnStr))
            {
                conn.Open();
                if (form.識別 == 0)
                {
                    string sql = @"INSERT INTO F匯率 (CURRENCY, 日期, 匯率) VALUES (@CURRENCY, @日期, @匯率);
                                   SELECT CAST(SCOPE_IDENTITY() AS int)";
                    return conn.QuerySingle<int>(sql, form);
                }
                else
                {
                    string sql = @"UPDATE F匯率 SET CURRENCY = @CURRENCY, 日期 = @日期, 匯率 = @匯率 WHERE 識別 = @識別";
                    conn.Execute(sql, form);
                    return form.識別;
                }
            }
        }
    }
}
