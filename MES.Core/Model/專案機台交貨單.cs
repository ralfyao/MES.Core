using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MES.Core.Model
{
    public class 專案機台交貨單
    {
        [Key] 
        public int? 識別碼 { get; set; }
        public string? 單號 { get; set; }
        public string? 日期 { get; set; }
        public string? 專案序號 { get; set; }
        public string? 單據地址 { get; set; }
        public string? 交貨地址 { get; set; }
        public string? 聯絡人 { get; set; }
        public string? 電話 { get; set; }
        public string? 訂購單號 { get; set; }
        public string? 發票單號 { get; set; }
        public string? Container { get; set; }
        public string? ContainerType { get; set; }
        public string? ContainerPort { get; set; }
        public string? DeliveryTeam { get; set; }
        public string? Insurance { get; set; }
        public string? DestinationPort { get; set; }
        public string? Packing { get; set; }
        public string? ETD { get; set; }
        public string? ETA { get; set; }
        public string? Arrival { get; set; }
        public string? CustomsClose { get; set; }
        public string? TypesOfBL { get; set; }
        public string? Forwarder { get; set; }
        public string? CertOfOrigin { get; set; }
        public string? SurrenderBL { get; set; }
        public string? CaseNo { get; set; }
        public string? Total { get; set; }
        public string? 建檔 { get; set; }
        public string? 修改 { get; set; }
        public string? 核准 { get; set; }
        public string? 建檔日 { get; set; }
        public string? 修改日 { get; set; }
        public string? 核准日 { get; set; }
        public string? Doc { get; set; }
        public string? Trade { get; set; }
        public string? Mark { get; set; }
        public string? Ship { get; set; }
        public string? Voyage { get; set; }
    }
}
