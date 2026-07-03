using System.ComponentModel.DataAnnotations;

namespace MES.Core.Model
{
    public class A材料庫存卡
    {
        [Key]
        public int 識別碼 { get; set; }
        public string? 產品編號 { get; set; }
        public string? 異動日期 { get; set; }
        public string? 摘要 { get; set; }
        public string? 來源用途 { get; set; }
        public string? 單位 { get; set; }
        public decimal? 入庫 { get; set; }
        public decimal? 出庫 { get; set; }
        public string? 儲位 { get; set; }
        public string? 異動人員 { get; set; }
        public string? 備註 { get; set; }
    }
}
