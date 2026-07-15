
using Dapper;
using MES.Core.Model;
using MES.Core.Repository;
using MES.Core.Repository.Impl;
using System;
using System.Data.SqlClient;

namespace MES.WebAPI.MiddleWare
{
    public class CurrencyAdjustMiddle
    {
        public List<資金調節總覽> getCurrencyAdjustList()
        {
            string sql = @"
SELECT dbo_F資金調節.單號
		, dbo_F資金調節.日期
		, dbo_F資金調節.用途
		, dbo_F資金調節.備註
		, dbo_F資金調節.傳票編號
		, dbo_F資金調節.建檔
		, dbo_F資金調節.核准
		, dbo_F銀行明細.銀存編碼
		, dbo_F銀行明細.摘要
		, dbo_F銀行明細.對象
		, dbo_F銀行明細.備註 AS Remark
FROM F資金調節 dbo_F資金調節
LEFT JOIN F銀行明細 dbo_F銀行明細 ON dbo_F資金調節.單號 = dbo_F銀行明細.連結單號";

            using (var conn = new SqlConnection(IRepository<string>.ConnStr))
            {
                conn.Open();
                return conn.Query<資金調節總覽>(sql).ToList();
            }
        }

        public string getFundAdjustNo()
        {
            string prefix = "FA" + DateTime.Now.ToString("yyyyMM");
            using (var conn = new SqlConnection(IRepository<string>.ConnStr))
            {
                conn.Open();
                int cnt = conn.ExecuteScalar<int>("SELECT COUNT(0) FROM F資金調節 WHERE 單號 LIKE @prefix + '%'", new { prefix });
                return prefix + (cnt + 1).ToString("000");
            }
        }

        public F資金調節 getFundAdjustByNo(string no)
        {
            using (var conn = new SqlConnection(IRepository<string>.ConnStr))
            {
                conn.Open();
                var form = conn.QueryFirstOrDefault<F資金調節>("SELECT * FROM F資金調節 WHERE 單號 = @no", new { no });
                if (form == null) return null;
                form.detailList = conn.Query<F銀行明細>("SELECT * FROM F銀行明細 WHERE 連結單號 = @no ORDER BY 識別碼", new { no }).ToList();
                form.銀存編碼 = form.detailList.FirstOrDefault()?.銀存編碼;
                return form;
            }
        }

        public int saveFundAdjust(F資金調節 form)
        {
            return new FundAdjustDataRepository().Insert(form);
        }

        public int updateFundAdjust(F資金調節 form)
        {
            return new FundAdjustDataRepository().Update(form);
        }

        public int doValidateFundAdjust(string no, bool approve, string user)
        {
            using (var conn = new SqlConnection(IRepository<string>.ConnStr))
            {
                conn.Open();
                if (approve)
                {
                    return conn.Execute("UPDATE F資金調節 SET 核准 = @user, 核准日 = @date WHERE 單號 = @no",
                        new { user, date = DateTime.Now.ToString("yyyy-MM-dd"), no });
                }
                return conn.Execute("UPDATE F資金調節 SET 核准 = NULL, 核准日 = NULL WHERE 單號 = @no", new { no });
            }
        }

        public int deleteFundAdjust(string no)
        {
            using (var conn = new SqlConnection(IRepository<string>.ConnStr))
            {
                conn.Open();
                return conn.Execute("DELETE FROM F資金調節 WHERE 單號 = @no; DELETE FROM F銀行明細 WHERE 連結單號 = @no", new { no });
            }
        }
    }
}
