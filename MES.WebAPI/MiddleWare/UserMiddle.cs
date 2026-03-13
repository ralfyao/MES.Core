
using Dapper;
using MES.Core.Model;
using MES.Core.Repository;
using Microsoft.AspNetCore.SignalR;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlClient;

namespace MES.WebAPI.MiddleWare
{
    public class UserMiddle
    {
        public int UpdatePassword(string? account, string? password)
        {
            int retCode = 0;
            try
            {
                using(var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    conn.Open();
                    string strSQL = $@"UPDATE Authenticate SET Password=@Password WHERE Account=@Account";
                    Authenticate authenticate = new Authenticate();
                    authenticate.Account = account;
                    authenticate.Password = password;
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
        public List<MenuSub> GetMenuFuncByAccount(string? account)
        {
            List<MenuSub> menuSubs = new List<MenuSub>();
            try
            {
                using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    conn.Open();
                    string strSQL = $@" SELECT DISTINCT A.ID, f.MenuID, e.MenuName,f.MenuSubID, f.MenuSubName, f.MenuSubUrl
		                                        , ISNULL(A2.高管, 0) 高管
		                                        , ISNULL(A2.核准, 0) 核准
		                                        , ISNULL(A2.編修, 0) 編修
		                                        , ISNULL(A2.報表, 0) 報表
		                                        , ISNULL(A2.輸出, 0) 輸出
		                                        , ISNULL(A2.註記, '') 註記
		                                        , ISNULL(A2.查詢, '') 查詢
		                                        , ISNULL(A2.職務代理效期, '') 職務代理效期
		                                        , ISNULL(A2.機號, '') 機號
                                                , 0 showDatePopup
                                          FROM dbo.Authenticate AS A
                                          LEFT OUTER JOIN AuthenticatePrivilege b ON a.Privilege=b.AuthenticatePrivilegeName
                                          LEFT OUTER JOIN Privilege c ON b.PrivilegeNameMapped=c.PrivilegeName
                                          LEFT OUTER JOIN PrivilegeMenu d ON c.PrivilegeName=d.PrivilegeName
                                          LEFT OUTER JOIN dbo.Menu AS e ON d.MenuID=e.MenuID
                                          LEFT OUTER JOIN dbo.MenuSub AS f ON e.MenuID=f.MenuID AND d.MenuSubID=f.MenuSubID
                                          LEFT OUTER JOIN dbo.A使用者授權 AS A2 ON CONVERT(VARCHAR,A.ID)=A2.員工編號 AND f.MenuID=A2.授權表單 AND f.MenuSubID=A2.授權子表單
                                         WHERE 1=1";
                    if (!string.IsNullOrEmpty(account))
                    {
                        strSQL += $@" AND A.Account='{account}'";
                    }
                    strSQL += " AND f.MenuSubID IS NOT NULL ORDER BY f.MenuSubID ";
                    menuSubs = conn.Query<MenuSub>(strSQL).ToList();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return menuSubs;
        }
        public List<string> GetPositionList()
        {
            List<string> list = new List<string>();
            try
            {
                using(var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    conn.Open();
                    string sql = $@"SELECT DISTINCT 職務 FROM H職務工作分類";
                    list = conn.Query<string>(sql).ToList();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return list;
        }

        public int updateUserAuth(List<MenuSub> menuSubs)
        {
            int execCnt = 0;
            try
            {
                using(var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    conn.Open();
                    using(var tran = conn.BeginTransaction())
                    {
                        DynamicParameters dynamicParameters = new DynamicParameters(menuSubs[0]);
                        conn.Execute($@"DELETE FROM A使用者授權 WHERE 員工編號=CONVERT(VARCHAR,@ID)", dynamicParameters, tran);
                        foreach (var sub in menuSubs)
                        {
                            string strSQL = $@"  INSERT INTO dbo.A使用者授權
                                                 (
                                                     員工編號,
                                                     職務,
                                                     高管,
                                                     核准,
                                                     編修,
                                                     報表,
                                                     輸出,
                                                     查詢,
                                                     註記,
                                                     職務代理效期,
                                                     機號,
                                                     授權表單,
                                                     授權子表單
                                                 )
                                                 VALUES
                                                 (   
                                                     @ID,
                                                     @職務,
                                                     @高管,
                                                     @核准,
                                                     @編修,
                                                     @報表,
                                                     @輸出,
                                                     @查詢,
                                                     @註記,
                                                     @職務代理效期,
                                                     @機號,
                                                     @MenuID,
                                                     @MenuSubID
                                                     )";  
                            dynamicParameters = new DynamicParameters(sub);
                            execCnt += conn.Execute(strSQL, dynamicParameters, tran);
                        }
                        tran.Commit();
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return execCnt;
        }

        internal int doValidateShipOrder(string? formNo, bool? validate, string? account)
        {
            int execCnt = 0;    
            try
            {
                using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    conn.Open();
                    
                    string strSQL = $@"UPDATE C出貨單 SET 核准='{((bool)validate ? account : "")}', 核准日={((bool)validate ? "GETDATE()" : "NULL")}
                                        WHERE 單號='{formNo}'";
                    execCnt += conn.Execute(strSQL);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return execCnt;
        }

        public int doValidateSalesOrder(string? formNo, bool? valid, string? account)
        {
            int execCnt = 0;
            try
            {
                using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    conn.Open();
                    string strSQL = $@"UPDATE C訂單 SET 核准='{((bool)valid ? account : "")}', 核准日={((bool)valid ? "GETDATE()" : "NULL")}
                                        WHERE 單號='{formNo}'";
                    execCnt += conn.Execute(strSQL);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return execCnt;
        }

        internal int doValidateQuotation(string? formNo, bool? valid, string? account)
        {
            int execCnt = 0;
            try
            {
                using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    conn.Open();
                    string strSQL = $@"UPDATE C報價單 SET 核准='{((bool)valid ? account : "")}', 核准日={((bool)valid ? "GETDATE()" : "NULL")}
                                        WHERE QUONO='{formNo}'";
                    execCnt += conn.Execute(strSQL);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return execCnt;
        }

        public int doValidateRepairForm(string? formNo, bool? valid, string? account)
        {
            int execCnt = 0;
            try
            {
                string sql = $@"UPDATE 維修服務單 SET 核准='{((bool)valid?account:"")}', 核准日={((bool)valid ? "GETDATE()" : "NULL")} WHERE 單號='{formNo}'";
                using(var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    conn.Open();
                    execCnt += conn.Execute(sql);
                }
            }
            catch (Exception)
            {

                throw;
            }
            return execCnt;
        }
    }
}
