namespace MES.WebAPI.Models
{
    public class UpdateFinishDateReq
    {
        public string bomNo { get; set; }
        public string finishDate { get; set; }
        public string operatorName { get; set; }
    }
}
