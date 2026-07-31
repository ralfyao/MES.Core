
using Dapper;
using MES.Core.Model;
using MES.Core.Repository;
using System.Data.SqlClient;

namespace MES.WebAPI.MiddleWare
{
    public class ProjectProcurementMiddle
    {
        public List<採購計畫> getProjectProcurementList()
        {
            string sql = @"
SELECT * FROM dbo.採購計畫 AS dbo_採購計畫
WHERE CONVERT(VARCHAR,dbo_採購計畫.[入庫移轉日],112)>='20250501'
ORDER BY [dbo_採購計畫].[專案序號] DESC, [dbo_採購計畫].[零件號碼] DESC, [dbo_採購計畫].[入庫移轉日] DESC";

            using (var conn = new SqlConnection(IRepository<string>.ConnStr))
            {
                conn.Open();
                return conn.Query<採購計畫>(sql).ToList();
            }
        }

        // ── 零件管制報告總覽：列出已建立零件管制單號的採購計畫 ─────────────
        public List<採購計畫> getMiscControlReportList()
        {
            string sql = @"
SELECT
    dbo_採購計畫.零件管制單號,
    dbo_採購計畫.專案序號,
    dbo_採購計畫.模組編碼,
    dbo_採購計畫.模組名稱,
    dbo_採購計畫.品名,
    dbo_採購計畫.數量,
    dbo_採購計畫.零件分類,
    dbo_採購計畫.驗收合格,
    dbo_採購計畫.零件號碼
FROM
    採購計畫 dbo_採購計畫
WHERE
    (((dbo_採購計畫.零件管制單號) IS NOT NULL))";

            using (var conn = new SqlConnection(IRepository<string>.ConnStr))
            {
                conn.Open();
                return conn.Query<採購計畫>(sql).ToList();
            }
        }

        // ── 零件管制報告書：依零件管制單號查詢單一採購計畫紀錄(表頭) ─────────
        public 採購計畫 getMiscControlOrderByNo(string controlNo)
        {
            using (var conn = new SqlConnection(IRepository<string>.ConnStr))
            {
                conn.Open();
                return conn.QueryFirstOrDefault<採購計畫>(
                    "SELECT * FROM 採購計畫 WHERE 零件管制單號=@controlNo", new { controlNo });
            }
        }

        // ── 零件管制報告書：零件生產工序「產製單位」下拉來源 ───────────────
        public List<產製單位> getProductionUnitList()
        {
            string sql = @"
SELECT
    識別碼,
    產製單位 AS 產製單位名稱,
    分類,
    所在區域
FROM
    產製單位";

            using (var conn = new SqlConnection(IRepository<string>.ConnStr))
            {
                conn.Open();
                return conn.Query<產製單位>(sql).ToList();
            }
        }

        // ── 零件管制報告書：零件檢驗履歷清單 ─────────────────────────
        public List<採購零件檢驗履歷> getMiscControlInspectionList(string controlNo)
        {
            using (var conn = new SqlConnection(IRepository<string>.ConnStr))
            {
                conn.Open();
                return conn.Query<採購零件檢驗履歷>(
                    "SELECT * FROM 採購零件檢驗履歷 WHERE 零件管制單號=@controlNo ORDER BY 檢查日期",
                    new { controlNo }).ToList();
            }
        }

        // ── 零件管制報告書：儲存表頭(驗收人員/倉管人員/驗收合格)與零件生產工序 Grid
        //    (機械加工/特殊塑型/精密加工/防變形/表面處理 五組並列欄位) ──────────
        public int updateMiscControlOrder(採購計畫 form)
        {
            string sql = @"
UPDATE 採購計畫 SET
    驗收人員=@驗收人員, 倉管人員=@倉管人員, 驗收合格=@驗收合格,
    修改=@修改, 修改日=@修改日,
    機械加工=@機械加工, 產製單位1=@產製單位1, 作業人員1=@作業人員1, 開工日期1=@開工日期1, 預交日期1=@預交日期1, 完工日期1=@完工日期1, 完工數量1=@完工數量1,
    特殊塑型=@特殊塑型, 產製單位2=@產製單位2, 作業人員2=@作業人員2, 開工日期2=@開工日期2, 預交日期2=@預交日期2, 完工日期2=@完工日期2, 完工數量2=@完工數量2,
    精密加工=@精密加工, 產製單位3=@產製單位3, 作業人員3=@作業人員3, 開工日期3=@開工日期3, 預交日期3=@預交日期3, 完工日期3=@完工日期3, 完工數量3=@完工數量3,
    防變形=@防變形, 產製單位4=@產製單位4, 作業人員4=@作業人員4, 開工日期4=@開工日期4, 預交日期4=@預交日期4, 完工日期4=@完工日期4, 完工數量4=@完工數量4,
    表面處理=@表面處理, 產製單位5=@產製單位5, 作業人員5=@作業人員5, 開工日期5=@開工日期5, 預交日期5=@預交日期5, 完工日期5=@完工日期5, 完工數量5=@完工數量5
WHERE 採購識別碼=@採購識別碼";

            using (var conn = new SqlConnection(IRepository<string>.ConnStr))
            {
                conn.Open();
                return conn.Execute(sql, form);
            }
        }

        // ── 零件管制報告書：儲存零件檢驗履歷 Grid(識別碼=0 新增列則 INSERT，否則 UPDATE) ──
        public int updateMiscControlInspectionList(List<採購零件檢驗履歷> list)
        {
            using (var conn = new SqlConnection(IRepository<string>.ConnStr))
            {
                conn.Open();
                using (var tran = conn.BeginTransaction())
                {
                    int execCnt = 0;
                    foreach (var item in list)
                    {
                        if (item.識別碼 == 0)
                        {
                            execCnt += conn.Execute(@"
INSERT INTO 採購零件檢驗履歷 (零件管制單號, 檢查日期, 檢查人員, 尺寸精度, 幾何精度, 材質標準, 表面工藝, 硬度要求, 毛邊修整, 微觀裂痕)
VALUES (@零件管制單號, @檢查日期, @檢查人員, @尺寸精度, @幾何精度, @材質標準, @表面工藝, @硬度要求, @毛邊修整, @微觀裂痕)", item, tran);
                        }
                        else
                        {
                            execCnt += conn.Execute(@"
UPDATE 採購零件檢驗履歷 SET
    檢查日期=@檢查日期, 檢查人員=@檢查人員, 尺寸精度=@尺寸精度, 幾何精度=@幾何精度,
    材質標準=@材質標準, 表面工藝=@表面工藝, 硬度要求=@硬度要求, 毛邊修整=@毛邊修整, 微觀裂痕=@微觀裂痕
WHERE 識別碼=@識別碼", item, tran);
                        }
                    }
                    tran.Commit();
                    return execCnt;
                }
            }
        }

        // ── 零件管制報告書：生效(寫入核准/核准日)／取消生效(清空核准/核准日) ────
        public int validateMiscControlOrder(string controlNo, bool approve, string account)
        {
            using (var conn = new SqlConnection(IRepository<string>.ConnStr))
            {
                conn.Open();
                if (approve)
                {
                    return conn.Execute(
                        "UPDATE 採購計畫 SET 核准=@account, 核准日=@date WHERE 零件管制單號=@controlNo",
                        new { account, date = DateTime.Now.ToString("yyyy/MM/dd"), controlNo });
                }
                return conn.Execute(
                    "UPDATE 採購計畫 SET 核准=NULL, 核准日=NULL WHERE 零件管制單號=@controlNo", new { controlNo });
            }
        }

        // ── 只更新採購追蹤欄位，不動其他排程用欄位（開工/完工/預交日期等） ──
        public int updateProjectProcurement(採購計畫 form)
        {
            string sql = @"
UPDATE dbo.採購計畫 SET
    零件分類 = @零件分類,
    採購人員 = @採購人員,
    實際採購日 = @實際採購日,
    預計到貨日 = @預計到貨日,
    倉管人員 = @倉管人員,
    入庫移轉日 = @入庫移轉日,
    驗收合格 = @驗收合格
WHERE 採購識別碼 = @採購識別碼";

            using (var conn = new SqlConnection(IRepository<string>.ConnStr))
            {
                conn.Open();
                return conn.Execute(sql, form);
            }
        }
    }
}
