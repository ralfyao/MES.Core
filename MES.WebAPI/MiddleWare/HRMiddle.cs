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
    }
}
