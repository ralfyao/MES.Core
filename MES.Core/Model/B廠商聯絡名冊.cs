using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MES.Core.Model
{
    public class B廠商聯絡名冊
    {
        [Key]
        public int? 識別{get; set; }
        public string 客廠編號{get; set; }
        public string 聯絡人{get; set; }
        public string 職稱{get; set; }
        public string 手機{get; set; }
        public string 電話{get; set; }
        public string 分機{get; set; }
        public string 傳真{get; set; }
        public string 電郵{get; set; }
        public string 分支機構{get; set; }
        public string 地址{get; set; }
    }
}
