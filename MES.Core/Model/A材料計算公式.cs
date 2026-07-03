using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MES.Core.Model
{
    public class A材料計算公式
    {
        [Key]
        public string 公式代號 { get; set; }
        public string 公式說明 { get; set; }
    }
}
