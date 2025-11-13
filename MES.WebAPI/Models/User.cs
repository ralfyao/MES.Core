using MES.Core.Model;

namespace MES.WebAPI.Models
{
    public class User
    {
        public string name { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string lastModifier { get; set; }

        public Authenticate ToAuthenticate()
        {
            Authenticate authenticate = new Authenticate();
            authenticate.Account = username;
            authenticate.Password = password;
            authenticate.AccountName = name;
            authenticate.LastModifier = lastModifier;
            return authenticate;
        }
    }
}
