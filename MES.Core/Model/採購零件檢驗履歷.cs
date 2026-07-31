using System.ComponentModel.DataAnnotations;

namespace MES.Core.Model
{
    public class 採購零件檢驗履歷
    {
        [Key] public int 識別碼 { get; set; }
        public string? 零件管制單號 { get; set; }
        public string? 檢查日期 { get; set; }
        public string? 檢查人員 { get; set; }
        public string? 尺寸精度 { get; set; }
        public string? 幾何精度 { get; set; }
        public string? 材質標準 { get; set; }
        public string? 表面工藝 { get; set; }
        public string? 硬度要求 { get; set; }
        public string? 毛邊修整 { get; set; }
        public string? 微觀裂痕 { get; set; }
        public string? 原因說明 { get; set; }
    }
}
