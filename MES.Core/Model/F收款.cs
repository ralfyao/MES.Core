using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MES.Core.Model
{
    public class F收款
    {
        public F收款() { }
        public F收款(C訂單 form) 
        {
            this.日期 = form.日期;
            this.單號 = form.AR單號;
            this.客戶編號 = form.客戶編號;
            this.幣別 = form.幣別;
            this.匯率 = form.匯率;
            this.請款人員 = form.建檔;
            this.收款總額 = form.總額;
        }
        [Key]
        public int? 識別碼 { get; set; }
        public string? 日期 { get; set; }
        public string? 單號 { get; set; }
        public string? 客戶編號 { get; set; }
        public string? 幣別 { get; set; }
        public decimal? 匯率 { get; set; }
        public string? 請款人員 { get; set; }
        public string? 收款日期 { get; set; }
        public string? 類別 { get; set; }
        public decimal? 收現金額 { get; set; }
        public decimal? 銀轉金額 { get; set; }
        public decimal? 匯費 { get; set; }
        public string? 銀存編碼 { get; set; }
        public decimal? 收票金額 { get; set; }
        public string? 票據號碼 { get; set; }
        public decimal? 收款總額 { get; set; }
        public string? MACHINENO { get; set; }
        public string? 發票號碼 { get; set; }
        public string? 備註 { get; set; }
        public string? 建檔 { get; set; }
        public string? 建檔日 { get; set; }
        public string? 修改 { get; set; }
        public string? 修改日 { get; set; }
        public string? 核准 { get; set; }
        public string? 核准日 { get; set; }
        public string? 傳票 { get; set; }
        public bool? 結案 { get; set; }
        public List<F收款明細> arListDetail { get; set; }
    }
}
