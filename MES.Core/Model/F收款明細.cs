using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MES.Core.Model
{
    public class F收款明細
    {
        [Key]
        public int? 識別碼 { get; set; }
        public string? 單號 { get; set; }
        public string? 帳款來源 { get; set; }
        public string? 沖帳碼 { get; set; }
        public decimal? 原幣收帳金額 { get; set; }
        public decimal? 台幣換算金額 { get; set; }
        public string? 說明 { get; set; }
        public string? 專案序號 { get; set; }
    }
}
