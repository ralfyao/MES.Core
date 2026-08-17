namespace MES.Core.Model
{
    // ── 員工加班紀錄表身：比照原 Access「加班分鐘核對-1」查詢結果，
    //    列出單一員工於查詢起訖日期範圍內、實際有加班上下班紀錄的每一天 ──────
    public class 員工加班紀錄列表
    {
        public string 日期 { get; set; }
        public string 班次 { get; set; }
        public string 加班上班 { get; set; }
        public string 加班下班 { get; set; }
        public double? 時數 { get; set; }
        public string 加班事由 { get; set; }
        public double? 加班時數 { get; set; }
        public double? 加班費 { get; set; }
        public double? 時薪 { get; set; }
    }
}
