using System.ComponentModel.DataAnnotations;

namespace MES.Core.Model
{
    public class 專案模組BOM明細
    {
        [Key]
        public int 識別碼 { get; set; }
        public string? BOM編號 { get; set; }
        public short? 球號 { get; set; }
        public string? 零件號碼 { get; set; }
        public string? 品名 { get; set; }
        public string? 描述 { get; set; }
        public short? 數量 { get; set; }
        public string? 最後修改日期 { get; set; }
        public string? 上一階品號 { get; set; }
        public bool? 不需備料 { get; set; }
        public string? 備註 { get; set; }
        public bool? 勾選 { get; set; }
    }
}
