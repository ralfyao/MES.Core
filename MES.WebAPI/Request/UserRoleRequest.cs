namespace MES.WebAPI.Request
{
    /// <summary>
    /// 使用者權限新增修改請求
    /// </summary>
    public class UserRoleRequest
    {
        public UserRoleRequest() { }
        public string account { get; set; }
        public string roleName { get; set; }
        public List<string> privList { get; set; }
        public List<UserMenu> selectedMenu { get; set; }
        public List<UserSubMenu> selectedSub { get; set; }
    }
    public class UserMenu
    {
        public UserMenu() { }
        public string menuID { get; set; }
    }
    public class UserSubMenu : UserMenu
    {
        public UserSubMenu() { }
        public string menuSubID { get; set; }
    }
}
