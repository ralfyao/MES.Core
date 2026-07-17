using Dapper;
using MES.Core;
using MES.Core.Model;
using MES.Core.Repository;
using MES.Core.Repository.Impl;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace MES.MiddleWare.Modules
{
    public class ARMiddle
    {
        #region 應收立帳單
        public static object arLock { get; set; } = new object();
        public List<F帳款管理> getAccountSourceAndCode(string custNo, string type)
        {
            string sql = $"SELECT DISTINCT [帳款來源], [沖帳碼] FROM [F帳款管理] WHERE 對象='{custNo}' AND 收付別='應收' ";
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
            lock (arLock) 
            { 
                form.建檔日 = DateTime.Now.ToString("yyyy-MM-dd");
                //if (string.IsNullOrEmpty(form.單號))
                //    form.單號 = getARNo();
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
                    using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                    {
                        conn.Open();
                        DynamicParameters dynamicParameters = new DynamicParameters(form);
                        execCnt += conn.Execute(sql, dynamicParameters);
                        foreach (var item in form.arListDetail)
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
                lock (arLock)
                {
                    using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                    {
                        conn.Open();
                        execCnt += conn.Execute(sql);
                    }
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
                lock (arLock)
                {
                    execCnt += deleteAR(form.單號);
                    execCnt += saveAR(form);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return execCnt;
        }

        public List<F收款> getARList(string topn = "TOP 1000", string whereCond = "")
        {
            List<F收款> list = new List<F收款>();
            try
            {
                using(var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    conn.Open();
                    list = conn.Query<F收款>($@"SELECT {topn}  a.識別碼, a.日期,
                                                        a.單號,
                                                        a.客戶編號,
                                                        (SELECT TOP 1 COMPANY FROM C客戶設定 WHERE 正航編號=a.客戶編號) 客戶名稱,
                                                        a.幣別,
                                                        a.匯率,
                                                        a.請款人員,
                                                        a.收款日期,
                                                        a.類別,
                                                        a.收現金額,
                                                        a.銀轉金額,
                                                        a.匯費,
                                                        a.銀存編碼,
                                                        a.收票金額,
                                                        a.票據號碼,
                                                        a.收款總額,
                                                        a.MACHINENO,
                                                        a.發票號碼,
                                                        a.備註,
                                                        a.建檔,
                                                        a.建檔日,
                                                        a.修改,
                                                        a.修改日,
                                                        a.核准,
                                                        a.核准日,
                                                        a.傳票,
                                                        CASE WHEN RTRIM(a.結案) = '1' THEN 1 ELSE 0 END AS 結案
                                                   FROM F收款 a WHERE 1=1 {whereCond}").ToList();
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
        #endregion
        #region 其他收入單
        public static object otherIncomeLock = new object();
        public List<F收支項目設定> getItemNumberList()
        {
            List<F收支項目設定> list = new List<F收支項目設定>();
            try
            {
                using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    conn.Open();
                    list = conn.Query<F收支項目設定>(@"SELECT *  FROM F收支項目設定").ToList();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return list;
        }
        public string getOtherIncomeNo()
        {
            string f = string.Empty;
            try
            {
                using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    string strSQL = $"SELECT COUNT(0) FROM F其他收入單 WHERE 單號 LIKE 'SV{DateTime.Now.ToString("yyyyMM")}%'";
                    List<string> ls = conn.Query<string>(strSQL).ToList();
                    if (ls.Count() > 0)
                    {
                        var count = int.Parse(ls[0]);
                        count++;
                        f = $"SV{DateTime.Now.ToString("yyyyMM")}{count.ToString("000")}";
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return f;
        }
        public int saveOtherIncome(F其他收入單 form)
        {
            int execCnt = 0;
            OtherIncomeRepository otherIncomeRepository = new OtherIncomeRepository();
            lock (arLock)
            {
                try
                {
                    form.單號 = getOtherIncomeNo();
                    execCnt = otherIncomeRepository.Insert(form);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            return execCnt;
        }
        public int updateOtherIncome(F其他收入單 form)
        {
            int execCnt = 0;
            OtherIncomeRepository otherIncomeRepository = new OtherIncomeRepository();
            lock (arLock)
            {
                try
                {
                    execCnt = otherIncomeRepository.Update(form);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            return execCnt;
        }
        public int deleteOtherIncome(F其他收入單 form)
        {
            int execCnt = 0;
            OtherIncomeRepository otherIncomeRepository = new OtherIncomeRepository();
            lock (arLock)
            {
                try
                {
                    using(var conn = new SqlConnection(IRepository<string>.ConnStr))
                    {
                        conn.Open();
                        DynamicParameters dynamicParameters = new DynamicParameters(form);
                        execCnt += conn.Execute(@"DELETE FROM F其他收入單 WHERE 單號=@單號;
                                       DELETE FROM F其他收支明細 WHERE 單號=@單號;", dynamicParameters);
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            return execCnt;
        }

        public List<F其他收入單> getOtherIncomeList()
        {
            List<F其他收入單> list = new List<F其他收入單>();
            try
            {
                using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    conn.Open();
                    list = conn.Query<F其他收入單>(@"SELECT [單號]
                                                           ,[日期]
                                                           ,[客戶編號]
                                                           ,[業務員]
                                                           ,[幣別]
                                                           ,[匯率]
                                                           ,[稅別]
                                                           ,[稅率]
                                                           ,[總額]
                                                           ,[結案]
                                                           ,CASE WHEN RTRIM(結案) = '1' THEN 1 ELSE 0 END AS 結案
                                                           ,[價格條件]
                                                           ,[付款方式]
                                                           ,[MACHINENO]
                                                           ,[Remark]
                                                           ,[建檔]
                                                           ,[修改]
                                                           ,[核准]
                                                           ,[建檔日]
                                                           ,[修改日]
                                                           ,[核准日]
                                                           ,[傳票]
                                                      FROM [CHINYO].[dbo].[F其他收入單]").ToList();
                    foreach (var item in list)
                    {
                        item.日期 = Utility.ConvertDate(item.日期);
                        item.detailList = conn.Query<F其他收支明細>($@"SELECT [識別]
                                                                           ,[單號]
                                                                           ,[項目編號]
                                                                           ,[原幣未稅]
                                                                           ,[未稅]
                                                                           ,[稅]
                                                                           ,[金額]
                                                                           ,[備註]
                                                                           ,[專案序號]
                                                                           ,CASE WHEN RTRIM(勾選) = '1' THEN 1 ELSE 0 END AS 勾選
                                                                           ,[憑證編號]
                                                                      FROM [CHINYO].[dbo].[F其他收支明細] WHERE 單號='{item.單號}'").ToList();
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return list;
        }

        public List<F帳款管理> getReceiveWirteOffList()
        {
            List<F帳款管理> list = new List<F帳款管理>();
            try
            {
                using(var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    conn.Open();
                    string strSQL = @"SELECT DISTINCT a.對象+a.備註 識別, b.COMPANY
                                           , a.對象
	                                       , a.備註
	                                       , a.幣別
	                                       , SUM(a.原幣未稅) 原幣未稅
                                           , sum(未稅) 未稅
	                                       , SUM(稅) 稅
	                                       , SUM(a.金額) 金額
                                      FROM F帳款管理 a
                                      LEFT OUTER JOIN dbo.C客戶設定 AS b ON a.對象=b.正航編號
                                     WHERE 結案=0 AND 收付別='應收'
                                     GROUP BY  b.COMPANY
                                           , a.對象
	                                       , a.備註
	                                       , a.幣別";
                    list = conn.Query<F帳款管理>(strSQL).ToList();
                    foreach(var item in list)
                    {
                        strSQL = $@"SELECT * FROM F帳款管理 WHERE 1=1
                                       AND 對象='{item.對象}'
                                       AND 備註='{item.備註}'
                                       AND 幣別='{item.幣別}' AND  結案=0 AND 收付別='應收'";
                        item.detailList = conn.Query<F帳款管理>(strSQL).ToList();
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return list;
        }

        public F其他收入單 doValidation(string? formNo, bool? valid, string? account)
        {
            try
            {
                using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    conn.Open();
                    F其他收入單 form = new F其他收入單();
                    form.單號 = formNo;
                    OtherIncomeRepository repairFormRepository = new OtherIncomeRepository();
                    form = repairFormRepository.GetUnique(form);
                    form.核准 = account;//((bool)valid?"1":"0");
                    repairFormRepository.UpdateValidate(form, valid);
                    form = repairFormRepository.GetUnique(form);
                    return form;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public F收款 doARValidation(string? formNo, bool? valid, string? account)
        {
            try
            {
                using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    conn.Open();
                    F收款 form = new F收款();
                    form.單號 = formNo;
                    AccountsReceivableRepository repairFormRepository = new AccountsReceivableRepository();
                    form = repairFormRepository.GetListBy(form, "單號", "單號").FirstOrDefault();
                    if (form != null)
                    {
                        form.核准 = account;
                        repairFormRepository.UpdateValidate(form, valid);
                        form = repairFormRepository.GetListBy(form, "單號", "單號").FirstOrDefault();
                    }
                    else
                    {
                        return form;
                    }
                    return form;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public int doUpdateCloseFlag(F收款? formNo)
        {
            int execCnt = 0;
            lock (arLock)
            {
                try
                {
                    using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                    {
                        conn.Open();
                        string strSQL = $@"UPDATE F收款 SET 結案 = {((bool)formNo.結案?"1":"0")}
                                            WHERE 單號='{formNo.單號}'";
                        execCnt =  conn.Execute(strSQL);
                        //DynamicParameters dynamicParameters = new DynamicParameters(form);
                        //execCnt += conn.Execute(@"DELETE FROM F其他收入單 WHERE 單號=@單號;
                        //               DELETE FROM F其他收支明細 WHERE 單號=@單號;", dynamicParameters);
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            return execCnt;
        }

        public List<F沖款收> getRWirteOffList(string custId)
        {
            List<F沖款收> list = new List<F沖款收>();
            try
            {
                using(var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    conn.Open();
                    list = conn.Query<F沖款收>($@"SELECT * FROM F沖款收 WHERE 1=1 {(!string.IsNullOrEmpty(custId)?$" AND 客戶編號='{custId}'":"")}").ToList();
                    foreach(var item in list)
                    {
                        item.writeOffDetailList = conn.Query<F收支沖帳明細>($@"SELECT * FROM F收支沖帳明細 WHERE 單號='{item.單號}'").ToList();
                    }
                }
            }
            catch (Exception ex)
            {

                throw;
            }
            return list;
        }

        public int writeOffAr(F收款 form)
        {
            int retInt = 0;
            try
            {
                F沖款收 writeOffForm = formWriteOffFromAR(form);
                using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    conn.Open();
                    using(var tran = conn.BeginTransaction())
                    {

                        string insertWriteOffSQL = $@"INSERT INTO dbo.F沖款收
                                                (
                                                    日期,
                                                    單號,
                                                    客戶編號,
                                                    幣別,
                                                    匯率,
                                                    請款人員,
                                                    MACHINENO,
                                                    備註,
                                                    建檔,
                                                    建檔日,
                                                    修改,
                                                    修改日,
                                                    核准,
                                                    核准日,
                                                    傳票,
                                                    收現金額,
                                                    銀轉金額,
                                                    匯費,
                                                    銀存編碼,
                                                    收票金額,
                                                    票據號碼,
                                                    收款總額
                                                )
                                                VALUES
                                                (   
	                                                @日期 -- smalldatetime
                                                    ,@單號 -- nvarchar(20)
                                                    ,@客戶編號 -- nvarchar(20)
                                                    ,@幣別 -- nvarchar(10)
                                                    ,@匯率 -- numeric(10, 2)
                                                    ,@請款人員 -- nvarchar(20)
                                                    ,@MACHINENO -- nvarchar(50)
                                                    ,@備註 -- nvarchar(max)
                                                    ,@建檔 -- nvarchar(20)
                                                    ,@建檔日 -- smalldatetime
                                                    ,@修改 -- nvarchar(20)
                                                    ,@修改日 -- smalldatetime
                                                    ,@核准 -- nvarchar(20)
                                                    ,@核准日 -- smalldatetime
                                                    ,@傳票 -- nvarchar(30)
                                                    ,@收現金額 -- numeric(18, 2)
                                                    ,@銀轉金額 -- numeric(18, 2)
                                                    ,@匯費 -- numeric(18, 2)
                                                    ,@銀存編碼 -- varchar(30)
                                                    ,@收票金額 -- numeric(18, 2)
                                                    ,@票據號碼 -- varchar(50)
                                                    ,@收款總額 -- numeric(18, 2)
                                                    )";
                        DynamicParameters dynamicParameters = new DynamicParameters(writeOffForm);
                        retInt += conn.Execute(insertWriteOffSQL, dynamicParameters, tran);
                        foreach(var item in writeOffForm.writeOffDetailList)
                        {
                            //item.單號 = form.單號;
                            dynamicParameters = new DynamicParameters(item);
                            string insertWriteOffDetailSQL = $@"INSERT INTO dbo.F收支沖帳明細
                                                                (
                                                                    單號,
                                                                    收付別,
                                                                    帳款來源,
                                                                    收款性質,
                                                                    帳款日期,
                                                                    沖帳碼,
                                                                    原幣未稅,
                                                                    台幣未稅,
                                                                    稅,
                                                                    金額,
                                                                    原幣沖帳金額,
                                                                    台幣沖帳金額,
                                                                    折讓金額,
                                                                    匯差,
                                                                    備註,
                                                                    帳務識別碼
                                                                )
                                                                VALUES
                                                                (   
	                                                                @單號 -- varchar(30)
                                                                    ,@收付別 -- nchar(10)
                                                                    ,@帳款來源 -- nchar(30)
                                                                    ,@收款性質 -- nchar(20)
                                                                    ,@帳款日期 -- smalldatetime
                                                                    ,@沖帳碼 -- nchar(20)
                                                                    ,@原幣未稅 -- numeric(18, 0)
                                                                    ,@台幣未稅 -- numeric(18, 0)
                                                                    ,@稅 -- numeric(18, 0)
                                                                    ,@金額 -- numeric(18, 0)
                                                                    ,@原幣沖帳金額 -- numeric(18, 0)
                                                                    ,@台幣沖帳金額 -- numeric(18, 0)
                                                                    ,@折讓金額 -- numeric(18, 0)
                                                                    ,@匯差 -- numeric(18, 0)
                                                                    ,@備註 -- nvarchar(50)
                                                                    ,@帳務識別碼 -- int
                                                                    )";
                            retInt += conn.Execute(insertWriteOffDetailSQL, dynamicParameters, tran);
                        }
                        tran.Commit();
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
            return retInt;
            //throw new NotImplementedException();
        }

        private F沖款收 formWriteOffFromAR(F收款 form)
        {
            string writeOffNo = getARWriteOffNo();
            F沖款收 retForm = new F沖款收(form);
            retForm.單號 = writeOffNo;
            foreach(var item in retForm.writeOffDetailList)
            {
                item.單號 = writeOffNo;
            }
            return retForm;
        }

        public string getARWriteOffNo()
        {
            string strRet = string.Empty;
            try
            {
                using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    conn.Open();
                    string strSQL = $@"SELECT COUNT(0) FROM F沖款收 WHERE 單號 LIKE '{DateTime.Now.ToString("yyyyMM")}%'";
                    int count = conn.QueryFirst<int>(strSQL);
                    count++;
                    strRet = $@"BR{DateTime.Now.ToString("yyyyMM")}{count.ToString("000")}";
                }
            }
            catch (Exception)
            {

                throw;
            }
            return strRet;
            //throw new NotImplementedException();
        }

        // ── 依單號查詢單一收款單資料，明細僅取「應收」的沖帳列 ────────────────────
        public F沖款收 getWriteOffByNo(string no)
        {
            try
            {
                using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    conn.Open();
                    var form = conn.QueryFirstOrDefault<F沖款收>("SELECT * FROM F沖款收 WHERE 單號=@no", new { no });
                    if (form != null)
                    {
                        form.writeOffDetailList = conn.Query<F收支沖帳明細>(
                            "SELECT * FROM F收支沖帳明細 WHERE 單號=@no AND 收付別='應收'", new { no }).ToList();
                    }
                    return form;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static string SQL_INSERT_F沖款收 = $@"INSERT INTO dbo.F沖款收
                                                    ( 日期, 單號, 客戶編號, 幣別, 匯率, 請款人員, MACHINENO, 備註,
                                                      建檔, 建檔日, 修改, 修改日, 核准, 核准日, 傳票,
                                                      收現金額, 銀轉金額, 匯費, 銀存編碼, 收票金額, 票據號碼, 收款總額 )
                                                    VALUES
                                                    ( @日期, @單號, @客戶編號, @幣別, @匯率, @請款人員, @MACHINENO, @備註,
                                                      @建檔, @建檔日, @修改, @修改日, @核准, @核准日, @傳票,
                                                      @收現金額, @銀轉金額, @匯費, @銀存編碼, @收票金額, @票據號碼, @收款總額 )";

        public static string SQL_INSERT_F收支沖帳明細_收款 = $@"INSERT INTO dbo.F收支沖帳明細
                                                    ( 單號, 收付別, 帳款來源, 收款性質, 帳款日期, 沖帳碼,
                                                      原幣未稅, 台幣未稅, 稅, 金額, 原幣沖帳金額, 台幣沖帳金額,
                                                      折讓金額, 匯差, 備註, 帳務識別碼 )
                                                    VALUES
                                                    ( @單號, @收付別, @帳款來源, @收款性質, @帳款日期, @沖帳碼,
                                                      @原幣未稅, @台幣未稅, @稅, @金額, @原幣沖帳金額, @台幣沖帳金額,
                                                      @折讓金額, @匯差, @備註, @帳務識別碼 )";

        // ── 新增收款單：手動輸入建立，明細列一律標記收付別='應收' ────────────────
        public void saveWriteOff(F沖款收 form)
        {
            try
            {
                using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    conn.Open();
                    using (var tran = conn.BeginTransaction())
                    {
                        DynamicParameters dynamicParameters = new DynamicParameters(form);
                        conn.Execute(SQL_INSERT_F沖款收, dynamicParameters, tran);
                        foreach (var item in form.writeOffDetailList ?? new List<F收支沖帳明細>())
                        {
                            item.單號 = form.單號;
                            item.收付別 = "應收";
                            dynamicParameters = new DynamicParameters(item);
                            conn.Execute(SQL_INSERT_F收支沖帳明細_收款, dynamicParameters, tran);
                        }
                        tran.Commit();
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        // ── 修改收款單：先刪除該單號既有的表頭與明細，再依畫面資料重新寫入 ──────────
        public void updateWriteOff(F沖款收 form)
        {
            try
            {
                using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    conn.Open();
                    using (var tran = conn.BeginTransaction())
                    {
                        conn.Execute("DELETE FROM F沖款收 WHERE 單號=@單號; DELETE FROM F收支沖帳明細 WHERE 單號=@單號 AND 收付別='應收'",
                            new { 單號 = form.單號 }, tran);
                        DynamicParameters dynamicParameters = new DynamicParameters(form);
                        conn.Execute(SQL_INSERT_F沖款收, dynamicParameters, tran);
                        foreach (var item in form.writeOffDetailList ?? new List<F收支沖帳明細>())
                        {
                            item.單號 = form.單號;
                            item.收付別 = "應收";
                            dynamicParameters = new DynamicParameters(item);
                            conn.Execute(SQL_INSERT_F收支沖帳明細_收款, dynamicParameters, tran);
                        }
                        tran.Commit();
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void deleteWriteOff(string no)
        {
            try
            {
                using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    conn.Open();
                    conn.Execute("DELETE FROM F沖款收 WHERE 單號=@no; DELETE FROM F收支沖帳明細 WHERE 單號=@no AND 收付別='應收'", new { no });
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        // ── 應收款導入：依客戶編號列出未結案帳款，供收款單「應收款導入」按鈕選取匯入 ──
        public List<應收帳款導入清單> getReceivableImportList(string custNo)
        {
            string sql = @"SELECT dbo_F帳款管理.對象, dbo_F帳款管理.帳款來源, dbo_F帳款管理.帳款日期, dbo_F帳款管理.沖帳碼,
                                  dbo_F帳款管理.原幣未稅, dbo_F帳款管理.幣別, dbo_F帳款管理.請款, dbo_F帳款管理.未稅,
                                  dbo_F帳款管理.稅, dbo_F帳款管理.金額, dbo_F帳款管理.備註, dbo_F帳款管理.結案,
                                  dbo_F帳款管理.請款單號, dbo_F帳款管理.發票號碼
                           FROM F帳款管理 dbo_F帳款管理
                           WHERE dbo_F帳款管理.對象=@custNo AND dbo_F帳款管理.結案<>1
                           ORDER BY dbo_F帳款管理.稅 DESC";
            try
            {
                using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    conn.Open();
                    return conn.Query<應收帳款導入清單>(sql, new { custNo }).ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void validateWriteOff(string no, bool approve, string user)
        {
            try
            {
                using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    conn.Open();
                    if (approve)
                    {
                        conn.Execute("UPDATE F沖款收 SET 核准=@user, 核准日=@date WHERE 單號=@no",
                            new { user, date = DateTime.Now.ToString("yyyy-MM-dd"), no });
                    }
                    else
                    {
                        conn.Execute("UPDATE F沖款收 SET 核准=NULL, 核准日=NULL WHERE 單號=@no", new { no });
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion
    }
}
