using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MES.Core.Model
{
    // ── 員工薪給結構(核薪紀錄)：對應 H員工基本資料，一個工號可有多筆(薪資歷程) ──
    public class H員工基本資料
    {
        public int 識別碼 { get; set; }
        public string 工號 { get; set; }
        public int? 職等 { get; set; }
        public int? 職級 { get; set; }
        public string 核薪日 { get; set; }
        public string 離職日 { get; set; }
        public int? 本薪 { get; set; }
        public int? 職務加給 { get; set; }
        public int? 日薪 { get; set; }
        public double? 時薪 { get; set; }
        public int? 主管津貼 { get; set; }
        public int? 全勤獎金 { get; set; }
        public int? 每日伙食津貼 { get; set; }
        public int? 其他加項 { get; set; }
        public int? 投保等級 { get; set; }
        public int? 眷保口數 { get; set; }
        public int? 勞保 { get; set; }
        public int? 健保 { get; set; }
        public int? 眷保 { get; set; }
        public int? 其他減項 { get; set; }
        public int? 退休金自提 { get; set; }
        public int? 退休公司提 { get; set; }
        public string 加班備註 { get; set; }
        public double? 扣款時薪 { get; set; }
        public string 備註一 { get; set; }
        public string 備註二 { get; set; }
        public string 備註三 { get; set; }
        public string 建檔維護 { get; set; }
        public string 核准人員 { get; set; }
    }
}
