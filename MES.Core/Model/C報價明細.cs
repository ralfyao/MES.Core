using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MES.Core.Model
{
    public  class C報價明細
    {
        public int 識別碼       {get;set;}
        public string? QUONO        {get;set;}
        public string? RFQNO { get; set; }
        public string? CONDATE { get; set; }
        public string? 產品編號     {get;set;}
        public string? 品名規格     {get;set;}
        public decimal 數量         {get;set;}
        public string? 單位         {get;set;}
        public decimal? 單價         {get;set;}
        public decimal? 金額         {get;set;}
        public string? 描述 { get; set; }
    }
}
