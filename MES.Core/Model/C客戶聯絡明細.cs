using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MES.Core.Model
{
    public class C客戶聯絡明細
    {
        [Key]
        public int SERNO { get; set; }
        [Key]
        public string COMPANY { get; set; } = "";
        public string 日期 { get; set; } = "";
        public string 註記 { get; set; } = "";
        public string 業務人員 { get; set; } = "";
        public string 業務人員姓名 { get; set; } = "";
        public string RFQNO { get; set; } = "";
    }
}
