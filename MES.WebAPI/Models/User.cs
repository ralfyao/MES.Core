using MES.Core.Model;

namespace MES.WebAPI.Models
{
    public class User
    {
        public string name { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public bool? isActivate { get; set; }
        public bool? isEmail { get; set; }
        public string? position { get; set; }
        public string? empNo { get; set; }
        public string lastModifier { get; set; }

        public Authenticate ToAuthenticate()
        {
            Authenticate authenticate = new Authenticate();
            authenticate.Account = username;
            authenticate.Password = password;
            authenticate.AccountName = name;
            authenticate.IsActivate = isActivate;
            authenticate.IsEmail = isEmail;
            authenticate.LastModifier = lastModifier;
            authenticate.職務 = position;
            authenticate.員工編號 = empNo;
            return authenticate;
        }
    }
}
