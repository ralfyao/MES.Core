using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MES.Core.Model
{
    public class 專案機台組測紀錄表頭
    {
        public string? 專案序號 { get; set; }
        public string? 機台類型 { get; set; }
        public string? 機台型號 { get; set; }
        public string? 機台名稱 { get; set; }
        public string? 客戶簡稱 { get; set; }
        public string? 國家地區 { get; set; }
        public string? 驗機日期 { get; set; }
        public string? 交貨日期 { get; set; }
        public string? 廠驗 { get; set; }
        public string? 裝機 { get; set; }
        public string? FQC製成參數 { get; set; }
        public string? OQC出機檢查 { get; set; }
        public string? MQC油壓委外單元 { get; set; }
    }
}
