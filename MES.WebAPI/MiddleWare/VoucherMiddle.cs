using Dapper;
using MES.Core.Model;
using MES.Core.Repository;
using MES.Core.Repository.Impl;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace MES.WebAPI.MiddleWare
{
    public class VoucherMiddle
    {
        public string getFormNo()
        {
            var repo = new VoucherRepository();
            return repo.getFormNo();
        }

        public int createVoucher(F會計傳票 form)
        {
            var repo = new VoucherRepository();
            return repo.Insert(form);
        }

        public F會計傳票 getVoucherByNo(string no)
        {
            var repo = new VoucherRepository();
            return repo.GetByNo(no);
        }

        public void postVoucher(string no, string user)
        {
            var repo = new VoucherRepository();
            repo.PostVoucher(no, user);
        }

        public void cancelPostVoucher(string no)
        {
            var repo = new VoucherRepository();
            repo.CancelPostVoucher(no);
        }

        // ── 會計科目選擇：僅列出未停用的科目 ──────────────────────────────
        public List<F會計科目> getAccountingSubjectList()
        {
            var repo = new CommonRepository<F會計科目>();
            return repo.GetList((F會計科目)null).Where(x => !x.停用).ToList();
        }

        // ── 會計傳票查詢：複式條件篩選，畫面上沒有輸入的條件不代入 SQL ──────────
        public List<會計傳票查詢清單> getVoucherQueryList(string dateFrom, string dateTo, string accountCode, string status)
        {
            var conditions = new List<string>();
            var param = new DynamicParameters();
            if (!string.IsNullOrEmpty(dateFrom)) { conditions.Add("dbo_F會計傳票.日期>=@dateFrom"); param.Add("dateFrom", dateFrom); }
            if (!string.IsNullOrEmpty(dateTo)) { conditions.Add("dbo_F會計傳票.日期<=@dateTo"); param.Add("dateTo", dateTo); }
            if (!string.IsNullOrEmpty(status)) { conditions.Add("dbo_F會計傳票.狀態=@status"); param.Add("status", status); }
            if (!string.IsNullOrEmpty(accountCode)) { conditions.Add("dbo_F會計傳票明細.會科代碼=@accountCode"); param.Add("accountCode", accountCode); }

            string where = conditions.Count > 0 ? "WHERE " + string.Join(" AND ", conditions) : "";

            string sql = $@"SELECT dbo_F會計傳票.單號, dbo_F會計傳票.日期, dbo_F會計傳票.狀態, dbo_F會計傳票.登錄人員,
                                   dbo_F會計傳票.過帳, dbo_F會計傳票.過帳日, dbo_F會計傳票明細.會科代碼
                            FROM F會計傳票 dbo_F會計傳票
                            RIGHT JOIN F會計傳票明細 dbo_F會計傳票明細 ON dbo_F會計傳票.單號 = dbo_F會計傳票明細.單號
                            {where}
                            GROUP BY dbo_F會計傳票.單號, dbo_F會計傳票.日期, dbo_F會計傳票.狀態, dbo_F會計傳票.登錄人員,
                                     dbo_F會計傳票.過帳, dbo_F會計傳票.過帳日, dbo_F會計傳票明細.會科代碼";
            using (var conn = new SqlConnection(IRepository<string>.ConnStr))
            {
                conn.Open();
                return conn.Query<會計傳票查詢清單>(sql, param).ToList();
            }
        }

        // ── 傳票編號模糊篩選 ─────────────────────────────────────────────
        public List<會計傳票查詢清單> getVoucherQueryListByNoLike(string pattern)
        {
            string sql = @"SELECT 單號, 日期, 狀態, 登錄人員, 過帳, 過帳日 FROM F會計傳票 WHERE 單號 LIKE @pattern";
            using (var conn = new SqlConnection(IRepository<string>.ConnStr))
            {
                conn.Open();
                return conn.Query<會計傳票查詢清單>(sql, new { pattern = $"%{pattern}%" }).ToList();
            }
        }

        // ── 查詢畫面用明細：帶出會科名稱供顯示 ───────────────────────────────
        public List<F會計傳票明細> getVoucherDetailForQuery(string no)
        {
            string sql = @"SELECT dbo_F會計傳票明細.單號, dbo_F會計傳票明細.會科代碼, dbo_F會計科目.會科名稱 AS 會計科目,
                                   dbo_F會計傳票明細.摘要, dbo_F會計傳票明細.借方, dbo_F會計傳票明細.貸方,
                                   dbo_F會計傳票明細.來源單據, dbo_F會計傳票明細.備註
                            FROM F會計傳票明細 dbo_F會計傳票明細
                            LEFT JOIN F會計科目 dbo_F會計科目 ON dbo_F會計傳票明細.會科代碼 = dbo_F會計科目.會科代碼
                            WHERE dbo_F會計傳票明細.單號=@no";
            using (var conn = new SqlConnection(IRepository<string>.ConnStr))
            {
                conn.Open();
                return conn.Query<F會計傳票明細>(sql, new { no }).ToList();
            }
        }
    }
}
