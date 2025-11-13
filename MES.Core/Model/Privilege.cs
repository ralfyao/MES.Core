using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MES.Core.Model
{
    public class Privilege
    {
        public string PrivilegeName { get; set; }
        public string PrivilegeDesc { get; set; }
        [Key]
        public int ID {  get; set; }
        public string CreateUser { get; set; }
        public DateTime CreateDate { get; set; }
        [Computed]
        public List<PrivilegeMenu> privilegeMenus { get; set; }
    }
}
