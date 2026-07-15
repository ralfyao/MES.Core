using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MES.Core.Model
{
    public class 銀行月底餘額
    {
        public string? 銀存編碼 { get; set; }
        public string? 日期_月 { get; set; }
        public decimal? 存入總計 { get; set; }
        public decimal? 支出總計 { get; set; }
        public int? 筆數 { get; set; }
        public decimal? 餘額 { get; set; }
        public string? 銀行名稱 { get; set; }
        public string? 帳號 { get; set; }
        public string? 幣別 { get; set; }
    }
}
