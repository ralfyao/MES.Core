using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MES.Core.Model
{
    public class A材料分類
    {
        [Key]
        public int 識別碼 { get; set; }
        public string 大分類 { get; set; }
        public string 分類名稱 { get; set; }
    }
}
