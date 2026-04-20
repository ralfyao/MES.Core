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
    public class PurchaseRequestRepository : AbstractRepository<B請購需求>
    {
        public static string SQL_INSERT_請購需求 = $@"INSERT INTO dbo.B請購需求
                                                        (
                                                            日期,
                                                            品項編號,
                                                            品名規格,
                                                            請購類別,
                                                            請購部門,
                                                            請購人員,
                                                            數量,
                                                            需求日期,
                                                            緊急,
                                                            用途,
                                                            註記,
                                                            指定供應廠商,
                                                            轉單,
                                                            結案,
                                                            選擇廠商,
                                                            採購單號
                                                        )
                                                        VALUES
                                                        (   
	                                                        @日期,
                                                            @品項編號,
                                                            @品名規格,
                                                            @請購類別,
                                                            @請購部門,
                                                            @請購人員,
                                                            @數量,
                                                            @需求日期,
                                                            @緊急,
                                                            @用途,
                                                            @註記,
                                                            @指定供應廠商,
                                                            @轉單,
                                                            @結案,
                                                            @選擇廠商,
                                                            @採購單號
                                                            )";

        public void DeletePurchaseRequest(string formSerial)
        {
            try
            {
                string sql = $@"DELETE FROM B請購需求 WHERE 請購序號={formSerial};";
                using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    conn.Open();
                    conn.Execute(sql);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public override int Insert(B請購需求 t)
        {
            throw new NotImplementedException();
        }

        public void SavePurchaseRequest(B請購需求 form)
        {
            try
            {
                string sql = $@"DELETE FROM B請購需求 WHERE 請購序號=@請購序號;
                                {SQL_INSERT_請購需求}";
                using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    conn.Open();
                    DynamicParameters dynamicParameters = new DynamicParameters(form);
                    conn.Execute(sql, dynamicParameters);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public override int Update(B請購需求 t)
        {
            throw new NotImplementedException();
        }
    }
}
