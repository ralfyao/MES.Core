using Dapper;
using MES.Core.Model;
using System.Data.SqlClient;

namespace MES.Core.Repository.Impl
{
    public class FundAdjustDataRepository : AbstractRepository<F資金調節>
    {
        public static string SQL_INSERT_F資金調節 = $@"INSERT INTO dbo.F資金調節
                                                        (
                                                            單號,
                                                            日期,
                                                            用途,
                                                            傳票編號,
                                                            備註,
                                                            建檔,
                                                            建檔日,
                                                            修改,
                                                            修改日,
                                                            核准,
                                                            核准日
                                                        )
                                                        VALUES
                                                        (
                                                            @單號,
                                                            @日期,
                                                            @用途,
                                                            @傳票編號,
                                                            @備註,
                                                            @建檔,
                                                            @建檔日,
                                                            @修改,
                                                            @修改日,
                                                            @核准,
                                                            @核准日
                                                        )";

        public static string SQL_INSERT_F銀行明細 = $@"INSERT INTO dbo.F銀行明細
                                                        (
                                                            銀存編碼,
                                                            日期,
                                                            摘要,
                                                            幣別,
                                                            匯率,
                                                            支出,
                                                            存入,
                                                            連結單號,
                                                            對象,
                                                            備註
                                                        )
                                                        VALUES
                                                        (
                                                            @銀存編碼,
                                                            @日期,
                                                            @摘要,
                                                            @幣別,
                                                            @匯率,
                                                            @支出,
                                                            @存入,
                                                            @連結單號,
                                                            @對象,
                                                            @備註
                                                        )";

        public override int Insert(F資金調節 t)
        {
            int execCnt = 0;
            using (var conn = new SqlConnection(IRepository<string>.ConnStr))
            {
                conn.Open();
                using (var tran = conn.BeginTransaction())
                {
                    var dynamicParameters = new DynamicParameters(t);
                    execCnt += conn.Execute(SQL_INSERT_F資金調節, dynamicParameters, tran);
                    foreach (var item in t.detailList)
                    {
                        item.連結單號 = t.單號;
                        dynamicParameters = new DynamicParameters(item);
                        execCnt += conn.Execute(SQL_INSERT_F銀行明細, dynamicParameters, tran);
                    }
                    tran.Commit();
                }
            }
            return execCnt;
        }

        public override int Update(F資金調節 t)
        {
            int execCnt = 0;
            using (var conn = new SqlConnection(IRepository<string>.ConnStr))
            {
                conn.Open();
                using (var tran = conn.BeginTransaction())
                {
                    var dynamicParameters = new DynamicParameters(t);
                    conn.Execute(@"DELETE FROM F資金調節 WHERE 單號 = @單號;
                                   DELETE FROM F銀行明細 WHERE 連結單號 = @單號", dynamicParameters, tran);
                    execCnt += conn.Execute(SQL_INSERT_F資金調節, dynamicParameters, tran);
                    foreach (var item in t.detailList)
                    {
                        item.連結單號 = t.單號;
                        dynamicParameters = new DynamicParameters(item);
                        execCnt += conn.Execute(SQL_INSERT_F銀行明細, dynamicParameters, tran);
                    }
                    tran.Commit();
                }
            }
            return execCnt;
        }
    }
}
