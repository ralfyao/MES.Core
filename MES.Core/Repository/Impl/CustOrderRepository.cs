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
    public class CustOrderRepository : AbstractRepository<C訂單>
    {
        public override int Insert(C訂單 t)
        {
            int retCount = 0;
            
                string sql = $@"INSERT INTO dbo.C訂單
                                    (
                                        日期,
                                        單號,
                                        客戶編號,
                                        業務員,
                                        幣別,
                                        稅別,
                                        稅率,
                                        總額,
                                        佣金,
                                        結案,
                                        要望日期,
                                        交貨地址,
                                        指配國別,
                                        目的港,
                                        價格條件,
                                        交貨方式,
                                        付款方式,
                                        交貨日期,
                                        MACHINENO,
                                        Remark,
                                        建檔,
                                        修改,
                                        核准,
                                        建檔日,
                                        修改日,
                                        核准日
                                    )
                                    VALUES
                                    (   
                                        @日期,
                                        @單號,
                                        @客戶編號,
                                        @業務員,
                                        @幣別,
                                        @稅別,
                                        @稅率,
                                        @總額,
                                        @佣金,
                                        @結案,
                                        @要望日期,
                                        @交貨地址,
                                        @指配國別,
                                        @目的港,
                                        @價格條件,
                                        @交貨方式,
                                        @付款方式,
                                        @交貨日期,
                                        @MACHINENO,
                                        @Remark,
                                        @建檔,
                                        @修改,
                                        @核准,
                                        GETDATE(),
                                        @修改日,
                                        @核准日
                                        )";
                using(var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    conn.Open();
                    using(var tran = conn.BeginTransaction())
                    {
                    try
                    {
                        DynamicParameters parameters = new DynamicParameters(t);
                        retCount = conn.Execute(sql, parameters, tran);
                        foreach(var item in t.orderListDetail)
                        {
                            sql = $@"INSERT INTO dbo.C訂單明細
                                        (
                                            單號,
                                            產品編號,
                                            品名規格,
                                            數量1,
                                            單位,
                                            單價1,
                                            金額1,
                                            樣品別,
                                            描述,
                                            QUONO,
                                            專案序號,
                                            佣金率,
                                            MTYPE
                                        )
                                        VALUES
                                        (   
                                            @單號,
                                            @產品編號,
                                            @品名規格,
                                            @數量1,
                                            @單位,
                                            @單價1,
                                            @金額1,
                                            @樣品別,
                                            @描述,
                                            @QUONO,
                                            @專案序號,
                                            @佣金率,
                                            @MTYPE
                                            )";
                            parameters = new DynamicParameters(item);
                            retCount += conn.Execute(sql, parameters, tran);
                        }
                        tran.Commit();
                    }
                    catch (Exception ex)
                    {
                        tran.Rollback();
                        retCount = 0;
                        throw ex;
                    }
                }
            }
            return retCount;
        }

        public override int Update(C訂單 t)
        {
            int retCount = 0;

            string sql = $@"UPDATE dbo.C訂單 SET
                                        日期        =@日期          ,
                                        客戶編號    =@客戶編號        ,
                                        業務員      =@業務員         ,
                                        幣別        =@幣別          ,
                                        稅別        =@稅別          ,
                                        稅率        =@稅率          ,
                                        總額        =@總額          ,
                                        佣金        =@佣金          ,
                                        結案        =@結案          ,
                                        要望日期    =@要望日期        ,
                                        交貨地址    =@交貨地址        ,
                                        指配國別    =@指配國別        ,
                                        目的港      =@目的港         ,
                                        價格條件    =@價格條件        ,
                                        交貨方式    =@交貨方式        ,
                                        付款方式    =@付款方式        ,
                                        交貨日期    =@交貨日期        ,
                                        MACHINENO   =@MACHINENO       ,
                                        Remark      =@Remark          ,
                                        建檔        =@建檔              ,
                                        修改        =@修改              ,
                                        核准        =@核准              ,
                                        建檔日      =@建檔日             ,
                                        修改日      =@修改日             ,
                                        核准日      =@核准日
                                    WHERE 單號=@單號";
            using (var conn = new SqlConnection(IRepository<string>.ConnStr))
            {
                conn.Open();
                using (var tran = conn.BeginTransaction())
                {
                    try
                    {
                        DynamicParameters parameters = new DynamicParameters(t);
                        retCount = conn.Execute(sql, parameters, tran);
                        retCount = conn.Execute($@"DELETE FROM C訂單明細 WHERE 單號=@單號", parameters, tran);
                        foreach (var item in t.orderListDetail)
                        {
                            sql = $@"INSERT INTO dbo.C訂單明細
                                        (
                                            單號,
                                            產品編號,
                                            品名規格,
                                            數量1,
                                            單位,
                                            單價1,
                                            金額1,
                                            樣品別,
                                            描述,
                                            QUONO,
                                            專案序號,
                                            佣金率,
                                            MTYPE
                                        )
                                        VALUES
                                        (   
                                            @單號,
                                            @產品編號,
                                            @品名規格,
                                            @數量1,
                                            @單位,
                                            @單價1,
                                            @金額1,
                                            @樣品別,
                                            @描述,
                                            @QUONO,
                                            @專案序號,
                                            @佣金率,
                                            @MTYPE
                                            )";
                            parameters = new DynamicParameters(item);
                            retCount += conn.Execute(sql, parameters, tran);
                        }
                        tran.Commit();
                    }
                    catch (Exception ex)
                    {
                        tran.Rollback();
                        retCount = 0;
                        throw ex;
                    }
                }
            }
            return retCount;
        }
    }
}
