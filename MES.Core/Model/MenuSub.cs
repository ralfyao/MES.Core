using System.ComponentModel.DataAnnotations;

namespace MES.Core.Model
{
    public class MenuSub
    {
        [Key]
        public int ID { get; set; }
        public int MenuID { get; set; }
        public int MenuSubID { get; set; } 
        public string MenuSubName { get; set; }
        public string MenuSubUrl { get; set; }
        public bool? 核准 { get; set; }
        public bool? 編修 { get; set; }
        public bool? 報表 { get; set; }
        public bool? 輸出 { get; set; }
        public bool? 註記 { get; set; }
        public string? 職務代理效期 { get; set; }
        public string? 機號 { get; set; }
        public string CreateUser { get; set; }
        public DateTime CreateDate { get; set; }
    }
}