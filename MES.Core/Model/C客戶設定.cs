using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MES.Core.Model
{
    public class C客戶設定
    {
        [Key]
        public int 識別 { get; set; }
        public string COMPANY { get; set; } = "";
        public string MA { get; set; } = "";
        public string TEL { get; set; } = "";
        public string FAX { get; set; } = "";
        public string CONTACTPERSON { get; set; } = "";
        public string POSITION { get; set; } = "";
        public string EMAIL { get; set; } = "";
        public string COUNTRY { get; set; } = "";
        public string INDUSTRYCODE { get; set; } = "";
        public string INDUSTRY { get; set; } = "";
        public string MACHINEISSUE { get; set; } = "";
        public string 正航編號 { get; set; } = "";            
        public string SOURCE { get; set; } = "";
        public string RANKING { get; set; } = "";
        public string CREDIBILITY { get; set; } = "";
        public string WEBSITE { get; set; } = "";
        public string MEMO { get; set; } = "";
        public string CREDATE { get; set; } = "";
        public string ZIPCODE { get; set; } = "";
        public string ADDRESS { get; set; } = "";
        public string DADDRESS { get; set; } = "";
        public string 欄位1 { get; set; } = "";
        public string 欄位2 { get; set; } = "";
        public string MODIFYDATE { get; set; } = "";
        public string 建檔 { get; set; } = "";
        public string 修改 { get; set; } = "";
        public string 建檔日 { get; set; } = "";
        public string 修改日 { get; set; } = "";
        public string 停用日 { get; set; } = "";
        public List<C客戶連絡人清單> contactLists { get; set; } = new List<C客戶連絡人清單>();
        public List<C客戶聯絡明細> contactDetails { get; set; } = new List<C客戶聯絡明細>();
    }
}
