using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MES.Core.Model
{
    public class B廠商供料
    {
        [Key]
        public string? 識別{ get; set; }
        public string? 廠商編號{ get; set; }
        public string? 詢價日期{ get; set; }
        public string? 品項編號{ get; set; }
        public string? 採購單位{ get; set; }
        public string? 最低採購量{ get; set; }
        public string? 最大採購量{ get; set; }
        public string? 單價{ get; set; }
        public string? 幣別{ get; set; }
        public string? 詢價人員{ get; set; }
        public string? 報價有效日期{ get; set; }
        public string? 廠商品號{ get; set; }
    }
}
