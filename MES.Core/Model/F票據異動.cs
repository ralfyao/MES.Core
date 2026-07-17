namespace MES.Core.Model
{
    public class F票據異動
    {
        public int 識別碼 { get; set; }
        public string? 收付日期 { get; set; }
        public string? 收付別 { get; set; }
        public string? 對象 { get; set; }
        public string? 兌付帳戶 { get; set; }
        public string? 兌現日期 { get; set; }
        public string? 票況 { get; set; }
        public string? 票據號碼 { get; set; }
        public string? 連結單號 { get; set; }
        public string? 對象銀行 { get; set; }
        public decimal? 金額 { get; set; }
        public string? 代收日期 { get; set; }
        public string? 傳票編號 { get; set; }
        public string? 備註 { get; set; }
        public bool? 結案 { get; set; }
    }
}
