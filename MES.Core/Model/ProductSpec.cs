using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MES.Core.Model
{
    public class ProductSpec
    {
        [Key]
        public int ID { get; set; }
        public string ProductGroupId { get; set; }
        public string ProductSpecId {  get; set; }
        public string ProductSpecName { get; set; }
        public string ProductSpecValue { get; set; }
        public double ProductSpecMaxValue { get; set; }
        public double ProductSpecMinValue { get; set; }
        public string CreateUser {  get; set; }
        public DateTime CreateDate {  get; set; }
        public string ModifyUser {  get; set; }
        public DateTime ModifyDate {  get; set; }
    }
}
