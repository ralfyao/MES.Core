using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MES.Core.Model
{
    public class F銀行明細
    {
        public int 識別碼 { get; set; }
        public string 銀存編碼 { get; set; }
        public string 日期 { get; set; }
        public string 摘要 { get; set; }
        public string 幣別 { get; set; }
        public decimal 匯率 { get; set; }
        public decimal 支出 { get; set; }
        public decimal 存入 { get; set; }
        public string 連結單號 { get; set; }
        public string 對象 { get; set; }
        public string 備註 { get; set; }
    }
}
