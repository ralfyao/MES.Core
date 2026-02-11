using Dapper;
using MES.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Transactions;
using System.Data.SqlClient;

namespace MES.Core.Repository.Impl
{
    public class CustomerContactRepository : AbstractRepository<C客戶連絡人清單>
    {
        public override int Insert(C客戶連絡人清單 t)
        {
            int retCode = 0;
            try
            {
                using (var conn = new SqlConnection(IRepository<C客戶連絡人清單>.ConnStr))
                {
                    conn.Open();
                    string strSQL = @"INSERT INTO dbo.C客戶連絡人清單
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
                    DynamicParameters dynamicParameters = new DynamicParameters(t);
                    conn.Execute(strSQL, dynamicParameters);
                }
            }
            catch (Exception ex)
            {
                retCode = 1;
            }
            return retCode;
        }

        public override int Update(C客戶連絡人清單 t)
        {
            int retCode = 0;
            try
            {
                using (var conn = new SqlConnection(IRepository<C客戶連絡人清單>.ConnStr))
                {
                    conn.Open();
                    string strSQL = @"UPDATE dbo.C客戶連絡人清單
                                        SET  COMPANY=@COMPANY,
                                             姓名=@姓名,
                                             職稱=@職稱,
                                             電話=@電話,
                                             分機=@分機,
                                             EMAIL=@EMAIL
                                       WHERE 識別碼=@識別碼";
                    DynamicParameters dynamicParameters = new DynamicParameters(t);
                    conn.Execute(strSQL, dynamicParameters);
                }
            }
            catch (Exception ex)
            {
                retCode = 1;
            }
            return retCode;
        }
    }
}
