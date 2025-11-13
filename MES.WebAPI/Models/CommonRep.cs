namespace MES.WebAPI.Models
{
    public class CommonRep<T>
    {
        public string WorkStatus { get; set; } = "OK";
        public string ErrorMessage { get; set; } = "";
        public T result { get; set; } 
        public List<T> resultList { get; set; } = new List<T>();
        public Dictionary<string, T> resultDictionary { get; set; } = new Dictionary<string, T>();
        public CommonRep() { }
        public CommonRep(HttpRequestMessage requestMessage) { }
    }
}
