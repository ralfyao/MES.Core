using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MES.Core.Model
{
    public class F收支項目設定
    {
        [Key]
        public int? 識別{get; set;}
        public string? 項目編號{get; set;}
        public string? 項目名稱 { get; set; }
        public string? 收付別 { get; set; }
        public string? 會科代碼 { get; set; }
        public string? 說明 { get; set; }
    }
}
