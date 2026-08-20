using Dapper;
using MES.Core.Model;
using System.Data.SqlClient;

namespace MES.Core.Repository.Impl
{
    // ── 成本單位人員配置：A-成本單位「成本單位人員配置」子表單對應之資料表 ──
    public class CostUnitStaffRepository : AbstractRepository<成本單位人員配置>
    {
        public override int Insert(成本單位人員配置 t)
        {
            using (var conn = new SqlConnection(IRepository<string>.ConnStr))
            {
                conn.Open();
                string sql = @"INSERT INTO 成本單位人員配置 (職務, 員工編號, 核准, 編修, 報表, 輸出, 註記, 職務代理效期, 機號)
                               VALUES (@職務, @員工編號, @核准, @編修, @報表, @輸出, @註記, @職務代理效期, @機號)";
                return conn.Execute(sql, t);
            }
        }

        public override int Update(成本單位人員配置 t)
        {
            using (var conn = new SqlConnection(IRepository<string>.ConnStr))
            {
                conn.Open();
                string sql = @"UPDATE 成本單位人員配置 SET 員工編號=@員工編號, 核准=@核准, 編修=@編修, 報表=@報表, 輸出=@輸出,
                               註記=@註記, 職務代理效期=@職務代理效期, 機號=@機號
                               WHERE 識別碼=@識別碼";
                return conn.Execute(sql, t);
            }
        }
    }
}
