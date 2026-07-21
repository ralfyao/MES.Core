using Dapper;
using MES.Core.Model;
using MES.Core.Repository;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace MES.WebAPI.MiddleWare
{
    public class ProjectProgressMiddle
    {
        // ── 專案進度追蹤表：僅列出未結案且已派設計案的專案 ──────────────────
        public List<專案進度表> getProjectProgressList()
        {
            List<專案進度表> list = new List<專案進度表>();
            string sql = @"
WITH [Follow-加工] AS (
SELECT
    dbo_採購計畫.專案序號,
    Count(dbo_採購計畫.入庫移轉日) AS 入庫移轉日之筆數,
    Count(dbo_採購計畫.零件分類) AS 零件分類之筆數,
    Count(dbo_採購計畫.開工日期1) AS 開工日期1之筆數,
    Count(dbo_採購計畫.完工日期1) AS 完工日期1之筆數,
    Count(dbo_採購計畫.開工日期2) AS 開工日期2之筆數,
    Count(dbo_採購計畫.完工日期2) AS 完工日期2之筆數,
    Count(dbo_採購計畫.開工日期3) AS 開工日期3之筆數,
    Count(dbo_採購計畫.完工日期3) AS 完工日期3之筆數,
    Count(dbo_採購計畫.開工日期4) AS 開工日期4之筆數,
    Count(dbo_採購計畫.完工日期4) AS 完工日期4之筆數,
    Count(dbo_採購計畫.開工日期5) AS 開工日期5之筆數,
    Count(dbo_採購計畫.完工日期5) AS 完工日期5之筆數
FROM
    採購計畫 dbo_採購計畫
WHERE
    (
        (
            (dbo_採購計畫.零件分類) = '自製/需購料'
            OR (dbo_採購計畫.零件分類) = '自製/在庫料'
        )
    )
GROUP BY
    dbo_採購計畫.專案序號
),
[Follow-採購] AS (
SELECT
    dbo_採購計畫.專案序號,
    Count(dbo_採購計畫.零件號碼) AS 零件號碼之筆數,
    Count(dbo_採購計畫.數量) AS 數量之筆數,
    Count(dbo_採購計畫.開始詢價日) AS 開始詢價日之筆數,
    Count(dbo_採購計畫.實際採購日) AS 實際採購日之筆數,
    Count(dbo_採購計畫.入庫移轉日) AS 入庫移轉日之筆數,
    Count(dbo_採購計畫.入庫移轉日) / Count(dbo_採購計畫.數量) AS 入庫比例
FROM
    採購計畫 dbo_採購計畫
GROUP BY
    dbo_採購計畫.專案序號
),
[Follow-設計] AS (
SELECT
    dbo_設計派案.專案序號,
    Count(dbo_設計派案.模組編碼) AS 模組編碼之筆數,
    Count(dbo_設計派案.實際開工日) AS 實際開工日之筆數,
    Count(dbo_設計派案.圖檔發行日) AS 圖檔發行日之筆數,
    Count(dbo_設計派案.圖檔發行日) / Count(dbo_設計派案.模組編碼) AS 出圖比例
FROM
    設計派案 dbo_設計派案
GROUP BY
    dbo_設計派案.專案序號
),
[Follow-組測] AS (
SELECT
    dbo_專案模組用料清單.專案序號,
    Count(dbo_專案模組用料清單.模組編碼) AS 模組編碼之筆數,
    Count(dbo_專案模組用料清單.圖檔發行日) AS 圖檔發行日之筆數,
    Count(dbo_專案模組用料清單.開工日期) AS 開工日期之筆數,
    Count(dbo_專案模組用料清單.完工日期) AS 完工日期之筆數,
    Count(dbo_專案模組用料清單.完工日期) / Count(dbo_專案模組用料清單.模組編碼) AS [模組完%],
    Count(dbo_專案模組用料清單.完工日期) / Count(dbo_專案模組用料清單.圖檔發行日) AS [已發圖完%]
FROM
    專案模組用料清單 dbo_專案模組用料清單
GROUP BY
    dbo_專案模組用料清單.專案序號
),
[Follow-電控] AS (
SELECT
    dbo_專案電控排程.專案序號,
    Count(dbo_專案電控排程.電控工序) AS 電控工序之筆數,
    Count(dbo_專案電控排程.開始作業日期) AS 開始作業日期之筆數,
    Count(dbo_專案電控排程.實際完成日期) AS 實際完成日期之筆數,
    Count(dbo_專案電控排程.實際完成日期) / Count(dbo_專案電控排程.電控工序) AS EUF
FROM
    專案電控排程 dbo_專案電控排程
GROUP BY
    dbo_專案電控排程.專案序號
)
SELECT
    dbo_工令單.專案序號							專案序號,
    dbo_工令單.結案								結案,
    isnull([Follow-設計].模組編碼之筆數,0) AS					D,
    isnull([Follow-設計].實際開工日之筆數,0) AS				DS,
    isnull([Follow-設計].圖檔發行日之筆數,0) AS				DF,
    isnull([Follow-設計].出圖比例,0) AS						DP,
    isnull([Follow-採購].數量之筆數,0) AS					P,
    isnull([Follow-採購].實際採購日之筆數,0) AS				PS,
    isnull([Follow-採購].入庫移轉日之筆數,0) AS				PF,
    isnull([Follow-採購].入庫比例,0) AS						PP,
    isnull([Follow-加工].零件分類之筆數,0) AS					M,
    isnull([Follow-加工].開工日期1之筆數,0) AS				M1S,
    isnull([Follow-加工].完工日期1之筆數,0) AS				M1F,
    isnull([Follow-加工].開工日期2之筆數,0) AS				M2S,
    isnull([Follow-加工].完工日期2之筆數,0) AS				M2F,
    isnull([Follow-加工].開工日期3之筆數,0) AS				M3S,
    isnull([Follow-加工].完工日期3之筆數,0) AS				M3F,
    isnull([Follow-加工].開工日期4之筆數,0) AS				M4S,
    isnull([Follow-加工].完工日期4之筆數,0) AS				M4F,
    isnull([Follow-加工].開工日期5之筆數,0) AS				M5S,
    isnull([Follow-加工].完工日期5之筆數,0) AS				M5F,
    isnull([Follow-組測].開工日期之筆數,0) AS					ASP,
    isnull([Follow-組測].完工日期之筆數,0) AS					AF,
    isnull([Follow-組測].[模組完%],0) AS					AUF,
    isnull([Follow-電控].電控工序之筆數,0) AS					E,
    isnull([Follow-電控].開始作業日期之筆數,0) AS				ES,
    isnull([Follow-電控].實際完成日期之筆數,0) AS				EF,
    isnull([Follow-電控].EUF,0)							EUF,
    isnull([Follow-設計].模組編碼之筆數,0)					模組編碼之筆數
FROM
    (
        (
            (
                (
                    [Follow-加工]
                    RIGHT JOIN 工令單 dbo_工令單 ON [Follow-加工].專案序號 = dbo_工令單.專案序號
                )
                LEFT JOIN [Follow-採購] ON dbo_工令單.專案序號 = [Follow-採購].專案序號
            )
            LEFT JOIN [Follow-電控] ON dbo_工令單.專案序號 = [Follow-電控].專案序號
        )
        LEFT JOIN [Follow-設計] ON dbo_工令單.專案序號 = [Follow-設計].專案序號
    )
    LEFT JOIN [Follow-組測] ON dbo_工令單.專案序號 = [Follow-組測].專案序號
GROUP BY
    dbo_工令單.專案序號,
    dbo_工令單.結案,
    [Follow-設計].實際開工日之筆數,
    [Follow-設計].圖檔發行日之筆數,
    [Follow-設計].出圖比例,
    [Follow-採購].數量之筆數,
    [Follow-採購].實際採購日之筆數,
    [Follow-採購].入庫移轉日之筆數,
    [Follow-採購].入庫比例,
    [Follow-加工].零件分類之筆數,
    [Follow-加工].開工日期1之筆數,
    [Follow-加工].完工日期1之筆數,
    [Follow-加工].開工日期2之筆數,
    [Follow-加工].完工日期2之筆數,
    [Follow-加工].開工日期3之筆數,
    [Follow-加工].完工日期3之筆數,
    [Follow-加工].開工日期4之筆數,
    [Follow-加工].完工日期4之筆數,
    [Follow-加工].開工日期5之筆數,
    [Follow-加工].完工日期5之筆數,
    [Follow-組測].開工日期之筆數,
    [Follow-組測].完工日期之筆數,
    [Follow-組測].[模組完%],
    [Follow-電控].電控工序之筆數,
    [Follow-電控].開始作業日期之筆數,
    [Follow-電控].實際完成日期之筆數,
    [Follow-電控].EUF,
    [Follow-設計].模組編碼之筆數,
    [Follow-設計].模組編碼之筆數
HAVING
    (
        ((dbo_工令單.結案) = 0)
        AND (([Follow-設計].模組編碼之筆數) > 0)
    );";

            using (var conn = new SqlConnection(IRepository<string>.ConnStr))
            {
                conn.Open();
                list = conn.Query<專案進度表>(sql).ToList();
            }
            return list;
        }

        // ── 專案管控表：表頭資料來源為工令單 ─────────────────────────────
        public 工令單 getWorkOrderByProjectNo(string projectNo)
        {
            using (var conn = new SqlConnection(IRepository<string>.ConnStr))
            {
                conn.Open();
                return conn.QueryFirstOrDefault<工令單>("SELECT * FROM 工令單 WHERE 專案序號=@專案序號", new { 專案序號 = projectNo });
            }
        }

        // ── 專案管控表：細項資料來源為設計派案 INNER JOIN 工令單 ──────────
        public List<設計派案> getDesignAssignmentList(string projectNo)
        {
            string sql = @"
SELECT dbo_設計派案.設計識別碼, dbo_設計派案.工程表識別碼, dbo_設計派案.專案序號, dbo_設計派案.模組編碼, dbo_設計派案.模組名稱, dbo_設計派案.檢查分類, dbo_設計派案.製圖, dbo_設計派案.設計人員, dbo_設計派案.設計圖類, dbo_設計派案.製圖檔名, dbo_設計派案.實際開工日, dbo_設計派案.預計完工日, dbo_設計派案.圖檔發行日, dbo_設計派案.審圖通過, dbo_設計派案.清單編號, dbo_工令單.客戶簡稱
  FROM 設計派案 dbo_設計派案
 INNER JOIN 工令單 dbo_工令單 ON dbo_設計派案.專案序號 = dbo_工令單.專案序號
 WHERE dbo_設計派案.專案序號 = @專案序號";

            using (var conn = new SqlConnection(IRepository<string>.ConnStr))
            {
                conn.Open();
                return conn.Query<設計派案>(sql, new { 專案序號 = projectNo }).ToList();
            }
        }

        // ── 設計派案：不篩選專案，列出全部設計派案(INNER JOIN 工令單取客戶簡稱) ──
        public List<設計派案> getAllDesignAssignmentList()
        {
            string sql = @"
SELECT
    dbo_設計派案.設計識別碼,
    dbo_設計派案.工程表識別碼,
    dbo_設計派案.專案序號,
    dbo_設計派案.模組編碼,
    dbo_設計派案.模組名稱,
    dbo_設計派案.檢查分類,
    dbo_設計派案.製圖,
    dbo_設計派案.設計人員,
    dbo_設計派案.設計圖類,
    dbo_設計派案.製圖檔名,
    dbo_設計派案.實際開工日,
    dbo_設計派案.預計完工日,
    dbo_設計派案.圖檔發行日,
    dbo_設計派案.審圖通過,
    dbo_設計派案.清單編號,
    dbo_工令單.客戶簡稱
FROM 設計派案 dbo_設計派案
INNER JOIN 工令單 dbo_工令單 ON dbo_設計派案.專案序號 = dbo_工令單.專案序號";

            using (var conn = new SqlConnection(IRepository<string>.ConnStr))
            {
                conn.Open();
                return conn.Query<設計派案>(sql).ToList();
            }
        }

        // ── 檢查分類下拉：模組圖檢查主檔(檢查分類/職務) ─────────────────────
        public List<模組圖檢查> getModuleDrawingCheckList()
        {
            using (var conn = new SqlConnection(IRepository<string>.ConnStr))
            {
                conn.Open();
                return conn.Query<模組圖檢查>("SELECT * FROM 模組圖檢查").ToList();
            }
        }

        // ── 用途下拉：成本單位主檔的職務清單 ───────────────────────────────
        public List<string> getCostUnitDutyList()
        {
            using (var conn = new SqlConnection(IRepository<string>.ConnStr))
            {
                conn.Open();
                return conn.Query<string>("SELECT 職務 FROM dbo.A成本單位 AS A").ToList();
            }
        }

        // ── 模組圖自檢一覽表：依檢查分類取得檢查項目明細 ────────────────────
        public List<模組圖檢查項目> getModuleCheckItemList(string category)
        {
            string sql = @"
SELECT [識別碼], [項次], [檢查分類], [檢查項目], [檢查方法], [說明]
  FROM 模組圖檢查項目
 WHERE 檢查分類=@檢查分類
 ORDER BY 項次";

            using (var conn = new SqlConnection(IRepository<string>.ConnStr))
            {
                conn.Open();
                return conn.Query<模組圖檢查項目>(sql, new { 檢查分類 = category }).ToList();
            }
        }

        // ── 模組圖自檢一覽表：儲存用途(職務)與檢查項目明細，明細採整批刪除後重建；
        //    若檢查分類尚不存在於模組圖檢查主檔(新增流程)，先建立該筆分類 ──────
        public void saveModuleCheckItemList(string category, string duty, List<模組圖檢查項目> items)
        {
            using (var conn = new SqlConnection(IRepository<string>.ConnStr))
            {
                conn.Open();
                using (var tran = conn.BeginTransaction())
                {
                    int exists = conn.Query<int>("SELECT COUNT(0) FROM 模組圖檢查 WHERE 檢查分類=@檢查分類", new { 檢查分類 = category }, tran).First();
                    if (exists == 0)
                    {
                        conn.Execute("INSERT INTO 模組圖檢查 (檢查分類, 職務) VALUES (@檢查分類, @職務)",
                            new { 檢查分類 = category, 職務 = duty }, tran);
                    }
                    else
                    {
                        conn.Execute("UPDATE 模組圖檢查 SET 職務=@職務 WHERE 檢查分類=@檢查分類",
                            new { 職務 = duty, 檢查分類 = category }, tran);
                    }

                    conn.Execute("DELETE FROM 模組圖檢查項目 WHERE 檢查分類=@檢查分類", new { 檢查分類 = category }, tran);

                    foreach (var x in items ?? new List<模組圖檢查項目>())
                    {
                        x.檢查分類 = category;
                        conn.Execute(@"
INSERT INTO 模組圖檢查項目 (項次, 檢查分類, 檢查項目, 檢查方法, 說明)
VALUES (@項次, @檢查分類, @檢查項目, @檢查方法, @說明)", x, tran);
                    }

                    tran.Commit();
                }
            }
        }

        // ── 設計派案：批次儲存編修後的派工欄位 ─────────────────────────────
        public void saveDesignAssignmentBatch(List<設計派案> list)
        {
            using (var conn = new SqlConnection(IRepository<string>.ConnStr))
            {
                conn.Open();
                using (var tran = conn.BeginTransaction())
                {
                    foreach (var x in list ?? new List<設計派案>())
                    {
                        conn.Execute(@"
UPDATE 設計派案
   SET 檢查分類=@檢查分類, 製圖=@製圖, 設計人員=@設計人員, 設計圖類=@設計圖類, 製圖檔名=@製圖檔名,
       實際開工日=@實際開工日, 預計完工日=@預計完工日, 圖檔發行日=@圖檔發行日
 WHERE 設計識別碼=@設計識別碼",
                            x, tran);
                    }
                    tran.Commit();
                }
            }
        }

        // ── 審圖總覽：列出已建立清單編號的設計派案審圖/發行狀態 ────────────
        public List<設計審圖總覽> getDesignAuditList()
        {
            string sql = @"
SELECT
    dbo_設計派案.清單編號,
    dbo_設計派案.專案序號,
    dbo_設計派案.模組編碼,
    dbo_設計派案.模組名稱,
    dbo_設計派案.設計人員,
    dbo_設計派案.製圖檔名,
    dbo_設計派案.圖檔發行日,
    dbo_設計派案.審圖通過,
    dbo_設計派案.發行人員,
    dbo_設計派案.設變,
    dbo_設計派案.已發行
FROM
    設計派案 dbo_設計派案
WHERE
    (((dbo_設計派案.清單編號) IS NOT NULL))";

            using (var conn = new SqlConnection(IRepository<string>.ConnStr))
            {
                conn.Open();
                return conn.Query<設計審圖總覽>(sql).ToList();
            }
        }

        // ── 設計審查清單：依清單編號取得單筆設計派案表頭 ───────────────────
        public 設計派案 getDesignAssignmentByListNo(string listNo)
        {
            string sql = @"
SELECT dbo_設計派案.設計識別碼, dbo_設計派案.工程表識別碼, dbo_設計派案.專案序號, dbo_設計派案.模組編碼, dbo_設計派案.模組名稱, dbo_設計派案.設計人員, dbo_設計派案.製圖檔名, dbo_設計派案.圖檔發行日, dbo_設計派案.審圖通過, dbo_設計派案.清單編號, dbo_設計派案.審查日期, dbo_設計派案.審查人員, dbo_設計派案.發行人員, dbo_設計派案.設變, dbo_設計派案.已發行
  FROM 設計派案 dbo_設計派案
 WHERE dbo_設計派案.清單編號 = @清單編號";

            using (var conn = new SqlConnection(IRepository<string>.ConnStr))
            {
                conn.Open();
                return conn.QueryFirstOrDefault<設計派案>(sql, new { 清單編號 = listNo });
            }
        }

        // ── 選擇審查項目：列出尚未建立審查清單編號、但已發行圖檔的設計派案，供新增審查單挑選 ──
        public List<設計派案> getPendingDesignAssignmentList()
        {
            string sql = @"
SELECT dbo_設計派案.設計識別碼, dbo_設計派案.工程表識別碼, dbo_設計派案.專案序號, dbo_設計派案.模組編碼, dbo_設計派案.模組名稱, dbo_設計派案.設計人員, dbo_設計派案.製圖檔名, dbo_設計派案.圖檔發行日
  FROM 設計派案 dbo_設計派案
 WHERE dbo_設計派案.清單編號 IS NULL AND dbo_設計派案.圖檔發行日 IS NOT NULL
 ORDER BY dbo_設計派案.專案序號, dbo_設計派案.模組編碼";

            using (var conn = new SqlConnection(IRepository<string>.ConnStr))
            {
                conn.Open();
                return conn.Query<設計派案>(sql).ToList();
            }
        }

        // ── 設計審查清單：依清單編號取得審查明細 ───────────────────────────
        public List<設計審查明細> getDesignAuditDetailList(string listNo)
        {
            using (var conn = new SqlConnection(IRepository<string>.ConnStr))
            {
                conn.Open();
                return conn.Query<設計審查明細>("SELECT * FROM 設計審查明細 WHERE 清單編號=@清單編號 ORDER BY 識別碼", new { 清單編號 = listNo }).ToList();
            }
        }

        // ── 選擇審查項目：列出設計審查項目主檔，供表身挑選制式審查項目 ─────
        public List<設計審查項目表> getDesignReviewItemList()
        {
            using (var conn = new SqlConnection(IRepository<string>.ConnStr))
            {
                conn.Open();
                return conn.Query<設計審查項目表>("SELECT * FROM 設計審查項目表 ORDER BY 識別碼").ToList();
            }
        }

        // ── 審查人員下拉：職務='設計'的成本單位人員配置(對應到 H員工清冊 取姓名) ──
        public List<成本單位人員配置> getDesignStaffList()
        {
            string sql = @"
SELECT c.識別碼, c.職務, c.員工編號, c.員工姓名, e.姓名
  FROM 成本單位人員配置 c
 INNER JOIN H員工清冊 e ON c.員工編號 = e.工號
 WHERE c.職務 = '設計'";

            using (var conn = new SqlConnection(IRepository<string>.ConnStr))
            {
                conn.Open();
                return conn.Query<成本單位人員配置>(sql).ToList();
            }
        }

        // ── 設計審查清單：以 DA+日期+兩碼序號 產生新的清單編號 ─────────────
        private string getNewDesignAuditListNo(SqlConnection conn, SqlTransaction tran)
        {
            string prefix = "DA" + DateTime.Now.ToString("yyyyMMdd");
            int seq = conn.Query<int>($"SELECT COUNT(0) + 1 FROM 設計派案 WHERE 清單編號 LIKE '{prefix}%'", null, tran).First();
            return prefix + seq.ToString("00");
        }

        // ── 設計審查清單：儲存表頭審查資訊(審查日期/審查人員/審圖通過)與明細，
        //    新單第一次儲存時自動產生清單編號；明細採整批刪除後重建 ─────────
        public string saveDesignAudit(設計派案 header, List<設計審查明細> details)
        {
            using (var conn = new SqlConnection(IRepository<string>.ConnStr))
            {
                conn.Open();
                using (var tran = conn.BeginTransaction())
                {
                    string listNo = header.清單編號;
                    if (string.IsNullOrEmpty(listNo))
                    {
                        listNo = getNewDesignAuditListNo(conn, tran);
                        conn.Execute("UPDATE 設計派案 SET 清單編號=@清單編號 WHERE 設計識別碼=@設計識別碼",
                            new { 清單編號 = listNo, header.設計識別碼 }, tran);
                    }

                    conn.Execute(@"
UPDATE 設計派案
   SET 審查日期=@審查日期, 審查人員=@審查人員, 審圖通過=@審圖通過, 已發行=@已發行
 WHERE 設計識別碼=@設計識別碼",
                        new { header.審查日期, header.審查人員, header.審圖通過, header.已發行, header.設計識別碼 }, tran);

                    conn.Execute("DELETE FROM 設計審查明細 WHERE 清單編號=@清單編號", new { 清單編號 = listNo }, tran);

                    foreach (var d in details ?? new List<設計審查明細>())
                    {
                        d.清單編號 = listNo;
                        conn.Execute(@"
INSERT INTO 設計審查明細 (清單編號, 審查項目, 初審意見, 複審一意見, 複審二意見, 符合)
VALUES (@清單編號, @審查項目, @初審意見, @複審一意見, @複審二意見, @符合)", d, tran);
                    }

                    tran.Commit();
                    return listNo;
                }
            }
        }

        // ── 設計審查清單：生效 — 設定審圖通過/發行人員/圖檔發行日(對應原巨集之 SetValue) ──
        public void activateDesignAudit(string listNo, string issuer)
        {
            using (var conn = new SqlConnection(IRepository<string>.ConnStr))
            {
                conn.Open();
                conn.Execute(@"
UPDATE 設計派案
   SET 審圖通過=1, 發行人員=@發行人員, 圖檔發行日=@圖檔發行日
 WHERE 清單編號=@清單編號",
                    new { 發行人員 = issuer, 圖檔發行日 = DateTime.Now, 清單編號 = listNo });
            }
        }

        // ── 設計審查清單：取消生效 — 清空審圖通過/發行人員/圖檔發行日(對應原巨集之 SetValue=Null) ──
        public void deactivateDesignAudit(string listNo)
        {
            using (var conn = new SqlConnection(IRepository<string>.ConnStr))
            {
                conn.Open();
                conn.Execute(@"
UPDATE 設計派案
   SET 審圖通過=NULL, 發行人員=NULL, 圖檔發行日=NULL
 WHERE 清單編號=@清單編號",
                    new { 清單編號 = listNo });
            }
        }

        // ── 圖面發行轉BOM：BOM編號＝專案序號-模組編碼-製圖檔名；若尚未建立
        //    專案模組用料清單表頭，複製設計派案資料建立一筆，再將設計派案標記為已發行 ──
        public string transferDrawingToBom(string listNo, string operatorName)
        {
            var header = getDesignAssignmentByListNo(listNo);
            if (header == null) throw new Exception("找不到設計派案資料，清單編號：" + listNo);

            string bomNo = $"{header.專案序號}-{header.模組編碼}-{header.製圖檔名}";

            using (var conn = new SqlConnection(IRepository<string>.ConnStr))
            {
                conn.Open();
                using (var tran = conn.BeginTransaction())
                {
                    int exists = conn.Query<int>("SELECT COUNT(0) FROM 專案模組用料清單 WHERE BOM編號=@BOM編號", new { BOM編號 = bomNo }, tran).First();
                    if (exists == 0)
                    {
                        conn.Execute(@"
INSERT INTO 專案模組用料清單
    (BOM編號, 專案序號, 模組編碼, 模組名稱, 設計人員, 製圖檔名, 圖檔發行日, 發行人員, 審查清單編號, 建檔, 建檔日)
VALUES
    (@BOM編號, @專案序號, @模組編碼, @模組名稱, @設計人員, @製圖檔名, @圖檔發行日, @發行人員, @審查清單編號, @建檔, @建檔日)",
                            new
                            {
                                BOM編號 = bomNo,
                                header.專案序號,
                                header.模組編碼,
                                header.模組名稱,
                                header.設計人員,
                                header.製圖檔名,
                                header.圖檔發行日,
                                header.發行人員,
                                審查清單編號 = listNo,
                                建檔 = operatorName,
                                建檔日 = DateTime.Now,
                            }, tran);
                    }

                    conn.Execute("UPDATE 設計派案 SET 已發行=1 WHERE 清單編號=@清單編號", new { 清單編號 = listNo }, tran);

                    tran.Commit();
                }
            }

            return bomNo;
        }

        // ── 專案模組用料清單：依BOM編號取得單筆表頭 ─────────────────────────
        public 專案模組用料清單 getModuleMaterialByBomNo(string bomNo)
        {
            using (var conn = new SqlConnection(IRepository<string>.ConnStr))
            {
                conn.Open();
                return conn.QueryFirstOrDefault<專案模組用料清單>("SELECT * FROM 專案模組用料清單 WHERE BOM編號=@BOM編號", new { BOM編號 = bomNo });
            }
        }

        // ── 專案模組用料清單：依BOM編號取得BOM明細 ──────────────────────────
        public List<專案模組BOM明細> getModuleBomDetailList(string bomNo)
        {
            using (var conn = new SqlConnection(IRepository<string>.ConnStr))
            {
                conn.Open();
                return conn.Query<專案模組BOM明細>("SELECT * FROM 專案模組BOM明細 WHERE BOM編號=@BOM編號 ORDER BY 球號", new { BOM編號 = bomNo }).ToList();
            }
        }

        // ── 專案模組用料清單：儲存表頭(組裝資訊)與BOM明細，明細採整批刪除後重建 ──
        public void saveModuleMaterial(專案模組用料清單 header, List<專案模組BOM明細> details, string operatorName)
        {
            using (var conn = new SqlConnection(IRepository<string>.ConnStr))
            {
                conn.Open();
                using (var tran = conn.BeginTransaction())
                {
                    conn.Execute(@"
UPDATE 專案模組用料清單
   SET 組裝人員=@組裝人員, 開工日期=@開工日期, 預交日期=@預交日期, 完工日期=@完工日期, 結案回報=@結案回報, 用途=@用途,
       修改=@修改, 修改日=@修改日
 WHERE BOM編號=@BOM編號",
                        new
                        {
                            header.組裝人員,
                            header.開工日期,
                            header.預交日期,
                            header.完工日期,
                            header.結案回報,
                            header.用途,
                            修改 = operatorName,
                            修改日 = DateTime.Now,
                            header.BOM編號,
                        }, tran);

                    conn.Execute("DELETE FROM 專案模組BOM明細 WHERE BOM編號=@BOM編號", new { header.BOM編號 }, tran);

                    foreach (var d in details ?? new List<專案模組BOM明細>())
                    {
                        d.BOM編號 = header.BOM編號;
                        conn.Execute(@"
INSERT INTO 專案模組BOM明細 (BOM編號, 球號, 零件號碼, 品名, 描述, 數量, 最後修改日期, 上一階品號, 不需備料, 備註, 勾選)
VALUES (@BOM編號, @球號, @零件號碼, @品名, @描述, @數量, @最後修改日期, @上一階品號, @不需備料, @備註, @勾選)", d, tran);
                    }

                    tran.Commit();
                }
            }
        }

        // ── 專案管控表：採購進度資料來源為採購計畫 ────────────────────────
        public List<採購計畫> getPurchasePlanList(string projectNo)
        {
            using (var conn = new SqlConnection(IRepository<string>.ConnStr))
            {
                conn.Open();
                return conn.Query<採購計畫>("SELECT * FROM 採購計畫 WHERE 專案序號=@專案序號", new { 專案序號 = projectNo }).ToList();
            }
        }

        // ── 專案管控表：組測進度資料來源為專案模組用料清單 ────────────────
        public List<專案模組用料清單> getModuleMaterialList(string projectNo)
        {
            using (var conn = new SqlConnection(IRepository<string>.ConnStr))
            {
                conn.Open();
                return conn.Query<專案模組用料清單>("SELECT * FROM 專案模組用料清單 WHERE 專案序號=@專案序號", new { 專案序號 = projectNo }).ToList();
            }
        }

        // ── 專案管控表：電控排程資料來源為專案電控排程 ────────────────────
        public List<專案電控排程> getElectricScheduleList(string projectNo)
        {
            using (var conn = new SqlConnection(IRepository<string>.ConnStr))
            {
                conn.Open();
                return conn.Query<專案電控排程>("SELECT * FROM 專案電控排程 WHERE 專案序號=@專案序號", new { 專案序號 = projectNo }).ToList();
            }
        }

        // ── 模組設計進度表：資料來源為設計派案，計算標準/完工期程、逾期天數、達交效率值與警示訊號 ──
        // projectNo 為 null 時列出全部專案；有帶入時僅篩選該專案序號 ──────
        public List<模組設計進度表> getModuleDesignProgressList(string projectNo = null)
        {
            string sql = @"

WITH Stage1 AS (
    SELECT
        dbo_設計派案.專案序號,
        dbo_設計派案.模組編碼,
        dbo_設計派案.模組名稱,
        dbo_設計派案.實際開工日,
        dbo_設計派案.預計完工日,
        dbo_設計派案.圖檔發行日,
        ISNULL(DATEDIFF(day, dbo_設計派案.實際開工日, dbo_設計派案.預計完工日),0) AS 標準期程天數,
        ISNULL(DATEDIFF(day, dbo_設計派案.實際開工日, dbo_設計派案.圖檔發行日),0) AS 完工期程天數
    FROM
        設計派案 dbo_設計派案
    WHERE
        dbo_設計派案.專案序號 = @專案序號
    GROUP BY
        dbo_設計派案.專案序號,
        dbo_設計派案.模組編碼,
        dbo_設計派案.模組名稱,
        dbo_設計派案.實際開工日,
        dbo_設計派案.預計完工日,
        dbo_設計派案.圖檔發行日
),
Stage2 AS (
    SELECT
        *,
        CASE WHEN [預計完工日] > GETDATE() THEN 0 else
            IsNull(
                IsNull(CAST([圖檔發行日] AS float),
                CAST(DATEDIFF(day, [預計完工日], GETDATE()) AS float)),
                CASE WHEN [圖檔發行日] <= [預計完工日] THEN 0 ELSE DATEDIFF(day, [預計完工日], [圖檔發行日]) END
            )
        end AS 逾期天數
    FROM Stage1
),
Stage3 AS (
    SELECT
        *,
		CASE WHEN 標準期程天數 = 0 THEN 0 else
        IsNull(
            IsNull(CAST([圖檔發行日] AS float),
            1 - (CAST([逾期天數] AS float) / NULLIF([標準期程天數], 0))),
            2 - (CAST([完工期程天數] AS float) / NULLIF([標準期程天數], 0))
        ) end AS 達交效率值
    FROM Stage2
)
SELECT
    *,
	CASE WHEN [達交效率值] >= 1 THEN 'Excellent'
	     WHEN 1 >= [達交效率值] AND [達交效率值]>= 0.75 THEN 'Good'
	     WHEN 0.75 >= [達交效率值] AND [達交效率值]>= 0.5 THEN 'Fair'
	     WHEN 0.5 >= [達交效率值] AND [達交效率值]>= 0.25 THEN 'Uncertain'
	     WHEN 0.25 >= [達交效率值] AND [達交效率值]>= 0 THEN 'Poor'
		 ELSE 'Bad' END AS 警示訊號
FROM Stage3
ORDER BY
    專案序號 DESC,
    模組編碼";

            using (var conn = new SqlConnection(IRepository<string>.ConnStr))
            {
                conn.Open();
                return conn.Query<模組設計進度表>(sql, new { 專案序號 = projectNo }).ToList();
            }
        }

        // ── 模組零件採購進度表：資料來源為採購計畫，依模組彙總零件/詢價/採購/入庫筆數與缺料比例 ──
        public List<模組零件採購進度表> getModuleProcurementProgressList(string projectNo)
        {
            string sql = @"
SELECT
    dbo_採購計畫.專案序號,
    dbo_採購計畫.模組編碼,
    dbo_採購計畫.模組名稱,
    ISNULL(COUNT(dbo_採購計畫.零件號碼),0) AS 零件號碼之筆數,
    ISNULL(Count(dbo_採購計畫.數量),0) AS 數量之筆數,
    ISNULL(Count(dbo_採購計畫.開始詢價日),0) AS 開始詢價日之筆數,
    ISNULL(Count(dbo_採購計畫.實際採購日),0) AS 實際採購日之筆數,
    ISNULL(Count(dbo_採購計畫.入庫移轉日),0) AS 入庫移轉日之筆數,
    CAST(ISNULL(Count(dbo_採購計畫.入庫移轉日),0) AS float) / NULLIF(ISNULL(COUNT(dbo_採購計畫.數量),1), 0) AS 入庫比例,
    1 - (CAST(ISNULL(Count(dbo_採購計畫.入庫移轉日),0) AS float) / NULLIF(ISNULL(Count(dbo_採購計畫.數量),1), 0)) AS 缺料比例,
    CASE WHEN (1 - (CAST(ISNULL(Count(dbo_採購計畫.入庫移轉日),0) AS float) / NULLIF(ISNULL(Count(dbo_採購計畫.數量),1), 0)) < 0.2) THEN  '★：接近完工，請積極催料。'
         WHEN  0.2 < (1 - (CAST(ISNULL(Count(dbo_採購計畫.入庫移轉日),0) AS float) / NULLIF(ISNULL(Count(dbo_採購計畫.數量),1), 0))) AND (1 - (CAST(ISNULL(Count(dbo_採購計畫.入庫移轉日),0) AS float) / NULLIF(ISNULL(Count(dbo_採購計畫.數量),1), 0)) < 0.4) THEN  '☆：採購須開始注意料況囉。'
		 ELSE '○：進度未達六成，再加油！' end
     AS 採購信號
FROM
    採購計畫 dbo_採購計畫 WHERE dbo_採購計畫.專案序號=@專案序號
GROUP BY
    dbo_採購計畫.專案序號,
    dbo_採購計畫.模組編碼,
    dbo_採購計畫.模組名稱
ORDER BY
    dbo_採購計畫.專案序號 DESC,
    dbo_採購計畫.模組編碼";

            using (var conn = new SqlConnection(IRepository<string>.ConnStr))
            {
                conn.Open();
                return conn.Query<模組零件採購進度表>(sql, new { 專案序號 = projectNo }).ToList();
            }
        }

        // ── 模組組測進度表：資料來源為專案模組用料清單，計算標準/完工期程、逾期天數、達交效率值與警示訊號 ──
        public List<模組組測進度表> getModuleAssemTestProgressList(string projectNo)
        {
            string sql = @"
SELECT
    DD.專案序號,
    DD.模組編碼,
    DD.模組名稱,
    DD.開工日期,
    DD.預交日期,
    DD.完工日期,
    DD.標準期程天數,
    DD.完工期程天數,
    DD.逾期天數,
    DD.達交效率值,
	CASE WHEN DD.[達交效率值] >= 1 THEN 'Excellent'
	     WHEN 1 > DD.[達交效率值] AND DD.[達交效率值] >=0.75 THEN 'Good'
	     WHEN 0.75 > DD.[達交效率值] AND DD.[達交效率值] >=0.5 THEN 'Fair'
	     WHEN 0.5 > DD.[達交效率值] AND DD.[達交效率值] >=0.25 THEN 'Poor' ELSE 'Bad' END 警示訊號
FROM (
SELECT
    組裝派案.專案序號,
    組裝派案.模組編碼,
    組裝派案.模組名稱,
    組裝派案.開工日期,
    組裝派案.預交日期,
    組裝派案.完工日期,
    ISNULL(DATEDIFF(DAY, [開工日期], [預交日期]),0) AS 標準期程天數,
    ISNULL(DATEDIFF(DAY, [開工日期], [完工日期]),0) AS 完工期程天數,
	ISNULL(CASE WHEN [預交日期] > getDate() THEN 0 ELSE
		 CASE WHEN [完工日期] IS NULL THEN ISNULL(DATEDIFF(DAY,[預交日期], getDate()),0) ELSE
			  CASE WHEN [完工日期] <= [預交日期] THEN 0 ELSE ISNULL(DATEDIFF(DAY,[預交日期],[完工日期]),0) END
		 END
	END, 0) 逾期天數,
	CASE WHEN [完工日期] IS NULL THEN
			1 - (
			CAST((
			CASE WHEN [預交日期] > getDate() THEN 0 ELSE
				 CASE WHEN [完工日期] IS NULL THEN DATEDIFF(DAY, [預交日期], getDate()) ELSE
					  CASE WHEN [完工日期] <= [預交日期] THEN 0 ELSE DATEDIFF(DAY, [預交日期], [完工日期]) END
				 END
			END
			) AS float) / NULLIF(ISNULL(DATEDIFF(DAY, [開工日期], [預交日期]), 0), 0))
		ELSE
			2 - (CAST(isnull(DATEDIFF(DAY, [開工日期], [完工日期]),0) AS float) / NULLIF(isnull(DATEDIFF(DAY, [開工日期], [預交日期]),0), 0)) END 達交效率值
FROM
    專案模組用料清單 組裝派案 WHERE 組裝派案.專案序號=@專案序號
	) DD
GROUP BY
    DD.專案序號,
    DD.模組編碼,
    DD.模組名稱,
    DD.開工日期,
    DD.預交日期,
    DD.完工日期,
    DD.標準期程天數,
    DD.完工期程天數,
    DD.逾期天數,
    DD.達交效率值
ORDER BY
    DD.專案序號 DESC,
    DD.模組編碼";

            using (var conn = new SqlConnection(IRepository<string>.ConnStr))
            {
                conn.Open();
                return conn.Query<模組組測進度表>(sql, new { 專案序號 = projectNo }).ToList();
            }
        }

        // ── 電控排程進度表：資料來源為專案電控排程，計算標準/完工期程、逾期天數、達交效率值與警示訊號 ──
        public List<電控排程進度表> getElecControlProgressList(string projectNo)
        {
            string sql = @"
SELECT DD.*,
	CASE WHEN DD.[達交效率值] >= 1 THEN 'Excellent'
	     WHEN 1 > DD.[達交效率值] AND DD.[達交效率值] >=0.75 THEN 'Good'
	     WHEN 0.75 > DD.[達交效率值] AND DD.[達交效率值] >=0.5 THEN 'Fair'
	     WHEN 0.5 > DD.[達交效率值] AND DD.[達交效率值] >=0.25 THEN 'Poor' ELSE 'Bad' END 警示訊號
FROM (
SELECT
    dbo_專案電控排程.專案序號,
    dbo_專案電控排程.電控工序,
    dbo_專案電控排程.開始作業日期,
    dbo_專案電控排程.預計完成日期,
    dbo_專案電控排程.實際完成日期,
    ISNULL(DATEDIFF(DAY, [開始作業日期], [預計完成日期]), 0) AS 標準期程天數,
    ISNULL(DATEDIFF(DAY, [開始作業日期], [實際完成日期]), 0) AS 完工期程天數,
	ISNULL(CASE WHEN [預計完成日期] > getDate() THEN 0 ELSE
		 CASE WHEN [實際完成日期] IS NULL THEN ISNULL(DATEDIFF(DAY,[預計完成日期], getDate()),0) ELSE
			  CASE WHEN [實際完成日期] <= [預計完成日期] THEN 0 ELSE ISNULL(DATEDIFF(DAY,[預計完成日期],[實際完成日期]),0) END
		 END
	END, 0) 逾期天數,
	CASE WHEN [實際完成日期] IS NULL THEN
			1 - (
			CAST((
			ISNULL(CASE WHEN [預計完成日期] > getDate() THEN 0 ELSE
				 CASE WHEN [實際完成日期] IS NULL THEN ISNULL(DATEDIFF(DAY,[預計完成日期], getDate()),0) ELSE
					  CASE WHEN [實際完成日期] <= [預計完成日期] THEN 0 ELSE ISNULL(DATEDIFF(DAY,[預計完成日期],[實際完成日期]),0) END
				 END
			END, 0)
			) AS float) / NULLIF(ISNULL(DATEDIFF(DAY, [開始作業日期], [預計完成日期]), 0), 0))
		ELSE
			2 - (CAST(isnull(DATEDIFF(DAY, [開始作業日期], [實際完成日期]),0) AS float) / NULLIF(isnull(DATEDIFF(DAY,  [開始作業日期], [預計完成日期]),0), 0)) END 達交效率值
FROM
    專案電控排程 dbo_專案電控排程
WHERE dbo_專案電控排程.專案序號=@專案序號 )DD
GROUP BY
    DD.專案序號,
    DD.電控工序,
    DD.開始作業日期,
    DD.預計完成日期,
    DD.實際完成日期,
    DD.標準期程天數,
    DD.完工期程天數,
    DD.逾期天數,
    DD.達交效率值
ORDER BY
    DD.專案序號 DESC,
    DD.電控工序";

            using (var conn = new SqlConnection(IRepository<string>.ConnStr))
            {
                conn.Open();
                return conn.Query<電控排程進度表>(sql, new { 專案序號 = projectNo }).ToList();
            }
        }

        // ── 週排程-設計：依設計派案之預計完工日將工時分配至查詢起日後六週的排程桶 ──
        public List<設計週排程表> getDesignScheduleList(DateTime 查詢起日, DateTime 第一週, DateTime 第二週, DateTime 第三週, DateTime 第四週, DateTime 第五週, DateTime 第六週)
        {
            string sql = @"
WITH [SKDL-設計] AS (
SELECT
    dbo_設計派案.專案序號,
    dbo_設計派案.模組編碼,
    dbo_設計派案.模組名稱,
    dbo_設計派案.設計人員,
    dbo_設計派案.製圖,
    dbo_設計派案.預計完工日,
    dbo_設計派案.圖檔發行日,
    dbo_設計派案.設計識別碼
FROM
    設計派案 dbo_設計派案
GROUP BY
    dbo_設計派案.專案序號,
    dbo_設計派案.模組編碼,
    dbo_設計派案.模組名稱,
    dbo_設計派案.設計人員,
    dbo_設計派案.製圖,
    dbo_設計派案.預計完工日,
    dbo_設計派案.圖檔發行日,
    dbo_設計派案.設計識別碼
HAVING
    (((dbo_設計派案.圖檔發行日) IS NULL))
),
[SKDL-設計1] AS (
SELECT [SKDL-設計].專案序號, [SKDL-設計].模組編碼, [SKDL-設計].模組名稱, [SKDL-設計].設計人員, [SKDL-設計].製圖, [SKDL-設計].預計完工日, [SKDL-設計].設計識別碼
FROM [SKDL-設計]
GROUP BY [SKDL-設計].專案序號, [SKDL-設計].模組編碼, [SKDL-設計].模組名稱, [SKDL-設計].設計人員, [SKDL-設計].製圖, [SKDL-設計].預計完工日, [SKDL-設計].設計識別碼
HAVING ((([SKDL-設計].預計完工日)>@查詢起日 And ([SKDL-設計].預計完工日)<=@第一週))
),
[SKDL-設計2] AS (
SELECT [SKDL-設計].專案序號, [SKDL-設計].模組編碼, [SKDL-設計].模組名稱, [SKDL-設計].設計人員, [SKDL-設計].製圖, [SKDL-設計].預計完工日, [SKDL-設計].設計識別碼
FROM [SKDL-設計]
GROUP BY [SKDL-設計].專案序號, [SKDL-設計].模組編碼, [SKDL-設計].模組名稱, [SKDL-設計].設計人員, [SKDL-設計].製圖, [SKDL-設計].預計完工日, [SKDL-設計].設計識別碼
HAVING ((([SKDL-設計].預計完工日)>@第一週 And ([SKDL-設計].預計完工日)<=@第二週))
),
[SKDL-設計3] AS (
SELECT [SKDL-設計].專案序號, [SKDL-設計].模組編碼, [SKDL-設計].模組名稱, [SKDL-設計].設計人員, [SKDL-設計].製圖, [SKDL-設計].預計完工日, [SKDL-設計].設計識別碼
FROM [SKDL-設計]
GROUP BY [SKDL-設計].專案序號, [SKDL-設計].模組編碼, [SKDL-設計].模組名稱, [SKDL-設計].設計人員, [SKDL-設計].製圖, [SKDL-設計].預計完工日, [SKDL-設計].設計識別碼
HAVING ((([SKDL-設計].預計完工日)>@第二週 And ([SKDL-設計].預計完工日)<=@第三週))
),
[SKDL-設計4] AS (
SELECT [SKDL-設計].專案序號, [SKDL-設計].模組編碼, [SKDL-設計].模組名稱, [SKDL-設計].設計人員, [SKDL-設計].製圖, [SKDL-設計].預計完工日, [SKDL-設計].設計識別碼
FROM [SKDL-設計]
GROUP BY [SKDL-設計].專案序號, [SKDL-設計].模組編碼, [SKDL-設計].模組名稱, [SKDL-設計].設計人員, [SKDL-設計].製圖, [SKDL-設計].預計完工日, [SKDL-設計].設計識別碼
HAVING ((([SKDL-設計].預計完工日)>@第三週 And ([SKDL-設計].預計完工日)<=@第四週))
),
[SKDL-設計5] AS (
SELECT [SKDL-設計].專案序號, [SKDL-設計].模組編碼, [SKDL-設計].模組名稱, [SKDL-設計].設計人員, [SKDL-設計].製圖, [SKDL-設計].預計完工日, [SKDL-設計].設計識別碼
FROM [SKDL-設計]
GROUP BY [SKDL-設計].專案序號, [SKDL-設計].模組編碼, [SKDL-設計].模組名稱, [SKDL-設計].設計人員, [SKDL-設計].製圖, [SKDL-設計].預計完工日, [SKDL-設計].設計識別碼
HAVING ((([SKDL-設計].預計完工日)>@第四週 And ([SKDL-設計].預計完工日)<=@第五週))
),
[SKDL-設計6] AS (
SELECT [SKDL-設計].專案序號, [SKDL-設計].模組編碼, [SKDL-設計].模組名稱, [SKDL-設計].設計人員, [SKDL-設計].製圖, [SKDL-設計].預計完工日, [SKDL-設計].設計識別碼
FROM [SKDL-設計]
GROUP BY [SKDL-設計].專案序號, [SKDL-設計].模組編碼, [SKDL-設計].模組名稱, [SKDL-設計].設計人員, [SKDL-設計].製圖, [SKDL-設計].預計完工日, [SKDL-設計].設計識別碼
HAVING ((([SKDL-設計].預計完工日)>@第五週 And ([SKDL-設計].預計完工日)<=@第六週))
),
[SKDL-設計0] AS (
SELECT [SKDL-設計].專案序號, [SKDL-設計].模組編碼, [SKDL-設計].模組名稱, [SKDL-設計].設計人員, [SKDL-設計].製圖, [SKDL-設計].預計完工日, [SKDL-設計].設計識別碼
FROM [SKDL-設計]
GROUP BY [SKDL-設計].專案序號, [SKDL-設計].模組編碼, [SKDL-設計].模組名稱, [SKDL-設計].設計人員, [SKDL-設計].製圖, [SKDL-設計].預計完工日, [SKDL-設計].設計識別碼
HAVING ((([SKDL-設計].預計完工日)<=@查詢起日))
),
[SKDL-設計N] AS (
SELECT
    [SKDL-設計].專案序號,
    [SKDL-設計].模組編碼,
    [SKDL-設計].模組名稱,
    [SKDL-設計].設計人員,
    [SKDL-設計].製圖,
    [SKDL-設計].預計完工日,
    [SKDL-設計].設計識別碼
FROM
    [SKDL-設計]
GROUP BY
    [SKDL-設計].專案序號,
    [SKDL-設計].模組編碼,
    [SKDL-設計].模組名稱,
    [SKDL-設計].設計人員,
    [SKDL-設計].製圖,
    [SKDL-設計].預計完工日,
    [SKDL-設計].設計識別碼
HAVING
    ((([SKDL-設計].預計完工日) IS NULL))
)
SELECT
    [SKDL-設計].專案序號,
    [SKDL-設計].模組編碼,
    [SKDL-設計].模組名稱,
    [SKDL-設計].設計人員,
    [SKDL-設計1].製圖 AS 第一週,
    [SKDL-設計2].製圖 AS 第二週,
    [SKDL-設計3].製圖 AS 第三週,
    [SKDL-設計4].製圖 AS 第四週,
    [SKDL-設計5].製圖 AS 第五週,
    [SKDL-設計6].製圖 AS 第六週,
    [SKDL-設計0].製圖 AS 過期,
    [SKDL-設計N].製圖 AS 未排,
    dbo_工令單.結案
FROM
    (
        (
            (
                (
                    (
                        (
                            (
                                (
                                    [SKDL-設計]
                                    LEFT JOIN [SKDL-設計1] ON [SKDL-設計].設計識別碼 = [SKDL-設計1].設計識別碼
                                )
                                LEFT JOIN [SKDL-設計2] ON [SKDL-設計].設計識別碼 = [SKDL-設計2].設計識別碼
                            )
                            LEFT JOIN [SKDL-設計3] ON [SKDL-設計].設計識別碼 = [SKDL-設計3].設計識別碼
                        )
                        LEFT JOIN [SKDL-設計4] ON [SKDL-設計].設計識別碼 = [SKDL-設計4].設計識別碼
                    )
                    LEFT JOIN [SKDL-設計5] ON [SKDL-設計].設計識別碼 = [SKDL-設計5].設計識別碼
                )
                LEFT JOIN [SKDL-設計6] ON [SKDL-設計].設計識別碼 = [SKDL-設計6].設計識別碼
            )
            LEFT JOIN [SKDL-設計0] ON [SKDL-設計].設計識別碼 = [SKDL-設計0].設計識別碼
        )
        LEFT JOIN [SKDL-設計N] ON [SKDL-設計].設計識別碼 = [SKDL-設計N].設計識別碼
    )
    LEFT JOIN 工令單 dbo_工令單 ON [SKDL-設計].專案序號 = dbo_工令單.專案序號
WHERE
    (
        (
            (dbo_工令單.結案) IS NULL
            OR (dbo_工令單.結案) = 0
        )
    )
	ORDER BY 專案序號 DESC, 模組編碼";

            using (var conn = new SqlConnection(IRepository<string>.ConnStr))
            {
                conn.Open();
                return conn.Query<設計週排程表>(sql, new { 查詢起日, 第一週, 第二週, 第三週, 第四週, 第五週, 第六週 }).ToList();
            }
        }

        // ── 週排程-採購：依採購計畫之預計到貨日將待入庫零件分配至基準日以前後四週的排程桶 ──
        public List<採購週排程表> getProcurementScheduleList(DateTime 基準日以前, DateTime 第一週, DateTime 第二週, DateTime 第三週, DateTime 第四週)
        {
            string sql = @"
WITH [SKDL-採購] AS (
SELECT
    dbo_採購計畫.專案序號,
    dbo_採購計畫.模組編碼,
    dbo_採購計畫.模組名稱,
    dbo_採購計畫.實際採購日,
    dbo_採購計畫.零件號碼,
    dbo_採購計畫.品名,
    dbo_採購計畫.預計到貨日,
    dbo_採購計畫.入庫移轉日,
    dbo_採購計畫.採購識別碼,
    dbo_採購計畫.零件分類
FROM
    採購計畫 dbo_採購計畫
GROUP BY
    dbo_採購計畫.專案序號,
    dbo_採購計畫.模組編碼,
    dbo_採購計畫.模組名稱,
    dbo_採購計畫.實際採購日,
    dbo_採購計畫.零件號碼,
    dbo_採購計畫.品名,
    dbo_採購計畫.預計到貨日,
    dbo_採購計畫.入庫移轉日,
    dbo_採購計畫.採購識別碼,
    dbo_採購計畫.零件分類
HAVING
    (
        ((dbo_採購計畫.模組編碼) IS NOT NULL)
        AND ((dbo_採購計畫.入庫移轉日) IS NULL)
        AND (
            (dbo_採購計畫.零件分類) = '市購品'
            OR (dbo_採購計畫.零件分類) = '自製/需購料'
        )
    )
),
[SKDL-採購0] AS (
SELECT [SKDL-採購].專案序號, [SKDL-採購].模組編碼, [SKDL-採購].模組名稱, [SKDL-採購].實際採購日, [SKDL-採購].零件號碼, [SKDL-採購].品名, [SKDL-採購].預計到貨日, [SKDL-採購].採購識別碼
FROM [SKDL-採購]
GROUP BY [SKDL-採購].專案序號, [SKDL-採購].模組編碼, [SKDL-採購].模組名稱, [SKDL-採購].實際採購日, [SKDL-採購].零件號碼, [SKDL-採購].品名, [SKDL-採購].預計到貨日, [SKDL-採購].採購識別碼
HAVING ((([SKDL-採購].預計到貨日)<=@基準日以前
))),
[SKDL-採購1] AS (
SELECT [SKDL-採購].專案序號, [SKDL-採購].模組編碼, [SKDL-採購].模組名稱, [SKDL-採購].實際採購日, [SKDL-採購].零件號碼, [SKDL-採購].品名, [SKDL-採購].預計到貨日, [SKDL-採購].採購識別碼
FROM [SKDL-採購]
GROUP BY [SKDL-採購].專案序號, [SKDL-採購].模組編碼, [SKDL-採購].模組名稱, [SKDL-採購].實際採購日, [SKDL-採購].零件號碼, [SKDL-採購].品名, [SKDL-採購].預計到貨日, [SKDL-採購].採購識別碼
HAVING ((([SKDL-採購].預計到貨日)>@基準日以前 And ([SKDL-採購].預計到貨日)<=@第一週))
),
[SKDL-採購2] AS (
SELECT [SKDL-採購].專案序號, [SKDL-採購].模組編碼, [SKDL-採購].模組名稱, [SKDL-採購].實際採購日, [SKDL-採購].零件號碼, [SKDL-採購].品名, [SKDL-採購].預計到貨日, [SKDL-採購].採購識別碼
FROM [SKDL-採購]
GROUP BY [SKDL-採購].專案序號, [SKDL-採購].模組編碼, [SKDL-採購].模組名稱, [SKDL-採購].實際採購日, [SKDL-採購].零件號碼, [SKDL-採購].品名, [SKDL-採購].預計到貨日, [SKDL-採購].採購識別碼
HAVING ((([SKDL-採購].預計到貨日)>@第一週 And ([SKDL-採購].預計到貨日)<=@第二週))
),
[SKDL-採購3] AS (
SELECT [SKDL-採購].專案序號, [SKDL-採購].模組編碼, [SKDL-採購].模組名稱, [SKDL-採購].實際採購日, [SKDL-採購].零件號碼, [SKDL-採購].品名, [SKDL-採購].預計到貨日, [SKDL-採購].採購識別碼
FROM [SKDL-採購]
GROUP BY [SKDL-採購].專案序號, [SKDL-採購].模組編碼, [SKDL-採購].模組名稱, [SKDL-採購].實際採購日, [SKDL-採購].零件號碼, [SKDL-採購].品名, [SKDL-採購].預計到貨日, [SKDL-採購].採購識別碼
HAVING ((([SKDL-採購].預計到貨日)>@第二週 And ([SKDL-採購].預計到貨日)<=@第三週))
),
[SKDL-採購4] AS (
SELECT [SKDL-採購].專案序號, [SKDL-採購].模組編碼, [SKDL-採購].模組名稱, [SKDL-採購].實際採購日, [SKDL-採購].零件號碼, [SKDL-採購].品名, [SKDL-採購].預計到貨日, [SKDL-採購].採購識別碼
FROM [SKDL-採購]
GROUP BY [SKDL-採購].專案序號, [SKDL-採購].模組編碼, [SKDL-採購].模組名稱, [SKDL-採購].實際採購日, [SKDL-採購].零件號碼, [SKDL-採購].品名, [SKDL-採購].預計到貨日, [SKDL-採購].採購識別碼
HAVING ((([SKDL-採購].預計到貨日)>@第三週 And ([SKDL-採購].預計到貨日)<=@第四週))
),
[SKDL-採購N] AS (
SELECT [SKDL-採購].專案序號, [SKDL-採購].模組編碼, [SKDL-採購].模組名稱, [SKDL-採購].實際採購日, [SKDL-採購].零件號碼, [SKDL-採購].品名, [SKDL-採購].預計到貨日, [SKDL-採購].採購識別碼
FROM [SKDL-採購]
GROUP BY [SKDL-採購].專案序號, [SKDL-採購].模組編碼, [SKDL-採購].模組名稱, [SKDL-採購].實際採購日, [SKDL-採購].零件號碼, [SKDL-採購].品名, [SKDL-採購].預計到貨日, [SKDL-採購].採購識別碼
HAVING ((([SKDL-採購].預計到貨日)>@第四週))
)
SELECT
    [SKDL-採購].專案序號,
    [SKDL-採購].模組編碼,
    [SKDL-採購].模組名稱,
    [SKDL-採購].零件號碼,
    [SKDL-採購].實際採購日,
    [SKDL-採購N].預計到貨日 AS 未排,
    [SKDL-採購0].預計到貨日 AS 過期,
    [SKDL-採購1].預計到貨日 AS 第一週,
    [SKDL-採購2].預計到貨日 AS 第二週,
    [SKDL-採購3].預計到貨日 AS 第三週,
    [SKDL-採購4].預計到貨日 AS 第四週,
    [SKDL-採購].採購識別碼,
    [SKDL-採購].品名,
    dbo_工令單.結案
FROM
    (
        (
            (
                (
                    (
                        (
                            [SKDL-採購]
                            LEFT JOIN [SKDL-採購0] ON [SKDL-採購].採購識別碼 = [SKDL-採購0].採購識別碼
                        )
                        LEFT JOIN [SKDL-採購1] ON [SKDL-採購].採購識別碼 = [SKDL-採購1].採購識別碼
                    )
                    LEFT JOIN [SKDL-採購2] ON [SKDL-採購].採購識別碼 = [SKDL-採購2].採購識別碼
                )
                LEFT JOIN [SKDL-採購3] ON [SKDL-採購].採購識別碼 = [SKDL-採購3].採購識別碼
            )
            LEFT JOIN [SKDL-採購4] ON [SKDL-採購].採購識別碼 = [SKDL-採購4].採購識別碼
        )
        LEFT JOIN [SKDL-採購N] ON [SKDL-採購].採購識別碼 = [SKDL-採購N].採購識別碼
    )
    LEFT JOIN 工令單 dbo_工令單 ON [SKDL-採購].專案序號 = dbo_工令單.專案序號
WHERE
    (
        (
            (dbo_工令單.結案) IS NULL
            OR (dbo_工令單.結案) = 0
        )
    ) ORDER BY 專案序號 DESC, 模組編碼";

            using (var conn = new SqlConnection(IRepository<string>.ConnStr))
            {
                conn.Open();
                return conn.Query<採購週排程表>(sql, new { 基準日以前, 第一週, 第二週, 第三週, 第四週 }).ToList();
            }
        }

        // ── 週排程-機加工：依採購計畫之預交日期1將待加工零件分配至基準日以前後四週的排程桶 ──
        public List<加工週排程表> getMachiningScheduleList(DateTime 基準日以前, DateTime 第一週, DateTime 第二週, DateTime 第三週, DateTime 第四週)
        {
            string sql = @"
WITH [SKDL-加工] AS (
SELECT
    dbo_採購計畫.專案序號,
    dbo_採購計畫.模組編碼,
    dbo_採購計畫.模組名稱,
    dbo_採購計畫.零件號碼,
    dbo_採購計畫.品名,
    dbo_採購計畫.零件分類,
    dbo_採購計畫.驗收日期,
    dbo_採購計畫.預計到貨日,
    dbo_採購計畫.預交日期1,
    dbo_採購計畫.開工日期1,
    dbo_採購計畫.完工日期1,
    dbo_採購計畫.採購識別碼
FROM
    採購計畫 dbo_採購計畫
GROUP BY
    dbo_採購計畫.專案序號,
    dbo_採購計畫.模組編碼,
    dbo_採購計畫.模組名稱,
    dbo_採購計畫.零件號碼,
    dbo_採購計畫.品名,
    dbo_採購計畫.零件分類,
    dbo_採購計畫.驗收日期,
    dbo_採購計畫.預計到貨日,
    dbo_採購計畫.預交日期1,
    dbo_採購計畫.開工日期1,
    dbo_採購計畫.完工日期1,
    dbo_採購計畫.採購識別碼
HAVING
    (
        ((dbo_採購計畫.模組編碼) IS NOT NULL)
        AND (
            (dbo_採購計畫.零件分類) = '自製/在庫料'
            OR (dbo_採購計畫.零件分類) = '自製/需購料'
        )
        AND ((dbo_採購計畫.完工日期1) IS NULL)
    )
),
[SKDL-加工0] AS (
SELECT dbo_採購計畫.專案序號, dbo_採購計畫.模組編碼, dbo_採購計畫.模組名稱, dbo_採購計畫.零件號碼, dbo_採購計畫.品名, dbo_採購計畫.驗收日期, dbo_採購計畫.預計到貨日, dbo_採購計畫.預交日期1, dbo_採購計畫.採購識別碼
FROM 採購計畫 dbo_採購計畫
GROUP BY dbo_採購計畫.專案序號, dbo_採購計畫.模組編碼, dbo_採購計畫.模組名稱, dbo_採購計畫.零件號碼, dbo_採購計畫.品名, dbo_採購計畫.驗收日期, dbo_採購計畫.預計到貨日, dbo_採購計畫.預交日期1, dbo_採購計畫.採購識別碼
HAVING (((dbo_採購計畫.預交日期1)<=@基準日以前))
),
[SKDL-加工1] AS (
SELECT dbo_採購計畫.專案序號, dbo_採購計畫.模組編碼, dbo_採購計畫.模組名稱, dbo_採購計畫.零件號碼, dbo_採購計畫.品名, dbo_採購計畫.驗收日期, dbo_採購計畫.預計到貨日, dbo_採購計畫.預交日期1, dbo_採購計畫.採購識別碼
FROM 採購計畫 dbo_採購計畫
GROUP BY dbo_採購計畫.專案序號, dbo_採購計畫.模組編碼, dbo_採購計畫.模組名稱, dbo_採購計畫.零件號碼, dbo_採購計畫.品名, dbo_採購計畫.驗收日期, dbo_採購計畫.預計到貨日, dbo_採購計畫.預交日期1, dbo_採購計畫.採購識別碼
HAVING (((dbo_採購計畫.預交日期1)>@基準日以前 And (dbo_採購計畫.預交日期1)<=@第一週))
),
[SKDL-加工2] AS (
SELECT dbo_採購計畫.專案序號, dbo_採購計畫.模組編碼, dbo_採購計畫.模組名稱, dbo_採購計畫.零件號碼, dbo_採購計畫.品名, dbo_採購計畫.驗收日期, dbo_採購計畫.預計到貨日, dbo_採購計畫.預交日期1, dbo_採購計畫.採購識別碼
FROM 採購計畫 dbo_採購計畫
GROUP BY dbo_採購計畫.專案序號, dbo_採購計畫.模組編碼, dbo_採購計畫.模組名稱, dbo_採購計畫.零件號碼, dbo_採購計畫.品名, dbo_採購計畫.驗收日期, dbo_採購計畫.預計到貨日, dbo_採購計畫.預交日期1, dbo_採購計畫.採購識別碼
HAVING (((dbo_採購計畫.預交日期1)>@第一週 And (dbo_採購計畫.預交日期1)<=@第二週))
),
[SKDL-加工3] AS (
SELECT dbo_採購計畫.專案序號, dbo_採購計畫.模組編碼, dbo_採購計畫.模組名稱, dbo_採購計畫.零件號碼, dbo_採購計畫.品名, dbo_採購計畫.驗收日期, dbo_採購計畫.預計到貨日, dbo_採購計畫.預交日期1, dbo_採購計畫.採購識別碼
FROM 採購計畫 dbo_採購計畫
GROUP BY dbo_採購計畫.專案序號, dbo_採購計畫.模組編碼, dbo_採購計畫.模組名稱, dbo_採購計畫.零件號碼, dbo_採購計畫.品名, dbo_採購計畫.驗收日期, dbo_採購計畫.預計到貨日, dbo_採購計畫.預交日期1, dbo_採購計畫.採購識別碼
HAVING (((dbo_採購計畫.預交日期1)>@第二週 And (dbo_採購計畫.預交日期1)<=@第三週))
),
[SKDL-加工4] AS (
SELECT dbo_採購計畫.專案序號, dbo_採購計畫.模組編碼, dbo_採購計畫.模組名稱, dbo_採購計畫.零件號碼, dbo_採購計畫.品名, dbo_採購計畫.驗收日期, dbo_採購計畫.預計到貨日, dbo_採購計畫.預交日期1, dbo_採購計畫.採購識別碼
FROM 採購計畫 dbo_採購計畫
GROUP BY dbo_採購計畫.專案序號, dbo_採購計畫.模組編碼, dbo_採購計畫.模組名稱, dbo_採購計畫.零件號碼, dbo_採購計畫.品名, dbo_採購計畫.驗收日期, dbo_採購計畫.預計到貨日, dbo_採購計畫.預交日期1, dbo_採購計畫.採購識別碼
HAVING (((dbo_採購計畫.預交日期1)>@第三週 And (dbo_採購計畫.預交日期1)<=@第四週))
),
[SKDL-加工N] AS (
SELECT dbo_採購計畫.專案序號, dbo_採購計畫.模組編碼, dbo_採購計畫.模組名稱, dbo_採購計畫.零件號碼, dbo_採購計畫.品名, dbo_採購計畫.驗收日期, dbo_採購計畫.預計到貨日, dbo_採購計畫.預交日期1, dbo_採購計畫.採購識別碼
FROM 採購計畫 dbo_採購計畫
GROUP BY dbo_採購計畫.專案序號, dbo_採購計畫.模組編碼, dbo_採購計畫.模組名稱, dbo_採購計畫.零件號碼, dbo_採購計畫.品名, dbo_採購計畫.驗收日期, dbo_採購計畫.預計到貨日, dbo_採購計畫.預交日期1, dbo_採購計畫.採購識別碼
HAVING (((dbo_採購計畫.預交日期1)>@第四週))
)
SELECT
    [SKDL-加工].專案序號,
    [SKDL-加工].模組編碼,
    [SKDL-加工].模組名稱,
    [SKDL-加工].零件號碼,
    [SKDL-加工].品名,
    [SKDL-加工].驗收日期,
    [SKDL-加工].預計到貨日,
    [SKDL-加工0].預交日期1 AS 過期,
    [SKDL-加工1].預交日期1 AS 第一週,
    [SKDL-加工2].預交日期1 AS 第二週,
    [SKDL-加工3].預交日期1 AS 第三週,
    [SKDL-加工4].預交日期1 AS 第四週,
    [SKDL-加工N].預交日期1 AS 未排,
    [SKDL-加工].採購識別碼,
    dbo_工令單.結案
FROM
    (
        (
            (
                (
                    (
                        (
                            [SKDL-加工]
                            LEFT JOIN [SKDL-加工0] ON [SKDL-加工].採購識別碼 = [SKDL-加工0].採購識別碼
                        )
                        LEFT JOIN [SKDL-加工1] ON [SKDL-加工].採購識別碼 = [SKDL-加工1].採購識別碼
                    )
                    LEFT JOIN [SKDL-加工2] ON [SKDL-加工].採購識別碼 = [SKDL-加工2].採購識別碼
                )
                LEFT JOIN [SKDL-加工3] ON [SKDL-加工].採購識別碼 = [SKDL-加工3].採購識別碼
            )
            LEFT JOIN [SKDL-加工N] ON [SKDL-加工].採購識別碼 = [SKDL-加工N].採購識別碼
        )
        LEFT JOIN [SKDL-加工4] ON [SKDL-加工].採購識別碼 = [SKDL-加工4].採購識別碼
    )
    LEFT JOIN 工令單 dbo_工令單 ON [SKDL-加工].專案序號 = dbo_工令單.專案序號
WHERE
    (
        (
            (dbo_工令單.結案) IS NULL
            OR (dbo_工令單.結案) = 0
        )
    ) ORDER BY 專案序號 DESC, 模組編碼";

            using (var conn = new SqlConnection(IRepository<string>.ConnStr))
            {
                conn.Open();
                return conn.Query<加工週排程表>(sql, new { 基準日以前, 第一週, 第二週, 第三週, 第四週 }).ToList();
            }
        }

        // ── 週排程-後製程：列出已開工(領料)但尚未完成委外製程(特殊塑型/精密加工/防變形/表面處理)之零件 ──
        public List<後製程週排程表> getPostProcessScheduleList()
        {
            string sql = @"
WITH [SKDL-委外] AS (
SELECT
    dbo_採購計畫.專案序號,
    dbo_採購計畫.模組編碼,
    dbo_採購計畫.模組名稱,
    dbo_採購計畫.零件號碼,
    dbo_採購計畫.品名,
    dbo_採購計畫.零件分類,
    dbo_採購計畫.開工日期1,
    dbo_採購計畫.預計到貨日,
    dbo_採購計畫.採購識別碼
FROM
    採購計畫 dbo_採購計畫
GROUP BY
    dbo_採購計畫.專案序號,
    dbo_採購計畫.模組編碼,
    dbo_採購計畫.模組名稱,
    dbo_採購計畫.零件號碼,
    dbo_採購計畫.品名,
    dbo_採購計畫.零件分類,
    dbo_採購計畫.開工日期1,
    dbo_採購計畫.預計到貨日,
    dbo_採購計畫.採購識別碼
HAVING
    (
        ((dbo_採購計畫.模組編碼) IS NOT NULL)
        AND (
            (dbo_採購計畫.零件分類) = '自製/在庫料'
            OR (dbo_採購計畫.零件分類) = '自製/需購料'
        )
        AND ((dbo_採購計畫.開工日期1) IS NOT NULL)
    )
),
[SKDL-委外2] AS (
SELECT
    dbo_採購計畫.專案序號,
    dbo_採購計畫.模組編碼,
    dbo_採購計畫.模組名稱,
    dbo_採購計畫.零件號碼,
    dbo_採購計畫.品名,
    dbo_採購計畫.零件分類,
    dbo_採購計畫.開工日期1,
    dbo_採購計畫.預計到貨日,
    dbo_採購計畫.預交日期2,
    dbo_採購計畫.開工日期2,
    dbo_採購計畫.完工日期2,
    dbo_採購計畫.採購識別碼
FROM
    採購計畫 dbo_採購計畫
GROUP BY
    dbo_採購計畫.專案序號,
    dbo_採購計畫.模組編碼,
    dbo_採購計畫.模組名稱,
    dbo_採購計畫.零件號碼,
    dbo_採購計畫.品名,
    dbo_採購計畫.零件分類,
    dbo_採購計畫.開工日期1,
    dbo_採購計畫.預計到貨日,
    dbo_採購計畫.預交日期2,
    dbo_採購計畫.開工日期2,
    dbo_採購計畫.完工日期2,
    dbo_採購計畫.採購識別碼
HAVING
    (
        ((dbo_採購計畫.模組編碼) IS NOT NULL)
        AND (
            (dbo_採購計畫.零件分類) = '自製/在庫料'
            OR (dbo_採購計畫.零件分類) = '自製/需購料'
        )
        AND ((dbo_採購計畫.開工日期1) IS NOT NULL)
        AND ((dbo_採購計畫.完工日期2) IS NULL)
    )
),
[SKDL-委外3] AS (
SELECT
    dbo_採購計畫.專案序號,
    dbo_採購計畫.模組編碼,
    dbo_採購計畫.模組名稱,
    dbo_採購計畫.零件號碼,
    dbo_採購計畫.品名,
    dbo_採購計畫.零件分類,
    dbo_採購計畫.開工日期1,
    dbo_採購計畫.預計到貨日,
    dbo_採購計畫.預交日期3,
    dbo_採購計畫.開工日期3,
    dbo_採購計畫.完工日期3,
    dbo_採購計畫.採購識別碼
FROM
    採購計畫 dbo_採購計畫
GROUP BY
    dbo_採購計畫.專案序號,
    dbo_採購計畫.模組編碼,
    dbo_採購計畫.模組名稱,
    dbo_採購計畫.零件號碼,
    dbo_採購計畫.品名,
    dbo_採購計畫.零件分類,
    dbo_採購計畫.開工日期1,
    dbo_採購計畫.預計到貨日,
    dbo_採購計畫.預交日期3,
    dbo_採購計畫.開工日期3,
    dbo_採購計畫.完工日期3,
    dbo_採購計畫.採購識別碼
HAVING
    (
        ((dbo_採購計畫.模組編碼) IS NOT NULL)
        AND (
            (dbo_採購計畫.零件分類) = '自製/在庫料'
            OR (dbo_採購計畫.零件分類) = '自製/需購料'
        )
        AND ((dbo_採購計畫.開工日期1) IS NOT NULL)
        AND ((dbo_採購計畫.完工日期3) IS NULL)
    )
),
[SKDL-委外4] AS (
SELECT
    dbo_採購計畫.專案序號,
    dbo_採購計畫.模組編碼,
    dbo_採購計畫.模組名稱,
    dbo_採購計畫.零件號碼,
    dbo_採購計畫.品名,
    dbo_採購計畫.零件分類,
    dbo_採購計畫.開工日期1,
    dbo_採購計畫.預計到貨日,
    dbo_採購計畫.預交日期4,
    dbo_採購計畫.開工日期4,
    dbo_採購計畫.完工日期4,
    dbo_採購計畫.採購識別碼
FROM
    採購計畫 dbo_採購計畫
GROUP BY
    dbo_採購計畫.專案序號,
    dbo_採購計畫.模組編碼,
    dbo_採購計畫.模組名稱,
    dbo_採購計畫.零件號碼,
    dbo_採購計畫.品名,
    dbo_採購計畫.零件分類,
    dbo_採購計畫.開工日期1,
    dbo_採購計畫.預計到貨日,
    dbo_採購計畫.預交日期4,
    dbo_採購計畫.開工日期4,
    dbo_採購計畫.完工日期4,
    dbo_採購計畫.採購識別碼
HAVING
    (
        ((dbo_採購計畫.模組編碼) IS NOT NULL)
        AND (
            (dbo_採購計畫.零件分類) = '自製/在庫料'
            OR (dbo_採購計畫.零件分類) = '自製/需購料'
        )
        AND ((dbo_採購計畫.開工日期1) IS NOT NULL)
        AND ((dbo_採購計畫.完工日期4) IS NULL)
    )
),
[SKDL-委外5] AS (
SELECT
    dbo_採購計畫.專案序號,
    dbo_採購計畫.模組編碼,
    dbo_採購計畫.模組名稱,
    dbo_採購計畫.零件號碼,
    dbo_採購計畫.品名,
    dbo_採購計畫.零件分類,
    dbo_採購計畫.開工日期1,
    dbo_採購計畫.預計到貨日,
    dbo_採購計畫.預交日期5,
    dbo_採購計畫.開工日期5,
    dbo_採購計畫.完工日期5,
    dbo_採購計畫.採購識別碼
FROM
    採購計畫 dbo_採購計畫
GROUP BY
    dbo_採購計畫.專案序號,
    dbo_採購計畫.模組編碼,
    dbo_採購計畫.模組名稱,
    dbo_採購計畫.零件號碼,
    dbo_採購計畫.品名,
    dbo_採購計畫.零件分類,
    dbo_採購計畫.開工日期1,
    dbo_採購計畫.預計到貨日,
    dbo_採購計畫.預交日期5,
    dbo_採購計畫.開工日期5,
    dbo_採購計畫.完工日期5,
    dbo_採購計畫.採購識別碼
HAVING
    (
        ((dbo_採購計畫.模組編碼) IS NOT NULL)
        AND (
            (dbo_採購計畫.零件分類) = '自製/在庫料'
            OR (dbo_採購計畫.零件分類) = '自製/需購料'
        )
        AND ((dbo_採購計畫.開工日期1) IS NOT NULL)
        AND ((dbo_採購計畫.完工日期5) IS NULL)
    )
)
SELECT
    [SKDL-委外].專案序號,
    [SKDL-委外].模組編碼,
    [SKDL-委外].模組名稱,
    [SKDL-委外].零件號碼,
    [SKDL-委外].品名,
    [SKDL-委外].開工日期1 AS 領料日,
    [SKDL-委外2].預交日期2,
    [SKDL-委外2].開工日期2,
    [SKDL-委外3].預交日期3,
    [SKDL-委外3].開工日期3,
    [SKDL-委外4].預交日期4,
    [SKDL-委外4].開工日期4,
    [SKDL-委外5].預交日期5,
    [SKDL-委外5].開工日期5,
    [SKDL-委外].採購識別碼,
    dbo_工令單.結案
FROM
    (
        (
            (
                (
                    [SKDL-委外]
                    LEFT JOIN [SKDL-委外2] ON [SKDL-委外].採購識別碼 = [SKDL-委外2].採購識別碼
                )
                LEFT JOIN [SKDL-委外3] ON [SKDL-委外].採購識別碼 = [SKDL-委外3].採購識別碼
            )
            LEFT JOIN [SKDL-委外4] ON [SKDL-委外].採購識別碼 = [SKDL-委外4].採購識別碼
        )
        LEFT JOIN [SKDL-委外5] ON [SKDL-委外].採購識別碼 = [SKDL-委外5].採購識別碼
    )
    LEFT JOIN 工令單 dbo_工令單 ON [SKDL-委外].專案序號 = dbo_工令單.專案序號
WHERE
    (
        (
            (dbo_工令單.結案) IS NULL
            OR (dbo_工令單.結案) = 0
        )
    )";

            using (var conn = new SqlConnection(IRepository<string>.ConnStr))
            {
                conn.Open();
                return conn.Query<後製程週排程表>(sql).ToList();
            }
        }

        // ── 週排程-組測：依採購計畫之預計到貨日(進料)/預交日期1(加工)將待組測零件分配至基準日以前後四週的排程桶 ──
        public List<組測週排程表> getAssemTestScheduleList(DateTime 基準日以前, DateTime 第一週, DateTime 第二週, DateTime 第三週, DateTime 第四週)
        {
            string sql = @"
WITH [SKDL-組測] AS (
SELECT
    dbo_採購計畫.專案序號,
    dbo_採購計畫.模組編碼,
    dbo_採購計畫.模組名稱,
    dbo_採購計畫.零件號碼,
    dbo_採購計畫.品名,
    dbo_採購計畫.零件分類,
    dbo_採購計畫.驗收合格,
    dbo_採購計畫.零件管制單號,
    dbo_採購計畫.採購識別碼
FROM
    採購計畫 dbo_採購計畫
WHERE
    (
        (
            (dbo_採購計畫.驗收合格) <> '合格允收'
            OR (dbo_採購計畫.驗收合格) IS NULL
        )
    )
),
[SKDL-採購] AS (
SELECT
    dbo_採購計畫.專案序號,
    dbo_採購計畫.模組編碼,
    dbo_採購計畫.模組名稱,
    dbo_採購計畫.實際採購日,
    dbo_採購計畫.零件號碼,
    dbo_採購計畫.品名,
    dbo_採購計畫.預計到貨日,
    dbo_採購計畫.入庫移轉日,
    dbo_採購計畫.採購識別碼,
    dbo_採購計畫.零件分類
FROM
    採購計畫 dbo_採購計畫
GROUP BY
    dbo_採購計畫.專案序號,
    dbo_採購計畫.模組編碼,
    dbo_採購計畫.模組名稱,
    dbo_採購計畫.實際採購日,
    dbo_採購計畫.零件號碼,
    dbo_採購計畫.品名,
    dbo_採購計畫.預計到貨日,
    dbo_採購計畫.入庫移轉日,
    dbo_採購計畫.採購識別碼,
    dbo_採購計畫.零件分類
HAVING
    (
        ((dbo_採購計畫.模組編碼) IS NOT NULL)
        AND ((dbo_採購計畫.入庫移轉日) IS NULL)
        AND (
            (dbo_採購計畫.零件分類) = '市購品'
            OR (dbo_採購計畫.零件分類) = '自製/需購料'
        )
    )
),
[SKDL-採購0] AS (
SELECT [SKDL-採購].專案序號, [SKDL-採購].模組編碼, [SKDL-採購].模組名稱, [SKDL-採購].實際採購日, [SKDL-採購].零件號碼, [SKDL-採購].品名, [SKDL-採購].預計到貨日, [SKDL-採購].採購識別碼
FROM [SKDL-採購]
GROUP BY [SKDL-採購].專案序號, [SKDL-採購].模組編碼, [SKDL-採購].模組名稱, [SKDL-採購].實際採購日, [SKDL-採購].零件號碼, [SKDL-採購].品名, [SKDL-採購].預計到貨日, [SKDL-採購].採購識別碼
HAVING ((([SKDL-採購].預計到貨日)<=@基準日以前
))),
[SKDL-採購1] AS (
SELECT [SKDL-採購].專案序號, [SKDL-採購].模組編碼, [SKDL-採購].模組名稱, [SKDL-採購].實際採購日, [SKDL-採購].零件號碼, [SKDL-採購].品名, [SKDL-採購].預計到貨日, [SKDL-採購].採購識別碼
FROM [SKDL-採購]
GROUP BY [SKDL-採購].專案序號, [SKDL-採購].模組編碼, [SKDL-採購].模組名稱, [SKDL-採購].實際採購日, [SKDL-採購].零件號碼, [SKDL-採購].品名, [SKDL-採購].預計到貨日, [SKDL-採購].採購識別碼
HAVING ((([SKDL-採購].預計到貨日)>@基準日以前 And ([SKDL-採購].預計到貨日)<=@第一週))
),
[SKDL-採購2] AS (
SELECT [SKDL-採購].專案序號, [SKDL-採購].模組編碼, [SKDL-採購].模組名稱, [SKDL-採購].實際採購日, [SKDL-採購].零件號碼, [SKDL-採購].品名, [SKDL-採購].預計到貨日, [SKDL-採購].採購識別碼
FROM [SKDL-採購]
GROUP BY [SKDL-採購].專案序號, [SKDL-採購].模組編碼, [SKDL-採購].模組名稱, [SKDL-採購].實際採購日, [SKDL-採購].零件號碼, [SKDL-採購].品名, [SKDL-採購].預計到貨日, [SKDL-採購].採購識別碼
HAVING ((([SKDL-採購].預計到貨日)>@第一週 And ([SKDL-採購].預計到貨日)<=@第二週))
),
[SKDL-採購3] AS (
SELECT [SKDL-採購].專案序號, [SKDL-採購].模組編碼, [SKDL-採購].模組名稱, [SKDL-採購].實際採購日, [SKDL-採購].零件號碼, [SKDL-採購].品名, [SKDL-採購].預計到貨日, [SKDL-採購].採購識別碼
FROM [SKDL-採購]
GROUP BY [SKDL-採購].專案序號, [SKDL-採購].模組編碼, [SKDL-採購].模組名稱, [SKDL-採購].實際採購日, [SKDL-採購].零件號碼, [SKDL-採購].品名, [SKDL-採購].預計到貨日, [SKDL-採購].採購識別碼
HAVING ((([SKDL-採購].預計到貨日)>@第二週 And ([SKDL-採購].預計到貨日)<=@第三週))
),
[SKDL-採購4] AS (
SELECT [SKDL-採購].專案序號, [SKDL-採購].模組編碼, [SKDL-採購].模組名稱, [SKDL-採購].實際採購日, [SKDL-採購].零件號碼, [SKDL-採購].品名, [SKDL-採購].預計到貨日, [SKDL-採購].採購識別碼
FROM [SKDL-採購]
GROUP BY [SKDL-採購].專案序號, [SKDL-採購].模組編碼, [SKDL-採購].模組名稱, [SKDL-採購].實際採購日, [SKDL-採購].零件號碼, [SKDL-採購].品名, [SKDL-採購].預計到貨日, [SKDL-採購].採購識別碼
HAVING ((([SKDL-採購].預計到貨日)>@第三週 And ([SKDL-採購].預計到貨日)<=@第四週))
),
[SKDL-採購N] AS (
SELECT [SKDL-採購].專案序號, [SKDL-採購].模組編碼, [SKDL-採購].模組名稱, [SKDL-採購].實際採購日, [SKDL-採購].零件號碼, [SKDL-採購].品名, [SKDL-採購].預計到貨日, [SKDL-採購].採購識別碼
FROM [SKDL-採購]
GROUP BY [SKDL-採購].專案序號, [SKDL-採購].模組編碼, [SKDL-採購].模組名稱, [SKDL-採購].實際採購日, [SKDL-採購].零件號碼, [SKDL-採購].品名, [SKDL-採購].預計到貨日, [SKDL-採購].採購識別碼
HAVING ((([SKDL-採購].預計到貨日)>@第四週))
),
[SKDL-採購排程] AS (
SELECT
    [SKDL-採購].專案序號,
    [SKDL-採購].模組編碼,
    [SKDL-採購].模組名稱,
    [SKDL-採購].零件號碼,
    [SKDL-採購].實際採購日,
    [SKDL-採購N].預計到貨日 AS 未排,
    [SKDL-採購0].預計到貨日 AS 過期,
    [SKDL-採購1].預計到貨日 AS 第一週,
    [SKDL-採購2].預計到貨日 AS 第二週,
    [SKDL-採購3].預計到貨日 AS 第三週,
    [SKDL-採購4].預計到貨日 AS 第四週,
    [SKDL-採購].採購識別碼,
    [SKDL-採購].品名,
    dbo_工令單.結案
FROM
    (
        (
            (
                (
                    (
                        (
                            [SKDL-採購]
                            LEFT JOIN [SKDL-採購0] ON [SKDL-採購].採購識別碼 = [SKDL-採購0].採購識別碼
                        )
                        LEFT JOIN [SKDL-採購1] ON [SKDL-採購].採購識別碼 = [SKDL-採購1].採購識別碼
                    )
                    LEFT JOIN [SKDL-採購2] ON [SKDL-採購].採購識別碼 = [SKDL-採購2].採購識別碼
                )
                LEFT JOIN [SKDL-採購3] ON [SKDL-採購].採購識別碼 = [SKDL-採購3].採購識別碼
            )
            LEFT JOIN [SKDL-採購4] ON [SKDL-採購].採購識別碼 = [SKDL-採購4].採購識別碼
        )
        LEFT JOIN [SKDL-採購N] ON [SKDL-採購].採購識別碼 = [SKDL-採購N].採購識別碼
    )
    LEFT JOIN 工令單 dbo_工令單 ON [SKDL-採購].專案序號 = dbo_工令單.專案序號
WHERE
    (
        (
            (dbo_工令單.結案) IS NULL
            OR (dbo_工令單.結案) = 0
        )
    )),
[SKDL-加工] AS (
SELECT
    dbo_採購計畫.專案序號,
    dbo_採購計畫.模組編碼,
    dbo_採購計畫.模組名稱,
    dbo_採購計畫.零件號碼,
    dbo_採購計畫.品名,
    dbo_採購計畫.零件分類,
    dbo_採購計畫.驗收日期,
    dbo_採購計畫.預計到貨日,
    dbo_採購計畫.預交日期1,
    dbo_採購計畫.開工日期1,
    dbo_採購計畫.完工日期1,
    dbo_採購計畫.採購識別碼
FROM
    採購計畫 dbo_採購計畫
GROUP BY
    dbo_採購計畫.專案序號,
    dbo_採購計畫.模組編碼,
    dbo_採購計畫.模組名稱,
    dbo_採購計畫.零件號碼,
    dbo_採購計畫.品名,
    dbo_採購計畫.零件分類,
    dbo_採購計畫.驗收日期,
    dbo_採購計畫.預計到貨日,
    dbo_採購計畫.預交日期1,
    dbo_採購計畫.開工日期1,
    dbo_採購計畫.完工日期1,
    dbo_採購計畫.採購識別碼
HAVING
    (
        ((dbo_採購計畫.模組編碼) IS NOT NULL)
        AND (
            (dbo_採購計畫.零件分類) = '自製/在庫料'
            OR (dbo_採購計畫.零件分類) = '自製/需購料'
        )
        AND ((dbo_採購計畫.完工日期1) IS NULL)
    )
),
[SKDL-加工0] AS (
SELECT dbo_採購計畫.專案序號, dbo_採購計畫.模組編碼, dbo_採購計畫.模組名稱, dbo_採購計畫.零件號碼, dbo_採購計畫.品名, dbo_採購計畫.驗收日期, dbo_採購計畫.預計到貨日, dbo_採購計畫.預交日期1, dbo_採購計畫.採購識別碼
FROM 採購計畫 dbo_採購計畫
GROUP BY dbo_採購計畫.專案序號, dbo_採購計畫.模組編碼, dbo_採購計畫.模組名稱, dbo_採購計畫.零件號碼, dbo_採購計畫.品名, dbo_採購計畫.驗收日期, dbo_採購計畫.預計到貨日, dbo_採購計畫.預交日期1, dbo_採購計畫.採購識別碼
HAVING (((dbo_採購計畫.預交日期1)<=@基準日以前))
),
[SKDL-加工1] AS (
SELECT dbo_採購計畫.專案序號, dbo_採購計畫.模組編碼, dbo_採購計畫.模組名稱, dbo_採購計畫.零件號碼, dbo_採購計畫.品名, dbo_採購計畫.驗收日期, dbo_採購計畫.預計到貨日, dbo_採購計畫.預交日期1, dbo_採購計畫.採購識別碼
FROM 採購計畫 dbo_採購計畫
GROUP BY dbo_採購計畫.專案序號, dbo_採購計畫.模組編碼, dbo_採購計畫.模組名稱, dbo_採購計畫.零件號碼, dbo_採購計畫.品名, dbo_採購計畫.驗收日期, dbo_採購計畫.預計到貨日, dbo_採購計畫.預交日期1, dbo_採購計畫.採購識別碼
HAVING (((dbo_採購計畫.預交日期1)>@基準日以前 And (dbo_採購計畫.預交日期1)<=@第一週))
),
[SKDL-加工2] AS (
SELECT dbo_採購計畫.專案序號, dbo_採購計畫.模組編碼, dbo_採購計畫.模組名稱, dbo_採購計畫.零件號碼, dbo_採購計畫.品名, dbo_採購計畫.驗收日期, dbo_採購計畫.預計到貨日, dbo_採購計畫.預交日期1, dbo_採購計畫.採購識別碼
FROM 採購計畫 dbo_採購計畫
GROUP BY dbo_採購計畫.專案序號, dbo_採購計畫.模組編碼, dbo_採購計畫.模組名稱, dbo_採購計畫.零件號碼, dbo_採購計畫.品名, dbo_採購計畫.驗收日期, dbo_採購計畫.預計到貨日, dbo_採購計畫.預交日期1, dbo_採購計畫.採購識別碼
HAVING (((dbo_採購計畫.預交日期1)>@第一週 And (dbo_採購計畫.預交日期1)<=@第二週))
),
[SKDL-加工3] AS (
SELECT dbo_採購計畫.專案序號, dbo_採購計畫.模組編碼, dbo_採購計畫.模組名稱, dbo_採購計畫.零件號碼, dbo_採購計畫.品名, dbo_採購計畫.驗收日期, dbo_採購計畫.預計到貨日, dbo_採購計畫.預交日期1, dbo_採購計畫.採購識別碼
FROM 採購計畫 dbo_採購計畫
GROUP BY dbo_採購計畫.專案序號, dbo_採購計畫.模組編碼, dbo_採購計畫.模組名稱, dbo_採購計畫.零件號碼, dbo_採購計畫.品名, dbo_採購計畫.驗收日期, dbo_採購計畫.預計到貨日, dbo_採購計畫.預交日期1, dbo_採購計畫.採購識別碼
HAVING (((dbo_採購計畫.預交日期1)>@第二週 And (dbo_採購計畫.預交日期1)<=@第三週))
),
[SKDL-加工4] AS (
SELECT dbo_採購計畫.專案序號, dbo_採購計畫.模組編碼, dbo_採購計畫.模組名稱, dbo_採購計畫.零件號碼, dbo_採購計畫.品名, dbo_採購計畫.驗收日期, dbo_採購計畫.預計到貨日, dbo_採購計畫.預交日期1, dbo_採購計畫.採購識別碼
FROM 採購計畫 dbo_採購計畫
GROUP BY dbo_採購計畫.專案序號, dbo_採購計畫.模組編碼, dbo_採購計畫.模組名稱, dbo_採購計畫.零件號碼, dbo_採購計畫.品名, dbo_採購計畫.驗收日期, dbo_採購計畫.預計到貨日, dbo_採購計畫.預交日期1, dbo_採購計畫.採購識別碼
HAVING (((dbo_採購計畫.預交日期1)>@第三週 And (dbo_採購計畫.預交日期1)<=@第四週))
),
[SKDL-加工N] AS (
SELECT dbo_採購計畫.專案序號, dbo_採購計畫.模組編碼, dbo_採購計畫.模組名稱, dbo_採購計畫.零件號碼, dbo_採購計畫.品名, dbo_採購計畫.驗收日期, dbo_採購計畫.預計到貨日, dbo_採購計畫.預交日期1, dbo_採購計畫.採購識別碼
FROM 採購計畫 dbo_採購計畫
GROUP BY dbo_採購計畫.專案序號, dbo_採購計畫.模組編碼, dbo_採購計畫.模組名稱, dbo_採購計畫.零件號碼, dbo_採購計畫.品名, dbo_採購計畫.驗收日期, dbo_採購計畫.預計到貨日, dbo_採購計畫.預交日期1, dbo_採購計畫.採購識別碼
HAVING (((dbo_採購計畫.預交日期1)>@第四週))
),
[SKDL-加工排程] AS (
SELECT
    [SKDL-加工].專案序號,
    [SKDL-加工].模組編碼,
    [SKDL-加工].模組名稱,
    [SKDL-加工].零件號碼,
    [SKDL-加工].品名,
    [SKDL-加工].驗收日期,
    [SKDL-加工].預計到貨日,
    [SKDL-加工0].預交日期1 AS 過期,
    [SKDL-加工1].預交日期1 AS 第一週,
    [SKDL-加工2].預交日期1 AS 第二週,
    [SKDL-加工3].預交日期1 AS 第三週,
    [SKDL-加工4].預交日期1 AS 第四週,
    [SKDL-加工N].預交日期1 AS 未排,
    [SKDL-加工].採購識別碼,
    dbo_工令單.結案
FROM
    (
        (
            (
                (
                    (
                        (
                            [SKDL-加工]
                            LEFT JOIN [SKDL-加工0] ON [SKDL-加工].採購識別碼 = [SKDL-加工0].採購識別碼
                        )
                        LEFT JOIN [SKDL-加工1] ON [SKDL-加工].採購識別碼 = [SKDL-加工1].採購識別碼
                    )
                    LEFT JOIN [SKDL-加工2] ON [SKDL-加工].採購識別碼 = [SKDL-加工2].採購識別碼
                )
                LEFT JOIN [SKDL-加工3] ON [SKDL-加工].採購識別碼 = [SKDL-加工3].採購識別碼
            )
            LEFT JOIN [SKDL-加工N] ON [SKDL-加工].採購識別碼 = [SKDL-加工N].採購識別碼
        )
        LEFT JOIN [SKDL-加工4] ON [SKDL-加工].採購識別碼 = [SKDL-加工4].採購識別碼
    )
    LEFT JOIN 工令單 dbo_工令單 ON [SKDL-加工].專案序號 = dbo_工令單.專案序號
WHERE
    (
        (
            (dbo_工令單.結案) IS NULL
            OR (dbo_工令單.結案) = 0
        )
    ))
SELECT
    [SKDL-組測].專案序號,
    [SKDL-組測].模組編碼,
    [SKDL-組測].採購識別碼,
    [SKDL-組測].零件號碼,
    [SKDL-組測].品名,
    [SKDL-組測].零件分類,
    [SKDL-組測].零件管制單號,
    [SKDL-組測].驗收合格,
    [SKDL-採購排程].第一週 AS P1,
    [SKDL-加工排程].第一週 AS W1,
    [SKDL-採購排程].第二週 AS P2,
    [SKDL-加工排程].第二週 AS W2,
    [SKDL-採購排程].第三週 AS P3,
    [SKDL-加工排程].第三週 AS W3,
    [SKDL-採購排程].第四週 AS P4,
    dbo_工令單.結案,
    [SKDL-加工排程].第四週 AS W4
FROM
    (
        (
            [SKDL-組測]
            LEFT JOIN [SKDL-採購排程] ON [SKDL-組測].採購識別碼 = [SKDL-採購排程].採購識別碼
        )
        LEFT JOIN [SKDL-加工排程] ON [SKDL-組測].採購識別碼 = [SKDL-加工排程].採購識別碼
    )
    LEFT JOIN 工令單 dbo_工令單 ON [SKDL-組測].專案序號 = dbo_工令單.專案序號
WHERE
    (
        (
            (dbo_工令單.結案) IS NULL
            OR (dbo_工令單.結案) = 0
        )
    ) ORDER BY 專案序號 DESC, 模組編碼";

            using (var conn = new SqlConnection(IRepository<string>.ConnStr))
            {
                conn.Open();
                return conn.Query<組測週排程表>(sql, new { 基準日以前, 第一週, 第二週, 第三週, 第四週 }).ToList();
            }
        }
    }
}
