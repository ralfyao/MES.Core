using Dapper;
using MES.Core.Model;
using System.Data.SqlClient;

namespace MES.Core.Repository.Impl
{
    public class HumanResourcePositionRepository : AbstractRepository<H職務工作分類>
    {
        public override int Insert(H職務工作分類 t)
        {
            using (var conn = new SqlConnection(IRepository<string>.ConnStr))
            {
                conn.Open();
                string sql = @"INSERT INTO H職務工作分類 (代碼, 分類, 說明, 職務, 積分點數)
                               VALUES (@代碼, @分類, @說明, @職務, @積分點數)";
                return conn.Execute(sql, t);
            }
        }

        public override int Update(H職務工作分類 t)
        {
            using (var conn = new SqlConnection(IRepository<string>.ConnStr))
            {
                conn.Open();
                string sql = @"UPDATE H職務工作分類 SET 代碼=@代碼, 分類=@分類, 說明=@說明, 積分點數=@積分點數
                               WHERE 識別碼=@識別碼";
                return conn.Execute(sql, t);
            }
        }
    }
}
