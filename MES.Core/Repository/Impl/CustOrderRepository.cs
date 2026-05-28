using Dapper;
using log4net.Repository.Hierarchy;
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
        public int DeleteSalesOrderByNo(string salesOrderNo)
        {
            int retCount = 0;

            string sql = $@"DELETE FROM C訂單 WHERE 單號='{salesOrderNo}';
                            DELETE FROM C訂單明細 WHERE 單號='{salesOrderNo}';
                            DELETE FROM F收款分期 WHERE 單號='{salesOrderNo}';";
            using (var conn = new SqlConnection(IRepository<string>.ConnStr))
            {
                conn.Open();
                using (var tran = conn.BeginTransaction())
                {
                    try
                    {
                        retCount = conn.Execute(sql, null, tran);
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
                            if (string.IsNullOrEmpty(item.單號))
                            {
                                item.單號 = t.單號;
                            }
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
                        if (t.arListDetail != null)
                        {
                            foreach (var item in t.arListDetail)
                            {
                                if (string.IsNullOrEmpty(item.單號))
                                {
                                    item.單號 = t.單號;
                                }
                                sql = $@"insert INTO　dbo.F收款分期
                                        (
                                            單號,
                                            款項期別,
                                            成數,
                                            金額,
                                            請款單號
                                        )
                                        VALUES
                                        (   
                                            @單號,
                                            @款項期別,
                                            @成數,
                                            @金額,
                                            @請款單號
                                        )";
                                parameters = new DynamicParameters(item);
                                retCount += conn.Execute(sql, parameters, tran);
                            }
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
            if (t.建檔日 == "Invalid Date")
            {
                t.建檔日 = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            }

            if (t.修改日 == "Invalid Date")
            {
                t.修改日 = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            }
            if (t.核准日 == "Invalid Date")
            {
                t.核准日 = null;
            }
            string logsql = $@"UPDATE dbo.C訂單 SET
                                        日期        ='{t.日期}'          ,
                                        客戶編號    ='{t.客戶編號}'       ,
                                        業務員      ='{t.業務員}'        ,
                                        幣別        ='{t.幣別}'          ,
                                        稅別        ='{t.稅別}'          ,
                                        稅率        ='{t.稅率}'          ,
                                        總額        ='{t.總額}'          ,
                                        佣金        ='{t.佣金}'          ,
                                        結案        ='{t.結案}'          ,
                                        要望日期    ='{t.要望日期}'        ,
                                        交貨地址    ='{t.交貨地址}'        ,
                                        指配國別    ='{t.指配國別}'        ,
                                        目的港      ='{t.目的港}'         ,
                                        價格條件    ='{t.價格條件}'        ,
                                        交貨方式    ='{t.交貨方式}'        ,
                                        付款方式    ='{t.付款方式}'        ,
                                        交貨日期    ='{t.交貨日期}'        ,
                                        MACHINENO   ='{t.MACHINENO}'       ,
                                        Remark      ='{t.Remark}'          ,
                                        建檔        ='{t.建檔}'              ,
                                        修改        ='{t.修改}'              ,
                                        核准        ='{t.核准}'              ,
                                        建檔日      ='{t.建檔日}'             ,
                                        修改日      ='{t.修改日}'             ,
                                        核准日      ='{t.核准日}'
                                    WHERE 單號='{t.單號}'";
                                                                                                                                                                                                                                                                                             
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
                                        修改日      =GETDATE()             ,
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
                        retCount = conn.Execute($@"DELETE FROM F收款分期 WHERE 單號=@單號", parameters, tran);
                        foreach (var item in t.orderListDetail)
                        {
                            if (string.IsNullOrEmpty(item.單號))
                            {
                                item.單號 = t.單號;
                            }
                            if (item.金額1 == null)
                            {
                                item.金額1 = (item.數量1 * item.單價1);
                            }
                            if (item.佣金率 == null)
                            {
                                item.佣金率 = "0";
                            }
                            logsql = $@"INSERT INTO dbo.C訂單明細
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
                                            '{item.單號}',
                                            '{item.產品編號}',
                                            '{item.品名規格}',
                                            '{item.數量1}',
                                            '{item.單位}',
                                            '{item.單價1}',
                                            '{item.數量1 * item.單價1}',
                                            '{item.樣品別}',
                                            '{item.描述}',
                                            '{item.QUONO}',
                                            '{item.專案序號}',
                                            '{item.佣金率}',
                                            '{item.MTYPE}'
                                            )";
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
                        foreach (var item in t.arListDetail)
                        {
                            if (string.IsNullOrEmpty(item.單號))
                            {
                                item.單號 = t.單號;
                            }
                            if (item.成數 == null)
                            {
                                item.成數 = 0;
                            }

                            if (item.金額 == null)
                            {
                                item.金額 = 0;
                            }
                            logsql = $@"insert INTO　dbo.F收款分期
                                        (
                                            單號,
                                            款項期別,
                                            成數,
                                            金額,
                                            請款單號
                                        )
                                        VALUES
                                        (   
                                            '{item.單號}',
                                            '{item.款項期別}',
                                            '{item.成數}',
                                            '{item.金額}',
                                            '{item.請款單號}'
                                        )";
                            sql = $@"insert INTO　dbo.F收款分期
                                        (
                                            單號,
                                            款項期別,
                                            成數,
                                            金額,
                                            請款單號
                                        )
                                        VALUES
                                        (   
                                            @單號,
                                            @款項期別,
                                            @成數,
                                            @金額,
                                            @請款單號
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
