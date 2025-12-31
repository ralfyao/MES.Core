using MES.Core.Model;

namespace MES.WebAPI.Models
{
    public class UpdateUserPrivilegesReq
    {
        public string user { get; set; }
        public string account { get; set; }
        public List<Privilege> privList { get; set; }
    }
}
