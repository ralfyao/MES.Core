using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MES.Core.Model
{
    public class 專案機台裝箱明細
    {
        public int? 識別碼 { get; set; }
        public string? 單號 { get; set; }
        public string? Description { get; set; }
        public decimal? QTY { get; set; }
        public string? Unit { get; set; }
        public string? Dollar1 { get; set; }
        public decimal? UnitPrice { get; set; }
        public string? Dollar2 { get; set; }
        public decimal? Amount { get; set; }
        public decimal? NWkgs { get; set; }
        public decimal? GWkgs { get; set; }
        public string? Dimensioncm { get; set; }
        public string? HSCode { get; set; }
    }
}
