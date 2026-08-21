namespace MES.Core.Model
{
    // ── 專案累計工作時數：比照原查詢「專案累計工作時數」，彙總每個專案下
    //    每位員工累計投入的工時與工時成本(工令單 LEFT JOIN 工作紀錄A LEFT
    //    JOIN H員工清冊)，僅列出實際有登載工作紀錄(員工編號/專案序號皆非
    //    空)的專案+員工組合 ─────────────────────────────────────────────
    public class 專案累計工作時數列表
    {
        public string 專案序號 { get; set; }
        public string 客戶簡稱 { get; set; }
        public string 機台型號 { get; set; }
        public string 機台名稱 { get; set; }
        public string 員工編號 { get; set; }
        public string 姓名 { get; set; }
        public double? 工時合計 { get; set; }
        public double? 工時成本合計 { get; set; }
        public bool? 結案 { get; set; }
    }
}
