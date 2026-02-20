using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MES.Core.Model
{
    public class F款項期別
    {
        [Key]
        public int 序號 { get; set; }
        public string 期別名稱 { get; set; }
        public string 備註 { get; set; }
    }
}
