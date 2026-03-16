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
    public class SupplierEvaluateRepository : AbstractRepository<B廠商評鑑>
    {
        public override int Insert(B廠商評鑑 t)
        {
            int execCnt = 0;
            try
            {
                string sql = $@"INSERT INTO dbo.B廠商評鑑
                                (
                                    單號,
                                    日期,
                                    廠商編號,
                                    評鑑人員,
                                    覆審人員,
                                    覆審日期,
                                    達成客戶要求的能力,
                                    提升經營效能的企圖,
                                    勞動安全與職工福利,
                                    能迅速處理客戶抱怨,
                                    設備的產能與準確度,
                                    足夠的人力資源條件,
                                    產銷接單適當無過載,
                                    健全的產品驗證系統,
                                    符合訂單的品質要求,
                                    依產品標準進行檢測,
                                    建檔,
                                    建檔日,
                                    修改,
                                    修改日,
                                    核准,
                                    核准日,
                                    達,
                                    提,
                                    勞,
                                    能,
                                    設,
                                    足,
                                    產,
                                    健,
                                    符,
                                    依
                                )
                                VALUES
                                (   
	                                @單號			,	-- nvarchar(15)
                                    @日期			,	-- smalldatetime
                                    @廠商編號			,	-- nvarchar(20)
                                    @評鑑人員			,	-- nvarchar(10)
                                    @覆審人員			,	-- nvarchar(10)
                                    @覆審日期			,	-- smalldatetime
                                    @達成客戶要求的能力	,	-- int
                                    @提升經營效能的企圖	,	-- int
                                    @勞動安全與職工福利	,	-- int
                                    @能迅速處理客戶抱怨	,	-- int
                                    @設備的產能與準確度	,	-- int
                                    @足夠的人力資源條件	,	-- int
                                    @產銷接單適當無過載	,	-- int
                                    @健全的產品驗證系統	,	-- int
                                    @符合訂單的品質要求	,	-- int
                                    @依產品標準進行檢測	,	-- int
                                    @建檔			,	-- nvarchar(20)
                                    @建檔日			,	-- smalldatetime
                                    @修改			,	-- nvarchar(20)
                                    @修改日			,	-- smalldatetime
                                    @核准			,	-- nvarchar(20)
                                    @核准日			,	-- smalldatetime
                                    @達				,	-- nvarchar(255)
                                    @提				,	-- nvarchar(255)
                                    @勞				,	-- nvarchar(255)
                                    @能				,	-- nvarchar(255)
                                    @設				,	-- nvarchar(255)
                                    @足				,	-- nvarchar(255)
                                    @產				,	-- nvarchar(255)
                                    @健				,	-- nvarchar(255)
                                    @符				,	-- nvarchar(255)
                                    @依					-- nvarchar(255)
                                    )";
                using (var conn = getConnection())
                {
                    DynamicParameters dynamicParameters = new DynamicParameters(t);
                    execCnt += conn.Execute(sql, t);
                }
            }
            catch (Exception)
            {

                throw;
            }
            return execCnt;
        }

        public override int Update(B廠商評鑑 t)
        {
            int execCnt = 0;
            try
            {
                string sql = $@"DELETE FROM dbo.B廠商評鑑 WHERE 單號=@單號;
                                INSERT INTO dbo.B廠商評鑑
                                (
                                    單號,
                                    日期,
                                    廠商編號,
                                    評鑑人員,
                                    覆審人員,
                                    覆審日期,
                                    達成客戶要求的能力,
                                    提升經營效能的企圖,
                                    勞動安全與職工福利,
                                    能迅速處理客戶抱怨,
                                    設備的產能與準確度,
                                    足夠的人力資源條件,
                                    產銷接單適當無過載,
                                    健全的產品驗證系統,
                                    符合訂單的品質要求,
                                    依產品標準進行檢測,
                                    建檔,
                                    建檔日,
                                    修改,
                                    修改日,
                                    核准,
                                    核准日,
                                    達,
                                    提,
                                    勞,
                                    能,
                                    設,
                                    足,
                                    產,
                                    健,
                                    符,
                                    依
                                )
                                VALUES
                                (   
	                                @單號			,	- nvarchar(15)
                                    @日期			,	- smalldatetime
                                    @廠商編號			,	- nvarchar(20)
                                    @評鑑人員			,	- nvarchar(10)
                                    @覆審人員			,	- nvarchar(10)
                                    @覆審日期			,	- smalldatetime
                                    @達成客戶要求的能力	,	- int
                                    @提升經營效能的企圖	,	- int
                                    @勞動安全與職工福利	,	- int
                                    @能迅速處理客戶抱怨	,	- int
                                    @設備的產能與準確度	,	- int
                                    @足夠的人力資源條件	,	- int
                                    @產銷接單適當無過載	,	- int
                                    @健全的產品驗證系統	,	- int
                                    @符合訂單的品質要求	,	- int
                                    @依產品標準進行檢測	,	- int
                                    @建檔			,	- nvarchar(20)
                                    @建檔日			,	- smalldatetime
                                    @修改			,	- nvarchar(20)
                                    @修改日			,	- smalldatetime
                                    @核准			,	- nvarchar(20)
                                    @核准日			,	- smalldatetime
                                    @達				,	- nvarchar(255)
                                    @提				,	- nvarchar(255)
                                    @勞				,	- nvarchar(255)
                                    @能				,	- nvarchar(255)
                                    @設				,	- nvarchar(255)
                                    @足				,	- nvarchar(255)
                                    @產				,	- nvarchar(255)
                                    @健				,	- nvarchar(255)
                                    @符				,	- nvarchar(255)
                                    @依					- nvarchar(255)
                                    )";
                using (var conn = getConnection())
                {
                    DynamicParameters dynamicParameters = new DynamicParameters(t);
                    execCnt += conn.Execute(sql, t);
                }
            }
            catch (Exception)
            {

                throw;
            }
            return execCnt;
        }

        public int ValidateSupplierEvaluate(string formNo, bool validate, string user)
        {
            int execCnt = 0;
            try
            {
                B廠商評鑑 evaluate = new B廠商評鑑();
                evaluate.單號 = formNo;
                if (validate)
                {
                    evaluate.核准 = user;
                    evaluate.核准日 = DateTime.Now.ToString("yyyy-MM-dd");
                }
                else
                {
                    evaluate.核准 = "";
                    evaluate.核准日 = "";
                }

                string sql = $@"UPDATE B廠商評鑑 SET 核准=@核准, 核准日 = @核准日 WHERE 單號=@單號";
                using (var conn = getConnection())
                {
                    DynamicParameters dynamicParameters = new DynamicParameters(evaluate);
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
