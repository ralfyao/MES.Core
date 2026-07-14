using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MES.Core.Model
{
    public class 客戶活動力分析
    {
        public string? 客戶 { get; set; }
        public string? 所屬國別 { get; set; }
        public int? 客戶建檔年度 { get; set; }
        public int? 客戶連絡次數 { get; set; }
        public int? 詢問函筆數 { get; set; }
        public int? 詢問函往來次數 { get; set; }
        public int? 報價單筆數 { get; set; }
        public string? Currency { get; set; }
        public decimal? 報價原幣金額 { get; set; }
        public decimal? 報價台幣金額 { get; set; }
        public int? 訂單筆數 { get; set; }
        public decimal? 訂單原幣金額 { get; set; }
        public decimal? 訂單台幣金額 { get; set; }
        public decimal? 換算匯率 { get; set; }
        public decimal? 單數成交率 { get; set; }
        public decimal? 金額成交率 { get; set; }
    }
}
