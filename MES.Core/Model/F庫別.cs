using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MES.Core.Model
{
    public class F庫別
    {
        [Key]
        public int? 識別碼 { get; set; }
        public string? 倉儲代碼 {  get; set; }
        public string? 倉庫 { get; set; }
        public string? 儲位 { get; set; }
    }
}
