using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MES.Core.Model
{
    public class 會計傳票查詢清單
    {
        public string? 單號 { get; set; }
        public string? 日期 { get; set; }
        public string? 狀態 { get; set; }
        public string? 登錄人員 { get; set; }
        public string? 過帳 { get; set; }
        public string? 過帳日 { get; set; }
        public string? 會科代碼 { get; set; }
    }
}
