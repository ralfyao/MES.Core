using Dapper;
using MES.Core.Model;
using MES.Core.Repository;
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
    }
}
