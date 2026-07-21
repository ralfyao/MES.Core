using MES.Core.Model;

namespace MES.WebAPI.Models
{
    public class SaveModuleCheckItemListReq
    {
        public string category { get; set; }
        public string duty { get; set; }
        public List<模組圖檢查項目> items { get; set; }
    }
}
