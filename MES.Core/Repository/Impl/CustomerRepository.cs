using Dapper;
using MES.Core.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
        public List<C產業代碼> getIndustryCode()
        {
            List<C產業代碼> l = new List<C產業代碼>();
            try
            {
                using (SqlConnection conn = new SqlConnection(IRepository<C產業代碼>.ConnStr))
                {
                    conn.Open();
                    SqlCommand sqlCommand = conn.CreateCommand();
                    string strSQL = "SELECT * FROM C產業代碼 ";
                    var result = conn.Query<C產業代碼>(strSQL);
                    l = result.ToList();
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
                                                       ,[修改日]) VALUES (
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
                                                       ,@修改日)";
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
