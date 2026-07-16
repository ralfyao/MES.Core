using Dapper;
using MES.Core.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace MES.Core.Repository.Impl
{
    public class VoucherRepository
    {
        public static string SQL_INSERT_F會計傳票 = $@"INSERT INTO dbo.F會計傳票
                                                        (
                                                            單號,
                                                            日期,
                                                            原始憑證,
                                                            借方,
                                                            貸方,
                                                            狀態,
                                                            登錄人員,
                                                            修改,
                                                            修改日,
                                                            過帳,
                                                            過帳日,
                                                            月結
                                                        )
                                                        VALUES
                                                        (
                                                            @單號,
                                                            @日期,
                                                            @原始憑證,
                                                            @借方,
                                                            @貸方,
                                                            @狀態,
                                                            @登錄人員,
                                                            @修改,
                                                            @修改日,
                                                            @過帳,
                                                            @過帳日,
                                                            @月結
                                                        )";
        public static string SQL_INSERT_F會計傳票明細 = $@"INSERT INTO dbo.F會計傳票明細
                                                        (
                                                            單號,
                                                            會科代碼,
                                                            摘要,
                                                            借方,
                                                            貸方,
                                                            備註,
                                                            來源單據
                                                        )
                                                        VALUES
                                                        (
                                                            @單號,
                                                            @會科代碼,
                                                            @摘要,
                                                            @借方,
                                                            @貸方,
                                                            @備註,
                                                            @來源單據
                                                        )";

        public int Insert(F會計傳票 t)
        {
            int execCnt = 0;
            try
            {
                using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    conn.Open();
                    using (var tran = conn.BeginTransaction())
                    {
                        var dynamicParameters = new DynamicParameters(t);
                        execCnt += conn.Execute(SQL_INSERT_F會計傳票, dynamicParameters, tran);
                        foreach (var item in t.voucherList ?? new List<F會計傳票明細>())
                        {
                            item.單號 = t.單號;
                            var lineParameters = new DynamicParameters(item);
                            execCnt += conn.Execute(SQL_INSERT_F會計傳票明細, lineParameters, tran);
                        }
                        tran.Commit();
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            return execCnt;
        }

        public F會計傳票 GetByNo(string no)
        {
            try
            {
                using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    conn.Open();
                    var header = conn.QueryFirstOrDefault<F會計傳票>("SELECT * FROM F會計傳票 WHERE 單號=@no", new { no });
                    if (header != null)
                    {
                        string detailSql = @"SELECT dbo_F會計傳票明細.*, dbo_F會計科目.會科名稱 AS 會計科目
                                              FROM F會計傳票明細 dbo_F會計傳票明細
                                              LEFT JOIN F會計科目 dbo_F會計科目 ON dbo_F會計傳票明細.會科代碼 = dbo_F會計科目.會科代碼
                                              WHERE dbo_F會計傳票明細.單號=@no";
                        header.voucherList = conn.Query<F會計傳票明細>(detailSql, new { no }).ToList();
                    }
                    return header;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void PostVoucher(string no, string user)
        {
            try
            {
                using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    conn.Open();
                    conn.Execute("UPDATE F會計傳票 SET 過帳=@user, 過帳日=@date, 狀態='過帳' WHERE 單號=@no",
                        new { user, date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), no });
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void CancelPostVoucher(string no)
        {
            try
            {
                using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    conn.Open();
                    conn.Execute("UPDATE F會計傳票 SET 過帳=NULL, 過帳日=NULL, 狀態='登錄' WHERE 單號=@no", new { no });
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public string getFormNo()
        {
            string formNo;
            using (var conn = new SqlConnection(IRepository<string>.ConnStr))
            {
                conn.Open();
                string sql = $@"SELECT COUNT(0) + 1 FROM F會計傳票 WHERE 單號 LIKE 'VR{DateTime.Now:yyyyMMdd}%'";
                int seq = conn.Query<int>(sql).FirstOrDefault();
                formNo = $"VR{DateTime.Now:yyyyMMdd}{seq:00}";
            }
            return formNo;
        }
    }
}
