using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MES.Core.Model
{
    public class F付款
    {
        [Key]
        public int? 識別碼 { get; set; }
        public string? 日期 { get; set; }
        public string? 單號 { get; set; }
        public string? 廠商編號 { get; set; }
        public string? 幣別 { get; set; }
        public decimal? 匯率 { get; set; }
        public string? 請款人員 { get; set; }
        public string? 付款日期 { get; set; }
        public string? 類別 { get; set; }
        public decimal? 付現金額 { get; set; }
        public decimal? 銀轉金額 { get; set; }
        public decimal? 匯費 { get; set; }
        public string? 銀存編碼 { get; set; }
        public decimal? 付票金額 { get; set; }
        public string? 票據號碼 { get; set; }
        public string? 付款總額 { get; set; }
        public string? MACHINENO { get; set; }
        public string? 發票號碼 { get; set; }
        public string? 備註 { get; set; }
        public string? 建檔 { get; set; }
        public string? 建檔日 { get; set; }
        public string? 修改 { get; set; }
        public string? 修改日 { get; set; }
        public string? 核准 { get; set; }
        public string? 核准日 { get; set; }
        public string? 傳票 { get; set; }
        public bool? 結案 { get; set; }
        public List<F付款明細> detailList { get; set; } = new List<F付款明細>();
    }
}
