using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MES.Core.Model
{
    public class 總務支出單列表
    {
        public string? 單號 { get; set; }
        public string? 日期 { get; set; }
        public string? 廠商編號 { get; set; }
        public string? 採購人員 { get; set; }
        public string? 採購類別 { get; set; }
        public string? 交易條件 { get; set; }
        public string? 項目編號 { get; set; }
        public string? 項目名稱 { get; set; }
        public bool? 結案 { get; set; }
        public string? 核准 { get; set; }
        public string? 姓名 { get; set; }
    }
}
