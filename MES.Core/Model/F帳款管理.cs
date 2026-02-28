using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MES.Core.Model
{
    public class F帳款管理
    {
        [Key]
        public int? 識別碼 { get; set; }
        public string? 識別 { get; set; }
        public string? COMPANY { get; set; }
        public string? 收付別 { get; set; }
        public string? 對象 { get; set; }
        public string? 帳款來源 { get; set; }
        public string? 收款性質 { get; set; }
        public string? 帳款日期 { get; set; }
        public string? 沖帳碼 { get; set; }
        public string? 連結單號 { get; set; }
        public string? 幣別 { get; set; }
        public decimal? 匯率 { get; set; }
        public decimal? 原幣未稅 { get; set; }
        public decimal? 未稅 { get; set; }
        public decimal? 稅 { get; set; }
        public decimal? 金額 { get; set; }
        public string? 備註 { get; set; }
        public string? 發票號碼 { get; set; }
        public string? 請款單號 { get; set; }
        public decimal? 沖帳金額 { get; set; }
        public string? 台幣沖帳 { get; set; }
        public decimal? 折讓金額 { get; set; }
        public string? 台幣折讓 { get; set; }
        public string? 結案 { get; set; }
        public string? 請款 { get; set; }
        public List<F帳款管理> detailList { get; set; }
    }
}
