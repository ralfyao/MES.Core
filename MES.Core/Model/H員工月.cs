using System.Collections.Generic;

namespace MES.Core.Model
{
    // ── 薪資月結表頭：對應 H員工月，一個結算月份一筆，表身為 H員工月工時成本 ──
    public class H員工月
    {
        public int 識別 { get; set; }
        public string 月底日 { get; set; }
        public string 年月 { get; set; }
        public bool? 月結 { get; set; }
        public bool? 選取 { get; set; }
        public string 傳票 { get; set; }
        public string 建檔 { get; set; }
        public string 建檔日 { get; set; }
        public string 修改 { get; set; }
        public string 修改日 { get; set; }
        public string 核准 { get; set; }
        public string 核准日 { get; set; }
        public List<H員工月工時成本> detailList { get; set; }
    }
}
