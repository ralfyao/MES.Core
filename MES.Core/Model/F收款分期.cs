using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MES.Core.Model
{
    public class F收款分期
    {
        public int 識別 { get; set; }
        public string? 單號 { get; set; }
        public string? 款項期別 { get; set; }
        public decimal? 成數 { get; set; }
        public decimal? 金額 { get; set; }
        public string 請款單號 { get; set; }    
    }
}
