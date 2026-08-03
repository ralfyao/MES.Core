namespace MES.Core.Model
{
    public class 專案機台程控紀錄表頭
    {
        public string? 專案序號 { get; set; }
        public string? 機台類型 { get; set; }
        public string? 機台型號 { get; set; }
        public string? 機台名稱 { get; set; }
        public string? 客戶簡稱 { get; set; }
        public string? 國家地區 { get; set; }
        public string? 驗機日期 { get; set; }
        public string? 交貨日期 { get; set; }
        public string? 廠驗 { get; set; }
        public string? 裝機 { get; set; }
        public string? MQC自動化程控 { get; set; }
        public bool? IO表 { get; set; }
        public bool? 電控迴路圖 { get; set; }
        public bool? PLC階梯圖原始檔 { get; set; }
        public bool? 人機介面原始檔 { get; set; }
        public bool? 電控箱配置圖 { get; set; }
        public bool? 電控用料表 { get; set; }
    }
}
