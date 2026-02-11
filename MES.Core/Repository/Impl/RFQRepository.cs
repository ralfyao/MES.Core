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
