using MES.Core.Model;

namespace MES.WebAPI.Models
{
    public class User
    {
        public List<A使用者授權> privilegeList;

        public string? name { get; set; }
        public string? username { get; set; }
        public string? password { get; set; }
        public bool? isActivate { get; set; }
        public bool? isEmail { get; set; }
        public string? position { get; set; }
        public string? empNo { get; set; }
        public string lastModifier { get; set; }
        public bool is高管(Guid? guid)
        {
            bool result = false;
            var priv = (from c in privilegeList where c.授權子表單 == guid select c).ToList().FirstOrDefault();
            if (priv != null)
            {
                if (priv.高管??false)
                {
                    return true;
                }
            }
            return result;
        }
        public bool is核准(Guid? guid)
        {
            bool result = false;
            var priv = (from c in privilegeList where c.授權子表單 == guid select c).ToList().FirstOrDefault();
            if (priv != null)
            {
                if (priv.核准 ?? false)
                {
                    return true;
                }
            }
            return result;
        }
        public bool is報表(Guid? guid)
        {
            bool result = false;
            var priv = (from c in privilegeList where c.授權子表單 == guid select c).ToList().FirstOrDefault();
            if (priv != null)
            {
                if (priv.報表 ?? false)
                {
                    return true;
                }
            }
            return result;
        }
        public bool is編修(Guid? guid)
        {
            bool result = false;
            var priv = (from c in privilegeList where c.授權子表單 == guid select c).ToList().FirstOrDefault();
            if (priv != null)
            {
                if (priv.編修 ?? false)
                {
                    return true;
                }
            }
            return result;
        }
        public bool is輸出(Guid? guid)
        {
            bool result = false;
            var priv = (from c in privilegeList where c.授權子表單 == guid select c).ToList().FirstOrDefault();
            if (priv != null)
            {
                if (priv.輸出 ?? false)
                {
                    return true;
                }
            }
            return result;
        }
        public bool is查詢(Guid? guid)
        {
            bool result = false;
            var priv = (from c in privilegeList where c.授權子表單 == guid select c).ToList().FirstOrDefault();
            if (priv != null)
            {
                if (priv.查詢 ?? false)
                {
                    return true;
                }
            }
            return result;
        }

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

        public account ToAccount()
        {
            account a = new account();
            a.帳號 = username;
            a.姓名 = name;
            a.密碼 = password;
            a.停用 = isActivate;
            a.寄件允許 = isEmail;
            a.工號 = username;
            return a;
        }
    }
}
