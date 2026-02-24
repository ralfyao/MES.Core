using Dapper;
using MES.Core;
using MES.Core.Model;
using MES.Core.Repository;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MES.MiddleWare.Modules
{
    public class ARMiddle
    {
        public List<F帳款管理> getAccountSourceAndCode()
        {
            string sql = "SELECT DISTINCT [帳款來源], [沖帳碼] FROM [F帳款管理]";
            List<F帳款管理> list = new List<F帳款管理>();
            try
            {
                using(var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    conn.Open();
                    list = conn.Query<F帳款管理>(sql).ToList();
                }
            } 
            catch (Exception ex)
            {
                throw ex;
            }
            return list;
        }
        public string getARNo()
        {
            string f = string.Empty;
            try
            {
                using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    string strSQL = $"SELECT COUNT(0) FROM F收款 WHERE 單號 LIKE 'AR{DateTime.Now.ToString("yyyy")}%'";
                    List<string> ls = conn.Query<string>(strSQL).ToList();
                    if (ls.Count() > 0)
                    {
                        var count = int.Parse(ls[0]);
                        count++;
                        f = $"AR{DateTime.Now.ToString("yyyy")}{count.ToString("000")}";
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return f;
        }
        public int saveAR(F收款 form)
        {
            int execCnt = 0;
            form.建檔日 = DateTime.Now.ToString("yyyy-MM-dd");
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
            try
            {
                using(var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    conn.Open();
                    DynamicParameters dynamicParameters = new DynamicParameters(form);
                    execCnt += conn.Execute(sql, dynamicParameters);
                    foreach(var item in form.arListDetail)
                    {
                        item.單號 = form.單號;
                        sql = $@"INSERT INTO dbo.F收款明細
                                (
                                    單號,
                                    帳款來源,
                                    沖帳碼,
                                    原幣收帳金額,
                                    台幣換算金額,
                                    說明,
                                    專案序號
                                )
                                VALUES
                                (   
                                    @單號,
                                    @帳款來源,
                                    @沖帳碼,
                                    @原幣收帳金額,
                                    @台幣換算金額,
                                    @說明,
                                    @專案序號
                                    )";
                        dynamicParameters = new DynamicParameters(item);
                        execCnt += conn.Execute(sql, dynamicParameters);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return execCnt;
        }
        public int deleteAR(string arNo)
        {
            int execCnt = 0;
            string sql = $@"DELETE FROM F收款 WHERE 單號='{arNo}';
                            DELETE FROM F收款明細 WHERE 單號='{arNo}'";
            try
            {
                using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    conn.Open();
                    execCnt += conn.Execute(sql);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return execCnt;
        }
        public int updateAR(F收款 form)
        {
            int execCnt = 0;
            try
            {
                execCnt += deleteAR(form.單號);
                execCnt += saveAR(form);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return execCnt;
        }

        public List<F收款> getARList()
        {
            List<F收款> list = new List<F收款>();
            try
            {
                using(var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    conn.Open();
                    list = conn.Query<F收款>(@"SELECT   識別碼, 日期,
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
                                                        CASE WHEN RTRIM(結案) = '1' THEN 1 ELSE 0 END AS 結案
                                                   FROM F收款").ToList();
                    foreach (var item in list)
                    {
                        item.日期 = Utility.ConvertDate(item.日期);
                        item.收款日期 = Utility.ConvertDate(item.收款日期);
                        item.arListDetail = conn.Query<F收款明細>($"SELECT * FROM F收款明細 WHERE 單號='{item.單號}'").ToList();
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return list;
        }
    }
}
