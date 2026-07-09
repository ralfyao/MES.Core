using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MES.Core.Model
{
    public class 設計派案
    {
        public string? 設計識別碼 { get; set; }
        public string? 工程表識別碼 { get; set; }
        public string? 專案序號 { get; set; }
        public string? 模組編碼 { get; set; }
        public string? 模組名稱 { get; set; }
        public string? 檢查分類 { get; set; }
        public string? 製圖 { get; set; }
        public string? 設計人員 { get; set; }
        public string? 設計圖類 { get; set; }
        public string? 製圖檔名 { get; set; }
        public string? 實際開工日 { get; set; }
        public string? 預計完工日 { get; set; }
        public string? 圖檔發行日 { get; set; }
        public string? 審圖通過 { get; set; }
        public string? 清單編號 { get; set; }
        public string? 客戶簡稱 { get; set; }
    }
}
