using Dapper;
using MES.Core.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MES.Core.Repository.Impl
{
    public class ShipOrderRepository : AbstractRepository<C出貨單>
    {
        public override int Insert(C出貨單 t)
        {
            int execCnt = 0;
            string strSQL = $@"INSERT INTO dbo.C出貨單
                                (
                                    日期,
                                    單號,
                                    客戶編號,
                                    業務員,
                                    幣別,
                                    匯率,
                                    稅別,
                                    稅率,
                                    總額,
                                    佣金,
                                    原定交貨日期,
                                    交貨地址,
                                    指配國別,
                                    目的港,
                                    價格條件,
                                    交貨方式,
                                    付款方式,
                                    交貨日期,
                                    Remark,
                                    建檔,
                                    修改,
                                    核准,
                                    建檔日,
                                    修改日,
                                    核准日,
                                    傳票
                                )
                                VALUES
                                (   
                                    @日期,
                                    @單號,
                                    @客戶編號,
                                    @業務員,
                                    @幣別,
                                    @匯率,
                                    @稅別,
                                    @稅率,
                                    @總額,
                                    @佣金,
                                    @原定交貨日期,
                                    @交貨地址,
                                    @指配國別,
                                    @目的港,
                                    @價格條件,
                                    @交貨方式,
                                    @付款方式,
                                    @交貨日期,
                                    @Remark,
                                    @建檔,
                                    @修改,
                                    @核准,
                                    GETDATE(),
                                    @修改日,
                                    @核准日,
                                    @傳票
                                    )";
            DynamicParameters dp = new DynamicParameters(t);
            try
            {

                using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    conn.Open();
                    using (var tran = conn.BeginTransaction())
                    {
                        execCnt += conn.Execute(strSQL, dp, tran);
                        foreach (var item in t.shipOrderLists)
                        {
                            strSQL = $@"INSERT INTO dbo.C出貨單明細
                                (
                                    單號,
                                    產品編號,
                                    品名規格,
                                    數量2,
                                    單位,
                                    單價2,
                                    金額2,
                                    樣品別,
                                    描述,
                                    ORDNO,
                                    倉庫別
                                )
                                VALUES
                                (   
                                    @單號,
                                    @產品編號,
                                    @品名規格,
                                    @數量2,
                                    @單位,
                                    @單價2,
                                    @金額2,
                                    @樣品別,
                                    @描述,
                                    @ORDNO,
                                    @倉庫別
                                    )";
                            dp = new DynamicParameters(item);
                            execCnt += conn.Execute(strSQL, dp, tran);
                        }
                        tran.Commit();
                    }
                }
            }
            catch (Exception ex)
            {
                execCnt = 0;
            }
            return execCnt;
        }

        public override int Update(C出貨單 t)
        {
            int execCnt = 0;
            string strSQL = $@" DELETE FROM C出貨單 WHERE 單號=@單號;
                                INSERT INTO dbo.C出貨單
                                (
                                    日期,
                                    單號,
                                    客戶編號,
                                    業務員,
                                    幣別,
                                    匯率,
                                    稅別,
                                    稅率,
                                    總額,
                                    佣金,
                                    原定交貨日期,
                                    交貨地址,
                                    指配國別,
                                    目的港,
                                    價格條件,
                                    交貨方式,
                                    付款方式,
                                    交貨日期,
                                    Remark,
                                    建檔,
                                    修改,
                                    核准,
                                    建檔日,
                                    修改日,
                                    核准日,
                                    傳票
                                )
                                VALUES
                                (   
                                    @日期,
                                    @單號,
                                    @客戶編號,
                                    @業務員,
                                    @幣別,
                                    @匯率,
                                    @稅別,
                                    @稅率,
                                    @總額,
                                    @佣金,
                                    @原定交貨日期,
                                    @交貨地址,
                                    @指配國別,
                                    @目的港,
                                    @價格條件,
                                    @交貨方式,
                                    @付款方式,
                                    @交貨日期,
                                    @Remark,
                                    @建檔,
                                    @修改,
                                    @核准,
                                    @建檔日,
                                    GETDATE(),
                                    @核准日,
                                    @傳票
                                    )";
            DynamicParameters dp = new DynamicParameters(t);
            try
            {
                using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    conn.Open();
                    using (var tran = conn.BeginTransaction())
                    {
                        execCnt += conn.Execute(strSQL, dp, tran);
                        strSQL = "DELETE FROM C出貨單明細 WHERE 單號=@單號";
                        execCnt += conn.Execute(strSQL, dp, tran);
                        foreach (var item in t.shipOrderLists)
                        {
                            strSQL = $@"INSERT INTO dbo.C出貨單明細
                                (
                                    單號,
                                    產品編號,
                                    品名規格,
                                    數量2,
                                    單位,
                                    單價2,
                                    金額2,
                                    樣品別,
                                    描述,
                                    ORDNO,
                                    倉庫別
                                )
                                VALUES
                                (   
                                    @單號,
                                    @產品編號,
                                    @品名規格,
                                    @數量2,
                                    @單位,
                                    @單價2,
                                    @金額2,
                                    @樣品別,
                                    @描述,
                                    @ORDNO,
                                    @倉庫別
                                    )";
                            dp = new DynamicParameters(item);
                            execCnt += conn.Execute(strSQL, dp, tran);
                        }
                        tran.Commit();
                    }
                }
            }
            catch (Exception ex)
            {
                execCnt = 0;
            }
            return execCnt;
        }
    }
}
