using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MES.Core.Model
{
    public class 專案用料總覽
    {
        public string? BOM編號 { get; set; }
        public string? 專案序號 { get; set; }
        public string? 模組編碼 { get; set; }
        public string? 模組名稱 { get; set; }
        public string? 零件號碼 { get; set; }
        public string? 品名 { get; set; }
        public string? 描述 { get; set; }
        public short? 數量 { get; set; }
        public string? 用途 { get; set; }
    }
}
