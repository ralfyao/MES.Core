using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MES.Core.Model
{
    public class 專案應收沖款明細
    {
        public int? 識別碼 { get; set; }
        public string? 專案序號 { get; set; }
        public string? 收款日期 { get; set; }
        public string? 收款項目 { get; set; }
        public string? 交付形式 { get; set; }
        public decimal? 沖帳金額 { get; set; }
        public decimal? 實收金額 { get; set; }
        public decimal? 手續費 { get; set; }
        public string? 其他減項 { get; set; }
        public string? 折減事由 { get; set; }
        public string? 備註 { get; set; }
        public string? 沖帳人員 { get; set; }
        public string? 業務複審 { get; set; }
    }
}
