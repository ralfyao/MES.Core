using Dapper;
using MES.Core.Model;
using MES.Core.Repository;
using System;
using System.Data.SqlClient;

namespace MES.WebAPI.MiddleWare
{
    public class BankLedgerMiddle
    {
        // ── 依連結單號查詢單一銀行明細(匯入款)資料 ────────────────────────────
        public F銀行明細 getBankLedgerByLinkNo(string linkNo)
        {
            try
            {
                using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    conn.Open();
                    return conn.QueryFirstOrDefault<F銀行明細>(
                        "SELECT * FROM F銀行明細 WHERE 連結單號=@linkNo", new { linkNo });
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static string SQL_INSERT_F銀行明細 = $@"INSERT INTO dbo.F銀行明細
                                                    ( 銀存編碼, 日期, 摘要, 幣別, 匯率, 支出, 存入, 連結單號, 對象, 備註 )
                                                    VALUES
                                                    ( @銀存編碼, @日期, @摘要, @幣別, @匯率, @支出, @存入, @連結單號, @對象, @備註 )";

        public void saveBankLedger(F銀行明細 form)
        {
            try
            {
                using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    conn.Open();
                    conn.Execute(SQL_INSERT_F銀行明細, new DynamicParameters(form));
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void updateBankLedger(F銀行明細 form)
        {
            try
            {
                using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    conn.Open();
                    string sql = @"UPDATE F銀行明細 SET
                                    銀存編碼=@銀存編碼, 日期=@日期, 摘要=@摘要, 幣別=@幣別, 匯率=@匯率,
                                    支出=@支出, 存入=@存入, 連結單號=@連結單號, 對象=@對象, 備註=@備註
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
