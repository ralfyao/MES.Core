using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MES.Core.Model
{
    // ── 日曆總覽/每日出勤表表頭：對應 H日曆，一天一筆 ─────────────────────
    public class H日曆
    {
        public string 日期 { get; set; }
        public bool? 例假日 { get; set; }
        public string 公告事項 { get; set; }
        public string 人事經辦 { get; set; }
        public bool? 核准生效 { get; set; }
        public string 核准人 { get; set; }
        public bool? 導入卡鐘資料 { get; set; }
        public string 導入時間 { get; set; }
    }
}
