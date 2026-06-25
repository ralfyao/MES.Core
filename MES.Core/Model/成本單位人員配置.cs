using System.ComponentModel.DataAnnotations;

namespace MES.Core.Model
{
    public class 成本單位人員配置
    {
        [Key]
        public int 識別碼 { get; set; }
        public string 職務 { get; set; }
        public string 員工編號 { get; set; }
        public string 員工姓名 { get; set; }
        public bool? 核准 { get; set; }
        public bool? 編修 { get; set; }
        public bool? 報表 { get; set; }
        public bool? 輸出 { get; set; }
        public string 註記 { get; set; }
        public DateTime? 職務代理效期 { get; set; }
        public string 機號 { get; set; }
        // 姓名 from JOIN (not in table, filled by query)
        public string 姓名 { get; set; }
    }
}
