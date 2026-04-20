using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MES.Core.Model
{
    public class B請購需求
    {
        [Key]
        public int? 請購序號 { get; set; }
        public string? 日期 { get; set; }
        public string? 品項編號 { get; set; }
        public string? 品名規格 { get; set; }
        public string? 單位 { get; set; }
        public string? 請購類別 { get; set; }
        public string? 請購部門 { get; set; }
        public string? 請購人員 { get; set; }
        public float? 數量 { get; set; }
        public string? 需求日期 { get; set; }
        public bool? 緊急 { get; set; }
        public string? 用途 { get; set; }
        public string? 註記 { get; set; }
        public string? 指定供應廠商 { get; set; }
        public string? 廠商簡稱 { get; set; }
        public bool? 轉單 { get; set; }
        public bool? 結案 { get; set; }
        public string? 選擇廠商 { get; set; }
        public string? 採購單號 { get; set; }
    }
}
