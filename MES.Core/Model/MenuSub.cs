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
        public string MenuSubUrl { get; set;}
        public string CreateUser { get; set; }
        public DateTime CreateDate { get; set; }
    }
}