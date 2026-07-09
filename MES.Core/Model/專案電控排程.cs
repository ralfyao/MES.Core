using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MES.Core.Model
{
    public class 專案電控排程
    {
        [Key]
        public int 識別碼 { get; set; }
        public string 專案序號 { get; set; }
        public string 電控工序 { get; set; }
        public string 簡要描述 { get; set; }
        public string 程控人員 { get; set; }
        public string 開始作業日期 { get; set; }
        public string 預計完成日期 { get; set; }
        public string 實際完成日期 { get; set; }
    }
}
