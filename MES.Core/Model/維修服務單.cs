using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MES.Core.Model
{
    public class 維修服務單
    {
        public 維修服務單(客戶訴願處理單 form)
        {
            this.申請日期 = DateTime.Now.ToString("yyyy-MM-dd");
            this.客戶簡稱 = form.客戶簡稱;
            this.客戶名稱 = form.客戶名稱;
            this.專案序號 = form.專案序號;
            this.機台型號 = form.機台型號;
            this.機台名稱 = form.機台名稱;
            this.客戶聯絡窗口 = form.訴願聯絡窗口;
            this.希望服務日期 = form.回覆日期;
            this.客戶反應 = form.客戶反應;
            this.原因類別1 = form.原因類別1;
            this.原因類別2 = form.原因類別2;
            this.原因類別3 = form.原因類別3;
            this.原因鑑定1 = form.原因鑑定1;
            this.原因鑑定2 = form.原因鑑定2;
            this.原因鑑定3 = form.原因鑑定3;
            this.簡要描述1 = form.簡要描述1;
            this.簡要描述2 = form.簡要描述2;
            this.簡要描述3 = form.簡要描述3;
        }

        public int? 識別碼 { get; set; }
        public string? 單號 { get; set; }
        public string? 申請日期 { get; set; }
        public string? 維修檢查人員 { get; set; }
        public string? 服務型態 { get; set; }
        public string? 客戶簡稱 { get; set; }
        public string? 客戶名稱 { get; set; }
        public string? 專案序號 { get; set; }
        public string? 機台型號 { get; set; }
        public string? 機台類型 { get; set; }
        public string? 機台名稱 { get; set; }
        public string? 客戶聯絡窗口 { get; set; }
        public string? 維修地點 { get; set; }
        public string? 希望服務日期 { get; set; }
        public string? 實際服務日期 { get; set; }
        public string? 故障情形 { get; set; }
        public string? 處置建議 { get; set; }
        public string? 零件工令編號 { get; set; }
        public string? 客戶反應 { get; set; }
        public string? 維修結案日期 { get; set; }
        public int? 維修服務時數 { get; set; }
        public bool? 轉零件申請 { get; set; }
        public string? 建檔 { get; set; }
        public string? 修改 { get; set; }
        public string? 核准 { get; set; }
        public string? 建檔日 { get; set; }
        public string? 修改日 { get; set; }
        public string? 核准日 { get; set; }
        public string? 原因類別1 { get; set; }
        public string? 簡要描述1 { get; set; }
        public string? 原因鑑定1 { get; set; }
        public string? 原因類別2 { get; set; }
        public string? 簡要描述2 { get; set; }
        public string? 原因鑑定2 { get; set; }
        public string? 原因類別3 { get; set; }
        public string? 簡要描述3 { get; set; }
        public string? 原因鑑定3 { get; set; }
    }
}
