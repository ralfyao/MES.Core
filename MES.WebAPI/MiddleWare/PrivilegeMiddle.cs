
using MES.Core.Model;
using MES.Core.Repository.Impl;
using MES.WebAPI.Request;

namespace MES.WebAPI.MiddleWare
{
    public class PrivilegeMiddle
    {
        public bool checkRoleName(string roleName)
        {
            PrivilegeRepository privilegeRepository = new PrivilegeRepository();
            Privilege queryCondition = new Privilege();
            queryCondition.PrivilegeDesc = roleName;
            queryCondition.CreateDate = null;
            List<Privilege> privilege = privilegeRepository.GetListBy(queryCondition, "PrivilegeDesc");
            return privilege.Count() > 0;
        }

        public void createPrivilegeMenu(PrivilegeMenu menuAdd)
        {
            PrivilegeMenuRepository privilegeMenuRepository = new PrivilegeMenuRepository();
            privilegeMenuRepository.Insert(menuAdd);
        }

        public void createPrivilege(Privilege createData)
        {
            PrivilegeRepository privilegeRepository = new PrivilegeRepository();
            privilegeRepository.Insert(createData);
        }

        public string UpdateRoleMenu(UserRoleRequest request)
        {
            PrivilegeRepository privilegeRepository = new PrivilegeRepository();
            PrivilegeMenuRepository privilegeMenuRepository = new PrivilegeMenuRepository();
            PrivilegeMiddle privilegeMiddle = new PrivilegeMiddle();
            Privilege queryCondition = new Privilege();
            queryCondition.PrivilegeDesc = request.roleName;
            queryCondition.CreateDate = null;
            Privilege privilege = privilegeRepository.GetListBy(queryCondition, "PrivilegeDesc").FirstOrDefault();
            if (privilege != null)
            {
                string idStr = privilege.PrivilegeName;
                privilegeMiddle.deletePrivilegeMenu(idStr);
                foreach (var menu in request.selectedMenu)
                {
                    PrivilegeMenu menuAdd = new PrivilegeMenu();
                    menuAdd.PrivilegeName = idStr;
                    menuAdd.MenuID = int.Parse(menu.menuID);
                    menuAdd.CreateUser = request.account;
                    menuAdd.CreateDate = DateTime.Now;
                    privilegeMiddle.createPrivilegeMenu(menuAdd);
                }
                foreach (var menu in request.selectedSub)
                {
                    PrivilegeMenu menuAdd = new PrivilegeMenu();
                    //string[] menuArr = menu.ToString().Split(',');
                    menuAdd.PrivilegeName = idStr;
                    menuAdd.MenuID = int.Parse(menu.menuID);
                    menuAdd.MenuSubID = int.Parse(menu.menuSubID);
                    menuAdd.CreateUser = request.account;
                    menuAdd.CreateDate = DateTime.Now;
                    privilegeMiddle.createPrivilegeMenu(menuAdd);
                }
                return "OK";
            }
            else
            {
                return "使用者權限不存在!!";
            }
            return string.Empty;
        }

        public void deletePrivilegeMenu(string idStr)
        {
            PrivilegeMenuRepository privilegeMenuRepository = new PrivilegeMenuRepository();
            PrivilegeMenu privilegeMenu = new PrivilegeMenu();
            privilegeMenu.PrivilegeName = idStr;
            privilegeMenuRepository.DeleteBy(privilegeMenu, "PrivilegeName");
        }

        public string deleteRoleMenu(string idStr)
        {
            PrivilegeRepository privilegeRepository = new PrivilegeRepository();

            Privilege queryCondition = new Privilege();
            queryCondition.PrivilegeName = idStr;
            queryCondition.CreateDate = null;
            Privilege privilege = privilegeRepository.GetListBy(queryCondition, "PrivilegeName").FirstOrDefault();
            
            privilegeRepository.DeleteBy(privilege, "PrivilegeName");

            PrivilegeMenuRepository privilegeMenuRepository = new PrivilegeMenuRepository();
            PrivilegeMenu privilegeMenu = new PrivilegeMenu();
            privilegeMenu.PrivilegeName = idStr;
            privilegeMenuRepository.DeleteBy(privilegeMenu, "PrivilegeName");
            return "OK";
        }
    }
}
