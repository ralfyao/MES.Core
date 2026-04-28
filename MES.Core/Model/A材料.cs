using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MES.Core.Model
{
    public class A材料
    {
        [Key]
        public string? 產品編號 { get; set; }
        public string? 品別 { get; set; }
        public string? 大分類 { get; set; }
        public string? 小分類 { get; set; }
        public string? 產品代號 { get; set; }
        public string? 品名規格 { get; set; }
        public string? 英文品名 { get; set; }
        public decimal? 外尺寸長 { get; set; }
        public decimal? 外尺寸寬 { get; set; }
        public decimal? 厚度 { get; set; }
        public decimal? 內徑 { get; set; }
        public decimal? 外徑 { get; set; }
        public string? 庫存單位 { get; set; }
        public string? 採購單位 { get; set; }
        public decimal? 採購換算倍數 { get; set; }
        public string? 銷售單位 { get; set; }
        public decimal? 銷售換算倍數 { get; set; }
        public bool? 停用 { get; set; }
        public string? 建檔 { get; set; }
        public string? 建檔日 { get; set; }
        public string? 修改 { get; set; }
        public string? 修改日 { get; set; }
        public string? 核准 { get; set; }
        public bool? 勾選 { get; set; }
        public string? 來源屬性 { get; set; }
    }
}
