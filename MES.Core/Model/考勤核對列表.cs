using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MES.Core.Model
{
    // ── 員工考勤核對(H-出勤卡)扁平化 DTO：H日曆(區間內每一天) LEFT JOIN
    //    H考勤紀錄(依員工編號過濾) 並帶出當日假別 ──────────────────────────
    public class 考勤核對列表
    {
        public string 日期 { get; set; }
        public bool? 例假日 { get; set; }
        public string 班次 { get; set; }
        public string 正規上班 { get; set; }
        public string 正規下班 { get; set; }
        public string 加班上班 { get; set; }
        public string 加班下班 { get; set; }
        public double? 出勤時數 { get; set; }
        public double? 請休時數 { get; set; }
        public int? 遲到分鐘數 { get; set; }
        public int? 早退分鐘數 { get; set; }
        public int? 忘卡 { get; set; }
        public string 備註 { get; set; }
        public string 假別 { get; set; }
        public double? 核准時數 { get; set; }
        public double? 加班費 { get; set; }
    }
}
