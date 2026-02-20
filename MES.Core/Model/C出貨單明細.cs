using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MES.Core.Model
{
    public class C出貨單明細
    {
        [Key]
        public int 識別碼 { get; set; }
        public string? 單號 { get; set; }
        public string? 產品編號 { get; set; }
        public string? 品名規格 { get; set; }
        public decimal? 數量2 { get; set; }
        public string? 單位 { get; set; }
        public decimal? 單價2 { get; set; }
        public decimal? 金額2 { get; set; }
        public string? 樣品別 { get; set; }
        public string? 描述 { get; set; }
        public string? ORDNO { get; set; }
        public string? 倉庫別 { get; set; }
    }
}
