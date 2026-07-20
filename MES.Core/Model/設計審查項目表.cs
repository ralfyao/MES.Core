using System.ComponentModel.DataAnnotations;

namespace MES.Core.Model
{
    public class 設計審查項目表
    {
        [Key]
        public int 識別碼 { get; set; }
        public string? 審查項目 { get; set; }
        public bool? 選項 { get; set; }
    }
}
