using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MES.Core.Model
{
    public class 組測週排程表
    {
        public string? 專案序號 { get; set; }
        public string? 模組編碼 { get; set; }
        public string? 零件號碼 { get; set; }
        public string? 品名 { get; set; }
        public string? 零件分類 { get; set; }
        public string? 驗收合格 { get; set; }
        public string? 零件管制單號 { get; set; }
        public string? P1 { get; set; }
        public string? W1 { get; set; }
        public string? P2 { get; set; }
        public string? W2 { get; set; }
        public string? P3 { get; set; }
        public string? W3 { get; set; }
        public string? P4 { get; set; }
        public string? W4 { get; set; }
    }
}
