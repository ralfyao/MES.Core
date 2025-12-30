using System.ComponentModel.DataAnnotations;

namespace MES.Core.Model
{
    public class AuthenticatePrivilege
    {
        public AuthenticatePrivilege() { }
        [Key]
        public int ID { get; set; }
        public Guid AuthenticatePrivilegeName { get; set; }
        public Guid PrivilegeNameMapped { get; set; }
        public DateTime ModifyDate { get; set; }
        public string ModifyUser { get; set; }
    }
}