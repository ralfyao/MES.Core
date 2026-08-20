using Dapper;
using MES.Core.Model;
using System.Data.SqlClient;

namespace MES.Core.Repository.Impl
{
    public class CostUnitRepository : AbstractRepository<A成本單位>
    {
        // ── 新增：識別碼為自動編號，不由此處指定 ────────────────────────────
        public override int Insert(A成本單位 t)
        {
            using (var conn = new SqlConnection(IRepository<string>.ConnStr))
            {
                conn.Open();
                string sql = @"INSERT INTO A成本單位 (職務, 標準編制, 上一級單位, 上兩級單位, 標準工時成本, 實際工時成本, 操作功能)
                               VALUES (@職務, @標準編制, @上一級單位, @上兩級單位, @標準工時成本, @實際工時成本, @操作功能)";
                return conn.Execute(sql, t);
            }
        }

        // ── 修改：以 職務(業務鍵)為條件，職務本身不可修改 ────────────────────
        public override int Update(A成本單位 t)
        {
            using (var conn = new SqlConnection(IRepository<string>.ConnStr))
            {
                conn.Open();
                string sql = @"UPDATE A成本單位 SET 標準編制=@標準編制, 上一級單位=@上一級單位, 上兩級單位=@上兩級單位,
                               標準工時成本=@標準工時成本, 實際工時成本=@實際工時成本, 操作功能=@操作功能
                               WHERE 職務=@職務";
                return conn.Execute(sql, t);
            }
        }
    }
}
