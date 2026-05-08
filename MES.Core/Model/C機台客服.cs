using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MES.Core.Model
{
    public class C機台客服
    {
        [Key]
        public int? 識別碼 { get; set; }
        public string? 日期 { get; set; }
        public string? 單號 { get; set; }
        public string? 客戶簡稱 { get; set; }
        public string? 專案序號 { get; set; }
        public string? 機台類型 { get; set; }
        public string? 機台型號 { get; set; }
        public string? 機台名稱 { get; set; }
        public string? 事件Events { get; set; }
        public string? 描述 { get; set; }
        public string? Keywords1 { get; set; }
        public string? Keywords2 { get; set; }
        public string? Keywords3 { get; set; }
        public string? Keywords4 { get; set; }
        public string? Keywords5 { get; set; }
        public string? 專案人員 { get; set; }
        public List<C機台客服明細> detailList { get; set; }
    }
}
