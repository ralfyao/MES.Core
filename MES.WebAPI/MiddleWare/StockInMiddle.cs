using Dapper;
using MES.Core.Model;
using MES.Core.Repository;
using MES.Core.Repository.Impl;
using System.Data.SqlClient;

namespace MES.WebAPI.MiddleWare
{
    public class StockInMiddle
    {
        public string SQL_INSERT_B進貨驗收單 = $@"INSERT INTO dbo.B進貨驗收單
                                                (
                                                    單號,
                                                    日期,
                                                    倉管人員,
                                                    備註,
                                                    建檔,
                                                    建檔日,
                                                    修改,
                                                    修改日,
                                                    核准,
                                                    核准日,
                                                    採購覆核,
                                                    覆核日,
                                                    傳票
                                                )
                                                VALUES
                                                (   
                                                    @單號		,
                                                    @日期		,
                                                    @倉管人員	,
                                                    @備註		,
                                                    @建檔		,
                                                    @建檔日		,
                                                    @修改		,
                                                    @修改日		,
                                                    @核准		,
                                                    @核准日		,
                                                    @採購覆核	,
                                                    @覆核日		,
                                                    @傳票		
                                                )";
        public string SQL_INSERT_B進退貨驗收明細 = $@"INSERT INTO dbo.B進退貨驗收明細
                                                        (
                                                            單號,
                                                            廠商編號,
                                                            品項編號,
                                                            品名規格,
                                                            批號,
                                                            收貨數量,
                                                            合格數量,
                                                            特採數量,
                                                            退回數量,
                                                            實際單價,
                                                            折讓金額,
                                                            付款金額,
                                                            樣品,
                                                            採購單號,
                                                            退貨單號,
                                                            包裝單號,
                                                            勾選
                                                        )
                                                        VALUES
                                                        (   @單號,    -- 單號 - nvarchar(20)
                                                            @廠商編號,    -- 廠商編號 - nvarchar(20)
                                                            @品項編號,    -- 品項編號 - nvarchar(30)
                                                            @品名規格,    -- 品名規格 - nvarchar(50)
                                                            @批號,    -- 批號 - nvarchar(30)
                                                            @收貨數量, -- 收貨數量 - float
                                                            @合格數量, -- 合格數量 - float
                                                            @特採數量, -- 特採數量 - float
                                                            @退回數量, -- 退回數量 - float
                                                            @實際單價, -- 實際單價 - float
                                                            @折讓金額, -- 折讓金額 - float
                                                            @付款金額, -- 付款金額 - float
                                                            @樣品, -- 樣品 - bit
                                                            @採購單號,    -- 採購單號 - nvarchar(20)
                                                            @退貨單號,    -- 退貨單號 - nvarchar(10)
                                                            @包裝單號,    -- 包裝單號 - nvarchar(10)
                                                            @勾選 -- 勾選 - bit
                                                            )";
        public List<B進貨驗收單> allStockInLists(string stockInNo = "")
        {
            List<B進貨驗收單> list = new List<B進貨驗收單>();
            StockInRepository repository = new StockInRepository();
            try
            {
                if (string.IsNullOrEmpty(stockInNo))
                {
                    list = repository.GetList(null, "", "");
                }
                else
                {
                    list = repository.GetListBy(new B進貨驗收單() {  單號 = stockInNo }, "", "");
                }
            }
            catch (Exception)
            {

                throw;
            }
            return list;
        }

        public string getFormNo()
        {
            string formNo = string.Empty;
            try
            {
                using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    conn.Open();
                    string sql = $@"SELECT COUNT(0) FROM B進貨驗收單 WHERE 單號 LIKE 'PR{DateTime.Now.ToString("yyyyMMdd")}%'";
                    var data = conn.Query<int>(sql).FirstOrDefault();
                    if (data == null)
                        data = 0;
                    return $"PR{DateTime.Now.ToString("yyyyMMdd")}{(++data).ToString("00")}";
                }
            }
            catch (Exception)
            {

                throw;
            }
            return formNo;
        }
        public List<H員工清冊> queryWareHouseWorker()
        {
            List<H員工清冊> list = new List<H員工清冊>();
            HumanResourceRepository humanResourceRepository = new HumanResourceRepository();
            try
            {
                list = humanResourceRepository.GetList(null, "", "").Where(x => x.職能 == "倉管" && x.狀況 == "正常" ).ToList();
            }
            catch (Exception)
            {
                throw;
            }
            return list;
        }

        public List<B進退貨驗收明細> getStockInDetail(string 單號)
        {
            List<B進退貨驗收明細> list = new List<B進退貨驗收明細>();
            try
            {
                string sql = $@"SELECT * FROM B進退貨驗收明細 WHERE 單號='{單號}'";
                using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    conn.Open();
                    list = conn.Query<B進退貨驗收明細>(sql).ToList();
                }
            }
            catch (Exception)
            {

                throw;
            }
            return list;
        }

        public void saveUpdateStockInForm(B進貨驗收單 form)
        {
            try
            {
                DynamicParameters dynamicParameters = new DynamicParameters(form);
                using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    conn.Open();
                    using (var tran = conn.BeginTransaction())
                    {
                        conn.Execute($@"DELETE FROM B進貨驗收單 WHERE 單號=@單號", dynamicParameters, tran);
                        conn.Execute(SQL_INSERT_B進貨驗收單, dynamicParameters, tran);
                        foreach(var item in form.detailList)
                        {
                            if (string.IsNullOrEmpty(item.單號))
                            {
                                item.單號 = form.單號;
                            }
                            dynamicParameters = new DynamicParameters(item);
                            conn.Execute($@"DELETE FROM B進退貨驗收明細 WHERE 識別碼=@識別碼", dynamicParameters, tran);
                            conn.Execute(SQL_INSERT_B進退貨驗收明細, dynamicParameters, tran);
                        }
                        tran.Commit();
                    }
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public void deleteStockInForm(B進貨驗收單 form)
        {
            try
            {
                DynamicParameters dynamicParameters = new DynamicParameters(form);
                using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    conn.Open();
                    using (var tran = conn.BeginTransaction())
                    {
                        conn.Execute($@"DELETE FROM B進貨驗收單 WHERE 單號=@單號", dynamicParameters, tran);
                        //conn.Execute(SQL_INSERT_B進貨驗收單, dynamicParameters, tran);
                        foreach (var item in form.detailList)
                        {
                            if (string.IsNullOrEmpty(item.單號))
                            {
                                item.單號 = form.單號;
                            }
                            dynamicParameters = new DynamicParameters(item);
                            conn.Execute($@"DELETE FROM B進退貨驗收明細 WHERE 識別碼=@識別碼", dynamicParameters, tran);
                            //conn.Execute(SQL_INSERT_B進退貨驗收明細, dynamicParameters, tran);
                        }
                        tran.Commit();
                    }
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
