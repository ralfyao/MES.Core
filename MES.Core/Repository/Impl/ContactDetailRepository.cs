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
    public class ContactDetailRepository : AbstractRepository<C客戶聯絡明細>
    {
        public override int Insert(C客戶聯絡明細 t)
        {
            int retCode = 0;
            try
            {
                using (var conn = new SqlConnection(IRepository<C客戶聯絡明細>.ConnStr))
                {
                    conn.Open();
                    string strSQL = @"INSERT INTO dbo.C客戶聯絡明細
                                                    (
                                                        COMPANY,
                                                        日期,
                                                        註記,
                                                        業務人員,
                                                        RFQNO
                                                    )
                                                    VALUES
                                                    (   
                                                       @COMPANY,
                                                       @日期,
                                                       @註記,
                                                       @業務人員,
                                                       @RFQNO
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

        public override int Update(C客戶聯絡明細 t)
        {
            int retCode = 0;
            try
            {
                using (var conn = new SqlConnection(IRepository<C客戶連絡人清單>.ConnStr))
                {
                    conn.Open();
                    string strSQL = @"UPDATE dbo.C客戶聯絡明細
                                         SET  日期=@日期,
                                              註記=@註記,
                                              業務人員=@業務人員,
                                              RFQNO=@RFQNO
                                       WHERE COMPANY=@COMPANY 
                                         AND SERNO=@SERNO";
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
