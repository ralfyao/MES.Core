namespace MES.Core.Model
{
    // ── 加班申請明細查詢：對應 H加班申請單 LEFT JOIN H核准加班明細 攤平列表，
    //    一張申請單可展開為多列(每段加班一列)，供「加班申請明細查詢」畫面顯示 ──
    public class 加班申請明細查詢
    {
        public string 單據編號 { get; set; }
        public string 申請單位 { get; set; }
        public string 申請人 { get; set; }
        public string 員工編號 { get; set; }
        public string 姓名 { get; set; }
        public string 加班日期 { get; set; }
        public string 起 { get; set; }
        public string 訖 { get; set; }
        public double? 時數 { get; set; }
        public string 加班事由 { get; set; }
        public bool? 核准生效 { get; set; }
        public string 核准人 { get; set; }
    }
}
