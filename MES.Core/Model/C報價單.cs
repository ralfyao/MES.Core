using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace MES.Core.Model
{
    public class C報價單
    {
        public string? IDNO { get; set; }      
        public string? QUONO             { get; set; }
        public string? MTYPE             { get; set; }
        public string? MMODEL            { get; set; }
        public string? CURRENCY          { get; set; }
        public decimal AMOUNT            { get; set; }
        public string? COMMISSION        { get; set; }
        public string? STATUS            { get; set; }
        public string? MACHINENO         { get; set; }
        public string? RFQNO             { get; set; }
        public string? CONDATE           { get; set; }
        public string? SHIPDATE          { get; set; }
        public string? QUODATE           { get; set; }
        public string? RANKING           { get; set; }
        public string? ADDRESS           { get; set; }
        public string? DADDRESS          { get; set; }
        public string? 價格條件          { get; set; }
        public string? 交貨方式          { get; set; }
        public string? 付款方式          { get; set; }
        public string? Remark            { get; set; }
        public string? 交貨日期          { get; set; }
        public double 稅率              { get; set; }
        public string? 建檔              { get; set; }
        public string? 修改              { get; set; }
        public string? 核准              { get; set; }
        public string? 建檔日            { get; set; }
        public string? 修改日            { get; set; }
        public string? 核准日 { get; set; }
        public List<C報價明細> quotationDetailFormList { get; set; }
    }
}
