using Dapper;
using MES.Core.Model;
using System.Data.SqlClient;

namespace MES.Core.Repository.Impl
{
    public class GeneralExpensesDataRepository : AbstractRepository<F總務支出單>
    {
        public static string SQL_INSERT_F總務支出單 = $@"INSERT INTO dbo.F總務支出單
                                                        (
                                                            單號,
                                                            日期,
                                                            廠商編號,
                                                            聯絡人,
                                                            營業稅率,
                                                            幣別,
                                                            匯率,
                                                            採購人員,
                                                            採購類別,
                                                            交易條件,
                                                            結案,
                                                            建檔,
                                                            建檔日,
                                                            修改,
                                                            修改日,
                                                            核准,
                                                            核准日,
                                                            注意事項,
                                                            傳票
                                                        )
                                                        VALUES
                                                        (
                                                            @單號,
                                                            @日期,
                                                            @廠商編號,
                                                            @聯絡人,
                                                            @營業稅率,
                                                            @幣別,
                                                            @匯率,
                                                            @採購人員,
                                                            @採購類別,
                                                            @交易條件,
                                                            @結案,
                                                            @建檔,
                                                            @建檔日,
                                                            @修改,
                                                            @修改日,
                                                            @核准,
                                                            @核准日,
                                                            @注意事項,
                                                            @傳票
                                                        )";

        public static string SQL_INSERT_F其他收支明細 = $@"INSERT INTO dbo.F其他收支明細
                                                        (
                                                            單號,
                                                            項目編號,
                                                            原幣未稅,
                                                            未稅,
                                                            稅,
                                                            金額,
                                                            備註,
                                                            專案序號,
                                                            勾選,
                                                            憑證編號
                                                        )
                                                        VALUES
                                                        (
                                                            @單號,
                                                            @項目編號,
                                                            @原幣未稅,
                                                            @未稅,
                                                            @稅,
                                                            @金額,
                                                            @備註,
                                                            @專案序號,
                                                            @勾選,
                                                            @憑證編號
                                                        )";

        public override int Insert(F總務支出單 t)
        {
            int execCnt = 0;
            using (var conn = new SqlConnection(IRepository<string>.ConnStr))
            {
                conn.Open();
                using (var tran = conn.BeginTransaction())
                {
                    var dynamicParameters = new DynamicParameters(t);
                    execCnt += conn.Execute(SQL_INSERT_F總務支出單, dynamicParameters, tran);
                    foreach (var item in t.detailList)
                    {
                        item.單號 = t.單號;
                        dynamicParameters = new DynamicParameters(item);
                        execCnt += conn.Execute(SQL_INSERT_F其他收支明細, dynamicParameters, tran);
                    }
                    tran.Commit();
                }
            }
            return execCnt;
        }

        public override int Update(F總務支出單 t)
        {
            int execCnt = 0;
            using (var conn = new SqlConnection(IRepository<string>.ConnStr))
            {
                conn.Open();
                using (var tran = conn.BeginTransaction())
                {
                    var dynamicParameters = new DynamicParameters(t);
                    conn.Execute(@"DELETE FROM F總務支出單 WHERE 單號 = @單號;
                                   DELETE FROM F其他收支明細 WHERE 單號 = @單號", dynamicParameters, tran);
                    execCnt += conn.Execute(SQL_INSERT_F總務支出單, dynamicParameters, tran);
                    foreach (var item in t.detailList)
                    {
                        item.單號 = t.單號;
                        dynamicParameters = new DynamicParameters(item);
                        execCnt += conn.Execute(SQL_INSERT_F其他收支明細, dynamicParameters, tran);
                    }
                    tran.Commit();
                }
            }
            return execCnt;
        }
    }
}
