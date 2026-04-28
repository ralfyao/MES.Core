using Dapper;
using MES.Core.Model;
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

        public void saveUpdateItem(A材料 form)
        {
            try
            {
                using(var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    conn.Open();
                    using (var tran = conn.BeginTransaction())
                    {
                        string sql = $@"DELETE FROM A材料 WHERE 產品編號=@產品編號;
                                        INSERT INTO dbo.A材料
                                        (
                                            產品編號,
                                            品別,
                                            大分類,
                                            小分類,
                                            產品代號,
                                            品名規格,
                                            英文品名,
                                            外尺寸長,
                                            外尺寸寬,
                                            厚度,
                                            內徑,
                                            外徑,
                                            庫存單位,
                                            採購單位,
                                            採購換算倍數,
                                            銷售單位,
                                            銷售換算倍數,
                                            停用,
                                            建檔,
                                            建檔日,
                                            修改,
                                            修改日,
                                            核准,
                                            勾選,
                                            來源屬性
                                        )
                                        VALUES
                                        (   
	                                        @產品編號, -- 產品編號 - nvarchar(100)
                                            @品別, -- 品別 - nvarchar(30)
                                            @大分類, -- 大分類 - nvarchar(25)
                                            @小分類, -- 小分類 - nvarchar(25)
                                            @產品代號, -- 產品代號 - nvarchar(50)
                                            @品名規格, -- 品名規格 - nvarchar(50)
                                            @英文品名, -- 英文品名 - nvarchar(50)
                                            @外尺寸長, -- 外尺寸長 - real
                                            @外尺寸寬, -- 外尺寸寬 - real
                                            @厚度, -- 厚度 - real
                                            @內徑, -- 內徑 - real
                                            @外徑, -- 外徑 - real
                                            @庫存單位, -- 庫存單位 - nchar(10)
                                            @採購單位, -- 採購單位 - nchar(10)
                                            @採購換算倍數, -- 採購換算倍數 - int
                                            @銷售單位, -- 銷售單位 - nchar(10)
                                            @銷售換算倍數, -- 銷售換算倍數 - int
                                            @停用, -- 停用 - bit
                                            @建檔, -- 建檔 - nvarchar(20)
                                            @建檔日, -- 建檔日 - smalldatetime
                                            @修改, -- 修改 - nvarchar(20)
                                            @修改日, -- 修改日 - smalldatetime
                                            @核准, -- 核准 - nvarchar(20)
                                            @勾選, -- 勾選 - varchar(10)
                                            @來源屬性 -- 來源屬性 - nvarchar(10)
                                            )";
                        DynamicParameters dynamicParameters = new DynamicParameters(form);
                        conn.Execute(sql, dynamicParameters, tran);
                        tran.Commit();
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void toggleDisableItem(string itemNo)
        {
            try
            {
                using(var conn = new SqlConnection(IRepository<dynamic>.ConnStr))
                {
                    conn.Open();
                    conn.Execute($@"UPDATE A材料 SET 停用 = CASE WHEN 停用=1 THEN 0 ELSE 1 end WHERE 產品編號 ='{itemNo}'");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void deleteItem(string itemNo)
        {
            try
            {
                using (var conn = new SqlConnection(IRepository<dynamic>.ConnStr))
                {
                    conn.Open();
                    conn.Execute($@"DELETE FROM A材料 WHERE 產品編號 ='{itemNo}'");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
