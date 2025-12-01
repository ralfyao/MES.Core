using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MES.Core.Model
{
    public class Product
    {
        [Key]
        public string ID { get; set; }
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public int ProductVersion { get; set; }
        public string ProductDescription { get; set; }
        public string ProductGroupId { get; set; }
        public string  CreateUser { get; set; }
        public DateTime CreateDate { get; set; }
        public string ModifyUser { get; set; }
        public DateTime ModifyDate { get; set; }
    }
}
