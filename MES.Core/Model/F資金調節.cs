using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MES.Core.Model
{
    public class F資金調節
    {
        public string? 單號 { get; set; }
        public string? 日期 { get; set; }
        public string? 用途 { get; set; }
        public string? 傳票編號 { get; set; }
        public string? 備註 { get; set; }
        public string? 建檔 { get; set; }
        public string? 建檔日 { get; set; }
        public string? 修改 { get; set; }
        public string? 修改日 { get; set; }
        public string? 核准 { get; set; }
        public string? 核准日 { get; set; }
        // 非資料庫欄位：整張單據的銀存編碼，來自明細列的 銀存編碼（同一張單只會有一個銀行帳戶）
        public string? 銀存編碼 { get; set; }
        public List<F銀行明細> detailList { get; set; } = new List<F銀行明細>();
    }
}
