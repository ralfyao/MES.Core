using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MES.Core.Model
{
    public class PrivilegeMenu
    {
        [Key]
        public int ID { get; set; }
        public string PrivilegeName { get; set; }
        public int MenuID { get; set; }
        public int MenuSubID { get; set; }
        public string CreateUser { get; set; }
        public DateTime CreateDate { get; set; }
        [Computed]
        public List<Menu> menuList { get; set; }

    }
}
