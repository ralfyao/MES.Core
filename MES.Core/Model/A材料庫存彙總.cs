namespace MES.Core.Model
{
    public class A材料庫存彙總
    {
        public string? 產品編號 { get; set; }
        public decimal? 入庫總計 { get; set; }
        public decimal? 出庫總計 { get; set; }
        public decimal? 結餘 { get; set; }
        public int 庫存卡筆數 { get; set; }
    }
}
