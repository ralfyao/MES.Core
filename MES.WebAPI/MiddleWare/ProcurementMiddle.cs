
using Dapper;
using MES.Core.Model;
using MES.Core.Repository;
using MES.Core.Repository.Impl;
using System.Data.SqlClient;

namespace MES.WebAPI.MiddleWare
{
    public class ProcurementMiddle
    {
        public string getPoNo()
        {
            string pono = string.Empty;
            try
            {
                string sql = $@"SELECT COUNT(0) + 1 FROM B採購單 WHERE 單號 LIKE 'PO{DateTime.Now.ToString("yyyyMMdd")}%'";
                using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    conn.Open();
                    var poCountList = conn.Query<int>(sql);
                    foreach (var po in poCountList)
                    {
                        pono = $@"PO{DateTime.Now.ToString("yyyyMMdd")}{po.ToString("00")}";
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return pono;
        }

        public int createPurchaseOrder(B採購單 form)
        {
            int execCnt = 0;
            try
            {
                ProcurementDataRepository procurementDataRepository = new ProcurementDataRepository();
                procurementDataRepository.Insert(form);
            }
            catch (Exception)
            {

                throw;
            }
            return execCnt;
            //throw new NotImplementedException();
        }

        public List<H員工清冊> getProcurementorList()
        {
            List<H員工清冊> list = new List<H員工清冊>();
            try
            {
                string sql = "SELECT * FROM dbo.H員工清冊 AS H\r\n  WHERE 職能='採購' AND 狀況='正常'";
                using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    conn.Open();
                    list = conn.Query<H員工清冊>(sql).ToList();
                }
            }
            catch (Exception)
            {

                throw;
            }
            return list;
        }

        public List<B採購單> getPurchaseOrderList(string purchaseOrderNo)
        {
            List<B採購單> list = new List<B採購單>();
            List<B採購單> tmplist = new List<B採購單>();
            ProcurementDataRepository procurementDataRepository= new ProcurementDataRepository();
            ProcurementDetailDataRepository procurementDetailDataRepository = new Core.Repository.Impl.ProcurementDetailDataRepository();
            InboundItemsAcceptDetailRepository inboundItemsAcceptDetailRepository = new InboundItemsAcceptDetailRepository();
            List<string> queryInboundItemCriterial = new List<string>();
            queryInboundItemCriterial.Add("採購單號");
            queryInboundItemCriterial.Add("品項編號");
            procurementDetailDataRepository.setIdColumn("單號");
            procurementDataRepository.setIdColumn("單號");
            try
            {
                if (!string.IsNullOrEmpty(purchaseOrderNo))
                {
                    B採購單 obj = new B採購單();
                    obj.單號 = purchaseOrderNo;
                    list = procurementDataRepository.GetList(obj, "").Where(x => x.結案 == false).OrderBy(x => x.日期).ToList();
                }
                else
                {
                    list = procurementDataRepository.GetList(null, "").Where(x => x.結案 == false).OrderBy(x => x.日期).ToList();
                }
                foreach (var item in list)
                {
                    B採購明細 b = new B採購明細();
                    b.單號 = item.單號;
                    item.procurementList = procurementDetailDataRepository.GetList(b).Where(x => x.結案 == false).ToList();
                    if (item.procurementList.Count() > 0) 
                    {
                        foreach(var  item2 in item.procurementList)
                        {
                            B進退貨驗收明細 b1 = new B進退貨驗收明細();
                            b1.採購單號 = item.單號;
                            b1.品項編號 = item2.品項編號;
                            List<B進退貨驗收明細> inboundList = inboundItemsAcceptDetailRepository.GetListBy(b1, queryInboundItemCriterial);
                            foreach(var item3 in inboundList)
                            {
                                item2.收貨數量 = item3.收貨數量;
                                item2.合格數量 = item3.合格數量;
                                item2.特採數量 = item3.特採數量;
                                item2.退回數量 = item3.退回數量;
                            }
                        }
                        tmplist.Add(item);
                    }
                }
                list = tmplist;
            }
            catch (Exception)
            {

                throw;
            }
            return list;
        }

        public int updatePurchaseOrder(B採購單 form)
        {
            int execCnt = 0;
            try
            {
                ProcurementDataRepository procurementDataRepository = new ProcurementDataRepository();
                procurementDataRepository.Update(form);
            }
            catch (Exception)
            {

                throw;
            }
            return execCnt;
        }

        public void deletePurchaseOrder(string purchaseOrderNo)
        {
            ProcurementDataRepository procurementDataRepository = new ProcurementDataRepository();
            ProcurementDetailDataRepository procurementDetailDataRepository = new ProcurementDetailDataRepository();
            B採購單 b = new B採購單();
            b.單號 = purchaseOrderNo;
            procurementDataRepository.Delete(b);
            procurementDetailDataRepository.DeleteList(purchaseOrderNo);
        }

        public void voidPurchaseOrder(string purchaseOrderNo)
        {
            using(var conn = new SqlConnection(IRepository<string>.ConnStr))
            {
                conn.Open();
                conn.Execute($@"UPDATE B採購單 SET 結案=1 WHERE 單號='{purchaseOrderNo}';
                                UPDATE B採購明細 SET 結案=1 WHERE 單號='{purchaseOrderNo}'");
            }
        }

        public void voidPurchaseOrderItem(string itemId)
        {
            using (var conn = new SqlConnection(IRepository<string>.ConnStr))
            {
                conn.Open();
                conn.Execute($@"DECLARE @iCount INTEGER;
                                UPDATE B採購明細 SET 結案=1 WHERE 識別='{itemId}'; 
                                SELECT @iCount = COUNT(0) FROM B採購明細 WHERE 單號=(SELECT 單號 FROM B採購明細 WHERE 識別='{itemId}') AND (結案=0 OR 結案 IS NULL);
                                IF (@iCount = 0)
                                BEGIN
                                    UPDATE B採購單 SET 結案=1 WHERE 單號=(SELECT 單號 FROM B採購明細 WHERE 識別='{itemId}');
                                END;");
            }
        }

        public void evaluatePurchaseOrder(string formNo, bool validate, string user)
        {
            using (var conn = new SqlConnection(IRepository<string>.ConnStr))
            {
                conn.Open();
                conn.Execute($@"UPDATE B採購單 SET 核准={(validate? $@"'{user}'" : "''")}, 核准日={(validate?"GETDATE()":"NULL")} WHERE 單號='{formNo}';");
            }
        }
    }
}
