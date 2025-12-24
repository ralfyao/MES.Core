using log4net;
using log4net.Config;
using MES.Core.Model;
using MES.Core.Repository.Impl;
using MES.WebAPI.MiddleWare;
using MES.WebAPI.Models;
using MES.WebAPI.Request;
using Microsoft.AspNetCore.Mvc;

namespace MES.WebAPI.Controllers
{
    [ApiController]
    public class PrivilegeController : ControllerBase
    {
        private ILog logger = LogManager.GetLogger(typeof(PrivilegeController));
        public PrivilegeController() 
        {
            XmlConfigurator.Configure(new FileInfo(AppDomain.CurrentDomain.BaseDirectory + @"\log4net.config"));
        }
        [Route("api/GetAllPrivilege"), HttpGet]
        public CommonRep<List<Privilege>> GetAlllPrivilege()
        {
            CommonRep<List<Privilege>> rep = new CommonRep<List<Privilege>>();
            try
            {
                PrivilegeRepository privilegeRepository = new PrivilegeRepository();
                rep.result = privilegeRepository.GetList(null);
            }
            catch (Exception ex)
            {
                rep.ErrorMessage = ex + ex.StackTrace;
                rep.WorkStatus = WorkStatus.Fail.ToString();
                logger.Error(rep.ErrorMessage);
            }
            return rep;
        }
        [Route("api/SaveRolePrivilege"), HttpPost]
        public CommonRep<string> SaveRole([FromBody]UserRoleRequest request)
        {
            CommonRep<string> commonRep = new CommonRep<string>();
            try
            {
                string idStr = Guid.NewGuid().ToString();
                PrivilegeMiddle privilegeMiddle = new PrivilegeMiddle();
                if (privilegeMiddle.checkRoleName(request.roleName))
                {
                    commonRep.ErrorMessage = $"{request.roleName}角色已經存在!";
                    commonRep.WorkStatus = WorkStatus.Fail.ToString();
                    return commonRep;
                }
                // create privilege
                Privilege createData = new Privilege();
                createData.PrivilegeName = idStr;
                createData.PrivilegeDesc = request.roleName;
                createData.CreateUser = request.account;
                createData.privilegeMenus = new List<PrivilegeMenu>();
                foreach(var menu in request.selectedMenu)
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
                privilegeMiddle.createPrivilege(createData);
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex + ex.StackTrace;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
                logger.Error(commonRep.ErrorMessage);
            }
            return commonRep;
        }
        //public IActionResult Index()
        //{
        //    return View();
        //}
    }
}
