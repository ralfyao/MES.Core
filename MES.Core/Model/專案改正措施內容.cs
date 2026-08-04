using System.ComponentModel.DataAnnotations;

namespace MES.Core.Model
{
    public class 專案改正措施內容
    {
        [Key] public int 識別碼 { get; set; }
        public string? 專案序號 { get; set; }
        public string? 事項Agenda { get; set; }
        public string? 事項中文轉譯 { get; set; }
        public string? 照片Ref { get; set; }
        public string? 說明Description { get; set; }
        public string? 說明中文轉譯 { get; set; }
        public string? 人員PIC { get; set; }
        public string? 日期Date { get; set; }
    }
}
