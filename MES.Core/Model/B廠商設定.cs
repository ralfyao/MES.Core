using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MES.Core.Model
{
    public class B廠商設定
    {
        [Key]
        public string? 廠商編號{ get; set; }
        public string? 廠商簡稱{ get; set; }
        public string? 廠商名稱{ get; set; }
        public string? 國別{ get; set; }
        public string? 公司地址{ get; set; }
        public string? 工廠地址{ get; set; }
        public string? 統一編號{ get; set; }
        public string? 聯絡人{ get; set; }
        public string? 職稱{ get; set; }
        public string? 手機{ get; set; }
        public string? 電話{ get; set; }
        public string? 傳真{ get; set; }
        public string? 電郵{ get; set; }
        public string? 所屬業別{ get; set; }
        public string? 管理分類{ get; set; }
        public string? 等級{ get; set; }
        public string? 備註{ get; set; }
        public string? R1{ get; set; }
        public string? R2{ get; set; }
        public string? R3{ get; set; }
        public bool? 停用{ get; set; }
        public string? 建檔{ get; set; }
        public string? 建檔日{ get; set; }
        public string? 修改{ get; set; }
        public string? 修改日{ get; set; }
        public string? 核准{ get; set; }
        public string? 核准日{ get; set; }
        public List<B廠商供料>? supplyList { get; set; }
        public List<B廠商聯絡名冊> contactList { get; set; }
    }
}
