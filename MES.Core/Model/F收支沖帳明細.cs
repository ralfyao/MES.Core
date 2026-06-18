using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MES.Core.Model
{
    public class F收支沖帳明細
    {
        [Key]
        public string? 識別碼 { get; set; }
        public string? 單號 { get; set; }
        public string? 收付別 { get; set; }
        public string? 帳款來源 { get; set; }
        public string? 收款性質 { get; set; }
        public string? 帳款日期 { get; set; }
        public string? 沖帳碼 { get; set; }
        public decimal? 原幣未稅 { get; set; }
        public decimal? 台幣未稅 { get; set; }
        public decimal? 稅 { get; set; }
        public decimal? 金額 { get; set; }
        public decimal? 原幣沖帳金額 { get; set; }
        public decimal? 台幣沖帳金額 { get; set; }
        public decimal? 折讓金額 { get; set; }
        public decimal? 匯差 { get; set; }
        public string? 備註 { get; set; }
        public string? 帳務識別碼 { get; set; }
    }
}
