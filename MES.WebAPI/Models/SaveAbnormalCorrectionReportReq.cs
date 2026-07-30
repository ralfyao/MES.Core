using MES.Core.Model;

namespace MES.WebAPI.Models
{
    public class SaveAbnormalCorrectionReportReq
    {
        public 異常矯正措施報告 form { get; set; }
        public string operatorName { get; set; }
    }
}
