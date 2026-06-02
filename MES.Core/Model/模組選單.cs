using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MES.Core.Model
{
    public class 模組選單
    {
        [Key]
        public Guid ID { get; set; }
        public string 模組名稱 { get; set; }
        public string 建立日期 { get; set; }
        public List<模組子選單> subModuleList { get; set; }
    }
}
