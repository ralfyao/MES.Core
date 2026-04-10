using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MES.Core.Model
{
    public class B採購明細
    {
        public int 識別 { get; set; }
        public string 單號 { get; set; }
        public string 品項編號 { get; set; }
        public string 品名規格 { get; set; }
        public double 數量 {get; set;}
        public double 單價 { get; set; }
        public double 原幣未稅 { get; set; }
        public double 未稅金額 { get; set; }
        public double 稅額 { get; set; }
        public double 採購金額 { get; set; }
        public string 交貨日期 { get; set; }
        public string 樣品 { get; set; }
        public string 備註 { get; set; }
        public string 請購序號 { get; set; }
        public string 專案序號 { get; set; }
        public double 收貨數量 { get; set; }
        public double 合格數量 { get; set; }
        public double 特採數量 { get; set; }
        public double 退回數量 { get; set; }
        public double 實際單價 { get; set; }
        public double 折讓金額 { get; set; }
        public double 付款金額 { get; set; }
        public bool 結案 { get; set; }
        public string 代工類別 { get; set; }
        public string 正公差 { get; set; }
        public string 勾選 { get; set; }
        public int 採購識別碼 { get; set; }
    }
}
