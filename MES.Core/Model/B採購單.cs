using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MES.Core.Model
{
    public class B採購單
    {
        public string 單號 { get; set; }
        public string 日期 { get; set; }
        public string 廠商編號 { get; set; }
        public string 聯絡人 { get; set; }
        public double 營業稅率 { get; set; }
        public string 幣別 { get; set; }
        public double 匯率 { get; set; }
        public string 採購人員 { get; set; }
        public string 採購類別 { get; set; }
        public string 交易條件 { get; set; }
        public string 運輸方式 { get; set; }
        public string 送貨地址 { get; set; }
        public string 貿易條件 { get; set; }
        public string 交貨日期 { get; set; }
        public bool 結案 { get; set; }
        public string 建檔 { get; set; }
        public string 建檔日 { get; set; }
        public string 修改 { get; set; }
        public string 修改日 { get; set; }
        public string 核准 { get; set; }
        public string 核准日 { get; set; }
        public string 注意事項 { get; set; }
        public List<B採購明細> procurementList { get; set; }
    }
}
