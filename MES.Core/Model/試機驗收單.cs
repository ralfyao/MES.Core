namespace MES.Core.Model
{
    // ── 試機驗收單：賣方廠驗收單 為主表，RIGHT JOIN 工令單 / 產品規格單 取得
    //    表頭與規範資料的聯集查詢結果 ──────────────────────────────
    public class 試機驗收單
    {
        public string? 專案序號 { get; set; }
        public string? 日期 { get; set; }
        public string? 客戶名稱 { get; set; }
        public string? 聯絡人 { get; set; }
        public string? 電話 { get; set; }
        public string? 機台型號 { get; set; }
        public string? 機台名稱 { get; set; }
        public string? 焊接電壓v { get; set; }
        public string? 焊接電壓hz { get; set; }
        public string? 焊接電壓 { get; set; }
        public string? 生產速率 { get; set; }
        public string? 開始 { get; set; }
        public string? 結束 { get; set; }
        public bool? 規範確認1 { get; set; }
        public bool? 規範確認2 { get; set; }
        public bool? 規範確認3 { get; set; }
        public bool? 規範確認4 { get; set; }
        public bool? 規範確認5 { get; set; }
        public bool? 規範確認6 { get; set; }
        public bool? 規範確認7 { get; set; }
        public bool? 規範確認8 { get; set; }
        public bool? 規範確認9 { get; set; }
        public bool? 規範確認10 { get; set; }
        public string? 實測型號1 { get; set; }
        public int? 實測數量1 { get; set; }
        public int? 實測時間1 { get; set; }
        public string? 實測型號2 { get; set; }
        public int? 實測數量2 { get; set; }
        public int? 實測時間2 { get; set; }
        public string? 實測型號3 { get; set; }
        public int? 實測數量3 { get; set; }
        public int? 實測時間3 { get; set; }
        public string? 內容說明結果 { get; set; }
        public string? Buyer { get; set; }
        public string? Dahching { get; set; }
        public string? 控制器型號 { get; set; }
        public string? 驗收規範項目1 { get; set; }
        public string? 驗收規範說明1 { get; set; }
        public string? 驗收規範項目2 { get; set; }
        public string? 驗收規範說明2 { get; set; }
        public string? 驗收規範項目3 { get; set; }
        public string? 驗收規範說明3 { get; set; }
        public string? 驗收規範項目4 { get; set; }
        public string? 驗收規範說明4 { get; set; }
        public string? 驗收規範項目5 { get; set; }
        public string? 驗收規範說明5 { get; set; }
        public string? 驗收規範項目6 { get; set; }
        public string? 驗收規範說明6 { get; set; }
        public string? 強度 { get; set; }
        public string? 尺寸 { get; set; }
        public string? 外觀 { get; set; }
        public string? 建檔 { get; set; }
        public string? 建檔日 { get; set; }
        public string? 修改 { get; set; }
        public string? 修改日 { get; set; }
        public string? 核准日 { get; set; }
        public string? 核准 { get; set; }
        public string? 結關日期 { get; set; }
        public string? 結案 { get; set; }
        public string? 內容說明結果1 { get; set; }
        public string? S1 { get; set; }
        public string? S2 { get; set; }
        public string? S3 { get; set; }
        public string? S4 { get; set; }
        public string? S5 { get; set; }
        public string? S6 { get; set; }
        public string? S7 { get; set; }
        public string? S8 { get; set; }
        public string? S9 { get; set; }
        public string? S10 { get; set; }
    }
}
