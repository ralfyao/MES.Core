using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MES.Core.Model
{
    public class 模組零件採購進度表
    {
        public string? 專案序號 { get; set; }
        public string? 模組編碼 { get; set; }
        public string? 模組名稱 { get; set; }
        public int? 零件號碼之筆數 { get; set; }
        public int? 數量之筆數 { get; set; }
        public int? 開始詢價日之筆數 { get; set; }
        public int? 實際採購日之筆數 { get; set; }
        public int? 入庫移轉日之筆數 { get; set; }
        public double? 入庫比例 { get; set; }
        public double? 缺料比例 { get; set; }
        public string? 採購信號 { get; set; }
    }
}
