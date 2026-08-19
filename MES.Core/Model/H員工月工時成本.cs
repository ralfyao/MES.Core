namespace MES.Core.Model
{
    // ── 薪資月結表身：對應 H員工月工時成本，一個月份下每位員工一筆薪資工時成本 ──
    public class H員工月工時成本
    {
        public int 識別 { get; set; }
        public string 工號 { get; set; }
        public string 年月 { get; set; }
        public double? 應領金額 { get; set; }
        public double? 請假扣款 { get; set; }
        public double? 遲到扣款 { get; set; }
        public double? 出勤時數 { get; set; }
    }
}
