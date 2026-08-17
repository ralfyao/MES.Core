namespace MES.Core.Model
{
    // ── 加班申請單明細：對應 H核准加班明細，一張單可有多筆(每位員工每段加班一筆) ──
    public class H核准加班明細
    {
        public int 識別碼 { get; set; }
        public string 單據編號 { get; set; }
        public string 員工編號 { get; set; }
        public string 加班日期 { get; set; }
        public string 起 { get; set; }
        public string 訖 { get; set; }
        public double? 時數 { get; set; }
        public string 加班事由 { get; set; }
        public string 加班內容詳述 { get; set; }
        public string 備註 { get; set; }
    }
}
