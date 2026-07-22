using MES.Core.Model;

namespace MES.WebAPI.Models
{
    public class SaveModuleMaterialHeaderBatchReq
    {
        public List<專案模組用料清單> list { get; set; }
        public string operatorName { get; set; }
    }
}
