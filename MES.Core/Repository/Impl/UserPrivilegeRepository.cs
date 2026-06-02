using Dapper;
using MES.Core.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Dapper.SqlMapper;

namespace MES.Core.Repository.Impl
{
    public class UserPrivilegeRepository : AbstractRepository<A使用者授權>
    {
        private SqlTransaction tran;
        private string INSERT_SQL = $@"INSERT INTO dbo.A使用者授權
                                        (
                                            職務,
                                            員工編號,
                                            員工姓名,
                                            核准,
                                            編修,
                                            報表,
                                            輸出,
                                            註記,
                                            職務代理效期,
                                            機號,
                                            授權表單,
                                            授權子表單,
                                            高管,
                                            查詢
                                        )
                                        VALUES
                                        (   
	                                        @職務, -- nvarchar(12)
                                            @員工編號, -- nvarchar(20)
                                            @員工姓名, -- nvarchar(30)
                                            @核准, -- bit
                                            @編修, -- bit
                                            @報表, -- bit
                                            @輸出, -- bit
                                            @註記, -- nvarchar(150)
                                            @職務代理效期, -- smalldatetime
                                            @機號, -- nvarchar(10)
                                            @授權表單, -- char(10)
                                            @授權子表單, -- varchar(20)
                                            @高管, -- bit
                                            @查詢 -- bit
                                        )";
        private string UPDATE_SQL = $@"
                                        UPDATE A使用者授權
                                        SET 
                                        職務		     =   @職務			,-- nvarchar(12)
                                        員工編號		 =   @員工編號      ,-- nvarchar(20)
                                        員工姓名		 =   @員工姓名      ,-- nvarchar(30)
                                        核准		     =   @核准			,-- bit
                                        編修		     =   @編修			,-- bit
                                        報表		     =   @報表			,-- bit
                                        輸出		     =   @輸出			,-- bit
                                        註記		     =   @註記			,-- nvarchar(150)
                                        職務代理效期     =   @職務代理效期  ,-- smalldatetime
                                        機號		     =   @機號			,-- nvarchar(10)
                                        授權表單		 =   @授權表單	    ,-- char(10)
                                        授權子表單	     =   @授權子表單	,-- varchar(20)
                                        高管		     =   @高管			,-- bit
                                        查詢		     =   @查詢			-- bit
                                        WHERE 識別碼 = @識別碼";
        public override int Insert(A使用者授權 t)
        {
            int execCnt = 0;
            try
            {
                using(var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    conn.Open();
                    using (tran = conn.BeginTransaction())
                    {
                        DynamicParameters dynamicParameters = new DynamicParameters(t);
                        execCnt += conn.Execute(INSERT_SQL, dynamicParameters, tran);
                        tran.Commit();
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
            return execCnt;
        }
        public int BatchInsert(List<A使用者授權> list)
        {
            int execCnt = 0;
            try
            {
                using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    conn.Open();
                    using (tran = conn.BeginTransaction())
                    {
                        foreach (var item in list)
                        {
                            DynamicParameters dynamicParameters = new DynamicParameters(item);
                            execCnt += conn.Execute(INSERT_SQL, dynamicParameters, tran);
                        }
                        tran.Commit();
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
            return execCnt;
        }
        public override int Update(A使用者授權 t)
        {
            int execCnt = 0;
            try
            {
                using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    conn.Open();
                    using (tran = conn.BeginTransaction())
                    {
                        DynamicParameters dynamicParameters = new DynamicParameters(t);
                        execCnt += conn.Execute(UPDATE_SQL, dynamicParameters, tran);
                        tran.Commit();
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
            return execCnt;
        }
        public int BatchUpdate(List<A使用者授權> list)
        {
            int execCnt = 0;
            try
            {
                using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    conn.Open();
                    using (tran = conn.BeginTransaction())
                    {
                        DynamicParameters dynamicParameters = new DynamicParameters(list[0]);
                        conn.Execute("DELETE FROM A使用者授權 WHERE 員工編號=@員工編號", dynamicParameters, tran);
                        foreach (var item in list)
                        {
                            dynamicParameters = new DynamicParameters(item);
                            execCnt += conn.Execute(INSERT_SQL, dynamicParameters, tran);
                        }
                        tran.Commit();
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
            return execCnt;
        }
    }
}
