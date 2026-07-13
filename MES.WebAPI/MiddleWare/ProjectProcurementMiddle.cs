
using Dapper;
using MES.Core.Model;
using MES.Core.Repository;
using System.Data.SqlClient;

namespace MES.WebAPI.MiddleWare
{
    public class ProjectProcurementMiddle
    {
        public List<採購計畫> getProjectProcurementList()
        {
            string sql = @"
SELECT * FROM dbo.採購計畫 AS dbo_採購計畫
WHERE CONVERT(VARCHAR,dbo_採購計畫.[入庫移轉日],112)>='20250501'
ORDER BY [dbo_採購計畫].[專案序號] DESC, [dbo_採購計畫].[零件號碼] DESC, [dbo_採購計畫].[入庫移轉日] DESC";

            using (var conn = new SqlConnection(IRepository<string>.ConnStr))
            {
                conn.Open();
                return conn.Query<採購計畫>(sql).ToList();
            }
        }

        // ── 只更新採購追蹤欄位，不動其他排程用欄位（開工/完工/預交日期等） ──
        public int updateProjectProcurement(採購計畫 form)
        {
            string sql = @"
UPDATE dbo.採購計畫 SET
    零件分類 = @零件分類,
    採購人員 = @採購人員,
    實際採購日 = @實際採購日,
    預計到貨日 = @預計到貨日,
    倉管人員 = @倉管人員,
    入庫移轉日 = @入庫移轉日,
    驗收合格 = @驗收合格
WHERE 採購識別碼 = @採購識別碼";

            using (var conn = new SqlConnection(IRepository<string>.ConnStr))
            {
                conn.Open();
                return conn.Execute(sql, form);
            }
        }
    }
}
