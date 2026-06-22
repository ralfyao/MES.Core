using Dapper;
using MES.Core.Model;
using MES.Core.Repository;
using System.Data.SqlClient;

namespace MES.WebAPI.Controllers
{
    internal class ProductionMiddle
    {
        public ProductionMiddle()
        {
        }

        public List<工令單> getWorkOrdersByCustId(string custId)
        {
            List<工令單> list = new List<工令單>();
            try
            {
                using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    conn.Open();
                    string strSql = $@"SELECT dbo_工令單.專案序號, dbo_工令單.機台型號, dbo_工令單.機台名稱, dbo_工令單.客戶簡稱 
                                    FROM 工令單 dbo_工令單 
                                    WHERE dbo_工令單.客戶簡稱='{custId}'";
                    list = conn.Query<工令單>(strSql).ToList();
                }
            }
            catch (Exception)
            {

                throw;
            }
            return list;
            //throw new NotImplementedException();
        }

        internal List<string> getKeyword(string kyType)
        {
            string strSQL = $@"SELECT dbo_D查修關鍵字.Keyword FROM C查修關鍵字 dbo_D查修關鍵字 WHERE dbo_D查修關鍵字.分類='{kyType}' ";
            List<string> list = new List<string>();
            try
            {
                using(var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    conn.Open();
                    list = conn.Query<string>(strSQL).ToList();
                }
            }
            catch (Exception)
            {

                throw;
            }
            return list;
        }

        internal List<string> getKeywordDetail(string kyType)
        {
            string strSQL = $@"SELECT 查修關鍵次分類查詢.類別 FROM C查修關鍵次分類 查修關鍵次分類查詢 ";
            List<string> list = new List<string>();
            try
            {
                using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    conn.Open();
                    list = conn.Query<string>(strSQL).ToList();
                }
            }
            catch (Exception)
            {

                throw;
            }
            return list;
        }

        internal List<string> getKeywordDetailByCategory(string category)
        {
            List<string> list = new List<string>();
            try
            {
                using(var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    conn.Open();
                    string strSQL = $@"SELECT 類別 FROM C查修關鍵次分類 WHERE Keyword='{category}'";
                    list = conn.Query<string>(strSQL).ToList();
                }
            }
            catch (Exception)
            {

                throw;
            }
            return list;
            //throw new NotImplementedException();
        }

        internal List<專案機台交貨單> getProjectShippingOrderBySerial(string projectSerial)
        {
            List<專案機台交貨單> list = new List<專案機台交貨單>();
            try
            {
                string strSQL = $@"SELECT [識別碼]
                                          ,[單號]
                                          ,[日期]
                                          ,[專案序號]
                                          ,[單據地址]
                                          ,[交貨地址]
                                          ,[聯絡人]
                                          ,[電話]
                                          ,[訂購單號]
                                          ,[發票單號]
                                          ,[Container]
                                          ,[ContainerType]
                                          ,[ContainerPort]
                                          ,[DeliveryTeam]
                                          ,[Insurance]
                                          ,[DestinationPort]
                                          ,[Packing]
                                          ,[ETD]
                                          ,[ETA]
                                          ,[Arrival]
                                          ,[CustomsClose]
                                          ,[TypesOfBL]
                                          ,[Forwarder]
                                          ,[CertOfOrigin]
                                          ,[SurrenderBL]
                                          ,[CaseNo]
                                          ,[Total]
                                          ,[建檔]
                                          ,[修改]
                                          ,[核准]
                                          ,[建檔日]
                                          ,[修改日]
                                          ,[核准日]
                                          ,[Doc]
                                          ,[Trade]
                                          ,[Mark]
                                          ,[Ship]
                                          ,[Voyage]
                                     FROM [CHINYO].[dbo].[專案機台交貨單] WHERE 專案序號='{projectSerial}' ";
                using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    conn.Open();
                    list = conn.Query<專案機台交貨單>(strSQL).ToList();
                }
            }
            catch (Exception)
            {

                throw;
            }
            return list;
            //throw new NotImplementedException();
        }
    }
}