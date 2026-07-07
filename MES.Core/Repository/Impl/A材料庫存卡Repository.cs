using Dapper;
using MES.Core.Model;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace MES.Core.Repository.Impl
{
    public class A材料庫存卡Repository : AbstractRepository<A材料庫存卡>
    {
        public override int Insert(A材料庫存卡 t) => throw new NotImplementedException();
        public override int Update(A材料庫存卡 t) => throw new NotImplementedException();

        // ── 資料庫實際欄位為「領用人」，此處別名為 異動人員 以對應 Model 屬性 ──────
        public List<A材料庫存卡> GetListByItemNo(string productNo)
        {
            using var conn = new SqlConnection(IRepository<string>.ConnStr);
            conn.Open();
            string sql = @"SELECT
                                識別碼,
                                產品編號,
                                異動日期,
                                摘要,
                                來源用途,
                                單位,
                                入庫,
                                出庫,
                                儲位,
                                領用人 AS 異動人員,
                                備註
                            FROM dbo.A材料庫存卡
                            WHERE 產品編號 = @產品編號";
            return conn.Query<A材料庫存卡>(sql, new { 產品編號 = productNo }).ToList();
        }
    }
}
