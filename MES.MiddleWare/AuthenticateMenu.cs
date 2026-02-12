using MES.Core;
using MES.Core.Model;
using MES.Core.Repository;
using MES.Core.Repository.Impl;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http.Json;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace MES.MiddleWare
{
    public class AuthenticateMenu
    {
        /// <summary>
        /// 從帳號取得Menu清單
        /// </summary>
        /// <param name="account"></param>
        /// <returns></returns>
        public List<Menu> GetMenuByAccount(string account)
        {
            List<Menu> menuList = new List<Menu>();
            try
            {
                string strSQL = $@"SELECT DISTINCT d.MenuID, e.MenuName, e.MenuIcon, e.MenuUrl
                                      FROM dbo.Authenticate AS A
                                      LEFT OUTER JOIN AuthenticatePrivilege b ON a.Privilege=b.AuthenticatePrivilegeName
                                      LEFT OUTER JOIN Privilege c ON b.PrivilegeNameMapped=c.PrivilegeName
                                      LEFT OUTER JOIN PrivilegeMenu d ON c.PrivilegeName=d.PrivilegeName
                                      LEFT OUTER JOIN dbo.Menu AS e ON d.MenuID=e.MenuID
                                      LEFT OUTER JOIN dbo.MenuSub AS f ON e.MenuID=f.MenuID
                                     WHERE 1=1";
                if (!string.IsNullOrEmpty(account))
                {
                    strSQL += $" AND A.Account='{account}'";
                }
                strSQL += " ORDER BY d.MenuID ";
                DataSet ds = Utility.getDataSet(IRepository<PrivilegeMenu>.ConnStr, strSQL);
                foreach(DataRow row in ds.Tables[0].Rows)
                {
                    Menu menu = new Menu();
                    menu.MenuName = row["MenuName"].ToString();
                    menu.MenuID = row["MenuID"].ToString() == "" ? -1 : int.Parse(row["MenuID"].ToString());
                    menu.MenuIcon = row["MenuIcon"].ToString();
                    menu.MenuUrl = row["MenuID"].ToString();
                    menu.menuSubList = new List<MenuSub>();
                    strSQL = $"SELECT DISTINCT MenuSubID, MenuSubUrl, MenuSubName FROM MenuSub WHERE MenuID='{menu.MenuID}'";
                    DataSet ds2 = Utility.getDataSet(IRepository<PrivilegeMenu>.ConnStr, strSQL);
                    foreach (DataRow row2 in ds2.Tables[0].Rows)
                    {
                        MenuSub menuSub = new MenuSub();
                        menuSub.MenuSubID = row2["MenuSubID"].ToString() == "" ? -1 : int.Parse(row2["MenuSubID"].ToString());
                        menuSub.MenuSubName = row2["MenuSubName"].ToString();
                        menuSub.MenuSubUrl = row2["MenuSubUrl"].ToString();
                        menu.menuSubList.Add(menuSub);
                    }
                    menuList.Add(menu);
                }

                menuList = menuList.OrderBy(x => x.MenuID).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return menuList;
        }
        /// <summary>
        /// 取得預設所有的清單資料
        /// </summary>
        /// <returns></returns>
        public List<Menu> GetAllMenuList()
        {
            List<Menu> menus = new List<Menu>();
            try
            {
                MenuRepository menuRepository = new MenuRepository();
                MenuSubRepository menuSubRepository = new MenuSubRepository();
                menus = menuRepository.GetList(new Menu());
                foreach(var menu in menus)
                {
                    MenuSub sub = new MenuSub();
                    sub.MenuID = menu.MenuID;
                    menu.menuSubList = menuSubRepository.GetListBy(sub, "MenuID", " DISTINCT MenuID, MenuSubID, MenuSubName ");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return menus;
        }
        public List<Menu> GetMenuByRole(string roleName)
        {
            List<Menu> menuList = new List<Menu>();
            PrivilegeRepository privilegeRepository = new PrivilegeRepository();
            PrivilegeMenuRepository privilegeMenuRepository = new PrivilegeMenuRepository();
            MenuRepository menuRepository = new MenuRepository();
            MenuSubRepository menuSubRepository = new MenuSubRepository();
            Privilege priv = privilegeRepository.GetListBy(new Privilege() { PrivilegeDesc = roleName }, "PrivilegeDesc").ToList().FirstOrDefault();
            try
            {
                if (priv != null)
                {
                    List<PrivilegeMenu> privilegeMenu = privilegeMenuRepository.GetListBy(new PrivilegeMenu() { PrivilegeName = priv.PrivilegeName }, "PrivilegeName");
                    List<int> privIdList = new List<int>();
                    foreach (var privMenu in privilegeMenu)
                    {
                        if (privIdList.Contains(privMenu.MenuID))
                            break;
                        privIdList.Add(privMenu.MenuID);
                        Menu menu = new Menu();
                        menu.MenuID = privMenu.MenuID;
                        menu = menuRepository.GetListBy(menu, "MenuID").ToList().FirstOrDefault();
                        if (menu != null)
                        {
                            MenuSub sub = new MenuSub();
                            sub.MenuID = menu.MenuID;
                            List<MenuSub> subMeuList = menuSubRepository.GetListBy(sub, "MenuID");
                            menu.menuSubList = subMeuList;
                        }
                        menuList.Add(menu);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return menuList;
        }
    }
}
