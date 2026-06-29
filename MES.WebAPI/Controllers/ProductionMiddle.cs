using Dapper;
using MES.Core.Model;
using MES.Core.Repository;
using System.Collections.Generic;
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

        internal List<C機台客服> getEqpServiceListByProjSerial(string? 專案序號)
        {
            List<C機台客服> list = new List<C機台客服>();
            try
            {
                string strSQL = $@"SELECT * FROM C機台客服 WHERE 專案序號 = '{專案序號}'";
                using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    conn.Open();
                    list = conn.Query<C機台客服>(strSQL).ToList();
                    foreach (var item in list)
                    {
                        item.detailList = conn.Query<C機台客服明細>($@"SELECT * FROM C機台客服明細 WHERE 單號='{item.單號}'").ToList();
                    }
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

        internal List<專案機台交貨單> getAllProjectShippingOrders()
        {
            List<專案機台交貨單> list = new List<專案機台交貨單>();
            try
            {
                string strSQL = @"SELECT [識別碼],[單號],[日期],[專案序號],[單據地址],[交貨地址],[聯絡人],[電話],
                                         [訂購單號],[發票單號],[Container],[ContainerType],[ContainerPort],
                                         [DeliveryTeam],[Insurance],[DestinationPort],[Packing],[ETD],[ETA],
                                         [Arrival],[CustomsClose],[TypesOfBL],[Forwarder],[CertOfOrigin],
                                         [SurrenderBL],[CaseNo],[Total],[建檔],[修改],[核准],[建檔日],[修改日],
                                         [核准日],[Doc],[Trade],[Mark],[Ship],[Voyage]
                                    FROM [CHINYO].[dbo].[專案機台交貨單]
                                   ORDER BY 日期 DESC";
                using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    conn.Open();
                    list = conn.Query<專案機台交貨單>(strSQL).ToList();
                }
            }
            catch (Exception) { throw; }
            return list;
        }

        internal List<工令單> getAllWorkOrderSerials()
        {
            using var conn = new SqlConnection(IRepository<string>.ConnStr);
            conn.Open();
            return conn.Query<工令單>("SELECT 專案序號, 客戶簡稱, 機台型號, 機台名稱, 客戶名稱 FROM 工令單 ORDER BY 專案序號 DESC").ToList();
        }

        internal string getNewEQPShippingNo()
        {
            string prefix = "DC" + DateTime.Now.ToString("yyyyMMdd");
            using var conn = new SqlConnection(IRepository<string>.ConnStr);
            conn.Open();
            string last = conn.QueryFirstOrDefault<string>(
                "SELECT TOP 1 單號 FROM 專案機台交貨單 WHERE 單號 LIKE @prefix ORDER BY 單號 DESC",
                new { prefix = prefix + "%" });
            if (string.IsNullOrEmpty(last)) return prefix;
            if (last == prefix) return prefix + "0001";
            if (last.Length > prefix.Length && int.TryParse(last.Substring(prefix.Length), out int seq))
                return prefix + (seq + 1).ToString("D4");
            return prefix;
        }

        internal 專案機台交貨單 getEQPShippingByNo(string 單號)
        {
            using var conn = new SqlConnection(IRepository<string>.ConnStr);
            conn.Open();
            var order = conn.QueryFirstOrDefault<專案機台交貨單>(
                "SELECT * FROM 專案機台交貨單 WHERE 單號=@單號", new { 單號 });
            if (order != null)
            {
                order.專案機台裝箱明細 = conn.Query<專案機台裝箱明細>(
                    "SELECT * FROM 專案機台裝箱明細 WHERE 單號=@單號", new { 單號 }).ToList();
                order.專案應收沖款明細 = conn.Query<專案應收沖款明細>(
                    @"SELECT 識別碼,專案序號,收款日期,收款項目,交付形式,沖帳金額,實收金額,手續費,其他減項,折減事由,備註,沖帳人員,業務複審
                      FROM 專案應收沖款明細 WHERE 專案序號=@專案序號", new { order.專案序號 }).ToList();
            }
            return order;
        }

        internal int saveEQPShipping(專案機台交貨單 t)
        {
            using var conn = new SqlConnection(IRepository<string>.ConnStr);
            conn.Open();
            int result = conn.Execute(@"INSERT INTO 專案機台交貨單
                (單號,日期,專案序號,單據地址,交貨地址,聯絡人,電話,訂購單號,發票單號,
                 Container,ContainerType,ContainerPort,DeliveryTeam,Insurance,DestinationPort,Packing,
                 ETD,ETA,Arrival,CustomsClose,TypesOfBL,Forwarder,CertOfOrigin,SurrenderBL,
                 CaseNo,Total,建檔,建檔日,Doc,Trade,Mark,Ship,Voyage)
                VALUES
                (@單號,@日期,@專案序號,@單據地址,@交貨地址,@聯絡人,@電話,@訂購單號,@發票單號,
                 @Container,@ContainerType,@ContainerPort,@DeliveryTeam,@Insurance,@DestinationPort,@Packing,
                 @ETD,@ETA,@Arrival,@CustomsClose,@TypesOfBL,@Forwarder,@CertOfOrigin,@SurrenderBL,
                 @CaseNo,@Total,@建檔,@建檔日,@Doc,@Trade,@Mark,@Ship,@Voyage)", t);
            foreach (var d in t.專案機台裝箱明細 ?? new List<專案機台裝箱明細>())
            {
                d.單號 = t.單號;
                conn.Execute(@"INSERT INTO 專案機台裝箱明細
                    (單號,Description,QTY,Unit,Dollar1,UnitPrice,Dollar2,Amount,NWkgs,GWkgs,Dimensioncm,HSCode)
                    VALUES (@單號,@Description,@QTY,@Unit,@Dollar1,@UnitPrice,@Dollar2,@Amount,@NWkgs,@GWkgs,@Dimensioncm,@HSCode)", d);
            }
            return result;
        }

        internal int updateEQPShipping(專案機台交貨單 t)
        {
            using var conn = new SqlConnection(IRepository<string>.ConnStr);
            conn.Open();
            int result = conn.Execute(@"UPDATE 專案機台交貨單 SET
                日期=@日期,專案序號=@專案序號,單據地址=@單據地址,交貨地址=@交貨地址,聯絡人=@聯絡人,電話=@電話,
                訂購單號=@訂購單號,發票單號=@發票單號,Container=@Container,ContainerType=@ContainerType,
                ContainerPort=@ContainerPort,DeliveryTeam=@DeliveryTeam,Insurance=@Insurance,
                DestinationPort=@DestinationPort,Packing=@Packing,ETD=@ETD,ETA=@ETA,Arrival=@Arrival,
                CustomsClose=@CustomsClose,TypesOfBL=@TypesOfBL,Forwarder=@Forwarder,CertOfOrigin=@CertOfOrigin,
                SurrenderBL=@SurrenderBL,CaseNo=@CaseNo,Total=@Total,修改=@修改,修改日=@修改日,
                Doc=@Doc,Trade=@Trade,Mark=@Mark,Ship=@Ship,Voyage=@Voyage
                WHERE 單號=@單號", t);
            conn.Execute("DELETE FROM 專案機台裝箱明細 WHERE 單號=@單號", new { t.單號 });
            foreach (var d in t.專案機台裝箱明細 ?? new List<專案機台裝箱明細>())
            {
                d.單號 = t.單號;
                conn.Execute(@"INSERT INTO 專案機台裝箱明細
                    (單號,Description,QTY,Unit,Dollar1,UnitPrice,Dollar2,Amount,NWkgs,GWkgs,Dimensioncm,HSCode)
                    VALUES (@單號,@Description,@QTY,@Unit,@Dollar1,@UnitPrice,@Dollar2,@Amount,@NWkgs,@GWkgs,@Dimensioncm,@HSCode)", d);
            }
            return result;
        }

        internal int deleteEQPShipping(string 單號)
        {
            using var conn = new SqlConnection(IRepository<string>.ConnStr);
            conn.Open();
            conn.Execute("DELETE FROM 專案機台裝箱明細 WHERE 單號=@單號", new { 單號 });
            return conn.Execute("DELETE FROM 專案機台交貨單 WHERE 單號=@單號", new { 單號 });
        }

        internal int validateEQPShipping(string 單號, bool approve, string account)
        {
            using var conn = new SqlConnection(IRepository<string>.ConnStr);
            conn.Open();
            if (approve)
                return conn.Execute(
                    "UPDATE 專案機台交貨單 SET 核准=@account, 核准日=@date WHERE 單號=@單號",
                    new { account, date = DateTime.Now.ToString("yyyy/MM/dd"), 單號 });
            else
                return conn.Execute(
                    "UPDATE 專案機台交貨單 SET 核准=NULL, 核准日=NULL WHERE 單號=@單號", new { 單號 });
        }

        internal 工令單 getWorkOrdersByProjSerial(string projSerial)
        {
            工令單 workOrder = new 工令單();
            try
            {
                string strSQL = $@" SELECT dbo_工令單.專案序號, dbo_工令單.客戶簡稱, dbo_工令單.機台類型, dbo_工令單.機台型號, dbo_工令單.機台名稱 
                                      FROM 工令單 dbo_工令單
                                     WHERE dbo_工令單.專案序號='{projSerial}'";
                using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    conn.Open();
                    workOrder = conn.QueryFirst<工令單>(strSQL);
                }
            }
            catch (Exception)
            {

                throw;
            }
            return workOrder;
        }
    }
}