using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MES.Core.Model
{
    public class F其他收支明細
    {
        [Key]
        public int? 識別 { get; set; }
        public string? 單號 { get; set; }
        public string? 項目編號 { get; set; }
        public decimal? 原幣未稅 { get; set; }
        public decimal? 未稅 { get; set; }
        public decimal? 稅 { get; set; }
        public decimal? 金額 { get; set; }
        public string? 備註 { get; set; }
        public string? 專案序號 { get; set; }
        public int? 勾選 { get; set; }
        public string? 憑證編號 { get; set; }
    }
}
