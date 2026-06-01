using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MES.Core.Model
{
    public class account
    {
        [Key]
        public string? 帳號 { get; set; }
        public string? 密碼 { get; set; }
        public string? 姓名 { get; set; }
        public bool? 停用      { get; set; }
        public bool? 寄件允許 { get; set; }
        public string? 職能 { get; set; }
        public string? 工號 { get; set; }
    }
}
