using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MES.Core.Model
{
    public class A使用者授權
    {
        [Key]
        public int? 識別碼{get; set; }
        public string? 職務{get; set; }
        public string? 員工編號{get; set; }
        public string? 員工姓名{get; set; }
        public bool? 高管 { get; set; }
        public bool? 核准{get; set; }
        public bool? 編修{get; set; }
        public bool? 報表{get; set; }
        public bool? 輸出{get; set; }
        public string? 註記{get; set; }
        public string? 職務代理效期{get; set; }
        public string? 機號{get; set; }
        public string? 授權表單{get; set; }
        public string? 授權子表單 { get; set; }
    }
}
