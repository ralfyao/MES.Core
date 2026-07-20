using MES.Core.Model;

namespace MES.WebAPI.Models
{
    public class SaveModuleMaterialReq
    {
        public 專案模組用料清單 header { get; set; }
        public List<專案模組BOM明細> details { get; set; }
        public string operatorName { get; set; }
    }
}
