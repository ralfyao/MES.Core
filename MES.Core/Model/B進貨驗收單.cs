using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MES.Core.Model
{
    public class B進貨驗收單
    {
        [Key]
        public string 單號 { get; set; }
        public string 日期 { get; set; }
        public string? 倉管人員 { get; set; }
        public string? 備註 { get; set; }
        public string? 建檔 { get; set; }
        public string? 建檔日 { get; set; }
        public string? 修改 { get; set; }
        public string? 修改日 { get; set; }
        public string? 核准 { get; set; }
        public string? 核准日 { get; set; }
        public string? 採購覆核 { get; set; }
        public string? 覆核日 { get; set; }
        public string? 傳票 { get; set; }
        public List<B進退貨驗收明細> detailList { get; set; } = new List<B進退貨驗收明細>();
    }
}
