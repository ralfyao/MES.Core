using Dapper;
using MES.Core.Model;
using MES.Core.Repository;
using MES.Core.Repository.Impl;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
                Lst = customerRepository.GetList(null);
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

        public List<C報價單> getQuotationList(string rfqNo)
        {
            List<C報價單> ls = new List<C報價單>();
            try
            {
                using (var conn = new SqlConnection(IRepository<string>.ConnStr))
                {
                    string strSQL = $"SELECT * FROM C報價單 WHERE RFQNO = '{rfqNo}'";
                    ls = conn.Query<C報價單>(strSQL).ToList();
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
    }
}
