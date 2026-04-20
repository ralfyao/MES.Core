using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MES.Core.Model
{
    public class A成本單位
    {
        [Key]
        public int? 識別碼 { get; set; }
        public string 職務 { get; set; }
        public int? 標準編制 { get; set; }
        public string 上一級單位 { get; set; }
        public string 上兩級單位 { get; set; }
        public float? 標準工時成本 { get; set; }
        public float? 實際工時成本 { get; set; }
        public string 操作功能 { get; set; }
    }
}
