
using Dapper;
using MES.Core.Model;
using MES.Core.Repository;
using System.Data.SqlClient;

namespace MES.WebAPI.MiddleWare
{
    public class SalesTrackingMiddle
    {
        public List<客戶活動力分析> getSalesTrackingList(DateTime 起日, DateTime 迄日)
        {
            string sql = @"
WITH [Z-客戶訂單統計] AS (
SELECT dbo_CUST.COMPANY, Count(dbo_D訂單.單號) AS 單號之筆數, Sum(dbo_D訂單.總額) AS 總額之總計, dbo_D訂單.幣別
FROM C訂單 dbo_D訂單
LEFT JOIN C客戶設定 dbo_CUST ON dbo_D訂單.客戶編號 = dbo_CUST.正航編號
WHERE (((dbo_D訂單.日期)>=@起日 And (dbo_D訂單.日期)<=@迄日))
GROUP BY dbo_CUST.COMPANY, dbo_D訂單.幣別
HAVING (((Sum(dbo_D訂單.總額))>0))
),
[Z-最新匯率] AS (
SELECT  dbo_F匯率.CURRENCY,
    (SELECT 匯率 FROM dbo.F匯率 WHERE CURRENCY = dbo_F匯率.CURRENCY AND 日期=MAX(dbo_F匯率.日期)) AS 匯率之最後一筆
FROM
    F匯率 dbo_F匯率
GROUP BY
    dbo_F匯率.CURRENCY
),
[Z-客戶報價統計] AS (
SELECT [dbo_C-RFQDATA].COMPANY, Count([dbo_C-QUODATA].QUONO) AS QUONO之筆數, Sum([dbo_C-QUODATA].AMOUNT) AS AMOUNT之總計, [dbo_C-QUODATA].Currency
FROM C報價單 [dbo_C-QUODATA]
INNER JOIN C客戶詢問函 [dbo_C-RFQDATA] ON [dbo_C-QUODATA].RFQNO = [dbo_C-RFQDATA].RFQNO
WHERE ((([dbo_C-QUODATA].QUODATE)>=@起日 And ([dbo_C-QUODATA].QUODATE)<=@迄日))
GROUP BY [dbo_C-RFQDATA].COMPANY, [dbo_C-QUODATA].Currency
),
[Z-客戶詢問往來次數] AS (
SELECT [dbo_C-RFQDATA].COMPANY, Count([dbo_C-RFQDATAMEMO].RFQDATE) AS RFQDATE之筆數
FROM C客戶詢問函 [dbo_C-RFQDATA]
INNER JOIN C詢問函聯絡紀錄 [dbo_C-RFQDATAMEMO] ON [dbo_C-RFQDATA].RFQNO = [dbo_C-RFQDATAMEMO].RFQNO
WHERE ((([dbo_C-RFQDATA].RFQDATE)>=@起日 And ([dbo_C-RFQDATA].RFQDATE)<=@迄日))
GROUP BY [dbo_C-RFQDATA].COMPANY
),
[Z-客戶詢問次數] AS (
SELECT [dbo_C-RFQDATA].COMPANY, Count([dbo_C-RFQDATA].RFQNO) AS RFQNO之筆數
FROM C客戶詢問函 [dbo_C-RFQDATA]
WHERE ((([dbo_C-RFQDATA].RFQDATE)>=@起日 And ([dbo_C-RFQDATA].RFQDATE)<=@迄日))
GROUP BY [dbo_C-RFQDATA].COMPANY
),
[Z-客戶連絡次數] AS (
SELECT dbo_CUSTMEMO.COMPANY, Count(dbo_CUSTMEMO.註記) AS 註記之筆數
FROM C客戶聯絡明細 dbo_CUSTMEMO
WHERE (((dbo_CUSTMEMO.日期)>=@起日 And (dbo_CUSTMEMO.日期)<=@迄日))
GROUP BY dbo_CUSTMEMO.COMPANY
),
[Z-客戶列表] AS (
SELECT
    dbo_CUST.COMPANY,
    dbo_CUST.COUNTRY,
    Year([建檔日]) AS 年度
FROM
    C客戶設定 dbo_CUST
)
SELECT
    [Z-客戶列表].COMPANY AS 客戶,
    [Z-客戶列表].COUNTRY AS 所屬國別,
    [Z-客戶列表].年度 AS 客戶建檔年度,
    [Z-客戶連絡次數].註記之筆數 AS 客戶連絡次數,
    [Z-客戶詢問次數].RFQNO之筆數 AS 詢問函筆數,
    [Z-客戶詢問往來次數].RFQDATE之筆數 AS 詢問函往來次數,
    [Z-客戶報價統計].QUONO之筆數 AS 報價單筆數,
    [Z-客戶報價統計].Currency,
    [Z-客戶報價統計].AMOUNT之總計 AS 報價原幣金額,
    [AMOUNT之總計] * [匯率之最後一筆] AS 報價台幣金額,
    [Z-客戶訂單統計].單號之筆數 AS 訂單筆數,
    [Z-客戶訂單統計].總額之總計 AS 訂單原幣金額,
    [總額之總計] * [匯率之最後一筆] AS 訂單台幣金額,
    [Z-最新匯率].匯率之最後一筆 AS 換算匯率,
    CAST(ISNULL([Z-客戶訂單統計].單號之筆數,0) AS FLOAT) / ISNULL([Z-客戶報價統計].QUONO之筆數,1) AS 單數成交率,
    ISNULL([Z-客戶訂單統計].總額之總計,0) / ISNULL([Z-客戶報價統計].AMOUNT之總計,1) AS 金額成交率
FROM
    (
        (
            (
                (
                    [Z-客戶列表]
                    LEFT JOIN [Z-客戶連絡次數] ON [Z-客戶列表].COMPANY = [Z-客戶連絡次數].COMPANY
                )
                LEFT JOIN [Z-客戶詢問次數] ON [Z-客戶連絡次數].COMPANY = [Z-客戶詢問次數].COMPANY
            )
            LEFT JOIN [Z-客戶詢問往來次數] ON [Z-客戶詢問次數].COMPANY = [Z-客戶詢問往來次數].COMPANY
        )
        LEFT JOIN (
            [Z-客戶報價統計]
            LEFT JOIN [Z-最新匯率] ON [Z-客戶報價統計].Currency = [Z-最新匯率].CURRENCY
        ) ON [Z-客戶列表].COMPANY = [Z-客戶報價統計].COMPANY
    )
    LEFT JOIN [Z-客戶訂單統計] ON [Z-客戶報價統計].COMPANY = [Z-客戶訂單統計].COMPANY
ORDER BY
    [Z-客戶連絡次數].註記之筆數 DESC,
    [AMOUNT之總計] * [匯率之最後一筆] DESC,
    [總額之總計] * [匯率之最後一筆] DESC";

            using (var conn = new SqlConnection(IRepository<string>.ConnStr))
            {
                conn.Open();
                return conn.Query<客戶活動力分析>(sql, new { 起日, 迄日 }).ToList();
            }
        }
    }
}
