namespace MES.MiddleWare
{
    public class ProductSpecReq
    {
        public ProductSpecReq() { }
        public string productSpecId { get; set; }
        public string productSpecName { get; set; }
        public string productSpecValue { get; set; }
        public double productSpecMaxValue { get; set; }
        public double productSpecMinValue { get; set; }
        public string createUser { get; set; }
        public string modifyUser { get; set; }

    }
}