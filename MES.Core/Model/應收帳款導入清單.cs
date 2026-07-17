namespace MES.Core.Model
{
    public class 應收帳款導入清單
    {
        public string? 對象 { get; set; }
        public string? 帳款來源 { get; set; }
        public string? 帳款日期 { get; set; }
        public string? 沖帳碼 { get; set; }
        public decimal? 原幣未稅 { get; set; }
        public string? 幣別 { get; set; }
        public string? 請款 { get; set; }
        public decimal? 未稅 { get; set; }
        public decimal? 稅 { get; set; }
        public decimal? 金額 { get; set; }
        public string? 備註 { get; set; }
        public bool? 結案 { get; set; }
        public string? 請款單號 { get; set; }
        public string? 發票號碼 { get; set; }
    }
}
