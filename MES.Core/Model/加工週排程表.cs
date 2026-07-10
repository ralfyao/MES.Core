using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MES.Core.Model
{
    public class 加工週排程表
    {
        public string? 專案序號 { get; set; }
        public string? 模組編碼 { get; set; }
        public string? 模組名稱 { get; set; }
        public string? 零件號碼 { get; set; }
        public string? 品名 { get; set; }
        public string? 驗收日期 { get; set; }
        public string? 預計到貨日 { get; set; }
        public string? 過期 { get; set; }
        public string? 第一週 { get; set; }
        public string? 第二週 { get; set; }
        public string? 第三週 { get; set; }
        public string? 第四週 { get; set; }
        public string? 未排 { get; set; }
    }
}
