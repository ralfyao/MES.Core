using Dapper;
using MES.Core;
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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MES.MiddleWare.Modules
{
    public class CustomerMiddle
    {
        public static object rfqLock { get; set; } = new object();
        public static object soLock { get; set; } = new object(); 
        public static object quotationLock { get; set; } = new object();
        public static object shippingLock { get; set; } = new object();
        public static object customerLock { get; set; } = new object();
        public static object carLock { get; set; } = new object();
        public static object repairLock = new object();
        public List<C客戶設定> getCustomerList()
        {
            List<C客戶設定> Lst = new List<C客戶設定>();
            try
            {
                CustomerRepository customerRepository = new CustomerRepository();
                Lst = customerRepository.GetList(null, "TOP 1000").OrderBy(x=>x.正航編號).ToList();
                foreach(var cust in  Lst)
                {
                    var industry = customerRepository.getIndustryCode(cust.INDUSTRYCODE).FirstOrDefault();
                    if (industry != null)
                    {
                        cust.INDUSTRYCODE_C = industry.中分類名稱;
                        cust.INDUSTRYCODE_E = industry.英文;
                    }
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
                lock (customerLock)
                {
                    repository.Insert(cust);
                }
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
                lock (customerLock)
                {
                    repository.Update(cust);
                }
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
                lock (customerLock)
                {
                    repository.Delete(cust);
                }
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
                lock (customerLock)
                {
                    retCode = repository.setCustomerExpiry(cust);
                }
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
                Lst.ForEach((x) =>
                {
                    x.RFQDATE = Utility.ConvertDate(x.RFQDATE);
                });
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
        public string getCARNo()
        {
            string rfqNo = string.Empty;
            try
            {
                using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    string strSQL = $"SELECT COUNT(0) FROM 客戶訴願處理單 WHERE 單號 LIKE 'CH{DateTime.Now.ToString("yyyyMMdd")}%'";
                    List<string> ls = conn.Query<string>(strSQL).ToList();
                    if (ls.Count() > 0)
                    {
                        var count = int.Parse(ls[0]);
                        count++;
                        rfqNo = $"CH{DateTime.Now.ToString("yyyyMMdd")}{count.ToString("00")}";
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return rfqNo;
        }

        public List<C報價單> getQuotationList(string rfqNo, string topn = "TOP 1000")
        {
            List<C報價單> ls = new List<C報價單>();
            try
            {
                if (!string.IsNullOrEmpty(rfqNo))
                {
                    using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                    {
                        string strSQL = $"SELECT {topn} * FROM C報價單 WHERE RFQNO = '{rfqNo}'";
                        ls = conn.Query<C報價單>(strSQL).ToList();
                    }
                }
                else
                {
                    CommonRepository<C報價單> commonRepository = new CommonRepository<C報價單>();
                    ls = commonRepository.GetQuotationCustomList(null);
                }
                //ls.ForEach((x) =>
                //{
                //    C客戶詢問函 rfq = new C客戶詢問函();
                //    rfq.RFQNO = x.RFQNO;
                //    CommonRepository<C客戶詢問函> commonRepository = new CommonRepository<C客戶詢問函>();
                //    rfq = commonRepository.GetList(rfq, "RFQNO").FirstOrDefault();
                //    if (rfq != null)
                //    {
                //        CommonRepository<C客戶設定> custRepository = new CommonRepository<C客戶設定>();
                //        C客戶設定 cust = new C客戶設定();
                //        cust.COMPANY = rfq.COMPANY;
                //        cust = custRepository.GetList(cust, "COMPANY").FirstOrDefault();
                //        if (cust != null)
                //        {
                //            x.COMPANY = cust.COMPANY;
                //            x.CONTACT = cust.CONTACTPERSON;
                //        }
                //    }
                //});
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

        public List<C詢問函聯絡紀錄> geRfqSalesWorkRecordList(string rfqNo)
        {
            List<C詢問函聯絡紀錄> ls = new List<C詢問函聯絡紀錄>();
            try
            {
                using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    string strSQL = $@"SELECT b.姓名, 
                                              SERNO		,
                                              RFQNO		,
                                              RFQDATE		,
                                              DESCRIPTION	,
                                              BSNSTYPE	,
                                              SALES		,
                                              RECALL
                                          FROM [C詢問函聯絡紀錄] a
                                          LEFT OUTER JOIN H員工清冊 b ON a.SALES=b.工號  and 職能='業務'
                                          where　1=1 AND RFQNO = '{rfqNo}'";
                    ls = conn.Query<C詢問函聯絡紀錄>(strSQL).ToList();
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
                try
                {
                    var date = DateTime.ParseExact(
                                    custInqForm.RFQDATE,
                                    "yyyy/MM/dd",
                                    CultureInfo.InvariantCulture
                                );
                    custInqForm.RFQDATE = date.ToString("dd/MM/yyyy");
                } catch
                {
                    var date = DateTime.ParseExact(
                                    custInqForm.RFQDATE,
                                    "yyyy-MM-dd",
                                    CultureInfo.InvariantCulture
                                );
                    custInqForm.RFQDATE = date.ToString("dd/MM/yyyy");
                }
                CustInquireyFormRepository custInquireyFormRepository = new CustInquireyFormRepository();
                lock (rfqLock)
                {
                    custInqForm.RFQNO = getRfqNo();
                    retCode = custInquireyFormRepository.Insert(custInqForm);
                }
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
                lock (rfqLock)
                {
                    retCode = custInquireyFormRepository.Update(custInqForm);
                }
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
                    lock (rfqLock)
                    {
                        conn.Execute($"DELETE FROM C客戶詢問函 WHERE RFQNO='{rfqNo}'");
                    }
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
                lock (quotationLock)
                {
                    form.RFQNO = getRfqNo();
                    CustomerQuotationRepository quotationFormRepository = new CustomerQuotationRepository();
                    retCode = quotationFormRepository.Insert(form);
                }
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
                lock (quotationLock)
                {
                    retCode = quotationFormRepository.Update(form);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return retCode;
        }

        public int updateQuotationRemark(C報價單 form)
        {
            int retCode = 0;
            try
            {
                CustomerQuotationRepository quotationFormRepository = new CustomerQuotationRepository();
                lock (quotationLock)
                {
                    retCode = quotationFormRepository.UpdateRemark(form);
                }
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
                lock (quotationLock)
                {
                    retCode = quotationFormRepository.DeleteQuotation(form);
                }
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
                lock (quotationLock)
                {
                    string sql = $@"UPDATE C報價單 SET 核准='{account}', 核准日=GETDATE() WHERE QUONO='{quono}'";
                    using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                    {
                        conn.Open();
                        conn.Execute(sql);
                    }
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
                lock (soLock)
                {
                    CustOrderRepository repository = new CustOrderRepository();
                    C訂單 salesOrder = new C訂單();
                    C客戶詢問函 rfq = getRfqByNo(form.RFQNO);
                    C客戶設定 customer = getCustomerByName(rfq.COMPANY);
                    salesOrder.客戶編號 = customer?.正航編號??"";
                    salesOrder.交貨方式 = form.交貨方式;
                    salesOrder.付款方式 = form.付款方式;
                    salesOrder.交貨日期 = form.交貨日期;
                    salesOrder.日期 = DateTime.Now.ToString("yyyy/MM/dd");
                    salesOrder.幣別 = form.CURRENCY;
                    salesOrder.價格條件 = form.價格條件;
                    salesOrder.佣金 = !string.IsNullOrEmpty(form.COMMISSION) ? decimal.Parse(form.COMMISSION) : 0;
                    salesOrder.指配國別 = customer?.COUNTRY ?? "";
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
                CustomerRepository customerRepository = new CustomerRepository();
                HumanResourceRepository humanResourceRepository = new HumanResourceRepository();
                list = custOrderRepository.GetList(null, "TOP 1000");
                foreach(var order in list)
                {
                    C客戶設定 cust = new C客戶設定();
                    H員工清冊 employee = new H員工清冊();
                    cust.正航編號 = order.客戶編號;
                    employee.工號 = order.業務員;
                    order.客戶全稱 = customerRepository.GetListBy(cust, "正航編號").FirstOrDefault()?.COMPANY;
                    order.業務人員 = humanResourceRepository.GetListBy(employee, "工號").FirstOrDefault()?.姓名;
                    C訂單明細 obj = new C訂單明細();
                    obj.單號 = order.單號;
                    order.orderListDetail = detailRepository.GetListBy(obj, "單號");

                    using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                    {
                        order.orderListDetail.ForEach((x) =>
                        {
                            string sql = $@"SELECT * FROM C報價明細 WHERE (QUONO='{x.專案序號}' OR QUONO='{x.QUONO}' AND 產品編號='{x.產品編號}' AND 品名規格='{x.品名規格}')";
                            var result = conn.Query<C報價明細>(sql).ToList().FirstOrDefault();
                            if (result != null)
                            {
                                x.報價單價 = result.單價;
                            }
                        });
                    }
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
                lock (soLock)
                {
                    using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                    {
                        conn.Open();
                        string sql = $@"UPDATE C訂單 SET 結案='{(flag ? "1" : "0")}' WHERE 單號='{orderNo}'";
                        conn.Execute(sql);
                        c = conn.Query<C訂單>($"SELECT * FROM C訂單 WHERE 單號='{orderNo}'").FirstOrDefault();
                    }
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
                lock (soLock)
                {
                    form.單號 = getSalesOrderNo();
                    CustOrderRepository custOrderRepository = new CustOrderRepository();
                    execCount = custOrderRepository.Insert(form);
                }
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
                lock (soLock)
                {
                    CustOrderRepository custOrderRepository = new CustOrderRepository();
                    execCount = custOrderRepository.Update(form);
                    using(var conn = new SqlConnection(IRepository<string>.ConnStr))
                    {
                        conn.Open();
                        foreach (var item in form.orderListDetail)
                        {
                            string strSQL = $@"UPDATE C報價明細 SET 單價='{item.報價單價}' WHERE (QUONO='{item.QUONO}' OR QUONO='{item.專案序號}') AND 產品編號='{item.產品編號}' AND 品名規格='{item.品名規格}'";
                            conn.Execute(strSQL);
                        }
                    }
                }
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
                lock (soLock)
                {
                    CustOrderRepository custOrderRepository = new CustOrderRepository();
                    execCount = custOrderRepository.DeleteSalesOrderByNo(salesOrderNo);
                }
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
                                                      AND 正航編號='{custNo}' AND CONVERT(VARCHAR, d.CONDATE, 112) >= '{orderDate}'
                                                      AND d.QUONO=e.QUONO
                                                      AND (SELECT COUNT(0) FROM C訂單明細 WHERE (QUONO=d.QUONO OR 專案序號=d.QUONO) AND 產品編號=e.產品編號 AND 品名規格=e.品名規格) = 0").ToList();
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
                lock (shippingLock)
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
                        shipOrderDetail.ORDNO = form.單號;// 這裡要記錄訂單單號
                        shipOrderDetail.描述 = item.描述;
                        //shipOrderDetail.倉庫別 = item.倉庫別;
                        //shipOrderDetail.ORDNO = item.ORDNO;
                        if (shipOrder.shipOrderLists == null)
                            shipOrder.shipOrderLists = new List<C出貨單明細>();
                        shipOrder.shipOrderLists.Add(shipOrderDetail);
                    }
                    execCnt = repository.Insert(shipOrder);
                }
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
                CustomerMiddle customerMiddle = new CustomerMiddle();
                HumanResourceRepository humanResourceRepository = new HumanResourceRepository();
                list = shipOrderRepository.GetList(null).ToList();
                foreach(var item in list)
                {
                    C出貨單明細 obj = new C出貨單明細();
                    obj.單號 = item.單號;
                    item.shipOrderLists = shipOrderDetailRepository.GetListBy(obj, "單號").ToList();
                    item.客戶簡稱 = customerMiddle.getCustomerByCustNo(item.客戶編號)?.欄位2;
                    item.業務人員 = humanResourceRepository.GetListBy(new H員工清冊() { 工號 = item.業務員 }, "工號").FirstOrDefault()?.姓名;//customerMiddle.getCustomerByCustNo(item.業務員)?.欄位2;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return list;
        }

        private C客戶設定? getCustomerByCustNo(string? 客戶編號)
        {
            C客戶設定 retCode = new C客戶設定();
            retCode.正航編號 = 客戶編號;
            try
            {
                CustomerRepository repository = new CustomerRepository();
                retCode = repository.GetListBy(retCode, "正航編號").FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return retCode;
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
                lock (shippingLock)
                {
                    form.單號 = getShipOrderNo();
                    ShipOrderRepository shipOrderRepository = new ShipOrderRepository();
                    execCnt = shipOrderRepository.Insert(form);
                }
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
                lock (shippingLock)
                {
                    ShipOrderRepository shipOrderRepository = new ShipOrderRepository();
                    execCnt = shipOrderRepository.Update(form);
                }
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
                lock (shippingLock)
                {
                    using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                    {
                        conn.Open();
                        execCnt += conn.Execute($"DELETE FROM C出貨單明細 WHERE 單號='{shippingOrderNo}'");
                        execCnt += conn.Execute($"DELETE FROM C出貨單 WHERE 單號='{shippingOrderNo}'");
                    }
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return execCnt;
        }

        public List<C報價明細> getQuotationListByCustid(string custid)
        {
            List<C報價明細> list = new List<C報價明細>();
            try
            {
                string sql = $@"SELECT c.*, b.CONDATE, b.RFQNO 
                                  FROM dbo.C客戶詢問函 AS a
                                  LEFT OUTER JOIN C報價單 b ON a.RFQNO=b.RFQNO
                                  LEFT OUTER JOIN dbo.C報價明細 AS c ON b.QUONO=c.QUONO
                                 WHERE a.COMPANYID={custid}";
                using(var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    conn.Open();
                    list = conn.Query<C報價明細>(sql).ToList();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return list;
        }

        public List<C客戶詢問函> getRfqListByCust(string custid)
        {
            List<C客戶詢問函> list = new List<C客戶詢問函>();
            try
            {
                using(var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    conn.Open();
                    list = conn.Query<C客戶詢問函>($@"SELECT * FROM C客戶詢問函 WHERE COMPANYID='{custid}'").ToList();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return list;
        }

        public int transferToReceivable(C訂單 form)
        {
            int execCnt = 0;
            try
            {
                AccountsReceivableRepository accountsReviver = new AccountsReceivableRepository();
                CustAccountReceivableRepository c = new CustAccountReceivableRepository();
                form.AR單號 = new ARMiddle().getARNo();
                form.匯率 = decimal.Parse(getExRateList(form.幣別).Count() > 0 && getExRateList(form.幣別)[0] != null ? getExRateList(form.幣別)[0]?.匯率 : "1");
                F收款 f = new F收款(form);
                lock (soLock)
                {
                    execCnt += accountsReviver.Insert(f);
                    foreach (var item in form.arListDetail)
                    {
                        item.單號 = form.單號;
                        item.請款單號 = f.單號;
                        execCnt += c.Insert(item);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return execCnt;
        }

        public List<工令單> getProjectSerialList(string custNo)
        {
            List<工令單> list = new List<工令單>();
            try
            {
                using(var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    conn.Open();
                    string strSQL = $@"SELECT * FROM 工令單 WHERE 客戶簡稱='{custNo}'";
                    list = conn.Query<工令單>(strSQL).ToList();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return list;
        }

        public 公司基本資料 getUserCompany()
        {
            公司基本資料 data = new 公司基本資料();
            try
            {
                using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    conn.Open();
                    string strSQL = $@"SELECT * FROM 公司基本資料";
                    data = conn.Query<公司基本資料>(strSQL).ToList().FirstOrDefault();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return data;
        }

        public List<C客戶設定> getCustListByCondition(QueryCustListByConditionReq request, string topn = "TOP 1000")
        {
            List<C客戶設定> list = new List<C客戶設定>();
            try
            {
                using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    conn.Open();
                    string strSQL = $@"SELECT {topn} * FROM C客戶設定";
                    list = conn.Query<C客戶設定>(strSQL).ToList();
                    if (!string.IsNullOrEmpty(request.company))
                    {
                        list = list.Where(x => x.COMPANY.IndexOf(request.company) != -1).ToList();
                    }
                    if (!string.IsNullOrEmpty(request.companyAlias))
                    {
                        list = list.Where(x => x.欄位2.IndexOf(request.companyAlias) != -1).ToList();
                    }
                    if (!string.IsNullOrEmpty(request.custNo))
                    {
                        list = list.Where(x => x.正航編號.IndexOf(request.custNo) != -1).ToList();
                    }
                    if (!string.IsNullOrEmpty(request.country))
                    {
                        list = list.Where(x => x.COUNTRY == request.country).ToList();
                    }
                    if (!string.IsNullOrEmpty(request.industryCode))
                    {
                        list = list.Where(x => x.INDUSTRYCODE.Trim() == request.industryCode).ToList();
                    }
                    if (!string.IsNullOrEmpty(request.eqpType))
                    {
                        list = list.Where(x => x.MACHINEISSUE.IndexOf(request.eqpType) != -1).ToList();
                    }
                    if (!string.IsNullOrEmpty(request.custType))
                    {
                        list = list.Where(x => x.MA.IndexOf(request.custType) != -1).ToList();
                    }
                    if (!string.IsNullOrEmpty(request.remark))
                    {
                        list = list.Where(x => x.MEMO.IndexOf(request.remark) != -1).ToList();
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return list;
        }

        public int updateCompanyName(string? originalName, string? changeToName)
        {
            int execCnt = 0;
            try
            {
                using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    conn.Open();
                    execCnt += conn.Execute($@"BEGIN TRAN UPDATE C客戶設定 SET COMPANY='{changeToName}' WHERE COMPANY='{originalName}'
                                    UPDATE C客戶連絡人清單 SET COMPANY='{changeToName}' WHERE COMPANY='{originalName}'
                                    UPDATE C客戶聯絡明細 SET COMPANY='{changeToName}' WHERE COMPANY='{originalName}'
                                    UPDATE C客戶詢問函 SET COMPANY='{changeToName}' WHERE COMPANY='{originalName}' COMMIT TRAN;");
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return execCnt;
        }

        public string getCustNo(string country)
        {
            string ret = string.Empty;
            try
            {
                using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    conn.Open();
                    string strSQL = $@"SELECT * FROM C客戶設定 WHERE 正航編號 LIKE (SELECT RTRIM(CODE)+'%' FROM C客戶國別 WHERE 國別 = '{country}')";
                    var retList = conn.Query<string>(strSQL);
                    strSQL = $"SELECT CODE FROM C客戶國別 WHERE 國別 = '{country}'";
                    C客戶國別 custCountry = conn.QueryFirst<C客戶國別>(strSQL);
                    int cnt = retList.Count();
                    cnt++;
                    ret = custCountry.CODE.Trim()+"-"+cnt.ToString("000");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return ret;
        }

        public int updateIndustryList(List<C產業代碼> list)
        {
            int execCnt = 0;
            try
            {
                List<C產業代碼> dataToUpdate = list.Where(x => x.中分類碼.Trim() == "").ToList();
                using(var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    conn.Open();
                    using(var tran = conn.BeginTransaction())
                    {
                        try
                        {
                            foreach(var item in dataToUpdate)
                            {
                                string sql = $"SELECT * FROM C產業代碼 WHERE RTRIM(大分類碼)='{item.大分類碼.Trim()}'";
                                var rs = conn.Query<C產業代碼>(sql, null, tran).ToList();
                                int serial = rs.Count();
                                serial++;
                                string strSQL = $@"INSERT INTO dbo.C產業代碼
                                                    (
                                                        大分類碼,
                                                        大分類名稱,
                                                        中分類碼,
                                                        中分類名稱,
                                                        英文,
                                                        内容,
                                                        其他
                                                    )
                                                    VALUES
                                                    (   
	                                                    @大分類碼,
                                                        @大分類名稱,
                                                        '{item.大分類碼.Trim()}.{serial.ToString("00")}',
                                                        @中分類名稱,
                                                        @英文,
                                                        @内容,
                                                        @其他
                                                        ) ";
                                DynamicParameters dynamicParameters = new DynamicParameters(item);
                                execCnt = conn.Execute(strSQL, dynamicParameters, tran);
                            }
                            tran.Commit();
                        }
                        catch (Exception)
                        {
                            execCnt = 0;
                            tran.Rollback();
                            throw;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return execCnt;
        }
        public List<客訴及維修原因類別> getCARRepairReasonList()
        {
            List<客訴及維修原因類別> list = new List<客訴及維修原因類別>();
            try
            {
                using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    conn.Open();
                    string strSQL = "SELECT * FROM 客訴及維修原因類別";
                    list = conn.Query<客訴及維修原因類別>(strSQL).ToList();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return list;
        }
        public int saveCAR(客戶訴願處理單 form)
        {
            int retCode = 0;
            try
            {
                lock (carLock)
                {
                    form.單號 = getCARNo();
                    using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                    {
                        conn.Open();
                        string strSQL = $@"INSERT INTO dbo.客戶訴願處理單
                                        (
                                            單號,
                                            申請日期,
                                            業務人員,
                                            客戶簡稱,
                                            客戶名稱,
                                            專案序號,
                                            機台型號,
                                            機台類型,
                                            機台名稱,
                                            訴願聯絡窗口,
                                            訴願類別,
                                            訴求內容,
                                            解決對策,
                                            議決人員,
                                            初步成效確認,
                                            回覆日期,
                                            回覆摘要,
                                            客戶反應,
                                            滿意度評分,
                                            維修服務單號,
                                            轉維修,
                                            原因類別1,
                                            簡要描述1,
                                            原因鑑定1,
                                            鑑定人員1,
                                            原因類別2,
                                            簡要描述2,
                                            原因鑑定2,
                                            鑑定人員2,
                                            原因類別3,
                                            簡要描述3,
                                            原因鑑定3,
                                            鑑定人員3
                                        )
                                        VALUES
                                        (   
	                                        @單號,
	                                        @申請日期,
	                                        @業務人員,
	                                        @客戶簡稱,
	                                        @客戶名稱,
	                                        @專案序號,
	                                        @機台型號,
	                                        @機台類型,
	                                        @機台名稱,
	                                        @訴願聯絡窗口,
	                                        @訴願類別,
	                                        @訴求內容,
	                                        @解決對策,
	                                        @議決人員,
	                                        @初步成效確認,
	                                        @回覆日期,
	                                        @回覆摘要,
	                                        @客戶反應,
	                                        @滿意度評分,
	                                        @維修服務單號,
	                                        @轉維修,
	                                        @原因類別1,
	                                        @簡要描述1,
	                                        @原因鑑定1,
	                                        @鑑定人員1,
	                                        @原因類別2,
	                                        @簡要描述2,
	                                        @原因鑑定2,
	                                        @鑑定人員2,
	                                        @原因類別3,
	                                        @簡要描述3,
	                                        @原因鑑定3,
	                                        @鑑定人員3
                                            )";
                        DynamicParameters dynamicParameters = new DynamicParameters(form);
                        retCode = conn.Execute(strSQL, dynamicParameters);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return retCode;
        }
        public int updateCAR(客戶訴願處理單 form)
        {
            int execCnt = 0;
            try
            {
                lock (carLock)
                {
                    using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                    {
                        conn.Open();
                        string strSQL = $@"UPDATE dbo.客戶訴願處理單
                                        SET 申請日期 = @申請日期,
                                            業務人員 = @業務人員,
                                            客戶簡稱 = @客戶簡稱,
                                            客戶名稱 = @客戶名稱,
                                            專案序號 = @專案序號,
                                            機台型號 = @機台型號,
                                            機台類型 = @機台類型,
                                            機台名稱 = @機台名稱,
                                            訴願聯絡窗口 = @訴願聯絡窗口,
                                            訴願類別 = @訴願類別,
                                            訴求內容 = @訴求內容,
                                            解決對策 = @解決對策,
                                            議決人員 = @議決人員,
                                            初步成效確認 = @初步成效確認,
                                            回覆日期 = @回覆日期,
                                            回覆摘要 = @回覆摘要,
                                            客戶反應 = @客戶反應,
                                            滿意度評分 = @滿意度評分,
                                            維修服務單號 = @維修服務單號,
                                            轉維修 = @轉維修,
                                            原因類別1 = @原因類別1,
                                            簡要描述1 = @簡要描述1,
                                            原因鑑定1 = @原因鑑定1,
                                            鑑定人員1 = @鑑定人員1,
                                            原因類別2 = @原因類別2,
                                            簡要描述2 = @簡要描述2,
                                            原因鑑定2 = @原因鑑定2,
                                            鑑定人員2 = @鑑定人員2,
                                            原因類別3 = @原因類別3,
                                            簡要描述3 = @簡要描述3,
                                            原因鑑定3 = @原因鑑定3,
                                            鑑定人員3 = @鑑定人員3
                                        WHERE 單號=@單號";
                        DynamicParameters dynamicParameters = new DynamicParameters(form);
                        execCnt = conn.Execute(strSQL, dynamicParameters);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return execCnt;
        }
        public int updateCARRepairNo(客戶訴願處理單 form)
        {
            int execCnt = 0;
            try
            {
                lock (carLock)
                {
                    using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                    {
                        conn.Open();
                        string strSQL = $@"UPDATE dbo.客戶訴願處理單
                                        SET 維修服務單號 = @維修服務單號,
                                            轉維修 = @轉維修
                                        WHERE 單號=@單號";
                        DynamicParameters dynamicParameters = new DynamicParameters(form);
                        execCnt = conn.Execute(strSQL, dynamicParameters);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return execCnt;
        }
        public int deleteCAR(string formNo)
        {
            int execCnt = 0;
            try
            {
                lock (carLock)
                {
                    using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                    {
                        conn.Open();
                        string strSQL = $@"DELETE FROM dbo.客戶訴願處理單
                                            WHERE 單號='{formNo}'";
                        execCnt = conn.Execute(strSQL);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return execCnt;
        }
        public List<客戶訴願處理單> getCARList()
        {
            List<客戶訴願處理單> list = new List<客戶訴願處理單>();
            try
            {
                using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    conn.Open();
                    list = conn.Query<客戶訴願處理單>(@"SELECT  [識別碼]
                                                              ,[單號]
                                                              ,CONVERT(VARCHAR,[申請日期],120) [申請日期]
                                                              ,[業務人員]
                                                              ,[客戶簡稱]
                                                              ,[客戶名稱]
                                                              ,[專案序號]
                                                              ,[機台型號]
                                                              ,[機台類型]
                                                              ,[機台名稱]
                                                              ,[訴願聯絡窗口]
                                                              ,[訴願類別]
                                                              ,[訴求內容]
                                                              ,[解決對策]
                                                              ,[議決人員]
                                                              ,[初步成效確認]
                                                              ,CONVERT(VARCHAR,[回覆日期],120) [回覆日期]
                                                              ,[回覆摘要]
                                                              ,[客戶反應]
                                                              ,[滿意度評分]
                                                              ,[維修服務單號]
                                                              ,[轉維修]
                                                              ,[原因類別1]
                                                              ,[簡要描述1]
                                                              ,[原因鑑定1]
                                                              ,[鑑定人員1]
                                                              ,[原因類別2]
                                                              ,[簡要描述2]
                                                              ,[原因鑑定2]
                                                              ,[鑑定人員2]
                                                              ,[原因類別3]
                                                              ,[簡要描述3]
                                                              ,[原因鑑定3]
                                                              ,[鑑定人員3] FROM 客戶訴願處理單").ToList();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return list;
        }
        public 客戶訴願處理單 transferToRepair(客戶訴願處理單 form)
        {
            string formNo = string.Empty;
            try
            {
                RepairFormRepository repairFormRepository = new RepairFormRepository();
                維修服務單 application = new 維修服務單(form);
                lock (repairLock)
                {
                    formNo = getRepairFormNo();
                    application.單號 = formNo;
                    repairFormRepository.Insert(application);
                    form.維修服務單號 = formNo;
                    form.轉維修 = 1;
                    updateCARRepairNo(form);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return form;
        }

        public string getRepairFormNo()
        {
            string rfqNo = string.Empty;
            try
            {
                using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    string strSQL = $"SELECT COUNT(0) FROM 維修服務單 WHERE 單號 LIKE 'RS{DateTime.Now.ToString("yyyyMMdd")}%'";
                    List<string> ls = conn.Query<string>(strSQL).ToList();
                    if (ls.Count() > 0)
                    {
                        var count = int.Parse(ls[0]);
                        count++;
                        rfqNo = $"RS{DateTime.Now.ToString("yyyyMMdd")}{count.ToString("00")}";
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return rfqNo;
        }

        public List<H員工清冊> getRepairtorList()
        {
            List<H員工清冊> Lst = new List<H員工清冊>();
            try
            {
                HumanResourceRepository customerRepository = new HumanResourceRepository();
                Lst = customerRepository.GetList(null).Where(x => (x.職能 == "設計" || x.職能 == "組測" || x.職能 == "程控") && x.狀況 == "正常").ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Lst;
        }

        public List<維修服務單> getRepairTestList()
        {
            List<維修服務單> list = new List<維修服務單>();
            try
            {
                RepairFormRepository repairFormRepository = new RepairFormRepository();
                list = repairFormRepository.GetList(null).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return list;
        }
        public int saveRepairTest(維修服務單 form)
        {
            int execCnt = 0;
            try
            {
                RepairFormRepository repairFormRepository = new RepairFormRepository();
                execCnt = repairFormRepository.Insert(form);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return execCnt;
        }

        public int updateRepairTest(維修服務單 form)
        {
            int execCnt = 0;
            try
            {
                RepairFormRepository repairFormRepository = new RepairFormRepository();
                execCnt = repairFormRepository.Update(form);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return execCnt;
        }

        public int deleteRepairTest(維修服務單 form)
        {
            int execCnt = 0;
            try
            {
                RepairFormRepository repairFormRepository = new RepairFormRepository();
                execCnt = repairFormRepository.Delete(form);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return execCnt;
        }

        public int transferRepairTo零件申請單(維修服務單 form)
        {
            int execCnt = 0;
            WorkOrderMiscRepository workOrderMiscRepository = new WorkOrderMiscRepository();
            try
            {
                lock (repairLock)
                {
                    
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return execCnt;
        }

        public List<C訂單> queryOrderListByCondition(QueryOrderListByConditionReq req, string topn = "TOP 1000")
        {
            List<C訂單> list = new List<C訂單>();
            CustOrderRepository custOrderRepository = new CustOrderRepository();
            try
            {
                using(var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    conn.Open();
                    string sql = $@"SELECT {topn} * FROM C訂單 WHERE 1=1";
                    if (!string.IsNullOrEmpty(req.company))
                    {
                        sql += $@" AND (客戶編號 = '{req.company}' OR 客戶編號 IN (SELECT 正航編號 FROM C客戶設定 WHERE COMPANY LIKE '%{req.company}%'))";
                    }
                    if (!string.IsNullOrEmpty(req.country))
                    {
                        sql += $@" AND 指配國別 = '{req.country}'";
                    }
                    if (!string.IsNullOrEmpty(req.itemNo))
                    {
                        sql += $@" AND 單號 IN (SELECT 單號 FROM C訂單明細 WHERE 產品編號 LIKE '%{req.itemNo}%')";
                    }
                    if (!string.IsNullOrEmpty(req.orderDateFrom))
                    {
                        sql += $@" AND CONVERT(VARCHAR, 日期, 112) >='{req.orderDateFrom.Replace("-","")}' ";
                    }
                    if (!string.IsNullOrEmpty(req.orderDateTo))
                    {
                        sql += $@" AND CONVERT(VARCHAR, 日期, 112) <='{req.orderDateTo.Replace("-", "")}' ";
                    }
                    list = conn.Query<C訂單>(sql).ToList();
                    list.ForEach((x)=>x.orderListDetail = getOrderListDetail(x.單號));
                }
            }
            catch (Exception)
            {

                throw;
            }
            return list;
        }
        public List<C訂單明細> getOrderListDetail(string orderNo)
        {
            List<C訂單明細> list = new List<C訂單明細>();
            try
            {
                using(var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    conn.Open();
                    list = conn.Query<C訂單明細>($@"SELECT * FROM C訂單明細 WHERE 單號='{orderNo}'").ToList();
                }
            }
            catch (Exception )
            {

                throw;
            }
            return list;
        }

        public List<C報價單> queryQuotationListByCondition(QueryQuotationListByConditionReq form, string topn = "TOP 1000")
        {
            List<C報價單> list = new List<C報價單>();
            try
            {
                using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    conn.Open();
                    string sql = $@"SELECT {topn} a.*, c.COMPANY, c.CONTACTPERSON CONTACT
                                      FROM C報價單 a
                                      LEFT OUTER JOIN C客戶詢問函 b ON a.RFQNO=b.RFQNO
                                      LEFT OUTER JOIN C客戶設定 c ON b.COMPANY=c.COMPANY
                                     WHERE 1=1";
                    if (!string.IsNullOrEmpty(form.quono))
                    {
                        sql += $@" AND a.QUONO like '%{form.quono}%'";
                    }
                    if (!string.IsNullOrEmpty(form.company))
                    {
                        sql += $@" AND a.RFQNO IN (SELECT RFQNO FROM C客戶詢問函 WHERE COMPANY LIKE '%{form.company}%')";
                    }
                    if (!string.IsNullOrEmpty(form.itemNo))
                    {
                        sql += $@" AND a.QUONO IN (SELECT QUONO FROM C報價明細 WHERE 產品編號 LIKE '%{form.itemNo}%')";
                    }
                    list = conn.Query<C報價單>(sql).ToList();
                    list.ForEach((x) => x.quotationDetailFormList = getQuotationDetailList(x.QUONO));
                }
            }
            catch (Exception)
            {

                throw;
            }
            return list;
        }

        public List<維修服務單> queryRepairTestListByCondition(string? custNo, string topn = "TOP 1000")
        {
            List<維修服務單> list = new List<維修服務單>();
            try
            {
                using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    conn.Open();
                    string sql = $@"SELECT {topn} a.*
                                      FROM 維修服務單 a
                                     WHERE 1=1 ";
                    if (!string.IsNullOrEmpty(custNo) && custNo != "undefined")
                    {
                        sql += $@" AND 客戶簡稱='{custNo}'";
                    }
                    
                    list = conn.Query<維修服務單>(sql).ToList();
                }
            }
            catch (Exception)
            {

                throw;
            }
            return list;
        }

        public List<C客戶詢問函> querySalesRecordList(QuerySalesRecordListParam param)
        {
            List<C客戶詢問函> list = new List<C客戶詢問函>();
            RFQRepository rFQRepository = new RFQRepository();
            CustomerRepository customerRepository = new CustomerRepository();
            list = rFQRepository.GetList(null, "");
            try
            {
                if (!string.IsNullOrEmpty(param.startDate)) 
                {
                    list = (from l in list where DateTime.ParseExact(l.RFQDATE, "MM/dd/yyyy HH:mm:ss", CultureInfo.InvariantCulture).ToString("yyyyMMdd").CompareTo(param.startDate.Replace("/", "")) >= 0 select l).ToList();
                }
                if (!string.IsNullOrEmpty(param.endDate))
                {
                    list = (from l in list where DateTime.ParseExact(l.RFQDATE, "MM/dd/yyyy HH:mm:ss", CultureInfo.InvariantCulture).ToString("yyyyMMdd").CompareTo(param.endDate.Replace("/", "")) <= 0 select l).ToList();
                }
                if (!string.IsNullOrEmpty(param.sales))
                {
                    list = (from l in list where l.SALES == param.sales select l).ToList();
                }
                if (!string.IsNullOrEmpty(param.custName))
                {
                    list = (from l in list where l.COMPANY.IndexOf(param.custName) != -1 select l).ToList();
                }
                if (!string.IsNullOrEmpty(param.industrycode))
                {
                    list = (from l in list where l.INDUSTRYCODE == (param.industrycode) select l).ToList();
                }
                if (!string.IsNullOrEmpty(param.situation))
                {
                    list = (from l in list where l.STATUS == (param.situation) select l).ToList();
                }

                if (!string.IsNullOrEmpty(param.country))
                {
                    C客戶國別 country = (from l in customerRepository.GetCountryList() where l.CODE.Trim() == param.country select l).ToList().FirstOrDefault();
                    if (country != null)
                    {
                        list = (from l in list where l.COUNTRY == (country.國別) select l)?.ToList();
                    }
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return list;
        }

        public List<string> getRfqJobClassification(string topn = "TOP 1000")
        {
            List<string> list = new List<string>();
            try
            {
                using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    conn.Open();
                    string sql = $@"SELECT {topn} [代碼]+'-'+分類 Data
                                      FROM [CHINYO].[dbo].[H職務工作分類]
                                     WHERE 職務='業務'";
                    list = conn.Query<string>(sql).ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
            return list;
        }

        public List<string> getRfqJobs()
        {
            List<string> list = new List<string>();
            try
            {
                using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    conn.Open();
                    string sql = "SELECT DISTINCT 職務 FROM [CHINYO].[dbo].[H職務工作分類]";
                    list = conn.Query<string>(sql).ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
            return list;
        }

        public int addRfqTrackingRecord(工作紀錄A form)
        {
            int execCnt = 0;
            try
            {
                RFQRepository rFQRepository = new RFQRepository();
                execCnt = rFQRepository.InsertTrackingRecord(form);
            }
            catch (Exception)
            {

                throw;
            }
            return execCnt;
        }

        public List<C訂單明細> getSalesOrderListDetailByQuono(string quono)
        {
            List<C訂單明細> list = new List<C訂單明細>();
            try
            {
                using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    conn.Open();
                    list = conn.Query<C訂單明細>($@"SELECT a.單號
                                                           , a.識別碼
                                                           , a.產品編號
                                                           , a.品名規格
                                                           , a.數量1
                                                           , a.單位
                                                           , a.單價1
                                                           , a.金額1
                                                           , a.專案序號
                                                           , a.quono
                                                           , b.日期
                                                           , b.建檔
                                                      FROM C訂單明細 a 
                                                      LEFT OUTER JOIN C訂單 b ON a.單號=b.單號
                                                     WHERE a.QUONO='{quono}'").ToList();
                }
            }   
            catch (Exception)
            {

                throw;
            }
            return list;
        }

        public List<C訂單> getSalesOrderListByNo(string orderNo)
        {
            List<C訂單> list = new List<C訂單>();
            try
            {
                CustOrderRepository custOrderRepository = new CustOrderRepository();
                CustOrderDetailRepository detailRepository = new CustOrderDetailRepository();
                CustAccountReceivableRepository custAccountReceivableRepository = new CustAccountReceivableRepository();
                CustomerQuotationRepository quotationRepository = new CustomerQuotationRepository();
                CustomerRepository customerRepository = new CustomerRepository();
                HumanResourceRepository humanResourceRepository = new HumanResourceRepository();
                list = custOrderRepository.GetList(null, "").Where(x=>x.單號 == orderNo).ToList();
                foreach (var order in list)
                {
                    C客戶設定 cust = new C客戶設定();
                    H員工清冊 employee = new H員工清冊();
                    cust.正航編號 = order.客戶編號;
                    employee.工號 = order.業務員;
                    order.客戶全稱 = customerRepository.GetListBy(cust, "正航編號").FirstOrDefault()?.COMPANY;
                    order.業務人員 = humanResourceRepository.GetListBy(employee, "工號").FirstOrDefault()?.姓名;
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

        public List<C訂單明細> getShipOrderListBySalesOrderId(string custNo)
        {
            List<C訂單明細> list = new List<C訂單明細>();
            try
            {
                using(var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    conn.Open();
                    string sql = $@"SELECT a.*, CONVERT(VARCHAR, a1.日期, 120) 日期, a1.建檔, ISNULL(b.數量2,0) 出貨數量
                                      FROM C訂單 _a
									  LEFT OUTER JOIN C訂單明細 a ON _a.單號 = a.單號
                                      LEFT OUTER JOIN C訂單 a1 ON a.單號=a1.單號
                                      LEFT OUTER JOIN C出貨單明細 b ON a.單號 = b.ORDNO  AND a.產品編號=b.產品編號 AND a.品名規格=b.品名規格
                                     WHERE _a.客戶編號 = '{custNo}'";
                        //$@"SELECT a.*, CONVERT(VARCHAR, a1.日期, 120) 日期, a1.建檔, ISNULL(b.數量2,0) 出貨數量
                        //              FROM C訂單明細 a
                        //              LEFT OUTER JOIN C訂單 a1 ON a.單號=a1.單號
                        //              LEFT OUTER JOIN C出貨單明細 b ON a.單號 = b.ORDNO 
                        //             WHERE b.ORDNO='{salesOrderId}'";
                    list = conn.Query<C訂單明細>(sql).ToList();
                }
            }
            catch (Exception ex)
            {
                throw ex;
                throw;
            }
            return list;
        }
    }
    public class QueryCustListByConditionReq
    {
        public string? company { get; set; }
        public string? companyAlias { get; set; }
        public string? custNo { get; set; }
        public string? country { get; set; }
        public string? industryCode { get; set; }
        public string? eqpType { get; set; }
        public string? custType { get; set; }
        public string? remark { get; set; }

    }
    public class QueryOrderListByConditionReq
    {
        public string? company { get; set; }
        public string? country { get; set; }
        public string? itemNo { get; set; }
        public string? orderDateFrom { get; set; }
        public string? orderDateTo { get; set; }
    }
    public class QueryQuotationListByConditionReq
    {
        public string? quono { get; set; }
        public string? company { get; set; }
        public string? itemNo { get; set; }
    }
    public class QuerySalesRecordListParam
    {
        public string? startDate { get; set; }
        public string? endDate { get; set; }
        public string? custName { get; set; }
        public string? country { get; set; }
        public string? sales { get; set; }
        public string? situation { get; set; }
        public string? industrycode { get; set; }
    }
}
