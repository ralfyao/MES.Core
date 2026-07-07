using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MES.Core.Model
{
    public class F會計科目明細
    {
        public string 識別碼 { get; set; }
        public string 會科代碼 { get; set; }
        public string 會計年度 { get; set; }
        public string 借方合計 { get; set; }
        public string 貸方合計 { get; set; }
        public string 月結餘額 { get; set; }
        public string 筆數 { get; set; }
        public string 借貸 { get; set; }
    }
}
