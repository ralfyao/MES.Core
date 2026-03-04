
using Dapper;
using MES.Core.Model;
using MES.Core.Repository;
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
    }
}
