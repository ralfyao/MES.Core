using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MES.Core.Model
{
    public class 模組組測進度表
    {
        public string? 專案序號 { get; set; }
        public string? 模組編碼 { get; set; }
        public string? 模組名稱 { get; set; }
        public string? 開工日期 { get; set; }
        public string? 預交日期 { get; set; }
        public string? 完工日期 { get; set; }
        public double? 標準期程天數 { get; set; }
        public double? 完工期程天數 { get; set; }
        public double? 逾期天數 { get; set; }
        public double? 達交效率值 { get; set; }
        public string? 警示訊號 { get; set; }
    }
}
