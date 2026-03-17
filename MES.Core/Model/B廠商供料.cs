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
        public int? 識別{ get; set; }
        public string? 廠商編號{ get; set; }
        public string? 廠商簡稱 { get; set; }
        public string? 詢價日期{ get; set; }
        public string? 品項編號{ get; set; }
        public string? 品名規格 { get; set; }
        public string? 採購單位{ get; set; }
        public int? 最低採購量{ get; set; }
        public int? 最大採購量{ get; set; }
        public int? 單價{ get; set; }
        public string? 幣別{ get; set; }
        public string? 詢價人員{ get; set; }
        public string? 報價有效日期{ get; set; }
        public string? 廠商品號{ get; set; }
        public bool showDatePopup { get; set; }
        public bool showEffDatePopup { get; set; }
        public List<B廠商設定>? supplierList { get; set; }
    }
}
