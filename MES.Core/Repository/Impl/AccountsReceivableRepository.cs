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
    public class AccountsReceivableRepository : AbstractRepository<F收款>
    {
        public override int Insert(F收款 t)
        {
            int execCnt = 0;
            try
            {
                string sql = $@"INSERT INTO dbo.F收款
                                (
                                    日期,
                                    單號,
                                    客戶編號,
                                    幣別,
                                    匯率,
                                    請款人員,
                                    收款日期,
                                    類別,
                                    收現金額,
                                    銀轉金額,
                                    匯費,
                                    銀存編碼,
                                    收票金額,
                                    票據號碼,
                                    收款總額,
                                    MACHINENO,
                                    發票號碼,
                                    備註,
                                    建檔,
                                    建檔日,
                                    修改,
                                    修改日,
                                    核准,
                                    核准日,
                                    傳票,
                                    結案
                                )
                                VALUES
                                (   
                                    @日期,
                                    @單號,
                                    @客戶編號,
                                    @幣別,
                                    @匯率,
                                    @請款人員,
                                    @收款日期,
                                    @類別,
                                    @收現金額,
                                    @銀轉金額,
                                    @匯費,
                                    @銀存編碼,
                                    @收票金額,
                                    @票據號碼,
                                    @收款總額,
                                    @MACHINENO,
                                    @發票號碼,
                                    @備註,
                                    @建檔,
                                    @建檔日,
                                    @修改,
                                    @修改日,
                                    @核准,
                                    @核准日,
                                    @傳票,
                                    @結案
                                    )";
                using(var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    conn.Open();
                    DynamicParameters dynamicParameters = new DynamicParameters(t);
                    execCnt += conn.Execute(sql, dynamicParameters);
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return execCnt;
        }

        public override int Update(F收款 t)
        {
            throw new NotImplementedException();
        }
    }
}
