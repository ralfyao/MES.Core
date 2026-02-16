using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MES.Core.Model
{
    public class F訂單交易條件
    {
        [Key]
        public int 識別碼       {get; set; }
        public string 條文編號     {get; set; }
        public string 條文名稱 { get; set; }
    }
}
