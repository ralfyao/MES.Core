using System.ComponentModel.DataAnnotations;

namespace MES.Core.Model
{
    public class 設計模組表
    {
        [Key] public int 識別碼 { get; set; }
        public string? 模組名稱 { get; set; }
        public string? 檢查分類 { get; set; }
    }
}
