using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MES.Core.Model
{
    public class 客訴及維修原因類別
    {
        public int 識別碼 { get; set; } = 0;
        public string 原因類別 { get; set; }
        public string 建立人員 { get; set; }
    }
}
