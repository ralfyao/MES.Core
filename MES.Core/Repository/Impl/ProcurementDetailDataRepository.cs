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
    public class ProcurementDetailDataRepository : AbstractRepository<B採購明細>
    {
        public void DeleteList(string purchaseOrderNo)
        {
            using(var conn = new SqlConnection(IRepository<string>.ConnStr))
            {
                conn.Open();
                conn.Execute($"DELETE FROM B採購明細 WHERE 單號='{purchaseOrderNo}'");
            }
        }

        public override int Insert(B採購明細 t)
        {
            throw new NotImplementedException();
        }

        public void setIdColumn(string v)
        {
            this.theId = v;
        }

        public override int Update(B採購明細 t)
        {
            throw new NotImplementedException();
        }
    }
}
