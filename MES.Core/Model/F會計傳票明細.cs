using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MES.Core.Model
{
    public class F會計傳票明細
    {
        public int 識別碼 { get; set; }
        public string 單號 { get; set; }
        public string 會科代碼 { get; set; }
        public string? 會計科目 { get; set; }
        public string 摘要 { get; set; }
        public decimal 借方 { get; set; }
        public decimal 貸方 { get; set; }
        public string 備註 { get; set; }
        public string 來源單據 { get; set; }
    }
}
