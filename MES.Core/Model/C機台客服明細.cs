using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MES.Core.Model
{
    public class C機台客服明細
    {
        public C機台客服明細()
        {

        }
        [Key]
        public int? 識別碼 { get; set; }
        public string? 單號 { get; set; }
        public string? 日期 { get; set; }
        public string? 客戶反映 { get; set; }
        public string? 聯絡者 { get; set; }
        public string? 公司回覆 { get; set; }
        public string? 執行者 { get; set; }
        public string? 客訴單號 { get; set; }
        public string? 業務紀錄 { get; set; }
        public string? 報價單號 { get; set; }
    }
}
