using Dapper;
using MES.Core.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MES.Core.Repository.Impl
{
    public class CustomerRepository : AbstractRepository<C客戶設定>
    {
        /// <summary>
        /// 取得銀行下拉列表資料來源
        /// </summary>
        /// <returns></returns>
        public List<F銀行設定> getBankCodeList()
        {
            List<F銀行設定> list = new List<F銀行設定>();
            try
            {
                using (SqlConnection conn = new SqlConnection(IRepository<F銀行設定>.ConnStr))
                {
                    conn.Open();
                    SqlCommand sqlCommand = conn.CreateCommand();
                    string strSQL = "SELECT * FROM F銀行設定 ";
                    var result = conn.Query<F銀行設定>(strSQL);
                    list = result.ToList();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return list;
        }
        /// <summary>
        /// 依月底日(yyyyMM)取得各銀行帳戶當月存入/支出總計與餘額
        /// </summary>
        public List<銀行月底餘額> getBankMonthSummaryList(string monthEnd)
        {
            List<銀行月底餘額> list = new List<銀行月底餘額>();
            try
            {
                using (SqlConnection conn = new SqlConnection(IRepository<F銀行設定>.ConnStr))
                {
                    conn.Open();
                    string strSQL = @"
SELECT DISTINCT dbo_F銀行明細.銀存編碼
, LEFT(CONVERT(VARCHAR, dbo_F銀行明細.[日期], 112),6) AS [日期_月]
, Sum(ISNULL([存入],0)) AS 存入總計
, Sum(ISNULL([支出],0)) AS 支出總計
, Count(*) AS 筆數, Sum(ISNULL([存入],0))-Sum(ISNULL([支出],0)) AS 餘額, dbo_F銀行設定.銀行名稱, dbo_F銀行設定.帳號, dbo_F銀行明細.幣別
FROM F銀行明細 dbo_F銀行明細
RIGHT JOIN F銀行設定 dbo_F銀行設定 ON dbo_F銀行明細.銀存編碼 = dbo_F銀行設定.銀存編碼
GROUP BY dbo_F銀行明細.銀存編碼
      , LEFT(CONVERT(VARCHAR, dbo_F銀行明細.[日期], 112),6)
      , dbo_F銀行設定.銀行名稱
      , dbo_F銀行設定.帳號
      , dbo_F銀行明細.幣別, Year([dbo_F銀行明細].[日期])*12+DatePart(MONTH,[dbo_F銀行明細].[日期])-1
HAVING (((LEFT(CONVERT(VARCHAR, dbo_F銀行明細.[日期], 112),6))=@monthEnd))";
                    list = conn.Query<銀行月底餘額>(strSQL, new { monthEnd }).ToList();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return list;
        }
        /// <summary>
        /// 月結確定：將指定月底日各銀行帳戶之餘額，以「月結餘額」摘要寫入下個月第一筆存入
        /// </summary>
        public int confirmBankMonthEnd(string monthEnd)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(IRepository<F銀行設定>.ConnStr))
                {
                    conn.Open();
                    string strSQL = @"
INSERT INTO F銀行明細 ( 銀存編碼, 存入, 摘要, 幣別, 日期 )
SELECT DISTINCT dbo_F銀行明細.銀存編碼
       , Sum(
			CASE WHEN [存入] IS NULL THEN 0 ELSE [存入] end
		)-Sum(
			CASE WHEN 支出 IS NULL THEN 0 ELSE 支出 end
		) AS 餘額
	   , '月結餘額' AS Expr1
       , dbo_F銀行明細.幣別
	   ,CONVERT(VARCHAR, DATEADD(MONTH,1, CONVERT(DATETIME,@monthEnd+'01',112)),112) AS Expr2
FROM F銀行明細 dbo_F銀行明細
WHERE (((LEFT(CONVERT(VARCHAR, dbo_F銀行明細.[日期], 112) ,6))=@monthEnd))
GROUP BY dbo_F銀行明細.銀存編碼
		 , dbo_F銀行明細.幣別";
                    return conn.Execute(strSQL, new { monthEnd });
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// 依銀存編碼取得銀行存簿明細
        /// </summary>
        public List<F銀行明細> getBankLedgerList(string bankCode)
        {
            List<F銀行明細> list = new List<F銀行明細>();
            try
            {
                using (SqlConnection conn = new SqlConnection(IRepository<F銀行設定>.ConnStr))
                {
                    conn.Open();
                    string strSQL = "SELECT * FROM F銀行明細 WHERE 銀存編碼=@bankCode ORDER BY 日期";
                    list = conn.Query<F銀行明細>(strSQL, new { bankCode }).ToList();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return list;
        }
        /// <summary>
        /// 新增或更新銀行設定（依銀存編碼先刪除再新增）
        /// </summary>
        public int saveBankInfo(F銀行設定 form)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(IRepository<F銀行設定>.ConnStr))
                {
                    conn.Open();
                    string strSQL = @"DELETE FROM F銀行設定 WHERE 銀存編碼=@銀存編碼;
                                       INSERT INTO F銀行設定 (銀存編碼, 銀行名稱, Bankname, Beneficiary, 帳號, 銀行地址, SwiftCode, 電話, 聯絡窗口, 分機, 會科代碼)
                                       VALUES (@銀存編碼, @銀行名稱, @Bankname, @Beneficiary, @帳號, @銀行地址, @SwiftCode, @電話, @聯絡窗口, @分機, @會科代碼)";
                    return conn.Execute(strSQL, form);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// 取得國別下拉列表資料來源
        /// </summary>
        /// <returns></returns>
        public List<C客戶國別> GetCountryList()
        {
            List<C客戶國別> list = new List<C客戶國別>();
            try
            {
                using (SqlConnection conn = new SqlConnection(IRepository<C客戶設定>.ConnStr))
                {
                    conn.Open();
                    SqlCommand sqlCommand = conn.CreateCommand();
                    string strSQL = "SELECT * FROM C客戶國別 ";
                    var result = conn.Query<C客戶國別>(strSQL);
                    list = result.ToList();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return list;
        }
        /// <summary>
        /// 取得產業別下拉列表資料來源
        /// </summary>
        /// <returns></returns>
        public List<C產業代碼> getIndustryCode(string code = "")
        {
            List<C產業代碼> l = new List<C產業代碼>();
            try
            {
                using (SqlConnection conn = new SqlConnection(IRepository<C產業代碼>.ConnStr))
                {
                    conn.Open();
                    SqlCommand sqlCommand = conn.CreateCommand();
                    string strSQL = "SELECT * FROM C產業代碼 WHERE 1=1 ";
                    if (!string.IsNullOrEmpty(code))
                    {
                        strSQL += $" AND RTRIM(中分類碼)='{code.Trim()}'";
                    }
                    var result = conn.Query<C產業代碼>(strSQL);
                    l = result.ToList();
                    l.ForEach((x) =>
                    {
                        x.中分類碼 = x.中分類碼.Trim();
                    });
                }
            }
            catch (Exception ex)
            {

                throw;
            }
            return l;
        }
        /// <summary>
        /// 寫入客戶資料
        /// </summary>
        /// <returns></returns>
        public override int Insert(C客戶設定 t)
        {
            
            using(SqlConnection conn = new SqlConnection(IRepository<C客戶設定>.ConnStr))
            {
                conn.Open();
                SqlTransaction tran = conn.BeginTransaction();
                string sql = $@"INSERT INTO [dbo].[C客戶設定]
                                                       ([COMPANY]
                                                       ,[MA]
                                                       ,[TEL]
                                                       ,[FAX]
                                                       ,[CONTACTPERSON]
                                                       ,[POSITION]
                                                       ,[EMAIL]
                                                       ,[COUNTRY]
                                                       ,[INDUSTRYCODE]
                                                       ,[INDUSTRY]
                                                       ,[MACHINEISSUE]
                                                       ,[正航編號]
                                                       ,[SOURCE]
                                                       ,[RANKING]
                                                       ,[CREDIBILITY]
                                                       ,[WEBSITE]
                                                       ,[MEMO]
                                                       ,[CREDATE]
                                                       ,[ZIPCODE]
                                                       ,[ADDRESS]
                                                       ,[DADDRESS]
                                                       ,[欄位1]
                                                       ,[欄位2]
                                                       ,[MODIFYDATE]
                                                       ,[建檔]
                                                       ,[修改]
                                                       ,[建檔日]
                                                       ,[修改日]
                                                       ,[啟用日]) VALUES (
                                                        @COMPANY
                                                       ,@MA
                                                       ,@TEL
                                                       ,@FAX
                                                       ,@CONTACTPERSON
                                                       ,@POSITION
                                                       ,@EMAIL
                                                       ,@COUNTRY
                                                       ,@INDUSTRYCODE
                                                       ,@INDUSTRY
                                                       ,@MACHINEISSUE
                                                       ,@正航編號
                                                       ,@SOURCE
                                                       ,@RANKING
                                                       ,@CREDIBILITY
                                                       ,@WEBSITE
                                                       ,@MEMO
                                                       ,getdate()
                                                       ,@ZIPCODE
                                                       ,@ADDRESS
                                                       ,@DADDRESS
                                                       ,@欄位1
                                                       ,@欄位2
                                                       ,@MODIFYDATE
                                                       ,@建檔
                                                       ,@修改
                                                       ,getdate()
                                                       ,@修改日,getdate())";
                try
                {
                    DynamicParameters dynamicParameters = new DynamicParameters(t);
                    conn.Execute(sql, dynamicParameters, tran);
                    // C客戶聯絡明細
                    foreach (var data in t.contactLists)
                    {
                        if (string.IsNullOrEmpty(data.COMPANY))
                        {
                            data.COMPANY = t.COMPANY;
                        }
                        data.姓名 = data.姓名 == null ? "" : data.姓名;
                        data.職稱 = data.職稱 == null ? "" : data.職稱;
                        data.電話 = data.電話 == null ? "" : data.電話;
                        data.EMAIL = data.EMAIL == null ? "" : data.EMAIL;
                        sql = @"INSERT INTO dbo.C客戶連絡人清單
                                                (
                                                    COMPANY,
                                                    姓名,
                                                    職稱,
                                                    電話,
                                                    分機,
                                                    EMAIL
                                                )
                                                VALUES
                                                (   
                                                     @COMPANY,
                                                     @姓名,
                                                     @職稱,
                                                     @電話,
                                                     @分機,
                                                     @EMAIL
                                                    )";
                        dynamicParameters = new DynamicParameters(data);
                        conn.Execute(sql, dynamicParameters, tran);
                    }
                    foreach(var data in t.contactDetails)
                    {
                        if (string.IsNullOrEmpty(data.COMPANY))
                        {
                            data.COMPANY = t.COMPANY;
                        }

                        data.日期 = DateTime.ParseExact(data.日期.Replace("/", "-"), "dd-MM-yyyy", CultureInfo.InvariantCulture).ToString("yyyy-MM-dd");
                        sql = @"INSERT INTO C客戶聯絡明細
                                            (
                                                COMPANY,
                                                日期,
                                                註記,
                                                業務人員,
                                                RFQNO
                                            )
                                            VALUES 
                                            (
                                                @COMPANY,
                                                @日期,
                                                @註記,
                                                @業務人員,
                                                @RFQNO
                                            )";
                        dynamicParameters = new DynamicParameters(data);
                        conn.Execute(sql, dynamicParameters, tran);
                    }
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    throw ex;
                }
                tran.Commit();
            }
            return 0;
        }
        /// <summary>
        /// 更新客戶資料
        /// </summary>
        /// <returns></returns>
        public override int Update(C客戶設定 t)
        {
            string strSQL = $@"UPDATE dbo.C客戶設定
                                SET 
                                [COMPANY]           =   @COMPANY
                                ,[MA]				=   @MA
                                ,[TEL]				=	@TEL
                                ,[FAX]				=	@FAX
                                ,[CONTACTPERSON]		=	@CONTACTPERSON
                                ,[POSITION]			=	@POSITION
                                ,[EMAIL]				=	@EMAIL
                                ,[COUNTRY]			=	@COUNTRY
                                ,[INDUSTRYCODE]		=	@INDUSTRYCODE
                                ,[INDUSTRY]			=	@INDUSTRY
                                ,[MACHINEISSUE]		=	@MACHINEISSUE
                                ,[正航編號]			 =	@正航編號
                                ,[SOURCE]			=	@SOURCE
                                ,[RANKING]			=	@RANKING
                                ,[CREDIBILITY]		=	@CREDIBILITY
                                ,[WEBSITE]			=	@WEBSITE
                                ,[MEMO]				=	@MEMO
                                ,[CREDATE]			=	@CREDATE
                                ,[ZIPCODE]			=	@ZIPCODE
                                ,[ADDRESS]			=	@ADDRESS
                                ,[DADDRESS]			=	@DADDRESS
                                ,[欄位1]			   =	@欄位1
                                ,[欄位2]			   =	@欄位2
                                ,[MODIFYDATE]		=	@MODIFYDATE
                                ,[修改]			   =	@修改
                                ,[修改日]			  =		GETDATE()
                                ,[啟用日]			  =		@啟用日
                                WHERE 識別=@識別";
            try
            {
                using (SqlConnection conn = new SqlConnection(IRepository<C客戶設定>.ConnStr))
                {
                    conn.Open();
                    SqlTransaction transaction = conn.BeginTransaction();
                    DynamicParameters dynamicParameters = new DynamicParameters(t);
                    conn.Execute(strSQL, dynamicParameters, transaction);
                    conn.Execute("DELETE FROM C客戶連絡人清單 WHERE COMPANY=@COMPANY", dynamicParameters, transaction);
                    conn.Execute("DELETE FROM C客戶聯絡明細 WHERE COMPANY=@COMPANY", dynamicParameters, transaction);
                    foreach(var data in t.contactLists)
                    {
                        if (string.IsNullOrEmpty(data.COMPANY))
                        {
                            data.COMPANY = t.COMPANY;
                        }
                        strSQL = @"INSERT INTO dbo.C客戶連絡人清單
                                                (
                                                    COMPANY,
                                                    姓名,
                                                    職稱,
                                                    電話,
                                                    分機,
                                                    EMAIL
                                                )
                                                VALUES
                                                (   
                                                     @COMPANY,
                                                     @姓名,
                                                     @職稱,
                                                     @電話,
                                                     @分機,
                                                     @EMAIL
                                                    )";
                        dynamicParameters = new DynamicParameters(data);
                        conn.Execute(strSQL, dynamicParameters, transaction);
                    }
                    foreach (var data in t.contactDetails)
                    {
                        if (string.IsNullOrEmpty(data.COMPANY))
                        {
                            data.COMPANY = t.COMPANY;
                        }
                        strSQL = @"INSERT INTO C客戶聯絡明細
                                            (
                                                COMPANY,
                                                日期,
                                                註記,
                                                業務人員,
                                                RFQNO
                                            )
                                            VALUES 
                                            (
                                                @COMPANY,
                                                @日期,
                                                @註記,
                                                @業務人員,
                                                @RFQNO
                                            )";
                        dynamicParameters = new DynamicParameters(data);
                        conn.Execute(strSQL, dynamicParameters, transaction);
                    }
                    transaction.Commit();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return 0;
        }
        public int Delete(C客戶設定 t)
        {
            int retCode = 0;
            try
            {
                string strSQL = @"DECLARE @C_Company VARCHAR(255); 
                                   SELECT @C_Company = COMPANY FROM C客戶設定 WHERE 識別=@識別; 
                                   BEGIN TRAN;
                                   DELETE FROM C客戶連絡人清單 WHERE COMPANY=@C_Company
                                   DELETE FROM C客戶聯絡明細 WHERE COMPANY=@C_Company
                                   DELETE FROM C客戶設定 WHERE 識別=@識別
                                   COMMIT TRAN";
                using (SqlConnection conn = new SqlConnection(IRepository<C客戶設定>.ConnStr))
                {
                    conn.Open();
                    DynamicParameters dynamicParameters = new DynamicParameters(t);
                    conn.Execute(strSQL, dynamicParameters);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return retCode;
        }

        public List<C客戶連絡人清單> getCustomerContactList(string company)
        {
            try
            {
                CustomerContactRepository customerContactRepository = new CustomerContactRepository();
                C客戶連絡人清單 obj = new C客戶連絡人清單();
                obj.COMPANY = company;
                return customerContactRepository.GetListBy(obj, "COMPANY");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<C客戶聯絡明細> getCustomerDetails(string company)
        {
            try
            {
                ContactDetailRepository customerContactRepository = new ContactDetailRepository();
                HumanResourceRepository humanResourceRepository = new HumanResourceRepository();
                C客戶聯絡明細 obj = new C客戶聯絡明細();
                obj.COMPANY = company;
                List<C客戶聯絡明細> cs = customerContactRepository.GetListBy(obj, "COMPANY");
                cs.ForEach((x) =>
                {
                    H員工清冊 aData = new H員工清冊();
                    aData.工號 = x.業務人員;
                    List<H員工清冊> aDataList = humanResourceRepository.GetListBy(aData, "工號").ToList();
                    if (aDataList.Count() > 0)
                        x.業務人員姓名 = aDataList.FirstOrDefault()?.姓名;
                });
                return cs;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int setCustomerExpiry(C客戶設定 t)
        {
            int retCode = 0;
            try
            {
                string strSQL = @"UPDATE C客戶設定 SET 停用日=@停用日 WHERE 識別=@識別";
                using (SqlConnection conn = new SqlConnection(IRepository<C客戶設定>.ConnStr))
                {
                    conn.Open();
                    DynamicParameters dynamicParameters = new DynamicParameters(t);
                    conn.Execute(strSQL, dynamicParameters);
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
