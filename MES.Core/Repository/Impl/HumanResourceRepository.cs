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
    public class HumanResourceRepository : AbstractRepository<H員工清冊>
    {
        public override int Insert(H員工清冊 t)
        {
            int retCode = 0;
            try
            {
                using (var conn = new SqlConnection(IRepository<C客戶聯絡明細>.ConnStr))
                {
                    conn.Open();
                    string strSQL = @"INSERT INTO dbo.H員工清冊
                                        (
                                            工號,
                                            姓名,
                                            部門,
                                            職能,
                                            地址,
                                            生日,
                                            職稱,
                                            狀況,
                                            身分證號,
                                            人事編號,
                                            卡號
                                        )
                                        VALUES
                                        (   
                                            @工號,
                                            @姓名,
                                            @部門,
                                            @職能,
                                            @地址,
                                            @生日,
                                            @職稱,
                                            @狀況,
                                            @身分證號,
                                            @人事編號,
                                            @卡號
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

        public override int Update(H員工清冊 t)
        {
            int retCode = 0;
            try
            {
                using (var conn = new SqlConnection(IRepository<C客戶連絡人清單>.ConnStr))
                {
                    conn.Open();
                    string strSQL = @"UPDATE dbo.H員工清冊
                                         SET 姓名=@姓名,
                                            部門=@部門,
                                            職能=@職能,
                                            地址=@地址,
                                            生日=@生日,
                                            職稱=@職稱,
                                            狀況=@狀況,
                                            身分證號=@身分證號,
                                            人事編號=@人事編號,
                                            卡號=@卡號
                                      WHERE 工號=@工號";
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
