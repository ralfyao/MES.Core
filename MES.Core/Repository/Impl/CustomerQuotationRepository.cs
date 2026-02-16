using Dapper;
using MES.Core.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MES.Core.Repository.Impl
{
    public class CustomerQuotationRepository : AbstractRepository<C報價單>
    {
        public override int Insert(C報價單 t)
        {
            int retCode = 0;
            //t.QUODATE = !string.IsNullOrEmpty(t.QUODATE) ? DateTime.ParseExact(t.QUODATE.Replace("/", "-"), "dd-MM-yyyy", CultureInfo.InvariantCulture).ToString("yyyy-MM-dd") : "";
            //t.CONDATE = !string.IsNullOrEmpty(t.CONDATE) ? DateTime.ParseExact(t.CONDATE.Replace("/", "-"), "dd-MM-yyyy", CultureInfo.InvariantCulture).ToString("yyyy-MM-dd") : "";
            string sql = $@"INSERT INTO dbo.C報價單
                            (
                                QUONO,
                                MTYPE,
                                MMODEL,
                                CURRENCY,
                                AMOUNT,
                                COMMISSION,
                                STATUS,
                                MACHINENO,
                                RFQNO,
                                CONDATE,
                                SHIPDATE,
                                QUODATE,
                                RANKING,
                                ADDRESS,
                                DADDRESS,
                                價格條件,
                                交貨方式,
                                付款方式,
                                Remark,
                                交貨日期,
                                稅率,
                                建檔,
                                修改,
                                核准,
                                建檔日,
                                修改日,
                                核准日
                            )
                            VALUES
                            (   
                                @QUONO,
                                @MTYPE,
                                @MMODEL,
                                @CURRENCY,
                                @AMOUNT,
                                @COMMISSION,
                                @STATUS,
                                @MACHINENO,
                                @RFQNO,
                                @CONDATE,
                                @SHIPDATE,
                                @QUODATE,
                                @RANKING,
                                @ADDRESS,
                                @DADDRESS,
                                @價格條件,
                                @交貨方式,
                                @付款方式,
                                @Remark,
                                @交貨日期,
                                @稅率,
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
                        DynamicParameters dynamicParameters = new DynamicParameters(t);
                        retCode = conn.Execute(sql, dynamicParameters, tran);
                        retCode = conn.Execute($@"DELETE FROM C報價明細 WHERE QUONO=@QUONO;", dynamicParameters, tran);
                        foreach (var item in t.quotationDetailFormList)
                        {
                            sql = $@"INSERT INTO dbo.C報價明細
                                                        (
                                                            QUONO,
                                                            產品編號,
                                                            品名規格,
                                                            數量,
                                                            單位,
                                                            單價,
                                                            金額,
                                                            描述
                                                        )
                                                        VALUES
                                                        (   
                                                            @QUONO,
                                                            @產品編號,
                                                            @品名規格,
                                                            @數量,
                                                            @單位,
                                                            @單價,
                                                            @金額,
                                                            @描述
                                                            )";
                            dynamicParameters = new DynamicParameters(item);
                            retCode = conn.Execute(sql, dynamicParameters, tran);
                        }
                        tran.Commit();
                    }
                    catch (Exception ex)
                    {
                        tran.Rollback();
                        return retCode;
                    }
                }
            }
            retCode = 1;
            return retCode;
        }

        public override int Update(C報價單 t)
        {
            int retCode = 0;
            //t.QUODATE = !string.IsNullOrEmpty(t.QUODATE) ? DateTime.ParseExact(t.QUODATE.Replace("/", "-"), "dd-MM-yyyy", CultureInfo.InvariantCulture).ToString("yyyy-MM-dd") : "";
            //t.CONDATE = !string.IsNullOrEmpty(t.CONDATE) ? DateTime.ParseExact(t.CONDATE.Replace("/", "-"), "dd-MM-yyyy", CultureInfo.InvariantCulture).ToString("yyyy-MM-dd") : "";
            string sql = $@"UPDATE dbo.C報價單
                            SET MTYPE          = @MTYPE      ,
                                MMODEL         = @MMODEL     ,
                                CURRENCY       = @CURRENCY   ,
                                AMOUNT         = @AMOUNT     ,
                                COMMISSION     = @COMMISSION ,
                                STATUS         = @STATUS     ,
                                MACHINENO      = @MACHINENO  ,
                                RFQNO          = @RFQNO      ,
                                CONDATE        = @CONDATE    ,
                                SHIPDATE       = @SHIPDATE   ,
                                QUODATE        = @QUODATE    ,
                                RANKING        = @RANKING    ,
                                ADDRESS        = @ADDRESS    ,
                                DADDRESS       = @DADDRESS   ,
                                價格條件       = @價格條件   ,
                                交貨方式       = @交貨方式   ,
                                付款方式       = @付款方式   ,
                                Remark         = @Remark     ,
                                交貨日期       = @交貨日期   ,
                                稅率           = @稅率         ,
                                建檔           = @建檔         ,
                                修改           = @修改         ,
                                核准           = @核准         ,
                                建檔日         = @建檔日    ,
                                修改日         = GETDATE()    ,
                                核准日         = @核准日    
                            WHERE QUONO = @QUONO";

            using (var conn = new SqlConnection(IRepository<string>.ConnStr))
            {
                conn.Open();
                using (var tran = conn.BeginTransaction())
                {
                    try
                    {
                        DynamicParameters dynamicParameters = new DynamicParameters(t);
                        retCode = conn.Execute(sql, dynamicParameters, tran);
                        sql = $@"DELETE FROM C報價明細 WHERE QUONO=@QUONO;";
                        retCode = conn.Execute(sql, dynamicParameters, tran);
                        foreach (var item in t.quotationDetailFormList)
                        {
                            sql = $@"INSERT INTO dbo.C報價明細
                                                        (
                                                            QUONO,
                                                            產品編號,
                                                            品名規格,
                                                            數量,
                                                            單位,
                                                            單價,
                                                            金額,
                                                            描述
                                                        )
                                                        VALUES
                                                        (   
                                                            @QUONO,
                                                            @產品編號,
                                                            @品名規格,
                                                            @數量,
                                                            @單位,
                                                            @單價,
                                                            @金額,
                                                            @描述
                                                            )";
                            dynamicParameters = new DynamicParameters(item);
                            retCode = conn.Execute(sql, dynamicParameters, tran);
                        }
                        tran.Commit();
                    }
                    catch (Exception ex)
                    {
                        tran.Rollback();
                        return retCode;
                    }
                }
            }
            retCode = 1;
            return retCode;
        }

        public int DeleteQuotation(C報價單 t)
        {
            int retCode = 0;
           
            using(var conn = new SqlConnection(IRepository<string>.ConnStr))
            {
                    conn.Open();
                    using (var tran = conn.BeginTransaction())
                    {
                        try
                        {
                            string sql = $@"DELETE FROM C報價單 WHERE QUONO='{t.QUONO}';
                                            DELETE FROM C報價明細 WHERE QUONO='{t.QUONO}'";
                            SqlCommand cmd = conn.CreateCommand();
                            cmd.CommandText = sql;
                            cmd.Transaction = tran;
                            cmd.ExecuteNonQuery();
                            tran.Commit();
                        }
                        catch (Exception ex)
                        {
                            tran.Rollback();
                            retCode = 1;
                        }
                    }
            }
           
            return retCode;
        }
    }
}
