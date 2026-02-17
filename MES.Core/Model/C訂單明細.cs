using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MES.Core.Model
{
    public class C訂單明細
    {
        public string? 識別碼 { get; set; }
        public string? 單號 { get; set; }
        public string? 產品編號 { get; set; }
        public string? 品名規格 { get; set; }
        public decimal? 數量1 { get; set; }
        public string? 單位 { get; set; }
        public decimal? 單價1 { get; set; }
        public decimal? 金額1 { get; set; }
        public string? 樣品別 { get; set; }
        public string? 描述 { get; set; }
        public string? QUONO { get; set; }
        public string? 專案序號 { get; set; }
        public string? 佣金率 { get; set; }
        public string? MTYPE { get; set; }
    }
}
