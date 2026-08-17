using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MES.Core.Model
{
    // ── 每日出勤紀錄明細：對應 H考勤紀錄，一天可有多筆(每位員工一筆) ────────
    public class H考勤紀錄
    {
        public int 識別碼 { get; set; }
        public string 員工編號 { get; set; }
        public string 日期 { get; set; }
        public string 班次 { get; set; }
        public string 正規上班 { get; set; }
        public string 正規下班 { get; set; }
        public string 加班上班 { get; set; }
        public string 加班下班 { get; set; }
        public double? 出勤時數 { get; set; }
        public double? 請休時數 { get; set; }
        public int? 遲到分鐘數 { get; set; }
        public int? 早退分鐘數 { get; set; }
        public string 卡號 { get; set; }
        public int? 忘卡 { get; set; }
        public string 備註 { get; set; }
    }
}
