using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MES.Core.Model
{
    public class 設計審圖總覽
    {
        public string? 清單編號 { get; set; }
        public string? 專案序號 { get; set; }
        public string? 模組編碼 { get; set; }
        public string? 模組名稱 { get; set; }
        public string? 設計人員 { get; set; }
        public string? 製圖檔名 { get; set; }
        public string? 圖檔發行日 { get; set; }
        public bool? 審圖通過 { get; set; }
        public string? 發行人員 { get; set; }
        public string? 設變 { get; set; }
        public bool? 已發行 { get; set; }
    }
}
