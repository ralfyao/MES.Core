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
    public class CommonRepository<T> : AbstractRepository<T> where T : class
    {
        public List<C報價單> GetQuotationCustomList(C報價單 value, string topn = "TOP 1000")
        {
            List<C報價單> list = new List<C報價單>();
            try
            {
                using(var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    conn.Open();
                    string strSQL = $@"SELECT {topn} a.*, c.COMPANY, c.CONTACTPERSON CONTACT, d.姓名 業務人員 
                                    FROM C報價單 a 
                                    LEFT OUTER JOIN C客戶詢問函 b ON a.RFQNO=b.RFQNO
                                    LEFT OUTER JOIN C客戶設定 c ON b.COMPANY=c.COMPANY
                                    LEFT OUTER JOIN H員工清冊 d ON a.DADDRESS=d.工號";
                    list = conn.Query<C報價單>(strSQL).ToList();
                    list.ForEach((x) =>
                    {
                        strSQL = $@"SELECT * FROM C報價明細 WHERE QUONO='{x.QUONO}'";
                        x.quotationDetailFormList = conn.Query<C報價明細>(strSQL).ToList();
                    });
                }
            }
            catch (Exception)
            {

                throw;
            }
            return list;
        }

        public override int Insert(T t)
        {
            throw new NotImplementedException();
        }

        public override int Update(T t)
        {
            throw new NotImplementedException();
        }
    }
}
