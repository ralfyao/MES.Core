using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MES.Core.Model
{
    public class 電控排程進度表
    {
        public string? 專案序號 { get; set; }
        public string? 電控工序 { get; set; }
        public string? 開始作業日期 { get; set; }
        public string? 預計完成日期 { get; set; }
        public string? 實際完成日期 { get; set; }
        public double? 標準期程天數 { get; set; }
        public double? 完工期程天數 { get; set; }
        public double? 逾期天數 { get; set; }
        public double? 達交效率值 { get; set; }
        public string? 警示訊號 { get; set; }
    }
}
