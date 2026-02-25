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
    public class OtherIncomeRepository : AbstractRepository<F其他收入單>
    {
        public static object otherLock = new object();
        public override int Insert(F其他收入單 t)
        {
            int execCnt = 0;
            try
            {
                lock (otherLock)
                {
                    string sql = $@"INSERT INTO dbo.F其他收入單
                                    (
                                        單號,
                                        日期,
                                        客戶編號,
                                        業務員,
                                        幣別,
                                        匯率,
                                        稅別,
                                        稅率,
                                        總額,
                                        結案,
                                        價格條件,
                                        付款方式,
                                        MACHINENO,
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
	                                    @單號,
                                        @日期,
                                        @客戶編號,
                                        @業務員,
                                        @幣別,
                                        @匯率,
                                        @稅別,
                                        @稅率,
                                        @總額,
                                        @結案,
                                        @價格條件,
                                        @付款方式,
                                        @MACHINENO,
                                        @Remark,
                                        @建檔,
                                        @修改,
                                        @核准,
                                        @建檔日,
                                        @修改日,
                                        @核准日,
                                        @傳票
                                        )";
                    using(var conn = new SqlConnection(IRepository<string>.ConnStr))
                    {
                        conn.Open();
                        DynamicParameters dynamicParameters = new DynamicParameters(t);
                        execCnt += conn.Execute(sql, dynamicParameters);
                        foreach(var item in t.detailList)
                        {
                            item.單號 = t.單號;
                            sql = @"INSERT INTO dbo.F其他收支明細
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
                            dynamicParameters = new DynamicParameters(item);
                            execCnt += conn.Execute(sql, dynamicParameters);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return execCnt;
        }

        public override int Update(F其他收入單 t)
        {
            int execCnt = 0;
            try
            {
                lock (otherLock)
                {
                    string sql = $@"DELETE FROM F其他收入單 WHERE 單號=@單號;
                                    INSERT INTO dbo.F其他收入單
                                    (
                                        單號,
                                        日期,
                                        客戶編號,
                                        業務員,
                                        幣別,
                                        匯率,
                                        稅別,
                                        稅率,
                                        總額,
                                        結案,
                                        價格條件,
                                        付款方式,
                                        MACHINENO,
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
	                                    @單號,
                                        @日期,
                                        @客戶編號,
                                        @業務員,
                                        @幣別,
                                        @匯率,
                                        @稅別,
                                        @稅率,
                                        @總額,
                                        @結案,
                                        @價格條件,
                                        @付款方式,
                                        @MACHINENO,
                                        @Remark,
                                        @建檔,
                                        @修改,
                                        @核准,
                                        @建檔日,
                                        @修改日,
                                        @核准日,
                                        @傳票
                                        )";
                    using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                    {
                        conn.Open();
                        DynamicParameters dynamicParameters = new DynamicParameters(t);
                        execCnt += conn.Execute(sql, dynamicParameters);
                        foreach (var item in t.detailList)
                        {
                            item.單號 = t.單號;
                            sql = @"DELETE FROM F其他收支明細 WHERE 識別=@識別;
                                    INSERT INTO dbo.F其他收支明細
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
                            dynamicParameters = new DynamicParameters(item);
                            execCnt += conn.Execute(sql, dynamicParameters);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return execCnt;
        }
    }
}
