using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MES.Core.Model
{
    public class C客戶連絡人清單
    {
        [Key]
        public int 識別碼 {  get; set; }
        public string COMPANY { get; set; }
        public string? 姓名 { get; set; }
        public string? 職稱 { get; set; }
        public string? 電話 { get; set; }
        public string? 分機 { get; set; }
        public string? EMAIL { get; set; }
    }
}
