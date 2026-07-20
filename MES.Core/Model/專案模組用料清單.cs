using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MES.Core.Model
{
    public class 專案模組用料清單
    {
        public int 識別碼 { get; set; }
        public string? BOM編號 { get; set; }
        public string? 專案序號 { get; set; }
        public string? 模組編碼 { get; set; }
        public string? 模組名稱 { get; set; }
        public string? 設計人員 { get; set; }
        public string? 設計圖類 { get; set; }
        public string? 製圖檔名 { get; set; }
        public string? 圖檔發行日 { get; set; }
        public string? 發行人員 { get; set; }
        public string? 審查清單編號 { get; set; }
        public string? 建檔 { get; set; }
        public string? 修改 { get; set; }
        public string? 核准 { get; set; }
        public string? 建檔日 { get; set; }
        public string? 修改日 { get; set; }
        public string? 核准日 { get; set; }
        public string? 組裝人員 { get; set; }
        public string? 開工日期 { get; set; }
        public string? 預交日期 { get; set; }
        public string? 完工日期 { get; set; }
        public string? 結案回報 { get; set; }
        public string? 用途 { get; set; }
    }
}
