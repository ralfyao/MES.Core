using System.Collections.Generic;

namespace MES.Core.Model
{
    // ── 加班申請單表頭：對應 H加班申請單，一張單一筆，表身為 H核准加班明細 ──────
    public class H加班申請單
    {
        public string 單據編號 { get; set; }
        public string 申請單位 { get; set; }
        public string 申請日期 { get; set; }
        public string 申請人 { get; set; }
        public bool? 核准生效 { get; set; }
        public string 核准人 { get; set; }
        public List<H核准加班明細> detailList { get; set; }
    }
}
