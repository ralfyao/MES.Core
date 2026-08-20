using Dapper;
using MES.Core.Model;
using MES.Core.Repository;
using System.Data.SqlClient;
using System.Security.Principal;

namespace MES.WebAPI.MiddleWare
{
    public class HRMiddle
    {
        public static string SQL_INSERT_工作紀錄A = $@"INSERT INTO dbo.工作紀錄A
                                                    (
                                                        日誌單號,
                                                        工作日期,
                                                        職務,
                                                        員工編號,
                                                        專案序號,
                                                        模組編碼,
                                                        模組名稱,
                                                        任務分類,
                                                        成效點數,
                                                        工作項目,
                                                        組裝零件,
                                                        進度,
                                                        本日工時,
                                                        特別註記,
                                                        單價,
                                                        工作簡述,
                                                        預計再訪
                                                    )
                                                    VALUES
                                                    (   
	                                                    @日誌單號	, -- 日誌單號			- nvarchar(30)
                                                        @工作日期	, -- 工作日期			- smalldatetime
                                                        @職務	, -- 職務			- nvarchar(12)
                                                        @員工編號	, -- 員工編號			- nvarchar(20)
                                                        @專案序號	, -- 專案序號			- nvarchar(20)
                                                        @模組編碼	, -- 模組編碼			- nvarchar(20)
                                                        @模組名稱	, -- 模組名稱			- nvarchar(150)
                                                        @任務分類	, -- 任務分類			- nvarchar(30)
                                                        @成效點數	, -- 成效點數			- real
                                                        @工作項目	, -- 工作項目			- nvarchar(max)
                                                        @組裝零件	, -- 組裝零件			- varchar(8000)
                                                        @進度	, -- 進度			- float
                                                        @本日工時	, -- 本日工時			- real
                                                        @特別註記	, -- 特別註記			- nvarchar(100)
                                                        @單價	, -- 單價			- real
                                                        @工作簡述	, -- 工作簡述			- nvarchar(max)
                                                        @預計再訪	  -- 預計再訪			- smalldatetime
                                                        )";
        // ── 員工清冊總覽：H員工基本資料 RIGHT JOIN H員工清冊 ON 工號 ─────────────
        public List<員工清冊列表> getEmployeeList()
        {
            List<員工清冊列表> list = new List<員工清冊列表>();
            try
            {
                using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    conn.Open();
                    string sql = $@"SELECT
                                        dbo_EMPL.工號,
                                        dbo_EMPL.姓名,
                                        dbo_EMPL.部門,
                                        dbo_EMPL.人事編號,
                                        dbo_EMPL.卡號,
                                        CONVERT(varchar(10), dbo_EMPL.生日, 111) AS 生日,
                                        dbo_H員工基本資料.職等,
                                        dbo_H員工基本資料.職級,
                                        CONVERT(varchar(10), dbo_H員工基本資料.核薪日, 111) AS 核薪日,
                                        CONVERT(varchar(10), dbo_H員工基本資料.離職日, 111) AS 離職日,
                                        dbo_EMPL.狀況
                                    FROM
                                        H員工基本資料 dbo_H員工基本資料
                                        RIGHT JOIN H員工清冊 dbo_EMPL ON dbo_H員工基本資料.工號 = dbo_EMPL.工號";
                    list = conn.Query<員工清冊列表>(sql).ToList();
                }
            }
            catch (Exception)
            {

                throw;
            }
            return list;
        }
        // ── 員工薪給結構(核薪紀錄)：依工號查詢 H員工基本資料 全部歷程，依核薪日排序 ──
        public List<H員工基本資料> getEmployeeSalaryList(string empNo)
        {
            List<H員工基本資料> list = new List<H員工基本資料>();
            try
            {
                using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    conn.Open();
                    string sql = $@"SELECT
                                        識別碼, 工號, 職等, 職級,
                                        CONVERT(varchar(10), 核薪日, 111) AS 核薪日,
                                        CONVERT(varchar(10), 離職日, 111) AS 離職日,
                                        本薪, 職務加給, 日薪, 時薪, 主管津貼, 全勤獎金,
                                        每日伙食津貼, 其他加項, 投保等級, 眷保口數,
                                        勞保, 健保, 眷保, 其他減項, 退休金自提, 退休公司提,
                                        加班備註, 扣款時薪, 備註一, 備註二, 備註三,
                                        建檔維護, 核准人員
                                    FROM H員工基本資料
                                    WHERE 工號 = @工號
                                    ORDER BY 識別碼";
                    list = conn.Query<H員工基本資料>(sql, new { 工號 = empNo }).ToList();
                }
            }
            catch (Exception)
            {

                throw;
            }
            return list;
        }

        // ── 員工薪給結構：新增或更新一筆核薪紀錄(識別碼=0 為新增) ──────────────
        public void saveEmployeeSalary(H員工基本資料 form)
        {
            try
            {
                using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    conn.Open();
                    if (form.識別碼 == 0)
                    {
                        string sql = @"INSERT INTO H員工基本資料
                                        (工號, 職等, 職級, 核薪日, 離職日, 本薪, 職務加給, 日薪, 時薪,
                                         主管津貼, 全勤獎金, 每日伙食津貼, 其他加項, 投保等級, 眷保口數,
                                         勞保, 健保, 眷保, 其他減項, 退休金自提, 退休公司提,
                                         加班備註, 扣款時薪, 備註一, 備註二, 備註三, 建檔維護)
                                       VALUES
                                        (@工號, @職等, @職級, @核薪日, @離職日, @本薪, @職務加給, @日薪, @時薪,
                                         @主管津貼, @全勤獎金, @每日伙食津貼, @其他加項, @投保等級, @眷保口數,
                                         @勞保, @健保, @眷保, @其他減項, @退休金自提, @退休公司提,
                                         @加班備註, @扣款時薪, @備註一, @備註二, @備註三, @建檔維護)";
                        conn.Execute(sql, form);
                    }
                    else
                    {
                        string sql = @"UPDATE H員工基本資料 SET
                                         職等=@職等, 職級=@職級, 核薪日=@核薪日, 離職日=@離職日,
                                         本薪=@本薪, 職務加給=@職務加給, 日薪=@日薪, 時薪=@時薪,
                                         主管津貼=@主管津貼, 全勤獎金=@全勤獎金, 每日伙食津貼=@每日伙食津貼,
                                         其他加項=@其他加項, 投保等級=@投保等級, 眷保口數=@眷保口數,
                                         勞保=@勞保, 健保=@健保, 眷保=@眷保, 其他減項=@其他減項,
                                         退休金自提=@退休金自提, 退休公司提=@退休公司提,
                                         加班備註=@加班備註, 扣款時薪=@扣款時薪,
                                         備註一=@備註一, 備註二=@備註二, 備註三=@備註三, 建檔維護=@建檔維護
                                       WHERE 識別碼=@識別碼";
                        conn.Execute(sql, form);
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        // ── 修改員工個資「狀況」改為離職時，將離職日期寫入該工號目前最新一筆
        //    (識別碼最大)核薪紀錄的 離職日；改回非離職狀態時傳入空白以清空 ──────
        public void updateLatestSalaryResignDate(string empNo, string resignDate)
        {
            try
            {
                using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    conn.Open();
                    int? latestId = conn.Query<int?>("SELECT MAX(識別碼) FROM H員工基本資料 WHERE 工號=@工號", new { 工號 = empNo }).FirstOrDefault();
                    if (!latestId.HasValue) return;

                    if (string.IsNullOrEmpty(resignDate))
                    {
                        conn.Execute("UPDATE H員工基本資料 SET 離職日=NULL WHERE 識別碼=@識別碼", new { 識別碼 = latestId.Value });
                    }
                    else
                    {
                        conn.Execute("UPDATE H員工基本資料 SET 離職日=@離職日 WHERE 識別碼=@識別碼", new { 離職日 = resignDate, 識別碼 = latestId.Value });
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        // ── 生效/取消生效：寫入或清空 核准人員(無獨立核准日欄位，比照原 Access 表單邏輯) ──
        public void validateEmployeeSalary(int id, bool approve, string account)
        {
            try
            {
                using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    conn.Open();
                    string sql = @"UPDATE H員工基本資料 SET 核准人員=@核准人員 WHERE 識別碼=@識別碼";
                    conn.Execute(sql, new { 核准人員 = approve ? account : null, 識別碼 = id });
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        // ── 刪除核薪紀錄：已核准(核准人員非空)禁止刪除，比照原 Access 表單邏輯 ────
        public void deleteEmployeeSalary(int id)
        {
            try
            {
                using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    conn.Open();
                    string approved = conn.Query<string>("SELECT 核准人員 FROM H員工基本資料 WHERE 識別碼=@識別碼", new { 識別碼 = id }).FirstOrDefault();
                    if (!string.IsNullOrEmpty(approved))
                    {
                        throw new Exception("已核准無法刪除，請洽後台管理員！");
                    }
                    conn.Execute("DELETE FROM H員工基本資料 WHERE 識別碼=@識別碼", new { 識別碼 = id });
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        // ── 每日出勤表：依日期查詢(或建立空白)表頭 H日曆 ──────────────────────
        public H日曆 getCalendarByDate(string date)
        {
            H日曆 obj = null;
            try
            {
                using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    conn.Open();
                    string sql = @"SELECT CONVERT(varchar(10), 日期, 111) AS 日期, 例假日,
                                          導入卡鐘資料, CONVERT(varchar(16), 導入時間, 120) AS 導入時間
                                   FROM H日曆 WHERE 日期=@日期";
                    obj = conn.Query<H日曆>(sql, new { 日期 = date }).FirstOrDefault();
                }
            }
            catch (Exception)
            {

                throw;
            }
            return obj ?? new H日曆 { 日期 = date };
        }

        // ── 每日卡鐘總覽(日曆總覽)：取得 H日曆 全部日期列表(含例假日)，供瀏覽/
        //    雙擊切換回「每日出勤表」使用 ──────────────────────────────────
        public List<H日曆> getCalendarList()
        {
            List<H日曆> list = new List<H日曆>();
            try
            {
                using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    conn.Open();
                    string sql = @"SELECT CONVERT(varchar(10), 日期, 111) AS 日期, 例假日,
                                          公告事項, 人事經辦, 核准生效, 核准人,
                                          導入卡鐘資料, CONVERT(varchar(16), 導入時間, 120) AS 導入時間
                                   FROM H日曆 ORDER BY 日期";
                    list = conn.Query<H日曆>(sql).ToList();
                }
            }
            catch (Exception)
            {

                throw;
            }
            return list;
        }

        // ── 每日出勤表：依日期排序取得全部已建立表頭的日期，供 Last/Next 切換使用 ──
        public List<string> getCalendarDateList()
        {
            List<string> list = new List<string>();
            try
            {
                using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    conn.Open();
                    string sql = @"SELECT CONVERT(varchar(10), 日期, 111) FROM H日曆 ORDER BY 日期";
                    list = conn.Query<string>(sql).ToList();
                }
            }
            catch (Exception)
            {

                throw;
            }
            return list;
        }

        // ── 每日出勤表：新增或更新表頭(依日期是否已存在判斷)，僅處理 例假日
        //    (不動 公告事項/人事經辦/核准生效/核准人，避免覆蓋日曆總覽維護的資料) ──
        public void saveCalendar(H日曆 form)
        {
            try
            {
                using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    conn.Open();
                    int exists = conn.Query<int>("SELECT COUNT(0) FROM H日曆 WHERE 日期=@日期", new { form.日期 }).First();
                    if (exists == 0)
                    {
                        conn.Execute(@"INSERT INTO H日曆 (日期, 例假日) VALUES (@日期, @例假日)", form);
                    }
                    else
                    {
                        conn.Execute(@"UPDATE H日曆 SET 例假日=@例假日 WHERE 日期=@日期", form);
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        // ── 日曆總覽(CalendarControl)：新增或更新一整筆(含 公告事項/人事經辦/
        //    核准生效/核准人)，依日期是否已存在判斷 ──────────────────────────
        public void saveCalendarFull(H日曆 form)
        {
            try
            {
                using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    conn.Open();
                    int exists = conn.Query<int>("SELECT COUNT(0) FROM H日曆 WHERE 日期=@日期", new { form.日期 }).First();
                    if (exists == 0)
                    {
                        conn.Execute(@"INSERT INTO H日曆 (日期, 例假日, 公告事項, 人事經辦, 核准生效, 核准人)
                                       VALUES (@日期, @例假日, @公告事項, @人事經辦, @核准生效, @核准人)", form);
                    }
                    else
                    {
                        conn.Execute(@"UPDATE H日曆 SET 例假日=@例假日, 公告事項=@公告事項, 人事經辦=@人事經辦,
                                         核准生效=@核准生效, 核准人=@核准人
                                       WHERE 日期=@日期", form);
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        // ── 每日出勤紀錄：依日期查詢表身(含姓名、依請假紀錄推算之假別) ────────
        public List<考勤紀錄列表> getAttendanceList(string date)
        {
            List<考勤紀錄列表> list = new List<考勤紀錄列表>();
            try
            {
                using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    conn.Open();
                    string sql = @"SELECT
                                        a.識別碼, a.員工編號, e.姓名, a.卡號, a.班次,
                                        LEFT(CONVERT(varchar(8), a.正規上班, 108), 5) AS 正規上班,
                                        LEFT(CONVERT(varchar(8), a.正規下班, 108), 5) AS 正規下班,
                                        LEFT(CONVERT(varchar(8), a.加班上班, 108), 5) AS 加班上班,
                                        LEFT(CONVERT(varchar(8), a.加班下班, 108), 5) AS 加班下班,
                                        a.出勤時數, a.請休時數, a.遲到分鐘數, a.忘卡,
                                        ISNULL(f.假別, '') AS 假別
                                    FROM H考勤紀錄 a
                                    LEFT JOIN H員工清冊 e ON a.員工編號 = e.工號
                                    LEFT JOIN (
                                        SELECT 員工編號, 日期,
                                            CASE WHEN 事假>0 THEN N'事假'
                                                 WHEN 病假>0 THEN N'病假'
                                                 WHEN 特休假>0 THEN N'特休假'
                                                 WHEN 產假>0 THEN N'產(陪)假'
                                                 WHEN 公假>0 THEN N'公假'
                                                 WHEN 生理假>0 THEN N'生理假'
                                                 WHEN 親情假>0 THEN N'親情假'
                                                 WHEN 曠職>0 THEN N'天災假'
                                                 ELSE '' END AS 假別
                                        FROM H請假紀錄
                                        WHERE 日期=@日期
                                    ) f ON f.員工編號 = a.員工編號
                                    WHERE a.日期=@日期
                                    ORDER BY a.卡號";
                    list = conn.Query<考勤紀錄列表>(sql, new { 日期 = date }).ToList();
                }
            }
            catch (Exception)
            {

                throw;
            }
            return list;
        }

        // ── 員工考勤核對(H-出勤卡)：依員工編號+查詢起訖日，列出區間內每一天的
        //    出勤紀錄(當天無打卡紀錄亦列出空白列，比照原 Access「H日曆 查詢」
        //    LEFT JOIN 邏輯)，並依 H請假紀錄 推算假別 ─────────────────────
        public List<考勤核對列表> getAttendanceCheckList(string empNo, string startDate, string endDate)
        {
            List<考勤核對列表> list = new List<考勤核對列表>();
            try
            {
                using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    conn.Open();
                    // ── 加班分鐘核對帳簿：比照原 Access 查詢邏輯換算加班分鐘數/核准時數，
                    //    唯原查詢的 JOIN 只用「日期」比對(未比對員工編號)，可能將他人的
                    //    加班核准/薪資資料誤配到同日出勤紀錄上；此處已修正為同時比對
                    //    員工編號，確保時薪/加班時數等資料屬於同一人 ─────────────────
                    string sql = @"SELECT
                                        CONVERT(varchar(10), c.日期, 111) AS 日期,
                                        c.例假日,
                                        a.班次,
                                        LEFT(CONVERT(varchar(8), a.正規上班, 108), 5) AS 正規上班,
                                        LEFT(CONVERT(varchar(8), a.正規下班, 108), 5) AS 正規下班,
                                        LEFT(CONVERT(varchar(8), a.加班上班, 108), 5) AS 加班上班,
                                        LEFT(CONVERT(varchar(8), a.加班下班, 108), 5) AS 加班下班,
                                        a.出勤時數, a.請休時數, a.遲到分鐘數, a.早退分鐘數, a.忘卡, a.備註,
                                        ISNULL(f.假別, '') AS 假別,
                                        ot.核准時數, ot.加班費
                                    FROM H日曆 c
                                    LEFT JOIN H考勤紀錄 a ON a.日期 = c.日期 AND a.員工編號 = @員工編號
                                    LEFT JOIN (
                                        SELECT 日期,
                                            CASE WHEN 事假>0 THEN N'事假'
                                                 WHEN 病假>0 THEN N'病假'
                                                 WHEN 特休假>0 THEN N'特休假'
                                                 WHEN 產假>0 THEN N'產(陪)假'
                                                 WHEN 公假>0 THEN N'公假'
                                                 WHEN 生理假>0 THEN N'生理假'
                                                 WHEN 親情假>0 THEN N'親情假'
                                                 WHEN 曠職>0 THEN N'天災假'
                                                 ELSE '' END AS 假別
                                        FROM H請假紀錄
                                        WHERE 員工編號=@員工編號
                                    ) f ON f.日期 = c.日期
                                    LEFT JOIN (
                                        SELECT
                                            m.日期,
                                            m.加班分鐘數 / 60.0 AS 核准時數,
                                            ROUND(mm.加班乘數分鐘 * ROUND(e.時薪 / 60.0, 2), 0) AS 加班費
                                        FROM (
                                            SELECT
                                                h.日期, h.員工編號, h.班次,
                                                CASE WHEN DATEDIFF(MINUTE, h.加班上班, h.加班下班) > o.時數*60
                                                     THEN o.時數*60
                                                     ELSE CAST(DATEDIFF(MINUTE, h.加班上班, h.加班下班) AS float)
                                                END AS 加班分鐘數
                                            FROM H考勤紀錄 h
                                            INNER JOIN H核准加班明細 o
                                                ON o.員工編號 = h.員工編號 AND o.加班日期 = h.日期
                                            WHERE h.員工編號 = @員工編號
                                              AND h.加班上班 IS NOT NULL AND h.加班下班 IS NOT NULL
                                        ) m
                                        CROSS APPLY (
                                            SELECT CASE
                                                WHEN m.班次 = N'國定假日' THEN m.加班分鐘數 * 1.0
                                                WHEN m.加班分鐘數 > 480 THEN (m.加班分鐘數-480)*8.0/3 + 360*5.0/3 + 120*4.0/3
                                                WHEN m.加班分鐘數 > 120 THEN (m.加班分鐘數-120)*5.0/3 + 120*4.0/3
                                                ELSE m.加班分鐘數 * 4.0/3
                                            END AS 加班乘數分鐘
                                        ) mm
                                        INNER JOIN H員工基本資料 e ON e.工號 = m.員工編號
                                        WHERE m.日期 >= e.核薪日 AND m.日期 <= e.離職日
                                    ) ot ON ot.日期 = c.日期
                                    WHERE c.日期 BETWEEN @開始日期 AND @結束日期
                                    ORDER BY c.日期";
                    list = conn.Query<考勤核對列表>(sql, new { 員工編號 = empNo, 開始日期 = startDate, 結束日期 = endDate }).ToList();
                }
            }
            catch (Exception)
            {

                throw;
            }
            return list;
        }

        // ── 導入卡鐘資料：H卡鐘(單欄 card 原始刷卡字串) 解析後寫入 H考勤紀錄。
        //    比照原 Access「H卡鐘查詢」/「H卡鐘正規上班」/「H卡鐘正規下班」/
        //    「H卡鐘加班下班」/「H考勤紀錄更新1」共 5 個查詢的邏輯合併重現：
        //    card 格式為 25 碼字串："AA"刷卡機(2) + 卡號(8) + 1碼未用 +
        //    "HHMM"時間(4) + "YYYYMMDD"日期(8) + 2碼未用；
        //    時間<12:00 視為正規上班(取最早一筆)；14:00~18:00 視為正規下班候
        //    選(取最早一筆)；>18:00 視為加班下班(取最晚一筆)；
        //    若有加班下班紀錄，正規下班/加班上班固定為 17:10，加班下班取實際
        //    刷卡時間；若無加班紀錄，正規下班取正規下班候選值，加班上下班空白 ──
        public void importClockData(string date)
        {
            try
            {
                using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    conn.Open();
                    string sql = @"
                        ;WITH ParsedCard AS (
                            SELECT
                                SUBSTRING(card,3,8) AS 卡號,
                                SUBSTRING(card,12,2) + ':' + SUBSTRING(card,14,2) AS 時間,
                                SUBSTRING(card,16,4) + '/' + SUBSTRING(card,20,2) + '/' + SUBSTRING(card,22,2) AS 日期
                            FROM H卡鐘
                            WHERE LEN(card) >= 23
                        ),
                        Filtered AS (
                            SELECT * FROM ParsedCard WHERE 日期 = @日期
                        ),
                        正規上班表 AS (
                            SELECT 卡號, MIN(時間) AS 正規上班 FROM Filtered WHERE 時間 < '12:00' GROUP BY 卡號
                        ),
                        正規下班表 AS (
                            SELECT 卡號, MIN(時間) AS 正規下班候 FROM Filtered WHERE 時間 BETWEEN '14:00' AND '18:00' GROUP BY 卡號
                        ),
                        加班下班表 AS (
                            SELECT 卡號, MAX(時間) AS 加班下班 FROM Filtered WHERE 時間 > '18:00' GROUP BY 卡號
                        ),
                        Combined AS (
                            SELECT
                                a.卡號,
                                e.工號 AS 員工編號,
                                a.正規上班,
                                CASE WHEN c.加班下班 IS NOT NULL THEN '17:10' ELSE b.正規下班候 END AS 正規下班,
                                CASE WHEN c.加班下班 IS NOT NULL THEN '17:10' ELSE NULL END AS 加班上班,
                                c.加班下班
                            FROM 正規上班表 a
                            LEFT JOIN 正規下班表 b ON a.卡號 = b.卡號
                            LEFT JOIN 加班下班表 c ON a.卡號 = c.卡號
                            LEFT JOIN H員工清冊 e ON a.卡號 = e.卡號
                        )
                        INSERT INTO H考勤紀錄 (日期, 卡號, 員工編號, 正規上班, 正規下班, 加班上班, 加班下班)
                        SELECT @日期, Combined.卡號, Combined.員工編號, Combined.正規上班, Combined.正規下班, Combined.加班上班, Combined.加班下班
                        FROM Combined
                        WHERE NOT EXISTS (SELECT 1 FROM H考勤紀錄 WHERE 日期=@日期 AND 卡號=Combined.卡號);";
                    conn.Execute(sql, new { 日期 = date });

                    int exists = conn.Query<int>("SELECT COUNT(0) FROM H日曆 WHERE 日期=@日期", new { 日期 = date }).First();
                    if (exists == 0)
                    {
                        conn.Execute("INSERT INTO H日曆 (日期, 導入卡鐘資料, 導入時間) VALUES (@日期, 1, GETDATE())", new { 日期 = date });
                    }
                    else
                    {
                        conn.Execute("UPDATE H日曆 SET 導入卡鐘資料=1, 導入時間=GETDATE() WHERE 日期=@日期", new { 日期 = date });
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        // ── 每日出勤紀錄：新增或更新一筆(識別碼=0 為新增) ─────────────────────
        public void saveAttendance(H考勤紀錄 form)
        {
            try
            {
                using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    conn.Open();
                    if (form.識別碼 == 0)
                    {
                        string sql = @"INSERT INTO H考勤紀錄
                                        (員工編號, 日期, 班次, 正規上班, 正規下班, 加班上班, 加班下班,
                                         出勤時數, 請休時數, 遲到分鐘數, 卡號, 忘卡, 備註)
                                       VALUES
                                        (@員工編號, @日期, @班次, @正規上班, @正規下班, @加班上班, @加班下班,
                                         @出勤時數, @請休時數, @遲到分鐘數, @卡號, @忘卡, @備註)";
                        conn.Execute(sql, form);
                    }
                    else
                    {
                        string sql = @"UPDATE H考勤紀錄 SET
                                         員工編號=@員工編號, 班次=@班次, 正規上班=@正規上班, 正規下班=@正規下班,
                                         加班上班=@加班上班, 加班下班=@加班下班, 出勤時數=@出勤時數,
                                         請休時數=@請休時數, 遲到分鐘數=@遲到分鐘數, 卡號=@卡號,
                                         忘卡=@忘卡, 備註=@備註
                                       WHERE 識別碼=@識別碼";
                        conn.Execute(sql, form);
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        // ── 每日出勤紀錄：刪除一筆 ────────────────────────────────────────
        public void deleteAttendance(int id)
        {
            try
            {
                using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    conn.Open();
                    conn.Execute("DELETE FROM H考勤紀錄 WHERE 識別碼=@識別碼", new { 識別碼 = id });
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public H員工清冊 getEmployeeByAccount(string account)
        {
            H員工清冊 obj = new H員工清冊();
            try
            {
                using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    conn.Open();
                    string sql = $@"SELECT * FROM H員工清冊 where 系統帳號 = '{account}';";
                    obj = conn.Query<H員工清冊>(sql).FirstOrDefault();
                }
            }
            catch (Exception)
            {

                throw;
            }
            return obj;
        }
        public void saveUpdateJournal(工作紀錄A form)
        {
            try
            {
                using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    conn.Open();
                    string sql = $@"{SQL_INSERT_工作紀錄A}";
                    DynamicParameters dynamicParameters = new DynamicParameters(form);
                    conn.Execute(sql, dynamicParameters);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        public 工作紀錄A getJournalByNo(string journalNo)
        {
            工作紀錄A a = new 工作紀錄A();
            try
            {
                using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    conn.Open();
                    string sql = $@"SELECT * FROM 工作紀錄A WHERE 日誌單號='{journalNo}'";
                    a = conn.Query<工作紀錄A>(sql).FirstOrDefault();
                }
            }
            catch (Exception)
            {

                throw;
            }
            return a;
        }
        public account getAccount(string account = "")
        {
            account a = new account();
            try
            {
                using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    conn.Open();
                    string sql = $@"SELECT * FROM account WHERE 1=1";
                    if (!string.IsNullOrEmpty(account))
                        sql +=  " AND 帳號=@帳號";
                    account account1 = new account();
                    account1.帳號 = account;
                    DynamicParameters dynamicParameters = new DynamicParameters(account1);
                    var tmpa = conn.Query<account>(sql, dynamicParameters)?.FirstOrDefault();
                    if (tmpa != null)
                        a = tmpa;
                }
            }
            catch (Exception)
            {

                throw;
            }
            return a;
        }

        internal int UpdatePassword(string account, string newPassword)
        {
            int retCode = 0;
            try
            {
                using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    conn.Open();
                    string strSQL = $@"UPDATE account SET 密碼=@密碼 WHERE 帳號=@帳號";
                    account authenticate = new account();
                    authenticate.帳號 = account;
                    authenticate.密碼 = newPassword;
                    DynamicParameters dynamicParameters = new DynamicParameters(authenticate);
                    retCode = conn.Execute(strSQL, dynamicParameters);
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return retCode;
        }

        // ══════════════════════════ 加班申請單(H-加班申請單) ══════════════════════════

        // ── 加班申請單總覽：僅表頭，供「總覽」清單挑選 ─────────────────────
        public List<H加班申請單> getOvertimeApplyList()
        {
            List<H加班申請單> list = new List<H加班申請單>();
            try
            {
                using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    conn.Open();
                    string sql = @"SELECT 單據編號, 申請單位, CONVERT(varchar(10), 申請日期, 111) AS 申請日期,
                                          申請人, 核准生效, 核准人
                                   FROM H加班申請單
                                   ORDER BY 單據編號 DESC";
                    list = conn.Query<H加班申請單>(sql).ToList();
                }
            }
            catch (Exception)
            {

                throw;
            }
            return list;
        }

        // ── 加班申請單單筆查詢：表頭+表身(核准加班明細) ────────────────────
        public H加班申請單 getOvertimeApplyByNo(string no)
        {
            try
            {
                using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    conn.Open();
                    string sql = @"SELECT 單據編號, 申請單位, CONVERT(varchar(10), 申請日期, 111) AS 申請日期,
                                          申請人, 核准生效, 核准人
                                   FROM H加班申請單
                                   WHERE 單據編號=@單據編號";
                    var form = conn.Query<H加班申請單>(sql, new { 單據編號 = no }).FirstOrDefault();
                    if (form == null) return null;

                    string sql2 = @"SELECT 識別碼, 單據編號, 員工編號, CONVERT(varchar(10), 加班日期, 111) AS 加班日期,
                                            LEFT(CONVERT(varchar(8), 起, 108), 5) AS 起,
                                            LEFT(CONVERT(varchar(8), 訖, 108), 5) AS 訖,
                                            時數, 加班事由, 加班內容詳述, 備註
                                     FROM H核准加班明細
                                     WHERE 單據編號=@單據編號
                                     ORDER BY 識別碼";
                    form.detailList = conn.Query<H核准加班明細>(sql2, new { 單據編號 = no }).ToList();
                    return form;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        // ── 單據編號預覽：點選「新增」時立即顯示，邏輯與 saveOvertimeApply
        //    內產生單據編號完全相同(僅供畫面顯示，實際仍以儲存交易內產生的
        //    編號為準，避免多人同時新增造成編號衝突) ──────────────────────
        public string previewOvertimeApplyNo(string date)
        {
            try
            {
                using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    conn.Open();
                    string maxNo = conn.Query<string>(
                        "SELECT MAX(單據編號) FROM H加班申請單 WHERE 申請日期=@申請日期",
                        new { 申請日期 = date }).FirstOrDefault();
                    if (string.IsNullOrEmpty(maxNo))
                    {
                        DateTime.TryParse(date, out var d);
                        return "OT" + d.ToString("yyyyMMdd") + "01";
                    }
                    int seq = int.Parse(maxNo.Substring(10, 2)) + 1;
                    return maxNo.Substring(0, 10) + seq.ToString("00");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        // ── 加班申請單明細：交易內先刪除表身再重新寫入(比照總務支出單慣例) ────
        private void saveOvertimeApplyDetail(SqlConnection conn, SqlTransaction tran, H加班申請單 form)
        {
            conn.Execute("DELETE FROM H核准加班明細 WHERE 單據編號=@單據編號", new { 單據編號 = form.單據編號 }, tran);
            string insSql = @"INSERT INTO H核准加班明細
                                (單據編號, 員工編號, 加班日期, 起, 訖, 時數, 加班事由, 加班內容詳述, 備註)
                               VALUES
                                (@單據編號, @員工編號, @加班日期, @起, @訖, @時數, @加班事由, @加班內容詳述, @備註)";
            foreach (var d in form.detailList ?? new List<H核准加班明細>())
            {
                d.單據編號 = form.單據編號;
                conn.Execute(insSql, d, tran);
            }
        }

        // ── 加班申請單新增：單據編號比照原巨集「日期」欄位 AfterUpdate 邏輯，
        //    以 DMax 取同一申請日期最大單號後遞增末2位序號(無則為 "OT"+申請日期
        //    8碼+"01")，僅新單、單據編號為空時才產生 ────────────────────────
        public string saveOvertimeApply(H加班申請單 form)
        {
            try
            {
                using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    conn.Open();
                    using (var tran = conn.BeginTransaction())
                    {
                        try
                        {
                            if (string.IsNullOrEmpty(form.單據編號))
                            {
                                string maxNo = conn.Query<string>(
                                    "SELECT MAX(單據編號) FROM H加班申請單 WHERE 申請日期=@申請日期",
                                    new { 申請日期 = form.申請日期 }, tran).FirstOrDefault();
                                if (string.IsNullOrEmpty(maxNo))
                                {
                                    DateTime.TryParse(form.申請日期, out var d);
                                    form.單據編號 = "OT" + d.ToString("yyyyMMdd") + "01";
                                }
                                else
                                {
                                    int seq = int.Parse(maxNo.Substring(10, 2)) + 1;
                                    form.單據編號 = maxNo.Substring(0, 10) + seq.ToString("00");
                                }
                            }

                            string sql = @"INSERT INTO H加班申請單
                                            (單據編號, 申請單位, 申請日期, 申請人, 核准生效, 核准人)
                                           VALUES
                                            (@單據編號, @申請單位, @申請日期, @申請人, @核准生效, @核准人)";
                            conn.Execute(sql, form, tran);
                            saveOvertimeApplyDetail(conn, tran, form);
                            tran.Commit();
                            return form.單據編號;
                        }
                        catch
                        {
                            tran.Rollback();
                            throw;
                        }
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        // ── 加班申請單修改：單據編號/申請日期不變，僅更新申請單位/申請人，
        //    表身整批刪除重建 ────────────────────────────────────────────
        public void updateOvertimeApply(H加班申請單 form)
        {
            try
            {
                using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    conn.Open();
                    using (var tran = conn.BeginTransaction())
                    {
                        try
                        {
                            string sql = @"UPDATE H加班申請單 SET 申請單位=@申請單位, 申請人=@申請人
                                           WHERE 單據編號=@單據編號";
                            conn.Execute(sql, form, tran);
                            saveOvertimeApplyDetail(conn, tran, form);
                            tran.Commit();
                        }
                        catch
                        {
                            tran.Rollback();
                            throw;
                        }
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        // ── 生效/取消生效：比照原巨集，生效時核准人寫入登入者姓名，
        //    取消生效清空核准人 ──────────────────────────────────────────
        public void validateOvertimeApply(string no, bool approve, string approver)
        {
            try
            {
                using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    conn.Open();
                    if (approve)
                    {
                        conn.Execute("UPDATE H加班申請單 SET 核准生效=1, 核准人=@核准人 WHERE 單據編號=@單據編號",
                            new { 核准人 = approver, 單據編號 = no });
                    }
                    else
                    {
                        conn.Execute("UPDATE H加班申請單 SET 核准生效=0, 核准人=NULL WHERE 單據編號=@單據編號",
                            new { 單據編號 = no });
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        // ── 刪除加班申請單：連同表身一併刪除 ──────────────────────────────
        public void deleteOvertimeApply(string no)
        {
            try
            {
                using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    conn.Open();
                    string sql = @"DELETE FROM H核准加班明細 WHERE 單據編號=@單據編號;
                                   DELETE FROM H加班申請單 WHERE 單據編號=@單據編號";
                    conn.Execute(sql, new { 單據編號 = no });
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        // ── 申請單位下拉來源：比照原巨集 RowSource(dbo_成本單位.職務)，
        //    實際對應 SQL Server 之 A成本單位 ─────────────────────────────
        public List<string> getCostUnitList()
        {
            try
            {
                using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    conn.Open();
                    return conn.Query<string>("SELECT 職務 FROM A成本單位 ORDER BY 識別碼").ToList();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        // ── 加班事由下拉來源：H加班事由 主檔 ──────────────────────────────
        public List<H加班事由> getOvertimeReasonList()
        {
            try
            {
                using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    conn.Open();
                    return conn.Query<H加班事由>("SELECT 加班事由代碼, 加班事由 FROM H加班事由").ToList();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        // ── 員工加班紀錄表頭導覽用清單：H員工清冊 全量，不篩選狀況，
        //    比照原巨集 RecordSource(dbo_EMPL)瀏覽全部員工並以首/前/次/末
        //    按鈕切換 ─────────────────────────────────────────────────────
        public List<H員工清冊> getAllEmployeeBasicList()
        {
            try
            {
                using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    conn.Open();
                    return conn.Query<H員工清冊>("SELECT * FROM H員工清冊 ORDER BY 工號").ToList();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        // ── 員工加班紀錄表身：比照原「加班分鐘核對-1」查詢，唯該查詢誤將
        //    「假日班」誤植為判斷字串(其真正來源查詢「加班分鐘核對帳簿」比對
        //    的是「國定假日」，且 H考勤紀錄.班次 亦僅會出現「國定假日」)，
        //    故此處採用與 getAttendanceCheckList 一致、已修正的正確版本 ──────
        public List<員工加班紀錄列表> getEmployeeOvertimeRecordList(string empNo, string startDate, string endDate)
        {
            List<員工加班紀錄列表> list = new List<員工加班紀錄列表>();
            try
            {
                using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    conn.Open();
                    string sql = @"SELECT
                                        CONVERT(varchar(10), m.日期, 111) AS 日期,
                                        m.班次,
                                        LEFT(CONVERT(varchar(8), m.加班上班, 108), 5) AS 加班上班,
                                        LEFT(CONVERT(varchar(8), m.加班下班, 108), 5) AS 加班下班,
                                        m.時數, m.加班事由,
                                        ROUND(m.加班分鐘數 / 60.0, 2) AS 加班時數,
                                        ROUND(mm.加班乘數分鐘 * ROUND(e.時薪 / 60.0, 2), 0) AS 加班費,
                                        e.時薪
                                    FROM (
                                        SELECT
                                            h.日期, h.班次, h.加班上班, h.加班下班, o.時數, o.加班事由,
                                            CASE WHEN DATEDIFF(MINUTE, h.加班上班, h.加班下班) > o.時數*60
                                                 THEN o.時數*60
                                                 ELSE CAST(DATEDIFF(MINUTE, h.加班上班, h.加班下班) AS float)
                                            END AS 加班分鐘數
                                        FROM H考勤紀錄 h
                                        INNER JOIN H核准加班明細 o
                                            ON o.員工編號 = h.員工編號 AND o.加班日期 = h.日期
                                        WHERE h.員工編號 = @員工編號
                                          AND h.加班上班 IS NOT NULL AND h.加班下班 IS NOT NULL
                                          AND h.日期 BETWEEN @開始日期 AND @結束日期
                                    ) m
                                    CROSS APPLY (
                                        SELECT CASE
                                            WHEN m.班次 = N'國定假日' THEN m.加班分鐘數 * 1.0
                                            WHEN m.加班分鐘數 > 480 THEN (m.加班分鐘數-480)*8.0/3 + 360*5.0/3 + 120*4.0/3
                                            WHEN m.加班分鐘數 > 120 THEN (m.加班分鐘數-120)*5.0/3 + 120*4.0/3
                                            ELSE m.加班分鐘數 * 4.0/3
                                        END AS 加班乘數分鐘
                                    ) mm
                                    INNER JOIN H員工基本資料 e ON e.工號 = @員工編號
                                    WHERE m.日期 >= e.核薪日 AND m.日期 <= e.離職日
                                    ORDER BY m.日期";
                    list = conn.Query<員工加班紀錄列表>(sql, new { 員工編號 = empNo, 開始日期 = startDate, 結束日期 = endDate }).ToList();
                }
            }
            catch (Exception)
            {

                throw;
            }
            return list;
        }

        // ══════════════════════════ 薪資月結(H-薪資月結) ══════════════════════════

        // ── 薪資月結總覽：僅表頭，供 ◄/► 切換 ─────────────────────────────
        public List<H員工月> getSalaryCloseList()
        {
            try
            {
                using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    conn.Open();
                    string sql = @"SELECT 識別, CONVERT(varchar(10), 月底日, 111) AS 月底日, 年月, 月結, 選取, 傳票,
                                          建檔, CONVERT(varchar(10), 建檔日, 111) AS 建檔日,
                                          修改, CONVERT(varchar(10), 修改日, 111) AS 修改日,
                                          核准, CONVERT(varchar(19), 核准日, 120) AS 核准日
                                   FROM H員工月
                                   ORDER BY 年月 DESC";
                    return conn.Query<H員工月>(sql).ToList();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        // ── 薪資月結單筆查詢：表頭+表身(員工月工時成本) ────────────────────
        public H員工月 getSalaryCloseByPeriod(string yearMonth)
        {
            try
            {
                using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    conn.Open();
                    string sql = @"SELECT 識別, CONVERT(varchar(10), 月底日, 111) AS 月底日, 年月, 月結, 選取, 傳票,
                                          建檔, CONVERT(varchar(10), 建檔日, 111) AS 建檔日,
                                          修改, CONVERT(varchar(10), 修改日, 111) AS 修改日,
                                          核准, CONVERT(varchar(19), 核准日, 120) AS 核准日
                                   FROM H員工月
                                   WHERE 年月=@年月";
                    var form = conn.Query<H員工月>(sql, new { 年月 = yearMonth }).FirstOrDefault();
                    if (form == null) return null;

                    string sql2 = @"SELECT 識別, 工號, 年月, 應領金額, 請假扣款, 遲到扣款, 出勤時數
                                     FROM H員工月工時成本
                                     WHERE 年月=@年月
                                     ORDER BY 工號";
                    form.detailList = conn.Query<H員工月工時成本>(sql2, new { 年月 = yearMonth }).ToList();
                    return form;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        // ── 薪資月結明細：交易內先刪除表身再重新寫入 ──────────────────────
        private void saveSalaryCloseDetail(SqlConnection conn, SqlTransaction tran, H員工月 form)
        {
            conn.Execute("DELETE FROM H員工月工時成本 WHERE 年月=@年月", new { 年月 = form.年月 }, tran);
            string insSql = @"INSERT INTO H員工月工時成本 (工號, 年月, 應領金額, 請假扣款, 遲到扣款, 出勤時數)
                               VALUES (@工號, @年月, @應領金額, @請假扣款, @遲到扣款, @出勤時數)";
            foreach (var d in form.detailList ?? new List<H員工月工時成本>())
            {
                d.年月 = form.年月;
                conn.Execute(insSql, d, tran);
            }
        }

        // ── 薪資月結新增/修改：依 年月 是否已存在判斷新增或更新，表身整批
        //    刪除重建(比照總務支出單慣例) ──────────────────────────────────
        public void saveSalaryClose(H員工月 form, bool isNew)
        {
            try
            {
                using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    conn.Open();
                    using (var tran = conn.BeginTransaction())
                    {
                        try
                        {
                            if (isNew)
                            {
                                string sql = @"INSERT INTO H員工月 (月底日, 年月, 建檔, 建檔日)
                                               VALUES (@月底日, @年月, @建檔, GETDATE())";
                                conn.Execute(sql, form, tran);
                            }
                            else
                            {
                                string sql = @"UPDATE H員工月 SET 月底日=@月底日, 修改=@修改, 修改日=GETDATE()
                                               WHERE 年月=@年月";
                                conn.Execute(sql, form, tran);
                            }
                            saveSalaryCloseDetail(conn, tran, form);
                            tran.Commit();
                        }
                        catch
                        {
                            tran.Rollback();
                            throw;
                        }
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        // ── 前一個月份是否已完成月結：以 年月(yyyy/MM)往前一個月比對
        //    (原巨集用 [年月]-1 做 Access 日期運算，此處改以西元年月直接減一
        //    個月比對，語意相同且不受文字格式影響) ──────────────────────────
        private bool isPreviousMonthClosed(SqlConnection conn, string yearMonth)
        {
            if (!DateTime.TryParse(yearMonth + "/01", out var d))
            {
                if (!DateTime.TryParseExact(yearMonth, "yyyy/MM", null, System.Globalization.DateTimeStyles.None, out d))
                    return true; // 年月格式無法解析時，不擋結帳
            }
            string prevMonth = d.AddMonths(-1).ToString("yyyy/MM");
            bool? closed = conn.Query<bool?>("SELECT 月結 FROM H員工月 WHERE 年月=@年月", new { 年月 = prevMonth }).FirstOrDefault();
            return closed == true;
        }

        // ── 結帳：需具編輯權限(原巨集另需符合「系統權限」核准，此處簡化為
        //    chkEditPrivilege)；已結帳、或前一個月尚未結帳皆擋下；結帳時自動
        //    轉出會計傳票(借:6111 薪資費用/貸:2191 應付薪資，金額為
        //    SUM(應領金額-請假扣款-遲到扣款))，比照原巨集「自轉傳票」+
        //    「傳票明細-薪資月結」/「傳票明細-薪資費用」查詢邏輯 ──────────────
        public string closeSalaryMonth(string yearMonth, string approver)
        {
            try
            {
                using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    conn.Open();
                    var current = conn.Query<H員工月>("SELECT * FROM H員工月 WHERE 年月=@年月", new { 年月 = yearMonth }).FirstOrDefault();
                    if (current == null) throw new Exception("查無此月結資料，請先儲存!");
                    if (current.月結 == true) throw new Exception("本月薪資已結帳，請確認您要結帳的月份！");
                    if (!isPreviousMonthClosed(conn, yearMonth)) throw new Exception("前一個月份尚未結帳，請查明！");

                    decimal amount = conn.Query<decimal?>(
                        "SELECT SUM(ISNULL(應領金額,0)-ISNULL(請假扣款,0)-ISNULL(遲到扣款,0)) FROM H員工月工時成本 WHERE 年月=@年月",
                        new { 年月 = yearMonth }).FirstOrDefault() ?? 0;

                    var voucherMiddle = new VoucherMiddle();
                    string voucherNo = current.傳票;
                    if (string.IsNullOrEmpty(voucherNo))
                    {
                        voucherNo = voucherMiddle.getFormNo();
                        var voucher = new F會計傳票
                        {
                            單號 = voucherNo,
                            日期 = DateTime.Now.ToString("yyyy-MM-dd"),
                            登錄人員 = approver,
                            狀態 = "登錄",
                            voucherList = new List<F會計傳票明細>
                            {
                                new F會計傳票明細 { 會科代碼 = "6111", 借方 = amount, 摘要 = yearMonth + "-員工薪資", 來源單據 = yearMonth + "-薪資月結單" },
                                new F會計傳票明細 { 會科代碼 = "2191", 貸方 = amount, 摘要 = yearMonth + "-員工薪資", 來源單據 = yearMonth + "-薪資月結單" },
                            },
                        };
                        voucherMiddle.createVoucher(voucher);
                    }
                    else
                    {
                        conn.Execute("UPDATE F會計傳票 SET 修改=@修改, 修改日=GETDATE() WHERE 單號=@單號",
                            new { 修改 = approver, 單號 = voucherNo });
                    }

                    conn.Execute(@"UPDATE H員工月 SET 核准=@核准, 核准日=GETDATE(), 月結=1, 傳票=@傳票 WHERE 年月=@年月",
                        new { 核准 = approver, 傳票 = voucherNo, 年月 = yearMonth });
                    return voucherNo;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        // ── 取消結帳：需具編輯權限；刪除自動產生的會計傳票(明細+單頭)，
        //    清空核准/核准日/月結/傳票 ─────────────────────────────────────
        public void reopenSalaryMonth(string yearMonth, string modifier)
        {
            try
            {
                using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    conn.Open();
                    var current = conn.Query<H員工月>("SELECT * FROM H員工月 WHERE 年月=@年月", new { 年月 = yearMonth }).FirstOrDefault();
                    if (current == null) throw new Exception("查無此月結資料!");

                    if (!string.IsNullOrEmpty(current.傳票))
                    {
                        conn.Execute("DELETE FROM F會計傳票明細 WHERE 單號=@單號", new { 單號 = current.傳票 });
                        conn.Execute("DELETE FROM F會計傳票 WHERE 單號=@單號", new { 單號 = current.傳票 });
                    }

                    conn.Execute(@"UPDATE H員工月 SET 核准=NULL, 核准日=NULL, 修改=@修改, 修改日=GETDATE(), 月結=0, 傳票=NULL
                                   WHERE 年月=@年月", new { 修改 = modifier, 年月 = yearMonth });
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        // ══════════════════════════ 成本單位(A-成本單位) ══════════════════════════

        // ── 成本單位單筆查詢：表頭+表身(成本單位人員配置，LEFT JOIN account
        //    取姓名) ──────────────────────────────────────────────────────
        public A成本單位 getCostUnitByPosition(string position)
        {
            try
            {
                using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    conn.Open();
                    var form = conn.Query<A成本單位>("SELECT * FROM A成本單位 WHERE 職務=@職務", new { 職務 = position }).FirstOrDefault();
                    if (form == null) return null;

                    string sql = @"SELECT s.識別碼, s.職務, s.員工編號, a.姓名 AS 員工姓名, a.姓名 AS 姓名,
                                          s.核准, s.編修, s.報表, s.輸出, s.註記, s.職務代理效期, s.機號
                                   FROM 成本單位人員配置 s
                                   LEFT JOIN account a ON a.帳號 = s.員工編號
                                   WHERE s.職務=@職務
                                   ORDER BY s.識別碼";
                    form.detailList = conn.Query<成本單位人員配置>(sql, new { 職務 = position }).ToList();
                    return form;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        // ── 成本單位新增/修改：以「職務」為業務鍵；新增前需檢查職務是否已存在，
        //    表身整批刪除重建 ────────────────────────────────────────────
        public void saveCostUnit(A成本單位 form, bool isNew)
        {
            try
            {
                using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    conn.Open();
                    if (isNew)
                    {
                        int exists = conn.Query<int>("SELECT COUNT(0) FROM A成本單位 WHERE 職務=@職務", new { 職務 = form.職務 }).First();
                        if (exists > 0) throw new Exception("職務「" + form.職務 + "」已存在，請重新輸入!");
                    }

                    using (var tran = conn.BeginTransaction())
                    {
                        try
                        {
                            if (isNew)
                            {
                                string sql = @"INSERT INTO A成本單位 (職務, 標準編制, 上一級單位, 上兩級單位, 標準工時成本, 實際工時成本, 操作功能)
                                               VALUES (@職務, @標準編制, @上一級單位, @上兩級單位, @標準工時成本, @實際工時成本, @操作功能)";
                                conn.Execute(sql, form, tran);
                            }
                            else
                            {
                                string sql = @"UPDATE A成本單位 SET 標準編制=@標準編制, 上一級單位=@上一級單位, 上兩級單位=@上兩級單位,
                                               標準工時成本=@標準工時成本, 實際工時成本=@實際工時成本, 操作功能=@操作功能
                                               WHERE 職務=@職務";
                                conn.Execute(sql, form, tran);
                            }

                            conn.Execute("DELETE FROM 成本單位人員配置 WHERE 職務=@職務", new { 職務 = form.職務 }, tran);
                            string insSql = @"INSERT INTO 成本單位人員配置 (職務, 員工編號, 核准, 編修, 報表, 輸出, 註記, 職務代理效期, 機號)
                                               VALUES (@職務, @員工編號, @核准, @編修, @報表, @輸出, @註記, @職務代理效期, @機號)";
                            foreach (var s in form.detailList ?? new List<成本單位人員配置>())
                            {
                                s.職務 = form.職務;
                                conn.Execute(insSql, s, tran);
                            }
                            tran.Commit();
                        }
                        catch
                        {
                            tran.Rollback();
                            throw;
                        }
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        // ── 新增職務(僅寫入 A成本單位.職務，不動 成本單位人員配置)：供
        //    「職務工作類別」畫面的新增職務按鈕使用，避免影響「成本單位」
        //    畫面管理的人員配置資料 ──────────────────────────────────────
        public void createCostUnitPosition(string position)
        {
            try
            {
                using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    conn.Open();
                    int exists = conn.Query<int>("SELECT COUNT(0) FROM A成本單位 WHERE 職務=@職務", new { 職務 = position }).First();
                    if (exists > 0) throw new Exception("職務「" + position + "」已存在，請重新輸入!");
                    conn.Execute("INSERT INTO A成本單位 (職務) VALUES (@職務)", new { 職務 = position });
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        // ── 職務工作分類點數：整批刪除重建(比照全站慣例) ────────────────────
        public void savePositionWorkCategoryList(string position, List<H職務工作分類> list)
        {
            try
            {
                using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    conn.Open();
                    using (var tran = conn.BeginTransaction())
                    {
                        try
                        {
                            conn.Execute("DELETE FROM H職務工作分類 WHERE 職務=@職務", new { 職務 = position }, tran);
                            string insSql = @"INSERT INTO H職務工作分類 (職務, 代碼, 分類, 積分點數, 說明)
                                               VALUES (@職務, @代碼, @分類, @積分點數, @說明)";
                            foreach (var x in list ?? new List<H職務工作分類>())
                            {
                                x.職務 = position;
                                conn.Execute(insSql, x, tran);
                            }
                            tran.Commit();
                        }
                        catch
                        {
                            tran.Rollback();
                            throw;
                        }
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        // ── 人工成本重整：比照原巨集「更新單價-人工」+「H人工成本單價導入」
        //    查詢邏輯，將該年月每位員工算出的工時成本((應領金額-請假扣款-
        //    遲到扣款)/出勤時數)寫回 工作紀錄A.單價，供各專案工作紀錄計算
        //    實際人工成本使用；原巨集以 Format$([工作日期],'yyyymm') 比對，
        //    此處改用日期區間比對，效果相同且效能較佳 ─────────────────────
        public string recalcLaborCost(string yearMonth)
        {
            try
            {
                using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    conn.Open();
                    var list = conn.Query<H員工月工時成本>(
                        "SELECT * FROM H員工月工時成本 WHERE 年月=@年月", new { 年月 = yearMonth }).ToList();

                    if (!DateTime.TryParseExact(yearMonth, "yyyy/MM", null, System.Globalization.DateTimeStyles.None, out var monthStart))
                        throw new Exception("年月格式錯誤!");
                    var monthEnd = monthStart.AddMonths(1);

                    int updated = 0;
                    foreach (var x in list)
                    {
                        if (string.IsNullOrEmpty(x.工號) || !x.出勤時數.HasValue || x.出勤時數 == 0) continue;
                        double cost = Math.Round(((x.應領金額 ?? 0) - (x.請假扣款 ?? 0) - (x.遲到扣款 ?? 0)) / x.出勤時數.Value, 2);
                        updated += conn.Execute(
                            @"UPDATE 工作紀錄A SET 單價=@單價 WHERE 員工編號=@員工編號 AND 工作日期>=@起 AND 工作日期<@迄",
                            new { 單價 = cost, 員工編號 = x.工號, 起 = monthStart, 迄 = monthEnd });
                    }
                    return $"成本重整計算完成，共更新 {updated} 筆工作紀錄!";
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        // ── 加班申請明細查詢：比照原巨集查詢「加班申請明細查詢」(H加班申請單
        //    LEFT JOIN H核准加班明細 ON 單據編號)，一張申請單可展開為多列；
        //    原查詢以 DLookUp("姓名","dbo_EMPL",...) 帶出姓名，dbo_EMPL 在
        //    CHINYO 並不存在，改以 H員工清冊 LEFT JOIN 取得 ──────────────────
        public List<加班申請明細查詢> getOvertimeApplyDetailQuery()
        {
            List<加班申請明細查詢> list = new List<加班申請明細查詢>();
            try
            {
                using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    conn.Open();
                    string sql = @"SELECT
                                        a.單據編號, a.申請單位, a.申請人,
                                        b.員工編號, e.姓名,
                                        CONVERT(varchar(10), b.加班日期, 111) AS 加班日期,
                                        LEFT(CONVERT(varchar(8), b.起, 108), 5) AS 起,
                                        LEFT(CONVERT(varchar(8), b.訖, 108), 5) AS 訖,
                                        b.時數, b.加班事由,
                                        a.核准生效, a.核准人
                                   FROM H加班申請單 a
                                   LEFT JOIN H核准加班明細 b ON a.單據編號 = b.單據編號
                                   LEFT JOIN H員工清冊 e ON e.工號 = b.員工編號
                                   ORDER BY a.單據編號 DESC";
                    list = conn.Query<加班申請明細查詢>(sql).ToList();
                }
            }
            catch (Exception)
            {

                throw;
            }
            return list;
        }
    }
}
