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
    public class RFQRepository : AbstractRepository<C客戶詢問函>
    {
        public override int Insert(C客戶詢問函 t)
        {
            int retCode = 0;
            try
            {
                using (var conn = new SqlConnection(IRepository<C客戶詢問函>.ConnStr))
                {
                    conn.Open();
                    string strSQL = @"INSERT INTO dbo.C客戶詢問函
                                        (
                                            RFQNO,
                                            SALES,
                                            RFQDATE,
                                            COMPANY,
                                            [M/A],
                                            TEL,
                                            CONTACT,
                                            POSITION,
                                            EMAIL,
                                            COUNTRY,
                                            INDUSTRYCODE,
                                            INDUSTRY,
                                            MACHINE,
                                            COMMISSION,
                                            ENDUSER,
                                            SOURCE,
                                            STATUS,
                                            DESCRIPTION,
                                            QUONO,
                                            RFQSTATUS,
                                            RANKING,
                                            AGENT
                                        )
                                        VALUES
                                        (   
	                                        @RFQNO				,
                                            @SALES              ,
                                            @RFQDATE            ,
                                            @COMPANY            ,
                                            @MA                ,
                                            @TEL                ,
                                            @CONTACT            ,
                                            @POSITION           ,
                                            @EMAIL              ,
                                            @COUNTRY            ,
                                            @INDUSTRYCODE       ,
                                            @INDUSTRY           ,
                                            @MACHINE            ,
                                            @COMMISSION         ,
                                            @ENDUSER            ,
                                            @SOURCE             ,
                                            @STATUS             ,
                                            @DESCRIPTION        ,
                                            @QUONO              ,
                                            @RFQSTATUS          ,
                                            @RANKING            ,
                                            @AGENT           
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

        public int InsertTrackingRecord(工作紀錄A t)
        {
            int retCode = 0;
            try
            {
                using (var conn = new SqlConnection(IRepository<工作紀錄A>.ConnStr))
                {
                    conn.Open();
                    string strSQL = $@" INSERT INTO 工作紀錄A(
                            日誌單號
                            ,工作日期
                            ,職務
                            ,員工編號
                            ,專案序號
                            ,模組編碼
                            ,模組名稱
                            ,任務分類
                            ,成效點數
                            ,工作項目
                            ,組裝零件
                            ,進度
                            ,本日工時
                            ,特別註記
                            ,單價
                            ,工作簡述
                            ,預計再訪) 
                            VALUES(
                                 @日誌單號
                                ,@工作日期
                                ,@職務
                                ,@員工編號
                                ,@專案序號
                                ,@模組編碼
                                ,@模組名稱
                                ,@任務分類
                                ,@成效點數
                                ,@工作項目
                                ,@組裝零件
                                ,@進度
                                ,@本日工時
                                ,@特別註記
                                ,@單價
                                ,@工作簡述
                                ,@預計再訪
                            );
                            INSERT INTO C詢問函聯絡紀錄(
                              RFQNO
                              ,RFQDATE
                              ,DESCRIPTION
                              ,BSNSTYPE
                              ,SALES
                            ) VALUES (
                                @專案序號
                               ,@工作日期
                               ,@工作簡述
                               ,@任務分類
                               ,@員工編號
                            )";
                    DynamicParameters dynamicParameters = new DynamicParameters(t);
                    conn.Execute(strSQL, dynamicParameters);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return retCode;
        }

        public override int Update(C客戶詢問函 t)
        {
            int retCode = 0;
            try
            {
                using (var conn = new SqlConnection(IRepository<C客戶詢問函>.ConnStr))
                {
                    conn.Open();
                    string strSQL = @"UPDATE dbo.C客戶詢問函
                                         SET SALES=@SALES,
                                            RFQDATE=@RFQDATE,
                                            COMPANY=@COMPANY,
                                            [M/A]=@MA,
                                            TEL=@TEL,
                                            CONTACT=@CONTACT,
                                            POSITION=@POSITION,
                                            EMAIL=@EMAIL,
                                            COUNTRY=@COUNTRY,
                                            INDUSTRYCODE=@INDUSTRYCODE,
                                            INDUSTRY=@INDUSTRY,
                                            MACHINE=@MACHINE,
                                            COMMISSION=@COMMISSION,
                                            ENDUSER=@ENDUSER,
                                            SOURCE=@SOURCE,
                                            STATUS=@STATUS,
                                            DESCRIPTION=@DESCRIPTION,
                                            QUONO=@QUONO,
                                            RFQSTATUS=@RFQSTATUS,
                                            RANKING=@RANKING,
                                            AGENT=@AGENT
                                       WHERE RFQNO=@RFQNO";
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
