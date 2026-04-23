using Dapper;
using MES.Core.Repository;
using System.Data.SqlClient;

namespace MES.WebAPI.MiddleWare
{
    public class ItemMiddle
    {
        public List<string> getItemTypeList()
        {
            List<string> list = new List<string>();
            try
            {
                using(var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    conn.Open();
                    list = conn.Query<string>("SELECT 品別 FROM A品別").ToList();
                }
            }
            catch (Exception)
            {

                throw;
            }
            return list;
        }
    }
}
