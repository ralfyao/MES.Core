using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MES.Core.Model
{
    public class 可領用零件清單
    {
        public string? 產品編號 { get; set; }
        public string? 零件號碼 { get; set; }
        public string? 品名 { get; set; }
        public string? 專案序號 { get; set; }
        public string? 模組編碼 { get; set; }
        public int? 採購識別碼 { get; set; }
        public string? 模組名稱 { get; set; }
        public string? 零件管制單號 { get; set; }
        public string? 零件分類 { get; set; }
        public string? BOM編號 { get; set; }
    }
}
