using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MES.Core.Model
{
    public class 付款沖帳總覽
    {
        public string? 單號 { get; set; }
        public string? 日期 { get; set; }
        public string? 廠商編號 { get; set; }
        public string? 廠商名稱 { get; set; }
        public string? 幣別 { get; set; }
        public decimal? 原幣未稅之總計 { get; set; }
        public decimal? 金額之總計 { get; set; }
        public decimal? 原幣沖帳金額之總計 { get; set; }
        public decimal? 台幣沖帳金額之總計 { get; set; }
        public decimal? 折讓金額之總計 { get; set; }
        public decimal? 匯差之總計 { get; set; }
        public string? 核准 { get; set; }
        public string? 核准日 { get; set; }
    }
}
