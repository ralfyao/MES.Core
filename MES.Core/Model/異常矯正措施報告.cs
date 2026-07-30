using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MES.Core.Model
{
    public class 異常矯正措施報告
    {
        [Key]
        public int 識別碼 { get; set; }
        public string? 日期 { get; set; }
        public string? 單號 { get; set; }
        public string? 專案序號 { get; set; }
        public string? 模組編碼 { get; set; }
        public string? 模組名稱 { get; set; }
        public string? 零件號碼 { get; set; }
        public string? 品名 { get; set; }
        public short? 數量 { get; set; }
        public string? 異常狀況 { get; set; }
        public string? 檢查人員 { get; set; }
        public string? 原因分析 { get; set; }
        public string? 設計人員 { get; set; }
        public string? 矯正措施 { get; set; }
        public bool? 設計變更 { get; set; }
        public string? 預防對策 { get; set; }
        public string? 建檔 { get; set; }
        public string? 修改 { get; set; }
        public string? 核准 { get; set; }
        public string? 建檔日 { get; set; }
        public string? 修改日 { get; set; }
        public string? 核准日 { get; set; }
        public string? 決策人員 { get; set; }
        public string? 來源單據 { get; set; }
        public string? 異常來源 { get; set; }
    }
}
