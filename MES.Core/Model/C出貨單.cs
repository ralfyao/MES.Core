using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MES.Core.Model
{
    public class C出貨單
    {
        [Key]
        public int? 識別 { get; set; }
        public string? 日期 { get; set; }
        public string? 單號 { get; set; }
        public string? 客戶編號 { get; set; }
        public string? 業務員 { get; set; }
        public string? 幣別 { get; set; }
        public decimal? 匯率 { get; set; }
        public string? 稅別 { get; set; }
        public string? 稅率 { get; set; }
        public decimal? 總額 { get; set; }
        public decimal? 佣金 { get; set; }
        public string? 原定交貨日期 { get; set; }
        public string? 交貨地址 { get; set; }
        public string? 指配國別 { get; set; }
        public string? 目的港 { get; set; }
        public string? 價格條件 { get; set; }
        public string? 交貨方式 { get; set; }
        public string? 付款方式 { get; set; }
        public string? 交貨日期 { get; set; }
        public string? Remark { get; set; }
        public string? 建檔 { get; set; }
        public string? 修改 { get; set; }
        public string? 核准 { get; set; }
        public string? 建檔日 { get; set; }
        public string? 修改日 { get; set; }
        public string? 核准日 { get; set; }
        public string? 傳票 { get; set; }
        public List<C出貨單明細> shipOrderLists { get; set; }
    }
}
