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
    public class RepairFormRepository : AbstractRepository<維修服務單>
    {
        //public static object lockRepair = new object();
        public override int Insert(維修服務單 t)
        {
            int execCnt = 0;
            try
            {
                //lock (lockRepair)
                //{
                    using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                    {
                        conn.Open();
                        string strSQL = $@"INSERT INTO  dbo.維修服務單
                                            (
                                                單號, 申請日期, 維修檢查人員, 服務型態, 客戶簡稱,
                                                客戶名稱, 專案序號, 機台型號, 機台類型, 機台名稱,
                                                客戶聯絡窗口, 維修地點, 希望服務日期, 實際服務日期,
                                                故障情形, 處置建議, 零件工令編號, 客戶反應,
                                                維修結案日期, 維修服務時數, 轉零件申請, 建檔,
                                                修改, 核准, 建檔日, 修改日, 核准日, 原因類別1, 簡要描述1,
                                                原因鑑定1, 原因類別2, 簡要描述2, 原因鑑定2, 原因類別3, 簡要描述3,
                                                原因鑑定3
                                            )
                                            VALUES
                                            (   
                                                @單號, @申請日期, @維修檢查人員, @服務型態, @客戶簡稱,
                                                @客戶名稱, @專案序號, @機台型號, @機台類型, @機台名稱,
                                                @客戶聯絡窗口, @維修地點, @希望服務日期, @實際服務日期, @故障情形,
                                                @處置建議, @零件工令編號, @客戶反應, @維修結案日期, @維修服務時數,
                                                @轉零件申請, @建檔, @修改, @核准, GETDATE(), @修改日, @核准日,
                                                @原因類別1, @簡要描述1, @原因鑑定1, @原因類別2, @簡要描述2,
                                                @原因鑑定2, @原因類別3, @簡要描述3, @原因鑑定3
                                                )";
                        DynamicParameters dynamicParameters = new DynamicParameters(t);
                        execCnt = conn.Execute(strSQL, dynamicParameters);
                    }
                //}
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return execCnt;
        }

        public override int Update(維修服務單 t)
        {
            int execCnt = 0;
            try
            {
                t.申請日期 = t.申請日期?.Replace("/", "-");
                t.希望服務日期 = t.希望服務日期?.Replace("/", "-");
                t.實際服務日期 = t.實際服務日期?.Replace("/", "-");
                t.維修結案日期 = t.維修結案日期?.Replace("/", "-");

                //lock (lockRepair)
                //{DeleteRepairTest
                using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                    {
                        conn.Open();
                        string strSQL = $@"UPDATE dbo.維修服務單
                                            SET 申請日期= @申請日期, 維修檢查人員=@維修檢查人員, 
                                                服務型態= @服務型態, 客戶簡稱=@客戶簡稱,
                                                客戶名稱=@客戶名稱, 專案序號= @專案序號, 機台型號=@機台型號, 
                                                機台類型= @機台類型, 機台名稱= @機台名稱,
                                                客戶聯絡窗口=@客戶聯絡窗口, 維修地點=@維修地點, 希望服務日期=@希望服務日期, 
                                                實際服務日期=@實際服務日期, 故障情形=@故障情形, 處置建議=@處置建議, 
                                                零件工令編號= @零件工令編號, 客戶反應=@客戶反應,
                                                維修結案日期= @維修結案日期, 維修服務時數=@維修服務時數, 
                                                轉零件申請=@轉零件申請, 建檔=@建檔, 修改=@修改, 核准=@核准, 
                                                建檔日=@建檔日, 修改日=CONVERT(VARCHAR,GETDATE(),120), 核准日=@核准日, 原因類別1=@原因類別1, 
                                                簡要描述1=@簡要描述1, 原因鑑定1=@原因鑑定1, 原因類別2=@原因類別2, 
                                                簡要描述2=@簡要描述2, 原因鑑定2=@原因鑑定2, 原因類別3=@原因類別3, 
                                                簡要描述3=@簡要描述3,
                                                原因鑑定3=@原因鑑定3 
                                          where 單號=@單號";
                        DynamicParameters dynamicParameters = new DynamicParameters(t);
                        execCnt = conn.Execute(strSQL, dynamicParameters);
                    }
                //}
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return execCnt;
        }
    }
}
