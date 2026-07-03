using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MES.Core.Model
{
    public class A材料品項代號
    {
        [Key]
        public string 產品代號 { get; set; }
        public string 大分類 { get; set; }
        public string 小分類 { get; set; }
        public string 小分類名稱 { get; set; }
        public string 密度 { get; set; }
        public string 公式 { get; set; }
        public string 公式代號 { get; set; }
        public decimal 單價 { get; set; }
    }
}
