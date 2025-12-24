using log4net;
using log4net.Config;
using MES.Core.Model;
using MES.Core.Repository.Impl;
using MES.MiddleWare;
using MES.WebAPI.MiddleWare;
using MES.WebAPI.Models;
using MES.WebAPI.Request;
using Microsoft.AspNetCore.Mvc;

namespace MES.WebAPI.Controllers
{
    public class MenuController : ControllerBase
    {
        private static ILog _logger = LogManager.GetLogger(typeof(MenuController));
        public MenuController()
        {
            XmlConfigurator.Configure(new FileInfo(AppDomain.CurrentDomain.BaseDirectory + @"\log4net.config"));
        }
        [HttpGet]
        [Route("api/GetMenu")]
        public CommonRep<Menu> GetMenu(string? account)
        {
            CommonRep<Menu> rep = new CommonRep<Menu>();
            try
            {
                AuthenticateMenu authenticateMenu = new AuthenticateMenu();
                List<Menu> menuList = new List<Menu>();
                if (account != null)
                {
                    menuList = authenticateMenu.GetMenuByAccount(account);
                }
                else
                {
                    menuList = authenticateMenu.GetMenuByAccount(null);
                }
                rep.resultList = menuList;
            }
            catch (Exception ex)
            {
                _logger.Error(ex+ex.StackTrace);
                rep.ErrorMessage = ex.Message;
                rep.WorkStatus = WorkStatus.Fail.ToString();
                //throw;
            }
            return rep;
        }
        [HttpGet]
        [Route("api/GetMenuList")]
        public CommonRep<Menu> GetMenuList()
        {
            List<Menu> menuList = new List<Menu>();
            CommonRep<Menu> rep = new CommonRep<Menu>();
            AuthenticateMenu authenticateMenu = new AuthenticateMenu();
            try
            {
                menuList = authenticateMenu.GetAllMenuList();
                rep.resultList = menuList;
            }
            catch (Exception ex)
            {
                _logger.Error(ex + ex.StackTrace);
                rep.ErrorMessage = ex.Message;
                rep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return rep;
        }
        [HttpGet]
        [Route("api/GetMenuByRole")]
        public CommonRep<Menu> GetMenuByRole(string roleName)
        {
            CommonRep<Menu> rep = new Models.CommonRep<Menu>();
            try
            {
                rep.resultList = new AuthenticateMenu().GetMenuByRole(roleName);
            }
            catch (Exception ex)
            {
                _logger.Error(ex + ex.StackTrace);
                rep.ErrorMessage = ex.Message;
                rep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return rep;
        }
        [HttpPost]
        [Route("api/UpdateRoleMenu")]
        public CommonRep<string> UpdateRoleMenu([FromBody]UserRoleRequest request)
        {
            CommonRep<string> rep = new CommonRep<string>();
            PrivilegeMiddle privilegeMiddle = new PrivilegeMiddle();
            try
            {
                rep.result = privilegeMiddle.UpdateRoleMenu(request);
            }
            catch (Exception ex)
            {
                _logger.Error(ex + ex.StackTrace);
                rep.ErrorMessage = ex.Message;
                rep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return rep;
        }
        [HttpDelete]
        [Route("api/DeleteRolePrivilege")]
        public CommonRep<string> DeleteRoleMenu(string roleName)
        {
            CommonRep<string> rep = new CommonRep<string>();
            PrivilegeMiddle privilegeMiddle = new PrivilegeMiddle();
            PrivilegeRepository privilegeRepository = new PrivilegeRepository();
            Privilege queryCondition = new Privilege();
            queryCondition.PrivilegeDesc = roleName;
            queryCondition.CreateDate = null;
            Privilege privilege = privilegeRepository.GetListBy(queryCondition, "PrivilegeDesc").FirstOrDefault();
            try
            {
                privilegeMiddle.deleteRoleMenu(privilege.PrivilegeName);
            }
            catch (Exception ex)
            {
                _logger.Error(ex + ex.StackTrace);
                rep.ErrorMessage = ex.Message;
                rep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return rep;
        }
    }
}
