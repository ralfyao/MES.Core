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
    }
}
