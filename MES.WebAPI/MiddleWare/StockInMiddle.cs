using Dapper;
using MES.Core.Model;
using MES.Core.Repository;
using MES.Core.Repository.Impl;
using System.Data.SqlClient;

namespace MES.WebAPI.MiddleWare
{
    public class StockInMiddle
    {
        public List<B進貨驗收單> allStockInLists()
        {
            List<B進貨驗收單> list = new List<B進貨驗收單>();
            StockInRepository repository = new StockInRepository();
            try
            {
                list = repository.GetList(null, "", "");
            }
            catch (Exception)
            {

                throw;
            }
            return list;
        }

        public string getFormNo()
        {
            string formNo = string.Empty;
            try
            {
                using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    conn.Open();
                    string sql = $@"SELECT COUNT(0) FROM B進貨驗收單 WHERE 單號 LIKE 'PR{DateTime.Now.ToString("yyyyMMdd")}%'";
                    var data = conn.Query<int>(sql).FirstOrDefault();
                    if (data == null)
                        data = 0;
                    return $"PR{DateTime.Now.ToString("yyyyMMdd")}{(++data).ToString("00")}";
                }
            }
            catch (Exception)
            {

                throw;
            }
            return formNo;
        }
        public List<H員工清冊> queryWareHouseWorker()
        {
            List<H員工清冊> list = new List<H員工清冊>();
            try
            {
                
            }
            catch (Exception)
            {

                throw;
            }
            return list;
        }
    }
}
