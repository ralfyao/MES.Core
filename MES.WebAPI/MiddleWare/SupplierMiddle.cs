using Dapper;
using MES.Core.Model;
using MES.Core.Repository;
using MES.Core.Repository.Impl;
using MES.WebAPI.Models;
using Microsoft.SqlServer.Server;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
                SupplierContactDataRepository supplierContactDataRepository = new SupplierContactDataRepository();
                list = supplierMiddle.GetList((B廠商設定)null);
                if (!string.IsNullOrEmpty(supplierNo) && supplierNo != "undefined")
                {
                    list = list.Where(x => x.廠商編號 == supplierNo).ToList();
                }
                if (!string.IsNullOrEmpty(supplierName) && supplierName != "undefined")
                {
                    list = list.Where(x => x.廠商名稱.IndexOf(supplierName) != -1).ToList();
                }
                foreach(var  item in list)
                {
                    // 詢價清單
                    B廠商供料 aItem = new B廠商供料();
                    aItem.廠商編號 = item.廠商編號;
                    item.supplyList = supplierDetailRepository.GetListBy(aItem, "廠商編號");

                    //聯絡人清單
                    B廠商聯絡名冊 bItem = new B廠商聯絡名冊();
                    bItem.客廠編號 = item.廠商編號;
                    item.contactList = supplierContactDataRepository.GetListBy(bItem, "客廠編號");
                }
            }
            catch (Exception)
            {

                throw;
            }
            return list;
        }

        public List<B廠商設定> getAllSupplierList(string? supplierNo = "", string supplierName = "")
        {
            List<B廠商設定> list = new List<B廠商設定>();
            try
            {
                SupplierRepository supplierMiddle = new SupplierRepository();
                SupplierDetailRepository supplierDetailRepository = new Core.Repository.Impl.SupplierDetailRepository();
                list = supplierMiddle.GetList(null, "", "");
                if (!string.IsNullOrEmpty(supplierNo))
                {
                    list = list.Where(x => x.廠商編號 == supplierNo).ToList();
                }
                if (!string.IsNullOrEmpty(supplierName))
                {
                    list = list.Where(x => x.廠商名稱.IndexOf(supplierName) != -1).ToList();
                }
                // 詢價清單
                foreach (var item in list)
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

        public string getSupplierNo()
        {
            string supplierNo = string.Empty;
            try
            {
                using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    string strSQL = $"SELECT COUNT(0) FROM B廠商評鑑 WHERE 單號 LIKE 'SE{DateTime.Now.ToString("yyyyMM")}%'";
                    List<string> ls = conn.Query<string>(strSQL).ToList();
                    if (ls.Count() > 0)
                    {
                        var count = int.Parse(ls[0]);
                        count++;
                        supplierNo = $"SE{DateTime.Now.ToString("yyyyMM")}{count.ToString("000")}";
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return supplierNo;
        }

        internal int insertSupplierEvaluate(B廠商評鑑 form)
        {
            int execCnt = 0;
            try
            {
                SupplierEvaluateRepository supplierEvaluateRepository = new SupplierEvaluateRepository();
                execCnt = supplierEvaluateRepository.Insert(form);
            }
            catch (Exception)
            {

                throw;
            }
            return execCnt;
        }

        public int validateSupplierEvaluate(string formNo, bool validate, string user)
        {
            int execCnt = 0;
            try
            {
                SupplierEvaluateRepository supplierEvaluateRepository = new SupplierEvaluateRepository();
                execCnt = supplierEvaluateRepository.ValidateSupplierEvaluate(formNo, validate, user);
            }
            catch (Exception)
            {

                throw;
            }
            return execCnt;
        }

        internal int validateSupplier(string formNo, bool validate, string user)
        {
            int execCnt = 0;
            try
            {
                SupplierEvaluateRepository supplierEvaluateRepository = new SupplierEvaluateRepository();
                execCnt = supplierEvaluateRepository.ValidateSupplier(formNo, validate, user);
            }
            catch (Exception)
            {

                throw;
            }
            return execCnt;
        }

        internal List<B廠商供料> getSupplierQuotationList()
        {
            List<B廠商供料> list = new List<B廠商供料>();
            try
            {
                SupplierQuotationRepository supplierEvaluateRepository = new SupplierQuotationRepository();
                list = supplierEvaluateRepository.GetList((B廠商供料)null);
            }
            catch (Exception)
            {

                throw;
            }
            return list;
        }

        internal string? get品名規格(string? 品項編號)
        {
            string 品名規格 = string.Empty;
            try
            {
                MaterialRepository materialRepository = new MaterialRepository();
                A材料 a = new A材料();
                a.產品編號 = 品項編號;
                var aMaterial = materialRepository.GetUnique(a);
                if (aMaterial != null)
                {
                    品名規格 = aMaterial.品名規格;
                }
            }
            catch(Exception)
            {
                throw;
            }
                return 品名規格;
        }

        public int activateSupplier(string formNo, bool validate, string user)
        {
            int execCnt = 0;
            try
            {
                SupplierEvaluateRepository supplierEvaluateRepository = new SupplierEvaluateRepository();
                execCnt = supplierEvaluateRepository.ActivateSupplier(formNo, validate, user);
            }
            catch (Exception)
            {

                throw;
            }
            return execCnt;
        }

        public 廠商供料List getQuotationByItem(string itemNo)
        {
            廠商供料List retObj = new 廠商供料List();
            MaterialRepository materialRepository = new MaterialRepository();
            SupplierRepository supplierRepository = new SupplierRepository();
            SupplierQuotationRepository supplierQuotationRepository = new SupplierQuotationRepository();
            try
            {
                A材料 query = new A材料();
                query.產品編號 = itemNo;
                retObj = new 廠商供料List( materialRepository.GetUnique(query));
                B廠商供料 query2 = new B廠商供料();
                query2.品項編號 = itemNo;
                B廠商設定 vendor = new B廠商設定();
                retObj.materialList = supplierQuotationRepository.GetListBy(query2, "品項編號");
                retObj.materialList.ForEach((x) =>
                {
                    vendor.廠商編號 = x.廠商編號;
                    x.廠商簡稱 = supplierRepository.GetUnique(vendor)?.廠商簡稱;
                    x.supplierList = supplierRepository.GetListBy(null, "");
                });
            }
            catch (Exception ex)
            {

                throw;
            }
            return retObj;
        }

        internal void insertSupplierQuotation(B廠商供料 item)
        {
            SupplierQuotationRepository supplierQuotationRepository = new SupplierQuotationRepository();
            supplierQuotationRepository.Insert(item);
        }

        internal void updateSupplierQuotation(B廠商供料 item)
        {
            SupplierQuotationRepository supplierQuotationRepository = new SupplierQuotationRepository();
            supplierQuotationRepository.Update(item);
        }

        internal int deleteSupplierQuotation(B廠商供料 form)
        {
            SupplierQuotationRepository supplierQuotationRepository = new SupplierQuotationRepository();
            return supplierQuotationRepository.Delete(form);
        }
    }
}
