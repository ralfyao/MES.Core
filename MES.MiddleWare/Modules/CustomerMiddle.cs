using Dapper;
using MES.Core.Model;
using MES.Core.Repository;
using MES.Core.Repository.Impl;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MES.MiddleWare.Modules
{
    public class CustomerMiddle
    {
        public List<C客戶設定> getCustomerList()
        {
            List<C客戶設定> Lst = new List<C客戶設定>();
            try
            {
                CustomerRepository customerRepository = new CustomerRepository();
                Lst = customerRepository.GetList(null);
                foreach(var cust in  Lst)
                {
                    cust.contactLists = customerRepository.getCustomerContactList(cust.COMPANY);
                    cust.contactDetails = customerRepository.getCustomerDetails(cust.COMPANY);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Lst;
        }
        public List<C客戶國別> getCountryList()
        {
            List<C客戶國別> Lst = new List<C客戶國別>();
            try
            {
                CustomerRepository customerRepository = new CustomerRepository();
                return customerRepository.GetCountryList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Lst;
        }
        public List<C產業代碼> getIncustryCodeList()
        {
            List<C產業代碼> Lst = new List<C產業代碼>();
            try
            {
                CustomerRepository customerRepository = new CustomerRepository();
                return customerRepository.getIndustryCode();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Lst;
        }
        public int insertCustomer(C客戶設定 cust)
        {
            int retCode = 0;
            try
            {
                CustomerRepository repository = new CustomerRepository();
                repository.Insert(cust);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return retCode;
        }

        public C客戶設定 getCustomer(int 識別)
        {
            C客戶設定 retCode = new C客戶設定();
            retCode.識別 = 識別;
            try
            {
                CustomerRepository repository = new CustomerRepository();
                retCode = repository.GetUnique(retCode);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return retCode;
        }
        public C客戶設定 getCustomerByName(string company)
        {
            C客戶設定 retCode = new C客戶設定();
            retCode.COMPANY = company;
            try
            {
                CustomerRepository repository = new CustomerRepository();
                retCode = repository.GetListBy(retCode, "COMPANY").FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return retCode;
        }

        public List<F銀行設定> getBankCodeList()
        {
            List<F銀行設定> retCode = new List<F銀行設定>();
            try
            {
                CustomerRepository customerRepository = new CustomerRepository();
                return customerRepository.getBankCodeList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return retCode;
        }

        public int updateCustomer(C客戶設定 cust)
        {
            int retCode = 0;
            try
            {
                CustomerRepository repository = new CustomerRepository();
                repository.Update(cust);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return retCode;
        }

        public int deleteCustomer(C客戶設定 cust)
        {
            int retCode = 0;
            try
            {
                CustomerRepository repository = new CustomerRepository();
                repository.Delete(cust);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return retCode;
        }

        public int setCustomerExpiry(C客戶設定 cust)
        {
            int retCode = 0;
            try
            {
                CustomerRepository repository = new CustomerRepository();
                retCode = repository.setCustomerExpiry(cust);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return retCode;
        }

        public List<C客戶詢問函> getSalesRecordList()
        {
            List<C客戶詢問函> Lst = new List<C客戶詢問函>();
            try
            {
                RFQRepository customerRepository = new RFQRepository();
                //CommonRepository<H員工清冊> commonRepository = new CommonRepository<H員工清冊>();
                //List<H員工清冊> employees = commonRepository.GetList(null);
                Lst = customerRepository.GetList(null);
                //foreach(var data in Lst)
                //{
                //    data.SALES = employees.Where(x => x.工號 == data.SALES).FirstOrDefault()?.姓名;  
                //}
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Lst;
        }

        public List<H員工清冊> getSalesList()
        {
            List<H員工清冊> Lst = new List<H員工清冊>();
            try
            {
                HumanResourceRepository customerRepository = new HumanResourceRepository();
                Lst = customerRepository.GetList(null).Where(x => x.職能 == "業務" && x.狀況 == "正常").ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Lst;
        }

        public C客戶設定 getCustByName(string companyName)
        {
            CustomerRepository customerRepository = new CustomerRepository();
            C客戶設定 cust = new C客戶設定();
            cust.COMPANY = companyName;
            try
            {
                List<C客戶設定> lst = customerRepository.GetListBy(cust, "COMPANY");
                if (lst.Count() > 0)
                {
                    cust = lst.FirstOrDefault();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return cust;
        }

        public List<C客戶連絡人清單> getContactList(string companyName)
        {
            List<C客戶連絡人清單> cs = new List<C客戶連絡人清單>();
            C客戶連絡人清單 c = new C客戶連絡人清單();
            c.COMPANY = companyName;
            try
            {
                CustomerContactRepository customerContactRepository = new CustomerContactRepository();
                cs = customerContactRepository.GetListBy(c, "COMPANY");
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return cs;
        }

        public List<C成交潛力值> getRankingList()
        {
            List<C成交潛力值> Lst = new List<C成交潛力值>();
            try
            {
                CommonRepository<C成交潛力值> repository = new CommonRepository<C成交潛力值>();
                Lst = repository.GetList(null);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Lst;
        }

        public List<C客戶動態> getCustStatusList()
        {
            List<C客戶動態> Lst = new List<C客戶動態>();
            try
            {
                CommonRepository<C客戶動態> repository = new CommonRepository<C客戶動態>();
                Lst = repository.GetList(null);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Lst;
        }

        public List<C轉介代理> getAgentOptionList()
        {
            List<C轉介代理> Lst = new List<C轉介代理>();
            try
            {
                CommonRepository<C轉介代理> repository = new CommonRepository<C轉介代理>();
                Lst = repository.GetList(null);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Lst;
        }

        public string getRfqNo()
        {
            string rfqNo = string.Empty;
            try
            {
                using(var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    string strSQL = $"SELECT COUNT(0) FROM C客戶詢問函 WHERE RFQNO LIKE 'R{DateTime.Now.ToString("yyyy")}%'";
                    List<string> ls = conn.Query<string>(strSQL).ToList();
                    if (ls.Count() > 0)
                    {
                        var count = int.Parse(ls[0]);
                        count++;
                        rfqNo = $"R{DateTime.Now.ToString("yyyy")}{count.ToString("000")}";
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return rfqNo;
        }

        public string getQuono()
        {
            string rfqNo = string.Empty;
            try
            {
                using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    string strSQL = $"SELECT COUNT(0) FROM C報價單 WHERE QUONO LIKE 'DC{DateTime.Now.ToString("yyyy")}%'";
                    List<string> ls = conn.Query<string>(strSQL).ToList();
                    if (ls.Count() > 0)
                    {
                        var count = int.Parse(ls[0]);
                        count++;
                        rfqNo = $"DC{DateTime.Now.ToString("yyyy")}{count.ToString("000")}";
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return rfqNo;
        }

        public List<C報價單> getQuotationList(string rfqNo)
        {
            List<C報價單> ls = new List<C報價單>();
            try
            {
                if (!string.IsNullOrEmpty(rfqNo))
                {
                    using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                    {
                        string strSQL = $"SELECT * FROM C報價單 WHERE RFQNO = '{rfqNo}'";
                        ls = conn.Query<C報價單>(strSQL).ToList();
                    }
                }
                else
                {
                    CommonRepository<C報價單> commonRepository = new CommonRepository<C報價單>();
                    ls = commonRepository.GetList(null);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return ls;
        }

        public List<C報價明細> getQuotationDetailList(string quoNo)
        {
            List<C報價明細> ls = new List<C報價明細>();
            try
            {
                using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    string strSQL = $"SELECT * FROM C報價明細 WHERE QUONO = '{quoNo}'";
                    ls = conn.Query<C報價明細>(strSQL).ToList();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return ls;
        }

        public List<工作紀錄A> geRfqSalesWorkRecordList(string rfqNo)
        {
            List<工作紀錄A> ls = new List<工作紀錄A>();
            try
            {
                using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    string strSQL = $@"SELECT [識別碼]
                                              ,[日誌單號]
                                              ,[工作日期] 
                                              ,[職務]
                                              ,[員工編號] 
                                              ,b.姓名
                                              ,[專案序號]
                                              ,[模組編碼]
                                              ,[模組名稱]
                                              ,[任務分類]
                                              ,[成效點數]
                                              ,[工作項目]
                                              ,[組裝零件]
                                              ,[進度]
                                              ,[本日工時]
                                              ,[特別註記]
                                              ,[單價]
                                              ,[工作簡述] 
                                              ,[SSMA_TimeStamp]
                                              ,[預計再訪]
                                          FROM [工作紀錄A] a
                                          LEFT OUTER JOIN [CHINYO].[dbo].H員工清冊 b ON a.[員工編號]=b.工號  and 職務='業務'
                                          where　1=1 AND 專案序號 = '{rfqNo}'";
                    ls = conn.Query<工作紀錄A>(strSQL).ToList();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return ls;
        }

        public int insertRfq(C客戶詢問函 custInqForm)
        {
            int retCode = 0;
            try
            {
                CustInquireyFormRepository custInquireyFormRepository = new CustInquireyFormRepository();
                retCode = custInquireyFormRepository.Insert(custInqForm);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return retCode;
        }

        public int UpdateRfq(C客戶詢問函 custInqForm)
        {
            int retCode = 0;
            try
            {
                CustInquireyFormRepository custInquireyFormRepository = new CustInquireyFormRepository();
                retCode = custInquireyFormRepository.Update(custInqForm);
            }
            catch (Exception ex)
            {

                throw;
            }
            return retCode;
        }

        public int DeleteRfq(string rfqNo)
        {
            int retCode = 0;
            try
            {
                using(var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    conn.Open();
                    conn.Execute($"DELETE FROM C客戶詢問函 WHERE RFQNO='{rfqNo}'");
                }
            }
            catch (Exception ex)
            {
                retCode = 1;
            }
            return retCode;
        }

        public List<A機台類型> getEqpType()
        {
            List<A機台類型> list = new List<A機台類型>();
            try
            {
                CommonRepository<A機台類型> commonRepository = new CommonRepository<A機台類型>();
                list = commonRepository.GetList(null);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return list;
        }

        public List<F幣別> getCurrencyList()
        {
            List<F幣別> list = new List<F幣別>();
            try
            {
                CommonRepository<F幣別> commonRepository = new CommonRepository<F幣別>();
                list = commonRepository.GetList(null);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return list;
        }

        public List<F匯率> getExRateList(string currency)
        {
            List<F匯率> list = new List<F匯率>();
            try
            {
                CommonRepository<F匯率> commonRepository = new CommonRepository<F匯率>();
                list.Add(commonRepository.GetList(null).Where(x => x.CURRENCY == currency).OrderByDescending(x => x.日期).FirstOrDefault());
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return list;
        }

        public List<F訂單交易條件> getTxCondition(string condition)
        {
            List<F訂單交易條件> fs = new List<F訂單交易條件>();
            try
            {
                using(var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    conn.Open();
                    fs = conn.Query<F訂單交易條件>($"SELECT * FROM F訂單交易條件 WHERE 條文編號 LIKE '{condition}%' AND 條文名稱 IS NOT NULL").ToList();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return fs;
        }

        public int saveQuotation(C報價單 form)
        {
            int retCode = 0;
            try
            {
                CustomerQuotationRepository quotationFormRepository = new CustomerQuotationRepository();
                retCode = quotationFormRepository.Insert(form);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return retCode;
        }

        public int updateQuotation(C報價單 form)
        {
            int retCode = 0;
            try
            {
                CustomerQuotationRepository quotationFormRepository = new CustomerQuotationRepository();
                retCode = quotationFormRepository.Update(form);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return retCode;
        }

        public int deleteQuotation(C報價單 form)
        {
            int retCode = 0;
            try
            {
                CustomerQuotationRepository quotationFormRepository = new CustomerQuotationRepository();
                retCode = quotationFormRepository.DeleteQuotation(form);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return retCode;
        }

        public C報價單 getQuotation(C報價單 quo)
        {
            C報價單 retObj = new C報價單();
            using (var conn = new SqlConnection(IRepository<string>.ConnStr))
            {
                conn.Open();
                retObj = conn.Query<C報價單>($"SELECT * FROM C報價單 WHERE QUONO='{quo.QUONO}'").FirstOrDefault();
                retObj.CONDATE = !string.IsNullOrEmpty(retObj.CONDATE) ? DateTime.ParseExact(retObj.CONDATE, "MM/dd/yyyy HH:mm:ss", CultureInfo.InvariantCulture).ToString("yyyy/MM/dd") : "";
                retObj.QUODATE = !string.IsNullOrEmpty(retObj.QUODATE) ? DateTime.ParseExact(retObj.QUODATE, "MM/dd/yyyy HH:mm:ss", CultureInfo.InvariantCulture).ToString("yyyy/MM/dd") : "";
                retObj.SHIPDATE = !string.IsNullOrEmpty(retObj.SHIPDATE) ? DateTime.ParseExact(retObj.SHIPDATE, "MM/dd/yyyy HH:mm:ss", CultureInfo.InvariantCulture).ToString("yyyy/MM/dd") : "";
                retObj.quotationDetailFormList = conn.Query<C報價明細>($"SELECT * FROM C報價明細 WHERE QUONO='{quo.QUONO}'").ToList();
            }
            return retObj;
        }

        public C報價單 updateQuotationExpiry(string? quono, string? type, string? account)
        {
            C報價單 ret = new C報價單();
            try
            {
                string sql = $@"UPDATE C報價單 SET 核准='{account}', 核准日=GETDATE() WHERE QUONO='{quono}'";
                using(var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    conn.Open();
                    conn.Execute(sql);
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return ret;
        }

        public C客戶詢問函 getRfq(string rfqno)
        {
            C客戶詢問函 obj = new C客戶詢問函();
            try
            {
                
                obj.RFQNO = rfqno;
                using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    conn.Open();
                    obj = conn.Query<C客戶詢問函>($@"SELECT * FROM C客戶詢問函 WHERE RFQNO='{rfqno}'").FirstOrDefault();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return obj;
        }

        public C客戶設定 getCompany(C客戶設定 quo)
        {
            C客戶設定 obj = new C客戶設定();
            try
            {

                obj.COMPANY = quo.COMPANY;
                using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    conn.Open();
                    obj = conn.Query<C客戶設定>($@"SELECT * FROM C客戶設定 WHERE COMPANY='{obj.COMPANY}'").FirstOrDefault();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return obj;
        }

        public int transferToSalesOrder(C報價單 form)
        {
            int execCnt = 0;
            try
            {
                CustOrderRepository repository = new CustOrderRepository();
                C訂單 salesOrder = new C訂單();
                C客戶詢問函 rfq = getRfqByNo(form.RFQNO);
                C客戶設定 customer = getCustomerByName(rfq.COMPANY);
                salesOrder.客戶編號 = customer.正航編號;
                salesOrder.交貨方式 = form.交貨方式;
                salesOrder.付款方式 = form.付款方式;
                salesOrder.交貨日期 = form.交貨日期;
                salesOrder.日期 = DateTime.Now.ToString("yyyy/MM/dd");
                salesOrder.幣別 = form.CURRENCY;
                salesOrder.價格條件 = form.價格條件;
                salesOrder.佣金 = !string.IsNullOrEmpty(form.COMMISSION) ? decimal.Parse(form.COMMISSION) : 0;
                salesOrder.指配國別 = customer.COUNTRY;
                salesOrder.業務員 = form.DADDRESS;
                salesOrder.單號 = getSalesOrderNo();
                salesOrder.稅率 = form.CURRENCY == "NTD" ? "0.05" : "0";
                salesOrder.總額 = form.AMOUNT;
                salesOrder.orderListDetail = new List<C訂單明細>();
                foreach (var item in form.quotationDetailFormList)
                {
                    C訂單明細 detail = new C訂單明細();
                    detail.QUONO = form.QUONO;
                    detail.單價1 = item.單價;
                    detail.數量1 = item.數量;
                    detail.金額1 = item.金額;
                    detail.產品編號 = item.產品編號;
                    detail.品名規格 = item.品名規格;
                    detail.單號 = salesOrder.單號;
                    salesOrder.orderListDetail.Add(detail);
                }
                execCnt = repository.Insert(salesOrder);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return execCnt;
        }

        public string? getSalesOrderNo()
        {
            string salesOrderNo = string.Empty;
            try
            {
                using(var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    conn.Open();
                    string sql = $"SELECT * FROM C訂單 WHERE 單號 LIKE 'SO{DateTime.Now.ToString("yyyyMM")}%'";
                    List<C訂單> list = conn.Query<C訂單>(sql).ToList();
                    int count = list.Count();
                    count++;
                    salesOrderNo = $"SO{DateTime.Now.ToString("yyyyMM")}{count.ToString("000")}";
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return salesOrderNo;
        }
        public string? getShipOrderNo()
        {
            string shipOrderNo = string.Empty;
            try
            {
                using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    conn.Open();
                    string sql = $"SELECT * FROM C出貨單 WHERE 單號 LIKE 'SD{DateTime.Now.ToString("yyyyMM")}%'";
                    List<C訂單> list = conn.Query<C訂單>(sql).ToList();
                    int count = list.Count();
                    count++;
                    shipOrderNo = $"SD{DateTime.Now.ToString("yyyyMM")}{count.ToString("000")}";
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return shipOrderNo;
        }

        private C客戶詢問函 getRfqByNo(string? rFQNO)
        {
            C客戶詢問函 retCode = new C客戶詢問函();
            retCode.RFQNO = rFQNO;
            try
            {
                CustInquireyFormRepository repository = new CustInquireyFormRepository();
                retCode = repository.GetListBy(retCode, "RFQNO").FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return retCode;
        }

        public List<C訂單> getSalesOrderList()
        {
            List<C訂單> list = new List<C訂單>();
            try
            {
                CustOrderRepository custOrderRepository = new CustOrderRepository();
                CustOrderDetailRepository detailRepository = new CustOrderDetailRepository();
                CustAccountReceivableRepository custAccountReceivableRepository = new CustAccountReceivableRepository();
                CustomerQuotationRepository quotationRepository = new CustomerQuotationRepository();
                list = custOrderRepository.GetList(null);
                foreach(var order in list)
                {
                    C訂單明細 obj = new C訂單明細();
                    obj.單號 = order.單號;
                    order.orderListDetail = detailRepository.GetListBy(obj, "單號");
                    F收款分期 obj2 = new F收款分期();
                    obj2.單號 = order.單號;
                    order.arListDetail = custAccountReceivableRepository.GetListBy(obj2, "單號");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return list;
        }

        public List<C客戶設定> getCustomerNumberList()
        {
            List<C客戶設定> list = new List<C客戶設定>();
            try
            {
                using(var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    conn.Open();
                    string sql = $@"SELECT DISTINCT C.正航編號, C.欄位2 COMPANY, C.COMPANY COMPANYFULLNAME, C.CREDIBILITY, C.COUNTRY FROM dbo.C客戶設定 AS C
                                     WHERE 正航編號 IS NOT NULL AND 正航編號 != ''  AND LEN(正航編號)=6";
                    list = conn.Query<C客戶設定>(sql).ToList();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return list;
        }

        public C訂單 updateSalesOrderCloseFlag(bool flag, string orderNo)
        {
            C訂單 c = new C訂單();
            try
            {
                using(var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    conn.Open();
                    string sql = $@"UPDATE C訂單 SET 結案='{(flag?"1":"0")}' WHERE 單號='{orderNo}'";
                    conn.Execute(sql);
                    c = conn.Query<C訂單>($"SELECT * FROM C訂單 WHERE 單號='{orderNo}'").FirstOrDefault();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return c;
        }

        public int saveSalesOrder(C訂單 form)
        {
            int execCount = 0;
            try
            {
                CustOrderRepository custOrderRepository = new CustOrderRepository();
                execCount = custOrderRepository.Insert(form);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return execCount;
        }

        public int updateSalesOrder(C訂單 form)
        {
            int execCount = 0;
            try
            {
                CustOrderRepository custOrderRepository = new CustOrderRepository();
                execCount = custOrderRepository.Update(form);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return execCount;
        }

        public int deleteSalesOrder(string salesOrderNo)
        {
            int execCount = 0;
            try
            {
                CustOrderRepository custOrderRepository = new CustOrderRepository();
                execCount = custOrderRepository.DeleteSalesOrderByNo(salesOrderNo);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return execCount;
        }

        public List<F款項期別> getInstallmentType()
        {
            List<F款項期別> list = new List<F款項期別>();
            try
            {
                using(var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    conn.Open();
                    list = conn.Query<F款項期別>("SELECT * FROM F款項期別").ToList();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return list;
        }

        public F銀行設定 getBankInfo(string? bankAccount)
        {
            F銀行設定 obj = new F銀行設定();
            obj.銀存編碼 = bankAccount;
            try
            {
                BankInfoRepository bankInfoRepository = new BankInfoRepository();
                obj = bankInfoRepository.GetListBy(obj, "銀存編碼").FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return obj;
        }

        public List<C報價明細> getQuotationDistrubutionList(string? custNo, string? orderDate)
        {
            List<C報價明細> list = new List<C報價明細>();
            try
            {
                using(var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    conn.Open();
                    list = conn.Query<C報價明細>($@"SELECT e.* 
                                                      FROM dbo.C客戶詢問函 AS C,
	                                                       dbo.C客戶設定 AS b,
	                                                       dbo.C報價單 AS d,
	                                                       dbo.C報價明細 AS e
                                                    WHERE C.COMPANY=b.COMPANY
                                                      AND c.RFQNO=d.RFQNO
                                                      AND 正航編號='{custNo}' AND d.CONDATE >= '{orderDate}'
                                                      AND d.QUONO=e.QUONO").ToList();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return list;
        }
        /// <summary>
        /// 訂單轉出貨單
        /// </summary>
        /// <param name="form"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public int transferToShipOrder(C訂單 form)
        {
            int execCnt = 0;
            try
            {
                ShipOrderRepository repository = new ShipOrderRepository();
                C出貨單 shipOrder = new C出貨單();
                shipOrder.日期 = !string.IsNullOrEmpty(form.日期) ? DateTime.ParseExact(form.日期, "MM/dd/yyyy HH:mm:ss", CultureInfo.InvariantCulture).ToString("yyyy-MM-dd") : "";
                shipOrder.客戶編號 = form.客戶編號;
                shipOrder.單號 = getShipOrderNo();
                shipOrder.業務員 = form.業務員;
                shipOrder.幣別 = form.幣別;
                shipOrder.稅別 = form.稅別;
                shipOrder.稅率 = form.稅率;
                shipOrder.總額 = form.總額;
                shipOrder.佣金 = form.佣金;
                shipOrder.交貨地址 = form.交貨地址;
                shipOrder.指配國別 = form.指配國別;
                shipOrder.目的港 = form.目的港;
                shipOrder.價格條件 = form.價格條件;
                shipOrder.交貨方式 = form.交貨方式;
                shipOrder.付款方式 = form.付款方式;
                shipOrder.交貨日期 = form.交貨日期;
                shipOrder.Remark = form.Remark;
                foreach (var item in form.orderListDetail)
                {
                    C出貨單明細 shipOrderDetail = new C出貨單明細();
                    shipOrderDetail.單號 = shipOrder.單號;
                    shipOrderDetail.產品編號 = item.產品編號;
                    shipOrderDetail.品名規格 = item.品名規格;
                    shipOrderDetail.數量2 = item.數量1;
                    shipOrderDetail.單位 = item.單位;
                    shipOrderDetail.單價2 = item.單價1;
                    shipOrderDetail.金額2 = item.金額1;
                    shipOrderDetail.樣品別 = item.樣品別;
                    shipOrderDetail.描述 = item.描述;
                    //shipOrderDetail.倉庫別 = item.倉庫別;
                    //shipOrderDetail.ORDNO = item.ORDNO;
                    if (shipOrder.shipOrderLists == null)
                        shipOrder.shipOrderLists = new List<C出貨單明細>();
                    shipOrder.shipOrderLists.Add(shipOrderDetail);
                }
                execCnt = repository.Insert(shipOrder);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return execCnt;
        }

        public List<C出貨單> getShippingOrderList()
        {
            List<C出貨單> list = new List<C出貨單>();
            try
            {
                ShipOrderRepository shipOrderRepository = new ShipOrderRepository();
                ShipOrderDetailRepository shipOrderDetailRepository = new ShipOrderDetailRepository();
                list = shipOrderRepository.GetList(null).ToList();
                foreach(var item in list)
                {
                    C出貨單明細 obj = new C出貨單明細();
                    obj.單號 = item.單號;
                    item.shipOrderLists = shipOrderDetailRepository.GetListBy(obj, "單號").ToList();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return list;
        }

        public List<F庫別> getWarehouseList()
        {
            List<F庫別> list = new List<F庫別>();
            try
            {
                using(var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    conn.Open();
                    list = conn.Query<F庫別>($@"SELECT * FROM F庫別").ToList();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return list;
        }

        public int saveShippingOrder(C出貨單 form)
        {
            int execCnt = 0;
            try
            {
                ShipOrderRepository shipOrderRepository = new ShipOrderRepository();
                execCnt = shipOrderRepository.Insert(form);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return execCnt;
        }

        public int updateShippingOrder(C出貨單 form)
        {
            int execCnt = 0;
            try
            {
                ShipOrderRepository shipOrderRepository = new ShipOrderRepository();
                execCnt = shipOrderRepository.Update(form);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return execCnt;
        }

        public int deleteShippingOrder(string shippingOrderNo)
        {
            int execCnt = 0;
            try
            {
                using(var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    conn.Open();
                    execCnt += conn.Execute($"DELETE FROM C出貨單明細 WHERE 單號='{shippingOrderNo}'");
                    execCnt += conn.Execute($"DELETE FROM C出貨單 WHERE 單號='{shippingOrderNo}'");
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return execCnt;
        }
    }
}
