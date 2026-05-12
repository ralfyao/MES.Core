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
    public class IndustryCodeRepository : AbstractRepository<C產業代碼>
    {
        public override int Insert(C產業代碼 t)
        {
            int execCnt = 0;
            try
            {
                string strSQL = $@"
                                    INSERT INTO dbo.C產業代碼
                                    (
                                        大分類碼,
                                        大分類名稱,
                                        中分類碼,
                                        中分類名稱,
                                        英文,
                                        内容,
                                        其他
                                    )
                                    VALUES
                                    (   
                                        @大分類碼,-- N'',  -- 大分類碼 - nchar(10)
                                        @大分類名稱,-- NULL, -- 大分類名稱 - nvarchar(255)
                                        @中分類碼,-- N'',  -- 中分類碼 - nchar(10)
                                        @中分類名稱,-- NULL, -- 中分類名稱 - nvarchar(255)
                                        @英文,-- NULL, -- 英文 - nvarchar(255)
                                        @内容,-- NULL, -- 内容 - nvarchar(255)
                                        @其他-- NULL  -- 其他 - nvarchar(255)
                                        )";
                using(var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    conn.Open();
                    execCnt += conn.Execute(strSQL, new DynamicParameters(t));
                }
            }
            catch (Exception)
            {

                throw;
            }
            return execCnt;
        }

        public override int Update(C產業代碼 t)
        {
            int execCnt = 0;
            try
            {
                string strSQL = $@" DELETE FROM C產業代碼 WHERE 中分類碼=@中分類碼;
                                    INSERT INTO dbo.C產業代碼
                                    (
                                        大分類碼,
                                        大分類名稱,
                                        中分類碼,
                                        中分類名稱,
                                        英文,
                                        内容,
                                        其他
                                    )
                                    VALUES
                                    (   
                                        @大分類碼,-- N'',  -- 大分類碼 - nchar(10)
                                        @大分類名稱,-- NULL, -- 大分類名稱 - nvarchar(255)
                                        @中分類碼,-- N'',  -- 中分類碼 - nchar(10)
                                        @中分類名稱,-- NULL, -- 中分類名稱 - nvarchar(255)
                                        @英文,-- NULL, -- 英文 - nvarchar(255)
                                        @内容,-- NULL, -- 内容 - nvarchar(255)
                                        @其他-- NULL  -- 其他 - nvarchar(255)
                                        )";
                using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    conn.Open();
                    execCnt += conn.Execute(strSQL, new DynamicParameters(t));
                }
            }
            catch (Exception)
            {

                throw;
            }
            return execCnt;
        }
    }
}
