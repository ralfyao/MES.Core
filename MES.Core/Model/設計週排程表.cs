using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MES.Core.Model
{
    public class 設計週排程表
    {
        public string? 專案序號 { get; set; }
        public string? 模組編碼 { get; set; }
        public string? 模組名稱 { get; set; }
        public string? 設計人員 { get; set; }
        public double? 第一週 { get; set; }
        public double? 第二週 { get; set; }
        public double? 第三週 { get; set; }
        public double? 第四週 { get; set; }
        public double? 第五週 { get; set; }
        public double? 第六週 { get; set; }
        public double? 過期 { get; set; }
        public double? 未排 { get; set; }
    }
}
