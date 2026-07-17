using Dapper;
using MES.Core.Model;
using MES.Core.Repository;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace MES.WebAPI.MiddleWare
{
    public class BillMiddle
    {
        // ── 票據異動總覽：列出全部票據異動紀錄 ─────────────────────────────
        public List<F票據異動> getBillList()
        {
            try
            {
                using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    conn.Open();
                    return conn.Query<F票據異動>("SELECT * FROM F票據異動").ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        // ── 依票據號碼查詢單一票據異動資料 ────────────────────────────────
        public F票據異動 getBillByNo(string billNo)
        {
            try
            {
                using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    conn.Open();
                    return conn.QueryFirstOrDefault<F票據異動>(
                        "SELECT * FROM F票據異動 WHERE 票據號碼=@billNo", new { billNo });
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static string SQL_INSERT_F票據異動 = $@"INSERT INTO dbo.F票據異動
                                                    ( 收付日期, 收付別, 對象, 兌付帳戶, 兌現日期, 票況, 票據號碼,
                                                      連結單號, 對象銀行, 金額, 代收日期, 傳票編號, 備註, 結案 )
                                                    VALUES
                                                    ( @收付日期, @收付別, @對象, @兌付帳戶, @兌現日期, @票況, @票據號碼,
                                                      @連結單號, @對象銀行, @金額, @代收日期, @傳票編號, @備註, @結案 )";

        public void saveBill(F票據異動 form)
        {
            try
            {
                using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    conn.Open();
                    conn.Execute(SQL_INSERT_F票據異動, new DynamicParameters(form));
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void updateBill(F票據異動 form)
        {
            try
            {
                using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    conn.Open();
                    string sql = @"UPDATE F票據異動 SET
                                    收付日期=@收付日期, 收付別=@收付別, 對象=@對象, 兌付帳戶=@兌付帳戶,
                                    兌現日期=@兌現日期, 票況=@票況, 票據號碼=@票據號碼, 連結單號=@連結單號,
                                    對象銀行=@對象銀行, 金額=@金額, 代收日期=@代收日期, 傳票編號=@傳票編號,
                                    備註=@備註, 結案=@結案
                                   WHERE 識別碼=@識別碼";
                    conn.Execute(sql, new DynamicParameters(form));
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
