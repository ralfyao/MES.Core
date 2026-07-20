using MES.Core.Model;

namespace MES.WebAPI.Models
{
    public class SaveDesignAuditReq
    {
        public 設計派案 header { get; set; }
        public List<設計審查明細> details { get; set; }
    }
}
