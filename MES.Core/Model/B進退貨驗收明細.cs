using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MES.Core.Model
{
    public class B進退貨驗收明細
    {
        [Key]
        public int 識別碼 { get; set; }
        public string 單號 { get; set; }
        public string 廠商編號 { get; set; }
        public string 品項編號 { get; set; }
        public string 品名規格 { get; set; }
        public string 批號 { get; set; }
        public float 收貨數量 { get; set; }
        public float 合格數量 { get; set; }
        public float 特採數量 { get; set; }
        public float 退回數量 { get; set; }
        public float 實際單價 { get; set; }
        public float 折讓金額 { get; set; }
        public float 付款金額 { get; set; }
        public bool 樣品 { get; set; }
        public string 採購單號 { get; set; }
        public string 退貨單號 { get; set; }
        public string 包裝單號 { get; set; }
        public bool 勾選 { get; set; }
    }
}
