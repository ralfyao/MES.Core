using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MES.Core.Model
{
    // ── 每日出勤紀錄表身扁平化 DTO：H考勤紀錄 LEFT JOIN H員工清冊(姓名) 並帶出
    //    當日假別(依 H請假紀錄 事假/病假/特休假/產假/公假/生理假/親情假/曠職
    //    何者>0 判斷，比照原 Access「日期假別查詢」邏輯) ─────────────────────
    public class 考勤紀錄列表
    {
        public int 識別碼 { get; set; }
        public string 員工編號 { get; set; }
        public string 姓名 { get; set; }
        public string 卡號 { get; set; }
        public string 班次 { get; set; }
        public string 正規上班 { get; set; }
        public string 正規下班 { get; set; }
        public string 加班上班 { get; set; }
        public string 加班下班 { get; set; }
        public double? 出勤時數 { get; set; }
        public double? 請休時數 { get; set; }
        public int? 遲到分鐘數 { get; set; }
        public int? 忘卡 { get; set; }
        public string 假別 { get; set; }
    }
}
