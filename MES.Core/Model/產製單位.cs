using System.ComponentModel.DataAnnotations;

namespace MES.Core.Model
{
    public class 產製單位
    {
        [Key] public int 識別碼 { get; set; }
        public string? 產製單位名稱 { get; set; }
        public string? 分類 { get; set; }
        public string? 所在區域 { get; set; }
    }
}
