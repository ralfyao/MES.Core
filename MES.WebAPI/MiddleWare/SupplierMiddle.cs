using Dapper;
using MES.Core.Model;
using MES.Core.Repository;
using MES.Core.Repository.Impl;
using System.Data.SqlClient;

namespace MES.WebAPI.MiddleWare
{
    public class SupplierMiddle
    {
        public List<B廠商設定> getSupplierList(string? supplierNo = "", string supplierName = "")
        {
            List<B廠商設定> list = new List<B廠商設定> ();
            try
            {
                SupplierRepository supplierMiddle = new SupplierRepository();
                SupplierDetailRepository supplierDetailRepository = new Core.Repository.Impl.SupplierDetailRepository();
                list = supplierMiddle.GetList(null);
                if (!string.IsNullOrEmpty(supplierNo))
                {
                    list = list.Where(x => x.廠商編號 == supplierNo).ToList();
                }
                if (!string.IsNullOrEmpty(supplierName))
                {
                    list = list.Where(x => x.廠商名稱.IndexOf(supplierName) != -1).ToList();
                }
                // 詢價清單
                foreach(var  item in list)
                {
                    B廠商供料 aItem = new B廠商供料();
                    aItem.廠商編號 = item.廠商編號;
                    item.supplyList = supplierDetailRepository.GetListBy(aItem, "廠商編號");
                }
            }
            catch (Exception)
            {

                throw;
            }
            return list;
        }

        public int updateSupplier(B廠商設定 form)
        {
            int execCnt = 0;
            string sql = $@"DELETE FROM B廠商設定 WHERE 廠商編號=@廠商編號;
                            INSERT INTO dbo.B廠商設定
                            (
                                廠商編號,
                                廠商簡稱,
                                廠商名稱,
                                國別,
                                公司地址,
                                工廠地址,
                                統一編號,
                                聯絡人,
                                職稱,
                                手機,
                                電話,
                                傳真,
                                電郵,
                                所屬業別,
                                管理分類,
                                等級,
                                備註,
                                R1,
                                R2,
                                R3,
                                停用,
                                建檔,
                                建檔日,
                                修改,
                                修改日,
                                核准,
                                核准日
                            )
                            VALUES
                            (   
	                            @廠商編號,	-- nvarchar(20)
                                @廠商簡稱,	-- nvarchar(20)
                                @廠商名稱,	-- nvarchar(100)
                                @國別	,		-- nvarchar(20)
                                @公司地址,	-- nvarchar(100)
                                @工廠地址,	-- nvarchar(100)
                                @統一編號,	-- nvarchar(10)
                                @聯絡人	,	-- nvarchar(10)
                                @職稱	,		-- nvarchar(10)
                                @手機	,		-- nvarchar(20)
                                @電話	,		-- nvarchar(20)
                                @傳真	,		-- nvarchar(20)
                                @電郵	,		-- nvarchar(50)
                                @所屬業別,	-- nvarchar(20)
                                @管理分類,	-- nvarchar(10)
                                @等級	,		-- nvarchar(10)
                                @備註	,		-- nvarchar(100)
                                @R1		,	-- nvarchar(50)
                                @R2		,	-- nvarchar(50)
                                @R3		,	-- nvarchar(50)
                                @停用	,		-- bit
                                @建檔	,		-- nvarchar(20)
                                @建檔日	,	-- smalldatetime
                                @修改	,		-- nvarchar(20)
                                @修改日	,	-- smalldatetime
                                @核准	,		-- nvarchar(20)
                                @核准日		-- smalldatetime
                                )";
            try
            {
                using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    conn.Open();
                    DynamicParameters dynamicParameters = new DynamicParameters(form);
                    execCnt += conn.Execute(sql, dynamicParameters);
                }
            }
            catch (Exception)
            {

                throw;
            }
            return execCnt;
        }
        public int insertSupplier(B廠商設定 form)
        {
            int execCnt = 0;
            string sql = $@"INSERT INTO dbo.B廠商設定
                            (
                                廠商編號,
                                廠商簡稱,
                                廠商名稱,
                                國別,
                                公司地址,
                                工廠地址,
                                統一編號,
                                聯絡人,
                                職稱,
                                手機,
                                電話,
                                傳真,
                                電郵,
                                所屬業別,
                                管理分類,
                                等級,
                                備註,
                                R1,
                                R2,
                                R3,
                                停用,
                                建檔,
                                建檔日,
                                修改,
                                修改日,
                                核准,
                                核准日
                            )
                            VALUES
                            (   
	                            @廠商編號,	-- nvarchar(20)
                                @廠商簡稱,	-- nvarchar(20)
                                @廠商名稱,	-- nvarchar(100)
                                @國別	,		-- nvarchar(20)
                                @公司地址,	-- nvarchar(100)
                                @工廠地址,	-- nvarchar(100)
                                @統一編號,	-- nvarchar(10)
                                @聯絡人	,	-- nvarchar(10)
                                @職稱	,		-- nvarchar(10)
                                @手機	,		-- nvarchar(20)
                                @電話	,		-- nvarchar(20)
                                @傳真	,		-- nvarchar(20)
                                @電郵	,		-- nvarchar(50)
                                @所屬業別,	-- nvarchar(20)
                                @管理分類,	-- nvarchar(10)
                                @等級	,		-- nvarchar(10)
                                @備註	,		-- nvarchar(100)
                                @R1		,	-- nvarchar(50)
                                @R2		,	-- nvarchar(50)
                                @R3		,	-- nvarchar(50)
                                @停用	,		-- bit
                                @建檔	,		-- nvarchar(20)
                                @建檔日	,	-- smalldatetime
                                @修改	,		-- nvarchar(20)
                                @修改日	,	-- smalldatetime
                                @核准	,		-- nvarchar(20)
                                @核准日		-- smalldatetime
                                )";
            try
            {
                using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    conn.Open();
                    DynamicParameters dynamicParameters = new DynamicParameters(form);
                    execCnt += conn.Execute(sql, dynamicParameters);
                }
            }
            catch (Exception)
            {

                throw;
            }
            return execCnt;
        }
        public int deleteSupplier(B廠商設定 form)
        {
            int execCnt = 0;
            string sql = $@"DELETE FROM B廠商設定 WHERE 廠商編號=@廠商編號;";
            try
            {
                using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    conn.Open();
                    DynamicParameters dynamicParameters = new DynamicParameters(form);
                    execCnt += conn.Execute(sql, dynamicParameters);
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
