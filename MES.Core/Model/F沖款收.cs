using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MES.Core.Model
{
    public class F沖款收
    {
        [Key]
        public string? 識別碼 { get; set; }
        public string? 日期 { get; set; }
        public string? 單號 { get; set; }
        public string? 客戶編號 { get; set; }
        public string? 幣別 { get; set; }
        public decimal? 匯率 { get; set; }
        public string? 請款人員 { get; set; }
        public string? MACHINENO { get; set; }
        public string? 備註 { get; set; }
        public string? 建檔 { get; set; }
        public string? 建檔日 { get; set; }
        public string? 修改 { get; set; }
        public string? 修改日 { get; set; }
        public string? 核准 { get; set; }
        public string? 核准日 { get; set; }
        public string? 傳票 { get; set; }
        public decimal? 收現金額 { get; set; }
        public decimal? 銀轉金額 { get; set; }
        public decimal? 匯費 { get; set; }
        public string? 銀存編碼 { get; set; }
        public decimal? 收票金額 { get; set; }
        public string? 票據號碼 { get; set; }
        public decimal? 收款總額 { get; set; }
        public List<F收支沖帳明細> writeOffDetailList { get; set; }
        public decimal 原幣加總()
        {
            decimal dec原幣加總 = 0;
            foreach(var item in writeOffDetailList)
            {
                dec原幣加總 += (decimal)(item.原幣沖帳金額 ?? 0);
            }
            return dec原幣加總;
        }
        public decimal 台幣加總()
        {
            decimal dec台幣加總 = 0;
            foreach (var item in writeOffDetailList)
            {
                dec台幣加總 += (decimal)(item.台幣沖帳金額 ?? 0);
            }
            return dec台幣加總;
        }
        public decimal 折讓加總()
        {
            decimal dec折讓加總 = 0;
            foreach (var item in writeOffDetailList)
            {
                dec折讓加總 += (decimal)(item.折讓金額 ?? 0);
            }
            return dec折讓加總;
        }
        public decimal 匯差加總()
        {
            decimal dec匯差加總 = 0;
            foreach (var item in writeOffDetailList)
            {
                dec匯差加總 += (decimal)(item.匯差 ?? 0);
            }
            return dec匯差加總;
        }
    }
}
