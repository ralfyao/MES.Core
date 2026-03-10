using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MES.Core.Model
{
    public class 零件申請BRG
    {
        public int? 識別碼 { get; set; }
        public string 單號 { get; set; }
        public string 零件分類 { get; set; }
        public string 零件號碼 { get; set; }
        public string 品名 { get; set; }
        public string 描述 { get; set; }
        public string 附屬模組 { get; set; }
        public string 選項 { get; set; }
        public string 模組編碼 { get; set; }
        public string BOM表識別碼 { get; set; }
        public string BOM編號 { get; set; }
    }
}
