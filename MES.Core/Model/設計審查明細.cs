using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MES.Core.Model
{
    public class 設計審查明細
    {
        [Key]
        public int 識別碼 { get; set; }
        public string 清單編號 { get; set; }
        public string 審查項目 { get; set; }
        public string 初審意見 { get; set; }
        public string 複審一意見 { get; set; }
        public string 複審二意見 { get; set; }
        public bool 符合 { get; set; }
    }
}
